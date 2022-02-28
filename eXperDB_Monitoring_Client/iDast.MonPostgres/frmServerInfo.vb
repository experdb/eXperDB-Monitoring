
Public Class frmServerInfo
    Private _crypt As New eXperDB.Common.ClsCrypt
    Private _clsQuery As clsQuerys
    Private _tmpStruct As eXperDB.ODBC.structConnection
    Private _strDefaultServerIP As String = ""

    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = New clsQuerys(odbcConn)
        initform()
    End Sub
    Public Sub New(ByRef odbcConn As eXperDBODBC, ByVal strRepoIP As String)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = New clsQuerys(odbcConn)
        _strDefaultServerIP = strRepoIP
        initform()
    End Sub

    Private Sub initform()
        StatusLabel.Text = p_clsMsgData.fn_GetData("M112")
        lblSvrIP.Text = p_clsMsgData.fn_GetData("F977")
        lblSvrPort.Text = p_clsMsgData.fn_GetData("F978")

        btnAct.Text = p_clsMsgData.fn_GetData("F141")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnApplyIP.Text = p_clsMsgData.fn_GetData("F367")

        txtSvrIP.Text = _tmpStruct.HostIP
        txtSvrPort.Text = _tmpStruct.Port
    End Sub

    Private Sub frmServerInfo_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim dtTable As DataTable = _clsQuery.SelectConfig
        If dtTable IsNot Nothing Then
            Dim strIp As String = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_IP")), "", dtTable.Rows(0).Item("AGENT_IP"))
            Dim intPort As Integer = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_PORT")), 0, dtTable.Rows(0).Item("AGENT_PORT"))
            If strIp = "" Or intPort = 0 Then
                MsgBox(p_clsMsgData.fn_GetData("M016"))
                Return
            End If
            'Dim aaa = _tmpStruct.HostIP
            txtSvrIP.Text = strIp
            txtSvrPort.Text = intPort
        Else
            MsgBox(p_clsMsgData.fn_GetData("M016"))
            Return
        End If
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP

        If txtSvrIP.Text.Trim = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Server IP"))
            Return
        End If
        If txtSvrPort.Text.Trim = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Server Port"))
            Return
        End If
        _clsQuery.UpdateServerConnInfo(strLocIP, txtSvrIP.Text, txtSvrPort.Text)
        MsgBox(p_clsMsgData.fn_GetData("M113"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSvrIP_TextChanged(sender As Object, e As EventArgs) Handles txtSvrIP.TextChanged, txtSvrPort.TextChanged

    End Sub

#Region "Internal functions"
    Private Function fn_ChkTestBef() As Boolean
        'check empty
        If txtSvrIP.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F006")))
            txtSvrIP.Focus()
            Return False
        End If

        If txtSvrPort.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F007")))
            txtSvrPort.Focus()
            Return False
        End If

        Dim intPort As Integer = txtSvrPort.Text
        If intPort < 1 Or intPort > 65535 Then
            MsgBox(p_clsMsgData.fn_GetData("M109"))
            txtSvrPort.Focus()
            Return False
        End If
        Return True
    End Function

#End Region

    Private Sub btnApplyIP_Click(sender As Object, e As EventArgs) Handles btnApplyIP.Click
        _tmpStruct = modCommon.AgentInfoRead()
        txtSvrIP.Text = _tmpStruct.HostIP
    End Sub
End Class