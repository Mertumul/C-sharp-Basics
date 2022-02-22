using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_uygulamaları
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
         public string TC;
         public string name_surname;
         public string telephone_number;

        private void Form2_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(TC +" "+ name_surname +" " +telephone_number);
        }
    }
}
