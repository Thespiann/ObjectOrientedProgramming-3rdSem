namespace AsteroidRain
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lose = new System.Windows.Forms.Label();
            this.urscore = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.win = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.BackColor = System.Drawing.Color.Transparent;
            this.lose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lose.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lose.ForeColor = System.Drawing.Color.DarkRed;
            this.lose.Location = new System.Drawing.Point(217, 97);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(514, 99);
            this.lose.TabIndex = 8;
            this.lose.Text = "YOU LOST";
            // 
            // urscore
            // 
            this.urscore.AutoSize = true;
            this.urscore.BackColor = System.Drawing.Color.Transparent;
            this.urscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.urscore.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urscore.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.urscore.Location = new System.Drawing.Point(250, 295);
            this.urscore.Name = "urscore";
            this.urscore.Size = new System.Drawing.Size(457, 66);
            this.urscore.TabIndex = 9;
            this.urscore.Text = "YOUR SCORE:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.AliceBlue;
            this.score.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.score.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.score.Location = new System.Drawing.Point(452, 392);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(51, 50);
            this.score.TabIndex = 10;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.LightCyan;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("OCR A Extended", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(69)))), ((int)(((byte)(143)))));
            this.back.Location = new System.Drawing.Point(413, 500);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(129, 47);
            this.back.TabIndex = 11;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.Color.Transparent;
            this.win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.win.Font = new System.Drawing.Font("OCR A Extended", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.win.ForeColor = System.Drawing.Color.LimeGreen;
            this.win.Location = new System.Drawing.Point(244, 196);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(455, 99);
            this.win.TabIndex = 12;
            this.win.Text = "YOU WON";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 645);
            this.Controls.Add(this.win);
            this.Controls.Add(this.back);
            this.Controls.Add(this.score);
            this.Controls.Add(this.urscore);
            this.Controls.Add(this.lose);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Label urscore;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label win;
    }
}