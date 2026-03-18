using System;

namespace MotorsportSim.RaceSim
{
    public class Vector
    {
        //Attributes:
        private float x;

        private float y;

        public Vector(float givenX, float givenY)
        {
            x = givenX;
            y = givenY;
        }

        //Getters and setters:
        public float X
        {
            get { return x; }
        }

        public float Y
        {
            get { return y; }
        }

        //Different class :
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.X - b.X, a.Y - b.Y);
        }

        public static Vector operator *(Vector a, float scalar)
        {
            return new Vector(a.X * scalar, a.Y * scalar);
        }

        public float GetMagnitude()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }

        public Vector GetUnitVector()
        {
            float magnitude = GetMagnitude();
            if (magnitude == 0)
            {
                return new Vector(0, 0);
            }
            return new Vector(X / magnitude, Y / magnitude);
        }

        public float GetAngleTo(Vector target)
        {
            Vector distance = new Vector(target.X - this.X, target.Y - this.Y);
            Vector unitDistance = distance.GetUnitVector();
            float angle = (float)Math.Atan2(unitDistance.Y, unitDistance.X);
            Console.WriteLine("Angle to target: " + angle);
            return angle;
        }
    }
}