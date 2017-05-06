Option Explicit On
Option Infer On

Friend Class frmEdit
    Inherits System.Windows.Forms.Form

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        Dim nResults As DialogResult
        Try
            nResults = MsgBox("Are you sure you want to delete this record from the library?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.Yes Then
                rsCode.MoveFirst()
                Do Until rsCode.EOF
                    If txtCodeName.Text = rsCode.Fields("CodeName").Value Then
                        rsCode.Delete()
                        Exit Do
                    Else
                        rsCode.MoveNext()
                    End If
                Loop
                FrmMain.cmdRefresh_Click(Me, EventArgs.Empty)
                Me.Close()
            End If
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub frmEdit_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        FrmMain.Tag = ""
    End Sub

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If FrmMain.Tag = "frmview" Then
            frmView.Close()
        ElseIf FrmMain.Tag = "frmadd" Then
            frmAdd.Close()
        End If
        FrmMain.Tag = "frmedit"
        rsAuth.MoveFirst()
        Do While Not rsAuth.EOF
            cmbAuthor.Items.Add(rsAuth.Fields("Author").Value)
            rsAuth.MoveNext()
        Loop
        rsLang.MoveFirst()
        Do While Not rsLang.EOF
            cmbLanguage.Items.Add(rsLang.Fields("Language").Value)
            rsLang.MoveNext()
        Loop
        'This is to fix the cmbLanguage index after its populated to show the correct one.
        cmbLanguage.SelectedItem = cmbLanguage.Tag
    End Sub

    Private Sub cmdReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReset.Click
        On Error Resume Next
        Dim nResults As DialogResult
        nResults = MsgBox("Are you sure you want to revert back? All changes will be undone.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
        If nResults = Windows.Forms.DialogResult.Yes Then
            GetEditData(txtCodeName.Text)
        End If
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

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Dim nResults As DialogResult
        nResults = MsgBox("Are you sure you want to update this record in the library?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
        If nResults = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        Try
            rsCode.MoveFirst()
            Do Until rsCode.EOF
                If txtCodeName.Text = rsCode.Fields("CodeName").Value Then
                    With rsCode
                        .Edit()
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
                    Exit Do
                Else
                    rsCode.MoveNext()
                End If
            Loop
        Catch
            MsgBox("Error: Could not update record because of a minor problem in the database. Use 'Compact/Repair' in the menu to solve the problem then try again.", MsgBoxStyle.Critical, "Code Librarian")
            Exit Sub
        End Try
        'Refreshes the data in the fields after the update as a sort of double check that it actually happened.
        GetEditData(txtCodeName.Text)
        MsgBox("The record has been updated successfully.", MsgBoxStyle.Information, "Code Librarian")
        'Refreshes the code list in case the user changed the language filter of the record and the list is being filtered to the old language filter to have it disappear from there.
        If Not FrmMain.FilterLanguage.Text = "All languages" Then
            FrmMain.cmdRefresh_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub Again(ByRef strSearch As String)
        On Error Resume Next
        With rsCode
            .FindNext(strSearch)
            If .NoMatch Then
                Exit Sub
            Else
                FrmMain.lstCode.Items.Add(rsCode.Fields("CodeName").Value)
                Again(strSearch)
            End If
        End With
    End Sub

    Public Sub GetEditData(ByRef SearchText As String)
        On Error Resume Next
        Dim strSearch As String
        strSearch = "[CodeName] = '" & SearchText & "'"
        rsCode.MoveFirst()
        With rsCode
            .FindFirst(strSearch)
            cmbAuthor.Text = rsCode.Fields("Author").Value
            txtPhone.Text = rsCode.Fields("Phone").Value
            txtCodeName.Text = rsCode.Fields("CodeName").Value
            txtPurpose.Text = rsCode.Fields("Purpose").Value
            txtOrigDate.Text = rsCode.Fields("OrigDate").Value
            txtUpdateDate.Text = CStr(Today)
            txtVersion.Text = rsCode.Fields("Version").Value
            cmbLanguage.Tag = rsCode.Fields("Language").Value
            cmbLanguage.SelectedItem = rsCode.Fields("Language").Value
            txtKeywords.Text = rsCode.Fields("Keywords").Value
            rtfCode.Text = rsCode.Fields("Code").Value
            Me.Text = "Source Code for: " & rsCode.Fields("CodeName").Value
        End With
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
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