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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArguments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccess = new System.Windows.Forms.TextBox();
            this.lstFile = new System.Windows.Forms.ListBox();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.txtEntity = new System.Windows.Forms.TextBox();
            this.lstEntity = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSPGen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSPGen = new System.Windows.Forms.TextBox();
            this.txtSPName = new System.Windows.Forms.TextBox();
            this.btnEntity = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAccessClipboard = new System.Windows.Forms.Button();
            this.btnArgumentsClipboard = new System.Windows.Forms.Button();
            this.btnEntityClipboard = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(749, 539);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(22, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(723, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DataAccess";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.btnSearch.Location = new System.Drawing.Point(540, 8);
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
            this.label2.Location = new System.Drawing.Point(205, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "DataArguments";
            // 
            // txtArguments
            // 
            this.txtArguments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArguments.Location = new System.Drawing.Point(207, 313);
            this.txtArguments.Multiline = true;
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(510, 206);
            this.txtArguments.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "DataAccess";
            // 
            // txtAccess
            // 
            this.txtAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccess.Location = new System.Drawing.Point(204, 64);
            this.txtAccess.Multiline = true;
            this.txtAccess.Name = "txtAccess";
            this.txtAccess.Size = new System.Drawing.Size(513, 209);
            this.txtAccess.TabIndex = 2;
            // 
            // lstFile
            // 
            this.lstFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFile.FormattingEnabled = true;
            this.lstFile.ItemHeight = 12;
            this.lstFile.Location = new System.Drawing.Point(8, 35);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(190, 482);
            this.lstFile.TabIndex = 1;
            this.lstFile.SelectedIndexChanged += new System.EventHandler(this.lstFile_SelectedIndexChanged);
            // 
            // txtDirectory
            // 
            this.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDirectory.Location = new System.Drawing.Point(74, 8);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(460, 21);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.Text = "D:\\Hotbook\\SP";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEntityClipboard);
            this.tabPage2.Controls.Add(this.btnEntity);
            this.tabPage2.Controls.Add(this.txtNamespace);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtEntityName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.cmbType);
            this.tabPage2.Controls.Add(this.txtParamName);
            this.tabPage2.Controls.Add(this.txtEntity);
            this.tabPage2.Controls.Add(this.lstEntity);
            this.tabPage2.Location = new System.Drawing.Point(22, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(723, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DataEntity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNamespace
            // 
            this.txtNamespace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNamespace.Location = new System.Drawing.Point(320, 7);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(241, 21);
            this.txtNamespace.TabIndex = 10;
            this.txtNamespace.Text = "Com.Library.DB.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Namespace";
            // 
            // txtEntityName
            // 
            this.txtEntityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntityName.Location = new System.Drawing.Point(320, 34);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(241, 21);
            this.txtEntityName.TabIndex = 8;
            this.txtEntityName.Text = "HotBook";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "EntityName";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(149, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 47);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(6, 501);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(209, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmbType
            // 
            this.cmbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(6, 34);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(137, 20);
            this.cmbType.TabIndex = 4;
            // 
            // txtParamName
            // 
            this.txtParamName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParamName.Location = new System.Drawing.Point(6, 8);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(137, 21);
            this.txtParamName.TabIndex = 2;
            // 
            // txtEntity
            // 
            this.txtEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEntity.Location = new System.Drawing.Point(221, 61);
            this.txtEntity.Multiline = true;
            this.txtEntity.Name = "txtEntity";
            this.txtEntity.Size = new System.Drawing.Size(496, 464);
            this.txtEntity.TabIndex = 1;
            // 
            // lstEntity
            // 
            this.lstEntity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstEntity.FormattingEnabled = true;
            this.lstEntity.ItemHeight = 12;
            this.lstEntity.Location = new System.Drawing.Point(6, 61);
            this.lstEntity.Name = "lstEntity";
            this.lstEntity.Size = new System.Drawing.Size(209, 434);
            this.lstEntity.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSelect);
            this.tabPage3.Controls.Add(this.btnSPGen);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtSPGen);
            this.tabPage3.Controls.Add(this.txtSPName);
            this.tabPage3.Location = new System.Drawing.Point(22, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(723, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SP Framework";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSPGen
            // 
            this.btnSPGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPGen.Location = new System.Drawing.Point(501, 6);
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
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "SP 이름";
            // 
            // txtSPGen
            // 
            this.txtSPGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPGen.Location = new System.Drawing.Point(14, 35);
            this.txtSPGen.Multiline = true;
            this.txtSPGen.Name = "txtSPGen";
            this.txtSPGen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSPGen.Size = new System.Drawing.Size(694, 490);
            this.txtSPGen.TabIndex = 1;
            // 
            // txtSPName
            // 
            this.txtSPName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPName.Location = new System.Drawing.Point(79, 8);
            this.txtSPName.Name = "txtSPName";
            this.txtSPName.Size = new System.Drawing.Size(416, 21);
            this.txtSPName.TabIndex = 0;
            this.txtSPName.Text = "TSP_";
            // 
            // btnEntity
            // 
            this.btnEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntity.Location = new System.Drawing.Point(567, 10);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(62, 45);
            this.btnEntity.TabIndex = 11;
            this.btnEntity.Text = "만들기";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(590, 6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(118, 23);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "클립보드 복사";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAccessClipboard
            // 
            this.btnAccessClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessClipboard.Location = new System.Drawing.Point(623, 35);
            this.btnAccessClipboard.Name = "btnAccessClipboard";
            this.btnAccessClipboard.Size = new System.Drawing.Size(94, 23);
            this.btnAccessClipboard.TabIndex = 8;
            this.btnAccessClipboard.Text = "클립보드복사";
            this.btnAccessClipboard.UseVisualStyleBackColor = true;
            this.btnAccessClipboard.Click += new System.EventHandler(this.btnAccessClipboard_Click);
            // 
            // btnArgumentsClipboard
            // 
            this.btnArgumentsClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArgumentsClipboard.Location = new System.Drawing.Point(623, 284);
            this.btnArgumentsClipboard.Name = "btnArgumentsClipboard";
            this.btnArgumentsClipboard.Size = new System.Drawing.Size(94, 23);
            this.btnArgumentsClipboard.TabIndex = 9;
            this.btnArgumentsClipboard.Text = "클립보드복사";
            this.btnArgumentsClipboard.UseVisualStyleBackColor = true;
            this.btnArgumentsClipboard.Click += new System.EventHandler(this.btnArgumentsClipboard_Click);
            // 
            // btnEntityClipboard
            // 
            this.btnEntityClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntityClipboard.Location = new System.Drawing.Point(644, 10);
            this.btnEntityClipboard.Name = "btnEntityClipboard";
            this.btnEntityClipboard.Size = new System.Drawing.Size(73, 45);
            this.btnEntityClipboard.TabIndex = 12;
            this.btnEntityClipboard.Text = "클립보드 복사";
            this.btnEntityClipboard.UseVisualStyleBackColor = true;
            this.btnEntityClipboard.Click += new System.EventHandler(this.btnEntityClipboard_Click);
            // 
            // frmHotbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 541);
            this.Controls.Add(this.tab);
            this.Name = "frmHotbook";
            this.Text = "Hotbook Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.TextBox txtEntity;
        private System.Windows.Forms.ListBox lstEntity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbType;
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
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnArgumentsClipboard;
        private System.Windows.Forms.Button btnAccessClipboard;
        private System.Windows.Forms.Button btnEntityClipboard;
    }
}

