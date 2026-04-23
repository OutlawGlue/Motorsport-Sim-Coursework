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
        private TimeSpan raceTime = TimeSpan.Zero;
        private float speedFactor = 1.0f;

        private double waterLevel = 0.0;
        private int currentLap = 1;
        private bool isPaused = false;

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

            managedCars[0].IsAI = false;
            managedCars[1].IsAI = false;

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
            get { return track.MainWaypoints; }
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

        public int CurrentLap
        {
            get { return currentLap; }
        }

        public bool IsPaused
        {
            get { return isPaused; }
        }

        public void SetSpeed(float speed)
        {
            speedFactor = speed;
        }

        public string GetFormattedRaceTime()
        {
            return raceTime.ToString(@"mm\:ss");
        }

        public void Update(float deltaT)
        {
            if (isPaused) return;

            float scaledDeltaT = deltaT * speedFactor;

            raceTime += TimeSpan.FromSeconds(scaledDeltaT);

            foreach (Car car in cars)
            {
                car.Update((float)raceTime.TotalSeconds, scaledDeltaT, speedFactor);
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
            return cars.All(car => car.LapNumber > lapCount);
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

        public void Pause()
        {
            isPaused = true;
        }

        public void Resume()
        {
            isPaused = false;
        }
    }
}