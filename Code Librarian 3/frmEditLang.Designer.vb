<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditLang
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
        Me.lstLang = New System.Windows.Forms.ListBox()
        Me.txtLang = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.SuspendLayout()
        '
        'lstLang
        '
        Me.lstLang.BackColor = System.Drawing.Color.White
        Me.lstLang.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstLang.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLang.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstLang.ItemHeight = 14
        Me.lstLang.Location = New System.Drawing.Point(8, 8)
        Me.lstLang.Name = "lstLang"
        Me.lstLang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstLang.Size = New System.Drawing.Size(241, 88)
        Me.lstLang.Sorted = True
        Me.lstLang.TabIndex = 7
        Me.lstLang.TabStop = False
        Me.ToolTip1.SetToolTip(Me.lstLang, "Displays programming languages")
        '
        'txtLang
        '
        Me.txtLang.AcceptsReturn = True
        Me.txtLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLang.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLang.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLang.ForeColor = System.Drawing.Color.Black
        Me.txtLang.Location = New System.Drawing.Point(8, 108)
        Me.txtLang.MaxLength = 25
        Me.txtLang.Name = "txtLang"
        Me.txtLang.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLang.Size = New System.Drawing.Size(241, 20)
        Me.txtLang.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtLang, "Add/edit box for programming languages (Required)")
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(256, 8)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(81, 25)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.cmdAdd, "Add a new language to the database")
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(256, 40)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(81, 25)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "Update"
        Me.ToolTip1.SetToolTip(Me.cmdEdit, "Updates changes for highlighted language")
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(256, 72)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(81, 25)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.Command1, "Deletes language from database")
        Me.Command1.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(256, 104)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(81, 25)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.cmdClose, "Close window")
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmEditLang
        '
        Me.AcceptButton = Me.cmdClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(345, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstLang)
        Me.Controls.Add(Me.txtLang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEditLang"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add/Edit Languages"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lstLang As System.Windows.Forms.ListBox
    Public WithEvents txtLang As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
