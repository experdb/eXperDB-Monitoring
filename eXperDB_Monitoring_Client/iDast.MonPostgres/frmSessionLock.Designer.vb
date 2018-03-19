<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSessionLock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSessionLock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.btnHistory = New eXperDB.BaseControls.Button()
        Me.btnCancel = New eXperDB.BaseControls.Button()
        Me.btnStop = New eXperDB.BaseControls.Button()
        Me.btnPause = New eXperDB.BaseControls.Button()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.cmbStatus = New eXperDB.BaseControls.ComboBox()
        Me.dgvSessionList = New eXperDB.BaseControls.DataGridView()
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New eXperDB.BaseControls.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpSession = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpLockInfo = New System.Windows.Forms.Label()
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.Silver
        Me.btnHistory.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnHistory.FixedHeight = False
        Me.btnHistory.FixedWidth = False
        Me.btnHistory.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.Yellow
        Me.btnHistory.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnHistory.Image = CType(resources.GetObject("btnHistory.Image"), System.Drawing.Image)
        Me.btnHistory.LineColor = System.Drawing.Color.LightGray
        Me.btnHistory.Location = New System.Drawing.Point(982, 15)
        Me.btnHistory.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Radius = 5
        Me.btnHistory.Size = New System.Drawing.Size(34, 31)
        Me.btnHistory.TabIndex = 16
        Me.btnHistory.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Silver
        Me.btnCancel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCancel.FixedHeight = False
        Me.btnCancel.FixedWidth = False
        Me.btnCancel.Font = New System.Drawing.Font("Webdings", 11.08059!)
        Me.btnCancel.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.LineColor = System.Drawing.Color.DarkGray
        Me.btnCancel.Location = New System.Drawing.Point(822, 15)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(34, 31)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Silver
        Me.btnStop.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnStop.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnStop.FixedHeight = False
        Me.btnStop.FixedWidth = False
        Me.btnStop.Font = New System.Drawing.Font("Webdings", 11.08059!)
        Me.btnStop.ForeColor = System.Drawing.Color.Red
        Me.btnStop.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.LineColor = System.Drawing.Color.LightGray
        Me.btnStop.Location = New System.Drawing.Point(862, 15)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Radius = 5
        Me.btnStop.Size = New System.Drawing.Size(34, 31)
        Me.btnStop.TabIndex = 18
        Me.btnStop.Text = "<"
        Me.btnStop.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Silver
        Me.btnPause.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPause.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPause.FixedHeight = False
        Me.btnPause.FixedWidth = False
        Me.btnPause.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.Blue
        Me.btnPause.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPause.LineColor = System.Drawing.Color.LightGray
        Me.btnPause.Location = New System.Drawing.Point(902, 15)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Radius = 5
        Me.btnPause.Size = New System.Drawing.Size(34, 31)
        Me.btnPause.TabIndex = 19
        Me.btnPause.Text = "q"
        Me.btnPause.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Silver
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.Yellow
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.LineColor = System.Drawing.Color.LightGray
        Me.btnExcel.Location = New System.Drawing.Point(942, 15)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(34, 31)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStatus.DisplayMember = "All"
        Me.cmbStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FixedWidth = False
        Me.cmbStatus.Font = New System.Drawing.Font("굴림", 9.065934!)
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"All", "Active", "Idle"})
        Me.cmbStatus.Location = New System.Drawing.Point(902, 15)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Necessary = False
        Me.cmbStatus.Size = New System.Drawing.Size(114, 20)
        Me.cmbStatus.StatusTip = ""
        Me.cmbStatus.TabIndex = 20
        Me.cmbStatus.ValueText = ""
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("굴림", 9.569597!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSessionList.ColumnHeadersHeight = 30
        Me.dgvSessionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSessionList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvSessionListDB, Me.coldgvSessionListPID, Me.coldgvSessionListCpuUsage, Me.coldgvSessionListStTime, Me.coldgvSessionListElapsedTime, Me.coldgvSessionListStatus, Me.coldgvSessionListUser, Me.coldgvSessionListClient, Me.coldgvSessionListApp, Me.coldgvSessionListRead, Me.coldgvSessionListWrite, Me.coldgvSessionListSQL, Me.colDgvSessionlistRegDate, Me.colDgvSessionListActvRegSeq})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("굴림", 9.569597!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSessionList.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSessionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSessionList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSessionList.EnableHeadersVisualStyles = False
        Me.dgvSessionList.Font = New System.Drawing.Font("굴림", 9.569597!)
        Me.dgvSessionList.GridColor = System.Drawing.Color.Gray
        Me.dgvSessionList.Location = New System.Drawing.Point(0, 40)
        Me.dgvSessionList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSessionList.Name = "dgvSessionList"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSessionList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSessionList.RowHeadersVisible = False
        Me.dgvSessionList.RowTemplate.Height = 23
        Me.dgvSessionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSessionList.Size = New System.Drawing.Size(1019, 288)
        Me.dgvSessionList.TabIndex = 10
        Me.dgvSessionList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvSessionList.UseTagValueMatchColor = False
        '
        'coldgvSessionListDB
        '
        Me.coldgvSessionListDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListDB.DataPropertyName = "DB_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvSessionListDB.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvSessionListDB.HeaderText = "F090"
        Me.coldgvSessionListDB.Name = "coldgvSessionListDB"
        Me.coldgvSessionListDB.ReadOnly = True
        Me.coldgvSessionListDB.Width = 59
        '
        'coldgvSessionListPID
        '
        Me.coldgvSessionListPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListPID.DataPropertyName = "PROCESS_ID"
        Me.coldgvSessionListPID.HeaderText = "F082"
        Me.coldgvSessionListPID.Name = "coldgvSessionListPID"
        Me.coldgvSessionListPID.ReadOnly = True
        Me.coldgvSessionListPID.Width = 59
        '
        'coldgvSessionListCpuUsage
        '
        Me.coldgvSessionListCpuUsage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListCpuUsage.DataPropertyName = "CPU_USAGE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.coldgvSessionListCpuUsage.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvSessionListCpuUsage.HeaderText = "F092"
        Me.coldgvSessionListCpuUsage.Name = "coldgvSessionListCpuUsage"
        Me.coldgvSessionListCpuUsage.ReadOnly = True
        Me.coldgvSessionListCpuUsage.Width = 59
        '
        'coldgvSessionListStTime
        '
        Me.coldgvSessionListStTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListStTime.DataPropertyName = "START_TIME"
        DataGridViewCellStyle4.Format = "HH:mm:ss"
        Me.coldgvSessionListStTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvSessionListStTime.FillWeight = 130.0!
        Me.coldgvSessionListStTime.HeaderText = "F050"
        Me.coldgvSessionListStTime.MinimumWidth = 130
        Me.coldgvSessionListStTime.Name = "coldgvSessionListStTime"
        Me.coldgvSessionListStTime.ReadOnly = True
        Me.coldgvSessionListStTime.Width = 130
        '
        'coldgvSessionListElapsedTime
        '
        Me.coldgvSessionListElapsedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListElapsedTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Seconds
        Me.coldgvSessionListElapsedTime.DataPropertyName = "ELAPSED_TIME"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "12"
        Me.coldgvSessionListElapsedTime.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvSessionListElapsedTime.FillWeight = 130.0!
        Me.coldgvSessionListElapsedTime.FormatString = "dd\ \d\a\y\ hh\:mm\:ss\.ff"
        Me.coldgvSessionListElapsedTime.HeaderText = "F051"
        Me.coldgvSessionListElapsedTime.MinimumWidth = 130
        Me.coldgvSessionListElapsedTime.Name = "coldgvSessionListElapsedTime"
        Me.coldgvSessionListElapsedTime.ReadOnly = True
        Me.coldgvSessionListElapsedTime.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListElapsedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListElapsedTime.Width = 130
        '
        'coldgvSessionListStatus
        '
        Me.coldgvSessionListStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListStatus.DataPropertyName = "STATE"
        Me.coldgvSessionListStatus.HeaderText = "F247"
        Me.coldgvSessionListStatus.MinimumWidth = 60
        Me.coldgvSessionListStatus.Name = "coldgvSessionListStatus"
        Me.coldgvSessionListStatus.ReadOnly = True
        Me.coldgvSessionListStatus.Width = 60
        '
        'coldgvSessionListUser
        '
        Me.coldgvSessionListUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvSessionListUser.DataPropertyName = "USER_NAME"
        Me.coldgvSessionListUser.HeaderText = "F008"
        Me.coldgvSessionListUser.MinimumWidth = 80
        Me.coldgvSessionListUser.Name = "coldgvSessionListUser"
        Me.coldgvSessionListUser.ReadOnly = True
        Me.coldgvSessionListUser.Width = 80
        '
        'coldgvSessionListClient
        '
        Me.coldgvSessionListClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvSessionListClient.DataPropertyName = "CLIENT_ADDR"
        Me.coldgvSessionListClient.FillWeight = 120.0!
        Me.coldgvSessionListClient.HeaderText = "F248"
        Me.coldgvSessionListClient.MinimumWidth = 100
        Me.coldgvSessionListClient.Name = "coldgvSessionListClient"
        Me.coldgvSessionListClient.ReadOnly = True
        '
        'coldgvSessionListApp
        '
        Me.coldgvSessionListApp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvSessionListApp.DataPropertyName = "CLIENT_APP"
        Me.coldgvSessionListApp.HeaderText = "F249"
        Me.coldgvSessionListApp.MinimumWidth = 100
        Me.coldgvSessionListApp.Name = "coldgvSessionListApp"
        Me.coldgvSessionListApp.ReadOnly = True
        '
        'coldgvSessionListRead
        '
        Me.coldgvSessionListRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListRead.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvSessionListRead.DataPropertyName = "CURRENT_PROC_READ_KB"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N1"
        Me.coldgvSessionListRead.DefaultCellStyle = DataGridViewCellStyle6
        Me.coldgvSessionListRead.HeaderText = "F048"
        Me.coldgvSessionListRead.HeaderWord = ""
        Me.coldgvSessionListRead.MinimumWidth = 100
        Me.coldgvSessionListRead.Name = "coldgvSessionListRead"
        Me.coldgvSessionListRead.ReadOnly = True
        Me.coldgvSessionListRead.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListRead.ShowUnit = True
        Me.coldgvSessionListRead.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListRead.TailWord = ""
        '
        'coldgvSessionListWrite
        '
        Me.coldgvSessionListWrite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvSessionListWrite.BaseUnit = eXperDB.Controls.DataGridViewDataSizeCell.SizeUnit.KB
        Me.coldgvSessionListWrite.DataPropertyName = "CURRENT_PROC_WRITE_KB"
        DataGridViewCellStyle7.Format = "N1"
        Me.coldgvSessionListWrite.DefaultCellStyle = DataGridViewCellStyle7
        Me.coldgvSessionListWrite.HeaderText = "F136"
        Me.coldgvSessionListWrite.HeaderWord = ""
        Me.coldgvSessionListWrite.MinimumWidth = 100
        Me.coldgvSessionListWrite.Name = "coldgvSessionListWrite"
        Me.coldgvSessionListWrite.ReadOnly = True
        Me.coldgvSessionListWrite.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvSessionListWrite.ShowUnit = True
        Me.coldgvSessionListWrite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvSessionListWrite.TailWord = ""
        '
        'coldgvSessionListSQL
        '
        Me.coldgvSessionListSQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvSessionListSQL.DataPropertyName = "SQL"
        Me.coldgvSessionListSQL.HeaderText = "F052"
        Me.coldgvSessionListSQL.MinimumWidth = 120
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
        Me.colDgvSessionlistRegDate.Width = 98
        '
        'colDgvSessionListActvRegSeq
        '
        Me.colDgvSessionListActvRegSeq.DataPropertyName = "ACTV_REG_SEQ"
        Me.colDgvSessionListActvRegSeq.HeaderText = "ACTV_REG_SEQ"
        Me.colDgvSessionListActvRegSeq.Name = "colDgvSessionListActvRegSeq"
        Me.colDgvSessionListActvRegSeq.ReadOnly = True
        Me.colDgvSessionListActvRegSeq.Visible = False
        Me.colDgvSessionListActvRegSeq.Width = 132
        '
        'dgvLock
        '
        Me.dgvLock.AllowUserToAddRows = False
        Me.dgvLock.AllowUserToDeleteRows = False
        Me.dgvLock.AllowUserToOrderColumns = True
        Me.dgvLock.AllowUserToResizeRows = False
        Me.dgvLock.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.Font = New System.Drawing.Font("굴림", 10.07326!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvLock.ColumnHeadersHeight = 30
        Me.dgvLock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvLockDB, Me.colDgvLockBlockingPID, Me.colDgvLockBlockingUser, Me.colDgvLockBlockingQuery, Me.colDgvLockBlockedPID, Me.colDgvLockBlockedUser, Me.colDgvLockBlockedQuery, Me.colDgvLockMode, Me.colDgvLockElapse, Me.colDgvLockQueryStart, Me.colDgvLockXactStart, Me.colDgvLockRegDate, Me.colDgvLockActvRegSeq})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Font = New System.Drawing.Font("굴림", 10.07326!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLock.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvLock.EnableHeadersVisualStyles = False
        Me.dgvLock.Font = New System.Drawing.Font("굴림", 10.07326!)
        Me.dgvLock.GridColor = System.Drawing.Color.Gray
        Me.dgvLock.ImageList = Nothing
        Me.dgvLock.Location = New System.Drawing.Point(0, 40)
        Me.dgvLock.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLock.Name = "dgvLock"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLock.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLock.RowHeadersVisible = False
        Me.dgvLock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLock.Size = New System.Drawing.Size(1019, 197)
        Me.dgvLock.TabIndex = 9
        '
        'colDgvLockDB
        '
        Me.colDgvLockDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockDB.DataPropertyName = "DB_NAME"
        Me.colDgvLockDB.DefaultNodeImage = Nothing
        Me.colDgvLockDB.FillWeight = 150.0!
        Me.colDgvLockDB.HeaderText = "F104"
        Me.colDgvLockDB.Name = "colDgvLockDB"
        Me.colDgvLockDB.ReadOnly = True
        Me.colDgvLockDB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockDB.Width = 44
        '
        'colDgvLockBlockingPID
        '
        Me.colDgvLockBlockingPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockingPID.DataPropertyName = "BLOCKING_PID"
        Me.colDgvLockBlockingPID.FillWeight = 102.0!
        Me.colDgvLockBlockingPID.HeaderText = "F197"
        Me.colDgvLockBlockingPID.Name = "colDgvLockBlockingPID"
        Me.colDgvLockBlockingPID.ReadOnly = True
        Me.colDgvLockBlockingPID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDgvLockBlockingPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockingPID.Width = 44
        '
        'colDgvLockBlockingUser
        '
        Me.colDgvLockBlockingUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockingUser.DataPropertyName = "BLOCKING_USER"
        Me.colDgvLockBlockingUser.FillWeight = 130.0!
        Me.colDgvLockBlockingUser.HeaderText = "F134"
        Me.colDgvLockBlockingUser.Name = "colDgvLockBlockingUser"
        Me.colDgvLockBlockingUser.ReadOnly = True
        Me.colDgvLockBlockingUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockingUser.Width = 44
        '
        'colDgvLockBlockingQuery
        '
        Me.colDgvLockBlockingQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvLockBlockingQuery.DataPropertyName = "BLOCKING_QUERY"
        Me.colDgvLockBlockingQuery.FillWeight = 200.0!
        Me.colDgvLockBlockingQuery.HeaderText = "F084"
        Me.colDgvLockBlockingQuery.MinimumWidth = 120
        Me.colDgvLockBlockingQuery.Name = "colDgvLockBlockingQuery"
        Me.colDgvLockBlockingQuery.ReadOnly = True
        Me.colDgvLockBlockingQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedPID
        '
        Me.colDgvLockBlockedPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockBlockedPID.DataPropertyName = "BLOCKED_PID"
        Me.colDgvLockBlockedPID.FillWeight = 102.0!
        Me.colDgvLockBlockedPID.HeaderText = "F195"
        Me.colDgvLockBlockedPID.Name = "colDgvLockBlockedPID"
        Me.colDgvLockBlockedPID.ReadOnly = True
        Me.colDgvLockBlockedPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockBlockedPID.Width = 44
        '
        'colDgvLockBlockedUser
        '
        Me.colDgvLockBlockedUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colDgvLockBlockedUser.DataPropertyName = "BLOCKED_USER"
        Me.colDgvLockBlockedUser.FillWeight = 130.0!
        Me.colDgvLockBlockedUser.HeaderText = "F196"
        Me.colDgvLockBlockedUser.Name = "colDgvLockBlockedUser"
        Me.colDgvLockBlockedUser.ReadOnly = True
        Me.colDgvLockBlockedUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockBlockedQuery
        '
        Me.colDgvLockBlockedQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDgvLockBlockedQuery.DataPropertyName = "BLOCKED_QUERY"
        Me.colDgvLockBlockedQuery.FillWeight = 200.0!
        Me.colDgvLockBlockedQuery.HeaderText = "F221"
        Me.colDgvLockBlockedQuery.MinimumWidth = 120
        Me.colDgvLockBlockedQuery.Name = "colDgvLockBlockedQuery"
        Me.colDgvLockBlockedQuery.ReadOnly = True
        Me.colDgvLockBlockedQuery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDgvLockMode
        '
        Me.colDgvLockMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockMode.DataPropertyName = "LOCK_MODE"
        Me.colDgvLockMode.FillWeight = 130.0!
        Me.colDgvLockMode.HeaderText = "F222"
        Me.colDgvLockMode.Name = "colDgvLockMode"
        Me.colDgvLockMode.ReadOnly = True
        Me.colDgvLockMode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockMode.Width = 44
        '
        'colDgvLockElapse
        '
        Me.colDgvLockElapse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockElapse.DataPropertyName = "BLOCKED_DURATION"
        Me.colDgvLockElapse.FillWeight = 120.0!
        Me.colDgvLockElapse.HeaderText = "F135"
        Me.colDgvLockElapse.Name = "colDgvLockElapse"
        Me.colDgvLockElapse.ReadOnly = True
        Me.colDgvLockElapse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockElapse.Width = 44
        '
        'colDgvLockQueryStart
        '
        Me.colDgvLockQueryStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockQueryStart.DataPropertyName = "QUERY_START"
        Me.colDgvLockQueryStart.FillWeight = 163.0!
        Me.colDgvLockQueryStart.HeaderText = "F223"
        Me.colDgvLockQueryStart.Name = "colDgvLockQueryStart"
        Me.colDgvLockQueryStart.ReadOnly = True
        Me.colDgvLockQueryStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockQueryStart.Width = 44
        '
        'colDgvLockXactStart
        '
        Me.colDgvLockXactStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDgvLockXactStart.DataPropertyName = "XACT_START"
        Me.colDgvLockXactStart.FillWeight = 163.0!
        Me.colDgvLockXactStart.HeaderText = "F224"
        Me.colDgvLockXactStart.Name = "colDgvLockXactStart"
        Me.colDgvLockXactStart.ReadOnly = True
        Me.colDgvLockXactStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDgvLockXactStart.Width = 44
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
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnExcel, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnHistory, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPause, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnStop, 4, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1019, 50)
        Me.TableLayoutPanel2.TabIndex = 16
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
        Me.MsgLabel.Size = New System.Drawing.Size(753, 50)
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
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgvSessionList)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgvLock)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1019, 569)
        Me.SplitContainer2.SplitterDistance = 328
        Me.SplitContainer2.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cmbStatus, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.grpSession, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1019, 40)
        Me.TableLayoutPanel1.TabIndex = 0
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
        'grpSession
        '
        Me.grpSession.AutoSize = True
        Me.grpSession.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSession.ForeColor = System.Drawing.Color.White
        Me.grpSession.Location = New System.Drawing.Point(43, 0)
        Me.grpSession.Name = "grpSession"
        Me.grpSession.Size = New System.Drawing.Size(853, 40)
        Me.grpSession.TabIndex = 3
        Me.grpSession.Text = "F313"
        Me.grpSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.grpLockInfo, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1019, 40)
        Me.TableLayoutPanel3.TabIndex = 1
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
        'grpLockInfo
        '
        Me.grpLockInfo.AutoSize = True
        Me.grpLockInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpLockInfo.ForeColor = System.Drawing.Color.White
        Me.grpLockInfo.Location = New System.Drawing.Point(43, 0)
        Me.grpLockInfo.Name = "grpLockInfo"
        Me.grpLockInfo.Size = New System.Drawing.Size(973, 40)
        Me.grpLockInfo.TabIndex = 3
        Me.grpLockInfo.Text = "F077"
        Me.grpLockInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSessionLock
        '
        Me.AutoSize = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1019, 619)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSessionLock"
        Me.Text = "Session Management"
        CType(Me.dgvSessionList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents btnPause As eXperDB.BaseControls.Button
    Friend WithEvents dgvLock As AdvancedDataGridView.TreeGridView
    Friend WithEvents dgvSessionList As eXperDB.BaseControls.DataGridView
    Friend WithEvents btnCancel As eXperDB.BaseControls.Button
    Friend WithEvents btnStop As eXperDB.BaseControls.Button
    Friend WithEvents cmbStatus As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnHistory As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As eXperDB.BaseControls.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpSession As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpLockInfo As System.Windows.Forms.Label
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
    Friend WithEvents colDgvSessionlistRegDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvSessionListActvRegSeq As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
