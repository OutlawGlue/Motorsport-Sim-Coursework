namespace MotorsportSim.RaceSim
{
    partial class Race
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_laps = new System.Windows.Forms.Label();
            this.Pnl_sideBar = new System.Windows.Forms.Panel();
            this.Dgv_standings = new System.Windows.Forms.DataGridView();
            this.Pnl_driver1 = new System.Windows.Forms.Panel();
            this.Lbl_driver1name = new System.Windows.Forms.Label();
            this.Pnl_driver2 = new System.Windows.Forms.Panel();
            this.Lbl_driver2name = new System.Windows.Forms.Label();
            this.Pnl_timeControls = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Pnl_track = new System.Windows.Forms.Panel();
            this.Btn_pause = new System.Windows.Forms.Button();
            this.Lbl_raceTime = new System.Windows.Forms.Label();
            this.Pnl_sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).BeginInit();
            this.Pnl_driver1.SuspendLayout();
            this.Pnl_driver2.SuspendLayout();
            this.Pnl_timeControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_laps
            // 
            this.Lbl_laps.Location = new System.Drawing.Point(60, 15);
            this.Lbl_laps.Name = "Lbl_laps";
            this.Lbl_laps.Size = new System.Drawing.Size(80, 20);
            this.Lbl_laps.TabIndex = 0;
            this.Lbl_laps.Text = "Lap 0";
            this.Lbl_laps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pnl_sideBar
            // 
            this.Pnl_sideBar.Controls.Add(this.Dgv_standings);
            this.Pnl_sideBar.Controls.Add(this.Lbl_laps);
            this.Pnl_sideBar.Location = new System.Drawing.Point(20, 20);
            this.Pnl_sideBar.Name = "Pnl_sideBar";
            this.Pnl_sideBar.Size = new System.Drawing.Size(200, 1000);
            this.Pnl_sideBar.TabIndex = 1;
            // 
            // Dgv_standings
            // 
            this.Dgv_standings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_standings.Location = new System.Drawing.Point(0, 50);
            this.Dgv_standings.Name = "Dgv_standings";
            this.Dgv_standings.RowHeadersWidth = 62;
            this.Dgv_standings.RowTemplate.Height = 28;
            this.Dgv_standings.Size = new System.Drawing.Size(200, 900);
            this.Dgv_standings.TabIndex = 2;
            // 
            // Pnl_driver1
            // 
            this.Pnl_driver1.Controls.Add(this.Lbl_driver1name);
            this.Pnl_driver1.Location = new System.Drawing.Point(350, 870);
            this.Pnl_driver1.Name = "Pnl_driver1";
            this.Pnl_driver1.Size = new System.Drawing.Size(400, 150);
            this.Pnl_driver1.TabIndex = 2;
            // 
            // Lbl_driver1name
            // 
            this.Lbl_driver1name.AutoSize = true;
            this.Lbl_driver1name.Location = new System.Drawing.Point(0, 0);
            this.Lbl_driver1name.Name = "Lbl_driver1name";
            this.Lbl_driver1name.Size = new System.Drawing.Size(59, 20);
            this.Lbl_driver1name.TabIndex = 8;
            this.Lbl_driver1name.Text = "Driver1";
            // 
            // Pnl_driver2
            // 
            this.Pnl_driver2.Controls.Add(this.Lbl_driver2name);
            this.Pnl_driver2.Location = new System.Drawing.Point(1250, 870);
            this.Pnl_driver2.Name = "Pnl_driver2";
            this.Pnl_driver2.Size = new System.Drawing.Size(400, 150);
            this.Pnl_driver2.TabIndex = 3;
            // 
            // Lbl_driver2name
            // 
            this.Lbl_driver2name.AutoSize = true;
            this.Lbl_driver2name.Location = new System.Drawing.Point(0, 0);
            this.Lbl_driver2name.Name = "Lbl_driver2name";
            this.Lbl_driver2name.Size = new System.Drawing.Size(59, 20);
            this.Lbl_driver2name.TabIndex = 9;
            this.Lbl_driver2name.Text = "Driver2";
            // 
            // Pnl_timeControls
            // 
            this.Pnl_timeControls.Controls.Add(this.Lbl_raceTime);
            this.Pnl_timeControls.Controls.Add(this.Btn_pause);
            this.Pnl_timeControls.Location = new System.Drawing.Point(900, 920);
            this.Pnl_timeControls.Name = "Pnl_timeControls";
            this.Pnl_timeControls.Size = new System.Drawing.Size(200, 100);
            this.Pnl_timeControls.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 920);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pnl_track
            // 
            this.Pnl_track.BackgroundImage = global::MotorsportSim.Properties.Resources.Monaco;
            this.Pnl_track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pnl_track.Location = new System.Drawing.Point(250, 20);
            this.Pnl_track.Name = "Pnl_track";
            this.Pnl_track.Size = new System.Drawing.Size(1500, 800);
            this.Pnl_track.TabIndex = 6;
            // 
            // Btn_pause
            // 
            this.Btn_pause.BackgroundImage = global::MotorsportSim.Properties.Resources.pause;
            this.Btn_pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_pause.FlatAppearance.BorderSize = 0;
            this.Btn_pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pause.Location = new System.Drawing.Point(75, 50);
            this.Btn_pause.Name = "Btn_pause";
            this.Btn_pause.Size = new System.Drawing.Size(50, 50);
            this.Btn_pause.TabIndex = 4;
            this.Btn_pause.UseVisualStyleBackColor = false;
            this.Btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // Lbl_raceTime
            // 
            this.Lbl_raceTime.AutoSize = true;
            this.Lbl_raceTime.Location = new System.Drawing.Point(71, 3);
            this.Lbl_raceTime.Name = "Lbl_raceTime";
            this.Lbl_raceTime.Size = new System.Drawing.Size(49, 20);
            this.Lbl_raceTime.TabIndex = 8;
            this.Lbl_raceTime.Text = "00:00";
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1978, 1144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pnl_track);
            this.Controls.Add(this.Pnl_timeControls);
            this.Controls.Add(this.Pnl_driver2);
            this.Controls.Add(this.Pnl_driver1);
            this.Controls.Add(this.Pnl_sideBar);
            this.Name = "Race";
            this.Text = "Race";
            this.Pnl_sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_standings)).EndInit();
            this.Pnl_driver1.ResumeLayout(false);
            this.Pnl_driver1.PerformLayout();
            this.Pnl_driver2.ResumeLayout(false);
            this.Pnl_driver2.PerformLayout();
            this.Pnl_timeControls.ResumeLayout(false);
            this.Pnl_timeControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_laps;
        private System.Windows.Forms.Panel Pnl_sideBar;
        private System.Windows.Forms.DataGridView Dgv_standings;
        private System.Windows.Forms.Panel Pnl_driver1;
        private System.Windows.Forms.Panel Pnl_driver2;
        private System.Windows.Forms.Button Btn_pause;
        private System.Windows.Forms.Panel Pnl_timeControls;
        private System.Windows.Forms.Panel Pnl_track;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_driver1name;
        private System.Windows.Forms.Label Lbl_driver2name;
        private System.Windows.Forms.Label Lbl_raceTime;
    }
}