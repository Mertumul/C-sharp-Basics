using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point loc1 = new Point();
        
        

        private void button1_Click(object sender, EventArgs e)
         
        {
            timer1.Start();
            loc1.Y = 150;

         
        }
        int number = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            number += 50;
            loc1.X = number;
            label1.Text = number.ToString();
            pictureBox1.Location = loc1;
            if (loc1.X == 900)
            {
                timer1.Stop();
            }
           
        }
    }
}
