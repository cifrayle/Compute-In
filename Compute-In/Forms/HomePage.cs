using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compute_In.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();

            sidePanel.Height = btn_Home.Height;
            sidePanel.Top = btn_Home.Top;
        }
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }
        // Import user32 DLL functions for dragging the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //>> loads HomeDashboard form
            loadForm(new HomeDashboard());
            //>> Responsive side panel
            sidePanel.Height = btn_Home.Height;
            sidePanel.Top = btn_Home.Top;
        }

        // this is ExpenseTracker not debtCounter
        private ExpenseTracker expenseTrackerInstance; // Declare an instance of ExpenseTracker

        private void btn_debtCounter_Click(object sender, EventArgs e)
        {
            // Responsive side panel
            sidePanel.Height = btn_expenseTracker.Height;
            sidePanel.Top = btn_expenseTracker.Top;

            // Check if the singleton instance of ExpenseTracker is null or not.
            // If it's null, create a new instance, configure its properties, and add it to the mainPanel.
            if (expenseTrackerInstance == null)
                if (expenseTrackerInstance == null)
            {
                // Create a new instance of ExpenseTracker
                expenseTrackerInstance = new ExpenseTracker();

                // Set properties for display within the mainPanel
                expenseTrackerInstance.TopLevel = false;
                expenseTrackerInstance.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(expenseTrackerInstance);
                this.mainPanel.Tag = expenseTrackerInstance;
            }

            // Bring the existing or newly created ExpenseTracker instance to the front and show it.
            expenseTrackerInstance.BringToFront();
            expenseTrackerInstance.Show();
        }

        private DebtCounter dcInstance; // declare an instance of DebtCounter

        // this is debt counter not budgetPlanner
        private void btn_budgetPlanner_Click(object sender, EventArgs e)
        {
            //>> Responsive side panel
            sidePanel.Height = btn_DebtCounter.Height;
            sidePanel.Top = btn_DebtCounter.Top;

            // check if the instance is null or not
            if (dcInstance == null)
            {
                // create a new instance if it's null
                dcInstance = new DebtCounter();
                dcInstance.TopLevel = false;
                dcInstance.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(dcInstance);
                this.mainPanel.Tag = dcInstance;
            }
            // Bring the existing or newly created DebtCounter instance to the front and show it.
            dcInstance.BringToFront();
            dcInstance.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //>> Responsive side panel
            sidePanel.Height = btn_Logout.Height;
            sidePanel.Top = btn_Logout.Top;

            //>> will ask the user to logout or not
            DialogResult response = MessageBox.Show("Are you sure you want to log out? ", "System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            // Handle user response
            if (response == DialogResult.Yes)
            {
                // Hide the current form
                this.Hide();
                // Create a new adminlog form with the provided instance of registeredForm
                LogInForm login = new LogInForm();
                login.Show();
            }
            else if (response == DialogResult.No)
            {
                // Show the current form
                this.Show();
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging the form by capturing mouse movements
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
