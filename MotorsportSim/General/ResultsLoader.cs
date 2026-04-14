using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MotorsportSim.Career;

namespace MotorsportSim.General
{
    internal class ResultsLoader
    {
        public List<RaceWeekend> LoadResults(CareerSave save, int year) 
        {
            return save.GetSeasonResults(year);
        }
    }
}
