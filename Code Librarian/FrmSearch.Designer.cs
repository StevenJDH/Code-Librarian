namespace Code_Librarian
{
    partial class FrmSearch
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbAuthors = new System.Windows.Forms.ComboBox();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.chkKeywords = new System.Windows.Forms.CheckBox();
            this.chkLanguage = new System.Windows.Forms.CheckBox();
            this.chkAuthor = new System.Windows.Forms.CheckBox();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.ControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.lstViewResults = new System.Windows.Forms.ListView();
            this.clmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Frame1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(88, 174);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 25);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.BackColor = System.Drawing.Color.White;
            this.cmbAuthors.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthors.Enabled = false;
            this.cmbAuthors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAuthors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbAuthors.Location = new System.Drawing.Point(8, 143);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbAuthors.Size = new System.Drawing.Size(153, 22);
            this.cmbAuthors.TabIndex = 3;
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.BackColor = System.Drawing.Color.White;
            this.cmbLanguages.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.Enabled = false;
            this.cmbLanguages.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbLanguages.Location = new System.Drawing.Point(8, 93);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbLanguages.Size = new System.Drawing.Size(153, 22);
            this.cmbLanguages.Sorted = true;
            this.cmbLanguages.TabIndex = 2;
            // 
            // txtKeywords
            // 
            this.txtKeywords.AcceptsReturn = true;
            this.txtKeywords.BackColor = System.Drawing.Color.White;
            this.txtKeywords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeywords.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeywords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeywords.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKeywords.Location = new System.Drawing.Point(8, 47);
            this.txtKeywords.MaxLength = 255;
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKeywords.Size = new System.Drawing.Size(153, 20);
            this.txtKeywords.TabIndex = 1;
            // 
            // chkKeywords
            // 
            this.chkKeywords.AutoSize = true;
            this.chkKeywords.BackColor = System.Drawing.SystemColors.Control;
            this.chkKeywords.Checked = true;
            this.chkKeywords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKeywords.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkKeywords.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkKeywords.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkKeywords.Location = new System.Drawing.Point(8, 29);
            this.chkKeywords.Name = "chkKeywords";
            this.chkKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkKeywords.Size = new System.Drawing.Size(155, 18);
            this.chkKeywords.TabIndex = 27;
            this.chkKeywords.TabStop = false;
            this.chkKeywords.Text = "By Keywords (Comma list)";
            this.chkKeywords.UseVisualStyleBackColor = false;
            this.chkKeywords.CheckedChanged += new System.EventHandler(this.ChkKeywords_CheckedChanged);
            // 
            // chkLanguage
            // 
            this.chkLanguage.AutoSize = true;
            this.chkLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.chkLanguage.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkLanguage.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkLanguage.Location = new System.Drawing.Point(8, 75);
            this.chkLanguage.Name = "chkLanguage";
            this.chkLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkLanguage.Size = new System.Drawing.Size(90, 18);
            this.chkLanguage.TabIndex = 26;
            this.chkLanguage.TabStop = false;
            this.chkLanguage.Text = "By Language";
            this.chkLanguage.UseVisualStyleBackColor = false;
            this.chkLanguage.CheckedChanged += new System.EventHandler(this.ChkLanguage_CheckedChanged);
            // 
            // chkAuthor
            // 
            this.chkAuthor.AutoSize = true;
            this.chkAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.chkAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAuthor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAuthor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAuthor.Location = new System.Drawing.Point(8, 125);
            this.chkAuthor.Name = "chkAuthor";
            this.chkAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAuthor.Size = new System.Drawing.Size(74, 18);
            this.chkAuthor.TabIndex = 25;
            this.chkAuthor.TabStop = false;
            this.chkAuthor.Text = "By Author";
            this.chkAuthor.UseVisualStyleBackColor = false;
            this.chkAuthor.CheckedChanged += new System.EventHandler(this.ChkAuthor_CheckedChanged);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuView.Size = new System.Drawing.Size(149, 22);
            this.mnuView.Text = "View";
            this.mnuView.Click += new System.EventHandler(this.MnuView_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuReset.Size = new System.Drawing.Size(149, 22);
            this.mnuReset.Text = "Reset";
            this.mnuReset.Click += new System.EventHandler(this.MnuReset_Click);
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSearch.Size = new System.Drawing.Size(149, 22);
            this.mnuSearch.Text = "Search";
            this.mnuSearch.Click += new System.EventHandler(this.MnuSearch_Click);
            // 
            // ControlsToolStripMenuItem
            // 
            this.ControlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch,
            this.mnuReset,
            this.ToolStripSeparator1,
            this.mnuView,
            this.mnuEdit});
            this.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem";
            this.ControlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.ControlsToolStripMenuItem.Text = "Controls";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEdit.Size = new System.Drawing.Size(149, 22);
            this.mnuEdit.Text = "Edit";
            this.mnuEdit.Click += new System.EventHandler(this.MnuEdit_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuExit.Size = new System.Drawing.Size(135, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.lstViewResults);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(168, 31);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(0);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(233, 168);
            this.Frame1.TabIndex = 28;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Search results:";
            // 
            // lstViewResults
            // 
            this.lstViewResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTitle,
            this.clmLanguage});
            this.lstViewResults.FullRowSelect = true;
            this.lstViewResults.GridLines = true;
            this.lstViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstViewResults.HideSelection = false;
            this.lstViewResults.Location = new System.Drawing.Point(8, 16);
            this.lstViewResults.MultiSelect = false;
            this.lstViewResults.Name = "lstViewResults";
            this.lstViewResults.Size = new System.Drawing.Size(216, 143);
            this.lstViewResults.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lstViewResults.TabIndex = 5;
            this.lstViewResults.UseCompatibleStateImageBehavior = false;
            this.lstViewResults.View = System.Windows.Forms.View.Details;
            this.lstViewResults.DoubleClick += new System.EventHandler(this.LstViewResults_DoubleClick);
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Title";
            this.clmTitle.Width = 216;
            // 
            // clmLanguage
            // 
            this.clmLanguage.Width = 0;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ControlsToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(405, 24);
            this.MenuStrip1.TabIndex = 19;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FrmSearch
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(409, 209);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.txtKeywords);
            this.Controls.Add(this.chkKeywords);
            this.Controls.Add(this.chkLanguage);
            this.Controls.Add(this.chkAuthor);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSearch";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search for Record";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.Frame1.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.ComboBox cmbAuthors;
        public System.Windows.Forms.ComboBox cmbLanguages;
        public System.Windows.Forms.TextBox txtKeywords;
        public System.Windows.Forms.CheckBox chkKeywords;
        public System.Windows.Forms.CheckBox chkLanguage;
        public System.Windows.Forms.CheckBox chkAuthor;
        internal System.Windows.Forms.ToolStripMenuItem mnuView;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem mnuReset;
        internal System.Windows.Forms.ToolStripMenuItem mnuSearch;
        internal System.Windows.Forms.ToolStripMenuItem ControlsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuEdit;
        internal System.Windows.Forms.ToolStripMenuItem mnuExit;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        public System.Windows.Forms.GroupBox Frame1;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ListView lstViewResults;
        private System.Windows.Forms.ColumnHeader clmTitle;
        private System.Windows.Forms.ColumnHeader clmLanguage;
    }
}