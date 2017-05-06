<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAuth
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
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAuth = New System.Windows.Forms.TextBox()
        Me.lstPhone = New System.Windows.Forms.ListBox()
        Me.lstAuth = New System.Windows.Forms.ListBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Black
        Me.txtPhone.Location = New System.Drawing.Point(148, 108)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone.Size = New System.Drawing.Size(141, 20)
        Me.txtPhone.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.txtPhone, "Add/edit box for the author's phone/ext/e-mail (Required)")
        '
        'txtAuth
        '
        Me.txtAuth.AcceptsReturn = True
        Me.txtAuth.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAuth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuth.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAuth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuth.ForeColor = System.Drawing.Color.Black
        Me.txtAuth.Location = New System.Drawing.Point(8, 108)
        Me.txtAuth.MaxLength = 50
        Me.txtAuth.Name = "txtAuth"
        Me.txtAuth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAuth.Size = New System.Drawing.Size(141, 20)
        Me.txtAuth.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtAuth, "Add/edit box for the author's name (Required)")
        '
        'lstPhone
        '
        Me.lstPhone.BackColor = System.Drawing.Color.White
        Me.lstPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstPhone.ItemHeight = 14
        Me.lstPhone.Location = New System.Drawing.Point(148, 8)
        Me.lstPhone.Name = "lstPhone"
        Me.lstPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstPhone.Size = New System.Drawing.Size(141, 88)
        Me.lstPhone.TabIndex = 11
        Me.lstPhone.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstPhone, "Authors' phone/ext/e-mail")
        '
        'lstAuth
        '
        Me.lstAuth.BackColor = System.Drawing.Color.White
        Me.lstAuth.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstAuth.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstAuth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstAuth.ItemHeight = 14
        Me.lstAuth.Location = New System.Drawing.Point(8, 8)
        Me.lstAuth.Name = "lstAuth"
        Me.lstAuth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstAuth.Size = New System.Drawing.Size(141, 88)
        Me.lstAuth.TabIndex = 10
        Me.lstAuth.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstAuth, "Names of authors")
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(296, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(65, 25)
        Me.cmdAdd.TabIndex = 2
        Me.cmdAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.cmdAdd, "Adds new author and phone/ext/e-mail to database")
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(296, 40)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(65, 25)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.cmdEdit, "Updates changes to highlighted author/contact info")
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(296, 72)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(65, 25)
        Me.Command1.TabIndex = 4
        Me.Command1.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.Command1, "Deletes author/contact info")
        Me.Command1.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(296, 104)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 25)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.cmdClose, "Close window")
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmEditAuth
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(369, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAuth)
        Me.Controls.Add(Me.lstPhone)
        Me.Controls.Add(Me.lstAuth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditAuth"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add/Edit Authors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents txtPhone As System.Windows.Forms.TextBox
    Public WithEvents txtAuth As System.Windows.Forms.TextBox
    Public WithEvents lstPhone As System.Windows.Forms.ListBox
    Public WithEvents lstAuth As System.Windows.Forms.ListBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
