Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Threading
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO

Public Class frmDownloader
    Inherits Form

    Public Enum GetWndConsts
        GW_HWNDFIRST = 0
        GW_HWNDLAST = 1
        GW_HWNDNEXT = 2
        GW_HWNDPREV = 3
        GW_OWNER = 4
        GW_CHILD = 5
        GW_ENABLEDPOPUP = 6
        GW_MAX = 6
    End Enum
    Private Const REGISTRYPATH As String = "HKEY_LOCAL_MACHINE\Software\K4M\eXperDB.Monitoring\Settings"
    Public p_AppConfigIni As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Config.ini")
    Private Const APPNAME As String = "eXperDB.Monitoring"
    Private Const RBLOCKSIZE As Integer = 1024 * 1024 * 1
    Private _AgentIP As String
    Private _AgentPort As Integer
    Private _RecvFileLength As Integer = 0
    Private _DownloadPath As String = ""
    Private _DownloadFile As String = ""
    Private _SetupFilePath As String = ""
    Private _SetupFileName As String = ""
    Private _errorString As String = ""
    Private _checkSum As String = ""
    Private _isClose As Boolean = False

    <DllImport("user32")> _
    Public Shared Function FindWindow(lpClassName As [String], lpWindowName As [String]) As IntPtr
    End Function
    <DllImport("user32")> _
    Private Shared Function FindWindowEx(ByVal parentHandle As IntPtr, ByVal childAfter As IntPtr, ByVal lclassName As String, ByVal windowTitle As String) As IntPtr
    End Function
    <DllImport("user32")> _
    Private Shared Function SetForegroundWindow(ByVal hwnd As Long) As IntPtr
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Private Shared Function SendMessage(ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Private Shared Function GetWindow(ByVal hwnd As IntPtr, ByVal wCmd As GetWndConsts) As Integer
    End Function
    <DllImport("user32.dll", SetLastError:=False, CharSet:=CharSet.Unicode)>
    Public Shared Function GetWindowText(hWnd As IntPtr, lpString As StringBuilder, nMaxCount As Integer) As Integer
    End Function


    Private Const BM_CLICK As Integer = &HF5
    Private Const WM_LBUTTONDOWN As Integer = &H201

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmDownloader_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _isClose = True
    End Sub


    Private Sub frmDownloader_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private WithEvents AgentMsg As clsAgentEMsg
    Private Sub AgentMsg_Complete(sender As Object, e As Object) Handles AgentMsg.Complete

        If _isClose Then
            bgmanual.CancelAsync()
            Return
        End If

        If e.GetType.Equals(GetType(clsAgentEMsg.filedata)) Then
            Dim rtnValue As clsAgentEMsg.filedata = DirectCast(e, clsAgentEMsg.filedata)

            If rtnValue.error_cd Is Nothing Then
                Dim bytes As Byte() = Convert.FromBase64CharArray(rtnValue.sendbuffer, 0, rtnValue.sendbuffer.Length)
                My.Computer.FileSystem.WriteAllBytes(_DownloadPath, bytes, True)

                _RecvFileLength += rtnValue.sendbyte
                If rtnValue.filelength > _RecvFileLength Then
                    AgentMsg = New clsAgentEMsg(_AgentIP, _AgentPort)
                    AgentMsg.SendDX100(_RecvFileLength, RBLOCKSIZE)
                    Me.Invoke(New MethodInvoker(Sub()
                                                    bgmanual.ReportProgress(_RecvFileLength / rtnValue.filelength * 100)
                                                End Sub))
                Else
                    _checkSum = rtnValue.checksum
                    Me.Invoke(New MethodInvoker(Sub()
                                                    If bgmanual.IsBusy = True Then
                                                        bgmanual.CancelAsync()
                                                        Return
                                                    End If
                                                    bgmanual.RunWorkerAsync()
                                                End Sub))
                End If
            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                If bgmanual.IsBusy = True Then
                                                    bgmanual.CancelAsync()
                                                    Return
                                                End If
                                                _errorString = rtnValue.error_msg
                                                bgmanual.RunWorkerAsync()
                                            End Sub))
            End If
        Else
            Me.Invoke(New MethodInvoker(Sub()
                                            If bgmanual.IsBusy = True Then
                                                bgmanual.CancelAsync()
                                                Return
                                            End If
                                            _errorString = "Unable to download file."
                                            bgmanual.RunWorkerAsync()
                                        End Sub))
        End If
    End Sub

    Public Function AgentInfoRead() As eXperDB.ODBC.structConnection
        Dim clsConfigIni As New Common.IniFile(p_AppConfigIni)


        Dim strUsr As String = clsConfigIni.ReadValue("AGENT", "USER", "")
        Dim strPw As String = clsConfigIni.ReadValue("AGENT", "PW", "")
        If strPw <> "" Then
            Dim dec As New eXperDB.Common.ClsCrypt
            strPw = dec.DecryptString(strPw, "cashweb0")
        End If
        Dim strIP As String = clsConfigIni.ReadValue("AGENT", "IP", "")
        Dim strPort As String = clsConfigIni.ReadValue("AGENT", "PORT", "0")
        Dim strDB As String = clsConfigIni.ReadValue("AGENT", "DATABASE", "")
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim enmODBC As eXperDBODBC.enumODBCType = clsConfigIni.ReadValue("AGENT", "ODBC", dbType)

        Dim rtnStruct As New eXperDB.ODBC.structConnection(enmODBC, strIP, IIf(strPort = "", 0, CInt(strPort)), strUsr, strDB, strPw)
        Return rtnStruct

    End Function

    Private Sub frmDownloader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tmpStruct As eXperDB.ODBC.structConnection = AgentInfoRead()
        Dim dtTable As DataTable
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim conODBC As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)
        Try
            If conODBC IsNot Nothing Then
                Dim strQuery As String = " SELECT AGENT_IP, AGENT_PORT, VERSION FROM TB_CONFIG WHERE ADMIN_USER_ID='ADMIN'"
                Dim dtSet As DataSet = conODBC.dbSelect(strQuery)
                If dtSet IsNot Nothing AndAlso dtSet.Tables.Count > 0 Then
                    dtTable = dtSet.Tables(0)
                    _AgentIP = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_IP")), "", dtTable.Rows(0).Item("AGENT_IP"))
                    _AgentPort = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_PORT")), 0, dtTable.Rows(0).Item("AGENT_PORT"))
                End If
            End If
        Catch ex As Exception
        End Try

        'prepare filesystem
        SetupDownloadFile()

        AgentMsg = New clsAgentEMsg(_AgentIP, _AgentPort)
        AgentMsg.SendDX100(0, RBLOCKSIZE)
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(100)
    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        lblProgress.Text = e.ProgressPercentage.ToString() + "%"
        PBDownloader.Value = e.ProgressPercentage
    End Sub

    Private Sub bckmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If e.Cancelled = False Then
            If _errorString <> "" Then
                MsgBox(_errorString)
                Me.Close()
                Return
            End If
            'lblEndTime.Text = Now
            lblStatus.Text = "Download complete"
            Try
                If Len(Dir(_SetupFilePath + _SetupFileName)) <> 0 Then
                    My.Computer.FileSystem.DeleteFile(_SetupFilePath + _SetupFileName)
                End If

                My.Computer.FileSystem.RenameFile(_DownloadPath, _SetupFileName)

                If validateFile(_SetupFilePath + _SetupFileName) = True Then
                    runSetup()
                Else
                    MsgBox("The downloaded file is not valid.")
                End If
            Catch exio As System.IO.IOException
                MsgBox("Fail to rename downloaded file.")
            Catch ex As Exception

            End Try
            Threading.Thread.Sleep(100)
            Me.Close()
        End If
    End Sub

    Public Function MsgBox(ByVal strMsg As String, Optional ByVal Title As String = "Message", Optional ByVal Buttons As frmMsgbox.MsgBoxStyle = frmMsgbox.MsgBoxStyle.OKOnly) As frmMsgbox.MsgBoxResult
        Dim frmMsg As New frmMsgbox(strMsg, Title, Buttons)
        Return frmMsg.ShowDialog
    End Function

    Public Sub SetupDownloadFile()
        Try
            Dim ClientVersion As String = Application.ProductVersion.Replace(".", "_")
            _DownloadFile = APPNAME + "_" + ClientVersion
            _DownloadPath = GetAppDataPath() + "\" + "K4M"
            'create download directory
            If (Not System.IO.Directory.Exists(_DownloadPath)) Then
                System.IO.Directory.CreateDirectory(_DownloadPath)
            End If

            _DownloadPath = _DownloadPath + "\" + APPNAME + "_" + ClientVersion
            If (Not System.IO.Directory.Exists(_DownloadPath)) Then
                System.IO.Directory.CreateDirectory(_DownloadPath)
            End If

            _SetupFilePath = _DownloadPath + "\"
            _DownloadPath = _DownloadPath + "\" + _DownloadFile + ".downloading"
            _SetupFileName = _DownloadFile + ".exe"

            If Len(Dir(_DownloadPath)) <> 0 Then
                My.Computer.FileSystem.DeleteFile(_DownloadPath)
            End If
        Catch ex As Exception
            MsgBox("Failed to create temporary directory")
        End Try

    End Sub
    Function GetAppDataPath() As String
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
    End Function
    Sub runSetup()
        Dim proc As Process = Nothing

        For Each p As Process In Process.GetProcesses()
            If p.ProcessName = "eXperDB.Monitoring" Then
                p.Kill()
                Exit For
            End If
        Next

        proc = Process.Start(_SetupFilePath + _SetupFileName)
        Threading.Thread.Sleep(3000)
    End Sub

    Function validateFile(ByVal vFilepath As String) As Boolean
        Return _checkSum.Equals(GenerateFileMD5(vFilepath))
    End Function

    Function GenerateFileMD5(ByVal filePath As String) As String
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string
    End Function
End Class
