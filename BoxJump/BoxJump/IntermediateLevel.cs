using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxJump
{
    public partial class IntermediateLevel : Form
    {

        bool goLeft = false;
        bool goRight = false;
        bool goUp = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        int gameTimeSeconds = 40;
        //DateTime startTime;

        public IntermediateLevel()
        {
            InitializeComponent();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
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
            }
        }
    }
}
