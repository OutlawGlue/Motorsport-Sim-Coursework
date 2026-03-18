using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.Career
{
    internal class BasicTeam
    {
        private string teamName;
        private int teamIndex;

        public BasicTeam(string teamName, int teamIndex)
        {
            this.teamName = teamName;
            this.teamIndex = teamIndex;
        }

        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
    }
}