Public Class frmMonDetail

#Region "Declares"

#Region "Timer"
    Private WithEvents TmCollect As Timer
    Private Sub TmCollect_Tick(sender As Object, e As EventArgs) Handles TmCollect.Tick
        If Me.IsHandleCreated Then

            TmCollect.Stop()
            Try
                initControls(p_clsAgentCollect.AgentState)

                If p_clsAgentCollect.AgentState = clsCollect.AgntState.Activate Then
                    SetDataBackEnd(p_clsAgentCollect.infoDataBackend)
                    SetDataCpuMem(p_clsAgentCollect.infoDataCpuMem) 'accumulate
                    SetDataDisk(p_clsAgentCollect.infoDataDisk)     'accumulate
                    SetDataSQLRespTm(p_clsAgentCollect.infoDataSQLRespTm) 'accumulate
                    SetDataRequest(p_clsAgentCollect.infoDataObject, p_clsAgentCollect.infoDataSessioninfo) 'accumulate
                    'This chart will move to object view 20180125
                    'SetDataObject(p_clsAgentCollect.infoDataObject) 'accumulate
                    SetDataPhysicaliO(p_clsAgentCollect.infoDataPhysicaliO) 'accumulate
                    SetDataHealth(p_clsAgentCollect.infoDataHealth)
                End If

            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Finally
                TmCollect.Start()
            End Try



        End If


    End Sub


    Private Sub initControls(ByVal AgentStat As clsCollect.AgntState)
        Try


            If AgentStat = clsCollect.AgntState.DeActivate Then
                rndProgHealth.CpuGaugeColor = Color.DarkGray
                dgvCPU.Rows.Clear()
                dgvGrpHealth.Rows.Clear()
                dgvDiskIO.Rows.Clear()
                dgvResUtilPerBackProc.DataSource = Nothing
                rndProgCPU.CpuGauge_value = 0
                rndProgCPU.Postgres_value = 0
                rndProgCPU.CacheGauge_value = 0
                rndProgCPU.BufferGauge_value = 0
                rndProgMEM.CpuGauge_value = 0
                rndProgMEM.Postgres_value = 0
                rndProgMEM.CacheGauge_value = 0
                rndProgMEM.BufferGauge_value = 0
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try


    End Sub

#End Region


    Private _Elapseinterval As Integer = 3000
    Private _ElapseCount As Integer = 200  ' 10을 기본으로 설정 
    Private _InstanceID As Integer = -1
    Private _ServerInfo As GroupInfo.ServerInfo = Nothing
    Private _ShowHchkNormal As Boolean = True
    Private _ShowHchkWarning As Boolean = True
    Private _ShowHchkCritical As Boolean = True
    Private _AgentCn As eXperDB.ODBC.DXODBC
    Private _clsQuery As clsQuerys  ' Main Thread용
    Private _TextFont As Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))

    ReadOnly Property AgentCn As DXODBC
        Get
            Return _AgentCn
        End Get
    End Property

    ReadOnly Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
    End Property


    Private _AgentInfo As structAgent
    ReadOnly Property AgentInfo As structAgent
        Get
            Return _AgentInfo
        End Get
    End Property

#End Region

