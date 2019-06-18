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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchForRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddEditLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DonateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDeleteRecord = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.picList = new System.Windows.Forms.Panel();
            this.lstSnippets = new System.Windows.Forms.ListBox();
            this.cmbLanguageFilter = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.picList.SuspendLayout();
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
            this.MenuStrip1.Size = new System.Drawing.Size(809, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDatabaseToolStripMenuItem,
            this.CloseDatabaseToolStripMenuItem1,
            this.ToolStripSeparator9,
            this.SettingsToolStripMenuItem,
            this.ToolStripSeparator3,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenDatabaseToolStripMenuItem
            // 
            this.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem";
            this.OpenDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenDatabaseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.OpenDatabaseToolStripMenuItem.Text = "Open Database";
            // 
            // CloseDatabaseToolStripMenuItem1
            // 
            this.CloseDatabaseToolStripMenuItem1.Name = "CloseDatabaseToolStripMenuItem1";
            this.CloseDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.CloseDatabaseToolStripMenuItem1.Text = "Close Database";
            this.CloseDatabaseToolStripMenuItem1.Visible = false;
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(194, 6);
            this.ToolStripSeparator9.Visible = false;
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(194, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // DatabaseToolStripMenuItem
            // 
            this.DatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchForRecordToolStripMenuItem,
            this.AddNewRecordToolStripMenuItem,
            this.mnuDeleteRecord,
            this.ToolStripSeparator1,
            this.MaintenanceToolStripMenuItem});
            this.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem";
            this.DatabaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.DatabaseToolStripMenuItem.Text = "Database";
            // 
            // SearchForRecordToolStripMenuItem
            // 
            this.SearchForRecordToolStripMenuItem.Name = "SearchForRecordToolStripMenuItem";
            this.SearchForRecordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.SearchForRecordToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.SearchForRecordToolStripMenuItem.Text = "Search For Record";
            // 
            // AddNewRecordToolStripMenuItem
            // 
            this.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem";
            this.AddNewRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.AddNewRecordToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.AddNewRecordToolStripMenuItem.Text = "Add New Record";
            // 
            // mnuDeleteRecord
            // 
            this.mnuDeleteRecord.Name = "mnuDeleteRecord";
            this.mnuDeleteRecord.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.mnuDeleteRecord.Size = new System.Drawing.Size(206, 22);
            this.mnuDeleteRecord.Text = "Delete Record";
            this.mnuDeleteRecord.Click += new System.EventHandler(this.MnuDeleteRecord_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // MaintenanceToolStripMenuItem
            // 
            this.MaintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddEditAuthorsToolStripMenuItem,
            this.AddEditLanguageToolStripMenuItem,
            this.ToolStripSeparator8,
            this.SaveBackupToolStripMenuItem});
            this.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem";
            this.MaintenanceToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.MaintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // AddEditAuthorsToolStripMenuItem
            // 
            this.AddEditAuthorsToolStripMenuItem.Name = "AddEditAuthorsToolStripMenuItem";
            this.AddEditAuthorsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.AddEditAuthorsToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.AddEditAuthorsToolStripMenuItem.Text = "Add/Edit Authors";
            // 
            // AddEditLanguageToolStripMenuItem
            // 
            this.AddEditLanguageToolStripMenuItem.Name = "AddEditLanguageToolStripMenuItem";
            this.AddEditLanguageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.AddEditLanguageToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.AddEditLanguageToolStripMenuItem.Text = "Add/Edit Language";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(213, 6);
            // 
            // SaveBackupToolStripMenuItem
            // 
            this.SaveBackupToolStripMenuItem.Name = "SaveBackupToolStripMenuItem";
            this.SaveBackupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.SaveBackupToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.SaveBackupToolStripMenuItem.Text = "Create Backup...";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DonateToolStripMenuItem1,
            this.ToolStripSeparator2,
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // DonateToolStripMenuItem1
            // 
            this.DonateToolStripMenuItem1.Name = "DonateToolStripMenuItem1";
            this.DonateToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.DonateToolStripMenuItem1.Text = "Donate 5€ (Paypal)...";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripInfo,
            this.toolStripTime,
            this.toolStripDate});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 505);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(809, 22);
            this.StatusStrip1.SizingGrip = false;
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.AutoSize = false;
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(608, 17);
            this.toolStripInfo.Text = "Info";
            this.toolStripInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripInfo.ToolTipText = "Shows current number of records in the database";
            // 
            // toolStripTime
            // 
            this.toolStripTime.AutoSize = false;
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(86, 17);
            this.toolStripTime.Text = "Time";
            this.toolStripTime.ToolTipText = "Current time";
            // 
            // toolStripDate
            // 
            this.toolStripDate.AutoSize = false;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(86, 17);
            this.toolStripDate.Text = "Date";
            this.toolStripDate.ToolTipText = "Current date";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton1,
            this.ToolStripButton2,
            this.ToolStripSeparator4,
            this.ToolStripButton3,
            this.ToolStripButton4,
            this.ToolStripButton5,
            this.toolStripDeleteRecord,
            this.ToolStripSeparator5,
            this.ToolStripButton6,
            this.ToolStripButton7,
            this.ToolStripButton9,
            this.ToolStripSeparator6,
            this.ToolStripButton8,
            this.ToolStripSeparator7});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(809, 25);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.AutoSize = false;
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = global::Code_Librarian.Properties.Resources.open;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton1.ToolTipText = "Open an existing database";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Image = global::Code_Librarian.Properties.Resources.settings;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton2.ToolTipText = "Settings";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.Image = global::Code_Librarian.Properties.Resources.add;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton3.ToolTipText = "Add new record";
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton4.Image = global::Code_Librarian.Properties.Resources.refresh;
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton4.ToolTipText = "Refresh list";
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton5.Image = global::Code_Librarian.Properties.Resources.search;
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton5.ToolTipText = "Search for a specific record";
            // 
            // toolStripDeleteRecord
            // 
            this.toolStripDeleteRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDeleteRecord.Image = global::Code_Librarian.Properties.Resources.delete;
            this.toolStripDeleteRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDeleteRecord.Name = "toolStripDeleteRecord";
            this.toolStripDeleteRecord.Size = new System.Drawing.Size(23, 22);
            this.toolStripDeleteRecord.ToolTipText = "Deletes a record from the database";
            this.toolStripDeleteRecord.Click += new System.EventHandler(this.ToolStripDeleteRecord_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton6.Image = global::Code_Librarian.Properties.Resources.author;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton6.ToolTipText = "Add/edit author information";
            // 
            // ToolStripButton7
            // 
            this.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton7.Image = global::Code_Librarian.Properties.Resources.lang;
            this.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton7.ToolTipText = "Add/edit language information";
            // 
            // ToolStripButton9
            // 
            this.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton9.Image = global::Code_Librarian.Properties.Resources.database;
            this.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton9.Name = "ToolStripButton9";
            this.ToolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton9.ToolTipText = "Creates a backup of your personal database";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton8.Image = global::Code_Librarian.Properties.Resources.about;
            this.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton8.ToolTipText = "About";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // picList
            // 
            this.picList.Controls.Add(this.lstSnippets);
            this.picList.Controls.Add(this.cmbLanguageFilter);
            this.picList.Controls.Add(this.btnEdit);
            this.picList.Controls.Add(this.btnView);
            this.picList.Controls.Add(this.btnRefresh);
            this.picList.Dock = System.Windows.Forms.DockStyle.Left;
            this.picList.Location = new System.Drawing.Point(0, 49);
            this.picList.Name = "picList";
            this.picList.Size = new System.Drawing.Size(153, 456);
            this.picList.TabIndex = 7;
            // 
            // lstSnippets
            // 
            this.lstSnippets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.lstSnippets.FormattingEnabled = true;
            this.lstSnippets.Location = new System.Drawing.Point(8, 104);
            this.lstSnippets.Name = "lstSnippets";
            this.lstSnippets.Size = new System.Drawing.Size(136, 342);
            this.lstSnippets.Sorted = true;
            this.lstSnippets.TabIndex = 2;
            // 
            // cmbLanguageFilter
            // 
            this.cmbLanguageFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguageFilter.FormattingEnabled = true;
            this.cmbLanguageFilter.Location = new System.Drawing.Point(8, 72);
            this.cmbLanguageFilter.Name = "cmbLanguageFilter";
            this.cmbLanguageFilter.Size = new System.Drawing.Size(137, 21);
            this.cmbLanguageFilter.TabIndex = 4;
            this.cmbLanguageFilter.SelectedIndexChanged += new System.EventHandler(this.CmbLanguageFilter_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(80, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(8, 40);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(65, 25);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.BtnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(8, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(137, 25);
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
            // FrmMain
            // 
            this.AcceptButton = this.btnView;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 527);
            this.Controls.Add(this.picList);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.picList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenDatabaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CloseDatabaseToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator9;
        internal System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DatabaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SearchForRecordToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddNewRecordToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuDeleteRecord;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem MaintenanceToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddEditAuthorsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddEditLanguageToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        internal System.Windows.Forms.ToolStripMenuItem SaveBackupToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem DonateToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripInfo;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripTime;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        public System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton1;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton ToolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton toolStripDeleteRecord;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton6;
        internal System.Windows.Forms.ToolStripButton ToolStripButton7;
        internal System.Windows.Forms.ToolStripButton ToolStripButton9;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        internal System.Windows.Forms.ToolStripButton ToolStripButton8;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        internal System.Windows.Forms.Panel picList;
        internal System.Windows.Forms.ListBox lstSnippets;
        internal System.Windows.Forms.ComboBox cmbLanguageFilter;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrDateTime;
    }
}

