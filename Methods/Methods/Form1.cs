using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        int multiplication(int n1,int n2,int n3,int n4)
        {
            int n5 = n1 * n2 * n3 * n4;
            return n5;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int n2 = Convert.ToInt16(textBox2.Text);
            int n3 = Convert.ToInt16(textBox3.Text);
            int n4 = Convert.ToInt16(textBox4.Text);


            label2.Text = multiplication(n1, n2, n3, n4).ToString();

        }
    }
}
