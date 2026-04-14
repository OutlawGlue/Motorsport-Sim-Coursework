using MotorsportSim.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    public class Season
    {
        private int year = 0;
        private int currentRound;
        private List<RaceWeekend> schedule;
        private List<DriverStanding> driverStandings;

        public Season(int year)
        {
            this.year = year;
            this.currentRound = 0;
            this.schedule = new List<RaceWeekend>(); //add full selection of how many races later
            this.driverStandings = new List<DriverStanding>();
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int CurrentRound
        {
            get { return currentRound; }
            set {  currentRound = value; }
        }

        public List<RaceWeekend> Schedule
        {
            get { return schedule; }
            set {  schedule = value; }
        }

        public List<DriverStanding> DriverStandings
        {
            get { return driverStandings; }
            set {  driverStandings = value; }
        }
    }
}
