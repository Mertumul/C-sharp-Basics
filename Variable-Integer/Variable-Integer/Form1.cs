using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Integer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int number1, number2, addition, subtraction, multiplication, dimension;

            number1 = Convert.ToInt32(textBox1.Text);
            number2 = Convert.ToInt32(textBox2.Text);

            addition = number1 + number2;
            subtraction = number1 - number2;
            multiplication = number1 * number2;
            dimension = number1 / number2;
            MessageBox.Show("Addition is:" + addition + "\n "+ "Subtraction is:" +subtraction+ "\n" +" Multiplication is:" + multiplication + "\n"+" Dimension is:" + dimension);
        }
    }
}
