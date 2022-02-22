using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_Structure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum cities {ADANA,ADIYAMAN,AFYON,AGRI,AMASYA,ANKARA,ANTALYA,ARTVİN,AYDIN}
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            cities ci;
            ci = (cities)number;
            label1.Text = ci.ToString();
        }
    }
}
