namespace Gordon.Cost4.Client.Controls
{
    partial class ButtonEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.innerButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // innerButton
            // 
            this.innerButton.BackgroundImage = global::Gordon.Cost4.Client.Properties.Resources.refresh;
            this.innerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.innerButton.CausesValidation = false;
            this.innerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.innerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.innerButton.Location = new System.Drawing.Point(0, 0);
            this.innerButton.Margin = new System.Windows.Forms.Padding(0);
            this.innerButton.Name = "innerButton";
            this.innerButton.Size = new System.Drawing.Size(20, 20);
            this.innerButton.Height=25;
            this.innerButton.TabIndex = 0;
            this.toolTip.SetToolTip(this.innerButton, "选择");
            this.innerButton.UseVisualStyleBackColor = false;
            this.innerButton.Visible = false;
            // 
            // ButtonEdit
            // 
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ReadOnly = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button innerButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
