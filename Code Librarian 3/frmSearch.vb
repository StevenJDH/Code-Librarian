Option Explicit On
Option Infer On

Friend Class frmSearch
    Inherits System.Windows.Forms.Form
    Dim strKeywords As String

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        If Not rsLang.RecordCount = 0 Then
            rsLang.MoveFirst()
            Do While Not rsLang.EOF
                cmbLanguage.Items.Add(rsLang.Fields("Language").Value)
                rsLang.MoveNext()
            Loop
        End If
        'Used to load the list sorted with the 2 hard coded options on top and to create the array to search for unlisted authors.
        Dim authList As New List(Of String)()
        'Loads custom so that you can still find authors of records that no longer exist.
        cmbAuthor.Items.Add("Custom")
        'Loads all Unlisted so that you can find all unlisted authors of records that no longer exist.
        cmbAuthor.Items.Add("All Unlisted Authors")
        If Not rsAuth.RecordCount = 0 Then
            rsAuth.MoveFirst()
            Do While Not rsAuth.EOF
                authList.Add(rsAuth.Fields("Author").Value)
                rsAuth.MoveNext()
            Loop
        End If
        'Sorts authors alphabetically and adds to list finally leaving custom and unlisted at the top.
        authList.Sort()
        For Each nAuth As String In authList
            cmbAuthor.Items.Add(nAuth)
        Next
    End Sub

    Private Sub chkAuthor_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAuthor.CheckStateChanged
        On Error Resume Next
        If chkAuthor.CheckState = 1 Then
            cmbAuthor.Enabled = True
        ElseIf chkAuthor.CheckState = 0 Then
            cmbAuthor.Enabled = False
        End If
    End Sub

    Private Sub chkLanguage_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkLanguage.CheckStateChanged
        On Error Resume Next
        If chkLanguage.CheckState = 1 Then
            cmbLanguage.Enabled = True
        ElseIf chkLanguage.CheckState = 0 Then
            cmbLanguage.Enabled = False
        End If
    End Sub

    Private Sub chkKeyword_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKeyword.CheckStateChanged
        On Error Resume Next
        If chkKeyword.CheckState = 1 Then
            txtKeyword.Enabled = True
        ElseIf chkKeyword.CheckState = 0 Then
            txtKeyword.Enabled = False
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        'We run a few checks to make sure the needful things are filled out.
        If chkKeyword.CheckState = 1 And Trim(txtKeyword.Text) = "" Then
            MsgBox("Please type something for keywords if you wish to start searching.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf chkLanguage.CheckState = 1 And Trim(cmbLanguage.Text) = "" Then
            MsgBox("Please select a language if you wish to start searching.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf chkAuthor.CheckState = 1 And Trim(cmbAuthor.Text) = "" Then
            MsgBox("Please select an author if you wish to start searching.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf chkKeyword.CheckState = 0 And chkLanguage.CheckState = 0 And chkAuthor.CheckState = 0 Then
            MsgBox("Please select a search method before searching.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim strSearch As String
        Dim strAuthor As String
        Dim strLanguage As String

        strSearch = ""
        strAuthor = ""
        strKeywords = ""

        lstResults.Items.Clear()

        strAuthor = "[Author] Like '" & cmbAuthor.Text & "'"
        strLanguage = "[Language] Like '" & cmbLanguage.Text & "'"

        If Trim(txtKeyword.Text) > "" Then
            GetKeywords()
        End If
        Try
            If chkAuthor.CheckState = 1 And chkLanguage.CheckState = 0 And chkKeyword.CheckState = 0 Then
                'We check to see if List All Authors is selected and if so we load all records so they can be filtered for unlisted authors
                'since the search code below can't be used for this in any easy way.
                If cmbAuthor.SelectedIndex = 1 Then
                    If Not rsCode.RecordCount = 0 Then 'rsCode.RecordCount tell us 0 if empty or 1 or -1 if not.
                        rsCode.MoveFirst()
                        Do While Not rsCode.EOF
                            If cmbAuthor.FindStringExact(rsCode.Fields("Author").Value.ToString) = -1 Then
                                lstResults.Items.Add(rsCode.Fields("CodeName").Value)
                            End If
                            rsCode.MoveNext()
                        Loop
                    End If
                    If lstResults.Items.Count = 1 Then
                        Frame1.Text = "Search results: " & lstResults.Items.Count & " match"
                    Else
                        Frame1.Text = "Search results: " & lstResults.Items.Count & " matches"
                    End If
                    Exit Sub
                Else
                    'If not select then prep for normal search mode.
                    strSearch = strAuthor
                End If
            ElseIf chkAuthor.CheckState = 0 And chkLanguage.CheckState = 1 And chkKeyword.CheckState = 0 Then
                strSearch = strLanguage
            ElseIf chkAuthor.CheckState = 0 And chkLanguage.CheckState = 0 And chkKeyword.CheckState = 1 Then
                strSearch = strKeywords
            ElseIf chkAuthor.CheckState = 1 And chkLanguage.CheckState = 1 And chkKeyword.CheckState = 0 Then
                'We check to see if List All Authors is selected and if so we prep in a way that using find and if then statments we return unlisted author results with the extra filtering.
                If cmbAuthor.SelectedIndex = 1 Then
                    strSearch = strLanguage
                Else
                    'If not select then prep for normal search mode.
                    strSearch = strAuthor & " AND " & strLanguage
                End If
            ElseIf chkAuthor.CheckState = 0 And chkLanguage.CheckState = 1 And chkKeyword.CheckState = 1 Then
                strSearch = strLanguage & " AND " & strKeywords
            ElseIf chkAuthor.CheckState = 1 And chkLanguage.CheckState = 0 And chkKeyword.CheckState = 1 Then
                'We check to see if List All Authors is selected and if so we prep in a way that using find and if then statments we return unlisted author results with the extra filtering.
                If cmbAuthor.SelectedIndex = 1 Then
                    strSearch = strKeywords
                Else
                    'If not select then prep for normal search mode.
                    strSearch = strAuthor & " AND " & strKeywords
                End If
            ElseIf chkAuthor.CheckState = 1 And chkLanguage.CheckState = 1 And chkKeyword.CheckState = 1 Then
                'We check to see if List All Authors is selected and if so we prep in a way that using find and if then statments we return unlisted author results with the extra filtering.
                If cmbAuthor.SelectedIndex = 1 Then
                    strSearch = strLanguage & " AND " & strKeywords
                Else
                    'If not select then prep for normal search mode.
                    strSearch = strAuthor & " AND " & strLanguage & " AND " & strKeywords
                End If
            End If
            'We check to see if List All Authors is selected and search by authors is selected to run an unlisted author filtered search.
            If chkAuthor.CheckState = 1 And cmbAuthor.SelectedIndex = 1 Then
                With rsCode
                    .FindFirst(strSearch)
                    If .NoMatch Then
                        Frame1.Text = "Search results: No matches"
                    Else
                        If cmbAuthor.FindStringExact(rsCode.Fields("Author").Value.ToString) = -1 Then 'If author is not list then add to list.
                            lstResults.Items.Add(rsCode.Fields("CodeName").Value)
                        End If
                        Again(strSearch)
                    End If
                End With
            Else 'Else we run a normal search
                With rsCode
                    .FindFirst(strSearch)
                    If .NoMatch Then
                        Frame1.Text = "Search results: No matches"
                    Else
                        lstResults.Items.Add(rsCode.Fields("CodeName").Value)
                        Again(strSearch)
                    End If
                End With
            End If
        Catch
            Frame1.Text = "Search results: Error while searching"
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub Again(ByRef strSearch As String)
        Try
            'We check to see if List All Authors is selected and search by authors is selected to run an unlisted author filtered search.
            If chkAuthor.CheckState = 1 And cmbAuthor.SelectedIndex = 1 Then
                With rsCode
                    .FindNext(strSearch)
                    If .NoMatch Then
                        If lstResults.Items.Count = 1 Then
                            Frame1.Text = "Search results: " & lstResults.Items.Count & " match"
                        Else
                            Frame1.Text = "Search results: " & lstResults.Items.Count & " matches"
                        End If
                    Else
                        If cmbAuthor.FindStringExact(rsCode.Fields("Author").Value.ToString) = -1 Then 'If author is not list then add to list.
                            lstResults.Items.Add(rsCode.Fields("CodeName").Value)
                        End If
                        Again(strSearch)
                    End If
                End With
            Else 'Else we run a normal search
                With rsCode
                    .FindNext(strSearch)
                    If .NoMatch Then
                        If lstResults.Items.Count = 1 Then
                            Frame1.Text = "Search results: " & lstResults.Items.Count & " match"
                        Else
                            Frame1.Text = "Search results: " & lstResults.Items.Count & " matches"
                        End If
                    Else
                        lstResults.Items.Add(rsCode.Fields("CodeName").Value)
                        Again(strSearch)
                    End If
                End With
            End If
        Catch
            Frame1.Text = "Search results: Error while searching"
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub lstResults_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstResults.DoubleClick
        ViewToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Public Sub GetKeywords()
        On Error Resume Next
        Dim Source() As String
        Dim x As Short
        Dim Textnum As Short
        Source = Split(Trim(txtKeyword.Text), ",", 5)
        If UBound(Source) = 0 Then
            strKeywords = "[Keywords] Like '*" & Source(0) & "*'"
        Else
            For x = 0 To UBound(Source)
                If Source(x) = "" Then
                    strKeywords = "[Keywords] Like '*" & Source(x) & "*'"
                Else
                    strKeywords = "[Keywords] Like '*" & Source(x) & "*' OR " & strKeywords
                End If
            Next x
            Textnum = Len(strKeywords)
            strKeywords = Microsoft.VisualBasic.Left(strKeywords, Textnum - 4)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        On Error Resume Next
        If lstResults.Text = "" Then Exit Sub
        frmEdit.GetEditData(lstResults.SelectedItem)
        frmEdit.MdiParent = FrmMain
        frmEdit.Show()
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        On Error Resume Next
        lstResults.Items.Clear()
        cmbAuthor.Enabled = False
        cmbLanguage.Enabled = False
        txtKeyword.Enabled = True
        chkAuthor.CheckState = CheckState.Unchecked
        chkLanguage.CheckState = CheckState.Unchecked
        chkKeyword.CheckState = CheckState.Checked
        cmbAuthor.Text = ""
        cmbLanguage.Text = ""
        txtKeyword.Text = ""
        Frame1.Text = "Search results:"
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
        cmdSearch_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ViewToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ViewToolStripMenuItem.Click
        On Error Resume Next
        If lstResults.Text = "" Then Exit Sub
        frmView.GetViewData(lstResults.SelectedItem)
        frmView.MdiParent = FrmMain
        frmView.Show()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbAuthor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAuthor.SelectedIndexChanged
        If cmbAuthor.SelectedIndex = 0 Then
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDown
            cmbAuthor.SelectedText = ""
        Else
            cmbAuthor.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub
End Class