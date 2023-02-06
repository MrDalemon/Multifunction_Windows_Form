using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit button exits the program
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lotto max Generates 8 random numbers and prints them to a file where they can be read
            Formlottomax newinstance = new Formlottomax();
            newinstance.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // lotto 649 Generates 7 random numbers and prints them to a file where they can be read
            Formlotto649 newinstance = new Formlotto649();
            newinstance.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            //calculator is a calculator that prints its results to a file 
            FormCalculator newinstance = new FormCalculator();
            newinstance.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // money conversion
            FormMoneyConversion newinstance = new FormMoneyConversion();
            newinstance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // temperature conversion
            FormTemperatureConversion newinstance = new FormTemperatureConversion();
            newinstance.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ip validation shows if an ip has the valid pattern of numbers
            FormIPvalidation newinstance = new FormIPvalidation();
            newinstance.Show();
        }
    }
}