#Region "Initialize & Dispose"
    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent, ByVal AgentCn As eXperDB.ODBC.DXODBC)


        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = ServerInfo.InstanceID
        _Elapseinterval = ElapseInterval
        _ServerInfo = ServerInfo
        _AgentInfo = clsAgentInfo
        _AgentCn = AgentCn
        _clsQuery = New clsQuerys(_AgentCn)

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'FormMovePanel1.Text += " [" + String.Format("{0}(v{3}) : {1}[{2}] Started on {4} ", strHeader, ServerInfo.ShowNm, ServerInfo.IP, ServerInfo.PGV, ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss")) + "]"
        'FormMovePanel1.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", ServerInfo.ShowNm, ServerInfo.IP, ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), ServerInfo.PGV) + "]"

        Me.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", ServerInfo.ShowNm, ServerInfo.IP, ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), ServerInfo.PGV) + "]"

        ServerName_lv.Text = String.Format("Name : {0},  IP : {1}, Started on {2}", ServerInfo.ShowNm, ServerInfo.IP, ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))

        TmCollect = New Timer()
        TmCollect.Interval = _Elapseinterval
        TmCollect.Start()

        _ElapseCount = (60000 / _Elapseinterval) * 60 / 6 ' 10분

        ReadConfig()
    End Sub

    Private Sub ReadConfig()
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        _ShowHchkNormal = clsIni.ReadValue("General", "NORMAL_SHOW", True)
        _ShowHchkWarning = clsIni.ReadValue("General", "WARNING_SHOW", True)
        _ShowHchkCritical = clsIni.ReadValue("General", "CRITICAL_SHOW", True)

        nudBackendcnt.Value = clsIni.ReadValue("FORM", "SESSIONDETAIL", 30)

        chkIDLE.Checked = clsIni.ReadValue("FORM", "IDLEDETAIL", "False")


    End Sub

    Private Sub frmMonDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.chtCPU.Dispose()
        _clsQuery = Nothing
        Dim monMain As frmMonMain = TryCast(Me.Owner, frmMonMain)
        If monMain IsNot Nothing Then
            monMain.InstanceSelectedChange(_InstanceID, False)
        End If
    End Sub

    Private Sub frmMonDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' 폼 초기화 
        InitForm()

        Try
            initControls(p_clsAgentCollect.AgentState)

            If p_clsAgentCollect.AgentState = clsCollect.AgntState.Activate Then
                SetDataBackEnd(p_clsAgentCollect.infoDataBackend)
                initDataCpu()
                'SetDataCpuMem(p_clsAgentCollect.infoDataCpuMem)
                SetDataDisk(p_clsAgentCollect.infoDataDisk)
                initDataSQLRespTm()
                'SetDataSQLRespTm(p_clsAgentCollect.infoDataSQLRespTm)
                initDataRequest()
                'SetDataRequest(p_clsAgentCollect.infoDataObject, p_clsAgentCollect.infoDataSessioninfo)
                'SetDataObject(p_clsAgentCollect.infoDataObject)
                SetDataPhysicaliO(p_clsAgentCollect.infoDataPhysicaliO)
                'SetDataHealth(p_clsAgentCollect.infoDataHealth)
                _clsQuery.CancelCommand()
            End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        Finally
            TmCollect.Start()
        End Try

    End Sub

    Private Sub InitForm()

        lblHealth.Text = ""
        ' Grp Health 
        dgvGrpHealth.AutoGenerateColumns = False
        'colDgvHealthItm.HeaderText = p_clsMsgData.fn_GetData("F059")
        colDgvHealthitmNm.HeaderText = p_clsMsgData.fn_GetData("F059")
        colDgvHealthIVal.HeaderText = p_clsMsgData.fn_GetData("F060")
        colDgvHealthUnit.HeaderText = p_clsMsgData.fn_GetData("F061")
        colDgvHealthStatus.HeaderText = p_clsMsgData.fn_GetData("F062")


        ' Grp Cpu 
        grpCpuMem.Text = p_clsMsgData.fn_GetData("F139")
        grpCPU.Text = p_clsMsgData.fn_GetData("F064")
        colDgvCPUCPU.HeaderText = p_clsMsgData.fn_GetData("F035")
        colDgvCpuUtil.HeaderText = p_clsMsgData.fn_GetData("F063")
        '    Grp Cpu AVG 
        Dim intIdx As Integer = dgvCPU.Rows.Add("AVG", 0, 0)
        'dgvCPU.Rows(intIdx).Cells(colDgvCPUCPU.Index).Value = "AVG"
        'dgvCPU.Rows(intIdx).Cells(colDgvCpuProg.Index).Value = 0
        'dgvCPU.Rows(intIdx).Cells(colDgvCpuUtil.Index).Value = 0


        ' Round Progress CPU 
        rndProgCPU.Main_Text = p_clsMsgData.fn_GetData("F035")



        ' Round Progress MEM
        rndProgMEM.Main_Text = p_clsMsgData.fn_GetData("F194")
        lblMemTot.Text = p_clsMsgData.fn_GetData("F065")
        lblMemUsed.Text = p_clsMsgData.fn_GetData("F066")
        lblMemFree.Text = p_clsMsgData.fn_GetData("F067")
        lblMemShared.Text = p_clsMsgData.fn_GetData("F068")
        lblMemBuffer.Text = p_clsMsgData.fn_GetData("F069")
        lblMemCache.Text = p_clsMsgData.fn_GetData("F070")
        lblMemSwapTotal.Text = p_clsMsgData.fn_GetData("F071")
        lblMemSwapUsed.Text = p_clsMsgData.fn_GetData("F072")
        lblMemSwapFree.Text = p_clsMsgData.fn_GetData("F073")
        lblMemSwapCached.Text = p_clsMsgData.fn_GetData("F152")




        'Disk IO 
        grpDiskIO.Text = p_clsMsgData.fn_GetData("F086")
        colDgvDiskIODiskNm.HeaderText = p_clsMsgData.fn_GetData("F085")
        colDgvDiskIORead.HeaderText = p_clsMsgData.fn_GetData("F087")
        colDgvDiskIOWrite.HeaderText = p_clsMsgData.fn_GetData("F088")
        colDgvDiskIOBusy.HeaderText = p_clsMsgData.fn_GetData("F043")


        '20140307 다국어적용 HYY
        'Session infomation
        grpSessioninfo.Text = p_clsMsgData.fn_GetData("F047")


        'Resource Util Per Backend Process
        grpResUtilPerBackProc.Text = p_clsMsgData.fn_GetData("F089")
        dgvResUtilPerBackProc.AutoGenerateColumns = False
        coldgvResUtilPerBackProcDB.HeaderText = p_clsMsgData.fn_GetData("F090")
        coldgvResUtilPerBackProcPID.HeaderText = p_clsMsgData.fn_GetData("F082")
        coldgvResUtilPerBackProcRead.HeaderText = p_clsMsgData.fn_GetData("F048")
        coldgvResUtilPerBackProcWrite.HeaderText = p_clsMsgData.fn_GetData("F136")
        coldgvResUtilPerBackProcCpuUsage.HeaderText = p_clsMsgData.fn_GetData("F092")
        coldgvResUtilPerBackProcSQL.HeaderText = p_clsMsgData.fn_GetData("F052")
        coldgvResUtilPerBackProcElapsedTime.HeaderText = p_clsMsgData.fn_GetData("F051")
        coldgvResUtilPerBackProcStTime.HeaderText = p_clsMsgData.fn_GetData("F050")

        chkIDLE.Text = p_clsMsgData.fn_GetData("F227")
        chkIDLE.Tag = p_clsMsgData.fn_GetSpecificData("F227", "COMMENTS")


        'EVENT Log
        'grpEventLog.Text = p_clsMsgData.fn_GetData("F094")
        'dgvEventLog.AutoGenerateColumns = False
        'coldgvEventLogIssueTime.HeaderText = p_clsMsgData.fn_GetData("F095")
        'coldgvEventLogCategory.HeaderText = p_clsMsgData.fn_GetData("F096")
        'coldgvEventLogValueUnit.HeaderText = p_clsMsgData.fn_GetData("F097")
        'coldgvEventLogServerity.HeaderText = p_clsMsgData.fn_GetData("F098")
        ''coldgvEventLogComments.HeaderText = p_clsMsgData.fn_GetData("F099")


        'Physical I/O      Logical I/O       Object    SQL Response Time
        grpPhysicalIO.Text = p_clsMsgData.fn_GetData("F100")
        grpLogicalIO.Text = p_clsMsgData.fn_GetData("F101")
        'Will move to object view
        'grpObject.Text = p_clsMsgData.fn_GetData("F102")
        grpSQLResposeTime.Text = p_clsMsgData.fn_GetData("F103")

        'DB Activity Info
        btnActInfo.Text = p_clsMsgData.fn_GetData("F075")

        'Log View
        btnLogView.Text = p_clsMsgData.fn_GetData("F233")

        'Query View
        btnSqlPlan.Text = p_clsMsgData.fn_GetData("F245")

        'chart detail
        'btnChartDetail.Text = p_clsMsgData.fn_GetData("F278")

        'Sessin Lock View
        btnSessionLock.Text = p_clsMsgData.fn_GetData("F246")

        'Me.FormControlBox1.UseConfigBox = False
        'Me.FormControlBox1.UseLockBox = False
        'Me.FormControlBox1.UseCriticalBox = False
        'Me.FormControlBox1.UseRotationBox = False
        'Me.FormControlBox1.UsePowerBox = False
        'Me.EspRight.Expand = False
        'fit position of components
        Me.btnRefreshSession.Location = New System.Drawing.Point(Me.grpSessioninfo.Width - Me.btnRefreshSession.Width - Me.btnRefreshSession.Margin.Right, Me.btnRefreshSession.Margin.Top)
        Me.btnRefreshLogicaliO.Location = New System.Drawing.Point(Me.grpLogicalIO.Width - Me.btnRefreshLogicaliO.Width - Me.btnRefreshLogicaliO.Margin.Right, Me.btnRefreshLogicaliO.Margin.Top)
        'Will move to object view
        'Me.btnRefreshObject.Location = New System.Drawing.Point(Me.grpObject.Width - Me.btnRefreshObject.Width - Me.btnRefreshObject.Margin.Right, Me.btnRefreshObject.Margin.Top)
        Me.btnRefreshPhysicaliO.Location = New System.Drawing.Point(Me.grpPhysicalIO.Width - Me.btnRefreshPhysicaliO.Width - Me.btnRefreshPhysicaliO.Margin.Right, Me.btnRefreshPhysicaliO.Margin.Top)
        Me.btnRefreshSqlResp.Location = New System.Drawing.Point(Me.grpSQLResposeTime.Width - Me.btnRefreshSqlResp.Width - Me.btnRefreshSqlResp.Margin.Right, Me.btnRefreshSqlResp.Margin.Top)


        For i As Integer = 0 To dgvResUtilPerBackProc.ColumnCount - 1
            dgvResUtilPerBackProc.Columns(i).DefaultCellStyle.BackColor = System.Drawing.Color.Black
            dgvResUtilPerBackProc.Columns(i).DefaultCellStyle.ForeColor = System.Drawing.Color.White
            dgvResUtilPerBackProc.Columns(i).DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            dgvResUtilPerBackProc.Columns(i).DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Next

        modCommon.FontChange(Me, p_Font)

    End Sub

#End Region





