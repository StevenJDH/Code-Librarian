<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.fraList = New System.Windows.Forms.GroupBox()
        Me.optRight = New System.Windows.Forms.RadioButton()
        Me.optLeft = New System.Windows.Forms.RadioButton()
        Me.lblDBPath = New System.Windows.Forms.Label()
        Me.txtDBPath = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.fraList.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraList
        '
        Me.fraList.BackColor = System.Drawing.SystemColors.Control
        Me.fraList.Controls.Add(Me.optRight)
        Me.fraList.Controls.Add(Me.optLeft)
        Me.fraList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraList.ForeColor = System.Drawing.Color.Black
        Me.fraList.Location = New System.Drawing.Point(8, 8)
        Me.fraList.Name = "fraList"
        Me.fraList.Padding = New System.Windows.Forms.Padding(0)
        Me.fraList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraList.Size = New System.Drawing.Size(177, 81)
        Me.fraList.TabIndex = 7
        Me.fraList.TabStop = False
        Me.fraList.Text = "List Placement"
        '
        'optRight
        '
        Me.optRight.BackColor = System.Drawing.SystemColors.Control
        Me.optRight.Cursor = System.Windows.Forms.Cursors.Default
        Me.optRight.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optRight.ForeColor = System.Drawing.Color.Black
        Me.optRight.Location = New System.Drawing.Point(8, 48)
        Me.optRight.Name = "optRight"
        Me.optRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optRight.Size = New System.Drawing.Size(161, 17)
        Me.optRight.TabIndex = 3
        Me.optRight.TabStop = True
        Me.optRight.Text = "Align List to Right"
        Me.optRight.UseVisualStyleBackColor = False
        '
        'optLeft
        '
        Me.optLeft.BackColor = System.Drawing.SystemColors.Control
        Me.optLeft.Checked = True
        Me.optLeft.Cursor = System.Windows.Forms.Cursors.Default
        Me.optLeft.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optLeft.ForeColor = System.Drawing.Color.Black
        Me.optLeft.Location = New System.Drawing.Point(8, 24)
        Me.optLeft.Name = "optLeft"
        Me.optLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optLeft.Size = New System.Drawing.Size(161, 17)
        Me.optLeft.TabIndex = 2
        Me.optLeft.TabStop = True
        Me.optLeft.Text = "Align List to Left"
        Me.optLeft.UseVisualStyleBackColor = False
        '
        'lblDBPath
        '
        Me.lblDBPath.BackColor = System.Drawing.Color.Transparent
        Me.lblDBPath.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDBPath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBPath.ForeColor = System.Drawing.Color.Black
        Me.lblDBPath.Location = New System.Drawing.Point(8, 96)
        Me.lblDBPath.Name = "lblDBPath"
        Me.lblDBPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDBPath.Size = New System.Drawing.Size(177, 17)
        Me.lblDBPath.TabIndex = 6
        Me.lblDBPath.Text = "Path To Personal Database File"
        Me.lblDBPath.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDBPath
        '
        Me.txtDBPath.AcceptsReturn = True
        Me.txtDBPath.BackColor = System.Drawing.Color.White
        Me.txtDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDBPath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDBPath.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBPath.ForeColor = System.Drawing.Color.Black
        Me.txtDBPath.Location = New System.Drawing.Point(8, 112)
        Me.txtDBPath.MaxLength = 0
        Me.txtDBPath.Multiline = True
        Me.txtDBPath.Name = "txtDBPath"
        Me.txtDBPath.ReadOnly = True
        Me.txtDBPath.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDBPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDBPath.Size = New System.Drawing.Size(177, 37)
        Me.txtDBPath.TabIndex = 2
        Me.txtDBPath.TabStop = False
        Me.txtDBPath.WordWrap = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(8, 160)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(81, 25)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.cmdSave, "Save/apply settings")
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(104, 160)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(81, 25)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.cmdCancel, "Cancel/discard changes")
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(193, 193)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDBPath)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.fraList)
        Me.Controls.Add(Me.lblDBPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.fraList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents fraList As System.Windows.Forms.GroupBox
    Public WithEvents optRight As System.Windows.Forms.RadioButton
    Public WithEvents optLeft As System.Windows.Forms.RadioButton
    Public WithEvents lblDBPath As System.Windows.Forms.Label
    Public WithEvents txtDBPath As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
