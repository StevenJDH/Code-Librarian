Option Explicit On
Option Infer On

Friend Module modUtilities
    'This are the database objects globally declared and accessible from everywhere.
    Friend DAODBEngine_definst As New DAO.DBEngine
    Friend db As DAO.Database
    Friend rsCode As DAO.Recordset
    Friend rsAuth As DAO.Recordset
    Friend rsLang As DAO.Recordset
    'This is the list used to created the dynamic array to create the orphaned records category
    Friend langList As New List(Of String)()
    Friend langListArray As String()
    'This is the varible that handles what side the list is on.
    Friend AlignList As Integer
    'This is the varible used when the user manually opens a code database.
    Friend nTempDBPath As String

    Public Function DBPath() As String
        Try
            'This copies the local copy to your profile.
            Dim nPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian\CodeLIB.cdb"
            If FileExists(nPath) = False And FileExists(My.Application.Info.DirectoryPath & "\CodeLIB.cdb") = True Then
                MsgBox("Code Librarian will now set up your personal database.", MsgBoxStyle.Information, "Code Librarian")
                'This If Then statement under this creates the directory structure in the profile.
                If System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C") = False Then
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C")
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian")
                ElseIf System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian") = False Then
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian")
                End If
                My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CodeLIB.cdb", nPath, _
                                                FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Finished successfully. You are now ready to start using the program.", MsgBoxStyle.Information, "Code Librarian")
                Return nPath
            ElseIf FileExists(nPath) = True Then
                'If there already use profile copy now that it is there.
                Return nPath
            Else
                'If profile and local copy is missing then find the database and copy to profile.
                Dim nResults As DialogResult = MsgBox("Could not locate your personal database file. Would you like to find it now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Code Librarian")
                If nResults = DialogResult.No Then
                    FrmMain.Close()
                End If
                FrmMain.dlgOpen.Title = "Open database"
                FrmMain.dlgOpen.Filter = "Code Librarian Database (*.cdb)|*.cdb"
                FrmMain.dlgOpen.FileName = "CodeLIB.cdb"
                FrmMain.dlgOpen.InitialDirectory = My.Application.Info.DirectoryPath & "\"
                nResults = FrmMain.dlgOpen.ShowDialog()
                If nResults = DialogResult.Cancel Then
                    FrmMain.Close()
                End If
                MsgBox("Code Librarian will now set up your personal database.", MsgBoxStyle.Information, "Code Librarian")
                'This If Then statement under this creates the directory structure in the profile.
                If System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C") = False Then
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C")
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian")
                ElseIf System.IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian") = False Then
                    System.IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\ASC-C\Code Librarian")
                End If
                My.Computer.FileSystem.CopyFile(FrmMain.dlgOpen.FileName, nPath, _
                                FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException)
                MsgBox("Finished successfully. You are now ready to start using the program.", MsgBoxStyle.Information, "Code Librarian")
                Return nPath
            End If
        Catch
            'If can't load with 3 methods above or is canceled in the middle then exit program.
            FrmMain.Close()
        End Try
    End Function

    Public Function FileExists(ByVal nPath As String) As Boolean
        Return System.IO.File.Exists(nPath)
    End Function

    Public Function Remove_Excess_WhiteSpace(ByVal nText As String) As String
        'Removes excess white space and white space made by tabs, newlines, and returns.
        Dim strData As String = ""
        strData = System.Text.RegularExpressions.Regex.Replace(nText, "\s{2,}", " ")
        strData = System.Text.RegularExpressions.Regex.Replace(strData, "[\t\r\n]", "")
        Return strData.Trim
    End Function

    Public Sub LoadSettings()
        Try
            If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\A Steve Creation\Code Librarian", "1run", Nothing) Is Nothing Then
                My.Computer.Registry.CurrentUser.CreateSubKey("Software\A Steve Creation\Code Librarian")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\A Steve Creation\Code Librarian", _
                        "1run", 1)
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\A Steve Creation\Code Librarian", _
                        "AlignList", 3)
            End If
            AlignList = My.Computer.Registry.GetValue _
                ("HKEY_CURRENT_USER\Software\A Steve Creation\Code Librarian", "AlignList", 3)
            Select Case AlignList
                Case 3
                    FrmMain.picList.Dock = System.Windows.Forms.DockStyle.Left
                Case 4
                    FrmMain.picList.Dock = System.Windows.Forms.DockStyle.Right
            End Select
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

    Public Sub SaveSettings()
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\A Steve Creation\Code Librarian", _
            "AlignList", AlignList)
        Catch
            MsgBox("Error: " & Err.Description, MsgBoxStyle.Critical, "Code Librarian")
        End Try
    End Sub

End Module