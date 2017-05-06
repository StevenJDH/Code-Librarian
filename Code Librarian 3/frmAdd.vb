Option Explicit On
Option Infer On

Public Class frmAdd
    Inherits System.Windows.Forms.Form

    Private Sub frmAdd_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Tag = ""
    End Sub

    Private Sub frmAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If FrmMain.Tag = "frmedit" Then
            frmEdit.Close()
        ElseIf FrmMain.Tag = "frmview" Then
            frmView.Close()
        End If
        FrmMain.Tag = "frmadd"
        If Not rsAuth.RecordCount = 0 Then
            rsAuth.MoveFirst()
            Do While Not rsAuth.EOF
                cmbAuthor.Items.Add(rsAuth.Fields("Author").Value)
                rsAuth.MoveNext()
            Loop
        End If
        If Not rsLang.RecordCount = 0 Then
            rsLang.MoveFirst()
            Do While Not rsLang.EOF
                cmbLanguage.Items.Add(rsLang.Fields("Language").Value)
                rsLang.MoveNext()
            Loop
        End If
        txtOrigDate.Text = CStr(Today)
        txtUpdateDate.Text = CStr(Today)
        txtVersion.Text = "1.00"
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        Dim nResults As DialogResult
        nResults = MsgBox("Are you sure you want to clear the entered information?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
        If nResults = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        cmbAuthor.Text = ""
        txtPhone.Text = ""
        txtCodeName.Text = ""
        txtOrigDate.Text = CStr(Today)
        txtUpdateDate.Text = CStr(Today)
        txtVersion.Text = "1.00"
        cmbLanguage.SelectedIndex = -1
        txtPurpose.Text = ""
        txtKeywords.Text = ""
        rtfCode.Text = ""
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub cmbAuthor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAuthor.SelectedIndexChanged
        On Error Resume Next
        Dim strSearch As String
        If Trim(cmbAuthor.Text) = "" Then
            Exit Sub
        Else
            strSearch = "[Author] Like '" & Trim(cmbAuthor.Text) & "'"
            With rsAuth
                .FindFirst(strSearch)
                txtPhone.Text = rsAuth.Fields("Phone").Value
            End With
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            'Makes sure codename unique
            If Trim(txtCodeName.Text) = "" Then
                MsgBox("Please select a name/title for your code record.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            ElseIf cmbAuthor.Text.Contains("#") Then
                MsgBox("The Pound symbol (#) is an invalid character in Author field.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            ElseIf txtCodeName.Text.Contains("#") Then
                MsgBox("The Pound symbol (#) is an invalid character in Code Name/Title field.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            Else
                If Not rsCode.RecordCount = 0 Then
                    rsCode.MoveFirst()
                    Do Until rsCode.EOF
                        If UCase(Trim(rsCode.Fields("CodeName").Value)) = UCase(Trim(txtCodeName.Text)) Then
                            MsgBox("Name/Title already exists. Please change it to a unique one for your code record.", MsgBoxStyle.Information, "Code Librarian")
                            Exit Sub
                        Else
                            rsCode.MoveNext()
                        End If
                    Loop
                End If
            End If
            Dim nResults As DialogResult
            nResults = MsgBox("Are you sure you want to add this record to the library?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            With rsCode
                .AddNew()
                If Trim(cmbAuthor.Text) = "" Then
                    .Fields("Author").Value = "N/A"
                Else
                    .Fields("Author").Value = Trim(cmbAuthor.Text)
                End If
                If Trim(txtPhone.Text) = "" Then
                    .Fields("Phone").Value = "N/A"
                Else
                    .Fields("Phone").Value = Trim(txtPhone.Text)
                End If
                If Trim(txtCodeName.Text) = "" Then
                    MsgBox("Please select a name/title for your code record.", MsgBoxStyle.Information, "Code Librarian")
                    Exit Sub
                Else
                    .Fields("CodeName").Value = Trim(txtCodeName.Text)
                End If
                If Trim(txtPurpose.Text) = "" Then
                    .Fields("Purpose").Value = "N/A"
                Else
                    .Fields("Purpose").Value = Trim(txtPurpose.Text)
                End If
                If Trim(txtOrigDate.Text) = "" Then
                    .Fields("OrigDate").Value = Today
                Else
                    .Fields("OrigDate").Value = Trim(txtOrigDate.Text)
                End If
                If Trim(txtUpdateDate.Text) = "" Then
                    .Fields("UpdateDate").Value = Today
                Else
                    .Fields("UpdateDate").Value = Trim(txtUpdateDate.Text)
                End If
                If Trim(txtVersion.Text) = "" Then
                    .Fields("Version").Value = "1.00"
                Else
                    .Fields("Version").Value = Trim(txtVersion.Text)
                End If
                If cmbLanguage.Text = "" Then
                    MsgBox("Please select the programming language of your code.", MsgBoxStyle.Information, "Code Librarian")
                    Exit Sub
                Else
                    .Fields("Language").Value = cmbLanguage.Text
                End If
                If Trim(txtKeywords.Text) = "" Then
                    .Fields("Keywords").Value = "None"
                Else
                    .Fields("Keywords").Value = Trim(txtKeywords.Text)
                End If
                If Trim(rtfCode.Text) = "" Then
                    MsgBox("Please fill in the code snippet area with your code.", MsgBoxStyle.Information, "Code Librarian")
                    Exit Sub
                Else
                    .Fields("Code").Value = Trim(rtfCode.Text)
                End If
                .Update()
            End With
            MsgBox("The record has been added successfully.", MsgBoxStyle.Information, "Code Librarian")
            FrmMain.cmdRefresh_Click(Me, EventArgs.Empty)
            Me.Close()
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub rtfCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtfCode.KeyPress
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

    Private Sub txtKeywords_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKeywords.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

End Class