﻿using System;
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
    public partial class DebtCounter : Form
    {
        public DebtCounter()
        {
            InitializeComponent();
        }

        private void btn_removeRow_Click(object sender, EventArgs e)
        {
            // Check if there are selected rows
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Display a confirmation message box
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // User clicked "Yes," proceed with removal
                    foreach (DataGridViewRow item in dataGridView2.SelectedRows)
                    {
                        // Remove the row from the DataGridView without affecting the data source
                        dataGridView2.Rows.Remove(item);
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
        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            // will show the calculator app
            Calculator calc = new Calculator();
            calc.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to clear all rows?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear all rows from the DataGridView
                dataGridView2.Rows.Clear();

                // If using a DataTable as the data source, you can clear the DataTable as well
                // ((DataTable)dataGridView1.DataSource).Clear();

                // Or if you're using a different data source, adjust accordingly
            }
            // If the user clicked "No," do nothing
        }
    }
}
