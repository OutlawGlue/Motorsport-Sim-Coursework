using MotorsportSim.RaceSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    internal class RaceResult
    {
        private string driverName;
        private string teamName;
        private int position;
        private bool finished;

        public RaceResult(string driverName, string teamName, int position, bool finished)
        {
            this.driverName = driverName;
            this.teamName = teamName;
            this.position = position;
            this.finished = finished;
        }
    }
}