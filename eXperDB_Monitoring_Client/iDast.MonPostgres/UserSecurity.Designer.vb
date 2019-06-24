<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSecurity
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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserSecurity))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim Edges2 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim Edges3 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox3 = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel4 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.tlpUserlist = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAddIP = New eXperDB.BaseControls.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAllowlist = New System.Windows.Forms.Label()
        Me.dgvWhitelist = New eXperDB.BaseControls.DataGridView()
        Me.coldgvWhitelistUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvWhitelistUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvWhitelistIPAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvWhitelistEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldgvWhitelistDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldgvWhitelistTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.nudAlertPasswordExpires = New System.Windows.Forms.NumericUpDown()
        Me.nudPasswordExpires = New System.Windows.Forms.NumericUpDown()
        Me.nudPasswordLength = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New eXperDB.BaseControls.Label()
        Me.Label2 = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPasswordPolicy = New System.Windows.Forms.Label()
        Me.chkCombine = New eXperDB.BaseControls.CheckBox()
        Me.lblCombine = New eXperDB.BaseControls.Label()
        Me.lblPasswordExpires = New eXperDB.BaseControls.Label()
        Me.lblAlertPasswordExpires = New eXperDB.BaseControls.Label()
        Me.lblPasswordLength = New eXperDB.BaseControls.Label()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.nudLockAccountFail = New System.Windows.Forms.NumericUpDown()
        Me.nudLockTimeout = New System.Windows.Forms.NumericUpDown()
        Me.nudLockAccountIdle = New System.Windows.Forms.NumericUpDown()
        Me.lblLockTimeout = New eXperDB.BaseControls.Label()
        Me.Label13 = New eXperDB.BaseControls.Label()
        Me.Label12 = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAccountPolicy = New System.Windows.Forms.Label()
        Me.chkDupLogin = New eXperDB.BaseControls.CheckBox()
        Me.lblDupLogin = New eXperDB.BaseControls.Label()
        Me.lblLockAccountFail = New eXperDB.BaseControls.Label()
        Me.lblLockAccountIdle = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPercentageColumn1 = New eXperDB.Controls.DataGridViewPercentageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpUserConfigMain.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.tlpUserlist.SuspendLayout()
        CType(Me.dgvWhitelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudAlertPasswordExpires, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPasswordExpires, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPasswordLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        CType(Me.nudLockAccountFail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLockTimeout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLockAccountIdle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserConfigMain.ColumnCount = 4
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54316!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.45684!))
        Me.tlpUserConfigMain.Controls.Add(Me.GroupBox3, 2, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.GroupBox2, 0, 2)
        Me.tlpUserConfigMain.Controls.Add(Me.GroupBox1, 0, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.TableLayoutPanel5, 1, 4)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 6
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(1061, 695)
        Me.tlpUserConfigMain.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox3.AlignString = System.Drawing.StringAlignment.Near
        Me.tlpUserConfigMain.SetColumnSpan(Me.GroupBox3, 2)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel4)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.EdgeRound = Edges1
        Me.GroupBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Icon = CType(resources.GetObject("GroupBox3.Icon"), System.Drawing.Icon)
        Me.GroupBox3.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox3.LineWidth = 1
        Me.GroupBox3.Location = New System.Drawing.Point(519, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.tlpUserConfigMain.SetRowSpan(Me.GroupBox3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(532, 575)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox3.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox3.UseGraColor = False
        Me.GroupBox3.UseRound = True
        Me.GroupBox3.UseTitle = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.tlpUserlist, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.dgvWhitelist, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 14)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(526, 558)
        Me.TableLayoutPanel4.TabIndex = 36
        '
        'tlpUserlist
        '
        Me.tlpUserlist.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tlpUserlist.ColumnCount = 5
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpUserlist.Controls.Add(Me.btnAddIP, 4, 0)
        Me.tlpUserlist.Controls.Add(Me.Label1, 0, 0)
        Me.tlpUserlist.Controls.Add(Me.lblAllowlist, 1, 0)
        Me.tlpUserlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserlist.Location = New System.Drawing.Point(23, 3)
        Me.tlpUserlist.Name = "tlpUserlist"
        Me.tlpUserlist.RowCount = 1
        Me.tlpUserlist.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserlist.Size = New System.Drawing.Size(480, 34)
        Me.tlpUserlist.TabIndex = 29
        '
        'btnAddIP
        '
        Me.btnAddIP.BackColor = System.Drawing.Color.LightGray
        Me.btnAddIP.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddIP.FixedHeight = False
        Me.btnAddIP.FixedWidth = False
        Me.btnAddIP.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnAddIP.ForeColor = System.Drawing.Color.White
        Me.btnAddIP.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddIP.Image = CType(resources.GetObject("btnAddIP.Image"), System.Drawing.Image)
        Me.btnAddIP.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAddIP.Location = New System.Drawing.Point(447, 3)
        Me.btnAddIP.Name = "btnAddIP"
        Me.btnAddIP.Radius = 5
        Me.btnAddIP.Size = New System.Drawing.Size(30, 28)
        Me.btnAddIP.TabIndex = 8
        Me.btnAddIP.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddIP.UseVisualStyleBackColor = False
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
        'lblAllowlist
        '
        Me.lblAllowlist.AutoSize = True
        Me.lblAllowlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAllowlist.ForeColor = System.Drawing.Color.White
        Me.lblAllowlist.Location = New System.Drawing.Point(43, 0)
        Me.lblAllowlist.Name = "lblAllowlist"
        Me.lblAllowlist.Size = New System.Drawing.Size(326, 34)
        Me.lblAllowlist.TabIndex = 3
        Me.lblAllowlist.Text = "F935"
        Me.lblAllowlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvWhitelist
        '
        Me.dgvWhitelist.AllowUserToAddRows = False
        Me.dgvWhitelist.AllowUserToDeleteRows = False
        Me.dgvWhitelist.AllowUserToResizeRows = False
        Me.dgvWhitelist.BackgroundColor = System.Drawing.Color.Black
        Me.dgvWhitelist.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.dgvWhitelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvWhitelist.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvWhitelist.ColumnHeadersHeight = 24
        Me.dgvWhitelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvWhitelist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvWhitelistUserID, Me.coldgvWhitelistUserName, Me.coldgvWhitelistIPAddress, Me.coldgvWhitelistEdit, Me.coldgvWhitelistDelete, Me.coldgvWhitelistTag})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Gulim", 9.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvWhitelist.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvWhitelist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvWhitelist.EnableHeadersVisualStyles = False
        Me.dgvWhitelist.GridColor = System.Drawing.Color.Black
        Me.dgvWhitelist.Location = New System.Drawing.Point(23, 43)
        Me.dgvWhitelist.Name = "dgvWhitelist"
        Me.dgvWhitelist.RowHeadersVisible = False
        Me.dgvWhitelist.RowTemplate.Height = 23
        Me.dgvWhitelist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWhitelist.Size = New System.Drawing.Size(480, 492)
        Me.dgvWhitelist.TabIndex = 28
        Me.dgvWhitelist.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvWhitelist.UseTagValueMatchColor = True
        '
        'coldgvWhitelistUserID
        '
        Me.coldgvWhitelistUserID.DataPropertyName = "USER_ID"
        Me.coldgvWhitelistUserID.FillWeight = 20.0!
        Me.coldgvWhitelistUserID.HeaderText = "F347"
        Me.coldgvWhitelistUserID.MinimumWidth = 100
        Me.coldgvWhitelistUserID.Name = "coldgvWhitelistUserID"
        Me.coldgvWhitelistUserID.ReadOnly = True
        '
        'coldgvWhitelistUserName
        '
        Me.coldgvWhitelistUserName.DataPropertyName = "USER_NAME"
        Me.coldgvWhitelistUserName.HeaderText = "F348"
        Me.coldgvWhitelistUserName.MinimumWidth = 120
        Me.coldgvWhitelistUserName.Name = "coldgvWhitelistUserName"
        Me.coldgvWhitelistUserName.ReadOnly = True
        Me.coldgvWhitelistUserName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvWhitelistUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvWhitelistUserName.Width = 120
        '
        'coldgvWhitelistIPAddress
        '
        Me.coldgvWhitelistIPAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvWhitelistIPAddress.DataPropertyName = "ALLOW_IP"
        Me.coldgvWhitelistIPAddress.HeaderText = "F933"
        Me.coldgvWhitelistIPAddress.MinimumWidth = 150
        Me.coldgvWhitelistIPAddress.Name = "coldgvWhitelistIPAddress"
        '
        'coldgvWhitelistEdit
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = CType(resources.GetObject("DataGridViewCellStyle2.NullValue"), Object)
        Me.coldgvWhitelistEdit.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvWhitelistEdit.HeaderText = ""
        Me.coldgvWhitelistEdit.Image = CType(resources.GetObject("coldgvWhitelistEdit.Image"), System.Drawing.Image)
        Me.coldgvWhitelistEdit.MinimumWidth = 45
        Me.coldgvWhitelistEdit.Name = "coldgvWhitelistEdit"
        Me.coldgvWhitelistEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvWhitelistEdit.Visible = False
        Me.coldgvWhitelistEdit.Width = 45
        '
        'coldgvWhitelistDelete
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        Me.coldgvWhitelistDelete.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvWhitelistDelete.HeaderText = ""
        Me.coldgvWhitelistDelete.Image = CType(resources.GetObject("coldgvWhitelistDelete.Image"), System.Drawing.Image)
        Me.coldgvWhitelistDelete.MinimumWidth = 45
        Me.coldgvWhitelistDelete.Name = "coldgvWhitelistDelete"
        Me.coldgvWhitelistDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvWhitelistDelete.Width = 45
        '
        'coldgvWhitelistTag
        '
        Me.coldgvWhitelistTag.DataPropertyName = "TAG"
        Me.coldgvWhitelistTag.HeaderText = ""
        Me.coldgvWhitelistTag.Name = "coldgvWhitelistTag"
        Me.coldgvWhitelistTag.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox2.AlignString = System.Drawing.StringAlignment.Near
        Me.tlpUserConfigMain.SetColumnSpan(Me.GroupBox2, 2)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.EdgeRound = Edges2
        Me.GroupBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Icon = CType(resources.GetObject("GroupBox2.Icon"), System.Drawing.Icon)
        Me.GroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox2.LineWidth = 1
        Me.GroupBox2.Location = New System.Drawing.Point(10, 312)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox2.Size = New System.Drawing.Size(489, 283)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox2.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox2.UseGraColor = False
        Me.GroupBox2.UseRound = True
        Me.GroupBox2.UseTitle = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.nudAlertPasswordExpires, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPasswordExpires, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPasswordLength, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkCombine, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCombine, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPasswordExpires, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAlertPasswordExpires, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPasswordLength, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 14)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(483, 266)
        Me.TableLayoutPanel1.TabIndex = 30
        '
        'nudAlertPasswordExpires
        '
        Me.nudAlertPasswordExpires.BackColor = System.Drawing.Color.White
        Me.nudAlertPasswordExpires.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudAlertPasswordExpires.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudAlertPasswordExpires.Location = New System.Drawing.Point(223, 176)
        Me.nudAlertPasswordExpires.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudAlertPasswordExpires.Name = "nudAlertPasswordExpires"
        Me.nudAlertPasswordExpires.Size = New System.Drawing.Size(154, 21)
        Me.nudAlertPasswordExpires.TabIndex = 61
        Me.nudAlertPasswordExpires.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudPasswordExpires
        '
        Me.nudPasswordExpires.BackColor = System.Drawing.Color.White
        Me.nudPasswordExpires.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudPasswordExpires.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudPasswordExpires.Location = New System.Drawing.Point(223, 141)
        Me.nudPasswordExpires.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudPasswordExpires.Name = "nudPasswordExpires"
        Me.nudPasswordExpires.Size = New System.Drawing.Size(154, 21)
        Me.nudPasswordExpires.TabIndex = 60
        Me.nudPasswordExpires.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudPasswordLength
        '
        Me.nudPasswordLength.BackColor = System.Drawing.Color.White
        Me.nudPasswordLength.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudPasswordLength.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudPasswordLength.Location = New System.Drawing.Point(223, 106)
        Me.nudPasswordLength.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudPasswordLength.Name = "nudPasswordLength"
        Me.nudPasswordLength.Size = New System.Drawing.Size(154, 21)
        Me.nudPasswordLength.TabIndex = 59
        Me.nudPasswordLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.FixedHeight = False
        Me.Label3.FixedWidth = False
        Me.Label3.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.LineSpacing = 0.0!
        Me.Label3.Location = New System.Drawing.Point(383, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "days"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.FixedHeight = False
        Me.Label2.FixedWidth = False
        Me.Label2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.LineSpacing = 0.0!
        Me.Label2.Location = New System.Drawing.Point(383, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "days"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 3)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblPasswordPolicy, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(477, 34)
        Me.TableLayoutPanel3.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 34)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "      "
        '
        'lblPasswordPolicy
        '
        Me.lblPasswordPolicy.AutoSize = True
        Me.lblPasswordPolicy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPasswordPolicy.ForeColor = System.Drawing.Color.White
        Me.lblPasswordPolicy.Location = New System.Drawing.Point(43, 0)
        Me.lblPasswordPolicy.Name = "lblPasswordPolicy"
        Me.lblPasswordPolicy.Size = New System.Drawing.Size(323, 34)
        Me.lblPasswordPolicy.TabIndex = 3
        Me.lblPasswordPolicy.Text = "F933"
        Me.lblPasswordPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkCombine
        '
        Me.chkCombine.AutoSize = True
        Me.chkCombine.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCombine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkCombine.ForeColor = System.Drawing.Color.White
        Me.chkCombine.LineColor = System.Drawing.Color.Gray
        Me.chkCombine.Location = New System.Drawing.Point(223, 78)
        Me.chkCombine.Name = "chkCombine"
        Me.chkCombine.Radius = 10
        Me.chkCombine.Size = New System.Drawing.Size(154, 14)
        Me.chkCombine.TabIndex = 4
        Me.chkCombine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCombine.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCombine.UseVisualStyleBackColor = True
        '
        'lblCombine
        '
        Me.lblCombine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCombine.FixedHeight = False
        Me.lblCombine.FixedWidth = False
        Me.lblCombine.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblCombine.ForeColor = System.Drawing.Color.White
        Me.lblCombine.LineSpacing = 0.0!
        Me.lblCombine.Location = New System.Drawing.Point(3, 75)
        Me.lblCombine.Name = "lblCombine"
        Me.lblCombine.Size = New System.Drawing.Size(214, 20)
        Me.lblCombine.TabIndex = 17
        Me.lblCombine.Text = "F929"
        Me.lblCombine.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPasswordExpires
        '
        Me.lblPasswordExpires.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPasswordExpires.FixedHeight = False
        Me.lblPasswordExpires.FixedWidth = False
        Me.lblPasswordExpires.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPasswordExpires.ForeColor = System.Drawing.Color.White
        Me.lblPasswordExpires.LineSpacing = 0.0!
        Me.lblPasswordExpires.Location = New System.Drawing.Point(3, 145)
        Me.lblPasswordExpires.Name = "lblPasswordExpires"
        Me.lblPasswordExpires.Size = New System.Drawing.Size(214, 20)
        Me.lblPasswordExpires.TabIndex = 11
        Me.lblPasswordExpires.Text = "F931"
        Me.lblPasswordExpires.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAlertPasswordExpires
        '
        Me.lblAlertPasswordExpires.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAlertPasswordExpires.FixedHeight = False
        Me.lblAlertPasswordExpires.FixedWidth = False
        Me.lblAlertPasswordExpires.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAlertPasswordExpires.ForeColor = System.Drawing.Color.White
        Me.lblAlertPasswordExpires.LineSpacing = 0.0!
        Me.lblAlertPasswordExpires.Location = New System.Drawing.Point(3, 180)
        Me.lblAlertPasswordExpires.Name = "lblAlertPasswordExpires"
        Me.lblAlertPasswordExpires.Size = New System.Drawing.Size(214, 20)
        Me.lblAlertPasswordExpires.TabIndex = 10
        Me.lblAlertPasswordExpires.Text = "F932"
        Me.lblAlertPasswordExpires.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPasswordLength
        '
        Me.lblPasswordLength.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPasswordLength.FixedHeight = False
        Me.lblPasswordLength.FixedWidth = False
        Me.lblPasswordLength.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPasswordLength.ForeColor = System.Drawing.Color.White
        Me.lblPasswordLength.LineSpacing = 0.0!
        Me.lblPasswordLength.Location = New System.Drawing.Point(3, 110)
        Me.lblPasswordLength.Name = "lblPasswordLength"
        Me.lblPasswordLength.Size = New System.Drawing.Size(214, 20)
        Me.lblPasswordLength.TabIndex = 8
        Me.lblPasswordLength.Text = "F930"
        Me.lblPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.tlpUserConfigMain.SetColumnSpan(Me.GroupBox1, 2)
        Me.GroupBox1.Controls.Add(Me.tlpSvrChk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges3
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Icon = CType(resources.GetObject("GroupBox1.Icon"), System.Drawing.Icon)
        Me.GroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(10, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(489, 272)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox1.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.UseGraColor = False
        Me.GroupBox1.UseRound = True
        Me.GroupBox1.UseTitle = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 3
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.nudLockAccountFail, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.nudLockTimeout, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.nudLockAccountIdle, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblLockTimeout, 0, 3)
        Me.tlpSvrChk.Controls.Add(Me.Label13, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.Label12, 2, 4)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlpSvrChk.Controls.Add(Me.chkDupLogin, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblDupLogin, 0, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblLockAccountFail, 0, 2)
        Me.tlpSvrChk.Controls.Add(Me.lblLockAccountIdle, 0, 4)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 14)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 7
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(483, 255)
        Me.tlpSvrChk.TabIndex = 30
        '
        'nudLockAccountFail
        '
        Me.nudLockAccountFail.BackColor = System.Drawing.Color.White
        Me.nudLockAccountFail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudLockAccountFail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockAccountFail.Location = New System.Drawing.Point(223, 71)
        Me.nudLockAccountFail.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudLockAccountFail.Name = "nudLockAccountFail"
        Me.nudLockAccountFail.Size = New System.Drawing.Size(154, 21)
        Me.nudLockAccountFail.TabIndex = 58
        Me.nudLockAccountFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLockTimeout
        '
        Me.nudLockTimeout.BackColor = System.Drawing.Color.White
        Me.nudLockTimeout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudLockTimeout.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockTimeout.Location = New System.Drawing.Point(223, 106)
        Me.nudLockTimeout.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.nudLockTimeout.Name = "nudLockTimeout"
        Me.nudLockTimeout.Size = New System.Drawing.Size(154, 21)
        Me.nudLockTimeout.TabIndex = 57
        Me.nudLockTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nudLockAccountIdle
        '
        Me.nudLockAccountIdle.BackColor = System.Drawing.Color.White
        Me.nudLockAccountIdle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudLockAccountIdle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.nudLockAccountIdle.Location = New System.Drawing.Point(223, 141)
        Me.nudLockAccountIdle.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nudLockAccountIdle.Name = "nudLockAccountIdle"
        Me.nudLockAccountIdle.Size = New System.Drawing.Size(154, 21)
        Me.nudLockAccountIdle.TabIndex = 56
        Me.nudLockAccountIdle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblLockTimeout
        '
        Me.lblLockTimeout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLockTimeout.FixedHeight = False
        Me.lblLockTimeout.FixedWidth = False
        Me.lblLockTimeout.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLockTimeout.ForeColor = System.Drawing.Color.White
        Me.lblLockTimeout.LineSpacing = 0.0!
        Me.lblLockTimeout.Location = New System.Drawing.Point(3, 110)
        Me.lblLockTimeout.Name = "lblLockTimeout"
        Me.lblLockTimeout.Size = New System.Drawing.Size(214, 20)
        Me.lblLockTimeout.TabIndex = 34
        Me.lblLockTimeout.Text = "F926"
        Me.lblLockTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label13.FixedHeight = False
        Me.Label13.FixedWidth = False
        Me.Label13.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.LineSpacing = 0.0!
        Me.Label13.Location = New System.Drawing.Point(383, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "minutes"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.FixedHeight = False
        Me.Label12.FixedWidth = False
        Me.Label12.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.LineSpacing = 0.0!
        Me.Label12.Location = New System.Drawing.Point(383, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "days"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.tlpSvrChk.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAccountPolicy, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(477, 34)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 34)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "      "
        '
        'lblAccountPolicy
        '
        Me.lblAccountPolicy.AutoSize = True
        Me.lblAccountPolicy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccountPolicy.ForeColor = System.Drawing.Color.White
        Me.lblAccountPolicy.Location = New System.Drawing.Point(43, 0)
        Me.lblAccountPolicy.Name = "lblAccountPolicy"
        Me.lblAccountPolicy.Size = New System.Drawing.Size(323, 34)
        Me.lblAccountPolicy.TabIndex = 3
        Me.lblAccountPolicy.Text = "F924"
        Me.lblAccountPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkDupLogin
        '
        Me.chkDupLogin.AutoSize = True
        Me.chkDupLogin.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkDupLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkDupLogin.ForeColor = System.Drawing.Color.White
        Me.chkDupLogin.LineColor = System.Drawing.Color.Gray
        Me.chkDupLogin.Location = New System.Drawing.Point(223, 183)
        Me.chkDupLogin.Name = "chkDupLogin"
        Me.chkDupLogin.Radius = 10
        Me.chkDupLogin.Size = New System.Drawing.Size(154, 14)
        Me.chkDupLogin.TabIndex = 3
        Me.chkDupLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkDupLogin.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkDupLogin.UseVisualStyleBackColor = True
        Me.chkDupLogin.Visible = False
        '
        'lblDupLogin
        '
        Me.lblDupLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDupLogin.FixedHeight = False
        Me.lblDupLogin.FixedWidth = False
        Me.lblDupLogin.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDupLogin.ForeColor = System.Drawing.Color.White
        Me.lblDupLogin.LineSpacing = 0.0!
        Me.lblDupLogin.Location = New System.Drawing.Point(3, 180)
        Me.lblDupLogin.Name = "lblDupLogin"
        Me.lblDupLogin.Size = New System.Drawing.Size(214, 20)
        Me.lblDupLogin.TabIndex = 8
        Me.lblDupLogin.Text = "F928"
        Me.lblDupLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDupLogin.Visible = False
        '
        'lblLockAccountFail
        '
        Me.lblLockAccountFail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLockAccountFail.FixedHeight = False
        Me.lblLockAccountFail.FixedWidth = False
        Me.lblLockAccountFail.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLockAccountFail.ForeColor = System.Drawing.Color.White
        Me.lblLockAccountFail.LineSpacing = 0.0!
        Me.lblLockAccountFail.Location = New System.Drawing.Point(3, 75)
        Me.lblLockAccountFail.Name = "lblLockAccountFail"
        Me.lblLockAccountFail.Size = New System.Drawing.Size(214, 20)
        Me.lblLockAccountFail.TabIndex = 0
        Me.lblLockAccountFail.Text = "F925"
        Me.lblLockAccountFail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLockAccountIdle
        '
        Me.lblLockAccountIdle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLockAccountIdle.FixedHeight = False
        Me.lblLockAccountIdle.FixedWidth = False
        Me.lblLockAccountIdle.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLockAccountIdle.ForeColor = System.Drawing.Color.White
        Me.lblLockAccountIdle.LineSpacing = 0.0!
        Me.lblLockAccountIdle.Location = New System.Drawing.Point(3, 145)
        Me.lblLockAccountIdle.Name = "lblLockAccountIdle"
        Me.lblLockAccountIdle.Size = New System.Drawing.Size(214, 20)
        Me.lblLockAccountIdle.TabIndex = 2
        Me.lblLockAccountIdle.Text = "F927"
        Me.lblLockAccountIdle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.tlpUserConfigMain.SetColumnSpan(Me.TableLayoutPanel5, 2)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel5.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(412, 648)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(194, 34)
        Me.TableLayoutPanel5.TabIndex = 38
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
        Me.btnSave.LineColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(46, 0)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.TableLayoutPanel5.SetRowSpan(Me.btnSave, 2)
        Me.btnSave.Size = New System.Drawing.Size(100, 34)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alert Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GROUP_NAME"
        DataGridViewCellStyle6.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Biz day"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "P"
        Me.DataGridViewPercentageColumn1.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "P"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
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
        'UserSecurity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.tlpUserConfigMain)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UserSecurity"
        Me.Size = New System.Drawing.Size(1061, 695)
        Me.tlpUserConfigMain.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.tlpUserlist.ResumeLayout(False)
        Me.tlpUserlist.PerformLayout()
        CType(Me.dgvWhitelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudAlertPasswordExpires, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPasswordExpires, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPasswordLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        CType(Me.nudLockAccountFail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLockTimeout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLockAccountIdle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPercentageColumn1 As eXperDB.Controls.DataGridViewPercentageColumn
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAccountPolicy As System.Windows.Forms.Label
    Friend WithEvents chkDupLogin As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblDupLogin As eXperDB.BaseControls.Label
    Friend WithEvents lblLockAccountFail As eXperDB.BaseControls.Label
    Friend WithEvents lblLockAccountIdle As eXperDB.BaseControls.Label
    Friend WithEvents GroupBox3 As eXperDB.BaseControls.GroupBox
    Friend WithEvents TableLayoutPanel4 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents tlpUserlist As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAddIP As eXperDB.BaseControls.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAllowlist As System.Windows.Forms.Label
    Friend WithEvents dgvWhitelist As eXperDB.BaseControls.DataGridView
    Friend WithEvents GroupBox2 As eXperDB.BaseControls.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblPasswordPolicy As System.Windows.Forms.Label
    Friend WithEvents chkCombine As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblCombine As eXperDB.BaseControls.Label
    Friend WithEvents lblPasswordExpires As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertPasswordExpires As eXperDB.BaseControls.Label
    Friend WithEvents lblPasswordLength As eXperDB.BaseControls.Label
    Friend WithEvents lblLockTimeout As eXperDB.BaseControls.Label
    Friend WithEvents Label13 As eXperDB.BaseControls.Label
    Friend WithEvents Label12 As eXperDB.BaseControls.Label
    Friend WithEvents Label3 As eXperDB.BaseControls.Label
    Friend WithEvents Label2 As eXperDB.BaseControls.Label
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents nudAlertPasswordExpires As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPasswordExpires As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPasswordLength As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLockAccountFail As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLockTimeout As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudLockAccountIdle As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents coldgvWhitelistUserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvWhitelistUserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvWhitelistIPAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvWhitelistEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvWhitelistDelete As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvWhitelistTag As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
