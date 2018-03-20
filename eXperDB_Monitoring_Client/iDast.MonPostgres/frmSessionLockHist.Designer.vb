<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSessionLockHist
    'Inherits Monitoring.frmMonBase
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
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle62 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle63 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle57 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle58 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle59 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle60 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle61 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSessionLockHist))
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
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
        Me.lblType = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDatabase = New eXperDB.BaseControls.Label()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.cmbType = New eXperDB.BaseControls.ComboBox()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.txtDatabase = New eXperDB.BaseControls.TextBox()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.lblSQL = New eXperDB.BaseControls.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpSession = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.tlpHead = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpLockInfo = New System.Windows.Forms.Label()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tlpHead.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'dgvLock
        '
        Me.dgvLock.AllowUserToAddRows = False
        Me.dgvLock.AllowUserToDeleteRows = False
        Me.dgvLock.AllowUserToOrderColumns = True
        Me.dgvLock.AllowUserToResizeRows = False
        Me.dgvLock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLock.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle34.Font = New System.Drawing.Font("굴림", 10.0!)
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle34
        Me.dgvLock.ColumnHeadersHeight = 30
        Me.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvLockDB, Me.coldgvLockCtrlType, Me.coldgvLockCtrlTime, Me.colDgvLockBlockingPID, Me.colDgvLockBlockingUser, Me.colDgvLockBlockingQuery, Me.colDgvLockBlockedPID, Me.colDgvLockBlockedUser, Me.colDgvLockBlockedQuery, Me.colDgvLockMode, Me.colDgvLockElapse, Me.colDgvLockQueryStart, Me.colDgvLockXactStart})
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle48.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle48.Font = New System.Drawing.Font("굴림", 10.0!)
        DataGridViewCellStyle48.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLock.DefaultCellStyle = DataGridViewCellStyle48
        Me.dgvLock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLock.EnableHeadersVisualStyles = False
        Me.dgvLock.Font = New System.Drawing.Font("굴림", 10.0!)
        Me.dgvLock.GridColor = System.Drawing.Color.Gray
        Me.dgvLock.ImageList = Nothing
        Me.dgvLock.Location = New System.Drawing.Point(0, 40)
        Me.dgvLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLock.MultiSelect = False
        Me.dgvLock.Name = "dgvLock"
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle49.Font = New System.Drawing.Font("굴림", 10.0!)
        DataGridViewCellStyle49.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle49.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.RowHeadersDefaultCellStyle = DataGridViewCellStyle49
        Me.dgvLock.RowHeadersVisible = False
        Me.dgvLock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLock.Size = New System.Drawing.Size(1150, 158)
        Me.dgvLock.TabIndex = 9
        '
        'colDgvLockDB
        '
        Me.colDgvLockDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockDB.DefaultCellStyle = DataGridViewCellStyle35
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
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvLockCtrlType.DefaultCellStyle = DataGridViewCellStyle36
        Me.coldgvLockCtrlType.FillWeight = 64.0!
        Me.coldgvLockCtrlType.HeaderText = "F252"
        Me.coldgvLockCtrlType.Name = "coldgvLockCtrlType"
        Me.coldgvLockCtrlType.ReadOnly = True
        Me.coldgvLockCtrlType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coldgvLockCtrlTime
        '
        Me.coldgvLockCtrlTime.DataPropertyName = "CONTROL_TIME"
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvLockCtrlTime.DefaultCellStyle = DataGridViewCellStyle37
        Me.coldgvLockCtrlTime.FillWeight = 160.0!
        Me.coldgvLockCtrlTime.HeaderText = "F253"
        Me.coldgvLockCtrlTime.Name = "coldgvLockCtrlTime"
        Me.coldgvLockCtrlTime.ReadOnly = True
        Me.coldgvLockCtrlTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingPID
        '
        Me.colDgvLockBlockingPID.DataPropertyName = "BLOCKING_PID"
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingPID.DefaultCellStyle = DataGridViewCellStyle38
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
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingUser.DefaultCellStyle = DataGridViewCellStyle39
        Me.colDgvLockBlockingUser.FillWeight = 130.0!
        Me.colDgvLockBlockingUser.HeaderText = "F134"
        Me.colDgvLockBlockingUser.Name = "colDgvLockBlockingUser"
        Me.colDgvLockBlockingUser.ReadOnly = True
        Me.colDgvLockBlockingUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockingQuery
        '
        Me.colDgvLockBlockingQuery.DataPropertyName = "BLOCKING_QUERY"
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle40.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockingQuery.DefaultCellStyle = DataGridViewCellStyle40
        Me.colDgvLockBlockingQuery.FillWeight = 200.0!
        Me.colDgvLockBlockingQuery.HeaderText = "F084"
        Me.colDgvLockBlockingQuery.Name = "colDgvLockBlockingQuery"
        Me.colDgvLockBlockingQuery.ReadOnly = True
        Me.colDgvLockBlockingQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedPID
        '
        Me.colDgvLockBlockedPID.DataPropertyName = "BLOCKED_PID"
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle41.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedPID.DefaultCellStyle = DataGridViewCellStyle41
        Me.colDgvLockBlockedPID.FillWeight = 102.0!
        Me.colDgvLockBlockedPID.HeaderText = "F195"
        Me.colDgvLockBlockedPID.Name = "colDgvLockBlockedPID"
        Me.colDgvLockBlockedPID.ReadOnly = True
        Me.colDgvLockBlockedPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedUser
        '
        Me.colDgvLockBlockedUser.DataPropertyName = "BLOCKED_USER"
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedUser.DefaultCellStyle = DataGridViewCellStyle42
        Me.colDgvLockBlockedUser.FillWeight = 130.0!
        Me.colDgvLockBlockedUser.HeaderText = "F196"
        Me.colDgvLockBlockedUser.Name = "colDgvLockBlockedUser"
        Me.colDgvLockBlockedUser.ReadOnly = True
        Me.colDgvLockBlockedUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedQuery
        '
        Me.colDgvLockBlockedQuery.DataPropertyName = "BLOCKED_QUERY"
        DataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle43.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockBlockedQuery.DefaultCellStyle = DataGridViewCellStyle43
        Me.colDgvLockBlockedQuery.FillWeight = 200.0!
        Me.colDgvLockBlockedQuery.HeaderText = "F221"
        Me.colDgvLockBlockedQuery.Name = "colDgvLockBlockedQuery"
        Me.colDgvLockBlockedQuery.ReadOnly = True
        Me.colDgvLockBlockedQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockMode
        '
        Me.colDgvLockMode.DataPropertyName = "LOCK_MODE"
        DataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle44.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockMode.DefaultCellStyle = DataGridViewCellStyle44
        Me.colDgvLockMode.FillWeight = 130.0!
        Me.colDgvLockMode.HeaderText = "F222"
        Me.colDgvLockMode.Name = "colDgvLockMode"
        Me.colDgvLockMode.ReadOnly = True
        Me.colDgvLockMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockElapse
        '
        Me.colDgvLockElapse.DataPropertyName = "BLOCKED_DURATION"
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle45.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockElapse.DefaultCellStyle = DataGridViewCellStyle45
        Me.colDgvLockElapse.FillWeight = 120.0!
        Me.colDgvLockElapse.HeaderText = "F135"
        Me.colDgvLockElapse.Name = "colDgvLockElapse"
        Me.colDgvLockElapse.ReadOnly = True
        Me.colDgvLockElapse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockQueryStart
        '
        Me.colDgvLockQueryStart.DataPropertyName = "QUERY_START"
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle46.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockQueryStart.DefaultCellStyle = DataGridViewCellStyle46
        Me.colDgvLockQueryStart.FillWeight = 163.0!
        Me.colDgvLockQueryStart.HeaderText = "F223"
        Me.colDgvLockQueryStart.Name = "colDgvLockQueryStart"
        Me.colDgvLockQueryStart.ReadOnly = True
        Me.colDgvLockQueryStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockXactStart
        '
        Me.colDgvLockXactStart.DataPropertyName = "XACT_START"
        DataGridViewCellStyle47.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle47.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.White
        Me.colDgvLockXactStart.DefaultCellStyle = DataGridViewCellStyle47
        Me.colDgvLockXactStart.FillWeight = 163.0!
        Me.colDgvLockXactStart.HeaderText = "F224"
        Me.colDgvLockXactStart.Name = "colDgvLockXactStart"
        Me.colDgvLockXactStart.ReadOnly = True
        Me.colDgvLockXactStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgvSessionList
        '
        Me.dgvSessionList.AllowUserToAddRows = False
        Me.dgvSessionList.AllowUserToDeleteRows = False
        Me.dgvSessionList.AllowUserToOrderColumns = True
        Me.dgvSessionList.AllowUserToResizeRows = False
        Me.dgvSessionList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSessionList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSessionList.ColumnHeadersHeight = 30
        Me.dgvSessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSessionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvSessionCtrlType, Me.coldgvSessionCtrlTime, Me.coldgvSessionListDB, Me.coldgvSessionListPID, Me.coldgvSessionListCpuUsage, Me.coldgvSessionListStTime, Me.coldgvSessionListElapsedTime, Me.coldgvSessionListStatus, Me.coldgvSessionListUser, Me.coldgvSessionListClient, Me.coldgvSessionListApp, Me.coldgvSessionListRead, Me.coldgvSessionListWrite, Me.coldgvSessionListSQL})
        DataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle62.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle62.Font = New System.Drawing.Font("굴림", 9.5!)
        DataGridViewCellStyle62.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle62.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionList.DefaultCellStyle = DataGridViewCellStyle62
        Me.dgvSessionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSessionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSessionList.EnableHeadersVisualStyles = False
        Me.dgvSessionList.Font = New System.Drawing.Font("굴림", 9.5!)
        Me.dgvSessionList.GridColor = System.Drawing.Color.Gray
        Me.dgvSessionList.Location = New System.Drawing.Point(0, 189)
        Me.dgvSessionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSessionList.MultiSelect = False
        Me.dgvSessionList.Name = "dgvSessionList"
        DataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle63.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle63.Font = New System.Drawing.Font("굴림", 9.5!)
        DataGridViewCellStyle63.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle63.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.RowHeadersDefaultCellStyle = DataGridViewCellStyle63
        Me.dgvSessionList.RowHeadersVisible = False
        Me.dgvSessionList.RowTemplate.Height = 23
        Me.dgvSessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessionList.Size = New System.Drawing.Size(1150, 207)
        Me.dgvSessionList.TabIndex = 10
        Me.dgvSessionList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSessionList.UseTagValueMatchColor = False
        '
        'coldgvSessionCtrlType
        '
        Me.coldgvSessionCtrlType.DataPropertyName = "ACCESS_TYPE"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionCtrlType.DefaultCellStyle = DataGridViewCellStyle15
        Me.coldgvSessionCtrlType.HeaderText = "F252"
        Me.coldgvSessionCtrlType.Name = "coldgvSessionCtrlType"
        Me.coldgvSessionCtrlType.ReadOnly = True
        Me.coldgvSessionCtrlType.Width = 66
        '
        'coldgvSessionCtrlTime
        '
        Me.coldgvSessionCtrlTime.DataPropertyName = "CONTROL_TIME"
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionCtrlTime.DefaultCellStyle = DataGridViewCellStyle16
        Me.coldgvSessionCtrlTime.HeaderText = "F253"
        Me.coldgvSessionCtrlTime.Name = "coldgvSessionCtrlTime"
        Me.coldgvSessionCtrlTime.ReadOnly = True
        Me.coldgvSessionCtrlTime.Width = 160
        '
        'coldgvSessionListDB
        '
        Me.coldgvSessionListDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle50.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle50.Format = "N2"
        DataGridViewCellStyle50.NullValue = "0"
        DataGridViewCellStyle50.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListDB.DefaultCellStyle = DataGridViewCellStyle50
        Me.coldgvSessionListDB.HeaderText = "F090"
        Me.coldgvSessionListDB.Name = "coldgvSessionListDB"
        Me.coldgvSessionListDB.ReadOnly = True
        Me.coldgvSessionListDB.Width = 88
        '
        'coldgvSessionListPID
        '
        Me.coldgvSessionListPID.DataPropertyName = "PROCESS_ID"
        DataGridViewCellStyle51.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle51.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListPID.DefaultCellStyle = DataGridViewCellStyle51
        Me.coldgvSessionListPID.HeaderText = "F082"
        Me.coldgvSessionListPID.Name = "coldgvSessionListPID"
        Me.coldgvSessionListPID.ReadOnly = True
        Me.coldgvSessionListPID.Width = 76
        '
        'coldgvSessionListCpuUsage
        '
        Me.coldgvSessionListCpuUsage.DataPropertyName = "CPU_USAGE"
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle52.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle52.Format = "P"
        DataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle52.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListCpuUsage.DefaultCellStyle = DataGridViewCellStyle52
        Me.coldgvSessionListCpuUsage.HeaderText = "F092"
        Me.coldgvSessionListCpuUsage.Name = "coldgvSessionListCpuUsage"
        Me.coldgvSessionListCpuUsage.ReadOnly = True
        Me.coldgvSessionListCpuUsage.Width = 76
        '
        'coldgvSessionListStTime
        '
        Me.coldgvSessionListStTime.DataPropertyName = "START_TIME"
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle53.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle53.Format = "HH:mm:ss"
        DataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListStTime.DefaultCellStyle = DataGridViewCellStyle53
        Me.coldgvSessionListStTime.HeaderText = "F050"
        Me.coldgvSessionListStTime.Name = "coldgvSessionListStTime"
        Me.coldgvSessionListStTime.ReadOnly = True
        Me.coldgvSessionListStTime.Width = 130
        '
        'coldgvSessionListElapsedTime
        '
        Me.coldgvSessionListElapsedTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.coldgvSessionListElapsedTime.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle54.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle54.Format = "N2"
        DataGridViewCellStyle54.NullValue = "12"
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListElapsedTime.DefaultCellStyle = DataGridViewCellStyle54
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
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle55.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListStatus.DefaultCellStyle = DataGridViewCellStyle55
        Me.coldgvSessionListStatus.HeaderText = "F247"
        Me.coldgvSessionListStatus.Name = "coldgvSessionListStatus"
        Me.coldgvSessionListStatus.ReadOnly = True
        Me.coldgvSessionListStatus.Width = 76
        '
        'coldgvSessionListUser
        '
        Me.coldgvSessionListUser.DataPropertyName = "USER_NAME"
        DataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle56.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle56.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListUser.DefaultCellStyle = DataGridViewCellStyle56
        Me.coldgvSessionListUser.HeaderText = "F008"
        Me.coldgvSessionListUser.Name = "coldgvSessionListUser"
        Me.coldgvSessionListUser.ReadOnly = True
        Me.coldgvSessionListUser.Width = 120
        '
        'coldgvSessionListClient
        '
        Me.coldgvSessionListClient.DataPropertyName = "CLIENT_ADDR"
        DataGridViewCellStyle57.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle57.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle57.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListClient.DefaultCellStyle = DataGridViewCellStyle57
        Me.coldgvSessionListClient.HeaderText = "F248"
        Me.coldgvSessionListClient.Name = "coldgvSessionListClient"
        Me.coldgvSessionListClient.ReadOnly = True
        Me.coldgvSessionListClient.Width = 200
        '
        'coldgvSessionListApp
        '
        Me.coldgvSessionListApp.DataPropertyName = "CLIENT_APP"
        DataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle58.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle58.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListApp.DefaultCellStyle = DataGridViewCellStyle58
        Me.coldgvSessionListApp.HeaderText = "F249"
        Me.coldgvSessionListApp.Name = "coldgvSessionListApp"
        Me.coldgvSessionListApp.ReadOnly = True
        Me.coldgvSessionListApp.Width = 200
        '
        'coldgvSessionListRead
        '
        Me.coldgvSessionListRead.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvSessionListRead.DataPropertyName = "CURRENT_PROC_READ_KB"
        DataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle59.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle59.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle59.Format = "N1"
        DataGridViewCellStyle59.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListRead.DefaultCellStyle = DataGridViewCellStyle59
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
        DataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle60.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle60.Format = "N1"
        DataGridViewCellStyle60.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle60.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListWrite.DefaultCellStyle = DataGridViewCellStyle60
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
        DataGridViewCellStyle61.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle61.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle61.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvSessionListSQL.DefaultCellStyle = DataGridViewCellStyle61
        Me.coldgvSessionListSQL.HeaderText = "F052"
        Me.coldgvSessionListSQL.Name = "coldgvSessionListSQL"
        Me.coldgvSessionListSQL.ReadOnly = True
        '
        'lblType
        '
        Me.lblType.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblType.FixedHeight = False
        Me.lblType.FixedWidth = False
        Me.lblType.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.lblType.ForeColor = System.Drawing.Color.LightGray
        Me.lblType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblType.Location = New System.Drawing.Point(3, 16)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(74, 26)
        Me.lblType.TabIndex = 23
        Me.lblType.Text = "F252"
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.FixedWidth = False
        Me.dtpSt.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(483, 17)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(164, 21)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 19
        '
        'lblDatabase
        '
        Me.lblDatabase.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDatabase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDatabase.FixedHeight = False
        Me.lblDatabase.FixedWidth = False
        Me.lblDatabase.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.lblDatabase.ForeColor = System.Drawing.Color.LightGray
        Me.lblDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDatabase.Location = New System.Drawing.Point(203, 16)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(74, 26)
        Me.lblDatabase.TabIndex = 24
        Me.lblDatabase.Text = "Database"
        Me.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.lblDuration2.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration2.Location = New System.Drawing.Point(653, 16)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(14, 26)
        Me.lblDuration2.TabIndex = 20
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbType
        '
        Me.cmbType.BackColor = System.Drawing.SystemColors.Window
        Me.cmbType.DisplayMember = "All"
        Me.cmbType.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.FixedWidth = False
        Me.cmbType.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"All", "Cancel", "Stop"})
        Me.cmbType.Location = New System.Drawing.Point(83, 18)
        Me.cmbType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Necessary = False
        Me.cmbType.Size = New System.Drawing.Size(114, 20)
        Me.cmbType.StatusTip = ""
        Me.cmbType.TabIndex = 17
        Me.cmbType.ValueText = ""
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.FixedWidth = False
        Me.dtpEd.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(673, 17)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(164, 21)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 21
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.White
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnExcel.Location = New System.Drawing.Point(1053, 12)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(94, 34)
        Me.btnExcel.TabIndex = 24
        Me.btnExcel.Text = "F142"
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseRound = True
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'txtDatabase
        '
        Me.txtDatabase.BackColor = System.Drawing.SystemColors.Window
        Me.txtDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDatabase.code = False
        Me.txtDatabase.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDatabase.FixedWidth = False
        Me.txtDatabase.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.txtDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDatabase.impossibleinput = ""
        Me.txtDatabase.Location = New System.Drawing.Point(283, 18)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Necessary = False
        Me.txtDatabase.PossibleInput = ""
        Me.txtDatabase.Prefix = ""
        Me.txtDatabase.Size = New System.Drawing.Size(114, 21)
        Me.txtDatabase.StatusTip = ""
        Me.txtDatabase.TabIndex = 18
        Me.txtDatabase.Value = ""
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(953, 12)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(94, 34)
        Me.btnQuery.TabIndex = 23
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.lblDuration.ForeColor = System.Drawing.Color.LightGray
        Me.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration.Location = New System.Drawing.Point(403, 16)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(74, 26)
        Me.lblDuration.TabIndex = 25
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSQL
        '
        Me.lblSQL.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSQL.FixedHeight = False
        Me.lblSQL.FixedWidth = False
        Me.lblSQL.Font = New System.Drawing.Font("굴림", 9.0!)
        Me.lblSQL.ForeColor = System.Drawing.Color.LightGray
        Me.lblSQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSQL.Location = New System.Drawing.Point(3, 0)
        Me.lblSQL.Name = "lblSQL"
        Me.lblSQL.Size = New System.Drawing.Size(74, 41)
        Me.lblSQL.TabIndex = 26
        Me.lblSQL.Text = "SQL"
        Me.lblSQL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvSessionList)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.tlpHead)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvLock)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1150, 598)
        Me.SplitContainer2.SplitterDistance = 396
        Me.SplitContainer2.TabIndex = 12
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.grpSession, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 149)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1150, 40)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "      "
        '
        'grpSession
        '
        Me.grpSession.AutoSize = True
        Me.grpSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSession.ForeColor = System.Drawing.Color.White
        Me.grpSession.Location = New System.Drawing.Point(43, 0)
        Me.grpSession.Name = "grpSession"
        Me.grpSession.Size = New System.Drawing.Size(1104, 40)
        Me.grpSession.TabIndex = 3
        Me.grpSession.Text = "F080"
        Me.grpSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 760.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.txtSQL, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblSQL, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 92)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1150, 57)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSQL.Location = New System.Drawing.Point(83, 3)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(754, 35)
        Me.txtSQL.TabIndex = 21
        '
        'tlpHead
        '
        Me.tlpHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpHead.ColumnCount = 11
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpHead.Controls.Add(Me.lblType, 0, 0)
        Me.tlpHead.Controls.Add(Me.cmbType, 1, 0)
        Me.tlpHead.Controls.Add(Me.lblDatabase, 2, 0)
        Me.tlpHead.Controls.Add(Me.txtDatabase, 3, 0)
        Me.tlpHead.Controls.Add(Me.lblDuration, 4, 0)
        Me.tlpHead.Controls.Add(Me.dtpSt, 5, 0)
        Me.tlpHead.Controls.Add(Me.lblDuration2, 6, 0)
        Me.tlpHead.Controls.Add(Me.dtpEd, 7, 0)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHead.Font = New System.Drawing.Font("굴림", 12.27167!)
        Me.tlpHead.Location = New System.Drawing.Point(0, 50)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 1
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpHead.Size = New System.Drawing.Size(1150, 42)
        Me.tlpHead.TabIndex = 18
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExcel, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnQuery, 6, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1150, 50)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(764, 50)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Text"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpLockInfo, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1150, 40)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "      "
        '
        'grpLockInfo
        '
        Me.grpLockInfo.AutoSize = True
        Me.grpLockInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLockInfo.ForeColor = System.Drawing.Color.White
        Me.grpLockInfo.Location = New System.Drawing.Point(43, 0)
        Me.grpLockInfo.Name = "grpLockInfo"
        Me.grpLockInfo.Size = New System.Drawing.Size(1104, 40)
        Me.grpLockInfo.TabIndex = 3
        Me.grpLockInfo.Text = "F274"
        Me.grpLockInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSessionLockHist
        '
        Me.ClientSize = New System.Drawing.Size(1150, 598)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSessionLockHist"
        Me.Text = "Session History Managemet"
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.tlpHead.ResumeLayout(False)
        Me.tlpHead.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgvLock As AdvancedDataGridView.TreeGridView
    Friend WithEvents lblSQL As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents txtDatabase As eXperDB.BaseControls.TextBox
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents cmbType As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents lblDatabase As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblType As eXperDB.BaseControls.Label
    Friend WithEvents dgvSessionList As eXperDB.BaseControls.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tlpHead As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpSession As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpLockInfo As System.Windows.Forms.Label
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
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

End Class
