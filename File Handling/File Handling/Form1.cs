using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Handling
{
    
    public partial class Form1 : Form
    {
        string filename, filepath;
        StreamWriter sw;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = filepath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            filename = textBox2.Text;
            sw = File.CreateText(filepath + "//" + filename + ".txt");
            sw.Close();
            MessageBox.Show("Ok Got it bro");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string line = sr.ReadLine();
                while (line!=null)
                {
                    listBox1.Items.Add(line);
                    line = sr.ReadLine();
                }
            }
         

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "File Documents|*.txt";
            saveFileDialog1.Title = "File Documents";
            saveFileDialog1.ShowDialog();
            StreamWriter sw2 = new StreamWriter(saveFileDialog1.FileName);
            sw2.WriteLine(richTextBox1.Text);
            sw2.Close();
            MessageBox.Show("Record Added");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
