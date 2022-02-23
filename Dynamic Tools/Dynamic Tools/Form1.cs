using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnlocation = new Point(30, 60);
            btn.Location = btnlocation;

            btn.Name = "Button2";
            btn.Text = "Click";
            btn.Width = 75;
            btn.Height = 50;
            btn.BackColor = Color.MistyRose;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lbllocation = new Point(20, 25);
            lbl.Location = lbllocation;
            lbl.Name = "Label1";
            lbl.Text = "Hi Everyone";
            lbl.BackColor = Color.AliceBlue;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);


            for(int i=1; i < 6; i++)
            {
                TextBox txt = new TextBox();
                Point txtlocation = new Point(350, i * 35);
                txt.Location = txtlocation;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);

            }

            

        }
    }
}
