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
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class FormMoneyConversion : Form
    {
        public FormMoneyConversion()
        {
            InitializeComponent();
        }
        Regex check = new Regex(@"^([0 - 9])");
        private void button1_Click(object sender, EventArgs e)
        {
            //exit button
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {//cad input

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {//usd input

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {//eur input

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {//gbp input

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {//btc imput

        }

        private void button2_Click(object sender, EventArgs e)
        {//convert button

        }

        private void button3_Click(object sender, EventArgs e)
        {// read button

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {// cad for output

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {// usd for output

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {// eur for output

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {//gbp for output

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {// btc for output

        }
    }
}
