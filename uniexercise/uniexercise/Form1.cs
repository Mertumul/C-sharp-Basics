using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uniexercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            for (int i = 0; i < 10; i++)
            {
                Convert.ToString(rastgele.Next(100));
                listBox1.Items.Add(Convert.ToString(rastgele.Next(100)));

            }



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Single result = 0;
            foreach (string s in listBox1.Items)
            {
                result += Convert.ToSingle(s);
            }
            button1.Text = "Result" + result.ToString();
            {

            }
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void YeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void AçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void KaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName,RichTextBoxStreamType.RichText);
            }

        }

        private void CıkısToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Color a = Color.FromName(textBox1.Text);
            graphicsObj.Clear(a);
            Pen mypen = new Pen(System.Drawing.Color.Red, 5);
            graphicsObj.DrawLine(mypen, 20, 40, 200, 210);
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen mypen = new Pen(System.Drawing.Color.Blue, 5);
            Rectangle myrectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawRectangle(mypen,myrectangle );
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            List<Rectangle> Drawlist = new List<Rectangle>();
            Drawlist.Add(new Rectangle(10, 30, 10, 40));
            Drawlist.Add(new Rectangle(50, 40, 20, 10));
            Drawlist.Add(new Rectangle(20, 20, 30, 20));

            Graphics g= this.CreateGraphics();
            foreach (Rectangle Object in Drawlist)
            {
                g.FillRectangle(new SolidBrush(Color.Black), Object);
            }

        }

        private void KesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void KopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void YapıstırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void RenkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void YazıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Font myfont = new System.Drawing.Font("Helvetica", 40, FontStyle.Italic);
            Brush mybrush = new SolidBrush(System.Drawing.Color.Green);
            graphicsObj.DrawString("hello c#", myfont, mybrush, 30, 30);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphicsObj;
            graphicsObj = this.CreateGraphics();
            Pen mypen = new Pen(System.Drawing.Color.Green, 5);
            Rectangle myrectangle = new Rectangle(20, 20, 250, 200);
            graphicsObj.DrawEllipse(mypen, myrectangle);


        }
    }
}
