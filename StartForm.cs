using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breakoutGame_Assingment2
{
    public partial class Form1 : Form
    {
        private FormGame gm;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// to start the game on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            if (gm == null)
            {
                gm = new Game();
            }
            gm.Show();
            Hide();
        }
    }
}
