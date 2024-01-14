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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        // Import user32 DLL functions for dragging the form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Allow dragging the form by capturing mouse movements
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
