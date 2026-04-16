using MotorsportSim.Career;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MotorsportSim.General
{
    public class RaceWeekend
    {
        //Used only for career, will be converted into raceConfig.
        private int trackIndex;  //not order in schedule, but index in track list
        private string trackName;
        private bool isCompleted;
        private List<DriverResult> result;

        //For completed races, when loading in from text file.
        public RaceWeekend(int trackIndex, bool isCompleted, List<DriverResult> result = null)
        {
            this.trackIndex = trackIndex;
            this.isCompleted = isCompleted;

            if (isCompleted)
            {
                this.result = result;
            }

            string[] tracks = Directory.GetFiles("Tracks");
            trackName = Path.GetFileNameWithoutExtension(tracks[trackIndex]);
        }

        public int TrackIndex
        {
            get { return trackIndex; }
        }

        public string TrackName
        {
            get { return trackName; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
        }

        public List<DriverResult> Result
        {
            get { return result; }
        }
    }
}