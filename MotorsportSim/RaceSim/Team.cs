using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    public class Team
    {
        private string name;
        private Color colour;
        private List<Driver> drivers; //List? Array? If allowing reserve drivers - list

        public Team(string name, Color colour, List<Driver> drivers)
        {
            this.name = name;
            this.colour = colour;
            this.drivers = drivers;
        }

        //Add setters if validation isn't elsewhere
        public string Name
        {
            get { return name; }
        }

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