using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace Gordon.Cost4.Client
{
    public partial class DummyDoc : DockContent
    {
        public DummyDoc()
        {
            InitializeComponent();
        }

		private string m_fileName = string.Empty;
		public string FileName
		{
			get	{	return m_fileName;	}
			set
			{
				if (value != string.Empty)
				{
					Stream s = new FileStream(value, FileMode.Open);

					FileInfo efInfo = new FileInfo(value);

					string fext = efInfo.Extension.ToUpper();


					s.Close();
				}

				m_fileName = value;
				this.ToolTipText = value;
			}
		}

		// workaround of RichTextbox control's bug:
		// If load file before the control showed, all the text format will be lost
		// re-load the file after it get showed.
		private bool m_resetText = true;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (m_resetText)
			{
				m_resetText = false;
				FileName = FileName;
			}
		}

		protected override string GetPersistString()
		{
            // Add extra information into the persist string for this document
            // so that it is available when deserialized.
			return GetType().ToString() + "," + FileName + "," + Text;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("This is to demostrate menu item has been successfully merged into the main form. Form Text=" + Text);
		}

		private void menuItemCheckTest_Click(object sender, System.EventArgs e)
		{
			menuItemCheckTest.Checked = !menuItemCheckTest.Checked;
		}

		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged (e);
		}

        /// <summary>
        /// 关闭右击选择的面板窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DummyDoc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}