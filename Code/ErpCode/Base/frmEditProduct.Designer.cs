namespace Base
{
    partial class frmEditProduct
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem1 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem2 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            DevExpress.XtraEditors.Controls.ComboBoxItem comboBoxItem3 = new DevExpress.XtraEditors.Controls.ComboBoxItem();
            this.editControl1 = new myControl.EditControl();
            this.editControl2 = new myControl.EditControl();
            this.lupControl1 = new myControl.lupControl();
            this.editControl9 = new myControl.EditControl();
            this.editControl3 = new myControl.EditControl();
            this.cbControl1 = new myControl.cbControl();
            this.lupControl2 = new myControl.lupControl();
            this.spinControl1 = new myControl.SpinControl();
            this.spinControl2 = new myControl.SpinControl();
            this.spinControl3 = new myControl.SpinControl();
            this.spinControl5 = new myControl.SpinControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.Page1 = new DevExpress.XtraTab.XtraTabPage();
            this.Page2 = new DevExpress.XtraTab.XtraTabPage();
            this.gcUnit = new DevExpress.XtraGrid.GridControl();
            this.binUnit = new System.Windows.Forms.BindingSource(this.components);
            this.gvUnit = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbUnit = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbDel = new DevExpress.XtraEditors.SimpleButton();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.sbClear = new DevExpress.XtraEditors.SimpleButton();
            this.sbLoad = new DevExpress.XtraEditors.SimpleButton();
            this.peItem = new DevExpress.XtraEditors.PictureEdit();
            this.Page4 = new DevExpress.XtraTab.XtraTabPage();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.editControl11 = new myControl.EditControl();
            this.editControl10 = new myControl.EditControl();
            this.editControl8 = new myControl.EditControl();
            this.editControl12 = new myControl.EditControl();
            this.editControl4 = new myControl.EditControl();
            this.spinControl6 = new myControl.SpinControl();
            this.spinControl7 = new myControl.SpinControl();
            this.ckOption = new DevExpress.XtraEditors.CheckEdit();
            this.cbColor = new myControl.cbControl();
            this.spinControl8 = new myControl.SpinControl();
            this.spinControl9 = new myControl.SpinControl();
            this.spinControl10 = new myControl.SpinControl();
            this.spinControl11 = new myControl.SpinControl();
            this.editControl5 = new myControl.EditControl();
            this.editControl6 = new myControl.EditControl();
            this.ckControl1 = new myControl.ckControl();
            this.editControl7 = new myControl.EditControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ckControl2 = new myControl.ckControl();
            this.editControl13 = new myControl.EditControl();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.binData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.Page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).BeginInit();
            this.panel1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peItem.Properties)).BeginInit();
            this.Page4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckOption.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Location = new System.Drawing.Point(547, 446);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(5);
            this.BtnOK.Text = "����(&S)";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("����", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(655, 446);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            // 
            // gbox
            // 
            this.gbox.Controls.Add(this.editControl13);
            this.gbox.Controls.Add(this.ckControl2);
            this.gbox.Controls.Add(this.editControl7);
            this.gbox.Controls.Add(this.ckControl1);
            this.gbox.Controls.Add(this.editControl6);
            this.gbox.Controls.Add(this.editControl5);
            this.gbox.Controls.Add(this.spinControl11);
            this.gbox.Controls.Add(this.spinControl10);
            this.gbox.Controls.Add(this.spinControl9);
            this.gbox.Controls.Add(this.spinControl8);
            this.gbox.Controls.Add(this.cbColor);
            this.gbox.Controls.Add(this.spinControl7);
            this.gbox.Controls.Add(this.spinControl6);
            this.gbox.Controls.Add(this.editControl4);
            this.gbox.Controls.Add(this.spinControl5);
            this.gbox.Controls.Add(this.spinControl3);
            this.gbox.Controls.Add(this.spinControl2);
            this.gbox.Controls.Add(this.spinControl1);
            this.gbox.Controls.Add(this.lupControl2);
            this.gbox.Controls.Add(this.cbControl1);
            this.gbox.Controls.Add(this.editControl3);
            this.gbox.Controls.Add(this.editControl9);
            this.gbox.Controls.Add(this.lupControl1);
            this.gbox.Controls.Add(this.editControl2);
            this.gbox.Controls.Add(this.editControl1);
            this.gbox.Location = new System.Drawing.Point(23, 45);
            this.gbox.Margin = new System.Windows.Forms.Padding(5);
            this.gbox.Padding = new System.Windows.Forms.Padding(5);
            this.gbox.Size = new System.Drawing.Size(732, 388);
            // 
            // ckCopy
            // 
            this.ckCopy.Location = new System.Drawing.Point(173, 451);
            this.ckCopy.Margin = new System.Windows.Forms.Padding(5);
            this.ckCopy.Visible = true;
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.Color.Transparent;
            this.editControl1.DataField = "F_ID";
            this.editControl1.DataSource = null;
            this.editControl1.EditLabel = "��Ʒ����:";
            this.editControl1.Location = new System.Drawing.Point(9, 26);
            this.editControl1.Margin = new System.Windows.Forms.Padding(5);
            this.editControl1.Name = "editControl1";
            this.editControl1.Request = true;
            this.editControl1.Size = new System.Drawing.Size(253, 34);
            this.editControl1.TabIndex = 0;
            // 
            // editControl2
            // 
            this.editControl2.BackColor = System.Drawing.Color.Transparent;
            this.editControl2.DataField = "F_Name";
            this.editControl2.DataSource = null;
            this.editControl2.EditLabel = "��Ʒ����:";
            this.editControl2.Location = new System.Drawing.Point(308, 26);
            this.editControl2.Margin = new System.Windows.Forms.Padding(5);
            this.editControl2.Name = "editControl2";
            this.editControl2.Request = true;
            this.editControl2.Size = new System.Drawing.Size(403, 34);
            this.editControl2.TabIndex = 1;
            // 
            // lupControl1
            // 
            this.lupControl1.BackColor = System.Drawing.Color.Transparent;
            this.lupControl1.DataField = "F_Type";
            this.lupControl1.DataSource = null;
            this.lupControl1.DisplayCaption = "";
            this.lupControl1.DropSQL = "";
            this.lupControl1.EditLabel = "��Ʒ���:";
            this.lupControl1.InvokeClass = "";
            this.lupControl1.LinkFields = null;
            this.lupControl1.Location = new System.Drawing.Point(8, 68);
            this.lupControl1.LookUpDataSource = null;
            this.lupControl1.LookUpDisplayField = null;
            this.lupControl1.LookUpKeyField = null;
            this.lupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.lupControl1.Name = "lupControl1";
            this.lupControl1.PopWidth = 150;
            this.lupControl1.Request = true;
            this.lupControl1.Size = new System.Drawing.Size(253, 28);
            this.lupControl1.TabIndex = 2;
            // 
            // editControl9
            // 
            this.editControl9.BackColor = System.Drawing.Color.Transparent;
            this.editControl9.DataField = "F_Remark";
            this.editControl9.DataSource = null;
            this.editControl9.EditLabel = "��ע:";
            this.editControl9.Location = new System.Drawing.Point(287, 314);
            this.editControl9.Margin = new System.Windows.Forms.Padding(5);
            this.editControl9.Name = "editControl9";
            this.editControl9.Request = false;
            this.editControl9.Size = new System.Drawing.Size(424, 26);
            this.editControl9.TabIndex = 21;
            // 
            // editControl3
            // 
            this.editControl3.BackColor = System.Drawing.Color.Transparent;
            this.editControl3.DataField = "F_Spec";
            this.editControl3.DataSource = null;
            this.editControl3.EditLabel = "���:";
            this.editControl3.Location = new System.Drawing.Point(472, 68);
            this.editControl3.Margin = new System.Windows.Forms.Padding(5);
            this.editControl3.Name = "editControl3";
            this.editControl3.Request = false;
            this.editControl3.Size = new System.Drawing.Size(239, 28);
            this.editControl3.TabIndex = 4;
            // 
            // cbControl1
            // 
            this.cbControl1.BackColor = System.Drawing.Color.Transparent;
            comboBoxItem1.Value = "����Ʒ";
            comboBoxItem2.Value = "���Ʒ";
            comboBoxItem3.Value = "����";
            this.cbControl1.cbItem = new DevExpress.XtraEditors.Controls.ComboBoxItem[] {
        comboBoxItem1,
        comboBoxItem2,
        comboBoxItem3};
            this.cbControl1.DataField = "F_Kind";
            this.cbControl1.DataSource = null;
            this.cbControl1.EditLabel = "��Ʒ����:";
            this.cbControl1.EditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbControl1.Location = new System.Drawing.Point(8, 102);
            this.cbControl1.Margin = new System.Windows.Forms.Padding(5);
            this.cbControl1.Name = "cbControl1";
            this.cbControl1.Request = true;
            this.cbControl1.SelectedIndex = -1;
            this.cbControl1.Size = new System.Drawing.Size(219, 26);
            this.cbControl1.TabIndex = 5;
            // 
            // lupControl2
            // 
            this.lupControl2.BackColor = System.Drawing.Color.Transparent;
            this.lupControl2.DataField = "F_StorageID";
            this.lupControl2.DataSource = null;
            this.lupControl2.DisplayCaption = "";
            this.lupControl2.DropSQL = "";
            this.lupControl2.EditLabel = "Ĭ�ϲֿ�:";
            this.lupControl2.InvokeClass = "";
            this.lupControl2.LinkFields = null;
            this.lupControl2.Location = new System.Drawing.Point(8, 145);
            this.lupControl2.LookUpDataSource = null;
            this.lupControl2.LookUpDisplayField = null;
            this.lupControl2.LookUpKeyField = null;
            this.lupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.lupControl2.Name = "lupControl2";
            this.lupControl2.PopWidth = 150;
            this.lupControl2.Request = false;
            this.lupControl2.Size = new System.Drawing.Size(251, 28);
            this.lupControl2.TabIndex = 8;
            // 
            // spinControl1
            // 
            this.spinControl1.BackColor = System.Drawing.Color.Transparent;
            this.spinControl1.DataField = "F_UpLimit";
            this.spinControl1.DataSource = null;
            this.spinControl1.EditLabel = "�������:";
            this.spinControl1.Location = new System.Drawing.Point(296, 225);
            this.spinControl1.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl1.Name = "spinControl1";
            this.spinControl1.Size = new System.Drawing.Size(173, 26);
            this.spinControl1.TabIndex = 15;
            // 
            // spinControl2
            // 
            this.spinControl2.BackColor = System.Drawing.Color.Transparent;
            this.spinControl2.DataField = "F_DownLimit";
            this.spinControl2.DataSource = null;
            this.spinControl2.EditLabel = "�������:";
            this.spinControl2.Location = new System.Drawing.Point(537, 225);
            this.spinControl2.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl2.Name = "spinControl2";
            this.spinControl2.Size = new System.Drawing.Size(173, 26);
            this.spinControl2.TabIndex = 16;
            // 
            // spinControl3
            // 
            this.spinControl3.BackColor = System.Drawing.Color.Transparent;
            this.spinControl3.DataField = "F_SafeQty";
            this.spinControl3.DataSource = null;
            this.spinControl3.EditLabel = "��ȫ���:";
            this.spinControl3.Location = new System.Drawing.Point(9, 225);
            this.spinControl3.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl3.Name = "spinControl3";
            this.spinControl3.Size = new System.Drawing.Size(191, 26);
            this.spinControl3.TabIndex = 14;
            // 
            // spinControl5
            // 
            this.spinControl5.BackColor = System.Drawing.Color.Transparent;
            this.spinControl5.DataField = "F_SellPrice";
            this.spinControl5.DataSource = null;
            this.spinControl5.EditLabel = "Ĭ���ۼ�:";
            this.spinControl5.Location = new System.Drawing.Point(308, 146);
            this.spinControl5.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl5.Name = "spinControl5";
            this.spinControl5.Size = new System.Drawing.Size(173, 26);
            this.spinControl5.TabIndex = 9;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(16, 15);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.Page1;
            this.xtraTabControl1.Size = new System.Drawing.Size(739, 429);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Page1,
            this.Page2,
            this.xtraTabPage1,
            this.Page4});
            // 
            // Page1
            // 
            this.Page1.Margin = new System.Windows.Forms.Padding(4);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(730, 393);
            this.Page1.Text = "��������";
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.gcUnit);
            this.Page2.Controls.Add(this.panel1);
            this.Page2.Margin = new System.Windows.Forms.Padding(4);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(730, 393);
            this.Page2.Text = "������λ";
            // 
            // gcUnit
            // 
            this.gcUnit.DataSource = this.binUnit;
            this.gcUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUnit.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcUnit.Location = new System.Drawing.Point(0, 0);
            this.gcUnit.MainView = this.gvUnit;
            this.gcUnit.Margin = new System.Windows.Forms.Padding(4);
            this.gcUnit.Name = "gcUnit";
            this.gcUnit.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.cbUnit});
            this.gcUnit.Size = new System.Drawing.Size(730, 352);
            this.gcUnit.TabIndex = 0;
            this.gcUnit.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUnit});
            // 
            // gvUnit
            // 
            this.gvUnit.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvUnit.GridControl = this.gcUnit;
            this.gvUnit.Name = "gvUnit";
            this.gvUnit.OptionsView.ColumnAutoWidth = false;
            this.gvUnit.OptionsView.ShowFooter = true;
            this.gvUnit.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "����λ";
            this.gridColumn1.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn1.FieldName = "F_Main";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 86;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "��λ����";
            this.gridColumn2.ColumnEdit = this.cbUnit;
            this.gridColumn2.FieldName = "F_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 190;
            // 
            // cbUnit
            // 
            this.cbUnit.AutoHeight = false;
            this.cbUnit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbUnit.Name = "cbUnit";
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "����";
            this.gridColumn3.FieldName = "F_Rate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 86;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbDel);
            this.panel1.Controls.Add(this.sbAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 352);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 41);
            this.panel1.TabIndex = 1;
            // 
            // sbDel
            // 
            this.sbDel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbDel.Appearance.Options.UseFont = true;
            this.sbDel.Location = new System.Drawing.Point(101, 5);
            this.sbDel.Margin = new System.Windows.Forms.Padding(4);
            this.sbDel.Name = "sbDel";
            this.sbDel.Size = new System.Drawing.Size(77, 29);
            this.sbDel.TabIndex = 1;
            this.sbDel.Text = "ɾ��(&D)";
            this.sbDel.Click += new System.EventHandler(this.sbDel_Click);
            // 
            // sbAdd
            // 
            this.sbAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAdd.Appearance.Options.UseFont = true;
            this.sbAdd.Location = new System.Drawing.Point(16, 5);
            this.sbAdd.Margin = new System.Windows.Forms.Padding(4);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(77, 29);
            this.sbAdd.TabIndex = 0;
            this.sbAdd.Text = "����(&A)";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.sbClear);
            this.xtraTabPage1.Controls.Add(this.sbLoad);
            this.xtraTabPage1.Controls.Add(this.peItem);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(730, 393);
            this.xtraTabPage1.Text = "ͼƬ";
            // 
            // sbClear
            // 
            this.sbClear.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbClear.Appearance.Options.UseFont = true;
            this.sbClear.Location = new System.Drawing.Point(636, 46);
            this.sbClear.Margin = new System.Windows.Forms.Padding(4);
            this.sbClear.Name = "sbClear";
            this.sbClear.Size = new System.Drawing.Size(80, 29);
            this.sbClear.TabIndex = 2;
            this.sbClear.Text = "���";
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // sbLoad
            // 
            this.sbLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbLoad.Appearance.Options.UseFont = true;
            this.sbLoad.Location = new System.Drawing.Point(636, 10);
            this.sbLoad.Margin = new System.Windows.Forms.Padding(4);
            this.sbLoad.Name = "sbLoad";
            this.sbLoad.Size = new System.Drawing.Size(80, 29);
            this.sbLoad.TabIndex = 1;
            this.sbLoad.Text = "����";
            this.sbLoad.Click += new System.EventHandler(this.sbLoad_Click);
            // 
            // peItem
            // 
            this.peItem.Location = new System.Drawing.Point(17, 10);
            this.peItem.Margin = new System.Windows.Forms.Padding(4);
            this.peItem.Name = "peItem";
            this.peItem.Properties.NullText = " ";
            this.peItem.Size = new System.Drawing.Size(599, 339);
            this.peItem.TabIndex = 0;
            this.peItem.DoubleClick += new System.EventHandler(this.peItem_DoubleClick);
            // 
            // Page4
            // 
            this.Page4.Controls.Add(this.btn4);
            this.Page4.Controls.Add(this.btn3);
            this.Page4.Controls.Add(this.btn2);
            this.Page4.Controls.Add(this.btn1);
            this.Page4.Controls.Add(this.editControl11);
            this.Page4.Controls.Add(this.editControl10);
            this.Page4.Controls.Add(this.editControl8);
            this.Page4.Controls.Add(this.editControl12);
            this.Page4.Margin = new System.Windows.Forms.Padding(4);
            this.Page4.Name = "Page4";
            this.Page4.Size = new System.Drawing.Size(730, 393);
            this.Page4.Text = "����";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(636, 202);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 29);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "...";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(636, 152);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 29);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "...";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(636, 101);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(45, 29);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "...";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(636, 52);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 29);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "...";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // editControl11
            // 
            this.editControl11.BackColor = System.Drawing.Color.Transparent;
            this.editControl11.DataField = "F_File4";
            this.editControl11.DataSource = null;
            this.editControl11.EditLabel = "����4:";
            this.editControl11.Location = new System.Drawing.Point(47, 205);
            this.editControl11.Margin = new System.Windows.Forms.Padding(5);
            this.editControl11.Name = "editControl11";
            this.editControl11.Request = false;
            this.editControl11.Size = new System.Drawing.Size(581, 26);
            this.editControl11.TabIndex = 11;
            // 
            // editControl10
            // 
            this.editControl10.BackColor = System.Drawing.Color.Transparent;
            this.editControl10.DataField = "F_File3";
            this.editControl10.DataSource = null;
            this.editControl10.EditLabel = "����3:";
            this.editControl10.Location = new System.Drawing.Point(47, 152);
            this.editControl10.Margin = new System.Windows.Forms.Padding(5);
            this.editControl10.Name = "editControl10";
            this.editControl10.Request = false;
            this.editControl10.Size = new System.Drawing.Size(581, 26);
            this.editControl10.TabIndex = 10;
            // 
            // editControl8
            // 
            this.editControl8.BackColor = System.Drawing.Color.Transparent;
            this.editControl8.DataField = "F_File2";
            this.editControl8.DataSource = null;
            this.editControl8.EditLabel = "����2:";
            this.editControl8.Location = new System.Drawing.Point(47, 104);
            this.editControl8.Margin = new System.Windows.Forms.Padding(5);
            this.editControl8.Name = "editControl8";
            this.editControl8.Request = false;
            this.editControl8.Size = new System.Drawing.Size(581, 26);
            this.editControl8.TabIndex = 9;
            // 
            // editControl12
            // 
            this.editControl12.BackColor = System.Drawing.Color.Transparent;
            this.editControl12.DataField = "F_File1";
            this.editControl12.DataSource = null;
            this.editControl12.EditLabel = "����1:";
            this.editControl12.Location = new System.Drawing.Point(47, 52);
            this.editControl12.Margin = new System.Windows.Forms.Padding(5);
            this.editControl12.Name = "editControl12";
            this.editControl12.Request = false;
            this.editControl12.Size = new System.Drawing.Size(581, 26);
            this.editControl12.TabIndex = 8;
            // 
            // editControl4
            // 
            this.editControl4.BackColor = System.Drawing.Color.Transparent;
            this.editControl4.DataField = "F_Grade";
            this.editControl4.DataSource = null;
            this.editControl4.EditLabel = "�ȼ�:";
            this.editControl4.Location = new System.Drawing.Point(568, 102);
            this.editControl4.Margin = new System.Windows.Forms.Padding(5);
            this.editControl4.Name = "editControl4";
            this.editControl4.Request = false;
            this.editControl4.Size = new System.Drawing.Size(143, 26);
            this.editControl4.TabIndex = 7;
            // 
            // spinControl6
            // 
            this.spinControl6.BackColor = System.Drawing.Color.Transparent;
            this.spinControl6.DataField = "F_Volume";
            this.spinControl6.DataSource = null;
            this.spinControl6.EditLabel = "���:";
            this.spinControl6.Location = new System.Drawing.Point(45, 269);
            this.spinControl6.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl6.Name = "spinControl6";
            this.spinControl6.Size = new System.Drawing.Size(157, 26);
            this.spinControl6.TabIndex = 17;
            // 
            // spinControl7
            // 
            this.spinControl7.BackColor = System.Drawing.Color.Transparent;
            this.spinControl7.DataField = "F_Weight";
            this.spinControl7.DataSource = null;
            this.spinControl7.EditLabel = "����:";
            this.spinControl7.Location = new System.Drawing.Point(287, 269);
            this.spinControl7.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl7.Name = "spinControl7";
            this.spinControl7.Size = new System.Drawing.Size(144, 26);
            this.spinControl7.TabIndex = 18;
            // 
            // ckOption
            // 
            this.ckOption.EditValue = true;
            this.ckOption.Location = new System.Drawing.Point(31, 451);
            this.ckOption.Margin = new System.Windows.Forms.Padding(4);
            this.ckOption.Name = "ckOption";
            this.ckOption.Properties.Caption = "���������";
            this.ckOption.Size = new System.Drawing.Size(135, 23);
            this.ckOption.TabIndex = 5;
            this.ckOption.CheckedChanged += new System.EventHandler(this.ckOption_CheckedChanged);
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.Color.Transparent;
            this.cbColor.cbItem = null;
            this.cbColor.DataField = "F_Color";
            this.cbColor.DataSource = null;
            this.cbColor.EditLabel = "��ɫ:";
            this.cbColor.EditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbColor.Location = new System.Drawing.Point(341, 102);
            this.cbColor.Margin = new System.Windows.Forms.Padding(5);
            this.cbColor.Name = "cbColor";
            this.cbColor.Request = false;
            this.cbColor.SelectedIndex = -1;
            this.cbColor.Size = new System.Drawing.Size(200, 26);
            this.cbColor.TabIndex = 6;
            // 
            // spinControl8
            // 
            this.spinControl8.BackColor = System.Drawing.Color.Transparent;
            this.spinControl8.DataField = "F_SellPrice1";
            this.spinControl8.DataSource = null;
            this.spinControl8.EditLabel = "�ۼ�1:";
            this.spinControl8.Location = new System.Drawing.Point(555, 145);
            this.spinControl8.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl8.Name = "spinControl8";
            this.spinControl8.Size = new System.Drawing.Size(156, 26);
            this.spinControl8.TabIndex = 10;
            // 
            // spinControl9
            // 
            this.spinControl9.BackColor = System.Drawing.Color.Transparent;
            this.spinControl9.DataField = "F_SellPrice2";
            this.spinControl9.DataSource = null;
            this.spinControl9.EditLabel = "�ۼ�2:";
            this.spinControl9.Location = new System.Drawing.Point(32, 185);
            this.spinControl9.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl9.Name = "spinControl9";
            this.spinControl9.Size = new System.Drawing.Size(171, 26);
            this.spinControl9.TabIndex = 11;
            // 
            // spinControl10
            // 
            this.spinControl10.BackColor = System.Drawing.Color.Transparent;
            this.spinControl10.DataField = "F_SellPrice3";
            this.spinControl10.DataSource = null;
            this.spinControl10.EditLabel = "�ۼ�3:";
            this.spinControl10.Location = new System.Drawing.Point(327, 185);
            this.spinControl10.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl10.Name = "spinControl10";
            this.spinControl10.Size = new System.Drawing.Size(143, 26);
            this.spinControl10.TabIndex = 12;
            // 
            // spinControl11
            // 
            this.spinControl11.BackColor = System.Drawing.Color.Transparent;
            this.spinControl11.DataField = "F_SellPrice4";
            this.spinControl11.DataSource = null;
            this.spinControl11.EditLabel = "�ۼ�4:";
            this.spinControl11.Location = new System.Drawing.Point(555, 185);
            this.spinControl11.Margin = new System.Windows.Forms.Padding(5);
            this.spinControl11.Name = "spinControl11";
            this.spinControl11.Size = new System.Drawing.Size(156, 26);
            this.spinControl11.TabIndex = 13;
            // 
            // editControl5
            // 
            this.editControl5.BackColor = System.Drawing.Color.Transparent;
            this.editControl5.DataField = "F_BarCode";
            this.editControl5.DataSource = null;
            this.editControl5.EditLabel = "����:";
            this.editControl5.Location = new System.Drawing.Point(464, 269);
            this.editControl5.Margin = new System.Windows.Forms.Padding(5);
            this.editControl5.Name = "editControl5";
            this.editControl5.Request = false;
            this.editControl5.Size = new System.Drawing.Size(247, 26);
            this.editControl5.TabIndex = 19;
            // 
            // editControl6
            // 
            this.editControl6.BackColor = System.Drawing.Color.Transparent;
            this.editControl6.DataField = "F_Position";
            this.editControl6.DataSource = null;
            this.editControl6.EditLabel = "���λ��:";
            this.editControl6.Location = new System.Drawing.Point(17, 314);
            this.editControl6.Margin = new System.Windows.Forms.Padding(5);
            this.editControl6.Name = "editControl6";
            this.editControl6.Request = false;
            this.editControl6.Size = new System.Drawing.Size(255, 26);
            this.editControl6.TabIndex = 20;
            // 
            // ckControl1
            // 
            this.ckControl1.BackColor = System.Drawing.Color.Transparent;
            this.ckControl1.DataField = "F_CalStorage";
            this.ckControl1.DataSource = null;
            this.ckControl1.EditLabel = "������";
            this.ckControl1.Location = new System.Drawing.Point(608, 356);
            this.ckControl1.Margin = new System.Windows.Forms.Padding(5);
            this.ckControl1.Name = "ckControl1";
            this.ckControl1.Size = new System.Drawing.Size(103, 24);
            this.ckControl1.TabIndex = 27;
            // 
            // editControl7
            // 
            this.editControl7.BackColor = System.Drawing.Color.Transparent;
            this.editControl7.DataField = "F_Brand";
            this.editControl7.DataSource = null;
            this.editControl7.EditLabel = "Ʒ��:";
            this.editControl7.Location = new System.Drawing.Point(287, 68);
            this.editControl7.Margin = new System.Windows.Forms.Padding(5);
            this.editControl7.Name = "editControl7";
            this.editControl7.Request = false;
            this.editControl7.Size = new System.Drawing.Size(177, 28);
            this.editControl7.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ckControl2
            // 
            this.ckControl2.BackColor = System.Drawing.Color.Transparent;
            this.ckControl2.DataField = "F_OneOut";
            this.ckControl2.DataSource = null;
            this.ckControl2.EditLabel = "һ���Գ���";
            this.ckControl2.Location = new System.Drawing.Point(327, 356);
            this.ckControl2.Margin = new System.Windows.Forms.Padding(5);
            this.ckControl2.Name = "ckControl2";
            this.ckControl2.Size = new System.Drawing.Size(128, 24);
            this.ckControl2.TabIndex = 28;
            // 
            // editControl13
            // 
            this.editControl13.BackColor = System.Drawing.Color.Transparent;
            this.editControl13.DataField = "F_Material";
            this.editControl13.DataSource = null;
            this.editControl13.EditLabel = "����:";
            this.editControl13.Location = new System.Drawing.Point(45, 354);
            this.editControl13.Margin = new System.Windows.Forms.Padding(5);
            this.editControl13.Name = "editControl13";
            this.editControl13.Request = false;
            this.editControl13.Size = new System.Drawing.Size(232, 26);
            this.editControl13.TabIndex = 29;
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(771, 490);
            this.Controls.Add(this.ckOption);
            this.Controls.Add(this.xtraTabControl1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmEditProduct";
            this.Text = "��Ʒ����--�༭";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.Shown += new System.EventHandler(this.frmEditProduct_Shown);
            this.Controls.SetChildIndex(this.ckCopy, 0);
            this.Controls.SetChildIndex(this.BtnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.xtraTabControl1, 0);
            this.Controls.SetChildIndex(this.gbox, 0);
            this.Controls.SetChildIndex(this.ckOption, 0);
            this.gbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.binData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckCopy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.Page2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peItem.Properties)).EndInit();
            this.Page4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckOption.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabPage Page1;
        private DevExpress.XtraTab.XtraTabPage Page2;
        private DevExpress.XtraGrid.GridControl gcUnit;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUnit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.BindingSource binUnit;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbDel;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.PictureEdit peItem;
        private DevExpress.XtraEditors.SimpleButton sbClear;
        private DevExpress.XtraEditors.SimpleButton sbLoad;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbUnit;
        private DevExpress.XtraTab.XtraTabPage Page4;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private myControl.EditControl editControl11;
        private myControl.EditControl editControl10;
        private myControl.EditControl editControl8;
        private myControl.EditControl editControl12;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public myControl.EditControl editControl1;
        public myControl.EditControl editControl2;
        public myControl.lupControl lupControl1;
        public myControl.EditControl editControl9;
        public myControl.EditControl editControl3;
        public myControl.cbControl cbControl1;
        public myControl.lupControl lupControl2;
        public myControl.SpinControl spinControl3;
        public myControl.SpinControl spinControl2;
        public myControl.SpinControl spinControl1;
        public myControl.SpinControl spinControl5;
        public myControl.EditControl editControl4;
        public myControl.SpinControl spinControl6;
        public myControl.SpinControl spinControl7;
        public DevExpress.XtraEditors.CheckEdit ckOption;
        public myControl.cbControl cbColor;
        public myControl.SpinControl spinControl11;
        public myControl.SpinControl spinControl10;
        public myControl.SpinControl spinControl9;
        public myControl.SpinControl spinControl8;
        public myControl.EditControl editControl5;
        public myControl.EditControl editControl6;
        public myControl.ckControl ckControl1;
        public myControl.EditControl editControl7;
        public myControl.ckControl ckControl2;
        public myControl.EditControl editControl13;
        public DevExpress.XtraTab.XtraTabControl xtraTabControl1;

    }
}