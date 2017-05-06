Option Explicit On
Option Infer On

Friend Class frmEditLang
    Inherits System.Windows.Forms.Form

    Private Sub frmEditLang_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'This is the only other piece of code that refreshes the language filter list not on the main form.
        Try
            FrmMain.FilterLanguage.Items.Clear()
            langList.Clear()
            FrmMain.FilterLanguage.Items.Add("All languages")
            FrmMain.FilterLanguage.Items.Add("Orphaned Records")
            If Not rsLang.RecordCount = 0 Then
                rsLang.MoveFirst()
                Do While Not rsLang.EOF
                    langList.Add(rsLang.Fields("Language").Value) 'This is the list used to created the dynamic array to create the orphaned records category
                    rsLang.MoveNext()
                Loop
            End If
            langList.Sort()
            For Each nLang As String In langList
                FrmMain.FilterLanguage.Items.Add(nLang)
            Next
            langListArray = langList.ToArray()
            FrmMain.FilterLanguage.SelectedIndex = 0
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub frmEditLang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DoRefresh()
    End Sub

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        If lstLang.Text = "" Then Exit Sub
        Try
            Dim nResults As DialogResult
            'Checks to see if the language filter you are about to delete has any records that will be left orphaned.
            Dim strSearch As String
            strSearch = "[Language] Like '" & lstLang.Text & "'"
            With rsCode
                .FindFirst(strSearch)
                If .NoMatch Then
                    'Safe to delete because it has no records.
                    nResults = MsgBox("Are you sure you want to delete this language? Don't worry, there are no records assigned to it.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsLang.MoveFirst()
                        Do Until rsLang.EOF
                            If lstLang.SelectedItem = rsLang.Fields("Language").Value Then
                                rsLang.Delete()
                                txtLang.Text = ""
                                MsgBox("The language has been deleted successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                Exit Do
                            Else
                                rsLang.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                Else
                    'Not safe to delete because it has records
                    nResults = MsgBox("Warning! This language has records assigned to it. You can still delete it, but those records will now only be accessible from the 'Orphaned Records' filter. Do you wish to continue?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsLang.MoveFirst()
                        Do Until rsLang.EOF
                            If lstLang.SelectedItem = rsLang.Fields("Language").Value Then
                                rsLang.Delete()
                                txtLang.Text = ""
                                MsgBox("The language has been deleted successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                Exit Do
                            Else
                                rsLang.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                End If
            End With
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub DoRefresh()
        On Error Resume Next
        lstLang.Items.Clear()
        If Not rsLang.RecordCount = 0 Then
            rsLang.MoveFirst()
            Do While Not rsLang.EOF
                lstLang.Items.Add(rsLang.Fields("Language").Value)
                rsLang.MoveNext()
            Loop
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstLang.Text = "" Then
            Exit Sub
        ElseIf txtLang.Text.Contains("#") Then
            MsgBox("The Pound symbol (#) is an invalid character. Use 'Sharp' in its' place like C-Sharp or J-Sharp.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf UCase(Remove_Excess_WhiteSpace(txtLang.Text)) = "ALL LANGUAGES" Or UCase(Remove_Excess_WhiteSpace(txtLang.Text)) = "ORPHANED RECORDS" Then
            MsgBox("You cannot update this using a name reserved for filtering.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Try
            'Makes sure language is unique
            If Not UCase(Trim(lstLang.Text)) = UCase(Trim(txtLang.Text)) Then
                rsLang.MoveFirst()
                Do Until rsLang.EOF
                    If UCase(Trim(rsLang.Fields("Language").Value)) = UCase(Trim(txtLang.Text)) Then
                        MsgBox("Cannot update language to another one that already exists in the list.", MsgBoxStyle.Information, "Code Librarian")
                        Exit Sub
                    Else
                        rsLang.MoveNext()
                    End If
                Loop
            End If
            'Checks to see if the language filter you are about to update has any records that will be left orphaned.
            Dim nResults As DialogResult
            Dim strSearch As String
            strSearch = "[Language] Like '" & lstLang.Text & "'"
            With rsCode
                .FindFirst(strSearch)
                If .NoMatch Then
                    'Safe to delete because it has no records.
                    nResults = MsgBox("Are you sure you want to update this language? Don't worry, there are no records assigned to it.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsLang.MoveFirst()
                        Do Until rsLang.EOF
                            If lstLang.SelectedItem = rsLang.Fields("Language").Value Then
                                With rsLang
                                    .Edit()
                                    .Fields("Language").Value = Trim(txtLang.Text)
                                    .Update()
                                End With
                                MsgBox("The language has been updated successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                lstLang.Text = txtLang.Text.Trim
                                txtLang.Text = txtLang.Text.Trim
                                Exit Do
                            Else
                                rsLang.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                Else
                    'Not safe to delete because it has records
                    nResults = MsgBox("Warning! This language has records assigned to it. You can still update it, but those records will now only be accessible from the 'Orphaned Records' filter. Do you wish to continue?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsLang.MoveFirst()
                        Do Until rsLang.EOF
                            If lstLang.SelectedItem = rsLang.Fields("Language").Value Then
                                With rsLang
                                    .Edit()
                                    .Fields("Language").Value = Trim(txtLang.Text)
                                    .Update()
                                End With
                                MsgBox("The language has been updated successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                lstLang.Text = txtLang.Text.Trim
                                txtLang.Text = txtLang.Text.Trim
                                Exit Do
                            Else
                                rsLang.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                End If
            End With
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub lstLang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLang.SelectedIndexChanged
        On Error Resume Next
        txtLang.Text = lstLang.SelectedItem
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            'Makes sure language unique
            If Trim(txtLang.Text) = "" Then
                Exit Sub
            ElseIf txtLang.Text.Contains("#") Then
                MsgBox("The Pound symbol (#) is an invalid character. Use 'Sharp' in its' place like C-Sharp or J-Sharp.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            ElseIf UCase(Remove_Excess_WhiteSpace(txtLang.Text)) = "ALL LANGUAGES" Or UCase(Remove_Excess_WhiteSpace(txtLang.Text)) = "ORPHANED RECORDS" Then
                MsgBox("You cannot add this as it's a reserved name for filtering.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            Else
                If Not rsLang.RecordCount = 0 Then
                    rsLang.MoveFirst()
                    Do Until rsLang.EOF
                        If UCase(Trim(rsLang.Fields("Language").Value)) = UCase(Trim(txtLang.Text)) Then
                            MsgBox("Language already exists and therefore cannot be added again.", MsgBoxStyle.Information, "Code Librarian")
                            Exit Sub
                        Else
                            rsLang.MoveNext()
                        End If
                    Loop
                End If
            End If
            Dim nResults As DialogResult
            nResults = MsgBox("Are you sure you want to add this language?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            'This does the actual adding
            With rsLang
                .AddNew()
                .Fields("Language").Value = Trim(txtLang.Text)
                .Update()
            End With
            MsgBox("The language has been added successfully.", MsgBoxStyle.Information, "Code Librarian")
            DoRefresh()
            lstLang.Text = txtLang.Text.Trim
            txtLang.Text = txtLang.Text.Trim
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

End Class