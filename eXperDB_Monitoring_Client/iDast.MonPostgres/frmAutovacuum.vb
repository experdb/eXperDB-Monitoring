Public Class frmAutovacuum

    Private _InstanceID As Integer = -1
    Private _SelectedIndex As String
    Private _clsQuery As clsQuerys
    Private _arrTables As New ArrayList
    Private _countTop As Integer = 5
    Private WithEvents _ProgresForm As frmProgres
    Private Event WaitMag(ByVal str As String)
    'Private _arrTablesRelID As New ArrayList
    Public Structure TableInfo
        Dim tableName As String
        Dim relID As String
        Public AxisXValue As Double
    End Structure
    Private _arrDatabases As New ArrayList

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

    Private _queryColors() As Color = {System.Drawing.Color.OrangeRed,
                     System.Drawing.Color.Orange,
                     System.Drawing.Color.Gold,
                     System.Drawing.Color.YellowGreen,
                     System.Drawing.Color.SkyBlue,
                     System.Drawing.Color.DodgerBlue,
                     System.Drawing.Color.Violet,
                     System.Drawing.Color.Pink,
                     System.Drawing.Color.Purple,
                     System.Drawing.Color.Tan,
                     System.Drawing.Color.SpringGreen,
                     System.Drawing.Color.Brown,
                     System.Drawing.Color.Blue,
                     System.Drawing.Color.Red,
                     System.Drawing.Color.Aqua,
                     System.Drawing.Color.FromArgb(255, CType(CType(0, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(192, Byte), Integer))}

    Public Sub New(ByVal AgentCn As eXperDB.ODBC.eXperDBODBC, ByVal ServerInfo As List(Of GroupInfo.ServerInfo), ByVal intInstanceID As Integer, ByVal stDt As DateTime, ByVal edDt As DateTime, ByVal AgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = intInstanceID
        _SvrpList = ServerInfo
        _AgentInfo = AgentInfo
        '_AgentCn = AgentCn
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        _AgentCn = New eXperDBODBC(dbType, _AgentInfo.AgentDBIP, _AgentInfo.AgentDBPort, _AgentInfo.AgentConnDBUser, _AgentInfo.AgentConnDBPW, _AgentInfo.AgentConnDBNM)

        _clsQuery = New clsQuerys(_AgentCn)
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            If tmpSvr.InstanceID = _InstanceID Then
                _ServerInfo = tmpSvr
            End If
            cmbInst.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
        Next

        dtpSt.Value = stDt.AddMinutes(0)
        dtpEd.Value = edDt.AddMinutes(0)
        dtpSt.Tag = stDt
        dtpEd.Tag = edDt

        dtpSt.Visible = True
        dtpEd.Visible = True
        lblSt.Visible = False
        lblEd.Visible = False
        btnQuery.Visible = True

        InitForm()
    End Sub

    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAutovacuum_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _InstanceID > 0 Then
            Dim comboSource As New Dictionary(Of String, String)()
            Dim index As Integer = 0
            For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
                If tmpSvr.InstanceID = _InstanceID Then
                    cmbInst.SelectedIndex = index
                    Me.Invoke(New MethodInvoker(Sub()
                                                    btnQuery.PerformClick()
                                                End Sub))
                End If
                index += 1
            Next
        End If
    End Sub


    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        Me.Text += " [ " + String.Format("{0}({1}) ", _ServerInfo.ShowNm, _ServerInfo.IP) + "]"
        lblSubject.Text = p_clsMsgData.fn_GetData("M062")
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'label & Input
        lblServer.Text = p_clsMsgData.fn_GetData("F033")
        lblDuration.Text = p_clsMsgData.fn_GetData("F254")
        lblWaparound.Text = p_clsMsgData.fn_GetData("F334")
        lblWorker.Text = p_clsMsgData.fn_GetData("F335")
        lblCount.Text = p_clsMsgData.fn_GetData("F336")

        ' Button 
        btnQuery.Text = p_clsMsgData.fn_GetData("F151")
        btnRange.Text = p_clsMsgData.fn_GetData("F269", "Off")

        cmbTop.SelectedIndex = 0
        '''''''''''''''''''''''''''''''''''''''''
    End Sub

    'Private Sub drawAutovacuumWorker(ByVal stDate As DateTime, ByVal edDate As DateTime)
    Private Sub drawAutovacuumWorker()
        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            For Each tmpSeries As DataVisualization.Charting.Series In chtAutovacuumWorkers.Series
                                                If tmpSeries.ChartArea = chtAutovacuumWorkers.ChartAreas(0).Name Then
                                                    tmpSeries.Points.Clear()
                                                End If
                                            Next
                                        Catch ex As Exception
                                            GC.Collect()
                                        End Try
                                    End Sub))

        Dim dtTable As DataTable = _dtTableAutovacuumWorker
        'Dim dtTable As DataTable = Nothing
        'Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
        '                                                         Try
        '                                                             dtTable = _clsQuery.SelectAutovacuumWorker(_InstanceID, stDate, edDate)
        '                                                         Catch ex As Exception
        '                                                             GC.Collect()
        '                                                         End Try
        '                                                     End Sub)
        'tmpTh.Start()
        'tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Dim sDateCollect As Double = 0.0
                                                If dtTable.Rows.Count > 0 Then
                                                    For Each dtRow As DataRow In dtTable.Rows
                                                        Dim tmpDate As Double = ConvOADate(dtRow.Item("COLLECT_DATE"))
                                                        sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Wraparound prevention", tmpDate, ConvDBL(dtRow.Item("WRAPAROUND")))
                                                        sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Vacuum", tmpDate, ConvDBL(dtRow.Item("COMMON")))
                                                    Next
                                                Else
                                                    'Dim tmpDate As Double = ConvOADate(Now())
                                                    'sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Wraparound prevention", tmpDate, 0.0)
                                                    'sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Vacuum", tmpDate, 0.0)
                                                    Dim tmpDate As Double = ConvOADate(dtpSt.Value)
                                                    sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Wraparound prevention", tmpDate, 0.0)
                                                    tmpDate = ConvOADate(dtpEd.Value)
                                                    sb_ChartAddPoint(Me.chtAutovacuumWorkers, "Vacuum", tmpDate, 0.0)
                                                End If
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If
        Me.Invoke(New MethodInvoker(Sub()
                                        sb_ChartAlignYAxies(Me.chtAutovacuumWorkers)
                                    End Sub))

    End Sub

    'Private Sub drawAutovacuumCount(ByVal stDate As DateTime, ByVal edDate As DateTime)
    Private Sub drawAutovacuumCount()

        Dim arrIndex As Integer = 0
        Dim arrColors As New ArrayList

        Dim strTopTables = ""

        For j As Integer = 0 To _arrTables.Count - 1
            arrColors.Add(_queryColors(arrIndex))
            arrIndex += 1
            Dim ti As TableInfo = _arrTables(j)
            If j = _arrTables.Count - 1 Then
                strTopTables += ti.relID
            Else
                strTopTables += ti.relID + ","
            End If
        Next

        strTopTables = String.Join(",", strTopTables)

        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            For Each tmpSeries As DataVisualization.Charting.Series In chtAutovacuumCount.Series
                                                If tmpSeries.ChartArea = chtAutovacuumCount.ChartAreas(0).Name Then
                                                    tmpSeries.Points.Clear()
                                                End If
                                            Next
                                            chtAutovacuumCount.Series.Clear()
                                        Catch ex As Exception
                                            GC.Collect()
                                        End Try
                                    End Sub))

        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            arrIndex = 0
                                            For Each tmpTable As TableInfo In _arrTables
                                                AddSeries(Me.chtAutovacuumCount, tmpTable.tableName, tmpTable.tableName, arrColors(arrIndex), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range)
                                                arrIndex += 1
                                            Next
                                        Catch ex As Exception
                                            GC.Collect()
                                        End Try
                                    End Sub))

        'Dim dtTable As DataTable = Nothing
        Dim dtTable As DataTable = _dtTableAutovacuumCount
        'Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
        '                                                         Try
        '                                                             dtTable = _clsQuery.SelectAutovacuumCount(_InstanceID, stDate, edDate, strTopTables)
        '                                                         Catch ex As Exception
        '                                                             GC.Collect()
        '                                                         End Try
        '                                                     End Sub)
        'tmpTh.Start()
        'tmpTh.Join()
        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            Dim sDateCollect As Double = 0.0
                                            If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
                                                For Each dtRow As DataRow In dtTable.Rows
                                                    Dim tmpDate As Double = ConvOADate(dtRow.Item("COLLECT_DATE"))
                                                    For i As Integer = 0 To _arrTables.Count - 1
                                                        Dim tmpTable As TableInfo = _arrTables(i)
                                                        If Not IsDBNull(dtRow.Item("RELID")) AndAlso dtRow.Item("RELID") = tmpTable.relID Then
                                                            'sb_ChartAddPoint(Me.chtAutovacuumCount, tmpTable.tableName, tmpDate, dtRow.Item("DIFF"))
                                                            sb_RangeChartAddPoint(Me.chtAutovacuumCount, tmpTable.tableName, tmpDate, IIf(dtRow.Item("DIFF") > 0, 1, 0), i)
                                                            tmpTable.AxisXValue = tmpDate
                                                            _arrTables(i) = tmpTable
                                                        End If
                                                    Next
                                                Next
                                            Else
                                                'Dim tmpDate As Double = ConvOADate(Now())
                                                'Dim j As Integer = 0
                                                'For i As Integer = 0 To _arrTables.Count - 1
                                                '    Dim tmpTable As TableInfo = _arrTables(i)
                                                '    sb_ChartAddPoint(Me.chtAutovacuumCount, tmpTable.tableName, tmpDate, 0.0)
                                                'Next
                                                Dim tmpDate As Double = ConvOADate(dtpSt.Value)

                                                AddSeries(Me.chtAutovacuumCount, "", "", Nothing, System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range)
                                                sb_ChartAddPoint(Me.chtAutovacuumCount, "", tmpDate, 0.0)
                                                tmpDate = ConvOADate(dtpEd.Value)
                                                sb_ChartAddPoint(Me.chtAutovacuumCount, "", tmpDate, 0.0)
                                            End If
                                        Catch ex As Exception
                                            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                            GC.Collect()
                                        End Try

                                    End Sub))

        Me.Invoke(New MethodInvoker(Sub()
                                        sb_ChartAlignYAxies(Me.chtAutovacuumCount)
                                    End Sub))

    End Sub

    'Private Sub drawAutovacuumWraparound(ByVal stDate As DateTime, ByVal edDate As DateTime)
    Private Sub drawAutovacuumWraparound()

        Dim arrIndex As Integer = 0
        Dim arrColors As New ArrayList

        Dim strDatabases = ""

        For j As Integer = 0 To _arrDatabases.Count - 1
            arrColors.Add(_queryColors(arrIndex))
            arrIndex += 1
            If j = _arrDatabases.Count - 1 Then
                strDatabases += _arrDatabases(j).ToString
            Else
                strDatabases += _arrDatabases(j).ToString + ","
            End If
        Next

        strDatabases = String.Join(",", strDatabases)

        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            For Each tmpSeries As DataVisualization.Charting.Series In chtAutovacuumWraparound.Series
                                                If tmpSeries.ChartArea = chtAutovacuumWraparound.ChartAreas(0).Name Then
                                                    tmpSeries.Points.Clear()
                                                End If
                                            Next
                                            chtAutovacuumWraparound.Series.Clear()
                                        Catch ex As Exception
                                            GC.Collect()
                                        End Try
                                    End Sub))

        Me.Invoke(New MethodInvoker(Sub()
                                        Try
                                            arrIndex = 0
                                            For Each tmpStr As String In _arrDatabases
                                                AddSeries(Me.chtAutovacuumWraparound, tmpStr, tmpStr, arrColors(arrIndex), System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine)
                                                arrIndex += 1
                                            Next
                                        Catch ex As Exception
                                            GC.Collect()
                                        End Try
                                    End Sub))

        'Dim dtTable As DataTable = Nothing
        Dim dtTable As DataTable = _dtTableAutovacuumWraparound
        'Dim tmpTh As Threading.Thread = New Threading.Thread(Sub()
        '                                                         Try
        '                                                             dtTable = _clsQuery.SelectAutovacuumWraparound(_InstanceID, stDate, edDate)
        '                                                         Catch ex As Exception
        '                                                             GC.Collect()
        '                                                         End Try
        '                                                     End Sub)
        'tmpTh.Start()
        'tmpTh.Join()
        If dtTable IsNot Nothing Then
            Me.Invoke(New MethodInvoker(Sub()
                                            Try
                                                Dim sDateCollect As Double = 0.0
                                                If dtTable.Rows.Count > 0 Then
                                                    For Each dtRow As DataRow In dtTable.Rows
                                                        Dim tmpDate As Double = ConvOADate(dtRow.Item("COLLECT_DATE"))
                                                        For i As Integer = 0 To _arrDatabases.Count - 1
                                                            If dtRow.Item("DB_NAME") = _arrDatabases(i).ToString Then
                                                                sb_ChartAddPoint(Me.chtAutovacuumWraparound, _arrDatabases(i).ToString, tmpDate, dtRow.Item("MAXAGE"))
                                                            End If
                                                        Next
                                                    Next
                                                Else
                                                    'Dim tmpDate As Double = ConvOADate(Now())
                                                    'Dim j As Integer = 0
                                                    'For i As Integer = 0 To _arrDatabases.Count - 1
                                                    '    sb_ChartAddPoint(Me.chtAutovacuumWraparound, _arrDatabases(i).ToString, tmpDate, 0.0)
                                                    'Next

                                                    Dim tmpDate As Double = ConvOADate(dtpSt.Value)
                                                    sb_ChartAddPoint(Me.chtAutovacuumWraparound, _arrDatabases(0).ToString, tmpDate, 0.0)
                                                    Dim tmpDt = DateAdd("n", -10, Now)
                                                    tmpDate = ConvOADate(dtpEd.Value)
                                                    sb_ChartAddPoint(Me.chtAutovacuumWraparound, _arrDatabases(0).ToString, tmpDate, 0.0)
                                                End If
                                            Catch ex As Exception
                                                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                                                GC.Collect()
                                            End Try

                                        End Sub))
        End If

        Me.Invoke(New MethodInvoker(Sub()
                                        'sb_ChartAlignYAxies(Me.chtAutovacuumWraparound)
                                    End Sub))

    End Sub
    Private Sub frmAutovacuum_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        If _AgentCn IsNot Nothing Then
            _AgentCn = Nothing
        End If
    End Sub

    Private Sub btnQuery_Click(sender As Object, e As EventArgs) Handles btnQuery.Click
        Try
            If fn_SearchBefCheck() = False Then Return
        Catch ex As Exception
            GC.Collect()
        End Try

        Threading.Thread.Sleep(10)
        If _ProgresForm Is Nothing Then
            _ProgresForm = New frmProgres()
            _ProgresForm.Owner = Me
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
        _ProgresForm.Show()
        Me.BringToFront()
        Me.Activate()

        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Function fn_SearchBefCheck() As Boolean
        If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return False
        Else
            If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) > (1440 * 7) Then
                MsgBox(p_clsMsgData.fn_GetData("M015", "7"))
                Return False
            End If
            If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 10 Then
                MsgBox(p_clsMsgData.fn_GetData("M117"))
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
        If dtpEd.Value <= dtpSt.Value Then
            dtpEd.Value = DateAdd(DateInterval.Minute, 2, dtpSt.Value)
        End If
    End Sub

    Private Sub frmAutovacuum_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        chtAutovacuumWraparound.ChartAreas(0).RecalculateAxesScale()
        chtAutovacuumWorkers.ChartAreas(0).RecalculateAxesScale()
        chtAutovacuumCount.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Private Sub GetTopAutovacuumTable(ByVal stDate As DateTime, ByVal edDate As DateTime, ByVal countTop As Integer)
        Try
            Dim dtTable As DataTable = Nothing
            dtTable = _clsQuery.SelectAutovacuumTop(_InstanceID, stDate, edDate, countTop)
            _arrTables.Clear()
            If dtTable IsNot Nothing Then
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    Dim ti = New TableInfo
                    ti.tableName = CStr(i + 1) + ":" + dtTable.Rows(i).Item("DB_NAME") + "." + dtTable.Rows(i).Item("SCHEMA_NAME") + "." + dtTable.Rows(i).Item("TABLE_NAME")
                    ti.relID = dtTable.Rows(i).Item("RELID")
                    _arrTables.Add(ti)
                Next
            End If
        Catch ex As Exception
            GC.Collect()
            _dtTableAutovacuumWorker = Nothing
        Finally
        End Try
    End Sub

    Private Sub GetDatabases()
        Try
            Dim dtTable As DataTable = Nothing
            dtTable = _clsQuery.SelectDatabases(_InstanceID)
            _arrDatabases.Clear()
            If dtTable IsNot Nothing Then
                For i As Integer = 0 To dtTable.Rows.Count - 1
                    _arrDatabases.Add(dtTable.Rows(i).Item("DB_NAME"))
                Next
            End If
        Catch ex As Exception
            GC.Collect()
            _dtTableAutovacuumWorker = Nothing
        Finally
        End Try
    End Sub

    Private Sub cmbDuration_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim cbo As BaseControls.ComboBox = DirectCast(sender, BaseControls.ComboBox)
        Dim tempDt As Date = Now
        Select Case cbo.SelectedIndex
            Case 0
                tempDt = dtpSt.Value.AddMinutes(60)
            Case 1
                tempDt = dtpSt.Value.AddMinutes(120)
            Case 2
                tempDt = dtpSt.Value.AddMinutes(240)
            Case 3
                tempDt = dtpSt.Value.AddMinutes(720)
        End Select

        If tempDt > Now Then
            tempDt = Now
        End If
        dtpEd.Value = tempDt
    End Sub

    Private Sub rb1H_Click(sender As Object, e As EventArgs) Handles rb1H.Click, rb2H.Click, rb4H.Click, rb12H.Click, rb1D.Click
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
        End If
        btnQuery.PerformClick()
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

    Public Sub AddSeries(ByVal chtName As System.Windows.Forms.DataVisualization.Charting.Chart,
                 ByVal SeriesName As String,
                 ByVal strTitle As String,
                 Optional ByVal LineColor As System.Drawing.Color = Nothing,
                 Optional ByVal ChartType As System.Windows.Forms.DataVisualization.Charting.SeriesChartType = DataVisualization.Charting.SeriesChartType.Line)
        Dim Series As System.Windows.Forms.DataVisualization.Charting.Series = chtName.Series.Add(SeriesName.ToUpper)
        Series.BorderWidth = 2
        Series.ChartArea = "ChartArea1"
        Series.ChartType = ChartType
        Series.Legend = "Legend1"
        Series.Name = SeriesName
        Series.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        Series.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime
        Series.CustomProperties = "PixelPointWidth=5"
        If Not IsNothing(LineColor) Then
            Series.Color = LineColor
        End If
    End Sub

    Private Function sb_ChartAddPoint(ByVal MSChart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal dblX As Double, ByVal dblY As Double, Optional intRetainTime As Integer = 0) As Integer
        Try
            Dim rtnValue As Integer = MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), dblY)
            Return rtnValue
        Catch ex As Exception
            Return -1
        Finally
        End Try

    End Function
    Private Function sb_RangeChartAddPoint(ByVal MSChart As DataVisualization.Charting.Chart, ByVal strSeries As String, ByVal dblX As Double, ByVal dblY As Double, ByVal rank As Integer) As Integer
        Try
            'Dim rtnValue As Integer = MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), dblY)
            'MSChart.Series(strSeries).Points.Last.AxisLabel = rank
            If dblY > 0 Then
                Dim tmpTable As TableInfo = _arrTables(rank)
                MSChart.Series(strSeries).Points.AddXY(IIf(tmpTable.AxisXValue = 0.0, Date.FromOADate(dblX), Date.FromOADate(tmpTable.AxisXValue)), rank, rank + dblY)
                MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), rank, rank + dblY)
                MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), Double.NaN, Double.NaN)
            Else
                MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), rank, rank + dblY)
                MSChart.Series(strSeries).Points.AddXY(Date.FromOADate(dblX), Double.NaN, Double.NaN)
            End If
            Return 0
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
    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        GetTopAutovacuumTable(dtpSt.Value, dtpEd.Value, _countTop)
        GetDatabases()
        bgmanual.ReportProgress(10)
        initAutovacuumWraparound(dtpSt.Value, dtpEd.Value)
        bgmanual.ReportProgress(40)
        initAutovacuumWorker(dtpSt.Value, dtpEd.Value)
        bgmanual.ReportProgress(70)
        initAutovacuumCount(dtpSt.Value, dtpEd.Value)
        bgmanual.ReportProgress(100)
    End Sub

    Private Sub bgmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        Select Case e.ProgressPercentage
            Case 10
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("TXID age information")
                End If
            Case 40
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Autovacuum Workers activity information")
                End If
            Case 70
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Autovacuum information by tables")
                End If
            Case 100
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Complete")
                End If
        End Select
    End Sub

    Private Sub bgmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If e.Cancelled = False Then
            If _dtTableAutovacuumWraparound IsNot Nothing Then
                drawAutovacuumWraparound()
            End If
            If _dtTableAutovacuumWorker IsNot Nothing Then
                drawAutovacuumWorker()
            End If
            'If _dtTableAutovacuumCount IsNot Nothing Then
            drawAutovacuumCount()
            'End If
        End If

        _ProgresForm.Close()
    End Sub

    Private _dtTableAutovacuumWraparound As DataTable = Nothing
    Private Sub initAutovacuumWraparound(ByVal stDate As DateTime, ByVal edDate As DateTime)
        '  Check min duration 20240219
        Dim timeSpan As TimeSpan = edDate.Subtract(stDate)
        Dim stDateMin As DateTime
        If timeSpan.TotalMinutes < 6 Then
            stDateMin = edDate.AddMinutes(-7)
        Else
            stDateMin = stDate
        End If
        Try
            _dtTableAutovacuumWraparound = _clsQuery.SelectAutovacuumWraparound(_InstanceID, stDateMin, edDate)
        Catch ex As Exception
            GC.Collect()
            _dtTableAutovacuumWraparound = Nothing
        Finally
        End Try
    End Sub
    Private _dtTableAutovacuumWorker As DataTable = Nothing
    Private Sub initAutovacuumWorker(ByVal stDate As DateTime, ByVal edDate As DateTime)
        Try
            '  Check min duration 20240219
            Dim timeSpan As TimeSpan = edDate.Subtract(stDate)
            Dim stDateMin As DateTime
            If timeSpan.TotalMinutes < 6 Then
                stDateMin = edDate.AddMinutes(-7)
            Else
                stDateMin = stDate
            End If
            _dtTableAutovacuumWorker = _clsQuery.SelectAutovacuumWorker(_InstanceID, stDate, edDate)
        Catch ex As Exception
            GC.Collect()
            _dtTableAutovacuumWorker = Nothing
        Finally
        End Try
    End Sub
    Private _dtTableAutovacuumCount As DataTable = Nothing
    Private Sub initAutovacuumCount(ByVal stDate As DateTime, ByVal edDate As DateTime)
        Try
            Dim arrIndex As Integer = 0
            Dim arrColors As New ArrayList
            Dim strTopTables = ""

            For j As Integer = 0 To _arrTables.Count - 1
                arrColors.Add(_queryColors(arrIndex))
                arrIndex += 1
                Dim ti As TableInfo = _arrTables(j)
                If j = _arrTables.Count - 1 Then
                    strTopTables += ti.relID
                Else
                    strTopTables += ti.relID + ","
                End If
            Next

            strTopTables = String.Join(",", strTopTables)

            _dtTableAutovacuumCount = _clsQuery.SelectAutovacuumCount(_InstanceID, stDate, edDate, strTopTables)
        Catch ex As Exception
            GC.Collect()
            _dtTableAutovacuumCount = Nothing
        Finally
        End Try
    End Sub

    Private Sub cmbTop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTop.SelectedIndexChanged
        _countTop = cmbTop.Items(cmbTop.SelectedIndex)
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub frmAutovacuum_Move(sender As Object, e As EventArgs) Handles Me.Move
        If _ProgresForm IsNot Nothing Then
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
    End Sub
End Class
