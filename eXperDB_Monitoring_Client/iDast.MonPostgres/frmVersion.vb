Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Public Class frmVersion
    Private Const REGISTRYPATH As String = "HKEY_LOCAL_MACHINE\Software\K4M\eXperDB.Monitoring\Settings"
    Private Const HKLMPATH As String = "Software\K4M\eXperDB.Monitoring\Settings"
    Private Const APPNAME As String = "eXperDB.Downloader.exe"
    Private _clsQuery As clsQuerys
    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = New clsQuerys(odbcConn)
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        btnAct.Visible = False
        'lblServerVersion.Text = p_clsMsgData.fn_GetData("F004")
        'lblClientVersion.Text = p_clsMsgData.fn_GetData("F275")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        'btnAct.Text = p_clsMsgData.fn_GetData("F003")
    End Sub

    Private Sub frmUserConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadVersion()
    End Sub

    Private Sub ReadVersion()
        Try
            Dim dtTableVersion As DataTable = _clsQuery.SelectSeverVersion()
            If dtTableVersion IsNot Nothing Then
                Dim ClientVersion As String = Application.ProductVersion
                Dim ServerVersion As String = dtTableVersion.Rows(0).Item("VERSION")
                lblClientVersionValue.Text = ClientVersion
                lblServerVersionValue.Text = ServerVersion
                If ClientVersion <> ServerVersion Then
                    btnAct.Visible = True
                    'If MsgBox(p_clsMsgData.fn_GetData("M065", "Server : v" + ServerVersion + "\nClient : v" + ClientVersion), _
                    '          Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                    '    RunDownloader()
                    'End If
                    dtTableVersion.Dispose()
                End If
            Else
                'MsgBox(p_clsMsgData.fn_GetData("M065"))
                dtTableVersion.Dispose()
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If MsgBox(p_clsMsgData.fn_GetData("M065", "Server : v" + lblServerVersionValue.Text + "\nClient : v" + lblClientVersionValue.Text), _
          Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
            AccessLog("upgrade", 0, "Upgrade client")
            RunDownloader()
        End If
    End Sub

    Private Sub RunDownloader()

        Dim proc As Process = Nothing
        Try
            Dim registryKey As RegistryKey = Nothing
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
            registryKey = registryKey.OpenSubKey(HKLMPATH, True)
            If registryKey IsNot Nothing Then
                Dim installPath = CStr(My.Computer.Registry.GetValue(REGISTRYPATH, "InstallPath", Nothing) + "\" + APPNAME)
                proc = Process.Start(installPath)
                Threading.Thread.Sleep(500)
            End If
            'Dim installPath = "D:\01.Project\K4M\DX-Monitoring\eXper-Monitoring\experdbmon_for_github\eXperDB_Monitoring_Client\iDast.MonPostgres\bin\Debug\eXperDB.Downloader.exe"
            Application.Exit()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub AccessLog(ByVal strAccessType As String, ByVal intStatus As Integer, _
                      Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertUserAccessInfo(p_cSession.UserID, strAccessType, intStatus, strLog, strLocIP)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
End Class