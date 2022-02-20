using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_Graphic_ToolsUsage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series["Books"].Points.AddXY("Medetterenian", 5);
            chart1.Series["Books"].Points.AddXY("Aegean", 8);
            chart1.Series["Books"].Points.AddXY("Central Anatolia", 3);
            chart1.Series["Books"].Points.AddXY("Marmara", 10);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
