namespace Stock
{
    partial class frmMRP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRP));
            this.TabControl = new DevExpress.XtraTab.XtraTabControl();
            this.PageWelcom = new DevExpress.XtraTab.XtraTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.pcFlag = new System.Windows.Forms.PictureBox();
            this.PageSelect = new DevExpress.XtraTab.XtraTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNeed = new System.Windows.Forms.RadioButton();
            this.rbTask = new System.Windows.Forms.RadioButton();
            this.rbSellOrder = new System.Windows.Forms.RadioButton();
            this.PageSellOrder = new DevExpress.XtraTab.XtraTabPage();
            this.cbSelAll2 = new System.Windows.Forms.CheckBox();
            this.cbSelAll1 = new System.Windows.Forms.CheckBox();
            this.ckNewZero = new System.Windows.Forms.CheckBox();
            this.ckSellNoOut = new System.Windows.Forms.CheckBox();
            this.ckStore = new System.Windows.Forms.CheckBox();
            this.sbRemove = new DevExpress.XtraEditors.SimpleButton();
            this.sbAdd = new DevExpress.XtraEditors.SimpleButton();
            this.gcTmp = new DevExpress.XtraGrid.GridControl();
            this.gvTmp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucDate = new myControl.ucDate();
            this.gcSellOrderMain = new DevExpress.XtraGrid.GridControl();
            this.gvSellOrderMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PageTask = new DevExpress.XtraTab.XtraTabPage();
            this.sbRemoveTask = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddTask = new DevExpress.XtraEditors.SimpleButton();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.gcTaskTmp = new DevExpress.XtraGrid.GridControl();
            this.gvTaskTmp = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn32 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn33 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn34 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn35 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn36 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn37 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn38 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTaskMain = new DevExpress.XtraGrid.GridControl();
            this.gvTaskMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn25 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn28 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn29 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn30 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.ucTask = new myControl.ucDate();
            this.PageNeed = new DevExpress.XtraTab.XtraTabPage();
            this.gcItem = new DevExpress.XtraGrid.GridControl();
            this.gvItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn24 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn26 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn41 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn43 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn44 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddRow = new DevExpress.XtraEditors.SimpleButton();
            this.PageResult = new DevExpress.XtraTab.XtraTabPage();
            this.sbExport = new DevExpress.XtraEditors.SimpleButton();
            this.ckTask = new DevExpress.XtraEditors.CheckEdit();
            this.ckStock = new DevExpress.XtraEditors.CheckEdit();
            this.sbPreview = new DevExpress.XtraEditors.SimpleButton();
            this.sbPrint = new DevExpress.XtraEditors.SimpleButton();
            this.sbGen = new DevExpress.XtraEditors.SimpleButton();
            this.gcResult = new DevExpress.XtraGrid.GridControl();
            this.gvResult = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn39 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn40 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn42 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn45 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn47 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn48 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn46 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn49 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn50 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sbPre = new DevExpress.XtraEditors.SimpleButton();
            this.sbNext = new DevExpress.XtraEditors.SimpleButton();
            this.sbClose = new DevExpress.XtraEditors.SimpleButton();
            this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.printableComponentLink1 = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.PageWelcom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFlag)).BeginInit();
            this.PageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.PageSellOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSellOrderMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellOrderMain)).BeginInit();
            this.PageTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaskTmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskTmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaskMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.PageNeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).BeginInit();
            this.PageResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckTask.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Location = new System.Drawing.Point(17, 15);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedTabPage = this.PageWelcom;
            this.TabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.TabControl.Size = new System.Drawing.Size(971, 566);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageWelcom,
            this.PageSelect,
            this.PageSellOrder,
            this.PageTask,
            this.PageNeed,
            this.PageResult});
            this.TabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControl_SelectedPageChanged);
            // 
            // PageWelcom
            // 
            this.PageWelcom.Controls.Add(this.label1);
            this.PageWelcom.Controls.Add(this.pcFlag);
            this.PageWelcom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageWelcom.Name = "PageWelcom";
            this.PageWelcom.Size = new System.Drawing.Size(962, 557);
            this.PageWelcom.Text = "��ӭ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(279, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "��ӭʹ������MRP�����򵼣��������������򵼷�ʽ�������MRP������������,������һ����ʼMRP���������á�";
            // 
            // pcFlag
            // 
            this.pcFlag.Image = ((System.Drawing.Image)(resources.GetObject("pcFlag.Image")));
            this.pcFlag.Location = new System.Drawing.Point(43, 89);
            this.pcFlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcFlag.Name = "pcFlag";
            this.pcFlag.Size = new System.Drawing.Size(119, 209);
            this.pcFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcFlag.TabIndex = 1;
            this.pcFlag.TabStop = false;
            // 
            // PageSelect
            // 
            this.PageSelect.Controls.Add(this.pictureBox1);
            this.PageSelect.Controls.Add(this.groupBox1);
            this.PageSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageSelect.Name = "PageSelect";
            this.PageSelect.Size = new System.Drawing.Size(962, 557);
            this.PageSelect.Text = "��ʽѡ��";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNeed);
            this.groupBox1.Controls.Add(this.rbTask);
            this.groupBox1.Controls.Add(this.rbSellOrder);
            this.groupBox1.Location = new System.Drawing.Point(297, 130);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(459, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "��������Զ��ѡ��";
            // 
            // rbNeed
            // 
            this.rbNeed.AutoSize = true;
            this.rbNeed.Location = new System.Drawing.Point(45, 109);
            this.rbNeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNeed.Name = "rbNeed";
            this.rbNeed.Size = new System.Drawing.Size(118, 19);
            this.rbNeed.TabIndex = 2;
            this.rbNeed.Text = "������������";
            this.rbNeed.UseVisualStyleBackColor = true;
            // 
            // rbTask
            // 
            this.rbTask.AutoSize = true;
            this.rbTask.Location = new System.Drawing.Point(45, 66);
            this.rbTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTask.Name = "rbTask";
            this.rbTask.Size = new System.Drawing.Size(133, 19);
            this.rbTask.TabIndex = 1;
            this.rbTask.Text = "������������";
            this.rbTask.UseVisualStyleBackColor = true;
            // 
            // rbSellOrder
            // 
            this.rbSellOrder.AutoSize = true;
            this.rbSellOrder.Checked = true;
            this.rbSellOrder.Location = new System.Drawing.Point(45, 26);
            this.rbSellOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSellOrder.Name = "rbSellOrder";
            this.rbSellOrder.Size = new System.Drawing.Size(118, 19);
            this.rbSellOrder.TabIndex = 0;
            this.rbSellOrder.TabStop = true;
            this.rbSellOrder.Text = "���ݿͻ�����";
            this.rbSellOrder.UseVisualStyleBackColor = true;
            // 
            // PageSellOrder
            // 
            this.PageSellOrder.Controls.Add(this.cbSelAll2);
            this.PageSellOrder.Controls.Add(this.cbSelAll1);
            this.PageSellOrder.Controls.Add(this.ckNewZero);
            this.PageSellOrder.Controls.Add(this.ckSellNoOut);
            this.PageSellOrder.Controls.Add(this.ckStore);
            this.PageSellOrder.Controls.Add(this.sbRemove);
            this.PageSellOrder.Controls.Add(this.sbAdd);
            this.PageSellOrder.Controls.Add(this.gcTmp);
            this.PageSellOrder.Controls.Add(this.panelControl1);
            this.PageSellOrder.Controls.Add(this.gcSellOrderMain);
            this.PageSellOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageSellOrder.Name = "PageSellOrder";
            this.PageSellOrder.Size = new System.Drawing.Size(962, 557);
            this.PageSellOrder.Text = "������";
            // 
            // cbSelAll2
            // 
            this.cbSelAll2.AutoSize = true;
            this.cbSelAll2.Location = new System.Drawing.Point(4, 535);
            this.cbSelAll2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelAll2.Name = "cbSelAll2";
            this.cbSelAll2.Size = new System.Drawing.Size(59, 19);
            this.cbSelAll2.TabIndex = 9;
            this.cbSelAll2.Text = "ȫѡ";
            this.cbSelAll2.UseVisualStyleBackColor = true;
            this.cbSelAll2.CheckedChanged += new System.EventHandler(this.cbSelAll2_CheckedChanged);
            // 
            // cbSelAll1
            // 
            this.cbSelAll1.AutoSize = true;
            this.cbSelAll1.Location = new System.Drawing.Point(9, 250);
            this.cbSelAll1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelAll1.Name = "cbSelAll1";
            this.cbSelAll1.Size = new System.Drawing.Size(59, 19);
            this.cbSelAll1.TabIndex = 8;
            this.cbSelAll1.Text = "ȫѡ";
            this.cbSelAll1.UseVisualStyleBackColor = true;
            this.cbSelAll1.CheckedChanged += new System.EventHandler(this.cbSelAll1_CheckedChanged);
            // 
            // ckNewZero
            // 
            this.ckNewZero.AutoSize = true;
            this.ckNewZero.Location = new System.Drawing.Point(389, 250);
            this.ckNewZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckNewZero.Name = "ckNewZero";
            this.ckNewZero.Size = new System.Drawing.Size(127, 19);
            this.ckNewZero.TabIndex = 7;
            this.ckNewZero.Text = "������������0";
            this.ckNewZero.UseVisualStyleBackColor = true;
            this.ckNewZero.CheckedChanged += new System.EventHandler(this.ckNewZero_CheckedChanged);
            // 
            // ckSellNoOut
            // 
            this.ckSellNoOut.AutoSize = true;
            this.ckSellNoOut.Location = new System.Drawing.Point(269, 250);
            this.ckSellNoOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckSellNoOut.Name = "ckSellNoOut";
            this.ckSellNoOut.Size = new System.Drawing.Size(104, 19);
            this.ckSellNoOut.TabIndex = 6;
            this.ckSellNoOut.Text = "�ܶ�δ����";
            this.ckSellNoOut.UseVisualStyleBackColor = true;
            this.ckSellNoOut.Visible = false;
            // 
            // ckStore
            // 
            this.ckStore.AutoSize = true;
            this.ckStore.Location = new System.Drawing.Point(181, 250);
            this.ckStore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckStore.Name = "ckStore";
            this.ckStore.Size = new System.Drawing.Size(74, 19);
            this.ckStore.TabIndex = 5;
            this.ckStore.Text = "�����";
            this.ckStore.UseVisualStyleBackColor = true;
            this.ckStore.Visible = false;
            // 
            // sbRemove
            // 
            this.sbRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbRemove.Appearance.Options.UseFont = true;
            this.sbRemove.Location = new System.Drawing.Point(868, 248);
            this.sbRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbRemove.Name = "sbRemove";
            this.sbRemove.Size = new System.Drawing.Size(80, 29);
            this.sbRemove.TabIndex = 4;
            this.sbRemove.Text = "�Ƴ�(&D)";
            this.sbRemove.Click += new System.EventHandler(this.sbRemove_Click);
            // 
            // sbAdd
            // 
            this.sbAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAdd.Appearance.Options.UseFont = true;
            this.sbAdd.Location = new System.Drawing.Point(780, 248);
            this.sbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbAdd.Name = "sbAdd";
            this.sbAdd.Size = new System.Drawing.Size(80, 29);
            this.sbAdd.TabIndex = 3;
            this.sbAdd.Text = "����(&A)";
            this.sbAdd.Click += new System.EventHandler(this.sbAdd_Click);
            // 
            // gcTmp
            // 
            this.gcTmp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTmp.Location = new System.Drawing.Point(4, 278);
            this.gcTmp.MainView = this.gvTmp;
            this.gcTmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTmp.Name = "gcTmp";
            this.gcTmp.Size = new System.Drawing.Size(955, 250);
            this.gcTmp.TabIndex = 2;
            this.gcTmp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTmp});
            // 
            // gvTmp
            // 
            this.gvTmp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15,
            this.gridColumn16,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20});
            this.gvTmp.GridControl = this.gcTmp;
            this.gvTmp.Name = "gvTmp";
            this.gvTmp.OptionsCustomization.AllowFilter = false;
            this.gvTmp.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTmp.OptionsView.ShowGroupPanel = false;
            this.gvTmp.OptionsView.ShowIndicator = false;
            // 
            // gridColumn11
            // 
            this.gridColumn11.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn11.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn11.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn11.Caption = "ѡ��";
            this.gridColumn11.FieldName = "F_Select";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            this.gridColumn11.Width = 39;
            // 
            // gridColumn12
            // 
            this.gridColumn12.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn12.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn12.Caption = "���";
            this.gridColumn12.FieldName = "Aid";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            this.gridColumn12.Width = 38;
            // 
            // gridColumn13
            // 
            this.gridColumn13.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn13.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn13.Caption = "��������";
            this.gridColumn13.FieldName = "F_BillID";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.OptionsColumn.AllowEdit = false;
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 70;
            // 
            // gridColumn14
            // 
            this.gridColumn14.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn14.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn14.Caption = "��Ʒ����";
            this.gridColumn14.FieldName = "F_ItemID";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.OptionsColumn.AllowEdit = false;
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            // 
            // gridColumn15
            // 
            this.gridColumn15.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn15.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn15.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn15.Caption = "��Ʒ����";
            this.gridColumn15.FieldName = "F_ItemName";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 105;
            // 
            // gridColumn16
            // 
            this.gridColumn16.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn16.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn16.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn16.Caption = "���";
            this.gridColumn16.FieldName = "F_Spec";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 5;
            // 
            // gridColumn17
            // 
            this.gridColumn17.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn17.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn17.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn17.Caption = "��λ";
            this.gridColumn17.FieldName = "F_Unit";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 6;
            this.gridColumn17.Width = 39;
            // 
            // gridColumn18
            // 
            this.gridColumn18.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn18.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn18.Caption = "����";
            this.gridColumn18.FieldName = "F_Qty";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 7;
            this.gridColumn18.Width = 59;
            // 
            // gridColumn19
            // 
            this.gridColumn19.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn19.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn19.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn19.Caption = "���ÿ��";
            this.gridColumn19.FieldName = "F_EvaQty";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 8;
            this.gridColumn19.Width = 64;
            // 
            // gridColumn20
            // 
            this.gridColumn20.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn20.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn20.Caption = "������";
            this.gridColumn20.FieldName = "F_NeedQty";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 9;
            this.gridColumn20.Width = 54;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucDate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(962, 36);
            this.panelControl1.TabIndex = 1;
            // 
            // ucDate
            // 
            this.ucDate.DateTag = myControl.DateFlag.����;
            this.ucDate.Location = new System.Drawing.Point(9, 0);
            this.ucDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucDate.Name = "ucDate";
            this.ucDate.Size = new System.Drawing.Size(529, 32);
            this.ucDate.TabIndex = 0;
            this.ucDate.RefreshDateChanged += new myControl.RefreshDateEventHandler(this.ucDate_RefreshDateChanged);
            // 
            // gcSellOrderMain
            // 
            this.gcSellOrderMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSellOrderMain.Location = new System.Drawing.Point(4, 40);
            this.gcSellOrderMain.MainView = this.gvSellOrderMain;
            this.gcSellOrderMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcSellOrderMain.Name = "gcSellOrderMain";
            this.gcSellOrderMain.Size = new System.Drawing.Size(955, 202);
            this.gcSellOrderMain.TabIndex = 0;
            this.gcSellOrderMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSellOrderMain});
            // 
            // gvSellOrderMain
            // 
            this.gvSellOrderMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn10,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvSellOrderMain.GridControl = this.gcSellOrderMain;
            this.gvSellOrderMain.Name = "gvSellOrderMain";
            this.gvSellOrderMain.OptionsCustomization.AllowFilter = false;
            this.gvSellOrderMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSellOrderMain.OptionsView.ShowGroupPanel = false;
            this.gvSellOrderMain.OptionsView.ShowIndicator = false;
            // 
            // gridColumn10
            // 
            this.gridColumn10.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn10.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn10.Caption = "ѡ��";
            this.gridColumn10.FieldName = "F_Select";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 34;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn1.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn1.Caption = "���ݱ��";
            this.gridColumn1.FieldName = "F_BillID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn2.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn2.Caption = "��������";
            this.gridColumn2.FieldName = "F_Date";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn3.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn3.Caption = "�ͻ�";
            this.gridColumn3.FieldName = "F_Client";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 124;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn4.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn4.Caption = "����";
            this.gridColumn4.FieldName = "F_Dept";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn5.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn5.Caption = "ҵ��Ա";
            this.gridColumn5.FieldName = "F_Opertor";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn6.Caption = "��������";
            this.gridColumn6.FieldName = "F_SendDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn7.Caption = "������";
            this.gridColumn7.FieldName = "F_BillMan";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn8.Caption = "�����";
            this.gridColumn8.FieldName = "F_CheckMan";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            // 
            // gridColumn9
            // 
            this.gridColumn9.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn9.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn9.Caption = "�������";
            this.gridColumn9.FieldName = "F_CheckDate";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            // 
            // PageTask
            // 
            this.PageTask.Controls.Add(this.sbRemoveTask);
            this.PageTask.Controls.Add(this.sbAddTask);
            this.PageTask.Controls.Add(this.checkBox5);
            this.PageTask.Controls.Add(this.checkBox4);
            this.PageTask.Controls.Add(this.gcTaskTmp);
            this.PageTask.Controls.Add(this.gcTaskMain);
            this.PageTask.Controls.Add(this.panelControl2);
            this.PageTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageTask.Name = "PageTask";
            this.PageTask.Size = new System.Drawing.Size(962, 557);
            this.PageTask.Text = "������";
            // 
            // sbRemoveTask
            // 
            this.sbRemoveTask.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbRemoveTask.Appearance.Options.UseFont = true;
            this.sbRemoveTask.Location = new System.Drawing.Point(879, 231);
            this.sbRemoveTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbRemoveTask.Name = "sbRemoveTask";
            this.sbRemoveTask.Size = new System.Drawing.Size(80, 29);
            this.sbRemoveTask.TabIndex = 12;
            this.sbRemoveTask.Text = "�Ƴ�(&D)";
            // 
            // sbAddTask
            // 
            this.sbAddTask.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAddTask.Appearance.Options.UseFont = true;
            this.sbAddTask.Location = new System.Drawing.Point(791, 231);
            this.sbAddTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbAddTask.Name = "sbAddTask";
            this.sbAddTask.Size = new System.Drawing.Size(80, 29);
            this.sbAddTask.TabIndex = 11;
            this.sbAddTask.Text = "����(&A)";
            this.sbAddTask.Click += new System.EventHandler(this.sbAddTask_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(4, 535);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(59, 19);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "ȫѡ";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 236);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(59, 19);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "ȫѡ";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // gcTaskTmp
            // 
            this.gcTaskTmp.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaskTmp.Location = new System.Drawing.Point(4, 264);
            this.gcTaskTmp.MainView = this.gvTaskTmp;
            this.gcTaskTmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaskTmp.Name = "gcTaskTmp";
            this.gcTaskTmp.Size = new System.Drawing.Size(955, 264);
            this.gcTaskTmp.TabIndex = 4;
            this.gcTaskTmp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaskTmp});
            // 
            // gvTaskTmp
            // 
            this.gvTaskTmp.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn31,
            this.gridColumn32,
            this.gridColumn33,
            this.gridColumn34,
            this.gridColumn35,
            this.gridColumn36,
            this.gridColumn37,
            this.gridColumn38});
            this.gvTaskTmp.GridControl = this.gcTaskTmp;
            this.gvTaskTmp.Name = "gvTaskTmp";
            this.gvTaskTmp.OptionsCustomization.AllowFilter = false;
            this.gvTaskTmp.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTaskTmp.OptionsView.ColumnAutoWidth = false;
            this.gvTaskTmp.OptionsView.ShowGroupPanel = false;
            this.gvTaskTmp.OptionsView.ShowIndicator = false;
            // 
            // gridColumn31
            // 
            this.gridColumn31.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn31.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn31.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn31.Caption = "ѡ��";
            this.gridColumn31.FieldName = "F_Select";
            this.gridColumn31.Name = "gridColumn31";
            this.gridColumn31.OptionsColumn.AllowEdit = false;
            this.gridColumn31.Visible = true;
            this.gridColumn31.VisibleIndex = 0;
            this.gridColumn31.Width = 43;
            // 
            // gridColumn32
            // 
            this.gridColumn32.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn32.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn32.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn32.Caption = "���";
            this.gridColumn32.FieldName = "Aid";
            this.gridColumn32.Name = "gridColumn32";
            this.gridColumn32.OptionsColumn.AllowEdit = false;
            this.gridColumn32.Visible = true;
            this.gridColumn32.VisibleIndex = 1;
            this.gridColumn32.Width = 43;
            // 
            // gridColumn33
            // 
            this.gridColumn33.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn33.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn33.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn33.Caption = "���񵥺�";
            this.gridColumn33.FieldName = "F_BillID";
            this.gridColumn33.Name = "gridColumn33";
            this.gridColumn33.OptionsColumn.AllowEdit = false;
            this.gridColumn33.Visible = true;
            this.gridColumn33.VisibleIndex = 2;
            this.gridColumn33.Width = 95;
            // 
            // gridColumn34
            // 
            this.gridColumn34.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn34.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn34.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn34.Caption = "��Ʒ����";
            this.gridColumn34.FieldName = "F_ItemID";
            this.gridColumn34.Name = "gridColumn34";
            this.gridColumn34.OptionsColumn.AllowEdit = false;
            this.gridColumn34.Visible = true;
            this.gridColumn34.VisibleIndex = 3;
            // 
            // gridColumn35
            // 
            this.gridColumn35.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn35.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn35.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn35.Caption = "��Ʒ����";
            this.gridColumn35.FieldName = "F_ItemName";
            this.gridColumn35.Name = "gridColumn35";
            this.gridColumn35.OptionsColumn.AllowEdit = false;
            this.gridColumn35.Visible = true;
            this.gridColumn35.VisibleIndex = 4;
            this.gridColumn35.Width = 142;
            // 
            // gridColumn36
            // 
            this.gridColumn36.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn36.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn36.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn36.Caption = "���";
            this.gridColumn36.FieldName = "F_Spec";
            this.gridColumn36.Name = "gridColumn36";
            this.gridColumn36.OptionsColumn.AllowEdit = false;
            this.gridColumn36.Visible = true;
            this.gridColumn36.VisibleIndex = 5;
            this.gridColumn36.Width = 97;
            // 
            // gridColumn37
            // 
            this.gridColumn37.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn37.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn37.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn37.Caption = "��λ";
            this.gridColumn37.FieldName = "F_Unit";
            this.gridColumn37.Name = "gridColumn37";
            this.gridColumn37.OptionsColumn.AllowEdit = false;
            this.gridColumn37.Visible = true;
            this.gridColumn37.VisibleIndex = 6;
            this.gridColumn37.Width = 39;
            // 
            // gridColumn38
            // 
            this.gridColumn38.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn38.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn38.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn38.Caption = "����";
            this.gridColumn38.FieldName = "F_Qty";
            this.gridColumn38.Name = "gridColumn38";
            this.gridColumn38.Visible = true;
            this.gridColumn38.VisibleIndex = 7;
            this.gridColumn38.Width = 54;
            // 
            // gcTaskMain
            // 
            this.gcTaskMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaskMain.Location = new System.Drawing.Point(4, 40);
            this.gcTaskMain.MainView = this.gvTaskMain;
            this.gcTaskMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcTaskMain.Name = "gcTaskMain";
            this.gcTaskMain.Size = new System.Drawing.Size(955, 189);
            this.gcTaskMain.TabIndex = 3;
            this.gcTaskMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTaskMain});
            // 
            // gvTaskMain
            // 
            this.gvTaskMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn21,
            this.gridColumn22,
            this.gridColumn23,
            this.gridColumn25,
            this.gridColumn28,
            this.gridColumn29,
            this.gridColumn30});
            this.gvTaskMain.GridControl = this.gcTaskMain;
            this.gvTaskMain.Name = "gvTaskMain";
            this.gvTaskMain.OptionsCustomization.AllowFilter = false;
            this.gvTaskMain.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTaskMain.OptionsView.ColumnAutoWidth = false;
            this.gvTaskMain.OptionsView.ShowGroupPanel = false;
            this.gvTaskMain.OptionsView.ShowIndicator = false;
            // 
            // gridColumn21
            // 
            this.gridColumn21.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn21.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn21.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn21.Caption = "ѡ��";
            this.gridColumn21.FieldName = "F_Select";
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.Visible = true;
            this.gridColumn21.VisibleIndex = 0;
            this.gridColumn21.Width = 34;
            // 
            // gridColumn22
            // 
            this.gridColumn22.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn22.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn22.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn22.Caption = "���ݱ��";
            this.gridColumn22.FieldName = "F_BillID";
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 1;
            // 
            // gridColumn23
            // 
            this.gridColumn23.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn23.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn23.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn23.Caption = "��������";
            this.gridColumn23.FieldName = "F_Date";
            this.gridColumn23.Name = "gridColumn23";
            this.gridColumn23.OptionsColumn.AllowEdit = false;
            this.gridColumn23.Visible = true;
            this.gridColumn23.VisibleIndex = 2;
            this.gridColumn23.Width = 97;
            // 
            // gridColumn25
            // 
            this.gridColumn25.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn25.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn25.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn25.Caption = "����";
            this.gridColumn25.FieldName = "F_Dept";
            this.gridColumn25.Name = "gridColumn25";
            this.gridColumn25.OptionsColumn.AllowEdit = false;
            this.gridColumn25.Visible = true;
            this.gridColumn25.VisibleIndex = 3;
            this.gridColumn25.Width = 114;
            // 
            // gridColumn28
            // 
            this.gridColumn28.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn28.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn28.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn28.Caption = "������";
            this.gridColumn28.FieldName = "F_BillMan";
            this.gridColumn28.Name = "gridColumn28";
            this.gridColumn28.OptionsColumn.AllowEdit = false;
            this.gridColumn28.Visible = true;
            this.gridColumn28.VisibleIndex = 4;
            // 
            // gridColumn29
            // 
            this.gridColumn29.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn29.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn29.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn29.Caption = "�����";
            this.gridColumn29.FieldName = "F_CheckMan";
            this.gridColumn29.Name = "gridColumn29";
            this.gridColumn29.OptionsColumn.AllowEdit = false;
            this.gridColumn29.Visible = true;
            this.gridColumn29.VisibleIndex = 5;
            this.gridColumn29.Width = 87;
            // 
            // gridColumn30
            // 
            this.gridColumn30.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn30.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn30.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn30.Caption = "�������";
            this.gridColumn30.FieldName = "F_CheckDate";
            this.gridColumn30.Name = "gridColumn30";
            this.gridColumn30.OptionsColumn.AllowEdit = false;
            this.gridColumn30.Visible = true;
            this.gridColumn30.VisibleIndex = 6;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.ucTask);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(962, 36);
            this.panelControl2.TabIndex = 2;
            // 
            // ucTask
            // 
            this.ucTask.DateTag = myControl.DateFlag.����;
            this.ucTask.Location = new System.Drawing.Point(9, 0);
            this.ucTask.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ucTask.Name = "ucTask";
            this.ucTask.Size = new System.Drawing.Size(529, 32);
            this.ucTask.TabIndex = 0;
            this.ucTask.RefreshDateChanged += new myControl.RefreshDateEventHandler(this.ucTask_RefreshDateChanged);
            // 
            // PageNeed
            // 
            this.PageNeed.Controls.Add(this.gcItem);
            this.PageNeed.Controls.Add(this.simpleButton7);
            this.PageNeed.Controls.Add(this.simpleButton6);
            this.PageNeed.Controls.Add(this.sbAddRow);
            this.PageNeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageNeed.Name = "PageNeed";
            this.PageNeed.Size = new System.Drawing.Size(962, 557);
            this.PageNeed.Text = "������";
            // 
            // gcItem
            // 
            this.gcItem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcItem.Location = new System.Drawing.Point(4, 4);
            this.gcItem.MainView = this.gvItem;
            this.gcItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcItem.Name = "gcItem";
            this.gcItem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ItemButtonEdit});
            this.gcItem.Size = new System.Drawing.Size(955, 515);
            this.gcItem.TabIndex = 0;
            this.gcItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItem});
            // 
            // gvItem
            // 
            this.gvItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn24,
            this.gridColumn26,
            this.gridColumn27,
            this.gridColumn41,
            this.gridColumn43,
            this.gridColumn44});
            this.gvItem.GridControl = this.gcItem;
            this.gvItem.Name = "gvItem";
            this.gvItem.OptionsCustomization.AllowFilter = false;
            this.gvItem.OptionsView.ColumnAutoWidth = false;
            this.gvItem.OptionsView.ShowFooter = true;
            this.gvItem.OptionsView.ShowGroupPanel = false;
            this.gvItem.OptionsView.ShowIndicator = false;
            this.gvItem.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvItem_InitNewRow);
            // 
            // gridColumn24
            // 
            this.gridColumn24.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn24.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn24.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn24.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn24.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn24.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn24.Caption = "���";
            this.gridColumn24.FieldName = "Aid";
            this.gridColumn24.Name = "gridColumn24";
            this.gridColumn24.OptionsColumn.AllowEdit = false;
            this.gridColumn24.Visible = true;
            this.gridColumn24.VisibleIndex = 0;
            this.gridColumn24.Width = 43;
            // 
            // gridColumn26
            // 
            this.gridColumn26.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn26.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn26.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn26.Caption = "��Ʒ����";
            this.gridColumn26.ColumnEdit = this.ItemButtonEdit;
            this.gridColumn26.FieldName = "F_ItemID";
            this.gridColumn26.Name = "gridColumn26";
            this.gridColumn26.Visible = true;
            this.gridColumn26.VisibleIndex = 1;
            this.gridColumn26.Width = 83;
            // 
            // ItemButtonEdit
            // 
            this.ItemButtonEdit.AutoHeight = false;
            this.ItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ItemButtonEdit.Name = "ItemButtonEdit";
            this.ItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ItemButtonEdit_ButtonClick);
            // 
            // gridColumn27
            // 
            this.gridColumn27.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn27.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn27.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn27.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn27.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn27.Caption = "��Ʒ����";
            this.gridColumn27.FieldName = "F_ItemName";
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.OptionsColumn.AllowEdit = false;
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 2;
            this.gridColumn27.Width = 199;
            // 
            // gridColumn41
            // 
            this.gridColumn41.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn41.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn41.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn41.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn41.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn41.Caption = "���";
            this.gridColumn41.FieldName = "F_Spec";
            this.gridColumn41.Name = "gridColumn41";
            this.gridColumn41.OptionsColumn.AllowEdit = false;
            this.gridColumn41.Visible = true;
            this.gridColumn41.VisibleIndex = 3;
            this.gridColumn41.Width = 99;
            // 
            // gridColumn43
            // 
            this.gridColumn43.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumn43.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn43.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn43.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn43.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn43.Caption = "��λ";
            this.gridColumn43.FieldName = "F_Unit";
            this.gridColumn43.Name = "gridColumn43";
            this.gridColumn43.OptionsColumn.AllowEdit = false;
            this.gridColumn43.Visible = true;
            this.gridColumn43.VisibleIndex = 4;
            this.gridColumn43.Width = 41;
            // 
            // gridColumn44
            // 
            this.gridColumn44.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn44.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn44.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn44.Caption = "������";
            this.gridColumn44.FieldName = "F_Qty";
            this.gridColumn44.Name = "gridColumn44";
            this.gridColumn44.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.gridColumn44.Visible = true;
            this.gridColumn44.VisibleIndex = 5;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(859, 526);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(100, 29);
            this.simpleButton7.TabIndex = 3;
            this.simpleButton7.Text = "ȫ��ɾ��";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(751, 526);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(100, 29);
            this.simpleButton6.TabIndex = 2;
            this.simpleButton6.Text = "ɾ��(&D)";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // sbAddRow
            // 
            this.sbAddRow.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbAddRow.Appearance.Options.UseFont = true;
            this.sbAddRow.Location = new System.Drawing.Point(643, 526);
            this.sbAddRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbAddRow.Name = "sbAddRow";
            this.sbAddRow.Size = new System.Drawing.Size(100, 29);
            this.sbAddRow.TabIndex = 1;
            this.sbAddRow.Text = "����(&A)";
            this.sbAddRow.Click += new System.EventHandler(this.sbAddRow_Click);
            // 
            // PageResult
            // 
            this.PageResult.Controls.Add(this.sbExport);
            this.PageResult.Controls.Add(this.ckTask);
            this.PageResult.Controls.Add(this.ckStock);
            this.PageResult.Controls.Add(this.sbPreview);
            this.PageResult.Controls.Add(this.sbPrint);
            this.PageResult.Controls.Add(this.sbGen);
            this.PageResult.Controls.Add(this.gcResult);
            this.PageResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PageResult.Name = "PageResult";
            this.PageResult.Size = new System.Drawing.Size(962, 557);
            this.PageResult.Text = "������";
            // 
            // sbExport
            // 
            this.sbExport.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbExport.Appearance.Options.UseFont = true;
            this.sbExport.Location = new System.Drawing.Point(868, 4);
            this.sbExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbExport.Name = "sbExport";
            this.sbExport.Size = new System.Drawing.Size(80, 29);
            this.sbExport.TabIndex = 6;
            this.sbExport.Text = "����(&E)";
            this.sbExport.Click += new System.EventHandler(this.sbExport_Click);
            // 
            // ckTask
            // 
            this.ckTask.Location = new System.Drawing.Point(224, 9);
            this.ckTask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckTask.Name = "ckTask";
            this.ckTask.Properties.Caption = "�ɰ�����";
            this.ckTask.Size = new System.Drawing.Size(113, 23);
            this.ckTask.TabIndex = 5;
            this.ckTask.CheckedChanged += new System.EventHandler(this.ckTask_CheckedChanged);
            // 
            // ckStock
            // 
            this.ckStock.Location = new System.Drawing.Point(31, 9);
            this.ckStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckStock.Name = "ckStock";
            this.ckStock.Properties.Caption = "�ɹ�δ����(��;��)";
            this.ckStock.Size = new System.Drawing.Size(169, 23);
            this.ckStock.TabIndex = 4;
            this.ckStock.CheckedChanged += new System.EventHandler(this.ckStock_CheckedChanged);
            // 
            // sbPreview
            // 
            this.sbPreview.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPreview.Appearance.Options.UseFont = true;
            this.sbPreview.Location = new System.Drawing.Point(780, 4);
            this.sbPreview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbPreview.Name = "sbPreview";
            this.sbPreview.Size = new System.Drawing.Size(80, 29);
            this.sbPreview.TabIndex = 3;
            this.sbPreview.Text = "Ԥ��(&V)";
            this.sbPreview.Click += new System.EventHandler(this.sbPreview_Click);
            // 
            // sbPrint
            // 
            this.sbPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPrint.Appearance.Options.UseFont = true;
            this.sbPrint.Location = new System.Drawing.Point(692, 4);
            this.sbPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbPrint.Name = "sbPrint";
            this.sbPrint.Size = new System.Drawing.Size(80, 29);
            this.sbPrint.TabIndex = 2;
            this.sbPrint.Text = "��ӡ(&P)";
            this.sbPrint.Click += new System.EventHandler(this.sbPrint_Click);
            // 
            // sbGen
            // 
            this.sbGen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbGen.Appearance.Options.UseFont = true;
            this.sbGen.Location = new System.Drawing.Point(584, 4);
            this.sbGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbGen.Name = "sbGen";
            this.sbGen.Size = new System.Drawing.Size(100, 29);
            this.sbGen.TabIndex = 1;
            this.sbGen.Text = "�����깺��";
            this.sbGen.Click += new System.EventHandler(this.sbGen_Click);
            // 
            // gcResult
            // 
            this.gcResult.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResult.Location = new System.Drawing.Point(5, 40);
            this.gcResult.MainView = this.gvResult;
            this.gcResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gcResult.Name = "gcResult";
            this.gcResult.Size = new System.Drawing.Size(953, 515);
            this.gcResult.TabIndex = 0;
            this.gcResult.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvResult});
            // 
            // gvResult
            // 
            this.gvResult.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn39,
            this.gridColumn40,
            this.gridColumn42,
            this.gridColumn45,
            this.gridColumn47,
            this.gridColumn48,
            this.gridColumn46,
            this.gridColumn49,
            this.gridColumn50});
            this.gvResult.GridControl = this.gcResult;
            this.gvResult.Name = "gvResult";
            this.gvResult.OptionsBehavior.Editable = false;
            this.gvResult.OptionsCustomization.AllowFilter = false;
            this.gvResult.OptionsView.ColumnAutoWidth = false;
            this.gvResult.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn39
            // 
            this.gridColumn39.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn39.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn39.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn39.Caption = "���ϱ���";
            this.gridColumn39.FieldName = "F_ItemID";
            this.gridColumn39.Name = "gridColumn39";
            this.gridColumn39.Visible = true;
            this.gridColumn39.VisibleIndex = 0;
            this.gridColumn39.Width = 85;
            // 
            // gridColumn40
            // 
            this.gridColumn40.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn40.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn40.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn40.Caption = "��������";
            this.gridColumn40.FieldName = "F_ItemName";
            this.gridColumn40.Name = "gridColumn40";
            this.gridColumn40.Visible = true;
            this.gridColumn40.VisibleIndex = 1;
            this.gridColumn40.Width = 128;
            // 
            // gridColumn42
            // 
            this.gridColumn42.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn42.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn42.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn42.Caption = "���";
            this.gridColumn42.FieldName = "F_Spec";
            this.gridColumn42.Name = "gridColumn42";
            this.gridColumn42.Visible = true;
            this.gridColumn42.VisibleIndex = 2;
            this.gridColumn42.Width = 83;
            // 
            // gridColumn45
            // 
            this.gridColumn45.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn45.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn45.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn45.Caption = "��λ";
            this.gridColumn45.FieldName = "F_Unit";
            this.gridColumn45.Name = "gridColumn45";
            this.gridColumn45.Visible = true;
            this.gridColumn45.VisibleIndex = 3;
            this.gridColumn45.Width = 58;
            // 
            // gridColumn47
            // 
            this.gridColumn47.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn47.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn47.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn47.Caption = "�ɹ�δ��";
            this.gridColumn47.FieldName = "F_StockQty";
            this.gridColumn47.Name = "gridColumn47";
            this.gridColumn47.Visible = true;
            this.gridColumn47.VisibleIndex = 5;
            this.gridColumn47.Width = 66;
            // 
            // gridColumn48
            // 
            this.gridColumn48.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn48.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn48.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn48.Caption = "�ɰ�����";
            this.gridColumn48.FieldName = "F_TaskQty";
            this.gridColumn48.Name = "gridColumn48";
            this.gridColumn48.Visible = true;
            this.gridColumn48.VisibleIndex = 6;
            this.gridColumn48.Width = 68;
            // 
            // gridColumn46
            // 
            this.gridColumn46.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn46.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn46.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn46.Caption = "������";
            this.gridColumn46.FieldName = "F_Qty";
            this.gridColumn46.Name = "gridColumn46";
            this.gridColumn46.Visible = true;
            this.gridColumn46.VisibleIndex = 7;
            this.gridColumn46.Width = 67;
            // 
            // gridColumn49
            // 
            this.gridColumn49.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn49.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn49.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn49.Caption = "ʵ������";
            this.gridColumn49.FieldName = "F_NeedQty";
            this.gridColumn49.Name = "gridColumn49";
            this.gridColumn49.Visible = true;
            this.gridColumn49.VisibleIndex = 8;
            this.gridColumn49.Width = 65;
            // 
            // gridColumn50
            // 
            this.gridColumn50.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn50.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridColumn50.Caption = "�����";
            this.gridColumn50.FieldName = "F_StoreQty";
            this.gridColumn50.Name = "gridColumn50";
            this.gridColumn50.Visible = true;
            this.gridColumn50.VisibleIndex = 4;
            this.gridColumn50.Width = 60;
            // 
            // sbPre
            // 
            this.sbPre.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPre.Appearance.Options.UseFont = true;
            this.sbPre.Enabled = false;
            this.sbPre.Location = new System.Drawing.Point(649, 589);
            this.sbPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbPre.Name = "sbPre";
            this.sbPre.Size = new System.Drawing.Size(100, 29);
            this.sbPre.TabIndex = 1;
            this.sbPre.Text = "<��һ��";
            this.sbPre.Click += new System.EventHandler(this.sbPre_Click);
            // 
            // sbNext
            // 
            this.sbNext.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbNext.Appearance.Options.UseFont = true;
            this.sbNext.Location = new System.Drawing.Point(757, 589);
            this.sbNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbNext.Name = "sbNext";
            this.sbNext.Size = new System.Drawing.Size(100, 29);
            this.sbNext.TabIndex = 2;
            this.sbNext.Text = "��һ��>";
            this.sbNext.Click += new System.EventHandler(this.sbNext_Click);
            // 
            // sbClose
            // 
            this.sbClose.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbClose.Appearance.Options.UseFont = true;
            this.sbClose.Location = new System.Drawing.Point(888, 589);
            this.sbClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sbClose.Name = "sbClose";
            this.sbClose.Size = new System.Drawing.Size(100, 29);
            this.sbClose.TabIndex = 3;
            this.sbClose.Text = "�ر�(&C)";
            this.sbClose.Click += new System.EventHandler(this.sbClose_Click);
            // 
            // printingSystem
            // 
            this.printingSystem.Links.AddRange(new object[] {
            this.printableComponentLink1});
            // 
            // printableComponentLink1
            // 
            this.printableComponentLink1.Component = this.gcResult;
            this.printableComponentLink1.CustomPaperSize = new System.Drawing.Size(0, 0);
            this.printableComponentLink1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("printableComponentLink1.ImageStream")));
            this.printableComponentLink1.PrintingSystem = this.printingSystem;
            this.printableComponentLink1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            // 
            // frmMRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1004, 632);
            this.Controls.Add(this.sbClose);
            this.Controls.Add(this.sbNext);
            this.Controls.Add(this.sbPre);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMRP";
            this.Text = "MRP����";
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.PageWelcom.ResumeLayout(false);
            this.PageWelcom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFlag)).EndInit();
            this.PageSelect.ResumeLayout(false);
            this.PageSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PageSellOrder.ResumeLayout(false);
            this.PageSellOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSellOrderMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellOrderMain)).EndInit();
            this.PageTask.ResumeLayout(false);
            this.PageTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaskTmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskTmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTaskMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTaskMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.PageNeed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemButtonEdit)).EndInit();
            this.PageResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckTask.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
            this.ResumeLayout(false);

}

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControl;
        private DevExpress.XtraTab.XtraTabPage PageWelcom;
        private DevExpress.XtraTab.XtraTabPage PageSelect;
        private DevExpress.XtraEditors.SimpleButton sbPre;
        private DevExpress.XtraEditors.SimpleButton sbNext;
        private DevExpress.XtraEditors.SimpleButton sbClose;
        private DevExpress.XtraTab.XtraTabPage PageSellOrder;
        private System.Windows.Forms.PictureBox pcFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNeed;
        private System.Windows.Forms.RadioButton rbTask;
        private System.Windows.Forms.RadioButton rbSellOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcSellOrderMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSellOrderMain;
        private myControl.ucDate ucDate;
        private DevExpress.XtraGrid.GridControl gcTmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTmp;
        private DevExpress.XtraEditors.SimpleButton sbAdd;
        private DevExpress.XtraEditors.SimpleButton sbRemove;
        private System.Windows.Forms.CheckBox ckSellNoOut;
        private System.Windows.Forms.CheckBox ckStore;
        private System.Windows.Forms.CheckBox ckNewZero;
        private DevExpress.XtraTab.XtraTabPage PageResult;
        private DevExpress.XtraGrid.GridControl gcResult;
        private DevExpress.XtraGrid.Views.Grid.GridView gvResult;
        private DevExpress.XtraEditors.SimpleButton sbGen;
        private DevExpress.XtraEditors.SimpleButton sbPreview;
        private DevExpress.XtraEditors.SimpleButton sbPrint;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private System.Windows.Forms.CheckBox cbSelAll1;
        private System.Windows.Forms.CheckBox cbSelAll2;
        private DevExpress.XtraTab.XtraTabPage PageTask;
        private DevExpress.XtraTab.XtraTabPage PageNeed;
        private DevExpress.XtraGrid.GridControl gcItem;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItem;
        private DevExpress.XtraGrid.GridControl gcTaskMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaskMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn23;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn25;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn28;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn29;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn30;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private myControl.ucDate ucTask;
        private DevExpress.XtraEditors.SimpleButton sbRemoveTask;
        private DevExpress.XtraEditors.SimpleButton sbAddTask;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private DevExpress.XtraGrid.GridControl gcTaskTmp;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTaskTmp;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton sbAddRow;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn24;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn26;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn41;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn43;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn44;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit ItemButtonEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn31;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn32;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn33;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn34;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn35;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn36;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn37;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn38;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn39;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn40;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn42;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn45;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn46;
        private DevExpress.XtraEditors.CheckEdit ckStock;
        private DevExpress.XtraEditors.CheckEdit ckTask;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn47;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn48;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn49;
        private DevExpress.XtraEditors.SimpleButton sbExport;
        private DevExpress.XtraPrinting.PrintingSystem printingSystem;
        private DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn50;
    }
}