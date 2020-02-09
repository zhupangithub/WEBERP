namespace Stock
{
    partial class frmStockPay
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
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem13 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem14 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem15 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem16 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            this.lupControl1 = new myControl.lupControl();
            this.editControl5 = new myControl.EditControl();
            this.cbControl1 = new myControl.cbControl();
            this.spinControl1 = new myControl.SpinControl();
            this.cbControl2 = new myControl.cbControl();
            this.sbAuto = new DevExpress.XtraEditors.SimpleButton();
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
            this.panelControl1.Controls.Add(this.sbAuto);
            this.panelControl1.Controls.Add(this.cbControl2);
            this.panelControl1.Controls.Add(this.spinControl1);
            this.panelControl1.Controls.Add(this.cbControl1);
            this.panelControl1.Controls.Add(this.editControl5);
            this.panelControl1.Controls.Add(this.lupControl1);
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(1068, 158);
            this.panelControl1.Controls.SetChildIndex(this.lbTitle, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.dateControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.lupControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.editControl5, 0);
            this.panelControl1.Controls.SetChildIndex(this.cbControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.spinControl1, 0);
            this.panelControl1.Controls.SetChildIndex(this.cbControl2, 0);
            this.panelControl1.Controls.SetChildIndex(this.sbAuto, 0);
            // 
            // editControl4
            // 
            this.editControl4.Location = new System.Drawing.Point(767, 8);
            this.editControl4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl3
            // 
            this.editControl3.Location = new System.Drawing.Point(347, 8);
            this.editControl3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // dateControl1
            // 
            this.dateControl1.Location = new System.Drawing.Point(333, 42);
            this.dateControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // editControl1
            // 
            this.editControl1.Location = new System.Drawing.Point(336, 10);
            this.editControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // lupControl1
            // 
            this.lupControl1.BackColor = System.Drawing.Color.Transparent;
            this.lupControl1.DataField = "F_SupplierID";
            this.lupControl1.DataSource = null;
            this.lupControl1.DisplayCaption = "";
            this.lupControl1.DropSQL = "";
            this.lupControl1.EditLabel = "供应商:";
            this.lupControl1.InvokeClass = "";
            this.lupControl1.LinkFields = null;
            this.lupControl1.Location = new System.Drawing.Point(33, 76);
            this.lupControl1.LookUpDataSource = null;
            this.lupControl1.LookUpDisplayField = null;
            this.lupControl1.LookUpKeyField = null;
            this.lupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.lupControl1.Name = "lupControl1";
            this.lupControl1.PopWidth = 150;
            this.lupControl1.Request = true;
            this.lupControl1.Size = new System.Drawing.Size(360, 28);
            this.lupControl1.TabIndex = 5;
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Remark";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "备注:";
            this.editControl5.Location = new System.Drawing.Point(49, 114);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(747, 34);
            this.editControl5.TabIndex = 7;
            // 
            // cbControl1
            // 
            this.cbControl1.BackColor = System.Drawing.Color.Transparent;
            comboBoxItem13.Value = "应付款";
            comboBoxItem14.Value = "预付款";
            comboBoxItem15.Value = "预付冲应付";
            comboBoxItem16.Value = "应付转预付";
            this.cbControl1.cbItem = new DevExpress.XtraEditors.Controls.ComboBoxItem[] {
        comboBoxItem13,
        comboBoxItem14,
        comboBoxItem15,
        comboBoxItem16};
            this.cbControl1.DataField = "F_Kind";
            this.cbControl1.DataSource = null;
            this.cbControl1.EditLabel = "付款类型:";
            this.cbControl1.EditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbControl1.Location = new System.Drawing.Point(16, 42);
            this.cbControl1.Margin = new System.Windows.Forms.Padding(5);
            this.cbControl1.Name = "cbControl1";
            this.cbControl1.Request = false;
            this.cbControl1.SelectedIndex = -1;
            this.cbControl1.Size = new System.Drawing.Size(233, 26);
            this.cbControl1.TabIndex = 3;
            // 
            // spinControl1
            // 
            this.spinControl1.BackColor = System.Drawing.Color.Transparent;
            this.spinControl1.DataField = "F_Money";
            this.spinControl1.DataSource = null;
            this.spinControl1.EditLabel = "付款金额:";
            this.spinControl1.Location = new System.Drawing.Point(535, 76);
            this.spinControl1.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl1.Name = "spinControl1";
            this.spinControl1.Size = new System.Drawing.Size(216, 26);
            this.spinControl1.TabIndex = 6;
            // 
            // cbControl2
            // 
            this.cbControl2.BackColor = System.Drawing.Color.Transparent;
            this.cbControl2.cbItem = new DevExpress.XtraEditors.Controls.ComboBoxItem[0];
            this.cbControl2.DataField = "F_PayType";
            this.cbControl2.DataSource = null;
            this.cbControl2.EditLabel = "付款方式:";
            this.cbControl2.EditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbControl2.Location = new System.Drawing.Point(535, 42);
            this.cbControl2.Margin = new System.Windows.Forms.Padding(5);
            this.cbControl2.Name = "cbControl2";
            this.cbControl2.Request = false;
            this.cbControl2.SelectedIndex = -1;
            this.cbControl2.Size = new System.Drawing.Size(216, 26);
            this.cbControl2.TabIndex = 4;
            // 
            // sbAuto
            // 
            this.sbAuto.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAuto.Appearance.Options.UseFont = true;
            this.sbAuto.Location = new System.Drawing.Point(961, 114);
            this.sbAuto.Margin = new System.Windows.Forms.Padding(4);
            this.sbAuto.Name = "sbAuto";
            this.sbAuto.Size = new System.Drawing.Size(91, 29);
            this.sbAuto.TabIndex = 9;
            this.sbAuto.Text = "自动分配";
            this.sbAuto.Click += new System.EventHandler(this.sbAuto_Click);
            // 
            // frmStockPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1068, 674);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmStockPay";
            this.Text = "采购付款单";
            this.Load += new System.EventHandler(this.frmStockOrder_Load);
            this.Shown += new System.EventHandler(this.frmStockPay_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.binMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binSlaver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbAuto;
        public myControl.lupControl lupControl1;
        public myControl.EditControl editControl5;
        public myControl.cbControl cbControl1;
        public myControl.SpinControl spinControl1;
        public myControl.cbControl cbControl2;
    }
}
