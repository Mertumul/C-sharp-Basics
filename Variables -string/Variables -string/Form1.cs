using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables__string
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name, surname, age, job, gender;
            name = textBox1.Text;
            surname = textBox2.Text;
            age = maskedTextBox1.Text;
            job = textBox3.Text;
            gender = textBox4.Text;

            listBox1.Items.Add(" Name:"+name + " Surname:"+surname+" Age:" + age+" Job:" + job+" Gender:" + gender);

        }
    }
}
