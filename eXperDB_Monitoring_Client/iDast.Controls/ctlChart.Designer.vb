<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlChart
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctlChart))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine1 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim LegendCellColumn1 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim LegendCellColumn2 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim LegendCellColumn3 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim LegendCellColumn4 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim LegendCellColumn5 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim LegendCellColumn6 As System.Windows.Forms.DataVisualization.Charting.LegendCellColumn = New System.Windows.Forms.DataVisualization.Charting.LegendCellColumn()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.mnuChartMenu = New System.Windows.Forms.ToolStrip()
        Me.tsCharts = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsGRPDEFAREA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuZoomType = New System.Windows.Forms.ToolStripComboBox()
        Me.mnuZoomReset = New System.Windows.Forms.ToolStripButton()
        Me.mnuPause = New System.Windows.Forms.ToolStripButton()
        Me.tsShowValue = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsShowValueDeSel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsShowValueSep1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsShowLegend = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsShowMean = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsPrints = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrintPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrintPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsPrintMultiPage = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.mnuPopUpLegend = New System.Windows.Forms.ContextMenuStrip()
        Me.mnuPopupAligns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupAlignTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupAlignLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupAlignRght = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupAlignBottom = New System.Windows.Forms.ToolStripMenuItem()
        Me.범ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupMin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupMax = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupMEAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupVAL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPopupHidden = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChartMenu.SuspendLayout()
        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPopUpLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuChartMenu
        '
        Me.mnuChartMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCharts, Me.mnuZoomType, Me.mnuZoomReset, Me.mnuPause, Me.tsShowValue, Me.tsShowLegend, Me.tsShowMean, Me.tsPrints})
        Me.mnuChartMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuChartMenu.Name = "mnuChartMenu"
        Me.mnuChartMenu.Size = New System.Drawing.Size(530, 25)
        Me.mnuChartMenu.TabIndex = 0
        Me.mnuChartMenu.Text = "ToolStrip1"
        '
        'tsCharts
        '
        Me.tsCharts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsGRPDEFAREA})
        Me.tsCharts.Image = CType(resources.GetObject("tsCharts.Image"), System.Drawing.Image)
        Me.tsCharts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCharts.Name = "tsCharts"
        Me.tsCharts.Size = New System.Drawing.Size(60, 22)
        Me.tsCharts.Text = "차트"
        '
        'tsGRPDEFAREA
        '
        Me.tsGRPDEFAREA.Checked = True
        Me.tsGRPDEFAREA.CheckOnClick = True
        Me.tsGRPDEFAREA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsGRPDEFAREA.Name = "tsGRPDEFAREA"
        Me.tsGRPDEFAREA.Size = New System.Drawing.Size(67, 22)
        Me.tsGRPDEFAREA.Tag = "DEFAREA"
        '
        'mnuZoomType
        '
        Me.mnuZoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mnuZoomType.Items.AddRange(New Object() {"None", "ALL", "X", "Y"})
        Me.mnuZoomType.Name = "mnuZoomType"
        Me.mnuZoomType.Size = New System.Drawing.Size(75, 25)
        Me.mnuZoomType.ToolTipText = "Select zoom type"
        '
        'mnuZoomReset
        '
        Me.mnuZoomReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuZoomReset.Image = CType(resources.GetObject("mnuZoomReset.Image"), System.Drawing.Image)
        Me.mnuZoomReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuZoomReset.Name = "mnuZoomReset"
        Me.mnuZoomReset.Size = New System.Drawing.Size(23, 22)
        Me.mnuZoomReset.Text = "Reset Zoom"
        Me.mnuZoomReset.ToolTipText = "Reset Zoom"
        '
        'mnuPause
        '
        Me.mnuPause.Image = CType(resources.GetObject("mnuPause.Image"), System.Drawing.Image)
        Me.mnuPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuPause.Name = "mnuPause"
        Me.mnuPause.Size = New System.Drawing.Size(75, 22)
        Me.mnuPause.Tag = "0"
        Me.mnuPause.Text = "일시정지"
        '
        'tsShowValue
        '
        Me.tsShowValue.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsShowValueDeSel, Me.tsShowValueSep1})
        Me.tsShowValue.Image = CType(resources.GetObject("tsShowValue.Image"), System.Drawing.Image)
        Me.tsShowValue.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsShowValue.Name = "tsShowValue"
        Me.tsShowValue.Size = New System.Drawing.Size(48, 22)
        Me.tsShowValue.Text = "값"
        Me.tsShowValue.ToolTipText = "값 보기"
        Me.tsShowValue.Visible = False
        '
        'tsShowValueDeSel
        '
        Me.tsShowValueDeSel.Name = "tsShowValueDeSel"
        Me.tsShowValueDeSel.Size = New System.Drawing.Size(146, 22)
        Me.tsShowValueDeSel.Tag = "FIX"
        Me.tsShowValueDeSel.Text = "모두선택해제"
        '
        'tsShowValueSep1
        '
        Me.tsShowValueSep1.Name = "tsShowValueSep1"
        Me.tsShowValueSep1.Size = New System.Drawing.Size(143, 6)
        '
        'tsShowLegend
        '
        Me.tsShowLegend.Image = CType(resources.GetObject("tsShowLegend.Image"), System.Drawing.Image)
        Me.tsShowLegend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsShowLegend.Name = "tsShowLegend"
        Me.tsShowLegend.Size = New System.Drawing.Size(60, 22)
        Me.tsShowLegend.Text = "범례"
        Me.tsShowLegend.ToolTipText = "범례 보기"
        '
        'tsShowMean
        '
        Me.tsShowMean.Image = CType(resources.GetObject("tsShowMean.Image"), System.Drawing.Image)
        Me.tsShowMean.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsShowMean.Name = "tsShowMean"
        Me.tsShowMean.Size = New System.Drawing.Size(111, 22)
        Me.tsShowMean.Text = "평균(Average)"
        '
        'tsPrints
        '
        Me.tsPrints.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsPrint, Me.tsPrintPageSetup, Me.tsPrintPreview, Me.tsPrintMultiPage})
        Me.tsPrints.Image = CType(resources.GetObject("tsPrints.Image"), System.Drawing.Image)
        Me.tsPrints.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPrints.Name = "tsPrints"
        Me.tsPrints.Size = New System.Drawing.Size(60, 22)
        Me.tsPrints.Text = "인쇄"
        '
        'tsPrint
        '
        Me.tsPrint.Name = "tsPrint"
        Me.tsPrint.Size = New System.Drawing.Size(138, 22)
        Me.tsPrint.Text = "인쇄"
        '
        'tsPrintPageSetup
        '
        Me.tsPrintPageSetup.Name = "tsPrintPageSetup"
        Me.tsPrintPageSetup.Size = New System.Drawing.Size(138, 22)
        Me.tsPrintPageSetup.Text = "페이지 설정"
        '
        'tsPrintPreview
        '
        Me.tsPrintPreview.Name = "tsPrintPreview"
        Me.tsPrintPreview.Size = New System.Drawing.Size(138, 22)
        Me.tsPrintPreview.Text = "미리보기"
        '
        'tsPrintMultiPage
        '
        Me.tsPrintMultiPage.Name = "tsPrintMultiPage"
        Me.tsPrintMultiPage.Size = New System.Drawing.Size(138, 22)
        Me.tsPrintMultiPage.Text = "분할인쇄"
        Me.tsPrintMultiPage.Visible = False
        '
        'MainChart
        '
        Me.MainChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics
        Me.MainChart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss
        ChartArea1.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.LabelStyle.Format = "HH:mm:ss"
        ChartArea1.AxisX.LabelStyle.Interval = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        StripLine1.BackColor = System.Drawing.Color.White
        StripLine1.BorderColor = System.Drawing.Color.Red
        StripLine1.Text = "10"
        StripLine1.TextAlignment = System.Drawing.StringAlignment.Center
        StripLine1.TextLineAlignment = System.Drawing.StringAlignment.Far
        ChartArea1.AxisY.StripLines.Add(StripLine1)
        ChartArea1.Name = "DEFAREA"
        Me.MainChart.ChartAreas.Add(ChartArea1)
        Me.MainChart.ContextMenuStrip = Me.mnuPopUpLegend
        Me.MainChart.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MainChart.Dock = System.Windows.Forms.DockStyle.Fill
        LegendCellColumn1.ColumnType = System.Windows.Forms.DataVisualization.Charting.LegendCellColumnType.SeriesSymbol
        LegendCellColumn1.HeaderText = "Color"
        LegendCellColumn1.Name = "colColor"
        LegendCellColumn2.HeaderText = "Title"
        LegendCellColumn2.Name = "colNm"
        LegendCellColumn3.HeaderText = "Min."
        LegendCellColumn3.Name = "colMin"
        LegendCellColumn3.Text = "#MIN{N1}"
        LegendCellColumn4.HeaderText = "Max."
        LegendCellColumn4.Name = "colMax"
        LegendCellColumn4.Text = "#MAX{N1}"
        LegendCellColumn5.HeaderText = "Avg."
        LegendCellColumn5.Name = "colMean"
        LegendCellColumn5.Text = "#AVG{N1}"
        LegendCellColumn6.HeaderText = "Value"
        LegendCellColumn6.MaximumWidth = 0
        LegendCellColumn6.Name = "colValue"
        LegendCellColumn6.Text = "#LAST"
        Legend1.CellColumns.Add(LegendCellColumn1)
        Legend1.CellColumns.Add(LegendCellColumn2)
        Legend1.CellColumns.Add(LegendCellColumn3)
        Legend1.CellColumns.Add(LegendCellColumn4)
        Legend1.CellColumns.Add(LegendCellColumn5)
        Legend1.CellColumns.Add(LegendCellColumn6)
        Legend1.DockedToChartArea = "DEFAREA"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.GradientLine
        Legend1.IsDockedInsideChartArea = False
        Legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.DotLine
        Legend1.Name = "DEFLEGEND"
        Me.MainChart.Legends.Add(Legend1)
        Me.MainChart.Location = New System.Drawing.Point(0, 25)
        Me.MainChart.Name = "MainChart"
        Me.MainChart.Size = New System.Drawing.Size(530, 308)
        Me.MainChart.TabIndex = 1
        Me.MainChart.Text = "Chart1"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
        Title1.IsDockedInsideChartArea = False
        Title1.Name = "Title1"
        Me.MainChart.Titles.Add(Title1)
        '
        'mnuPopUpLegend
        '
        Me.mnuPopUpLegend.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopupAligns, Me.범ToolStripMenuItem, Me.mnuPopupHidden})
        Me.mnuPopUpLegend.Name = "mnuPopUpLegend"
        Me.mnuPopUpLegend.Size = New System.Drawing.Size(135, 70)
        '
        'mnuPopupAligns
        '
        Me.mnuPopupAligns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopupAlignTop, Me.mnuPopupAlignLeft, Me.mnuPopupAlignRght, Me.mnuPopupAlignBottom})
        Me.mnuPopupAligns.Name = "mnuPopupAligns"
        Me.mnuPopupAligns.Size = New System.Drawing.Size(134, 22)
        Me.mnuPopupAligns.Text = "맞춤(Align)"
        '
        'mnuPopupAlignTop
        '
        Me.mnuPopupAlignTop.CheckOnClick = True
        Me.mnuPopupAlignTop.Name = "mnuPopupAlignTop"
        Me.mnuPopupAlignTop.Size = New System.Drawing.Size(114, 22)
        Me.mnuPopupAlignTop.Tag = "0"
        Me.mnuPopupAlignTop.Text = "Top"
        '
        'mnuPopupAlignLeft
        '
        Me.mnuPopupAlignLeft.CheckOnClick = True
        Me.mnuPopupAlignLeft.Name = "mnuPopupAlignLeft"
        Me.mnuPopupAlignLeft.Size = New System.Drawing.Size(114, 22)
        Me.mnuPopupAlignLeft.Tag = "3"
        Me.mnuPopupAlignLeft.Text = "Left"
        '
        'mnuPopupAlignRght
        '
        Me.mnuPopupAlignRght.CheckOnClick = True
        Me.mnuPopupAlignRght.Name = "mnuPopupAlignRght"
        Me.mnuPopupAlignRght.Size = New System.Drawing.Size(114, 22)
        Me.mnuPopupAlignRght.Tag = "1"
        Me.mnuPopupAlignRght.Text = "Right"
        '
        'mnuPopupAlignBottom
        '
        Me.mnuPopupAlignBottom.CheckOnClick = True
        Me.mnuPopupAlignBottom.Name = "mnuPopupAlignBottom"
        Me.mnuPopupAlignBottom.Size = New System.Drawing.Size(114, 22)
        Me.mnuPopupAlignBottom.Tag = "2"
        Me.mnuPopupAlignBottom.Text = "Bottom"
        '
        '범ToolStripMenuItem
        '
        Me.범ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPopupMin, Me.mnuPopupMax, Me.mnuPopupMEAN, Me.mnuPopupVAL})
        Me.범ToolStripMenuItem.Name = "범ToolStripMenuItem"
        Me.범ToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.범ToolStripMenuItem.Text = "표시항목"
        '
        'mnuPopupMin
        '
        Me.mnuPopupMin.Checked = True
        Me.mnuPopupMin.CheckOnClick = True
        Me.mnuPopupMin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuPopupMin.Name = "mnuPopupMin"
        Me.mnuPopupMin.Size = New System.Drawing.Size(144, 22)
        Me.mnuPopupMin.Tag = "2"
        Me.mnuPopupMin.Text = "최소값(Min.)"
        '
        'mnuPopupMax
        '
        Me.mnuPopupMax.Checked = True
        Me.mnuPopupMax.CheckOnClick = True
        Me.mnuPopupMax.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuPopupMax.Name = "mnuPopupMax"
        Me.mnuPopupMax.Size = New System.Drawing.Size(144, 22)
        Me.mnuPopupMax.Tag = "3"
        Me.mnuPopupMax.Text = "최대값(Max.)"
        '
        'mnuPopupMEAN
        '
        Me.mnuPopupMEAN.Checked = True
        Me.mnuPopupMEAN.CheckOnClick = True
        Me.mnuPopupMEAN.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuPopupMEAN.Name = "mnuPopupMEAN"
        Me.mnuPopupMEAN.Size = New System.Drawing.Size(144, 22)
        Me.mnuPopupMEAN.Tag = "4"
        Me.mnuPopupMEAN.Text = "평균값(Avg.)"
        '
        'mnuPopupVAL
        '
        Me.mnuPopupVAL.CheckOnClick = True
        Me.mnuPopupVAL.Name = "mnuPopupVAL"
        Me.mnuPopupVAL.Size = New System.Drawing.Size(144, 22)
        Me.mnuPopupVAL.Tag = "5"
        Me.mnuPopupVAL.Text = "값(Value)"
        '
        'mnuPopupHidden
        '
        Me.mnuPopupHidden.CheckOnClick = True
        Me.mnuPopupHidden.Name = "mnuPopupHidden"
        Me.mnuPopupHidden.Size = New System.Drawing.Size(134, 22)
        Me.mnuPopupHidden.Text = "숨기기"
        '
        'ctlChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainChart)
        Me.Controls.Add(Me.mnuChartMenu)
        Me.Name = "ctlChart"
        Me.Size = New System.Drawing.Size(530, 333)
        Me.mnuChartMenu.ResumeLayout(False)
        Me.mnuChartMenu.PerformLayout()
        CType(Me.MainChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPopUpLegend.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuChartMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuZoomType As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents mnuZoomReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuPause As System.Windows.Forms.ToolStripButton
    Friend WithEvents MainChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents tsShowValue As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsShowLegend As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsShowMean As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsPrints As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsPrintPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrintPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrintMultiPage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsShowValueDeSel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsShowValueSep1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsCharts As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsGRPDEFAREA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopUpLegend As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuPopupAligns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupAlignTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupAlignLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupAlignRght As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupAlignBottom As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 범ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupMin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupMax As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupMEAN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupHidden As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPopupVAL As System.Windows.Forms.ToolStripMenuItem

End Class
