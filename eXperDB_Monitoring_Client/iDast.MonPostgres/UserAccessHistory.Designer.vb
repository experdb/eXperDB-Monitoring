<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserAccessHistory
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAccessHistory))
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPercentageColumn1 = New eXperDB.Controls.DataGridViewPercentageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvActionLog = New eXperDB.BaseControls.DataGridView()
        Me.coldgvActionLogUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogActionType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogActionDT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogUserIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogCluster = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogClusterIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvActionLogDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSearch = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbUserName = New eXperDB.BaseControls.ComboBox()
        Me.lblUserName = New eXperDB.BaseControls.Label()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.cmbAction = New eXperDB.BaseControls.ComboBox()
        Me.cmbUserID = New eXperDB.BaseControls.ComboBox()
        Me.lblAction = New eXperDB.BaseControls.Label()
        Me.lblUserID = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSearch = New eXperDB.BaseControls.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAccessHistory = New System.Windows.Forms.Label()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnExcel = New eXperDB.BaseControls.Button()
        CType(Me.dgvActionLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpUserConfigMain.SuspendLayout()
        Me.tlpSearch.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alert Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Biz day"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 120.5725!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Biz hour"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewPercentageColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.DataGridViewPercentageColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPercentageColumn1.HeaderText = "Alert Level"
        Me.DataGridViewPercentageColumn1.MinimumWidth = 180
        Me.DataGridViewPercentageColumn1.Name = "DataGridViewPercentageColumn1"
        Me.DataGridViewPercentageColumn1.ReadOnly = True
        Me.DataGridViewPercentageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPercentageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPercentageColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RETENTION_TIME"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Alert Level"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RETENTION_TIME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alert duration"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CHECK_USER_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cycle"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 95
        '
        'dgvActionLog
        '
        Me.dgvActionLog.AllowUserToAddRows = False
        Me.dgvActionLog.AllowUserToDeleteRows = False
        Me.dgvActionLog.AllowUserToResizeRows = False
        Me.dgvActionLog.BackgroundColor = System.Drawing.Color.Black
        Me.dgvActionLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActionLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvActionLog.ColumnHeadersHeight = 24
        Me.dgvActionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActionLog.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvActionLogUserID, Me.coldgvActionLogUserName, Me.coldgvActionLogActionType, Me.coldgvActionLogActionDT, Me.coldgvActionLogUserIP, Me.coldgvActionLogCluster, Me.coldgvActionLogClusterIP, Me.coldgvActionLogStatus, Me.coldgvActionLogDetail})
        Me.tlpUserConfigMain.SetColumnSpan(Me.dgvActionLog, 3)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActionLog.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActionLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActionLog.EnableHeadersVisualStyles = False
        Me.dgvActionLog.GridColor = System.Drawing.Color.Black
        Me.dgvActionLog.Location = New System.Drawing.Point(3, 83)
        Me.dgvActionLog.Name = "dgvActionLog"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActionLog.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvActionLog.RowHeadersVisible = False
        Me.dgvActionLog.RowTemplate.Height = 23
        Me.dgvActionLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActionLog.Size = New System.Drawing.Size(1155, 605)
        Me.dgvActionLog.TabIndex = 25
        Me.dgvActionLog.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvActionLog.UseTagValueMatchColor = True
        '
        'coldgvActionLogUserID
        '
        Me.coldgvActionLogUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvActionLogUserID.DataPropertyName = "USER_ID"
        Me.coldgvActionLogUserID.HeaderText = "F347"
        Me.coldgvActionLogUserID.MinimumWidth = 120
        Me.coldgvActionLogUserID.Name = "coldgvActionLogUserID"
        Me.coldgvActionLogUserID.ReadOnly = True
        Me.coldgvActionLogUserID.Width = 120
        '
        'coldgvActionLogUserName
        '
        Me.coldgvActionLogUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.coldgvActionLogUserName.DataPropertyName = "USER_NAME"
        Me.coldgvActionLogUserName.HeaderText = "F348"
        Me.coldgvActionLogUserName.MinimumWidth = 120
        Me.coldgvActionLogUserName.Name = "coldgvActionLogUserName"
        Me.coldgvActionLogUserName.ReadOnly = True
        Me.coldgvActionLogUserName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvActionLogUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvActionLogUserName.Width = 120
        '
        'coldgvActionLogActionType
        '
        Me.coldgvActionLogActionType.DataPropertyName = "ACCESS_TYPE"
        Me.coldgvActionLogActionType.HeaderText = "F937"
        Me.coldgvActionLogActionType.MinimumWidth = 120
        Me.coldgvActionLogActionType.Name = "coldgvActionLogActionType"
        Me.coldgvActionLogActionType.ReadOnly = True
        Me.coldgvActionLogActionType.Width = 120
        '
        'coldgvActionLogActionDT
        '
        Me.coldgvActionLogActionDT.DataPropertyName = "ACCESS_DT"
        Me.coldgvActionLogActionDT.HeaderText = "F936"
        Me.coldgvActionLogActionDT.MinimumWidth = 140
        Me.coldgvActionLogActionDT.Name = "coldgvActionLogActionDT"
        Me.coldgvActionLogActionDT.ReadOnly = True
        Me.coldgvActionLogActionDT.Width = 140
        '
        'coldgvActionLogUserIP
        '
        Me.coldgvActionLogUserIP.DataPropertyName = "ACCESS_IP"
        Me.coldgvActionLogUserIP.HeaderText = "F935"
        Me.coldgvActionLogUserIP.MinimumWidth = 140
        Me.coldgvActionLogUserIP.Name = "coldgvActionLogUserIP"
        Me.coldgvActionLogUserIP.ReadOnly = True
        Me.coldgvActionLogUserIP.Width = 140
        '
        'coldgvActionLogCluster
        '
        Me.coldgvActionLogCluster.DataPropertyName = "HOST_NAME"
        Me.coldgvActionLogCluster.HeaderText = "F229"
        Me.coldgvActionLogCluster.MinimumWidth = 140
        Me.coldgvActionLogCluster.Name = "coldgvActionLogCluster"
        Me.coldgvActionLogCluster.ReadOnly = True
        Me.coldgvActionLogCluster.Visible = False
        Me.coldgvActionLogCluster.Width = 140
        '
        'coldgvActionLogClusterIP
        '
        Me.coldgvActionLogClusterIP.DataPropertyName = "SERVER_IP"
        Me.coldgvActionLogClusterIP.HeaderText = "F006"
        Me.coldgvActionLogClusterIP.MinimumWidth = 120
        Me.coldgvActionLogClusterIP.Name = "coldgvActionLogClusterIP"
        Me.coldgvActionLogClusterIP.ReadOnly = True
        Me.coldgvActionLogClusterIP.Width = 120
        '
        'coldgvActionLogStatus
        '
        Me.coldgvActionLogStatus.DataPropertyName = "ACCESS_STATUS"
        Me.coldgvActionLogStatus.HeaderText = "F247"
        Me.coldgvActionLogStatus.MinimumWidth = 100
        Me.coldgvActionLogStatus.Name = "coldgvActionLogStatus"
        Me.coldgvActionLogStatus.ReadOnly = True
        '
        'coldgvActionLogDetail
        '
        Me.coldgvActionLogDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvActionLogDetail.DataPropertyName = "ACCESS_LOG"
        Me.coldgvActionLogDetail.HeaderText = "F357"
        Me.coldgvActionLogDetail.MinimumWidth = 150
        Me.coldgvActionLogDetail.Name = "coldgvActionLogDetail"
        Me.coldgvActionLogDetail.ReadOnly = True
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpUserConfigMain.ColumnCount = 3
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.Controls.Add(Me.tlpSearch, 0, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpUserConfigMain.Controls.Add(Me.dgvActionLog, 0, 2)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 4
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(1161, 692)
        Me.tlpUserConfigMain.TabIndex = 3
        '
        'tlpSearch
        '
        Me.tlpSearch.BackColor = System.Drawing.Color.Transparent
        Me.tlpSearch.ColumnCount = 13
        Me.tlpUserConfigMain.SetColumnSpan(Me.tlpSearch, 3)
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
        Me.tlpSearch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpSearch.Controls.Add(Me.cmbUserName, 3, 0)
        Me.tlpSearch.Controls.Add(Me.lblUserName, 2, 0)
        Me.tlpSearch.Controls.Add(Me.lblDuration, 6, 0)
        Me.tlpSearch.Controls.Add(Me.dtpEd, 9, 0)
        Me.tlpSearch.Controls.Add(Me.dtpSt, 7, 0)
        Me.tlpSearch.Controls.Add(Me.cmbAction, 5, 0)
        Me.tlpSearch.Controls.Add(Me.cmbUserID, 1, 0)
        Me.tlpSearch.Controls.Add(Me.lblAction, 4, 0)
        Me.tlpSearch.Controls.Add(Me.lblUserID, 0, 0)
        Me.tlpSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSearch.Location = New System.Drawing.Point(3, 43)
        Me.tlpSearch.Name = "tlpSearch"
        Me.tlpSearch.RowCount = 1
        Me.tlpSearch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSearch.Size = New System.Drawing.Size(1155, 34)
        Me.tlpSearch.TabIndex = 27
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
        Me.cmbUserName.Location = New System.Drawing.Point(263, 10)
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
        Me.lblUserName.Location = New System.Drawing.Point(183, 8)
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
        Me.lblDuration.Location = New System.Drawing.Point(543, 8)
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
        Me.dtpEd.Location = New System.Drawing.Point(798, 9)
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
        Me.dtpSt.Location = New System.Drawing.Point(623, 9)
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
        Me.cmbAction.Location = New System.Drawing.Point(443, 10)
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
        Me.cmbUserID.Location = New System.Drawing.Point(83, 10)
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
        Me.lblAction.Location = New System.Drawing.Point(363, 8)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(74, 26)
        Me.lblAction.TabIndex = 2
        Me.lblAction.Text = "Action"
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
        Me.lblUserID.Location = New System.Drawing.Point(3, 8)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(74, 26)
        Me.lblUserID.TabIndex = 1
        Me.lblUserID.Text = "F347"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.tlpUserConfigMain.SetColumnSpan(Me.TableLayoutPanel1, 3)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnExcel, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSearch, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAccessHistory, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1155, 34)
        Me.TableLayoutPanel1.TabIndex = 26
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSearch.FixedHeight = False
        Me.btnSearch.FixedWidth = False
        Me.btnSearch.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(1086, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Radius = 5
        Me.btnSearch.Size = New System.Drawing.Size(30, 28)
        Me.btnSearch.TabIndex = 28
        Me.btnSearch.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSearch.UseVisualStyleBackColor = False
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
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "      "
        '
        'lblAccessHistory
        '
        Me.lblAccessHistory.AutoSize = True
        Me.lblAccessHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccessHistory.ForeColor = System.Drawing.Color.White
        Me.lblAccessHistory.Location = New System.Drawing.Point(43, 0)
        Me.lblAccessHistory.Name = "lblAccessHistory"
        Me.lblAccessHistory.Size = New System.Drawing.Size(1001, 34)
        Me.lblAccessHistory.TabIndex = 3
        Me.lblAccessHistory.Text = "M075"
        Me.lblAccessHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnExcel.Location = New System.Drawing.Point(1122, 3)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(30, 28)
        Me.btnExcel.TabIndex = 29
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'UserAccessHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = true
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.Controls.Add(Me.tlpUserConfigMain)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserAccessHistory"
        Me.Size = New System.Drawing.Size(1161, 692)
        CType(Me.dgvActionLog,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpUserConfigMain.ResumeLayout(false)
        Me.tlpSearch.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPercentageColumn1 As eXperDB.Controls.DataGridViewPercentageColumn
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvActionLog As eXperDB.BaseControls.DataGridView
    Friend WithEvents tlpSearch As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAccessHistory As System.Windows.Forms.Label
    Friend WithEvents lblAction As eXperDB.BaseControls.Label
    Friend WithEvents lblUserID As eXperDB.BaseControls.Label
    Friend WithEvents cmbUserID As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbAction As eXperDB.BaseControls.ComboBox
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents lblUserName As eXperDB.BaseControls.Label
    Friend WithEvents cmbUserName As eXperDB.BaseControls.ComboBox
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents btnSearch As eXperDB.BaseControls.Button
    Friend WithEvents coldgvActionLogUserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogActionType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogActionDT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogUserIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogCluster As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogClusterIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvActionLogDetail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button

End Class
