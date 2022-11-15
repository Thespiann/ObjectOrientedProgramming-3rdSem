namespace AsteroidRain
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.asteroid = new System.Windows.Forms.Label();
            this.rain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.BackColor = System.Drawing.Color.LightCyan;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.play.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(143)))));
            this.play.Location = new System.Drawing.Point(425, 415);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(115, 47);
            this.play.TabIndex = 4;
            this.play.Text = "PLAY";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.LightCyan;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.score.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(143)))));
            this.score.Location = new System.Drawing.Point(370, 468);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(225, 45);
            this.score.TabIndex = 5;
            this.score.Text = "HIGH SCORE";
            this.score.UseVisualStyleBackColor = false;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // asteroid
            // 
            this.asteroid.AutoSize = true;
            this.asteroid.BackColor = System.Drawing.Color.Transparent;
            this.asteroid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.asteroid.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asteroid.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.asteroid.Location = new System.Drawing.Point(224, 187);
            this.asteroid.Name = "asteroid";
            this.asteroid.Size = new System.Drawing.Size(514, 99);
            this.asteroid.TabIndex = 7;
            this.asteroid.Text = "ASTEROID";
            // 
            // rain
            // 
            this.rain.AutoSize = true;
            this.rain.BackColor = System.Drawing.Color.Transparent;
            this.rain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rain.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rain.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.rain.Location = new System.Drawing.Point(385, 298);
            this.rain.Name = "rain";
            this.rain.Size = new System.Drawing.Size(184, 66);
            this.rain.TabIndex = 8;
            this.rain.Text = "RAIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 638);
            this.Controls.Add(this.rain);
            this.Controls.Add(this.asteroid);
            this.Controls.Add(this.score);
            this.Controls.Add(this.play);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asteroid Rain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Label asteroid;
        private System.Windows.Forms.Label rain;
    }
}

