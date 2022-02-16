using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car c1 = new Car();
            c1.colour = "White";
            c1.speed = 180;
            c1.engine=1234.56;
            c1.price = 250000;
            c1.status = 'f';

            label1.Text = c1.colour;
            label2.Text = c1.speed.ToString();
            label3.Text = c1.engine.ToString();
            label4.Text = c1.price.ToString();
            label5.Text = c1.status.ToString();

        }
    }
}