#Region "Delegate & Ctl "
    ' ''' <summary>
    ' ''' Chart Point 등록 Delegate 
    ' ''' </summary>
    ' ''' <param name="MsChart"></param>
    ' ''' <param name="strSeries"></param>
    ' ''' <param name="dblX"></param>
    ' ''' <param name="dblY"></param>
    ' ''' <returns></returns>
    ' ''' <remarks></remarks>
    'Private Delegate Function DelegateChartAddPoint(ByVal MsChart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal dblX As Double, ByVal dblY As Double) As Integer

    ''' <summary>
    ''' Chart Point 등록 
    ''' </summary>
    ''' <param name="MSChart"></param>
    ''' <param name="strSeries"></param>
    ''' <param name="dblX"></param>
    ''' <param name="dblY"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function sb_ChartAddPoint(ByVal MSChart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal dblX As Double, ByVal dblY As Double) As Integer
        Try
            Dim rtnValue As Integer = MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), dblY)

            Dim NowCnt As Integer = MSChart.Series(strSeries).Points.Count
            If NowCnt >= _ElapseCount Then
                For i As Integer = 0 To NowCnt - _ElapseCount
                    MSChart.Series(strSeries).Points.RemoveAt(0)
                Next

            End If


            Return rtnValue
            'End If

        Catch ex As Exception
            Return -1
        Finally


        End Try

    End Function


    Private Sub sb_ChartAlignYAxies(ByVal MSChart As DataVisualization.Charting.Chart)


        Dim dblMaxPri As Double = 0
        Dim dblMaxSec As Double = 0
        For Each tmpSeries As DataVisualization.Charting.Series In MSChart.Series
            If tmpSeries.Points.Count > 0 Then
                If tmpSeries.YAxisType = DataVisualization.Charting.AxisType.Primary Then
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxPri = Math.Max(dblMaxPri, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))

                Else
                    Dim tmpValue As Double = Double.NaN
                    tmpValue = tmpSeries.Points.FindMaxByValue().YValues(0)
                    dblMaxSec = Math.Max(dblMaxSec, IIf(tmpValue.Equals(Double.NaN), 0, tmpValue))


                End If
            End If


        Next


        If Not dblMaxPri.Equals(Double.NaN) Then
            Dim intValuePri As Integer = dblMaxPri \ 5
            intValuePri += 1

            MSChart.ChartAreas(0).AxisY.Maximum = intValuePri * 5
            MSChart.ChartAreas(0).AxisY.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY.Interval = MSChart.ChartAreas(0).AxisY.Maximum / 5
        End If



        If Not dblMaxSec.Equals(Double.NaN) Then

            Dim intValueSec As Integer = dblMaxSec \ 5
            MSChart.ChartAreas(0).AxisY2.Maximum = intValueSec * 5
            MSChart.ChartAreas(0).AxisY2.IntervalAutoMode = DataVisualization.Charting.IntervalAutoMode.FixedCount
            MSChart.ChartAreas(0).AxisY2.Interval = MSChart.ChartAreas(0).AxisY2.Maximum / 5
        End If
        MSChart.ChartAreas(0).RecalculateAxesScale()



    End Sub



#End Region

#Region "Add Data"
    ''' <summary>
    ''' CPU / MEM 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataCpuMem(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)


        If dtRows.Count > 0 Then
            Dim dblRegDate As Double = ConvOADate(dtRows(0).Item("REG_DATE"))
            Dim dblCpuMain As Integer = ConvDBL(dtRows(0).Item("CPU_MAIN"))
            Dim dblCpuWait As Integer = ConvDBL(dtRows(0).Item("WAIT_UTIL_RATE"))
            Dim dblMemUsed As Integer = ConvDBL(dtRows(0).Item("MEM_USED_RATE"))
            Dim dblSwapUsed As Integer = ConvDBL(dtRows(0).Item("SWP_USED_RATE"))
            Dim dblBuffer As Double = ConvDBL(dtRows(0).Item("BUFFER_RATE"))
            Dim dblCash As Double = 0

            ' Round Progress Bar 
            rndProgCPU.CpuGauge_value = dblCpuMain
            rndProgCPU.Postgres_value = dblCpuWait
            rndProgMEM.CpuGauge_value = dblMemUsed
            rndProgMEM.Postgres_value = 0
            rndProgMEM.BufferGauge_value = CInt(dblBuffer)
            rndProgMEM.CacheGauge_value = CInt(dblCash)

            sb_ChartAddPoint(Me.chtCPU, "MAIN", dblRegDate, ConvULong(dblCpuMain))
            sb_ChartAddPoint(Me.chtCPU, "POSTGRES", dblRegDate, ConvULong(dblCpuWait))
            sb_ChartAlignYAxies(Me.chtCPU)


            ' Memory Information 
            ' lblMemTotVal.Text = ConvDBL(dtRows(0).Item("MEM_TOTAL_MB")).ToString("N2") & " MB" '   arrLst.Item(0).C08_MEM_TOTAL_MB.ToString("N0") & " MB"
            lblMemTotVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("MEM_TOTAL_MB")), clsEnums.FileSizeUnit.MB) '   arrLst.Item(0).C08_MEM_TOTAL_MB.ToString("N0") & " MB"
            lblMemUsedVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("MEM_USED_MB")), clsEnums.FileSizeUnit.MB)
            lblMemFreeVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("MEM_FREE_MB")), clsEnums.FileSizeUnit.MB)
            lblMemSharedVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("SHM_MB")), clsEnums.FileSizeUnit.MB)
            lblMemBufferVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("MEM_BUFFERED_MB")), clsEnums.FileSizeUnit.MB)
            lblMemCacheVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("MEM_CACHED_MB")), clsEnums.FileSizeUnit.MB)
            lblMemSwapTotalVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("SWP_TOTAL_MB")), clsEnums.FileSizeUnit.MB)
            lblMemSwapUsedVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("SWP_USED_MB")), clsEnums.FileSizeUnit.MB)
            lblMemSwapFreeVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("SWP_FREE_MB")), clsEnums.FileSizeUnit.MB)
            lblMemSwapCachedVal.Text = TranslateFileSizeWithUnit(ConvDBL(dtRows(0).Item("SWP_CACHED_MB")), clsEnums.FileSizeUnit.MB)


            ' Cpu Information 

            Using dgvAvgRow As DataGridViewRow = dgvCPU.FindFirstRow("AVG", colDgvCPUCPU.Index)
                If dgvAvgRow IsNot Nothing Then
                    dgvAvgRow.Cells(colDgvCpuProg.Index).Value = dblCpuMain
                    dgvAvgRow.Cells(colDgvCpuUtil.Index).Value = dblCpuMain / 100
                End If

            End Using

            For Each tmpRow As DataRow In dtRows
                Dim intCpuID As Integer = ConvDBL(tmpRow.Item("CPU_LOGICAL_ID")) - 1
                Dim dblRate As Double = ConvDBL(tmpRow.Item("CORE_CPU_RATE"))
                Using dgvCpuRow As DataGridViewRow = dgvCPU.FindFirstRow(intCpuID, colDgvCPUCPU.Index)
                    If dgvCpuRow Is Nothing Then
                        Dim intIDx As Integer = dgvCPU.Rows.Add

                        dgvCPU.Rows(intIDx).Cells(colDgvCPUCPU.Index).Value = intCpuID
                        dgvCPU.Rows(intIDx).Cells(colDgvCpuProg.Index).Value = dblRate
                        dgvCPU.Rows(intIDx).Cells(colDgvCpuUtil.Index).Value = dblRate / 100
                    Else
                        dgvCpuRow.Cells(colDgvCpuProg.Index).Value = dblRate
                        dgvCpuRow.Cells(colDgvCpuUtil.Index).Value = dblRate / 100
                    End If

                End Using
            Next
            modCommon.sb_GridProgClrChg(dgvCPU)
        End If


    End Sub


    ''' <summary>
    ''' Disk  정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataDisk(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        Dim dtRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND DISK_NAME <> '{1}'", Me.InstanceID, "-"))


        Dim strUpdTime As Double = Now.ToOADate


        For Each tmpRow As DataRow In dtRows
            Dim strDiskNm As String = tmpRow.Item("DISK_NAME")
            Dim dblReadKB As Double = ConvDBL(tmpRow.Item("READ_KB_PER_SEC"))
            Dim dblWriteKB As Double = ConvDBL(tmpRow.Item("WRITE_KB_PER_SEC"))
            Dim dblButyRate As Double = ConvDBL(tmpRow.Item("BUSY_RATE"))


            Using dgvDiskRow As DataGridViewRow = dgvDiskIO.FindFirstRow(strDiskNm, colDgvDiskIODiskNm.Index)
                If dgvDiskRow Is Nothing Then
                    Dim intIDx As Integer = dgvDiskIO.Rows.Add
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIODiskNm.Index).Value = strDiskNm
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIORead.Index).Value = dblReadKB
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIOWrite.Index).Value = dblWriteKB
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIOProg.Index).Value = dblButyRate
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIOBusy.Index).Value = dblButyRate / 100
                    dgvDiskIO.Rows(intIDx).Cells(colDgvDiskIOUpdtime.Index).Value = strUpdTime
                Else
                    dgvDiskRow.Cells(colDgvDiskIORead.Index).Value = dblReadKB
                    dgvDiskRow.Cells(colDgvDiskIOWrite.Index).Value = dblWriteKB
                    dgvDiskRow.Cells(colDgvDiskIOProg.Index).Value = dblButyRate
                    dgvDiskRow.Cells(colDgvDiskIOBusy.Index).Value = dblButyRate / 100
                    dgvDiskRow.Cells(colDgvDiskIOUpdtime.Index).Value = strUpdTime
                End If

            End Using
        Next


        dgvDiskIO.invokeRowsRemoves(strUpdTime, colDgvDiskIOUpdtime.Index, False)
        modCommon.sb_GridProgClrChg(dgvDiskIO)
        sb_GridSortChg(dgvDiskIO, colDgvDiskIOBusy.Index)



    End Sub


    ''' <summary>
    ''' Request Information 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataRequest(ByVal dtTable As DataTable, ByVal dtTableSession As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 




        If dtTableSession IsNot Nothing Then
            Dim dtRowsSession As DataRow() = dtTableSession.Select("INSTANCE_ID=" & Me.InstanceID)

            If dtRowsSession.Count = 0 Then
                Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                sb_ChartAddPoint(Me.chtSession, "BACKENDACT", dblRegDt, 0)
                sb_ChartAddPoint(Me.chtSession, "BACKENDTOT", dblRegDt, 0)
            Else
                For Each tmpRow As DataRow In dtRowsSession
                    Dim dblRegDt As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))
                    sb_ChartAddPoint(Me.chtSession, "BACKENDACT", dblRegDt, ConvULong(tmpRow.Item("CUR_ACTV_BACKEND_CNT")))
                    sb_ChartAddPoint(Me.chtSession, "BACKENDTOT", dblRegDt, ConvULong(tmpRow.Item("TOT_BACKEND_CNT")))
                Next
            End If
        End If


        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)
        For Each tmpRow As DataRow In dtRows
            Dim dblRegDt As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))





            ' Logical I/O Info   
            sb_ChartAddPoint(Me.chtLocalIO, "READ", dblRegDt, ConvULong(tmpRow.Item("SELECT_TUPLES_PER_SEC")))
            sb_ChartAddPoint(Me.chtLocalIO, "INSERT", dblRegDt, ConvULong(tmpRow.Item("INSERT_TUPLES_PER_SEC")))
            sb_ChartAddPoint(Me.chtLocalIO, "UPDATE", dblRegDt, ConvULong(tmpRow.Item("UPDATE_TUPLES_PER_SEC")))
            sb_ChartAddPoint(Me.chtLocalIO, "DELETE", dblRegDt, ConvULong(tmpRow.Item("DELETE_TUPLES_PER_SEC")))





        Next
        sb_ChartAlignYAxies(Me.chtSession)
        sb_ChartAlignYAxies(Me.chtLocalIO)





    End Sub


    ''' <summary>
    ''' SQL Response Time 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataSQLRespTm(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 

        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)


        ' Chart 데이터는 Invoke 로 넣어야 한다. 

        If dtRows.Count = 0 Then
            Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm"))
            sb_ChartAddPoint(Me.chtSQLRespTm, "MAX", dblRegDt, 0)
            sb_ChartAddPoint(Me.chtSQLRespTm, "AVG", dblRegDt, 0)
        Else
            For Each tmprow As DataRow In dtRows
                Dim dblRegDt As Double = ConvOADate(tmprow.Item("REG_DATE"))
                Dim dblMax As Double = ConvULong(tmprow.Item("MAX_SQL_ELAPSED_SEC"))
                Dim dblAvg As Double = ConvULong(tmprow.Item("AVG_SQL_ELAPSED_SEC"))

                sb_ChartAddPoint(Me.chtSQLRespTm, "MAX", dblRegDt, dblMax)
                sb_ChartAddPoint(Me.chtSQLRespTm, "AVG", dblRegDt, dblAvg)
            Next
        End If
        sb_ChartAlignYAxies(Me.chtSQLRespTm)
    End Sub
    ''' <summary>
    ''' SQL Response Time 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataObject(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 
        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)


        ' Chart 데이터는 Invoke 로 넣어야 한다. 


        For Each tmpRow As DataRow In dtRows
            Dim dblRegDate As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))
            Dim dblIndexScan As Double = ConvULong(tmpRow.Item("INDEX_SCAN_TUPLES_PER_SEC"))
            Dim dblSqlScan As Double = ConvULong(tmpRow.Item("SEQ_SCAN_TUPLES_PER_SEC"))



            'sb_ChartAddPoint(Me.chtObject, "INDEX", dblRegDate, dblIndexScan) 'Will move to object view
            'sb_ChartAddPoint(Me.chtObject, "SEQUENTIAL", dblRegDate, dblSqlScan) 'Will move to object view
        Next

        'sb_ChartAlignYAxies(Me.chtObject) 'Will move to object view

    End Sub

    ''' <summary>
    ''' BackEnd 정보 등록 
    ''' </summary>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Private Sub SetDataBackEnd(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 


        '        Me.dgvResUtilPerBackProc.InvokeRowsClear()

        dgvResUtilPerBackProc.Font = _TextFont

        Dim strQuery As String = ""
        Dim subQuery As String = IIf(chkIDLE.Checked, "", String.Format("AND SQL <> '{0}'", chkIDLE.Tag))

        strQuery = String.Format("INSTANCE_ID = {0} {1}", Me.InstanceID, subQuery)

        Dim dtView As DataView = New DataView(dtTable, strQuery, "CPU_USAGE DESC, ELAPSED_TIME DESC", DataViewRowState.CurrentRows)

        Dim ShowDT As DataTable = Nothing
        If dtView.Count > 0 Then
            ShowDT = dtView.ToTable.AsEnumerable.Take(nudBackendcnt.Value).CopyToDataTable
        End If

        dgvResUtilPerBackProc.DataSource = ShowDT
        dgvResUtilPerBackProc.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)



    End Sub


    Private Sub SetDataPhysicaliO(ByVal dtTable As DataTable)
        ' 전체 목록중 내것만 추출 
        ' Me.InstanceID => Form New에서 초기에 정보를 가지고 있음. 


        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)

        Dim strDiskNm As String = ""
        If cmbPhysical.SelectedIndex >= 0 Then
            strDiskNm = cmbPhysical.Text
        End If

        cmbPhysical.Items.Clear()

        For Each dtRow As DataRow In dtRows
            cmbPhysical.Items.Add(dtRow.Item("DISK_NAME"))
        Next

        cmbPhysical.Tag = dtTable

        If cmbPhysical.Items.Count > 0 Then
            If strDiskNm = "" Then
                cmbPhysical.SelectedIndex = 0
                strDiskNm = cmbPhysical.Text
            Else
                cmbPhysical.Text = strDiskNm
            End If
            Me.chtPhysicaliO.Tag = strDiskNm
        End If






    End Sub

    Private Sub SetDataHealth(ByVal dtTable As DataTable)
        'Dim InstanceMaxVals = _
        '  dtTable.AsEnumerable().GroupBy( _
        '      Function(r) New With {Key .InstanceID = r.Field(Of Integer)("INSTANCE_ID"), _
        '                    Key .IP = r.Field(Of String)("SERVER_IP"), _
        '                    Key .Port = r.Field(Of String)("SERVICE_PORT"), _
        '                    Key .Name = r.Field(Of String)("CONN_NAME")} _
        '               ).[Select]( _
        '               Function(grp) _
        '                   New With {Key .InstanceID = grp.Key.InstanceID, _
        '                             Key .IP = grp.Key.IP, _
        '                             Key .Port = grp.Key.Port, _
        '                             Key .Name = grp.Key.Name, _
        '                             Key .MaxVal = grp.Max(Function(e) e.Field(Of Integer)("HCHK_VALUE"))} _
        '                         )

        'InstanceMaxVals.Where(Function(r) r.InstanceID = Me.InstanceID)

        dgvGrpHealth.Font = _TextFont

        'Dim tmpData = dtTable.AsEnumerable.Where(Function(e) e.Item("INSTANCE_ID") = Me.InstanceID)
        Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID, "HCHK_VALUE DESC")
        If dtRows.Count = 0 Then Return

        For Each tmpRow As DataRow In dtRows
            Dim strItm As String = tmpRow.Item("HCHK_NAME")
            Dim intHchkVal As Integer = tmpRow.Item("HCHK_VALUE")
            Dim intValue As Long = tmpRow.Item("VALUE")
            Dim strUnit As String = tmpRow.Item("UNIT")
            Dim intSeq As String = IIf(IsDBNull(tmpRow.Item("REG_SEQ")), "", tmpRow.Item("REG_SEQ"))
            Dim strRegDt As String = IIf(IsDBNull(tmpRow.Item("REG_DATE")), Now.ToString("yyyyMMdd"), tmpRow.Item("REG_DATE"))
            Using dgvHealthRow As DataGridViewRow = dgvGrpHealth.FindFirstRow(strItm, colDgvHealthItm.Index)
                If dgvHealthRow Is Nothing Then
                    Dim intIDx As Integer = dgvGrpHealth.Rows.Add
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthItm.Index).Value = strItm
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthitmNm.Index).Value = p_clsMsgData.fn_GetData(strItm)
                    If VarType(modCommon.fn_GetValueCast(strItm, intValue)) = vbLong Then
                        dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthIVal.Index).Value = CStr(modCommon.fn_GetValueCast(strItm, intValue))
                    Else
                        dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthIVal.Index).Value = modCommon.fn_GetValueCast(strItm, intValue)
                    End If
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthStatus.Index).Value = fn_GetHealthName(intHchkVal)
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthStatusVal.Index).Value = intHchkVal
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthUnit.Index).Value = strUnit
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthSeq.Index).Value = intSeq
                    dgvGrpHealth.Rows(intIDx).Cells(colDgvHealthRegDate.Index).Value = strRegDt
                    dgvGrpHealth.Rows(intIDx).Tag = p_clsMsgData.fn_GetSpecificData(strItm, "COLUMNS")
                Else
                    If VarType(modCommon.fn_GetValueCast(strItm, intValue)) = vbLong Then
                        dgvHealthRow.Cells(colDgvHealthIVal.Index).Value = CStr(modCommon.fn_GetValueCast(strItm, intValue))
                    Else
                        dgvHealthRow.Cells(colDgvHealthIVal.Index).Value = fn_GetValueCast(strItm, intValue)
                    End If
                    dgvHealthRow.Cells(colDgvHealthStatus.Index).Value = fn_GetHealthName(intHchkVal)
                    dgvHealthRow.Cells(colDgvHealthStatusVal.Index).Value = intHchkVal
                    dgvHealthRow.Cells(colDgvHealthUnit.Index).Value = strUnit
                    dgvHealthRow.Cells(colDgvHealthSeq.Index).Value = intSeq
                    dgvHealthRow.Cells(colDgvHealthRegDate.Index).Value = strRegDt
                End If

            End Using

        Next


        modCommon.sb_GridSortChg(dgvGrpHealth)



        Dim dtBind As New DataTable
        dtBind.Columns.Add("REG_DATE", GetType(String))
        dtBind.Columns.Add("HCHK_NAME", GetType(String))
        dtBind.Columns.Add("VALUE", GetType(String))
        dtBind.Columns.Add("HCHK_VALUE", GetType(Integer))
        dtBind.Columns.Add("HCHK_VALUE_STRING", GetType(String))
        dtBind.Columns.Add("COMMEMTS", GetType(String))

        'Dim tmpDtView As DataView = TryCast(dgvEventLog.DataSource, DataView)

        'If tmpDtView IsNot Nothing Then
        '    If tmpDtView.Count > 5000 - dtTable.Rows.Count Then
        '        Do Until tmpDtView.Count = 5000 - dtTable.Rows.Count
        '            tmpDtView.Delete(0)
        '        Loop
        '    End If
        '    dtBind = tmpDtView.ToTable
        'End If


        Dim arrValue As New ArrayList
        If _ShowHchkNormal Then
            arrValue.Add("'" & 100 & "'")
        End If
        If _ShowHchkWarning Then
            arrValue.Add("'" & 200 & "'")
        End If
        If _ShowHchkCritical Then
            arrValue.Add("'" & 300 & "'")
        End If
        Dim strSubQuery As String = String.Join(",", arrValue.ToArray)
        For Each tmpRow As DataRow In dtTable.Select(String.Format("INSTANCE_ID='{0}' AND HCHK_VALUE IN ({1}) ", Me.InstanceID, strSubQuery))
            Dim tmpBdRow As DataRow = dtBind.Rows.Add(tmpRow.Item("REG_DATE"), _
                                                      p_clsMsgData.fn_GetData(tmpRow.Item("HCHK_NAME")), _
                                                      fn_GetValueCast(tmpRow.Item("HCHK_NAME"), ConvULong(tmpRow.Item("VALUE"))) & " [" & tmpRow.Item("UNIT") & "]", _
                                                      tmpRow.Item("HCHK_VALUE"), _
                                                      modCommon.fn_GetHealthName(CInt(tmpRow.Item("HCHK_VALUE"))), _
                                                      tmpRow.Item("COMMENTS"))

            'tmpBdRow.ItemArray = tmpRow.ItemArray.Clone

        Next
        dtBind.AcceptChanges()

        'dgvEventLog.DataSource = dtBind.DefaultView
        ''dgvEventLog.TopLeftHeaderCell = dgvEventLog.(dgvEventLog.Rows.Count - 1).Cells(0)
        'If dgvEventLog.RowCount > 0 Then
        '    dgvEventLog.Rows(dgvEventLog.Rows.Count - 1).Selected = True
        '    dgvEventLog.FirstDisplayedScrollingRowIndex = dgvEventLog.Rows.Count - 1
        'End If

        Dim intMAxVal As Integer = dtTable.AsEnumerable.Where(Function(e) e.Field(Of Integer)("INSTANCE_ID") = Me.InstanceID).Max(Function(e) e.Field(Of Integer)("HCHK_VALUE"))
        lblHealth.Text = fn_GetHealthName(intMAxVal)
        rndProgHealth.CpuGaugeColor = sb_RageValueColor(intMAxVal, p_RageHealthClr)



        modCommon.sb_GridProgClrChg(dgvGrpHealth, colDgvHealthStatusVal.Index, p_RageHealthClr)

        'modCommon.sb_GridSortChg(dgvResUtilPerBackProc)


    End Sub




