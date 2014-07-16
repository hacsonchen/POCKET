using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pocket.Clients.Gordon.Cost4.Controls
{
    [DefaultProperty("Text")]
    [DefaultEvent("ButtonClick")]
    public partial class ButtonEdit : TextBox
    {
        [Category("ButtonEdit")]
        public event EventHandler ButtonClick;

        public ButtonEdit()
        {
            InitializeComponent();

            this.Controls.Add(this.innerButton);

            this.innerButton.Visible = true;
            this.innerButton.BackColor = SystemColors.Control;
            this.innerButton.Click += InnerButtonClick;
            this.innerButton.BringToFront();
        }

        #region properties

        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                this.toolTip.SetToolTip(this, value);
            }
        }

        [Category("外观")]
        [DefaultValue("选择")]
        [System.ComponentModel.Description("按钮显示的字符")]
        public string ButtonText
        {
            get { return this.toolTip.GetToolTip(this.innerButton); }
            set { this.toolTip.SetToolTip(this.innerButton, value); }
        }

        [Category("外观")]
        [DefaultValue(true)]
        [System.ComponentModel.Description("是否显示按钮")]
        public bool ButtonEnabled
        {
            get { return this.innerButton.Visible; }
            set { this.innerButton.Visible = value; }
        }

        //[Category("外观")]
        //[DefaultValue(false)]
        //[System.ComponentModel.Description("是否总是显示按钮")]
        //public bool AlwaysShowButton
        //{
        //    get { return this.alwaysShowButton; }
        //    set
        //    {
        //        this.alwaysShowButton = value;
        //        this.innerButton.Visible = value;
        //    }
        //}

        protected Button InnerButton
        {
            get { return this.innerButton; }
        }

        #endregion

        protected virtual void OnButtonClick(EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(this, EventArgs.Empty);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            this.innerButton.Visible = this.Enabled;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!this.ReadOnly)
                return;

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                this.Text = null;
                this.Tag = null;
            }
        }

        private void InnerButtonClick(object sender, EventArgs e)
        {
            this.OnButtonClick(e);
        }

       
    }
}
