using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcolator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1;
        double num2;
        string op;
        double result;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text=textBox1.Text+"1";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void pov_Click(object sender, EventArgs e)
        {
            num1 =double.Parse(textBox1.Text);
            textBox1.Clear();
            op = "+";
        }

        private void neg_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = "-";
        }

        private void time_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
            textBox1.Clear();
            op = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (op =="+" ) {
           result= num1 + num2;
                textBox1.Text = Convert.ToString(result);
            
            }
          else if (op == "-")
            {
                result = num1 - num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == "*")
            {
                result = num1 * num2;
                textBox1.Text = Convert.ToString(result);
            }
            else if (op == "/")
            {
                result = num1 / num2;
                textBox1.Text = Convert.ToString(result);
            }
        }
    }
}
