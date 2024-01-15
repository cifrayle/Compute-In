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
    public partial class ExpenseTracker : Form
    {
        public ExpenseTracker()
        {
            InitializeComponent();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            // will show the calculator app
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ExpenseTracker_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if there are selected rows
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User clicked "Yes," proceed with removal
                    foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                    {
                        // Remove the row from the DataGridView without affecting the data source
                        dataGridView1.Rows.Remove(item);
                    }
                }
                // If the user clicked "No," do nothing
            }
            else
            {
                // Inform the user that no rows are selected
                MessageBox.Show("No rows selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_ClearRows_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to clear all rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear all rows from the DataGridView
                dataGridView1.Rows.Clear();

                // If using a DataTable as the data source, you can clear the DataTable as well
                // ((DataTable)dataGridView1.DataSource).Clear();

                // Or if you're using a different data source, adjust accordingly
            }
            // If the user clicked "No," do nothing
        }
    }
}
