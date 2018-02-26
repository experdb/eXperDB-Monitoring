Public Class frmMonItemDetail

    Private _InstanceID As Integer = -1
    Private _SelectedIndex As String
    Private _SelectedGrid As String
    Private _chtOrder As Integer = -1
    Private _clsQuery As clsQuerys

    Private _ThreadDetail As Threading.Thread



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
    Private _AgentCn As eXperDB.ODBC.DXODBC

    ReadOnly Property AgentCn As DXODBC
        Get
            Return _AgentCn
        End Get
    End Property

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.DXODBC, ByVal ServerInfo As List(Of GroupInfo.ServerInfo), ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, ByVal AgentInfo As structAgent, ByVal chtOrder As Integer)
        'Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = intInstanceID
        _SvrpList = ServerInfo
        _AgentInfo = AgentInfo
        _AgentCn = AgentCn
        _chtOrder = chtOrder
        _clsQuery = New clsQuerys(_AgentCn)
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            If tmpSvr.InstanceID = _InstanceID Then
                _ServerInfo = tmpSvr
            End If
            cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
        Next
        dtpSt.Value = stDt.AddMinutes(-1)
        dtpEd.Value = edDt.AddMinutes(1)
        dtpSt.Tag = stDt
        dtpEd.Tag = edDt

    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmMonItemDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
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
        InitCharts()
        SetDataSession()
    End Sub

    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'label & Input
        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        grpChart.Text = p_clsMsgData.fn_GetData("F268")

        ' Checkbox Button
        chkCpu.Text = p_clsMsgData.fn_GetData("F035")
        chkSession.Text = p_clsMsgData.fn_GetData("F047")
        chkLogicalIO.Text = p_clsMsgData.fn_GetData("F101")
        chkPhysicalIO.Text = p_clsMsgData.fn_GetData("F100")
        chkSQLResp.Text = p_clsMsgData.fn_GetData("F267")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information

        grpSession.Text = p_clsMsgData.fn_GetData("F313", 0)
        dgvSessionList.AutoGenerateColumns = False
        coldgvSessionListDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvSessionListPID.HeaderText = p_clsMsgData.fn_GetData("F082")
        coldgvSessionListCpuUsage.HeaderText = p_clsMsgData.fn_GetData("F092")
        coldgvSessionListStTime.HeaderText = p_clsMsgData.fn_GetData("F050")
        coldgvSessionListElapsedTime.HeaderText = p_clsMsgData.fn_GetData("F051")
        coldgvSessionListUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        coldgvSessionListClient.HeaderText = p_clsMsgData.fn_GetData("F248")
        coldgvSessionListApp.HeaderText = p_clsMsgData.fn_GetData("F249")
        coldgvSessionListSQL.HeaderText = p_clsMsgData.fn_GetData("F052")

        grpSessionLock.Text = p_clsMsgData.fn_GetData("F246")

        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseRotationBox = False
        Me.FormControlBox1.UsePowerBox = False

        chtCPU.Visible = False
        chtSession.Visible = False
        chtLogicalIO.Visible = False
        chtPhysicalIO.Visible = False
        chtSQLResp.Visible = False

        modCommon.FontChange(Me, p_Font)
    End Sub
    ''' <summary>
    ''' Lock info 변경 되었을 경우 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub SetDataLockinfo(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 
        'Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView

        ' dgvLock.DataSource = dtView
        'If btnPause.Text = "4" Then Return

        'Dim topRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND BLOCKED_PID IS NULL", Me.InstanceID), "ORDER_NO ASC")
        Dim Dgv As AdvancedDataGridView.TreeGridView = dgvLock
        Dgv.Nodes.Clear()
        Dim intLockCount As Integer = 0
        Dim HashTbl As New Hashtable
        For Each tmpCol As DataGridViewColumn In Dgv.Columns

            If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) Then
                HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
            End If
        Next

        Dim dtView As DataView = dtTable.AsEnumerable.Where(Function(r) r.Item("INSTANCE_ID") = Me.InstanceID).AsDataView
        For Each tmpRow As DataRow In dtView.ToTable.Select("BLOCKED_PID IS NULL", "ORDER_NO ASC")
            Dim topNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("DB_NAME"))
            sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)
            intLockCount += 1
            For Each tmpChild As DataRow In dtView.Table.Select(String.Format("BLOCKED_PID IS NOT NULL AND BLOCKING_PID = {0}", tmpRow.Item("BLOCKING_PID")), "ORDER_NO ASC")
                Dim cNOde As AdvancedDataGridView.TreeGridNode = topNode.Nodes.Add(tmpChild.Item("DB_NAME"))
                sb_AddTreeGridDatas(cNOde, HashTbl, tmpChild)

            Next
            topNode.Expand()
            topNode.Cells(0).Value = tmpRow.Item("DB_NAME") & " (" & topNode.Nodes.Count & ")"

        Next

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
    Public Sub SetDataSession()

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectDetailSQLListChart(_InstanceID, p_ShowName.ToString("d"), dtpSt.Value, dtpEd.Value)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Dim strQuery As String = ""

                                                strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)

                                                Dim dtView As DataView = New DataView(dtTable, strQuery, "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

                                                Dim ShowDT As DataTable = Nothing
                                                If dtView.Count > 0 Then
                                                    ShowDT = dtView.ToTable.AsEnumerable.Take(100).CopyToDataTable
                                                End If

                                                If ShowDT Is Nothing Then
                                                    dgvSessionList.DataSource = Nothing
                                                    Return
                                                End If

                                                dgvSessionList.DataSource = ShowDT

                                                modCommon.sb_GridSortChg(dgvSessionList)
                                                'dgvSessionList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If




        'Dim strQuery As String = ""

        'strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)
        ''strQuery = String.Format("INSTANCE_ID = {0}", Me.InstanceID)

        'Dim dtView As DataView = New DataView(dtTable, strQuery, "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

        'Dim ShowDT As DataTable = Nothing
        'If dtView.Count > 0 Then
        '    ShowDT = dtView.ToTable.AsEnumerable.Take(100).CopyToDataTable
        'End If

        'If ShowDT Is Nothing Then
        '    dgvSessionList.DataSource = Nothing
        '    Return
        'End If

        'dgvSessionList.DataSource = ShowDT

        'grpSession.Text = p_clsMsgData.fn_GetData("F313", dtView.Count)
        'modCommon.sb_GridSortChg(dgvSessionList)
        ''dgvSessionList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)

    End Sub

    Private Sub dgvIdxinfo_CellErrorTextNeeded(sender As Object, e As DataGridViewCellErrorTextNeededEventArgs)
        If e.ErrorText <> "" Then

        End If

    End Sub

    Private Sub dgvLock_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLock.CellContentDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvLock.RowCount <= 0 Then Return
        _Selectedindex = dgvLock.CurrentRow.Cells(colDgvLockBlockingPID.Index).Value
        _SelectedGrid = 1
        If e.ColumnIndex = colDgvLockBlockedQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockedUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        ElseIf e.ColumnIndex = colDgvLockBlockingQuery.Index Then
            strDb = dgvLock.CurrentRow.Cells(colDgvLockDB.Index).Value
            strQuery = dgvLock.CurrentCell.Value
            strUser = dgvLock.CurrentRow.Cells(colDgvLockBlockingUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgvLock_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvLock.CellMouseClick
        If dgvLock.RowCount <= 0 Then Return
        For i As Integer = 0 To dgvSessionList.Rows.Count - 1
            dgvSessionList.Rows(i).Selected = False
        Next

        _SelectedIndex = dgvLock.CurrentRow.Cells(colDgvLockBlockingPID.Index).Value
        _SelectedGrid = 1
        If e.RowIndex >= 0 Then
            dgvLock.Cursor = Cursors.Hand
            If dgvLock.Rows(e.RowIndex).Selected = False Then
                dgvLock.ClearSelection()
                dgvLock.Rows(e.RowIndex).Selected = True
            End If
            For i As Integer = 0 To dgvLock.ColumnCount - 1
                dgvLock.Rows(e.RowIndex).Cells(i).Style.SelectionBackColor = Color.FromArgb(0, 30, 60)
            Next
        End If
    End Sub


    Private Sub dgvSessionList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvSessionList.RowCount <= 0 Then Return
        _SelectedIndex = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
        _SelectedGrid = 0
        If e.ColumnIndex = coldgvSessionListSQL.Index Then
            strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
            strQuery = dgvSessionList.CurrentCell.Value
            strUser = dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value
            Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
            frmQuery.ShowDialog(Me)
        End If
    End Sub

    Private Sub dgvSessionList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        If dgvSessionList.RowCount <= 0 Then Return
        For i As Integer = 0 To dgvLock.Rows.Count - 1
            dgvLock.Rows(i).Selected = False
        Next
        _SelectedIndex = dgvSessionList.CurrentRow.Cells(coldgvSessionListPID.Index).Value
        _SelectedGrid = 0
        If e.RowIndex >= 0 Then
            dgvSessionList.Cursor = Cursors.Hand
            If dgvSessionList.Rows(e.RowIndex).Selected = False Then
                dgvSessionList.ClearSelection()
                dgvSessionList.Rows(e.RowIndex).Selected = True
            End If
            For i As Integer = 0 To dgvSessionList.ColumnCount - 1
                dgvSessionList.Rows(e.RowIndex).Cells(i).Style.SelectionBackColor = Color.FromArgb(0, 30, 60)
            Next
        End If
    End Sub
    Private Sub InitCharts()

        chkCpu.Tag = 0
        chkSession.Tag = 1
        chkLogicalIO.Tag = 2
        chkPhysicalIO.Tag = 3
        chkSQLResp.Tag = 4

        SetDefaultTitle(chkCpu, chtCPU, False, "")
        SetDefaultTitle(chkSession, chtSession, False, "")
        SetDefaultTitle(chkLogicalIO, chtLogicalIO, False, "")
        SetDefaultTitle(chkPhysicalIO, chtPhysicalIO, False, "")
        SetDefaultTitle(chkSQLResp, chtSQLResp, False, "")

        If _chtOrder >= 0 Then
            Select Case _chtOrder
                Case 0 : SetDefaultTitle(chkCpu, chtCPU, True, "")
                Case 1 : SetDefaultTitle(chkSession, chtSession, True, "")
                Case 2 : SetDefaultTitle(chkLogicalIO, chtLogicalIO, True, "")
                Case 3 : SetDefaultTitle(chkPhysicalIO, chtPhysicalIO, True, "")
                Case 4 : SetDefaultTitle(chkSQLResp, chtSQLResp, True, "")
            End Select
        End If
    End Sub
    Private Sub SetDefaultTitle(ByRef chkBox As eXperDB.BaseControls.CheckBox, ByRef chart As eXperDB.Monitoring.ctlChart, ByVal chtEnable As Boolean, ByVal chtTitle As String)
        chkBox.Checked = chtEnable
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkSQLResp.CheckedChanged, chkSession.CheckedChanged, chkPhysicalIO.CheckedChanged, chkLogicalIO.CheckedChanged, chkCpu.CheckedChanged
        Dim CheckBox As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)

        Select Case CheckBox.Tag
            Case 0
                Me.chtCPU.Visible = True
                _ThreadDetail = New Threading.Thread(Sub()

                                                         ShowCpuChart(dtpSt.Value, dtpEd.Value, CheckBox.Checked)
                                                     End Sub)
            Case 1
                Me.chtSession.Visible = True
                _ThreadDetail = New Threading.Thread(Sub()
                                                         ShowSessionChart(dtpSt.Value, dtpEd.Value, CheckBox.Checked)
                                                     End Sub)
            Case 2
                Me.chtLogicalIO.Visible = True
                _ThreadDetail = New Threading.Thread(Sub()
                                                         ShowLogicalIOChart(dtpSt.Value, dtpEd.Value, CheckBox.Checked)
                                                     End Sub)
            Case 3
                Me.chtPhysicalIO.Visible = True
                _ThreadDetail = New Threading.Thread(Sub()
                                                         ShowPhysicalIOChart(dtpSt.Value, dtpEd.Value, CheckBox.Checked)
                                                     End Sub)
            Case 4
                Me.chtSQLResp.Visible = True
                _ThreadDetail = New Threading.Thread(Sub()
                                                         ShowSQLRespChart(dtpSt.Value, dtpEd.Value, CheckBox.Checked)
                                                     End Sub)
        End Select

        _ThreadDetail.Start()
    End Sub
    Private Sub ShowCpuChart(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strUsed As String = "USED"
        Dim strWait As String = "WAIT"

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Me.chtCPU.Clear()
                                                Me.chtCPU.Visible = False
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))
            Return
        End If
        ' Chart CPU 
        Me.Invoke(New MethodInvoker(Sub()
                                        If chtCPU.GetSeries(strUsed) = False Then
                                            chtCPU.AddSeries(strUsed, strUsed, Color.Lime, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If
                                        If chtCPU.GetSeries(strWait) = False Then
                                            chtCPU.AddSeries(strWait, strWait, Color.Yellow, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If

                                        Me.chtCPU.SetAxisXTitle("CPU USAGE")
                                        Me.chtCPU.SetAxisYTitle("RATE(%)")
                                        'Me.chtCPU.SetDefaultMean("USED")
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectReportCPUChart(_InstanceID, stDate, edDate)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                For Each tmpSeries As DataVisualization.Charting.Series In chtCPU.MainChart.Series
                                                    tmpSeries.Points.Clear()
                                                Next
                                                chtCPU.SetMinimumAxisX(ConvOADate(stDate))
                                                chtCPU.SetMaximumAxisX(ConvOADate(edDate))
                                                For i As Integer = 0 To dtTable.Rows.Count - 1
                                                    Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                    Me.chtCPU.AddPoints(strUsed, tmpDate, ConvULong(dtTable.Rows(i).Item("USED_UTIL_RATE")))
                                                    Me.chtCPU.AddPoints(strWait, tmpDate, ConvULong(dtTable.Rows(i).Item("WAIT_UTIL_RATE")))
                                                Next
                                                Me.chtCPU.ShowMaxValue(True)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtCPU.SetInnerPlotPosition()
                                        chtCPU.MainChart.ChartAreas(0).RecalculateAxesScale()
                                    End Sub))

    End Sub
    Private Sub ShowSessionChart(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strTotal As String = "BACKENDTOT"
        Dim strActive As String = "BACKENDACT"

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Me.chtSession.Clear()
                                                Me.chtSession.Visible = False
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))
            Return
        End If
        ' Chart CPU 
        Me.Invoke(New MethodInvoker(Sub()
                                        If chtSession.GetSeries(strTotal) = False Then
                                            chtSession.AddSeries(strTotal, strTotal, Color.Yellow, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If
                                        If chtSession.GetSeries(strActive) = False Then
                                            chtSession.AddSeries(strActive, strActive, Color.Lime, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If

                                        Me.chtSession.SetAxisXTitle("Session")
                                        Me.chtSession.SetAxisYTitle("Count")
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectInitSessionInfoChart(_InstanceID, stDate, edDate, True)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                For Each tmpSeries As DataVisualization.Charting.Series In chtSession.MainChart.Series
                                                    tmpSeries.Points.Clear()
                                                Next
                                                chtSession.SetMinimumAxisX(ConvOADate(stDate))
                                                chtSession.SetMaximumAxisX(ConvOADate(edDate))

                                                For i As Integer = 0 To dtTable.Rows.Count - 1
                                                    Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                    Me.chtSession.AddPoints(strTotal, tmpDate, ConvULong(dtTable.Rows(i).Item("TOT_BACKEND_CNT")))
                                                    Me.chtSession.AddPoints(strActive, tmpDate, ConvULong(dtTable.Rows(i).Item("CUR_ACTV_BACKEND_CNT")))
                                                Next
                                                Me.chtSession.ShowMaxValue(True)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtSession.SetInnerPlotPosition()
                                        chtSession.MainChart.ChartAreas(0).RecalculateAxesScale()
                                    End Sub))

    End Sub
    Private Sub ShowLogicalIOChart(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strRead As String = "Read"
        Dim strInsert As String = "Insert"
        Dim strUpdate As String = "Update"
        Dim strDelete As String = "Delete"

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Me.chtLogicalIO.Clear()
                                                Me.chtLogicalIO.Visible = False
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))
            Return
        End If
        ' Chart CPU 
        Me.Invoke(New MethodInvoker(Sub()
                                        If chtLogicalIO.GetSeries(strRead) = False Then
                                            chtLogicalIO.AddSeries(strRead, strRead, Color.Lime, YAxisType:=DataVisualization.Charting.AxisType.Secondary)
                                            chtLogicalIO.SetAxisY2(Color.Lime)
                                        End If
                                        If chtLogicalIO.GetSeries(strInsert) = False Then
                                            chtLogicalIO.AddSeries(strInsert, strInsert, Color.Blue)
                                        End If
                                        If chtLogicalIO.GetSeries(strUpdate) = False Then
                                            chtLogicalIO.AddSeries(strUpdate, strUpdate, Color.Orange)
                                        End If
                                        If chtLogicalIO.GetSeries(strDelete) = False Then
                                            chtLogicalIO.AddSeries(strDelete, strDelete, Color.Red)
                                        End If

                                        Me.chtLogicalIO.SetAxisXTitle(p_clsMsgData.fn_GetData("F040"))
                                        Me.chtLogicalIO.SetAxisYTitle("TUPLES/sec")
                                        Me.chtLogicalIO.AutoGridYSpacing()
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectInitObjectChart(_InstanceID, p_ShowName.ToString("d"), stDate, edDate, True)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                chtLogicalIO.SetMinimumAxisX(ConvOADate(stDate))
                                                chtLogicalIO.SetMaximumAxisX(ConvOADate(edDate))

                                                For i As Integer = 0 To dtTable.Rows.Count - 1
                                                    Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                    Me.chtLogicalIO.AddPoints(strRead, tmpDate, ConvULong(dtTable.Rows(i).Item("SELECT_TUPLES_PER_SEC")))
                                                    Me.chtLogicalIO.AddPoints(strInsert, tmpDate, ConvULong(dtTable.Rows(i).Item("INSERT_TUPLES_PER_SEC")))
                                                    Me.chtLogicalIO.AddPoints(strUpdate, tmpDate, ConvULong(dtTable.Rows(i).Item("UPDATE_TUPLES_PER_SEC")))
                                                    Me.chtLogicalIO.AddPoints(strDelete, tmpDate, ConvULong(dtTable.Rows(i).Item("DELETE_TUPLES_PER_SEC")))
                                                Next
                                                Me.chtLogicalIO.ShowMaxValue(True)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtLogicalIO.SetInnerPlotPosition()
                                        chtLogicalIO.MainChart.ChartAreas(0).RecalculateAxesScale()
                                    End Sub))
    End Sub
    Private Sub ShowPhysicalIOChart(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strUsed As String = "USED"
        Dim strWait As String = "WAIT"

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Me.chtPhysicalIO.Clear()
                                                Me.chtPhysicalIO.Visible = False
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))
            Return
        End If
        ' Chart CPU 
        Me.Invoke(New MethodInvoker(Sub()
                                        If chtPhysicalIO.GetSeries(strUsed) = False Then
                                            chtPhysicalIO.AddSeries(strUsed, strUsed, Color.Lime, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If
                                        If chtPhysicalIO.GetSeries(strWait) = False Then
                                            chtPhysicalIO.AddSeries(strWait, strWait, Color.Yellow, DataVisualization.Charting.SeriesChartType.SplineArea)
                                        End If

                                        Me.chtPhysicalIO.SetAxisXTitle("Physical I/O")
                                        Me.chtPhysicalIO.SetAxisYTitle("BUSY(%)")
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectReportCPUChart(_InstanceID, stDate, edDate)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                For Each tmpSeries As DataVisualization.Charting.Series In chtPhysicalIO.MainChart.Series
                                                    tmpSeries.Points.Clear()
                                                Next
                                                chtPhysicalIO.SetMinimumAxisX(ConvOADate(stDate))
                                                chtPhysicalIO.SetMaximumAxisX(ConvOADate(edDate))
                                                For i As Integer = 0 To dtTable.Rows.Count - 1
                                                    Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                    Me.chtPhysicalIO.AddPoints(strUsed, tmpDate, ConvULong(dtTable.Rows(i).Item("USED_UTIL_RATE")))
                                                    Me.chtPhysicalIO.AddPoints(strWait, tmpDate, ConvULong(dtTable.Rows(i).Item("WAIT_UTIL_RATE")))
                                                Next
                                                Me.chtPhysicalIO.ShowMaxValue(True)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtPhysicalIO.SetInnerPlotPosition()
                                        chtPhysicalIO.MainChart.ChartAreas(0).RecalculateAxesScale()
                                    End Sub))
    End Sub
    Private Sub ShowSQLRespChart(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim strTime As String = p_clsMsgData.fn_GetData("F103")

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Me.chtSQLResp.Clear()
                                                Me.chtSQLResp.Visible = False
                                            Catch ex As Exception
                                                GC.Collect()
                                            End Try
                                        End Sub))
            Return
        End If
        ' Chart CPU 
        Me.Invoke(New MethodInvoker(Sub()
                                        If chtSQLResp.GetSeries(strTime) = False Then
                                            chtSQLResp.AddSeries(strTime, strTime, Color.Lime, DataVisualization.Charting.SeriesChartType.Point)
                                        End If

                                        Me.chtSQLResp.SetAxisXTitle(p_clsMsgData.fn_GetData("F103"))
                                        Me.chtSQLResp.SetAxisYTitle("SEC")
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     dtTable = _clsQuery.SelectDetailSQLRespChart(_InstanceID, stDate, edDate)
                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                chtSQLResp.SetMinimumAxisX(ConvOADate(stDate))
                                                chtSQLResp.SetMaximumAxisX(ConvOADate(edDate))

                                                For i As Integer = 0 To dtTable.Rows.Count - 1
                                                    Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DT"))
                                                    Me.chtSQLResp.AddPoints(strTime, tmpDate, ConvULong(dtTable.Rows(i).Item("SQL_ELAPSED_SEC")))
                                                Next
                                                Me.chtSQLResp.ShowMaxValue(True)
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtSQLResp.SetInnerPlotPosition()
                                        chtSQLResp.MainChart.ChartAreas(0).RecalculateAxesScale()
                                    End Sub))
    End Sub

    Private Sub frmMonItemDetail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _clsQuery.CancelCommand()
        If _ThreadDetail IsNot Nothing Then
            _ThreadDetail.Abort()
            _ThreadDetail = Nothing
        End If
    End Sub

    Private Sub chtCPU_VisibleChanged(sender As Object, e As EventArgs) Handles chtCPU.VisibleChanged, chtSQLResp.VisibleChanged, chtSession.VisibleChanged, chtPhysicalIO.VisibleChanged, chtLogicalIO.VisibleChanged
        pnlChart.Controls.SetChildIndex(chtCPU, 4)
        pnlChart.Controls.SetChildIndex(chtSession, 3)
        pnlChart.Controls.SetChildIndex(chtLogicalIO, 2)
        pnlChart.Controls.SetChildIndex(chtPhysicalIO, 1)
        pnlChart.Controls.SetChildIndex(chtSQLResp, 0)
    End Sub
End Class
