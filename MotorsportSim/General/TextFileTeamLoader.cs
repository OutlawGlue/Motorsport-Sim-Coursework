using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MotorsportSim.RaceSim;
using System.Drawing;

namespace MotorsportSim.General
{
    internal class TextFileTeamLoader : ITeamLoader
    {
        private readonly string filePath;

        public TextFileTeamLoader(string givenFilepath)
        {
            filePath = givenFilepath;
        }

        public List<Team> LoadTeams()
        {
            List<Team> teams = new List<Team>();
            string[] lines = File.ReadAllLines(filePath);

            int i = 0;
            while (i < lines.Length)
            {
                //Skip empty lines
                if (string.IsNullOrWhiteSpace(lines[i]))
                {
                    i++;
                    continue;
                }

                //Team line:

                string[] tempTm = lines[i].Split(',');
                string teamName = tempTm[0];
                Color teamColour = Color.FromArgb(
                    int.Parse(tempTm[1]), int.Parse(tempTm[2]), int.Parse(tempTm[3]));
                i++;

                //Driver lines:

                List<Driver> drivers = new List<Driver>(); //List for this team
                while (i < lines.Length && !string.IsNullOrWhiteSpace(lines[i]))
                {
                    string[] tempDr = lines[i].Split(',');
                    drivers.Add(new Driver(tempDr[0], int.Parse(tempDr[1])));
                    i++;
                }

                teams.Add(new Team(teamName, teamColour, drivers));
            }

            return teams;
        }
    }
}