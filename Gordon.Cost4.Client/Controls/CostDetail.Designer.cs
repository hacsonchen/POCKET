namespace Gordon.Cost4.Client.Controls
{
    partial class CostDetail
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.innerToolStrip = new System.Windows.Forms.ToolStrip();
            this.tbsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbAutoFill = new System.Windows.Forms.ToolStripButton();
            this.innerDataGridView = new Gordon.Cost4.Client.Controls.DataGridViewPlus();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.innerToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // innerToolStrip
            // 
            this.innerToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.innerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsAdd,
            this.tsbDelete,
            this.tsbAutoFill});
            this.innerToolStrip.Location = new System.Drawing.Point(0, 0);
            this.innerToolStrip.Name = "innerToolStrip";
            this.innerToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.innerToolStrip.Size = new System.Drawing.Size(482, 25);
            this.innerToolStrip.TabIndex = 0;
            this.innerToolStrip.Text = "toolStrip1";
            // 
            // tbsAdd
            // 
            this.tbsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsAdd.Image = global::Gordon.Cost4.Client.Properties.Resources.add_obj;
            this.tbsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsAdd.Name = "tbsAdd";
            this.tbsAdd.Size = new System.Drawing.Size(23, 22);
            this.tbsAdd.Text = "Add";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Gordon.Cost4.Client.Properties.Resources.delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Delete";
            // 
            // tsbAutoFill
            // 
            this.tsbAutoFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAutoFill.Image = global::Gordon.Cost4.Client.Properties.Resources.copy_a_row;
            this.tsbAutoFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAutoFill.Name = "tsbAutoFill";
            this.tsbAutoFill.Size = new System.Drawing.Size(23, 22);
            this.tsbAutoFill.Text = "Auto Fill";
            // 
            // innerDataGridView
            // 
            this.innerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.innerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.innerDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.innerDataGridView.Location = new System.Drawing.Point(0, 25);
            this.innerDataGridView.Name = "innerDataGridView";
            this.innerDataGridView.RowTemplate.Height = 23;
            this.innerDataGridView.Size = new System.Drawing.Size(482, 282);
            this.innerDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // CostDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.innerDataGridView);
            this.Controls.Add(this.innerToolStrip);
            this.Name = "CostDetail";
            this.Size = new System.Drawing.Size(482, 307);
            this.innerToolStrip.ResumeLayout(false);
            this.innerToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip innerToolStrip;
        private System.Windows.Forms.ToolStripButton tbsAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbAutoFill;
        private DataGridViewPlus innerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
