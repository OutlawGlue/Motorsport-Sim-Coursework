namespace MotorsportSim.Menus
{
    partial class NewGame
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
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Btn_career = new System.Windows.Forms.Button();
            this.Btn_quickRace = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Name = "Pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1380, 135);
            this.Pnl_top.TabIndex = 19;
            // 
            // Btn_career
            // 
            this.Btn_career.Location = new System.Drawing.Point(200, 200);
            this.Btn_career.Name = "Btn_career";
            this.Btn_career.Size = new System.Drawing.Size(400, 300);
            this.Btn_career.TabIndex = 20;
            this.Btn_career.Text = "Career";
            this.Btn_career.UseVisualStyleBackColor = true;
            this.Btn_career.Click += new System.EventHandler(this.Btn_career_Click);
            // 
            // Btn_quickRace
            // 
            this.Btn_quickRace.Location = new System.Drawing.Point(800, 200);
            this.Btn_quickRace.Name = "Btn_quickRace";
            this.Btn_quickRace.Size = new System.Drawing.Size(400, 300);
            this.Btn_quickRace.TabIndex = 21;
            this.Btn_quickRace.Text = "Quick Race";
            this.Btn_quickRace.UseVisualStyleBackColor = true;
            this.Btn_quickRace.Click += new System.EventHandler(this.Btn_quickRace_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(200, 550);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(400, 100);
            this.Btn_back.TabIndex = 22;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_quickRace);
            this.Controls.Add(this.Btn_career);
            this.Controls.Add(this.Pnl_top);
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Button Btn_career;
        private System.Windows.Forms.Button Btn_quickRace;
        private System.Windows.Forms.Button Btn_back;
    }
}