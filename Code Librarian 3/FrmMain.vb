Option Explicit On
Option Infer On


Friend Class FrmMain
    Inherits System.Windows.Forms.Form

    Public Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If Screen.PrimaryScreen.Bounds.Width < 1024 Or Screen.PrimaryScreen.Bounds.Height < 600 Then
                Dim nResults As DialogResult
                nResults = MsgBox("This program is designed to work with screen resolutions of 1024 X 600 or greater. Do you want to continue?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Code Librarian")
                If nResults = Windows.Forms.DialogResult.No Then
                    Close()
                End If
            End If
            'This sets the background image since using the vb UI to do it non programmically doesn't work if i remember correctly.
            Me.BackgroundImage = My.Resources.Alpha_Background
            TimeToolStripStatusLabel1.Text = Now.ToLongTimeString
            DateToolStripStatusLabel2.Text = Now.Date
            LoadSettings()
            'Opens the database from your profile so that it can be used.
            db = DAODBEngine_definst.OpenDatabase(DBPath)
            rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            'Loads the language filter names list
            FilterLanguage.Items.Add("All languages")
            FilterLanguage.Items.Add("Orphaned Records")
            If Not rsLang.RecordCount = 0 Then
                rsLang.MoveFirst()
                Do While Not rsLang.EOF
                    langList.Add(rsLang.Fields("Language").Value) 'This is the list used to created the dynamic array to create the orphaned records category
                    rsLang.MoveNext()
                Loop
            End If
            'Sorts the language list alphabetically under the 2 default filters all languages and orphaned records.
            langList.Sort()
            For Each nLang As String In langList
                FilterLanguage.Items.Add(nLang)
            Next
            'Creates the array that will be used to check for orphaned records.
            langListArray = langList.ToArray()
            'provokes the change invent in the language combobox to finish loading the code names list.
            'This is done like this because if I included the code here then changed the index it would run twice.
            FilterLanguage.SelectedIndex = 0
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Public Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Try
            'This will do the actual list reloading.
            FilterLanguage_SelectedIndexChanged(Me, EventArgs.Empty)
            'Updates the count in the statusbar after refresh is called for example when a record is added and refresh got called.
            Dim Count As Short = rsCode.RecordCount
            If Count > 1 Or Count = 0 Then
                stbInfo.Text = "There are currently " & Count & " code records in the database."
            Else
                stbInfo.Text = "There is currently " & Count & " code record in the database."
            End If
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub FilterLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterLanguage.SelectedIndexChanged
        If FilterLanguage.Text = "All languages" Then 'Load all the code records into the list.
            lstCode.Items.Clear()
            If Not rsCode.RecordCount = 0 Then 'rsCode.RecordCount tell us 0 if empty or 1 or -1 if not.
                rsCode.MoveFirst()
                Do While Not rsCode.EOF
                    lstCode.Items.Add(rsCode.Fields("CodeName").Value)
                    rsCode.MoveNext()
                Loop
            End If
            Dim Count As Short = rsCode.RecordCount
            If Count > 1 Or Count = 0 Then
                stbInfo.Text = "There are currently " & Count & " code records in the database."
            Else
                stbInfo.Text = "There is currently " & Count & " code record in the database."
            End If
        ElseIf FilterLanguage.Text = "Orphaned Records" Then 'displays the orphaned recordes that are set to a language that no longer exist.
            lstCode.Items.Clear()
            If Not rsCode.RecordCount = 0 Then 'rsCode.RecordCount tell us 0 if empty or 1 or -1 if not.
                rsCode.MoveFirst()
                Do While Not rsCode.EOF
                    If isOrphaned(rsCode.Fields("Language").Value) = True Then
                        lstCode.Items.Add(rsCode.Fields("CodeName").Value)
                    End If
                    rsCode.MoveNext()
                Loop
            End If
        Else 'else if the list is being filter by a specific programming language then display these records for that.
            Dim strLanguage As String
            Dim strSearch As String
            strSearch = ""
            lstCode.Items.Clear()
            strLanguage = "[Language] Like '" & FilterLanguage.Text & "'"
            strSearch = strLanguage
            With rsCode
                .FindFirst(strSearch)
                If .NoMatch Then
                    Exit Sub
                Else
                    lstCode.Items.Add(rsCode.Fields("CodeName").Value)
                    Again(strSearch)
                End If
            End With
        End If
    End Sub

    Private Function isOrphaned(strLang As String) As Boolean
        For Each nLang As String In langListArray
            If strLang = nLang Then
                Return False ' its not orphaned
            End If
        Next
        Return True ' it is orphaned since it made it here this far.
    End Function

    Private Sub Again(ByRef strSearch As String)
        On Error Resume Next
        With rsCode
            .FindNext(strSearch)
            If .NoMatch Then
                Exit Sub
            Else
                lstCode.Items.Add(rsCode.Fields("CodeName").Value)
                Again(strSearch)
            End If
        End With
    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        On Error Resume Next
        If lstCode.Text = "" Then Exit Sub
        frmView.GetViewData(lstCode.SelectedItem)
        frmView.MdiParent = Me
        frmView.Show()
    End Sub

    Private Sub lstCode_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCode.DoubleClick
        On Error Resume Next
        cmdView_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub TimerClock_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TimerClock.Tick
        TimeToolStripStatusLabel1.Text = Now.ToLongTimeString
        DateToolStripStatusLabel2.Text = Now.Date
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        On Error Resume Next
        If lstCode.Text = "" Then Exit Sub
        frmEdit.GetEditData(lstCode.SelectedItem)
        frmEdit.MdiParent = Me
        frmEdit.Show()
    End Sub

    Private Sub lstCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdView_Click(Me, EventArgs.Empty)
        End If
    End Sub

