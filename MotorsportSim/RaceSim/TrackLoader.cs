using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MotorsportSim.RaceSim
{
    internal class TrackLoader
    {
        private int trackIndex;

        public Track LoadTrack(int trackIndex)
        {
            this.trackIndex = trackIndex;

            //Load the track waypoints in:
            Track track = new Track(trackIndex);
            track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Later use index.

            return track;
        }
    }
}