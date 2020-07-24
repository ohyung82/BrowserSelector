namespace BrowserSelector
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.imlButtons = new System.Windows.Forms.ImageList(this.components);
            this.grdRules = new System.Windows.Forms.DataGridView();
            this.lblFallback = new System.Windows.Forms.Label();
            this.lblDefaultDesc = new System.Windows.Forms.Label();
            this.chkUseDefault = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unregisterBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.setAsDefaultBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDefaultsSection = new System.Windows.Forms.GroupBox();
            this.cboDefaultBrowser = new ImageComboBox.ImageComboBox();
            this.imlBrowsers = new System.Windows.Forms.ImageList(this.components);
            this.grpRulesSection = new System.Windows.Forms.GroupBox();
            this.cboBrowser = new ImageComboBox.ImageComboBox();
            this.cboMatchType = new System.Windows.Forms.ComboBox();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemoveUrl = new System.Windows.Forms.Button();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.colSerial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrowserImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBrowser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRules)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpDefaultsSection.SuspendLayout();
            this.grpRulesSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 19);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(26, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.txtUrl.Location = new System.Drawing.Point(144, 18);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(357, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // imlButtons
            // 
            this.imlButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButtons.ImageStream")));
            this.imlButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButtons.Images.SetKeyName(0, "delete_16x.ico");
            this.imlButtons.Images.SetKeyName(1, "112_UpArrowShort_Green.ico");
            this.imlButtons.Images.SetKeyName(2, "112_DownArrowShort_Orange.ico");
            this.imlButtons.Images.SetKeyName(3, "112_Plus_Green.ico");
            // 
            // grdRules
            // 
            this.grdRules.AllowUserToAddRows = false;
            this.grdRules.AllowUserToDeleteRows = false;
            this.grdRules.AllowUserToOrderColumns = true;
            this.grdRules.AllowUserToResizeRows = false;
            this.grdRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerial,
            this.colMatchType,
            this.colUrl,
            this.colBrowserImage,
            this.colBrowser});
            this.grdRules.Location = new System.Drawing.Point(12, 47);
            this.grdRules.MultiSelect = false;
            this.grdRules.Name = "grdRules";
            this.grdRules.ReadOnly = true;
            this.grdRules.RowHeadersVisible = false;
            this.grdRules.RowTemplate.Height = 24;
            this.grdRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRules.Size = new System.Drawing.Size(654, 312);
            this.grdRules.TabIndex = 6;
            this.grdRules.SelectionChanged += new System.EventHandler(this.grdRules_SelectionChanged);
            // 
            // lblFallback
            // 
            this.lblFallback.AutoSize = true;
            this.lblFallback.Location = new System.Drawing.Point(11, 22);
            this.lblFallback.Name = "lblFallback";
            this.lblFallback.Size = new System.Drawing.Size(40, 13);
            this.lblFallback.TabIndex = 0;
            this.lblFallback.Text = "대비용";
            // 
            // lblDefaultDesc
            // 
            this.lblDefaultDesc.AutoSize = true;
            this.lblDefaultDesc.Location = new System.Drawing.Point(58, 43);
            this.lblDefaultDesc.Name = "lblDefaultDesc";
            this.lblDefaultDesc.Size = new System.Drawing.Size(354, 13);
            this.lblDefaultDesc.TabIndex = 3;
            this.lblDefaultDesc.Text = "URL에 대한 규칙이 없을경우 이 대비용 웹 브라우저를 사용하게 됩니다.";
            // 
            // chkUseDefault
            // 
            this.chkUseDefault.AutoSize = true;
            this.chkUseDefault.Location = new System.Drawing.Point(197, 18);
            this.chkUseDefault.Name = "chkUseDefault";
            this.chkUseDefault.Size = new System.Drawing.Size(330, 17);
            this.chkUseDefault.TabIndex = 2;
            this.chkUseDefault.Text = "모든 URL에 대해서 이 웹 브라우저를 사용 (규칙을 무시합니다)";
            this.chkUseDefault.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "&적용";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "&적용하고 끝내기";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerBrowserToolStripMenuItem,
            this.unregisterBrowserToolStripMenuItem,
            this.toolStripMenuItem1,
            this.setAsDefaultBrowserToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolsToolStripMenuItem.Text = "&도구";
            // 
            // registerBrowserToolStripMenuItem
            // 
            this.registerBrowserToolStripMenuItem.Name = "registerBrowserToolStripMenuItem";
            this.registerBrowserToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.registerBrowserToolStripMenuItem.Text = "&기본 웹 브라우저 목록에 등록";
            this.registerBrowserToolStripMenuItem.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // unregisterBrowserToolStripMenuItem
            // 
            this.unregisterBrowserToolStripMenuItem.Name = "unregisterBrowserToolStripMenuItem";
            this.unregisterBrowserToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.unregisterBrowserToolStripMenuItem.Text = "&기본 웹 브라우저 목록에 등록 해제";
            this.unregisterBrowserToolStripMenuItem.Click += new System.EventHandler(this.btnUnregister_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(259, 6);
            // 
            // setAsDefaultBrowserToolStripMenuItem
            // 
            this.setAsDefaultBrowserToolStripMenuItem.Name = "setAsDefaultBrowserToolStripMenuItem";
            this.setAsDefaultBrowserToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.setAsDefaultBrowserToolStripMenuItem.Text = "기본 앱에서 웹 브라우저 설정하기";
            this.setAsDefaultBrowserToolStripMenuItem.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.helpToolStripMenuItem.Text = "&도움말";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&개발자";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grpDefaultsSection
            // 
            this.grpDefaultsSection.Controls.Add(this.cboDefaultBrowser);
            this.grpDefaultsSection.Controls.Add(this.chkUseDefault);
            this.grpDefaultsSection.Controls.Add(this.lblFallback);
            this.grpDefaultsSection.Controls.Add(this.lblDefaultDesc);
            this.grpDefaultsSection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDefaultsSection.Location = new System.Drawing.Point(9, 26);
            this.grpDefaultsSection.Name = "grpDefaultsSection";
            this.grpDefaultsSection.Size = new System.Drawing.Size(708, 64);
            this.grpDefaultsSection.TabIndex = 2;
            this.grpDefaultsSection.TabStop = false;
            this.grpDefaultsSection.Text = "기본 설정";
            // 
            // cboDefaultBrowser
            // 
            this.cboDefaultBrowser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDefaultBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultBrowser.ImageList = this.imlBrowsers;
            this.cboDefaultBrowser.Indent = 0;
            this.cboDefaultBrowser.ItemHeight = 16;
            this.cboDefaultBrowser.Location = new System.Drawing.Point(61, 18);
            this.cboDefaultBrowser.Name = "cboDefaultBrowser";
            this.cboDefaultBrowser.Size = new System.Drawing.Size(130, 22);
            this.cboDefaultBrowser.TabIndex = 1;
            // 
            // imlBrowsers
            // 
            this.imlBrowsers.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlBrowsers.ImageSize = new System.Drawing.Size(16, 16);
            this.imlBrowsers.TransparentColor = System.Drawing.Color.Black;
            // 
            // grpRulesSection
            // 
            this.grpRulesSection.Controls.Add(this.cboBrowser);
            this.grpRulesSection.Controls.Add(this.cboMatchType);
            this.grpRulesSection.Controls.Add(this.lblUrl);
            this.grpRulesSection.Controls.Add(this.txtUrl);
            this.grpRulesSection.Controls.Add(this.btnMoveDown);
            this.grpRulesSection.Controls.Add(this.btnMoveUp);
            this.grpRulesSection.Controls.Add(this.btnRemoveUrl);
            this.grpRulesSection.Controls.Add(this.btnAddUrl);
            this.grpRulesSection.Controls.Add(this.grdRules);
            this.grpRulesSection.Location = new System.Drawing.Point(9, 96);
            this.grpRulesSection.Name = "grpRulesSection";
            this.grpRulesSection.Size = new System.Drawing.Size(708, 376);
            this.grpRulesSection.TabIndex = 3;
            this.grpRulesSection.TabStop = false;
            this.grpRulesSection.Text = "규칙 - 규칙은 이 프로그램을 끝내야 저장, 적용됩니다.";
            // 
            // cboBrowser
            // 
            this.cboBrowser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBrowser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrowser.ImageList = this.imlBrowsers;
            this.cboBrowser.Indent = 0;
            this.cboBrowser.ItemHeight = 16;
            this.cboBrowser.Location = new System.Drawing.Point(507, 18);
            this.cboBrowser.Name = "cboBrowser";
            this.cboBrowser.Size = new System.Drawing.Size(130, 22);
            this.cboBrowser.TabIndex = 3;
            // 
            // cboMatchType
            // 
            this.cboMatchType.BackColor = System.Drawing.SystemColors.Window;
            this.cboMatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMatchType.FormattingEnabled = true;
            this.cboMatchType.Location = new System.Drawing.Point(60, 18);
            this.cboMatchType.Name = "cboMatchType";
            this.cboMatchType.Size = new System.Drawing.Size(78, 21);
            this.cboMatchType.TabIndex = 1;
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMoveDown.ImageKey = "112_DownArrowShort_Orange.ico";
            this.btnMoveDown.ImageList = this.imlButtons;
            this.btnMoveDown.Location = new System.Drawing.Point(672, 105);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(28, 28);
            this.btnMoveDown.TabIndex = 9;
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.ImageKey = "112_UpArrowShort_Green.ico";
            this.btnMoveUp.ImageList = this.imlButtons;
            this.btnMoveUp.Location = new System.Drawing.Point(672, 76);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(28, 28);
            this.btnMoveUp.TabIndex = 8;
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnRemoveUrl
            // 
            this.btnRemoveUrl.ImageKey = "delete_16x.ico";
            this.btnRemoveUrl.ImageList = this.imlButtons;
            this.btnRemoveUrl.Location = new System.Drawing.Point(672, 47);
            this.btnRemoveUrl.Name = "btnRemoveUrl";
            this.btnRemoveUrl.Size = new System.Drawing.Size(28, 28);
            this.btnRemoveUrl.TabIndex = 7;
            this.btnRemoveUrl.UseVisualStyleBackColor = true;
            this.btnRemoveUrl.Click += new System.EventHandler(this.btnRemoveUrl_Click);
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.ImageKey = "112_Plus_Green.ico";
            this.btnAddUrl.ImageList = this.imlButtons;
            this.btnAddUrl.Location = new System.Drawing.Point(643, 18);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(28, 28);
            this.btnAddUrl.TabIndex = 4;
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // colSerial
            // 
            this.colSerial.HeaderText = "#";
            this.colSerial.Name = "colSerial";
            this.colSerial.ReadOnly = true;
            this.colSerial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSerial.Width = 30;
            // 
            // colMatchType
            // 
            this.colMatchType.HeaderText = "규칙";
            this.colMatchType.Name = "colMatchType";
            this.colMatchType.ReadOnly = true;
            this.colMatchType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMatchType.Width = 85;
            // 
            // colUrl
            // 
            this.colUrl.HeaderText = "URL";
            this.colUrl.Name = "colUrl";
            this.colUrl.ReadOnly = true;
            this.colUrl.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colUrl.Width = 360;
            // 
            // colBrowserImage
            // 
            this.colBrowserImage.HeaderText = "";
            this.colBrowserImage.Name = "colBrowserImage";
            this.colBrowserImage.ReadOnly = true;
            this.colBrowserImage.Width = 24;
            // 
            // colBrowser
            // 
            this.colBrowser.HeaderText = "웹 브라우저";
            this.colBrowser.Name = "colBrowser";
            this.colBrowser.ReadOnly = true;
            this.colBrowser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBrowser.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 470);
            this.Controls.Add(this.grpRulesSection);
            this.Controls.Add(this.grpDefaultsSection);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BrowserSelector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grdRules)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDefaultsSection.ResumeLayout(false);
            this.grpDefaultsSection.PerformLayout();
            this.grpRulesSection.ResumeLayout(false);
            this.grpRulesSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.DataGridView grdRules;
        private System.Windows.Forms.Button btnRemoveUrl;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Label lblFallback;
        private System.Windows.Forms.Label lblDefaultDesc;
        private System.Windows.Forms.CheckBox chkUseDefault;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unregisterBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsDefaultBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpDefaultsSection;
        private System.Windows.Forms.GroupBox grpRulesSection;
        private System.Windows.Forms.ComboBox cboMatchType;
        private System.Windows.Forms.ImageList imlButtons;
        private System.Windows.Forms.ImageList imlBrowsers;
        private ImageComboBox.ImageComboBox cboDefaultBrowser;
        private ImageComboBox.ImageComboBox cboBrowser;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUrl;
        private System.Windows.Forms.DataGridViewImageColumn colBrowserImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrowser;
    }
}

