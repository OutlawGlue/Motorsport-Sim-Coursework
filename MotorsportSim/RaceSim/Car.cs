using System;
using System.Collections.Generic;
using System.Drawing;

namespace MotorsportSim.RaceSim
{
    public class Car
    {
        //Constant attributes:
        private readonly Track track;
        private readonly Color colour;
        private readonly int driverNumber;
        private readonly string driverName;
        private readonly float topSpeed = 70f;
        private readonly float acceleration = 10f;
        private readonly float deceleration = 20f;
        private bool isAI = true;

        //Dynamic attributes:
        private List<Vector> waypoints;

        private Vector position;

        private Vector velocity;
        private float cornerDist;
        private float speed = 0f;
        private float lapStartTime = 0f;
        private List<float> lapTimes = new List<float>();
        private float currentLap = 0f;
        private int lapNumber = 1;
        private int currentWaypointIndex = 1;
        private int nextWaypointIndex = 0;
        private bool reachedStartLine = true;
        private Tyre currentTyre;

        private Tyre nextTyre;
        private CarState state = CarState.Racing;

        private float pitTimer = 0f;
        private const float PIT_DURATION = 3f;

        private static Random rng = new Random();

        //Move variables used in multiple methods to here, rather than passing between methods

        //Event used to notify race when lap changes
        public event Action<Car, int> LapChanged;

        //Driving states:
        public enum CarState
        {
            Racing, Pitting, InPits, PitStop, LeavingPits
        }

        public Car(Vector startPosition, Color colour, int driverNumber, string driverName, Track track)
        {
            position = startPosition;
            this.colour = colour;
            this.driverNumber = driverNumber;
            this.driverName = driverName;
            this.track = track;

            velocity = new Vector(0, 0);
            waypoints = this.track.MainWaypoints;
        }

        //Getters and setters:
        public int DriverNumber
        {
            get { return driverNumber; }
        }

        public string DriverName
        {
            get { return driverName; }
        }

        public int LapNumber
        {
            get { return lapNumber; }
            set { lapNumber = value; }
        }

        public float LapStartTime
        {
            get { return lapStartTime; }
            set { lapStartTime = value; }
        }

        public List<float> LapTimes
        {
            get { return lapTimes; }
            set { lapTimes = value; }
        }

        public bool IsAI
        {
            set { isAI = value; }
        }

        public CarState State
        {
            get { return state; }
        }

        //Methods:
        public void Update(float raceTime, float deltaT, float simSpeed)
        {
            switch (state)
            {
                case CarState.Racing:
                    waypoints = track.MainWaypoints;

                    if (isAI) // however you track this
                    {
                        TryAIPit(3);
                    }

                    CheckPitEntry();
                    break;

                case CarState.Pitting:
                    //waypoints = track.PitWaypoints;
                    CheckPitEntry();
                    break;

                case CarState.InPits:
                    waypoints = track.PitWaypoints;
                    CheckForPitBox();  
                    break;

                case CarState.PitStop:
                    HandlePitStop(deltaT); 
                    return; // stop movement while stationary

                case CarState.LeavingPits:
                    waypoints = track.MainWaypoints;

                    if (Vector.Distance(position, track.PitExit) < 5f)
                    {
                        state = CarState.Racing;
                        currentWaypointIndex = 0;
                    }
                    break;
            }

            Move(raceTime, deltaT, simSpeed);
            currentLap += deltaT;
        }

