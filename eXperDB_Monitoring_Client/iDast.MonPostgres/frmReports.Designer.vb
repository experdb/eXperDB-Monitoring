<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    'Inherits frmMonBase
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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim BorderSkin1 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim BorderSkin2 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin3 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderSkin4 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin5 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin6 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin7 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin8 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin9 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.grpRptCpu = New eXperDB.BaseControls.GroupBox()
        Me.chtRptCpu = New eXperDB.Monitoring.ctlChart()
        Me.btnSearch = New eXperDB.BaseControls.Button()
        Me.pnlSearch = New eXperDB.BaseControls.Panel()
        Me.btnPrint = New eXperDB.BaseControls.Button()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.Label1 = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblInstDt = New eXperDB.BaseControls.Label()
        Me.cmbInst = New eXperDB.BaseControls.ComboBox()
        Me.lblInst = New eXperDB.BaseControls.Label()
        Me.grpRptDisk = New eXperDB.BaseControls.GroupBox()
        Me.chtRptDisk = New eXperDB.Monitoring.ctlChart()
        Me.chtRptDiskRate = New eXperDB.Monitoring.ctlChart()
        Me.flpDisk = New eXperDB.BaseControls.FlowLayoutPanel()
        Me.grpRptTimeLine = New eXperDB.BaseControls.GroupBox()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.dgvRptSQL = New eXperDB.BaseControls.DataGridView()
        Me.colDgvRptSqlDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlElapsedMax = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCpuTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlSql = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chtBufferrate = New eXperDB.Monitoring.ctlChart()
        Me.chtBuffer = New eXperDB.Monitoring.ctlChart()
        Me.chtObjectRate = New eXperDB.Monitoring.ctlChart()
        Me.chtObjectTuple = New eXperDB.Monitoring.ctlChart()
        Me.chtLogical = New eXperDB.Monitoring.ctlChart()
        Me.chtSession = New eXperDB.Monitoring.ctlChart()
        Me.flpDB = New eXperDB.BaseControls.FlowLayoutPanel()
        Me.colDgvRptSqlInstID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlStart = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCpuMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlAddr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlMain = New eXperDB.BaseControls.Panel()
        Me.grpRptCpu.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.grpRptDisk.SuspendLayout()
        Me.grpRptTimeLine.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRptSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRptCpu
        '
        Me.grpRptCpu.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptCpu.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptCpu.Controls.Add(Me.chtRptCpu)
        Me.grpRptCpu.Dock = System.Windows.Forms.DockStyle.Top
        Edges1.LeftBottom = 0
        Edges1.RightBottom = 0
        Me.grpRptCpu.EdgeRound = Edges1
        Me.grpRptCpu.FillColor = System.Drawing.Color.Black
        Me.grpRptCpu.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.grpRptCpu.Icon = Nothing
        Me.grpRptCpu.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpRptCpu.LineWidth = 1
        Me.grpRptCpu.Location = New System.Drawing.Point(0, 0)
        Me.grpRptCpu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRptCpu.MinimumSize = New System.Drawing.Size(0, 250)
        Me.grpRptCpu.Name = "grpRptCpu"
        Me.grpRptCpu.Padding = New System.Windows.Forms.Padding(3, 17, 3, 3)
        Me.grpRptCpu.Size = New System.Drawing.Size(1805, 425)
        Me.grpRptCpu.TabIndex = 9
        Me.grpRptCpu.TabStop = False
        Me.grpRptCpu.Text = "F164"
        Me.grpRptCpu.TitleFont = New System.Drawing.Font("Gulim", 17.44833!)
        Me.grpRptCpu.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpRptCpu.UseGraColor = True
        Me.grpRptCpu.UseRound = True
        Me.grpRptCpu.UseTitle = True
        '
        'chtRptCpu
        '
        Me.chtRptCpu.AutoScroll = True
        Me.chtRptCpu.BorderSkin = BorderSkin1
        Me.chtRptCpu.DataSource = Nothing
        Me.chtRptCpu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chtRptCpu.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptCpu.Location = New System.Drawing.Point(3, 34)
        Me.chtRptCpu.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptCpu.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtRptCpu.MenuVisible = True
        Me.chtRptCpu.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtRptCpu.Name = "chtRptCpu"
        Me.chtRptCpu.Size = New System.Drawing.Size(1799, 375)
        Me.chtRptCpu.TabIndex = 15
        Me.chtRptCpu.Title = ""
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Black
        Me.btnSearch.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FixedHeight = False
        Me.btnSearch.FixedWidth = False
        Me.btnSearch.Font = New System.Drawing.Font("Gulim", 13.775!)
        Me.btnSearch.ForeColor = System.Drawing.Color.LightGray
        Me.btnSearch.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(1717, 4)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Radius = 5
        Me.btnSearch.Size = New System.Drawing.Size(102, 26)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "F151"
        Me.btnSearch.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.UseRound = True
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnPrint)
        Me.pnlSearch.Controls.Add(Me.dtpEd)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.Label1)
        Me.pnlSearch.Controls.Add(Me.dtpSt)
        Me.pnlSearch.Controls.Add(Me.lblInstDt)
        Me.pnlSearch.Controls.Add(Me.cmbInst)
        Me.pnlSearch.Controls.Add(Me.lblInst)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.pnlSearch.Location = New System.Drawing.Point(2, 29)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSearch.Size = New System.Drawing.Size(1822, 34)
        Me.pnlSearch.TabIndex = 8
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Black
        Me.btnPrint.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.FixedHeight = False
        Me.btnPrint.FixedWidth = False
        Me.btnPrint.Font = New System.Drawing.Font("Gulim", 13.775!)
        Me.btnPrint.ForeColor = System.Drawing.Color.LightGray
        Me.btnPrint.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrint.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(1615, 4)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(102, 26)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrint.UseRound = True
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpEd.FixedWidth = False
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(609, 4)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(180, 24)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FixedHeight = False
        Me.Label1.FixedWidth = False
        Me.Label1.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(583, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "~"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpSt.FixedWidth = False
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(403, 4)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(180, 24)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 3
        '
        'lblInstDt
        '
        Me.lblInstDt.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblInstDt.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInstDt.FixedHeight = False
        Me.lblInstDt.Font = New System.Drawing.Font("Gulim", 11.02!, System.Drawing.FontStyle.Bold)
        Me.lblInstDt.ForeColor = System.Drawing.Color.LightGray
        Me.lblInstDt.Location = New System.Drawing.Point(253, 4)
        Me.lblInstDt.Name = "lblInstDt"
        Me.lblInstDt.Size = New System.Drawing.Size(150, 26)
        Me.lblInstDt.TabIndex = 2
        Me.lblInstDt.Text = "F147"
        Me.lblInstDt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbInst
        '
        Me.cmbInst.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInst.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbInst.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.cmbInst.FormattingEnabled = True
        Me.cmbInst.Location = New System.Drawing.Point(103, 4)
        Me.cmbInst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbInst.Name = "cmbInst"
        Me.cmbInst.Necessary = False
        Me.cmbInst.Size = New System.Drawing.Size(150, 23)
        Me.cmbInst.StatusTip = ""
        Me.cmbInst.TabIndex = 1
        Me.cmbInst.ValueText = ""
        '
        'lblInst
        '
        Me.lblInst.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInst.FixedHeight = False
        Me.lblInst.Font = New System.Drawing.Font("Gulim", 11.02!, System.Drawing.FontStyle.Bold)
        Me.lblInst.ForeColor = System.Drawing.Color.LightGray
        Me.lblInst.Location = New System.Drawing.Point(3, 4)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(100, 26)
        Me.lblInst.TabIndex = 0
        Me.lblInst.Text = "F146"
        Me.lblInst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpRptDisk
        '
        Me.grpRptDisk.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptDisk.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptDisk.Controls.Add(Me.chtRptDisk)
        Me.grpRptDisk.Controls.Add(Me.chtRptDiskRate)
        Me.grpRptDisk.Controls.Add(Me.flpDisk)
        Me.grpRptDisk.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRptDisk.EdgeRound = Edges2
        Me.grpRptDisk.FillColor = System.Drawing.Color.Black
        Me.grpRptDisk.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.grpRptDisk.Icon = Nothing
        Me.grpRptDisk.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpRptDisk.LineWidth = 1
        Me.grpRptDisk.Location = New System.Drawing.Point(0, 425)
        Me.grpRptDisk.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRptDisk.MinimumSize = New System.Drawing.Size(0, 250)
        Me.grpRptDisk.Name = "grpRptDisk"
        Me.grpRptDisk.Padding = New System.Windows.Forms.Padding(3, 17, 3, 3)
        Me.grpRptDisk.Size = New System.Drawing.Size(1805, 838)
        Me.grpRptDisk.TabIndex = 11
        Me.grpRptDisk.TabStop = False
        Me.grpRptDisk.Text = "F165"
        Me.grpRptDisk.TitleFont = New System.Drawing.Font("Gulim", 17.44833!)
        Me.grpRptDisk.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpRptDisk.UseGraColor = True
        Me.grpRptDisk.UseRound = True
        Me.grpRptDisk.UseTitle = True
        '
        'chtRptDisk
        '
        Me.chtRptDisk.BorderSkin = BorderSkin2
        Me.chtRptDisk.DataSource = Nothing
        Me.chtRptDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chtRptDisk.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptDisk.Location = New System.Drawing.Point(3, 434)
        Me.chtRptDisk.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptDisk.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtRptDisk.MenuVisible = True
        Me.chtRptDisk.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtRptDisk.Name = "chtRptDisk"
        Me.chtRptDisk.Size = New System.Drawing.Size(1799, 375)
        Me.chtRptDisk.TabIndex = 18
        Me.chtRptDisk.Title = ""
        '
        'chtRptDiskRate
        '
        Me.chtRptDiskRate.BorderSkin = BorderSkin3
        Me.chtRptDiskRate.DataSource = Nothing
        Me.chtRptDiskRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtRptDiskRate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptDiskRate.Location = New System.Drawing.Point(3, 59)
        Me.chtRptDiskRate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptDiskRate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtRptDiskRate.MenuVisible = True
        Me.chtRptDiskRate.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtRptDiskRate.Name = "chtRptDiskRate"
        Me.chtRptDiskRate.Size = New System.Drawing.Size(1799, 375)
        Me.chtRptDiskRate.TabIndex = 19
        Me.chtRptDiskRate.Title = ""
        '
        'flpDisk
        '
        Me.flpDisk.AutoSize = True
        Me.flpDisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpDisk.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpDisk.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.flpDisk.Location = New System.Drawing.Point(3, 34)
        Me.flpDisk.Margin = New System.Windows.Forms.Padding(1)
        Me.flpDisk.MinimumSize = New System.Drawing.Size(0, 25)
        Me.flpDisk.Name = "flpDisk"
        Me.flpDisk.Size = New System.Drawing.Size(1799, 25)
        Me.flpDisk.TabIndex = 20
        '
        'grpRptTimeLine
        '
        Me.grpRptTimeLine.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptTimeLine.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptTimeLine.Controls.Add(Me.Panel1)
        Me.grpRptTimeLine.Controls.Add(Me.flpDB)
        Me.grpRptTimeLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRptTimeLine.EdgeRound = Edges3
        Me.grpRptTimeLine.FillColor = System.Drawing.Color.Black
        Me.grpRptTimeLine.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.grpRptTimeLine.Icon = Nothing
        Me.grpRptTimeLine.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpRptTimeLine.LineWidth = 1
        Me.grpRptTimeLine.Location = New System.Drawing.Point(0, 1263)
        Me.grpRptTimeLine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRptTimeLine.MinimumSize = New System.Drawing.Size(0, 250)
        Me.grpRptTimeLine.Name = "grpRptTimeLine"
        Me.grpRptTimeLine.Padding = New System.Windows.Forms.Padding(3, 17, 3, 3)
        Me.grpRptTimeLine.Size = New System.Drawing.Size(1805, 1061)
        Me.grpRptTimeLine.TabIndex = 17
        Me.grpRptTimeLine.TabStop = False
        Me.grpRptTimeLine.Text = "F155"
        Me.grpRptTimeLine.TitleFont = New System.Drawing.Font("Gulim", 17.44833!)
        Me.grpRptTimeLine.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpRptTimeLine.UseGraColor = True
        Me.grpRptTimeLine.UseRound = True
        Me.grpRptTimeLine.UseTitle = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.dgvRptSQL)
        Me.Panel1.Controls.Add(Me.chtBufferrate)
        Me.Panel1.Controls.Add(Me.chtBuffer)
        Me.Panel1.Controls.Add(Me.chtObjectRate)
        Me.Panel1.Controls.Add(Me.chtObjectTuple)
        Me.Panel1.Controls.Add(Me.chtLogical)
        Me.Panel1.Controls.Add(Me.chtSession)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Gulim", 13.49338!)
        Me.Panel1.Location = New System.Drawing.Point(3, 59)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1799, 999)
        Me.Panel1.TabIndex = 31
        '
        'dgvRptSQL
        '
        Me.dgvRptSQL.AllowUserToAddRows = False
        Me.dgvRptSQL.AllowUserToDeleteRows = False
        Me.dgvRptSQL.AllowUserToOrderColumns = True
        Me.dgvRptSQL.AllowUserToResizeRows = False
        Me.dgvRptSQL.BackgroundColor = System.Drawing.Color.Black
        Me.dgvRptSQL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRptSQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 11.02!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRptSQL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRptSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRptSQL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvRptSqlDBNm, Me.colDgvRptSqlElapsedMax, Me.colDgvRptSqlCpuTime, Me.colDgvRptSqlCount, Me.colDgvRptSqlSql})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 11.02!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRptSQL.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRptSQL.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvRptSQL.EnableHeadersVisualStyles = False
        Me.dgvRptSQL.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.dgvRptSQL.GridColor = System.Drawing.Color.DimGray
        Me.dgvRptSQL.Location = New System.Drawing.Point(0, 2250)
        Me.dgvRptSQL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvRptSQL.MultiSelect = False
        Me.dgvRptSQL.Name = "dgvRptSQL"
        Me.dgvRptSQL.RowHeadersVisible = False
        Me.dgvRptSQL.RowTemplate.Height = 23
        Me.dgvRptSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRptSQL.Size = New System.Drawing.Size(1782, 50)
        Me.dgvRptSQL.TabIndex = 31
        Me.dgvRptSQL.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvRptSQL.UseTagValueMatchColor = False
        '
        'colDgvRptSqlDBNm
        '
        Me.colDgvRptSqlDBNm.DataPropertyName = "DB_NAME"
        Me.colDgvRptSqlDBNm.HeaderText = "F172"
        Me.colDgvRptSqlDBNm.Name = "colDgvRptSqlDBNm"
        Me.colDgvRptSqlDBNm.ReadOnly = True
        Me.colDgvRptSqlDBNm.Width = 76
        '
        'colDgvRptSqlElapsedMax
        '
        Me.colDgvRptSqlElapsedMax.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.colDgvRptSqlElapsedMax.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.colDgvRptSqlElapsedMax.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDgvRptSqlElapsedMax.FormatString = "hh\:mm\:ss"
        Me.colDgvRptSqlElapsedMax.HeaderText = "F183"
        Me.colDgvRptSqlElapsedMax.Name = "colDgvRptSqlElapsedMax"
        Me.colDgvRptSqlElapsedMax.ReadOnly = True
        Me.colDgvRptSqlElapsedMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDgvRptSqlElapsedMax.Width = 76
        '
        'colDgvRptSqlCpuTime
        '
        Me.colDgvRptSqlCpuTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.colDgvRptSqlCpuTime.DataPropertyName = "OCCUPIED_TIME"
        Me.colDgvRptSqlCpuTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDgvRptSqlCpuTime.FormatString = "hh\:mm\:ss\.ff"
        Me.colDgvRptSqlCpuTime.HeaderText = "F231"
        Me.colDgvRptSqlCpuTime.Name = "colDgvRptSqlCpuTime"
        Me.colDgvRptSqlCpuTime.ReadOnly = True
        Me.colDgvRptSqlCpuTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDgvRptSqlCpuTime.Visible = False
        Me.colDgvRptSqlCpuTime.Width = 76
        '
        'colDgvRptSqlCount
        '
        Me.colDgvRptSqlCount.DataPropertyName = "SQL_COUNT"
        Me.colDgvRptSqlCount.HeaderText = "F232"
        Me.colDgvRptSqlCount.Name = "colDgvRptSqlCount"
        Me.colDgvRptSqlCount.ReadOnly = True
        Me.colDgvRptSqlCount.Width = 76
        '
        'colDgvRptSqlSql
        '
        Me.colDgvRptSqlSql.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvRptSqlSql.DataPropertyName = "SQL"
        Me.colDgvRptSqlSql.HeaderText = "F185"
        Me.colDgvRptSqlSql.Name = "colDgvRptSqlSql"
        Me.colDgvRptSqlSql.ReadOnly = True
        '
        'chtBufferrate
        '
        Me.chtBufferrate.BorderSkin = BorderSkin4
        Me.chtBufferrate.DataSource = Nothing
        Me.chtBufferrate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtBufferrate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtBufferrate.Location = New System.Drawing.Point(0, 1875)
        Me.chtBufferrate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtBufferrate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtBufferrate.MenuVisible = True
        Me.chtBufferrate.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtBufferrate.Name = "chtBufferrate"
        Me.chtBufferrate.Size = New System.Drawing.Size(1782, 375)
        Me.chtBufferrate.TabIndex = 30
        Me.chtBufferrate.Title = ""
        '
        'chtBuffer
        '
        Me.chtBuffer.BorderSkin = BorderSkin5
        Me.chtBuffer.DataSource = Nothing
        Me.chtBuffer.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtBuffer.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtBuffer.Location = New System.Drawing.Point(0, 1500)
        Me.chtBuffer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtBuffer.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtBuffer.MenuVisible = True
        Me.chtBuffer.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtBuffer.Name = "chtBuffer"
        Me.chtBuffer.Size = New System.Drawing.Size(1782, 375)
        Me.chtBuffer.TabIndex = 29
        Me.chtBuffer.Title = ""
        '
        'chtObjectRate
        '
        Me.chtObjectRate.BorderSkin = BorderSkin6
        Me.chtObjectRate.DataSource = Nothing
        Me.chtObjectRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtObjectRate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtObjectRate.Location = New System.Drawing.Point(0, 1125)
        Me.chtObjectRate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtObjectRate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectRate.MenuVisible = True
        Me.chtObjectRate.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectRate.Name = "chtObjectRate"
        Me.chtObjectRate.Size = New System.Drawing.Size(1782, 375)
        Me.chtObjectRate.TabIndex = 28
        Me.chtObjectRate.Title = ""
        '
        'chtObjectTuple
        '
        Me.chtObjectTuple.BorderSkin = BorderSkin7
        Me.chtObjectTuple.DataSource = Nothing
        Me.chtObjectTuple.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtObjectTuple.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtObjectTuple.Location = New System.Drawing.Point(0, 750)
        Me.chtObjectTuple.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtObjectTuple.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectTuple.MenuVisible = True
        Me.chtObjectTuple.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectTuple.Name = "chtObjectTuple"
        Me.chtObjectTuple.Size = New System.Drawing.Size(1782, 375)
        Me.chtObjectTuple.TabIndex = 27
        Me.chtObjectTuple.Title = ""
        '
        'chtLogical
        '
        Me.chtLogical.BorderSkin = BorderSkin8
        Me.chtLogical.DataSource = Nothing
        Me.chtLogical.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtLogical.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtLogical.Location = New System.Drawing.Point(0, 375)
        Me.chtLogical.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtLogical.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtLogical.MenuVisible = True
        Me.chtLogical.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtLogical.Name = "chtLogical"
        Me.chtLogical.Size = New System.Drawing.Size(1782, 375)
        Me.chtLogical.TabIndex = 25
        Me.chtLogical.Title = ""
        '
        'chtSession
        '
        Me.chtSession.BorderSkin = BorderSkin9
        Me.chtSession.DataSource = Nothing
        Me.chtSession.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtSession.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtSession.Location = New System.Drawing.Point(0, 0)
        Me.chtSession.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtSession.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtSession.MenuVisible = True
        Me.chtSession.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtSession.Name = "chtSession"
        Me.chtSession.Size = New System.Drawing.Size(1782, 375)
        Me.chtSession.TabIndex = 20
        Me.chtSession.Title = ""
        '
        'flpDB
        '
        Me.flpDB.AutoSize = True
        Me.flpDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpDB.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.flpDB.Location = New System.Drawing.Point(3, 34)
        Me.flpDB.Margin = New System.Windows.Forms.Padding(1)
        Me.flpDB.MinimumSize = New System.Drawing.Size(0, 25)
        Me.flpDB.Name = "flpDB"
        Me.flpDB.Size = New System.Drawing.Size(1799, 25)
        Me.flpDB.TabIndex = 21
        '
        'colDgvRptSqlInstID
        '
        Me.colDgvRptSqlInstID.DataPropertyName = "INSTANCE_ID"
        Me.colDgvRptSqlInstID.HeaderText = "ID"
        Me.colDgvRptSqlInstID.Name = "colDgvRptSqlInstID"
        Me.colDgvRptSqlInstID.ReadOnly = True
        Me.colDgvRptSqlInstID.Visible = False
        '
        'colDgvRptSqlStart
        '
        Me.colDgvRptSqlStart.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.colDgvRptSqlStart.DataPropertyName = "QUERY_START"
        Me.colDgvRptSqlStart.FormatString = "hh\:mm\:ss"
        Me.colDgvRptSqlStart.HeaderText = "F050"
        Me.colDgvRptSqlStart.Name = "colDgvRptSqlStart"
        Me.colDgvRptSqlStart.ReadOnly = True
        '
        'colDgvRptSqlCpuMax
        '
        Me.colDgvRptSqlCpuMax.DataPropertyName = "MAX_CPU_USAGE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "P2"
        Me.colDgvRptSqlCpuMax.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDgvRptSqlCpuMax.HeaderText = "F181"
        Me.colDgvRptSqlCpuMax.Name = "colDgvRptSqlCpuMax"
        Me.colDgvRptSqlCpuMax.ReadOnly = True
        '
        'colDgvRptSqlAddr
        '
        Me.colDgvRptSqlAddr.DataPropertyName = "CLIENT_ADDR"
        Me.colDgvRptSqlAddr.HeaderText = "F182"
        Me.colDgvRptSqlAddr.Name = "colDgvRptSqlAddr"
        Me.colDgvRptSqlAddr.ReadOnly = True
        '
        'colDgvRptSqlUser
        '
        Me.colDgvRptSqlUser.DataPropertyName = "USER_NAME"
        Me.colDgvRptSqlUser.HeaderText = "F184"
        Me.colDgvRptSqlUser.Name = "colDgvRptSqlUser"
        Me.colDgvRptSqlUser.ReadOnly = True
        Me.colDgvRptSqlUser.Visible = False
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.grpRptTimeLine)
        Me.pnlMain.Controls.Add(Me.grpRptDisk)
        Me.pnlMain.Controls.Add(Me.grpRptCpu)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.pnlMain.Location = New System.Drawing.Point(2, 63)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1822, 1033)
        Me.pnlMain.TabIndex = 19
        '
        'frmReports
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        'Me.BaseHeight = 1100
        Me.ClientSize = New System.Drawing.Size(1826, 1098)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmReports"
        Me.Controls.SetChildIndex(Me.pnlSearch, 0)
        Me.Controls.SetChildIndex(Me.pnlMain, 0)
        Me.grpRptCpu.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.grpRptDisk.ResumeLayout(False)
        Me.grpRptDisk.PerformLayout()
        Me.grpRptTimeLine.ResumeLayout(False)
        Me.grpRptTimeLine.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvRptSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents Label1 As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblInstDt As eXperDB.BaseControls.Label
    Friend WithEvents cmbInst As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblInst As eXperDB.BaseControls.Label
    Friend WithEvents grpRptCpu As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnSearch As eXperDB.BaseControls.Button
    Friend WithEvents grpRptDisk As eXperDB.BaseControls.GroupBox
    Friend WithEvents chtRptCpu As eXperDB.Monitoring.ctlChart
    Friend WithEvents grpRptTimeLine As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnPrint As eXperDB.BaseControls.Button
    Friend WithEvents pnlSearch As eXperDB.BaseControls.Panel
    Friend WithEvents flpDisk As eXperDB.BaseControls.FlowLayoutPanel
    Friend WithEvents flpDB As eXperDB.BaseControls.FlowLayoutPanel
    Friend WithEvents pnlMain As eXperDB.BaseControls.Panel
    Friend WithEvents chtRptDisk As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtRptDiskRate As eXperDB.Monitoring.ctlChart
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents dgvRptSQL As eXperDB.BaseControls.DataGridView
    Friend WithEvents colDgvRptSqlInstID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlStart As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlElapsedMax As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlCpuMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlCpuTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlAddr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlSql As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chtBufferrate As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtBuffer As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtObjectRate As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtObjectTuple As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtLogical As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtSession As eXperDB.Monitoring.ctlChart

End Class
