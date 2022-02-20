using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Strip_Usage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bLIUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void gREYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void bLACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("this project was made by mert umul", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mADMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8");
        }
    }
}
