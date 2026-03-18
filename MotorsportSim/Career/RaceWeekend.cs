using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    internal class RaceWeekend
    {
        //Used only for career, will be converted into raceConfig.

        private int trackIndex; //not order in schedule, but index in track list
        private bool isCompleted;
        private List<RaceResult> result;

        //For completed races, when loading in from text file.
        public RaceWeekend(int trackIndex, bool isCompleted, List<RaceResult> results)
        {
            this.trackIndex = trackIndex;
            this.isCompleted = isCompleted;

            if (isCompleted)
            {
                this.result = results;
            }
            else
            {
                this.result = null;
            }
        }
    }
}