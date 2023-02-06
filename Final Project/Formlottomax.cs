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
    public partial class Formlottomax : Form
    {
        public Formlottomax()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string filepath = @"c:\final\";
        string filepath1 = @"c:\final\LottoNbrs.txt";
        FileStream lottonbers = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrNumbers = new int[8];
            Random random = new Random();
            string tempo = "";
            int randomNumber = 0;
            textBox1.Text = "";

            arrNumbers[0] = random.Next(1, 9);
            for (int i = 1; i < 8; i++)         
            {
                randomNumber = random.Next(1, 9);
                arrNumbers[i] = randomNumber;
            }

            for (int j = 0; j < 7; j++)
            {
                tempo = tempo + arrNumbers[j] + ",";
                textBox1.Text += arrNumbers[j] +"\t";
            }
            tempo = tempo + " Extra: " + arrNumbers[7];
            textBox1.Text += arrNumbers[7];

            MessageBox.Show(DateTime.Now.ToString() + " - " + tempo);
            
            lottonbers = new FileStream(filepath1, FileMode.Append, FileAccess.Write);
            StreamWriter textOut = new StreamWriter(lottonbers);
            textOut.Write("Lotto max"+ "|");
            textOut.Write(DateTime.Now.ToString() + "|");
            textOut.WriteLine(tempo + "|");
            textOut.Close();
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte count = 0;
            lottonbers = new FileStream(filepath1, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textIn = new StreamReader(lottonbers);
            string results = "Lotto Results";
            while (textIn.Peek() != -1)  
            {
                string row = textIn.ReadLine();
                count++;
                string[] columns = row.Split('|');
                results += "\n" + columns[0] + "\t" +columns[1] + "\t" + columns[2]+ "\n";
                if (count == 5)
                {
                    MessageBox.Show(results);
                    count = 0;
                    results = "Lotto Results";
                }
            }
            if (count > 0) MessageBox.Show(results);
            textIn.Close();
            lottonbers.Close();
        }

        private void Formlottomax_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}