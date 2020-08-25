<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportHistory
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportHistory))
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.lblClusters = New eXperDB.BaseControls.Label()
        Me.cmbClusters = New eXperDB.BaseControls.ComboBox()
        Me.cmbUserName = New eXperDB.BaseControls.ComboBox()
        Me.lblUserName = New eXperDB.BaseControls.Label()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.cmbAction = New eXperDB.BaseControls.ComboBox()
        Me.cmbUserID = New eXperDB.BaseControls.ComboBox()
        Me.lblAction = New eXperDB.BaseControls.Label()
        Me.lblUserID = New eXperDB.BaseControls.Label()
        Me.dgvReportLog = New eXperDB.BaseControls.DataGridView()
        Me.coldgvReportLogCluster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogActionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogActionDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogUserIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvReportLogDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReportHistory = New System.Windows.Forms.Label()
        Me.tlpUserConfigMain.SuspendLayout()
        Me.tlpSearch.SuspendLayout()
        CType(Me.dgvReportLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "F033"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 130
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INSTANCE_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "coldgvAlertINSTANCEID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HCHK_REG_SEQ"
        Me.DataGridViewTextBoxColumn3.HeaderText = "coldgvAlertHCHKREGREQ"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "REG_DATE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "colRegDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "COLLECT_TIME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn5.HeaderText = "F257"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 170
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 170
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "HCHK_NAME"
        Me.DataGridViewTextBoxColumn6.FillWeight = 120.5725!
        Me.DataGridViewTextBoxColumn6.HeaderText = "F258"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 120
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STATE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn7.HeaderText = "F247"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VALUE"
        Me.DataGridViewTextBoxColumn8.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "F259"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "CHECK_USER_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "F262"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "CHECK_COMMENT"
        Me.DataGridViewTextBoxColumn10.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "F260"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 200
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CHECK_IP"
        Me.DataGridViewTextBoxColumn11.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "F266"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "CHECK_DT"
        Me.DataGridViewTextBoxColumn12.FillWeight = 170.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "F261"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 170
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpUserConfigMain.ColumnCount = 3
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24138!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.24138!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.51724!))
        Me.tlpUserConfigMain.Controls.Add(Me.tlpSearch, 0, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.dgvReportLog, 0, 2)
        Me.tlpUserConfigMain.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 4
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(1148, 657)
        Me.tlpUserConfigMain.TabIndex = 4
        '
        'tlpSearch
        '
        Me.tlpSearch.BackColor = System.Drawing.Color.Transparent
        Me.tlpSearch.ColumnCount = 14
        Me.tlpUserConfigMain.SetColumnSpan(Me.tlpSearch, 3)
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSearch.Controls.Add(Me.lblClusters, 0, 0)
        Me.tlpSearch.Controls.Add(Me.cmbClusters, 1, 0)
        Me.tlpSearch.Controls.Add(Me.cmbUserName, 5, 0)
        Me.tlpSearch.Controls.Add(Me.lblUserName, 4, 0)
        Me.tlpSearch.Controls.Add(Me.lblDuration, 8, 0)
        Me.tlpSearch.Controls.Add(Me.dtpEd, 11, 0)
        Me.tlpSearch.Controls.Add(Me.dtpSt, 9, 0)
        Me.tlpSearch.Controls.Add(Me.cmbAction, 7, 0)
        Me.tlpSearch.Controls.Add(Me.cmbUserID, 3, 0)
        Me.tlpSearch.Controls.Add(Me.lblAction, 6, 0)
        Me.tlpSearch.Controls.Add(Me.lblUserID, 2, 0)
        Me.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSearch.Location = New System.Drawing.Point(3, 43)
        Me.tlpSearch.Name = "tlpSearch"
        Me.tlpSearch.RowCount = 1
        Me.tlpSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSearch.Size = New System.Drawing.Size(1142, 34)
        Me.tlpSearch.TabIndex = 27
        '
        'lblClusters
        '
        Me.lblClusters.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblClusters.FixedHeight = False
        Me.lblClusters.FixedWidth = False
        Me.lblClusters.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblClusters.ForeColor = System.Drawing.Color.White
        Me.lblClusters.LineSpacing = 0.0!
        Me.lblClusters.Location = New System.Drawing.Point(3, 8)
        Me.lblClusters.Name = "lblClusters"
        Me.lblClusters.Size = New System.Drawing.Size(74, 26)
        Me.lblClusters.TabIndex = 31
        Me.lblClusters.Text = "F146"
        Me.lblClusters.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbClusters
        '
        Me.cmbClusters.BackColor = System.Drawing.SystemColors.Window
        Me.cmbClusters.DisplayMember = "All"
        Me.cmbClusters.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbClusters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClusters.FixedWidth = False
        Me.cmbClusters.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClusters.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.cmbClusters.FormattingEnabled = True
        Me.cmbClusters.Location = New System.Drawing.Point(83, 10)
        Me.cmbClusters.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbClusters.Name = "cmbClusters"
        Me.cmbClusters.Necessary = False
        Me.cmbClusters.Size = New System.Drawing.Size(94, 20)
        Me.cmbClusters.StatusTip = ""
        Me.cmbClusters.TabIndex = 30
        Me.cmbClusters.ValueText = ""
        '
        'cmbUserName
        '
        Me.cmbUserName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUserName.DisplayMember = "All"
        Me.cmbUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbUserName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserName.FixedWidth = False
        Me.cmbUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUserName.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.cmbUserName.FormattingEnabled = True
        Me.cmbUserName.Location = New System.Drawing.Point(443, 10)
        Me.cmbUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUserName.Name = "cmbUserName"
        Me.cmbUserName.Necessary = False
        Me.cmbUserName.Size = New System.Drawing.Size(94, 20)
        Me.cmbUserName.StatusTip = ""
        Me.cmbUserName.TabIndex = 29
        Me.cmbUserName.ValueText = ""
        '
        'lblUserName
        '
        Me.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserName.FixedHeight = False
        Me.lblUserName.FixedWidth = False
        Me.lblUserName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.LineSpacing = 0.0!
        Me.lblUserName.Location = New System.Drawing.Point(363, 8)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 26)
        Me.lblUserName.TabIndex = 28
        Me.lblUserName.Text = "F348"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.White
        Me.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration.LineSpacing = 0.0!
        Me.lblDuration.Location = New System.Drawing.Point(723, 8)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(74, 26)
        Me.lblDuration.TabIndex = 26
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(978, 9)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(150, 21)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 22
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(803, 9)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(150, 21)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 20
        Me.dtpSt.Value = New Date(2018, 3, 19, 15, 15, 0, 0)
        '
        'cmbAction
        '
        Me.cmbAction.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAction.DisplayMember = "All"
        Me.cmbAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAction.FixedWidth = False
        Me.cmbAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbAction.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.cmbAction.FormattingEnabled = True
        Me.cmbAction.Items.AddRange(New Object() {"All", "login ", "logout ", "change user", "change pwd ", "single cluster", "cancel query ", "kill session"})
        Me.cmbAction.Location = New System.Drawing.Point(623, 10)
        Me.cmbAction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbAction.Name = "cmbAction"
        Me.cmbAction.Necessary = False
        Me.cmbAction.Size = New System.Drawing.Size(94, 20)
        Me.cmbAction.StatusTip = ""
        Me.cmbAction.TabIndex = 19
        Me.cmbAction.ValueText = ""
        '
        'cmbUserID
        '
        Me.cmbUserID.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUserID.DisplayMember = "All"
        Me.cmbUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserID.FixedWidth = False
        Me.cmbUserID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUserID.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.cmbUserID.FormattingEnabled = True
        Me.cmbUserID.Location = New System.Drawing.Point(263, 10)
        Me.cmbUserID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUserID.Name = "cmbUserID"
        Me.cmbUserID.Necessary = False
        Me.cmbUserID.Size = New System.Drawing.Size(94, 20)
        Me.cmbUserID.StatusTip = ""
        Me.cmbUserID.TabIndex = 18
        Me.cmbUserID.ValueText = ""
        '
        'lblAction
        '
        Me.lblAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAction.FixedHeight = False
        Me.lblAction.FixedWidth = False
        Me.lblAction.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.White
        Me.lblAction.LineSpacing = 0.0!
        Me.lblAction.Location = New System.Drawing.Point(543, 8)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(74, 26)
        Me.lblAction.TabIndex = 2
        Me.lblAction.Text = "ReportType"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserID
        '
        Me.lblUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserID.FixedHeight = False
        Me.lblUserID.FixedWidth = False
        Me.lblUserID.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.LineSpacing = 0.0!
        Me.lblUserID.Location = New System.Drawing.Point(183, 8)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(74, 26)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "F347"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvReportLog
        '
        Me.dgvReportLog.AllowUserToAddRows = False
        Me.dgvReportLog.AllowUserToDeleteRows = False
        Me.dgvReportLog.AllowUserToResizeRows = False
        Me.dgvReportLog.BackgroundColor = System.Drawing.Color.Black
        Me.dgvReportLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReportLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvReportLog.ColumnHeadersHeight = 24
        Me.dgvReportLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReportLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvReportLogCluster, Me.coldgvReportLogUserID, Me.coldgvReportLogUserName, Me.coldgvReportLogActionType, Me.coldgvReportLogActionDT, Me.coldgvReportLogUserIP, Me.coldgvReportLogStatus, Me.coldgvReportLogDetail})
        Me.tlpUserConfigMain.SetColumnSpan(Me.dgvReportLog, 3)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReportLog.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvReportLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvReportLog.EnableHeadersVisualStyles = False
        Me.dgvReportLog.GridColor = System.Drawing.Color.Black
        Me.dgvReportLog.Location = New System.Drawing.Point(3, 83)
        Me.dgvReportLog.Name = "dgvReportLog"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReportLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReportLog.RowHeadersVisible = False
        Me.dgvReportLog.RowTemplate.Height = 23
        Me.dgvReportLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportLog.Size = New System.Drawing.Size(1142, 570)
        Me.dgvReportLog.TabIndex = 25
        Me.dgvReportLog.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvReportLog.UseTagValueMatchColor = True
        '
        'coldgvReportLogCluster
        '
        Me.coldgvReportLogCluster.DataPropertyName = "HOST_NAME"
        Me.coldgvReportLogCluster.HeaderText = "F229"
        Me.coldgvReportLogCluster.MinimumWidth = 140
        Me.coldgvReportLogCluster.Name = "coldgvReportLogCluster"
        Me.coldgvReportLogCluster.ReadOnly = True
        Me.coldgvReportLogCluster.Visible = False
        Me.coldgvReportLogCluster.Width = 140
        '
        'coldgvReportLogUserID
        '
        Me.coldgvReportLogUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvReportLogUserID.DataPropertyName = "USER_ID"
        Me.coldgvReportLogUserID.HeaderText = "F347"
        Me.coldgvReportLogUserID.MinimumWidth = 120
        Me.coldgvReportLogUserID.Name = "coldgvReportLogUserID"
        Me.coldgvReportLogUserID.ReadOnly = True
        Me.coldgvReportLogUserID.Width = 120
        '
        'coldgvReportLogUserName
        '
        Me.coldgvReportLogUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvReportLogUserName.DataPropertyName = "USER_NAME"
        Me.coldgvReportLogUserName.HeaderText = "F348"
        Me.coldgvReportLogUserName.MinimumWidth = 120
        Me.coldgvReportLogUserName.Name = "coldgvReportLogUserName"
        Me.coldgvReportLogUserName.ReadOnly = True
        Me.coldgvReportLogUserName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvReportLogUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvReportLogUserName.Width = 120
        '
        'coldgvReportLogActionType
        '
        Me.coldgvReportLogActionType.DataPropertyName = "REPORT_TYPE"
        Me.coldgvReportLogActionType.HeaderText = "F937"
        Me.coldgvReportLogActionType.MinimumWidth = 120
        Me.coldgvReportLogActionType.Name = "coldgvReportLogActionType"
        Me.coldgvReportLogActionType.ReadOnly = True
        Me.coldgvReportLogActionType.Width = 120
        '
        'coldgvReportLogActionDT
        '
        Me.coldgvReportLogActionDT.DataPropertyName = "REPORT_DT"
        Me.coldgvReportLogActionDT.HeaderText = "F936"
        Me.coldgvReportLogActionDT.MinimumWidth = 140
        Me.coldgvReportLogActionDT.Name = "coldgvReportLogActionDT"
        Me.coldgvReportLogActionDT.ReadOnly = True
        Me.coldgvReportLogActionDT.Width = 140
        '
        'coldgvReportLogUserIP
        '
        Me.coldgvReportLogUserIP.DataPropertyName = "REPORT_IP"
        Me.coldgvReportLogUserIP.HeaderText = "F935"
        Me.coldgvReportLogUserIP.MinimumWidth = 140
        Me.coldgvReportLogUserIP.Name = "coldgvReportLogUserIP"
        Me.coldgvReportLogUserIP.ReadOnly = True
        Me.coldgvReportLogUserIP.Width = 140
        '
        'coldgvReportLogStatus
        '
        Me.coldgvReportLogStatus.DataPropertyName = "REPORT_ACTION"
        Me.coldgvReportLogStatus.HeaderText = "F247"
        Me.coldgvReportLogStatus.MinimumWidth = 100
        Me.coldgvReportLogStatus.Name = "coldgvReportLogStatus"
        Me.coldgvReportLogStatus.ReadOnly = True
        '
        'coldgvReportLogDetail
        '
        Me.coldgvReportLogDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvReportLogDetail.DataPropertyName = "REPORT_LOG"
        Me.coldgvReportLogDetail.HeaderText = "F357"
        Me.coldgvReportLogDetail.MinimumWidth = 150
        Me.coldgvReportLogDetail.Name = "coldgvReportLogDetail"
        Me.coldgvReportLogDetail.ReadOnly = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.tlpUserConfigMain.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnExcel, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnQuery, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblReportHistory, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1142, 34)
        Me.TableLayoutPanel2.TabIndex = 28
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Silver
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.Yellow
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.LineColor = System.Drawing.Color.LightGray
        Me.btnExcel.Location = New System.Drawing.Point(1105, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(34, 28)
        Me.btnExcel.TabIndex = 31
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.LightGray
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(1065, 3)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(34, 28)
        Me.btnQuery.TabIndex = 29
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "      "
        '
        'lblReportHistory
        '
        Me.lblReportHistory.AutoSize = True
        Me.lblReportHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblReportHistory.ForeColor = System.Drawing.Color.White
        Me.lblReportHistory.Location = New System.Drawing.Point(43, 0)
        Me.lblReportHistory.Name = "lblReportHistory"
        Me.lblReportHistory.Size = New System.Drawing.Size(1016, 34)
        Me.lblReportHistory.TabIndex = 4
        Me.lblReportHistory.Text = "M075"
        Me.lblReportHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmReportHistory
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1148, 657)
        Me.Controls.Add(Me.tlpUserConfigMain)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmReportHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report history"
        Me.tlpUserConfigMain.ResumeLayout(False)
        Me.tlpSearch.ResumeLayout(False)
        CType(Me.dgvReportLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpSearch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbUserName As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblUserName As eXperDB.BaseControls.Label
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents cmbAction As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbUserID As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblAction As eXperDB.BaseControls.Label
    Friend WithEvents lblUserID As eXperDB.BaseControls.Label
    Friend WithEvents dgvReportLog As eXperDB.BaseControls.DataGridView
    Friend WithEvents lblClusters As eXperDB.BaseControls.Label
    Friend WithEvents cmbClusters As eXperDB.BaseControls.ComboBox
    Friend WithEvents coldgvReportLogCluster As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogUserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogActionType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogActionDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogUserIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvReportLogDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblReportHistory As System.Windows.Forms.Label

End Class
