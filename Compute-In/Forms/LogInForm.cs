using Compute_In.Forms;
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

namespace Compute_In
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        // Import user32 DLL functions for dragging the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LogInForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = button1;
            lbl_accountMessage.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminUsername = textBoxUser.Text;
            string adminPassword = textBoxPassword.Text;
            
            

            if (adminUsername == "admin" && adminPassword == "adminWOW")
            {
                this.Hide();
                HomePage home = new HomePage();
                home.ShowDialog();
            }// this line won't display anything if the user entered an empty text.
            else if (adminUsername == "" && adminPassword == "")
            {
                this.Show();
            }
            else
            {
                lbl_accountMessage.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging the form by capturing mouse movements
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
