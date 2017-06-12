using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tron_PG_WPA
{
    public partial class PW_TRON : Form
    {
        private int dir = 0;
        private Timer my_timer = new Timer();
        private Random rand = new Random();
        private Graphics graphics;
        private Lightcycle player1, player2;

        public PW_TRON()
        {
            InitializeComponent();
            player1 = new Lightcycle();
            player2 = new Lightcycle();
            my_timer.Interval = 75;
            my_timer.Tick += Update;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IntroInfo_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyData)
            {
                case Keys.Enter:
                    break;
                case Keys.Space:
                    break;
         
            }
        }

        private void IntroInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Update(object sender, EventArgs e)
        {

        }

        private void Restart()
        {

        }
    }
}
