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
    public partial class LevelScreen : Form
    {

        
        public LevelScreen()
        {
            InitializeComponent();
        }

        private void easyLevelClick(object sender, EventArgs e)
        {
            Game gameDisplay = new Game();
            gameDisplay.Show();
        }

        private void intermediateLevelClick(object sender, EventArgs e)
        {
            
        }
    }
}
