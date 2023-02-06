using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }
        decimal num1 = 0, num2 = 0, total = 0;
        char op = ' ';
        bool displayok = false;
        string filepath = @"c:\final\";
        string filepath1 = @"c:\final\calculator.txt";
        FileStream calcresult = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 1;
            }
            textBox1.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 2;
            }
            textBox1.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 3;
            }
            textBox1.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 4;
            }
            textBox1.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 5;
            }
            textBox1.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 6;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 7;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 8;
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 9;
            }
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 0;
            }
            textBox1.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(displayok == true)
            {
                textBox1.Text = "";
                displayok = false;
                total = 0;
            }
            textBox1.Text += ".";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.Trim();
            op = '+';
            if (num1 == 0)
            {
                try
                {
                    num1 = Convert.ToDecimal(val);
                    textBox1.Text = "";
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.Trim();
            op = '-';
            if (num1 == 0)
            {
                try
                {
                    num1 = Convert.ToDecimal(val);
                    textBox1.Text = "";
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.Trim();
            op = '*';
            if (num1 == 0)
            {
                try
                {
                    num1 = Convert.ToDecimal(val);
                    textBox1.Text = "";
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.Trim();
            op = '/';
            if (num1 == 0)
            {
                try
                {
                    num1 = Convert.ToDecimal(val);
                    textBox1.Text = "";
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            total = 0;
            textBox1.Text = "";
        }

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.Trim();
            if (num2 == 0)
            {
                try
                {
                    num2 = Convert.ToDecimal(val);
                    textBox1.Text = "";
                }
                catch (Exception exp) { MessageBox.Show(exp.Message); }
            }
            if (op == '+')
            {
                total = num1 + num2;
                textBox1.Text = total.ToString();
                MessageBox.Show("num1: " + num1 + " + num2: " + num2 + " = total: " + total);
                calcresult = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(calcresult);
                textOut.WriteLine(num1 + "+" + num2 + "=" + total);
                textOut.Close();
                displayok = true;
                num1 = 0; num2 = 0;
            }
            if (op == '-')
            {
                total = num1 - num2;
                textBox1.Text = total.ToString();
                MessageBox.Show("num1: " + num1 + " - num2: " + num2 + " = total: " + total);
                calcresult = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(calcresult);
                textOut.WriteLine(num1 + "-" + num2 + "=" + total);
                textOut.Close();
                displayok = true;
                num1 = 0; num2 = 0;
            }
            if (op == '*')
            {
                total = num1 * num2;
                textBox1.Text = total.ToString();
                MessageBox.Show("num1: " + num1 + " * num2: " + num2 + " = total: " + total);
                calcresult = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(calcresult);
                textOut.WriteLine(num1 + "*" + num2 + "=" + total);
                textOut.Close();
                displayok = true;
                num1 = 0; num2 = 0;
            }
            if (op == '/')
            {
                total = num1 / num2;
                textBox1.Text = total.ToString();
                MessageBox.Show("num1: " + num1 + " / num2: " + num2 + " = total: " + total);
                calcresult = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(calcresult);
                textOut.WriteLine(num1 + "/" + num2 + "=" + total);
                textOut.Close();
                displayok = true;
                num1 = 0; num2 = 0;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }
    }
}
