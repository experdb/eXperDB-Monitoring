Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Imports System.Net
Imports Microsoft.Win32

Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Const REGISTRYPATH As String = "HKEY_LOCAL_MACHINE\Software\K4M\eXperDB.Monitoring\Settings"
    Private Const HKLMPATH As String = "Software\K4M\eXperDB.Monitoring\Settings"
    Private Const APPNAME As String = "eXperDB.Downloader.exe"
    Private _connStruct As eXperDB.ODBC.structConnection = Nothing
    Private _odbcConn As eXperDBODBC
    Private _clsQuery As clsQuerys

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        'System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        '220, 120, 196, 255
        'btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer))
        'btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Transparent
        btnLogin.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.BorderSize = 0
        btnLogin.BackColor = Color.Transparent
        _connStruct = modCommon.AgentInfoRead()

        If _connStruct.HostIP.Length > 0 Then
            txtServerIP.Text = _connStruct.HostIP
        End If

        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.ReadValue("LOGIN", "USERID", txtUserID.Text)
        Dim rememberID As Boolean = clsIni.ReadValue("LOGIN", "REMEMBERID", 0)
        chkRememberID.Checked = rememberID
        Dim strUserID As String = clsIni.ReadValue("LOGIN", "USERID", "")
        If strUserID.Length > 0 Then
            txtUserID.Text = strUserID
            txtUserID.ForeColor = Color.Black
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If fn_ChkTestBef() = False Then Return
        If makeConnection() = False Then Return
        If DoLogin() = False Then Return

        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("LOGIN", "REMEMBERID", IIf(chkRememberID.Checked, 1, 0))
        If chkRememberID.Checked Then
            clsIni.WriteValue("LOGIN", "USERID", IIf(txtUserID.Text.Equals("User ID"), "", txtUserID.Text))
        Else
            clsIni.WriteValue("LOGIN", "USERID", "")
        End If

        checkVersion()
        txtPassword.Text = "Password"
        txtPassword.ForeColor = Color.DarkGray
        txtPassword.PasswordChar = ""

        Dim frmSvrList As New frmSvrList(_odbcConn, _connStruct)
        frmSvrList.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("LOGIN", "REMEMBERID", IIf(chkRememberID.Checked, 1, 0))
        If chkRememberID.Checked = False Then
            clsIni.WriteValue("LOGIN", "USERID", "")
        End If
        Me.Close()
    End Sub

    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        Dim frmAgentServer As New frmAgentInfo(_connStruct)
        If frmAgentServer.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmAgentServer.rtnValue(_connStruct)
            txtServerIP.Text = _connStruct.HostIP
        End If
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave, btnClose.MouseLeave
        Dim tmpButton = DirectCast(sender, System.Windows.Forms.Button)
        tmpButton.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter, btnClose.MouseEnter
        Dim tmpButton = DirectCast(sender, System.Windows.Forms.Button)
        tmpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(112, Byte), Integer))
    End Sub

    Private Sub txtUserID_Enter(sender As Object, e As EventArgs) Handles txtUserID.Enter
        If txtUserID.Text.Equals("User ID") Then
            txtUserID.Text = ""
            txtUserID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUserID_Leave(sender As Object, e As EventArgs) Handles txtUserID.Leave
        If txtUserID.Text.Equals("") Then
            txtUserID.Text = "User ID"
            txtUserID.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text.Equals("Password") Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text.Equals("") Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.DarkGray
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.Focus()
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Equals("Password") = False Then
            txtPassword.PasswordChar = "*"
        End If
    End Sub

