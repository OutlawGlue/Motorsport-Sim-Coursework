using MotorsportSim.QuickRace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsportSim.RaceSim
{
    internal class RaceSimulation
    {
        private Track track;
        private List<Car> cars;
        private int lapCount;

        public RaceSimulation(Track track, List<Car> cars, RaceSettings settings)
        {
            Track = track;
            Cars = cars;
            LapCount = settings.LapCount;
        }

        public Track Track
        {
            set { track = value; }
        }

        public List<Vector> Waypoints
        {
            get { return track.Waypoints; }
        }

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }

        public void UpdateCars()
        {
            foreach (var car in cars)
            {
                car.Move();
            }
        }
    }
}