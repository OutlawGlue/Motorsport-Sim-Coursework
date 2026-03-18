using System;
using MotorsportSim.RaceSim;
using System.Collections.Generic;

namespace MotorsportSim.Career
{
    internal class CareerSave
    {
        private string careerName;
        private DateTime lastUpdated;
        private int currentRound;
        private List<RaceWeekend> schedule;
        private int lapCount; // constant across all tracks in career for time saving (set on career creation), easy future update
        private List<Team> teams;
        private int managedTeamIndex;

        //Use this constructor when creating a new save, not when loading an existing save
        public CareerSave(string careerName, DateTime lastUpdated, int lapCount, List<Team> teams, int managedTeamIndex)
        {
            this.careerName = careerName;
            this.lastUpdated = lastUpdated;
            currentRound = 0;
            schedule = new List<RaceWeekend>(); //temp, allow user to choose in future
            this.lapCount = lapCount;
            this.teams = teams; // TEMPORARY HARDCODED VALUE
            this.managedTeamIndex = managedTeamIndex;
        }

        //Validation should be done when career is set up, so no setters needed here
        public string CareerName
        {
            get { return careerName; }
            set { careerName = value; }
        }

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
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

        public Track NextTrack
        {
            get
            {
                TrackLoader trackLoader = new TrackLoader();
                Track next = trackLoader.LoadTrack(currentRound);
                return next;
            }
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
    }
}