#Region "Movable Form"
    Public Const WM_NCLBUTTONDOWN As Integer = 161
    Public Const HT_CAPTION As Integer = 2

    <DllImport("User32")> Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImport("User32")> Private Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub frmLogin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, pnlLogin.MouseDown, _
                                    lblLoginName.MouseDown, lblLogo.MouseDown, lblLogo1.MouseDown, lblLogo2.MouseDown
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Sub pnlDesc_MouseDown(sender As Object, e As MouseEventArgs)
        If (e.Button = MouseButtons.Left) Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Private Function makeConnection() As Boolean
        Try
            Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
            _odbcConn = New eXperDBODBC(dbType, _connStruct.HostIP, _connStruct.Port, _connStruct.UserID, _connStruct.Password, _connStruct.DBName)
            If _odbcConn.ConnectionCheck = True Then
                _clsQuery = New clsQuerys(_odbcConn)
                If _odbcConn IsNot Nothing AndAlso _odbcConn.GetType Is GetType(eXperDB.ODBC.eXperDBODBC) Then
                    modCommon.AgentInfoWrite(DirectCast(_odbcConn, eXperDB.ODBC.eXperDBODBC).ODBCConninfo)
                    _connStruct = modCommon.AgentInfoRead()
                Else
                    p_Log.AddMessage(clsLog4Net.enmType.Error, p_clsMsgData.fn_GetData("M022"))
                End If
            Else
                MsgBox(p_clsMsgData.fn_GetData("M004"))
                Return False
            End If
        Catch ex As Exception
            MsgBox(p_clsMsgData.fn_GetData("M004"))
            Return False
        End Try
        Return True
    End Function

    Private Sub checkVersion()
        Try
            Dim dtTableVersion As DataTable = _clsQuery.SelectSeverVersion()
            If dtTableVersion IsNot Nothing Then
                Dim ClientVersion As String = Application.ProductVersion
                Dim ServerVersion As String = dtTableVersion.Rows(0).Item("VERSION")
                If ClientVersion <> ServerVersion Then
                    If MsgBox(p_clsMsgData.fn_GetData("M065", "Server : v" + ServerVersion + "\nClient : v" + ClientVersion), _
                              Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                        RunDownloader()
                    End If
                    dtTableVersion.Dispose()
                End If
            Else
                MsgBox(p_clsMsgData.fn_GetData("M065"))
                dtTableVersion.Dispose()
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Function getUserPermission() As Boolean
        Return p_cSession.loadUserPermission(_clsQuery)
    End Function

    Public Function ConvertCIDRToMask(cidr As Integer) As String
        Dim ip As Int64 = Convert.ToInt64(New String("1"c, cidr).PadRight(32, "0"c), 2)
        Return (String.Join(".", New Net.IPAddress(ip).GetAddressBytes.Reverse))
    End Function

    Private Function checkAllowIP(ByVal IPAddr1 As String, ByVal IPAddr2 As String, ByVal NetMask As String) As Boolean
        Dim ie As IPAddressExtensions = New IPAddressExtensions
        Dim ip1 As IPAddress = IPAddress.Parse(IPAddr1)
        Dim ip2 = IPAddress.Parse(IPAddr2)
        Dim mask = IPAddress.Parse(NetMask)
        Return ie.IsInSameSubnet(ip1, ip2, mask)
    End Function

    Private Function DoLogin() As Boolean
        Try
            Dim _crypt As New eXperDB.Common.ClsCrypt
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            '''''''''''''''' check login fail count''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim dtTable As DataTable = _clsQuery.CheckLoginFailCount(strLocIP)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                Dim afterSeconds As Integer = Integer.Parse(dtTable.Rows(0).Item("TIMEOUT").ToString())
                If afterSeconds > 0 Then
                    MsgBox(p_clsMsgData.fn_GetData("M083", afterSeconds))
                    Return False
                End If
            End If
            '''''''''''''''' check login           ''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim strPw = _crypt.EncryptStringSHA256(txtPassword.Text)
            dtTable = _clsQuery.CheckLogin(txtUserID.Text, strPw)
            If dtTable Is Nothing OrElse dtTable.Rows.Count = 0 Then
                _clsQuery.SetLoginFail(strLocIP)
                MsgBox(p_clsMsgData.fn_GetData("M077"))
                Return False
            Else
                If dtTable.Rows(0).Item("MATCHED").ToString() <> "1" Then
                    MsgBox(p_clsMsgData.fn_GetData("M077"))
                    AccessLog("login", 1, "Wrong password")
                    Return False
                End If
            End If

            Dim isLock As Boolean = Integer.Parse(dtTable.Rows(0).Item("IS_LOCKED_TF").ToString())
            Dim isAdmin As Boolean = dtTable.Rows(0).Item("IS_ADMIN_TF")
            Dim isExpired As Boolean = dtTable.Rows(0).Item("ISEXPIRED")
            Dim isExpiredNear As Boolean = dtTable.Rows(0).Item("ISEXPIREDNEAR")
            Dim UntilExpireDays As Integer = Integer.Parse(dtTable.Rows(0).Item("UntilExpireDays").ToString())

            _clsQuery.ClearLoginFail(strLocIP)
            '''''''''''''''' check lock           '''''''''''''''''''''''''''''''''''''''''''''''''''''
            If isLock = True Then
                MsgBox(p_clsMsgData.fn_GetData("M084"))
                AccessLog("login", 1, "Account Locked")
                Return False
            End If

            '''''''''''''''' check allow ip       '''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim bAllowIP As Boolean = False
            dtTable = _clsQuery.CheckAllowIP(txtUserID.Text)
            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                For Each tmpDtRow As DataRow In dtTable.Rows
                    Dim strIPArr As String() = tmpDtRow.Item("ALLOW_IP").ToString().Split(New Char() {"/"c})
                    Dim strIP As String = strIPArr(0)
                    Dim strSubnetMask As String = ConvertCIDRToMask(strIPArr(1))
                    If checkAllowIP(strLocIP, strIP, strSubnetMask) = True Then
                        bAllowIP = True
                        Exit For
                    End If
                Next
                If bAllowIP = False Then
                    MsgBox(p_clsMsgData.fn_GetData("M086"))
                    AccessLog("login", 1, "Account Locked")
                    Return False
                End If
            End If

            Dim loginDt As DateTime = Now()
            p_cSession = New clsSession(txtUserID.Text, strPw, isAdmin, loginDt)

            AccessLog("login", 0)
            '''''''''''''''' check expiration pw  '''''''''''''''''''''''''''''''''''''''''''''''''''''
            If isExpired Then
                Dim frmPassword As New frmUserPassword(_clsQuery, False)
                If frmPassword.ShowDialog <> Windows.Forms.DialogResult.OK Then
                    Return False
                End If
            End If

            '''''''''''''''' check expiration pw near '''''''''''''''''''''''''''''''''''''''''''''''''
            If isExpiredNear Then
                MsgBox(p_clsMsgData.fn_GetData("M085", UntilExpireDays))
            End If


            If _clsQuery.DoLogin(txtUserID.Text, loginDt, strLocIP) < 0 Then
                _clsQuery.SetLoginFail(strLocIP)
                MsgBox(p_clsMsgData.fn_GetData("M078"))
                Return False
            End If

            If getUserPermission() = False Then
                MsgBox(p_clsMsgData.fn_GetData("M078"))
                Return False
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        Return True
    End Function

    Private Function fn_ChkTestBef() As Boolean
        'check empty
        If txtServerIP.Text.Length = 0 Or txtServerIP.Text = "Server Information" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F006")))
            Return False
        End If
        If txtUserID.Text = "" Or txtUserID.Text = "User ID" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F008")))
            txtUserID.Focus()
            Return False
        End If
        If txtPassword.Text = "" Or txtPassword.Text = "Password" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F009")))
            txtPassword.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub RunDownloader()
        Dim proc As Process = Nothing
        Try
            Dim registryKey As RegistryKey = Nothing
            registryKey = registryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry32)
            'registryKey = registryKey.OpenSubKey(HKLMPATH, True)
            registryKey = registryKey.OpenSubKey(HKLMPATH, False)
            If registryKey IsNot Nothing Then
                Dim installPath = CStr(My.Computer.Registry.GetValue(REGISTRYPATH, "InstallPath", Nothing) + "\" + APPNAME)
                proc = Process.Start(installPath)
                Threading.Thread.Sleep(500)
            End If
            'Dim installPath = "D:\01.Project\K4M\DX-Monitoring\eXper-Monitoring\experdbmon_for_github\eXperDB_Monitoring_Client\iDast.MonPostgres\bin\Debug\eXperDB.Downloader.exe"
            Me.Close()
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
#End Region

End Class
