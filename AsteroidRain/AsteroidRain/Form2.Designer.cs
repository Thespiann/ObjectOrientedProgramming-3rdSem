namespace AsteroidRain
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.introtxt1 = new System.Windows.Forms.Label();
            this.introtxt2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.spaceship = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.scoretxt = new System.Windows.Forms.Label();
            this.scorelbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // introtxt1
            // 
            this.introtxt1.AutoSize = true;
            this.introtxt1.BackColor = System.Drawing.Color.Transparent;
            this.introtxt1.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introtxt1.ForeColor = System.Drawing.Color.AliceBlue;
            this.introtxt1.Location = new System.Drawing.Point(30, 281);
            this.introtxt1.Name = "introtxt1";
            this.introtxt1.Size = new System.Drawing.Size(931, 29);
            this.introtxt1.TabIndex = 0;
            this.introtxt1.Text = "Commander! Asteroids incoming, we are counting on you!";
            // 
            // introtxt2
            // 
            this.introtxt2.AutoSize = true;
            this.introtxt2.BackColor = System.Drawing.Color.Transparent;
            this.introtxt2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.introtxt2.ForeColor = System.Drawing.Color.AliceBlue;
            this.introtxt2.Location = new System.Drawing.Point(198, 310);
            this.introtxt2.Name = "introtxt2";
            this.introtxt2.Size = new System.Drawing.Size(585, 20);
            this.introtxt2.TabIndex = 1;
            this.introtxt2.Text = "Press space to shoot and use the arrows to move.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 103;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // spaceship
            // 
            this.spaceship.BackColor = System.Drawing.Color.Transparent;
            this.spaceship.Image = ((System.Drawing.Image)(resources.GetObject("spaceship.Image")));
            this.spaceship.Location = new System.Drawing.Point(419, 462);
            this.spaceship.Name = "spaceship";
            this.spaceship.Size = new System.Drawing.Size(114, 207);
            this.spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spaceship.TabIndex = 2;
            this.spaceship.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 137;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // scoretxt
            // 
            this.scoretxt.AutoSize = true;
            this.scoretxt.BackColor = System.Drawing.Color.LightCyan;
            this.scoretxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoretxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scoretxt.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.scoretxt.Location = new System.Drawing.Point(784, 9);
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(98, 27);
            this.scoretxt.TabIndex = 3;
            this.scoretxt.Text = "Score:";
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.scorelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.scorelbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.scorelbl.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.ForeColor = System.Drawing.Color.LightCyan;
            this.scorelbl.Location = new System.Drawing.Point(888, 11);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(26, 25);
            this.scorelbl.TabIndex = 4;
            this.scorelbl.Text = "0";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.timer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timer.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.LightCyan;
            this.timer.Location = new System.Drawing.Point(215, 11);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(40, 25);
            this.timer.TabIndex = 6;
            this.timer.Text = "45";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.Color.LightCyan;
            this.timelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timelbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timelbl.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.timelbl.Location = new System.Drawing.Point(55, 9);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(154, 27);
            this.timelbl.TabIndex = 5;
            this.timelbl.Text = "Time Left:";
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 649);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.scorelbl);
            this.Controls.Add(this.scoretxt);
            this.Controls.Add(this.spaceship);
            this.Controls.Add(this.introtxt2);
            this.Controls.Add(this.introtxt1);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spaceship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introtxt1;
        private System.Windows.Forms.Label introtxt2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox spaceship;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label scoretxt;
        private System.Windows.Forms.Label scorelbl;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Timer timer5;
    }
}