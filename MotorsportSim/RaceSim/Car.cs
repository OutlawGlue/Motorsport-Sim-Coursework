using System;
using System.Collections.Generic;
using System.Drawing;

namespace MotorsportSim.RaceSim
{
    internal class Car
    {
        //Constant attributes:
        private readonly List<Vector> waypoints;

        private readonly Track track;
        private readonly Color colour;
        private readonly int driverNumber;
        private readonly float topSpeed = 2f;
        private readonly float acceleration = 0.008f;
        private readonly float deceleration = 0.010f;

        //Dynamic attributes:
        private Vector position;

        private Vector velocity;
        private float speed = 2f;
        private int lapNumber = 0;
        private int currentWaypointIndex = 1;
        private int nextWaypointIndex = 0;

        //Move variables used in multiple methods to here, rather than passing between methods

        public Car(Vector startPosition, Color givenColour, int givenDriverNumber, Track givenTrack)
        {
            position = startPosition;
            colour = givenColour;
            driverNumber = givenDriverNumber;
            track = givenTrack;

            velocity = new Vector(0, 0);
            waypoints = track.Waypoints;
        }

        //Unused getters and setters:
        public Vector Position
        {
            get { return position; }
        }

        public Vector Velocity
        {
            get { return velocity; }
        }

        public Color Colour
        {
            get { return colour; }
        }

        public int DriverNumber
        {
            get { return driverNumber; }
        }

        public int LapNumber
        {
            get { return lapNumber; }
            set { lapNumber = value; }
        }

        //Used getters and setters:
        public int CurrentWaypointIndex
        {
            get { return currentWaypointIndex; }
            set { currentWaypointIndex = value; }
        }

        public void Move()
        {
            Vector target = waypoints[currentWaypointIndex];
            Vector distance = target - position;
            float cornerDist = distance.GetMagnitude();

            Vector unitDistance = distance.GetUnitVector();
            velocity = unitDistance * speed; //Currently speed is constant, but will be updated later

            //Check distance to corner, update waypoint if close enough. Remember max speed = 2f
            if (cornerDist < 3f)
            {
                currentWaypointIndex++;

                if (currentWaypointIndex >= waypoints.Count)
                {
                    currentWaypointIndex = 0;
                    lapNumber++;
                }
            }

            //Recalculate values:
            nextWaypointIndex = (currentWaypointIndex + 1) % waypoints.Count;
            target = waypoints[currentWaypointIndex];
            distance = target - position;
            cornerDist = distance.GetMagnitude();

            //Update position
            position += velocity;

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
                double theta = dot / (magAB * magAC);

                theta = Math.Max(-1.0, Math.Min(1.0, theta)); //Clamp value between -1 and 1 to avoid NaN error

                angle = (float)(Math.Acos(theta) * 180.0 / Math.PI);
            }

            //Logic to calculate whether to accelerate or decelerate:
            double cornerSeverity;
            float targetSpeed;
            float brakeDistance = 0;
            if (angle <= 160f) //Can be changed to tune behaviour
            {
                cornerSeverity = 1 - (angle / 180);
                targetSpeed = topSpeed / (float)(1 + cornerSeverity * 4); //final value is used to tune corner speed
                brakeDistance = (speed * speed - targetSpeed * targetSpeed) / (2 * deceleration);
            }

            //Clamp brakeDistance:
            if (brakeDistance < 0)
            {
                brakeDistance = 0; //ie dont brake
            }

            //string accel = ""; //TEST CODE
            if (cornerDist <= brakeDistance)
            {
                speed -= deceleration;
                //accel = "Braking"; //TEST CODE
            }
            else
            {
                speed += acceleration;
                //accel = "Accelerating"; //TEST CODE
            }

            if (speed < 0)
            {
                speed = 0;
            }
            else if (speed > topSpeed)
            {
                speed = topSpeed;
            }

            //Console.WriteLine($"Speed: {speed}, Accel: {accel}, Angle: {angle}"); //TEST CODE
        }

        public void ShowCar(Graphics g)
        {
            int size = 20;
            g.FillEllipse(new SolidBrush(colour), position.X - size / 2, position.Y - size / 2, size, size);
            g.DrawString(driverNumber.ToString(), SystemFonts.DefaultFont, Brushes.White, position.X - 5, position.Y - 8);
        }
    }
}