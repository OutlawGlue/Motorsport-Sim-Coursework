using MotorsportSim.General;
using MotorsportSim.QuickRace;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MotorsportSim.RaceSim
{
    public partial class Race : Form
    {
        private Timer timer;
        private readonly RaceSimulation sim;
        private const int WaypointSize = 8;

        public Race(RaceSettings settings)
        {
            InitializeComponent();
            MenuUI.Form(this); //Might have a raceUI class, or just all use MenuUi but different methods

            DoubleBuffered = true; //Reduces flickering

            sim = CreateSimulation(settings);
            SetupTimer();
        }

        private RaceSimulation CreateSimulation(RaceSettings settings)
        {
            Track track = new Track();
            track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Change to load different tracks later

            List<Car> cars = new List<Car>
            {
                new Car(new Vector(200, 420), Color.Red, 16, track),
                new Car(new Vector(210, 430), Color.Blue, 1, track)
            };

            return new RaceSimulation(track, cars, settings);
        }

        private void SetupTimer()
        {
            timer = new Timer { Interval = 16 }; // roughly 60 FPS (16)
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            sim.UpdateCars();
            Invalidate(); //Add a condition to pause race
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
            foreach (var waypoint in sim.Waypoints)
            {
                g.FillEllipse(Brushes.Green, waypoint.X - WaypointSize / 2, waypoint.Y - WaypointSize / 2, WaypointSize, WaypointSize);
            }
            // Draw cars
            foreach (var car in sim.Cars)
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