        public void Move(float raceTime, float deltaT, float simSpeed)
        {
            if (waypoints == null || waypoints.Count == 0)
                return;

            if (currentWaypointIndex < 0 || currentWaypointIndex >= waypoints.Count)
                currentWaypointIndex = 0;

            Vector target = waypoints[currentWaypointIndex];
            Vector distance = target - position;
            cornerDist = distance.GetMagnitude();

            Vector unitDistance = distance.GetUnitVector();
            velocity = unitDistance * speed;

            //Check distance to corner, update waypoint if close enough. Remember max speed = 2f
            if (cornerDist < 3f)
            {
                currentWaypointIndex++;

                if (currentWaypointIndex >= waypoints.Count)
                {
                    currentWaypointIndex = 0;
                    reachedStartLine = false;
                }
            }

            //Recalculate values:
            nextWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;

            target = waypoints[currentWaypointIndex];
            distance = target - position;
            cornerDist = distance.GetMagnitude();

            //Update position
            position += velocity * deltaT;

            //Detect crossing start line:
            if (currentWaypointIndex == 1 && !reachedStartLine)
            {
                lapNumber++;
                reachedStartLine = true;

                float lapTime = raceTime - lapStartTime;
                lapTimes.Add(lapTime);

                lapStartTime = raceTime;
                currentLap = 0;

                LapChanged?.Invoke(this, lapNumber);
            }

            //Angle calculation
            Vector AB = waypoints[nextWaypointIndex] - target;
            Vector AC = position - target;

            float magAB = AB.GetMagnitude();
            float magAC = AC.GetMagnitude();

            float angle = 180f;

            //If statement reduces chance of division by zero, which results in weird angles
            if (magAB > 0.001f && magAC > 0.001f)
            {
                double dot = AC.X * AB.X + AC.Y * AB.Y;
                double radAngle = dot / (magAB * magAC);

                radAngle = Math.Max(-1.0, Math.Min(1.0, radAngle)); //Clamp value between -1 and 1 to avoid NaN error

                angle = (float)(Math.Acos(radAngle) * 180.0 / Math.PI);
            }

            //Logic to calculate whether to accelerate or decelerate:
            double cornerSeverity;
            double grip = 1.0 - currentTyre.Wear;
            float targetSpeed;
            float brakeDistance = 0;
            if (angle <= 160f) //Can be changed to tune behaviour
            {
                cornerSeverity = 1 - (angle / 180);
                float gripFactor = (float)(0.5 + 0.5 * grip);
                targetSpeed = (topSpeed / (float)(1 + cornerSeverity * 4)) * gripFactor; //final value is used to tune corner speed
                float effectiveDecel = deceleration * (float)(0.5 + 0.5 * grip);
                brakeDistance = (speed * speed - targetSpeed * targetSpeed) / (2 * effectiveDecel);
            }

            //Clamp brakeDistance:
            if (brakeDistance < 0)
            {
                brakeDistance = 0; //ie dont brake
            }

            if (cornerDist <= brakeDistance)
            {
                //If braking:
                speed -= deceleration * deltaT;
                currentTyre.Degrade(1 * Convert.ToInt16(simSpeed)); //SHOULD BE DELTAT TO MATCH. ???
            }
            else
            {
                //If accelerating:
                speed += acceleration * deltaT;
            }

            if (speed < 0)
            {
                speed = 0;
            }
            else if (speed > topSpeed)
            {
                speed = topSpeed;
            }
        }

        //Pitting logic:
        private void CheckPitEntry()
        {
            if (state == CarState.Pitting && Vector.Distance(position, track.PitEntry) < 5f)
            {
                waypoints = track.PitWaypoints;
                currentWaypointIndex = 0;
                state = CarState.InPits;

                EnterPits();
            }
        }

        public void RequestPit(Tyre nextTyre)
        {
            this.nextTyre = nextTyre;
            state = CarState.Pitting;
        }

        private void CheckForPitBox()
        {
            if (Vector.Distance(position, track.GetPitWayPoint(1)) < 5f)
            {
                speed = 0;
                state = CarState.PitStop;
            }
        }

        private void HandlePitStop(float deltaT)
        {
            pitTimer += deltaT;

            if (pitTimer >= PIT_DURATION)
            {
                ChangeTyre(nextTyre);
                pitTimer = 0;
                state = CarState.LeavingPits;
                lapNumber++;
            }
        }

        private void EnterPits()
        {
            waypoints = track.PitWaypoints;
            currentWaypointIndex = 0;
            state = CarState.InPits;
        }

        public float RaceProgress()
        {
            return (lapNumber * waypoints.Count) + currentWaypointIndex - (cornerDist / 100f);
        }

        public void ShowCar(Graphics g)
        {
            int size = 20;
            g.FillEllipse(new SolidBrush(colour), position.X - size / 2, position.Y - size / 2, size, size);
            g.DrawString(driverNumber.ToString(), SystemFonts.DefaultFont, Brushes.White, position.X - 5, position.Y - 8);
        }

        public void ChangeTyre(Tyre newTyre)
        {
            currentTyre = newTyre;
        }

        public string GetFormattedLapTime()
        {
            TimeSpan time = TimeSpan.FromSeconds(currentLap);
            return time.ToString(@"m\:ss");
        }

        public string GetFormattedTyreWear()
        {
            double wear = currentTyre.Wear;
            return wear.ToString("P0");
        }

        public void TryAIPit(int totalLaps)
        {
            if (state != CarState.Racing)
                return;

            // Don’t pit near race end
            if (lapNumber >= totalLaps - 1)
                return;

            double wear = currentTyre.Wear;

            // Simple threshold with randomness
            float threshold = 0.4f + (float)(rng.NextDouble() * 0.1 - 0.05);
            // ~0.35 to 0.45

            if (wear >= threshold)
            {
                RequestPit(new Tyre('M', 0.9, 0.02f * totalLaps, 0.0, 1.0));
            }
        }
    }
}