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
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderSkin1 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin2 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin3 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin4 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin5 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin6 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin7 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin8 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin9 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.grpRptCpu = New eXperDB.BaseControls.GroupBox()
        Me.pnlSystem = New eXperDB.BaseControls.Panel()
        Me.flpDisk = New eXperDB.BaseControls.FlowLayoutPanel()
        Me.btnSearch = New eXperDB.BaseControls.Button()
        Me.pnlSearch = New eXperDB.BaseControls.Panel()
        Me.tlpDuration = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.Label1 = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.tlpButton = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dtpDay = New eXperDB.BaseControls.DateTimePicker()
        Me.lblInstDt = New eXperDB.BaseControls.Label()
        Me.cmbInst = New eXperDB.BaseControls.ComboBox()
        Me.lblInst = New eXperDB.BaseControls.Label()
        Me.rb1D = New eXperDB.BaseControls.RadioButton()
        Me.rb12H = New eXperDB.BaseControls.RadioButton()
        Me.rb4H = New eXperDB.BaseControls.RadioButton()
        Me.rb2H = New eXperDB.BaseControls.RadioButton()
        Me.rb1H = New eXperDB.BaseControls.RadioButton()
        Me.btnPrint = New eXperDB.BaseControls.Button()
        Me.grpRptTimeLine = New eXperDB.BaseControls.GroupBox()
        Me.pnlTimeline = New eXperDB.BaseControls.Panel()
        Me.flpDB = New eXperDB.BaseControls.FlowLayoutPanel()
        Me.colDgvRptSqlInstID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlStart = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCpuMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlAddr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer1 = New eXperDB.BaseControls.SplitContainer()
        Me.pnlMain = New eXperDB.BaseControls.Panel()
        Me.SplitContainer2 = New eXperDB.BaseControls.SplitContainer()
        Me.dgvRptSQL = New eXperDB.BaseControls.DataGridView()
        Me.colDgvRptSqlDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlElapsedMax = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCpuTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.colDgvRptSqlCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvRptSqlSql = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chtRptDiskRate = New eXperDB.Monitoring.ctlChart()
        Me.chtRptDisk = New eXperDB.Monitoring.ctlChart()
        Me.chtRptCpu = New eXperDB.Monitoring.ctlChart()
        Me.chtBufferrate = New eXperDB.Monitoring.ctlChart()
        Me.chtBuffer = New eXperDB.Monitoring.ctlChart()
        Me.chtObjectRate = New eXperDB.Monitoring.ctlChart()
        Me.chtObjectTuple = New eXperDB.Monitoring.ctlChart()
        Me.chtLogical = New eXperDB.Monitoring.ctlChart()
        Me.chtSession = New eXperDB.Monitoring.ctlChart()
        Me.grpRptSQL = New eXperDB.BaseControls.GroupBox()
        Me.grpRptCpu.SuspendLayout()
        Me.pnlSystem.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.tlpDuration.SuspendLayout()
        Me.tlpButton.SuspendLayout()
        Me.grpRptTimeLine.SuspendLayout()
        Me.pnlTimeline.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgvRptSQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRptSQL.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRptCpu
        '
        Me.grpRptCpu.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptCpu.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptCpu.AutoSize = True
        Me.grpRptCpu.Controls.Add(Me.pnlSystem)
        Me.grpRptCpu.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.LeftTop = 0
        Edges1.RightBottom = 0
        Edges1.RightTop = 0
        Me.grpRptCpu.EdgeRound = Edges1
        Me.grpRptCpu.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptCpu.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptCpu.Icon = Nothing
        Me.grpRptCpu.LineColor = System.Drawing.Color.Gainsboro
        Me.grpRptCpu.LineWidth = 1
        Me.grpRptCpu.Location = New System.Drawing.Point(0, 0)
        Me.grpRptCpu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRptCpu.MinimumSize = New System.Drawing.Size(0, 250)
        Me.grpRptCpu.Name = "grpRptCpu"
        Me.grpRptCpu.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpRptCpu.Size = New System.Drawing.Size(1826, 371)
        Me.grpRptCpu.TabIndex = 9
        Me.grpRptCpu.TabStop = False
        Me.grpRptCpu.Text = "System"
        Me.grpRptCpu.TitleFont = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptCpu.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptCpu.UseGraColor = False
        Me.grpRptCpu.UseRound = True
        Me.grpRptCpu.UseTitle = True
        '
        'pnlSystem
        '
        Me.pnlSystem.AutoScroll = True
        Me.pnlSystem.Controls.Add(Me.chtRptDiskRate)
        Me.pnlSystem.Controls.Add(Me.chtRptDisk)
        Me.pnlSystem.Controls.Add(Me.flpDisk)
        Me.pnlSystem.Controls.Add(Me.chtRptCpu)
        Me.pnlSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSystem.Location = New System.Drawing.Point(3, 28)
        Me.pnlSystem.Name = "pnlSystem"
        Me.pnlSystem.Size = New System.Drawing.Size(1820, 340)
        Me.pnlSystem.TabIndex = 24
        '
        'flpDisk
        '
        Me.flpDisk.AutoSize = True
        Me.flpDisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpDisk.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpDisk.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.flpDisk.Location = New System.Drawing.Point(0, 320)
        Me.flpDisk.Margin = New System.Windows.Forms.Padding(1)
        Me.flpDisk.MinimumSize = New System.Drawing.Size(0, 25)
        Me.flpDisk.Name = "flpDisk"
        Me.flpDisk.Size = New System.Drawing.Size(1803, 25)
        Me.flpDisk.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSearch.FixedHeight = False
        Me.btnSearch.FixedWidth = False
        Me.btnSearch.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(1721, 4)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Radius = 5
        Me.btnSearch.Size = New System.Drawing.Size(102, 31)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "F151"
        Me.btnSearch.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.UseRound = True
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.tlpDuration)
        Me.pnlSearch.Controls.Add(Me.tlpButton)
        Me.pnlSearch.Controls.Add(Me.btnPrint)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.pnlSearch.Location = New System.Drawing.Point(0, 0)
        Me.pnlSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSearch.Size = New System.Drawing.Size(1826, 39)
        Me.pnlSearch.TabIndex = 8
        '
        'tlpDuration
        '
        Me.tlpDuration.ColumnCount = 4
        Me.tlpDuration.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDuration.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpDuration.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpDuration.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDuration.Controls.Add(Me.dtpEd, 2, 0)
        Me.tlpDuration.Controls.Add(Me.Label1, 1, 0)
        Me.tlpDuration.Controls.Add(Me.dtpSt, 0, 0)
        Me.tlpDuration.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpDuration.Location = New System.Drawing.Point(1265, 4)
        Me.tlpDuration.Name = "tlpDuration"
        Me.tlpDuration.RowCount = 1
        Me.tlpDuration.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDuration.Size = New System.Drawing.Size(354, 31)
        Me.tlpDuration.TabIndex = 17
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpEd.FixedWidth = False
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(185, 4)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(146, 22)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.FixedHeight = False
        Me.Label1.FixedWidth = False
        Me.Label1.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(155, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 31)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "~"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpSt.FixedWidth = False
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(3, 4)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(145, 22)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 32
        '
        'tlpButton
        '
        Me.tlpButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpButton.ColumnCount = 13
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.637519!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.32034!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.637519!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.849288!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.849288!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.849288!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.849288!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.849288!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.6267!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.527948!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.56973!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.86407!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.56973!))
        Me.tlpButton.Controls.Add(Me.dtpDay, 8, 0)
        Me.tlpButton.Controls.Add(Me.lblInstDt, 2, 0)
        Me.tlpButton.Controls.Add(Me.cmbInst, 1, 0)
        Me.tlpButton.Controls.Add(Me.lblInst, 0, 0)
        Me.tlpButton.Controls.Add(Me.rb1D, 7, 0)
        Me.tlpButton.Controls.Add(Me.rb12H, 6, 0)
        Me.tlpButton.Controls.Add(Me.rb4H, 5, 0)
        Me.tlpButton.Controls.Add(Me.rb2H, 4, 0)
        Me.tlpButton.Controls.Add(Me.rb1H, 3, 0)
        Me.tlpButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpButton.Location = New System.Drawing.Point(3, 4)
        Me.tlpButton.Name = "tlpButton"
        Me.tlpButton.RowCount = 1
        Me.tlpButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Size = New System.Drawing.Size(1169, 31)
        Me.tlpButton.TabIndex = 16
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
        Me.dtpDay.Location = New System.Drawing.Point(688, 4)
        Me.dtpDay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpDay.MinDate = New Date(2018, 1, 1, 0, 0, 0, 0)
        Me.dtpDay.Name = "dtpDay"
        Me.dtpDay.Necessary = False
        Me.dtpDay.ShowCheckBox = True
        Me.dtpDay.Size = New System.Drawing.Size(129, 22)
        Me.dtpDay.StatusTip = ""
        Me.dtpDay.TabIndex = 35
        Me.dtpDay.Value = New Date(2018, 9, 14, 0, 0, 0, 0)
        '
        'lblInstDt
        '
        Me.lblInstDt.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblInstDt.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInstDt.FixedHeight = False
        Me.lblInstDt.FixedWidth = False
        Me.lblInstDt.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Bold)
        Me.lblInstDt.ForeColor = System.Drawing.Color.LightGray
        Me.lblInstDt.Location = New System.Drawing.Point(259, 0)
        Me.lblInstDt.Name = "lblInstDt"
        Me.lblInstDt.Size = New System.Drawing.Size(69, 31)
        Me.lblInstDt.TabIndex = 31
        Me.lblInstDt.Text = "F147"
        Me.lblInstDt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbInst
        '
        Me.cmbInst.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInst.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbInst.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.cmbInst.FormattingEnabled = True
        Me.cmbInst.Location = New System.Drawing.Point(92, 4)
        Me.cmbInst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbInst.Name = "cmbInst"
        Me.cmbInst.Necessary = False
        Me.cmbInst.Size = New System.Drawing.Size(150, 23)
        Me.cmbInst.StatusTip = ""
        Me.cmbInst.TabIndex = 30
        Me.cmbInst.ValueText = ""
        '
        'lblInst
        '
        Me.lblInst.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblInst.FixedHeight = False
        Me.lblInst.FixedWidth = False
        Me.lblInst.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Bold)
        Me.lblInst.ForeColor = System.Drawing.Color.LightGray
        Me.lblInst.Location = New System.Drawing.Point(3, 0)
        Me.lblInst.Name = "lblInst"
        Me.lblInst.Size = New System.Drawing.Size(69, 31)
        Me.lblInst.TabIndex = 29
        Me.lblInst.Text = "F146"
        Me.lblInst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rb1D
        '
        Me.rb1D.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb1D.CheckFillColor = System.Drawing.Color.Gray
        Me.rb1D.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb1D.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb1D.ForeColor = System.Drawing.Color.White
        Me.rb1D.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rb1D.Location = New System.Drawing.Point(620, 3)
        Me.rb1D.Name = "rb1D"
        Me.rb1D.Radius = 8
        Me.rb1D.Size = New System.Drawing.Size(62, 25)
        Me.rb1D.TabIndex = 27
        Me.rb1D.Text = "~1D"
        Me.rb1D.UnCheckFillColor = System.Drawing.Color.Black
        Me.rb1D.UseRound = True
        Me.rb1D.UseVisualStyleBackColor = True
        Me.rb1D.Warning = False
        Me.rb1D.WarningColor = System.Drawing.Color.Red
        '
        'rb12H
        '
        Me.rb12H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb12H.CheckFillColor = System.Drawing.Color.Gray
        Me.rb12H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb12H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb12H.ForeColor = System.Drawing.Color.White
        Me.rb12H.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rb12H.Location = New System.Drawing.Point(552, 3)
        Me.rb12H.Name = "rb12H"
        Me.rb12H.Radius = 8
        Me.rb12H.Size = New System.Drawing.Size(62, 25)
        Me.rb12H.TabIndex = 26
        Me.rb12H.Text = "~12H"
        Me.rb12H.UnCheckFillColor = System.Drawing.Color.Black
        Me.rb12H.UseRound = True
        Me.rb12H.UseVisualStyleBackColor = True
        Me.rb12H.Warning = False
        Me.rb12H.WarningColor = System.Drawing.Color.Red
        '
        'rb4H
        '
        Me.rb4H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb4H.CheckFillColor = System.Drawing.Color.Gray
        Me.rb4H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb4H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb4H.ForeColor = System.Drawing.Color.White
        Me.rb4H.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rb4H.Location = New System.Drawing.Point(484, 3)
        Me.rb4H.Name = "rb4H"
        Me.rb4H.Radius = 8
        Me.rb4H.Size = New System.Drawing.Size(62, 25)
        Me.rb4H.TabIndex = 25
        Me.rb4H.Text = "~4H"
        Me.rb4H.UnCheckFillColor = System.Drawing.Color.Black
        Me.rb4H.UseRound = True
        Me.rb4H.UseVisualStyleBackColor = True
        Me.rb4H.Warning = False
        Me.rb4H.WarningColor = System.Drawing.Color.Red
        '
        'rb2H
        '
        Me.rb2H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb2H.CheckFillColor = System.Drawing.Color.Gray
        Me.rb2H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb2H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb2H.ForeColor = System.Drawing.Color.White
        Me.rb2H.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rb2H.Location = New System.Drawing.Point(416, 3)
        Me.rb2H.Name = "rb2H"
        Me.rb2H.Radius = 8
        Me.rb2H.Size = New System.Drawing.Size(62, 25)
        Me.rb2H.TabIndex = 24
        Me.rb2H.Text = "~2H"
        Me.rb2H.UnCheckFillColor = System.Drawing.Color.Black
        Me.rb2H.UseRound = True
        Me.rb2H.UseVisualStyleBackColor = True
        Me.rb2H.Warning = False
        Me.rb2H.WarningColor = System.Drawing.Color.Red
        '
        'rb1H
        '
        Me.rb1H.Appearance = System.Windows.Forms.Appearance.Button
        Me.rb1H.CheckFillColor = System.Drawing.Color.Gray
        Me.rb1H.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rb1H.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.rb1H.ForeColor = System.Drawing.Color.White
        Me.rb1H.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.rb1H.Location = New System.Drawing.Point(348, 3)
        Me.rb1H.Name = "rb1H"
        Me.rb1H.Radius = 8
        Me.rb1H.Size = New System.Drawing.Size(62, 25)
        Me.rb1H.TabIndex = 23
        Me.rb1H.Text = "~1H"
        Me.rb1H.UnCheckFillColor = System.Drawing.Color.Black
        Me.rb1H.UseRound = True
        Me.rb1H.UseVisualStyleBackColor = True
        Me.rb1H.Warning = False
        Me.rb1H.WarningColor = System.Drawing.Color.Red
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrint.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnPrint.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPrint.FixedHeight = False
        Me.btnPrint.FixedWidth = False
        Me.btnPrint.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPrint.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(1619, 4)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Radius = 5
        Me.btnPrint.Size = New System.Drawing.Size(102, 31)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPrint.UseRound = True
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'grpRptTimeLine
        '
        Me.grpRptTimeLine.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptTimeLine.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptTimeLine.AutoSize = True
        Me.grpRptTimeLine.Controls.Add(Me.pnlTimeline)
        Me.grpRptTimeLine.Controls.Add(Me.flpDB)
        Me.grpRptTimeLine.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.LeftTop = 0
        Edges2.RightBottom = 0
        Edges2.RightTop = 0
        Me.grpRptTimeLine.EdgeRound = Edges2
        Me.grpRptTimeLine.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptTimeLine.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptTimeLine.Icon = Nothing
        Me.grpRptTimeLine.LineColor = System.Drawing.Color.Gainsboro
        Me.grpRptTimeLine.LineWidth = 1
        Me.grpRptTimeLine.Location = New System.Drawing.Point(0, 0)
        Me.grpRptTimeLine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpRptTimeLine.MinimumSize = New System.Drawing.Size(0, 250)
        Me.grpRptTimeLine.Name = "grpRptTimeLine"
        Me.grpRptTimeLine.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpRptTimeLine.Size = New System.Drawing.Size(1826, 401)
        Me.grpRptTimeLine.TabIndex = 17
        Me.grpRptTimeLine.TabStop = False
        Me.grpRptTimeLine.Text = "eXperDB"
        Me.grpRptTimeLine.TitleFont = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptTimeLine.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptTimeLine.UseGraColor = False
        Me.grpRptTimeLine.UseRound = True
        Me.grpRptTimeLine.UseTitle = True
        '
        'pnlTimeline
        '
        Me.pnlTimeline.AutoScroll = True
        Me.pnlTimeline.Controls.Add(Me.chtBufferrate)
        Me.pnlTimeline.Controls.Add(Me.chtBuffer)
        Me.pnlTimeline.Controls.Add(Me.chtObjectRate)
        Me.pnlTimeline.Controls.Add(Me.chtObjectTuple)
        Me.pnlTimeline.Controls.Add(Me.chtLogical)
        Me.pnlTimeline.Controls.Add(Me.chtSession)
        Me.pnlTimeline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTimeline.Font = New System.Drawing.Font("Gulim", 13.49338!)
        Me.pnlTimeline.Location = New System.Drawing.Point(3, 53)
        Me.pnlTimeline.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlTimeline.Name = "pnlTimeline"
        Me.pnlTimeline.Size = New System.Drawing.Size(1820, 345)
        Me.pnlTimeline.TabIndex = 31
        '
        'flpDB
        '
        Me.flpDB.AutoSize = True
        Me.flpDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpDB.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.flpDB.Location = New System.Drawing.Point(3, 28)
        Me.flpDB.Margin = New System.Windows.Forms.Padding(1)
        Me.flpDB.MinimumSize = New System.Drawing.Size(0, 25)
        Me.flpDB.Name = "flpDB"
        Me.flpDB.Size = New System.Drawing.Size(1820, 25)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "P2"
        Me.colDgvRptSqlCpuMax.DefaultCellStyle = DataGridViewCellStyle1
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
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlMain)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpRptSQL)
        Me.SplitContainer1.Size = New System.Drawing.Size(1826, 1015)
        Me.SplitContainer1.SplitterDistance = 776
        Me.SplitContainer1.TabIndex = 18
        '
        'pnlMain
        '
        Me.pnlMain.AutoScroll = True
        Me.pnlMain.Controls.Add(Me.SplitContainer2)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1826, 776)
        Me.pnlMain.TabIndex = 18
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.grpRptCpu)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.grpRptTimeLine)
        Me.SplitContainer2.Size = New System.Drawing.Size(1826, 776)
        Me.SplitContainer2.SplitterDistance = 371
        Me.SplitContainer2.TabIndex = 18
        '
        'dgvRptSQL
        '
        Me.dgvRptSQL.AllowUserToAddRows = False
        Me.dgvRptSQL.AllowUserToDeleteRows = False
        Me.dgvRptSQL.AllowUserToOrderColumns = True
        Me.dgvRptSQL.AllowUserToResizeColumns = False
        Me.dgvRptSQL.AllowUserToResizeRows = False
        Me.dgvRptSQL.BackgroundColor = System.Drawing.Color.Black
        Me.dgvRptSQL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRptSQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 11.02!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRptSQL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRptSQL.ColumnHeadersHeight = 30
        Me.dgvRptSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRptSQL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvRptSqlDBNm, Me.colDgvRptSqlElapsedMax, Me.colDgvRptSqlCpuTime, Me.colDgvRptSqlCount, Me.colDgvRptSqlSql})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 11.02!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRptSQL.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRptSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRptSQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvRptSQL.EnableHeadersVisualStyles = False
        Me.dgvRptSQL.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.dgvRptSQL.GridColor = System.Drawing.Color.Gray
        Me.dgvRptSQL.Location = New System.Drawing.Point(3, 28)
        Me.dgvRptSQL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvRptSQL.MultiSelect = False
        Me.dgvRptSQL.Name = "dgvRptSQL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRptSQL.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRptSQL.RowHeadersVisible = False
        Me.dgvRptSQL.RowTemplate.Height = 23
        Me.dgvRptSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRptSQL.Size = New System.Drawing.Size(1820, 204)
        Me.dgvRptSQL.TabIndex = 32
        Me.dgvRptSQL.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvRptSQL.UseTagValueMatchColor = False
        '
        'colDgvRptSqlDBNm
        '
        Me.colDgvRptSqlDBNm.DataPropertyName = "DB_NAME"
        Me.colDgvRptSqlDBNm.HeaderText = "F172"
        Me.colDgvRptSqlDBNm.Name = "colDgvRptSqlDBNm"
        Me.colDgvRptSqlDBNm.ReadOnly = True
        '
        'colDgvRptSqlElapsedMax
        '
        Me.colDgvRptSqlElapsedMax.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.colDgvRptSqlElapsedMax.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.colDgvRptSqlElapsedMax.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDgvRptSqlElapsedMax.FormatString = "hh\:mm\:ss"
        Me.colDgvRptSqlElapsedMax.HeaderText = "F183"
        Me.colDgvRptSqlElapsedMax.Name = "colDgvRptSqlElapsedMax"
        Me.colDgvRptSqlElapsedMax.ReadOnly = True
        Me.colDgvRptSqlElapsedMax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colDgvRptSqlElapsedMax.Width = 190
        '
        'colDgvRptSqlCpuTime
        '
        Me.colDgvRptSqlCpuTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.colDgvRptSqlCpuTime.DataPropertyName = "OCCUPIED_TIME"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.colDgvRptSqlCpuTime.DefaultCellStyle = DataGridViewCellStyle4
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
        Me.colDgvRptSqlCount.Width = 190
        '
        'colDgvRptSqlSql
        '
        Me.colDgvRptSqlSql.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvRptSqlSql.DataPropertyName = "SQL"
        Me.colDgvRptSqlSql.HeaderText = "F185"
        Me.colDgvRptSqlSql.Name = "colDgvRptSqlSql"
        Me.colDgvRptSqlSql.ReadOnly = True
        '
        'chtRptDiskRate
        '
        Me.chtRptDiskRate.BorderSkin = BorderSkin1
        Me.chtRptDiskRate.DataSource = Nothing
        Me.chtRptDiskRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtRptDiskRate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptDiskRate.Location = New System.Drawing.Point(0, 665)
        Me.chtRptDiskRate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptDiskRate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtRptDiskRate.MenuVisible = True
        Me.chtRptDiskRate.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtRptDiskRate.Name = "chtRptDiskRate"
        Me.chtRptDiskRate.Size = New System.Drawing.Size(1803, 320)
        Me.chtRptDiskRate.TabIndex = 23
        Me.chtRptDiskRate.Title = ""
        '
        'chtRptDisk
        '
        Me.chtRptDisk.BorderSkin = BorderSkin2
        Me.chtRptDisk.DataSource = Nothing
        Me.chtRptDisk.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtRptDisk.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptDisk.Location = New System.Drawing.Point(0, 345)
        Me.chtRptDisk.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptDisk.MaximumSize = New System.Drawing.Size(0, 350)
        Me.chtRptDisk.MenuVisible = True
        Me.chtRptDisk.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtRptDisk.Name = "chtRptDisk"
        Me.chtRptDisk.Size = New System.Drawing.Size(1803, 320)
        Me.chtRptDisk.TabIndex = 22
        Me.chtRptDisk.Title = ""
        '
        'chtRptCpu
        '
        Me.chtRptCpu.AutoScroll = True
        Me.chtRptCpu.BorderSkin = BorderSkin3
        Me.chtRptCpu.DataSource = Nothing
        Me.chtRptCpu.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtRptCpu.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtRptCpu.Location = New System.Drawing.Point(0, 0)
        Me.chtRptCpu.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtRptCpu.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtRptCpu.MenuVisible = True
        Me.chtRptCpu.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtRptCpu.Name = "chtRptCpu"
        Me.chtRptCpu.Size = New System.Drawing.Size(1803, 320)
        Me.chtRptCpu.TabIndex = 15
        Me.chtRptCpu.Title = ""
        '
        'chtBufferrate
        '
        Me.chtBufferrate.BorderSkin = BorderSkin4
        Me.chtBufferrate.DataSource = Nothing
        Me.chtBufferrate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtBufferrate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtBufferrate.Location = New System.Drawing.Point(0, 1655)
        Me.chtBufferrate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtBufferrate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtBufferrate.MenuVisible = True
        Me.chtBufferrate.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtBufferrate.Name = "chtBufferrate"
        Me.chtBufferrate.Size = New System.Drawing.Size(1803, 375)
        Me.chtBufferrate.TabIndex = 30
        Me.chtBufferrate.Title = ""
        '
        'chtBuffer
        '
        Me.chtBuffer.BorderSkin = BorderSkin5
        Me.chtBuffer.DataSource = Nothing
        Me.chtBuffer.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtBuffer.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtBuffer.Location = New System.Drawing.Point(0, 1335)
        Me.chtBuffer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtBuffer.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtBuffer.MenuVisible = True
        Me.chtBuffer.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtBuffer.Name = "chtBuffer"
        Me.chtBuffer.Size = New System.Drawing.Size(1803, 320)
        Me.chtBuffer.TabIndex = 29
        Me.chtBuffer.Title = ""
        '
        'chtObjectRate
        '
        Me.chtObjectRate.BorderSkin = BorderSkin6
        Me.chtObjectRate.DataSource = Nothing
        Me.chtObjectRate.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtObjectRate.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtObjectRate.Location = New System.Drawing.Point(0, 960)
        Me.chtObjectRate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtObjectRate.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectRate.MenuVisible = True
        Me.chtObjectRate.MinimumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectRate.Name = "chtObjectRate"
        Me.chtObjectRate.Size = New System.Drawing.Size(1803, 375)
        Me.chtObjectRate.TabIndex = 28
        Me.chtObjectRate.Title = ""
        '
        'chtObjectTuple
        '
        Me.chtObjectTuple.BorderSkin = BorderSkin7
        Me.chtObjectTuple.DataSource = Nothing
        Me.chtObjectTuple.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtObjectTuple.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtObjectTuple.Location = New System.Drawing.Point(0, 640)
        Me.chtObjectTuple.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtObjectTuple.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtObjectTuple.MenuVisible = True
        Me.chtObjectTuple.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtObjectTuple.Name = "chtObjectTuple"
        Me.chtObjectTuple.Size = New System.Drawing.Size(1803, 320)
        Me.chtObjectTuple.TabIndex = 27
        Me.chtObjectTuple.Title = ""
        '
        'chtLogical
        '
        Me.chtLogical.BorderSkin = BorderSkin8
        Me.chtLogical.DataSource = Nothing
        Me.chtLogical.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtLogical.Font = New System.Drawing.Font("Gulim", 11.02!)
        Me.chtLogical.Location = New System.Drawing.Point(0, 320)
        Me.chtLogical.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.chtLogical.MaximumSize = New System.Drawing.Size(0, 375)
        Me.chtLogical.MenuVisible = True
        Me.chtLogical.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtLogical.Name = "chtLogical"
        Me.chtLogical.Size = New System.Drawing.Size(1803, 320)
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
        Me.chtSession.MaximumSize = New System.Drawing.Size(0, 350)
        Me.chtSession.MenuVisible = True
        Me.chtSession.MinimumSize = New System.Drawing.Size(0, 320)
        Me.chtSession.Name = "chtSession"
        Me.chtSession.Size = New System.Drawing.Size(1803, 320)
        Me.chtSession.TabIndex = 20
        Me.chtSession.Title = ""
        '
        'grpRptSQL
        '
        Me.grpRptSQL.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRptSQL.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRptSQL.AutoSize = True
        Me.grpRptSQL.Controls.Add(Me.dgvRptSQL)
        Me.grpRptSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Edges3.LeftBottom = 0
        Edges3.LeftTop = 0
        Edges3.RightBottom = 0
        Edges3.RightTop = 0
        Me.grpRptSQL.EdgeRound = Edges3
        Me.grpRptSQL.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptSQL.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptSQL.Icon = Nothing
        Me.grpRptSQL.LineColor = System.Drawing.Color.Gainsboro
        Me.grpRptSQL.LineWidth = 1
        Me.grpRptSQL.Location = New System.Drawing.Point(0, 0)
        Me.grpRptSQL.Name = "grpRptSQL"
        Me.grpRptSQL.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpRptSQL.Size = New System.Drawing.Size(1826, 235)
        Me.grpRptSQL.TabIndex = 33
        Me.grpRptSQL.TabStop = False
        Me.grpRptSQL.Text = "SQL list"
        Me.grpRptSQL.TitleFont = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpRptSQL.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRptSQL.UseGraColor = False
        Me.grpRptSQL.UseRound = True
        Me.grpRptSQL.UseTitle = True
        '
        'frmReports
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1826, 1054)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlSearch)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grpRptCpu.ResumeLayout(False)
        Me.pnlSystem.ResumeLayout(False)
        Me.pnlSystem.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.tlpDuration.ResumeLayout(False)
        Me.tlpButton.ResumeLayout(False)
        Me.grpRptTimeLine.ResumeLayout(False)
        Me.grpRptTimeLine.PerformLayout()
        Me.pnlTimeline.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgvRptSQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRptSQL.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRptCpu As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnSearch As eXperDB.BaseControls.Button
    Friend WithEvents chtRptCpu As eXperDB.Monitoring.ctlChart
    Friend WithEvents grpRptTimeLine As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnPrint As eXperDB.BaseControls.Button
    Friend WithEvents pnlSearch As eXperDB.BaseControls.Panel
    Friend WithEvents colDgvRptSqlInstID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlStart As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlCpuMax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlAddr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tlpButton As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents rb1D As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb12H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb4H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb2H As eXperDB.BaseControls.RadioButton
    Friend WithEvents rb1H As eXperDB.BaseControls.RadioButton
    Friend WithEvents Label1 As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblInstDt As eXperDB.BaseControls.Label
    Friend WithEvents cmbInst As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblInst As eXperDB.BaseControls.Label
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents pnlTimeline As eXperDB.BaseControls.Panel
    Friend WithEvents SplitContainer1 As eXperDB.BaseControls.SplitContainer
    Friend WithEvents pnlMain As eXperDB.BaseControls.Panel
    Friend WithEvents dgvRptSQL As eXperDB.BaseControls.DataGridView
    Friend WithEvents chtRptDiskRate As eXperDB.Monitoring.ctlChart
    Friend WithEvents flpDisk As eXperDB.BaseControls.FlowLayoutPanel
    Friend WithEvents chtBufferrate As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtBuffer As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtObjectRate As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtObjectTuple As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtLogical As eXperDB.Monitoring.ctlChart
    Friend WithEvents chtSession As eXperDB.Monitoring.ctlChart
    Friend WithEvents flpDB As eXperDB.BaseControls.FlowLayoutPanel
    Friend WithEvents pnlSystem As eXperDB.BaseControls.Panel
    Friend WithEvents chtRptDisk As eXperDB.Monitoring.ctlChart
    Friend WithEvents SplitContainer2 As eXperDB.BaseControls.SplitContainer
    Friend WithEvents dtpDay As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents tlpDuration As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents colDgvRptSqlDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlElapsedMax As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlCpuTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents colDgvRptSqlCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvRptSqlSql As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpRptSQL As eXperDB.BaseControls.GroupBox

End Class