#Region "Menu Items"

    Private Sub DonateToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DonateToolStripMenuItem1.Click
        On Error Resume Next
        Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=8493677")
    End Sub

    Private Sub SaveBackupToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveBackupToolStripMenuItem.Click
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmview" Then
            MsgBox("You are currently viewing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmadd" Then
            MsgBox("You are currently adding a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim nResults As DialogResult
        If Me.lstCode.Tag = "1" Then
            nResults = MsgBox("Are you sure you want to backup your opened database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            FBDialog1.Description = vbNewLine & "Select a folder to backup your opened database to:"
        Else
            nResults = MsgBox("Are you sure you want to backup your personal database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            FBDialog1.Description = vbNewLine & "Select a folder to backup your personal database to:"
        End If
        Dim nSourceFilename As String
        Dim nBackupPath As String
        nResults = FBDialog1.ShowDialog()
        If nResults = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        'This gets the filename without extension just in case a custom name was used so it keeps it for when it is saved.
        If Me.lstCode.Tag = "1" Then
            nSourceFilename = System.IO.Path.GetFileNameWithoutExtension(nTempDBPath)
        Else
            nSourceFilename = System.IO.Path.GetFileNameWithoutExtension(DBPath)
        End If
        'This check to see if the path end with \ abd builds the distination path using the filename from above.
        If FBDialog1.SelectedPath.EndsWith("\") = True Then 'example c:\
            nBackupPath = FBDialog1.SelectedPath & nSourceFilename & "_" & Format(Today.Date, "yyyy-MM-dd") & ".cdb"
        Else
            nBackupPath = FBDialog1.SelectedPath & "\" & nSourceFilename & "_" & Format(Today.Date, "yyyy-MM-dd") & ".cdb"
        End If
        'Here is where the actually backing up is done.
        Try
            db.Close() 'Here we close the database to back it up. It doesn't need to be closed but we do it just in case anyway.
            If Me.lstCode.Tag = "1" Then
                My.Computer.FileSystem.CopyFile(nTempDBPath, nBackupPath, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Your opened database has been backed up successfully.", MsgBoxStyle.Information, "Code Librarian")
            Else
                My.Computer.FileSystem.CopyFile(DBPath, nBackupPath, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Your personal database has been backed up successfully.", MsgBoxStyle.Information, "Code Librarian")
            End If
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        Finally
            'Here we reopen the database now that it has been backed up.
            If Me.lstCode.Tag = "1" Then
                db = DAODBEngine_definst.OpenDatabase(nTempDBPath)
                rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            Else
                db = DAODBEngine_definst.OpenDatabase(DBPath)
                rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            End If
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        On Error Resume Next
        Me.Close()
    End Sub

    Private Sub SearchForRecordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchForRecordToolStripMenuItem.Click
        On Error Resume Next
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim Frm As New frmSearch
        Frm.ShowDialog()
        Frm.Dispose()
        Frm = Nothing
    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        On Error Resume Next
        frmAdd.MdiParent = Me
        frmAdd.Show()
    End Sub

    Private Sub OpenDatabaseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenDatabaseToolStripMenuItem.Click
        Dim nResults As DialogResult
        Try
            dlgOpen.Title = "Open Database"
            dlgOpen.Filter = "Code Librarian Database (*.cdb)|*.cdb"
            dlgOpen.InitialDirectory = ""
            dlgOpen.FileName = ""
            nResults = dlgOpen.ShowDialog()
            If nResults = DialogResult.Cancel Then
                Exit Sub
            End If
            If Me.Tag = "frmedit" Then
                frmEdit.Close()
            ElseIf Me.Tag = "frmadd" Then
                frmAdd.Close()
            ElseIf Me.Tag = "frmview" Then
                frmView.Close()
            End If
            Me.Tag = ""
            nTempDBPath = dlgOpen.FileName
            CompactRepairToolStripMenuItem.Text = "Compact/Repair Opened Database"
            Me.lstCode.Tag = "1"
            CloseDatabaseToolStripMenuItem1.Visible = True
            ToolStripSeparator9.Visible = True
            'This releases the database from use by this program
            db.Close()
            'Opens the manually opened database for use.
            db = DAODBEngine_definst.OpenDatabase(nTempDBPath)
            rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            'Loads the language filter names list
            FilterLanguage.Items.Clear()
            langList.Clear()
            FilterLanguage.Items.Add("All languages")
            FilterLanguage.Items.Add("Orphaned Records")
            If Not rsLang.RecordCount = 0 Then
                rsLang.MoveFirst()
                Do While Not rsLang.EOF
                    langList.Add(rsLang.Fields("Language").Value) 'This is the list used to created the dynamic array to create the orphaned records category
                    rsLang.MoveNext()
                Loop
            End If
            'Sorts the language list alphabetically under the 2 default filters all languages and orphaned records.
            langList.Sort()
            For Each nLang As String In langList
                FilterLanguage.Items.Add(nLang)
            Next
            'Creates the array that will be used to check for orphaned records.
            langListArray = langList.ToArray()
            'provokes the change invent in the language combobox to finish loading the code names list.
            'This is done like this because if I included the code here then changed the index it would run twice.
            FilterLanguage.SelectedIndex = 0
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
            Me.Tag = ""
            nTempDBPath = ""
            CompactRepairToolStripMenuItem.Text = "Compact/Repair Personal Database"
            Me.lstCode.Tag = ""
            CloseDatabaseToolStripMenuItem1.Visible = False
            ToolStripSeparator9.Visible = False
            'Opens the database from your profile so that it can be used since there was an error while opening the manually opened one.
            db = DAODBEngine_definst.OpenDatabase(DBPath)
            rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            'Loads the language filter names list
            FilterLanguage.Items.Clear()
            langList.Clear()
            FilterLanguage.Items.Add("All languages")
            FilterLanguage.Items.Add("Orphaned Records")
            If Not rsLang.RecordCount = 0 Then
                rsLang.MoveFirst()
                Do While Not rsLang.EOF
                    langList.Add(rsLang.Fields("Language").Value) 'This is the list used to created the dynamic array to create the orphaned records category
                    rsLang.MoveNext()
                Loop
            End If
            'Sorts the language list alphabetically under the 2 default filters all languages and orphaned records.
            langList.Sort()
            For Each nLang As String In langList
                FilterLanguage.Items.Add(nLang)
            Next
            'Creates the array that will be used to check for orphaned records.
            langListArray = langList.ToArray()
            'provokes the change invent in the language combobox to finish loading the code names list.
            'This is done like this because if I included the code here then changed the index it would run twice.
            FilterLanguage.SelectedIndex = 0
        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        On Error Resume Next
        Dim Frm As New frmSettings
        Frm.ShowDialog()
        Frm.Dispose()
        Frm = Nothing
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        On Error Resume Next
        Dim Frm As New frmAbout
        Frm.ShowDialog()
        Frm.Dispose()
        Frm = Nothing
    End Sub

    Private Sub AddEditAuthorsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddEditAuthorsToolStripMenuItem.Click
        On Error Resume Next
        On Error Resume Next
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmadd" Then
            MsgBox("You are currently adding a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim Frm As New frmEditAuth
        Frm.ShowDialog()
        Frm.Dispose()
        Frm = Nothing
    End Sub

    Private Sub AddEditLanguageToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddEditLanguageToolStripMenuItem.Click
        On Error Resume Next
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmadd" Then
            MsgBox("You are currently adding a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim Frm As New frmEditLang
        Frm.ShowDialog()
        Frm.Dispose()
        Frm = Nothing
    End Sub

    Private Sub DeleteRecordToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteRecordToolStripMenuItem1.Click
        If lstCode.Text = "" Then Exit Sub
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmview" Then
            MsgBox("You are currently viewing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmadd" Then
            MsgBox("You are currently adding a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim nResults As DialogResult
        Try
            nResults = MsgBox("Are you sure you want to delete this record from the library?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.Yes Then
                rsCode.MoveFirst()
                Do Until rsCode.EOF
                    If lstCode.SelectedItem = rsCode.Fields("CodeName").Value Then
                        rsCode.Delete()
                        Exit Do
                    Else
                        rsCode.MoveNext()
                    End If
                Loop
                MsgBox("The record has been deleted successfully.", MsgBoxStyle.Information, "Code Librarian")
                cmdRefresh_Click(Me, EventArgs.Empty)
            End If
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub CloseDatabaseToolStripMenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CloseDatabaseToolStripMenuItem1.Click
        Try
            If Me.Tag = "frmedit" Then
                frmEdit.Close()
            ElseIf Me.Tag = "frmadd" Then
                frmAdd.Close()
            ElseIf Me.Tag = "frmview" Then
                frmView.Close()
            End If
            Me.Tag = ""
            nTempDBPath = ""
            CompactRepairToolStripMenuItem.Text = "Compact/Repair Personal Database"
            Me.lstCode.Tag = ""
            CloseDatabaseToolStripMenuItem1.Visible = False
            ToolStripSeparator9.Visible = False
            'This releases the database from use by this program
            db.Close()
            'To close the opened manually database, the one from your profile is opened in its place.
            db = DAODBEngine_definst.OpenDatabase(DBPath)
            rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
            rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            'Loads the language filter names list
            FilterLanguage.Items.Clear()
            langList.Clear()
            FilterLanguage.Items.Add("All languages")
            FilterLanguage.Items.Add("Orphaned Records")
            If Not rsLang.RecordCount = 0 Then
                rsLang.MoveFirst()
                Do While Not rsLang.EOF
                    langList.Add(rsLang.Fields("Language").Value) 'This is the list used to created the dynamic array to create the orphaned records category
                    rsLang.MoveNext()
                Loop
            End If
            'Sorts the language list alphabetically under the 2 default filters all languages and orphaned records.
            langList.Sort()
            For Each nLang As String In langList
                FilterLanguage.Items.Add(nLang)
            Next
            'Creates the array that will be used to check for orphaned records.
            langListArray = langList.ToArray()
            'provokes the change invent in the language combobox to finish loading the code names list.
            'This is done like this because if I included the code here then changed the index it would run twice.
            FilterLanguage.SelectedIndex = 0
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Private Sub CompactRepairToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CompactRepairToolStripMenuItem.Click
        If Me.Tag = "frmedit" Then
            MsgBox("You are currently editing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmview" Then
            MsgBox("You are currently viewing a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        ElseIf Me.Tag = "frmadd" Then
            MsgBox("You are currently adding a record. Please close it to continue.", MsgBoxStyle.Information, "Code Librarian")
            Exit Sub
        End If
        Dim nResults As DialogResult
        Dim nRepairedFile As String
        Dim nSourceFilename As String
        If Me.lstCode.Tag = "1" Then
            nResults = MsgBox("Are you sure you want to compact/repair your opened database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            'This gets the filename without extension just in case a custom name was used so it keeps it for when it is saved.
            nSourceFilename = System.IO.Path.GetFileNameWithoutExtension(nTempDBPath)
            'This check to see if the path end with \ abd builds the distination path using the filename from above.
            If System.IO.Path.GetDirectoryName(nTempDBPath).EndsWith("\") = True Then 'example c:\
                nRepairedFile = System.IO.Path.GetDirectoryName(nTempDBPath) & nSourceFilename & "-Repaired.cdb"
            Else
                nRepairedFile = System.IO.Path.GetDirectoryName(nTempDBPath) & "\" & nSourceFilename & "-Repaired.cdb"
            End If
        Else
            nResults = MsgBox("Are you sure you want to compact/repair your personal database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
            If nResults = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            'This is in the profile so no extra code needed.
            nRepairedFile = System.IO.Path.GetDirectoryName(DBPath) & "\CodeLIB-Repaired.cdb"
        End If
        Try
            db.Close()
            If Me.lstCode.Tag = "1" Then
                'Here we create the new repaired/compacted database and leave the original as a backup.
                DAODBEngine_definst.CompactDatabase(nTempDBPath, nRepairedFile)
                MsgBox("Your opened database has been compacted/repaired successfully." & vbNewLine & _
                       "The compacted/repaired database has been loaded automatically.", MsgBoxStyle.Information, "Code Librarian")
            Else
                'Here we create the new repaired/compacted database and then delete the bad one and rename the new one for use.
                DAODBEngine_definst.CompactDatabase(DBPath, nRepairedFile)
                My.Computer.FileSystem.DeleteFile(DBPath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                My.Computer.FileSystem.RenameFile(nRepairedFile, "CodeLIB.cdb")
                MsgBox("Your personal database has been compacted/repaired successfully." & vbNewLine & _
                       "The compacted/repaired database has been loaded automatically.", MsgBoxStyle.Information, "Code Librarian")
            End If
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        Finally
            If Me.lstCode.Tag = "1" Then
                'This reopens the new compacted and repaired database
                db = DAODBEngine_definst.OpenDatabase(nRepairedFile)
                rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            Else
                'This reopens the new compacted and repaired database which now has replaced the old one.
                db = DAODBEngine_definst.OpenDatabase(DBPath)
                rsCode = db.OpenRecordset("tblSourceCode", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsLang = db.OpenRecordset("tblLanguage", DAO.RecordsetTypeEnum.dbOpenDynaset)
                rsAuth = db.OpenRecordset("tblAuthor", DAO.RecordsetTypeEnum.dbOpenDynaset)
            End If
        End Try
    End Sub

#End Region

#Region "Toolbar Buttons"

    Private Sub ToolStripButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        OpenDatabaseToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        SettingsToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        AddNewRecordToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        cmdRefresh_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        SearchForRecordToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        AddEditAuthorsToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        AddEditLanguageToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        AboutToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        SaveBackupToolStripMenuItem_Click(Me, EventArgs.Empty)
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        DeleteRecordToolStripMenuItem1_Click(Me, EventArgs.Empty)
    End Sub

#End Region

End Class
