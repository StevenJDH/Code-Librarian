Option Explicit On
Option Infer On

Friend Class frmView
    Inherits System.Windows.Forms.Form

    Private Sub frmView_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Tag = ""
    End Sub

    Private Sub frmView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If FrmMain.Tag = "frmedit" Then
            frmEdit.Close()
        ElseIf FrmMain.Tag = "frmadd" Then
            frmAdd.Close()
        End If
        FrmMain.Tag = "frmview"
    End Sub

    Public Sub GetViewData(ByRef SearchText As String)
        On Error Resume Next
        Dim strSearch As String
        strSearch = "[Codename] Like '" & SearchText & "'"
        With rsCode
            .FindFirst(strSearch)
            txtAuthor.Text = rsCode.Fields("Author").Value
            txtPhone.Text = rsCode.Fields("Phone").Value
            txtCodeName.Text = rsCode.Fields("CodeName").Value
            txtPurpose.Text = rsCode.Fields("Purpose").Value
            txtOrigDate.Text = rsCode.Fields("OrigDate").Value
            txtUpdateDate.Text = rsCode.Fields("UpdateDate").Value
            txtVersion.Text = rsCode.Fields("Version").Value
            txtLanguage.Text = rsCode.Fields("Language").Value
            txtKeywords.Text = rsCode.Fields("Keywords").Value
            rtfCode.Text = rsCode.Fields("Code").Value
            Me.Text = "Source Code for: " & rsCode.Fields("CodeName").Value
        End With
    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        Try
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(rtfCode.Text)
            MsgBox("Code copied to clipboard. You may now paste it into your project(s).", MsgBoxStyle.Information, "Code Librarian")
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub rtfCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtfCode.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txtKeywords_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKeywords.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub txtPurpose_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurpose.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

End Class