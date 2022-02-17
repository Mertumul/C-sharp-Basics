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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car c2 = new Car();

            c2.colour = "Blue";
            c2.speed = 200;
            c2.engine = 412.51;
            c2.price = 300000;
            c2.status = 's';

            label1.Text = c2.colour;
            label2.Text = c2.speed.ToString();
            label3.Text = c2.engine.ToString();
            label4.Text = c2.price.ToString();
            label5.Text = c2.status.ToString();
            pictureBox1.BackColor = Color.CadetBlue;


        }
    }
}
