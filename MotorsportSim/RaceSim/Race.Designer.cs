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
            this.SuspendLayout();
            // 
            // Lbl_laps
            // 
            this.Lbl_laps.AutoSize = true;
            this.Lbl_laps.Location = new System.Drawing.Point(0, 0);
            this.Lbl_laps.Name = "Lbl_laps";
            this.Lbl_laps.Size = new System.Drawing.Size(49, 20);
            this.Lbl_laps.TabIndex = 0;
            this.Lbl_laps.Text = "Lap 0";
            // 
            // Race
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Lbl_laps);
            this.Name = "Race";
            this.Text = "Race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_laps;
    }
}