﻿Public Class frmAdmin


    Private _AgentIP As String
    Private _AgentPort As Integer
    Private _checkAgentInterval As Integer = 1000
    Private _startDt As String
    Private _applyCount As Integer = 0
    Private crypt As New eXperDB.Common.ClsCrypt

#Region "Form Initialize"


    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        initForm()

    End Sub

    Private Sub initForm()

        'Me.grpAgentSvr.Text = p_clsMsgData.fn_GetData("F001")
        'btnConTest.Text = p_clsMsgData.fn_GetData("F002")
        'btnConSave.Text = p_clsMsgData.fn_GetData("F003")
        'lblSvrIP.Text = p_clsMsgData.fn_GetData("F006")
        'lblSvrPort.Text = p_clsMsgData.fn_GetData("F007")
        'lblSvrUsr.Text = p_clsMsgData.fn_GetData("F008")
        'lblSvrPwd.Text = p_clsMsgData.fn_GetData("F009")
        'lblSvrDBNm.Text = p_clsMsgData.fn_GetData("F010")

        lblLogSaveDly.Text = p_clsMsgData.fn_GetData("F012")
        lblSvrLst.Text = p_clsMsgData.fn_GetData("F013")
        lblBasicConfig.Text = p_clsMsgData.fn_GetData("F280")


        colCheck.HeaderText = p_clsMsgData.fn_GetData("F017")
        colCollectYN.HeaderText = p_clsMsgData.fn_GetData("F207")
        colDBNm.HeaderText = p_clsMsgData.fn_GetData("F010")
        colAliasNm.HeaderText = p_clsMsgData.fn_GetData("F019")
        colUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        colIP.HeaderText = p_clsMsgData.fn_GetData("F006")
        colPort.HeaderText = p_clsMsgData.fn_GetData("F007")
        colPW.HeaderText = p_clsMsgData.fn_GetData("F009")
        colLstIP.HeaderText = p_clsMsgData.fn_GetData("F020")
        colSchema.HeaderText = p_clsMsgData.fn_GetData("F074")
        colCollectSecond.HeaderText = p_clsMsgData.fn_GetData("F011")
        colStmtCollectSecond.HeaderText = p_clsMsgData.fn_GetData("F342")
        colSnapshotHour.HeaderText = p_clsMsgData.fn_GetData("F960", "(Min)")

        btnApply.Text = p_clsMsgData.fn_GetData("F014")
        btnDelete.Text = p_clsMsgData.fn_GetData("F015")

        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnAdminPW.Text = p_clsMsgData.fn_GetData("F279")

        sb_Ctlenabled(False)

        'Dim tmpStruct As ODBC.structConnection = modCommon.AgentInfoRead()


        'txtSvrIP.Text = tmpStruct.HostIP
        'txtSvrPwd.Text = tmpStruct.Password
        'txtSvrUsr.Text = tmpStruct.UserID
        'txtSvrPort.Text = tmpStruct.Port
        'txtSvrIP_LostFocus(txtSvrIP, Nothing)
        'cmbSvrDBNm.Text = tmpStruct.DBName
        modCommon.FontChange(Me, p_Font)


        btnCreate.Text = p_clsMsgData.fn_GetData("F140")
        btnModify.Text = p_clsMsgData.fn_GetData("F141")


        lblLogBatch.Text = p_clsMsgData.fn_GetData("F143")
        lblLogBatchH.Text = p_clsMsgData.fn_GetData("F144")
        lblLogBatchM.Text = p_clsMsgData.fn_GetData("F145")

        lblSnapshotTopN.Text = p_clsMsgData.fn_GetData("F957")
        lblSnapshotSaveDly.Text = p_clsMsgData.fn_GetData("F958")
        lblTReportSaveDly.Text = p_clsMsgData.fn_GetData("F974")


        For i As Integer = 0 To 23
            cmbLogBatchH.Items.Add(i)
        Next

        For i As Integer = 0 To 59
            cmbLogBatchM.Items.Add(i)
        Next


        Dim strValue As String = p_clsMsgData.fn_GetData("F192")
        Dim tmpArr As String() = strValue.Split(";")
        For Each tmpStr As String In tmpArr
            If tmpStr.Trim <> "" Then
                Dim subArr As String() = tmpStr.Split("|")
                Dim strDesc As String = subArr(0)
                Dim intSec As Integer = subArr(1)
                cmbHealthTime.AddValue(intSec, strDesc)
            End If

        Next

        strValue = p_clsMsgData.fn_GetData("F316")
        tmpArr = strValue.Split(";")
        For Each tmpStr As String In tmpArr
            If tmpStr.Trim <> "" Then
                Dim subArr As String() = tmpStr.Split("|")
                Dim strDesc As String = subArr(0)
                Dim intSec As Integer = subArr(1)
                cmbObjectTime.AddValue(intSec, strDesc)
            End If

        Next

        strValue = p_clsMsgData.fn_GetData("F328")
        tmpArr = strValue.Split(";")
        For Each tmpStr As String In tmpArr
            If tmpStr.Trim <> "" Then
                Dim subArr As String() = tmpStr.Split("|")
                Dim strDesc As String = subArr(0)
                Dim intSec As Integer = subArr(1)
                cmbStmtTime.AddValue(intSec, strDesc)
            End If

        Next

        strValue = p_clsMsgData.fn_GetData("F964")
        tmpArr = strValue.Split(";")
        For Each tmpStr As String In tmpArr
            If tmpStr.Trim <> "" Then
                Dim subArr As String() = tmpStr.Split("|")
                Dim strDesc As String = subArr(0)
                Dim intSec As Integer = subArr(1)
                cmbSnapshotTopN.AddValue(intSec, strDesc)
            End If

        Next

        lblHealthTime.Text = p_clsMsgData.fn_GetData("F200")
        lblObjectTime.Text = p_clsMsgData.fn_GetData("F315")
        lblStmtTime.Text = p_clsMsgData.fn_GetData("F327")

        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)



        If tmpCn.ConnectionCheck = True Then
            ' 하위의 Enable Diable 처리 
            sb_Ctlenabled(True)
            ' 현재 Agent 접속 정보를 저장한다. 
            ' 추후 Tag 값으로 Agent 서버의 등록 서버 정보를 관리한다. 
            ' 상단의 접속 테스트 정보를 변경하여도 테스트를 하지 않는한 계속 같은 정보를 바라본다. 
            lblSvrLst.Tag = tmpCn
            ' 접속 성공시 Agent 서버에서 기등록된 데이터를 불러온다. 
            ReadSvrList(tmpCn)
        Else
            lblSvrLst.Enabled = False
            sb_Ctlenabled(False)
            btnApply.Tag = Nothing

            ' 접속 실패시 
            MsgBox(p_clsMsgData.fn_GetData("M004"))
            Return
        End If
    End Sub





    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgLabel.Text = p_clsMsgData.fn_GetData("M053")

    End Sub


    Private Sub sb_Ctlenabled(ByVal Bret As Boolean)

        lblSvrLst.Enabled = Bret
        pnlB.Enabled = Bret

    End Sub

