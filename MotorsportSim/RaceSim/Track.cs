using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace MotorsportSim.RaceSim
{
    public class Track
    {
        private int index;
        private List<Vector> waypoints;

        public Track(int index)
        {
            this.index = index;
        }

        public int Index
        {
            get { return index; }
        }

        public List<Vector> Waypoints
        {
            get { return waypoints; }
            private set { waypoints = value; }
        }

        public Vector GetWaypoint(int index)
        {
            return waypoints[index];
        }

        public List<Vector> LoadWaypointsFromFile(string filePath)
        {
            List<Vector> loadedWaypoints = new List<Vector>();

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 &&
                    float.TryParse(parts[0], out float x) &&
                    float.TryParse(parts[1], out float y))
                {
                    loadedWaypoints.Add(new Vector(x, y));
                }
            }

            if (loadedWaypoints.Count == 0)
            {
                throw new Exception("No valid waypoints found in the file.");
            }

            waypoints = loadedWaypoints;
            return loadedWaypoints;
        }
    }
}