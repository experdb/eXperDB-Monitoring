<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSessionLockHist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSessionLockHist))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.grpSessionLockHist = New eXperDB.BaseControls.GroupBox()
        Me.txtDatabase = New eXperDB.BaseControls.TextBox()
        Me.lblSQL = New eXperDB.BaseControls.Label()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.lblDatabase = New eXperDB.BaseControls.Label()
        Me.lblType = New eXperDB.BaseControls.Label()
        Me.txtSQL = New eXperDB.BaseControls.TextBox()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.cmbType = New eXperDB.BaseControls.ComboBox()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.grpSession = New eXperDB.BaseControls.GroupBox()
        Me.dgvSessionList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvSessionCtrlType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionCtrlTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListCpuUsage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListStTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListElapsedTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.coldgvSessionListStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListClient = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListApp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvSessionListRead = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvSessionListWrite = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvSessionListSQL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpLockInfo = New eXperDB.BaseControls.GroupBox()
        Me.dgvLock = New AdvancedDataGridView.TreeGridView()
        Me.colDgvLockDB = New AdvancedDataGridView.TreeGridColumn()
        Me.coldgvLockCtrlType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLockCtrlTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpSessionLockHist.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.grpSession.SuspendLayout()
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLockInfo.SuspendLayout()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'grpSessionLockHist
        '
        Me.grpSessionLockHist.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSessionLockHist.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSessionLockHist.BackColor = System.Drawing.Color.Black
        Me.grpSessionLockHist.Controls.Add(Me.txtDatabase)
        Me.grpSessionLockHist.Controls.Add(Me.lblSQL)
        Me.grpSessionLockHist.Controls.Add(Me.lblDuration)
        Me.grpSessionLockHist.Controls.Add(Me.lblDatabase)
        Me.grpSessionLockHist.Controls.Add(Me.lblType)
        Me.grpSessionLockHist.Controls.Add(Me.txtSQL)
        Me.grpSessionLockHist.Controls.Add(Me.dtpEd)
        Me.grpSessionLockHist.Controls.Add(Me.lblDuration2)
        Me.grpSessionLockHist.Controls.Add(Me.dtpSt)
        Me.grpSessionLockHist.Controls.Add(Me.cmbType)
        Me.grpSessionLockHist.Controls.Add(Me.btnQuery)
        Me.grpSessionLockHist.Controls.Add(Me.btnExcel)
        Me.grpSessionLockHist.Controls.Add(Me.tlpBottom)
        Me.grpSessionLockHist.Dock = System.Windows.Forms.DockStyle.Fill
        Edges3.LeftBottom = 0
        Edges3.RightBottom = 0
        Me.grpSessionLockHist.EdgeRound = Edges3
        Me.grpSessionLockHist.FillColor = System.Drawing.Color.Black
        Me.grpSessionLockHist.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.grpSessionLockHist.Icon = Nothing
        Me.grpSessionLockHist.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpSessionLockHist.LineWidth = 1
        Me.grpSessionLockHist.Location = New System.Drawing.Point(3, 4)
        Me.grpSessionLockHist.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSessionLockHist.Name = "grpSessionLockHist"
        Me.grpSessionLockHist.Padding = New System.Windows.Forms.Padding(3, 13, 3, 3)
        Me.tlpMain.SetRowSpan(Me.grpSessionLockHist, 2)
        Me.grpSessionLockHist.Size = New System.Drawing.Size(1816, 1051)
        Me.grpSessionLockHist.TabIndex = 1
        Me.grpSessionLockHist.TabStop = False
        Me.grpSessionLockHist.Text = "F247"
        Me.grpSessionLockHist.TitleFont = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.grpSessionLockHist.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSessionLockHist.UseGraColor = False
        Me.grpSessionLockHist.UseRound = True
        Me.grpSessionLockHist.UseTitle = True
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.Window
        Me.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatabase.code = False
        Me.txtDatabase.FixedWidth = False
        Me.txtDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDatabase.impossibleinput = ""
        Me.txtDatabase.Location = New System.Drawing.Point(802, 7)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Necessary = False
        Me.txtDatabase.PossibleInput = ""
        Me.txtDatabase.Prefix = ""
        Me.txtDatabase.Size = New System.Drawing.Size(120, 25)
        Me.txtDatabase.StatusTip = ""
        Me.txtDatabase.TabIndex = 27
        Me.txtDatabase.Value = ""
        '
        'lblSQL
        '
        Me.lblSQL.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblSQL.FixedHeight = False
        Me.lblSQL.FixedWidth = False
        Me.lblSQL.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblSQL.ForeColor = System.Drawing.Color.LightGray
        Me.lblSQL.Location = New System.Drawing.Point(1411, 5)
        Me.lblSQL.Name = "lblSQL"
        Me.lblSQL.Size = New System.Drawing.Size(50, 26)
        Me.lblSQL.TabIndex = 26
        Me.lblSQL.Text = "SQL"
        Me.lblSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblDuration.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration.Location = New System.Drawing.Point(927, 5)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(88, 26)
        Me.lblDuration.TabIndex = 25
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDatabase
        '
        Me.lblDatabase.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDatabase.FixedHeight = False
        Me.lblDatabase.FixedWidth = False
        Me.lblDatabase.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblDatabase.ForeColor = System.Drawing.Color.LightGray
        Me.lblDatabase.Location = New System.Drawing.Point(719, 5)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(88, 26)
        Me.lblDatabase.TabIndex = 24
        Me.lblDatabase.Text = "Database"
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblType
        '
        Me.lblType.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblType.FixedHeight = False
        Me.lblType.FixedWidth = False
        Me.lblType.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblType.ForeColor = System.Drawing.Color.LightGray
        Me.lblType.Location = New System.Drawing.Point(525, 5)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(88, 26)
        Me.lblType.TabIndex = 23
        Me.lblType.Text = "F252"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSQL
        '
        Me.txtSQL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQL.code = False
        Me.txtSQL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSQL.impossibleinput = ""
        Me.txtSQL.Location = New System.Drawing.Point(1463, 7)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Necessary = False
        Me.txtSQL.PossibleInput = ""
        Me.txtSQL.Prefix = ""
        Me.txtSQL.Size = New System.Drawing.Size(150, 25)
        Me.txtSQL.StatusTip = ""
        Me.txtSQL.TabIndex = 22
        Me.txtSQL.Value = ""
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpEd.FixedWidth = False
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(1226, 7)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(140, 25)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 21
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.lblDuration2.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration2.Location = New System.Drawing.Point(1200, 5)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(26, 26)
        Me.lblDuration2.TabIndex = 20
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpSt.FixedWidth = False
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(1020, 7)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(170, 25)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 19
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbType.DisplayMember = "All"
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FixedWidth = False
        Me.cmbType.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"All", "Cancel", "Stop"})
        Me.cmbType.Location = New System.Drawing.Point(619, 8)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Necessary = False
        Me.cmbType.Size = New System.Drawing.Size(94, 23)
        Me.cmbType.StatusTip = ""
        Me.cmbType.TabIndex = 17
        Me.cmbType.ValueText = ""
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.Black
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnQuery.ForeColor = System.Drawing.Color.LightGray
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(1619, 4)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(100, 31)
        Me.btnQuery.TabIndex = 10
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnExcel.ForeColor = System.Drawing.Color.LightGray
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(1716, 4)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(102, 31)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "F142"
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseRound = True
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Transparent
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Controls.Add(Me.SplitContainer1, 0, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.tlpBottom.Location = New System.Drawing.Point(3, 31)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 2
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1810, 1017)
        Me.tlpBottom.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.tlpBottom.SetColumnSpan(Me.SplitContainer1, 2)
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpSession)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grpLockInfo)
        Me.tlpBottom.SetRowSpan(Me.SplitContainer1, 2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1804, 1011)
        Me.SplitContainer1.SplitterDistance = 601
        Me.SplitContainer1.TabIndex = 0
        '
        'grpSession
        '
        Me.grpSession.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSession.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSession.BackColor = System.Drawing.Color.Black
        Me.grpSession.Controls.Add(Me.dgvSessionList)
        Me.grpSession.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.RightBottom = 0
        Me.grpSession.EdgeRound = Edges1
        Me.grpSession.FillColor = System.Drawing.Color.Black
        Me.grpSession.Font = New System.Drawing.Font("Gulim", 11.0!)
        Me.grpSession.Icon = CType(resources.GetObject("grpSession.Icon"), System.Drawing.Icon)
        Me.grpSession.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpSession.LineWidth = 1
        Me.grpSession.Location = New System.Drawing.Point(0, 0)
        Me.grpSession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSession.Name = "grpSession"
        Me.grpSession.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpSession.Size = New System.Drawing.Size(1804, 601)
        Me.grpSession.TabIndex = 3
        Me.grpSession.TabStop = False
        Me.grpSession.Text = "F080"
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
        Me.dgvSessionList.AllowUserToResizeRows = False
        Me.dgvSessionList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSessionList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSessionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSessionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvSessionCtrlType, Me.coldgvSessionCtrlTime, Me.coldgvSessionListDB, Me.coldgvSessionListPID, Me.coldgvSessionListCpuUsage, Me.coldgvSessionListStTime, Me.coldgvSessionListElapsedTime, Me.coldgvSessionListStatus, Me.coldgvSessionListUser, Me.coldgvSessionListClient, Me.coldgvSessionListApp, Me.coldgvSessionListRead, Me.coldgvSessionListWrite, Me.coldgvSessionListSQL})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Gulim", 9.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionList.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSessionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSessionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSessionList.EnableHeadersVisualStyles = False
        Me.dgvSessionList.Font = New System.Drawing.Font("Gulim", 9.5!)
        Me.dgvSessionList.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvSessionList.Location = New System.Drawing.Point(3, 33)
        Me.dgvSessionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSessionList.MultiSelect = False
        Me.dgvSessionList.Name = "dgvSessionList"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 9.5!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSessionList.RowHeadersVisible = False
        Me.dgvSessionList.RowTemplate.Height = 23
        Me.dgvSessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessionList.Size = New System.Drawing.Size(1798, 565)
        Me.dgvSessionList.TabIndex = 10
        Me.dgvSessionList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSessionList.UseTagValueMatchColor = False
        '
        'coldgvSessionCtrlType
        '
        Me.coldgvSessionCtrlType.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvSessionCtrlType.HeaderText = "F252"
        Me.coldgvSessionCtrlType.Name = "coldgvSessionCtrlType"
        Me.coldgvSessionCtrlType.ReadOnly = True
        Me.coldgvSessionCtrlType.Width = 66
        '
        'coldgvSessionCtrlTime
        '
        Me.coldgvSessionCtrlTime.DataPropertyName = "CONTROL_TIME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.coldgvSessionCtrlTime.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvSessionCtrlTime.HeaderText = "F253"
        Me.coldgvSessionCtrlTime.Name = "coldgvSessionCtrlTime"
        Me.coldgvSessionCtrlTime.ReadOnly = True
        Me.coldgvSessionCtrlTime.Width = 160
        '
        'coldgvSessionListDB
        '
        Me.coldgvSessionListDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.coldgvSessionListDB.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.coldgvSessionListCpuUsage.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvSessionListCpuUsage.HeaderText = "F092"
        Me.coldgvSessionListCpuUsage.Name = "coldgvSessionListCpuUsage"
        Me.coldgvSessionListCpuUsage.ReadOnly = True
        Me.coldgvSessionListCpuUsage.Width = 76
        '
        'coldgvSessionListStTime
        '
        Me.coldgvSessionListStTime.DataPropertyName = "START_TIME"
        DataGridViewCellStyle5.Format = "HH:mm:ss"
        Me.coldgvSessionListStTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvSessionListStTime.HeaderText = "F050"
        Me.coldgvSessionListStTime.Name = "coldgvSessionListStTime"
        Me.coldgvSessionListStTime.ReadOnly = True
        Me.coldgvSessionListStTime.Width = 130
        '
        'coldgvSessionListElapsedTime
        '
        Me.coldgvSessionListElapsedTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.coldgvSessionListElapsedTime.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "12"
        Me.coldgvSessionListElapsedTime.DefaultCellStyle = DataGridViewCellStyle6
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
        'coldgvSessionListStatus
        '
        Me.coldgvSessionListStatus.DataPropertyName = "STATE"
        Me.coldgvSessionListStatus.HeaderText = "F247"
        Me.coldgvSessionListStatus.Name = "coldgvSessionListStatus"
        Me.coldgvSessionListStatus.ReadOnly = True
        Me.coldgvSessionListStatus.Width = 76
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
        'coldgvSessionListRead
        '
        Me.coldgvSessionListRead.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvSessionListRead.DataPropertyName = "CURRENT_PROC_READ_KB"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N1"
        Me.coldgvSessionListRead.DefaultCellStyle = DataGridViewCellStyle7
        Me.coldgvSessionListRead.HeaderText = "F048"
        Me.coldgvSessionListRead.HeaderWord = ""
        Me.coldgvSessionListRead.Name = "coldgvSessionListRead"
        Me.coldgvSessionListRead.ReadOnly = True
        Me.coldgvSessionListRead.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListRead.ShowUnit = True
        Me.coldgvSessionListRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListRead.TailWord = ""
        Me.coldgvSessionListRead.Width = 110
        '
        'coldgvSessionListWrite
        '
        Me.coldgvSessionListWrite.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvSessionListWrite.DataPropertyName = "CURRENT_PROC_WRITE_KB"
        DataGridViewCellStyle8.Format = "N1"
        Me.coldgvSessionListWrite.DefaultCellStyle = DataGridViewCellStyle8
        Me.coldgvSessionListWrite.HeaderText = "F136"
        Me.coldgvSessionListWrite.HeaderWord = ""
        Me.coldgvSessionListWrite.Name = "coldgvSessionListWrite"
        Me.coldgvSessionListWrite.ReadOnly = True
        Me.coldgvSessionListWrite.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListWrite.ShowUnit = True
        Me.coldgvSessionListWrite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListWrite.TailWord = ""
        Me.coldgvSessionListWrite.Width = 110
        '
        'coldgvSessionListSQL
        '
        Me.coldgvSessionListSQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvSessionListSQL.DataPropertyName = "SQL"
        Me.coldgvSessionListSQL.HeaderText = "F052"
        Me.coldgvSessionListSQL.Name = "coldgvSessionListSQL"
        Me.coldgvSessionListSQL.ReadOnly = True
        '
        'grpLockInfo
        '
        Me.grpLockInfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpLockInfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpLockInfo.BackColor = System.Drawing.Color.Black
        Me.grpLockInfo.Controls.Add(Me.dgvLock)
        Me.grpLockInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.RightBottom = 0
        Me.grpLockInfo.EdgeRound = Edges2
        Me.grpLockInfo.FillColor = System.Drawing.Color.Black
        Me.grpLockInfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.grpLockInfo.Icon = CType(resources.GetObject("grpLockInfo.Icon"), System.Drawing.Icon)
        Me.grpLockInfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpLockInfo.LineWidth = 1
        Me.grpLockInfo.Location = New System.Drawing.Point(0, 0)
        Me.grpLockInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLockInfo.Name = "grpLockInfo"
        Me.grpLockInfo.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpLockInfo.Size = New System.Drawing.Size(1804, 406)
        Me.grpLockInfo.TabIndex = 12
        Me.grpLockInfo.TabStop = False
        Me.grpLockInfo.Text = "F077"
        Me.grpLockInfo.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpLockInfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpLockInfo.UseGraColor = False
        Me.grpLockInfo.UseRound = True
        Me.grpLockInfo.UseTitle = True
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
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvLockDB, Me.coldgvLockCtrlType, Me.coldgvLockCtrlTime, Me.colDgvLockBlockingPID, Me.colDgvLockBlockingUser, Me.colDgvLockBlockingQuery, Me.colDgvLockBlockedPID, Me.colDgvLockBlockedUser, Me.colDgvLockBlockedQuery, Me.colDgvLockMode, Me.colDgvLockElapse, Me.colDgvLockQueryStart, Me.colDgvLockXactStart})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLock.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvLock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLock.EnableHeadersVisualStyles = False
        Me.dgvLock.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvLock.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvLock.ImageList = Nothing
        Me.dgvLock.Location = New System.Drawing.Point(3, 31)
        Me.dgvLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLock.MultiSelect = False
        Me.dgvLock.Name = "dgvLock"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
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
        'coldgvLockCtrlType
        '
        Me.coldgvLockCtrlType.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvLockCtrlType.FillWeight = 64.0!
        Me.coldgvLockCtrlType.HeaderText = "F252"
        Me.coldgvLockCtrlType.Name = "coldgvLockCtrlType"
        Me.coldgvLockCtrlType.ReadOnly = True
        Me.coldgvLockCtrlType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coldgvLockCtrlTime
        '
        Me.coldgvLockCtrlTime.DataPropertyName = "CONTROL_TIME"
        DataGridViewCellStyle12.Format = "yyyy-MM-dd HH:mm:ss"
        Me.coldgvLockCtrlTime.DefaultCellStyle = DataGridViewCellStyle12
        Me.coldgvLockCtrlTime.FillWeight = 160.0!
        Me.coldgvLockCtrlTime.HeaderText = "F253"
        Me.coldgvLockCtrlTime.Name = "coldgvLockCtrlTime"
        Me.coldgvLockCtrlTime.ReadOnly = True
        Me.coldgvLockCtrlTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.grpSessionLockHist, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.tlpMain.Location = New System.Drawing.Point(2, 29)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.670529!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.32947!))
        Me.tlpMain.Size = New System.Drawing.Size(1822, 1059)
        Me.tlpMain.TabIndex = 11
        '
        'frmSessionLockHist
        '
        Me.BaseHeight = 1092
        Me.ClientSize = New System.Drawing.Size(1826, 1090)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSessionLockHist"
        Me.Controls.SetChildIndex(Me.tlpMain, 0)
        Me.grpSessionLockHist.ResumeLayout(False)
        Me.grpSessionLockHist.PerformLayout()
        Me.tlpBottom.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.grpSession.ResumeLayout(False)
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLockInfo.ResumeLayout(False)
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents grpSessionLockHist As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents grpLockInfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvLock As AdvancedDataGridView.TreeGridView
    Friend WithEvents grpSession As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvSessionList As eXperDB.BaseControls.DataGridView
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents coldgvSessionCtrlType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionCtrlTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListDB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListCpuUsage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListStTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListElapsedTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents coldgvSessionListStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListClient As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListApp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvSessionListRead As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvSessionListWrite As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvSessionListSQL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockDB As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents coldgvLockCtrlType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLockCtrlTime As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents cmbType As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblType As eXperDB.BaseControls.Label
    Friend WithEvents txtSQL As eXperDB.BaseControls.TextBox
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDatabase As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents lblSQL As eXperDB.BaseControls.Label
    Friend WithEvents txtDatabase As eXperDB.BaseControls.TextBox

End Class
