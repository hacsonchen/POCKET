using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Pocket.Clients.Gordon.Cost4
{
    public partial class DummyHistoryExplorer : ToolWindow
    {
        public DummyHistoryExplorer()
        {
            InitializeComponent();
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
        }
    }
}