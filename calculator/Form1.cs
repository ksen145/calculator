using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(txtExpression.Text);
                    txtExpression.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(txtExpression.Text);
                    txtExpression.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(txtExpression.Text);
                    txtExpression.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(txtExpression.Text);
                    txtExpression.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void btnCal1_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 1;
        }

        private void btnCal2_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 2;
        }

        private void btnCal3_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 3;
        }

        private void btnCal4_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 4;
        }

        private void btnCal5_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 5;
        }

        private void btnCal6_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 6;
        }

        private void btnCal7_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 7;
        }

        private void btnCal8_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 8;
        }

        private void btnCal9_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 9;
        }

        private void btnCal0_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = float.Parse(txtExpression.Text);
            txtExpression.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = float.Parse(txtExpression.Text);
            txtExpression.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            a = float.Parse(txtExpression.Text);
            txtExpression.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            a = float.Parse(txtExpression.Text);
            txtExpression.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void btnRav_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtExpression.Text = "";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lenght = txtExpression.Text.Length - 1;
            string text = txtExpression.Text;
            txtExpression.Clear();
            for (int i = 0; i < lenght; i++)
            {
                txtExpression.Text = txtExpression.Text + text[i];
            }
        }

        private void btnZnak_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                txtExpression.Text = "-" + txtExpression.Text;
                znak = false;
            }
            else if (znak == false)
            {
                txtExpression.Text = txtExpression.Text.Replace("-", "");
                znak = true;
            }
        }

        private void btnToch_Click(object sender, EventArgs e)
        {
            txtExpression.Text = txtExpression.Text + ",";
        }
    }
}
