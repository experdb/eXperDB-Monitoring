
Public Class frmNotiConfig
    Private _crypt As New eXperDB.Common.ClsCrypt
    Private _isChangedPW As Integer = 0
    Private _OldPWValue As String = ""
    Private _strAgentIP As String = ""
    Private _intAgentPort As Integer = 0

    Private _clsQuery As clsQuerys

    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SvrpList As List(Of GroupInfo.ServerInfo)
        Get
            Return _SvrpList
        End Get
    End Property

    Public Sub New(ByVal svrLst As List(Of GroupInfo.ServerInfo))

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblUser.Text = p_clsMsgData.fn_GetData("F008")
        lblPW.Text = p_clsMsgData.fn_GetData("F009")
        lblPort.Text = p_clsMsgData.fn_GetData("F007")
        lblIP.Text = p_clsMsgData.fn_GetData("F006")
        lblDB.Text = p_clsMsgData.fn_GetData("F010")
        lblStatements.Text = p_clsMsgData.fn_GetData("F215")
        btnTest.Text = p_clsMsgData.fn_GetData("F002")
        btnAct.Text = p_clsMsgData.fn_GetData("F014")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnNotiHistory.Text = p_clsMsgData.fn_GetData("F353")
        StatusLabel.Text = p_clsMsgData.fn_GetData("M068")

        _SvrpList = svrLst

        Dim ts As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New eXperDBODBC(dbType, ts.HostIP, ts.Port, ts.UserID, ts.Password, ts.DBName)
        _clsQuery = New clsQuerys(tmpCn)
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If txtIP.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Server hostname/IP"))
            Return
        End If
        If txtPort.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Server port"))
            Return
        End If
        If txtDbnm.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Server database"))
            Return
        End If
        If txtUsr.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "User ID"))
            Return
        End If
        If txtPW.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "User password"))
            Return
        End If
        If txtStatements.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Statements"))
            Return
        End If

        If cmbDBMS.SelectedIndex < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F288")))
            cmbDBMS.Focus()
            Return
        End If

        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Dim strStatements = txtStatements.Text.Replace("'", "''")
        Dim nReturn As Integer = _clsQuery.insertAlertLinkConfig(cmbDBMS.SelectedIndex, txtIP.Text, txtPort.Text, txtDbnm.Text, txtUsr.Text, txtPW.Text, strStatements, txtSender.Text, strLocIP)
        If nReturn < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M029"))
        Else
            MsgBox(p_clsMsgData.fn_GetData("M028"))
        End If
        Me.Close()
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        If _OldPWValue.Length > 0 Then
            _isChangedPW = 1
        End If
        _OldPWValue = txtPW.Text
    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIP_LostFocus(sender As Object, e As EventArgs)
        btnAct.Enabled = False
        ' HA info 201804
        If txtUsr.Text.Trim <> "" _
            AndAlso txtPW.Text.Trim <> "" _
            AndAlso txtIP.Text.Trim <> "" _
            AndAlso txtPort.Text.Trim <> "" Then
        End If
    End Sub

    Private WithEvents AgentMsgDbInfo As clsAgentEMsg
    Private Sub AgentMsgDbInfo_Complete(sender As Object, e As Object) Handles AgentMsgDbInfo.Complete
        If e.GetType.Equals(GetType(clsAgentEMsg.DX004_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX004_REP = DirectCast(e, clsAgentEMsg.DX004_REP)
            If rtnValue IsNot Nothing Then
                If rtnValue.ERRORS Is Nothing AndAlso rtnValue.DATAS.Count > 0 Then
                    Me.Invoke(New MethodInvoker(Sub()
                                                    For Each tmpLst As clsAgentEMsg.DBLIST In rtnValue.DATAS
                                                        'cmbDbnm.Items.Add(tmpLst.DBName)
                                                    Next
                                                    'cmbDbnm.Tag = rtnValue.DATAS
                                                End Sub))


                End If

            End If
        End If
        If e.GetType.Equals(GetType(clsAgentEMsg.DX008_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX008_REP = DirectCast(e, clsAgentEMsg.DX008_REP)
            If rtnValue IsNot Nothing Then
                Me.Invoke(New MethodInvoker(Sub()
                                                If rtnValue.DATAS IsNot Nothing Then
                                                    'txtHAHost.Text = rtnValue.DATAS.HAHost
                                                    'txtHAREPLHost.Text = rtnValue.DATAS.HAHost
                                                    'txtHAPort.Text = rtnValue.DATAS.HAPort
                                                    'txtHAREPLHost.Visible = False
                                                    'lblHAREPLHost.Visible = False
                                                Else
                                                    'txtHAREPLHost.Visible = True
                                                    'lblHAREPLHost.Visible = True
                                                End If
                                            End Sub))

            End If
        End If
        AgentMsgDbInfo = Nothing
    End Sub


    Private WithEvents AgentMsgConnectCheck As clsAgentEMsg

    Private Sub AgentMsgConnectCheck_Complete(sender As Object, e As Object) Handles AgentMsgConnectCheck.Complete
        'If _frmW IsNot Nothing Then
        '    Me.Invoke(New MethodInvoker(Sub()
        '                                    _frmW.Close()
        '                                End Sub))
        'End If


        If e.GetType.Equals(GetType(clsAgentEMsg.DX003_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX003_REP = DirectCast(e, clsAgentEMsg.DX003_REP)

            If rtnValue._tran_res_data IsNot Nothing AndAlso rtnValue._tran_res_data(0)._error_cd Is Nothing Then
                Me.Invoke(New MethodInvoker(Sub()
                                                ' 추가 버튼을 활성화 
                                                ' 정보 컨트롤에서 입력 값을 변경 하였을 경우 TextChange Evevt에서 Disable을 처리한다.  
                                                btnAct.Enabled = True

                                                ' 접속 성공시 Tag에 정보를 추가한다. 
                                                Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
                                                'Dim tmpCn As New eXperDBODBC(dbType, txtIP.Text, CInt(txtPort.Text), txtUsr.Text, txtPW.Text, cmbDbnm.Text)
                                                'btnTest.Tag = tmpCn.ODBCConninfo

                                                '접속이 성공 하였을 경우 
                                                MsgBox(p_clsMsgData.fn_GetData("M003"))
                                            End Sub))

            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                ' 추가 버튼 컨트롤 비활성화 
                                                btnAct.Enabled = False
                                                ' 접속 정보Tag도 삭제한다. 
                                                btnTest.Tag = Nothing
                                                ' 접속 실패시 
                                                If rtnValue._tran_res_data(0)._error_cd.Equals("DX003_E03") = True Then
                                                    MsgBox(p_clsMsgData.fn_GetData("M004"))
                                                Else
                                                    MsgBox(p_clsMsgData.fn_GetData("M073"))
                                                End If

                                            End Sub))

                'Return

            End If
        ElseIf e.GetType.Equals(GetType(clsSocket.Results)) Then
            Me.Invoke(New MethodInvoker(Sub()
                                            ' 추가 버튼 컨트롤 비활성화 
                                            btnAct.Enabled = False
                                            ' 접속 정보Tag도 삭제한다. 
                                            btnTest.Tag = Nothing
                                            ' 접속 실패시 
                                            If DirectCast(e, clsSocket.Results).ErrorMsg = "" Then
                                                MsgBox("Fail to connect to Agent")
                                            Else
                                                MsgBox(DirectCast(e, clsSocket.Results).ErrorMsg)
                                            End If


                                        End Sub))
            'Return
        Else
            Me.Invoke(New MethodInvoker(Sub()
                                            ' 추가 버튼 컨트롤 비활성화 
                                            btnAct.Enabled = False
                                            ' 접속 정보Tag도 삭제한다. 
                                            btnTest.Tag = Nothing
                                            ' 접속 실패시 
                                            MsgBox("UnKnown Error")

                                        End Sub))
            'Return
        End If


        Me.Invoke(New MethodInvoker(Sub()
                                        tlpSvrChk.Enabled = True
                                    End Sub))
    End Sub


    Private Sub frmNotiConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim dt As DataTable = _clsQuery.SelectAlertLinkConfig()
            Dim linkType As Integer = CInt(dt.Rows(0).Item("LINK_TYPE"))
            cmbDBMS.SelectedIndex = linkType
            txtIP.Text = dt.Rows(0).Item("LINK_IP")
            txtPort.Text = CInt(dt.Rows(0).Item("LINK_PORT"))
            txtDbnm.Text = dt.Rows(0).Item("LINK_DATABASE")
            txtUsr.Text = dt.Rows(0).Item("LINK_ID")
            txtPW.Text = dt.Rows(0).Item("LINK_PASSWORD")
            _OldPWValue = txtPW.Text
            txtStatements.Text = dt.Rows(0).Item("LINK_STATEMENTS")
            txtSender.Text = dt.Rows(0).Item("NOTIFICATION_SENDER")
            btnAct.Enabled = False
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub cmbHARole_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As eXperDB.BaseControls.ComboBox = CType(sender, eXperDB.BaseControls.ComboBox)
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        ' 서버 정보 추가 테스트  사전 체크 
        If fn_ChkSvrTestBef() = False Then Return

        Dim strIp As String = txtIP.Text
        Dim strPort As Integer = txtPort.Text
        Dim strID As String = txtUsr.Text
        Dim strPw As String
        Dim strKey As String = ""

        Try
            Dim dtConfig As DataTable = _clsQuery.SelectConfig
            _strAgentIP = IIf(IsDBNull(dtConfig.Rows(0).Item("AGENT_IP")), "", dtConfig.Rows(0).Item("AGENT_IP"))
            _intAgentPort = IIf(IsDBNull(dtConfig.Rows(0).Item("AGENT_PORT")), 0, dtConfig.Rows(0).Item("AGENT_PORT"))
            Dim dtTable As DataTable = _clsQuery.SelectSerialKey
            If dtTable IsNot Nothing Then
                Dim dtRow As DataRow = dtTable.Rows(0)
                strKey = dtRow.Item("LICDATA")
            Else : Return
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try

        If _isChangedPW = 1 Then
            _crypt.TDESImplementation(strKey.Substring(0, 24), strKey.Substring(0, 8))
            strPw = _crypt.EncryptTDES(txtPW.Text)
            txtPW.Text = strPw
        Else
            strPw = txtPW.Text
        End If
        _isChangedPW = 0
        Dim DBName As String = txtDbnm.Text
        'If _frmW IsNot Nothing Then
        '    _frmW = New frmWait
        '    _frmW.TopMost = True
        '    _frmW.Show(Me)
        'End If

        tlpSvrChk.Enabled = False

        AgentMsgConnectCheck = New clsAgentEMsg(_strAgentIP, _intAgentPort)
        AgentMsgConnectCheck.SendDX003(strIp, strPort, strID, DBName, strPw, -2)
    End Sub

    ''' <summary>
    ''' 접속 테스트 위한 체크 메서드
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fn_ChkSvrTestBef() As Boolean
        If txtIP.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "IP")
            MsgBox(strMsg)
            txtIP.Focus()
            Return False
        Else
            'If Common.ClsObjectCtl.fn_CheckIPAddress(txtIP.Text) = False Then
            '    Dim strMsg As String = p_clsMsgData.fn_GetData("M002")
            '    MsgBox(strMsg)
            '    txtIP.Focus()
            '    Return False
            'End If
        End If

        If txtPort.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "PORT")
            MsgBox(strMsg)
            txtPort.Focus()
            Return False

        End If

        If txtDbnm.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "Database Name")
            MsgBox(strMSg)
            txtDbnm.Focus()
            Return False
        End If

        If txtUsr.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "User")
            MsgBox(strMSg)
            txtUsr.Focus()
            Return False
        End If

        If txtPW.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "Password")
            MsgBox(strMsg)
            txtPW.Focus()
            Return False
        End If

        Return True

    End Function

    Private Sub btnNotiHistory_Click(sender As Object, e As EventArgs) Handles btnNotiHistory.Click
        Dim frmUM As New frmNotiHistory(_SvrpList)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If
    End Sub
End Class