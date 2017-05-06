<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdd
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
        Me.txtKeywords = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtUpdateDate = New System.Windows.Forms.TextBox()
        Me.txtCodeName = New System.Windows.Forms.TextBox()
        Me.txtOrigDate = New System.Windows.Forms.TextBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblCodeName = New System.Windows.Forms.Label()
        Me.lblOrigDate = New System.Windows.Forms.Label()
        Me.lblUpdateDate = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblKeywords = New System.Windows.Forms.Label()
        Me.cmbAuthor = New System.Windows.Forms.ComboBox()
        Me.cmbLanguage = New System.Windows.Forms.ComboBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.rtfCode = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.SuspendLayout()
        '
        'txtKeywords
        '
        Me.txtKeywords.AcceptsReturn = True
        Me.txtKeywords.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtKeywords.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKeywords.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeywords.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtKeywords.Location = New System.Drawing.Point(328, 104)
        Me.txtKeywords.MaxLength = 255
        Me.txtKeywords.Multiline = True
        Me.txtKeywords.Name = "txtKeywords"
        Me.txtKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKeywords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeywords.Size = New System.Drawing.Size(317, 35)
        Me.txtKeywords.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.Location = New System.Drawing.Point(216, 24)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone.Size = New System.Drawing.Size(113, 20)
        Me.txtPhone.TabIndex = 1
        '
        'txtUpdateDate
        '
        Me.txtUpdateDate.AcceptsReturn = True
        Me.txtUpdateDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtUpdateDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUpdateDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateDate.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtUpdateDate.Location = New System.Drawing.Point(368, 64)
        Me.txtUpdateDate.MaxLength = 10
        Me.txtUpdateDate.Name = "txtUpdateDate"
        Me.txtUpdateDate.ReadOnly = True
        Me.txtUpdateDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUpdateDate.Size = New System.Drawing.Size(81, 20)
        Me.txtUpdateDate.TabIndex = 26
        Me.txtUpdateDate.TabStop = False
        Me.txtUpdateDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodeName
        '
        Me.txtCodeName.AcceptsReturn = True
        Me.txtCodeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtCodeName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodeName.Location = New System.Drawing.Point(8, 64)
        Me.txtCodeName.MaxLength = 50
        Me.txtCodeName.Name = "txtCodeName"
        Me.txtCodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodeName.Size = New System.Drawing.Size(265, 20)
        Me.txtCodeName.TabIndex = 2
        Me.txtCodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtCodeName, "Required")
        '
        'txtOrigDate
        '
        Me.txtOrigDate.AcceptsReturn = True
        Me.txtOrigDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtOrigDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOrigDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigDate.ForeColor = System.Drawing.SystemColors.GrayText
        Me.txtOrigDate.Location = New System.Drawing.Point(280, 64)
        Me.txtOrigDate.MaxLength = 10
        Me.txtOrigDate.Name = "txtOrigDate"
        Me.txtOrigDate.ReadOnly = True
        Me.txtOrigDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOrigDate.Size = New System.Drawing.Size(81, 20)
        Me.txtOrigDate.TabIndex = 25
        Me.txtOrigDate.TabStop = False
        Me.txtOrigDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVersion
        '
        Me.txtVersion.AcceptsReturn = True
        Me.txtVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtVersion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtVersion.Location = New System.Drawing.Point(456, 64)
        Me.txtVersion.MaxLength = 5
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtVersion.Size = New System.Drawing.Size(60, 20)
        Me.txtVersion.TabIndex = 3
        Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPurpose
        '
        Me.txtPurpose.AcceptsReturn = True
        Me.txtPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurpose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPurpose.Location = New System.Drawing.Point(8, 104)
        Me.txtPurpose.MaxLength = 255
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPurpose.Size = New System.Drawing.Size(317, 35)
        Me.txtPurpose.TabIndex = 5
        '
        'lblAuthor
        '
        Me.lblAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAuthor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAuthor.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblAuthor.Location = New System.Drawing.Point(8, 8)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAuthor.Size = New System.Drawing.Size(200, 17)
        Me.lblAuthor.TabIndex = 40
        Me.lblAuthor.Text = "Author"
        Me.lblAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblPhone.Location = New System.Drawing.Point(216, 8)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhone.Size = New System.Drawing.Size(113, 17)
        Me.lblPhone.TabIndex = 39
        Me.lblPhone.Text = "Phone/Ext/E-Mail"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCodeName
        '
        Me.lblCodeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCodeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCodeName.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCodeName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCodeName.Location = New System.Drawing.Point(8, 48)
        Me.lblCodeName.Name = "lblCodeName"
        Me.lblCodeName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCodeName.Size = New System.Drawing.Size(265, 17)
        Me.lblCodeName.TabIndex = 38
        Me.lblCodeName.Text = "Code Name/Title"
        Me.lblCodeName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.lblCodeName, "Required")
        '
        'lblOrigDate
        '
        Me.lblOrigDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblOrigDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOrigDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOrigDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrigDate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblOrigDate.Location = New System.Drawing.Point(280, 48)
        Me.lblOrigDate.Name = "lblOrigDate"
        Me.lblOrigDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOrigDate.Size = New System.Drawing.Size(81, 17)
        Me.lblOrigDate.TabIndex = 37
        Me.lblOrigDate.Text = "Create Date"
        Me.lblOrigDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUpdateDate
        '
        Me.lblUpdateDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblUpdateDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdateDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUpdateDate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateDate.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblUpdateDate.Location = New System.Drawing.Point(368, 48)
        Me.lblUpdateDate.Name = "lblUpdateDate"
        Me.lblUpdateDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUpdateDate.Size = New System.Drawing.Size(81, 17)
        Me.lblUpdateDate.TabIndex = 36
        Me.lblUpdateDate.Text = "Last Update"
        Me.lblUpdateDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblVersion.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblVersion.Location = New System.Drawing.Point(456, 48)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVersion.Size = New System.Drawing.Size(60, 17)
        Me.lblVersion.TabIndex = 35
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPurpose
        '
        Me.lblPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPurpose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPurpose.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPurpose.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPurpose.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblPurpose.Location = New System.Drawing.Point(8, 88)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPurpose.Size = New System.Drawing.Size(317, 17)
        Me.lblPurpose.TabIndex = 33
        Me.lblPurpose.Text = "Purpose/Function Of The Code"
        Me.lblPurpose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCode
        '
        Me.lblCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCode.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblCode.Location = New System.Drawing.Point(8, 144)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCode.Size = New System.Drawing.Size(638, 17)
        Me.lblCode.TabIndex = 32
        Me.lblCode.Text = "Code Snippet"
        Me.lblCode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.lblCode, "Required")
        '
        'lblKeywords
        '
        Me.lblKeywords.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblKeywords.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblKeywords.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblKeywords.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeywords.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblKeywords.Location = New System.Drawing.Point(328, 88)
        Me.lblKeywords.Name = "lblKeywords"
        Me.lblKeywords.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblKeywords.Size = New System.Drawing.Size(317, 17)
        Me.lblKeywords.TabIndex = 31
        Me.lblKeywords.Text = "Searchable Keywords (Comma Seperated)"
        Me.lblKeywords.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbAuthor
        '
        Me.cmbAuthor.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbAuthor.FormattingEnabled = True
        Me.cmbAuthor.Location = New System.Drawing.Point(8, 24)
        Me.cmbAuthor.MaxLength = 50
        Me.cmbAuthor.Name = "cmbAuthor"
        Me.cmbAuthor.Size = New System.Drawing.Size(200, 21)
        Me.cmbAuthor.TabIndex = 0
        '
        'cmbLanguage
        '
        Me.cmbLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.cmbLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmbLanguage.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLanguage.Location = New System.Drawing.Point(523, 64)
        Me.cmbLanguage.Name = "cmbLanguage"
        Me.cmbLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbLanguage.Size = New System.Drawing.Size(121, 21)
        Me.cmbLanguage.Sorted = True
        Me.cmbLanguage.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.cmbLanguage, "Required")
        '
        'lblLanguage
        '
        Me.lblLanguage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLanguage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLanguage.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLanguage.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.ForeColor = System.Drawing.SystemColors.MenuText
        Me.lblLanguage.Location = New System.Drawing.Point(523, 48)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLanguage.Size = New System.Drawing.Size(121, 17)
        Me.lblLanguage.TabIndex = 43
        Me.lblLanguage.Text = "Language"
        Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.lblLanguage, "Required")
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(336, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(97, 33)
        Me.cmdAdd.TabIndex = 8
        Me.cmdAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.cmdAdd, "Adds the new record to the database")
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.Location = New System.Drawing.Point(440, 8)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(97, 33)
        Me.cmdReset.TabIndex = 9
        Me.cmdReset.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.cmdReset, "Clears current information")
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(544, 8)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(97, 33)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.cmdExit, "Close window")
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'rtfCode
        '
        Me.rtfCode.AcceptsReturn = True
        Me.rtfCode.AcceptsTab = True
        Me.rtfCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.rtfCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtfCode.Location = New System.Drawing.Point(8, 160)
        Me.rtfCode.Multiline = True
        Me.rtfCode.Name = "rtfCode"
        Me.rtfCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rtfCode.Size = New System.Drawing.Size(638, 296)
        Me.rtfCode.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.rtfCode, "Required")
        '
        'frmAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(655, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.rtfCode)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmbLanguage)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.cmbAuthor)
        Me.Controls.Add(Me.txtKeywords)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtUpdateDate)
        Me.Controls.Add(Me.txtCodeName)
        Me.Controls.Add(Me.txtOrigDate)
        Me.Controls.Add(Me.txtVersion)
        Me.Controls.Add(Me.txtPurpose)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblCodeName)
        Me.Controls.Add(Me.lblOrigDate)
        Me.Controls.Add(Me.lblUpdateDate)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblPurpose)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.lblKeywords)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(661, 490)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(661, 490)
        Me.Name = "frmAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Add New Code Record"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtKeywords As System.Windows.Forms.TextBox
    Public WithEvents txtPhone As System.Windows.Forms.TextBox
    Public WithEvents txtUpdateDate As System.Windows.Forms.TextBox
    Public WithEvents txtCodeName As System.Windows.Forms.TextBox
    Public WithEvents txtOrigDate As System.Windows.Forms.TextBox
    Public WithEvents txtVersion As System.Windows.Forms.TextBox
    Public WithEvents txtPurpose As System.Windows.Forms.TextBox
    Public WithEvents lblAuthor As System.Windows.Forms.Label
    Public WithEvents lblPhone As System.Windows.Forms.Label
    Public WithEvents lblCodeName As System.Windows.Forms.Label
    Public WithEvents lblOrigDate As System.Windows.Forms.Label
    Public WithEvents lblUpdateDate As System.Windows.Forms.Label
    Public WithEvents lblVersion As System.Windows.Forms.Label
    Public WithEvents lblPurpose As System.Windows.Forms.Label
    Public WithEvents lblCode As System.Windows.Forms.Label
    Public WithEvents lblKeywords As System.Windows.Forms.Label
    Friend WithEvents cmbAuthor As System.Windows.Forms.ComboBox
    Public WithEvents cmbLanguage As System.Windows.Forms.ComboBox
    Public WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdReset As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents rtfCode As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
