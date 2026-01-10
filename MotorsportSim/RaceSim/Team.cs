using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class Team
    {
        private string name;
        private Color colour;
        private List<Driver> drivers; //List? Array? If allowing reserve drivers - list

        public Team(string givenName, Color givenColour, List<Driver> givenDrivers)
        {
            name = givenName;
            colour = givenColour;
            drivers = givenDrivers;
        }

        //Add setters if validation isn't elsewhere

        public Color Colour
        {
            get { return colour; }
        }

        public List<Driver> Drivers
        {
            get { return drivers; }
        }
    }
}