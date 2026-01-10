using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class DriverEntry
    {
        private Driver driver;
        private Team team;

        public DriverEntry(Driver givenDriver, Team givenTeam)
        {
            driver = givenDriver;
            team = givenTeam;
        }

        public Driver Driver
        {
            get { return driver; }
        }

        public Team Team
        {
            get { return team; }
        }
    }
}