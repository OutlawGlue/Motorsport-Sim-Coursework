using System;
using System.Linq;
using MotorsportSim.RaceSim;
using System.Collections.Generic;

namespace MotorsportSim.Career
{
    public class CareerSave
    {
        private string careerName;
        private int currentRound;
        private List<RaceWeekend> schedule;
        private List<DriverStanding> driverStandings;
        private int lapCount; // constant across all tracks in career for time saving (set on career creation), easy future update
        private List<Team> teams;
        private int managedTeamIndex;

        //Use this constructor when creating a new save, not when loading an existing save
        public CareerSave(string careerName, int lapCount, List<Team> teams, int managedTeamIndex)
        {
            this.careerName = careerName;
            currentRound = 0;
            schedule = new List<RaceWeekend>(); //temp, allow user to choose in future
            driverStandings = new List<DriverStanding>();
            this.lapCount = lapCount;
            this.teams = teams;
            this.managedTeamIndex = managedTeamIndex;
        }

        //Validation should be done when career is set up, so no setters needed here
        public string CareerName
        {
            get { return careerName; }
            set { careerName = value; }
        }

        public int CurrentRound
        {
            get { return currentRound; }
            set { currentRound = value; }
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }

        public List<Team> Teams
        {
            get { return teams; }
            set { teams = value; }
        }

        public int ManagedTeamIndex

        {
            get { return managedTeamIndex; }
            set { managedTeamIndex = value; }
        }

        public List<RaceWeekend> Schedule
        {
            get { return schedule; }
        }

        public List<DriverStanding> DriverStandings
        {
            get { return driverStandings; }
            set { driverStandings = value; }
        }

        public void AddResult(RaceWeekend raceWeekend)
        {
            schedule.Add(raceWeekend);
            CalculateStandings(raceWeekend);
            //Add code to update driverstandings
        }

        public void InitialiseStandings()
        {
            if (DriverStandings != null && DriverStandings.Count > 0)
                return;

            foreach (Team team in Teams)
            {
                foreach (Driver driver in team.Drivers)
                {
                    DriverStandings.Add(
                        new DriverStanding(driver.Number, 0));
                }
            }
        }

        public void CalculateStandings(RaceWeekend raceWeekend)
        {
            int[] pointsTable = { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };

            foreach (DriverResult result in raceWeekend.Result)
            {
                int pos = result.Position;

                int points = pointsTable[pos - 1];

                DriverStanding standing = 
                    driverStandings.First(d => d.DriverNumber == result.DriverNumber);

                standing.Points += points;
            }
        }
    }
}