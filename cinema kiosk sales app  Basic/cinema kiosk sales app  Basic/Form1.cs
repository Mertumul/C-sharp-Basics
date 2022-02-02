using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinema_kiosk_sales_app__Basic
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        int cashtotal = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, tea, toast, ticket,total;
            popcorn = Convert.ToInt16(txtpopcorn.Text);
            water = Convert.ToInt16(txtwater.Text);
            tea = Convert.ToInt16(txttea.Text);
            toast = Convert.ToInt16(txttoast.Text);
            ticket = Convert.ToInt16(txtticket.Text);

            total = popcorn * 15 + water * 2 + tea * 3 + toast * 20 + ticket * 25;
            lbltotal.Text = total.ToString() + "TL";
            cashtotal = cashtotal + total;
            lblcash.Text = cashtotal.ToString() + "TL";

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtpopcorn.Text = " ";
            txttea.Text = " ";
            txtwater.Text = " ";
            txttoast.Text = " ";
            txtticket.Text = " ";
            lbltotal.Text = "0TL ";
        }
    }
}
