using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1{
    public partial class Form1 : Form{
        int score=0;
        int pic = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            Random random = new Random();
            pic = random.Next(1 , 7);
            switch (pic){

                case (1):
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett);
                    break;
                case (2):
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett2);
                    break;
                case (3):
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett3);
                    break;
                case (4):
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett4);
                    break;
                case (5):
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett5);
                    break;
                default:
                    button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.bennett6);
                    break;
            }
            button1.Size = new Size(button1.BackgroundImage.Width, button1.BackgroundImage.Height);
            int randomX = random.Next(0, (this.Width-button1.BackgroundImage.Width));
            int randomY = random.Next(0, (this.Height-button1.BackgroundImage.Height));
            button1.Location = new Point(randomX, randomY);
            score++;
            lbl1.Text = "Score: " + score;
            timer1.Enabled = true;
            timer1.Stop();
            timer1.Start();
            timer1.Interval -= 50;
            lbl1.Location = new Point(0, this.Height-50);
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void timer1_Tick(object sender, EventArgs e){
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.problem);
            button1.Size = new Size(button1.BackgroundImage.Width, button1.BackgroundImage.Height);
            Random random = new Random();
            int randomX = random.Next(0, (this.Width - button1.BackgroundImage.Width));
            int randomY = random.Next(0, (this.Height - button1.BackgroundImage.Height));
            button1.Location = new Point(randomX, randomY);
            score--;
            timer1.Interval += 50;
            lbl1.Text = "Score: " + score;
        }



    }
}
