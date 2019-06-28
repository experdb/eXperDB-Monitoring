<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutovacuum
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutovacuum))
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine2 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.btnRange = New eXperDB.BaseControls.Button()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.tlpChartArea3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.chtAutovacuumCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tlpChartTitle3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbTop = New eXperDB.BaseControls.ComboBox()
        Me.Label11 = New eXperDB.BaseControls.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.tlpChartArea2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.chtAutovacuumWorkers = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tlpChartTitle2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWorker = New System.Windows.Forms.Label()
        Me.tlpChartArea = New eXperDB.BaseControls.TableLayoutPanel()
        Me.chtAutovacuumWraparound = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tlpChartTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWaparound = New System.Windows.Forms.Label()
        Me.tlpInput = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dtpDay = New eXperDB.BaseControls.DateTimePicker()
        Me.rb1D = New eXperDB.BaseControls.RadioButton()
        Me.rb12H = New eXperDB.BaseControls.RadioButton()
        Me.rb4H = New eXperDB.BaseControls.RadioButton()
        Me.rb2H = New eXperDB.BaseControls.RadioButton()
        Me.rb1H = New eXperDB.BaseControls.RadioButton()
        Me.pnlEd = New eXperDB.BaseControls.Panel()
        Me.lblEd = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.pnlSt = New eXperDB.BaseControls.Panel()
        Me.lblSt = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.cmbInst = New eXperDB.BaseControls.ComboBox()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.colDgvLockDB = New AdvancedDataGridView.TreeGridColumn()
        Me.colDgvLockBlockingPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockingUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockingQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockElapse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockQueryStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockXactStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockRegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockActvRegSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.tlpChartArea3.SuspendLayout()
        CType(Me.chtAutovacuumCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpChartTitle3.SuspendLayout()
        Me.tlpChartArea2.SuspendLayout()
        CType(Me.chtAutovacuumWorkers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpChartTitle2.SuspendLayout()
        Me.tlpChartArea.SuspendLayout()
        CType(Me.chtAutovacuumWraparound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpChartTitle.SuspendLayout()
        Me.tlpInput.SuspendLayout()
        Me.pnlEd.SuspendLayout()
        Me.pnlSt.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblSubject, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuery, 7, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnRange, 6, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1184, 50)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubject.ForeColor = System.Drawing.Color.White
        Me.lblSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubject.Location = New System.Drawing.Point(43, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(738, 50)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 50)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "      "
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.Transparent
        Me.btnQuery.Location = New System.Drawing.Point(1087, 14)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(94, 32)
        Me.btnQuery.TabIndex = 31
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'btnRange
        '
        Me.btnRange.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRange.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnRange.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRange.FixedHeight = False
        Me.btnRange.FixedWidth = False
        Me.btnRange.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnRange.ForeColor = System.Drawing.Color.White
        Me.btnRange.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRange.LineColor = System.Drawing.Color.Transparent
        Me.btnRange.Location = New System.Drawing.Point(987, 14)
        Me.btnRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Radius = 5
        Me.btnRange.Size = New System.Drawing.Size(94, 32)
        Me.btnRange.TabIndex = 32
        Me.btnRange.Text = "F269"
        Me.btnRange.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRange.UseRound = True
        Me.btnRange.UseVisualStyleBackColor = False
        Me.btnRange.Visible = False
        '
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Transparent
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Controls.Add(Me.tlpChartArea3, 0, 2)
        Me.tlpBottom.Controls.Add(Me.tlpChartArea2, 0, 1)
        Me.tlpBottom.Controls.Add(Me.tlpChartArea, 0, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 11.46654!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpBottom.Location = New System.Drawing.Point(0, 50)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 3
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25!))
        Me.tlpBottom.Size = New System.Drawing.Size(1184, 912)
        Me.tlpBottom.TabIndex = 8
        '
        'tlpChartArea3
        '
        Me.tlpChartArea3.BackColor = System.Drawing.Color.Transparent
        Me.tlpChartArea3.ColumnCount = 1
        Me.tlpBottom.SetColumnSpan(Me.tlpChartArea3, 2)
        Me.tlpChartArea3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea3.Controls.Add(Me.chtAutovacuumCount, 0, 1)
        Me.tlpChartArea3.Controls.Add(Me.tlpChartTitle3, 0, 0)
        Me.tlpChartArea3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChartArea3.Font = New System.Drawing.Font("Gulim", 9.366439!)
        Me.tlpChartArea3.Location = New System.Drawing.Point(3, 630)
        Me.tlpChartArea3.Name = "tlpChartArea3"
        Me.tlpChartArea3.RowCount = 2
        Me.tlpChartArea3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpChartArea3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartArea3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartArea3.Size = New System.Drawing.Size(1178, 279)
        Me.tlpChartArea3.TabIndex = 2
        '
        'chtAutovacuumCount
        '
        Me.chtAutovacuumCount.BackColor = System.Drawing.Color.Black
        ChartArea4.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea4.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea4.AxisX.IsLabelAutoFit = False
        ChartArea4.AxisX.IsMarginVisible = False
        ChartArea4.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea4.AxisX.LabelStyle.Format = "MM-dd HH:mm"
        ChartArea4.AxisX.LabelStyle.Interval = 0.0R
        ChartArea4.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea4.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea4.AxisX.LabelStyle.IsEndLabelVisible = False
        ChartArea4.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea4.AxisX.MajorTickMark.Enabled = False
        ChartArea4.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea4.AxisX.ScaleView.Zoomable = False
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisX2.IsLabelAutoFit = False
        ChartArea4.AxisX2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisX2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea4.AxisY.IsLabelAutoFit = False
        ChartArea4.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea4.AxisY.LabelStyle.Format = "       0"
        ChartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea4.AxisY.MajorTickMark.Enabled = False
        ChartArea4.AxisY.MaximumAutoSize = 100.0!
        ChartArea4.AxisY.Title = "Autovacuums"
        ChartArea4.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea4.AxisY2.IsLabelAutoFit = False
        ChartArea4.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.AxisY2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea4.BackColor = System.Drawing.Color.Black
        ChartArea4.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea4.CursorX.IsUserEnabled = True
        ChartArea4.CursorX.IsUserSelectionEnabled = True
        ChartArea4.CursorY.AutoScroll = False
        ChartArea4.Name = "ChartArea1"
        Me.chtAutovacuumCount.ChartAreas.Add(ChartArea4)
        Me.chtAutovacuumCount.Dock = System.Windows.Forms.DockStyle.Fill
        Legend4.Alignment = System.Drawing.StringAlignment.Far
        Legend4.BackColor = System.Drawing.Color.Black
        Legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend4.ForeColor = System.Drawing.Color.White
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.chtAutovacuumCount.Legends.Add(Legend4)
        Me.chtAutovacuumCount.Location = New System.Drawing.Point(3, 41)
        Me.chtAutovacuumCount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtAutovacuumCount.Name = "chtAutovacuumCount"
        Me.chtAutovacuumCount.Size = New System.Drawing.Size(1172, 234)
        Me.chtAutovacuumCount.TabIndex = 6
        Me.chtAutovacuumCount.Text = "Chart5"
        '
        'tlpChartTitle3
        '
        Me.tlpChartTitle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpChartTitle3.ColumnCount = 4
        Me.tlpChartTitle3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpChartTitle3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpChartTitle3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpChartTitle3.Controls.Add(Me.cmbTop, 3, 0)
        Me.tlpChartTitle3.Controls.Add(Me.Label11, 2, 0)
        Me.tlpChartTitle3.Controls.Add(Me.Label12, 0, 0)
        Me.tlpChartTitle3.Controls.Add(Me.lblCount, 1, 0)
        Me.tlpChartTitle3.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpChartTitle3.Location = New System.Drawing.Point(3, 3)
        Me.tlpChartTitle3.Name = "tlpChartTitle3"
        Me.tlpChartTitle3.RowCount = 1
        Me.tlpChartTitle3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle3.Size = New System.Drawing.Size(1172, 31)
        Me.tlpChartTitle3.TabIndex = 4
        '
        'cmbTop
        '
        Me.cmbTop.BackColor = System.Drawing.SystemColors.Window
        Me.cmbTop.DisplayMember = "All"
        Me.cmbTop.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTop.FixedWidth = False
        Me.cmbTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbTop.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.cmbTop.FormattingEnabled = True
        Me.cmbTop.Items.AddRange(New Object() {"5", "10"})
        Me.cmbTop.Location = New System.Drawing.Point(1075, 6)
        Me.cmbTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTop.Name = "cmbTop"
        Me.cmbTop.Necessary = False
        Me.cmbTop.Size = New System.Drawing.Size(94, 20)
        Me.cmbTop.StatusTip = ""
        Me.cmbTop.TabIndex = 29
        Me.cmbTop.ValueText = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label11.FixedHeight = False
        Me.Label11.FixedWidth = False
        Me.Label11.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.LineSpacing = 0.0!
        Me.Label11.Location = New System.Drawing.Point(995, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 31)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Top"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Image = CType(resources.GetObject("Label12.Image"), System.Drawing.Image)
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 31)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "      "
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.BackColor = System.Drawing.Color.Transparent
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(43, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(946, 31)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "F336"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpChartArea2
        '
        Me.tlpChartArea2.BackColor = System.Drawing.Color.Transparent
        Me.tlpChartArea2.ColumnCount = 1
        Me.tlpBottom.SetColumnSpan(Me.tlpChartArea2, 2)
        Me.tlpChartArea2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea2.Controls.Add(Me.chtAutovacuumWorkers, 0, 1)
        Me.tlpChartArea2.Controls.Add(Me.tlpChartTitle2, 0, 0)
        Me.tlpChartArea2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChartArea2.Font = New System.Drawing.Font("Gulim", 9.366439!)
        Me.tlpChartArea2.Location = New System.Drawing.Point(3, 345)
        Me.tlpChartArea2.Name = "tlpChartArea2"
        Me.tlpChartArea2.RowCount = 2
        Me.tlpChartArea2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpChartArea2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea2.Size = New System.Drawing.Size(1178, 279)
        Me.tlpChartArea2.TabIndex = 1
        '
        'chtAutovacuumWorkers
        '
        Me.chtAutovacuumWorkers.BackColor = System.Drawing.Color.Black
        ChartArea6.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea6.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea6.AxisX.IsLabelAutoFit = False
        ChartArea6.AxisX.IsMarginVisible = False
        ChartArea6.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea6.AxisX.LabelStyle.Format = "MM-dd HH:mm"
        ChartArea6.AxisX.LabelStyle.Interval = 0.0R
        ChartArea6.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea6.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea6.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea6.AxisX.LabelStyle.IsEndLabelVisible = False
        ChartArea6.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea6.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea6.AxisX.MajorTickMark.Enabled = False
        ChartArea6.AxisX.ScaleView.Zoomable = False
        ChartArea6.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisX2.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea6.AxisX2.IsLabelAutoFit = False
        ChartArea6.AxisX2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisX2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisY.IsLabelAutoFit = False
        ChartArea6.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea6.AxisY.LabelStyle.Format = "       0"
        ChartArea6.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea6.AxisY.MajorTickMark.Enabled = False
        ChartArea6.AxisY.Title = "Workers"
        ChartArea6.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[False]
        ChartArea6.AxisY2.IsLabelAutoFit = False
        ChartArea6.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.AxisY2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea6.BackColor = System.Drawing.Color.Black
        ChartArea6.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea6.Name = "ChartArea1"
        Me.chtAutovacuumWorkers.ChartAreas.Add(ChartArea6)
        Me.chtAutovacuumWorkers.Dock = System.Windows.Forms.DockStyle.Fill
        Legend6.Alignment = System.Drawing.StringAlignment.Far
        Legend6.BackColor = System.Drawing.Color.Black
        Legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend6.ForeColor = System.Drawing.Color.White
        Legend6.IsTextAutoFit = False
        Legend6.Name = "Legend1"
        Me.chtAutovacuumWorkers.Legends.Add(Legend6)
        Me.chtAutovacuumWorkers.Location = New System.Drawing.Point(3, 41)
        Me.chtAutovacuumWorkers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtAutovacuumWorkers.Name = "chtAutovacuumWorkers"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea
        Series3.Color = System.Drawing.Color.Khaki
        Series3.Legend = "Legend1"
        Series3.Name = "Wraparound prevention"
        Series4.BorderColor = System.Drawing.Color.LightSeaGreen
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea
        Series4.Color = System.Drawing.Color.LightSeaGreen
        Series4.Legend = "Legend1"
        Series4.Name = "Vacuum"
        Me.chtAutovacuumWorkers.Series.Add(Series3)
        Me.chtAutovacuumWorkers.Series.Add(Series4)
        Me.chtAutovacuumWorkers.Size = New System.Drawing.Size(1172, 234)
        Me.chtAutovacuumWorkers.TabIndex = 6
        Me.chtAutovacuumWorkers.Text = "Chart4"
        '
        'tlpChartTitle2
        '
        Me.tlpChartTitle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpChartTitle2.ColumnCount = 4
        Me.tlpChartTitle2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpChartTitle2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpChartTitle2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpChartTitle2.Controls.Add(Me.Label4, 0, 0)
        Me.tlpChartTitle2.Controls.Add(Me.lblWorker, 1, 0)
        Me.tlpChartTitle2.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpChartTitle2.Location = New System.Drawing.Point(3, 3)
        Me.tlpChartTitle2.Name = "tlpChartTitle2"
        Me.tlpChartTitle2.RowCount = 1
        Me.tlpChartTitle2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle2.Size = New System.Drawing.Size(1172, 31)
        Me.tlpChartTitle2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "      "
        '
        'lblWorker
        '
        Me.lblWorker.AutoSize = True
        Me.lblWorker.BackColor = System.Drawing.Color.Transparent
        Me.lblWorker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWorker.ForeColor = System.Drawing.Color.White
        Me.lblWorker.Location = New System.Drawing.Point(43, 0)
        Me.lblWorker.Name = "lblWorker"
        Me.lblWorker.Size = New System.Drawing.Size(946, 31)
        Me.lblWorker.TabIndex = 3
        Me.lblWorker.Text = "F335"
        Me.lblWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpChartArea
        '
        Me.tlpChartArea.BackColor = System.Drawing.Color.Transparent
        Me.tlpChartArea.ColumnCount = 1
        Me.tlpBottom.SetColumnSpan(Me.tlpChartArea, 2)
        Me.tlpChartArea.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea.Controls.Add(Me.chtAutovacuumWraparound, 0, 3)
        Me.tlpChartArea.Controls.Add(Me.tlpChartTitle, 0, 2)
        Me.tlpChartArea.Controls.Add(Me.tlpInput, 0, 0)
        Me.tlpChartArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChartArea.Font = New System.Drawing.Font("Gulim", 9.366439!)
        Me.tlpChartArea.Location = New System.Drawing.Point(3, 3)
        Me.tlpChartArea.Name = "tlpChartArea"
        Me.tlpChartArea.RowCount = 4
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartArea.Size = New System.Drawing.Size(1178, 336)
        Me.tlpChartArea.TabIndex = 0
        '
        'chtAutovacuumWraparound
        '
        Me.chtAutovacuumWraparound.BackColor = System.Drawing.Color.Black
        ChartArea5.AlignmentOrientation = CType((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical Or System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal), System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)
        ChartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea5.AxisX.IsLabelAutoFit = False
        ChartArea5.AxisX.IsMarginVisible = False
        ChartArea5.AxisX.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea5.AxisX.LabelStyle.Format = "MM-dd HH:mm"
        ChartArea5.AxisX.LabelStyle.Interval = 0.0R
        ChartArea5.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea5.AxisX.LabelStyle.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea5.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea5.AxisX.LabelStyle.IsEndLabelVisible = False
        ChartArea5.AxisX.LabelStyle.TruncatedLabels = True
        ChartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea5.AxisX.MajorTickMark.Enabled = False
        ChartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White
        ChartArea5.AxisX.ScaleView.Zoomable = False
        ChartArea5.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisX2.IsLabelAutoFit = False
        ChartArea5.AxisX2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisX2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.[True]
        ChartArea5.AxisY.Interval = 500.0R
        ChartArea5.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number
        ChartArea5.AxisY.IsLabelAutoFit = False
        ChartArea5.AxisY.IsMarginVisible = False
        ChartArea5.AxisY.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.WhiteSmoke
        ChartArea5.AxisY.LabelStyle.Format = "0M"
        ChartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        ChartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea5.AxisY.MajorTickMark.Enabled = False
        ChartArea5.AxisY.Maximum = 2048.0R
        ChartArea5.AxisY.Minimum = 0.0R
        ChartArea5.AxisY.StripLines.Add(StripLine2)
        ChartArea5.AxisY.Title = "Age of TXID"
        ChartArea5.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea5.AxisY2.IsLabelAutoFit = False
        ChartArea5.AxisY2.LabelStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.AxisY2.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 9.687912!)
        ChartArea5.BackColor = System.Drawing.Color.Black
        ChartArea5.CursorX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes
        ChartArea5.CursorX.IsUserEnabled = True
        ChartArea5.CursorX.IsUserSelectionEnabled = True
        ChartArea5.CursorY.AutoScroll = False
        ChartArea5.Name = "ChartArea1"
        Me.chtAutovacuumWraparound.ChartAreas.Add(ChartArea5)
        Me.chtAutovacuumWraparound.Dock = System.Windows.Forms.DockStyle.Fill
        Legend5.Alignment = System.Drawing.StringAlignment.Far
        Legend5.BackColor = System.Drawing.Color.Black
        Legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Legend5.ForeColor = System.Drawing.Color.White
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.chtAutovacuumWraparound.Legends.Add(Legend5)
        Me.chtAutovacuumWraparound.Location = New System.Drawing.Point(3, 90)
        Me.chtAutovacuumWraparound.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtAutovacuumWraparound.Name = "chtAutovacuumWraparound"
        Me.chtAutovacuumWraparound.Size = New System.Drawing.Size(1172, 242)
        Me.chtAutovacuumWraparound.TabIndex = 7
        Me.chtAutovacuumWraparound.Text = "Chart5"
        '
        'tlpChartTitle
        '
        Me.tlpChartTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpChartTitle.ColumnCount = 4
        Me.tlpChartTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpChartTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpChartTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpChartTitle.Controls.Add(Me.Label2, 0, 0)
        Me.tlpChartTitle.Controls.Add(Me.lblWaparound, 1, 0)
        Me.tlpChartTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpChartTitle.Location = New System.Drawing.Point(3, 48)
        Me.tlpChartTitle.Name = "tlpChartTitle"
        Me.tlpChartTitle.RowCount = 1
        Me.tlpChartTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartTitle.Size = New System.Drawing.Size(1172, 34)
        Me.tlpChartTitle.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "      "
        '
        'lblWaparound
        '
        Me.lblWaparound.AutoSize = True
        Me.lblWaparound.BackColor = System.Drawing.Color.Transparent
        Me.lblWaparound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWaparound.ForeColor = System.Drawing.Color.White
        Me.lblWaparound.Location = New System.Drawing.Point(43, 0)
        Me.lblWaparound.Name = "lblWaparound"
        Me.lblWaparound.Size = New System.Drawing.Size(946, 34)
        Me.lblWaparound.TabIndex = 3
        Me.lblWaparound.Text = "F334"
        Me.lblWaparound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpInput
        '
        Me.tlpInput.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpInput.ColumnCount = 14
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpInput.Controls.Add(Me.dtpDay, 8, 0)
        Me.tlpInput.Controls.Add(Me.rb1D, 7, 0)
        Me.tlpInput.Controls.Add(Me.rb12H, 6, 0)
        Me.tlpInput.Controls.Add(Me.rb4H, 5, 0)
        Me.tlpInput.Controls.Add(Me.rb2H, 4, 0)
        Me.tlpInput.Controls.Add(Me.rb1H, 3, 0)
        Me.tlpInput.Controls.Add(Me.pnlEd, 13, 0)
        Me.tlpInput.Controls.Add(Me.pnlSt, 11, 0)
        Me.tlpInput.Controls.Add(Me.cmbInst, 1, 0)
        Me.tlpInput.Controls.Add(Me.lblServer, 0, 0)
        Me.tlpInput.Controls.Add(Me.lblDuration2, 12, 0)
        Me.tlpInput.Controls.Add(Me.lblDuration, 2, 0)
        Me.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInput.Font = New System.Drawing.Font("Gulim", 7.650974!)
        Me.tlpInput.ForeColor = System.Drawing.Color.White
        Me.tlpInput.Location = New System.Drawing.Point(3, 3)
        Me.tlpInput.Name = "tlpInput"
        Me.tlpInput.RowCount = 1
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInput.Size = New System.Drawing.Size(1172, 31)
        Me.tlpInput.TabIndex = 0
        '
        'dtpDay
        '
        Me.dtpDay.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDay.Checked = False
        Me.dtpDay.CustomFormat = "yyyy-MM-dd"
        Me.dtpDay.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpDay.FixedWidth = False
        Me.dtpDay.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDay.Location = New System.Drawing.Point(633, 4)
        Me.dtpDay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDay.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Necessary = False
        Me.dtpDay.ShowCheckBox = True
        Me.dtpDay.Size = New System.Drawing.Size(124, 22)
        Me.dtpDay.StatusTip = ""
        Me.dtpDay.TabIndex = 41
        Me.dtpDay.Value = New Date(2018, 9, 14, 0, 0, 0, 0)
        '
        'rb1D
        '
        Me.rb1D.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb1D.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rb1D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb1D.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb1D.ForeColor = System.Drawing.Color.White
        Me.rb1D.LineColor = System.Drawing.Color.Transparent
        Me.rb1D.Location = New System.Drawing.Point(563, 3)
        Me.rb1D.Name = "rb1D"
        Me.rb1D.Radius = 8
        Me.rb1D.Size = New System.Drawing.Size(64, 25)
        Me.rb1D.TabIndex = 40
        Me.rb1D.Text = "~1D"
        Me.rb1D.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rb1D.UseRound = True
        Me.rb1D.UseVisualStyleBackColor = True
        Me.rb1D.Warning = False
        Me.rb1D.WarningColor = System.Drawing.Color.Red
        '
        'rb12H
        '
        Me.rb12H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb12H.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rb12H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb12H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb12H.ForeColor = System.Drawing.Color.White
        Me.rb12H.LineColor = System.Drawing.Color.Transparent
        Me.rb12H.Location = New System.Drawing.Point(493, 3)
        Me.rb12H.Name = "rb12H"
        Me.rb12H.Radius = 8
        Me.rb12H.Size = New System.Drawing.Size(64, 25)
        Me.rb12H.TabIndex = 39
        Me.rb12H.Text = "~12H"
        Me.rb12H.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rb12H.UseRound = True
        Me.rb12H.UseVisualStyleBackColor = True
        Me.rb12H.Warning = False
        Me.rb12H.WarningColor = System.Drawing.Color.Red
        '
        'rb4H
        '
        Me.rb4H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb4H.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rb4H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb4H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb4H.ForeColor = System.Drawing.Color.White
        Me.rb4H.LineColor = System.Drawing.Color.Transparent
        Me.rb4H.Location = New System.Drawing.Point(423, 3)
        Me.rb4H.Name = "rb4H"
        Me.rb4H.Radius = 8
        Me.rb4H.Size = New System.Drawing.Size(64, 25)
        Me.rb4H.TabIndex = 38
        Me.rb4H.Text = "~4H"
        Me.rb4H.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rb4H.UseRound = True
        Me.rb4H.UseVisualStyleBackColor = True
        Me.rb4H.Warning = False
        Me.rb4H.WarningColor = System.Drawing.Color.Red
        '
        'rb2H
        '
        Me.rb2H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb2H.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rb2H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb2H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb2H.ForeColor = System.Drawing.Color.White
        Me.rb2H.LineColor = System.Drawing.Color.Transparent
        Me.rb2H.Location = New System.Drawing.Point(353, 3)
        Me.rb2H.Name = "rb2H"
        Me.rb2H.Radius = 8
        Me.rb2H.Size = New System.Drawing.Size(64, 25)
        Me.rb2H.TabIndex = 37
        Me.rb2H.Text = "~2H"
        Me.rb2H.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rb2H.UseRound = True
        Me.rb2H.UseVisualStyleBackColor = True
        Me.rb2H.Warning = False
        Me.rb2H.WarningColor = System.Drawing.Color.Red
        '
        'rb1H
        '
        Me.rb1H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb1H.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rb1H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb1H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb1H.ForeColor = System.Drawing.Color.White
        Me.rb1H.LineColor = System.Drawing.Color.Transparent
        Me.rb1H.Location = New System.Drawing.Point(283, 3)
        Me.rb1H.Name = "rb1H"
        Me.rb1H.Radius = 8
        Me.rb1H.Size = New System.Drawing.Size(64, 25)
        Me.rb1H.TabIndex = 36
        Me.rb1H.Text = "~1H"
        Me.rb1H.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.rb1H.UseRound = True
        Me.rb1H.UseVisualStyleBackColor = True
        Me.rb1H.Warning = False
        Me.rb1H.WarningColor = System.Drawing.Color.Red
        '
        'pnlEd
        '
        Me.pnlEd.Controls.Add(Me.lblEd)
        Me.pnlEd.Controls.Add(Me.dtpEd)
        Me.pnlEd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlEd.Location = New System.Drawing.Point(995, 3)
        Me.pnlEd.Name = "pnlEd"
        Me.pnlEd.Size = New System.Drawing.Size(174, 25)
        Me.pnlEd.TabIndex = 35
        '
        'lblEd
        '
        Me.lblEd.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEd.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblEd.FixedHeight = False
        Me.lblEd.FixedWidth = False
        Me.lblEd.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblEd.ForeColor = System.Drawing.Color.White
        Me.lblEd.LineSpacing = 0.0!
        Me.lblEd.Location = New System.Drawing.Point(0, -24)
        Me.lblEd.Name = "lblEd"
        Me.lblEd.Size = New System.Drawing.Size(174, 27)
        Me.lblEd.TabIndex = 30
        Me.lblEd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEd.Visible = False
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.ControlLength = eXperDB.BaseControls.DateTimePicker.enmLength.MiddleLong
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(0, 3)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(170, 22)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 23
        '
        'pnlSt
        '
        Me.pnlSt.Controls.Add(Me.lblSt)
        Me.pnlSt.Controls.Add(Me.dtpSt)
        Me.pnlSt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSt.Location = New System.Drawing.Point(795, 3)
        Me.pnlSt.Name = "pnlSt"
        Me.pnlSt.Size = New System.Drawing.Size(174, 25)
        Me.pnlSt.TabIndex = 34
        '
        'lblSt
        '
        Me.lblSt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSt.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSt.FixedHeight = False
        Me.lblSt.FixedWidth = False
        Me.lblSt.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblSt.ForeColor = System.Drawing.Color.White
        Me.lblSt.LineSpacing = 0.0!
        Me.lblSt.Location = New System.Drawing.Point(0, -24)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(174, 27)
        Me.lblSt.TabIndex = 29
        Me.lblSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSt.Visible = False
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.ControlLength = eXperDB.BaseControls.DateTimePicker.enmLength.MiddleLong
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(0, 3)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(170, 22)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 22
        '
        'cmbInst
        '
        Me.cmbInst.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInst.DisplayMember = "All"
        Me.cmbInst.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInst.FixedWidth = False
        Me.cmbInst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbInst.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.cmbInst.FormattingEnabled = True
        Me.cmbInst.Location = New System.Drawing.Point(83, 7)
        Me.cmbInst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbInst.Name = "cmbInst"
        Me.cmbInst.Necessary = False
        Me.cmbInst.Size = New System.Drawing.Size(114, 20)
        Me.cmbInst.StatusTip = ""
        Me.cmbInst.TabIndex = 20
        Me.cmbInst.ValueText = ""
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblServer.FixedHeight = False
        Me.lblServer.FixedWidth = False
        Me.lblServer.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.LineSpacing = 0.0!
        Me.lblServer.Location = New System.Drawing.Point(3, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(74, 31)
        Me.lblServer.TabIndex = 30
        Me.lblServer.Text = "F033"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 6.438643!)
        Me.lblDuration2.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration2.LineSpacing = 0.0!
        Me.lblDuration2.Location = New System.Drawing.Point(975, 0)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(14, 31)
        Me.lblDuration2.TabIndex = 28
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuration
        '
        Me.lblDuration.BackColor = System.Drawing.Color.Transparent
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblDuration.ForeColor = System.Drawing.Color.White
        Me.lblDuration.LineSpacing = 0.0!
        Me.lblDuration.Location = New System.Drawing.Point(203, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(74, 31)
        Me.lblDuration.TabIndex = 26
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'colDgvLockDB
        '
        Me.colDgvLockDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockDB.DefaultCellStyle = DataGridViewCellStyle14
        Me.colDgvLockDB.DefaultNodeImage = Nothing
        Me.colDgvLockDB.FillWeight = 150.0!
        Me.colDgvLockDB.HeaderText = "F104"
        Me.colDgvLockDB.MinimumWidth = 130
        Me.colDgvLockDB.Name = "colDgvLockDB"
        Me.colDgvLockDB.ReadOnly = True
        Me.colDgvLockDB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingPID
        '
        Me.colDgvLockBlockingPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockingPID.DataPropertyName = "BLOCKING_PID"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingPID.DefaultCellStyle = DataGridViewCellStyle15
        Me.colDgvLockBlockingPID.FillWeight = 102.0!
        Me.colDgvLockBlockingPID.HeaderText = "F197"
        Me.colDgvLockBlockingPID.MinimumWidth = 30
        Me.colDgvLockBlockingPID.Name = "colDgvLockBlockingPID"
        Me.colDgvLockBlockingPID.ReadOnly = True
        Me.colDgvLockBlockingPID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockBlockingPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingUser
        '
        Me.colDgvLockBlockingUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockingUser.DataPropertyName = "BLOCKING_USER"
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingUser.DefaultCellStyle = DataGridViewCellStyle16
        Me.colDgvLockBlockingUser.FillWeight = 130.0!
        Me.colDgvLockBlockingUser.HeaderText = "F134"
        Me.colDgvLockBlockingUser.MinimumWidth = 95
        Me.colDgvLockBlockingUser.Name = "colDgvLockBlockingUser"
        Me.colDgvLockBlockingUser.ReadOnly = True
        Me.colDgvLockBlockingUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingQuery
        '
        Me.colDgvLockBlockingQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvLockBlockingQuery.DataPropertyName = "BLOCKING_QUERY"
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingQuery.DefaultCellStyle = DataGridViewCellStyle17
        Me.colDgvLockBlockingQuery.FillWeight = 200.0!
        Me.colDgvLockBlockingQuery.HeaderText = "F084"
        Me.colDgvLockBlockingQuery.MinimumWidth = 160
        Me.colDgvLockBlockingQuery.Name = "colDgvLockBlockingQuery"
        Me.colDgvLockBlockingQuery.ReadOnly = True
        Me.colDgvLockBlockingQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedPID
        '
        Me.colDgvLockBlockedPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockedPID.DataPropertyName = "BLOCKED_PID"
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedPID.DefaultCellStyle = DataGridViewCellStyle18
        Me.colDgvLockBlockedPID.FillWeight = 102.0!
        Me.colDgvLockBlockedPID.HeaderText = "F195"
        Me.colDgvLockBlockedPID.MinimumWidth = 30
        Me.colDgvLockBlockedPID.Name = "colDgvLockBlockedPID"
        Me.colDgvLockBlockedPID.ReadOnly = True
        Me.colDgvLockBlockedPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedUser
        '
        Me.colDgvLockBlockedUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockedUser.DataPropertyName = "BLOCKED_USER"
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedUser.DefaultCellStyle = DataGridViewCellStyle19
        Me.colDgvLockBlockedUser.FillWeight = 130.0!
        Me.colDgvLockBlockedUser.HeaderText = "F196"
        Me.colDgvLockBlockedUser.MinimumWidth = 95
        Me.colDgvLockBlockedUser.Name = "colDgvLockBlockedUser"
        Me.colDgvLockBlockedUser.ReadOnly = True
        Me.colDgvLockBlockedUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedQuery
        '
        Me.colDgvLockBlockedQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvLockBlockedQuery.DataPropertyName = "BLOCKED_QUERY"
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedQuery.DefaultCellStyle = DataGridViewCellStyle20
        Me.colDgvLockBlockedQuery.FillWeight = 190.0!
        Me.colDgvLockBlockedQuery.HeaderText = "F221"
        Me.colDgvLockBlockedQuery.MinimumWidth = 160
        Me.colDgvLockBlockedQuery.Name = "colDgvLockBlockedQuery"
        Me.colDgvLockBlockedQuery.ReadOnly = True
        Me.colDgvLockBlockedQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockMode
        '
        Me.colDgvLockMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockMode.DataPropertyName = "LOCK_MODE"
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockMode.DefaultCellStyle = DataGridViewCellStyle21
        Me.colDgvLockMode.FillWeight = 130.0!
        Me.colDgvLockMode.HeaderText = "F222"
        Me.colDgvLockMode.MinimumWidth = 100
        Me.colDgvLockMode.Name = "colDgvLockMode"
        Me.colDgvLockMode.ReadOnly = True
        Me.colDgvLockMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockElapse
        '
        Me.colDgvLockElapse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockElapse.DataPropertyName = "BLOCKED_DURATION"
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockElapse.DefaultCellStyle = DataGridViewCellStyle22
        Me.colDgvLockElapse.FillWeight = 120.0!
        Me.colDgvLockElapse.HeaderText = "F135"
        Me.colDgvLockElapse.MinimumWidth = 110
        Me.colDgvLockElapse.Name = "colDgvLockElapse"
        Me.colDgvLockElapse.ReadOnly = True
        Me.colDgvLockElapse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockQueryStart
        '
        Me.colDgvLockQueryStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockQueryStart.DataPropertyName = "QUERY_START"
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockQueryStart.DefaultCellStyle = DataGridViewCellStyle23
        Me.colDgvLockQueryStart.FillWeight = 163.0!
        Me.colDgvLockQueryStart.HeaderText = "F223"
        Me.colDgvLockQueryStart.MinimumWidth = 140
        Me.colDgvLockQueryStart.Name = "colDgvLockQueryStart"
        Me.colDgvLockQueryStart.ReadOnly = True
        Me.colDgvLockQueryStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockXactStart
        '
        Me.colDgvLockXactStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockXactStart.DataPropertyName = "XACT_START"
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockXactStart.DefaultCellStyle = DataGridViewCellStyle24
        Me.colDgvLockXactStart.FillWeight = 163.0!
        Me.colDgvLockXactStart.HeaderText = "F224"
        Me.colDgvLockXactStart.MinimumWidth = 140
        Me.colDgvLockXactStart.Name = "colDgvLockXactStart"
        Me.colDgvLockXactStart.ReadOnly = True
        Me.colDgvLockXactStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockRegDate
        '
        Me.colDgvLockRegDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockRegDate.DataPropertyName = "REG_DATE"
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockRegDate.DefaultCellStyle = DataGridViewCellStyle25
        Me.colDgvLockRegDate.HeaderText = "REG_DATE"
        Me.colDgvLockRegDate.MinimumWidth = 120
        Me.colDgvLockRegDate.Name = "colDgvLockRegDate"
        Me.colDgvLockRegDate.ReadOnly = True
        Me.colDgvLockRegDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockRegDate.Visible = False
        '
        'colDgvLockActvRegSeq
        '
        Me.colDgvLockActvRegSeq.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockActvRegSeq.DataPropertyName = "ACTV_REG_SEQ"
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockActvRegSeq.DefaultCellStyle = DataGridViewCellStyle26
        Me.colDgvLockActvRegSeq.HeaderText = "ACTV_REG_SEQ"
        Me.colDgvLockActvRegSeq.MinimumWidth = 90
        Me.colDgvLockActvRegSeq.Name = "colDgvLockActvRegSeq"
        Me.colDgvLockActvRegSeq.ReadOnly = True
        Me.colDgvLockActvRegSeq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockActvRegSeq.Visible = False
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'frmAutovacuum
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 962)
        Me.Controls.Add(Me.tlpBottom)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MinimumSize = New System.Drawing.Size(1000, 0)
        Me.Name = "frmAutovacuum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autovacuum"
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tlpBottom.ResumeLayout(False)
        Me.tlpChartArea3.ResumeLayout(False)
        CType(Me.chtAutovacuumCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpChartTitle3.ResumeLayout(False)
        Me.tlpChartTitle3.PerformLayout()
        Me.tlpChartArea2.ResumeLayout(False)
        CType(Me.chtAutovacuumWorkers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpChartTitle2.ResumeLayout(False)
        Me.tlpChartTitle2.PerformLayout()
        Me.tlpChartArea.ResumeLayout(False)
        CType(Me.chtAutovacuumWraparound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpChartTitle.ResumeLayout(False)
        Me.tlpChartTitle.PerformLayout()
        Me.tlpInput.ResumeLayout(False)
        Me.pnlEd.ResumeLayout(False)
        Me.pnlSt.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpChartArea As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpInput As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents cmbInst As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents tlpChartTitle As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWaparound As System.Windows.Forms.Label
    Friend WithEvents btnRange As eXperDB.BaseControls.Button
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pnlSt As eXperDB.BaseControls.Panel
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents pnlEd As eXperDB.BaseControls.Panel
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblEd As eXperDB.BaseControls.Label
    Friend WithEvents lblSt As eXperDB.BaseControls.Label
    Friend WithEvents colDgvLockDB As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents colDgvLockBlockingPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockingUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockingQuery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedQuery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockElapse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockQueryStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockXactStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockRegDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockActvRegSeq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rb1D As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb12H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb4H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb2H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb1H As eXperDB.BaseControls.RadioButton
    Friend WithEvents dtpDay As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents DBIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents USERIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QUERYIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlpChartArea3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpChartTitle3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbTop As eXperDB.BaseControls.ComboBox
    Friend WithEvents Label11 As eXperDB.BaseControls.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents tlpChartArea2 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpChartTitle2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblWorker As System.Windows.Forms.Label
    Friend WithEvents chtAutovacuumCount As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chtAutovacuumWorkers As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chtAutovacuumWraparound As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker

End Class
