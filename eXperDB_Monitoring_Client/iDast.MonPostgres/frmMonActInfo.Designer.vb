<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonActInfo
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
        Dim Edges5 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMonActInfo))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges4 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.colDgvLockDB = New AdvancedDataGridView.TreeGridColumn()
        Me.colDgvLockBlockingPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockingUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockingQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockBlockedQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockElapse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLOckLockMode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockQueryStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvLockXactStart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.spnlMain = New System.Windows.Forms.SplitContainer()
        Me.tlpMain = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpTableInfo = New eXperDB.BaseControls.GroupBox()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.lblRefreshTime = New eXperDB.BaseControls.Label()
        Me.btnRefresh = New eXperDB.BaseControls.Button()
        Me.tlpBottom = New eXperDB.BaseControls.TableLayoutPanel()
        Me.grpTblinfo = New eXperDB.BaseControls.GroupBox()
        Me.dgvTblinfo = New eXperDB.BaseControls.DataGridView()
        Me.coldgvTblinfoDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoTABLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoTABLESIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvTblinfoINDEXSIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvTblinfoINDEXCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoISTOAST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoSEQSCAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoINDEXSCAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoLIVETUPLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblinfoLASTVACUUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpTblSpaceInfo = New eXperDB.BaseControls.GroupBox()
        Me.dgvTblSpaceInfo = New eXperDB.BaseControls.DataGridView()
        Me.coldgvTblSpaceInfoFileSystem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblSpaceInfoDISKSIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvTblSpaceInfoDISKUSED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblSpaceInfoAvail = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvTblSpaceInfoMountPoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblSpaceInfoTABLESPACE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvTblSpaceInfoSIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvTblSpaceInfoLOCATION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpidxinfo = New eXperDB.BaseControls.GroupBox()
        Me.dgvIdxinfo = New eXperDB.BaseControls.DataGridView()
        Me.coldgvIdxinfoDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoINDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoTABLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoINDEXSIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvIdxinfoINDEXSCANCOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoUPDATEDTUPLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoDELETEDTUPLES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIdxinfoLiveTuples = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpDBinfo = New eXperDB.BaseControls.GroupBox()
        Me.dgvDBinfo = New eXperDB.BaseControls.DataGridView()
        Me.coldgvDBinfoDB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvDBinfoSIZE = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvDBinfoTABLECNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvDBinfoINDEXCNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvDBinfoDISKREAD = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvDBinfoBUFFERREAD = New eXperDB.Controls.DataGridViewDataSizeColumn()
        Me.coldgvDBinfoHITRATIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvLock = New AdvancedDataGridView.TreeGridView()
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spnlMain.Panel1.SuspendLayout()
        Me.spnlMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.grpTableInfo.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.grpTblinfo.SuspendLayout()
        CType(Me.dgvTblinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTblSpaceInfo.SuspendLayout()
        CType(Me.dgvTblSpaceInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpidxinfo.SuspendLayout()
        CType(Me.dgvIdxinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDBinfo.SuspendLayout()
        CType(Me.dgvDBinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDgvLockDB
        '
        Me.colDgvLockDB.DataPropertyName = "DB_NAME"
        Me.colDgvLockDB.DefaultNodeImage = Nothing
        Me.colDgvLockDB.HeaderText = "F104"
        Me.colDgvLockDB.Name = "colDgvLockDB"
        Me.colDgvLockDB.ReadOnly = True
        Me.colDgvLockDB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockDB.Width = 47
        '
        'colDgvLockBlockingPID
        '
        Me.colDgvLockBlockingPID.DataPropertyName = "BLOCKING_PID"
        Me.colDgvLockBlockingPID.HeaderText = "F197"
        Me.colDgvLockBlockingPID.Name = "colDgvLockBlockingPID"
        Me.colDgvLockBlockingPID.ReadOnly = True
        Me.colDgvLockBlockingPID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockBlockingPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockingPID.Width = 46
        '
        'colDgvLockBlockingUser
        '
        Me.colDgvLockBlockingUser.DataPropertyName = "BLOCKING_USER"
        Me.colDgvLockBlockingUser.HeaderText = "F134"
        Me.colDgvLockBlockingUser.Name = "colDgvLockBlockingUser"
        Me.colDgvLockBlockingUser.ReadOnly = True
        Me.colDgvLockBlockingUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockingUser.Width = 47
        '
        'colDgvLockBlockingQuery
        '
        Me.colDgvLockBlockingQuery.DataPropertyName = "BLOCKING_QUERY"
        Me.colDgvLockBlockingQuery.HeaderText = "F084"
        Me.colDgvLockBlockingQuery.Name = "colDgvLockBlockingQuery"
        Me.colDgvLockBlockingQuery.ReadOnly = True
        Me.colDgvLockBlockingQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockingQuery.Width = 47
        '
        'colDgvLockBlockedPID
        '
        Me.colDgvLockBlockedPID.DataPropertyName = "BLOCKED_PID"
        Me.colDgvLockBlockedPID.HeaderText = "F195"
        Me.colDgvLockBlockedPID.Name = "colDgvLockBlockedPID"
        Me.colDgvLockBlockedPID.ReadOnly = True
        Me.colDgvLockBlockedPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockedPID.Width = 46
        '
        'colDgvLockBlockedUser
        '
        Me.colDgvLockBlockedUser.DataPropertyName = "BLOCKED_USER"
        Me.colDgvLockBlockedUser.HeaderText = "F196"
        Me.colDgvLockBlockedUser.Name = "colDgvLockBlockedUser"
        Me.colDgvLockBlockedUser.ReadOnly = True
        Me.colDgvLockBlockedUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockedUser.Width = 46
        '
        'colDgvLockBlockedQuery
        '
        Me.colDgvLockBlockedQuery.DataPropertyName = "BLOCKED_QUERY"
        Me.colDgvLockBlockedQuery.HeaderText = "F221"
        Me.colDgvLockBlockedQuery.Name = "colDgvLockBlockedQuery"
        Me.colDgvLockBlockedQuery.ReadOnly = True
        Me.colDgvLockBlockedQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockedQuery.Width = 46
        '
        'colDgvLockElapse
        '
        Me.colDgvLockElapse.DataPropertyName = "BLOCKED_DURATION"
        Me.colDgvLockElapse.HeaderText = "F135"
        Me.colDgvLockElapse.Name = "colDgvLockElapse"
        Me.colDgvLockElapse.ReadOnly = True
        Me.colDgvLockElapse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockElapse.Width = 46
        '
        'colDgvLOckLockMode
        '
        Me.colDgvLOckLockMode.DataPropertyName = "LOCK_MODE"
        Me.colDgvLOckLockMode.HeaderText = "F222"
        Me.colDgvLOckLockMode.Name = "colDgvLOckLockMode"
        Me.colDgvLOckLockMode.ReadOnly = True
        Me.colDgvLOckLockMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLOckLockMode.Width = 46
        '
        'colDgvLockQueryStart
        '
        Me.colDgvLockQueryStart.DataPropertyName = "QUERY_START"
        Me.colDgvLockQueryStart.HeaderText = "F223"
        Me.colDgvLockQueryStart.Name = "colDgvLockQueryStart"
        Me.colDgvLockQueryStart.ReadOnly = True
        Me.colDgvLockQueryStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockQueryStart.Width = 46
        '
        'colDgvLockXactStart
        '
        Me.colDgvLockXactStart.DataPropertyName = "XACT_START"
        Me.colDgvLockXactStart.HeaderText = "F224"
        Me.colDgvLockXactStart.Name = "colDgvLockXactStart"
        Me.colDgvLockXactStart.ReadOnly = True
        Me.colDgvLockXactStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockXactStart.Width = 47
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'spnlMain
        '
        Me.spnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spnlMain.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.spnlMain.Location = New System.Drawing.Point(2, 29)
        Me.spnlMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.spnlMain.Name = "spnlMain"
        Me.spnlMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spnlMain.Panel1
        '
        Me.spnlMain.Panel1.Controls.Add(Me.tlpMain)
        Me.spnlMain.Panel1.Font = New System.Drawing.Font("Gulim", 10.0!)
        '
        'spnlMain.Panel2
        '
        Me.spnlMain.Panel2.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.spnlMain.Size = New System.Drawing.Size(1822, 1059)
        Me.spnlMain.SplitterDistance = 1029
        Me.spnlMain.SplitterWidth = 5
        Me.spnlMain.TabIndex = 11
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.grpTableInfo, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.670529!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 96.32947!))
        Me.tlpMain.Size = New System.Drawing.Size(1822, 1029)
        Me.tlpMain.TabIndex = 11
        '
        'grpTableInfo
        '
        Me.grpTableInfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpTableInfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpTableInfo.BackColor = System.Drawing.Color.Black
        Me.grpTableInfo.Controls.Add(Me.btnExcel)
        Me.grpTableInfo.Controls.Add(Me.lblRefreshTime)
        Me.grpTableInfo.Controls.Add(Me.btnRefresh)
        Me.grpTableInfo.Controls.Add(Me.tlpBottom)
        Me.grpTableInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges5.LeftBottom = 0
        Edges5.RightBottom = 0
        Me.grpTableInfo.EdgeRound = Edges5
        Me.grpTableInfo.FillColor = System.Drawing.Color.Black
        Me.grpTableInfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.grpTableInfo.Icon = Nothing
        Me.grpTableInfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpTableInfo.LineWidth = 1
        Me.grpTableInfo.Location = New System.Drawing.Point(3, 4)
        Me.grpTableInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTableInfo.Name = "grpTableInfo"
        Me.grpTableInfo.Padding = New System.Windows.Forms.Padding(3, 13, 3, 3)
        Me.tlpMain.SetRowSpan(Me.grpTableInfo, 2)
        Me.grpTableInfo.Size = New System.Drawing.Size(1816, 1021)
        Me.grpTableInfo.TabIndex = 1
        Me.grpTableInfo.TabStop = False
        Me.grpTableInfo.Text = "F138"
        Me.grpTableInfo.TitleFont = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Bold)
        Me.grpTableInfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpTableInfo.UseGraColor = False
        Me.grpTableInfo.UseRound = True
        Me.grpTableInfo.UseTitle = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackColor = System.Drawing.Color.Black
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.btnExcel.ForeColor = System.Drawing.Color.LightGray
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(1704, 2)
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
        'lblRefreshTime
        '
        Me.lblRefreshTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRefreshTime.BackColor = System.Drawing.Color.Black
        Me.lblRefreshTime.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblRefreshTime.FixedHeight = False
        Me.lblRefreshTime.FixedWidth = False
        Me.lblRefreshTime.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.lblRefreshTime.ForeColor = System.Drawing.Color.DarkGray
        Me.lblRefreshTime.Location = New System.Drawing.Point(1424, 4)
        Me.lblRefreshTime.Name = "lblRefreshTime"
        Me.lblRefreshTime.Size = New System.Drawing.Size(229, 26)
        Me.lblRefreshTime.TabIndex = 2
        Me.lblRefreshTime.Text = "-"
        Me.lblRefreshTime.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.Black
        Me.btnRefresh.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnRefresh.FixedHeight = False
        Me.btnRefresh.FixedWidth = False
        Me.btnRefresh.Font = New System.Drawing.Font("Webdings", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.LightGray
        Me.btnRefresh.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnRefresh.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnRefresh.Location = New System.Drawing.Point(1659, 2)
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
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.Black
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Controls.Add(Me.grpTblinfo, 0, 1)
        Me.tlpBottom.Controls.Add(Me.grpTblSpaceInfo, 1, 0)
        Me.tlpBottom.Controls.Add(Me.grpidxinfo, 1, 1)
        Me.tlpBottom.Controls.Add(Me.grpDBinfo, 0, 0)
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.tlpBottom.Location = New System.Drawing.Point(3, 33)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 2
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(1810, 985)
        Me.tlpBottom.TabIndex = 0
        '
        'grpTblinfo
        '
        Me.grpTblinfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpTblinfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpTblinfo.BackColor = System.Drawing.Color.Black
        Me.grpTblinfo.Controls.Add(Me.dgvTblinfo)
        Me.grpTblinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.RightBottom = 0
        Me.grpTblinfo.EdgeRound = Edges1
        Me.grpTblinfo.FillColor = System.Drawing.Color.Black
        Me.grpTblinfo.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.grpTblinfo.Icon = CType(resources.GetObject("grpTblinfo.Icon"), System.Drawing.Icon)
        Me.grpTblinfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpTblinfo.LineWidth = 1
        Me.grpTblinfo.Location = New System.Drawing.Point(3, 496)
        Me.grpTblinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTblinfo.Name = "grpTblinfo"
        Me.grpTblinfo.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpTblinfo.Size = New System.Drawing.Size(899, 485)
        Me.grpTblinfo.TabIndex = 3
        Me.grpTblinfo.TabStop = False
        Me.grpTblinfo.Text = "F080"
        Me.grpTblinfo.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpTblinfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpTblinfo.UseGraColor = False
        Me.grpTblinfo.UseRound = True
        Me.grpTblinfo.UseTitle = True
        '
        'dgvTblinfo
        '
        Me.dgvTblinfo.AllowUserToAddRows = False
        Me.dgvTblinfo.AllowUserToDeleteRows = False
        Me.dgvTblinfo.AllowUserToOrderColumns = True
        Me.dgvTblinfo.AllowUserToResizeRows = False
        Me.dgvTblinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvTblinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTblinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTblinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTblinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTblinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvTblinfoDB, Me.coldgvTblinfoTABLE, Me.coldgvTblinfoTABLESIZE, Me.coldgvTblinfoINDEXSIZE, Me.coldgvTblinfoINDEXCNT, Me.coldgvTblinfoISTOAST, Me.coldgvTblinfoSEQSCAN, Me.coldgvTblinfoINDEXSCAN, Me.coldgvTblinfoLIVETUPLES, Me.coldgvTblinfoLASTVACUUM})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTblinfo.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTblinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTblinfo.EnableHeadersVisualStyles = False
        Me.dgvTblinfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvTblinfo.GridColor = System.Drawing.Color.Black
        Me.dgvTblinfo.Location = New System.Drawing.Point(3, 38)
        Me.dgvTblinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTblinfo.MultiSelect = False
        Me.dgvTblinfo.Name = "dgvTblinfo"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTblinfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTblinfo.RowHeadersVisible = False
        Me.dgvTblinfo.RowTemplate.Height = 23
        Me.dgvTblinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTblinfo.Size = New System.Drawing.Size(893, 444)
        Me.dgvTblinfo.TabIndex = 12
        Me.dgvTblinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvTblinfo.UseTagValueMatchColor = False
        '
        'coldgvTblinfoDB
        '
        Me.coldgvTblinfoDB.DataPropertyName = "DB"
        Me.coldgvTblinfoDB.HeaderText = "F116"
        Me.coldgvTblinfoDB.Name = "coldgvTblinfoDB"
        Me.coldgvTblinfoDB.ReadOnly = True
        Me.coldgvTblinfoDB.Width = 76
        '
        'coldgvTblinfoTABLE
        '
        Me.coldgvTblinfoTABLE.DataPropertyName = "TABLE"
        Me.coldgvTblinfoTABLE.HeaderText = "F117"
        Me.coldgvTblinfoTABLE.Name = "coldgvTblinfoTABLE"
        Me.coldgvTblinfoTABLE.ReadOnly = True
        Me.coldgvTblinfoTABLE.Width = 76
        '
        'coldgvTblinfoTABLESIZE
        '
        Me.coldgvTblinfoTABLESIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvTblinfoTABLESIZE.DataPropertyName = "SIZE"
        DataGridViewCellStyle2.Format = "N1"
        Me.coldgvTblinfoTABLESIZE.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvTblinfoTABLESIZE.HeaderText = "F118"
        Me.coldgvTblinfoTABLESIZE.HeaderWord = ""
        Me.coldgvTblinfoTABLESIZE.Name = "coldgvTblinfoTABLESIZE"
        Me.coldgvTblinfoTABLESIZE.ReadOnly = True
        Me.coldgvTblinfoTABLESIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvTblinfoTABLESIZE.ShowUnit = True
        Me.coldgvTblinfoTABLESIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvTblinfoTABLESIZE.TailWord = ""
        Me.coldgvTblinfoTABLESIZE.Width = 76
        '
        'coldgvTblinfoINDEXSIZE
        '
        Me.coldgvTblinfoINDEXSIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvTblinfoINDEXSIZE.DataPropertyName = "INDEX SIZE"
        DataGridViewCellStyle3.Format = "N"
        Me.coldgvTblinfoINDEXSIZE.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvTblinfoINDEXSIZE.HeaderText = "F119"
        Me.coldgvTblinfoINDEXSIZE.HeaderWord = ""
        Me.coldgvTblinfoINDEXSIZE.Name = "coldgvTblinfoINDEXSIZE"
        Me.coldgvTblinfoINDEXSIZE.ReadOnly = True
        Me.coldgvTblinfoINDEXSIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvTblinfoINDEXSIZE.ShowUnit = True
        Me.coldgvTblinfoINDEXSIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvTblinfoINDEXSIZE.TailWord = ""
        Me.coldgvTblinfoINDEXSIZE.Width = 76
        '
        'coldgvTblinfoINDEXCNT
        '
        Me.coldgvTblinfoINDEXCNT.DataPropertyName = "INDEX CNT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.coldgvTblinfoINDEXCNT.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvTblinfoINDEXCNT.HeaderText = "F120"
        Me.coldgvTblinfoINDEXCNT.Name = "coldgvTblinfoINDEXCNT"
        Me.coldgvTblinfoINDEXCNT.ReadOnly = True
        Me.coldgvTblinfoINDEXCNT.Width = 76
        '
        'coldgvTblinfoISTOAST
        '
        Me.coldgvTblinfoISTOAST.DataPropertyName = "IS_TOAST"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        Me.coldgvTblinfoISTOAST.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvTblinfoISTOAST.HeaderText = "F121"
        Me.coldgvTblinfoISTOAST.Name = "coldgvTblinfoISTOAST"
        Me.coldgvTblinfoISTOAST.ReadOnly = True
        Me.coldgvTblinfoISTOAST.Width = 76
        '
        'coldgvTblinfoSEQSCAN
        '
        Me.coldgvTblinfoSEQSCAN.DataPropertyName = "SEQ SCAN COUNT"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.coldgvTblinfoSEQSCAN.DefaultCellStyle = DataGridViewCellStyle6
        Me.coldgvTblinfoSEQSCAN.HeaderText = "F122"
        Me.coldgvTblinfoSEQSCAN.Name = "coldgvTblinfoSEQSCAN"
        Me.coldgvTblinfoSEQSCAN.ReadOnly = True
        Me.coldgvTblinfoSEQSCAN.Width = 76
        '
        'coldgvTblinfoINDEXSCAN
        '
        Me.coldgvTblinfoINDEXSCAN.DataPropertyName = "INDEX SCAN COUNT"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.coldgvTblinfoINDEXSCAN.DefaultCellStyle = DataGridViewCellStyle7
        Me.coldgvTblinfoINDEXSCAN.HeaderText = "F123"
        Me.coldgvTblinfoINDEXSCAN.Name = "coldgvTblinfoINDEXSCAN"
        Me.coldgvTblinfoINDEXSCAN.ReadOnly = True
        Me.coldgvTblinfoINDEXSCAN.Width = 76
        '
        'coldgvTblinfoLIVETUPLES
        '
        Me.coldgvTblinfoLIVETUPLES.DataPropertyName = "LIVE TUPLES"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.coldgvTblinfoLIVETUPLES.DefaultCellStyle = DataGridViewCellStyle8
        Me.coldgvTblinfoLIVETUPLES.HeaderText = "F124"
        Me.coldgvTblinfoLIVETUPLES.Name = "coldgvTblinfoLIVETUPLES"
        Me.coldgvTblinfoLIVETUPLES.ReadOnly = True
        Me.coldgvTblinfoLIVETUPLES.Width = 76
        '
        'coldgvTblinfoLASTVACUUM
        '
        Me.coldgvTblinfoLASTVACUUM.DataPropertyName = "LAST VACUUM"
        DataGridViewCellStyle9.Format = "yyyy-MM-dd HH:mm:ss"
        Me.coldgvTblinfoLASTVACUUM.DefaultCellStyle = DataGridViewCellStyle9
        Me.coldgvTblinfoLASTVACUUM.HeaderText = "F125"
        Me.coldgvTblinfoLASTVACUUM.Name = "coldgvTblinfoLASTVACUUM"
        Me.coldgvTblinfoLASTVACUUM.ReadOnly = True
        Me.coldgvTblinfoLASTVACUUM.Width = 76
        '
        'grpTblSpaceInfo
        '
        Me.grpTblSpaceInfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpTblSpaceInfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpTblSpaceInfo.BackColor = System.Drawing.Color.Black
        Me.grpTblSpaceInfo.Controls.Add(Me.dgvTblSpaceInfo)
        Me.grpTblSpaceInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges2.LeftBottom = 0
        Edges2.RightBottom = 0
        Me.grpTblSpaceInfo.EdgeRound = Edges2
        Me.grpTblSpaceInfo.FillColor = System.Drawing.Color.Black
        Me.grpTblSpaceInfo.Font = New System.Drawing.Font("Gulim", 14.03751!)
        Me.grpTblSpaceInfo.Icon = CType(resources.GetObject("grpTblSpaceInfo.Icon"), System.Drawing.Icon)
        Me.grpTblSpaceInfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpTblSpaceInfo.LineWidth = 1
        Me.grpTblSpaceInfo.Location = New System.Drawing.Point(908, 4)
        Me.grpTblSpaceInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpTblSpaceInfo.Name = "grpTblSpaceInfo"
        Me.grpTblSpaceInfo.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpTblSpaceInfo.Size = New System.Drawing.Size(899, 484)
        Me.grpTblSpaceInfo.TabIndex = 1
        Me.grpTblSpaceInfo.TabStop = False
        Me.grpTblSpaceInfo.Text = "F079"
        Me.grpTblSpaceInfo.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpTblSpaceInfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpTblSpaceInfo.UseGraColor = False
        Me.grpTblSpaceInfo.UseRound = True
        Me.grpTblSpaceInfo.UseTitle = True
        '
        'dgvTblSpaceInfo
        '
        Me.dgvTblSpaceInfo.AllowUserToAddRows = False
        Me.dgvTblSpaceInfo.AllowUserToDeleteRows = False
        Me.dgvTblSpaceInfo.AllowUserToOrderColumns = True
        Me.dgvTblSpaceInfo.AllowUserToResizeRows = False
        Me.dgvTblSpaceInfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvTblSpaceInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTblSpaceInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTblSpaceInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvTblSpaceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTblSpaceInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvTblSpaceInfoFileSystem, Me.coldgvTblSpaceInfoDISKSIZE, Me.coldgvTblSpaceInfoDISKUSED, Me.coldgvTblSpaceInfoAvail, Me.coldgvTblSpaceInfoMountPoint, Me.coldgvTblSpaceInfoTABLESPACE, Me.coldgvTblSpaceInfoSIZE, Me.coldgvTblSpaceInfoLOCATION})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTblSpaceInfo.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvTblSpaceInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTblSpaceInfo.EnableHeadersVisualStyles = False
        Me.dgvTblSpaceInfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvTblSpaceInfo.GridColor = System.Drawing.Color.Black
        Me.dgvTblSpaceInfo.Location = New System.Drawing.Point(3, 38)
        Me.dgvTblSpaceInfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvTblSpaceInfo.MultiSelect = False
        Me.dgvTblSpaceInfo.Name = "dgvTblSpaceInfo"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTblSpaceInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvTblSpaceInfo.RowHeadersVisible = False
        Me.dgvTblSpaceInfo.RowTemplate.Height = 23
        Me.dgvTblSpaceInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTblSpaceInfo.Size = New System.Drawing.Size(893, 443)
        Me.dgvTblSpaceInfo.TabIndex = 12
        Me.dgvTblSpaceInfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvTblSpaceInfo.UseTagValueMatchColor = False
        '
        'coldgvTblSpaceInfoFileSystem
        '
        Me.coldgvTblSpaceInfoFileSystem.HeaderText = "F271"
        Me.coldgvTblSpaceInfoFileSystem.Name = "coldgvTblSpaceInfoFileSystem"
        Me.coldgvTblSpaceInfoFileSystem.ReadOnly = True
        '
        'coldgvTblSpaceInfoDISKSIZE
        '
        Me.coldgvTblSpaceInfoDISKSIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvTblSpaceInfoDISKSIZE.DataPropertyName = "DISK SIZE"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N1"
        Me.coldgvTblSpaceInfoDISKSIZE.DefaultCellStyle = DataGridViewCellStyle13
        Me.coldgvTblSpaceInfoDISKSIZE.HeaderText = "F114"
        Me.coldgvTblSpaceInfoDISKSIZE.HeaderWord = ""
        Me.coldgvTblSpaceInfoDISKSIZE.Name = "coldgvTblSpaceInfoDISKSIZE"
        Me.coldgvTblSpaceInfoDISKSIZE.ReadOnly = True
        Me.coldgvTblSpaceInfoDISKSIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvTblSpaceInfoDISKSIZE.ShowUnit = True
        Me.coldgvTblSpaceInfoDISKSIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvTblSpaceInfoDISKSIZE.TailWord = ""
        Me.coldgvTblSpaceInfoDISKSIZE.Width = 76
        '
        'coldgvTblSpaceInfoDISKUSED
        '
        Me.coldgvTblSpaceInfoDISKUSED.DataPropertyName = "DISK USED"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "P"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.coldgvTblSpaceInfoDISKUSED.DefaultCellStyle = DataGridViewCellStyle14
        Me.coldgvTblSpaceInfoDISKUSED.HeaderText = "F115"
        Me.coldgvTblSpaceInfoDISKUSED.Name = "coldgvTblSpaceInfoDISKUSED"
        Me.coldgvTblSpaceInfoDISKUSED.ReadOnly = True
        Me.coldgvTblSpaceInfoDISKUSED.Width = 76
        '
        'coldgvTblSpaceInfoAvail
        '
        Me.coldgvTblSpaceInfoAvail.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N1"
        Me.coldgvTblSpaceInfoAvail.DefaultCellStyle = DataGridViewCellStyle15
        Me.coldgvTblSpaceInfoAvail.HeaderText = "F272"
        Me.coldgvTblSpaceInfoAvail.HeaderWord = ""
        Me.coldgvTblSpaceInfoAvail.Name = "coldgvTblSpaceInfoAvail"
        Me.coldgvTblSpaceInfoAvail.ReadOnly = True
        Me.coldgvTblSpaceInfoAvail.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvTblSpaceInfoAvail.ShowUnit = True
        Me.coldgvTblSpaceInfoAvail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvTblSpaceInfoAvail.TailWord = ""
        Me.coldgvTblSpaceInfoAvail.Width = 76
        '
        'coldgvTblSpaceInfoMountPoint
        '
        Me.coldgvTblSpaceInfoMountPoint.HeaderText = "F273"
        Me.coldgvTblSpaceInfoMountPoint.Name = "coldgvTblSpaceInfoMountPoint"
        Me.coldgvTblSpaceInfoMountPoint.ReadOnly = True
        '
        'coldgvTblSpaceInfoTABLESPACE
        '
        Me.coldgvTblSpaceInfoTABLESPACE.DataPropertyName = "TABLESPACE"
        Me.coldgvTblSpaceInfoTABLESPACE.HeaderText = "F111"
        Me.coldgvTblSpaceInfoTABLESPACE.Name = "coldgvTblSpaceInfoTABLESPACE"
        Me.coldgvTblSpaceInfoTABLESPACE.ReadOnly = True
        Me.coldgvTblSpaceInfoTABLESPACE.Width = 76
        '
        'coldgvTblSpaceInfoSIZE
        '
        Me.coldgvTblSpaceInfoSIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvTblSpaceInfoSIZE.DataPropertyName = "SIZE"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N1"
        Me.coldgvTblSpaceInfoSIZE.DefaultCellStyle = DataGridViewCellStyle16
        Me.coldgvTblSpaceInfoSIZE.HeaderText = "F112"
        Me.coldgvTblSpaceInfoSIZE.HeaderWord = ""
        Me.coldgvTblSpaceInfoSIZE.Name = "coldgvTblSpaceInfoSIZE"
        Me.coldgvTblSpaceInfoSIZE.ReadOnly = True
        Me.coldgvTblSpaceInfoSIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvTblSpaceInfoSIZE.ShowUnit = True
        Me.coldgvTblSpaceInfoSIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvTblSpaceInfoSIZE.TailWord = ""
        Me.coldgvTblSpaceInfoSIZE.Width = 76
        '
        'coldgvTblSpaceInfoLOCATION
        '
        Me.coldgvTblSpaceInfoLOCATION.DataPropertyName = "LOCATION"
        Me.coldgvTblSpaceInfoLOCATION.HeaderText = "F113"
        Me.coldgvTblSpaceInfoLOCATION.Name = "coldgvTblSpaceInfoLOCATION"
        Me.coldgvTblSpaceInfoLOCATION.ReadOnly = True
        Me.coldgvTblSpaceInfoLOCATION.Width = 76
        '
        'grpidxinfo
        '
        Me.grpidxinfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpidxinfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpidxinfo.BackColor = System.Drawing.Color.Black
        Me.grpidxinfo.Controls.Add(Me.dgvIdxinfo)
        Me.grpidxinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges3.LeftBottom = 0
        Edges3.RightBottom = 0
        Me.grpidxinfo.EdgeRound = Edges3
        Me.grpidxinfo.FillColor = System.Drawing.Color.Black
        Me.grpidxinfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.grpidxinfo.Icon = CType(resources.GetObject("grpidxinfo.Icon"), System.Drawing.Icon)
        Me.grpidxinfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpidxinfo.LineWidth = 1
        Me.grpidxinfo.Location = New System.Drawing.Point(908, 496)
        Me.grpidxinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpidxinfo.Name = "grpidxinfo"
        Me.grpidxinfo.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpidxinfo.Size = New System.Drawing.Size(899, 485)
        Me.grpidxinfo.TabIndex = 4
        Me.grpidxinfo.TabStop = False
        Me.grpidxinfo.Text = "F081"
        Me.grpidxinfo.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpidxinfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpidxinfo.UseGraColor = False
        Me.grpidxinfo.UseRound = True
        Me.grpidxinfo.UseTitle = True
        '
        'dgvIdxinfo
        '
        Me.dgvIdxinfo.AllowUserToAddRows = False
        Me.dgvIdxinfo.AllowUserToDeleteRows = False
        Me.dgvIdxinfo.AllowUserToOrderColumns = True
        Me.dgvIdxinfo.AllowUserToResizeRows = False
        Me.dgvIdxinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvIdxinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvIdxinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIdxinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvIdxinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIdxinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvIdxinfoDB, Me.coldgvIdxinfoINDEX, Me.coldgvIdxinfoTABLE, Me.coldgvIdxinfoINDEXSIZE, Me.coldgvIdxinfoINDEXSCANCOUNT, Me.coldgvIdxinfoINDEXFETCHEDTUPLES, Me.coldgvIdxinfoUPDATEDTUPLES, Me.coldgvIdxinfoDELETEDTUPLES, Me.coldgvIdxinfoLiveTuples})
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIdxinfo.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgvIdxinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvIdxinfo.EnableHeadersVisualStyles = False
        Me.dgvIdxinfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvIdxinfo.GridColor = System.Drawing.Color.Black
        Me.dgvIdxinfo.Location = New System.Drawing.Point(3, 31)
        Me.dgvIdxinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvIdxinfo.MultiSelect = False
        Me.dgvIdxinfo.Name = "dgvIdxinfo"
        Me.dgvIdxinfo.RowHeadersVisible = False
        Me.dgvIdxinfo.RowTemplate.Height = 23
        Me.dgvIdxinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIdxinfo.Size = New System.Drawing.Size(893, 451)
        Me.dgvIdxinfo.TabIndex = 13
        Me.dgvIdxinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvIdxinfo.UseTagValueMatchColor = False
        '
        'coldgvIdxinfoDB
        '
        Me.coldgvIdxinfoDB.DataPropertyName = "DB"
        Me.coldgvIdxinfoDB.HeaderText = "F126"
        Me.coldgvIdxinfoDB.Name = "coldgvIdxinfoDB"
        Me.coldgvIdxinfoDB.ReadOnly = True
        Me.coldgvIdxinfoDB.Width = 76
        '
        'coldgvIdxinfoINDEX
        '
        Me.coldgvIdxinfoINDEX.DataPropertyName = "INDEX"
        Me.coldgvIdxinfoINDEX.HeaderText = "F127"
        Me.coldgvIdxinfoINDEX.Name = "coldgvIdxinfoINDEX"
        Me.coldgvIdxinfoINDEX.ReadOnly = True
        Me.coldgvIdxinfoINDEX.Width = 76
        '
        'coldgvIdxinfoTABLE
        '
        Me.coldgvIdxinfoTABLE.DataPropertyName = "TABLE"
        Me.coldgvIdxinfoTABLE.HeaderText = "F128"
        Me.coldgvIdxinfoTABLE.Name = "coldgvIdxinfoTABLE"
        Me.coldgvIdxinfoTABLE.ReadOnly = True
        Me.coldgvIdxinfoTABLE.Width = 76
        '
        'coldgvIdxinfoINDEXSIZE
        '
        Me.coldgvIdxinfoINDEXSIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvIdxinfoINDEXSIZE.DataPropertyName = "SIZE"
        Me.coldgvIdxinfoINDEXSIZE.HeaderText = "F129"
        Me.coldgvIdxinfoINDEXSIZE.HeaderWord = ""
        Me.coldgvIdxinfoINDEXSIZE.Name = "coldgvIdxinfoINDEXSIZE"
        Me.coldgvIdxinfoINDEXSIZE.ReadOnly = True
        Me.coldgvIdxinfoINDEXSIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvIdxinfoINDEXSIZE.ShowUnit = True
        Me.coldgvIdxinfoINDEXSIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvIdxinfoINDEXSIZE.TailWord = ""
        Me.coldgvIdxinfoINDEXSIZE.Width = 76
        '
        'coldgvIdxinfoINDEXSCANCOUNT
        '
        Me.coldgvIdxinfoINDEXSCANCOUNT.DataPropertyName = "INDEX SCAN COUNT"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N0"
        Me.coldgvIdxinfoINDEXSCANCOUNT.DefaultCellStyle = DataGridViewCellStyle20
        Me.coldgvIdxinfoINDEXSCANCOUNT.HeaderText = "F130"
        Me.coldgvIdxinfoINDEXSCANCOUNT.Name = "coldgvIdxinfoINDEXSCANCOUNT"
        Me.coldgvIdxinfoINDEXSCANCOUNT.ReadOnly = True
        Me.coldgvIdxinfoINDEXSCANCOUNT.Width = 76
        '
        'coldgvIdxinfoINDEXFETCHEDTUPLES
        '
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.DataPropertyName = "INDEX FETCHED TUPLES"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N0"
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.DefaultCellStyle = DataGridViewCellStyle21
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.HeaderText = "F131"
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.Name = "coldgvIdxinfoINDEXFETCHEDTUPLES"
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.ReadOnly = True
        Me.coldgvIdxinfoINDEXFETCHEDTUPLES.Width = 76
        '
        'coldgvIdxinfoUPDATEDTUPLES
        '
        Me.coldgvIdxinfoUPDATEDTUPLES.DataPropertyName = "UPDATED TUPLES"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N0"
        Me.coldgvIdxinfoUPDATEDTUPLES.DefaultCellStyle = DataGridViewCellStyle22
        Me.coldgvIdxinfoUPDATEDTUPLES.HeaderText = "F132"
        Me.coldgvIdxinfoUPDATEDTUPLES.Name = "coldgvIdxinfoUPDATEDTUPLES"
        Me.coldgvIdxinfoUPDATEDTUPLES.ReadOnly = True
        Me.coldgvIdxinfoUPDATEDTUPLES.Width = 76
        '
        'coldgvIdxinfoDELETEDTUPLES
        '
        Me.coldgvIdxinfoDELETEDTUPLES.DataPropertyName = "DELETED TUPLES"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N0"
        Me.coldgvIdxinfoDELETEDTUPLES.DefaultCellStyle = DataGridViewCellStyle23
        Me.coldgvIdxinfoDELETEDTUPLES.HeaderText = "F133"
        Me.coldgvIdxinfoDELETEDTUPLES.Name = "coldgvIdxinfoDELETEDTUPLES"
        Me.coldgvIdxinfoDELETEDTUPLES.ReadOnly = True
        Me.coldgvIdxinfoDELETEDTUPLES.Width = 76
        '
        'coldgvIdxinfoLiveTuples
        '
        Me.coldgvIdxinfoLiveTuples.DataPropertyName = "LIVE TUPLES"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N0"
        Me.coldgvIdxinfoLiveTuples.DefaultCellStyle = DataGridViewCellStyle24
        Me.coldgvIdxinfoLiveTuples.HeaderText = "F124"
        Me.coldgvIdxinfoLiveTuples.Name = "coldgvIdxinfoLiveTuples"
        Me.coldgvIdxinfoLiveTuples.ReadOnly = True
        Me.coldgvIdxinfoLiveTuples.Width = 76
        '
        'grpDBinfo
        '
        Me.grpDBinfo.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpDBinfo.AlignString = System.Drawing.StringAlignment.Near
        Me.grpDBinfo.BackColor = System.Drawing.Color.Black
        Me.grpDBinfo.Controls.Add(Me.dgvDBinfo)
        Me.grpDBinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Edges4.LeftBottom = 0
        Edges4.RightBottom = 0
        Me.grpDBinfo.EdgeRound = Edges4
        Me.grpDBinfo.FillColor = System.Drawing.Color.Black
        Me.grpDBinfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.grpDBinfo.Icon = CType(resources.GetObject("grpDBinfo.Icon"), System.Drawing.Icon)
        Me.grpDBinfo.LineColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.grpDBinfo.LineWidth = 1
        Me.grpDBinfo.Location = New System.Drawing.Point(3, 4)
        Me.grpDBinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpDBinfo.Name = "grpDBinfo"
        Me.grpDBinfo.Padding = New System.Windows.Forms.Padding(3, 11, 3, 3)
        Me.grpDBinfo.Size = New System.Drawing.Size(899, 484)
        Me.grpDBinfo.TabIndex = 2
        Me.grpDBinfo.TabStop = False
        Me.grpDBinfo.Text = "F078"
        Me.grpDBinfo.TitleFont = New System.Drawing.Font("Gulim", 11.0!, System.Drawing.FontStyle.Bold)
        Me.grpDBinfo.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpDBinfo.UseGraColor = False
        Me.grpDBinfo.UseRound = True
        Me.grpDBinfo.UseTitle = True
        '
        'dgvDBinfo
        '
        Me.dgvDBinfo.AllowUserToAddRows = False
        Me.dgvDBinfo.AllowUserToDeleteRows = False
        Me.dgvDBinfo.AllowUserToOrderColumns = True
        Me.dgvDBinfo.AllowUserToResizeRows = False
        Me.dgvDBinfo.BackgroundColor = System.Drawing.Color.Black
        Me.dgvDBinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDBinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDBinfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvDBinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDBinfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvDBinfoDB, Me.coldgvDBinfoSIZE, Me.coldgvDBinfoTABLECNT, Me.coldgvDBinfoINDEXCNT, Me.coldgvDBinfoDISKREAD, Me.coldgvDBinfoBUFFERREAD, Me.coldgvDBinfoHITRATIO})
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDBinfo.DefaultCellStyle = DataGridViewCellStyle33
        Me.dgvDBinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDBinfo.EnableHeadersVisualStyles = False
        Me.dgvDBinfo.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvDBinfo.GridColor = System.Drawing.Color.Black
        Me.dgvDBinfo.Location = New System.Drawing.Point(3, 31)
        Me.dgvDBinfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvDBinfo.MultiSelect = False
        Me.dgvDBinfo.Name = "dgvDBinfo"
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDBinfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.dgvDBinfo.RowHeadersVisible = False
        Me.dgvDBinfo.RowTemplate.Height = 23
        Me.dgvDBinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDBinfo.Size = New System.Drawing.Size(893, 450)
        Me.dgvDBinfo.TabIndex = 11
        Me.dgvDBinfo.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvDBinfo.UseTagValueMatchColor = False
        '
        'coldgvDBinfoDB
        '
        Me.coldgvDBinfoDB.DataPropertyName = "DB"
        Me.coldgvDBinfoDB.HeaderText = "F104"
        Me.coldgvDBinfoDB.Name = "coldgvDBinfoDB"
        Me.coldgvDBinfoDB.ReadOnly = True
        Me.coldgvDBinfoDB.Width = 76
        '
        'coldgvDBinfoSIZE
        '
        Me.coldgvDBinfoSIZE.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvDBinfoSIZE.DataPropertyName = "SIZE"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle27.Format = "N1"
        Me.coldgvDBinfoSIZE.DefaultCellStyle = DataGridViewCellStyle27
        Me.coldgvDBinfoSIZE.HeaderText = "F105"
        Me.coldgvDBinfoSIZE.HeaderWord = ""
        Me.coldgvDBinfoSIZE.Name = "coldgvDBinfoSIZE"
        Me.coldgvDBinfoSIZE.ReadOnly = True
        Me.coldgvDBinfoSIZE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvDBinfoSIZE.ShowUnit = True
        Me.coldgvDBinfoSIZE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvDBinfoSIZE.TailWord = ""
        Me.coldgvDBinfoSIZE.Width = 76
        '
        'coldgvDBinfoTABLECNT
        '
        Me.coldgvDBinfoTABLECNT.DataPropertyName = "TABLE COUNT"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle28.Format = "N0"
        DataGridViewCellStyle28.NullValue = Nothing
        Me.coldgvDBinfoTABLECNT.DefaultCellStyle = DataGridViewCellStyle28
        Me.coldgvDBinfoTABLECNT.HeaderText = "F106"
        Me.coldgvDBinfoTABLECNT.Name = "coldgvDBinfoTABLECNT"
        Me.coldgvDBinfoTABLECNT.ReadOnly = True
        Me.coldgvDBinfoTABLECNT.Width = 76
        '
        'coldgvDBinfoINDEXCNT
        '
        Me.coldgvDBinfoINDEXCNT.DataPropertyName = "INDEX COUNT"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "N0"
        DataGridViewCellStyle29.NullValue = Nothing
        Me.coldgvDBinfoINDEXCNT.DefaultCellStyle = DataGridViewCellStyle29
        Me.coldgvDBinfoINDEXCNT.HeaderText = "F107"
        Me.coldgvDBinfoINDEXCNT.Name = "coldgvDBinfoINDEXCNT"
        Me.coldgvDBinfoINDEXCNT.ReadOnly = True
        Me.coldgvDBinfoINDEXCNT.Width = 76
        '
        'coldgvDBinfoDISKREAD
        '
        Me.coldgvDBinfoDISKREAD.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvDBinfoDISKREAD.DataPropertyName = "DISK READ"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N1"
        Me.coldgvDBinfoDISKREAD.DefaultCellStyle = DataGridViewCellStyle30
        Me.coldgvDBinfoDISKREAD.HeaderText = "F108"
        Me.coldgvDBinfoDISKREAD.HeaderWord = ""
        Me.coldgvDBinfoDISKREAD.Name = "coldgvDBinfoDISKREAD"
        Me.coldgvDBinfoDISKREAD.ReadOnly = True
        Me.coldgvDBinfoDISKREAD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvDBinfoDISKREAD.ShowUnit = True
        Me.coldgvDBinfoDISKREAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvDBinfoDISKREAD.TailWord = ""
        Me.coldgvDBinfoDISKREAD.Width = 76
        '
        'coldgvDBinfoBUFFERREAD
        '
        Me.coldgvDBinfoBUFFERREAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvDBinfoBUFFERREAD.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvDBinfoBUFFERREAD.DataPropertyName = "BUFFER READ"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N1"
        Me.coldgvDBinfoBUFFERREAD.DefaultCellStyle = DataGridViewCellStyle31
        Me.coldgvDBinfoBUFFERREAD.HeaderText = "F109"
        Me.coldgvDBinfoBUFFERREAD.HeaderWord = ""
        Me.coldgvDBinfoBUFFERREAD.Name = "coldgvDBinfoBUFFERREAD"
        Me.coldgvDBinfoBUFFERREAD.ReadOnly = True
        Me.coldgvDBinfoBUFFERREAD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvDBinfoBUFFERREAD.ShowUnit = True
        Me.coldgvDBinfoBUFFERREAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvDBinfoBUFFERREAD.TailWord = ""
        '
        'coldgvDBinfoHITRATIO
        '
        Me.coldgvDBinfoHITRATIO.DataPropertyName = "HIT RATIO"
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle32.Format = "N0"
        DataGridViewCellStyle32.NullValue = Nothing
        Me.coldgvDBinfoHITRATIO.DefaultCellStyle = DataGridViewCellStyle32
        Me.coldgvDBinfoHITRATIO.HeaderText = "F110"
        Me.coldgvDBinfoHITRATIO.Name = "coldgvDBinfoHITRATIO"
        Me.coldgvDBinfoHITRATIO.ReadOnly = True
        Me.coldgvDBinfoHITRATIO.Width = 76
        '
        'dgvLock
        '
        Me.dgvLock.AllowUserToAddRows = False
        Me.dgvLock.AllowUserToDeleteRows = False
        Me.dgvLock.AllowUserToOrderColumns = True
        Me.dgvLock.AllowUserToResizeRows = False
        Me.dgvLock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLock.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle35
        Me.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvLockDB, Me.colDgvLockBlockingPID, Me.colDgvLockBlockingUser, Me.colDgvLockBlockingQuery, Me.colDgvLockBlockedPID, Me.colDgvLockBlockedUser, Me.colDgvLockBlockedQuery, Me.colDgvLockElapse, Me.colDgvLOckLockMode, Me.colDgvLockQueryStart, Me.colDgvLockXactStart})
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLock.DefaultCellStyle = DataGridViewCellStyle36
        Me.dgvLock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLock.EnableHeadersVisualStyles = False
        Me.dgvLock.Font = New System.Drawing.Font("Gulim", 10.0!)
        Me.dgvLock.GridColor = System.Drawing.Color.Black
        Me.dgvLock.ImageList = Nothing
        Me.dgvLock.Location = New System.Drawing.Point(3, 31)
        Me.dgvLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLock.MultiSelect = False
        Me.dgvLock.Name = "dgvLock"
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Gulim", 10.0!)
        DataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.RowHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.dgvLock.RowHeadersVisible = False
        Me.dgvLock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLock.Size = New System.Drawing.Size(1816, 20)
        Me.dgvLock.TabIndex = 9
        '
        'frmMonActInfo
        '
        Me.BaseHeight = 1092
        Me.ClientSize = New System.Drawing.Size(1826, 1090)
        Me.Controls.Add(Me.spnlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmMonActInfo"
        Me.Controls.SetChildIndex(Me.spnlMain, 0)
        Me.spnlMain.Panel1.ResumeLayout(False)
        CType(Me.spnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spnlMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.grpTableInfo.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.grpTblinfo.ResumeLayout(False)
        CType(Me.dgvTblinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTblSpaceInfo.ResumeLayout(False)
        CType(Me.dgvTblSpaceInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpidxinfo.ResumeLayout(False)
        CType(Me.dgvIdxinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDBinfo.ResumeLayout(False)
        CType(Me.dgvDBinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents colDgvLockDB As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents colDgvLockBlockingPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockingUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockingQuery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedPID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockBlockedQuery As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockElapse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLOckLockMode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockQueryStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvLockXactStart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents spnlMain As System.Windows.Forms.SplitContainer
    Friend WithEvents tlpMain As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents grpTableInfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents lblRefreshTime As eXperDB.BaseControls.Label
    Friend WithEvents btnRefresh As eXperDB.BaseControls.Button
    Friend WithEvents tlpBottom As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents grpTblinfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvTblinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvTblinfoDB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoTABLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoTABLESIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvTblinfoINDEXSIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvTblinfoINDEXCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoISTOAST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoSEQSCAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoINDEXSCAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoLIVETUPLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblinfoLASTVACUUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpTblSpaceInfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvTblSpaceInfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents grpidxinfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvIdxinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvIdxinfoDB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoINDEX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoTABLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoINDEXSIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvIdxinfoINDEXSCANCOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoINDEXFETCHEDTUPLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoUPDATEDTUPLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoDELETEDTUPLES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIdxinfoLiveTuples As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpDBinfo As eXperDB.BaseControls.GroupBox
    Friend WithEvents dgvDBinfo As eXperDB.BaseControls.DataGridView
    Friend WithEvents coldgvDBinfoDB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvDBinfoSIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvDBinfoTABLECNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvDBinfoINDEXCNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvDBinfoDISKREAD As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvDBinfoBUFFERREAD As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvDBinfoHITRATIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvLock As AdvancedDataGridView.TreeGridView
    Friend WithEvents coldgvTblSpaceInfoFileSystem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblSpaceInfoDISKSIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvTblSpaceInfoDISKUSED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblSpaceInfoAvail As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvTblSpaceInfoMountPoint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblSpaceInfoTABLESPACE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvTblSpaceInfoSIZE As eXperDB.Controls.DataGridViewDataSizeColumn
    Friend WithEvents coldgvTblSpaceInfoLOCATION As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
