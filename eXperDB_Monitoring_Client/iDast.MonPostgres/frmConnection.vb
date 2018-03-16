
Public Class frmConnection
    Private _idxROw As Integer
    Private _strAgentIP As String = ""
    Private _intAgentPort As Integer = 0
    Private _InstanceCnt As Integer = 0
    Private _isChangedPW As Integer = 0
    Private _strSerial As String = ""
    Private _OldPWValue As String = ""
    Private _crypt As New eXperDB.Common.ClsCrypt
    Public Sub New(ByVal strAgentIp As String, ByVal intAgentPort As Integer, ByVal idxRow As Integer, ByVal strUser As String, ByVal strPw As String, ByVal strIP As String, ByVal intPort As Integer, ByVal DBNm As String, ByVal strSchema As String, ByVal intCollectSec As Integer, ByVal strAliasNm As String, ByVal InstanceCnt As Integer, ByVal strSerial As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _strSerial = strSerial
        _crypt = New eXperDB.Common.ClsCrypt

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _strAgentIP = strAgentIp
        _intAgentPort = intAgentPort
        _InstanceCnt = InstanceCnt


        lblSvrGatSDly.Text = p_clsMsgData.fn_GetData("F011")
        lblUser.Text = p_clsMsgData.fn_GetData("F008")
        lblPW.Text = p_clsMsgData.fn_GetData("F009")
        lblPort.Text = p_clsMsgData.fn_GetData("F007")
        lblIP.Text = p_clsMsgData.fn_GetData("F006")
        lblDB.Text = p_clsMsgData.fn_GetData("F010")
        lblSchema.Text = p_clsMsgData.fn_GetData("F074")
        lblAlias.Text = p_clsMsgData.fn_GetData("F019")
        btnTest.Text = p_clsMsgData.fn_GetData("F002")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")


        txtUsr.Text = strUser
        txtPW.Text = strPw
        txtIP.Text = strIP
        txtPort.Text = intPort
        txtIP_LostFocus(txtIP, Nothing)
        cmbDbnm.Text = DBNm
        cmbSchema.Text = strSchema
        nudCollectSecond.Value = intCollectSec
        txtAlias.Text = strAliasNm
        'nudLogSaveDly.Value = DirectCast(sender, BaseControls.DataGridView).Item(colLogSave.Index, e.RowIndex).Value
        _idxROw = idxRow
        If idxRow >= 0 Then
            btnAct.Text = p_clsMsgData.fn_GetData("F141")
            StatusLabel.Text = "DBMS 정보를 수정합니다."
        Else
            btnAct.Text = p_clsMsgData.fn_GetData("F140")
            StatusLabel.Text = "DBMS 정보를 새롭게 등록합니다."
        End If
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
            If Common.ClsObjectCtl.fn_CheckIPAddress(txtIP.Text) = False Then
                Dim strMsg As String = p_clsMsgData.fn_GetData("M002")
                MsgBox(strMsg)
                txtIP.Focus()
                Return False
            End If
        End If


        If txtPort.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "PORT")
            MsgBox(strMsg)
            txtPort.Focus()
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

        If cmbDbnm.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "Database Name")
            MsgBox(strMSg)
            cmbDbnm.Focus()
            Return False
        End If


        If cmbSchema.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "Schema")
            MsgBox(strMSg)
            cmbSchema.Focus()
            Return False
        End If

        Return True

    End Function


    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        ' 서버 정보 추가 테스트  사전 체크 
        If fn_ChkSvrTestBef() = False Then Return

        Dim strIp As String = txtIP.Text
        Dim strPort As Integer = txtPort.Text
        Dim strID As String = txtUsr.Text
        Dim strPw As String
        If _isChangedPW = 1 Then
            _crypt.TDESImplementation(_strSerial.Substring(0, 24), _strSerial.Substring(0, 8))
            strPw = _crypt.EncryptTDES(txtPW.Text)
            txtPW.Text = strPw
        Else
            strPw = txtPW.Text
        End If
        _isChangedPW = 0
        Dim DBName As String = cmbDbnm.Text
        'If _frmW IsNot Nothing Then
        '    _frmW = New frmWait
        '    _frmW.TopMost = True
        '    _frmW.Show(Me)
        'End If

        tlpSvrChk.Enabled = False

        AgentMsgConnectCheck = New clsAgentEMsg(_strAgentIP, _intAgentPort)
        AgentMsgConnectCheck.SendDX003(strIp, strPort, strID, DBName, strPw, _InstanceCnt)


        'Dim tmpCn As New DXODBC( dbtype, strIp, strPort, strID, strPw, DBName)


        'If tmpCn.ConnectionCheck = True Then
        '    '접속이 성공 하였을 경우 
        '    MsgBox(p_clsMsgData.fn_GetData("M003"))
        '    ' 추가 버튼을 활성화 
        '    ' 정보 컨트롤에서 입력 값을 변경 하였을 경우 TextChange Evevt에서 Disable을 처리한다.  
        '    btnAct.Enabled = True
        '    ' 접속 성공시 Tag에 정보를 추가한다. 
        '    btnTest.Tag = tmpCn.ODBCConninfo
        'Else
        '    ' 접속 실패시 
        '    MsgBox(p_clsMsgData.fn_GetData("M004"))
        '    ' 추가 버튼 컨트롤 비활성화 
        '    btnAct.Enabled = False
        '    ' 접속 정보Tag도 삭제한다. 
        '    btnTest.Tag = Nothing
        '    Return
        'End If
    End Sub

    ''' <summary>
    ''' 서버 목록 추가 버튼 클릭시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()


    End Sub


    Private Sub cmbDbnm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDbnm.SelectedIndexChanged
        Dim strBef As String = cmbSchema.Text
        btnAct.Enabled = False
        cmbSchema.Items.Clear()
        If txtUsr.Text.Trim <> "" _
            AndAlso txtPW.Text.Trim <> "" _
            AndAlso txtIP.Text.Trim <> "" _
            AndAlso txtPort.Text.Trim <> "" _
            AndAlso cmbDbnm.Text <> "" Then


            ' ================== 예전에 프로그램에서 서버로 Direct 접속하는것 시작
            ' POSTGRES DATABASE는 권한이 없어도 접속이 가능함.  대소문자 구분을 하므로 주의할 것 
            'Dim tmpCn As New ODBC.DXODBC( dbtype, txtIP.Text, CInt(txtPort.Text), txtUsr.Text, txtPW.Text, cmbDbnm.Text)
            'If tmpCn.ConnectionCheck = True Then
            '    Dim tmpCls As New clsQuerys(tmpCn)
            '    Dim dtTable As DataTable = tmpCls.GetSchemaLIst
            '    If dtTable IsNot Nothing Then
            '        For Each tmpRow As DataRow In dtTable.Rows
            '            cmbSchema.Items.Add(tmpRow.Item(0))
            '        Next
            '    End If
            '    cmbSchema.Text = strBef
            'End If
            ' ================== 예전에 프로그램에서 서버로 Direct 접속하는것 종료 

            If cmbDbnm.Tag.GetType().Equals(GetType(List(Of clsAgentEMsg.DBLIST))) Then
                Dim dbLsts As List(Of clsAgentEMsg.DBLIST) = DirectCast(cmbDbnm.Tag, List(Of clsAgentEMsg.DBLIST))
                'dbLsts.Select(Function(e As clsAgentEMsg.DBLIST) e.DBName = cmbDbnm.Text)
                Dim scheLst = dbLsts.Where(Function(r) r.DBName = cmbDbnm.Text).Select(Function(rr) rr.Schema)
                For Each tmpStr As String In scheLst(0)
                    cmbSchema.Items.Add(tmpStr)
                Next

            End If

        End If


    End Sub





    Public Sub rtnValue(ByRef intRow As Integer, ByRef ODBCConnect As structConnection, ByRef StrSchema As String, ByRef intCollect As Integer, ByRef strAliasNm As String)
        intRow = _idxROw
        ODBCConnect = btnTest.Tag

        StrSchema = cmbSchema.Text
        intCollect = nudCollectSecond.Value

        strAliasNm = txtAlias.Text
    End Sub


    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If txtAlias.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Alias Name"))
            Return
        End If


        ' 접속 테스트 정보가 존재할 경우 
        If btnTest.Tag IsNot Nothing AndAlso btnTest.Tag.GetType Is GetType(eXperDB.ODBC.structConnection) Then

            Me.DialogResult = Windows.Forms.DialogResult.OK

            '' 기존에 데이터가 있을 경우 
            '' 서버 목록에 있는 대상을 선택 하였을 경우 BtnAdd에 해당 Row의 값을 넣어 둔다. 
            'If btnClose.Tag IsNot Nothing Then
            '    Dim tmpStruct As ODBC.structConnection = DirectCast(btnTest.Tag, ODBC.structConnection)
            '    Dim tmpRow As DataGridViewRow = btnClose.Tag

            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colCollectYN.Index, "Y")
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colAliasNm.Index, tmpStruct.DBName)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colDBNm.Index, tmpStruct.DBName)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colIP.Index, tmpStruct.HostIP)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colUser.Index, tmpStruct.UserID)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colPort.Index, tmpStruct.Port)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colPW.Index, tmpStruct.Password)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colSchema.Index, cmbSchema.Text)
            '    dgvSvrLst.fn_DataCellADD(tmpRow.Index, colCollectSecond.Index, nudCollectSecond.Value)
            '    'dgvSvrLst.fn_DataCellADD(tmpRow.Index, colLogSave.Index, nudLogSaveDly.Value)

            'Else
            '    ' 기존 데이터가 없고 완전 신규일경우 
            '    ' 신규이나 기존에 서버가 있을 경우 

            '    Dim tmpStruct As ODBC.structConnection = DirectCast(btnTest.Tag, ODBC.structConnection)
            '    Dim tmpIpRow As DataGridViewRow = dgvSvrLst.FindFirstRow(tmpStruct.HostIP, colIP.Index, True)
            '    Dim tmpPortRow As DataGridViewRow = dgvSvrLst.FindFirstRow(tmpStruct.Port, colPort.Index, True)

            '    If (tmpIpRow Is Nothing AndAlso tmpPortRow Is Nothing) OrElse tmpIpRow.Equals(tmpPortRow) = False Then

            '        Dim idxRow As Integer = dgvSvrLst.Rows.Add()
            '        dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "Y")
            '        dgvSvrLst.fn_DataCellADD(idxRow, colAliasNm.Index, tmpStruct.DBName)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colDBNm.Index, tmpStruct.DBName)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colIP.Index, tmpStruct.HostIP)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colUser.Index, tmpStruct.UserID)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colPort.Index, tmpStruct.Port)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colPW.Index, tmpStruct.Password)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colSchema.Index, cmbSchema.Text)
            '        dgvSvrLst.fn_DataCellADD(idxRow, colCollectSecond.Index, nudCollectSecond.Value)
            '        'dgvSvrLst.fn_DataCellADD(idxRow, colLogSave.Index, nudLogSaveDly.Value)
            '        ' 신규 삽입된 코드의 경우 -1로 처리하여 신규 추기인지 확인한다. 
            '        ' 기존에 있던 데이터들은 Row Tag 가 Instance ID로 되어있음. 
            '        dgvSvrLst.Rows(idxRow).Tag = -1
            '        ' 삽입 후 컨트롤 초기화 한다. 
            '        txtUsr.Text = ""
            '        txtPW.Text = ""
            '        txtIP.Text = ""
            '        txtPort.Text = ""
            '        cmbDbnm.Items.Clear()
            '        cmbDbnm.Text = ""
            '        cmbSchema.Items.Clear()
            '        cmbSchema.Text = ""

            '    Else
            '        Dim strMsg As String = p_clsMsgData.fn_GetData("M011")
            '        MsgBox(strMsg)
            '    End If

            'End If








        End If
    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged
        If _OldPWValue.Length > 0 Then
            _isChangedPW = 1
        End If
        _OldPWValue = txtPW.Text
    End Sub

    Private Sub txtUsr_TextChanged(sender As Object, e As EventArgs) Handles txtUsr.TextChanged

    End Sub

    Private Sub txtIP_LostFocus(sender As Object, e As EventArgs) Handles txtIP.LostFocus, txtPW.LostFocus, txtUsr.LostFocus, txtPort.LostFocus
        Dim strBef As String = cmbDbnm.Text
        cmbDbnm.Items.Clear()
        btnAct.Enabled = False
        If txtUsr.Text.Trim <> "" _
            AndAlso txtPW.Text.Trim <> "" _
            AndAlso txtIP.Text.Trim <> "" _
            AndAlso txtPort.Text.Trim <> "" Then


            ' ================== 예전에 프로그램에서 서버로 Direct 접속하는것 시작
            ' POSTGRES DATABASE는 권한이 없어도 접속이 가능함.  대소문자 구분을 하므로 주의할 것 
            'Dim tmpCn As New ODBC.DXODBC( dbtype, txtIP.Text, CInt(txtPort.Text), txtUsr.Text, txtPW.Text, "postgres")
            'If tmpCn.ConnectionCheck = True Then
            '    Dim tmpCls As New clsQuerys(tmpCn)
            '    Dim dtTable As DataTable = tmpCls.GetDatabaseLIst
            '    If dtTable IsNot Nothing Then
            '        For Each tmpStr As DataRow In dtTable.Rows
            '            cmbDbnm.Items.Add(tmpStr.Item(0))
            '        Next
            '    End If
            '    strBef = cmbDbnm.Text
            'End If
            ' ================== 예전에 프로그램에서 서버로 Direct 접속하는것 종료 

            If AgentMsgDbInfo Is Nothing Then
                AgentMsgDbInfo = New clsAgentEMsg(_strAgentIP, _intAgentPort, 3000, 3000)
                AgentMsgDbInfo.SendDX004(txtIP.Text, txtPort.Text, txtUsr.Text, txtPW.Text)
            End If

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
                                                        cmbDbnm.Items.Add(tmpLst.DBName)
                                                    Next
                                                    cmbDbnm.Tag = rtnValue.DATAS
                                                End Sub))


                End If

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
                                                Dim dbType As DXODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicode)
                                                Dim tmpCn As New DXODBC(dbType, txtIP.Text, CInt(txtPort.Text), txtUsr.Text, txtPW.Text, cmbDbnm.Text)
                                                btnTest.Tag = tmpCn.ODBCConninfo

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
                                                MsgBox(rtnValue._tran_res_data(0)._error_msg)

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

    'Private WithEvents _frmW As frmWait

    'Private Sub _frmW_Shown(sender As Object, e As EventArgs) Handles _frmW.Shown

    'End Sub
    'Private Sub _frmW_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _frmW.FormClosed
    '    If AgentMsgConnectCheck IsNot Nothing Then
    '        AgentMsgConnectCheck.Cancel()
    '        AgentMsgConnectCheck = Nothing
    '    End If

    '    _frmW = Nothing
    '    tlpSvrChk.Enabled = True


    'End Sub



    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class