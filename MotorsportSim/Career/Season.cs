using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    internal class Season
    {
        private int year = 0;
        private int currentRound;
        private List<RaceWeekend> schedule;
        private List<DriverStanding> driverStandings;

        public Season(int year)
        {
            this.year = year;
            this.currentRound = 0;
            this.schedule = new List<RaceWeekend>();
            this.driverStandings = new List<DriverStanding>();
        }
    }
}
