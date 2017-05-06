<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkKeyword = New System.Windows.Forms.CheckBox()
        Me.chkLanguage = New System.Windows.Forms.CheckBox()
        Me.chkAuthor = New System.Windows.Forms.CheckBox()
        Me.txtKeyword = New System.Windows.Forms.TextBox()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.cmbAuthor = New System.Windows.Forms.ComboBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ControlsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(409, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ResetToolStripMenuItem, Me.ToolStripSeparator1, Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(146, 6)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'chkKeyword
        '
        Me.chkKeyword.AutoSize = True
        Me.chkKeyword.BackColor = System.Drawing.SystemColors.Control
        Me.chkKeyword.Checked = True
        Me.chkKeyword.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkKeyword.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkKeyword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKeyword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkKeyword.Location = New System.Drawing.Point(8, 32)
        Me.chkKeyword.Name = "chkKeyword"
        Me.chkKeyword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkKeyword.Size = New System.Drawing.Size(143, 18)
        Me.chkKeyword.TabIndex = 16
        Me.chkKeyword.TabStop = False
        Me.chkKeyword.Text = "By Keywords (5 ',' max)"
        Me.ToolTip1.SetToolTip(Me.chkKeyword, "Enable/Disable Search by Keywords")
        Me.chkKeyword.UseVisualStyleBackColor = False
        '
        'chkLanguage
        '
        Me.chkLanguage.AutoSize = True
        Me.chkLanguage.BackColor = System.Drawing.SystemColors.Control
        Me.chkLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkLanguage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkLanguage.Location = New System.Drawing.Point(8, 80)
        Me.chkLanguage.Name = "chkLanguage"
        Me.chkLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkLanguage.Size = New System.Drawing.Size(90, 18)
        Me.chkLanguage.TabIndex = 15
        Me.chkLanguage.TabStop = False
        Me.chkLanguage.Text = "By Language"
        Me.ToolTip1.SetToolTip(Me.chkLanguage, "Enable/Disable Search by Language")
        Me.chkLanguage.UseVisualStyleBackColor = False
        '
        'chkAuthor
        '
        Me.chkAuthor.AutoSize = True
        Me.chkAuthor.BackColor = System.Drawing.SystemColors.Control
        Me.chkAuthor.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAuthor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuthor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAuthor.Location = New System.Drawing.Point(8, 128)
        Me.chkAuthor.Name = "chkAuthor"
        Me.chkAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAuthor.Size = New System.Drawing.Size(74, 18)
        Me.chkAuthor.TabIndex = 14
        Me.chkAuthor.TabStop = False
        Me.chkAuthor.Text = "By Author"
        Me.ToolTip1.SetToolTip(Me.chkAuthor, "Enable/Disable Search by Author")
        Me.chkAuthor.UseVisualStyleBackColor = False
        '
        'txtKeyword
        '
        Me.txtKeyword.AcceptsReturn = True
        Me.txtKeyword.BackColor = System.Drawing.Color.White
        Me.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeyword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKeyword.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKeyword.Location = New System.Drawing.Point(8, 48)
        Me.txtKeyword.MaxLength = 50
        Me.txtKeyword.Name = "txtKeyword"
        Me.txtKeyword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKeyword.Size = New System.Drawing.Size(153, 20)
        Me.txtKeyword.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtKeyword, "Type in up to 5 COMMAs seperated keywords")
        '
        'cmbLanguage
        '
        Me.cmbLanguage.BackColor = System.Drawing.Color.White
        Me.cmbLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguage.Enabled = False
        Me.cmbLanguage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLanguage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLanguage.Location = New System.Drawing.Point(8, 96)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLanguage.Size = New System.Drawing.Size(153, 22)
        Me.cmbLanguage.Sorted = True
        Me.cmbLanguage.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbLanguage, "This list shows the current Languages to search by")
        '
        'cmbAuthor
        '
        Me.cmbAuthor.BackColor = System.Drawing.Color.White
        Me.cmbAuthor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuthor.Enabled = False
        Me.cmbAuthor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAuthor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAuthor.Location = New System.Drawing.Point(8, 144)
        Me.cmbAuthor.Name = "cmbAuthor"
        Me.cmbAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbAuthor.Size = New System.Drawing.Size(153, 22)
        Me.cmbAuthor.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.cmbAuthor, "This list shows the which authors to search by")
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.Color.White
        Me.lstResults.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstResults.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(175, 48)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstResults.Size = New System.Drawing.Size(217, 144)
        Me.lstResults.Sorted = True
        Me.lstResults.TabIndex = 13
        Me.lstResults.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstResults, "Here are your results")
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(168, 32)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(233, 168)
        Me.Frame1.TabIndex = 17
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Search results:"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(8, 176)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(73, 25)
        Me.cmdSearch.TabIndex = 3
        Me.cmdSearch.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.cmdSearch, "Begin search")
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(88, 176)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(73, 25)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.cmdClose, "Close window")
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AcceptButton = Me.cmdSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(409, 209)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmbAuthor)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.txtKeyword)
        Me.Controls.Add(Me.chkKeyword)
        Me.Controls.Add(Me.chkLanguage)
        Me.Controls.Add(Me.chkAuthor)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search For Record"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents chkKeyword As System.Windows.Forms.CheckBox
    Public WithEvents chkLanguage As System.Windows.Forms.CheckBox
    Public WithEvents chkAuthor As System.Windows.Forms.CheckBox
    Public WithEvents txtKeyword As System.Windows.Forms.TextBox
    Public WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Public WithEvents cmbAuthor As System.Windows.Forms.ComboBox
    Public WithEvents lstResults As System.Windows.Forms.ListBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
