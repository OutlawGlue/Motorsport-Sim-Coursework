using System;
using System.Collections.Generic;
using System.Drawing;

namespace MotorsportSim.RaceSim
{
    public class Car
    {
        //Constant attributes:
        private readonly List<Vector> waypoints;

        private readonly Track track;
        private readonly Color colour;
        private readonly int driverNumber;
        private readonly string driverName;
        private readonly float topSpeed = 1.6f;
        private readonly float acceleration = 0.006f;
        private readonly float deceleration = 0.008f;

        //Dynamic attributes:
        private Vector position;

        private Vector velocity;
        private float cornerDist;
        private float speed = 0f;
        private float lapStartTime = 0f;
        private List<float> lapTimes;
        private int lapNumber = 1;
        private int currentWaypointIndex = 1;
        private int nextWaypointIndex = 0;
        private bool reachedStartLine = true;
        private Tyre currentTyre;

        //Move variables used in multiple methods to here, rather than passing between methods

        //Event used to notify race when lap changes
        public event Action<Car, int> LapChanged;

        public Car(Vector startPosition, Color colour, int driverNumber, string driverName, Track track)
        {
            position = startPosition;
            this.colour = colour;
            this.driverNumber = driverNumber;
            this.driverName = driverName;
            this.track = track;
            //this.currentTyre = startTyre;

            velocity = new Vector(0, 0);
            waypoints = this.track.Waypoints;
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

        //Methods:
        public void Update(float raceTime, float deltaT)
        {
            Move(); //Add to this method using time deltaT, for improved accuracy
        }

        public void Move()
        {
            Vector target = waypoints[currentWaypointIndex];
            Vector distance = target - position;
            cornerDist = distance.GetMagnitude();

            Vector unitDistance = distance.GetUnitVector();
            velocity = unitDistance * speed; //Currently speed is constant, but will be updated later

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
            position += velocity;

            // Detect crossing start line:
            if (currentWaypointIndex == 1 && !reachedStartLine)
            {
                lapNumber++;
                reachedStartLine = true;

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
                speed -= deceleration;
                currentTyre.Degrade(1);
            }
            else
            {
                //If accelerating:
                speed += acceleration;
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
    }
}