using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Gordon.Cost4.Client
{
    public partial class ToolWindow : DockContent
    {
        public ToolWindow()
        {
            InitializeComponent();
        }

        private void option1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}