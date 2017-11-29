Option Explicit On
Imports System.Windows.Forms
Imports System.Windows
Imports System.IO
Imports Microsoft.Win32

Public Class frmSetting
    Private CurrPath As String = CurDir() & Path.DirectorySeparatorChar
    Private ConfigureFile As String = CurrPath & "Configure.xml"
    Private Log4jFile As String = CurrPath & "App.Asbl.xml"
    Private _FolderType() As String = {"Tmp", "User", "Log"}
    Private _YoN(,) As String = {{"Y", "예"}, {"N", "아니요"}}

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "환경설정"
        Me.Icon = PuplationIco(My.Resources.wizard)

        '버튼 이미지 초기화
        SettingButton.Image = PuplationIco(My.Resources.play).ToBitmap
        ClearButton.Image = PuplationIco(My.Resources.inital).ToBitmap
        TnsOpenDirButton.Image = PuplationIco(My.Resources.folder_open).ToBitmap
        TempOpenDirButton.Image = PuplationIco(My.Resources.folder_open).ToBitmap
        UserOpenDirButton.Image = PuplationIco(My.Resources.folder_open).ToBitmap
        LogOpenDirButton.Image = PuplationIco(My.Resources.folder_open).ToBitmap
        MetaOpenDirButton.Image = PuplationIco(My.Resources.folder_open).ToBitmap
        CloseTSB.Image = PuplationIco(My.Resources.proc_stop).ToBitmap

        InfoTextBox.Text = "솔루션 기본 환경을 세팅합니다." & vbCrLf & _
                           "수행하기전 i-DAST를 Close 및 같은 폴더 위치에서 " & _
                           "실행해주시기 바랍니다."

    End Sub

    Private Sub frmSetting_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        '초기 경로
        initPath()

        '세팅정보 가져오기
        getConfigureXml()

        InfoTextBox.SelectionLength = 0
    End Sub

    '==================================================
    ' 아이콘 리턴
    '==================================================
    Private Function PuplationIco(ByVal pIconName As Icon) As Icon
        Dim img As Icon = pIconName
        Return img
    End Function

    Private Sub initPath()
        TempPath.Text = CurrPath & _FolderType(0)
        UserPath.Text = CurrPath & _FolderType(1)
        LogPath.Text = CurrPath & _FolderType(2)
    End Sub


    Private Sub SettingButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingButton.Click

        If Trim(KeyTextBox.Text) = "" Then
            MsgBox("인증 정보를 입력해주십시요.", MsgBoxStyle.Information, "정보")
            Exit Sub
        End If

        '설정 변경
        setConfigure()

    End Sub

    Private Sub getConfigureXml()
        Try
            Dim CFG = New ClsConfigureCtl(ConfigureFile)
            TnsPath.Text = CFG.getValue("cfgAppender", "TnsFullPath")
            'TempPath.Text = CFG.getValue("cfgAppender", "TempPath")
            'UserPath.Text = CFG.getValue("cfgAppender", "UserPath")
            'LogPath.Text = CFG.getValue("cfgAppender", "LogPath")
            KeyTextBox.Text = CFG.getValue("cfgAppender", "Certification")

            IPTextBox.Text = CFG.getValue("UpdateServer", "IpAddress")
            PortTextBox.Text = CFG.getValue("UpdateServer", "Port")
            SSLComboBox.Text = CFG.getValue("UpdateServer", "UsingSSL")

            CheckMetaFile.CheckState = False

        Catch ex As Exception
            MsgBox("설정정보 추출시 에러가 발생하였습니다", MsgBoxStyle.Critical, "에러")
        End Try
    End Sub

    Private Sub setConfigure()

        Try
            Me.Validate()

            '언어환경세팅
            Environment.SetEnvironmentVariable("NLS_LANG", "KOREAN_KOREA.KO16MSWIN949", EnvironmentVariableTarget.User)

            'i-DAST Configure 세팅
            Dim CFG = New ClsConfigureCtl(ConfigureFile)
            CFG.setValue("cfgAppender", "TnsFullPath", TnsPath.Text)
            CFG.setValue("cfgAppender", "TempPath", TempPath.Text)
            CFG.setValue("cfgAppender", "UserPath", UserPath.Text)
            CFG.setValue("cfgAppender", "LogPath", LogPath.Text)
            CFG.setValue("cfgAppender", "Certification", KeyTextBox.Text)

            CFG.setValue("UpdateServer", "IpAddress", IPTextBox.Text)
            CFG.setValue("UpdateServer", "Port", PortTextBox.Text)
            CFG.setValue("UpdateServer", "UsingSSL", SSLComboBox.Text)
            CFG.Save()

            'log4jxml Configure 세팅
            Dim LOG4J = New ClsLog4jXmlCtl(Log4jFile)
            LOG4J.setValue("iDastApp", "file", LogPath.Text & Path.DirectorySeparatorChar & "iDastApp.log")
            LOG4J.Save()

            '메타정보파일 세팅
            If CheckMetaFile.CheckState Then
                File.Move(MetaFilePath.Text, Application.StartupPath & Path.DirectorySeparatorChar & _
                                             "Shared" & Path.DirectorySeparatorChar & _
                                             "lib" & Path.DirectorySeparatorChar & "anthology" & ".dll")            
            End If

            MsgBox("정상적으로 적용되었습니다", MsgBoxStyle.Information, "정보")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "에러")
        End Try

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        TnsPath.Clear()
        TempPath.Clear()
        UserPath.Clear()
        LogPath.Clear()
        KeyTextBox.Clear()

        '초기화 경로
        initPath()
    End Sub

    Private Function OpenTnsFD() As String
        Dim FilePath As String = String.Empty
        With OpenFileDialog
            .Title = "Tns 경로"
            .FileName = "tnsnames.ora"
            .RestoreDirectory = True
            .Filter = "File (*.ora)|*.ora"

            If (.ShowDialog(Me) = DialogResult.OK) Then
                FilePath = .FileName
            End If
        End With
        Return FilePath
    End Function

    Private Function OpenIdaFD() As String
        Dim FilePath As String = String.Empty
        With OpenFileDialog
            .Title = "파일 위치"
            .FileName = "anthology.ida"
            .Filter = "File (*.ida)|*.ida"
            .RestoreDirectory = True
            If (.ShowDialog(Me) = DialogResult.OK) Then
                FilePath = .FileName
            End If
        End With
        Return FilePath
    End Function

    Private Function OpenFoldDir() As String
        Dim FilePath As String = String.Empty
        With FolderBrowserDialog
            .RootFolder = Environment.SpecialFolder.Desktop

            If (.ShowDialog(Me) = DialogResult.OK) Then
                '파일경로지정
                FilePath = .SelectedPath

            End If
        End With
        Return FilePath

    End Function

    Private Sub TnsOpenDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TnsOpenDirButton.Click
        TnsPath.Text = OpenTnsFD()
    End Sub

    Private Sub TempOpenDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TempOpenDirButton.Click
        TempPath.Text = OpenFoldDir() & Path.DirectorySeparatorChar & _FolderType(0)
    End Sub

    Private Sub UserOpenDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserOpenDirButton.Click
        UserPath.Text = OpenFoldDir() & Path.DirectorySeparatorChar & _FolderType(1)
    End Sub

    Private Sub LogOpenDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOpenDirButton.Click
        LogPath.Text = OpenFoldDir() & Path.DirectorySeparatorChar & _FolderType(2)
    End Sub

    Private Sub CloseTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseTSB.Click
        Me.Close()
    End Sub

    Private Sub MetaOpenDirButton_Click(sender As Object, e As EventArgs) Handles MetaOpenDirButton.Click
        MetaFilePath.Text = OpenIdaFD()
    End Sub

    Private Sub CheckMetaFile_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckMetaFile.CheckStateChanged
        MetaOpenDirButton.Enabled = CheckMetaFile.CheckState
    End Sub
End Class
