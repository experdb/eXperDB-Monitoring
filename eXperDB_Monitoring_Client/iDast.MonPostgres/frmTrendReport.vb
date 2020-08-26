''공통 NPOI
Imports NPOI
Imports NPOI.SS.UserModel
'표준 xls 버젼 excel시트
Imports NPOI.HSSF
Imports NPOI.HSSF.UserModel
'확장 xlsx 버젼 excel 시트
Imports NPOI.XSSF
Imports NPOI.XSSF.UserModel
Imports System.IO
Imports NPOI.HSSF.Util
Imports NPOI.SS.UserModel.Charts

Public Class frmTrendReport

    Private _clsQuery As clsQuerys
    Private _collapseHeight As Integer
    Private _GrpLst As List(Of GroupInfo)
    Private WithEvents _ProgresForm As frmProgres

    Private _instanceID As Integer
    Private _startDt As DateTime
    Private _endDt As DateTime
    Private _arrItems As New ArrayList
    Private _Result As Boolean
    Private _dtCodeTable As DataTable
    Private _dtTrendTable As DataTable
    Private _dtTrendStmtStatTable As DataTable
    Private _dtTrendLockTable As DataTable
    Private _dtTrendQueryTable As DataTable
    Private _dtTrendLockQueryTable As DataTable
    Private _topNSQL As Integer
    Private _isHour As Boolean
    Private _cluster As String
    Private _arrQueryItems As New ArrayList
    Private _arrLinkItems As New ArrayList
    Private _linkCellRow As New ArrayList
    Private _linkCellRowForLock As New ArrayList

    ''''''<For Chart>''''''''''''''''''''''''''''''''''
    Private _workbook As IWorkbook = Nothing
    Private Const subjectFontSize As Integer = 18
    Private Const contentFontSize As Integer = 12

    Private _titleBackColor = Nothing
    Private _clusterTitleBackColor = Nothing
    Private _timeValueBackColor = Nothing

    Private _defaultFont As IFont = Nothing
    Private _subjectFont As IFont = Nothing
    Private _infoFont As IFont = Nothing
    Private _queryIDFont As IFont = Nothing

    Private _defaultStyle As XSSFCellStyle = Nothing
    Private _subjectStyle As XSSFCellStyle = Nothing
    Private _itmeTitleStyle As XSSFCellStyle = Nothing
    Private _itmeSubTitleStyle As XSSFCellStyle = Nothing
    Private _timeSeriesStyle As XSSFCellStyle = Nothing
    Private _infoStyle As XSSFCellStyle = Nothing
    Private _infoValueStyle As XSSFCellStyle = Nothing
    Private _queryTextStyle As XSSFCellStyle = Nothing
    Private _queryIDStyle As XSSFCellStyle = Nothing

    Private _defaultRowHeight As Integer = 0

    Private _chartHeight As Integer = 10
    Private _chartNumber As Integer = 0
    Private _rowNumber As Integer = 0

    Public Class CellInfo
        Public Sub New(ByVal queryID As String, ByVal linkAddress As String)
            _queryID = queryID
            _linkAddress = linkAddress
        End Sub

        Private _queryID As String = ""
        ReadOnly Property queryID
            Get
                Return _queryID
            End Get
        End Property

        Private _linkAddress As String
        ReadOnly Property linkAddress As String
            Get
                Return _linkAddress
            End Get
        End Property
    End Class


    ''''''<For Chart>''''''''''''''''''''''''''''''''''

    Public Sub New(ByRef odbcConn As eXperDBODBC, ByVal GrpLst As List(Of GroupInfo))

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
        _clsQuery = New clsQuerys(odbcConn)
        _GrpLst = GrpLst

        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbClusters.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next

        lblReportItemConfig.Text = p_clsMsgData.fn_GetData("F966")
        colDgvCollectItemListCodeName.HeaderText = p_clsMsgData.fn_GetData("F967")
        colDgvReportItemListCodeName.HeaderText = p_clsMsgData.fn_GetData("F968")

        Me.ttChart.SetToolTip(Me.btnAddItem, p_clsMsgData.fn_GetData("F016"))
        Me.ttChart.SetToolTip(Me.btnDeleteItem, p_clsMsgData.fn_GetData("F015"))
    End Sub

    Private Sub initForm()
        lblReportFrom.Text = p_clsMsgData.fn_GetData("F254")
        lblUnit.Text = p_clsMsgData.fn_GetData("F973")
        rbToday.Text = p_clsMsgData.fn_GetData("F969")
        rbTomorrow.Text = p_clsMsgData.fn_GetData("F970")
        rbLastWeek.Text = p_clsMsgData.fn_GetData("F971")
        rbLastMonth.Text = p_clsMsgData.fn_GetData("F972")
        btnGenerate.Text = p_clsMsgData.fn_GetData("F956", "Report")
        StatusLabel.Text = p_clsMsgData.fn_GetData("M096")
    End Sub

    Private Sub frmSnapshotR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim todayMidnight As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0)
        dtpSt.Value = todayMidnight
        dtpEd.Value = Now
        cmbTopNSQL.SelectedIndex = 0
        cmbUnit.SelectedIndex = 0
        _dtCodeTable = _clsQuery.selectReportItems()
        If _dtCodeTable IsNot Nothing Then
            For Each tmpRow As DataRow In _dtCodeTable.Rows
                Dim idxRow As Integer = dgvCollectItemList.Rows.Add()
                dgvCollectItemList.fn_DataCellADD(idxRow, 0, tmpRow.Item("CODE"))
                dgvCollectItemList.fn_DataCellADD(idxRow, 1, tmpRow.Item("CODE_NAME"))
            Next
        End If
    End Sub

