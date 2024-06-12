using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {

        int pipeMovement = 8;
        int movement = 5;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void birdDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                movement = -5; 
            }

        }

        private void birdUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                movement = 5;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += movement;
            pipeDown.Left -= pipeMovement;
            pipeUp.Left -= pipeMovement;
            Score.Text = "Score: " + score.ToString();


            if(pipeDown.Left < -70)
            {
                pipeDown.Left = 400;
                score++;
            }
            if(pipeUp.Left < -100)
            {
                pipeUp.Left = 550;
                score++;
            }
        }
    }
}
