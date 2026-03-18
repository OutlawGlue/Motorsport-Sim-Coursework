namespace MotorsportSim.RaceSim.Management
{
    partial class RaceStrategy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceStrategy));
            this.Rbtn_hard = new System.Windows.Forms.RadioButton();
            this.iml_tyres = new System.Windows.Forms.ImageList(this.components);
            this.Rbtn_inter = new System.Windows.Forms.RadioButton();
            this.Rbtn_wet = new System.Windows.Forms.RadioButton();
            this.Rbtn_medium = new System.Windows.Forms.RadioButton();
            this.Rbtn_soft = new System.Windows.Forms.RadioButton();
            this.Pnl_tyres = new System.Windows.Forms.Panel();
            this.Btn_save = new System.Windows.Forms.Button();
            this.Lbl_car = new System.Windows.Forms.Label();
            this.Pnl_tyres.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rbtn_hard
            // 
            this.Rbtn_hard.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rbtn_hard.ImageIndex = 2;
            this.Rbtn_hard.ImageList = this.iml_tyres;
            this.Rbtn_hard.Location = new System.Drawing.Point(600, 25);
            this.Rbtn_hard.Name = "Rbtn_hard";
            this.Rbtn_hard.Size = new System.Drawing.Size(200, 200);
            this.Rbtn_hard.TabIndex = 4;
            this.Rbtn_hard.TabStop = true;
            this.Rbtn_hard.UseVisualStyleBackColor = true;
            // 
            // iml_tyres
            // 
            this.iml_tyres.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iml_tyres.ImageStream")));
            this.iml_tyres.TransparentColor = System.Drawing.Color.Transparent;
            this.iml_tyres.Images.SetKeyName(0, "soft.png");
            this.iml_tyres.Images.SetKeyName(1, "medium.png");
            this.iml_tyres.Images.SetKeyName(2, "hard.png");
            this.iml_tyres.Images.SetKeyName(3, "inter.png");
            this.iml_tyres.Images.SetKeyName(4, "wet.png");
            // 
            // Rbtn_inter
            // 
            this.Rbtn_inter.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rbtn_inter.ImageIndex = 3;
            this.Rbtn_inter.ImageList = this.iml_tyres;
            this.Rbtn_inter.Location = new System.Drawing.Point(850, 25);
            this.Rbtn_inter.Name = "Rbtn_inter";
            this.Rbtn_inter.Size = new System.Drawing.Size(200, 200);
            this.Rbtn_inter.TabIndex = 3;
            this.Rbtn_inter.TabStop = true;
            this.Rbtn_inter.UseVisualStyleBackColor = true;
            // 
            // Rbtn_wet
            // 
            this.Rbtn_wet.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rbtn_wet.ImageIndex = 4;
            this.Rbtn_wet.ImageList = this.iml_tyres;
            this.Rbtn_wet.Location = new System.Drawing.Point(1100, 25);
            this.Rbtn_wet.Name = "Rbtn_wet";
            this.Rbtn_wet.Size = new System.Drawing.Size(200, 200);
            this.Rbtn_wet.TabIndex = 2;
            this.Rbtn_wet.TabStop = true;
            this.Rbtn_wet.UseVisualStyleBackColor = true;
            // 
            // Rbtn_medium
            // 
            this.Rbtn_medium.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rbtn_medium.ImageIndex = 1;
            this.Rbtn_medium.ImageList = this.iml_tyres;
            this.Rbtn_medium.Location = new System.Drawing.Point(350, 25);
            this.Rbtn_medium.Name = "Rbtn_medium";
            this.Rbtn_medium.Size = new System.Drawing.Size(200, 200);
            this.Rbtn_medium.TabIndex = 1;
            this.Rbtn_medium.TabStop = true;
            this.Rbtn_medium.UseVisualStyleBackColor = true;
            // 
            // Rbtn_soft
            // 
            this.Rbtn_soft.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rbtn_soft.ImageIndex = 0;
            this.Rbtn_soft.ImageList = this.iml_tyres;
            this.Rbtn_soft.Location = new System.Drawing.Point(100, 25);
            this.Rbtn_soft.Name = "Rbtn_soft";
            this.Rbtn_soft.Size = new System.Drawing.Size(200, 200);
            this.Rbtn_soft.TabIndex = 0;
            this.Rbtn_soft.TabStop = true;
            this.Rbtn_soft.UseVisualStyleBackColor = true;
            // 
            // pnl_tyres
            // 
            this.Pnl_tyres.Controls.Add(this.Rbtn_soft);
            this.Pnl_tyres.Controls.Add(this.Rbtn_wet);
            this.Pnl_tyres.Controls.Add(this.Rbtn_inter);
            this.Pnl_tyres.Controls.Add(this.Rbtn_hard);
            this.Pnl_tyres.Controls.Add(this.Rbtn_medium);
            this.Pnl_tyres.Location = new System.Drawing.Point(0, 200);
            this.Pnl_tyres.Name = "pnl_tyres";
            this.Pnl_tyres.Size = new System.Drawing.Size(1400, 250);
            this.Pnl_tyres.TabIndex = 5;
            // 
            // Btn_save
            // 
            this.Btn_save.Location = new System.Drawing.Point(994, 606);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.Size = new System.Drawing.Size(75, 37);
            this.Btn_save.TabIndex = 6;
            this.Btn_save.Text = "Save";
            this.Btn_save.UseVisualStyleBackColor = true;
            this.Btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_car
            // 
            this.Lbl_car.AutoSize = true;
            this.Lbl_car.Location = new System.Drawing.Point(96, 94);
            this.Lbl_car.Name = "lbl_car";
            this.Lbl_car.Size = new System.Drawing.Size(38, 20);
            this.Lbl_car.TabIndex = 7;
            this.Lbl_car.Text = "Car ";
            // 
            // RaceStrategy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1378, 744);
            this.Controls.Add(this.Lbl_car);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.Pnl_tyres);
            this.Name = "RaceStrategy";
            this.Text = "Race Strategy";
            this.Pnl_tyres.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_tyres;
        private System.Windows.Forms.Button Btn_save;
        private System.Windows.Forms.RadioButton Rbtn_hard;
        private System.Windows.Forms.ImageList iml_tyres;
        private System.Windows.Forms.RadioButton Rbtn_inter;
        private System.Windows.Forms.RadioButton Rbtn_wet;
        private System.Windows.Forms.RadioButton Rbtn_medium;
        private System.Windows.Forms.RadioButton Rbtn_soft;
        private System.Windows.Forms.Label Lbl_car;
    }
}