#Region "Internal functions"

    Private Sub ReportLog(ByVal intAccessType As Integer, ByVal intStatus As Integer, _
                      Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertReportInfo(p_cSession.UserID, intAccessType, intStatus, strLog, strLocIP, intInstanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim frmReportHistory As New frmReportHistory(_clsQuery, _GrpLst, cmbClusters.SelectedValue)
        frmReportHistory.ShowDialog()
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        _topNSQL = cmbTopNSQL.SelectedItem
        _isHour = IIf(cmbUnit.SelectedItem.Equals("Hour"), True, False)
        _cluster = cmbClusters.SelectedItem(0).ToString
        If dgvReportItemList.Rows.Count = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M106"))
            Return
        End If
        If DateDiff(DateInterval.Minute, dtpSt.Value, dtpEd.Value) < 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M014"))
            Return
        End If
        makeProgress()
    End Sub

    Private Sub makeProgress()
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

        '''''''''''''''''''''''''''''''''''''''''''
        'set global variable for background worker'
        '''''''''''''''''''''''''''''''''''''''''''
        _instanceID = cmbClusters.SelectedValue
        _startDt = dtpSt.Value
        _endDt = dtpEd.Value
        '''''''''''''''''''''''''''''''''''''''''''
        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(0)
        GenerateReport()
        bgmanual.ReportProgress(100)
    End Sub

    Private Sub bgmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        Select Case e.ProgressPercentage
            Case 100
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Complete")
                End If
        End Select
    End Sub

    Private Sub bgmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If _ProgresForm IsNot Nothing Then
            _ProgresForm.Close()
            _ProgresForm = Nothing
        End If
        If _dtTrendTable Is Nothing Or _workbook Is Nothing Then
            MsgBox(p_clsMsgData.fn_GetData("M104"))
            Return
        End If

        Try
            Dim logStr As String = _startDt.ToString("yyyyMMddHH") + "-" + _endDt.ToString("yyyyMMddHH") + " "
            For Each tmpRow As DataGridViewRow In dgvReportItemList.Rows
                logStr += tmpRow.Cells(1).Value
                logStr += ","
            Next
            If logStr.Length > 199 Then
                logStr = logStr.Substring(0, 199)
            End If
            ReportLog(1, 0, logStr, _instanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try

        Try
            If _Result = False Then
                MsgBox(p_clsMsgData.fn_GetData("M104"))
                Return
            End If
            Dim fsd As New SaveFileDialog
            fsd.AddExtension = True
            fsd.DefaultExt = "*.xlsx"

            fsd.FileName = cmbClusters.SelectedItem(0) + "_" + _startDt.ToString("yyyyMMddHH") + "_" + _endDt.ToString("yyyyMMddHH")
            fsd.FileName = fsd.FileName.Replace(":", String.Empty).Replace("-", String.Empty).Replace(" ", String.Empty)
            fsd.Filter = "Excel |*.xlsx"
            If fsd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                WriteExcel(_workbook, fsd.FileName)
                If MsgBox(p_clsMsgData.fn_GetData("M013"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start(fsd.FileName)
                End If
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub GenerateReport()
        Try
            _arrItems.Clear()
            For Each tmpRow As DataGridViewRow In Me.dgvReportItemList.Rows
                _arrItems.Add(Integer.Parse(tmpRow.Cells(0).Value))
            Next

            _dtTrendTable = _clsQuery.selectTrendReport(_instanceID, _startDt, _endDt, _isHour, _arrItems)
            _dtTrendStmtStatTable = _clsQuery.selectTrendReportStmtStat(1, _startDt, _endDt, 321)
            _dtTrendLockTable = _clsQuery.selectTrendReportLock(1, _startDt, _endDt, 320)
            'If _dtTrendTable Is Nothing Or _dtTrendTable.Rows.Count = 0 Then
            '    Return
            'End If
            _Result = GenerateExcel()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub frmSnapshotR_Move(sender As Object, e As EventArgs) Handles Me.Move
        If _ProgresForm IsNot Nothing Then
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
    End Sub

    Private Sub rbToday_CheckedChanged(sender As Object, e As EventArgs) Handles rbToday.CheckedChanged, rbTomorrow.CheckedChanged, rbLastWeek.CheckedChanged, rbLastMonth.CheckedChanged
        Dim Rb As BaseControls.RadioButton = DirectCast(sender, BaseControls.RadioButton)
        If Rb.Checked = True Then
            Dim todayMidnight As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0)
            Dim yesterdayMidnight As DateTime = todayMidnight.AddDays(-1)
            dtpEd.Value = DateTime.Now
            If Rb.Name.Equals("rbToday") Then
                dtpSt.Value = todayMidnight
                dtpEd.Value = DateTime.Now.Date.AddHours(24)
            ElseIf Rb.Name.Equals("rbTomorrow") Then
                dtpSt.Value = yesterdayMidnight
                dtpEd.Value = dtpSt.Value.AddHours(24)
            ElseIf Rb.Name.Equals("rbLastWeek") Then
                dtpSt.Value = DateTime.Today.AddDays(-(DateTime.Today.DayOfWeek - DayOfWeek.Sunday)).AddHours(0)
                dtpEd.Value = DateTime.Now.Date.AddHours(24)
            ElseIf Rb.Name.Equals("rbLastMonth") Then
                dtpSt.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                dtpEd.Value = DateTime.Now.Date.AddHours(24)
            End If
        End If
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try
            For Each tmpRow As DataGridViewRow In Me.dgvCollectItemList.SelectedRows
                dgvReportItemList.Rows.Add(tmpRow.Cells(0).Value, tmpRow.Cells(1).Value)
                dgvCollectItemList.Rows.Remove(tmpRow)
            Next
            dgvCollectItemList.Sort(dgvCollectItemList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            dgvReportItemList.Sort(dgvReportItemList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        Try
            For Each tmpRow As DataGridViewRow In Me.dgvReportItemList.SelectedRows
                dgvCollectItemList.Rows.Add(tmpRow.Cells(0).Value, tmpRow.Cells(1).Value)
                dgvReportItemList.Rows.Remove(tmpRow)
            Next
            dgvCollectItemList.Sort(dgvCollectItemList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
            dgvReportItemList.Sort(dgvReportItemList.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub dgvCollectItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCollectItemList.CellDoubleClick
        Me.Invoke(New MethodInvoker(Sub()
                                        btnAddItem.PerformClick()
                                    End Sub))
    End Sub

    Private Sub dgvReportItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReportItemList.CellContentClick
        Me.Invoke(New MethodInvoker(Sub()
                                        btnDeleteItem.PerformClick()
                                    End Sub))
    End Sub


#Region "Excel"

    Private Sub GenerateStyles(ByRef workbook As IWorkbook)
        _defaultRowHeight = 360

        _titleBackColor = New XSSFColor(System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(233, Byte), Integer)))
        _clusterTitleBackColor = New XSSFColor(System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(231, Byte), Integer)))
        _timeValueBackColor = New XSSFColor(System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(209, Byte), Integer)))

        _defaultFont = workbook.CreateFont()
        _subjectFont = workbook.CreateFont()
        _infoFont = workbook.CreateFont()
        _queryIDFont = workbook.CreateFont()

        _defaultStyle = workbook.CreateCellStyle()
        _subjectStyle = workbook.CreateCellStyle()
        _infoStyle = workbook.CreateCellStyle()
        _itmeTitleStyle = workbook.CreateCellStyle()
        _timeSeriesStyle = workbook.CreateCellStyle()
        _infoValueStyle = workbook.CreateCellStyle()
        _itmeSubTitleStyle = workbook.CreateCellStyle()
        _queryTextStyle = workbook.CreateCellStyle()
        _queryIDStyle = workbook.CreateCellStyle()

        _defaultFont.Color = IndexedColors.DarkBlue.Index
        _defaultFont.FontName = ("Arial")
        _defaultFont.FontHeightInPoints = 12
        _defaultFont.IsBold = False

        _subjectFont.FontHeightInPoints = subjectFontSize
        _subjectFont.IsBold = True

        _infoFont.FontHeightInPoints = contentFontSize
        _infoFont.IsBold = True

        _queryIDFont.FontName = ("Arial")
        _queryIDFont.FontHeightInPoints = 12
        _queryIDFont.Underline = FontUnderlineType.Single
        _queryIDFont.Color = IndexedColors.Blue.Index

        _defaultStyle.Alignment = HorizontalAlignment.Center
        _defaultStyle.VerticalAlignment = VerticalAlignment.Center
        _defaultStyle.FillPattern = FillPattern.SolidForeground
        _defaultStyle.FillForegroundColor = IndexedColors.White.Index
        _defaultStyle.BorderTop = BorderStyle.Thin
        _defaultStyle.BorderBottom = BorderStyle.Thin
        _defaultStyle.BorderLeft = BorderStyle.Thin
        _defaultStyle.BorderRight = BorderStyle.Thin
        _defaultStyle.BottomBorderColor = IndexedColors.Grey50Percent.Index
        _defaultStyle.LeftBorderColor = IndexedColors.Grey50Percent.Index
        _defaultStyle.RightBorderColor = IndexedColors.Grey50Percent.Index
        _defaultStyle.TopBorderColor = IndexedColors.Grey50Percent.Index
        _defaultStyle.SetDataFormat(workbook.CreateDataFormat().GetFormat("0.00"))

        _subjectStyle.CloneStyleFrom(_defaultStyle)
        _subjectStyle.SetFont(_subjectFont)
        _subjectStyle.SetFillForegroundColor(_titleBackColor)

        _infoStyle.CloneStyleFrom(_defaultStyle)
        _infoStyle.SetFont(_infoFont)
        _infoStyle.SetFillForegroundColor(_clusterTitleBackColor)

        _infoValueStyle.CloneStyleFrom(_defaultStyle)
        _infoValueStyle.FillForegroundColor = IndexedColors.White.Index

        _itmeTitleStyle.CloneStyleFrom(_defaultStyle)
        _itmeTitleStyle.Alignment = HorizontalAlignment.Left
        _itmeTitleStyle.FillForegroundColor = IndexedColors.Grey25Percent.Index

        _itmeSubTitleStyle.Alignment = HorizontalAlignment.Left
        _itmeSubTitleStyle.VerticalAlignment = VerticalAlignment.Center
        _itmeSubTitleStyle.BorderTop = BorderStyle.Thin
        _itmeSubTitleStyle.BorderBottom = BorderStyle.Thin
        _itmeSubTitleStyle.BorderLeft = BorderStyle.Thin
        _itmeSubTitleStyle.BorderRight = BorderStyle.Thin

        _timeSeriesStyle.CloneStyleFrom(_defaultStyle)
        _timeSeriesStyle.SetFillForegroundColor(_timeValueBackColor)

        _queryTextStyle.FillPattern = FillPattern.SolidForeground
        _queryTextStyle.FillForegroundColor = IndexedColors.White.Index
        _queryTextStyle.BorderTop = BorderStyle.Thin
        _queryTextStyle.BorderBottom = BorderStyle.Thin
        _queryTextStyle.BorderLeft = BorderStyle.Thin
        _queryTextStyle.BorderRight = BorderStyle.Thin
        _queryTextStyle.Alignment = HorizontalAlignment.Left
        _queryTextStyle.VerticalAlignment = VerticalAlignment.Top
        _queryTextStyle.WrapText = True

        _queryIDStyle.FillPattern = FillPattern.SolidForeground
        _queryIDStyle.FillForegroundColor = IndexedColors.White.Index
        _queryIDStyle.BorderTop = BorderStyle.Thin
        _queryIDStyle.BorderBottom = BorderStyle.Thin
        _queryIDStyle.BorderLeft = BorderStyle.Thin
        _queryIDStyle.BorderRight = BorderStyle.Thin
        _queryIDStyle.Alignment = HorizontalAlignment.Center
        _queryIDStyle.SetFont(_queryIDFont)

    End Sub
    Private Sub WriteHeaderFooter(ByRef sheet As ISheet)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'set header text
        sheet.Header.Left = HSSFHeader.Page
        sheet.Header.Center = "eXperDB-Monitoring"
        'set footer text
        sheet.Footer.Left = "Copyright eXperDB"
        sheet.Footer.Right = Now
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    End Sub

    Private Function MakeRows(ByRef sheet As ISheet, ByVal rows As Integer) As Boolean
        'Row 생성
        Dim row As IRow = Nothing
        Try
            For i As Integer = 0 To rows
                row = sheet.CreateRow(i)
                row.Height = _defaultRowHeight
                For j As Integer = 0 To 12
                    row.CreateCell(j)
                Next
            Next
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Private Function WriteSubject(ByRef sheet As ISheet, ByVal Cluster As String, ByVal startTime As String, ByVal endTime As String) As Boolean
        Try
            Dim cell As ICell = Nothing
            Dim range = New NPOI.SS.Util.CellRangeAddress(0, 2, 0, 12)
            sheet.AddMergedRegion(range)
            For i As Integer = 0 To 2
                For j As Integer = 0 To 12
                    cell = GetCell(sheet.GetRow(i), j)
                    cell.CellStyle = _subjectStyle
                    cell.SetCellValue("Trend Report")
                Next
            Next

            Dim clusterTitleRange = New NPOI.SS.Util.CellRangeAddress(4, 4, 6, 8)
            sheet.AddMergedRegion(clusterTitleRange)
            Dim startTitleRange = New NPOI.SS.Util.CellRangeAddress(4, 4, 9, 10)
            sheet.AddMergedRegion(startTitleRange)
            Dim endTitleRange = New NPOI.SS.Util.CellRangeAddress(4, 4, 11, 12)
            sheet.AddMergedRegion(endTitleRange)
            Dim clusterRange = New NPOI.SS.Util.CellRangeAddress(5, 5, 6, 8)
            sheet.AddMergedRegion(clusterRange)
            Dim startRange = New NPOI.SS.Util.CellRangeAddress(5, 5, 9, 10)
            sheet.AddMergedRegion(startRange)
            Dim endRange = New NPOI.SS.Util.CellRangeAddress(5, 5, 11, 12)
            sheet.AddMergedRegion(endRange)

            For i = 6 To 8
                cell = GetCell(sheet.GetRow(4), i)
                cell.SetCellValue("Cluster name")
                cell.CellStyle = _infoStyle
                cell = GetCell(sheet.GetRow(5), i)
                cell.CellStyle = _infoValueStyle
                cell.SetCellValue(Cluster)
            Next

            For i = 9 To 10
                cell = GetCell(sheet.GetRow(4), i)
                cell.CellStyle = _infoStyle
                cell.SetCellValue("Start time")
                cell = GetCell(sheet.GetRow(5), i)
                cell.CellStyle = _infoValueStyle
                cell.SetCellValue(startTime)
            Next

            For i = 11 To 12
                cell = GetCell(sheet.GetRow(4), i)
                cell.CellStyle = _infoStyle
                cell.SetCellValue("End time")
                cell = GetCell(sheet.GetRow(5), i)
                cell.CellStyle = _infoValueStyle
                cell.SetCellValue(endTime)
            Next
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Private Function WriteTrendData(ByRef sheet As ISheet, ByRef dtView As DataView, ByVal charIndex As Integer, ByVal trendType As Integer) As Boolean
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = charIndex * 3
        Dim colIndex As Integer = 1
        If dtView.Count <= 0 Then
            Return False
        End If
        Try
            cell = GetCell(sheet.GetRow(rowIndex), 0)
            cell.SetCellValue(trendType)
            cell.CellStyle = _defaultStyle

            For Each tmpRow As DataRow In dtView.ToTable.Select()
                cell = GetCell(sheet.GetRow(rowIndex), colIndex)
                cell.SetCellValue(tmpRow.Item("COLLECT_DATETIME").ToString)
                cell.CellStyle = _timeSeriesStyle
                colIndex += 1
            Next

            cell = GetCell(sheet.GetRow(rowIndex + 1), 0)
            cell.SetCellValue("MAX")
            cell.CellStyle = _defaultStyle

            cell = GetCell(sheet.GetRow(rowIndex + 2), 0)
            cell.SetCellValue("AVG")
            cell.CellStyle = _defaultStyle
            colIndex = 1
            For Each tmpRow As DataRow In dtView.ToTable.Select()
                cell = GetCell(sheet.GetRow(rowIndex + 1), colIndex)
                cell.SetCellValue(Double.Parse(tmpRow.Item("MAX_VALUE").ToString))
                cell.SetCellType(CellType.Numeric)
                cell.CellStyle = _defaultStyle
                cell = GetCell(sheet.GetRow(rowIndex + 2), colIndex)
                cell.SetCellValue(Double.Parse(tmpRow.Item("AVG_VALUE").ToString))
                cell.SetCellType(CellType.Numeric)
                cell.CellStyle = _defaultStyle
                colIndex += 1
            Next
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function

    Private Function DrawChartFromData(ByRef sheetReport As ISheet, ByRef sheetData As ISheet, ByVal title As String, ByVal colCount As Integer, ByVal charIndex As Integer) As Boolean
        Try
            Dim drawing As IDrawing = sheetReport.CreateDrawingPatriarch()
            Dim chartTop As Integer = _rowNumber
            Dim anchor1 As IClientAnchor = drawing.CreateAnchor(0, 0, 0, 0, 0, chartTop, 13, chartTop + _chartHeight)
            CreateChart(drawing, sheetReport, sheetData, anchor1, "MAX", "AVG", charIndex * 3, charIndex * 3, 1, colCount)
            _rowNumber += _chartHeight
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Private Function WriteSectionHeader(ByRef sheet As ISheet, ByVal title As String)
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = _rowNumber + 1
        Try
            Dim sectionTitleRange = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 0, 12)
            sheet.AddMergedRegion(sectionTitleRange)

            For i = 0 To 12
                cell = GetCell(sheet.GetRow(rowIndex), i)
                cell.SetCellValue(title)
                cell.CellStyle = _itmeTitleStyle
            Next

            _rowNumber += 1
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function

    Private Function WriteSectionSubHeader(ByRef sheet As ISheet, ByVal title As String)
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = _rowNumber + 1
        Try
            Dim sectionTitleRange = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 0, 12)
            sheet.AddMergedRegion(sectionTitleRange)

            For i = 0 To 12
                cell = GetCell(sheet.GetRow(rowIndex), i)
                cell.SetCellValue(title)
                cell.CellStyle = _itmeSubTitleStyle
            Next

            _rowNumber += 1
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function

    Private Function WriteStatement(ByRef sheet As ISheet, ByRef dtTable As DataTable, ByVal order As Integer)
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = _rowNumber
        Dim strOrder As String = IIf(order = 1, "total_time desc", "calls desc")
        Try
            Dim dtView As DataView = New DataView(dtTable, "", strOrder, DataViewRowState.CurrentRows)
            Dim dtSubTable = dtView.ToTable("Selected", False, "queryid_md5", "userid", "dbid", "calls", "calls(%)", "total_time", "total_time(%)", "rows", "rows(%)", "cpu(%)").AsEnumerable.Take(_topNSQL).CopyToDataTable()
            Dim range As NPOI.SS.Util.CellRangeAddress = Nothing

            '''''''''''store queryids'''''''''''''
            Dim j As Integer = 0
            For i As Integer = 0 To dtSubTable.Columns.Count - 1
                cell = GetCell(sheet.GetRow(rowIndex), j)
                cell.SetCellValue(dtSubTable.Columns(i).ColumnName.ToLower)
                cell.CellStyle = _timeSeriesStyle
                If i = 0 Or i = 5 Or i = 6 Then
                    range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, j, j + 1)
                    sheet.AddMergedRegion(range)
                    cell = GetCell(sheet.GetRow(rowIndex), j + 1)
                    cell.SetCellValue(dtSubTable.Columns(i).ColumnName)
                    cell.CellStyle = _timeSeriesStyle
                    j += 1
                End If
                j += 1
            Next

            rowIndex += 1
            _linkCellRow.Add(rowIndex)
            For i As Integer = 0 To dtSubTable.Rows.Count - 1
                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 0, 1)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 0)
                cell.SetCellValue(dtSubTable.Rows(i).Item("queryid_md5").ToString)
                cell.CellStyle = _queryIDStyle
                cell = GetCell(sheet.GetRow(rowIndex), 1)
                cell.SetCellValue(dtSubTable.Rows(i).Item("queryid_md5").ToString)
                cell.CellStyle = _queryIDStyle
                _arrQueryItems.Add(dtSubTable.Rows(i).Item("queryid_md5").ToString) 'collect queryid

                cell = GetCell(sheet.GetRow(rowIndex), 2)
                cell.SetCellValue(dtSubTable.Rows(i).Item("userid").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 3)
                cell.SetCellValue(dtSubTable.Rows(i).Item("dbid").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 4)
                cell.SetCellValue(dtSubTable.Rows(i).Item("calls").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 5)
                cell.SetCellValue(dtSubTable.Rows(i).Item("calls(%)").ToString)
                cell.CellStyle = _defaultStyle

                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 6, 7)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 6)
                cell.SetCellValue(dtSubTable.Rows(i).Item("total_time").ToString)
                cell.CellStyle = _defaultStyle
                cell = GetCell(sheet.GetRow(rowIndex), 7)
                cell.SetCellValue(dtSubTable.Rows(i).Item("total_time").ToString)
                cell.CellStyle = _defaultStyle

                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 8, 9)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 8)
                cell.SetCellValue(dtSubTable.Rows(i).Item("total_time(%)").ToString)
                cell.CellStyle = _defaultStyle
                cell = GetCell(sheet.GetRow(rowIndex), 9)
                cell.SetCellValue(dtSubTable.Rows(i).Item("total_time(%)").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 10)
                cell.SetCellValue(dtSubTable.Rows(i).Item("rows").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 11)
                cell.SetCellValue(dtSubTable.Rows(i).Item("rows(%)").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 12)
                cell.SetCellValue(dtSubTable.Rows(i).Item("cpu(%)").ToString)
                cell.CellStyle = _defaultStyle

                rowIndex += 1
                If rowIndex Mod 52 = 0 Then
                    'sheet.SetRowBreak(rowIndex)
                    'sheet.FitToPage = True
                    'Dim ps = sheet.PrintSetup
                    'ps.FitWidth = 1
                    'ps.FitHeight = 1
                End If
            Next
            _linkCellRow.Add(rowIndex)
            _rowNumber = rowIndex
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function


    Private Function WriteLockSessions(ByRef sheet As ISheet, ByRef dtTable As DataTable)
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = _rowNumber
        Try
            Dim dtView As DataView = New DataView(dtTable, "", "", DataViewRowState.CurrentRows)
            Dim dtSubTable = dtView.ToTable("Selected", False, "DB", "USER", "PID", "BLOCKING", "LOCK USER", "LOCK PID", "MODE", "QUERYID", "DURATION", "TRANSACTION START")
            Dim range As NPOI.SS.Util.CellRangeAddress = Nothing

            Dim j As Integer = 0
            For i As Integer = 0 To dtSubTable.Columns.Count - 1
                cell = GetCell(sheet.GetRow(rowIndex), j)
                cell.SetCellValue(dtSubTable.Columns(i).ColumnName.ToLower)
                cell.CellStyle = _timeSeriesStyle
                If i = 6 Or i = 7 Or i = 9 Then
                    range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, j, j + 1)
                    sheet.AddMergedRegion(range)
                    cell = GetCell(sheet.GetRow(rowIndex), j + 1)
                    cell.SetCellValue(dtSubTable.Columns(i).ColumnName)
                    cell.CellStyle = _timeSeriesStyle
                    j += 1
                End If
                j += 1
            Next
            rowIndex += 1
            _linkCellRowForLock.Add(rowIndex)
            For i As Integer = 0 To dtSubTable.Rows.Count - 1
                cell = GetCell(sheet.GetRow(rowIndex), 0)
                cell.SetCellValue(dtSubTable.Rows(i).Item("db").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 1)
                cell.SetCellValue(dtSubTable.Rows(i).Item("user").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 2)
                cell.SetCellValue(dtSubTable.Rows(i).Item("pid").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 3)
                cell.SetCellValue(dtSubTable.Rows(i).Item("blocking").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 4)
                cell.SetCellValue(dtSubTable.Rows(i).Item("lock user").ToString)
                cell.CellStyle = _defaultStyle

                cell = GetCell(sheet.GetRow(rowIndex), 5)
                cell.SetCellValue(dtSubTable.Rows(i).Item("lock pid").ToString)
                cell.CellStyle = _defaultStyle

                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 6, 7)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 6)
                cell.SetCellValue(dtSubTable.Rows(i).Item("mode").ToString)
                cell.CellStyle = _defaultStyle
                cell = GetCell(sheet.GetRow(rowIndex), 7)
                cell.SetCellValue(dtSubTable.Rows(i).Item("mode").ToString)
                cell.CellStyle = _defaultStyle

                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 8, 9)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 8)
                cell.SetCellValue(dtSubTable.Rows(i).Item("queryid").ToString)
                cell.CellStyle = _queryIDStyle
                cell = GetCell(sheet.GetRow(rowIndex), 9)
                cell.SetCellValue(dtSubTable.Rows(i).Item("queryid").ToString)
                cell.CellStyle = _queryIDStyle
                _arrQueryItems.Add(dtSubTable.Rows(i).Item("queryid").ToString) 'collect queryid

                cell = GetCell(sheet.GetRow(rowIndex), 10)
                cell.SetCellValue(dtSubTable.Rows(i).Item("duration").ToString)
                cell.CellStyle = _defaultStyle

                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 11, 12)
                sheet.AddMergedRegion(range)
                cell = GetCell(sheet.GetRow(rowIndex), 11)
                cell.SetCellValue(dtSubTable.Rows(i).Item("TRANSACTION START").ToString)
                cell.CellStyle = _defaultStyle
                cell = GetCell(sheet.GetRow(rowIndex), 12)
                cell.SetCellValue(dtSubTable.Rows(i).Item("TRANSACTION START").ToString)
                cell.CellStyle = _defaultStyle

                rowIndex += 1
            Next
            _linkCellRowForLock.Add(rowIndex)
            _rowNumber = rowIndex
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function

    Private Function WriteQuery(ByRef sheet As ISheet, ByRef dtTable As DataTable)
        Dim cell As ICell = Nothing
        Dim rowIndex As Integer = _rowNumber
        Try
            Dim range As NPOI.SS.Util.CellRangeAddress = Nothing

            '''''''''''store queryids'''''''''''''
            range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 0, 1)
            sheet.AddMergedRegion(range)
            range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 2, 12)
            sheet.AddMergedRegion(range)
            For i As Integer = 0 To 12
                If i < 2 Then
                    cell = GetCell(sheet.GetRow(rowIndex), i)
                    cell.SetCellValue(dtTable.Columns(0).ColumnName.ToLower)
                    cell.CellStyle = _timeSeriesStyle
                Else
                    cell = GetCell(sheet.GetRow(rowIndex), i)
                    cell.SetCellValue(dtTable.Columns(1).ColumnName.ToLower)
                    cell.CellStyle = _timeSeriesStyle
                End If
            Next

            rowIndex += 1
            Dim lineCount As Integer = 0
            For i As Integer = 0 To dtTable.Rows.Count - 1
                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 0, 1)
                sheet.AddMergedRegion(range)
                range = New NPOI.SS.Util.CellRangeAddress(rowIndex, rowIndex, 2, 12)
                sheet.AddMergedRegion(range)
                For j = 0 To 12
                    If j < 2 Then
                        cell = GetCell(sheet.GetRow(rowIndex), j)
                        cell.SetCellValue(dtTable.Rows(i).Item("queryid").ToString)
                        cell.CellStyle = _defaultStyle
                        If j = 0 Then
                            Dim cellinfo = New CellInfo(cell.StringCellValue, cell.Address.ToString)
                            If j = 0 Then _arrLinkItems.Add(cellinfo)
                        End If
                    Else
                        cell = GetCell(sheet.GetRow(rowIndex), j)
                        Dim strQuery As String = dtTable.Rows(i).Item("query").ToString
                        strQuery.Replace(Chr(13), vbCrLf)
                        cell.SetCellValue(strQuery)
                        lineCount = strQuery.Split(vbCrLf).Length
                        sheet.GetRow(rowIndex).Height = _defaultRowHeight * lineCount
                        For k As Integer = 0 To lineCount - 1
                            If strQuery.Split(vbCrLf)(k).Length > 110 Then
                                Dim newlineCount As Integer = strQuery.Split(vbCrLf)(k).Length \ 110
                                sheet.GetRow(rowIndex).Height += _defaultRowHeight * newlineCount
                            End If
                        Next
                        cell.CellStyle = _queryTextStyle
                        cell.CellStyle.WrapText = True
                    End If
                Next
                rowIndex += 1
            Next
            _rowNumber = rowIndex
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
        rowIndex += 1
    End Function

    Private Sub CreateChart(ByRef drawing As IDrawing, ByRef sheetReport As ISheet, ByRef sheetData As ISheet, ByRef anchor As IClientAnchor, ByVal serie1 As String, ByVal serie2 As String, _
                        ByVal firstRow As Integer, ByVal lastRow As Integer, ByVal firstCol As Integer, ByVal lastCol As Integer)
        Dim chart As IChart = drawing.CreateChart(anchor)
        Dim legend As IChartLegend = chart.GetOrCreateLegend()
        legend.Position = LegendPosition.Right

        'CType(chart, XSSFChart).SetTitle(title)
        'CType(chart, XSSFChart).Title.ApplyFont(_defaultFont)

        Dim lineChartData = chart.ChartDataFactory.CreateLineChartData(Of Double, Double)()

        ' Use a category axis for the bottom axis.
        Dim bottomAxis As IChartAxis = chart.ChartAxisFactory.CreateCategoryAxis(AxisPosition.Bottom)
        Dim leftAxis As IValueAxis = chart.ChartAxisFactory.CreateValueAxis(AxisPosition.Left)
        leftAxis.Crosses = AxisCrosses.AutoZero

        Dim xs = NPOI.SS.UserModel.Charts.DataSources.FromNumericCellRange(sheetData, New NPOI.SS.Util.CellRangeAddress(firstRow, lastRow, firstCol, lastCol))
        Dim ys1 = NPOI.SS.UserModel.Charts.DataSources.FromNumericCellRange(sheetData, New NPOI.SS.Util.CellRangeAddress(firstRow + 1, lastRow + 1, firstCol, lastCol))
        Dim ys2 = NPOI.SS.UserModel.Charts.DataSources.FromNumericCellRange(sheetData, New NPOI.SS.Util.CellRangeAddress(firstRow + 2, lastRow + 2, firstCol, lastCol))

        lineChartData.AddSeries(xs, ys1)
        lineChartData.AddSeries(xs, ys2)
        lineChartData.GetSeries(0).SetTitle(serie1)
        lineChartData.GetSeries(1).SetTitle(serie2)
        chart.Plot(lineChartData, bottomAxis, leftAxis)
    End Sub

    Private Function CreateWorkbook(ByVal version As String) As IWorkbook
        '표준 xls 버젼
        If version.Equals("xls") Then
            Return New HSSFWorkbook()
            '확장 xlsx 버젼
        ElseIf ("xlsx".Equals(version)) Then
            Return New XSSFWorkbook()
        End If
        Throw New NotSupportedException("")
    End Function
    Public Function GetCell(ByVal row As IRow, ByVal cellnum As Integer) As ICell
        Dim cell As ICell = row.GetCell(cellnum)
        If cell Is Nothing Then
            cell = row.CreateCell(cellnum)
        End If
        Return cell
    End Function


    Private Function GenerateExcel() As Boolean
        Try
            _workbook = New XSSFWorkbook()
            Dim sheetR As ISheet = Nothing
            Dim sheetD As ISheet = Nothing
            Dim title As String = Nothing
            Dim reportRows As Integer = 7 'for Subjects
            GenerateStyles(_workbook)
            sheetR = _workbook.CreateSheet("Report")
            sheetD = _workbook.CreateSheet("Data")

            WriteHeaderFooter(sheetR)
            MakeRows(sheetD, 15 * 3) 'DataSheet
            sheetR.DisplayGridlines = False
            sheetR.PrintSetup.PaperSize = PaperSize.A4

            reportRows += _arrItems.Count * (_chartHeight + 2)
            MakeRows(sheetR, 500) 'ReportSheet

            If WriteSubject(sheetR, _cluster, _startDt.ToString("yyyy-MM-dd HH"), _endDt.ToString("yyyy-MM-dd HH")) = False Then
                Return False
            End If

            _rowNumber = 6

            ''''''''''''''''''''''''''''''''Trend Report
            Dim dtView As DataView
            If _dtTrendTable IsNot Nothing AndAlso _dtTrendTable.Rows.Count > 0 Then
                For i As Integer = 0 To _arrItems.Count - 1
                    Dim trendType = _arrItems(i)
                    If trendType >= 320 Then Exit For
                    Dim strQuery = String.Format("TREND_TYPE = {0}", _arrItems(i))
                    dtView = New DataView(_dtTrendTable, strQuery, "", DataViewRowState.CurrentRows)

                    title = GetCodeName(_arrItems(i))
                    If dtView.Count <= 0 Then
                        title = title + "-" + "No Data"
                    End If
                    WriteSectionHeader(sheetR, title)
                    _rowNumber += 1

                    If WriteTrendData(sheetD, dtView, i, _arrItems(i)) = True Then
                        DrawChartFromData(sheetR, sheetD, title, dtView.Count, i)
                    End If
                Next
                _rowNumber += 1
            End If

            ''''''''''''''''''''''''''''''''
            ''''''''''''''''''''''''''''''''LIST type data
            _arrQueryItems.Clear()
            For i As Integer = 0 To _arrItems.Count - 1
                Dim trendType = _arrItems(i)
                If trendType < 320 Then Continue For
                Dim dtCodeView As DataView = Nothing
                Select Case trendType
                    Case 320
                        title = GetCodeName(trendType)
                        If _dtTrendLockTable Is Nothing Or _dtTrendLockTable.Rows.Count <= 0 Then
                            title = title + "-" + "No Data"
                            WriteSectionHeader(sheetR, title)
                            _rowNumber += 1
                            Continue For
                        End If
                        title = _dtTrendLockTable.Rows(0).Item("TREND_TYPE")
                        WriteSectionHeader(sheetR, title)
                        _rowNumber += 1
                        _linkCellRowForLock.Clear()
                        WriteLockSessions(sheetR, _dtTrendLockTable)
                    Case 321
                        title = GetCodeName(trendType)
                        If _dtTrendStmtStatTable Is Nothing Or _dtTrendStmtStatTable.Rows.Count <= 0 Then
                            title = title + "-" + "No Data"
                            WriteSectionHeader(sheetR, title)
                            Continue For
                        End If
                        title = _dtTrendStmtStatTable.Rows(0).Item("TREND_TYPE")
                        WriteSectionHeader(sheetR, title)
                        WriteSectionSubHeader(sheetR, "Top Statement - Total time")
                        _rowNumber += 1
                        _linkCellRow.Clear()
                        WriteStatement(sheetR, _dtTrendStmtStatTable, 1)
                        WriteSectionSubHeader(sheetR, "Top Statement - Calls")
                        _rowNumber += 1
                        WriteStatement(sheetR, _dtTrendStmtStatTable, 2)
                    Case 322
                End Select

            Next

            '''''''''''''''Get query text
            _dtTrendQueryTable = _clsQuery.selectTrendReportQuery(_instanceID, _arrQueryItems)

            If _dtTrendQueryTable IsNot Nothing AndAlso _dtTrendQueryTable.Rows.Count > 0 Then
                title = "Query text"
                WriteSectionHeader(sheetR, title)
                _rowNumber += 1
                _arrLinkItems.Clear()
                WriteQuery(sheetR, _dtTrendQueryTable)
            End If

            '''''''''''''''Set link for queryid
            Dim startRowIndex As Integer = 0
            Dim endRowIndex As Integer = 0
            If _linkCellRowForLock.Count > 0 Then
                startRowIndex = _linkCellRowForLock(0)
                endRowIndex = _linkCellRowForLock(1)
                For j As Integer = startRowIndex To endRowIndex - 1
                    Dim cell = GetCell(sheetR.GetRow(j), 8)
                    For k As Integer = 0 To _arrLinkItems.Count - 1
                        Dim cellinfo = CType(_arrLinkItems(k), CellInfo)
                        If cell.StringCellValue.Equals(cellinfo.queryID) Then
                            Dim link As XSSFHyperlink = New XSSFHyperlink(HyperlinkType.Document)
                            link.Address = cellinfo.linkAddress
                            cell.Hyperlink = link
                            Exit For
                        End If
                    Next
                Next
            End If
            If _linkCellRow.Count > 0 Then
                For i As Integer = 0 To _linkCellRow.Count / 2 - 1
                    startRowIndex = _linkCellRow(i * 2)
                    endRowIndex = _linkCellRow(i * 2 + 1)
                    For j As Integer = startRowIndex To endRowIndex - 1
                        Dim cell = GetCell(sheetR.GetRow(j), 0)
                        For k As Integer = 0 To _arrLinkItems.Count - 1
                            Dim cellinfo = CType(_arrLinkItems(k), CellInfo)
                            If cell.StringCellValue.Equals(cellinfo.queryID) Then
                                Dim link As XSSFHyperlink = New XSSFHyperlink(HyperlinkType.Document)
                                link.Address = cellinfo.linkAddress
                                cell.Hyperlink = link
                                Exit For
                            End If
                        Next
                    Next
                Next
            End If
            _workbook.SetPrintArea(0, 0, 12, 0, _rowNumber)
            Return True
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try

    End Function


    Private Sub WriteExcel(ByRef workbook As IWorkbook, ByVal filepath As String)
        Using file As FileStream = New FileStream(filepath, FileMode.Create, FileAccess.Write)
            workbook.Write(file)
        End Using
    End Sub

    Private Function GetCodeName(ByVal code As String) As String
        Dim codeName As String = ""
        If _dtCodeTable IsNot Nothing Then
            For Each tmpRow As DataRow In _dtCodeTable.Rows
                If tmpRow.Item("CODE").ToString.Equals(code) Then
                    codeName = tmpRow.Item("CODE_NAME")
                    Exit For
                End If
            Next
        End If
        Return codeName
    End Function

#End Region


End Class


