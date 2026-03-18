using MotorsportSim.RaceSim.Management;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace MotorsportSim.RaceSim
{
    public class RaceBuilder
    {
        public RaceSim BuildRace(RaceConfig config)
        {
            Track track = config.Track;

            track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Change to load different tracks later

            //Get intitial direction from first two waypoints:
            Vector start = track.GetWaypoint(0);
            Vector next = track.GetWaypoint(1);
            Vector direction = (next - start).GetUnitVector();
            float gridSpacing = 15f; //Distance between cars on grid

            List<Car> cars = new List<Car>();
            int gridPos = 0;

            for (int team = 0; team < config.Teams.Count; team++)
            {
                for (int driver = 0; driver < config.Teams[team].Drivers.Count; driver++)
                {
                    Vector position = start + direction * (-gridPos * gridSpacing);

                    Car tempCar = new Car(
                    position,
                    config.Teams[team].Colour,
                    config.Teams[team].Drivers[driver].Number,
                    config.Teams[team].Drivers[driver].Name,
                    track);

                    new StrategyCall(tempCar, 'P', 'S'); //Default = start on soft tyres

                    cars.Add(tempCar);
                    gridPos++;
                }
            }

            return new RaceSim(track, cars, config);
        }
    }
}