#End Region


    Private Sub rbHour1_CheckedChanged(sender As Object, e As EventArgs)

        If DirectCast(sender, BaseControls.RadioButton).Checked = True Then
            ' 현재 Tag로 넣었으나 3초 간격이고 실제 시간으로 계산하여 되어야 함. 
            ' 버튼 Tag로 값을 넣어 두었음. 
            '_ElapseCount = (60000 / _Elapseinterval) * 60 * CDbl(DirectCast(sender, BaseControls.RadioButton).Tag)
            _ElapseCount = (60000 / _Elapseinterval) * 60 / 6 ' 10분

            ' 시간 간격 선택시 각 Chart 초기화 및 이전 시간부터 초기 값 가져올것  ' 쿼리 조건을 별도로 구성하여서 가져옴. 


        End If


    End Sub

    Private Sub btnActInfo_Click(sender As Object, e As EventArgs) Handles btnActInfo.Click
        Dim BretFrm As frmMonActInfo = Nothing

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim frmDtl As frmMonActInfo = TryCast(tmpFrm, frmMonActInfo)
            If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = _InstanceID Then
                BretFrm = tmpFrm
                Exit For
            End If
        Next

        If BretFrm Is Nothing Then
            BretFrm = New frmMonActInfo(_ServerInfo, _Elapseinterval, AgentInfo)
            BretFrm.Show()
        Else
            BretFrm.Activate()
        End If



    End Sub

    Private Sub btnLogView_Click(sender As Object, e As EventArgs) Handles btnLogView.Click
        Dim BretFrm As frmLogView = Nothing

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim frmDtl As frmLogView = TryCast(tmpFrm, frmLogView)
            If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = _InstanceID Then
                BretFrm = tmpFrm
                Exit For
            End If
        Next

        If BretFrm Is Nothing Then
            BretFrm = New frmLogView(_ServerInfo, _Elapseinterval, AgentInfo)
            BretFrm.Show()
        Else
            BretFrm.Activate()
        End If



    End Sub



    Private Sub cmbPhysical_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhysical.SelectedIndexChanged
        If cmbPhysical.Tag IsNot Nothing AndAlso cmbPhysical.Tag.GetType.Equals(GetType(DataTable)) Then
            Dim dtTable As DataTable = TryCast(cmbPhysical.Tag, DataTable)
            Dim strDiskNm As String = DirectCast(sender, BaseControls.ComboBox).Text
            If Me.chtPhysicaliO.Tag Is Nothing OrElse Not Me.chtPhysicaliO.Tag.Equals(strDiskNm) Then
                For Each tmpSeries As DataVisualization.Charting.Series In Me.chtPhysicaliO.Series
                    tmpSeries.Points.Clear()
                Next
                initPhysical(strDiskNm)
            End If

            SetPhysical(strDiskNm, dtTable)

        End If



    End Sub


    Private Sub SetPhysical(ByVal strDiskNm As String, ByVal dtTable As DataTable)


        Dim dtRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND DISK_NAME = '{1}'", Me.InstanceID, strDiskNm))




        For Each tmpRow As DataRow In dtRows
            Dim dblRegDate As Double = ConvOADate(tmpRow.Item("REG_DATE"))
            Dim dblPhyRead As Double = ConvULong(tmpRow.Item("PHY_READ"))
            Dim dblPhyWrite As Double = ConvULong(tmpRow.Item("PHY_WRITE"))

            sb_ChartAddPoint(Me.chtPhysicaliO, "READ", dblRegDate, dblPhyRead)
            sb_ChartAddPoint(Me.chtPhysicaliO, "WRITE", dblRegDate, dblPhyWrite)
        Next

        sb_ChartAlignYAxies(Me.chtPhysicaliO)
    End Sub
    ''' <summary>
    ''' CPU / MEM 정보 초기 등록 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDataCpu()
        Me.Invoke(Sub()
                      Dim dtTable As DataTable = Nothing
                      Try
                          dtTable = _clsQuery.SelectInitCPUChart(InstanceID, p_ShowName.ToString("d"))

                          Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)

                          If dtRows.Count > 0 Then
                              Dim dblRegDate As Double
                              Dim dblCpuMain As Integer
                              Dim dblCpuWait As Integer

                              ' Cpu Information 
                              Using dgvAvgRow As DataGridViewRow = dgvCPU.FindFirstRow("AVG", colDgvCPUCPU.Index)
                                  If dgvAvgRow IsNot Nothing Then
                                      dgvAvgRow.Cells(colDgvCpuProg.Index).Value = dblCpuMain
                                      dgvAvgRow.Cells(colDgvCpuUtil.Index).Value = dblCpuMain / 100
                                  End If

                              End Using

                              Dim lastRow As Integer = 0
                              For Each tmpRow As DataRow In dtRows
                                  dblRegDate = ConvOADate(tmpRow.Item("REG_DATE"))
                                  dblCpuMain = ConvDBL(tmpRow.Item("CPU_MAIN"))
                                  dblCpuWait = ConvDBL(tmpRow.Item("WAIT_UTIL_RATE"))
                                  sb_ChartAddPoint(Me.chtCPU, "MAIN", dblRegDate, ConvULong(dblCpuMain))
                                  sb_ChartAddPoint(Me.chtCPU, "POSTGRES", dblRegDate, ConvULong(dblCpuWait))
                              Next

                              modCommon.sb_GridProgClrChg(dgvCPU)
                              sb_ChartAlignYAxies(Me.chtCPU)
                          End If
                      Catch ex As Exception
                          GC.Collect()
                      End Try
                  End Sub)
    End Sub
    ''' <summary>
    ''' SQL Response Time 정보 초기 등록 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDataSQLRespTm()
        Me.Invoke(Sub()
                      Dim dtTable As DataTable = Nothing
                      Try
                          dtTable = _clsQuery.SelectInitSQLRespTmChart(InstanceID)

                          Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)


                          ' Chart 데이터는 Invoke 로 넣어야 한다. 
                          If dtRows.Count = 0 Then
                              Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                              sb_ChartAddPoint(Me.chtSQLRespTm, "MAX", dblRegDt, 0)
                              sb_ChartAddPoint(Me.chtSQLRespTm, "AVG", dblRegDt, 0)
                          Else
                              For Each tmprow As DataRow In dtRows
                                  Dim dblRegDt As Double = ConvOADate(tmprow.Item("REG_DATE"))
                                  Dim dblMax As Double = ConvULong(tmprow.Item("MAX_SQL_ELAPSED_SEC"))
                                  Dim dblAvg As Double = ConvULong(tmprow.Item("AVG_SQL_ELAPSED_SEC"))

                                  sb_ChartAddPoint(Me.chtSQLRespTm, "MAX", dblRegDt, dblMax)
                                  sb_ChartAddPoint(Me.chtSQLRespTm, "AVG", dblRegDt, dblAvg)
                              Next
                          End If
                          sb_ChartAlignYAxies(Me.chtSQLRespTm)
                      Catch ex As Exception
                          GC.Collect()
                      End Try
                  End Sub)
    End Sub
    Private Sub initDataRequest()
        Me.Invoke(Sub()
                      Dim dtTableSession As DataTable = Nothing
                      Dim dtTable As DataTable = Nothing
                      Try
                          dtTableSession = _clsQuery.SelectInitSessionInfoChart(InstanceID, New Date(), New Date(), False)
                          Dim dtRowsSession As DataRow() = dtTableSession.Select("INSTANCE_ID=" & Me.InstanceID)
                          If dtRowsSession.Count = 0 Then
                              Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                              sb_ChartAddPoint(Me.chtSession, "BACKENDACT", dblRegDt, 0)
                              sb_ChartAddPoint(Me.chtSession, "BACKENDTOT", dblRegDt, 0)
                          Else
                              For Each tmpRow As DataRow In dtRowsSession
                                  Dim dblRegDt As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))
                                  sb_ChartAddPoint(Me.chtSession, "BACKENDACT", dblRegDt, ConvULong(tmpRow.Item("CUR_ACTV_BACKEND_CNT")))
                                  sb_ChartAddPoint(Me.chtSession, "BACKENDTOT", dblRegDt, ConvULong(tmpRow.Item("TOT_BACKEND_CNT")))
                              Next
                          End If

                          dtTable = _clsQuery.SelectInitObjectChart(InstanceID, p_ShowName.ToString("d"), New Date(), New Date(), False)
                          Dim dtRows As DataRow() = dtTable.Select("INSTANCE_ID=" & Me.InstanceID)
                          If dtRows.Count = 0 Then
                              Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                              sb_ChartAddPoint(Me.chtLocalIO, "READ", dblRegDt, 0)
                              sb_ChartAddPoint(Me.chtLocalIO, "INSERT", dblRegDt, 0)
                              sb_ChartAddPoint(Me.chtLocalIO, "UPDATE", dblRegDt, 0)
                              sb_ChartAddPoint(Me.chtLocalIO, "DELETE", dblRegDt, 0)
                          Else
                              For Each tmpRow As DataRow In dtRows
                                  Dim dblRegDt As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))
                                  ' Logical I/O Info   
                                  sb_ChartAddPoint(Me.chtLocalIO, "READ", dblRegDt, ConvULong(tmpRow.Item("SELECT_TUPLES_PER_SEC")))
                                  sb_ChartAddPoint(Me.chtLocalIO, "INSERT", dblRegDt, ConvULong(tmpRow.Item("INSERT_TUPLES_PER_SEC")))
                                  sb_ChartAddPoint(Me.chtLocalIO, "UPDATE", dblRegDt, ConvULong(tmpRow.Item("UPDATE_TUPLES_PER_SEC")))
                                  sb_ChartAddPoint(Me.chtLocalIO, "DELETE", dblRegDt, ConvULong(tmpRow.Item("DELETE_TUPLES_PER_SEC")))
                                  'This chart will move to object view 20180125
                                  'Dim dblRegDate As Double = ConvOADate(tmpRow.Item("COLLECT_DT"))
                                  'Dim dblIndexScan As Double = ConvULong(tmpRow.Item("INDEX_SCAN_TUPLES_PER_SEC"))
                                  'Dim dblSqlScan As Double = ConvULong(tmpRow.Item("SEQ_SCAN_TUPLES_PER_SEC"))
                                  'sb_ChartAddPoint(Me.chtObject, "INDEX", dblRegDate, dblIndexScan)
                                  'sb_ChartAddPoint(Me.chtObject, "SEQUENTIAL", dblRegDate, dblSqlScan)
                              Next
                          End If

                          'sb_ChartAlignYAxies(Me.chtObject) 'This chart will move to object view 20180125
                          sb_ChartAlignYAxies(Me.chtSession)
                          sb_ChartAlignYAxies(Me.chtLocalIO)
                      Catch ex As Exception
                          GC.Collect()
                      End Try
                  End Sub)
    End Sub

    Private Sub initPhysical(ByVal strDiskNm As String)
        Me.Invoke(Sub()
                      Dim dtTable As DataTable = _clsQuery.SelectInitPhysicalIOChart(InstanceID)
                      Dim dtRows As DataRow() = dtTable.Select(String.Format("INSTANCE_ID={0} AND DISK_NAME = '{1}'", Me.InstanceID, strDiskNm))
                      If dtRows.Count = 0 Then
                          Dim dblRegDt As Double = ConvOADate(Format(Now, "yyyy-MM-dd HH:mm:ss"))
                          sb_ChartAddPoint(Me.chtPhysicaliO, "READ", dblRegDt, 0)
                          sb_ChartAddPoint(Me.chtPhysicaliO, "WRITE", dblRegDt, 0)
                      Else
                          For Each tmpRow As DataRow In dtRows
                              Dim dblRegDate As Double = ConvOADate(tmpRow.Item("REG_DATE"))
                              Dim dblPhyRead As Double = ConvULong(tmpRow.Item("PHY_READ"))
                              Dim dblPhyWrite As Double = ConvULong(tmpRow.Item("PHY_WRITE"))

                              sb_ChartAddPoint(Me.chtPhysicaliO, "READ", dblRegDate, dblPhyRead)
                              sb_ChartAddPoint(Me.chtPhysicaliO, "WRITE", dblRegDate, dblPhyWrite)
                          Next
                      End If
                      sb_ChartAlignYAxies(Me.chtPhysicaliO)
                  End Sub)
    End Sub

    Private Sub grpHealth_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefreshPhysicaliO.Click, btnRefreshLogicaliO.Click, btnRefreshSqlResp.Click
        Select Case DirectCast(sender, BaseControls.Button).Name.ToUpper
            Case "BTNREFRESHSESSION"
                ChartClear(chtSession)
            Case "BTNREFRESHPHYSICALIO"
                ChartClear(chtPhysicaliO)
            Case "BTNREFRESHLOGICALIO"
                ChartClear(chtLocalIO)
                'This chart will move to object view 20180125
                'Case "BTNREFRESHOBJECT"
                '    ChartClear(chtObject)
            Case "BTNREFRESHSQLRESP"
                ChartClear(chtSQLRespTm)
        End Select

    End Sub

    Private Sub ChartClear(ByVal Ctl As DataVisualization.Charting.Chart)
        For Each tmpSeries As DataVisualization.Charting.Series In Ctl.Series
            tmpSeries.Points.Clear()
        Next

        Ctl.Invalidate()

        'For Each tmpArea As DataVisualization.Charting.ChartArea In Ctl.ChartAreas
        '    tmpArea.RecalculateAxesScale()
        'Next

    End Sub

    Private Sub chtCPU_Click(sender As Object, e As EventArgs) Handles chtCPU.Click

    End Sub

    'Private Sub chtCPU_CursorPositionChanged(sender As Object, e As DataVisualization.Charting.CursorEventArgs) Handles chtCPU.CursorPositionChanged _
    '                                                                                                                    , chtLocalIO.CursorPositionChanged _
    '                                                                                                                    , chtPhysicaliO.CursorPositionChanged _
    '                                                                                                                    , chtSQLRespTm.CursorPositionChanged
    '    If Double.IsNaN(e.NewPosition) Then Return
    '    Dim stDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionStart)
    '    Dim edDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionEnd)
    '    If stDt > edDt Then
    '        Dim tmpDt As DateTime
    '        tmpDt = stDt
    '        stDt = edDt
    '        edDt = tmpDt
    '    End If

    '    If DateDiff(DateInterval.Minute, stDt, edDt) < 0 Then
    '        MsgBox(p_clsMsgData.fn_GetData("M014"))
    '        Return
    '    Else
    '        If DateDiff(DateInterval.Minute, stDt, edDt) > 120 Then
    '            MsgBox(p_clsMsgData.fn_GetData("M015"))
    '            Return
    '        End If
    '    End If



    '    Dim ctlChart As DataVisualization.Charting.Chart = DirectCast(sender, DataVisualization.Charting.Chart)
    '    ctlChart.ChartAreas(0).CursorX.SetSelectionPosition(-1, -1)
    '    ctlChart.ChartAreas(0).CursorX.SetCursorPosition(-1)
    '    Dim frmRpt As New frmReports(DirectCast(Me.Owner, frmMonMain).AgentCn, DirectCast(Me.Owner, frmMonMain).GrpList, Me.InstanceID, stDt, edDt, _AgentInfo)
    '    frmRpt.Show(DirectCast(Me.Owner, frmMonMain))



    'End Sub

    Private Sub rndProgMEM_Click(sender As Object, e As EventArgs) Handles rndProgMEM.Click

    End Sub

    Private Sub rtbSvrInfo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvGrpHealth_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpHealth.CellContentClick
        Dim intRow As Integer = e.RowIndex
        If intRow > -1 Then
            Dim dgvRow As DataGridViewRow = DirectCast(sender, BaseControls.DataGridView).Rows(intRow)
            ' TAG에 DATAGRIDVIEW TAG정보를 넣어 두었음 만약 없다면 설정이 없는것으로 판단하고 팝업을 띄우지 않는다.
            If dgvRow.Tag.ToString <> "" Then
                Dim RegDt As String = dgvRow.Cells(colDgvHealthRegDate.Index).Value
                Dim HealthItem As String = dgvRow.Cells(colDgvHealthItm.Index).Value
                Dim HealthSeq As String = dgvRow.Cells(colDgvHealthSeq.Index).Value
                Dim strValue As String = String.Format("{0} {1}[{2}]", dgvRow.Cells(colDgvHealthIVal.Index).Value, dgvRow.Cells(colDgvHealthUnit.Index).Value, dgvRow.Cells(colDgvHealthStatus.Index).Value)

                Dim frmHealthDtl As New frmHealthDetail(AgentCn, InstanceID, RegDt, HealthItem, HealthSeq, strValue, _AgentInfo)
                frmHealthDtl.Show(Me)
            End If

        End If
    End Sub

    Private Sub dgvGrpHealth_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpHealth.CellContentDoubleClick

    End Sub

    Private Sub nudBackendcnt_ValueChanged(sender As Object, e As EventArgs) Handles nudBackendcnt.ValueChanged
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("FORM", "SESSIONDETAIL", DirectCast(sender, BaseControls.NumericUpDown).Value)


    End Sub

    Private Sub chkIDLE_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDLE.CheckedChanged
        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("FORM", "IDLEDETAIL", chkIDLE.Checked)
    End Sub

    Private Sub dgvGrpHealth_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGrpHealth.CellMouseMove
        If e.RowIndex >= 0 Then
            dgvGrpHealth.Cursor = Cursors.Hand
            If dgvGrpHealth.Rows(e.RowIndex).Selected = False Then
                dgvGrpHealth.ClearSelection()
                dgvGrpHealth.Rows(e.RowIndex).Selected = True
            End If
            dgvGrpHealth.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 40, 70)
        End If
    End Sub

    Private Sub dgvGrpHealth_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrpHealth.CellMouseLeave
        If e.RowIndex >= 0 Then
            dgvGrpHealth.Cursor = Cursors.Arrow
            If dgvGrpHealth.Rows(e.RowIndex).Selected = True Then
                dgvGrpHealth.ClearSelection()
                dgvGrpHealth.Rows(e.RowIndex).Selected = False
            End If
            dgvGrpHealth.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = dgvGrpHealth.DefaultCellStyle.SelectionBackColor
        End If
    End Sub

    'Private Sub dgvResUtilPerBackProc_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvResUtilPerBackProc.CellMouseMove
    '    If e.RowIndex >= 0 Then
    '        'If e.ColumnIndex = coldgvResUtilPerBackProcSQL.Index Then
    '        dgvResUtilPerBackProc.Cursor = Cursors.Hand
    '        If dgvResUtilPerBackProc.Rows(e.RowIndex).Selected = False Then
    '            dgvResUtilPerBackProc.ClearSelection()
    '            dgvResUtilPerBackProc.Rows(e.RowIndex).Selected = True
    '        End If
    '        dgvResUtilPerBackProc.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 40, 70)
    '        'End If
    '    End If
    'End Sub

    'Private Sub dgvResUtilPerBackProc_CellMouseLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResUtilPerBackProc.CellMouseLeave
    '    If e.RowIndex >= 0 Then
    '        'If e.ColumnIndex = coldgvResUtilPerBackProcSQL.Index Then
    '        dgvResUtilPerBackProc.Cursor = Cursors.Arrow
    '        If dgvResUtilPerBackProc.Rows(e.RowIndex).Selected = True Then
    '            dgvResUtilPerBackProc.ClearSelection()
    '            dgvResUtilPerBackProc.Rows(e.RowIndex).Selected = False
    '        End If
    '        dgvResUtilPerBackProc.Rows(e.RowIndex).DefaultCellStyle.SelectionBackColor = dgvResUtilPerBackProc.DefaultCellStyle.SelectionBackColor
    '        'End If
    '    End If
    'End Sub

    Private Sub btnSqlPlan_Click(sender As Object, e As EventArgs) Handles btnSqlPlan.Click
        Dim frmQuery As New frmQueryView("", "", InstanceID, _AgentInfo, "")
        frmQuery.Show()
    End Sub

    Private Sub btnSessionLock_Click(sender As Object, e As EventArgs) Handles btnSessionLock.Click
        Dim BretFrm As frmSessionLock = Nothing

        For Each tmpFrm As Form In My.Application.OpenForms
            Dim frmDtl As frmSessionLock = TryCast(tmpFrm, frmSessionLock)
            If frmDtl IsNot Nothing AndAlso frmDtl.InstanceID = _InstanceID Then
                BretFrm = tmpFrm
                Exit For
            End If
        Next

        If BretFrm Is Nothing Then
            BretFrm = New frmSessionLock(_ServerInfo, _Elapseinterval, AgentInfo, _AgentCn)
            BretFrm.Show()
        Else
            BretFrm.Activate()
        End If
    End Sub

    Private Sub chtSession_CursorPositionChanged(sender As Object, e As DataVisualization.Charting.CursorEventArgs) Handles chtSession.CursorPositionChanged _
                                                                                                                        , chtCPU.CursorPositionChanged _
                                                                                                                        , chtLocalIO.CursorPositionChanged _
                                                                                                                        , chtPhysicaliO.CursorPositionChanged _
                                                                                                                        , chtSQLRespTm.CursorPositionChanged

        If Double.IsNaN(e.NewPosition) Then Return
        Dim stDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionStart)
        Dim edDt As DateTime = Date.FromOADate(e.ChartArea.CursorX.SelectionEnd)
        If stDt > edDt Then
            Dim tmpDt As DateTime
            tmpDt = stDt
            stDt = edDt
            edDt = tmpDt
        End If

        If DateDiff(DateInterval.Minute, stDt, edDt) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return
        Else
            If DateDiff(DateInterval.Minute, stDt, edDt) > 120 Then
                MsgBox(p_clsMsgData.fn_GetData("M015", "2"))
                Return
            End If
        End If

        Dim ctlChart As DataVisualization.Charting.Chart = DirectCast(sender, DataVisualization.Charting.Chart)
        ctlChart.ChartAreas(0).CursorX.SetSelectionPosition(-1, -1)
        ctlChart.ChartAreas(0).CursorX.SetCursorPosition(-1)
        Dim index As Integer
        Select Case ctlChart.Name
            Case "chtCPU"
                index = 0
            Case "chtSession"
                index = 1
            Case "chtLocalIO"
                index = 2
            Case "chtPhysicalIO"
                index = 3
            Case "chtSQLRespTm"
                index = 4
        End Select

        Dim frmRpt As New frmMonItemDetail(DirectCast(Me.Owner, frmMonMain).AgentCn, DirectCast(Me.Owner, frmMonMain).GrpListServerinfo, Me.InstanceID, stDt, edDt, _AgentInfo, index)
        frmRpt.Show(DirectCast(Me.Owner, frmMonMain))
    End Sub

    Private Sub dgvResUtilPerBackProc_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResUtilPerBackProc.CellDoubleClick
        If dgvResUtilPerBackProc.RowCount <= 0 Then Return
        'SQL
        If e.RowIndex >= 0 Then
            Dim frmQuery As New frmQueryView(dgvResUtilPerBackProc.Rows(e.RowIndex).Cells(coldgvResUtilPerBackProcSQL.Index).Value, dgvResUtilPerBackProc.Rows(e.RowIndex).Cells(coldgvResUtilPerBackProcDB.Index).Value, InstanceID, _AgentInfo, dgvResUtilPerBackProc.Rows(e.RowIndex).Cells(coldgvResUtilPerBackProcUser.Index).Value)
            frmQuery.Show()
        End If
    End Sub

    Private Sub EspRight_SplitterMoved(sender As Object, e As SplitterEventArgs)

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub

    'Private Sub btnChartDetail_Click(sender As Object, e As EventArgs) Handles btnChartDetail.Click
    '    Dim stDt As DateTime = Now.AddMinutes(-5)
    '    Dim edDt As DateTime = Now

    '    Dim frmRpt As New frmMonItemDetail(DirectCast(Me.Owner, frmMonMain).AgentCn, DirectCast(Me.Owner, frmMonMain).GrpListServerinfo, Me.InstanceID, stDt, edDt, _AgentInfo, -1)
    '    frmRpt.Show(DirectCast(Me.Owner, frmMonMain))
    'End Sub
End Class
