using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tapsiriq_08._05._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            string cav = " ";
            if (x / 4 > 0 && x / 6 > 0)
            {
                cav = "Bolunur";
            }
            else
            {
                cav = "Bolunmur";
            }
            label1.Text = "Cavab :" + cav;






        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox2.Text);
            string cav = " ";
            if (x <= 50)
                cav = "F";
            else if (x >= 51 && x <= 60)
                cav = "E";
            else if (x >= 61 && x <= 70)
                cav = "D";
            else if (x >= 71 && x <= 80)
                cav = "C";
            else if (x >= 81 && x <= 90)
                cav = "B";
            else if (x >= 91 && x <= 100)
                cav = "A";
            else
            {
                cav = "Bele bir bal yoxdur";
            }
            label2.Text = cav;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = textBox3.Text;
            string psw = textBox4.Text;
            string cavab = "";
            if (ad == "admin" && psw == "12345")
            {
                cavab = "Duzdur";
            }
            else
            {
                cavab = "Sehvdir";
            }
            label3.Text = cavab;
            MessageBox.Show(cavab);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox5.Text);
            string cavab = string.Empty;


            if (x >= 1 && x <= 300)
            {
                cavab = (x - x * 5 / 100).ToString();

            }
            else if (x >= 301 && x <= 500)
            {
                cavab = (x - x * 10 / 100).ToString();

            }
            else if (x >= 501 && x <= 700)
            {
               cavab = (x - x * 15 / 100).ToString();

            }
            else
                cavab = "Bele sert qeyd olunmayib";

            label4.Text = cavab;    






        }
    }
}
