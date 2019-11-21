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
    public partial class MenuScreen : Form
    {
        

        public MenuScreen()
        {
            InitializeComponent();


            System.Media.SoundPlayer music = new System.Media.SoundPlayer();
            music.SoundLocation = "C:/Users/Dilan Patel/Engineering45/Project/BoxJump/BoxJump/aNightOfDizzySpells.wav";
            music.Play();


        }

        private void startGame(object sender, EventArgs e)
        {
            
            Game game = new Game();
           
            game.Show();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
