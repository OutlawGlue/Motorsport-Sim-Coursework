using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    public class RaceWeekend
    {
        //Used only for career, will be converted into raceConfig.
        private int trackIndex; //not order in schedule, but index in track list
        private bool isCompleted;
        private List<DriverResult> result;

        //For completed races, when loading in from text file.
        public RaceWeekend(int trackIndex, bool isCompleted, List<DriverResult> result)
        {
            this.trackIndex = trackIndex;
            this.isCompleted = isCompleted;

            if (isCompleted)
            {
                this.result = result;
            }
            else
            {
                this.result = null;
            }
        }

        public int TrackIndex
        {
            get { return trackIndex; }
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