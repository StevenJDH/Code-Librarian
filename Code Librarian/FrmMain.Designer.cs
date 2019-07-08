namespace Code_Librarian
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNewRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuManageAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCreateBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuUpdateCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOpenDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSettings = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAddNewRecord = new System.Windows.Forms.ToolStripButton();
            this.toolStripRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripManageAuthors = new System.Windows.Forms.ToolStripButton();
            this.toolStripManageLanguages = new System.Windows.Forms.ToolStripButton();
            this.toolStripCreateBackup = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.pnlDock = new System.Windows.Forms.Panel();
            this.lstSnippets = new System.Windows.Forms.ListBox();
            this.cmbLanguageFilter = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.pnlDock.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.DatabaseToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(850, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenDatabase,
            this.mnuCloseDatabase,
            this.ToolStripSeparator9,
            this.mnuSettings,
            this.ToolStripSeparator3,
            this.mnuExit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // mnuOpenDatabase
            // 
            this.mnuOpenDatabase.Name = "mnuOpenDatabase";
            this.mnuOpenDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpenDatabase.Size = new System.Drawing.Size(228, 22);
            this.mnuOpenDatabase.Text = "Open Database";
            this.mnuOpenDatabase.Click += new System.EventHandler(this.MnuOpenDatabase_Click);
            // 
            // mnuCloseDatabase
            // 
            this.mnuCloseDatabase.Name = "mnuCloseDatabase";
            this.mnuCloseDatabase.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuCloseDatabase.Size = new System.Drawing.Size(228, 22);
            this.mnuCloseDatabase.Text = "Close Database";
            this.mnuCloseDatabase.Visible = false;
            this.mnuCloseDatabase.Click += new System.EventHandler(this.MnuCloseDatabase_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(225, 6);
            this.ToolStripSeparator9.Visible = false;
            // 
            // mnuSettings
            // 
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSettings.Size = new System.Drawing.Size(228, 22);
            this.mnuSettings.Text = "Settings";
            this.mnuSettings.Click += new System.EventHandler(this.MnuSettings_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuExit.Size = new System.Drawing.Size(228, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // DatabaseToolStripMenuItem
            // 
            this.DatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearch,
            this.toolStripSeparator11,
            this.mnuNewRecord,
            this.mnuEditRecord,
            this.mnuDeleteRecord,
            this.ToolStripSeparator1,
            this.mnuManageAuthors,
            this.mnuManageLanguages,
            this.ToolStripSeparator8,
            this.mnuCreateBackup});
            this.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem";
            this.DatabaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.DatabaseToolStripMenuItem.Text = "Database";
            // 
            // mnuSearch
            // 
            this.mnuSearch.Name = "mnuSearch";
            this.mnuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuSearch.Size = new System.Drawing.Size(217, 22);
            this.mnuSearch.Text = "Search for Record";
            this.mnuSearch.Click += new System.EventHandler(this.MnuSearch_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(214, 6);
            // 
            // mnuNewRecord
            // 
            this.mnuNewRecord.Name = "mnuNewRecord";
            this.mnuNewRecord.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNewRecord.Size = new System.Drawing.Size(217, 22);
            this.mnuNewRecord.Text = "New Record";
            this.mnuNewRecord.Click += new System.EventHandler(this.MnuNewRecord_Click);
            // 
            // mnuEditRecord
            // 
            this.mnuEditRecord.Name = "mnuEditRecord";
            this.mnuEditRecord.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuEditRecord.Size = new System.Drawing.Size(217, 22);
            this.mnuEditRecord.Text = "Edit Record";
            this.mnuEditRecord.Click += new System.EventHandler(this.MnuEditRecord_Click);
            // 
            // mnuDeleteRecord
            // 
            this.mnuDeleteRecord.Name = "mnuDeleteRecord";
            this.mnuDeleteRecord.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuDeleteRecord.Size = new System.Drawing.Size(217, 22);
            this.mnuDeleteRecord.Text = "Delete Record";
            this.mnuDeleteRecord.Click += new System.EventHandler(this.MnuDeleteRecord_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // mnuManageAuthors
            // 
            this.mnuManageAuthors.Name = "mnuManageAuthors";
            this.mnuManageAuthors.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuManageAuthors.Size = new System.Drawing.Size(217, 22);
            this.mnuManageAuthors.Text = "Manage Authors";
            this.mnuManageAuthors.Click += new System.EventHandler(this.MnuManageAuthors_Click);
            // 
            // mnuManageLanguages
            // 
            this.mnuManageLanguages.Name = "mnuManageLanguages";
            this.mnuManageLanguages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mnuManageLanguages.Size = new System.Drawing.Size(217, 22);
            this.mnuManageLanguages.Text = "Manage Languages";
            this.mnuManageLanguages.Click += new System.EventHandler(this.MnuManageLanguages_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(214, 6);
            // 
            // mnuCreateBackup
            // 
            this.mnuCreateBackup.Name = "mnuCreateBackup";
            this.mnuCreateBackup.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuCreateBackup.Size = new System.Drawing.Size(217, 22);
            this.mnuCreateBackup.Text = "Create Backup...";
            this.mnuCreateBackup.Click += new System.EventHandler(this.MnuCreateBackup_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDonate,
            this.ToolStripSeparator2,
            this.mnuUpdateCheck,
            this.mnuAbout});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // mnuDonate
            // 
            this.mnuDonate.Name = "mnuDonate";
            this.mnuDonate.Size = new System.Drawing.Size(182, 22);
            this.mnuDonate.Text = "Donate 5€ (Paypal)...";
            this.mnuDonate.Click += new System.EventHandler(this.MnuDonate_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // mnuUpdateCheck
            // 
            this.mnuUpdateCheck.Name = "mnuUpdateCheck";
            this.mnuUpdateCheck.Size = new System.Drawing.Size(182, 22);
            this.mnuUpdateCheck.Text = "Check for Updates";
            this.mnuUpdateCheck.Click += new System.EventHandler(this.MnuUpdateCheck_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(182, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripInfo,
            this.toolStripTime,
            this.toolStripDate});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 505);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(850, 22);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.AutoSize = false;
            this.toolStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(750, 17);
            this.toolStripInfo.Spring = true;
            this.toolStripInfo.Text = "Info";
            this.toolStripInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripInfo.ToolTipText = "Shows current number of records in the database";
            // 
            // toolStripTime
            // 
            this.toolStripTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripTime.Text = "Time";
            this.toolStripTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripTime.ToolTipText = "Current time";
            // 
            // toolStripDate
            // 
            this.toolStripDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripDate.Size = new System.Drawing.Size(51, 17);
            this.toolStripDate.Text = "Date";
            this.toolStripDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripDate.ToolTipText = "Current date";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpenDatabase,
            this.toolStripSettings,
            this.ToolStripSeparator4,
            this.toolStripAddNewRecord,
            this.toolStripRefresh,
            this.toolStripSearch,
            this.toolStripDeleteRecord,
            this.ToolStripSeparator5,
            this.toolStripManageAuthors,
            this.toolStripManageLanguages,
            this.toolStripCreateBackup,
            this.ToolStripSeparator6,
            this.toolStripAbout,
            this.ToolStripSeparator7});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(850, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripOpenDatabase
            // 
            this.toolStripOpenDatabase.AutoSize = false;
            this.toolStripOpenDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenDatabase.Image = global::Code_Librarian.Properties.Resources.open;
            this.toolStripOpenDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenDatabase.Name = "toolStripOpenDatabase";
            this.toolStripOpenDatabase.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenDatabase.ToolTipText = "Open an existing database";
            this.toolStripOpenDatabase.Click += new System.EventHandler(this.ToolStripOpenDatabase_Click);
            // 
            // toolStripSettings
            // 
            this.toolStripSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSettings.Image = global::Code_Librarian.Properties.Resources.settings;
            this.toolStripSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSettings.Name = "toolStripSettings";
            this.toolStripSettings.Size = new System.Drawing.Size(23, 22);
            this.toolStripSettings.ToolTipText = "Settings";
            this.toolStripSettings.Click += new System.EventHandler(this.ToolStripSettings_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripAddNewRecord
            // 
            this.toolStripAddNewRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAddNewRecord.Image = global::Code_Librarian.Properties.Resources.add;
            this.toolStripAddNewRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAddNewRecord.Name = "toolStripAddNewRecord";
            this.toolStripAddNewRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripAddNewRecord.ToolTipText = "Add new record";
            this.toolStripAddNewRecord.Click += new System.EventHandler(this.ToolStripAddNewRecord_Click);
            // 
            // toolStripRefresh
            // 
            this.toolStripRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRefresh.Image = global::Code_Librarian.Properties.Resources.refresh;
            this.toolStripRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRefresh.Name = "toolStripRefresh";
            this.toolStripRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripRefresh.ToolTipText = "Refresh list";
            this.toolStripRefresh.Click += new System.EventHandler(this.ToolStripRefresh_Click);
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearch.Image = global::Code_Librarian.Properties.Resources.search;
            this.toolStripSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(23, 22);
            this.toolStripSearch.ToolTipText = "Search for a specific record";
            this.toolStripSearch.Click += new System.EventHandler(this.ToolStripSearch_Click);
            // 
            // toolStripDeleteRecord
            // 
            this.toolStripDeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteRecord.Image = global::Code_Librarian.Properties.Resources.delete;
            this.toolStripDeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteRecord.Name = "toolStripDeleteRecord";
            this.toolStripDeleteRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteRecord.ToolTipText = "Delete a record from the database";
            this.toolStripDeleteRecord.Click += new System.EventHandler(this.ToolStripDeleteRecord_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripManageAuthors
            // 
            this.toolStripManageAuthors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripManageAuthors.Image = global::Code_Librarian.Properties.Resources.author;
            this.toolStripManageAuthors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripManageAuthors.Name = "toolStripManageAuthors";
            this.toolStripManageAuthors.Size = new System.Drawing.Size(23, 22);
            this.toolStripManageAuthors.ToolTipText = "Manage authors";
            this.toolStripManageAuthors.Click += new System.EventHandler(this.ToolStripManageAuthors_Click);
            // 
            // toolStripManageLanguages
            // 
            this.toolStripManageLanguages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripManageLanguages.Image = global::Code_Librarian.Properties.Resources.lang;
            this.toolStripManageLanguages.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripManageLanguages.Name = "toolStripManageLanguages";
            this.toolStripManageLanguages.Size = new System.Drawing.Size(23, 22);
            this.toolStripManageLanguages.ToolTipText = "Manage languages";
            this.toolStripManageLanguages.Click += new System.EventHandler(this.ToolStripManageLanguages_Click);
            // 
            // toolStripCreateBackup
            // 
            this.toolStripCreateBackup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCreateBackup.Image = global::Code_Librarian.Properties.Resources.database;
            this.toolStripCreateBackup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCreateBackup.Name = "toolStripCreateBackup";
            this.toolStripCreateBackup.Size = new System.Drawing.Size(23, 22);
            this.toolStripCreateBackup.ToolTipText = "Creates a backup of your personal database";
            this.toolStripCreateBackup.Click += new System.EventHandler(this.ToolStripCreateBackup_Click);
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAbout.Image = global::Code_Librarian.Properties.Resources.about;
            this.toolStripAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripAbout.ToolTipText = "About";
            this.toolStripAbout.Click += new System.EventHandler(this.ToolStripAbout_Click);
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // pnlDock
            // 
            this.pnlDock.Controls.Add(this.lstSnippets);
            this.pnlDock.Controls.Add(this.cmbLanguageFilter);
            this.pnlDock.Controls.Add(this.btnEdit);
            this.pnlDock.Controls.Add(this.btnView);
            this.pnlDock.Controls.Add(this.btnRefresh);
            this.pnlDock.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDock.Location = new System.Drawing.Point(0, 49);
            this.pnlDock.Name = "pnlDock";
            this.pnlDock.Size = new System.Drawing.Size(193, 456);
            this.pnlDock.TabIndex = 7;
            // 
            // lstSnippets
            // 
            this.lstSnippets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lstSnippets.FormattingEnabled = true;
            this.lstSnippets.Location = new System.Drawing.Point(8, 104);
            this.lstSnippets.Name = "lstSnippets";
            this.lstSnippets.Size = new System.Drawing.Size(176, 342);
            this.lstSnippets.Sorted = true;
            this.lstSnippets.TabIndex = 2;
            this.lstSnippets.DoubleClick += new System.EventHandler(this.LstSnippets_DoubleClick);
            this.lstSnippets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LstSnippets_KeyDown);
            // 
            // cmbLanguageFilter
            // 
            this.cmbLanguageFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguageFilter.FormattingEnabled = true;
            this.cmbLanguageFilter.Location = new System.Drawing.Point(8, 72);
            this.cmbLanguageFilter.Name = "cmbLanguageFilter";
            this.cmbLanguageFilter.Size = new System.Drawing.Size(177, 21);
            this.cmbLanguageFilter.TabIndex = 4;
            this.cmbLanguageFilter.SelectedIndexChanged += new System.EventHandler(this.CmbLanguageFilter_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(100, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(8, 40);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(85, 25);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(8, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(177, 25);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Enabled = true;
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.TmrDateTime_Tick);
            // 
            // fbDialog
            // 
            this.fbDialog.Description = "Select a folder to backup the database to:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Title = "Open Database";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 527);
            this.Controls.Add(this.pnlDock);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Librarian";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.pnlDock.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuOpenDatabase;
        internal System.Windows.Forms.ToolStripMenuItem mnuCloseDatabase;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripMenuItem mnuSettings;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem mnuExit;
        internal System.Windows.Forms.ToolStripMenuItem DatabaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuSearch;
        internal System.Windows.Forms.ToolStripMenuItem mnuNewRecord;
        internal System.Windows.Forms.ToolStripMenuItem mnuDeleteRecord;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem mnuManageAuthors;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuDonate;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem mnuAbout;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripInfo;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripTime;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton toolStripOpenDatabase;
        internal System.Windows.Forms.ToolStripButton toolStripSettings;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton toolStripAddNewRecord;
        internal System.Windows.Forms.ToolStripButton toolStripRefresh;
        internal System.Windows.Forms.ToolStripButton toolStripSearch;
        internal System.Windows.Forms.ToolStripButton toolStripDeleteRecord;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton toolStripManageAuthors;
        internal System.Windows.Forms.ToolStripButton toolStripManageLanguages;
        internal System.Windows.Forms.ToolStripButton toolStripCreateBackup;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton toolStripAbout;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.Panel pnlDock;
        internal System.Windows.Forms.ListBox lstSnippets;
        internal System.Windows.Forms.ComboBox cmbLanguageFilter;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateCheck;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem mnuEditRecord;
        private System.Windows.Forms.ToolStripMenuItem mnuManageLanguages;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateBackup;
    }
}

