using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number1, number2, number3;
            number1 = rnd.Next(1, 10);
            number2 = rnd.Next(10, 20);
            number3 = rnd.Next(20, 31);
            label1.Text = number1.ToString();
            label2.Text = number2.ToString();
            label3.Text = number3.ToString();




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            label2.Text = " ";
            label3.Text = " ";
        }
    }
}
