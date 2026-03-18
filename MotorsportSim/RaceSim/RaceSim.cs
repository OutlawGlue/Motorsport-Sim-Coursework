using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MotorsportSim.RaceSim
{
    public class RaceSim
    {
        private Track track;
        private List<Car> cars;
        private List<Car> managedCars;
        private int carCount;
        private int lapCount;
        private float raceTime = 0;
        private double waterLevel = 0.0;
        private int currentLap = 1;

        public event Action<int> LeaderLapChanged;

        public RaceSim(Track track, List<Car> cars, RaceConfig raceConfig)
        {
            this.track = track;
            this.cars = cars;
            int teamIndex = raceConfig.ManagedTeamIndex;
            this.managedCars = cars.Where(car => car.DriverNumber == raceConfig.Teams[teamIndex].Drivers[0].Number ||
                                car.DriverNumber == raceConfig.Teams[teamIndex].Drivers[1].Number).ToList();
            carCount = raceConfig.CarCount;
            lapCount = raceConfig.Laps;

            foreach (Car car in cars)
            {
                car.LapChanged += LapChanged;
            }
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

        public List<Car> ManagedCars
        {
            get { return managedCars; }
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

        public int CurrentLap
        {
            get { return currentLap; }
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
                .OrderByDescending(car => car.RaceProgress())
                .ToList();
        }

        public bool RaceFinished()
        {
            if (currentLap > lapCount && cars[carCount - 1].LapNumber > lapCount)
            {
                return true;
            }

            return false;
        }

        private void LapChanged(Car car, int lap)
        {
            Car leader = SortCarsOrder().First();

            if (leader.LapNumber != currentLap)
            {
                currentLap = leader.LapNumber;
                LeaderLapChanged?.Invoke(currentLap);
            }
        }
    }
}