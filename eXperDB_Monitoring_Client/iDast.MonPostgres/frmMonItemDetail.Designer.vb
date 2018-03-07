<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonItemDetail
    Inherits Monitoring.frmMonBase

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
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonItemDetail))
        Dim BorderSkin1 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin2 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin3 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin4 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim BorderSkin5 As System.Windows.Forms.DataVisualization.Charting.BorderSkin = New System.Windows.Forms.DataVisualization.Charting.BorderSkin()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grpSessionLock = New eXperDB.BaseControls.GroupBox()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpChartArea = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpChart = New eXperDB.BaseControls.GroupBox()
        Me.pnlChart = New eXperDB.BaseControls.Panel()
        Me.chtLogicalIO = New eXperDB.Monitoring.ctlChartEx()
        Me.chtSQLResp = New eXperDB.Monitoring.ctlChartEx()
        Me.chtPhysicalIO = New eXperDB.Monitoring.ctlChartEx()
        Me.chtSession = New eXperDB.Monitoring.ctlChartEx()
        Me.chtCPU = New eXperDB.Monitoring.ctlChartEx()
        Me.tlpInput = New eXperDB.BaseControls.TableLayoutPanel()
        Me.cmbInst = New eXperDB.BaseControls.ComboBox()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.tlpButton = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnChartMenu = New eXperDB.BaseControls.Button()
        Me.btnRange = New eXperDB.BaseControls.Button()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.chkSQLResp = New eXperDB.BaseControls.CheckBox()
        Me.chkPhysicalIO = New eXperDB.BaseControls.CheckBox()
        Me.chkLogicalIO = New eXperDB.BaseControls.CheckBox()
        Me.chkSession = New eXperDB.BaseControls.CheckBox()
        Me.chkCpu = New eXperDB.BaseControls.CheckBox()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.grpSession = New eXperDB.BaseControls.GroupBox()
        Me.dgvSessionList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvSessionListDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListCpuUsage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListStTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListElapsedTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.coldgvSessionListUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListSQL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvSessionlistRegDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvSessionListActvRegSeq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLock = New AdvancedDataGridView.TreeGridView()
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
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpSessionLock.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tlpChartArea.SuspendLayout()
        Me.grpChart.SuspendLayout()
        Me.pnlChart.SuspendLayout()
        Me.tlpInput.SuspendLayout()
        Me.tlpButton.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grpSession.SuspendLayout()
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSessionLock
        '
        Me.grpSessionLock.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSessionLock.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSessionLock.BackColor = System.Drawing.Color.Black
        Me.grpSessionLock.Controls.Add(Me.tlpBottom)
        Me.grpSessionLock.Dock = System.Windows.Forms.DockStyle.Fill
        Edges3.LeftBottom = 0
        Edges3.RightBottom = 0
        Me.grpSessionLock.EdgeRound = Edges3
        Me.grpSessionLock.FillColor = System.Drawing.Color.Black
        Me.grpSessionLock.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSessionLock.Icon = Nothing
        Me.grpSessionLock.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpSessionLock.LineWidth = 1
        Me.grpSessionLock.Location = New System.Drawing.Point(3, 4)
        Me.grpSessionLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSessionLock.Name = "grpSessionLock"
        Me.tlpMain.SetRowSpan(Me.grpSessionLock, 2)
        Me.grpSessionLock.Size = New System.Drawing.Size(1428, 851)
        Me.grpSessionLock.TabIndex = 1
        Me.grpSessionLock.TabStop = False
        Me.grpSessionLock.Text = "F247"
        Me.grpSessionLock.TitleFont = New System.Drawing.Font("Arial", 10.61905!, System.Drawing.FontStyle.Bold)
        Me.grpSessionLock.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSessionLock.UseGraColor = False
        Me.grpSessionLock.UseRound = True
        Me.grpSessionLock.UseTitle = False
        '
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Transparent
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 11.46654!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpBottom.Location = New System.Drawing.Point(3, 21)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 2
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1422, 827)
        Me.tlpBottom.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.Black
        Me.tlpBottom.SetColumnSpan(Me.SplitContainer1, 2)
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpChartArea)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.Black
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpBottom.SetRowSpan(Me.SplitContainer1, 2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1416, 821)
        Me.SplitContainer1.SplitterDistance = 430
        Me.SplitContainer1.TabIndex = 0
        '
        'tlpChartArea
        '
        Me.tlpChartArea.ColumnCount = 1
        Me.tlpChartArea.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea.Controls.Add(Me.grpChart, 0, 2)
        Me.tlpChartArea.Controls.Add(Me.tlpInput, 0, 0)
        Me.tlpChartArea.Controls.Add(Me.tlpButton, 0, 1)
        Me.tlpChartArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpChartArea.Font = New System.Drawing.Font("Gulim", 9.366439!)
        Me.tlpChartArea.Location = New System.Drawing.Point(0, 0)
        Me.tlpChartArea.Name = "tlpChartArea"
        Me.tlpChartArea.RowCount = 3
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartArea.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpChartArea.Size = New System.Drawing.Size(1416, 430)
        Me.tlpChartArea.TabIndex = 0
        '
        'grpChart
        '
        Me.grpChart.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpChart.AlignString = System.Drawing.StringAlignment.Near
        Me.grpChart.BackColor = System.Drawing.Color.Black
        Me.grpChart.Controls.Add(Me.pnlChart)
        Me.grpChart.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.RightBottom = 0
        Me.grpChart.EdgeRound = Edges1
        Me.grpChart.FillColor = System.Drawing.Color.Black
        Me.grpChart.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpChart.Icon = CType(resources.GetObject("grpChart.Icon"), System.Drawing.Icon)
        Me.grpChart.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpChart.LineWidth = 1
        Me.grpChart.Location = New System.Drawing.Point(3, 84)
        Me.grpChart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpChart.Name = "grpChart"
        Me.grpChart.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpChart.Size = New System.Drawing.Size(1410, 342)
        Me.grpChart.TabIndex = 13
        Me.grpChart.TabStop = False
        Me.grpChart.Text = "F268"
        Me.grpChart.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpChart.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpChart.UseGraColor = False
        Me.grpChart.UseRound = True
        Me.grpChart.UseTitle = True
        '
        'pnlChart
        '
        Me.pnlChart.AutoScroll = True
        Me.pnlChart.AutoSize = True
        Me.pnlChart.Controls.Add(Me.chtLogicalIO)
        Me.pnlChart.Controls.Add(Me.chtSQLResp)
        Me.pnlChart.Controls.Add(Me.chtPhysicalIO)
        Me.pnlChart.Controls.Add(Me.chtSession)
        Me.pnlChart.Controls.Add(Me.chtCPU)
        Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlChart.Location = New System.Drawing.Point(3, 33)
        Me.pnlChart.Name = "pnlChart"
        Me.pnlChart.Size = New System.Drawing.Size(1404, 306)
        Me.pnlChart.TabIndex = 0
        '
        'chtLogicalIO
        '
        Me.chtLogicalIO.BorderSkin = BorderSkin1
        Me.chtLogicalIO.DataSource = Nothing
        Me.chtLogicalIO.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtLogicalIO.Location = New System.Drawing.Point(0, 1448)
        Me.chtLogicalIO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtLogicalIO.MenuVisible = False
        Me.chtLogicalIO.Name = "chtLogicalIO"
        Me.chtLogicalIO.Size = New System.Drawing.Size(1383, 362)
        Me.chtLogicalIO.TabIndex = 6
        Me.chtLogicalIO.Title = ""
        Me.chtLogicalIO.Visible = False
        '
        'chtSQLResp
        '
        Me.chtSQLResp.BorderSkin = BorderSkin2
        Me.chtSQLResp.DataSource = Nothing
        Me.chtSQLResp.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtSQLResp.Location = New System.Drawing.Point(0, 1086)
        Me.chtSQLResp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtSQLResp.MenuVisible = False
        Me.chtSQLResp.Name = "chtSQLResp"
        Me.chtSQLResp.Size = New System.Drawing.Size(1383, 362)
        Me.chtSQLResp.TabIndex = 8
        Me.chtSQLResp.Title = ""
        Me.chtSQLResp.Visible = False
        '
        'chtPhysicalIO
        '
        Me.chtPhysicalIO.BorderSkin = BorderSkin3
        Me.chtPhysicalIO.DataSource = Nothing
        Me.chtPhysicalIO.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtPhysicalIO.Location = New System.Drawing.Point(0, 724)
        Me.chtPhysicalIO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtPhysicalIO.MenuVisible = False
        Me.chtPhysicalIO.Name = "chtPhysicalIO"
        Me.chtPhysicalIO.Size = New System.Drawing.Size(1383, 362)
        Me.chtPhysicalIO.TabIndex = 7
        Me.chtPhysicalIO.Title = ""
        Me.chtPhysicalIO.Visible = False
        '
        'chtSession
        '
        Me.chtSession.BorderSkin = BorderSkin4
        Me.chtSession.DataSource = Nothing
        Me.chtSession.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtSession.Location = New System.Drawing.Point(0, 362)
        Me.chtSession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtSession.MenuVisible = False
        Me.chtSession.Name = "chtSession"
        Me.chtSession.Size = New System.Drawing.Size(1383, 362)
        Me.chtSession.TabIndex = 5
        Me.chtSession.Title = ""
        Me.chtSession.Visible = False
        '
        'chtCPU
        '
        Me.chtCPU.BorderSkin = BorderSkin5
        Me.chtCPU.DataSource = Nothing
        Me.chtCPU.Dock = System.Windows.Forms.DockStyle.Top
        Me.chtCPU.Location = New System.Drawing.Point(0, 0)
        Me.chtCPU.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chtCPU.MenuVisible = False
        Me.chtCPU.Name = "chtCPU"
        Me.chtCPU.Size = New System.Drawing.Size(1383, 362)
        Me.chtCPU.TabIndex = 3
        Me.chtCPU.Title = ""
        '
        'tlpInput
        '
        Me.tlpInput.ColumnCount = 8
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInput.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpInput.Controls.Add(Me.cmbInst, 1, 0)
        Me.tlpInput.Controls.Add(Me.lblServer, 0, 0)
        Me.tlpInput.Controls.Add(Me.dtpEd, 5, 0)
        Me.tlpInput.Controls.Add(Me.lblDuration2, 4, 0)
        Me.tlpInput.Controls.Add(Me.dtpSt, 3, 0)
        Me.tlpInput.Controls.Add(Me.lblDuration, 2, 0)
        Me.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInput.Font = New System.Drawing.Font("Gulim", 7.650974!)
        Me.tlpInput.Location = New System.Drawing.Point(3, 3)
        Me.tlpInput.Name = "tlpInput"
        Me.tlpInput.RowCount = 1
        Me.tlpInput.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInput.Size = New System.Drawing.Size(1410, 34)
        Me.tlpInput.TabIndex = 0
        '
        'cmbInst
        '
        Me.cmbInst.BackColor = System.Drawing.SystemColors.Window
        Me.cmbInst.DisplayMember = "All"
        Me.cmbInst.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInst.FixedWidth = False
        Me.cmbInst.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.cmbInst.FormattingEnabled = True
        Me.cmbInst.Location = New System.Drawing.Point(83, 7)
        Me.cmbInst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbInst.Name = "cmbInst"
        Me.cmbInst.Necessary = False
        Me.cmbInst.Size = New System.Drawing.Size(114, 23)
        Me.cmbInst.StatusTip = ""
        Me.cmbInst.TabIndex = 31
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
        Me.lblServer.ForeColor = System.Drawing.Color.LightGray
        Me.lblServer.Location = New System.Drawing.Point(3, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(74, 34)
        Me.lblServer.TabIndex = 30
        Me.lblServer.Text = "F033"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(463, 5)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(150, 25)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 29
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 6.438643!)
        Me.lblDuration2.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration2.Location = New System.Drawing.Point(443, 0)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(14, 34)
        Me.lblDuration2.TabIndex = 28
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(283, 5)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(150, 25)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 27
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblDuration.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration.Location = New System.Drawing.Point(203, 0)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(74, 34)
        Me.lblDuration.TabIndex = 26
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tlpButton
        '
        Me.tlpButton.ColumnCount = 10
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpButton.Controls.Add(Me.btnChartMenu, 9, 0)
        Me.tlpButton.Controls.Add(Me.btnRange, 8, 0)
        Me.tlpButton.Controls.Add(Me.btnQuery, 7, 0)
        Me.tlpButton.Controls.Add(Me.chkSQLResp, 4, 0)
        Me.tlpButton.Controls.Add(Me.chkPhysicalIO, 3, 0)
        Me.tlpButton.Controls.Add(Me.chkLogicalIO, 2, 0)
        Me.tlpButton.Controls.Add(Me.chkSession, 1, 0)
        Me.tlpButton.Controls.Add(Me.chkCpu, 0, 0)
        Me.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButton.Location = New System.Drawing.Point(3, 43)
        Me.tlpButton.Name = "tlpButton"
        Me.tlpButton.RowCount = 1
        Me.tlpButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButton.Size = New System.Drawing.Size(1410, 34)
        Me.tlpButton.TabIndex = 2
        '
        'btnChartMenu
        '
        Me.btnChartMenu.BackColor = System.Drawing.Color.Black
        Me.btnChartMenu.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChartMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnChartMenu.FixedHeight = False
        Me.btnChartMenu.FixedWidth = False
        Me.btnChartMenu.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnChartMenu.ForeColor = System.Drawing.Color.LightGray
        Me.btnChartMenu.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnChartMenu.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnChartMenu.Location = New System.Drawing.Point(1293, 4)
        Me.btnChartMenu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChartMenu.Name = "btnChartMenu"
        Me.btnChartMenu.Radius = 5
        Me.btnChartMenu.Size = New System.Drawing.Size(114, 26)
        Me.btnChartMenu.TabIndex = 13
        Me.btnChartMenu.Text = "F270"
        Me.btnChartMenu.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnChartMenu.UseRound = True
        Me.btnChartMenu.UseVisualStyleBackColor = False
        '
        'btnRange
        '
        Me.btnRange.BackColor = System.Drawing.Color.Black
        Me.btnRange.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRange.FixedHeight = False
        Me.btnRange.FixedWidth = False
        Me.btnRange.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnRange.ForeColor = System.Drawing.Color.LightGray
        Me.btnRange.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRange.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRange.Location = New System.Drawing.Point(1173, 4)
        Me.btnRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Radius = 5
        Me.btnRange.Size = New System.Drawing.Size(114, 26)
        Me.btnRange.TabIndex = 12
        Me.btnRange.Text = "F269"
        Me.btnRange.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRange.UseRound = True
        Me.btnRange.UseVisualStyleBackColor = False
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.Black
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.btnQuery.ForeColor = System.Drawing.Color.LightGray
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(1053, 4)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(114, 26)
        Me.btnQuery.TabIndex = 11
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'chkSQLResp
        '
        Me.chkSQLResp.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkSQLResp.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkSQLResp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSQLResp.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.chkSQLResp.ForeColor = System.Drawing.Color.White
        Me.chkSQLResp.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.chkSQLResp.Location = New System.Drawing.Point(603, 3)
        Me.chkSQLResp.Name = "chkSQLResp"
        Me.chkSQLResp.Radius = 8
        Me.chkSQLResp.Size = New System.Drawing.Size(144, 28)
        Me.chkSQLResp.TabIndex = 5
        Me.chkSQLResp.Text = "F103"
        Me.chkSQLResp.UnCheckFillColor = System.Drawing.Color.Black
        Me.chkSQLResp.UseRound = True
        Me.chkSQLResp.UseVisualStyleBackColor = True
        '
        'chkPhysicalIO
        '
        Me.chkPhysicalIO.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPhysicalIO.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkPhysicalIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkPhysicalIO.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.chkPhysicalIO.ForeColor = System.Drawing.Color.White
        Me.chkPhysicalIO.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.chkPhysicalIO.Location = New System.Drawing.Point(453, 3)
        Me.chkPhysicalIO.Name = "chkPhysicalIO"
        Me.chkPhysicalIO.Radius = 8
        Me.chkPhysicalIO.Size = New System.Drawing.Size(144, 28)
        Me.chkPhysicalIO.TabIndex = 4
        Me.chkPhysicalIO.Text = "F100"
        Me.chkPhysicalIO.UnCheckFillColor = System.Drawing.Color.Black
        Me.chkPhysicalIO.UseRound = True
        Me.chkPhysicalIO.UseVisualStyleBackColor = True
        '
        'chkLogicalIO
        '
        Me.chkLogicalIO.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkLogicalIO.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkLogicalIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkLogicalIO.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.chkLogicalIO.ForeColor = System.Drawing.Color.White
        Me.chkLogicalIO.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.chkLogicalIO.Location = New System.Drawing.Point(303, 3)
        Me.chkLogicalIO.Name = "chkLogicalIO"
        Me.chkLogicalIO.Radius = 8
        Me.chkLogicalIO.Size = New System.Drawing.Size(144, 28)
        Me.chkLogicalIO.TabIndex = 3
        Me.chkLogicalIO.Text = "F101"
        Me.chkLogicalIO.UnCheckFillColor = System.Drawing.Color.Black
        Me.chkLogicalIO.UseRound = True
        Me.chkLogicalIO.UseVisualStyleBackColor = True
        '
        'chkSession
        '
        Me.chkSession.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkSession.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkSession.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.chkSession.ForeColor = System.Drawing.Color.White
        Me.chkSession.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.chkSession.Location = New System.Drawing.Point(153, 3)
        Me.chkSession.Name = "chkSession"
        Me.chkSession.Radius = 8
        Me.chkSession.Size = New System.Drawing.Size(144, 28)
        Me.chkSession.TabIndex = 2
        Me.chkSession.Text = "F047"
        Me.chkSession.UnCheckFillColor = System.Drawing.Color.Black
        Me.chkSession.UseRound = True
        Me.chkSession.UseVisualStyleBackColor = True
        '
        'chkCpu
        '
        Me.chkCpu.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkCpu.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCpu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chkCpu.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.chkCpu.ForeColor = System.Drawing.Color.White
        Me.chkCpu.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.chkCpu.Location = New System.Drawing.Point(3, 3)
        Me.chkCpu.Name = "chkCpu"
        Me.chkCpu.Radius = 8
        Me.chkCpu.Size = New System.Drawing.Size(144, 28)
        Me.chkCpu.TabIndex = 1
        Me.chkCpu.Text = "F035"
        Me.chkCpu.UnCheckFillColor = System.Drawing.Color.Black
        Me.chkCpu.UseRound = True
        Me.chkCpu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grpSession)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1416, 387)
        Me.Panel1.TabIndex = 0
        '
        'grpSession
        '
        Me.grpSession.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSession.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSession.BackColor = System.Drawing.Color.Black
        Me.grpSession.Controls.Add(Me.dgvSessionList)
        Me.grpSession.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.RightBottom = 0
        Me.grpSession.EdgeRound = Edges2
        Me.grpSession.FillColor = System.Drawing.Color.Black
        Me.grpSession.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpSession.Icon = CType(resources.GetObject("grpSession.Icon"), System.Drawing.Icon)
        Me.grpSession.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpSession.LineWidth = 1
        Me.grpSession.Location = New System.Drawing.Point(0, 0)
        Me.grpSession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSession.Name = "grpSession"
        Me.grpSession.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpSession.Size = New System.Drawing.Size(1416, 387)
        Me.grpSession.TabIndex = 12
        Me.grpSession.TabStop = False
        Me.grpSession.Text = "F313"
        Me.grpSession.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpSession.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSession.UseGraColor = False
        Me.grpSession.UseRound = True
        Me.grpSession.UseTitle = True
        '
        'dgvSessionList
        '
        Me.dgvSessionList.AllowUserToAddRows = False
        Me.dgvSessionList.AllowUserToDeleteRows = False
        Me.dgvSessionList.AllowUserToOrderColumns = True
        Me.dgvSessionList.AllowUserToResizeColumns = False
        Me.dgvSessionList.AllowUserToResizeRows = False
        Me.dgvSessionList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSessionList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSessionList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvSessionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSessionList.ColumnHeadersHeight = 30
        Me.dgvSessionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvSessionListDB, Me.coldgvSessionListPID, Me.coldgvSessionListCpuUsage, Me.coldgvSessionListStTime, Me.coldgvSessionListElapsedTime, Me.coldgvSessionListUser, Me.coldgvSessionListClient, Me.coldgvSessionListApp, Me.coldgvSessionListSQL, Me.colDgvSessionlistRegDate, Me.colDgvSessionListActvRegSeq})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 7.760073!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSessionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSessionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSessionList.EnableHeadersVisualStyles = False
        Me.dgvSessionList.Font = New System.Drawing.Font("Gulim", 7.760073!)
        Me.dgvSessionList.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSessionList.Location = New System.Drawing.Point(3, 33)
        Me.dgvSessionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSessionList.Name = "dgvSessionList"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 9.2!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvSessionList.RowHeadersVisible = False
        Me.dgvSessionList.RowTemplate.Height = 23
        Me.dgvSessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessionList.Size = New System.Drawing.Size(1410, 351)
        Me.dgvSessionList.TabIndex = 11
        Me.dgvSessionList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSessionList.UseTagValueMatchColor = False
        '
        'coldgvSessionListDB
        '
        Me.coldgvSessionListDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvSessionListDB.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvSessionListDB.HeaderText = "F090"
        Me.coldgvSessionListDB.Name = "coldgvSessionListDB"
        Me.coldgvSessionListDB.ReadOnly = True
        Me.coldgvSessionListDB.Width = 88
        '
        'coldgvSessionListPID
        '
        Me.coldgvSessionListPID.DataPropertyName = "PROCESS_ID"
        Me.coldgvSessionListPID.HeaderText = "F082"
        Me.coldgvSessionListPID.Name = "coldgvSessionListPID"
        Me.coldgvSessionListPID.ReadOnly = True
        Me.coldgvSessionListPID.Width = 76
        '
        'coldgvSessionListCpuUsage
        '
        Me.coldgvSessionListCpuUsage.DataPropertyName = "CPU_USAGE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.coldgvSessionListCpuUsage.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvSessionListCpuUsage.HeaderText = "F092"
        Me.coldgvSessionListCpuUsage.Name = "coldgvSessionListCpuUsage"
        Me.coldgvSessionListCpuUsage.ReadOnly = True
        Me.coldgvSessionListCpuUsage.Width = 76
        '
        'coldgvSessionListStTime
        '
        Me.coldgvSessionListStTime.DataPropertyName = "START_TIME"
        DataGridViewCellStyle4.Format = "HH:mm:ss"
        Me.coldgvSessionListStTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvSessionListStTime.HeaderText = "F050"
        Me.coldgvSessionListStTime.Name = "coldgvSessionListStTime"
        Me.coldgvSessionListStTime.ReadOnly = True
        Me.coldgvSessionListStTime.Width = 130
        '
        'coldgvSessionListElapsedTime
        '
        Me.coldgvSessionListElapsedTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.coldgvSessionListElapsedTime.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "12"
        Me.coldgvSessionListElapsedTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvSessionListElapsedTime.FillWeight = 150.0!
        Me.coldgvSessionListElapsedTime.FormatString = "dd\ \d\a\y\ hh\:mm\:ss\.ff"
        Me.coldgvSessionListElapsedTime.HeaderText = "F051"
        Me.coldgvSessionListElapsedTime.MinimumWidth = 150
        Me.coldgvSessionListElapsedTime.Name = "coldgvSessionListElapsedTime"
        Me.coldgvSessionListElapsedTime.ReadOnly = True
        Me.coldgvSessionListElapsedTime.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListElapsedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListElapsedTime.Width = 150
        '
        'coldgvSessionListUser
        '
        Me.coldgvSessionListUser.DataPropertyName = "USER_NAME"
        Me.coldgvSessionListUser.HeaderText = "F008"
        Me.coldgvSessionListUser.Name = "coldgvSessionListUser"
        Me.coldgvSessionListUser.ReadOnly = True
        Me.coldgvSessionListUser.Width = 120
        '
        'coldgvSessionListClient
        '
        Me.coldgvSessionListClient.DataPropertyName = "CLIENT_ADDR"
        Me.coldgvSessionListClient.HeaderText = "F248"
        Me.coldgvSessionListClient.Name = "coldgvSessionListClient"
        Me.coldgvSessionListClient.ReadOnly = True
        Me.coldgvSessionListClient.Width = 200
        '
        'coldgvSessionListApp
        '
        Me.coldgvSessionListApp.DataPropertyName = "CLIENT_APP"
        Me.coldgvSessionListApp.HeaderText = "F249"
        Me.coldgvSessionListApp.Name = "coldgvSessionListApp"
        Me.coldgvSessionListApp.ReadOnly = True
        Me.coldgvSessionListApp.Width = 200
        '
        'coldgvSessionListSQL
        '
        Me.coldgvSessionListSQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvSessionListSQL.DataPropertyName = "SQL"
        Me.coldgvSessionListSQL.HeaderText = "F052"
        Me.coldgvSessionListSQL.Name = "coldgvSessionListSQL"
        Me.coldgvSessionListSQL.ReadOnly = True
        '
        'colDgvSessionlistRegDate
        '
        Me.colDgvSessionlistRegDate.DataPropertyName = "REG_DATE"
        Me.colDgvSessionlistRegDate.HeaderText = "REG_DATE"
        Me.colDgvSessionlistRegDate.Name = "colDgvSessionlistRegDate"
        Me.colDgvSessionlistRegDate.ReadOnly = True
        Me.colDgvSessionlistRegDate.Visible = False
        Me.colDgvSessionlistRegDate.Width = 102
        '
        'colDgvSessionListActvRegSeq
        '
        Me.colDgvSessionListActvRegSeq.DataPropertyName = "ACTV_REG_SEQ"
        Me.colDgvSessionListActvRegSeq.HeaderText = "ACTV_REG_SEQ"
        Me.colDgvSessionListActvRegSeq.Name = "colDgvSessionListActvRegSeq"
        Me.colDgvSessionListActvRegSeq.ReadOnly = True
        Me.colDgvSessionListActvRegSeq.Visible = False
        Me.colDgvSessionListActvRegSeq.Width = 136
        '
        'dgvLock
        '
        Me.dgvLock.AllowUserToAddRows = False
        Me.dgvLock.AllowUserToDeleteRows = False
        Me.dgvLock.AllowUserToOrderColumns = True
        Me.dgvLock.AllowUserToResizeRows = False
        Me.dgvLock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLock.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvLockDB, Me.colDgvLockBlockingPID, Me.colDgvLockBlockingUser, Me.colDgvLockBlockingQuery, Me.colDgvLockBlockedPID, Me.colDgvLockBlockedUser, Me.colDgvLockBlockedQuery, Me.colDgvLockMode, Me.colDgvLockElapse, Me.colDgvLockQueryStart, Me.colDgvLockXactStart, Me.colDgvLockRegDate, Me.colDgvLockActvRegSeq})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLock.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvLock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLock.EnableHeadersVisualStyles = False
        Me.dgvLock.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvLock.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvLock.ImageList = Nothing
        Me.dgvLock.Location = New System.Drawing.Point(3, 31)
        Me.dgvLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLock.Name = "dgvLock"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLock.RowHeadersVisible = False
        Me.dgvLock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLock.Size = New System.Drawing.Size(1798, 372)
        Me.dgvLock.TabIndex = 9
        '
        'colDgvLockDB
        '
        Me.colDgvLockDB.DataPropertyName = "DB_NAME"
        Me.colDgvLockDB.DefaultNodeImage = Nothing
        Me.colDgvLockDB.FillWeight = 150.0!
        Me.colDgvLockDB.HeaderText = "F104"
        Me.colDgvLockDB.Name = "colDgvLockDB"
        Me.colDgvLockDB.ReadOnly = True
        Me.colDgvLockDB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingPID
        '
        Me.colDgvLockBlockingPID.DataPropertyName = "BLOCKING_PID"
        Me.colDgvLockBlockingPID.FillWeight = 102.0!
        Me.colDgvLockBlockingPID.HeaderText = "F197"
        Me.colDgvLockBlockingPID.Name = "colDgvLockBlockingPID"
        Me.colDgvLockBlockingPID.ReadOnly = True
        Me.colDgvLockBlockingPID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockBlockingPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingUser
        '
        Me.colDgvLockBlockingUser.DataPropertyName = "BLOCKING_USER"
        Me.colDgvLockBlockingUser.FillWeight = 130.0!
        Me.colDgvLockBlockingUser.HeaderText = "F134"
        Me.colDgvLockBlockingUser.Name = "colDgvLockBlockingUser"
        Me.colDgvLockBlockingUser.ReadOnly = True
        Me.colDgvLockBlockingUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingQuery
        '
        Me.colDgvLockBlockingQuery.DataPropertyName = "BLOCKING_QUERY"
        Me.colDgvLockBlockingQuery.FillWeight = 200.0!
        Me.colDgvLockBlockingQuery.HeaderText = "F084"
        Me.colDgvLockBlockingQuery.Name = "colDgvLockBlockingQuery"
        Me.colDgvLockBlockingQuery.ReadOnly = True
        Me.colDgvLockBlockingQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedPID
        '
        Me.colDgvLockBlockedPID.DataPropertyName = "BLOCKED_PID"
        Me.colDgvLockBlockedPID.FillWeight = 102.0!
        Me.colDgvLockBlockedPID.HeaderText = "F195"
        Me.colDgvLockBlockedPID.Name = "colDgvLockBlockedPID"
        Me.colDgvLockBlockedPID.ReadOnly = True
        Me.colDgvLockBlockedPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedUser
        '
        Me.colDgvLockBlockedUser.DataPropertyName = "BLOCKED_USER"
        Me.colDgvLockBlockedUser.FillWeight = 130.0!
        Me.colDgvLockBlockedUser.HeaderText = "F196"
        Me.colDgvLockBlockedUser.Name = "colDgvLockBlockedUser"
        Me.colDgvLockBlockedUser.ReadOnly = True
        Me.colDgvLockBlockedUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedQuery
        '
        Me.colDgvLockBlockedQuery.DataPropertyName = "BLOCKED_QUERY"
        Me.colDgvLockBlockedQuery.FillWeight = 200.0!
        Me.colDgvLockBlockedQuery.HeaderText = "F221"
        Me.colDgvLockBlockedQuery.Name = "colDgvLockBlockedQuery"
        Me.colDgvLockBlockedQuery.ReadOnly = True
        Me.colDgvLockBlockedQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockMode
        '
        Me.colDgvLockMode.DataPropertyName = "LOCK_MODE"
        Me.colDgvLockMode.FillWeight = 130.0!
        Me.colDgvLockMode.HeaderText = "F222"
        Me.colDgvLockMode.Name = "colDgvLockMode"
        Me.colDgvLockMode.ReadOnly = True
        Me.colDgvLockMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockElapse
        '
        Me.colDgvLockElapse.DataPropertyName = "BLOCKED_DURATION"
        Me.colDgvLockElapse.FillWeight = 120.0!
        Me.colDgvLockElapse.HeaderText = "F135"
        Me.colDgvLockElapse.Name = "colDgvLockElapse"
        Me.colDgvLockElapse.ReadOnly = True
        Me.colDgvLockElapse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockQueryStart
        '
        Me.colDgvLockQueryStart.DataPropertyName = "QUERY_START"
        Me.colDgvLockQueryStart.FillWeight = 163.0!
        Me.colDgvLockQueryStart.HeaderText = "F223"
        Me.colDgvLockQueryStart.Name = "colDgvLockQueryStart"
        Me.colDgvLockQueryStart.ReadOnly = True
        Me.colDgvLockQueryStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockXactStart
        '
        Me.colDgvLockXactStart.DataPropertyName = "XACT_START"
        Me.colDgvLockXactStart.FillWeight = 163.0!
        Me.colDgvLockXactStart.HeaderText = "F224"
        Me.colDgvLockXactStart.Name = "colDgvLockXactStart"
        Me.colDgvLockXactStart.ReadOnly = True
        Me.colDgvLockXactStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockRegDate
        '
        Me.colDgvLockRegDate.DataPropertyName = "REG_DATE"
        Me.colDgvLockRegDate.HeaderText = "REG_DATE"
        Me.colDgvLockRegDate.Name = "colDgvLockRegDate"
        Me.colDgvLockRegDate.ReadOnly = True
        Me.colDgvLockRegDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockRegDate.Visible = False
        '
        'colDgvLockActvRegSeq
        '
        Me.colDgvLockActvRegSeq.DataPropertyName = "ACTV_REG_SEQ"
        Me.colDgvLockActvRegSeq.HeaderText = "ACTV_REG_SEQ"
        Me.colDgvLockActvRegSeq.Name = "colDgvLockActvRegSeq"
        Me.colDgvLockActvRegSeq.ReadOnly = True
        Me.colDgvLockActvRegSeq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockActvRegSeq.Visible = False
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.grpSessionLock, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Gulim", 11.46654!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpMain.Location = New System.Drawing.Point(2, 29)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.670529!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.32947!))
        Me.tlpMain.Size = New System.Drawing.Size(1434, 859)
        Me.tlpMain.TabIndex = 11
        '
        'frmMonItemDetail
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BaseHeight = 892
        Me.ClientSize = New System.Drawing.Size(1438, 890)
        Me.Controls.Add(Me.tlpMain)
        Me.Font = New System.Drawing.Font("Gulim", 9.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMonItemDetail"
        Me.Controls.SetChildIndex(Me.tlpMain, 0)
        Me.grpSessionLock.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tlpChartArea.ResumeLayout(False)
        Me.grpChart.ResumeLayout(False)
        Me.grpChart.PerformLayout()
        Me.pnlChart.ResumeLayout(False)
        Me.tlpInput.ResumeLayout(False)
        Me.tlpButton.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.grpSession.ResumeLayout(False)
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpSessionLock As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvLock As AdvancedDataGridView.TreeGridView
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
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
    Friend WithEvents tlpChartArea As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpInput As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents cmbInst As eXperDB.BaseControls.ComboBox
    Friend WithEvents chkCpu As eXperDB.BaseControls.CheckBox
    Friend WithEvents tlpButton As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents chkSQLResp As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkPhysicalIO As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkLogicalIO As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkSession As eXperDB.BaseControls.CheckBox
    Friend WithEvents dgvSessionList As eXperDB.BaseControls.DataGridView
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents grpSession As eXperDB.BaseControls.GroupBox
    Friend WithEvents coldgvSessionListDB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListCpuUsage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListStTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListElapsedTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents coldgvSessionListUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListClient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListSQL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvSessionlistRegDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvSessionListActvRegSeq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chtCPU As eXperDB.Monitoring.ctlChartEx
    Friend WithEvents grpChart As eXperDB.BaseControls.GroupBox
    Friend WithEvents chtSQLResp As eXperDB.Monitoring.ctlChartEx
    Friend WithEvents chtPhysicalIO As eXperDB.Monitoring.ctlChartEx
    Friend WithEvents chtLogicalIO As eXperDB.Monitoring.ctlChartEx
    Friend WithEvents chtSession As eXperDB.Monitoring.ctlChartEx
    Friend WithEvents pnlChart As eXperDB.BaseControls.Panel
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents btnChartMenu As eXperDB.BaseControls.Button
    Friend WithEvents btnRange As eXperDB.BaseControls.Button

End Class
