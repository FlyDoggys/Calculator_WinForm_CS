using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        string Calc;
        double num1;
        double num2;
        string operation;
        string lastInput;
        double result;

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operation = "+";
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            txtDisplay.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button16_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            if (operation != null)
            {
                if (operation.Equals("+"))
                {
                    result = num1 + num2;
                }
                if (operation.Equals("-"))
                {
                    result = num1 - num2;
                }
                if (operation.Equals("*"))
                {
                    result = num1 * num2;
                }
                if (operation.Equals("/"))
                {
                    result = num1 / num2;
                }

                txtDisplay.Clear();
                txtDisplay.Text = result + "";
            }
            else
            {
                lastInput = txtDisplay.Text;
                txtDisplay.Text = lastInput;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            operation = "-";
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = double.Parse(txtDisplay.Text, CultureInfo.InvariantCulture);

            txtDisplay.Clear();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }
    }
}
