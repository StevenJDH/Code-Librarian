<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseDatabaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchForRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditAuthorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompactRepairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveBackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stbInfo = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DateToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.picList = New System.Windows.Forms.Panel()
        Me.lstCode = New System.Windows.Forms.ListBox()
        Me.FilterLanguage = New System.Windows.Forms.ComboBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TimerClock = New System.Windows.Forms.Timer(Me.components)
        Me.FBDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.picList.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDatabaseToolStripMenuItem, Me.CloseDatabaseToolStripMenuItem1, Me.ToolStripSeparator9, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenDatabaseToolStripMenuItem
        '
        Me.OpenDatabaseToolStripMenuItem.Name = "OpenDatabaseToolStripMenuItem"
        Me.OpenDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenDatabaseToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.OpenDatabaseToolStripMenuItem.Text = "Open Database"
        '
        'CloseDatabaseToolStripMenuItem1
        '
        Me.CloseDatabaseToolStripMenuItem1.Name = "CloseDatabaseToolStripMenuItem1"
        Me.CloseDatabaseToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.CloseDatabaseToolStripMenuItem1.Text = "Close Database"
        Me.CloseDatabaseToolStripMenuItem1.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(194, 6)
        Me.ToolStripSeparator9.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(194, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchForRecordToolStripMenuItem, Me.AddNewRecordToolStripMenuItem, Me.DeleteRecordToolStripMenuItem1, Me.ToolStripSeparator1, Me.MaintenanceToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'SearchForRecordToolStripMenuItem
        '
        Me.SearchForRecordToolStripMenuItem.Name = "SearchForRecordToolStripMenuItem"
        Me.SearchForRecordToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.SearchForRecordToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.SearchForRecordToolStripMenuItem.Text = "Search For Record"
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddNewRecordToolStripMenuItem.Text = "Add New Record"
        '
        'DeleteRecordToolStripMenuItem1
        '
        Me.DeleteRecordToolStripMenuItem1.Name = "DeleteRecordToolStripMenuItem1"
        Me.DeleteRecordToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteRecordToolStripMenuItem1.Size = New System.Drawing.Size(206, 22)
        Me.DeleteRecordToolStripMenuItem1.Text = "Delete Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(203, 6)
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditAuthorsToolStripMenuItem, Me.AddEditLanguageToolStripMenuItem, Me.ToolStripSeparator8, Me.CompactRepairToolStripMenuItem, Me.ToolStripSeparator10, Me.SaveBackupToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'AddEditAuthorsToolStripMenuItem
        '
        Me.AddEditAuthorsToolStripMenuItem.Name = "AddEditAuthorsToolStripMenuItem"
        Me.AddEditAuthorsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.AddEditAuthorsToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.AddEditAuthorsToolStripMenuItem.Text = "Add/Edit Authors"
        '
        'AddEditLanguageToolStripMenuItem
        '
        Me.AddEditLanguageToolStripMenuItem.Name = "AddEditLanguageToolStripMenuItem"
        Me.AddEditLanguageToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.AddEditLanguageToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.AddEditLanguageToolStripMenuItem.Text = "Add/Edit Language"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(298, 6)
        '
        'CompactRepairToolStripMenuItem
        '
        Me.CompactRepairToolStripMenuItem.Name = "CompactRepairToolStripMenuItem"
        Me.CompactRepairToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.CompactRepairToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.CompactRepairToolStripMenuItem.Text = "Compact/Repair Personal Database"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(298, 6)
        '
        'SaveBackupToolStripMenuItem
        '
        Me.SaveBackupToolStripMenuItem.Name = "SaveBackupToolStripMenuItem"
        Me.SaveBackupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.SaveBackupToolStripMenuItem.Size = New System.Drawing.Size(301, 22)
        Me.SaveBackupToolStripMenuItem.Text = "Create Backup..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem1, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'DonateToolStripMenuItem1
        '
        Me.DonateToolStripMenuItem1.Name = "DonateToolStripMenuItem1"
        Me.DonateToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.DonateToolStripMenuItem1.Text = "Donate 5€ (Paypal)..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stbInfo, Me.TimeToolStripStatusLabel1, Me.DateToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 505)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(802, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stbInfo
        '
        Me.stbInfo.AutoSize = False
        Me.stbInfo.Name = "stbInfo"
        Me.stbInfo.Size = New System.Drawing.Size(608, 17)
        Me.stbInfo.Text = "Status"
        Me.stbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.stbInfo.ToolTipText = "Shows current number of records in the database"
        '
        'TimeToolStripStatusLabel1
        '
        Me.TimeToolStripStatusLabel1.AutoSize = False
        Me.TimeToolStripStatusLabel1.Name = "TimeToolStripStatusLabel1"
        Me.TimeToolStripStatusLabel1.Size = New System.Drawing.Size(86, 17)
        Me.TimeToolStripStatusLabel1.Text = "Time"
        Me.TimeToolStripStatusLabel1.ToolTipText = "Current time"
        '
        'DateToolStripStatusLabel2
        '
        Me.DateToolStripStatusLabel2.AutoSize = False
        Me.DateToolStripStatusLabel2.Name = "DateToolStripStatusLabel2"
        Me.DateToolStripStatusLabel2.Size = New System.Drawing.Size(86, 17)
        Me.DateToolStripStatusLabel2.Text = "Date"
        Me.DateToolStripStatusLabel2.ToolTipText = "Current date"
        '
        'picList
        '
        Me.picList.Controls.Add(Me.lstCode)
        Me.picList.Controls.Add(Me.FilterLanguage)
        Me.picList.Controls.Add(Me.cmdEdit)
        Me.picList.Controls.Add(Me.cmdView)
        Me.picList.Controls.Add(Me.cmdRefresh)
        Me.picList.Dock = System.Windows.Forms.DockStyle.Left
        Me.picList.Location = New System.Drawing.Point(0, 49)
        Me.picList.Name = "picList"
        Me.picList.Size = New System.Drawing.Size(153, 456)
        Me.picList.TabIndex = 4
        '
        'lstCode
        '
        Me.lstCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.lstCode.FormattingEnabled = True
        Me.lstCode.Location = New System.Drawing.Point(8, 104)
        Me.lstCode.Name = "lstCode"
        Me.lstCode.Size = New System.Drawing.Size(136, 342)
        Me.lstCode.Sorted = True
        Me.lstCode.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lstCode, "A list that displays the records")
        '
        'FilterLanguage
        '
        Me.FilterLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FilterLanguage.FormattingEnabled = True
        Me.FilterLanguage.Location = New System.Drawing.Point(8, 72)
        Me.FilterLanguage.Name = "FilterLanguage"
        Me.FilterLanguage.Size = New System.Drawing.Size(137, 21)
        Me.FilterLanguage.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.FilterLanguage, "Filters programming languages")
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(80, 40)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(65, 25)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.cmdEdit, "Edit code record for highlighted")
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(8, 40)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(65, 25)
        Me.cmdView.TabIndex = 0
        Me.cmdView.Text = "View"
        Me.ToolTip1.SetToolTip(Me.cmdView, "View code record for highlighted")
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(8, 8)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(137, 25)
        Me.cmdRefresh.TabIndex = 3
        Me.cmdRefresh.Text = "Refresh List"
        Me.ToolTip1.SetToolTip(Me.cmdRefresh, "Reloads the list from database")
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'dlgOpen
        '
        Me.dlgOpen.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton10, Me.ToolStripSeparator5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton9, Me.ToolStripSeparator6, Me.ToolStripButton8, Me.ToolStripSeparator7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(802, 25)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Code_Librarian.My.Resources.Resources.open
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.ToolTipText = "Open an existing database"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Code_Librarian.My.Resources.Resources.settings
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.ToolTipText = "Settings"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Code_Librarian.My.Resources.Resources.add
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.ToolTipText = "Add new record"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.Code_Librarian.My.Resources.Resources.refresh
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.ToolTipText = "Refresh list"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.Code_Librarian.My.Resources.Resources.search
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.ToolTipText = "Search for a specific record"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = Global.Code_Librarian.My.Resources.Resources._Exit
        Me.ToolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.ToolTipText = "Deletes a record from the database"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = Global.Code_Librarian.My.Resources.Resources.author
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.ToolTipText = "Add/edit author information"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = Global.Code_Librarian.My.Resources.Resources.lang
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.ToolTipText = "Add/edit language information"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = Global.Code_Librarian.My.Resources.Resources.database
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.ToolTipText = "Creates a backup of your personal database"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = Global.Code_Librarian.My.Resources.Resources.about
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.ToolTipText = "About"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'TimerClock
        '
        Me.TimerClock.Enabled = True
        Me.TimerClock.Interval = 1000
        '
        'FrmMain
        '
        Me.AcceptButton = Me.cmdView
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 527)
        Me.Controls.Add(Me.picList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Code Librarian"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.picList.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents picList As System.Windows.Forms.Panel
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FilterLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdView As System.Windows.Forms.Button
    Friend WithEvents lstCode As System.Windows.Forms.ListBox
    Friend WithEvents stbInfo As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimeToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DateToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OpenDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchForRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewRecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditAuthorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddEditLanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TimerClock As System.Windows.Forms.Timer
    Friend WithEvents DonateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveBackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FBDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteRecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseDatabaseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompactRepairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button

End Class
