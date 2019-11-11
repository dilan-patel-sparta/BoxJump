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
    public partial class helpScreen : Form
    {
        menuScreen menuDisplay = new menuScreen();

        public helpScreen()
        {
            InitializeComponent();
        }

        private void backButton(object sender, EventArgs e)
        {
            menuDisplay.Show();
            this.Close();
        }
    }
}
