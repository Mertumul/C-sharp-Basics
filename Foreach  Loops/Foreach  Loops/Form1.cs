using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach__Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //string[] contacs = { "Ali","Ahmet","Mert","Melis","Buse","Aslı" };
            //foreach(string c in contacs)
            //{
            //    listBox1.Items.Add(c);
            //}
            int[] exams = { 70, 65, 85, 100, 90 };
            foreach(int x in exams)
            {
                listBox1.Items.Add(x);
                total += x;

            }
            label2.Text = total.ToString();
            int avarage = total / exams.Length;
            label4.Text = avarage.ToString();

        }
    }
}
