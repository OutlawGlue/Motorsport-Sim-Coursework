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
        private int carCount;
        private int lapCount;
        private float raceTime = 0;

        public RaceSimulation(Track givenTrack, List<Car> givenCars, RaceSettings settings)
        {
            track = givenTrack;
            cars = givenCars;
            carCount = settings.CarCount;
            lapCount = settings.LapCount;
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

        public int CarCount
        {
            get { return carCount; }
        }

        public int LapCount
        {
            get { return lapCount; }
            set { lapCount = value; }
        }

        public float RaceTime
        {
            get { return raceTime; }
        }

        public void Update(float deltaT)
        {
            raceTime += deltaT;

            foreach (Car car in cars)
            {
                car.Update(raceTime, deltaT);
            }
        }

        public List<Car> SortCarsOrder()
        {
            return cars
                .OrderByDescending(c => c.RaceProgress())
                .ToList();
        }
    }
}