using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_shopping_discount_calculator
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amountofbook, total;
            amountofbook = Convert.ToUInt16(textBox1.Text);

            if (amountofbook <= 20&&amountofbook>0)
            {
                total = amountofbook * 10 * 8 / 10;
                lblprice.Text = total.ToString();


            }
            else if (amountofbook > 20 && amountofbook < 40)
            {
                total = amountofbook * 10 * 6 / 10;
                lblprice.Text = total.ToString();


            }
            else if (amountofbook>50)
            {
                total = amountofbook * 10 * 5 / 10;
                lblprice.Text= total.ToString();

            }
            else
            {
                lblprice.Text = "you have to enter greater than the 0 number ";
            }
        }
    }
}
