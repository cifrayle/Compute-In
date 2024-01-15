using System;
using System.CodeDom;
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
        private double num1;
        private double num2;
        private string operation;
        private string numString;
        private double calcTotal;
        private bool equalsIsTrue;
        private bool totalIsTrue;

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

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtLbl.Text.Equals(""))
            {

            }
            else
            {
                if (totalIsTrue.Equals(true))
                {
                    equalsIsTrue = false;
                }
                else
                {
                    if (equalsIsTrue.Equals(true))
                    {
                        txtLbl.Text = "";
                        equalsIsTrue = false;
                    }            
                }

                txtLbl.Text = txtLbl.Text + Convert.ToString(0);
                numString = numString + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }

            txtLbl.Text = txtLbl.Text + Convert.ToString(1);
            numString = numString + "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            
            txtLbl.Text = txtLbl.Text + Convert.ToString(2);
            numString = numString + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(3);
            numString = numString + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(4);
            numString = numString + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(5);
            numString = numString + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(6);
            numString = numString + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(7);
            numString = numString + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(8);
            numString = numString + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }
            

            txtLbl.Text = txtLbl.Text + Convert.ToString(9);
            numString = numString + "9";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            txtLbl.Text = "";
            numString = "0";
            totalIsTrue = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtLbl.Text.Equals(""))
            {

            }
            else
            {
                if (totalIsTrue.Equals(true))
                {
                    num1 = Convert.ToDouble(calcTotal);
                }
                else if (totalIsTrue.Equals(false))
                {
                    num1 = Convert.ToDouble(numString);
                }
                operation = "+";
                numString = "0";
                txtLbl.Text = txtLbl.Text + "+";
            }
           
        }

        private void buttonSbrct_Click(object sender, EventArgs e)
        {
            if (txtLbl.Text.Equals(""))
            {

            }
            else
            {
                if (totalIsTrue.Equals(true))
                {
                    num1 = Convert.ToDouble(calcTotal);
                }
                else if (totalIsTrue.Equals(false))
                {
                    num1 = Convert.ToDouble(numString);
                }
                operation = "-";
                numString = "0";
                txtLbl.Text = txtLbl.Text + "-";
            }
        }

        private void buttonMltpl_Click(object sender, EventArgs e)
        {
            if (txtLbl.Text.Equals(""))
            {

            }
            else
            {
                if (totalIsTrue.Equals(true))
                {
                    num1 = Convert.ToDouble(calcTotal);
                }
                else if (totalIsTrue.Equals(false))
                {
                    num1 = Convert.ToDouble(numString);
                }
                operation = "x";
                numString = "0";
                txtLbl.Text = txtLbl.Text + "x";
            }
        }

        private void buttonDvd_Click(object sender, EventArgs e)
        {
            if (txtLbl.Text.Equals(""))
            {

            }
            else
            {
                if (totalIsTrue.Equals(true))
                {
                    num1 = Convert.ToDouble(calcTotal);
                }
                else if (totalIsTrue.Equals(false))
                {
                    num1 = Convert.ToDouble(numString);
                }
                operation = "/";
                numString = "0";
                txtLbl.Text = txtLbl.Text + "/";
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (totalIsTrue.Equals(true))
            {
                equalsIsTrue = false;
            }
            else
            {
                if (equalsIsTrue.Equals(true))
                {
                    txtLbl.Text = "";
                    equalsIsTrue = false;
                }
            }

            txtLbl.Text = txtLbl.Text + ".";
            numString = numString + ".";
        }


        private void buttonEql_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(numString);
            totalIsTrue = true;
            if (operation.Equals("+")){
                calcTotal = num1 + num2;
                txtLbl.Text = Convert.ToString(calcTotal);
                numString = "0";
                num1 = 0;
                num2 = 0;
                equalsIsTrue = true;
            }
            else if (operation.Equals("-"))
            {
                calcTotal = num1 - num2;
                txtLbl.Text = Convert.ToString(calcTotal);
                numString = "0";
                num1 = 0;
                num2 = 0;
                equalsIsTrue = true;
            }
            else if (operation.Equals("x"))
            {
                calcTotal = num1 * num2;
                txtLbl.Text = Convert.ToString(calcTotal);
                numString = "0";
                num1 = 0;
                num2 = 0;
                equalsIsTrue = true;
            }
            else if (operation.Equals("/"))
            {
                calcTotal = num1 / num2;
                txtLbl.Text = Convert.ToString(calcTotal);
                numString = "0";
                num1 = 0;
                num2 = 0;
                equalsIsTrue = true;
            }
        }
    }
}
