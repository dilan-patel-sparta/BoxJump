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
    public partial class menuScreen : Form
    {
        levelScreen levelDisplay = new levelScreen();
        helpScreen helpDisplay = new helpScreen();
        //gameScreen gameDisplay = new gameScreen();

        public menuScreen()
        {
            InitializeComponent();
        }

        private void startGame(object sender, EventArgs e)
        {
            levelDisplay.Show();
        }

        private void showHelp(object sender, EventArgs e)
        {
            helpDisplay.Show();
        }
    }
}
