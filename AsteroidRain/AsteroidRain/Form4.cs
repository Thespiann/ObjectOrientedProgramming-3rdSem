using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidRain
{
    public partial class Form4 : Form
    {
        public List<int> scores = new List<int>();
        public Form4()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);// Για smooth animation
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            deserialize();
            while (scores.Count() < 10){
                scores.Add(0);
            }
            scores.Sort();
            scores.Reverse();

            place1.Text = scores[0].ToString();
            place2.Text = scores[1].ToString();
            place3.Text = scores[2].ToString();
            place4.Text = scores[3].ToString();
            place5.Text = scores[4].ToString();
            place6.Text = scores[5].ToString();
            place7.Text = scores[6].ToString();
            place8.Text = scores[7].ToString();               
            place9.Text = scores[8].ToString();
            place10.Text = scores[9].ToString();
        }
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
        private void deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("topScores.ser", FileMode.Open, FileAccess.Read);
            scores = (List<int>)formatter.Deserialize(stream);
            stream.Close();
        }
    }
}
