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
    public partial class FormTemperatureConversion : Form
    {
        public FormTemperatureConversion()
        {
            InitializeComponent();
        }
        Regex tempcheck = new Regex(@"^([-]){0,1}([0-9]){1,3}");
        private void button1_Click(object sender, EventArgs e)
        {
            //exit button
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Finputbox.ReadOnly=true;
            Cinputbox.ReadOnly = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Cinputbox.ReadOnly = true;
            Finputbox.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // convert f to c 
            if (radioButton1.Checked==true)
            {
                int output = 0;
                int Input2 = 0;
                Int32.TryParse(Cinputbox.Text,out Input2);
                output = (Input2 * 9 / 5) + 32;
                Cinputbox.Text= Convert.ToString(Input2);
                Finputbox.Text = Convert.ToString(output);
            }
            if (radioButton2.Checked == true)
            {
                if (tempcheck.IsMatch(Finputbox.Text) == true)
                {
                    int output = 0;
                    int Input2 = 0;
                    Int32.TryParse(Finputbox.Text, out Input2);
                    output = (Input2 - 32) * 5 / 9;
                    Finputbox.Text = Convert.ToString(Input2);
                    Cinputbox.Text = Convert.ToString(output);
                }
                else
                {
                  MessageBox.Show("The input is invald the only accepted inputs are numbers(0-9) and negative symbol (-)");
                    Finputbox.Text = "";
                }

            }
        }
    }
}
