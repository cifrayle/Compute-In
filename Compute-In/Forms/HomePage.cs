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

        private void btn_debtCounter_Click(object sender, EventArgs e)
        {
            //>> Responsive side panel
            sidePanel.Height = btn_expenseTracker.Height;
            sidePanel.Top = btn_expenseTracker.Top;

            //>> loads debtCounterPage
            loadForm(new ExpenseTracker());

            // NOTE: Pag hindi gumana yung loadform, ito nalang:
            // Manually set up registeredForm for display in the homePanel
            // NAME NG FORM.TopLevel = false;
            // NAME NG FORM.Dock = DockStyle.Fill;
            // this.mainPanel.Controls.Add(NAME NG FORM);
            // this.mainPanel.Tag = NAME NG FORM;
            // NAME NG FORM.BringToFront();
            // NAME NG FORM.Show();
        }

        private void btn_budgetPlanner_Click(object sender, EventArgs e)
        {
            //>> Responsive side panel
            sidePanel.Height = btn_DebtCounter.Height;
            sidePanel.Top = btn_DebtCounter.Top;

            //>> loads budgetPlannerPage
            loadForm(new DebtCounter());

            // NOTE: Pag hindi gumana yung loadform, ito nalang:
            // Manually set up registeredForm for display in the homePanel
            // NAME NG FORM.TopLevel = false;
            // NAME NG FORM.Dock = DockStyle.Fill;
            // this.mainPanel.Controls.Add(NAME NG FORM);
            // this.mainPanel.Tag = NAME NG FORM;
            // NAME NG FORM.BringToFront();
            // NAME NG FORM.Show();
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
