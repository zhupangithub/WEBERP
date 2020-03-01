namespace Product
{
    partial class frmBomEdit
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.editControl5 = new myControl.EditControl();
            this.editControl6 = new myControl.EditControl();
            this.editControl7 = new myControl.EditControl();
            this.editControl8 = new myControl.EditControl();
            this.editControl9 = new myControl.EditControl();
            this.sbSelItem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Size = new System.Drawing.Size(117, 27);
            this.lbTitle.Text = "frmBase";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.sbSelItem);
            this.panelControl1.Controls.Add(this.editControl9);
            this.panelControl1.Controls.Add(this.editControl8);
            this.panelControl1.Controls.Add(this.editControl7);
            this.panelControl1.Controls.Add(this.editControl6);
            this.panelControl1.Controls.Add(this.editControl5);
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panelControl1.Size = new System.Drawing.Size(1063, 171);
            this.panelControl1.Controls.SetChildIndex(this.lbTitle, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl5, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl6, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl7, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl8, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl9, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbSelItem, 0);
            // 
            // editControl4
            // 
            this.editControl4.Location = new System.Drawing.Point(821, 8);
            // 
            // editControl3
            // 
            this.editControl3.Location = new System.Drawing.Point(372, 8);
            // 
            // dateControl1
            // 
            this.dateControl1.Location = new System.Drawing.Point(341, 31);
            this.dateControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl1
            // 
            this.editControl1.Location = new System.Drawing.Point(341, 0);
            this.editControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Remark";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "备注:";
            this.editControl5.Location = new System.Drawing.Point(49, 132);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(852, 34);
            this.editControl5.TabIndex = 4;
            // 
            // editControl6
            // 
            this.editControl6.BackColor = System.Drawing.Color.Transparent;
            this.editControl6.DataField = "F_ItemID";
            this.editControl6.DataSource = null;
            this.editControl6.EditLabel = "主件编码:";
            this.editControl6.Location = new System.Drawing.Point(16, 65);
            this.editControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl6.Name = "editControl6";
            this.editControl6.Request = true;
            this.editControl6.Size = new System.Drawing.Size(239, 26);
            this.editControl6.TabIndex = 6;
            // 
            // editControl7
            // 
            this.editControl7.BackColor = System.Drawing.Color.Transparent;
            this.editControl7.DataField = "";
            this.editControl7.DataSource = null;
            this.editControl7.EditLabel = "主件名称:";
            this.editControl7.Enabled = false;
            this.editControl7.Location = new System.Drawing.Point(309, 65);
            this.editControl7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl7.Name = "editControl7";
            this.editControl7.Request = false;
            this.editControl7.Size = new System.Drawing.Size(299, 26);
            this.editControl7.TabIndex = 7;
            // 
            // editControl8
            // 
            this.editControl8.BackColor = System.Drawing.Color.Transparent;
            this.editControl8.DataField = "";
            this.editControl8.DataSource = null;
            this.editControl8.EditLabel = "主件规格:";
            this.editControl8.Enabled = false;
            this.editControl8.Location = new System.Drawing.Point(648, 65);
            this.editControl8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl8.Name = "editControl8";
            this.editControl8.Request = false;
            this.editControl8.Size = new System.Drawing.Size(253, 26);
            this.editControl8.TabIndex = 8;
            // 
            // editControl9
            // 
            this.editControl9.BackColor = System.Drawing.Color.Transparent;
            this.editControl9.DataField = "";
            this.editControl9.DataSource = null;
            this.editControl9.EditLabel = "单位:";
            this.editControl9.Enabled = false;
            this.editControl9.Location = new System.Drawing.Point(49, 99);
            this.editControl9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl9.Name = "editControl9";
            this.editControl9.Request = false;
            this.editControl9.Size = new System.Drawing.Size(140, 26);
            this.editControl9.TabIndex = 9;
            // 
            // sbSelItem
            // 
            this.sbSelItem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbSelItem.Appearance.Options.UseFont = true;
            this.sbSelItem.Location = new System.Drawing.Point(255, 65);
            this.sbSelItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbSelItem.Name = "sbSelItem";
            this.sbSelItem.Size = new System.Drawing.Size(25, 29);
            this.sbSelItem.TabIndex = 10;
            this.sbSelItem.Text = "...";
            this.sbSelItem.Click += new System.EventHandler(this.sbSelItem_Click);
            // 
            // frmBomEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1063, 636);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmBomEdit";
            this.Text = "物料清单";
            this.Load += new System.EventHandler(this.frmStockOrder_Load);
            this.Shown += new System.EventHandler(this.frmBomEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbSelItem;
        public myControl.EditControl editControl5;
        public myControl.EditControl editControl8;
        public myControl.EditControl editControl7;
        public myControl.EditControl editControl6;
        public myControl.EditControl editControl9;
    }
}
