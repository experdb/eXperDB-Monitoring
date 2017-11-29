<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogView))
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.spnlMain = New System.Windows.Forms.SplitContainer()
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblTitle = New eXperDB.BaseControls.Label()
        Me.grpLogInfo = New eXperDB.BaseControls.GroupBox()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.tlpTop = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpLogFileList = New eXperDB.BaseControls.GroupBox()
        Me.lblRefreshTime = New eXperDB.BaseControls.Label()
        Me.btnRefresh = New eXperDB.BaseControls.Button()
        Me.dgvLogFileList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvLogFileListName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLogFileListTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLogFileListSize = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.grpLogview = New eXperDB.BaseControls.GroupBox()
        Me.dgvLogData = New eXperDB.BaseControls.DataGridView()
        Me.coldgvLogData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblLogReadUnit = New eXperDB.BaseControls.Label()
        Me.btnMore = New eXperDB.BaseControls.Button()
        Me.cboLogReadUnit = New eXperDB.BaseControls.ComboBox()
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlMain.Panel1.SuspendLayout()
        Me.spnlMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.grpLogInfo.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.grpLogFileList.SuspendLayout()
        CType(Me.dgvLogFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLogview.SuspendLayout()
        CType(Me.dgvLogData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'spnlMain
        '
        Me.spnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spnlMain.Font = New System.Drawing.Font("Gulim", 12.38785!)
        Me.spnlMain.Location = New System.Drawing.Point(2, 33)
        Me.spnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnlMain.Name = "spnlMain"
        Me.spnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spnlMain.Panel1
        '
        Me.spnlMain.Panel1.Controls.Add(Me.tlpMain)
        Me.spnlMain.Panel1.Font = New System.Drawing.Font("Gulim", 12.38785!)
        '
        'spnlMain.Panel2
        '
        Me.spnlMain.Panel2.Font = New System.Drawing.Font("Gulim", 1.0!)
        Me.spnlMain.Size = New System.Drawing.Size(1822, 1049)
        Me.spnlMain.SplitterDistance = 1019
        Me.spnlMain.SplitterWidth = 5
        Me.spnlMain.TabIndex = 11
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.lblTitle, 0, 0)
        Me.tlpMain.Controls.Add(Me.grpLogInfo, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Gulim", 15.16822!)
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.670529!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.32947!))
        Me.tlpMain.Size = New System.Drawing.Size(1822, 1019)
        Me.tlpMain.TabIndex = 11
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.FixedHeight = False
        Me.lblTitle.FixedWidth = False
        Me.lblTitle.Font = New System.Drawing.Font("Gulim", 14.20626!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(3, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1816, 37)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "lblTitle"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpLogInfo
        '
        Me.grpLogInfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpLogInfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpLogInfo.BackColor = System.Drawing.Color.Black
        Me.grpLogInfo.Controls.Add(Me.btnExcel)
        Me.grpLogInfo.Controls.Add(Me.tlpTop)
        Me.grpLogInfo.Controls.Add(Me.tlpBottom)
        Me.grpLogInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges3.LeftBottom = 0
        Edges3.LeftTop = 20
        Edges3.RightBottom = 0
        Edges3.RightTop = 20
        Me.grpLogInfo.EdgeRound = Edges3
        Me.grpLogInfo.FillColor = System.Drawing.Color.Black
        Me.grpLogInfo.Font = New System.Drawing.Font("Gulim", 3.227603!)
        Me.grpLogInfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpLogInfo.LineWidth = 1
        Me.grpLogInfo.Location = New System.Drawing.Point(3, 41)
        Me.grpLogInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLogInfo.Name = "grpLogInfo"
        Me.grpLogInfo.Padding = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.grpLogInfo.Size = New System.Drawing.Size(1816, 974)
        Me.grpLogInfo.TabIndex = 1
        Me.grpLogInfo.TabStop = False
        Me.grpLogInfo.Text = "F138"
        Me.grpLogInfo.TitleFont = New System.Drawing.Font("Gulim", 1.091719!)
        Me.grpLogInfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpLogInfo.UseGraColor = True
        Me.grpLogInfo.UseRound = True
        Me.grpLogInfo.UseTitle = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 15.48481!)
        Me.btnExcel.ForeColor = System.Drawing.Color.LightGray
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(1499, -18)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(102, 31)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "F142"
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseRound = True
        Me.btnExcel.UseVisualStyleBackColor = False
        Me.btnExcel.Visible = False
        '
        'tlpTop
        '
        Me.tlpTop.BackColor = System.Drawing.Color.Transparent
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.Controls.Add(Me.grpLogFileList, 0, 0)
        Me.tlpTop.Controls.Add(Me.grpLogview, 1, 0)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Font = New System.Drawing.Font("Gulim", 15.16822!)
        Me.tlpTop.Location = New System.Drawing.Point(3, 8)
        Me.tlpTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.Size = New System.Drawing.Size(1810, 923)
        Me.tlpTop.TabIndex = 0
        '
        'grpLogFileList
        '
        Me.grpLogFileList.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpLogFileList.AlignString = System.Drawing.StringAlignment.Near
        Me.grpLogFileList.BackColor = System.Drawing.Color.Black
        Me.grpLogFileList.Controls.Add(Me.lblRefreshTime)
        Me.grpLogFileList.Controls.Add(Me.btnRefresh)
        Me.grpLogFileList.Controls.Add(Me.dgvLogFileList)
        Me.grpLogFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.LeftTop = 20
        Edges1.RightBottom = 0
        Edges1.RightTop = 20
        Me.grpLogFileList.EdgeRound = Edges1
        Me.grpLogFileList.FillColor = System.Drawing.Color.Black
        Me.grpLogFileList.Font = New System.Drawing.Font("Gulim", 12.3562!)
        Me.grpLogFileList.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpLogFileList.LineWidth = 1
        Me.grpLogFileList.Location = New System.Drawing.Point(3, 4)
        Me.grpLogFileList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLogFileList.Name = "grpLogFileList"
        Me.grpLogFileList.Padding = New System.Windows.Forms.Padding(3, 13, 3, 3)
        Me.grpLogFileList.Size = New System.Drawing.Size(364, 915)
        Me.grpLogFileList.TabIndex = 3
        Me.grpLogFileList.TabStop = False
        Me.grpLogFileList.Text = "F235"
        Me.grpLogFileList.TitleFont = New System.Drawing.Font("Gulim", 13.19153!, System.Drawing.FontStyle.Bold)
        Me.grpLogFileList.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpLogFileList.UseGraColor = True
        Me.grpLogFileList.UseRound = True
        Me.grpLogFileList.UseTitle = True
        '
        'lblRefreshTime
        '
        Me.lblRefreshTime.BackColor = System.Drawing.Color.Transparent
        Me.lblRefreshTime.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblRefreshTime.FixedHeight = False
        Me.lblRefreshTime.FixedWidth = False
        Me.lblRefreshTime.Font = New System.Drawing.Font("Gulim", 12.3562!)
        Me.lblRefreshTime.ForeColor = System.Drawing.Color.DarkGray
        Me.lblRefreshTime.Location = New System.Drawing.Point(151, 9)
        Me.lblRefreshTime.Name = "lblRefreshTime"
        Me.lblRefreshTime.Size = New System.Drawing.Size(229, 26)
        Me.lblRefreshTime.TabIndex = 2
        Me.lblRefreshTime.Text = "-"
        Me.lblRefreshTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblRefreshTime.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.FixedHeight = False
        Me.btnRefresh.FixedWidth = False
        Me.btnRefresh.Font = New System.Drawing.Font("Webdings", 12.01656!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.LightGray
        Me.btnRefresh.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(323, 3)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Radius = 5
        Me.btnRefresh.Size = New System.Drawing.Size(38, 31)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "q"
        Me.btnRefresh.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.UseRound = True
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dgvLogFileList
        '
        Me.dgvLogFileList.AllowUserToAddRows = False
        Me.dgvLogFileList.AllowUserToDeleteRows = False
        Me.dgvLogFileList.AllowUserToOrderColumns = True
        Me.dgvLogFileList.AllowUserToResizeRows = False
        Me.dgvLogFileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLogFileList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLogFileList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogFileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 12.38785!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogFileList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLogFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogFileList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvLogFileListName, Me.coldgvLogFileListTime, Me.coldgvLogFileListSize})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 12.38785!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogFileList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLogFileList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogFileList.EnableHeadersVisualStyles = False
        Me.dgvLogFileList.Font = New System.Drawing.Font("Gulim", 12.38785!)
        Me.dgvLogFileList.GridColor = System.Drawing.Color.Black
        Me.dgvLogFileList.Location = New System.Drawing.Point(3, 37)
        Me.dgvLogFileList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLogFileList.MultiSelect = False
        Me.dgvLogFileList.Name = "dgvLogFileList"
        Me.dgvLogFileList.RowHeadersVisible = False
        Me.dgvLogFileList.RowTemplate.Height = 23
        Me.dgvLogFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogFileList.Size = New System.Drawing.Size(358, 875)
        Me.dgvLogFileList.TabIndex = 12
        Me.dgvLogFileList.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvLogFileList.UseTagValueMatchColor = False
        '
        'coldgvLogFileListName
        '
        Me.coldgvLogFileListName.DataPropertyName = "LOGNAME"
        Me.coldgvLogFileListName.HeaderText = "F237"
        Me.coldgvLogFileListName.Name = "coldgvLogFileListName"
        Me.coldgvLogFileListName.ReadOnly = True
        Me.coldgvLogFileListName.Visible = False
        Me.coldgvLogFileListName.Width = 81
        '
        'coldgvLogFileListTime
        '
        Me.coldgvLogFileListTime.DataPropertyName = "LOGTIME"
        Me.coldgvLogFileListTime.HeaderText = "F237"
        Me.coldgvLogFileListTime.Name = "coldgvLogFileListTime"
        Me.coldgvLogFileListTime.ReadOnly = True
        Me.coldgvLogFileListTime.Width = 81
        '
        'coldgvLogFileListSize
        '
        Me.coldgvLogFileListSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvLogFileListSize.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.Bytes
        Me.coldgvLogFileListSize.DataPropertyName = "LOGLENGTH"
        DataGridViewCellStyle2.Format = "N1"
        Me.coldgvLogFileListSize.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvLogFileListSize.HeaderText = "F238"
        Me.coldgvLogFileListSize.HeaderWord = ""
        Me.coldgvLogFileListSize.Name = "coldgvLogFileListSize"
        Me.coldgvLogFileListSize.ReadOnly = True
        Me.coldgvLogFileListSize.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvLogFileListSize.ShowUnit = True
        Me.coldgvLogFileListSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvLogFileListSize.TailWord = ""
        Me.coldgvLogFileListSize.Width = 81
        '
        'grpLogview
        '
        Me.grpLogview.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpLogview.AlignString = System.Drawing.StringAlignment.Near
        Me.grpLogview.BackColor = System.Drawing.Color.Black
        Me.grpLogview.Controls.Add(Me.dgvLogData)
        Me.grpLogview.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.LeftTop = 20
        Edges2.RightBottom = 0
        Edges2.RightTop = 20
        Me.grpLogview.EdgeRound = Edges2
        Me.grpLogview.FillColor = System.Drawing.Color.Black
        Me.grpLogview.Font = New System.Drawing.Font("Gulim", 12.3562!)
        Me.grpLogview.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpLogview.LineWidth = 1
        Me.grpLogview.Location = New System.Drawing.Point(373, 4)
        Me.grpLogview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLogview.Name = "grpLogview"
        Me.grpLogview.Padding = New System.Windows.Forms.Padding(3, 13, 3, 3)
        Me.grpLogview.Size = New System.Drawing.Size(1434, 915)
        Me.grpLogview.TabIndex = 4
        Me.grpLogview.TabStop = False
        Me.grpLogview.Text = "F236"
        Me.grpLogview.TitleFont = New System.Drawing.Font("Gulim", 13.19153!, System.Drawing.FontStyle.Bold)
        Me.grpLogview.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpLogview.UseGraColor = True
        Me.grpLogview.UseRound = True
        Me.grpLogview.UseTitle = True
        '
        'dgvLogData
        '
        Me.dgvLogData.AllowUserToAddRows = False
        Me.dgvLogData.AllowUserToDeleteRows = False
        Me.dgvLogData.AllowUserToOrderColumns = True
        Me.dgvLogData.AllowUserToResizeRows = False
        Me.dgvLogData.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLogData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 12.38785!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvLogData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvLogData})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 12.38785!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLogData.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvLogData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLogData.EnableHeadersVisualStyles = False
        Me.dgvLogData.Font = New System.Drawing.Font("Gulim", 12.38785!)
        Me.dgvLogData.GridColor = System.Drawing.Color.Black
        Me.dgvLogData.Location = New System.Drawing.Point(3, 37)
        Me.dgvLogData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLogData.Name = "dgvLogData"
        Me.dgvLogData.RowHeadersVisible = False
        Me.dgvLogData.RowTemplate.Height = 23
        Me.dgvLogData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogData.Size = New System.Drawing.Size(1428, 875)
        Me.dgvLogData.TabIndex = 13
        Me.dgvLogData.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvLogData.UseTagValueMatchColor = False
        '
        'coldgvLogData
        '
        Me.coldgvLogData.DataPropertyName = "LOGNAME"
        Me.coldgvLogData.HeaderText = "F239"
        Me.coldgvLogData.Name = "coldgvLogData"
        Me.coldgvLogData.ReadOnly = True
        Me.coldgvLogData.Width = 81
        '
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Transparent
        Me.tlpBottom.ColumnCount = 5
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.49612!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.50387!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171.0!))
        Me.tlpBottom.Controls.Add(Me.lblLogReadUnit, 2, 0)
        Me.tlpBottom.Controls.Add(Me.btnMore, 4, 0)
        Me.tlpBottom.Controls.Add(Me.cboLogReadUnit, 3, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 15.16822!)
        Me.tlpBottom.Location = New System.Drawing.Point(3, 931)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1810, 40)
        Me.tlpBottom.TabIndex = 0
        '
        'lblLogReadUnit
        '
        Me.lblLogReadUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblLogReadUnit.BackColor = System.Drawing.Color.Black
        Me.lblLogReadUnit.FixedHeight = False
        Me.lblLogReadUnit.FixedWidth = False
        Me.lblLogReadUnit.Font = New System.Drawing.Font("Gulim", 12.36535!)
        Me.lblLogReadUnit.ForeColor = System.Drawing.Color.White
        Me.lblLogReadUnit.Location = New System.Drawing.Point(1339, 9)
        Me.lblLogReadUnit.Name = "lblLogReadUnit"
        Me.lblLogReadUnit.Size = New System.Drawing.Size(136, 21)
        Me.lblLogReadUnit.TabIndex = 17
        Me.lblLogReadUnit.Text = "F241"
        '
        'btnMore
        '
        Me.btnMore.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMore.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnMore.FixedHeight = False
        Me.btnMore.FixedWidth = False
        Me.btnMore.Font = New System.Drawing.Font("Gulim", 12.36535!)
        Me.btnMore.ForeColor = System.Drawing.Color.LightGray
        Me.btnMore.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMore.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnMore.Location = New System.Drawing.Point(1641, 4)
        Me.btnMore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Radius = 5
        Me.btnMore.Size = New System.Drawing.Size(166, 32)
        Me.btnMore.TabIndex = 15
        Me.btnMore.Text = "F240"
        Me.btnMore.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMore.UseRound = True
        Me.btnMore.UseVisualStyleBackColor = False
        '
        'cboLogReadUnit
        '
        Me.cboLogReadUnit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLogReadUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cboLogReadUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLogReadUnit.Font = New System.Drawing.Font("Gulim", 12.36535!)
        Me.cboLogReadUnit.FormattingEnabled = True
        Me.cboLogReadUnit.Location = New System.Drawing.Point(1481, 5)
        Me.cboLogReadUnit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboLogReadUnit.Name = "cboLogReadUnit"
        Me.cboLogReadUnit.Necessary = False
        Me.cboLogReadUnit.Size = New System.Drawing.Size(150, 29)
        Me.cboLogReadUnit.StatusTip = ""
        Me.cboLogReadUnit.TabIndex = 15
        Me.cboLogReadUnit.ValueText = ""
        '
        'frmLogView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.BaseHeight = 1102
        Me.ClientSize = New System.Drawing.Size(1826, 1084)
        Me.Controls.Add(Me.spnlMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmLogView"
        Me.Controls.SetChildIndex(Me.spnlMain, 0)
        Me.spnlMain.Panel1.ResumeLayout(False)
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.grpLogInfo.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.grpLogFileList.ResumeLayout(False)
        CType(Me.dgvLogFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLogview.ResumeLayout(False)
        CType(Me.dgvLogData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents spnlMain As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblTitle As eXperDB.BaseControls.Label
    Friend WithEvents grpLogInfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents lblRefreshTime As eXperDB.BaseControls.Label
    Friend WithEvents btnRefresh As eXperDB.BaseControls.Button
    Friend WithEvents tlpTop As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents grpLogview As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvLogData As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvLogData As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpLogFileList As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvLogFileList As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvLogFileListName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLogFileListTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLogFileListSize As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents cboLogReadUnit As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnMore As eXperDB.BaseControls.Button
    Friend WithEvents lblLogReadUnit As eXperDB.BaseControls.Label

End Class
