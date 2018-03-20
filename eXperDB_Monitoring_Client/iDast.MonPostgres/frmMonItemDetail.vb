Public Class frmMonItemDetail

    Private _InstanceID As Integer = -1
    Private _SelectedIndex As String
    Private _SelectedGrid As String
    Private _chtOrder As Integer = -1
    Private _AreaCount As Integer = 5
    Private _chtCount As Integer = 0
    Private _chtHeight As Integer
    Private _clsQuery As clsQuerys
    Private _bChartMenu As Boolean = False
    Private _bRange As Boolean = False
    Private _annotationIndex As Integer = -1

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

        If _chtOrder >= 0 Then
            dtpSt.Visible = False
            dtpEd.Visible = False
            lblSt.Visible = True
            lblEd.Visible = True
            lblSt.Text = dtpSt.Value.ToString("yyyy-MM-dd HH:mm:ss")
            lblEd.Text = dtpEd.Value.ToString("yyyy-MM-dd HH:mm:ss")
            cmbDuration.Visible = False
        Else
            _chtOrder = 0
            dtpSt.Visible = True
            dtpEd.Visible = False
            lblSt.Visible = False
            lblEd.Visible = False
            cmbDuration.Visible = True
            cmbDuration.SelectedIndex = 0
        End If

        InitForm()
        InitCharts()
    End Sub

    Delegate Sub InvokeDelegate()


    Public Sub InvokeMethod()
        If _chtOrder >= 0 Then
            Select Case _chtOrder
                Case 0 : SetDefaultTitle(chkCpu, chtCPU, True, "")
                Case 1 : SetDefaultTitle(chkSession, chtSession, True, "")
                Case 2 : SetDefaultTitle(chkLogicalIO, chtLogicalIO, True, "")
                Case 3 : SetDefaultTitle(chkPhysicalIO, chtPhysicalIO, True, "")
                Case 4 : SetDefaultTitle(chkSQLResp, chtSQLResp, True, "")
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
        SetDataSession(dtpSt.Value, dtpEd.Value)
        BeginInvoke(New InvokeDelegate(AddressOf InvokeMethod))
    End Sub

    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        'FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        Me.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        lblSubject.Text = "Chart Detail"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'label & Input
        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        lblChart.Text = p_clsMsgData.fn_GetData("F268")

        ' Checkbox Button
        chkCpu.Text = p_clsMsgData.fn_GetData("F035")
        chkSession.Text = p_clsMsgData.fn_GetData("F047")
        chkLogicalIO.Text = p_clsMsgData.fn_GetData("F101")
        chkPhysicalIO.Text = p_clsMsgData.fn_GetData("F100")
        chkSQLResp.Text = p_clsMsgData.fn_GetData("F267")

        ' Button 
        btnQuery.Text = p_clsMsgData.fn_GetData("F151")
        btnRange.Text = p_clsMsgData.fn_GetData("F269", "Off")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information

        lslSession.Text = p_clsMsgData.fn_GetData("F313", 0)
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

        dgvSessionList.DefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)
        dgvSessionList.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Gulim", 9.0!)

        chtCPU.Visible = False
        chtSession.Visible = False
        chtLogicalIO.Visible = False
        chtPhysicalIO.Visible = False
        chtSQLResp.Visible = False

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
                                                                     dtTable = _clsQuery.SelectDetailSQLListChart(_InstanceID, p_ShowName.ToString("d"), starDt, endDt)
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
                                                    ShowDT = dtView.ToTable.AsEnumerable.Take(200).CopyToDataTable
                                                End If

                                                If ShowDT Is Nothing Then
                                                    dgvSessionList.DataSource = Nothing
                                                    Return
                                                End If

                                                dgvSessionList.DataSource = ShowDT

                                                modCommon.sb_GridSortChg(dgvSessionList)
                                                lslSession.Text = p_clsMsgData.fn_GetData("F313", dtView.Count)
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

    Private Sub InitCharts()

        chkCpu.Tag = 0
        chkSession.Tag = 1
        chkLogicalIO.Tag = 2
        chkPhysicalIO.Tag = 3
        chkSQLResp.Tag = 4

        _chtHeight = chtCPU.Height + 30

        SetDefaultTitle(chkCpu, chtCPU, False, "")
        SetDefaultTitle(chkSession, chtSession, False, "")
        SetDefaultTitle(chkLogicalIO, chtLogicalIO, False, "")
        SetDefaultTitle(chkPhysicalIO, chtPhysicalIO, False, "")
        SetDefaultTitle(chkSQLResp, chtSQLResp, False, "")

        chtCPU.MainChart.ChartAreas(0).Visible = False
        chtCPU.AddAreaEx("CPU USAGE", "RATE(%)", True, "CPUAREA")
        chtCPU.AddAreaEx("Session", "Count", True, "SESSIONAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F040"), "TUPLES/sec", True, "LOGICALAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F100"), "BUSY(%)", True, "PHYSICALAREA")
        chtCPU.AddAreaEx(p_clsMsgData.fn_GetData("F103"), "SEC", True, "SQLRESPAREA")

        chtCPU.MainChart.ChartAreas("CPUAREA").Visible = False
        chtCPU.MainChart.ChartAreas("SESSIONAREA").Visible = False
        chtCPU.MainChart.ChartAreas("LOGICALAREA").Visible = False
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").Visible = False
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").Visible = False

        Me.chtCPU.Visible = True

        'chtCPU.MainChart.ChartAreas("CPUAREA").AxisX.ScaleView.Zoomable = False
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserEnabled = True
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorX.IsUserSelectionEnabled = True
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorY.IsUserEnabled = False
        'chtCPU.MainChart.ChartAreas("CPUAREA").CursorY.IsUserSelectionEnabled = False

        'chtCPU.MainChart.ChartAreas("SESSIONAREA").AxisX.ScaleView.Zoomable = False
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        'chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IsUserEnabled = True
        'chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorX.IsUserSelectionEnabled = True
        'chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorY.IsUserEnabled = False
        'chtCPU.MainChart.ChartAreas("SESSIONAREA").CursorY.IsUserSelectionEnabled = False

        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("LOGICALAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds

        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("PHYSICALAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds

        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IntervalType = DataVisualization.Charting.DateTimeIntervalType.Seconds
        chtCPU.MainChart.ChartAreas("SQLRESPAREA").CursorX.IntervalOffsetType = DataVisualization.Charting.DateTimeIntervalType.Seconds

    End Sub
    Private Sub SetDefaultTitle(ByRef chkBox As eXperDB.BaseControls.CheckBox, ByRef chart As eXperDB.Monitoring.ctlChartEx, ByVal chtEnable As Boolean, ByVal chtTitle As String)
        chkBox.Checked = chtEnable
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkSQLResp.CheckedChanged, chkSession.CheckedChanged, chkPhysicalIO.CheckedChanged, chkLogicalIO.CheckedChanged, chkCpu.CheckedChanged

        Dim CheckBox As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)

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

        If CheckBox.Checked = False Then
            If _annotationIndex = CheckBox.Tag + 1 Then
                fn_DeleteAnnotaion()
                SetDataSession(dtpSt.Value, dtpEd.Value)
            End If
        End If

        QueryChartData(CheckBox.Tag + 1, CheckBox.Checked)
    End Sub
    Private Sub QueryChartData(ByVal index As Integer, ByVal enable As Boolean)

        If fn_SearchBefCheck() = False Then Return

        If index = 4 Then
            _ThreadDetail = New Threading.Thread(Sub()
                                                     Threading.Thread.Sleep(50)
                                                     ShowPhysicalIOChart(index, dtpSt.Value, dtpEd.Value, enable)
                                                 End Sub)
        Else
            _ThreadDetail = New Threading.Thread(Sub()
                                                     Threading.Thread.Sleep(50)
                                                     ShowDynamicChart(index, dtpSt.Value, dtpEd.Value, enable)
                                                 End Sub)
        End If

        _ThreadDetail.Start()
        'modCommon.FontChange(Me, p_Font)
    End Sub
    Private Sub ArrangeChartlayout()
        Dim tmpChartArea As System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim nCount As Integer = 0
        Dim MarginTop As Integer = 0
        Dim MarginBottom As Integer = 0
        Dim AreaHeight As Integer = (100 / 5)
        MarginTop = AreaHeight * 0.18
        AreaHeight = AreaHeight * 0.65
        MarginBottom = AreaHeight * 0.17
        For i As Integer = 1 To _AreaCount
            tmpChartArea = Me.chtCPU.MainChart.ChartAreas(i)
            If tmpChartArea.Visible = True Then
                tmpChartArea.Position.Y = (nCount * AreaHeight) + MarginTop * (nCount + 1) + MarginBottom * nCount
                tmpChartArea.Position.Height = AreaHeight
                tmpChartArea.Position.X = 3
                If i = 3 AndAlso tmpChartArea.Position.Width < 90 Then
                    tmpChartArea.Position.Width = tmpChartArea.Position.Width * (1 + CSng(100 / (Me.chtCPU.MainChart.Width)))
                End If
                nCount += 1
            End If
        Next
        SetAreaWithAnnotation()
    End Sub

    Private Sub SetAreaWithAnnotation()
        If _bRange = True Then
            Dim vlStart As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(0)
            Dim vlEnd As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(1)
            For Each tmpChartArea As DataVisualization.Charting.ChartArea In chtCPU.MainChart.ChartAreas
                If tmpChartArea.Visible = True Then
                    tmpChartArea.CursorX.SetSelectionPosition(vlStart.X, vlEnd.X)
                End If
            Next
        End If
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
                LineColor1 = Color.Lime
                LineColor2 = Color.Yellow
                seriesChartType = DataVisualization.Charting.SeriesChartType.SplineArea
            Case 2
                strLegend1 = "BACKENDTOT"
                strLegend2 = "BACKENDACT"
                strSeriesData1 = "TOT_BACKEND_CNT"
                strSeriesData2 = "CUR_ACTV_BACKEND_CNT"
                LineColor1 = Color.Lime
                LineColor2 = Color.Yellow
                seriesChartType = DataVisualization.Charting.SeriesChartType.SplineArea
            Case 3
                strLegend1 = "Read"
                strLegend2 = "Insert"
                strLegend3 = "Update"
                strLegend4 = "Delete"
                strSeriesData1 = "SELECT_TUPLES_PER_SEC"
                strSeriesData2 = "INSERT_TUPLES_PER_SEC"
                strSeriesData3 = "UPDATE_TUPLES_PER_SEC"
                strSeriesData4 = "DELETE_TUPLES_PER_SEC"
                LineColor1 = Color.Lime
                LineColor2 = Color.Blue
                LineColor3 = Color.Orange
                LineColor4 = Color.Red
                seriesChartType = DataVisualization.Charting.SeriesChartType.Line
                yAxisType = DataVisualization.Charting.AxisType.Secondary
            Case 4
            Case 5
                strLegend1 = p_clsMsgData.fn_GetData("F103")
                strSeriesData1 = "SQL_ELAPSED_SEC"
                LineColor1 = Color.Lime
                seriesChartType = DataVisualization.Charting.SeriesChartType.Point
        End Select

        If ShowChart = False Then
            Me.Invoke(New MethodInvoker(Sub()
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
        Me.Invoke(New MethodInvoker(Sub()
                                        If strLegend1 <> "" AndAlso chtCPU.GetSeries(strLegend1) = False Then
                                            chtCPU.AddSeries(chtCPU.MainChart.ChartAreas(index).Name, strLegend1, strLegend1, LineColor1, seriesChartType, yAxisType)
                                            If yAxisType = DataVisualization.Charting.AxisType.Secondary Then
                                                chtCPU.SetAxisY2ChartArea(Color.Lime, index)
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
                                    End Sub))

        Dim dtTable As DataTable = Nothing
        Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                 Try
                                                                     Select Case index
                                                                         Case 1
                                                                             dtTable = _clsQuery.SelectReportCPUChart(_InstanceID, stDate, edDate)
                                                                         Case 2
                                                                             dtTable = _clsQuery.SelectInitSessionInfoChart(_InstanceID, stDate, edDate, True)
                                                                         Case 3
                                                                             dtTable = _clsQuery.SelectInitObjectChart(_InstanceID, p_ShowName.ToString("d"), stDate, edDate, True)
                                                                         Case 4
                                                                         Case 5
                                                                             dtTable = _clsQuery.SelectDetailSQLRespChart(_InstanceID, stDate, edDate)
                                                                     End Select

                                                                 Catch ex As Exception
                                                                     GC.Collect()
                                                                 End Try
                                                             End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
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
                                                        If strLegend1 <> "" Then Me.chtCPU.AddPoints(strLegend1, tmpDate, ConvULong(dtTable.Rows(i).Item(strSeriesData1)))
                                                        If strLegend2 <> "" Then Me.chtCPU.AddPoints(strLegend2, tmpDate, ConvULong(dtTable.Rows(i).Item(strSeriesData2)))
                                                        If strLegend3 <> "" Then Me.chtCPU.AddPoints(strLegend3, tmpDate, ConvULong(dtTable.Rows(i).Item(strSeriesData3)))
                                                        If strLegend4 <> "" Then Me.chtCPU.AddPoints(strLegend4, tmpDate, ConvULong(dtTable.Rows(i).Item(strSeriesData4)))
                                                    Next
                                                Else
                                                    Dim tmpDate As Double = ConvOADate(Now())
                                                    If strLegend1 <> "" Then Me.chtCPU.AddPoints(strLegend1, tmpDate, 0.0)
                                                    If strLegend2 <> "" Then Me.chtCPU.AddPoints(strLegend2, tmpDate, 0.0)
                                                    If strLegend3 <> "" Then Me.chtCPU.AddPoints(strLegend3, tmpDate, 0.0)
                                                    If strLegend4 <> "" Then Me.chtCPU.AddPoints(strLegend4, tmpDate, 0.0)
                                                End If

                                                Me.chtCPU.ShowMaxValue(True)
                                                chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        chtCPU.SetInnerPlotPositionChartArea(index, _chtCount)
                                        chtCPU.MainChart.ChartAreas(index).RecalculateAxesScale()
                                        ArrangeChartlayout()
                                    End Sub))

    End Sub
    Private Sub ShowPhysicalIOChart(ByVal index As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal ShowChart As Boolean)
        Dim arrPartition As New ArrayList
        Dim colors() As Color = {System.Drawing.Color.Lime,
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
            Me.Invoke(New MethodInvoker(Sub()
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
            Me.Invoke(New MethodInvoker(Sub()
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
        ' Chart Physical I/O
        Me.Invoke(New MethodInvoker(Sub()
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
            Me.Invoke(New MethodInvoker(Sub()
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

        Me.Invoke(New MethodInvoker(Sub()
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
    End Sub

    Private Sub chtCPU_VisibleChanged(sender As Object, e As EventArgs) Handles chtCPU.VisibleChanged, chtSQLResp.VisibleChanged, chtSession.VisibleChanged, chtPhysicalIO.VisibleChanged, chtLogicalIO.VisibleChanged
        pnlChart.Controls.SetChildIndex(chtCPU, 4)
        pnlChart.Controls.SetChildIndex(chtSession, 3)
        pnlChart.Controls.SetChildIndex(chtLogicalIO, 2)
        pnlChart.Controls.SetChildIndex(chtPhysicalIO, 1)
        pnlChart.Controls.SetChildIndex(chtSQLResp, 0)
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        If _bRange = True Then
            fn_DeleteAnnotaion()
        End If

        For i As Integer = 1 To _AreaCount
            If chtCPU.MainChart.ChartAreas(i).Visible = True Then
                QueryChartData(i, True)
            End If
        Next
        SetDataSession(dtpSt.Value, dtpEd.Value)
    End Sub

    Private Sub btnRange_Click(sender As Object, e As EventArgs) Handles btnRange.Click
        If _bRange = True Then
            fn_DeleteAnnotaion()
            SetDataSession(dtpSt.Value, dtpEd.Value)
        Else
            Dim index As Integer
            For index = 1 To _AreaCount
                If chtCPU.MainChart.ChartAreas(index).Visible = True Then
                    Exit For
                End If
            Next
            fn_MakeAnnotation(index)
            _annotationIndex = index
            _bRange = True
        End If
    End Sub

    Private Sub chtCPU_AnnotationPositionChanged(sender As Object, e As EventArgs)
        Dim vlStart As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(0)
        Dim vlEnd As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(1)
        Dim index As Integer = -1
        For index = 1 To _AreaCount
            If chtCPU.MainChart.ChartAreas(index).Visible = True Then
                Exit For
            End If
        Next

        SetAreaWithAnnotation()

        If chtCPU.MainChart.Annotations(0).X < chtCPU.GetMinimumAxisXChartArea(index) _
            Or chtCPU.MainChart.Annotations(0).X > chtCPU.GetMaximumAxisXChartArea(index) Then
            chtCPU.MainChart.Annotations(0).X = chtCPU.GetMinimumAxisXChartArea(index)
        End If

        If chtCPU.MainChart.Annotations(1).X < chtCPU.GetMinimumAxisXChartArea(index) _
            Or chtCPU.MainChart.Annotations(1).X > chtCPU.GetMaximumAxisXChartArea(index) Then
            chtCPU.MainChart.Annotations(1).X = chtCPU.GetMaximumAxisXChartArea(index)
        End If

        SetDataSession(DateTime.FromOADate(vlStart.X), DateTime.FromOADate(vlEnd.X))
    End Sub

    Private Sub chtCPU_AnnotationPositionChanging(sender As Object, e As EventArgs)
        Dim vl As DataVisualization.Charting.VerticalLineAnnotation = DirectCast(sender, DataVisualization.Charting.VerticalLineAnnotation)
        Dim vlStart As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(0)
        Dim vlEnd As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(1)

        If vl.Name = "StartTime" Then
            If vl.X >= vlEnd.X Then
                chtCPU.MainChart.Annotations(1).X = vl.X + (2 * 0.00003471)
            End If
        Else
            If vl.X <= vlStart.X Then
                chtCPU.MainChart.Annotations(0).X = vl.X - (2 * 0.00003471)
            End If
        End If

        SetAreaWithAnnotation()
    End Sub

    Private Sub dgvSessionList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSessionList.CellDoubleClick
        Dim strDb As String = ""
        Dim strUser As String = ""
        Dim strQuery As String = ""
        If dgvSessionList.RowCount <= 0 Then Return
        'If e.ColumnIndex = coldgvSessionListSQL.Index Then
        strDb = dgvSessionList.CurrentRow.Cells(coldgvSessionListDB.Index).Value
        strQuery = dgvSessionList.CurrentRow.Cells(coldgvSessionListSQL.Index).Value
        strUser = dgvSessionList.CurrentRow.Cells(coldgvSessionListUser.Index).Value
        Dim frmQuery As New frmQueryView(strQuery, strDb, Me.InstanceID, Me.AgentInfo, strUser)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Function fn_SearchBefCheck() As Boolean
        If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return False
        Else
            If DateDiff(DateInterval.Hour, dtpSt.Value, dtpEd.Value) >= 1 Then
                MsgBox(p_clsMsgData.fn_GetData("M015", "1"))
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub cmbInst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInst.SelectedIndexChanged
        _InstanceID = cmbInst.SelectedValue
        Me.Invoke(New MethodInvoker(Sub()
                                        btnQuery.PerformClick()
                                    End Sub))
        If _bRange = True Then
            Me.Invoke(New MethodInvoker(Sub()
                                            btnRange.PerformClick()
                                        End Sub))
        End If

    End Sub

    Private Sub dtpSt_ValueChanged(sender As Object, e As EventArgs) Handles dtpSt.ValueChanged
        If cmbDuration.Visible = True Then
            Dim tempDt As Date = Now
            If cmbDuration.SelectedIndex = 0 Then
                tempDt = dtpSt.Value.AddMinutes(5)
                If tempDt > Now Then
                    tempDt = Now
                End If
                dtpEd.Value = tempDt
            ElseIf cmbDuration.SelectedIndex = 1 Then
                tempDt = dtpSt.Value.AddMinutes(10)
                If tempDt > Now Then
                    tempDt = Now
                End If
                dtpEd.Value = tempDt
            ElseIf cmbDuration.SelectedIndex = 2 Then
                tempDt = dtpSt.Value.AddMinutes(30)
                If tempDt > Now Then
                    tempDt = Now
                End If
                dtpEd.Value = tempDt
            Else
            End If
        End If
    End Sub

    Private Sub fn_MakeAnnotation(ByVal index As Integer)
        Dim stVerticalAnnotation As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(0)
        Dim edVerticalAnnotation As DataVisualization.Charting.VerticalLineAnnotation = chtCPU.MainChart.Annotations(1)
        Dim stRectAnnotation As DataVisualization.Charting.RectangleAnnotation = chtCPU.MainChart.Annotations(2)
        Dim edRectAnnotation As DataVisualization.Charting.RectangleAnnotation = chtCPU.MainChart.Annotations(3)

        stVerticalAnnotation.AxisX = chtCPU.MainChart.ChartAreas(index).AxisX
        stVerticalAnnotation.AxisY = chtCPU.MainChart.ChartAreas(index).AxisY
        stVerticalAnnotation.X = chtCPU.GetMinimumAxisXChartArea(index)
        stVerticalAnnotation.Visible = True
        stVerticalAnnotation.AllowMoving = True
        stVerticalAnnotation.IsInfinitive = True
        stVerticalAnnotation.Name = "StartTime"
        stVerticalAnnotation.AnchorY = 200
        stVerticalAnnotation.ToolTip = "StartTime"
        stVerticalAnnotation.AllowTextEditing = True

        edVerticalAnnotation.AxisX = chtCPU.MainChart.ChartAreas(index).AxisX
        edVerticalAnnotation.AxisY = chtCPU.MainChart.ChartAreas(index).AxisY
        edVerticalAnnotation.X = chtCPU.GetMaximumAxisXChartArea(index)
        edVerticalAnnotation.Visible = True
        edVerticalAnnotation.AllowMoving = True
        edVerticalAnnotation.IsInfinitive = True
        edVerticalAnnotation.Name = "EndTime"
        edVerticalAnnotation.AnchorY = 200
        edVerticalAnnotation.ToolTip = "EndTime"

        AddHandler chtCPU.MainChart.AnnotationPositionChanging, AddressOf chtCPU_AnnotationPositionChanging
        AddHandler chtCPU.MainChart.AnnotationPositionChanged, AddressOf chtCPU_AnnotationPositionChanged

        btnRange.Text = p_clsMsgData.fn_GetData("F269", "On")
        btnRange.ForeColor = Color.Lime
    End Sub

    Private Sub fn_DeleteAnnotaion()
        RemoveHandler chtCPU.MainChart.AnnotationPositionChanging, AddressOf chtCPU_AnnotationPositionChanging
        RemoveHandler chtCPU.MainChart.AnnotationPositionChanged, AddressOf chtCPU_AnnotationPositionChanged

        chtCPU.MainChart.Annotations(0).Visible = False
        chtCPU.MainChart.Annotations(1).Visible = False

        For Each tmpChartArea As DataVisualization.Charting.ChartArea In chtCPU.MainChart.ChartAreas
            If tmpChartArea.Visible = True Then
                tmpChartArea.CursorX.SetSelectionPosition(-1, -1)
            End If
        Next

        btnRange.Text = p_clsMsgData.fn_GetData("F269", "Off")
        btnRange.ForeColor = Color.LightGray
        _bRange = False
    End Sub


    Private Sub frmMonItemDetail_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If _chtCount > 0 Then
            For i As Integer = 1 To _AreaCount
                chtCPU.SetInnerPlotXPositionChartArea(i, _chtCount)
                chtCPU.MainChart.ChartAreas(i).RecalculateAxesScale()
            Next
        End If
    End Sub
End Class
