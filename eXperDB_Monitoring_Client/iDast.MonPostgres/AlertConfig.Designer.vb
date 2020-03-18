<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertConfig))
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tlpGroup = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dgvSvrLst = New AdvancedDataGridView.TreeGridView()
        Me.coldgvHostName = New AdvancedDataGridView.TreeGridColumn()
        Me.coldgvHostNameKey = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvAliasNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvHARole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvHAHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblHead = New System.Windows.Forms.TableLayoutPanel()
        Me.lblServerList = New System.Windows.Forms.Label()
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnSaveAll = New eXperDB.BaseControls.Button()
        Me.btnInit = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.tlpAlertConfig = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dbmsImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.rbGrpHAGroup = New eXperDB.BaseControls.RadioButton()
        Me.rbGrpCluster = New eXperDB.BaseControls.RadioButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.tlpGroup.SuspendLayout()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHead.SuspendLayout()
        Me.tlpUserConfigMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpGroup)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tlpUserConfigMain)
        Me.SplitContainer1.Size = New System.Drawing.Size(1161, 692)
        Me.SplitContainer1.SplitterDistance = 280
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 20
        '
        'tlpGroup
        '
        Me.tlpGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpGroup.ColumnCount = 6
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpGroup.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpGroup.Controls.Add(Me.dgvSvrLst, 1, 2)
        Me.tlpGroup.Controls.Add(Me.tblHead, 0, 1)
        Me.tlpGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpGroup.Location = New System.Drawing.Point(0, 0)
        Me.tlpGroup.Name = "tlpGroup"
        Me.tlpGroup.RowCount = 4
        Me.tlpGroup.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpGroup.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.tlpGroup.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpGroup.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpGroup.Size = New System.Drawing.Size(278, 690)
        Me.tlpGroup.TabIndex = 13
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToResizeRows = False
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSvrLst.ColumnHeadersHeight = 24
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSvrLst.ColumnHeadersVisible = False
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvHostName, Me.coldgvHostNameKey, Me.coldgvAliasNm, Me.coldgvIP, Me.coldgvHARole, Me.coldgvHAHost})
        Me.tlpGroup.SetColumnSpan(Me.dgvSvrLst, 4)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Black
        Me.dgvSvrLst.HideExpandeIcon = False
        Me.dgvSvrLst.ImageList = Nothing
        Me.dgvSvrLst.Location = New System.Drawing.Point(13, 74)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.ShowLines = False
        Me.dgvSvrLst.Size = New System.Drawing.Size(257, 603)
        Me.dgvSvrLst.TabIndex = 31
        '
        'coldgvHostName
        '
        Me.coldgvHostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvHostName.DataPropertyName = "HOST_NAME"
        Me.coldgvHostName.DefaultNodeImage = Nothing
        Me.coldgvHostName.HeaderText = "F229"
        Me.coldgvHostName.Name = "coldgvHostName"
        Me.coldgvHostName.ReadOnly = True
        Me.coldgvHostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'coldgvHostNameKey
        '
        Me.coldgvHostNameKey.DataPropertyName = "HOST_NAME"
        Me.coldgvHostNameKey.HeaderText = ""
        Me.coldgvHostNameKey.Name = "coldgvHostNameKey"
        Me.coldgvHostNameKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvHostNameKey.Visible = False
        '
        'coldgvAliasNm
        '
        Me.coldgvAliasNm.DataPropertyName = "CONN_NAME"
        Me.coldgvAliasNm.HeaderText = "F019"
        Me.coldgvAliasNm.Name = "coldgvAliasNm"
        Me.coldgvAliasNm.ReadOnly = True
        Me.coldgvAliasNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvAliasNm.Visible = False
        '
        'coldgvIP
        '
        Me.coldgvIP.DataPropertyName = "SERVER_IP"
        Me.coldgvIP.HeaderText = "F006"
        Me.coldgvIP.Name = "coldgvIP"
        Me.coldgvIP.ReadOnly = True
        Me.coldgvIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvIP.Visible = False
        '
        'coldgvHARole
        '
        Me.coldgvHARole.DataPropertyName = "HA_ROLE"
        Me.coldgvHARole.HeaderText = "Column1"
        Me.coldgvHARole.Name = "coldgvHARole"
        Me.coldgvHARole.ReadOnly = True
        Me.coldgvHARole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvHARole.Visible = False
        '
        'coldgvHAHost
        '
        Me.coldgvHAHost.DataPropertyName = "HA_HOST"
        Me.coldgvHAHost.HeaderText = "Column1"
        Me.coldgvHAHost.Name = "coldgvHAHost"
        Me.coldgvHAHost.ReadOnly = True
        Me.coldgvHAHost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvHAHost.Visible = False
        '
        'tblHead
        '
        Me.tblHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tblHead.ColumnCount = 2
        Me.tlpGroup.SetColumnSpan(Me.tblHead, 6)
        Me.tblHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblHead.Controls.Add(Me.rbGrpCluster, 0, 2)
        Me.tblHead.Controls.Add(Me.rbGrpHAGroup, 0, 2)
        Me.tblHead.Controls.Add(Me.lblServerList, 0, 0)
        Me.tblHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblHead.Location = New System.Drawing.Point(3, 8)
        Me.tblHead.Name = "tblHead"
        Me.tblHead.RowCount = 3
        Me.tblHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.tblHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3.0!))
        Me.tblHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.tblHead.Size = New System.Drawing.Size(272, 60)
        Me.tblHead.TabIndex = 11
        '
        'lblServerList
        '
        Me.lblServerList.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tblHead.SetColumnSpan(Me.lblServerList, 2)
        Me.lblServerList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServerList.ForeColor = System.Drawing.Color.White
        Me.lblServerList.Location = New System.Drawing.Point(3, 0)
        Me.lblServerList.Name = "lblServerList"
        Me.lblServerList.Size = New System.Drawing.Size(266, 27)
        Me.lblServerList.TabIndex = 3
        Me.lblServerList.Text = "F941"
        Me.lblServerList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpUserConfigMain.ColumnCount = 7
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpUserConfigMain.Controls.Add(Me.btnSaveAll, 4, 2)
        Me.tlpUserConfigMain.Controls.Add(Me.btnInit, 3, 2)
        Me.tlpUserConfigMain.Controls.Add(Me.btnSave, 2, 2)
        Me.tlpUserConfigMain.Controls.Add(Me.tlpAlertConfig, 1, 0)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpUserConfigMain.MinimumSize = New System.Drawing.Size(860, 0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 4
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(878, 690)
        Me.tlpUserConfigMain.TabIndex = 3
        '
        'btnSaveAll
        '
        Me.btnSaveAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSaveAll.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSaveAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSaveAll.FixedHeight = False
        Me.btnSaveAll.FixedWidth = False
        Me.btnSaveAll.ForeColor = System.Drawing.Color.White
        Me.btnSaveAll.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSaveAll.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSaveAll.Location = New System.Drawing.Point(489, 650)
        Me.btnSaveAll.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Radius = 10
        Me.btnSaveAll.Size = New System.Drawing.Size(100, 35)
        Me.btnSaveAll.TabIndex = 13
        Me.btnSaveAll.Text = "F951"
        Me.btnSaveAll.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSaveAll.UseRound = True
        Me.btnSaveAll.UseVisualStyleBackColor = False
        '
        'btnInit
        '
        Me.btnInit.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnInit.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnInit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInit.FixedHeight = False
        Me.btnInit.FixedWidth = False
        Me.btnInit.ForeColor = System.Drawing.Color.White
        Me.btnInit.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnInit.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnInit.Location = New System.Drawing.Point(389, 650)
        Me.btnInit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnInit.Name = "btnInit"
        Me.btnInit.Radius = 10
        Me.btnInit.Size = New System.Drawing.Size(100, 35)
        Me.btnInit.TabIndex = 12
        Me.btnInit.Text = "F226"
        Me.btnInit.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInit.UseRound = True
        Me.btnInit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(289, 650)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(100, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tlpAlertConfig
        '
        Me.tlpAlertConfig.ColumnCount = 1
        Me.tlpUserConfigMain.SetColumnSpan(Me.tlpAlertConfig, 5)
        Me.tlpAlertConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlertConfig.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlertConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAlertConfig.Location = New System.Drawing.Point(5, 0)
        Me.tlpAlertConfig.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpAlertConfig.Name = "tlpAlertConfig"
        Me.tlpAlertConfig.RowCount = 1
        Me.tlpUserConfigMain.SetRowSpan(Me.tlpAlertConfig, 2)
        Me.tlpAlertConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlertConfig.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAlertConfig.Size = New System.Drawing.Size(868, 650)
        Me.tlpAlertConfig.TabIndex = 0
        '
        'dbmsImgLst
        '
        Me.dbmsImgLst.ImageStream = CType(resources.GetObject("dbmsImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.dbmsImgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.dbmsImgLst.Images.SetKeyName(0, "if_database_green_92629.ico")
        Me.dbmsImgLst.Images.SetKeyName(1, "if_database_link_35958.ico")
        '
        'rbGrpHAGroup
        '
        Me.rbGrpHAGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrpHAGroup.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbGrpHAGroup.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rbGrpHAGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrpHAGroup.ForeColor = System.Drawing.Color.White
        Me.rbGrpHAGroup.LineColor = System.Drawing.Color.Transparent
        Me.rbGrpHAGroup.Location = New System.Drawing.Point(137, 31)
        Me.rbGrpHAGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.rbGrpHAGroup.Name = "rbGrpHAGroup"
        Me.rbGrpHAGroup.Radius = 7
        Me.rbGrpHAGroup.Size = New System.Drawing.Size(134, 28)
        Me.rbGrpHAGroup.TabIndex = 13
        Me.rbGrpHAGroup.TabStop = True
        Me.rbGrpHAGroup.Text = "F363"
        Me.rbGrpHAGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrpHAGroup.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.rbGrpHAGroup.UseRound = True
        Me.rbGrpHAGroup.UseVisualStyleBackColor = False
        Me.rbGrpHAGroup.Warning = False
        Me.rbGrpHAGroup.WarningColor = System.Drawing.Color.Red
        '
        'rbGrpCluster
        '
        Me.rbGrpCluster.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbGrpCluster.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rbGrpCluster.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.rbGrpCluster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbGrpCluster.ForeColor = System.Drawing.Color.White
        Me.rbGrpCluster.LineColor = System.Drawing.Color.Transparent
        Me.rbGrpCluster.Location = New System.Drawing.Point(1, 31)
        Me.rbGrpCluster.Margin = New System.Windows.Forms.Padding(1)
        Me.rbGrpCluster.Name = "rbGrpCluster"
        Me.rbGrpCluster.Radius = 7
        Me.rbGrpCluster.Size = New System.Drawing.Size(134, 28)
        Me.rbGrpCluster.TabIndex = 14
        Me.rbGrpCluster.TabStop = True
        Me.rbGrpCluster.Text = "F362"
        Me.rbGrpCluster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbGrpCluster.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.rbGrpCluster.UseRound = True
        Me.rbGrpCluster.UseVisualStyleBackColor = False
        Me.rbGrpCluster.Warning = False
        Me.rbGrpCluster.WarningColor = System.Drawing.Color.Red
        '
        'AlertConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.SplitContainer1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "AlertConfig"
        Me.Size = New System.Drawing.Size(1161, 692)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.tlpGroup.ResumeLayout(False)
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHead.ResumeLayout(False)
        Me.tlpUserConfigMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tblHead As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblServerList As System.Windows.Forms.Label
    Friend WithEvents tlpGroup As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgvSvrLst As AdvancedDataGridView.TreeGridView
    Friend WithEvents dbmsImgLst As System.Windows.Forms.ImageList
    Friend WithEvents tlpAlertConfig As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnSaveAll As eXperDB.BaseControls.Button
    Friend WithEvents btnInit As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents coldgvHostName As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents coldgvHostNameKey As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvAliasNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvHARole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvHAHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbGrpHAGroup As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbGrpCluster As eXperDB.BaseControls.RadioButton

End Class
