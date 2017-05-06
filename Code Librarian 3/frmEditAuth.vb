Option Explicit On
Option Infer On

Friend Class frmEditAuth
    Inherits System.Windows.Forms.Form

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        If lstAuth.Text = "" Then Exit Sub
        Try
            Dim nResults As DialogResult
            'Checks to see if the author you are about to delete has any records that are created by this author.
            Dim strSearch As String
            strSearch = "[Author] Like '" & lstAuth.Text & "'"
            With rsCode
                .FindFirst(strSearch)
                If .NoMatch Then
                    'Safe to delete because it has no records.
                    nResults = MsgBox("Are you sure you want to delete this author? Don't worry, there are no records by this author.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsAuth.MoveFirst()
                        Do Until rsAuth.EOF
                            If lstAuth.SelectedItem = rsAuth.Fields("Author").Value Then
                                rsAuth.Delete()
                                txtAuth.Text = ""
                                txtPhone.Text = ""
                                MsgBox("The author has been deleted successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                Exit Do
                            Else
                                rsAuth.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                Else
                    'Not safe to delete because it has records
                    nResults = MsgBox("Warning! There are records created by this author. You can still delete it, but those records created by this author can only use search options such as 'Custom' and 'All Unlisted Authors'. Do you wish to continue?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsAuth.MoveFirst()
                        Do Until rsAuth.EOF
                            If lstAuth.SelectedItem = rsAuth.Fields("Author").Value Then
                                rsAuth.Delete()
                                txtAuth.Text = ""
                                txtPhone.Text = ""
                                MsgBox("The author has been deleted successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                Exit Do
                            Else
                                rsAuth.MoveNext()
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
        lstAuth.Items.Clear()
        lstPhone.Items.Clear()
        If Not rsAuth.RecordCount = 0 Then
            rsAuth.MoveFirst()
            Do While Not rsAuth.EOF
                lstAuth.Items.Add(rsAuth.Fields("Author").Value)
                lstPhone.Items.Add(rsAuth.Fields("Phone").Value)
                rsAuth.MoveNext()
            Loop
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub lstAuth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAuth.SelectedIndexChanged
        On Error Resume Next
        If lstAuth.Text = "" Then Exit Sub
        lstPhone.SelectedIndex = lstAuth.SelectedIndex
        txtAuth.Text = lstAuth.SelectedItem
        txtPhone.Text = lstPhone.SelectedItem
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            'Makes sure author unique
            If Trim(txtAuth.Text) = "" Or Trim(txtPhone.Text) = "" Then
                Exit Sub
            ElseIf txtAuth.Text.Contains("#") Then
                MsgBox("The Pound symbol (#) is an invalid character for author's name.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            ElseIf UCase(Trim(txtAuth.Text)) = "CUSTOM" Or UCase(Remove_Excess_WhiteSpace(txtAuth.Text)) = "ALL UNLISTED AUTHORS" Then
                MsgBox("You cannot add this as it's a reserved name for searches.", MsgBoxStyle.Information, "Code Librarian")
                Exit Sub
            Else
                If Not rsAuth.RecordCount = 0 Then
                    rsAuth.MoveFirst()
                    Do Until rsAuth.EOF
                        If UCase(Trim(rsAuth.Fields("Author").Value)) = UCase(Trim(txtAuth.Text)) Then
                            MsgBox("Author name already exists and therefore cannot be added again.", MsgBoxStyle.Information, "Code Librarian")
                            Exit Sub
                        Else
                            rsAuth.MoveNext()
                        End If
                    Loop
                End If
            End If
            Dim nResults As DialogResult
            nResults = MsgBox("Are you sure you want to add this author?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            With rsAuth
                .AddNew()
                .Fields("Author").Value = Trim(txtAuth.Text)
                .Fields("Phone").Value = Trim(txtPhone.Text)
                .Update()
            End With
            MsgBox("The author has been added successfully.", MsgBoxStyle.Information, "Code Librarian")
            DoRefresh()
            lstAuth.Text = txtAuth.Text.Trim
            lstPhone.Text = txtPhone.Text.Trim
            txtAuth.Text = txtAuth.Text.Trim
            txtPhone.Text = txtPhone.Text.Trim
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If lstAuth.Text = "" Or Trim(txtAuth.Text) = "" Or Trim(txtPhone.Text) = "" Then
            Exit Sub
        ElseIf txtAuth.Text.Contains("#") Then
            MsgBox("The Pound symbol (#) is an invalid character for author's name.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf UCase(Trim(txtAuth.Text)) = "CUSTOM" Or UCase(Remove_Excess_WhiteSpace(txtAuth.Text)) = "ALL UNLISTED AUTHORS" Then
            MsgBox("You cannot update this as it's a reserved name for searches.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Try
            'Makes sure author unique
            If Not UCase(Trim(lstAuth.Text)) = UCase(Trim(txtAuth.Text)) Then
                rsAuth.MoveFirst()
                Do Until rsAuth.EOF
                    If UCase(Trim(rsAuth.Fields("Author").Value)) = UCase(Trim(txtAuth.Text)) Then
                        MsgBox("Cannot update author name to another one that already exists in the list.", MsgBoxStyle.Information, "Code Librarian")
                        Exit Sub
                    Else
                        rsAuth.MoveNext()
                    End If
                Loop
            End If
            'Checks to see if the author you are about to update has any records that are created by this author.
            Dim nResults As DialogResult
            Dim strSearch As String
            strSearch = "[Author] Like '" & lstAuth.Text & "'"
            With rsCode
                .FindFirst(strSearch)
                If .NoMatch Then
                    'Safe to delete because it has no records.
                    nResults = MsgBox("Are you sure you want to update this author? Don't worry, there are no records by this author.", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsAuth.MoveFirst()
                        Do Until rsAuth.EOF
                            If lstAuth.SelectedItem = rsAuth.Fields("Author").Value And lstPhone.SelectedItem = rsAuth.Fields("Phone").Value Then
                                With rsAuth
                                    .Edit()
                                    .Fields("Author").Value = Trim(txtAuth.Text)
                                    .Fields("Phone").Value = Trim(txtPhone.Text)
                                    .Update()
                                End With
                                MsgBox("The author has been updated successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                lstAuth.Text = txtAuth.Text.Trim
                                lstPhone.Text = txtPhone.Text.Trim
                                txtAuth.Text = txtAuth.Text.Trim
                                txtPhone.Text = txtPhone.Text.Trim
                                Exit Do
                            Else
                                rsAuth.MoveNext()
                            End If
                        Loop
                    Else
                        Exit Sub
                    End If
                Else
                    'Not safe to delete because it has records
                    nResults = MsgBox("Warning! There are records created by this author. You can still update it, but those records created by this author can only use search options such as 'Custom' and 'All Unlisted Authors'. Do you wish to continue?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Code Librarian")
                    If nResults = Windows.Forms.DialogResult.Yes Then
                        rsAuth.MoveFirst()
                        Do Until rsAuth.EOF
                            If lstAuth.SelectedItem = rsAuth.Fields("Author").Value And lstPhone.SelectedItem = rsAuth.Fields("Phone").Value Then
                                With rsAuth
                                    .Edit()
                                    .Fields("Author").Value = Trim(txtAuth.Text)
                                    .Fields("Phone").Value = Trim(txtPhone.Text)
                                    .Update()
                                End With
                                MsgBox("The author has been updated successfully.", MsgBoxStyle.Information, "Code Librarian")
                                DoRefresh()
                                lstAuth.Text = txtAuth.Text.Trim
                                lstPhone.Text = txtPhone.Text.Trim
                                txtAuth.Text = txtAuth.Text.Trim
                                txtPhone.Text = txtPhone.Text.Trim
                                Exit Do
                            Else
                                rsAuth.MoveNext()
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

    Private Sub frmEditAuth_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        DoRefresh()
    End Sub

    Private Sub lstPhone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPhone.SelectedIndexChanged
        On Error Resume Next
        If lstPhone.Text = "" Then Exit Sub
        lstAuth.SelectedIndex = lstPhone.SelectedIndex
        txtAuth.Text = lstAuth.SelectedItem
        txtPhone.Text = lstPhone.SelectedItem
    End Sub

End Class