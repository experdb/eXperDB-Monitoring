
Public Class frmRepositoryInfo
    Private _crypt As New eXperDB.Common.ClsCrypt
    Private _clsQuery As clsQuerys
    Private _tmpStruct As eXperDB.ODBC.structConnection

    Public Sub New(ByRef tmpStruct As eXperDB.ODBC.structConnection)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _tmpStruct = tmpStruct
        initform()
    End Sub

    Private Sub initform()
        StatusLabel.Text = p_clsMsgData.fn_GetData("M050")
        lblSvrIP.Text = p_clsMsgData.fn_GetData("F006")
        lblSvrUsr.Text = p_clsMsgData.fn_GetData("F008")
        lblSvrDBNm.Text = p_clsMsgData.fn_GetData("F010")
        lblSvrPort.Text = p_clsMsgData.fn_GetData("F007")
        lblSvrPwd.Text = p_clsMsgData.fn_GetData("F009")

        btnTest.Text = p_clsMsgData.fn_GetData("F002")
        btnAct.Text = p_clsMsgData.fn_GetData("F003")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        txtSvrIP.Text = _tmpStruct.HostIP
        txtSvrPwd.Text = _tmpStruct.Password
        txtSvrUsr.Text = _tmpStruct.UserID
        txtSvrPort.Text = _tmpStruct.Port
        txtSvrDBNm.Text = _tmpStruct.DBName
    End Sub

    Public Sub rtnValue(ByRef tmpStruct As eXperDB.ODBC.structConnection)
        tmpStruct = _tmpStruct
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        If fn_ChkTestBef() = False Then Return
        Dim strIp As String = txtSvrIP.Text
        Dim strPort As Integer = txtSvrPort.Text
        Dim strID As String = txtSvrUsr.Text
        Dim strPw As String = txtSvrPwd.Text
        Dim DBName As String = txtSvrDBNm.Text
        Try
            Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
            Dim tmpCn As New eXperDBODBC(dbType, strIp, strPort, strID, strPw, DBName)
            If tmpCn.ConnectionCheck = True Then
                'MsgBox(p_clsMsgData.fn_GetData("M003"))
                _clsQuery = New clsQuerys(tmpCn)

                If tmpCn IsNot Nothing AndAlso tmpCn.GetType Is GetType(eXperDB.ODBC.eXperDBODBC) Then
                    modCommon.AgentInfoWrite(DirectCast(tmpCn, eXperDB.ODBC.eXperDBODBC).ODBCConninfo)
                    _tmpStruct = modCommon.AgentInfoRead()
                Else
                    MsgBox(p_clsMsgData.fn_GetData("M022"))
                End If
                MsgBox(p_clsMsgData.fn_GetData("M003"))
                sb_Ctlenabled(True)
            Else
                MsgBox(p_clsMsgData.fn_GetData("M004"))
                sb_Ctlenabled(False)
                Return
            End If
        Catch ex As Exception
            MsgBox(p_clsMsgData.fn_GetData("M004"))
        End Try
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmRepositoryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtSvrIP_TextChanged(sender As Object, e As EventArgs) Handles txtSvrIP.TextChanged, txtSvrUsr.TextChanged, txtSvrPort.TextChanged, txtSvrDBNm.TextChanged
        sb_Ctlenabled(False)
    End Sub

#Region "Internal functions"
    Private Function fn_ChkTestBef() As Boolean
        'check empty
        If txtSvrIP.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F006")))
            txtSvrIP.Focus()
            Return False
        End If

        'If Common.ClsObjectCtl.fn_CheckIPAddress(txtSvrIP.Text) = False Then
        '    MsgBox(p_clsMsgData.fn_GetData("M002"))
        '    txtSvrIP.Focus()
        '    Return False
        'End If

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

        If txtSvrDBNm.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F010")))
            txtSvrDBNm.Focus()
            Return False
        End If
        If txtSvrUsr.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F008")))
            txtSvrUsr.Focus()
            Return False
        End If
        If txtSvrPwd.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M036"), p_clsMsgData.fn_GetData("F009"))
            txtSvrPwd.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function fn_GetSerial() As String
        Dim strKey As String
        Try
            Dim dtTable As DataTable = _clsQuery.SelectSerialKey()
            If dtTable IsNot Nothing Then
                Dim dtRow As DataRow = dtTable.Rows(0)
                strKey = dtRow.Item("LICDATA")
                If strKey.Length < 24 Then
                    Return ""
                End If
                Return strKey
            End If
            Return ""
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return ""
        End Try
    End Function

    Private Sub sb_Ctlenabled(ByVal Bret As Boolean)
        btnAct.Enabled = Bret
    End Sub


#End Region

End Class