Option Explicit On
Option Infer On

Friend Class frmSettings
    Inherits System.Windows.Forms.Form

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        txtDBPath.Text = DBPath()
        Select Case AlignList
            Case 3
                optLeft.Checked = True
            Case 4
                optRight.Checked = True
        End Select
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next
        If optLeft.Checked = True Then
            AlignList = 3
        ElseIf optRight.Checked = True Then
            AlignList = 4
        End If
        FrmMain.picList.Dock = AlignList
        SaveSettings()
        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        On Error Resume Next
        Me.Close()
    End Sub

End Class