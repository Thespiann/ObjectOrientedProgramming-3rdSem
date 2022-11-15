using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidRain
{
    public partial class Form3 : Form
    {
        bool myres = false;
        int myscore;
        SoundPlayer w,l;
        public List<string> playerscore = new List<string>();
        public Form3(int score, bool result)
        {
            InitializeComponent();
            myscore = score;
            myres = result;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//Smooth animation
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            l = new SoundPlayer("negative_beeps-6008.wav");
            w = new SoundPlayer("success-1-6297.wav");
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            score.Text = myscore.ToString();
            if (myres == false)
            {
                lose.Show();
                win.Hide();
                l.Play();
            }
            else {
                win.Show();
                lose.Hide();
                w.Play();
            }
            
        }
        //Animation
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
        }

        private void back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }


    }
}

