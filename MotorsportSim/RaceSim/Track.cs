using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Windows.Forms.VisualStyles;

namespace MotorsportSim.RaceSim
{
    public class Track
    {
        private int index;
        private string imagePath;

        private List<Vector> mainWaypoints;
        private List<Vector> pitWaypoints;
        Vector pitEntry;
        Vector pitExit;
        Vector pitBox;

        public Track(int index)
        {
            this.index = index;


            //pitWaypoints = new List<Vector>();

            ////Set waypoints
            //pitEntry = mainWaypoints[20 - 3]; //TEMP HARDCODE
            //pitExit = mainWaypoints[0];
            //Vector mean = (pitEntry + pitExit);
            //mean *= 0.5f;
            //pitBox = mean;

            ////Setup pitwaypoints:
            //pitWaypoints.Add(pitEntry);
            //pitWaypoints.Add(pitBox);
            //pitWaypoints.Add(pitExit);
        }

        public int Index
        {
            get { return index; }
        }

        public List<Vector> MainWaypoints
        {
            get { return mainWaypoints; }
            private set { mainWaypoints = value; }
        }

        public List<Vector> PitWaypoints
        {
            get { return pitWaypoints; }
        }

        public Vector PitEntry
        {
            get { return pitEntry; }
        }

        public Vector PitBox
        {
            get { return pitBox; }
        }

        public Vector PitExit
        {
            get { return pitExit; }
        }

        public Vector GetPitWayPoint(int index)
        {
            switch (index)
            {
                case 0: return pitEntry;
                case 1: return pitBox;
                case 2: return pitExit;
                default: return null;
            }
        }

        public string ImagePath
        {
            get { return FindImagePath(); }
        }

        public Vector GetWaypoint(int index)
        {
            return mainWaypoints[index];
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

            mainWaypoints = loadedWaypoints;
            return loadedWaypoints;
        }

        public string FindImagePath()
        {
            string[] tracks = Directory.GetFiles("TrackImages");
            return Path.GetFullPath(tracks[index]);
        }

        public void InitialisePit()
        {
            pitWaypoints = new List<Vector>();

            pitEntry = mainWaypoints[mainWaypoints.Count - 3];
            pitExit = mainWaypoints[0];

            Vector mean = (pitEntry + pitExit) * 0.5f;
            pitBox = mean;

            pitWaypoints.Add(pitEntry);
            pitWaypoints.Add(pitBox);
            pitWaypoints.Add(pitExit);
        }
    }
}