using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AsteroidRain
{
    public partial class Form2 : Form
    {
        int score = 0;
        List<Label> bullets = new List<Label>();
        List<PictureBox> asteroids1 = new List<PictureBox>();
        List<PictureBox> asteroids2 = new List<PictureBox>();
        List<int> playerscore = new List<int>();
        Random r;
        SoundPlayer s;
        int counter = 45;

        public Form2()
        {
            InitializeComponent();
            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// Για smooth animation
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            s = new SoundPlayer("Flash-laser-02.wav");
            deserialize();
           
        }
        int counter1 = 0, len1 = 0;
        string txt1;
       
        //Για το animation
        bool currentlyAnimating = false;
        bool isAnimating = true;
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (isAnimating)
            {
                AnimateImage();
                ImageAnimator.UpdateFrames();
            }
            base.OnPaintBackground(e);
        }

        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(this.BackgroundImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            introtxt1.Text = txt1.Substring(0, counter1);
            ++counter1;
            if (counter1 > len1)
            {
                introtxt1.Text = "";
                introtxt2.Text = "";
                introtxt1.Hide();
                introtxt2.Hide();
                timer1.Stop();
                timer2.Start();
                timer3.Start();
                timer4.Start();
                timer5.Start();
                timer.Text = counter.ToString();
            }

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Label p in bullets)
            {
                p.Location = new Point(p.Location.X, p.Location.Y - 10);
            }
            foreach (PictureBox a in asteroids1)
            {
                a.Location = new Point(a.Location.X - 10, a.Location.Y + 13);
            }
            foreach (PictureBox a in asteroids2)
            {
                a.Location = new Point(a.Location.X + 10, a.Location.Y + 13);
            }
            destroyast();
            scorelbl.Text = score.ToString();
            lose();


        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString().Equals("Left"))
            {
                spaceship.Location = new Point(spaceship.Location.X - 15, spaceship.Location.Y);
            }
            else if (e.KeyCode.ToString().Equals("Right"))
            {
                spaceship.Location = new Point(spaceship.Location.X + 15, spaceship.Location.Y);
            }
            else if (e.KeyCode.ToString().Equals("Space"))
            {
                shoot(spaceship.Location.X);
            }
        }
        private void shoot(int startX)
        {
            if (timer2.Enabled == true)
            {

                Label p1 = new Label();
                p1.Text = " ";
                p1.Size = new Size(10, 32);
                p1.ForeColor = Color.LightGoldenrodYellow;
                p1.BackColor = Color.LightGoldenrodYellow;
                p1.Location = new Point(startX + 60, spaceship.Location.Y - 50);
                Controls.Add(p1);
                bullets.Add(p1);
                s.Play();
            }
                
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            r = new Random();
            txt1 = introtxt1.Text + "       ";
            len1 = txt1.Length;
            introtxt1.Text = "";
            timer1.Start();

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            createComet(spaceship.Location.X);
            if (score > 25)
            {
                timer3.Interval = 2000;
            }
            if (score > 30)
            {
                timer3.Interval = 1000;
            }

        }

        private void createComet(int startx)
        {
            PictureBox a1 = new PictureBox();
            PictureBox a2 = new PictureBox();
            a1.ImageLocation = "asteroid3.png";
            a2.ImageLocation = "asteroid4.png";
            a1.Location = new Point(0, 0);
            a1.BackColor = Color.Transparent;
            a2.BackColor = Color.Transparent;
            a1.Location = new Point(r.Next(Width - spaceship.Width), spaceship.Location.Y - 500);
            a2.Location = new Point(r.Next(Width - 2 * spaceship.Width), spaceship.Location.Y - 500);
            a1.Size = new Size(110, 120);
            a2.Size = new Size(110, 120);
            a1.SizeMode = PictureBoxSizeMode.StretchImage;
            a2.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(a1);
            Controls.Add(a2);
            asteroids1.Add(a1);
            asteroids2.Add(a2);


        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            foreach (PictureBox a3 in asteroids1)
            {
                if (a3.ImageLocation == "explosion.png")
                {
                    a3.Location = new Point(2000, 2000);
                    a3.Hide();
                }
            }
            foreach (PictureBox a4 in asteroids2)
            {
                if (a4.ImageLocation == "explosion.png")
                {
                    a4.Location = new Point(2000, 2000);
                    a4.Hide();
                }
            }
        }

        private void destroyast()
        {
            foreach (Label b in bullets)
            {
                foreach (PictureBox a1 in asteroids1)
                {
                    if (b.Bounds.IntersectsWith(a1.Bounds))
                    {
                        if (b.Location.Y < this.ClientSize.Height)
                        {
                            a1.ImageLocation = "explosion.png";
                            b.Hide();
                            b.Location = new Point(-1000, 1000);
                            b.Hide();
                            score++;
                        }

                    }

                }
                foreach (PictureBox a2 in asteroids2)
                {
                    if (b.Bounds.IntersectsWith(a2.Bounds))
                    {
                        if (b.Location.Y < this.ClientSize.Height)
                        {
                            b.Hide();
                            a2.ImageLocation = "explosion.png";
                            b.Location = new Point(-1000, 1000);
                            b.Hide();
                            score++;
                        }
                    }
                }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter < 4) {
                timer.ForeColor = Color.DarkRed;
            }
            if (counter == -1) {
                timer5.Stop();
                new Form3(score, true).Show();
                serialize();
                bullets.Clear();
                asteroids1.Clear();
                asteroids2.Clear();
                this.Close();
            }
            timer.Text=counter.ToString();
        }

        private void lose()
        {
            foreach (PictureBox p1 in asteroids1)
            {
                if (p1.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    serialize();
                    new Form3(score, false).Show();
                    this.Close();
                }

            }
            foreach (PictureBox p2 in asteroids2)
            {
                if (p2.Bounds.IntersectsWith(spaceship.Bounds))
                {
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timer5.Stop();
                    serialize();
                    new Form3(score, false).Show();
                    this.Close();
                }
            }
        }
        private void serialize() {
            playerscore.Add(score);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser", FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, playerscore);
            stream.Close();
        }
        private void deserialize() {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser", FileMode.Open, FileAccess.Read);
            playerscore = (List<int>)formatter.Deserialize(stream);
            stream.Close();
        }
    }  
       
}
