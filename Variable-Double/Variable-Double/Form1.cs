using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Double
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
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name, surname;
            double exam1, exam2, project, total;

            name = textBox1.Text;
            surname = textBox2.Text;
            exam1 = Convert.ToDouble(textBox3.Text);
            exam2 = Convert.ToDouble(textBox4.Text);
            project = Convert.ToDouble(textBox5.Text);
            total = (exam1 + exam2 + project) / 3;
            listBox1.Items.Add("Name&Surname:" + name + " " + surname + "  total note:" + total);
        }
    }
}
