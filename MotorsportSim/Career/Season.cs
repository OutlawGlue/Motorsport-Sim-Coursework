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

        public Season(int year, int raceCount)
        {
            this.year = year;
            this.currentRound = 0;
            this.schedule = new List<RaceWeekend>(); //add full selection of how many races later
            this.driverStandings = new List<DriverStanding>();

            SetUpSechdule(raceCount);
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int CurrentRound
        {
            get { return currentRound; }
            set { currentRound = value; }
        }

        public List<RaceWeekend> Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }

        public List<DriverStanding> DriverStandings
        {
            get { return driverStandings; }
            set {  driverStandings = value; }
        }

        private void SetUpSechdule(int raceCount)
        {
            for (int r = 0; r < raceCount; r++)
            {
                RaceWeekend tempRace = new RaceWeekend(r, false);
                schedule.Add(tempRace);
            }
        }

        public void UpdateSchedule(RaceWeekend race)
        {
            schedule[currentRound] = race; //fix index
        }
    }
}
