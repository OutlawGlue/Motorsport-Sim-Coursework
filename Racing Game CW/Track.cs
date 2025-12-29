using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Racing_Game_CW
{
    internal class Track
    {
        private List<Vector> waypoints;

        public List<Vector> Waypoints
        {
            get { return waypoints; }
            private set { waypoints = value; }
        }

        public List<Vector> LoadWaypointsFromFile(string filePath)
        {
            List<Vector> loadedWaypoints = new List<Vector>();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
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