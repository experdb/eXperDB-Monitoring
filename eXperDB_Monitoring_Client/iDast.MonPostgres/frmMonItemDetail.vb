Imports System.ComponentModel

Public Class frmMonItemDetail

    Private _InstanceID As Integer = -1
    Private _SelectedIndex As String
    Private _SelectedGrid As String
    Private _chtOrder As Integer = -1
    Private _AreaCount As Integer = 8
    Private _chtCount As Integer = 0
    Private _clsQuery As clsQuerys
    Private _bChartMenu As Boolean = False

    Private _ThreadDetail As Threading.Thread

    Private _isFromFormLoad As Boolean = True

    Private _ListStatements As New List(Of String)
    Private _UseFilter As Boolean

    Private WithEvents _ProgresForm As frmProgres
    Private Event ShowMasg()
    Private Event WaitMasg(ByVal str As String)
    Private Event WaitComplete()

    ReadOnly Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
    End Property
    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    Private _ServerInfo As GroupInfo.ServerInfo = Nothing

    Private _AgentInfo As structAgent
    ReadOnly Property AgentInfo As structAgent
        Get
            Return _AgentInfo
        End Get
    End Property
    Private _AgentCn As eXperDB.ODBC.eXperDBODBC

    ReadOnly Property AgentCn As eXperDBODBC
        Get
            Return _AgentCn
        End Get
    End Property

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal ServerInfo As List(Of GroupInfo.ServerInfo), ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, ByVal AgentInfo As structAgent, ByVal chtOrder As Integer)
        'Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _InstanceID = intInstanceID
        _SvrpList = ServerInfo
        _AgentInfo = AgentInfo

        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        '_AgentCn = New eXperDBODBC(dbType, "192.168.56.111", 5432, "pgmon", "pgmon", "pgmon")
        _AgentCn = New eXperDBODBC(dbType, _AgentInfo.AgentDBIP, _AgentInfo.AgentDBPort, _AgentInfo.AgentConnDBUser, _AgentInfo.AgentConnDBPW, _AgentInfo.AgentConnDBNM)

        _chtOrder = chtOrder

        _clsQuery = New clsQuerys(_AgentCn)
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            If tmpSvr.InstanceID = _InstanceID Then
                _ServerInfo = tmpSvr
            End If
            cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
        Next

        'If _chtOrder >= 0 Then   'DDDD
        '    dtpSt.Visible = True
        '    dtpEd.Visible = True
        '    cmbDuration.Visible = False
        '    'btnQuery.Visible = False
        'Else
        '    _chtOrder = 0
        '    dtpSt.Visible = True
        '    dtpEd.Visible = False
        '    cmbDuration.Visible = True
        '    cmbDuration.SelectedIndex = 0
        '    'btnQuery.Visible = True
        'End If

        dtpSt.Visible = True
        dtpEd.Visible = True
        'cmbDuration.Visible = False 'DDDD


        dtpSt.Value = stDt.AddMinutes(-1)
        dtpEd.Value = edDt.AddMinutes(1)
        dtpSt.Tag = stDt
        dtpEd.Tag = edDt

        InitForm()
        InitCharts()
        ReadConfig()
    End Sub

    Delegate Sub InvokeDelegate()


    Public Sub InvokeMethod()
        If _chtOrder >= 0 Then
            Select Case _chtOrder
                Case 0 : SetDefaultTitle(chkCpu, chtCPU, True, "")
                Case 1 : SetDefaultTitle(chkSession, chtSession, True, "")
                Case 2 : SetDefaultTitle(chkLogicalIO, chtLogicalIO, True, "")
                Case 3 : SetDefaultTitle(chkPhysicalRead, chtPhysicalRead, True, "")
                Case 4 : SetDefaultTitle(chkDiskIO, chtDiskIO, True, "")
                Case 5 : SetDefaultTitle(chkSQLResp, chtSQLResp, True, "")
                Case 6 : SetDefaultTitle(chkLock, chtLock, True, "")
                    tabSession.SelectedIndex = 2
                Case 7 : SetDefaultTitle(chkTPS, chtTPS, True, "")
            End Select
        End If
    End Sub 'InvokeMethod


    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMonItemDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _InstanceID > 0 Then
            Dim comboSource As New Dictionary(Of String, String)()
            Dim index As Integer = 0
            For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
                If tmpSvr.InstanceID = _InstanceID Then
                    cmbInst.SelectedIndex = index
                End If
                index += 1
            Next
        End If

        '_chtCount = 1
        chtCPU.MainChart.Focus()

        Me.Invoke(New MethodInvoker(Sub()
                                        btnQuery.PerformClick()
                                    End Sub))
        'SetDataSession(dtpSt.Value, dtpEd.Value)
        'SetDataLock(dtpSt.Value, dtpEd.Value)
        BeginInvoke(New InvokeDelegate(AddressOf InvokeMethod))
    End Sub

    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Public Sub frmMonItemDetail_ReLoad(ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, Optional chtOrder As Integer = 1)
        _InstanceID = intInstanceID

        _chtOrder = chtOrder

        _chtOrder = 0
        dtpSt.Visible = True
        dtpEd.Visible = True
        'cmbDuration.Visible = True 'DDDD
        'cmbDuration.SelectedIndex = 0
        btnQuery.Visible = True
        Dim prevStdt As DateTime = dtpSt.Value
        Dim prevInstanceIndex = cmbInst.SelectedIndex
        dtpSt.Value = stDt.AddMinutes(0)
        dtpSt.Tag = stDt

        chtCPU.MainChart.Focus()
        If _InstanceID > 0 Then
            Dim comboSource As New Dictionary(Of String, String)()
            Dim index As Integer = 0
            For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
                If tmpSvr.InstanceID = _InstanceID Then
                    cmbInst.SelectedIndex = index
                End If
                index += 1
            Next
        End If

        If prevInstanceIndex <> cmbInst.SelectedIndex Or prevStdt <> dtpSt.Value Then
            Me.Invoke(New MethodInvoker(Sub()
                                            btnQuery.PerformClick()
                                        End Sub))
        End If

        'SetDataSession(dtpSt.Value, dtpEd.Value)
        'SetDataLock(dtpSt.Value, dtpEd.Value)
        'BeginInvoke(New InvokeDelegate(AddressOf InvokeMethod))
    End Sub

    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        'FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        'Me.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        Me.Text += " [ " + String.Format("{0}({1}) ", _ServerInfo.ShowNm, _ServerInfo.IP) + "]"
        lblSubject.Text = p_clsMsgData.fn_GetData("M045")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'label & Input
        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        lblChart.Text = p_clsMsgData.fn_GetData("F268")

        ' Checkbox Button
        chkCpu.Text = p_clsMsgData.fn_GetData("F035")
        chkSession.Text = p_clsMsgData.fn_GetData("F047")
        chkLogicalIO.Text = p_clsMsgData.fn_GetData("F101")
        chkPhysicalRead.Text = p_clsMsgData.fn_GetData("F100")
        chkDiskIO.Text = p_clsMsgData.fn_GetData("F086")
        chkSQLResp.Text = p_clsMsgData.fn_GetData("F267")
        chkLock.Text = p_clsMsgData.fn_GetData("F317")
        chkTPS.Text = p_clsMsgData.fn_GetData("F320")

        ' Button 
        btnQuery.Text = p_clsMsgData.fn_GetData("F151")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information (whole)

        lslSession.Text = p_clsMsgData.fn_GetData("F314", 0)
        dgvSessionList.AutoGenerateColumns = False
        coldgvSessionListDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvSessionListPID.HeaderText = p_clsMsgData.fn_GetData("F082")
        coldgvSessionListCpuUsage.HeaderText = p_clsMsgData.fn_GetData("F092")
        coldgvSessionListStTime.HeaderText = p_clsMsgData.fn_GetData("F050")
        coldgvSessionListElapsedTime.HeaderText = p_clsMsgData.fn_GetData("F051")
        coldgvSessionListUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        coldgvSessionListClient.HeaderText = p_clsMsgData.fn_GetData("F248")
        coldgvSessionListApp.HeaderText = p_clsMsgData.fn_GetData("F249")
        coldgvSessionListSQL.HeaderText = p_clsMsgData.fn_GetData("F084")

        dgvSessionList.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvSessionList.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information (statistics)

        dgvRptSQL.AutoGenerateColumns = False
        colDgvRptSqlDBNm.HeaderText = p_clsMsgData.fn_GetData("F090")
        colDgvRptSqlCpuTime.HeaderText = p_clsMsgData.fn_GetData("F231")
        colDgvRptSqlCount.HeaderText = p_clsMsgData.fn_GetData("F232")
        colDgvRptSqlElapsedMax.HeaderText = p_clsMsgData.fn_GetData("F183")
        colDgvRptSqlSql.HeaderText = p_clsMsgData.fn_GetData("F185")

        tabWhole.Text = p_clsMsgData.fn_GetData("F045")
        tabStats.Text = p_clsMsgData.fn_GetData("F297")

        dgvRptSQL.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvRptSQL.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)

        '''''''''''''''''''''''''''''''''''''''''
        ' Lock Information 
        dgvLock.AutoGenerateColumns = False
        colDgvLockDB.HeaderText = p_clsMsgData.fn_GetData("F104")
        colDgvLockBlockedPID.HeaderText = p_clsMsgData.fn_GetData("F195")
        colDgvLockBlockedUser.HeaderText = p_clsMsgData.fn_GetData("F196")
        colDgvLockBlockingPID.HeaderText = p_clsMsgData.fn_GetData("F197")
        colDgvLockBlockingUser.HeaderText = p_clsMsgData.fn_GetData("F198")
        colDgvLockElapse.HeaderText = p_clsMsgData.fn_GetData("F135")
        colDgvLockBlockingQuery.HeaderText = p_clsMsgData.fn_GetData("F225")
        colDgvLockBlockedQuery.HeaderText = p_clsMsgData.fn_GetData("F221")
        colDgvLockMode.HeaderText = p_clsMsgData.fn_GetData("F222")
        colDgvLockQueryStart.HeaderText = p_clsMsgData.fn_GetData("F223")
        colDgvLockXactStart.HeaderText = p_clsMsgData.fn_GetData("F224")

        tabLock.Text = p_clsMsgData.fn_GetData("F317")


        dgvLock.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvLock.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)

        '''''''''''''''''''''''''''''''''''''''''
        ' Statements Information 

        dgvStmtList.AutoGenerateColumns = False
        coldgvStmtListDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvStmtListUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        coldgvStmtListQuery.HeaderText = p_clsMsgData.fn_GetData("F084")


        chtCPU.Visible = False
        chtSession.Visible = False
        chtLogicalIO.Visible = False
        chtPhysicalRead.Visible = False
        chtDiskIO.Visible = False
        chtSQLResp.Visible = False
        chtLock.Visible = False
        chtTPS.Visible = False

        'modCommon.FontChange(Me, p_Font)
    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub

    ''' <summary>
    ''' BackEnd 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataSession(ByVal starDt As DateTime, ByVal endDt As DateTime)

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectDetailSQLListChart(_InstanceID, p_ShowName.ToString("d"), starDt, endDt, AgentInfo.AgentVer)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Dim nCount As Integer = 0
            dgvSessionList.Invoke(New MethodInvoker(Sub()
                                                        Try
                                                            Dim strQuery As String = ""

                                                            strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)

                                                            Dim dtView As DataView = New DataView(dtTable, strQuery, "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

                                                            Dim ShowDT As DataTable = Nothing
                                                            If dtView.Count > 0 Then
                                                                ShowDT = dtView.ToTable.AsEnumerable.Take(500).CopyToDataTable
                                                            End If

                                                            If ShowDT Is Nothing Then
                                                                dgvSessionList.DataSource = Nothing
                                                                Return
                                                            End If

                                                            dgvSessionList.DataSource = ShowDT

                                                            modCommon.sb_GridSortChg(dgvSessionList)
                                                            nCount = dtView.Count
                                                        Catch ex As Exception
                                                            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                            GC.Collect()
                                                        End Try

                                                    End Sub))
            lslSession.Invoke(New MethodInvoker(Sub()
                                                    lslSession.Text = p_clsMsgData.fn_GetData("F314", nCount)
                                                End Sub))

        End If
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Statistics
        Dim dtTableStats As DataTable = Nothing
        Dim tmpStatsTh As Threading.Thread = New Threading.Thread(Sub()
                                                                      Try
                                                                          dtTableStats = _clsQuery.SelectReportSQL(_InstanceID, starDt, endDt, AgentInfo.AgentVer, 1000)
                                                                      Catch ex As Exception
                                                                          GC.Collect()
                                                                      End Try
                                                                  End Sub)
        tmpStatsTh.Start()
        tmpStatsTh.Join()
        If dtTableStats IsNot Nothing Then
            dgvRptSQL.Invoke(New MethodInvoker(Sub()
                                                   Try
                                                       Dim strQuery As String = ""

                                                       'strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)

                                                       Dim dtView As DataView = New DataView(dtTableStats, strQuery, "OCCUPIED_TIME DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

                                                       Dim ShowDT As DataTable = Nothing
                                                       If dtView.Count > 0 Then
                                                           ShowDT = dtView.ToTable.AsEnumerable.Take(500).CopyToDataTable
                                                       End If

                                                       If ShowDT Is Nothing Then
                                                           dgvRptSQL.DataSource = Nothing
                                                           Return
                                                       End If

                                                       dgvRptSQL.DataSource = ShowDT

                                                       modCommon.sb_GridSortChg(dgvRptSQL)
                                                   Catch ex As Exception
                                                       p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                       GC.Collect()
                                                   End Try

                                               End Sub))
        End If

    End Sub

    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs)
        If e.ErrorText <> "" Then

        End If

    End Sub

    'Private Sub dgvSessionList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim strDb As String = ""
    '    Dim strUser As String = ""
    '    Dim strQuery As String = ""
    '    If dgvSessionList.RowCount <= 0 Then Return
    '    _SelectedIndex = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
    '    _SelectedGrid = 0
    '    If e.ColumnIndex = coldgvSessionListSQL.Index Then
    '        strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
    '        strQuery = dgvSessionList.CurrentCell.Value
    '        strUser = dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value
    '        Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
    '        frmQuery.ShowDialog(Me)
    '    End If
    'End Sub


    ''' <summary>
    ''' Lock 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataLock(ByVal starDt As DateTime, ByVal endDt As DateTime)

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectLockInfoAccum(_InstanceID, starDt, endDt, True)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            dgvLock.Invoke(New MethodInvoker(Sub()
                                                 Try
                                                     Dim dtView As DataView = New DataView(dtTable)
                                                     Dim ShowDT As DataTable = Nothing
                                                     If dtView.Count > 0 Then
                                                         ShowDT = dtView.ToTable.AsEnumerable.Take(500).CopyToDataTable
                                                     End If

                                                     If ShowDT Is Nothing Then
                                                         dgvLock.DataSource = Nothing
                                                         Return
                                                     End If

                                                     dgvLock.DataSource = ShowDT
                                                     'Dim Dgv As AdvancedDataGridView.TreeGridView = dgvLock
                                                     'Dgv.Nodes.Clear()
                                                     'Dim intLockCount As Integer = 0
                                                     'Dim HashTbl As New Hashtable
                                                     'For Each tmpCol As DataGridViewColumn In Dgv.Columns

                                                     '    If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) Then
                                                     '        HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
                                                     '    End If
                                                     'Next

                                                     'Dim dtView As DataView = dtTable.AsEnumerable.AsDataView
                                                     'For Each tmpRow As DataRow In dtView.ToTable.Select("BLOCKED_PID IS NULL", "ORDER_NO ASC")
                                                     '    Dim topNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
                                                     '    sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)
                                                     '    intLockCount += 1
                                                     '    For Each tmpChild As DataRow In dtView.Table.Select(String.Format("BLOCKED_PID IS NOT NULL AND BLOCKING_PID = {0} AND ACTV_REG_SEQ = {1}", tmpRow.Item("BLOCKING_PID"), tmpRow.Item("ACTV_REG_SEQ")), "ORDER_NO ASC")
                                                     '        Dim cNOde As AdvancedDataGridView.TreeGridNode = topNode.Nodes.Add(tmpChild.Item("DB_NAME"))
                                                     '        sb_AddTreeGridDatas(cNOde, HashTbl, tmpChild)

                                                     '    Next
                                                     '    topNode.Expand()
                                                     '    topNode.Cells(0).Value = tmpRow.Item("DB_NAME") & " (" & topNode.Nodes.Count & ")"

                                                     'Next

                                                     'grpLockInfo.Text = p_clsMsgData.fn_GetData("F077", intLockCount)
                                                     'lslSession.Text = p_clsMsgData.fn_GetData("F314", dtView.Count)
                                                 Catch ex As Exception
                                                     p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                     GC.Collect()
                                                 End Try

                                             End Sub))
        End If
    End Sub


    ''' <summary>
    ''' BackEnd 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataStmt(ByVal starDt As DateTime, ByVal endDt As DateTime)


        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectCurrentStatementsDuration(_InstanceID, starDt, endDt)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            dgvStmtList.Invoke(New MethodInvoker(Sub()
                                                     Try
                                                         Dim dtView As DataView = New DataView(dtTable)
                                                         Dim ShowDT As DataTable = Nothing
                                                         If dtView.Count > 0 Then
                                                             ShowDT = dtView.ToTable.AsEnumerable.Take(500).CopyToDataTable
                                                         End If

                                                         If ShowDT Is Nothing Then
                                                             dgvStmtList.DataSource = Nothing
                                                             Return
                                                         End If

                                                         'dgvStmtList.DataSource = ShowDT
                                                         STMTTableBindingSource.DataSource = ShowDT

                                                         If _UseFilter = True Then
                                                             SetRowfilter()
                                                         End If
                                                     Catch ex As Exception
                                                         p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                         GC.Collect()
                                                     End Try

                                                 End Sub))
        End If

    End Sub

    Private Sub InitCharts()

        chkCpu.Tag = 0
        chkSession.Tag = 1
        chkLogicalIO.Tag = 2
        chkPhysicalRead.Tag = 3
        chkDiskIO.Tag = 4
        chkSQLResp.Tag = 5
        chkLock.Tag = 6
        chkTPS.Tag = 7

        SetDefaultTitle(chkCpu, chtCPU, False, "")
        SetDefaultTitle(chkSession, chtSession, False, "")
        SetDefaultTitle(chkLogicalIO, chtLogicalIO, False, "")
        SetDefaultTitle(chkPhysicalRead, chtPhysicalRead, False, "")
        SetDefaultTitle(chkDiskIO, chtDiskIO, False, "")
        SetDefaultTitle(chkSQLResp, chtSQLResp, False, "")
        SetDefaultTitle(chkLock, chtLock, False, "")
        SetDefaultTitle(chkTPS, chtTPS, False, "")

        chtCPU.MainChart.ChartAreas(0).Visible = False
        'chtCPU.AddAreaEx("CPU Usage", "RATE(%)", True, "CPUAREA")
        chtCPU.AddAreaEx("CPU Usage", "RATE(%)", True, "CPUAREA")
        chtCPU.AddAreaEx("Session", "Count", True, "SESSIONAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F040"), "Tuples/sec", True, "LOGICALAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F100"), "Blocks/sec", True, "PHYSICALAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F086"), "Busy(%)", True, "DISKAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F103"), "SEC", True, "SQLRESPAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F317"), "Count", True, "LOCKAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F320"), "Transactions/sec", True, "TPSAREA")

        chtCPU.MainChart.ChartAreas("CPUAREA").Visible = False
        chtCPU.MainChart.ChartAreas("SESSIONAREA").Visible = False
        chtCPU.MainChart.ChartAreas("LOGICALAREA").Visible = False
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").Visible = False
        chtCPU.MainChart.ChartAreas("DISKAREA").Visible = False
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").Visible = False
        chtCPU.MainChart.ChartAreas("LOCKAREA").Visible = False
        chtCPU.MainChart.ChartAreas("TPSAREA").Visible = False

        chtCPU.MainChart.ChartAreas("CPUAREA").AxisY.Maximum = 100
        chtCPU.MainChart.ChartAreas("CPUAREA").AxisY.Minimum = 0

        chtCPU.MainChart.ChartAreas("DISKAREA").AxisY.Maximum = 100
        chtCPU.MainChart.ChartAreas("DISKAREA").AxisY.Minimum = 0

        Me.chtCPU.Visible = True

        chtCPU.MainChart.ChartAreas("CPUAREA").AxisX.ScaleView.Zoomable = False
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserSelectionEnabled = True

        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes

        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserEnabled = True
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserSelectionEnabled = True
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorY.IsUserEnabled = False
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorY.IsUserSelectionEnabled = False

        'chtCPU.MainChart.ChartAreas("SESSIONAREA").AxisX.ScaleView.Zoomable = False
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("SESSIONAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("LOGICALAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("DISKAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("DISKAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("DISKAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("DISKAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("DISKAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("LOCKAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("LOCKAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("LOCKAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("LOCKAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("LOCKAREA").AxisX.ScaleView.Zoomable = False

        chtCPU.MainChart.ChartAreas("TPSAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("TPSAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("TPSAREA").CursorX.IsUserEnabled = True
        chtCPU.MainChart.ChartAreas("TPSAREA").CursorX.IsUserSelectionEnabled = True
        chtCPU.MainChart.ChartAreas("TPSAREA").AxisX.ScaleView.Zoomable = False

        AddHandler chtCPU.MainChart.CursorPositionChanged, AddressOf chtCPU_CursorPositionChanged

    End Sub
    Private Sub SetDefaultTitle(ByRef chkBox As eXperDB.BaseControls.CheckBox, ByRef chart As eXperDB.Monitoring.ctlChartEx, ByVal chtEnable As Boolean, ByVal chtTitle As String)
        chkBox.Checked = chtEnable
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkSQLResp.CheckedChanged, chkSession.CheckedChanged, chkDiskIO.CheckedChanged, chkPhysicalRead.CheckedChanged, chkLogicalIO.CheckedChanged, chkCpu.CheckedChanged, chkLock.CheckedChanged, chkTPS.CheckedChanged

        Dim CheckBox As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)

        If fn_SearchBefCheck() = False Then Return

        If CheckBox.Checked = True Then
            _chtCount += 1
        Else
            _chtCount -= 1
        End If

        If _chtCount <= 0 Then
            CheckBox.Checked = True
            Return
        End If
        chtCPU.Height = 2000 'fix Height of Chart
        chtCPU.MainChart.Focus()

        If _isFromFormLoad = True Then
            _isFromFormLoad = False
            Return
        End If

        If CheckBox.Checked = False Then
            ' If _annotationIndex = CheckBox.Tag + 1 Then
            'fn_DeleteAnnotaion()
            SetDataSession(dtpSt.Value, dtpEd.Value)
            SetDataLock(dtpSt.Value, dtpEd.Value)
            SetDataStmt(dtpSt.Value, dtpEd.Value)
            'End If
        End If
        Dim checkIndex = CheckBox.Tag + 1
        Dim isCheck = CheckBox.Checked

        _ProgresForm = New frmProgres()
        _ProgresForm.Owner = Me
        _ProgresForm.Location = Me.Location
        _ProgresForm.Size = Me.Size
        _ProgresForm.Show()

        If _ThreadDetail IsNot Nothing AndAlso _ThreadDetail.IsAlive = True Then Return
        _ThreadDetail = New Threading.Thread(Sub()
                                                 Try
                                                     QueryChartData(checkIndex, isCheck)
                                                     RaiseEvent WaitComplete()
                                                 Catch ex As Exception
                                                     GC.Collect()
                                                 Finally
                                                 End Try
                                             End Sub)
        _ThreadDetail.Start()
        'QueryChartData(CheckBox.Tag + 1, CheckBox.Checked)
    End Sub
    Private Sub QueryChartData(ByVal index As Integer, ByVal enable As Boolean)

        'Threading.Thread.Sleep(10)
        Dim stDate As DateTime = dtpSt.Value
        Dim edDate As DateTime = dtpEd.Value

        If index = 5 Then
            '_ThreadDetail = New Threading.Thread(Sub()
            '                                         Threading.Thread.Sleep(50)
            '                                         ShowDiskIOChart(index, stDate, edDate, enable)
            '                                     End Sub)
            ShowDiskIOChart(index, dtpSt.Value, dtpEd.Value, enable)
        Else
            '_ThreadDetail = New Threading.Thread(Sub()
            '                                         Try
            '                                             ShowDynamicChart(index, stDate, edDate, enable)
            '                                         Catch ex As Exception
            '                                             GC.Collect()
            '                                         End Try

            '                                     End Sub)
            ShowDynamicChart(index, dtpSt.Value, dtpEd.Value, enable)
        End If

        '_ThreadDetail.Start()
        'modCommon.FontChange(Me, p_Font)
    End Sub

    Private Sub ArrangeChartlayout()
        Dim tmpChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim nCount As Integer = 0
        Dim MarginTop As Double = 0
        Dim MarginBottom As Double = 0
        Dim AreaHeight As Double = (100 / _AreaCount)
        MarginTop = AreaHeight * 0.23
        MarginBottom = AreaHeight * 0.23
        AreaHeight = AreaHeight * 0.54
        For i As Integer = 1 To _AreaCount
            tmpChartArea = Me.chtCPU.MainChart.ChartAreas(i)
            If tmpChartArea.Visible = True Then
                tmpChartArea.Position.Y = (nCount * AreaHeight) + MarginTop * (nCount + 1) + MarginBottom * nCount
                tmpChartArea.Position.Height = AreaHeight
                'tmpChartArea.InnerPlotPosition.Y = 10
                'tmpChartArea.InnerPlotPosition.Height = 80 + _chtCount / 2
                tmpChartArea.Position.X = 3
                If i = 3 AndAlso tmpChartArea.Position.Width < 90 Then
                    tmpChartArea.Position.Width = tmpChartArea.Position.Width * (1 + CSng(100 / (Me.chtCPU.MainChart.Width)))
                End If
                'If i = 4 Then
                '    tmpChartArea.Position.Y = tmpChartArea.Position.Y + 1
                'End If
                nCount += 1
            End If
        Next
    End Sub

    'Private Sub ArrangeChartlayout()
    '    Dim tmpChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea
    '    Dim nCount As Integer = 0
    '    Dim MarginTop As Integer = 0
    '    Dim MarginBottom As Integer = 0
    '    Dim AreaHeight As Integer = (100 / _chtCount)
    '    MarginTop = AreaHeight * 0.2
    '    AreaHeight = AreaHeight * 0.7
    '    MarginBottom = AreaHeight * 0.1
    '    For i As Integer = 1 To _AreaCount
    '        tmpChartArea = Me.chtCPU.MainChart.ChartAreas(i)
    '        If tmpChartArea.Visible = True Then
    '            tmpChartArea.Position.Y = (nCount * AreaHeight) + MarginTop * (nCount + 1) + MarginBottom * nCount
    '            tmpChartArea.Position.Height = AreaHeight
    '            tmpChartArea.Position.X = 3
    '            If i = 3 AndAlso tmpChartArea.Position.Width < 90 Then
    '                tmpChartArea.Position.Width = tmpChartArea.Position.Width * (1 + CSng(100 / (Me.chtCPU.MainChart.Width)))
    '            End If
    '            nCount += 1
    '        End If
    '    Next

    'End Sub

    Private Sub ShowDynamicChart(ByVal index As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strLegend1 As String = ""
        Dim strLegend2 As String = ""
        Dim strLegend3 As String = ""
        Dim strLegend4 As String = ""
        Dim strSeriesData1 As String = ""
        Dim strSeriesData2 As String = ""
        Dim strSeriesData3 As String = ""
        Dim strSeriesData4 As String = ""

        Dim LineColor1 As System.Drawing.Color
        Dim LineColor2 As System.Drawing.Color
        Dim LineColor3 As System.Drawing.Color
        Dim LineColor4 As System.Drawing.Color
        Dim seriesChartType As DataVisualization.Charting.SeriesChartType
        Dim yAxisType As DataVisualization.Charting.AxisType = DataVisualization.Charting.AxisType.Primary
        'YAxisType:=DataVisualization.Charting.AxisType.Secondary

        Select Case index
            Case 1
                strLegend1 = "USED"
                strLegend2 = "WAIT"
                strSeriesData1 = "USED_UTIL_RATE"
                strSeriesData2 = "WAIT_UTIL_RATE"
                LineColor1 = Color.FromArgb(255, CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
                LineColor2 = Color.Gold
                seriesChartType = DataVisualization.Charting.SeriesChartType.SplineArea
                If ShowChart = True Then
                    RaiseEvent WaitMasg("CPU Information")
                End If
            Case 2
                strLegend1 = "BACKENDTOT"
                strLegend2 = "BACKENDACT"
                strSeriesData1 = "TOT_BACKEND_CNT"
                strSeriesData2 = "CUR_ACTV_BACKEND_CNT"
                LineColor1 = Color.FromArgb(255, CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
                LineColor2 = Color.Violet
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                If ShowChart = True Then
                    RaiseEvent WaitMasg("Session Information")
                End If
            Case 3
                strLegend1 = "Read"
                strLegend2 = "Insert"
                strLegend3 = "Update"
                strLegend4 = "Delete"
                strSeriesData1 = "SELECT_TUPLES_PER_SEC"
                strSeriesData2 = "INSERT_TUPLES_PER_SEC"
                strSeriesData3 = "UPDATE_TUPLES_PER_SEC"
                strSeriesData4 = "DELETE_TUPLES_PER_SEC"
                LineColor1 = Color.FromArgb(255, CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
                LineColor2 = Color.Blue
                LineColor3 = Color.Orange
                LineColor4 = Color.Red
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                yAxisType = DataVisualization.Charting.AxisType.Secondary
                If ShowChart = True Then
                    RaiseEvent WaitMasg("Logical I/O Information")
                End If
            Case 4
                strLegend1 = "Physical Read"
                strSeriesData1 = "PHY_READ_PER_SEC"
                LineColor1 = Color.FromArgb(255, CType(CType(24, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(128, Byte), Integer))
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                If ShowChart = True Then
                    RaiseEvent WaitMasg("Physical Read Information")
                End If
            Case 5
            Case 6
                strLegend1 = p_clsMsgData.fn_GetData("F103")
                strSeriesData1 = "SQL_ELAPSED_SEC"
                LineColor1 = Color.LimeGreen
                seriesChartType = DataVisualization.Charting.SeriesChartType.Point
                If ShowChart = True Then
                    RaiseEvent WaitMasg("SQL Response time Information")
                End If
            Case 7
                strLegend1 = "LOCKTOT"
                strLegend2 = "LOCKWAIT"
                strSeriesData1 = "LOCK_TOTAL"
                strSeriesData2 = "LOCK_WAIT"
                LineColor1 = Color.RoyalBlue
                LineColor2 = Color.Crimson
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                If ShowChart = True Then
                    RaiseEvent WaitMasg("Lock Information")
                End If
            Case 8
                strLegend1 = "Commit"
                strLegend2 = "Rollback"
                strLegend3 = "Transaction"
                strSeriesData1 = "COMMIT_TUPLES_PER_SEC"
                strSeriesData2 = "ROLLBACK_TUPLES_PER_SEC"
                strSeriesData3 = "TRANSACTION_TUPLES_PER_SEC"
                LineColor1 = Color.HotPink
                LineColor2 = Color.RoyalBlue
                LineColor3 = Color.Orange
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                If ShowChart = True Then
                    RaiseEvent WaitMasg("Transaction Information")
                End If
        End Select

        If ShowChart = False Then
            chtCPU.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    chtCPU.MainChart.ChartAreas(index).Visible = ShowChart
                                                    For Each tmpSeries As DataVisualization.Charting.Series In chtCPU.MainChart.Series
                                                        If tmpSeries.ChartArea = chtCPU.MainChart.ChartAreas(index).Name Then
                                                            tmpSeries.Points.Clear()
                                                        End If
                                                    Next
                                                    ArrangeChartlayout()
                                                Catch ex As Exception
                                                    GC.Collect()
                                                End Try
                                            End Sub))
            Return
        End If

        chtCPU.Invoke(New MethodInvoker(Sub()
                                            Try
                                                If strLegend1 <> "" AndAlso chtCPU.GetSeries(strLegend1) = False Then
                                                    chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strLegend1, strLegend1, LineColor1, seriesChartType, yAxisType)
                                                    If yAxisType = DataVisualization.Charting.AxisType.Secondary Then
                                                        chtCPU.SetAxisY2ChartArea(Color.YellowGreen, index)
                                                    End If
                                                End If
                                                If strLegend2 <> "" AndAlso chtCPU.GetSeries(strLegend2) = False Then
                                                    chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strLegend2, strLegend2, LineColor2, seriesChartType)
                                                End If
                                                If strLegend3 <> "" AndAlso chtCPU.GetSeries(strLegend3) = False Then
                                                    chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strLegend3, strLegend3, LineColor3, seriesChartType)
                                                End If
                                                If strLegend4 <> "" AndAlso chtCPU.GetSeries(strLegend4) = False Then
                                                    chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strLegend4, strLegend4, LineColor4, seriesChartType)
                                                End If
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))


        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     Select Case index
                                                                         Case 1
                                                                             dtTable = _clsQuery.SelectReportCPUChart(_InstanceID, stDate, edDate)
                                                                         Case 2
                                                                             dtTable = _clsQuery.SelectDetailSessionInfoChart(_InstanceID, stDate, edDate)
                                                                         Case 3, 4, 8
                                                                             dtTable = _clsQuery.SelectDetailObjectChart(_InstanceID, p_ShowName.ToString("d"), stDate, edDate)
                                                                         Case 5
                                                                         Case 6
                                                                             dtTable = _clsQuery.SelectDetailSQLRespChart(_InstanceID, stDate, edDate)
                                                                         Case 7
                                                                             dtTable = _clsQuery.SelectLockCountTimeLine(_InstanceID, stDate, edDate)
                                                                     End Select

                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            chtCPU.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    chtCPU.MainChart.ChartAreas(index).Visible = ShowChart
                                                    For Each tmpSeries As DataVisualization.Charting.Series In chtCPU.MainChart.Series
                                                        If tmpSeries.ChartArea = chtCPU.MainChart.ChartAreas(index).Name Then
                                                            tmpSeries.Points.Clear()
                                                        End If
                                                    Next
                                                    chtCPU.SetMinimumAxisXChartArea(ConvOADate(stDate), index)
                                                    chtCPU.SetMaximumAxisXChartArea(ConvOADate(edDate), index)
                                                    If dtTable.Rows.Count > 0 Then
                                                        For i As Integer = 0 To dtTable.Rows.Count - 1
                                                            Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DATE"))
                                                            If strLegend1 <> "" Then Me.chtCPU.AddPoints(strLegend1, tmpDate, ConvDBL(dtTable.Rows(i).Item(strSeriesData1)))
                                                            If strLegend2 <> "" Then Me.chtCPU.AddPoints(strLegend2, tmpDate, ConvDBL(dtTable.Rows(i).Item(strSeriesData2)))
                                                            If strLegend3 <> "" Then Me.chtCPU.AddPoints(strLegend3, tmpDate, ConvDBL(dtTable.Rows(i).Item(strSeriesData3)))
                                                            If strLegend4 <> "" Then Me.chtCPU.AddPoints(strLegend4, tmpDate, ConvDBL(dtTable.Rows(i).Item(strSeriesData4)))
                                                        Next
                                                    Else
                                                        Dim tmpDate As Double = ConvOADate(Now())
                                                        If strLegend1 <> "" Then Me.chtCPU.AddPoints(strLegend1, tmpDate, 0.0)
                                                        If strLegend2 <> "" Then Me.chtCPU.AddPoints(strLegend2, tmpDate, 0.0)
                                                        If strLegend3 <> "" Then Me.chtCPU.AddPoints(strLegend3, tmpDate, 0.0)
                                                        If strLegend4 <> "" Then Me.chtCPU.AddPoints(strLegend4, tmpDate, 0.0)
                                                    End If

                                                    Me.chtCPU.ShowMaxValue(True)
                                                    'chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                                Catch ex As Exception
                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                    GC.Collect()
                                                End Try

                                            End Sub))
        End If

        chtCPU.Invoke(New MethodInvoker(Sub()
                                            chtCPU.SetInnerPlotPositionChartArea(index, _chtCount)
                                            chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                            ArrangeChartlayout()
                                        End Sub))

    End Sub
    Private Sub ShowDiskIOChart(ByVal index As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim arrPartition As New ArrayList
        Dim colors() As Color = {System.Drawing.Color.LimeGreen,
                         System.Drawing.Color.FromArgb(255, CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer)),
                         System.Drawing.Color.Orange,
                         System.Drawing.Color.Red,
                         System.Drawing.Color.Blue,
                         System.Drawing.Color.Brown,
                         System.Drawing.Color.Green,
                         System.Drawing.Color.Purple,
                         System.Drawing.Color.Yellow,
                         System.Drawing.Color.Pink,
                         System.Drawing.Color.PowderBlue,
                         System.Drawing.Color.SkyBlue,
                         System.Drawing.Color.SpringGreen,
                         System.Drawing.Color.YellowGreen,
                         System.Drawing.Color.Violet,
                         System.Drawing.Color.Salmon}

        If ShowChart = False Then
            chtCPU.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    chtCPU.MainChart.ChartAreas(index).Visible = ShowChart
                                                    For Each tmpSeries As DataVisualization.Charting.Series In chtCPU.MainChart.Series
                                                        If tmpSeries.ChartArea = chtCPU.MainChart.ChartAreas(index).Name Then
                                                            tmpSeries.Points.Clear()
                                                        End If
                                                    Next
                                                    ArrangeChartlayout()
                                                Catch ex As Exception
                                                    GC.Collect()
                                                End Try
                                            End Sub))
            Return
        End If

        RaiseEvent WaitMasg("Disk I/O Information")
        ' Get Partition list
        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectPhysicaliO(_InstanceID)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            chtCPU.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    For i As Integer = 0 To dtTable.Rows.Count - 1
                                                        arrPartition.Add(dtTable.Rows(i).Item("DISK_NAME"))
                                                    Next
                                                Catch ex As Exception
                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                    GC.Collect()
                                                End Try
                                            End Sub))
        Else
        End If
        ' Chart Disk I/O
        chtCPU.Invoke(New MethodInvoker(Sub()
                                            For i As Integer = 0 To arrPartition.Count - 1
                                                Dim strSeries = arrPartition.Item(i)
                                                If Not IsDBNull(strSeries) AndAlso strSeries <> "" Then
                                                    If chtCPU.GetSeries(strSeries) = False Then
                                                        chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strSeries, strSeries, colors(i))
                                                    End If
                                                End If
                                            Next
                                        End Sub))

        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             dtTable = _clsQuery.SelectDetailPhysicalIOChart(_InstanceID, stDate, edDate)
                                         Catch ex As Exception
                                             GC.Collect()
                                         End Try
                                     End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            chtCPU.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    chtCPU.MainChart.ChartAreas(index).Visible = ShowChart
                                                    For Each tmpSeries As DataVisualization.Charting.Series In chtCPU.MainChart.Series
                                                        If tmpSeries.ChartArea = chtCPU.MainChart.ChartAreas(index).Name Then
                                                            tmpSeries.Points.Clear()
                                                        End If
                                                    Next

                                                    chtCPU.SetMinimumAxisXChartArea(ConvOADate(stDate), index)
                                                    chtCPU.SetMaximumAxisXChartArea(ConvOADate(edDate), index)

                                                    If dtTable.Rows.Count > 0 Then
                                                        For i As Integer = 0 To dtTable.Rows.Count - 1
                                                            Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                            Dim strSeries = dtTable.Rows(i).Item("DISK_NAME")
                                                            For j As Integer = 0 To arrPartition.Count - 1
                                                                If strSeries = arrPartition.Item(j) Then
                                                                    Me.chtCPU.AddPoints(strSeries, tmpDate, ConvULong(dtTable.Rows(i).Item("PHY_IO")))
                                                                    Exit For
                                                                End If
                                                            Next
                                                        Next
                                                    Else
                                                        For i As Integer = 0 To dtTable.Rows.Count - 1
                                                            Dim tmpDate As Double = ConvOADate(Now())
                                                            Dim strSeries = dtTable.Rows(i).Item("DISK_NAME")
                                                            For j As Integer = 0 To arrPartition.Count - 1
                                                                If strSeries = arrPartition.Item(j) Then
                                                                    Me.chtCPU.AddPoints(strSeries, tmpDate, ConvULong(dtTable.Rows(i).Item("PHY_IO")))
                                                                    Exit For
                                                                End If
                                                            Next
                                                        Next
                                                    End If
                                                    Me.chtCPU.ShowMaxValue(True)
                                                    chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                                Catch ex As Exception
                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                    GC.Collect()
                                                End Try
                                            End Sub))
        End If

        chtCPU.Invoke(New MethodInvoker(Sub()
                                            chtCPU.SetInnerPlotPositionChartArea(index, _chtCount)
                                            chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                            ArrangeChartlayout()
                                        End Sub))
    End Sub

    Private Sub frmMonItemDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _clsQuery.CancelCommand()
        If _ThreadDetail IsNot Nothing Then
            _ThreadDetail.Abort()
            _ThreadDetail = Nothing
        End If

        RemoveHandler chtCPU.MainChart.CursorPositionChanged, AddressOf chtCPU_CursorPositionChanged

        If _AgentCn IsNot Nothing Then
            _AgentCn = Nothing
        End If
    End Sub

    Private Sub chtCPU_VisibleChanged(sender As Object, e As EventArgs) Handles chtCPU.VisibleChanged, chtSQLResp.VisibleChanged, chtSession.VisibleChanged, chtDiskIO.VisibleChanged, chtPhysicalRead.VisibleChanged, chtLogicalIO.VisibleChanged, chtLock.VisibleChanged, chtTPS.VisibleChanged
        'pnlChart.Controls.SetChildIndex(chtCPU, 5)
        'pnlChart.Controls.SetChildIndex(chtSession, 4)
        'pnlChart.Controls.SetChildIndex(chtLogicalIO, 3)
        'pnlChart.Controls.SetChildIndex(chtPhysicalIO, 2)
        'pnlChart.Controls.SetChildIndex(chtSQLResp, 1)
        'pnlChart.Controls.SetChildIndex(chtLock, 0)
        pnlChart.Controls.SetChildIndex(chtCPU, 7)
        pnlChart.Controls.SetChildIndex(chtSession, 6)
        pnlChart.Controls.SetChildIndex(chtLogicalIO, 5)
        pnlChart.Controls.SetChildIndex(chtPhysicalRead, 4)
        pnlChart.Controls.SetChildIndex(chtDiskIO, 3)
        pnlChart.Controls.SetChildIndex(chtSQLResp, 2)
        pnlChart.Controls.SetChildIndex(chtLock, 1)
        pnlChart.Controls.SetChildIndex(chtTPS, 0)
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        'check duration
        If fn_SearchBefCheck() = False Then Return

        _ProgresForm = New frmProgres()
        _ProgresForm.Owner = Me
        _ProgresForm.Location = Me.Location
        _ProgresForm.Size = Me.Size
        _ProgresForm.Show()

        For i As Integer = 1 To _AreaCount
            chtCPU.MainChart.ChartAreas(i).CursorX.SetSelectionPosition(-1, -1)
            chtCPU.MainChart.ChartAreas(i).CursorX.SetCursorPosition(-1)
        Next

        If _ThreadDetail IsNot Nothing AndAlso _ThreadDetail.IsAlive = True Then Return
        _ThreadDetail = New Threading.Thread(Sub()
                                                 Try

                                                     RaiseEvent ShowMasg()


                                                     'Case 0 : SetDefaultTitle(chkCpu, chtCPU, True, "")
                                                     'Case 1 : SetDefaultTitle(chkSession, chtSession, True, "")
                                                     'Case 2 : SetDefaultTitle(chkLogicalIO, chtLogicalIO, True, "")
                                                     'Case 3 : SetDefaultTitle(chkPhysicalRead, chtPhysicalRead, True, "")
                                                     'Case 4 : SetDefaultTitle(chkDiskIO, chtDiskIO, True, "")
                                                     'Case 5 : SetDefaultTitle(chkSQLResp, chtSQLResp, True, "")
                                                     'Case 6 : SetDefaultTitle(chkLock, chtLock, True, "")
                                                     '                                     tabSession.SelectedIndex = 2
                                                     'Case 7 : SetDefaultTitle(chkTPS, chtTPS, True, "")


                                                     Dim chkIndex As Integer = 0
                                                     For Each tmpCtl As Control In tlpButton.Controls
                                                         Dim tmpChk As BaseControls.CheckBox = DirectCast(tmpCtl, BaseControls.CheckBox)
                                                         If tmpChk.Name = "chkCpu" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(1, True)
                                                         ElseIf tmpChk.Name = "chkSession" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(2, True)
                                                         ElseIf tmpChk.Name = "chkLogicalIO" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(3, True)
                                                         ElseIf tmpChk.Name = "chkPhysicalRead" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(4, True)
                                                         ElseIf tmpChk.Name = "chkDiskIO" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(5, True)
                                                         ElseIf tmpChk.Name = "chkSQLResp" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(6, True)
                                                         ElseIf tmpChk.Name = "chkLock" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(7, True)
                                                         ElseIf tmpChk.Name = "chkTPS" AndAlso tmpChk.Checked = True Then
                                                             QueryChartData(8, True)
                                                         End If
                                                     Next
                                                     'For i As Integer = 1 To _AreaCount
                                                     '    If chtCPU.MainChart.ChartAreas(i).Visible = True Then
                                                     '        QueryChartData(i, True)
                                                     '    End If
                                                     'Next

                                                     RaiseEvent WaitMasg("Session Information")
                                                     SetDataSession(dtpSt.Value, dtpEd.Value)
                                                     RaiseEvent WaitMasg("Lock Information")
                                                     SetDataLock(dtpSt.Value, dtpEd.Value)
                                                     RaiseEvent WaitMasg("Statemets Information")
                                                     SetDataStmt(dtpSt.Value, dtpEd.Value)
                                                     RaiseEvent WaitComplete()
                                                 Catch ex As Exception
                                                     GC.Collect()
                                                 Finally
                                                 End Try
                                             End Sub)
        _ThreadDetail.Start()



        'For i As Integer = 1 To _AreaCount
        '    If chtCPU.MainChart.ChartAreas(i).Visible = True Then
        '        QueryChartData(i, True)
        '    End If
        'Next

    End Sub

    Private Sub dgvSessionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessionList.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvSessionList.RowCount <= 0 Then Return
        'If e.ColumnIndex = coldgvSessionListSQL.Index Then
        strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
        strQuery = IIf(IsDBNull(dgvSessionList.CurrentRow.Cells(coldgvSessionListSQL.Index).Value), "", dgvSessionList.CurrentRow.Cells(coldgvSessionListSQL.Index).Value)
        strUser = IIf(IsDBNull(dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value), "", dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value)
        Dim frmQuery As New frmQueryView(_AgentCn, strQuery, strDb, strUser, Me.InstanceID, Me.AgentInfo)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub


    Private Sub dgvRptSql_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRptSQL.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvRptSQL.RowCount <= 0 Then Return
        'If e.ColumnIndex = coldgvSessionListSQL.Index Then
        strDb = dgvRptSQL.CurrentRow.Cells(colDgvRptSqlDBNm.Index).Value
        strQuery = dgvRptSQL.CurrentRow.Cells(colDgvRptSqlSql.Index).Value
        strUser = IIf(IsDBNull(dgvRptSQL.CurrentRow.Cells(colDgvRptSqlUserName.Index).Value), "", dgvRptSQL.CurrentRow.Cells(colDgvRptSqlUserName.Index).Value)
        Dim frmQuery As New frmQueryView(_AgentCn, strQuery, strDb, strUser, Me.InstanceID, Me.AgentInfo)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Sub dgvLock_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLock.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvLock.RowCount <= 0 Then Return
        
        If e.ColumnIndex = colDgvLockBlockedQuery.Index Then
            strDb = IIf(IsDBNull(dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value), "", dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value)
            strUser = IIf(IsDBNull(dgvLock.CurrentRow.Cells(colDgvLockBlockedUser.Index).Value), "", dgvLock.CurrentRow.Cells(colDgvLockBlockedUser.Index).Value)
            strQuery = IIf(IsDBNull(dgvLock.CurrentCell.Value), "", dgvLock.CurrentCell.Value)
        Else
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strUser = IIf(IsDBNull(dgvLock.CurrentRow.Cells(colDgvLockBlockingUser.Index).Value), "", dgvLock.CurrentRow.Cells(colDgvLockBlockingUser.Index).Value)
            strQuery = IIf(IsDBNull(dgvLock.CurrentRow.Cells(colDgvLockBlockingQuery.Index).Value), "", dgvLock.CurrentRow.Cells(colDgvLockBlockingQuery.Index).Value)
        End If
        Dim frmQuery As New frmQueryView(_AgentCn, strQuery, strDb, strUser, Me.InstanceID, Me.AgentInfo)
        frmQuery.ShowDialog(Me)
    End Sub

    Private Sub dgvStmtList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStmtList.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvStmtList.RowCount <= 0 Then Return
        strDb = dgvStmtList.CurrentRow.Cells(coldgvStmtListDB.Index).Value
        strQuery = IIf(IsDBNull(dgvStmtList.CurrentRow.Cells(coldgvStmtListQuery.Index).Value), "", dgvStmtList.CurrentRow.Cells(coldgvStmtListQuery.Index).Value)
        strUser = IIf(IsDBNull(dgvStmtList.CurrentRow.Cells(coldgvStmtListUser.Index).Value), "", dgvStmtList.CurrentRow.Cells(coldgvStmtListUser.Index).Value)
        Dim frmQuery As New frmQueryView(_AgentCn, strQuery, strDb, strUser, Me.InstanceID, Me.AgentInfo)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Function fn_SearchBefCheck() As Boolean
        If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return False
        Else
            If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) > 241 Then
                MsgBox(p_clsMsgData.fn_GetData("M063", 4))
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub cmbInst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInst.SelectedIndexChanged
        _InstanceID = cmbInst.SelectedValue
        'Me.Invoke(New MethodInvoker(Sub()
        '                                btnQuery.PerformClick()
        '                            End Sub))
    End Sub

    Private Sub dtpSt_ValueChanged(sender As Object, e As EventArgs) Handles dtpSt.ValueChanged
        'If cmbDuration.Visible = True Then 'DDDD
        '    Dim tempDt As Date = Now
        '    If cmbDuration.SelectedIndex = 0 Then
        '        tempDt = dtpSt.Value.AddMinutes(10)
        '        If tempDt > Now Then
        '            tempDt = Now
        '        End If
        '        dtpEd.Value = tempDt
        '    ElseIf cmbDuration.SelectedIndex = 1 Then
        '        tempDt = dtpSt.Value.AddMinutes(30)
        '        If tempDt > Now Then
        '            tempDt = Now
        '        End If
        '        dtpEd.Value = tempDt
        '    ElseIf cmbDuration.SelectedIndex = 2 Then
        '        tempDt = dtpSt.Value.AddMinutes(60)
        '        If tempDt > Now Then
        '            tempDt = Now
        '        End If
        '        dtpEd.Value = tempDt
        '    Else
        '    End If
        'End If
    End Sub

    'Private Sub cmbDuration_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDuration.SelectedIndexChanged 'DDDD
    '    Dim intSelectedIndex As Integer = DirectCast(sender, BaseControls.ComboBox).SelectedIndex
    '    Dim tempDt As Date = Now
    '    Select Case intSelectedIndex
    '        Case 0
    '            tempDt = dtpSt.Value.AddMinutes(10)
    '        Case 1
    '            tempDt = dtpSt.Value.AddMinutes(30)
    '        Case 2
    '            tempDt = dtpSt.Value.AddMinutes(60)
    '    End Select
    '    dtpEd.Value = tempDt
    'End Sub


    Private Sub frmMonItemDetail_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If _chtCount > 0 Then
            For i As Integer = 1 To _AreaCount
                chtCPU.SetInnerPlotXPositionChartArea(i, _chtCount)
                chtCPU.MainChart.ChartAreas(i).RecalculateAxesScale()
            Next
        End If
    End Sub

    Private Sub frmMonItemDetail_WaitComplete() Handles Me.WaitComplete
        If _ProgresForm IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            _ProgresForm.Close()
                                        End Sub))
        End If
    End Sub

    Private Sub frmMonItemDetail_WaitMasg(str As String) Handles Me.WaitMasg
        If _ProgresForm IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            _ProgresForm.Addtext(str)
                                        End Sub))
        End If
    End Sub

    Private Sub frmMonItemDetail_ShowMasg() Handles Me.ShowMasg
        If _ProgresForm IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            _ProgresForm.Show()
                                        End Sub))
        End If
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        If _ThreadDetail IsNot Nothing Then
            _clsQuery.CancelCommand()
            _ThreadDetail.Abort()
            _ThreadDetail = Nothing
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub rb1H_Click(sender As Object, e As EventArgs) Handles rb1H.Click, rb2H.Click, rb4H.Click
        Dim Rb As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If Rb.Checked = True Then
            dtpEd.Value = DateTime.Now
            If Rb.Text.Equals("~1H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-1)
            ElseIf Rb.Text.Equals("~2H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-2)
            ElseIf Rb.Text.Equals("~4H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-4)
            End If
        End If
        btnQuery.PerformClick()
    End Sub

    Private Sub chtCPU_CursorPositionChanged(sender As Object, e As DataVisualization.Charting.CursorEventArgs)

        Dim stDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionStart)
        Dim edDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionEnd)
        If stDt > edDt Then
            Dim tmpDt As DateTime
            tmpDt = stDt
            stDt = edDt
            edDt = tmpDt
        End If

        For i As Integer = 1 To _AreaCount
            chtCPU.MainChart.ChartAreas(i).CursorX.SetSelectionPosition(e.ChartArea.CursorX.SelectionStart, e.ChartArea.CursorX.SelectionEnd)
            chtCPU.MainChart.ChartAreas(i).CursorX.SetCursorPosition(e.ChartArea.CursorX.SelectionStart)
        Next

        SetDataSession(stDt, edDt)
        SetDataLock(stDt, edDt)
        SetDataStmt(stDt, edDt)
    End Sub

    Private Sub ReadConfig()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        _UseFilter = clsIni.ReadValue("STATSTATEMENTS", "UseFilter", False)

        Dim StatementFilters As String() = clsIni.ReadValue("STATSTATEMENTS", "StatementFilters", "pg_catalog").Split(New Char() {","c})

        Dim StatementFilter As String
        For Each StatementFilter In StatementFilters
            If Not StatementFilter.Equals("") Then
                _ListStatements.Add(StatementFilter)
            End If
        Next
    End Sub

    Private Sub SetRowfilter()
        Try
            Dim dt As DataTable
            If _UseFilter = True Then
                'Dim rowFilter As String = String.Format("Convert([{0}], System.String) NOT LIKE '%{1}%'", coldgvStmtQuery.HeaderText, "application_name")
                Dim rowFilter As String = ""
                Dim rowFilterList As String = ""
                For Each StatementFilter In _ListStatements
                    rowFilterList += String.Format("AND Convert([{0}], System.String) NOT LIKE '%{1}%' ", coldgvStmtListQuery.HeaderText, StatementFilter)
                Next
                rowFilter = String.Format("Convert([{0}], System.String) <> '----' {1}", coldgvStmtListQuery.HeaderText, rowFilterList)
                'dt = dgvStmtList.DataSource.DataSource
                'dt.DefaultView.RowFilter = rowFilter
                Dim data As IBindingListView = TryCast(Me.dgvStmtList.DataSource, IBindingListView)
                data.Filter = rowFilter
            Else
                dt = dgvStmtList.DataSource
                dt.DefaultView.RowFilter = Nothing
            End If

            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            clsIni.WriteValue("STATSTATEMENTS", "UseFilter", True)

        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub
End Class
