using MotorsportSim.General;
using MotorsportSim.QuickRace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MotorsportSim.RaceSim
{
    public partial class Race : Form
    {
        private Timer timer;
        private Timer leaderboardTimer;
        private readonly RaceSimulation sim;
        private const int WaypointSize = 8;

        public Race(RaceSettings settings)
        {
            //Might have a raceUI class, or just all use MenuUI but different methods
            InitializeComponent();
            MenuUI.Form(this);
            MenuUI.Panel(Pnl_sideBar);
            MenuUI.BodyLabel(Lbl_laps);
            MenuUI.DataGridView(Dgv_standings);

            //Setup data grid view:
            Dgv_standings.AutoGenerateColumns = false;
            Dgv_standings.Columns.Clear();
            Dgv_standings.Columns.Add("Position", "Pos");
            Dgv_standings.Columns.Add("DriverNumber", "No.");
            Dgv_standings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DoubleBuffered = true; //Reduces flickering

            sim = CreateSimulation(settings);
            SetupTimers();
        }

        private RaceSimulation CreateSimulation(RaceSettings settings)
        {
            //Load the track waypoints in:
            Track track = new Track();
            track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Change to load different tracks later

            //Load teams and drivers:
            ITeamLoader teamLoader = new TextFileTeamLoader("Teams.txt");
            List<Team> teams = teamLoader.LoadTeams();

            List<DriverEntry> selectedDrivers = teams
                .SelectMany(t => t.Drivers.Select(d => new DriverEntry(d, t)))
                .Take(settings.CarCount)
                .ToList();

            //Get intitial direction from first two waypoints:
            Vector start = track.GetWaypoint(0);
            Vector next = track.GetWaypoint(1);
            Vector direction = (next - start).GetUnitVector();
            float gridSpacing = 15f; //Distance between cars on grid

            List<Car> cars = new List<Car>();

            for (int d = 0; d < settings.CarCount; d++)
            {
                Vector position = start + direction * (-d * gridSpacing);

                cars.Add(new Car(
                    position,
                    selectedDrivers[d].Team.Colour,
                    selectedDrivers[d].Driver.Number,
                    track));
            }

            //Check lap change event for leader car:
            cars[0].LapChanged += (car, lap) => UpdateLap();

            return new RaceSimulation(track, cars, settings);
        }

        private void SetupTimers()
        {
            timer = new Timer { Interval = 16 }; // roughly 60 FPS (16)
            timer.Tick += TimerTick;
            timer.Start();

            leaderboardTimer = new Timer { Interval = 500 }; // Update leaderboard every 0.5 seconds
            leaderboardTimer.Tick += LeaderboardTimerTick;
            leaderboardTimer.Start();

            UpdateLap();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            sim.Update(timer.Interval);
            Invalidate(); //Add a condition to pause race
        }

        private void LeaderboardTimerTick(object sender, EventArgs e)
        {
            List<Car> sortedCars = sim.SortCarsOrder();
            Dgv_standings.Rows.Clear();
            for (int i = 0; i < sortedCars.Count; i++)
            {
                Dgv_standings.Rows.Add(i + 1, sortedCars[i].DriverNumber);
            }
        }

        private void UpdateLap()
        {
            Lbl_laps.Text = $"Lap {sim.Cars[0].LapNumber} / {sim.LapCount}";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // Draw waypoints
            foreach (Vector waypoint in sim.Waypoints)
            {
                g.FillEllipse(Brushes.Green, waypoint.X - WaypointSize / 2, waypoint.Y - WaypointSize / 2, WaypointSize, WaypointSize);
            }
            // Draw cars
            foreach (Car car in sim.Cars)
            {
                car.ShowCar(g);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timer?.Stop();
            timer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}