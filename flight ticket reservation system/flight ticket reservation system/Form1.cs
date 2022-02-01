using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flight_ticket_reservation_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {         
            listBox1.Items.Add("Route:" + comboBox1.Text + "-" + comboBox2.Text+" Date:"+dateTimePicker1.Text+" Time:"+maskedTextBox1.Text+"///Passanger Name & Surname:"+textBox1.Text+ " TC Identity Number"+maskedTextBox2.Text+" Phone Number:"+maskedTextBox3.Text);
            MessageBox.Show("Passenger Register Succesfull");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
