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
    public partial class DummyPropertyWindow : ToolWindow
    {
        public DummyPropertyWindow()
        {
            InitializeComponent();
			comboBox.SelectedIndex = 0;
			propertyGrid.SelectedObject = propertyGrid;
        }
    }
}