using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Final_Project
{
    public partial class FormIPvalidation : Form
    {
        public FormIPvalidation()
        {
            InitializeComponent();
        }
        Regex Check = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
        private void button3_Click(object sender, EventArgs e)
        {
            //exit
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reset
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate ip
            
            textBox1.Text = textBox1.Text.Trim();
            if (Check.IsMatch(textBox1.Text) ==true)
            {
                MessageBox.Show(textBox1.Text + "This IP is valid");
            }
            else
            {
                MessageBox.Show("ip is not valid \n valid format example is \n 255.255.25.255");
            }
        }

        private void FormIPvalidation_Load(object sender, EventArgs e)
        {
            // show date
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
