using MotorsportSim.Career;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class TrackLoader
    {
        public Track LoadTrack(int trackIndex)
        {
            //Load the track waypoints in:
            Track track = new Track(trackIndex);
            track.LoadWaypointsFromFile("Tracks/Monaco.txt");
            track.InitialisePit();
            //Later use index.

            return track;
        }

        public List<string> LoadAll()
        {
            List<string> tracks = new List<string>();
            string[] files = Directory.GetFiles("Tracks");
            foreach (string file in files)
            {
                tracks.Add(Path.GetFileNameWithoutExtension(file));
            }

            return tracks;
        }
    }
}