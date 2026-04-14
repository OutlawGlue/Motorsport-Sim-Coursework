using System;
using System.Linq;
using MotorsportSim.RaceSim;
using System.Collections.Generic;
using MotorsportSim.General;
using System.Windows.Forms;

namespace MotorsportSim.Career
{
    public class CareerSave
    {
        private string careerName;
        private List<Season> seasons;
        private int currentSeasonIndex;
        private int lapCount; // constant across all tracks in career for time saving (set on career creation), easy future update
        private List<Team> teams;
        private int managedTeamIndex;

        //Use this constructor when creating a new save, not when loading an existing save
        public CareerSave(string careerName, int lapCount, List<Team> teams, int managedTeamIndex, int raceCount = 3)
        {
            this.careerName = careerName;
            seasons = new List<Season>();
            currentSeasonIndex = 0; //load from text file later
            
            this.lapCount = lapCount;
            this.teams = teams;
            this.managedTeamIndex = managedTeamIndex;
        }

        //Validation should be done when career is set up, so no setters needed here

        //All constant data for file writing: (ie stored in save, not season)
        public string CareerName
        {
            get { return careerName; }
            set { careerName = value; }
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

        public List<Season> Seasons
        {
            get { return seasons; }
        }

        public void AddResult(RaceWeekend raceWeekend)
        {
            seasons[currentSeasonIndex].Schedule.Add(raceWeekend);
            CalculateStandings(raceWeekend);
            //Add code to update driverstandings
        }

        public void InitialiseStandings()
        {
            List<DriverStanding> tempDS = seasons[currentSeasonIndex].DriverStandings;

            if (tempDS != null && tempDS.Count > 0)
                return;

            foreach (Team team in Teams)
            {
                foreach (Driver driver in team.Drivers)
                {
                    tempDS.Add(
                        new DriverStanding(driver.Number, 0));
                }
            }
        }

        public void CalculateStandings(RaceWeekend raceWeekend)
        {
            int[] pointsTable = { 25, 18, 15, 12, 10, 8, 6, 4, 2, 1 };

            Season currentSeason = seasons[currentSeasonIndex];

            foreach (DriverResult result in raceWeekend.Result)
            {
                int pos = result.Position;

                //Only award points for top 10:
                int points = (pos <= pointsTable.Length) ? pointsTable[pos - 1] : 0;

                DriverStanding tempStanding = currentSeason.DriverStandings
                    .FirstOrDefault(d => d.DriverNumber == result.DriverNumber);

                //If no driver:
                if (tempStanding == null)
                {
                    MsgBox.ShowError("Null Driver", "There was no driver standing found.");
                    continue;
                }

                tempStanding.Points += points;
            }
        }

        public void StartSeason()
        {
            //Prevent duplicate empty seasons issue:
            if (seasons.Count > 0 && seasons.Last().CurrentRound == 0)
                return;

            int nextYear = (seasons.Count > 0) ? seasons.Last().Year + 1 : 1;

            Season newSeason = new Season(nextYear);

            seasons.Add(newSeason);
            currentSeasonIndex = seasons.Count - 1;
        }

        public RaceWeekend GetSeasonResult(int year, int race)
        {
            try
            {
                return seasons[year].Schedule[race];
            }
            catch (Exception)
            {
                MsgBox.ShowError("Season Not Found", $"Season {year} not found.");
                return null;
            }
        }

        public int GetCurrentRound()
        {
            return seasons[currentSeasonIndex].CurrentRound;
        }

        public void NextRound()
        {
            seasons[currentSeasonIndex].CurrentRound++;
        }

        public List<DriverStanding> GetDriverStandings()
        {
            return seasons[currentSeasonIndex].DriverStandings;
        }
    }
}