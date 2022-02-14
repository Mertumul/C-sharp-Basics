using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knowledge__competition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label5.Text = btna.Text;
            if (label4.Text == label5.Text)
            {
                correctno++;
                lbl_number_of_correct.Text = correctno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrectno++;
                lbl_bumber_of_incorrect.Text = incorrectno.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            label5.Text = btnd.Text;
            if (label5.Text == label4.Text)
            {
                correctno++;
                lbl_number_of_correct.Text = correctno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrectno++;
                lbl_bumber_of_incorrect.Text = incorrectno.ToString();
                pictureBox2.Visible = true;
            }
        }
        int questionno=0,correctno=0,incorrectno=0;

        private void btnc_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            label5.Text = btnc.Text;
            if (label5.Text == label4.Text)
            {
                correctno++;
                lbl_number_of_correct.Text = correctno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrectno++;
                lbl_bumber_of_incorrect.Text = incorrectno.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnb_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = true;

            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;

            label5.Text = btnb.Text;
            if (label5.Text == label4.Text)
            {
                correctno++;
                lbl_number_of_correct.Text = correctno.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                incorrectno++;
                lbl_bumber_of_incorrect.Text = incorrectno.ToString();
                pictureBox2.Visible = true;
            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled = true;
            btnnext.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnnext.Text = "Next";
            questionno++;
            lblquestionno.Text = questionno.ToString();
            if (questionno == 1)
            {
                richTextBox1.Text = "In what year was the republic declared?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label4.Text = "1923";

            }
            if (questionno == 2)
            {
                richTextBox1.Text = "Which province is not found in the Aegean region?";
                btna.Text = "Aydın";
                btnb.Text = "Muğla";
                btnc.Text = "Sakarya";
                btnd.Text = "Izmir";
                label4.Text = "Sakarya";
            }
            if (questionno == 3)
            {
                richTextBox1.Text = "who is the author of the the unbearable lightness of being";
                btna.Text = "Milan Kundera";
                btnb.Text = "Albert Camus";
                btnc.Text = "Stefan Zweig";
                btnd.Text = "George Orwell";
                label4.Text = "Milan Kundera";
                btnnext.Text = "RESULTS";

            }
            if (questionno == 4)
            {

                btnnext.Enabled = false;
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                MessageBox.Show("Number of Correct: " + correctno + "\n" + "Number of Incorrect:" + incorrectno);
            }
            
        }
    }
}
