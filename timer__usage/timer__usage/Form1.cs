using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer__usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int timer = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
          
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            label1.Text = timer.ToString();
            if (timer<30)
            {
                this.BackColor = Color.Red;
            }
            if (timer == 30)
            {
                this.BackColor = Color.Yellow;
            }
            if (timer > 39)
            {
                this.BackColor = Color.Green;
            }
            if (timer > 70)
            {
                timer = 0;
            }
        }
    }
}
