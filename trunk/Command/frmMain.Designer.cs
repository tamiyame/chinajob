namespace HotbookCommand
{
    partial class frmHotbook
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("필드명", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("타입", System.Windows.Forms.HorizontalAlignment.Left);
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnArgumentsClipboard = new System.Windows.Forms.Button();
            this.btnAccessClipboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstEntityParam = new System.Windows.Forms.ListView();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
            this.lstEntityField = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.lstEntityTable = new System.Windows.Forms.ListBox();
            this.btnEntityDBConnect = new System.Windows.Forms.Button();
            this.btnEntityClipboard = new System.Windows.Forms.Button();
            this.btnEntity = new System.Windows.Forms.Button();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panParamModify = new System.Windows.Forms.Panel();
            this.btnParamClose = new System.Windows.Forms.Button();
            this.btnParamRemove = new System.Windows.Forms.Button();
            this.btnParam_Modify = new System.Windows.Forms.Button();
            this.cmbParam_INOUT = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtParam_Value = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbParam_Type = new System.Windows.Forms.ComboBox();
            this.txtParam_Size = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtParam_Name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstParam = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lstField = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colType = new System.Windows.Forms.ColumnHeader();
            this.colSize = new System.Windows.Forms.ColumnHeader();
            this.colPrimary = new System.Windows.Forms.ColumnHeader();
            this.colIdentity = new System.Windows.Forms.ColumnHeader();
            this.btnParamClear = new System.Windows.Forms.Button();
            this.btnInfoPart = new System.Windows.Forms.Button();
            this.btnUpdatePart = new System.Windows.Forms.Button();
            this.btnInsertPart = new System.Windows.Forms.Button();
            this.btnSelectPart = new System.Windows.Forms.Button();
            this.btnInOutParam = new System.Windows.Forms.Button();
            this.btnOutParam = new System.Windows.Forms.Button();
            this.btnInputParam = new System.Windows.Forms.Button();
            this.btnDBReader = new System.Windows.Forms.Button();
            this.lstTable = new System.Windows.Forms.ListBox();
            this.btnSPClipboard = new System.Windows.Forms.Button();
            this.btnSPGen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSPGen = new System.Windows.Forms.TextBox();
            this.txtSPName = new System.Windows.Forms.TextBox();
            this.txtAccessName = new System.Windows.Forms.TextBox();
            this.txtArgumentsName = new System.Windows.Forms.TextBox();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panParamModify.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(887, 639);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtArgumentsName);
            this.tabPage1.Controls.Add(this.txtAccessName);
            this.tabPage1.Controls.Add(this.btnArgumentsClipboard);
            this.tabPage1.Controls.Add(this.btnAccessClipboard);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtArguments);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtAccess);
            this.tabPage1.Controls.Add(this.lstFile);
            this.tabPage1.Controls.Add(this.txtDirectory);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataAccess";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnArgumentsClipboard
            // 
            this.btnArgumentsClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArgumentsClipboard.Location = new System.Drawing.Point(776, 329);
            this.btnArgumentsClipboard.Name = "btnArgumentsClipboard";
            this.btnArgumentsClipboard.Size = new System.Drawing.Size(94, 23);
            this.btnArgumentsClipboard.TabIndex = 9;
            this.btnArgumentsClipboard.Text = "클립보드복사";
            this.btnArgumentsClipboard.UseVisualStyleBackColor = true;
            this.btnArgumentsClipboard.Click += new System.EventHandler(this.btnArgumentsClipboard_Click);
            // 
            // btnAccessClipboard
            // 
            this.btnAccessClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessClipboard.Location = new System.Drawing.Point(776, 35);
            this.btnAccessClipboard.Name = "btnAccessClipboard";
            this.btnAccessClipboard.Size = new System.Drawing.Size(94, 23);
            this.btnAccessClipboard.TabIndex = 8;
            this.btnAccessClipboard.Text = "클립보드복사";
            this.btnAccessClipboard.UseVisualStyleBackColor = true;
            this.btnAccessClipboard.Click += new System.EventHandler(this.btnAccessClipboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "디렉토리";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(795, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "DataArguments";
            // 
            // txtArguments
            // 
            this.txtArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArguments.Location = new System.Drawing.Point(275, 358);
            this.txtArguments.Multiline = true;
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArguments.Size = new System.Drawing.Size(595, 250);
            this.txtArguments.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "DataAccess";
            // 
            // txtAccess
            // 
            this.txtAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccess.Location = new System.Drawing.Point(275, 64);
            this.txtAccess.Multiline = true;
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAccess.Size = new System.Drawing.Size(595, 246);
            this.txtAccess.TabIndex = 2;
            // 
            // lstFile
            // 
            this.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 12;
            this.lstFile.Location = new System.Drawing.Point(6, 41);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(263, 566);
            this.lstFile.TabIndex = 1;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            // 
            // txtDirectory
            // 
            this.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectory.Location = new System.Drawing.Point(74, 8);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(715, 21);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.Text = "D:\\Hotbook\\SP";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.lstEntityParam);
            this.tabPage2.Controls.Add(this.lstEntityField);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lstEntityTable);
            this.tabPage2.Controls.Add(this.btnEntityDBConnect);
            this.tabPage2.Controls.Add(this.btnEntityClipboard);
            this.tabPage2.Controls.Add(this.btnEntity);
            this.tabPage2.Controls.Add(this.txtNamespace);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtEntityName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtEntity);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataEntity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(688, 175);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(182, 23);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstEntityParam
            // 
            this.lstEntityParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEntityParam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lstEntityParam.FullRowSelect = true;
            this.lstEntityParam.GridLines = true;
            this.lstEntityParam.Location = new System.Drawing.Point(281, 61);
            this.lstEntityParam.Name = "lstEntityParam";
            this.lstEntityParam.Size = new System.Drawing.Size(401, 137);
            this.lstEntityParam.TabIndex = 17;
            this.lstEntityParam.UseCompatibleStateImageBehavior = false;
            this.lstEntityParam.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "이름";
            this.columnHeader11.Width = 108;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "타입";
            this.columnHeader12.Width = 59;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "기본값";
            this.columnHeader13.Width = 97;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "치환";
            this.columnHeader14.Width = 117;
            // 
            // lstEntityField
            // 
            this.lstEntityField.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstEntityField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEntityField.CheckBoxes = true;
            this.lstEntityField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lstEntityField.GridLines = true;
            this.lstEntityField.Location = new System.Drawing.Point(6, 267);
            this.lstEntityField.Name = "lstEntityField";
            this.lstEntityField.Size = new System.Drawing.Size(269, 339);
            this.lstEntityField.TabIndex = 16;
            this.lstEntityField.UseCompatibleStateImageBehavior = false;
            this.lstEntityField.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "필드명";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "타입";
            this.columnHeader7.Width = 58;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "크기";
            this.columnHeader8.Width = 37;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "키";
            this.columnHeader9.Width = 34;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "증가";
            this.columnHeader10.Width = 41;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtParamName);
            this.panel1.Location = new System.Drawing.Point(688, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 100);
            this.panel1.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "타입";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "이름";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(14, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbType
            // 
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(62, 39);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(106, 20);
            this.cmbType.TabIndex = 9;
            // 
            // txtParamName
            // 
            this.txtParamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParamName.Location = new System.Drawing.Point(62, 12);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(106, 21);
            this.txtParamName.TabIndex = 8;
            // 
            // lstEntityTable
            // 
            this.lstEntityTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEntityTable.FormattingEnabled = true;
            this.lstEntityTable.ItemHeight = 12;
            this.lstEntityTable.Location = new System.Drawing.Point(6, 31);
            this.lstEntityTable.Name = "lstEntityTable";
            this.lstEntityTable.Size = new System.Drawing.Size(269, 230);
            this.lstEntityTable.TabIndex = 14;
            this.lstEntityTable.SelectedIndexChanged += new System.EventHandler(this.lstEntityTable_SelectedIndexChanged);
            // 
            // btnEntityDBConnect
            // 
            this.btnEntityDBConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntityDBConnect.Location = new System.Drawing.Point(3, 6);
            this.btnEntityDBConnect.Name = "btnEntityDBConnect";
            this.btnEntityDBConnect.Size = new System.Drawing.Size(272, 22);
            this.btnEntityDBConnect.TabIndex = 13;
            this.btnEntityDBConnect.Text = "DB 점속";
            this.btnEntityDBConnect.UseVisualStyleBackColor = true;
            this.btnEntityDBConnect.Click += new System.EventHandler(this.btnEntityDBConnect_Click);
            // 
            // btnEntityClipboard
            // 
            this.btnEntityClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntityClipboard.Location = new System.Drawing.Point(771, 10);
            this.btnEntityClipboard.Name = "btnEntityClipboard";
            this.btnEntityClipboard.Size = new System.Drawing.Size(99, 45);
            this.btnEntityClipboard.TabIndex = 12;
            this.btnEntityClipboard.Text = "클립보드 복사";
            this.btnEntityClipboard.UseVisualStyleBackColor = true;
            this.btnEntityClipboard.Click += new System.EventHandler(this.btnEntityClipboard_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntity.Location = new System.Drawing.Point(688, 10);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(77, 45);
            this.btnEntity.TabIndex = 11;
            this.btnEntity.Text = "만들기";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // txtNamespace
            // 
            this.txtNamespace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamespace.Location = new System.Drawing.Point(373, 7);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(309, 21);
            this.txtNamespace.TabIndex = 10;
            this.txtNamespace.Text = "Com.Library.DB.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Namespace";
            // 
            // txtEntityName
            // 
            this.txtEntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntityName.Location = new System.Drawing.Point(373, 34);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(309, 21);
            this.txtEntityName.TabIndex = 8;
            this.txtEntityName.Text = "HotBook";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(297, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "EntityName";
            // 
            // txtEntity
            // 
            this.txtEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntity.Location = new System.Drawing.Point(281, 204);
            this.txtEntity.Multiline = true;
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(589, 402);
            this.txtEntity.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panParamModify);
            this.tabPage3.Controls.Add(this.lstParam);
            this.tabPage3.Controls.Add(this.lstField);
            this.tabPage3.Controls.Add(this.btnParamClear);
            this.tabPage3.Controls.Add(this.btnInfoPart);
            this.tabPage3.Controls.Add(this.btnUpdatePart);
            this.tabPage3.Controls.Add(this.btnInsertPart);
            this.tabPage3.Controls.Add(this.btnSelectPart);
            this.tabPage3.Controls.Add(this.btnInOutParam);
            this.tabPage3.Controls.Add(this.btnOutParam);
            this.tabPage3.Controls.Add(this.btnInputParam);
            this.tabPage3.Controls.Add(this.btnDBReader);
            this.tabPage3.Controls.Add(this.lstTable);
            this.tabPage3.Controls.Add(this.btnSPClipboard);
            this.tabPage3.Controls.Add(this.btnSPGen);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSPGen);
            this.tabPage3.Controls.Add(this.txtSPName);
            this.tabPage3.Location = new System.Drawing.Point(4, 21);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(879, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SP Framework";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panParamModify
            // 
            this.panParamModify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panParamModify.Controls.Add(this.btnParamClose);
            this.panParamModify.Controls.Add(this.btnParamRemove);
            this.panParamModify.Controls.Add(this.btnParam_Modify);
            this.panParamModify.Controls.Add(this.cmbParam_INOUT);
            this.panParamModify.Controls.Add(this.label11);
            this.panParamModify.Controls.Add(this.txtParam_Value);
            this.panParamModify.Controls.Add(this.label10);
            this.panParamModify.Controls.Add(this.cmbParam_Type);
            this.panParamModify.Controls.Add(this.txtParam_Size);
            this.panParamModify.Controls.Add(this.label9);
            this.panParamModify.Controls.Add(this.label8);
            this.panParamModify.Controls.Add(this.txtParam_Name);
            this.panParamModify.Controls.Add(this.label7);
            this.panParamModify.Location = new System.Drawing.Point(590, 165);
            this.panParamModify.Name = "panParamModify";
            this.panParamModify.Size = new System.Drawing.Size(221, 184);
            this.panParamModify.TabIndex = 20;
            this.panParamModify.Visible = false;
            // 
            // btnParamClose
            // 
            this.btnParamClose.Location = new System.Drawing.Point(148, 156);
            this.btnParamClose.Name = "btnParamClose";
            this.btnParamClose.Size = new System.Drawing.Size(61, 23);
            this.btnParamClose.TabIndex = 23;
            this.btnParamClose.Text = "닫기";
            this.btnParamClose.UseVisualStyleBackColor = true;
            this.btnParamClose.Click += new System.EventHandler(this.btnParamClose_Click);
            // 
            // btnParamRemove
            // 
            this.btnParamRemove.Location = new System.Drawing.Point(80, 156);
            this.btnParamRemove.Name = "btnParamRemove";
            this.btnParamRemove.Size = new System.Drawing.Size(61, 23);
            this.btnParamRemove.TabIndex = 22;
            this.btnParamRemove.Text = "삭제";
            this.btnParamRemove.UseVisualStyleBackColor = true;
            this.btnParamRemove.Click += new System.EventHandler(this.btnParamRemove_Click);
            // 
            // btnParam_Modify
            // 
            this.btnParam_Modify.Location = new System.Drawing.Point(13, 156);
            this.btnParam_Modify.Name = "btnParam_Modify";
            this.btnParam_Modify.Size = new System.Drawing.Size(61, 23);
            this.btnParam_Modify.TabIndex = 21;
            this.btnParam_Modify.Text = "수정";
            this.btnParam_Modify.UseVisualStyleBackColor = true;
            this.btnParam_Modify.Click += new System.EventHandler(this.btnParam_Modify_Click);
            // 
            // cmbParam_INOUT
            // 
            this.cmbParam_INOUT.FormattingEnabled = true;
            this.cmbParam_INOUT.Items.AddRange(new object[] {
            "INPUT",
            "OUTPUT",
            "INPUT/OUTPUT"});
            this.cmbParam_INOUT.Location = new System.Drawing.Point(66, 122);
            this.cmbParam_INOUT.Name = "cmbParam_INOUT";
            this.cmbParam_INOUT.Size = new System.Drawing.Size(137, 20);
            this.cmbParam_INOUT.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "IN/OUT";
            // 
            // txtParam_Value
            // 
            this.txtParam_Value.Location = new System.Drawing.Point(66, 95);
            this.txtParam_Value.Name = "txtParam_Value";
            this.txtParam_Value.Size = new System.Drawing.Size(137, 21);
            this.txtParam_Value.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "기본값";
            // 
            // cmbParam_Type
            // 
            this.cmbParam_Type.FormattingEnabled = true;
            this.cmbParam_Type.Items.AddRange(new object[] {
            "varchar",
            "nvarchar",
            "bigint",
            "int",
            "smallint",
            "tinyint",
            "float",
            "datatime",
            "smalldatatime"});
            this.cmbParam_Type.Location = new System.Drawing.Point(66, 41);
            this.cmbParam_Type.Name = "cmbParam_Type";
            this.cmbParam_Type.Size = new System.Drawing.Size(137, 20);
            this.cmbParam_Type.TabIndex = 6;
            // 
            // txtParam_Size
            // 
            this.txtParam_Size.Location = new System.Drawing.Point(66, 68);
            this.txtParam_Size.Mask = "99999";
            this.txtParam_Size.Name = "txtParam_Size";
            this.txtParam_Size.Size = new System.Drawing.Size(46, 21);
            this.txtParam_Size.TabIndex = 5;
            this.txtParam_Size.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "크기";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "타입";
            // 
            // txtParam_Name
            // 
            this.txtParam_Name.Location = new System.Drawing.Point(66, 14);
            this.txtParam_Name.Name = "txtParam_Name";
            this.txtParam_Name.Size = new System.Drawing.Size(137, 21);
            this.txtParam_Name.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "필드명";
            // 
            // lstParam
            // 
            this.lstParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstParam.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstParam.FullRowSelect = true;
            this.lstParam.GridLines = true;
            this.lstParam.Location = new System.Drawing.Point(274, 35);
            this.lstParam.MultiSelect = false;
            this.lstParam.Name = "lstParam";
            this.lstParam.ShowGroups = false;
            this.lstParam.Size = new System.Drawing.Size(596, 121);
            this.lstParam.TabIndex = 19;
            this.lstParam.UseCompatibleStateImageBehavior = false;
            this.lstParam.View = System.Windows.Forms.View.Details;
            this.lstParam.Click += new System.EventHandler(this.lstParam_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "필드명";
            this.columnHeader1.Width = 176;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "타입";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "크기";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "기본값";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "IN/OUT";
            this.columnHeader5.Width = 118;
            // 
            // lstField
            // 
            this.lstField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstField.CheckBoxes = true;
            this.lstField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colSize,
            this.colPrimary,
            this.colIdentity});
            this.lstField.FullRowSelect = true;
            this.lstField.GridLines = true;
            listViewGroup1.Header = "필드명";
            listViewGroup1.Name = "vwName";
            listViewGroup2.Header = "타입";
            listViewGroup2.Name = "vwType";
            this.lstField.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lstField.Location = new System.Drawing.Point(3, 301);
            this.lstField.Name = "lstField";
            this.lstField.ShowGroups = false;
            this.lstField.Size = new System.Drawing.Size(265, 216);
            this.lstField.TabIndex = 18;
            this.lstField.UseCompatibleStateImageBehavior = false;
            this.lstField.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "필드명";
            this.colName.Width = 75;
            // 
            // colType
            // 
            this.colType.Text = "타입";
            this.colType.Width = 62;
            // 
            // colSize
            // 
            this.colSize.Text = "크기";
            this.colSize.Width = 41;
            // 
            // colPrimary
            // 
            this.colPrimary.Text = "키";
            this.colPrimary.Width = 37;
            // 
            // colIdentity
            // 
            this.colIdentity.Text = "증가";
            this.colIdentity.Width = 37;
            // 
            // btnParamClear
            // 
            this.btnParamClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParamClear.Location = new System.Drawing.Point(3, 583);
            this.btnParamClear.Name = "btnParamClear";
            this.btnParamClear.Size = new System.Drawing.Size(265, 25);
            this.btnParamClear.TabIndex = 15;
            this.btnParamClear.Text = "파라미터 Clear";
            this.btnParamClear.UseVisualStyleBackColor = true;
            this.btnParamClear.Click += new System.EventHandler(this.btnParamClear_Click);
            // 
            // btnInfoPart
            // 
            this.btnInfoPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPart.Location = new System.Drawing.Point(137, 243);
            this.btnInfoPart.Name = "btnInfoPart";
            this.btnInfoPart.Size = new System.Drawing.Size(131, 23);
            this.btnInfoPart.TabIndex = 14;
            this.btnInfoPart.Text = "Info";
            this.btnInfoPart.UseVisualStyleBackColor = true;
            this.btnInfoPart.Click += new System.EventHandler(this.btnInfoPart_Click);
            // 
            // btnUpdatePart
            // 
            this.btnUpdatePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePart.Location = new System.Drawing.Point(137, 272);
            this.btnUpdatePart.Name = "btnUpdatePart";
            this.btnUpdatePart.Size = new System.Drawing.Size(131, 23);
            this.btnUpdatePart.TabIndex = 13;
            this.btnUpdatePart.Text = "Update";
            this.btnUpdatePart.UseVisualStyleBackColor = true;
            this.btnUpdatePart.Click += new System.EventHandler(this.btnUpdatePart_Click);
            // 
            // btnInsertPart
            // 
            this.btnInsertPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertPart.Location = new System.Drawing.Point(3, 272);
            this.btnInsertPart.Name = "btnInsertPart";
            this.btnInsertPart.Size = new System.Drawing.Size(131, 23);
            this.btnInsertPart.TabIndex = 12;
            this.btnInsertPart.Text = "Insert";
            this.btnInsertPart.UseVisualStyleBackColor = true;
            this.btnInsertPart.Click += new System.EventHandler(this.btnInsertPart_Click);
            // 
            // btnSelectPart
            // 
            this.btnSelectPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPart.Location = new System.Drawing.Point(3, 243);
            this.btnSelectPart.Name = "btnSelectPart";
            this.btnSelectPart.Size = new System.Drawing.Size(131, 23);
            this.btnSelectPart.TabIndex = 11;
            this.btnSelectPart.Text = "Select";
            this.btnSelectPart.UseVisualStyleBackColor = true;
            this.btnSelectPart.Click += new System.EventHandler(this.btnSelectPart_Click);
            // 
            // btnInOutParam
            // 
            this.btnInOutParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInOutParam.Location = new System.Drawing.Point(3, 554);
            this.btnInOutParam.Name = "btnInOutParam";
            this.btnInOutParam.Size = new System.Drawing.Size(265, 23);
            this.btnInOutParam.TabIndex = 10;
            this.btnInOutParam.Text = "in/out 파라미터";
            this.btnInOutParam.UseVisualStyleBackColor = true;
            this.btnInOutParam.Click += new System.EventHandler(this.btnInOutParam_Click);
            // 
            // btnOutParam
            // 
            this.btnOutParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutParam.Location = new System.Drawing.Point(137, 525);
            this.btnOutParam.Name = "btnOutParam";
            this.btnOutParam.Size = new System.Drawing.Size(131, 23);
            this.btnOutParam.TabIndex = 9;
            this.btnOutParam.Text = "output 파라미터";
            this.btnOutParam.UseVisualStyleBackColor = true;
            this.btnOutParam.Click += new System.EventHandler(this.btnOutParam_Click);
            // 
            // btnInputParam
            // 
            this.btnInputParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputParam.Location = new System.Drawing.Point(3, 525);
            this.btnInputParam.Name = "btnInputParam";
            this.btnInputParam.Size = new System.Drawing.Size(131, 23);
            this.btnInputParam.TabIndex = 8;
            this.btnInputParam.Text = "input 파라미터";
            this.btnInputParam.UseVisualStyleBackColor = true;
            this.btnInputParam.Click += new System.EventHandler(this.btnInputParam_Click);
            // 
            // btnDBReader
            // 
            this.btnDBReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBReader.Location = new System.Drawing.Point(3, 5);
            this.btnDBReader.Name = "btnDBReader";
            this.btnDBReader.Size = new System.Drawing.Size(265, 23);
            this.btnDBReader.TabIndex = 6;
            this.btnDBReader.Text = "DB 접속";
            this.btnDBReader.UseVisualStyleBackColor = true;
            this.btnDBReader.Click += new System.EventHandler(this.btnDBReader_Click);
            // 
            // lstTable
            // 
            this.lstTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTable.FormattingEnabled = true;
            this.lstTable.ItemHeight = 12;
            this.lstTable.Location = new System.Drawing.Point(3, 29);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(265, 206);
            this.lstTable.TabIndex = 5;
            this.lstTable.SelectedIndexChanged += new System.EventHandler(this.lstTable_SelectedIndexChanged);
            // 
            // btnSPClipboard
            // 
            this.btnSPClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPClipboard.Location = new System.Drawing.Point(734, 6);
            this.btnSPClipboard.Name = "btnSPClipboard";
            this.btnSPClipboard.Size = new System.Drawing.Size(136, 23);
            this.btnSPClipboard.TabIndex = 4;
            this.btnSPClipboard.Text = "클립보드 복사";
            this.btnSPClipboard.UseVisualStyleBackColor = true;
            this.btnSPClipboard.Click += new System.EventHandler(this.btnSPClipboard_Click);
            // 
            // btnSPGen
            // 
            this.btnSPGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPGen.Location = new System.Drawing.Point(653, 6);
            this.btnSPGen.Name = "btnSPGen";
            this.btnSPGen.Size = new System.Drawing.Size(75, 23);
            this.btnSPGen.TabIndex = 3;
            this.btnSPGen.Text = "실행";
            this.btnSPGen.UseVisualStyleBackColor = true;
            this.btnSPGen.Click += new System.EventHandler(this.btnSPGen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "SP 이름";
            // 
            // txtSPGen
            // 
            this.txtSPGen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSPGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPGen.Font = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSPGen.Location = new System.Drawing.Point(274, 162);
            this.txtSPGen.Multiline = true;
            this.txtSPGen.Name = "txtSPGen";
            this.txtSPGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSPGen.Size = new System.Drawing.Size(601, 447);
            this.txtSPGen.TabIndex = 1;
            this.txtSPGen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSPGen_KeyUp);
            // 
            // txtSPName
            // 
            this.txtSPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPName.Location = new System.Drawing.Point(327, 8);
            this.txtSPName.Name = "txtSPName";
            this.txtSPName.Size = new System.Drawing.Size(323, 21);
            this.txtSPName.TabIndex = 0;
            this.txtSPName.Text = "TSP_";
            // 
            // txtAccessName
            // 
            this.txtAccessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccessName.Location = new System.Drawing.Point(370, 35);
            this.txtAccessName.Name = "txtAccessName";
            this.txtAccessName.Size = new System.Drawing.Size(306, 21);
            this.txtAccessName.TabIndex = 10;
            // 
            // txtArgumentsName
            // 
            this.txtArgumentsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArgumentsName.Location = new System.Drawing.Point(370, 331);
            this.txtArgumentsName.Name = "txtArgumentsName";
            this.txtArgumentsName.Size = new System.Drawing.Size(306, 21);
            this.txtArgumentsName.TabIndex = 11;
            // 
            // frmHotbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 641);
            this.Controls.Add(this.tab);
            this.Name = "frmHotbook";
            this.Text = "Hotbook Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panParamModify.ResumeLayout(false);
            this.panParamModify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAccess;
        private System.Windows.Forms.ListBox lstFile;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSPGen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSPGen;
        private System.Windows.Forms.TextBox txtSPName;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.Button btnSPClipboard;
        private System.Windows.Forms.Button btnArgumentsClipboard;
        private System.Windows.Forms.Button btnAccessClipboard;
        private System.Windows.Forms.Button btnEntityClipboard;
        private System.Windows.Forms.ListBox lstTable;
        private System.Windows.Forms.Button btnDBReader;
        private System.Windows.Forms.Button btnSelectPart;
        private System.Windows.Forms.Button btnInOutParam;
        private System.Windows.Forms.Button btnOutParam;
        private System.Windows.Forms.Button btnInputParam;
        private System.Windows.Forms.Button btnInfoPart;
        private System.Windows.Forms.Button btnUpdatePart;
        private System.Windows.Forms.Button btnInsertPart;
        private System.Windows.Forms.Button btnParamClear;
        private System.Windows.Forms.ListView lstField;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ListView lstParam;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Panel panParamModify;
        private System.Windows.Forms.Button btnParamRemove;
        private System.Windows.Forms.Button btnParam_Modify;
        private System.Windows.Forms.ComboBox cmbParam_INOUT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtParam_Value;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbParam_Type;
        private System.Windows.Forms.MaskedTextBox txtParam_Size;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtParam_Name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnParamClose;
        private System.Windows.Forms.ColumnHeader colPrimary;
        private System.Windows.Forms.ColumnHeader colIdentity;
        private System.Windows.Forms.Button btnEntityDBConnect;
        private System.Windows.Forms.ListView lstEntityField;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.ListBox lstEntityTable;
        private System.Windows.Forms.ListView lstEntityParam;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtArgumentsName;
        private System.Windows.Forms.TextBox txtAccessName;
    }
}

