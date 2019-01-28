Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmReports

    Private _AgentCn As eXperDB.ODBC.eXperDBODBC
    Private _GrpLst As List(Of GroupInfo)

    Private _ShownSearch As Boolean = False
    Private _clsQuery As clsQuerys  ' Main Thread용
    Private _clsQuerySub As clsQuerys ' Disk Thread 용 
    Private _AgentInfo As structAgent

    ' 임시 전역 변수 
    Private _dtDB As DataTable = Nothing
    Private _dtSession As DataTable = Nothing
    Private _dtSql As DataTable = Nothing
    Private _ServerInfo As GroupInfo.ServerInfo = Nothing
    Private _SvrpList As List(Of GroupInfo.ServerInfo)

    Private WithEvents _ProgresForm As frmProgres

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal GrpLst As List(Of GroupInfo), ByVal AgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        ' Form Default
        cmbInst.Items.Clear()
        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next
        _GrpLst = GrpLst
        '_AgentCn = AgentCn
        _AgentCn = New eXperDBODBC(AgentCn.ODBCConninfo, 30)
        _clsQuery = New clsQuerys(_AgentCn)
        _clsQuerySub = New clsQuerys(_AgentCn)
        _AgentInfo = AgentInfo

        'dtpEd.Value = dtpSt.Value.AddMinutes(1)

        dtpSt.Value = dtpSt.Value.AddMinutes(-120)

        'Me.FormControlBox1.UseConfigBox = False
        'Me.FormControlBox1.UseCriticalBox = False
        'Me.FormControlBox1.UseLockBox = False
        'Me.FormControlBox1.UseRotationBox = False
        'Me.FormControlBox1.UsePowerBox = False

        initChart()


    End Sub

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal GrpLst As List(Of GroupInfo), ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, ByVal AgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        ' Form Default
        cmbInst.Items.Clear()
        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next
        _GrpLst = GrpLst
        '_AgentCn = AgentCn
        _AgentCn = New eXperDBODBC(AgentCn.ODBCConninfo, 30)
        _clsQuery = New clsQuerys(_AgentCn)
        _clsQuerySub = New clsQuerys(_AgentCn)
        dtpSt.Value = stDt.AddMinutes(-1)
        dtpEd.Value = edDt.AddMinutes(1)
        cmbInst.SelectedValue = intInstanceID
        _AgentInfo = AgentInfo

        initChart()

        _ShownSearch = True

    End Sub

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal ServerInfo As List(Of GroupInfo.ServerInfo), ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, ByVal AgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        ' Form Default

        _SvrpList = ServerInfo

        cmbInst.Items.Clear()

        For Each tmpSvr As GroupInfo.ServerInfo In ServerInfo
            cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
        Next

        '_AgentCn = AgentCn
        _AgentCn = New eXperDBODBC(AgentCn.ODBCConninfo, 30)
        _clsQuery = New clsQuerys(_AgentCn)
        _clsQuerySub = New clsQuerys(_AgentCn)
        dtpSt.Value = stDt.AddMinutes(-1)
        dtpEd.Value = edDt.AddMinutes(1)
        cmbInst.SelectedValue = intInstanceID
        _AgentInfo = AgentInfo

        initChart()

        _ShownSearch = True

    End Sub

    Public Sub frmReports_ReLoad(ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime)
        Dim prevStdt As DateTime = dtpSt.Value
        Dim prevInstanceIndex = cmbInst.SelectedIndex

        dtpSt.Value = stDt
        dtpEd.Value = edDt
        dtpSt.Tag = stDt
        dtpEd.Tag = edDt

        cmbInst.SelectedValue = intInstanceID

        btnSearch.PerformClick()
    End Sub

    Public Function MakeBaseRBCtl(ByVal Title As String) As BaseControls.RadioButton

        Dim rtnRB As New eXperDB.BaseControls.RadioButton()
        '
        'rbGrp3
        '
        rtnRB.Appearance = System.Windows.Forms.Appearance.Button
        rtnRB.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        rtnRB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        rtnRB.ForeColor = System.Drawing.Color.White
        rtnRB.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        rtnRB.Location = New System.Drawing.Point(3, 3)
        rtnRB.Radius = 10
        rtnRB.Size = New System.Drawing.Size(120, 30)
        rtnRB.TabIndex = 5
        rtnRB.Text = Title
        rtnRB.UnCheckFillColor = System.Drawing.Color.Black
        rtnRB.UseRound = True
        rtnRB.UseVisualStyleBackColor = True
        rtnRB.Warning = False
        rtnRB.WarningColor = System.Drawing.Color.Red
        Return rtnRB
    End Function

    Public Function MakeBaseCheckCtl(ByVal Title As String) As BaseControls.CheckBox

        Dim rtnChk As New eXperDB.BaseControls.CheckBox()
        '
        'rbGrp3
        '
        rtnChk.Appearance = System.Windows.Forms.Appearance.Button
        rtnChk.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        rtnChk.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        rtnChk.ForeColor = System.Drawing.Color.White
        rtnChk.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        rtnChk.Location = New System.Drawing.Point(3, 3)
        rtnChk.Radius = 10
        rtnChk.Size = New System.Drawing.Size(100, 23)
        rtnChk.TabIndex = 5
        rtnChk.Text = Title
        rtnChk.UnCheckFillColor = System.Drawing.Color.Black
        rtnChk.UseRound = True
        rtnChk.UseVisualStyleBackColor = True

        Return rtnChk
    End Function

    Private Sub initChart()
        lblInst.Text = p_clsMsgData.fn_GetData("F146")
        lblInstDt.Text = p_clsMsgData.fn_GetData("F157")



        btnSearch.Text = p_clsMsgData.fn_GetData("F151")

        ' Grid CPU
        'grpRptCpu.Text = p_clsMsgData.fn_GetData("F164")
        'dgvRptCpu.AutoGenerateColumns = False
        '' colDgvRptCpuHostNm.HeaderText = p_clsMsgData.fn_GetData("F146")
        'colDgvRptCpuUser.HeaderText = p_clsMsgData.fn_GetData("F147")
        'colDgvRptCpuSys.HeaderText = p_clsMsgData.fn_GetData("F148")
        'colDgvRptCpuWait.HeaderText = p_clsMsgData.fn_GetData("F149")
        'colDgvRptCpuIDLE.HeaderText = p_clsMsgData.fn_GetData("F150")
        'coldgvRptCPUNice.HeaderText = p_clsMsgData.fn_GetData("F188")

        ' Chart CPU 
        Me.chtRptCpu.AddSeries("USED", "USED", Color.Red)
        Me.chtRptCpu.AddSeries("WAIT", "WAIT", Color.Lime)
        Me.chtRptCpu.SetAxisXTitle("CPU Usage(MAX)")
        Me.chtRptCpu.SetAxisYTitle("RATE(%)")
        'Me.chtRptCpu.SetDefaultMean("USED")

        Me.chtRptMem.AddSeries("MEM", "MEM", Color.Red)
        Me.chtRptMem.AddSeries("SWAP", "SWAP", Color.Lime)
        Me.chtRptMem.SetAxisXTitle("MEM Usage(MAX)")
        Me.chtRptMem.SetAxisYTitle("RATE(%)")

        chtRptDiskUsage.SetAxisXTitle(p_clsMsgData.fn_GetData("F044") + "(MAX)")
        chtRptDiskUsage.SetAxisYTitle("Usage(%)")
        chtRptDisk.SetAxisXTitle(p_clsMsgData.fn_GetData("F153"))
        chtRptDisk.SetAxisYTitle("KB/s")
        chtRptDiskRate.SetAxisXTitle(p_clsMsgData.fn_GetData("F154"))
        chtRptDiskRate.SetAxisYTitle("BUSY RATE(%)")


        'Table Access

        'dgvRptTbAccess.AutoGenerateColumns = False
        'colDgvRptTbAccessBufferRead.HeaderText = p_clsMsgData.fn_GetData("F160")
        'colDgvRptTbAccessHitRatio.HeaderText = p_clsMsgData.fn_GetData("F161")
        'colDgvRptTbAccessInsert_Tuples.HeaderText = p_clsMsgData.fn_GetData("F162")
        'colDgvRptTbAccessUpdate_Tuples.HeaderText = p_clsMsgData.fn_GetData("F163")
        'colDgvRptTbAccessDelete_Tuples.HeaderText = p_clsMsgData.fn_GetData("F173")
        'colDgvRptTbAccessSelect_Tuples.HeaderText = p_clsMsgData.fn_GetData("F174")
        'colDgvRptTbAccessSeqTuples.HeaderText = p_clsMsgData.fn_GetData("F175")
        'colDgvRptTbAccessIndexTuples.HeaderText = p_clsMsgData.fn_GetData("F176")
        'colDgvRptTbAccessSeqScan.HeaderText = p_clsMsgData.fn_GetData("F177")
        'colDgvRptTbAccessIndexScan.HeaderText = p_clsMsgData.fn_GetData("F178")




        ' SQL 정보



        ' Session 
        'grpRptTimeLine.Text = p_clsMsgData.fn_GetData("F155")
        'dgvRptSession.AutoGenerateColumns = False
        'colDgvRptSessionActive.HeaderText = p_clsMsgData.fn_GetData("F168")
        'colDgvRptSessionIDLE.HeaderText = p_clsMsgData.fn_GetData("F169")
        'colDgvRptSessionIDLETrans.HeaderText = p_clsMsgData.fn_GetData("F170")


        'Session Chart
        Me.chtSession.AddSeries("ACTIVE", "ACTIVE", Color.Red)
        Me.chtSession.AddSeries("IDLE", "IDLE", Color.Orange)
        Me.chtSession.AddSeries("TRANS", "IDLE TRANX", Color.Lime)
        Me.chtSession.SetAxisXTitle(p_clsMsgData.fn_GetData("F167"))
        Me.chtSession.SetAxisYTitle("COUNT")


        ' Logical I/O
        'grpRptLogical.Text = p_clsMsgData.fn_GetData("F166")
        chtLogical.AddSeries("INSERT", "INSERT", Color.FromArgb(0, 112, 192))
        chtLogical.AddSeries("UPDATE", "UPDATE", Color.Orange)
        chtLogical.AddSeries("DELETE", "DELETE", Color.Red)
        chtLogical.SetAxisY2(Color.Lime)
        chtLogical.AddSeries("READ", "READ", Color.Lime, YAxisType:=AxisType.Secondary)
        chtLogical.SetAxisXTitle(p_clsMsgData.fn_GetData("F166"))
        chtLogical.SetAxisYTitle("TUPLES")


        ' Physical I/O
        'grpRptLogical.Text = p_clsMsgData.fn_GetData("F166")
        chtPhysicalIO.AddSeries("READ", "READ", Color.YellowGreen)
        chtPhysicalIO.SetAxisXTitle(p_clsMsgData.fn_GetData("F091"))
        chtPhysicalIO.SetAxisYTitle("Blocks")

        ' Object Access
        'grpObject.Text = p_clsMsgData.fn_GetData("F168")
        chtObjectTuple.AddSeries("AVG_SEQ_SCAN", "SEQ SCAN", Color.Red)
        chtObjectTuple.AddSeries("AVG_INDEX_SCAN", "INDEX SCAN", Color.Lime)
        chtObjectTuple.SetAxisXTitle(p_clsMsgData.fn_GetData("F156"))
        chtObjectTuple.SetAxisYTitle("TUPLES")
        chtObjectRate.AddSeries("SEQ_SCAN", "SEQ SCAN", Color.Red)
        chtObjectRate.AddSeries("INDEX_SCAN", "INDEX SCAN", Color.Lime)
        chtObjectRate.SetMaximumAxisY(100)
        chtObjectRate.SetAxisXTitle(p_clsMsgData.fn_GetData("F158"))
        chtObjectRate.SetAxisYTitle("RATE(%)")



        chtBuffer.AddSeries("DISK_READ_KB", "DISK READ", Color.Red)
        chtBuffer.AddSeries("BUFFER_READ_KB", "BUFFER READ", Color.Lime)
        chtBuffer.SetAxisXTitle(p_clsMsgData.fn_GetData("F169"))
        chtBuffer.SetAxisYTitle("KB")

        chtBufferrate.AddSeries("HIT_RATIO", "BUFFER HIT", Color.Red)
        chtBufferrate.SetMaximumAxisY(100)
        chtBufferrate.SetAxisXTitle(p_clsMsgData.fn_GetData("F159"))
        chtBufferrate.SetAxisYTitle("RATE(%)")



        '' DB Access
        'dgvRptDBAccess.AutoGenerateColumns = False
        'grpRptDBAccess.Text = p_clsMsgData.fn_GetData("F171")


        'coldgvRptDBAccessDBNm.HeaderText = p_clsMsgData.fn_GetData("F172")
        'coldgvRptDBAccessHitRatio.HeaderText = p_clsMsgData.fn_GetData("F173")
        'coldgvRptDBAccessDiskBlockRead.HeaderText = p_clsMsgData.fn_GetData("F174")
        'coldgvRptDBAccessBuffer.HeaderText = p_clsMsgData.fn_GetData("F175")


        'Me.chtRptDiskRate.SetAxisYTitle("Rate(%)")
        'Me.chtRptDisk.SetAxisYTitle("Value")


        '' Transcation 
        'dgvRptTrans.AutoGenerateColumns = False
        'grpRptTrans.Text = p_clsMsgData.fn_GetData("F176")

        'colDgvRptTransDBNm.HeaderText = p_clsMsgData.fn_GetData("F172")
        'colDgvRptTransUpd.HeaderText = p_clsMsgData.fn_GetData("F177")
        'colDgvRptTransIns.HeaderText = p_clsMsgData.fn_GetData("F178")
        'colDgvRptTransDel.HeaderText = p_clsMsgData.fn_GetData("F179")
        'colDgvRptTransSel.HeaderText = p_clsMsgData.fn_GetData("F180")

        ' SQL 
        'grpRptSQL.Text = p_clsMsgData.fn_GetData("F186")
        dgvRptSQL.AutoGenerateColumns = False
        colDgvRptSqlDBNm.HeaderText = p_clsMsgData.fn_GetData("F172")
        colDgvRptSqlCpuMax.HeaderText = p_clsMsgData.fn_GetData("F181")
        colDgvRptSqlCpuTime.HeaderText = p_clsMsgData.fn_GetData("F231")
        colDgvRptSqlCount.HeaderText = p_clsMsgData.fn_GetData("F232")
        colDgvRptSqlAddr.HeaderText = p_clsMsgData.fn_GetData("F182")
        colDgvRptSqlElapsedMax.HeaderText = p_clsMsgData.fn_GetData("F183")
        colDgvRptSqlUser.HeaderText = p_clsMsgData.fn_GetData("F184")
        colDgvRptSqlStart.HeaderText = p_clsMsgData.fn_GetData("F050")
        colDgvRptSqlSql.HeaderText = p_clsMsgData.fn_GetData("F185")

        Me.btnSearch.Text = p_clsMsgData.fn_GetData("F151")
        Me.btnPrint.Text = p_clsMsgData.fn_GetData("F171")


        Me.chtRptCpu.SetInnerPlotPosition()
        Me.chtRptMem.SetInnerPlotPosition()
        Me.chtRptDiskUsage.SetInnerPlotPosition()
        Me.chtRptDisk.SetInnerPlotPosition()
        Me.chtRptDiskRate.SetInnerPlotPosition()
        Me.chtSession.SetInnerPlotPosition()
        Me.chtLogical.SetInnerPlotPosition()
        Me.chtPhysicalIO.SetInnerPlotPosition()
        Me.chtBuffer.SetInnerPlotPosition()
        Me.chtBufferrate.SetInnerPlotPosition()
        Me.chtObjectRate.SetInnerPlotPosition()
        Me.chtObjectTuple.SetInnerPlotPosition()

    End Sub

    Private Event WaitMag(ByVal str As String)
    Private Event WaitComplete()

    Private WithEvents _frmW As frmWait

    Private Sub Thmain(ByVal intInstance As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal enmSvrNm As clsEnums.ShowName)

        'Dim clsQuery As New clsQuerys(_AgentCn)
        Dim dtTable As DataTable = Nothing

        ' CPU
        Dim tmpTh As Threading.Thread
        'RaiseEvent WaitMag("CPU Information")
        'tmpTh = New Threading.Thread(Sub()
        '                                 Try
        '                                     dtTable = _clsQuery.SelectReportCPU(intInstance, stDate, edDate)
        '                                 Catch ex As Exception
        '                                     p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                     GC.Collect()
        '                                 End Try
        '                             End Sub)
        'tmpTh.Start()
        'tmpTh.Join()
        'If dtTable IsNot Nothing Then
        '    dgvRptCpu.Invoke(New MethodInvoker(Sub()
        '                                           Try
        '                                               dgvRptCpu.DataSource = dtTable
        '                                           Catch ex As Exception
        '                                               p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                               GC.Collect()
        '                                           End Try
        '                                       End Sub))
        '    dtTable = Nothing
        'End If

        ' CPU Chart 
        RaiseEvent WaitMag("CPU Information")
        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             dtTable = _clsQuery.SelectReportCPUChartStats(intInstance, stDate, edDate)
                                         Catch ex As Exception
                                             GC.Collect()
                                         End Try
                                     End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            chtRptCpu.Invoke(New MethodInvoker(Sub()
                                                   Try
                                                       chtRptCpu.SetMinimumAxisX(ConvOADate(stDate))
                                                       chtRptCpu.SetMaximumAxisX(ConvOADate(edDate))
                                                       chtRptMem.SetMinimumAxisX(ConvOADate(stDate))
                                                       chtRptMem.SetMaximumAxisX(ConvOADate(edDate))
                                                       For i As Integer = 0 To dtTable.Rows.Count - 1
                                                           Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DATE"))
                                                           Me.chtRptCpu.AddPoints("USED", tmpDate, ConvULong(dtTable.Rows(i).Item("USED_UTIL_RATE")))
                                                           Me.chtRptCpu.AddPoints("WAIT", tmpDate, ConvULong(dtTable.Rows(i).Item("WAIT_UTIL_RATE")))
                                                           Me.chtRptMem.AddPoints("MEM", tmpDate, ConvULong(dtTable.Rows(i).Item("MEM_USED_RATE")))
                                                           Me.chtRptMem.AddPoints("SWAP", tmpDate, ConvULong(dtTable.Rows(i).Item("SWP_USED_RATE")))
                                                       Next

                                                       Me.chtRptCpu.ShowMaxValue(True)
                                                       Me.chtRptMem.ShowMaxValue(True)


                                                   Catch ex As Exception
                                                       p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                       GC.Collect()
                                                   End Try
                                               End Sub))
            dtTable = Nothing
        End If

        ' DISK Usage Chart
        RaiseEvent WaitMag("DISK Information")
        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             dtTable = _clsQuery.SelectReportDiskUsage(intInstance, stDate, edDate)
                                         Catch ex As Exception
                                             GC.Collect()
                                         End Try
                                     End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            chtRptDiskUsage.Invoke(New MethodInvoker(Sub()
                                                         Try
                                                             chtRptDiskUsage.SetMinimumAxisX(ConvOADate(stDate))
                                                             chtRptDiskUsage.SetMaximumAxisX(ConvOADate(edDate))

                                                             chtRptDiskUsage.SeriesClear()

                                                             Dim groupedRows = _
                                                                dtTable.AsEnumerable().GroupBy( _
                                                                    Function(r) New With {Key .MOUNTPOINT = r.Field(Of String)("MOUNTPOINT")} _
                                                                             ).[Select]( _
                                                                             Function(grp) _
                                                                                 New With {Key .MOUNTPOINT = grp.Key.MOUNTPOINT} _
                                                                                       )
                                                             For i As Integer = 0 To groupedRows.Count - 1
                                                                 Dim mt As String = groupedRows.AsEnumerable.ToList(i).MOUNTPOINT
                                                                 chtRptDiskUsage.AddSeries(mt, mt)
                                                             Next

                                                             'groupedRows.AsEnumerable.Tolist(0).MOUNTPOINT
                                                             For i As Integer = 0 To dtTable.Rows.Count - 1
                                                                 Dim tmpDate As Double = ConvOADate(dtTable.Rows(i).Item("COLLECT_DATE"))
                                                                 Me.chtRptDiskUsage.AddPoints(dtTable.Rows(i).Item("MOUNTPOINT"), tmpDate, ConvULong(dtTable.Rows(i).Item("USAGE")))
                                                             Next

                                                             Me.chtRptDiskUsage.ShowMaxValue(True)


                                                         Catch ex As Exception
                                                             p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                             GC.Collect()
                                                         End Try
                                                     End Sub))
            dtTable = Nothing
        End If

        ' DISK I/O Chart
        chtRptDisk.Invoke(New MethodInvoker(Sub()
                                                Try
                                                    chtRptDisk.SeriesClear()
                                                    chtRptDiskRate.SeriesClear()
                                                Catch ex As Exception
                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                    GC.Collect()
                                                End Try
                                            End Sub))


        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             dtTable = _clsQuery.SelectReportDisk(intInstance, stDate, edDate)
                                         Catch ex As Exception
                                             p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                             GC.Collect()
                                         End Try
                                     End Sub)
        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            flpDisk.Invoke(New MethodInvoker(Sub()
                                                 Try
                                                     chtRptDisk.SetMinimumAxisX(ConvOADate(stDate))
                                                     chtRptDisk.SetMaximumAxisX(ConvOADate(edDate))
                                                     chtRptDiskRate.SetMinimumAxisX(ConvOADate(stDate))
                                                     chtRptDiskRate.SetMaximumAxisX(ConvOADate(edDate))
                                                     For Each tmpRow As DataRow In dtTable.Rows
                                                         Dim tmpRb As BaseControls.CheckBox = MakeBaseCheckCtl(tmpRow.Item("DISK_NAME"))
                                                         flpDisk.Controls.Add(tmpRb)
                                                         AddHandler tmpRb.CheckedChanged, AddressOf ChkDisk_CheckedChanged
                                                     Next
                                                     If flpDisk.Controls.Count > 0 Then
                                                         DirectCast(flpDisk.Controls(0), BaseControls.CheckBox).Checked = True
                                                     End If
                                                 Catch ex As Exception

                                                 End Try
                                             End Sub))

            'dgvRptDisk.Invoke(New MethodInvoker(Sub()
            '                                        Try


            '                                            dgvRptDisk.DataSource = dtTable
            '                                            'For Each tmpRow As DataRow In dtTable.Rows
            '                                            '    Dim intRow As Integer = dgvRptDisk.Rows.Add

            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskInstID.Index).Value = tmpRow.Item(colDgvRptDiskInstID.DataPropertyName)
            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskNm.Index).Value = tmpRow.Item(colDgvRptDiskNm.DataPropertyName)
            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskBusy.Index).Value = tmpRow.Item(colDgvRptDiskBusy.DataPropertyName)
            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskWrite.Index).Value = tmpRow.Item(colDgvRptDiskWrite.DataPropertyName)
            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskRead.Index).Value = tmpRow.Item(colDgvRptDiskRead.DataPropertyName)
            '                                            '    dgvRptDisk.Rows(intRow).Cells(colDgvRptDiskCheck.Index).Value = False

            '                                            'Next


            '                                            If dtTable.Rows.Count > 0 Then
            '                                                dgvRptDisk.Rows(0).Cells(colDgvRptDiskCheck.Index).Value = True
            '                                                'ShowDiskChart(intInstance, stDate, edDate, dgvRptDisk.Rows(0).Cells(colDgvRptDiskNm.Index).Value, True)
            '                                            End If
            '                                        Catch ex As Exception
            '                                            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            '                                            GC.Collect()
            '                                        End Try
            '                                    End Sub))
            dtTable = Nothing
        End If


        ' Session Chart 
        RaiseEvent WaitMag("Session Chart Information")
        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             'dtTable = _clsQuery.SelectReportSessionChart(intInstance, stDate, edDate)
                                             dtTable = _clsQuery.SelectReportSessionChartStats(intInstance, stDate, edDate)
                                         Catch ex As Exception
                                             p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                             GC.Collect()

                                         End Try
                                     End Sub)

        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            _dtSession = dtTable.Copy

            dtTable = Nothing
        End If

        ' Logical I/O , Object Access , Buffer HIT
        RaiseEvent WaitMag("Logical I/O , Object Access , Buffer HIT Information")
        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             'dtTable = _clsQuery.SelectReportTBAccess(intInstance, stDate, edDate, enmSvrNm)
                                             dtTable = _clsQuery.SelectReportTBAccessStats(intInstance, stDate, edDate, enmSvrNm)

                                         Catch ex As Exception
                                             p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                             GC.Collect()
                                         End Try
                                     End Sub)

        tmpTh.Start()
        tmpTh.Join()
        If dtTable IsNot Nothing Then
            _dtDB = dtTable.Copy

            ' Radio Button Adds
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Dim tmpDtTable As DataTable = dtTable.DefaultView.ToTable(True, "DB_NAME")
                                                chtSession.SetMinimumAxisX(ConvOADate(stDate))
                                                chtSession.SetMaximumAxisX(ConvOADate(edDate))
                                                chtLogical.SetMinimumAxisX(ConvOADate(stDate))
                                                chtLogical.SetMaximumAxisX(ConvOADate(edDate))
                                                chtPhysicalIO.SetMinimumAxisX(ConvOADate(stDate))
                                                chtPhysicalIO.SetMaximumAxisX(ConvOADate(edDate))
                                                chtBuffer.SetMinimumAxisX(ConvOADate(stDate))
                                                chtBuffer.SetMaximumAxisX(ConvOADate(edDate))
                                                chtBufferrate.SetMinimumAxisX(ConvOADate(stDate))
                                                chtBufferrate.SetMaximumAxisX(ConvOADate(edDate))
                                                chtObjectRate.SetMinimumAxisX(ConvOADate(stDate))
                                                chtObjectRate.SetMaximumAxisX(ConvOADate(edDate))
                                                chtObjectTuple.SetMinimumAxisX(ConvOADate(stDate))
                                                chtObjectTuple.SetMaximumAxisX(ConvOADate(edDate))
                                                For Each tmpRow As DataRow In tmpDtTable.Rows
                                                    Dim strBtnText As String = tmpRow.Item("DB_NAME")
                                                    Dim tmpRb As BaseControls.RadioButton = MakeBaseRBCtl(strBtnText)
                                                    flpDB.Controls.Add(tmpRb)
                                                    AddHandler tmpRb.CheckedChanged, AddressOf ChkDB_CheckedChanged

                                                Next
                                            Catch ex As Exception

                                            End Try
                                        End Sub))

            dtTable = Nothing






        End If

        ' SQL
        RaiseEvent WaitMag("SQL Information")
        tmpTh = New Threading.Thread(Sub()
                                         Try
                                             dtTable = _clsQuery.SelectReportSQL(intInstance, stDate, edDate, _AgentInfo.AgentVer)
                                             If dtTable IsNot Nothing Then
                                                 _dtSql = dtTable
                                             End If
                                         Catch ex As Exception
                                             p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                             GC.Collect()
                                         End Try
                                     End Sub)

        tmpTh.Start()
        tmpTh.Join()


        ' DB 별 데이터가 있을 경우 
        If flpDB.Controls.Count > 0 Then
            flpDB.Invoke(New MethodInvoker(Sub()
                                               DirectCast(flpDB.Controls(0), BaseControls.RadioButton).Checked = True
                                           End Sub))
        End If

        'If dtTable IsNot Nothing Then
        '    dgvRptTbAccess.Invoke(New MethodInvoker(Sub()
        '                                                Try
        '                                                    dgvRptTbAccess.DataSource = dtTable
        '                                                Catch ex As Exception
        '                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                                    GC.Collect()
        '                                                End Try
        '                                            End Sub))
        '    dtTable = Nothing
        'End If







        '' DB Access
        'RaiseEvent WaitMag("DB Access Information")
        'tmpTh = New Threading.Thread(Sub()
        '                                 Try
        '                                     dtTable = _clsQuery.SelectReportDBAccess(intInstance, stDate, edDate)
        '                                 Catch ex As Exception
        '                                     p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                     GC.Collect()
        '                                 End Try

        '                             End Sub)
        'tmpTh.Start()
        'tmpTh.Join()

        'If dtTable IsNot Nothing Then
        '    dgvRptDBAccess.Invoke(New MethodInvoker(Sub()
        '                                                Try


        '                                                    dgvRptDBAccess.DataSource = dtTable
        '                                                Catch ex As Exception
        '                                                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                                    GC.Collect()

        '                                                End Try
        '                                            End Sub))
        '    dtTable = Nothing
        'End If



        ''Transaction
        'RaiseEvent WaitMag("Transaction Information")
        'tmpTh = New Threading.Thread(Sub()
        '                                 Try
        '                                     dtTable = _clsQuery.SelectReportTransaction(intInstance, stDate, edDate)
        '                                 Catch ex As Exception
        '                                     p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                     GC.Collect()
        '                                 End Try
        '                             End Sub)

        'tmpTh.Start()
        'tmpTh.Join()
        'If dtTable IsNot Nothing Then
        '    dgvRptTrans.Invoke(New MethodInvoker(Sub()
        '                                             Try
        '                                                 dgvRptTrans.DataSource = dtTable
        '                                             Catch ex As Exception
        '                                                 p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        '                                                 GC.Collect()
        '                                             End Try

        '                                         End Sub))
        '    dtTable = Nothing
        'End If



        RaiseEvent WaitComplete()
    End Sub

    Private _ThreadRpt As Threading.Thread

    Private Function fn_SearchBefCheck() As Boolean


        If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return False
        Else
            If DateDiff(DateInterval.Hour, dtpSt.Value, dtpEd.Value) > (24 * 7) Then
                MsgBox(p_clsMsgData.fn_GetData("M015", "7"))
                Return False
            End If
        End If


        Return True
    End Function
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        If fn_SearchBefCheck() = False Then Return

        ' DB 관련 전역 변수 초기화 
        _dtDB = Nothing
        _dtSession = Nothing


        Me.chtRptCpu.Clear()
        Me.chtRptMem.Clear()
        Me.chtRptDisk.Clear()
        Me.chtRptDiskRate.Clear()
        Me.chtSession.Clear()
        ' Disk 
        For Each tmpCtl As Control In Me.flpDisk.Controls
            If tmpCtl.GetType.Equals(GetType(BaseControls.CheckBox)) Then
                RemoveHandler DirectCast(tmpCtl, BaseControls.CheckBox).CheckedChanged, AddressOf ChkDisk_CheckedChanged
            End If
        Next
        Me.flpDisk.Controls.Clear()

        ' Session 
        For Each tmpCtl As Control In Me.flpDB.Controls
            If tmpCtl.GetType.Equals(GetType(BaseControls.RadioButton)) Then
                RemoveHandler DirectCast(tmpCtl, BaseControls.RadioButton).CheckedChanged, AddressOf ChkDb_CheckedChanged

            End If
        Next
        Me.flpDB.Controls.Clear()




        If _ThreadRpt IsNot Nothing AndAlso _ThreadRpt.IsAlive = True Then Return


        '_frmW = New frmWait
        '_frmW.TopMost = True
        '_frmW.Show(Me)

        _ProgresForm = New frmProgres()
        _ProgresForm.Owner = Me
        _ProgresForm.Location = Me.Location
        _ProgresForm.Size = Me.Size
        _ProgresForm.Show()

        Dim intInstance As Integer = cmbInst.SelectedValue
        Dim stDate As DateTime = dtpSt.Value
        Dim edDate As DateTime = dtpEd.Value
        Dim enmSvrnm As clsEnums.ShowName = p_ShowName



        _ThreadRpt = New Threading.Thread(Sub()
                                              Try


                                                  Thmain(intInstance, stDate, edDate, enmSvrNm)
                                              Catch ex As Exception
                                                  GC.Collect()
                                              End Try
                                          End Sub)



        _ThreadRpt.Start()

        cmbInst.Tag = intInstance
        dtpSt.Tag = stDate
        dtpEd.Tag = edDate

        pnlMain.Focus()




    End Sub

    Private Sub dtpSt_ValueChanged(sender As Object, e As EventArgs) Handles dtpSt.ValueChanged
        If dtpEd.Value <= dtpSt.Value Then
            dtpEd.Value = DateAdd(DateInterval.Minute, 2, dtpSt.Value)
        End If
    End Sub



    Private Sub ShowDiskChart(ByVal intInstanceID As Integer, ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal DiskNm As String, ByVal ShowSeries As Boolean, ByVal SingleMode As Boolean)

        'If _frmW Is Nothing Then
        '_frmW = New frmWait
        '_frmW.TopMost = True

        'Me.Invoke(New MethodInvoker(Sub()
        '                                _frmW.Show(Me)
        '                            End Sub))

        'End If

        If _ProgresForm Is Nothing Then
            _ProgresForm = New frmProgres()
            _ProgresForm.Owner = Me
            _ProgresForm.Location = Me.Location
            _ProgresForm.Size = Me.Size

            Me.Invoke(New MethodInvoker(Sub()
                                            _ProgresForm.Show(Me)
                                        End Sub))
        End If

        RaiseEvent WaitMag("Disk Information - " & DiskNm)

        Dim strRead As String = DiskNm & " READ"
        Dim strWrite As String = DiskNm & " WRITE"
        If ShowSeries = False Then

            Me.Invoke(New MethodInvoker(Sub()

                                            Try


                                                chtRptDisk.ShowLegend(strRead, ShowSeries)
                                                chtRptDisk.ShowLegend(strWrite, ShowSeries)
                                                chtRptDisk.MainChart.ChartAreas(0).RecalculateAxesScale()

                                                chtRptDiskRate.ShowLegend(strRead, ShowSeries)
                                                chtRptDiskRate.ShowLegend(strWrite, ShowSeries)
                                                chtRptDiskRate.MainChart.ChartAreas(0).RecalculateAxesScale()
                                            Catch ex As Exception
                                                Debug.Print(ex.ToString)
                                            End Try
                                        End Sub))

        Else

            Dim bretAddRead As Boolean = False
            Dim bretAddWrite As Boolean = False
            Dim bretAddReadRate As Boolean = False
            Dim bretAddWriteRate As Boolean = False
            Me.Invoke(New MethodInvoker(Sub()
                                            If chtRptDisk.GetSeries(strRead) = False Then

                                                chtRptDisk.AddSeries(strRead, strRead)


                                                bretAddRead = True
                                            Else
                                                chtRptDisk.ShowLegend(strRead, ShowSeries)
                                            End If
                                            If chtRptDisk.GetSeries(strWrite) = False Then
                                                chtRptDisk.AddSeries(strWrite, strWrite)

                                                bretAddWrite = True
                                            Else
                                                chtRptDisk.ShowLegend(strWrite, ShowSeries)
                                            End If


                                            If chtRptDiskRate.GetSeries(strRead) = False Then
                                                chtRptDiskRate.AddSeries(strRead, strRead)

                                                bretAddReadRate = True
                                            Else
                                                chtRptDiskRate.ShowLegend(strRead, ShowSeries)
                                            End If

                                            If chtRptDiskRate.GetSeries(strWrite) = False Then

                                                chtRptDiskRate.AddSeries(strWrite, strWrite)


                                                bretAddWriteRate = True
                                            Else
                                                chtRptDiskRate.ShowLegend(strWrite, ShowSeries)
                                            End If
                                        End Sub))

            If bretAddRead = True Or bretAddWrite = True Then
                'Dim clsQuery As New clsQuerys(_AgentCn)
                Dim dtTable As DataTable = Nothing
                Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
                                                                         Try
                                                                             dtTable = _clsQuerySub.SelectReportDiskChart(intInstanceID, stDate, edDate, DiskNm)
                                                                         Catch ex As Exception
                                                                             GC.Collect()
                                                                         End Try


                                                                     End Sub)

                tmpTh.Start()
                tmpTh.Join()
                If dtTable IsNot Nothing Then
                    Me.Invoke(New MethodInvoker(Sub()
                                                    For Each tmpRow As DataRow In dtTable.Rows
                                                        Dim tmpDate As Double = ConvOADate(tmpRow.Item("COLLECT_DATE"))
                                                        If bretAddRead = True Then

                                                            'Me.chtRptDisk.AddPoints(strRead, tmpDate, ConvULong(dtTable.Rows(i).Item("READ_KB_PER_SEC")))
                                                            Me.chtRptDisk.Invoke(New MethodInvoker(Sub()
                                                                                                       Me.chtRptDisk.AddPoints(strRead, tmpDate, ConvULong(tmpRow.Item("READ_KB_PER_SEC")))
                                                                                                   End Sub))
                                                        End If
                                                        If bretAddWrite = True Then
                                                            'Me.chtRptDisk.AddPoints(strWrite, tmpDate, ConvULong(dtTable.Rows(i).Item("WRITE_KB_PER_SEC")))
                                                            Me.chtRptDisk.Invoke(New MethodInvoker(Sub()
                                                                                                       Me.chtRptDisk.AddPoints(strWrite, tmpDate, ConvULong(tmpRow.Item("WRITE_KB_PER_SEC")))
                                                                                                   End Sub))
                                                        End If

                                                        If bretAddReadRate = True Then
                                                            'Me.chtRptDiskRate.AddPoints(strRead, tmpDate, ConvULong(dtTable.Rows(i).Item("READ_BUSY_RATE")))
                                                            Me.chtRptDiskRate.Invoke(New MethodInvoker(Sub()
                                                                                                           Me.chtRptDiskRate.AddPoints(strRead, tmpDate, ConvULong(tmpRow.Item("READ_BUSY_RATE")))
                                                                                                       End Sub))
                                                        End If

                                                        If bretAddWriteRate = True Then
                                                            'Me.chtRptDiskRate.AddPoints(strWrite, tmpDate, ConvULong(dtTable.Rows(i).Item("WRITE_BUSY_RATE")))
                                                            Me.chtRptDiskRate.Invoke(New MethodInvoker(Sub()
                                                                                                           Me.chtRptDiskRate.AddPoints(strWrite, tmpDate, ConvULong(tmpRow.Item("WRITE_BUSY_RATE")))
                                                                                                       End Sub))
                                                        End If

                                                    Next
                                                End Sub))

                End If



            End If
            Me.Invoke(New MethodInvoker(Sub()
                                            chtRptDisk.MainChart.ChartAreas(0).RecalculateAxesScale()
                                            chtRptDiskRate.MainChart.ChartAreas(0).RecalculateAxesScale()
                                        End Sub))

        End If
        If SingleMode = True Then
            RaiseEvent WaitComplete()
        End If


    End Sub





    Private _ThreadDisk As Threading.Thread


    Private Sub chtRptCpu_LocationChanged(sender As Object, e As EventArgs) Handles chtRptCpu.LocationChanged, chtRptDisk.LocationChanged

        'Dim grp As BaseControls.GroupBox = DirectCast(sender, Control).Parent
        'Dim grpheight As Integer = grp.Padding.Top + grp.Padding.Bottom + 2
        'grp.Height = grpheight + DirectCast(sender, Control).Top + DirectCast(sender, Control).MinimumSize.Height




    End Sub

    Private Sub frmReports_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If _ThreadRpt IsNot Nothing Then
            _clsQuery.CancelCommand()
            _ThreadRpt.Abort()
            _ThreadRpt = Nothing
        End If

        If _ThreadDisk IsNot Nothing Then
            _clsQuerySub.CancelCommand()
            _ThreadDisk.Abort()
            _ThreadDisk = Nothing
        End If
    End Sub

    Private Sub frmReports_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _ShownSearch = True Then
            btnSearch.PerformClick()
        End If

        chtRptCpu_LocationChanged(Me.chtRptCpu, New EventArgs())
    End Sub

    Private Sub frmReports_WaitComplete() Handles Me.WaitComplete
        'If _frmW IsNot Nothing Then

        '    Me.Invoke(New MethodInvoker(Sub()
        '                                    _frmW.Close()
        '                                End Sub))

        'End If
        If _ProgresForm IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            _ProgresForm.Close()
                                        End Sub))
        End If
    End Sub

    Private Sub frmReports_WaitMag(str As String) Handles Me.WaitMag
        'If _frmW IsNot Nothing Then
        '    _frmW.AddText(str)
        'End If

        If _ProgresForm IsNot Nothing Then
            _ProgresForm.AddText(str)
        End If
    End Sub

    'Private Sub _frmW_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _frmW.FormClosed
    '    If _ThreadRpt IsNot Nothing Then
    '        _clsQuery.CancelCommand()
    '        _ThreadRpt.Abort()
    '        _ThreadRpt = Nothing
    '    End If


    '    If _ThreadDisk IsNot Nothing Then
    '        _clsQuerySub.CancelCommand()
    '        _ThreadDisk.Abort()
    '        _ThreadDisk = Nothing
    '    End If



    '    _frmW = Nothing



    'End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        If _ThreadRpt IsNot Nothing Then
            _clsQuery.CancelCommand()
            _ThreadRpt.Abort()
            _ThreadRpt = Nothing
        End If

        If _ThreadDisk IsNot Nothing Then
            _clsQuerySub.CancelCommand()
            _ThreadDisk.Abort()
            _ThreadDisk = Nothing
        End If
        _ProgresForm = Nothing

    End Sub

    Private Sub dgvRptSQL_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRptSQL.CellDoubleClick
        'If e.ColumnIndex = colDgvRptSqlSql.Index Then
        Dim frmQuery As New frmQueryView(_AgentCn, dgvRptSQL.Rows(e.RowIndex).Cells(colDgvRptSqlSql.Index).Value, dgvRptSQL.Rows(e.RowIndex).Cells(colDgvRptSqlDBNm.Index).Value, "", cmbInst.Tag, _AgentInfo)
        frmQuery.ShowDialog(Me)
        'End If
    End Sub

    Private Sub dgvRptSQL_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        'If (dgvRptCpu.RowCount > 0) Then
        Dim str As String = dtpSt.Value & " ~ " & dtpEd.Value
        Dim frmP As New frmPrint(cmbInst.Text.ToString, str, grpRptCpu, grpRptTimeLine, grpRptSQL)
        'dtpSt.Value = stDt.AddMinutes(-1)
        'dtpEd.Value = edDt.AddMinutes(1)

        frmP.Show()
        'End If

    End Sub




    'Private Sub rbDisk_CheckedChanged(sender As Object, e As EventArgs)

    'End Sub

    Private Sub ChkDisk_CheckedChanged(sender As Object, e As EventArgs)
        If cmbInst.Tag IsNot Nothing AndAlso dtpSt.Tag IsNot Nothing AndAlso dtpEd.Tag IsNot Nothing Then
            'RaiseEvent WaitMag("DISK Information - " & dgvRptDisk.Rows(0).Cells(colDgvRptDiskNm.Index).Value)
            'dgvRptDisk.Rows(0).Cells(colDgvRptDiskCheck.Index).Value = True
            'ShowDiskChart(intInstance, stDate, edDate, dgvRptDisk.Rows(0).Cells(colDgvRptDiskNm.Index).Value, True)
            Dim Rb As BaseControls.CheckBox = DirectCast(sender, BaseControls.CheckBox)

            Dim SingleMode As Boolean = True
            'If _frmW IsNot Nothing Then
            If _ProgresForm IsNot Nothing Then
                SingleMode = False
                ShowDiskChart(cmbInst.Tag, dtpSt.Tag, dtpEd.Tag _
                            , Rb.Text _
                            , Rb.Checked, SingleMode)
                chtRptDisk.ShowMaxValue(True)
                chtRptDiskRate.ShowMaxValue(True)

            Else
                SingleMode = True

                _ThreadDisk = New Threading.Thread(Sub()

                                                       ShowDiskChart(cmbInst.Tag, dtpSt.Tag, dtpEd.Tag _
                                                                   , Rb.Text _
                                                                   , Rb.Checked, SingleMode)

                                                       Try
                                                           chtRptDisk.ShowMaxValue(True)
                                                           chtRptDiskRate.ShowMaxValue(True)
                                                       Catch ex As Exception
                                                           Debug.Print(ex.ToString)
                                                       End Try

                                                   End Sub)
                _ThreadDisk.Start()


            End If

        End If
    End Sub


    Private Sub ChkDB_CheckedChanged(sender As Object, e As EventArgs)
        Dim Rb As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If cmbInst.Tag IsNot Nothing AndAlso dtpSt.Tag IsNot Nothing AndAlso dtpEd.Tag IsNot Nothing AndAlso _dtSession IsNot Nothing Then

            ' Session 
            Dim arrParamSession As SeriesColumn() = {New SeriesColumn("ACTIVE", "CUR_ACTV_BACKEND_CNT"), _
                                                  New SeriesColumn("IDLE", "IDLE_BACKEND_CNT"), _
                                                  New SeriesColumn("TRANS", "IDLE_IN_TRC_BACKEND_CNT")}



            ShowVariableChartData(Me.chtSession, cmbInst.Tag, "Session Information", _dtSession, Rb.Text, arrParamSession)
            Me.chtSession.ShowMinValue(True)
            ' Logical IO
            Dim arrParamLogical As SeriesColumn() = {New SeriesColumn("INSERT", "INSERT_TUPLES_PER_SEC"), _
                                             New SeriesColumn("UPDATE", "UPDATE_TUPLES_PER_SEC"), _
                                             New SeriesColumn("DELETE", "DELETE_TUPLES_PER_SEC"), _
                                             New SeriesColumn("READ", "SELECT_TUPLES_PER_SEC")}

            ShowVariableChartData(Me.chtLogical, cmbInst.Tag, "Logical Information", _dtDB, Rb.Text, arrParamLogical)
            'Me.chtLogical.AutoGridYSpacing()
            Me.chtLogical.ShowMinValue(True)

            ' Physical IO
            Dim arrParamPhysical As SeriesColumn() = {New SeriesColumn("READ", "PHY_READ_PER_SEC")}

            ShowVariableChartData(Me.chtPhysicalIO, cmbInst.Tag, "Physical Read", _dtDB, Rb.Text, arrParamPhysical)
            'Me.chtLogical.AutoGridYSpacing()
            Me.chtPhysicalIO.ShowMinValue(True)
            ' Object Access Tuples
            Dim arrParamObjectTuples As SeriesColumn() = {New SeriesColumn("AVG_SEQ_SCAN", "SEQ_TUPLES"), _
                                             New SeriesColumn("AVG_INDEX_SCAN", "INDEX_TUPLES")}

            ShowVariableChartData(Me.chtObjectTuple, cmbInst.Tag, "Object Access Information", _dtDB, Rb.Text, arrParamObjectTuples)
            Me.chtObjectTuple.ShowMinValue(True)

            ' Object Access Rate
            Dim arrParamObjectRates As SeriesColumn() = {New SeriesColumn("SEQ_SCAN", "SEQ_SCAN"), _
                                         New SeriesColumn("INDEX_SCAN", "INDEX_SCAN")}

            ShowVariableChartData(Me.chtObjectRate, cmbInst.Tag, "Object Access Information", _dtDB, Rb.Text, arrParamObjectRates)
            Me.chtObjectRate.ShowMinValue(True)

            ' Buffer Read
            Dim arrParamBufferRead As SeriesColumn() = {New SeriesColumn("BUFFER_READ_KB", "BUFFER_READ_KB") _
                                             , New SeriesColumn("DISK_READ_KB", "DISK_READ_KB")}

            ShowVariableChartData(Me.chtBuffer, cmbInst.Tag, "Buffer Information", _dtDB, Rb.Text, arrParamBufferRead)
            Me.chtBuffer.ShowMinValue(True)
            ' Buffer rate 
            Dim arrParamBufferRate As SeriesColumn() = {New SeriesColumn("HIT_RATIO", "HIT_RATIO")}


            ShowVariableChartData(Me.chtBufferrate, cmbInst.Tag, "Buffer Rate Information", _dtDB, Rb.Text, arrParamBufferRate)
            Me.chtBufferrate.ShowMinValue(True)


        End If


        If cmbInst.Tag IsNot Nothing AndAlso dtpSt.Tag IsNot Nothing AndAlso dtpEd.Tag IsNot Nothing AndAlso _dtSql IsNot Nothing Then
            dgvRptSQL.Invoke(New MethodInvoker(Sub()
                                                   Try
                                                       If _dtSql.Select(String.Format("DB_NAME = '{0}'", Rb.Text.Replace("'", "''")) _
                                                                                             , "ELAPSED_TIME DESC").Count > 0 Then
                                                           Dim tmpDt As DataTable = _dtSql.Select(String.Format("DB_NAME = '{0}'", Rb.Text.Replace("'", "''")) _
                                                                                        , "ELAPSED_TIME DESC").CopyToDataTable
                                                           dgvRptSQL.DataSource = tmpDt
                                                           modCommon.sb_GridSortChg(dgvRptSQL, colDgvRptSqlElapsedMax.Index)
                                                           dgvRptSQL.AutoResizeColumns()
                                                           'colDgvRptSqlDBNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
                                                           'colDgvRptSqlStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
                                                           'colDgvRptSqlElapsedMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
                                                           'colDgvRptSqlCpuMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
                                                           colDgvRptSqlDBNm.Width = 104
                                                           'colDgvRptSqlStart.Width = 114
                                                           colDgvRptSqlElapsedMax.Width = 214
                                                           'colDgvRptSqlCpuMax.Width = 174
                                                           'colDgvRptSqlCpuTime.Width = 214
                                                           colDgvRptSqlCount.Width = 174
                                                           'colDgvRptSqlAddr.Width = 164

                                                           If dgvRptSQL.Height < (50 + tmpDt.Rows.Count * 23) Then
                                                               Dim increaseHeight As Integer
                                                               increaseHeight = (50 + tmpDt.Rows.Count * 23 - dgvRptSQL.Height)
                                                               ' origine
                                                               'dgvRptSQL.Height += increaseHeight
                                                               'grpRptTimeLine.Height += increaseHeight
                                                               ' fix grp
                                                               dgvRptSQL.Height += increaseHeight

                                                           End If
                                                       Else
                                                           dgvRptSQL.DataSource = Nothing

                                                           colDgvRptSqlDBNm.Width = 104
                                                           'colDgvRptSqlStart.Width = 114
                                                           colDgvRptSqlElapsedMax.Width = 214
                                                           'colDgvRptSqlCpuMax.Width = 174
                                                           'colDgvRptSqlCpuTime.Width = 214
                                                           colDgvRptSqlCount.Width = 174
                                                           'colDgvRptSqlAddr.Width = 164
                                                           'Me.colDgvRptSqlDBNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
                                                       End If

                                                   Catch ex As Exception
                                                       p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                       GC.Collect()
                                                   End Try
                                               End Sub))
        End If

    End Sub



    Private Structure SeriesColumn
        Dim SeriesNm As String
        Dim ColumnNm As String
        Public Sub New(ByVal strSeries As String, ByVal strColumn As String)
            SeriesNm = strSeries
            ColumnNm = strColumn
        End Sub
    End Structure
    Private Sub ShowVariableChartData(ByVal ctlChart As Monitoring.ctlChart, ByVal intInstanceID As Integer, ByVal strTitle As String, ByVal dtSessionInfo As DataTable, ByVal strDBNm As String, ParamArray SerCol() As SeriesColumn)


        ' InitSeries 
        Me.Invoke(New MethodInvoker(Sub()
                                        For Each tmpSeries As DataVisualization.Charting.Series In ctlChart.MainChart.Series
                                            tmpSeries.Points.Clear()
                                        Next
                                        Try
                                            Dim tmpDtTable As DataTable = dtSessionInfo.Select(String.Format("DB_NAME = '{0}'", strDBNm.Replace("'", "''")) _
                                                                                            , "COLLECT_DATE ASC").CopyToDataTable
                                            If tmpDtTable IsNot Nothing Then
                                                For Each tmpRow As DataRow In tmpDtTable.Rows
                                                    Dim tmpDate As Double = ConvOADate(tmpRow.Item("COLLECT_DATE"))
                                                    For Each tmpSeriesColumn As SeriesColumn In SerCol
                                                        ctlChart.AddPoints(tmpSeriesColumn.SeriesNm, tmpDate, ConvULong(tmpRow.Item(tmpSeriesColumn.ColumnNm)))
                                                    Next



                                                Next
                                            End If
                                        Catch ex As Exception
                                            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                            GC.Collect()
                                            'ctlChart.AddPoints(tmpSeriesColumn.SeriesNm, tmpDate, ConvULong(tmpRow.Item(tmpSeriesColumn.ColumnNm)))
                                            For i As Integer = 0 To 1
                                                For Each tmpSeriesColumn As SeriesColumn In SerCol
                                                    ctlChart.AddPoints(tmpSeriesColumn.SeriesNm, ctlChart.GetMinimumAxisX, 0)
                                                Next
                                            Next
                                        Finally
                                            ctlChart.MainChart.ChartAreas(0).RecalculateAxesScale()
                                        End Try
                                    End Sub))





    End Sub



    Private Sub chtBufferrate_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub grpRptCpu_Enter(sender As Object, e As EventArgs) Handles grpRptCpu.Enter

    End Sub


    Private Sub chkLogicalIO_CheckedChanged(sender As Object, e As EventArgs) Handles rb1H.CheckedChanged, rb2H.CheckedChanged, rb4H.CheckedChanged, rb12H.CheckedChanged, rb1D.CheckedChanged
        Dim Rb As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If Rb.Checked = True Then
            dtpDay.Checked = False
            dtpEd.Value = DateTime.Now
            If Rb.Text.Equals("~1H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-1)
            ElseIf Rb.Text.Equals("~2H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-2)
            ElseIf Rb.Text.Equals("~4H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-4)
            ElseIf Rb.Text.Equals("~12H") Then
                dtpSt.Value = dtpEd.Value.AddHours(-12)
            ElseIf Rb.Text.Equals("~1D") Then
                dtpSt.Value = dtpEd.Value.AddHours(-24)
            End If

            btnSearch.PerformClick()
        End If
    End Sub

    Private Sub dtpDay_ValueChanged(sender As Object, e As EventArgs) Handles dtpDay.ValueChanged
        If dtpDay.Checked = True Then
            dtpSt.Value = New Date(dtpDay.Value.Year, dtpDay.Value.Month, dtpDay.Value.Day, 0, 0, 0, 0)
            dtpEd.Value = dtpSt.Value.AddHours(24)

            rb1H.Checked = False
            rb2H.Checked = False
            rb4H.Checked = False
            rb12H.Checked = False
            rb1D.Checked = False
        End If
    End Sub
End Class
