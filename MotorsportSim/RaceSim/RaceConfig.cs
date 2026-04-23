using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    public class RaceConfig
    {
        private readonly Track track;
        private readonly int laps;
        private readonly int managedTeamIndex;
        private readonly List<Team> teams;

        public RaceConfig(Track track, int laps, int managedTeamIndex, List<Team> teams)
        {
            this.track = track;
            this.laps = laps;
            this.managedTeamIndex = managedTeamIndex;
            this.teams = teams;
        }

        public Track Track
        {
            get { return track; }
        }

        public int Laps
        {
            get { return laps; }
        }

        public int ManagedTeamIndex
        {
            get { return managedTeamIndex; }
        }

        public List<Team> Teams
        {
            get { return teams; }
        }

        public int CarCount
        {
            get { return teams.Count * 2; }
        }
    }
}