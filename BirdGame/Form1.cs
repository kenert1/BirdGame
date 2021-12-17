using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdGame
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int TreeSpeed = 6;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Santa.Top += gravity;
            Tree1.Left -= TreeSpeed;
            Tree2.Left -= TreeSpeed;
            moon.Left -= TreeSpeed;
            house.Left -= TreeSpeed;
            SnowFlake.Left -= TreeSpeed;
            scorelabel.Text = $"Score: {score}";

            if(Tree1.Left < -100)
            {
                Tree1.Left = 1600;
                score++;
            }
           
            if(Tree2.Left < -100)
            {
                Tree2.Left = 1400;
                score++;
            }
            if(moon.Left < -100)
            {
                moon.Left = 1300;
            }
            if(SnowFlake.Left < -100)
            {
                SnowFlake.Left = 2000;
            }
            if(house.Left < -100)
            {
                house.Left = 1800;
            }
            if (Santa.Top < -25)
            {
                gameOver();
            }
            if (Santa.Bounds.IntersectsWith(Tree1.Bounds) || Santa.Bounds.IntersectsWith(Tree2.Bounds) || Santa.Bounds.IntersectsWith(Ground.Bounds))
            {
                gameOver();
            }




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        private void gameOver()
        {
            timer1.Stop();
            scorelabel.Text = $"Game Over!";
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }
    }
}
