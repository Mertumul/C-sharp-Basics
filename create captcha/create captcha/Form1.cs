using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create_captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            string[] symbol1 = { "A", "B", "C", "D", "E", "F", "G", "H" };
            string[] symbol2 = { "e", "f", "g", "j", "z", "k", "m", "t" };
            string[] symbol3 = {"+","*","-","/","#","$","&"};

            Random rnd = new Random();
            int s1, s2, s3, s4, s5;

            s1 = rnd.Next(0, symbol1.Length);
            s2 = rnd.Next(0, symbol2.Length);
            s3 = rnd.Next(0, symbol3.Length);
            s4 = rnd.Next(1, 5);
            s5 = rnd.Next(5, 11);
            label1.Text = symbol1[s1].ToString() + s4.ToString() + symbol3[s3].ToString() + s5.ToString() + symbol2[s2].ToString();

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == label1.Text)
            {
                label1.Text = "Login Succesfull";
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.Text = "Login Failed";
                label1.BackColor = Color.Red;

            }
            textBox1.Text = "";
        }
    }
}