#End Region

#Region "Server List"
    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <param name="conODBC"></param>
    ''' <remarks></remarks>
    Private Sub ReadSvrList(ByVal conODBC As eXperDB.ODBC.eXperDBODBC)
        dgvSvrLst.Rows.Clear()

        If conODBC Is Nothing Then Return

        Dim ClsQuery As New clsQuerys(conODBC)
        Dim dtTable As DataTable = ClsQuery.SelectServerListAdmin()
        If dtTable IsNot Nothing Then
            For Each tmpRow As DataRow In dtTable.Rows
                Dim idxRow As Integer = dgvSvrLst.Rows.Add()
                ' Tag에는 Instance ID를 넣은다. 
                ' Add시에는 Instance ID = -1 
                ' Delete 시에는 Visible를 꺼서 삭제 목록을 가져온다. 
                dgvSvrLst.Rows(idxRow).Tag = tmpRow.Item("INSTANCE_ID")
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 

                dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, tmpRow.Item("COLLECT_YN"))
                dgvSvrLst.fn_DataCellADD(idxRow, colIP.Index, tmpRow.Item("SERVER_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPort.Index, tmpRow.Item("SERVICE_PORT"))
                dgvSvrLst.fn_DataCellADD(idxRow, colUser.Index, tmpRow.Item("CONN_USER_ID"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPW.Index, tmpRow.Item("CONN_USER_PWD"))
                dgvSvrLst.fn_DataCellADD(idxRow, colDBNm.Index, tmpRow.Item("CONN_DB_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colAliasNm.Index, tmpRow.Item("CONN_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colLstIP.Index, tmpRow.Item("LAST_MOD_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colSchema.Index, tmpRow.Item("CONN_SCHEMA_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colCollectSecond.Index, tmpRow.Item("COLLECT_PERIOD_SEC"))
                dgvSvrLst.fn_DataCellADD(idxRow, colStmtCollectSecond.Index, tmpRow.Item("RTSTMT_PERIOD_SEC"))
                dgvSvrLst.fn_DataCellADD(idxRow, colSnapshotHour.Index, Integer.Parse(tmpRow.Item("SNAP_PERIOD_MIN")))
                dgvSvrLst.fn_DataCellADD(idxRow, colPWCH.Index, 0)
                dgvSvrLst.fn_DataCellADD(idxRow, colHARole.Index, tmpRow.Item("HA_ROLE"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAHost.Index, tmpRow.Item("HA_HOST"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAPort.Index, tmpRow.Item("HA_PORT"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAREPLHost.Index, tmpRow.Item("HA_REPL_HOST"))
                dgvSvrLst.fn_DataCellADD(idxRow, colVirtualIP.Index, tmpRow.Item("VIRTUAL_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colVirtualIP2.Index, tmpRow.Item("VIRTUAL_IP2"))
                'dgvSvrLst.fn_DataCellADD(idxRow, colLogSave.Index, IIf(tmpRow.Item("LOG_KEEP_DAYS") < Me.nudLogSaveDly.Minimum, Me.nudLogSaveDly.Minimum, tmpRow.Item("LOG_KEEP_DAYS")))
            Next


        End If

        Dim dtConfig As DataTable = ClsQuery.SelectConfig
        Dim intLogDays As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("LOG_KEEP_DAYS")), 7, dtConfig.Rows(0).Item("LOG_KEEP_DAYS"))
        nudLogSaveDly.Value = IIf(intLogDays = -1, 7, intLogDays)
        nudLogSaveDly.Tag = intLogDays

        Dim intSnapDays As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("RETENTION")), 7, dtConfig.Rows(0).Item("RETENTION"))
        nudSnapshotSaveDly.Value = IIf(intSnapDays = -1, 7, intSnapDays)
        nudSnapshotSaveDly.Tag = intSnapDays

        Dim intTrendLogDays As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("TREPORT_KEEP_DAYS")), 7, dtConfig.Rows(0).Item("TREPORT_KEEP_DAYS"))
        nudTReportSaveDly.Value = IIf(intTrendLogDays = -1, 7, intTrendLogDays)
        nudTReportSaveDly.Tag = intTrendLogDays

        Dim strBatchTime As TimeSpan = IIf(IsDBNull(dtConfig.Rows(0).Item("DAILY_BATCH_START_TIME")), New TimeSpan(0, 0, 0), dtConfig.Rows(0).Item("DAILY_BATCH_START_TIME"))

        cmbLogBatchH.Text = strBatchTime.Hours '  CInt(strBatchTime.Substring(0, strBatchTime.IndexOf(":")))
        cmbLogBatchH.Tag = strBatchTime.Hours '  CInt(strBatchTime.Substring(0, strBatchTime.IndexOf(":")))
        cmbLogBatchM.Text = strBatchTime.Minutes     '  CInt(strBatchTime.Substring(strBatchTime.IndexOf(":") + 1))
        cmbLogBatchM.Tag = strBatchTime.Minutes ' CInt(strBatchTime.Substring(strBatchTime.IndexOf(":") + 1))

        ' Java Agent 정보  설정 
        _AgentIP = IIf(IsDBNull(dtConfig.Rows(0).Item("AGENT_IP")), "", dtConfig.Rows(0).Item("AGENT_IP"))
        _AgentPort = IIf(IsDBNull(dtConfig.Rows(0).Item("AGENT_PORT")), 0, dtConfig.Rows(0).Item("AGENT_PORT"))

        Dim intHchkPeriodSec As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("HCHK_PERIOD_SEC")), 3, dtConfig.Rows(0).Item("HCHK_PERIOD_SEC"))
        Dim intObjtPeriodSec As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("OBJT_PERIOD_SEC")), 3, dtConfig.Rows(0).Item("OBJT_PERIOD_SEC"))
        Dim intStmpPeriodSec As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("STMT_PERIOD_SEC")), 3, dtConfig.Rows(0).Item("STMT_PERIOD_SEC"))
        Dim intSnapTopN As Integer = IIf(IsDBNull(dtConfig.Rows(0).Item("TOPN")), 3, dtConfig.Rows(0).Item("TOPN"))

        cmbHealthTime.SelectedValue = intHchkPeriodSec
        cmbHealthTime.Tag = intHchkPeriodSec

        cmbObjectTime.SelectedValue = intObjtPeriodSec
        cmbObjectTime.Tag = intObjtPeriodSec

        cmbStmtTime.SelectedValue = intStmpPeriodSec
        cmbStmtTime.Tag = intStmpPeriodSec

        cmbSnapshotTopN.SelectedValue = intSnapTopN
        cmbSnapshotTopN.Tag = intSnapTopN

        If cmbHealthTime.SelectedIndex < 0 Then
            cmbHealthTime.SelectedIndex = 0
        End If

        If cmbObjectTime.SelectedIndex < 0 Then
            cmbObjectTime.SelectedIndex = 0
        End If

        If cmbStmtTime.SelectedIndex < 0 Then
            cmbStmtTime.SelectedIndex = 0
        End If

        If cmbSnapshotTopN.SelectedIndex < 0 Then
            cmbSnapshotTopN.SelectedIndex = 0
        End If

        If _AgentIP.Trim = "" Or _AgentPort = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M016"))
        End If

        Dim nCount As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Visible = True Then
                nCount += 1
            End If
        Next

        lblSvrLst.Text = p_clsMsgData.fn_GetData("F013") + " ( " + nCount.ToString + " ) "

    End Sub


#End Region


#Region "Agent Area"

#End Region

#Region "Svr Area"






#End Region



    ''' <summary>
    ''' 테스트 접속 후 데이터를 변경 하였을 경우  추가 버튼 Enabled을 비활성화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtIP_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

        End If

    End Sub

    Private Sub dgvSvrLst_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSvrLst.CellMouseDoubleClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            btnModify.Enabled = True
            btnModify.PerformClick()
        End If
    End Sub



    ''' <summary>
    ''' 서버 목록을 선택 하였을 경우 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvSvrLst_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvSvrLst.CellMouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            btnModify.Enabled = True
        End If
    End Sub


    Private Sub txtSvrPort_TextChanged(sender As Object, e As EventArgs)

    End Sub



    ''' <summary>
    ''' 적용 버튼을 클릭 하엿을 경우 해당 복록을 DB에 저장한다. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub AddData(ByVal intRow As Integer, ByVal structConn As structConnection, ByVal strSChema As String, ByVal intCollect As Integer, ByVal intStmtCollect As Integer, ByVal intReScanStmt As Integer, ByVal intSnapshotCollect As Integer, ByVal strAliasNm As String, ByRef strHARole As String, ByRef strHAHost As String, ByRef strHAPort As Integer, ByRef strHAREPLHost As String, ByRef strVirtualIP As String, ByRef strVirtualIP2 As String)



        ' 기존에 데이터가 있을 경우 
        ' 서버 목록에 있는 대상을 선택 하였을 경우 BtnAdd에 해당 Row의 값을 넣어 둔다. 
        If intRow >= 0 Then
            Dim tmpStruct As eXperDB.ODBC.structConnection = structConn
            Dim tmpRow As DataGridViewRow = dgvSvrLst.Rows(intRow)

            tmpRow.Cells(colCollectYN.Index).Value = "Y"
            tmpRow.Cells(colAliasNm.Index).Value = strAliasNm
            tmpRow.Cells(colDBNm.Index).Value = tmpStruct.DBName
            tmpRow.Cells(colIP.Index).Value = tmpStruct.HostIP
            tmpRow.Cells(colUser.Index).Value = tmpStruct.UserID
            tmpRow.Cells(colPort.Index).Value = tmpStruct.Port
            If Not tmpRow.Cells(colPW.Index).Value.Equals(tmpStruct.Password) Then
                tmpRow.Cells(colPWCH.Index).Value = 1
            End If
            tmpRow.Cells(colPW.Index).Value = tmpStruct.Password
            tmpRow.Cells(colSchema.Index).Value = strSChema
            tmpRow.Cells(colCollectSecond.Index).Value = intCollect
            tmpRow.Cells(colStmtCollectSecond.Index).Value = intStmtCollect
            tmpRow.Cells(colSnapshotHour.Index).Value = intSnapshotCollect
            tmpRow.Cells(colHARole.Index).Value = strHARole
            tmpRow.Cells(colHAHost.Index).Value = strHAHost
            tmpRow.Cells(colHAPort.Index).Value = CInt(strHAPort)
            tmpRow.Cells(colHAREPLHost.Index).Value = strHAREPLHost
            tmpRow.Cells(colVirtualIP.Index).Value = strVirtualIP
            tmpRow.Cells(colVirtualIP2.Index).Value = strVirtualIP2
            tmpRow.Cells(colReScanStmt.Index).Value = intReScanStmt

            'dgvSvrLst.fn_DataCellADD(tmpRow.Index, colLogSave.Index, nudLogSaveDly.Value)

        Else
            ' 기존 데이터가 없고 완전 신규일경우 
            ' 신규이나 기존에 서버가 있을 경우 

            Dim tmpStruct As eXperDB.ODBC.structConnection = structConn
            Dim tmpIpRow As DataGridViewRow = dgvSvrLst.FindFirstRow(tmpStruct.HostIP, colIP.Index, True)
            Dim tmpPortRow As DataGridViewRow = dgvSvrLst.FindFirstRow(tmpStruct.Port, colPort.Index, True)

            If (tmpIpRow Is Nothing Or tmpPortRow Is Nothing) OrElse tmpIpRow.Equals(tmpPortRow) = False Then

                Dim idxRow As Integer = dgvSvrLst.Rows.Add()
                dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "Y")
                dgvSvrLst.fn_DataCellADD(idxRow, colAliasNm.Index, strAliasNm)
                dgvSvrLst.fn_DataCellADD(idxRow, colDBNm.Index, tmpStruct.DBName)
                dgvSvrLst.fn_DataCellADD(idxRow, colIP.Index, tmpStruct.HostIP)
                dgvSvrLst.fn_DataCellADD(idxRow, colUser.Index, tmpStruct.UserID)
                dgvSvrLst.fn_DataCellADD(idxRow, colPort.Index, tmpStruct.Port)
                dgvSvrLst.fn_DataCellADD(idxRow, colPW.Index, tmpStruct.Password)
                dgvSvrLst.fn_DataCellADD(idxRow, colSchema.Index, strSChema)
                dgvSvrLst.fn_DataCellADD(idxRow, colCollectSecond.Index, intCollect)
                dgvSvrLst.fn_DataCellADD(idxRow, colStmtCollectSecond.Index, intStmtCollect)
                dgvSvrLst.fn_DataCellADD(idxRow, colSnapshotHour.Index, intSnapshotCollect)
                dgvSvrLst.fn_DataCellADD(idxRow, colPWCH.Index, 0)
                dgvSvrLst.fn_DataCellADD(idxRow, colHARole.Index, strHARole)
                dgvSvrLst.fn_DataCellADD(idxRow, colHAHost.Index, strHAHost)
                dgvSvrLst.fn_DataCellADD(idxRow, colHAPort.Index, CInt(strHAPort))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAREPLHost.Index, strHAREPLHost)
                dgvSvrLst.fn_DataCellADD(idxRow, colVirtualIP.Index, strVirtualIP)
                dgvSvrLst.fn_DataCellADD(idxRow, colVirtualIP2.Index, strVirtualIP2)
                dgvSvrLst.fn_DataCellADD(idxRow, colReScanStmt.Index, intReScanStmt)
                'dgvSvrLst.fn_DataCellADD(idxRow, colLogSave.Index, nudLogSaveDly.Value)
                ' 신규 삽입된 코드의 경우 -1로 처리하여 신규 추기인지 확인한다. 
                ' 기존에 있던 데이터들은 Row Tag 가 Instance ID로 되어있음. 
                dgvSvrLst.Rows(idxRow).Tag = -1


            Else
                Dim strMsg As String = p_clsMsgData.fn_GetData("M011")
                MsgBox(strMsg)
            End If

        End If





    End Sub

    Private WithEvents AgentMsg As clsAgentEMsg
    Private Sub AgentMsg_Complete(sender As Object, e As Object) Handles AgentMsg.Complete

    End Sub
    Private Function fn_ChkServer(ByVal conODBC As eXperDB.ODBC.eXperDBODBC) As String

        Dim clsQry As New clsQuerys(conODBC)
        Dim strStartDt As String = ""
        Dim dtTable As DataTable = clsQry.SelectServerDate()
        If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
            Dim dtRow As DataRow = dtTable.Rows(0)
            If dtRow.Item("DRIVER_STATUS") = True Then
                strStartDt = dtRow.Item("START_DT")
                Return strStartDt
            End If
        End If
        Return ""
    End Function
    Private Function fn_GetSerial() As String
        Dim strKey As String
        Try
            Dim odbcCon As eXperDB.ODBC.eXperDBODBC = TryCast(lblSvrLst.Tag, eXperDB.ODBC.eXperDBODBC)
            Dim ClsQuery As New clsQuerys(odbcCon)
            Dim dtTable As DataTable = ClsQuery.SelectSerialKey()
            If dtTable IsNot Nothing Then
                Dim dtRow As DataRow = dtTable.Rows(0)
                strKey = dtRow.Item("LICDATA")
                If strKey.Length < 24 Then
                    Return ""
                End If
                Return strKey
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return ""
        End Try
    End Function

#Region "Timer Thread "
    Private WithEvents tmCheckAgent As New Timer
    Private Sub tmCheckAgent_Tick(sender As Object, e As EventArgs) Handles tmCheckAgent.Tick
        tmCheckAgent.Stop()
        tmCheckAgent.Dispose()
        If _applyCount > 180 Then
            CircularProgressControl1.Stop()
            CircularProgressControl1.Visible = False
            _applyCount = 0
            MsgBox(p_clsMsgData.fn_GetData("M029"))
            Return
        End If
        Dim odbcCon As eXperDB.ODBC.eXperDBODBC = TryCast(lblSvrLst.Tag, eXperDB.ODBC.eXperDBODBC)
        If _startDt.CompareTo(fn_ChkServer(odbcCon)) < 0 Then
            CircularProgressControl1.Stop()
            CircularProgressControl1.Visible = False
            _applyCount = 0
            MsgBox(p_clsMsgData.fn_GetData("M028"))
        Else
            _applyCount += 1
            tmCheckAgent.Start()
        End If
    End Sub
#End Region



    Private Sub btnAdminPW_Click(sender As Object, e As EventArgs) Handles btnAdminPW.Click
        Dim strkey = fn_GetSerial()
        Dim frmUserConf As New frmUserPassword(TryCast(lblSvrLst.Tag, clsQuerys), True)
        frmUserConf.ShowDialog()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        crypt.TDESImplementation("lWpOnrrKPTarwaLwLrrvHDNh", "lWpOnrrK")
        Dim testStr As String = crypt.EncryptTDES("experdba")
        ' Agent Server 접속시 정보를 넣어 두었음. 
        If _AgentIP.Trim = "" Or _AgentPort = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M016"))
            Return
        End If
        Dim intCnt As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Visible = True Then
                intCnt += 1
            End If
        Next

        Dim strkey = fn_GetSerial()
        Dim frmConn As New frmConnection(_AgentIP, _AgentPort, -1, "", "", "", 5432, "", "", 3, 0, 0, "", intCnt + 1, strkey, "", "")
        If frmConn.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim struct As structConnection = Nothing
            Dim strSchema As String = ""
            Dim intCollect As Integer = 0
            Dim intStmtCollect As Integer = 0
            Dim intReScanStmt As Integer = 0
            Dim intSnapshot As Integer = 0
            Dim strAlias As String = ""
            Dim strHARole As String = ""
            Dim strHAHost As String = ""
            Dim intHAPort As Integer = 0
            Dim strHAREPLHost As String = ""
            Dim strVirtualIP As String = ""
            Dim strVirtualIP2 As String = ""
            frmConn.rtnValue(-1, struct, strSchema, intCollect, intStmtCollect, intReScanStmt, intSnapshot, strAlias, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2)

            AddData(-1, struct, strSchema, intCollect, intStmtCollect, intReScanStmt, intSnapshot, strAlias, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2)

        End If

        Dim nCount As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Visible = True Then
                nCount += 1
            End If
        Next

        lblSvrLst.Text = p_clsMsgData.fn_GetData("F013") + " ( " + nCount.ToString + " ) "

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        ' Agent Server 접속시 정보를 넣어 두었음. 
        If _AgentIP.Trim = "" Or _AgentPort = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M016"))
            Return
        End If

        If dgvSvrLst.SelectedRows.Count <= 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M034"))
            Return
        End If

        Dim tmpRow As DataGridViewRow = dgvSvrLst.SelectedRows(0)
        Dim intSelRow As Integer = tmpRow.Index
        Dim strIP As String = tmpRow.Cells(colIP.Index).Value
        Dim strPort As String = tmpRow.Cells(colPort.Index).Value
        'Dim strDBType As String = System.Enum.GetName(GetType(ODBC.DXODBC.enumODBCType), odbcCon.ODBCConninfo.ODBCType)
        Dim strUser As String = tmpRow.Cells(colUser.Index).Value
        Dim strPw As String = tmpRow.Cells(colPW.Index).Value
        Dim strCollectYN As String = tmpRow.Cells(colCollectYN.Index).Value
        Dim strDBNM As String = tmpRow.Cells(colDBNm.Index).Value
        Dim strAliasNm As String = tmpRow.Cells(colAliasNm.Index).Value
        Dim strSchema As String = tmpRow.Cells(colSchema.Index).Value
        Dim intPeriod As Integer = tmpRow.Cells(colCollectSecond.Index).Value
        Dim intStmtPeriod As Integer = tmpRow.Cells(colStmtCollectSecond.Index).Value
        Dim intSnapshotPeriod As Integer = tmpRow.Cells(colSnapshotHour.Index).Value
        Dim strHARole As String = tmpRow.Cells(colHARole.Index).Value
        Dim strHAHost As String = tmpRow.Cells(colHAHost.Index).Value
        Dim intHAPort As Integer = tmpRow.Cells(colHAPort.Index).Value
        Dim strHAREPLHost As String = tmpRow.Cells(colHAREPLHost.Index).Value
        Dim strVirtualIP As String = IIf(IsDBNull(tmpRow.Cells(colVirtualIP.Index).Value), "", tmpRow.Cells(colVirtualIP.Index).Value)
        Dim strVirtualIP2 As String = IIf(IsDBNull(tmpRow.Cells(colVirtualIP2.Index).Value), "", tmpRow.Cells(colVirtualIP2.Index).Value)

        Dim intCnt As Integer = 0
        For Each cntRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If cntRow.Visible = True Then
                intCnt += 1
            End If
        Next

        Dim strKey = fn_GetSerial()
        Dim frmConn As New frmConnection(_AgentIP, _AgentPort, intSelRow, strUser, strPw, strIP, strPort, strDBNM, strSchema, intPeriod, intStmtPeriod, intSnapshotPeriod, strAliasNm, intCnt, strKey, strVirtualIP, strVirtualIP2, strHARole, strHAHost, intHAPort, strHAREPLHost)
        If frmConn.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtnStruct As structConnection = Nothing
            Dim rtnSchema As String = ""
            Dim rtnCollect As Integer = 0
            Dim rtnStmtCollect As Integer = 0
            Dim rtnReScanStmt As Integer = 0
            Dim rtnSnapshot As Integer = 0
            Dim strAlias As String = ""

            frmConn.rtnValue(-1, rtnStruct, rtnSchema, rtnCollect, rtnStmtCollect, rtnReScanStmt, rtnSnapshot, strAlias, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2)

            AddData(tmpRow.Index, rtnStruct, rtnSchema, rtnCollect, rtnStmtCollect, rtnReScanStmt, rtnSnapshot, strAlias, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2)
        End If


    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ' 저장하겠냐는 메시지 출력 
        If MsgBox(p_clsMsgData.fn_GetData("M006"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then Return


        ' 상단의 Agent 서버 접속 정보테스트 완료 시 해당하는 접속 정보를 Grid Tag에 넣어 두었음. 
        Dim odbcCon As eXperDB.ODBC.eXperDBODBC = TryCast(lblSvrLst.Tag, eXperDB.ODBC.eXperDBODBC)



        ' 추가적으로 모두 업데이트에 대한 로직 필요 



        If odbcCon IsNot Nothing Then

            Dim ClsQuery As New clsQuerys(odbcCon)
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP

            For Each tmpRow As DataGridViewRow In dgvSvrLst.Rows
                Dim intInstID As Integer = IIf(tmpRow.Tag Is Nothing, -1, tmpRow.Tag)

                Dim strIP As String = tmpRow.Cells(colIP.Index).Value
                Dim strPort As String = tmpRow.Cells(colPort.Index).Value
                Dim strDBType As String = System.Enum.GetName(GetType(eXperDB.ODBC.eXperDBODBC.enumODBCType), odbcCon.ODBCConninfo.ODBCType)
                Dim strUser As String = tmpRow.Cells(colUser.Index).Value
                Dim strPw As String = tmpRow.Cells(colPW.Index).Value
                Dim strCollectYN As String = tmpRow.Cells(colCollectYN.Index).Value
                Dim strDBNM As String = tmpRow.Cells(colDBNm.Index).Value
                Dim strAliasNm As String = tmpRow.Cells(colAliasNm.Index).Value
                Dim strSchema As String = tmpRow.Cells(colSchema.Index).Value
                Dim intPeriod As Integer = tmpRow.Cells(colCollectSecond.Index).Value
                Dim intStmtPeriod As Integer = tmpRow.Cells(colStmtCollectSecond.Index).Value
                Dim intSnapshotPeriod As Integer = tmpRow.Cells(colSnapshotHour.Index).Value
                Dim intPwch As Integer = tmpRow.Cells(colPWCH.Index).Value
                Dim strHARole As String = tmpRow.Cells(colHARole.Index).Value
                Dim strHAHost As String = tmpRow.Cells(colHAHost.Index).Value
                Dim intHAPort As Integer = tmpRow.Cells(colHAPort.Index).Value
                Dim strHAREPLHost As String = tmpRow.Cells(colHAREPLHost.Index).Value
                Dim strVirtualIP As String = IIf(IsDBNull(tmpRow.Cells(colVirtualIP.Index).Value), "", tmpRow.Cells(colVirtualIP.Index).Value)
                Dim strVirtualIP2 As String = IIf(IsDBNull(tmpRow.Cells(colVirtualIP2.Index).Value), "", tmpRow.Cells(colVirtualIP2.Index).Value)
                Dim intReScanStmt As Integer = tmpRow.Cells(colReScanStmt.Index).Value
                ' Dim intLogDay As Integer = tmpRow.Cells(colLogSave.Index).Value

                Try
                    Dim dtTable As DataTable = ClsQuery.SelectSerialKey()
                    If dtTable IsNot Nothing Then
                        Dim dtRow As DataRow = dtTable.Rows(0)
                        Dim strKey As String = dtRow.Item("LICDATA")
                        If strKey.Length < 24 Then
                            MsgBox(p_clsMsgData.fn_GetData("M018"))
                            Return
                        End If

                    End If
                Catch ex As Exception
                    Console.WriteLine(e.ToString)
                    MsgBox(p_clsMsgData.fn_GetData("M018"))
                    Return
                End Try

                If tmpRow.Tag IsNot Nothing AndAlso tmpRow.Tag = -1 Then
                    ' 기존 데이터가 아닐경우 
                    Dim tmpInst As Integer = ClsQuery.ExistsServer(strIP, strPort)
                    If tmpInst < 0 Then
                        tmpRow.Tag = ClsQuery.insertServerList(strIP, strPort, strDBType, strUser, strPw, strCollectYN, intPeriod, intStmtPeriod, intSnapshotPeriod, strDBNM, strAliasNm, strLocIP, strSchema, strHARole, strHAHost, intHAPort, strHAREPLHost)
                    Else
                        tmpRow.Tag = tmpInst
                        ClsQuery.UpdateServerList(tmpInst, strIP, strPort, strDBType, strUser, strPw, strCollectYN, intPeriod, intStmtPeriod, intSnapshotPeriod, strDBNM, strAliasNm, strLocIP, strSchema, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2, intReScanStmt)
                    End If

                ElseIf tmpRow.Visible = False AndAlso tmpRow.Tag <> -1 Then
                    ' Delete 시에 Visible을 없애 버리므로 Visible 을 체크하고 
                    ' 신규 서버인 경우에 굳이 Delete 쿼리를 날릴 필요가 없으므로 그냥 넘어감 
                    ClsQuery.DeleteServerList(intInstID, strLocIP)
                Else
                    ' 주기타임을 변경하였거나 혹은 개별 정보를 수정하였을 경우에는 
                    If dgvSvrLst.fn_DataRowChangeCheck(tmpRow.Index) = True Then
                        ClsQuery.UpdateServerList(intInstID, strIP, strPort, strDBType, strUser, strPw, strCollectYN, intPeriod, intStmtPeriod, intSnapshotPeriod, strDBNM, strAliasNm, strLocIP, strSchema, strHARole, strHAHost, intHAPort, strHAREPLHost, strVirtualIP, strVirtualIP2, intReScanStmt)
                    End If

                End If
            Next

            If Not nudLogSaveDly.Value.Equals(nudLogSaveDly.Tag) _
                Or Not cmbLogBatchH.SelectedIndex.Equals(cmbLogBatchH.Tag) _
                Or Not cmbLogBatchM.SelectedIndex.Equals(cmbLogBatchM.Tag) _
                Or Not cmbHealthTime.SelectedValue.Equals(cmbHealthTime.Tag) _
                Or Not cmbObjectTime.SelectedValue.Equals(cmbObjectTime.Tag) _
                Or Not cmbStmtTime.SelectedValue.Equals(cmbStmtTime.Tag) _
                Or Not nudTReportSaveDly.Value.Equals(nudTReportSaveDly.Tag) Then
                ClsQuery.UpdateConfig(nudLogSaveDly.Value, strLocIP, String.Format("{0}:{1}", cmbLogBatchH.SelectedIndex, cmbLogBatchM.SelectedIndex), cmbHealthTime.SelectedValue, cmbObjectTime.SelectedValue, cmbStmtTime.SelectedValue, nudTReportSaveDly.Value)
            End If

            'If Not nudSnapshotSaveDly.Value.Equals(nudSnapshotSaveDly.Tag) _
            '    Or Not cmbSnapshotTopN.SelectedValue.Equals(cmbSnapshotTopN.Tag) Then
            '    ClsQuery.UpdateSnapshotConfig(nudSnapshotSaveDly.Value, cmbSnapshotTopN.SelectedValue)
            'End If

        End If
        ' 데이터 삽입 후 서버 Agent 재시작 
        AgentMsg = New clsAgentEMsg(_AgentIP, _AgentPort)
        AgentMsg.SendMDX001(clsAgentEMsg.MDX001_REQ.enumMDX001ACTION.Restart)
        ' 데이터 삽입 후 목록 재 갱신 
        ReadSvrList(odbcCon)
        ' wait until the agent is restart
        _startDt = fn_ChkServer(odbcCon)
        _applyCount = 0
        CircularProgressControl1.Visible = True
        CircularProgressControl1.Start()
        tmCheckAgent.Interval = _checkAgentInterval
        tmCheckAgent.Start()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim nCount As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Cells(colCheck.Index).RowIndex = dgvSvrLst.SelectedRows(0).Index Then
                tmpRow.Visible = False
            Else
                nCount += 1
            End If
        Next
        lblSvrLst.Text = p_clsMsgData.fn_GetData("F013") + " ( " + nCount.ToString + " ) "
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class