using MotorsportSim.RaceSim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.General
{
    internal interface ITeamLoader
    {
        List<Team> LoadTeams();
    }
}