﻿namespace FlappyBirdGame
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
            this.components = new System.ComponentModel.Container();
            this.Score = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.restartImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(12, 756);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(151, 48);
            this.Score.TabIndex = 4;
            this.Score.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // bird
            // 
            this.bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(75, 308);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(91, 75);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            this.ground.BackgroundImage = global::FlappyBirdGame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-3, 718);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(819, 98);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = global::FlappyBirdGame.Properties.Resources.pipe;
            this.pipeUp.Location = new System.Drawing.Point(399, 446);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(110, 276);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 0;
            this.pipeUp.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
            this.pipeDown.Location = new System.Drawing.Point(536, 2);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(110, 264);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 1;
            this.pipeDown.TabStop = false;
            // 
            // restartImage
            // 
            this.restartImage.Image = global::FlappyBirdGame.Properties.Resources.reset_image;
            this.restartImage.Location = new System.Drawing.Point(224, 255);
            this.restartImage.Name = "restartImage";
            this.restartImage.Size = new System.Drawing.Size(241, 219);
            this.restartImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restartImage.TabIndex = 5;
            this.restartImage.TabStop = false;
            this.restartImage.Click += new System.EventHandler(this.RestartClickEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(706, 813);
            this.Controls.Add(this.restartImage);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Controls.Add(this.pipeDown);
            this.Name = "Form1";
            this.Text = "FlappyBirdForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.birdDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.birdUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restartImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox restartImage;
    }
}

