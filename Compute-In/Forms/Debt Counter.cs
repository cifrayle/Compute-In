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
    public partial class BudgetPlannerPage : Form
    {
        public BudgetPlannerPage()
        {
            InitializeComponent();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            calculator.Show();
        }
    }
}
