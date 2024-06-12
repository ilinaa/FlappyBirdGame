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

        int pipeMovement = 7;
        int movement = 5;
        int score = 0;

        bool gameOver = false;
        Random randomPipeSizes = new Random();



        public Form1()
        {
            InitializeComponent();
            ground.Controls.Add(Score);
            Score.Left = 20;
            Score.Top = 25;
            RestartGame();
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
            if(e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += movement;
            pipeDown.Left -= pipeMovement;
            pipeUp.Left -= pipeMovement;
            Score.Text = "Score: " + score;


            if(pipeDown.Left < -70)
            {
                pipeDown.Left = randomPipeSizes.Next(450 , 1000);
                score++;
            }
            if(pipeUp.Left < -100)
            {
                pipeUp.Left = randomPipeSizes.Next(550, 1200);
                score++;
            }
            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) ||
                bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                bird.Bounds.IntersectsWith(ground.Bounds) ||
                bird.Top < -5 ) {

                endGame();
            }
            if(score > 7)
            {
                pipeMovement = 12;
            }
            if (score > 20)
            {
                pipeMovement = 18;
            }
            if(bird.Top < -25)
            {
                endGame();
            }

        }
        private void endGame()
        {
            gameTimer.Stop();
            Score.Text += " Game over! Press R to Retry";
            gameOver = true;
            restartImage.Enabled = true;
            restartImage.Visible = true;
        }

        private void RestartGame()
        {
            gameOver = false;
            bird.Location = new Point(75, 308);
            pipeUp.Left = 400;
            pipeDown.Left = 550;

            score = 0;
            pipeMovement = 8;
            Score.Text = "Score: 0";
            restartImage.Enabled = false;
            restartImage.Visible = false;
            gameTimer.Start();
        }

        private void RestartClickEvent(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
