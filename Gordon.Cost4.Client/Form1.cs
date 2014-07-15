using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gordon.Cost4.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewPlus1.GridColor = Color.FromArgb(211,211,211);
            dataGridViewPlus1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(105, 105, 105);
        }
    }
}
