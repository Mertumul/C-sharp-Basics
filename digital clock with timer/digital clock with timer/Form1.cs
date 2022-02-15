using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace digital_clock_with_timer
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
        int hour = 0, minute = 0, second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            lblsecond.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                lblminute.Text = minute.ToString();

                second = 0;
                if (minute == 60)
                {
                    hour++;
                    lblhour.Text = hour.ToString();
                    minute = 0;
                }
            }

        }
    }
}
