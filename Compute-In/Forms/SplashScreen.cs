using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compute_In.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 4;

            if(panel2.Width >= 589) 
            {
                timer1.Stop();
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
        }
    }
}
