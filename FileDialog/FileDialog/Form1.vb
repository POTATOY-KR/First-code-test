Imports System.Reflection
Imports System.Security.Principal
Public Class Form1

    Dim selectcycle As Integer
    Dim closechk As Boolean
    Dim filedirwrt() As String
    Dim fileexewrt() As String
    Dim fileminwrt() As Boolean
    Dim Folderchk As FolderBrowserDialog
    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFileSelect_Click(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        Select Case selectcycle
            Case 1
                Dim OpenFileDialog1 As New OpenFileDialog()
                OpenFileDialog1.Title = "HAERUBOT.exe 파일을 선택해주세요(기본위치: C:\HAERUBOT)"
                ' 초기 디렉토리를 설정합니다.
                OpenFileDialog1.InitialDirectory = "C:\HAERUBOT\"
                ' 초기 선택파일명을 선택합니다.
                OpenFileDialog1.FileName = "HAERUBOT.exe"
                ' 파일의 필터를 설정합니다.
                OpenFileDialog1.Filter = "실행파일|*.exe;"
                ' 필터의 초기설정입니다. 
                OpenFileDialog1.FilterIndex = 1
                ' 다이얼로그를 닫을때 마지막 설정을 유효로 하겠다는 설정입니다.
                OpenFileDialog1.RestoreDirectory = True
                ' 복수파일을 선택가능하게 합니다.
                OpenFileDialog1.Multiselect = False
                ' HELP 버튼을 표시합니다.
                OpenFileDialog1.ShowHelp = False
                ' 읽기전용으로 표시합니다.
                OpenFileDialog1.ShowReadOnly = False
                ' 체크박스를 표시합니다.
                OpenFileDialog1.ReadOnlyChecked = False
                ' 존재하지않는 파일을 선택했을때 경고를 표시합니다.
                OpenFileDialog1.CheckFileExists = True
                ' 존재하지않는 경로를 지정했을때 경고를 표시합니다.
                OpenFileDialog1.CheckPathExists = True
                ' 확장자가 존재하지 않는경우에는 확장자를 자동으로 붙여줍니다.
                'OpenFileDialog1.AddExtension = True
                ' 유효한 Win32 파일명만을 입력받게합니다.
                'OpenFileDialog1.ValidateNames = True
                ' 다이얼로그를 표시하고 OK 선택시에만 선택한 파일을 표시합니다.
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox1.Text = OpenFileDialog1.FileName
                    Dim HRB As String
                    'HRB = Mid(TextBox1.Text, 1, TextBox1.TextLength - 12)
                    HRB = Mid(TextBox1.Text, TextBox1.TextLength - 11, 12)
                    If HRB = "HAERUBOT.exe" Then
                        TextBox2.Text = Mid(TextBox1.Text, 1, TextBox1.TextLength - 12)
                        btnFileCopy.Enabled = True
                    Else
                        TextBox2.Text = "다시 선택해주세요"
                    End If

                End If
                ' 처리가 끝났으므로 파기합니다.
                OpenFileDialog1.Dispose()
            Case 2
                Dim OpenFileDialog1 As New OpenFileDialog()
                OpenFileDialog1.Title = "FFXIV_Boot.exe 파일을 선택해주세요(기본위치: C:\Program Files (x86)\FINAL FANTASY XIV - KOREA\boot)"
                ' 초기 디렉토리를 설정합니다.
                OpenFileDialog1.InitialDirectory = "C:\Program Files (x86)\FINAL FANTASY XIV - KOREA\boot"
                ' 초기 선택파일명을 선택합니다.
                OpenFileDialog1.FileName = "FFXIV_Boot.exe"
                ' 파일의 필터를 설정합니다.
                OpenFileDialog1.Filter = "실행파일|*.exe;"
                ' 필터의 초기설정입니다. 
                OpenFileDialog1.FilterIndex = 1
                ' 다이얼로그를 닫을때 마지막 설정을 유효로 하겠다는 설정입니다.
                OpenFileDialog1.RestoreDirectory = True
                ' 복수파일을 선택가능하게 합니다.
                OpenFileDialog1.Multiselect = False
                ' HELP 버튼을 표시합니다.
                OpenFileDialog1.ShowHelp = False
                ' 읽기전용으로 표시합니다.
                OpenFileDialog1.ShowReadOnly = False
                ' 체크박스를 표시합니다.
                OpenFileDialog1.ReadOnlyChecked = False
                ' 존재하지않는 파일을 선택했을때 경고를 표시합니다.
                OpenFileDialog1.CheckFileExists = True
                ' 존재하지않는 경로를 지정했을때 경고를 표시합니다.
                OpenFileDialog1.CheckPathExists = True
                ' 확장자가 존재하지 않는경우에는 확장자를 자동으로 붙여줍니다.
                'OpenFileDialog1.AddExtension = True
                ' 유효한 Win32 파일명만을 입력받게합니다.
                'OpenFileDialog1.ValidateNames = True
                ' 다이얼로그를 표시하고 OK 선택시에만 선택한 파일을 표시합니다.
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox1.Text = OpenFileDialog1.FileName
                    Dim HRB As String
                    'HRB = Mid(TextBox1.Text, 1, TextBox1.TextLength - 12)
                    HRB = Mid(TextBox1.Text, TextBox1.TextLength - 13, 14)
                    If HRB = "FFXIV_Boot.exe" Then
                        TextBox2.Text = Mid(TextBox1.Text, 1, TextBox1.TextLength - 14)
                        btnFileCopy.Enabled = True
                    Else
                        TextBox2.Text = "다시 선택해주세요"
                        btnFileCopy.Enabled = False
                    End If

                End If
                ' 처리가 끝났으므로 파기합니다.
                OpenFileDialog1.Dispose()
            Case Is >= 3
                btnFileCopy.Text = "종료하기"
                Dim OpenFileDialog1 As New OpenFileDialog()
                OpenFileDialog1.Title = "실행파일을 선택해주세요"
                ' 초기 디렉토리를 설정합니다.
                OpenFileDialog1.InitialDirectory = "C:\"
                ' 초기 선택파일명을 선택합니다.
                OpenFileDialog1.FileName = ""
                ' 파일의 필터를 설정합니다.
                OpenFileDialog1.Filter = "실행파일|*.exe;"
                ' 필터의 초기설정입니다. 
                OpenFileDialog1.FilterIndex = 1
                ' 다이얼로그를 닫을때 마지막 설정을 유효로 하겠다는 설정입니다.
                OpenFileDialog1.RestoreDirectory = True
                ' 복수파일을 선택가능하게 합니다.
                OpenFileDialog1.Multiselect = False
                ' HELP 버튼을 표시합니다.
                OpenFileDialog1.ShowHelp = False
                ' 읽기전용으로 표시합니다.
                OpenFileDialog1.ShowReadOnly = False
                ' 체크박스를 표시합니다.
                OpenFileDialog1.ReadOnlyChecked = False
                ' 존재하지않는 파일을 선택했을때 경고를 표시합니다.
                OpenFileDialog1.CheckFileExists = True
                ' 존재하지않는 경로를 지정했을때 경고를 표시합니다.
                OpenFileDialog1.CheckPathExists = True
                ' 확장자가 존재하지 않는경우에는 확장자를 자동으로 붙여줍니다.
                'OpenFileDialog1.AddExtension = True
                ' 유효한 Win32 파일명만을 입력받게합니다.
                'OpenFileDialog1.ValidateNames = True
                ' 다이얼로그를 표시하고 OK 선택시에만 선택한 파일을 표시합니다.
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox1.Text = OpenFileDialog1.FileName
                    Dim x() As String
                    Dim ls As String
                    x = Split(TextBox1.Text, "\")
                    Dim i As Integer
                    ls = ""
                    For i = LBound(x) To UBound(x) - 1
                        ls = ls + x(i) + "\"
                    Next
                    TextBox3.Text = x(UBound(x))
                    TextBox2.Text = ls
                    btnFileCopy.Text = "선택완료"
                End If
                ' 처리가 끝났으므로 파기합니다.
                OpenFileDialog1.Dispose()
        End Select
    End Sub

    ''' <summary>
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFileCopy_Click(sender As Object, e As EventArgs) Handles btnFileCopy.Click
        Dim bfc = btnFileCopy.Text
        If bfc = "선택완료" Then
            If TextBox2.Text = "다시 선택해주세요" Then
            Else
                If TextBox2.Text = "파일이 선택되지 않았습니다" Then
                Else
                    Dim schk As Integer
                    schk = selectcycle
                    Select Case schk
                        Case 1
                            ReDim Preserve fileexewrt(selectcycle)
                            ReDim Preserve filedirwrt(selectcycle)
                            ReDim Preserve fileminwrt(selectcycle)
                            fileexewrt(selectcycle - 1) = "HAERUBOT.exe"
                            filedirwrt(selectcycle - 1) = TextBox2.Text
                            fileminwrt(selectcycle - 1) = False
                            selectcycle = 2
                            TextBox1.Text = "파판14 실행파일(FFXIV_Boot.exe)을 선택해주세요"
                            TextBox2.Text = "파일이 선택되지 않았습니다"
                            btnFileCopy.Enabled = False
                        Case 2
                            ReDim Preserve fileexewrt(selectcycle)
                            ReDim Preserve filedirwrt(selectcycle)
                            ReDim Preserve fileminwrt(selectcycle)
                            fileexewrt(selectcycle - 1) = "FFXIV_Boot.exe"
                            filedirwrt(selectcycle - 1) = TextBox2.Text
                            fileminwrt(selectcycle - 1) = False
                            Dim rtm = MsgBox("미터기를 제외하고" & vbCrLf & "파판과 같이 실행할 추가적인 프로그램이 있습니까?", vbYesNo, "질문")
                            Select Case rtm
                                Case 6
                                    selectcycle = 3
                                    TextBox1.Text = "실행파일을 선택해주세요"
                                    TextBox2.Text = "파일이 선택되지 않았습니다"
                                    TextBox2.Width = 175
                                    CheckBox1.Visible = True
                                    CheckBox1.Checked = False
                                    btnFileCopy.Text = "종료하기"
                                Case 7
                                    filesave()

                            End Select
                        Case Is >= 3
                            Dim rtm = MsgBox("아직 더 추가할 프로그램이 있습니까?" & vbCrLf & "아직 더 추가할 프로그램이 있다면 -> [예]" & vbCrLf & "프로그램 선택을 완료했으면 -> [아니요]" & vbCrLf & "프로그램 선택을 잘못 했다면 -> [취소]", vbYesNoCancel, "확인")
                            Select Case rtm
                                Case 6
                                    ReDim Preserve fileexewrt(selectcycle)
                                    ReDim Preserve filedirwrt(selectcycle)
                                    ReDim Preserve fileminwrt(selectcycle)
                                    fileexewrt(selectcycle - 1) = TextBox3.Text
                                    filedirwrt(selectcycle - 1) = TextBox2.Text
                                    fileminwrt(selectcycle - 1) = CheckBox1.CheckState
                                    selectcycle = selectcycle + 1
                                    TextBox1.Text = "실행파일을 선택해주세요"
                                    TextBox2.Text = "파일이 선택되지 않았습니다"
                                    TextBox3.Text = "파일이 선택되지 않았습니다"
                                    CheckBox1.Checked = False
                                    btnFileCopy.Text = "종료하기"
                                Case 7
                                    ReDim Preserve fileexewrt(selectcycle)
                                    ReDim Preserve filedirwrt(selectcycle)
                                    ReDim Preserve fileminwrt(selectcycle)
                                    fileexewrt(selectcycle - 1) = TextBox3.Text
                                    filedirwrt(selectcycle - 1) = TextBox2.Text
                                    fileminwrt(selectcycle - 1) = CheckBox1.CheckState
                                    filesave()
                                Case 2
                                    TextBox1.Text = "실행파일을 선택해주세요"
                                    TextBox2.Text = "파일이 선택되지 않았습니다"
                                    TextBox3.Text = "파일이 선택되지 않았습니다"
                                    CheckBox1.Checked = False
                                    btnFileCopy.Text = "종료하기"
                            End Select
                    End Select
                End If
            End If
        ElseIf bfc = "종료하기" Then
            Dim rtm = MsgBox("프로그램을 종료하시겠습니까?" & vbCrLf & "선택했던 프로그램으로 실행파일을 만들고 종료하려면 -> [예]" & vbCrLf & "자동화 파일을 만들지 않고 프로그램을 종료하려면 -> [아니요]" & vbCrLf & "프로그램을 종료를 취소할려면 -> [취소]", vbYesNoCancel, "프로그램 종료 확인")
            Select Case rtm
                Case 6
                    selectcycle = selectcycle - 1
                    filesave()
                Case 7
                    closechk = False
                    Me.Close()
                Case 2
            End Select
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsRunningAsAdministrator() Then
            Dim processStartInfo As ProcessStartInfo = New ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase)
            With processStartInfo
                .UseShellExecute = True
                .Verb = "runas"
                Process.Start(processStartInfo)
                closechk = True
                Application.Exit()

            End With
        Else
            TextBox1.Enabled = True
            btnFileSelect.Enabled = True
            TextBox1.Text = "해루봇 실행파일(HAERUBOT.exe)을 선택해주세요"
            TextBox2.Text = "파일이 선택되지 않았습니다"
        End If
        closechk = False
        selectcycle = 1
        Folderchk = New FolderBrowserDialog
        Folderchk.SelectedPath = Application.StartupPath
        Folderchk.Description = "배치파일을 저장할 위치를 선택해주세요" & vbCrLf & "[취소] 선택 시 프로그램을 실행한 폴더에 생성됩니다" & vbCrLf & "*주의* 같은 파일이 존재한다면 덮어씌워집니다"
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing '폼이 닫힐때
        If selectcycle >= 1 Then
            If closechk = False Then
                Dim cc = MsgBox("정말 종료하시겠습니까?" & vbCrLf & "자동화 파일이 만들어지지 않습니다.", vbYesNo, "프로그램 종료 확인")
                If cc = 7 Then
                    e.Cancel = True 'X버튼누른걸 무효화
                End If
            End If
        End If
    End Sub

    Public Sub filesave()
        Dim spth As String
        If Folderchk.ShowDialog() = DialogResult.OK Then
            spth = Folderchk.SelectedPath + "\"
        Else
            spth = Application.StartupPath + "\"
        End If
        Dim thefile As String
        Dim results As String
        Dim file As System.IO.StreamWriter
        Dim dsd As New System.Text.UTF8Encoding(False)
        thefile = spth + "ff14start.bat"
        results = Dir$(thefile)
        If results = "" Then
        Else
            My.Computer.FileSystem.DeleteFile(spth + "ff14start.bat")
        End If
        thefile = spth + "ff14start.txt"
        results = Dir$(thefile)
        If results = "" Then
        Else
            My.Computer.FileSystem.DeleteFile(spth + "ff14start.txt")
        End If
        file = New System.IO.StreamWriter(spth + "ff14start.txt", True, dsd)
        file.WriteLine("@echo off")
        file.WriteLine("chcp 65001")
        file.WriteLine("if not " + Chr(34) + "%minimized%" + Chr(34) + "==" + Chr(34) + "" + Chr(34) + " goto :minimized")
        file.WriteLine("set minimized=true")
        file.WriteLine("start /min cmd /C " + Chr(34) + "%~dpnx0" + Chr(34) + "")
        file.WriteLine("goto :EOF")
        file.WriteLine(":minimized")
        file.WriteLine(">nul 2>&1 " + Chr(34) + "%SYSTEMROOT%\system32\cacls.exe" + Chr(34) + " " + Chr(34) + "%SYSTEMROOT%\system32\config\system" + Chr(34) + "")
        file.WriteLine("if '%errorlevel%' NEQ '0' (")
        file.WriteLine("echo 관리 권한을 요청하는 중...")
        file.WriteLine("goto UACPrompt")
        file.WriteLine(") else ( goto gotAdmin )")
        file.WriteLine(":UACPrompt")
        file.WriteLine("echo Set UAC = CreateObject^(" + Chr(34) + "Shell.Application" + Chr(34) + "^) > " + Chr(34) + "%temp%\getadmin.vbs" + Chr(34) + "")
        file.WriteLine("set params = %*:" + Chr(34) + "=" + Chr(34) + "" + Chr(34) + "")
        file.WriteLine("echo UAC.ShellExecute " + Chr(34) + "cmd.exe" + Chr(34) + ", " + Chr(34) + "/c %~s0 %params%" + Chr(34) + ", " + Chr(34) + "" + Chr(34) + ", " + Chr(34) + "runas" + Chr(34) + ", 1 >> " + Chr(34) + "%temp%\getadmin.vbs" + Chr(34) + "")
        file.WriteLine(Chr(34) + "%temp%\getadmin.vbs" + Chr(34))
        file.WriteLine("del " + Chr(34) + "%temp%\getadmin.vbs" + Chr(34) + "")
        file.WriteLine("exit /B")
        file.WriteLine(":gotAdmin")
        file.WriteLine("pushd " + Chr(34) + "%CD%" + Chr(34))
        file.WriteLine("CD /D " + Chr(34) + "%~dp0" + Chr(34))
        file.WriteLine("@echo off")
        For i = 2 To selectcycle - 1
            Dim flt As String
            If fileexewrt(i).Length > 25 Then
                flt = Mid(fileexewrt(i), 1, 25)
            Else flt = fileexewrt(i)
            End If
            file.WriteLine("tasklist | find " + Chr(34) + flt + Chr(34) + " /c > NUL")
            If fileminwrt(i) = True Then
                file.WriteLine("IF %ErrorLevel%==1 start /min /d " + Chr(34) + filedirwrt(i) + Chr(34) + " /b " + Chr(34) + Chr(34) + " " + Chr(34) + fileexewrt(i) + Chr(34))
            Else
                file.WriteLine("IF %ErrorLevel%==1 start /d " + Chr(34) + filedirwrt(i) + Chr(34) + " /b " + Chr(34) + Chr(34) + " " + Chr(34) + fileexewrt(i) + Chr(34))
            End If

        Next
        'file.WriteLine("@echo on")
        file.WriteLine("tasklist | find " + Chr(34) + fileexewrt(1) + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + "FFXIV_Launcher.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + "ffxiv.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + "ffxiv_dx11.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 start /d " + Chr(34) + filedirwrt(1) + Chr(34) + " /b " + fileexewrt(1))
        file.WriteLine("IF %ErrorLevel%==1 goto strt")
        file.WriteLine("IF NOT %ErrorLevel%==1 goto gogo")
        file.WriteLine(":strt")
        file.WriteLine("tasklist | find " + Chr(34) + "Advanced Combat Tracker.e" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + fileexewrt(0) + Chr(34) + " /c > NUL")
        file.WriteLine("IF NOT %ErrorLevel%==1 goto fish")
        file.WriteLine(":repeat")
        file.WriteLine("Timeout 1 > NUL")
        file.WriteLine("@echo off")
        file.WriteLine("tasklist | find " + Chr(34) + "ffxiv_dx11.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + "ffxiv.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF NOT %ErrorLevel%==1 goto gogo")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + "FFXIV_Launcher.exe" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 goto fish")
        file.WriteLine("IF NOT %ErrorLevel%==1 goto rtrn")
        file.WriteLine(":rtrn")
        file.WriteLine("goto repeat")
        file.WriteLine(":gogo")
        'file.WriteLine("@echo on")
        file.WriteLine("tasklist | find " + Chr(34) + "Advanced Combat Tracker.e" + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 tasklist | find " + Chr(34) + fileexewrt(0) + Chr(34) + " /c > NUL")
        file.WriteLine("IF %ErrorLevel%==1 start /d " + Chr(34) + filedirwrt(0) + Chr(34) + " /b " + fileexewrt(0))
        file.WriteLine(":fish")
        'file.WriteLine("pause")
        file.Close()
        My.Computer.FileSystem.RenameFile(spth + "ff14start.txt", "ff14start.bat")
        Dim cc = MsgBox("시작 메뉴에 바로가기를 추가하시겠습니까?", vbYesNo, "확인")
        If cc = 6 Then
            CreateShortCut(spth + "ff14start.bat")
        End If
        closechk = True
        Me.Close()
    End Sub
    Private Function IsRunningAsAdministrator() As Boolean
        Dim windowsIdentity As WindowsIdentity = WindowsIdentity.GetCurrent()
        Dim windowsPrincipal As WindowsPrincipal = New WindowsPrincipal(windowsIdentity)
        Return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator)
    End Function
    Private Sub CreateShortCut(ByVal TargetName As String)
        Dim oShell As Object
        Dim oLink As Object
        Try
            oShell = CreateObject("WScript.Shell")
            oLink = oShell.CreateShortcut(My.Computer.FileSystem.SpecialDirectories.Programs + "\ff14start.lnk")
            oLink.TargetPath = TargetName
            oLink.WindowStyle = 1
            oLink.IconLocation = Application.ExecutablePath & ", 0"
            oLink.Save()
        Catch ex As Exception
        End Try
    End Sub
End Class