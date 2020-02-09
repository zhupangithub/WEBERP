namespace Storage
{
    partial class frmStorageQty
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
            this.cbKind = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // rgOption
            // 
            this.rgOption.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgOption.Properties.Appearance.Options.UseBackColor = true;
            // 
            // lbTitle
            // 
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Size = new System.Drawing.Size(125, 30);
            this.lbTitle.Text = "frmBase";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Size = new System.Drawing.Size(963, 56);
            // 
            // cbKind
            // 
            this.cbKind.Location = new System.Drawing.Point(585, 44);
            this.cbKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKind.Name = "cbKind";
            this.cbKind.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbKind.Properties.Items.AddRange(new object[] {
            "产成品",
            "半成品",
            "原材料",
            "其它"});
            this.cbKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbKind.Size = new System.Drawing.Size(133, 25);
            this.cbKind.TabIndex = 17;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // frmStorageQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(963, 586);
            this.Controls.Add(this.cbKind);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmStorageQty";
            this.Text = "实时库存";
            this.Load += new System.EventHandler(this.frmStorageQty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStorageQty_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.cbKind, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rgOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbKind.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbKind;
    }
}
