using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1;
            number1 = Convert.ToDouble(textBox1.Text);
            // label2.Text = Math.Abs(number1).ToString();
            //label2.Text = Math.Ceiling(number1).ToString();
            // label2.Text = Math.Floor(number1).ToString();
            // label2.Text = Math.Pow(number1,3).ToString();
            label2.Text = Math.Sqrt(number1).ToString();
        }
    }
}
