using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar; //What is this?

namespace Racing_Game_CW
{
    public partial class Race : Form
    {
        private Timer timer;
        private readonly List<Car> cars;
        private readonly List<Vector> waypoints;

        public Race()
        {
            InitializeComponent();
            MenuUI.Form(this); //Might have a raceUI class, or just all use MenuUi but different methods

            this.DoubleBuffered = true; //Reduces flickering

            Track track = new Track();
            waypoints = track.LoadWaypointsFromFile("Tracks/Monaco.txt"); //Change to load different tracks later

            cars = new List<Car>
            {
                new Car(new Vector(200, 420), Color.Red, 16, track),
                new Car(new Vector(210, 430), Color.Blue, 1, track)
            };

            timer = new Timer
            {
                Interval = 16 // roughly 6 FPS (160)
            };
            timer.Tick += (s, e) => { UpdateRace(); Invalidate(); }; //Add a condition to pause race
            timer.Start();
        }

        private void UpdateRace()
        {
            foreach (var car in cars)
            {
                car.Move();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            // Draw waypoints
            foreach (var waypoint in waypoints)
            {
                int size = 8;
                g.FillEllipse(Brushes.Green, waypoint.X - size / 2, waypoint.Y - size / 2, size, size);
            }
            // Draw cars
            foreach (var car in cars)
            {
                car.ShowCar(g);
            }
        }
    }
}