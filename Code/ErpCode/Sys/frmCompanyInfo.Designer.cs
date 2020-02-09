namespace Sys
{
    partial class frmCompanyInfo
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
            this.dateControl1 = new myControl.DateControl();
            this.editControl6 = new myControl.EditControl();
            this.editControl5 = new myControl.EditControl();
            this.editControl4 = new myControl.EditControl();
            this.editControl3 = new myControl.EditControl();
            this.editControl2 = new myControl.EditControl();
            this.editControl1 = new myControl.EditControl();
            this.picLogo = new DevExpress.XtraEditors.PictureEdit();
            this.ckUse = new DevExpress.XtraEditors.CheckEdit();
            this.editControl7 = new myControl.EditControl();
            this.editControl8 = new myControl.EditControl();
            this.editControl9 = new myControl.EditControl();
            this.editControl10 = new myControl.EditControl();
            this.editControl11 = new myControl.EditControl();
            this.editControl12 = new myControl.EditControl();
            this.editControl13 = new myControl.EditControl();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckUse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Location = new System.Drawing.Point(513, 455);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(621, 455);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.editControl13);
            this.gbox.Controls.Add(this.editControl12);
            this.gbox.Controls.Add(this.editControl11);
            this.gbox.Controls.Add(this.editControl10);
            this.gbox.Controls.Add(this.editControl9);
            this.gbox.Controls.Add(this.editControl8);
            this.gbox.Controls.Add(this.editControl7);
            this.gbox.Controls.Add(this.ckUse);
            this.gbox.Controls.Add(this.dateControl1);
            this.gbox.Controls.Add(this.editControl6);
            this.gbox.Controls.Add(this.editControl5);
            this.gbox.Controls.Add(this.editControl4);
            this.gbox.Controls.Add(this.editControl3);
            this.gbox.Controls.Add(this.editControl2);
            this.gbox.Controls.Add(this.editControl1);
            this.gbox.Controls.Add(this.picLogo);
            this.gbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbox.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gbox.Size = new System.Drawing.Size(704, 422);
            // 
            // ckCopy
            // 
            // 
            // dateControl1
            // 
            this.dateControl1.BackColor = System.Drawing.Color.Transparent;
            this.dateControl1.DataField = "F_UseDate";
            this.dateControl1.DataSource = null;
            this.dateControl1.DisplayFormat = "d";
            this.dateControl1.EditLabel = "启用日期:";
            this.dateControl1.EditMask = "d";
            this.dateControl1.Location = new System.Drawing.Point(13, 379);
            this.dateControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dateControl1.Name = "dateControl1";
            this.dateControl1.Request = false;
            this.dateControl1.Size = new System.Drawing.Size(247, 26);
            this.dateControl1.TabIndex = 13;
            // 
            // editControl6
            // 
            this.editControl6.BackColor = System.Drawing.Color.Transparent;
            this.editControl6.DataField = "F_Email";
            this.editControl6.DataSource = null;
            this.editControl6.EditLabel = "邮箱:";
            this.editControl6.Location = new System.Drawing.Point(49, 345);
            this.editControl6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl6.Name = "editControl6";
            this.editControl6.Request = false;
            this.editControl6.Size = new System.Drawing.Size(627, 26);
            this.editControl6.TabIndex = 12;
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_Net";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "网址:";
            this.editControl5.Location = new System.Drawing.Point(49, 311);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(627, 26);
            this.editControl5.TabIndex = 11;
            // 
            // editControl4
            // 
            this.editControl4.BackColor = System.Drawing.Color.Transparent;
            this.editControl4.DataField = "F_Adr";
            this.editControl4.DataSource = null;
            this.editControl4.EditLabel = "地址:";
            this.editControl4.Location = new System.Drawing.Point(49, 278);
            this.editControl4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl4.Name = "editControl4";
            this.editControl4.Request = false;
            this.editControl4.Size = new System.Drawing.Size(627, 26);
            this.editControl4.TabIndex = 10;
            // 
            // editControl3
            // 
            this.editControl3.BackColor = System.Drawing.Color.Transparent;
            this.editControl3.DataField = "F_LinkMan";
            this.editControl3.DataSource = null;
            this.editControl3.EditLabel = "联系人:";
            this.editControl3.Location = new System.Drawing.Point(33, 244);
            this.editControl3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl3.Name = "editControl3";
            this.editControl3.Request = false;
            this.editControl3.Size = new System.Drawing.Size(285, 26);
            this.editControl3.TabIndex = 9;
            // 
            // editControl2
            // 
            this.editControl2.BackColor = System.Drawing.Color.Transparent;
            this.editControl2.DataField = "F_Tel";
            this.editControl2.DataSource = null;
            this.editControl2.EditLabel = "联系电话1:";
            this.editControl2.Location = new System.Drawing.Point(8, 142);
            this.editControl2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl2.Name = "editControl2";
            this.editControl2.Request = false;
            this.editControl2.Size = new System.Drawing.Size(311, 26);
            this.editControl2.TabIndex = 3;
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.Color.Transparent;
            this.editControl1.DataField = "F_Company";
            this.editControl1.DataSource = null;
            this.editControl1.EditLabel = "企业名称:";
            this.editControl1.Location = new System.Drawing.Point(16, 62);
            this.editControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl1.Name = "editControl1";
            this.editControl1.Request = true;
            this.editControl1.Size = new System.Drawing.Size(489, 26);
            this.editControl1.TabIndex = 1;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(545, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(133, 120);
            this.picLogo.TabIndex = 22;
            // 
            // ckUse
            // 
            this.ckUse.Location = new System.Drawing.Point(513, 379);
            this.ckUse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckUse.Name = "ckUse";
            this.ckUse.Properties.Caption = "启用";
            this.ckUse.Size = new System.Drawing.Size(75, 23);
            this.ckUse.TabIndex = 14;
            // 
            // editControl7
            // 
            this.editControl7.BackColor = System.Drawing.Color.Transparent;
            this.editControl7.DataField = "F_Tel1";
            this.editControl7.DataSource = null;
            this.editControl7.EditLabel = "联系电话2:";
            this.editControl7.Location = new System.Drawing.Point(341, 142);
            this.editControl7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl7.Name = "editControl7";
            this.editControl7.Request = false;
            this.editControl7.Size = new System.Drawing.Size(337, 26);
            this.editControl7.TabIndex = 4;
            // 
            // editControl8
            // 
            this.editControl8.BackColor = System.Drawing.Color.Transparent;
            this.editControl8.DataField = "F_Tel2";
            this.editControl8.DataSource = null;
            this.editControl8.EditLabel = "联系电话3:";
            this.editControl8.Location = new System.Drawing.Point(8, 176);
            this.editControl8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl8.Name = "editControl8";
            this.editControl8.Request = false;
            this.editControl8.Size = new System.Drawing.Size(311, 26);
            this.editControl8.TabIndex = 5;
            // 
            // editControl9
            // 
            this.editControl9.BackColor = System.Drawing.Color.Transparent;
            this.editControl9.DataField = "F_ID";
            this.editControl9.DataSource = null;
            this.editControl9.EditLabel = "企业编号:";
            this.editControl9.Location = new System.Drawing.Point(16, 25);
            this.editControl9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl9.Name = "editControl9";
            this.editControl9.Request = true;
            this.editControl9.Size = new System.Drawing.Size(489, 26);
            this.editControl9.TabIndex = 0;
            // 
            // editControl10
            // 
            this.editControl10.BackColor = System.Drawing.Color.Transparent;
            this.editControl10.DataField = "F_Fax";
            this.editControl10.DataSource = null;
            this.editControl10.EditLabel = "传真1:";
            this.editControl10.Location = new System.Drawing.Point(373, 176);
            this.editControl10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl10.Name = "editControl10";
            this.editControl10.Request = false;
            this.editControl10.Size = new System.Drawing.Size(305, 26);
            this.editControl10.TabIndex = 6;
            // 
            // editControl11
            // 
            this.editControl11.BackColor = System.Drawing.Color.Transparent;
            this.editControl11.DataField = "F_Fax1";
            this.editControl11.DataSource = null;
            this.editControl11.EditLabel = "传真2:";
            this.editControl11.Location = new System.Drawing.Point(40, 210);
            this.editControl11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl11.Name = "editControl11";
            this.editControl11.Request = false;
            this.editControl11.Size = new System.Drawing.Size(279, 26);
            this.editControl11.TabIndex = 7;
            // 
            // editControl12
            // 
            this.editControl12.BackColor = System.Drawing.Color.Transparent;
            this.editControl12.DataField = "F_Fax2";
            this.editControl12.DataSource = null;
            this.editControl12.EditLabel = "传真3:";
            this.editControl12.Location = new System.Drawing.Point(373, 210);
            this.editControl12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl12.Name = "editControl12";
            this.editControl12.Request = false;
            this.editControl12.Size = new System.Drawing.Size(305, 26);
            this.editControl12.TabIndex = 8;
            // 
            // editControl13
            // 
            this.editControl13.BackColor = System.Drawing.Color.Transparent;
            this.editControl13.DataField = "F_TaxID";
            this.editControl13.DataSource = null;
            this.editControl13.EditLabel = "税务编号:";
            this.editControl13.Location = new System.Drawing.Point(16, 100);
            this.editControl13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.editControl13.Name = "editControl13";
            this.editControl13.Request = false;
            this.editControl13.Size = new System.Drawing.Size(489, 26);
            this.editControl13.TabIndex = 2;
            // 
            // frmCompanyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(737, 499);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmCompanyInfo";
            this.Text = "公司信息";
            this.gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.binData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckUse.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private myControl.DateControl dateControl1;
        private myControl.EditControl editControl6;
        private myControl.EditControl editControl5;
        private myControl.EditControl editControl4;
        private myControl.EditControl editControl3;
        private myControl.EditControl editControl2;
        private myControl.EditControl editControl1;
        private DevExpress.XtraEditors.PictureEdit picLogo;
        private DevExpress.XtraEditors.CheckEdit ckUse;
        private myControl.EditControl editControl8;
        private myControl.EditControl editControl7;
        private myControl.EditControl editControl10;
        private myControl.EditControl editControl9;
        private myControl.EditControl editControl13;
        private myControl.EditControl editControl12;
        private myControl.EditControl editControl11;

    }
}
