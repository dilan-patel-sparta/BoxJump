using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BoxJump
{
    public partial class EasyLevel : Form
    {
        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int gameTimeSeconds = 40;
        DateTime startTime;

        public EasyLevel()
        {
            InitializeComponent();
            startTime = DateTime.Now;
        }


        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && !goUp)
            {
                goUp = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (goUp)
            {
                goUp = false;
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            int elapsedSeconds = (int)(DateTime.Now - startTime).TotalSeconds;
            int remainingSeconds = gameTimeSeconds - elapsedSeconds;

            timerDisplay.Text = "Seconds Left: " + (remainingSeconds);

            if (remainingSeconds <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Oh no! You ran out of time and have lost.");
                this.Hide();
            }
            if (player.Bounds.IntersectsWith(chest.Bounds))
            {
                timer1.Stop();
                MessageBox.Show("Congratulations, you beat the level with a score of " + score.ToString() + " with " + remainingSeconds + " seconds left" + "!");
                this.Hide();

            }
            player.Top += jumpSpeed;
            if (goUp && force < 0)
            {
                goUp = false;
            }

            if (goLeft)
            {
                player.Left -= 5;
            }

            if (goRight)
            {
                player.Left += 5;
            }

            if (goUp)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag == "floor")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds) && !goUp)
                    {
                        force = 8;
                        player.Top = i.Top - player.Height;
                    }
                }

                if (i is PictureBox && i.Tag == "leftWall")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        player.Left = i.Left - player.Width;
                    }
                }

                if (i is PictureBox && i.Tag == "rightWall")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds))
                    {
                        player.Left = i.Left + player.Width;
                    }
                }

                if (i is PictureBox && i.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(i.Bounds) && !goUp)
                    {
                        this.Controls.Remove(i);
                        score++;
                        scoreDisplay.Text = "Score: " + (score).ToString();
                    }
                }
            }
        }
    }
}
