using System;
using System.Drawing;
using System.Windows.Forms;

namespace AsteroidRain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);//Smooth animation
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void play_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
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
        private void OnFrameChanged(object o, EventArgs e)
        {
            this.Invalidate();
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

        private void score_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }
    }
}
