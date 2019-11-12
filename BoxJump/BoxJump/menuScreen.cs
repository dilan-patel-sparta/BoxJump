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
        }

        private void startGame(object sender, EventArgs e)
        {
            
            LevelScreen levelDisplay = new LevelScreen();
            //gamePanel.Controls.Add(levelDisplay);
            levelDisplay.Show();
        }

        
    }
}
