using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decision_Structures__Exercies
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

        private void button1_Click(object sender, EventArgs e)
        {
            int exam1, exam2, project;
            double total;
            exam1 = Convert.ToInt16(txtexam1.Text);
            exam2 = Convert.ToInt16(txtexam2.Text);
            project = Convert.ToInt16(txtproject.Text);
            total = (exam1 + exam2 + project) / 3;
            if (total >= 50)
            {
                lblresult.Text = "Total Point:" + total.ToString() + "  Conclusion:Pass";
            }
            else
            {
                lblresult.Text = "Total Point:" + total.ToString() + " Conclusion : Failed";
            }

            RESULTS.Items.Add(lblresult.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtexam1.Text = " ";
            txtexam2.Text = " ";
            txtproject.Text = " ";
            lblresult.Text = " ";

        }
    }
}
