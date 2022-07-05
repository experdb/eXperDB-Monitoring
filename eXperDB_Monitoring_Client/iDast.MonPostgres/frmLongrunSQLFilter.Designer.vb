<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLongrunSQLFilter
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLongrunSQLFilter))
        Me.tlpList = New eXperDB.BaseControls.TableLayoutPanel()
        Me.cmbExcludeSession = New eXperDB.BaseControls.ComboBox()
        Me.btnAddExcludeSession = New eXperDB.BaseControls.Button()
        Me.lblExcludeSession = New eXperDB.BaseControls.Label()
        Me.txtExcludeSession = New eXperDB.BaseControls.TextBox()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.dgvLongSQLFilterList = New eXperDB.BaseControls.DataGridView()
        Me.coldgvLongSQLFilterListCondition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvLongSQLFilterListText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvStatementFilterListDel = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tlpDesc = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tlpList.SuspendLayout()
        CType(Me.dgvLongSQLFilterList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpDesc.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpList
        '
        Me.tlpList.BackColor = System.Drawing.Color.Transparent
        Me.tlpList.ColumnCount = 10
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpList.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556!))
        Me.tlpList.Controls.Add(Me.cmbExcludeSession, 3, 0)
        Me.tlpList.Controls.Add(Me.btnAddExcludeSession, 8, 0)
        Me.tlpList.Controls.Add(Me.lblExcludeSession, 1, 0)
        Me.tlpList.Controls.Add(Me.txtExcludeSession, 5, 0)
        Me.tlpList.Controls.Add(Me.btnClose, 5, 2)
        Me.tlpList.Controls.Add(Me.btnApply, 3, 2)
        Me.tlpList.Controls.Add(Me.dgvLongSQLFilterList, 1, 1)
        Me.tlpList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpList.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpList.Location = New System.Drawing.Point(0, 50)
        Me.tlpList.Name = "tlpList"
        Me.tlpList.RowCount = 3
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpList.Size = New System.Drawing.Size(434, 335)
        Me.tlpList.TabIndex = 5
        '
        'cmbExcludeSession
        '
        Me.cmbExcludeSession.BackColor = System.Drawing.SystemColors.Window
        Me.tlpList.SetColumnSpan(Me.cmbExcludeSession, 2)
        Me.cmbExcludeSession.DisplayMember = "All"
        Me.cmbExcludeSession.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbExcludeSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExcludeSession.FixedWidth = False
        Me.cmbExcludeSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbExcludeSession.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.cmbExcludeSession.FormattingEnabled = True
        Me.cmbExcludeSession.Items.AddRange(New Object() {"user name", "db name", "client IP addr"})
        Me.cmbExcludeSession.Location = New System.Drawing.Point(92, 16)
        Me.cmbExcludeSession.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbExcludeSession.Name = "cmbExcludeSession"
        Me.cmbExcludeSession.Necessary = False
        Me.cmbExcludeSession.Size = New System.Drawing.Size(118, 20)
        Me.cmbExcludeSession.StatusTip = ""
        Me.cmbExcludeSession.TabIndex = 35
        Me.cmbExcludeSession.ValueText = ""
        '
        'btnAddExcludeSession
        '
        Me.btnAddExcludeSession.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAddExcludeSession.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAddExcludeSession.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAddExcludeSession.FixedHeight = False
        Me.btnAddExcludeSession.FixedWidth = False
        Me.btnAddExcludeSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddExcludeSession.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAddExcludeSession.ForeColor = System.Drawing.Color.White
        Me.btnAddExcludeSession.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAddExcludeSession.LineColor = System.Drawing.Color.Transparent
        Me.btnAddExcludeSession.Location = New System.Drawing.Point(370, 12)
        Me.btnAddExcludeSession.Name = "btnAddExcludeSession"
        Me.btnAddExcludeSession.Radius = 5
        Me.btnAddExcludeSession.Size = New System.Drawing.Size(54, 25)
        Me.btnAddExcludeSession.TabIndex = 34
        Me.btnAddExcludeSession.Text = "F016"
        Me.btnAddExcludeSession.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddExcludeSession.UseRound = True
        Me.btnAddExcludeSession.UseVisualStyleBackColor = False
        '
        'lblExcludeSession
        '
        Me.lblExcludeSession.BackColor = System.Drawing.Color.Transparent
        Me.tlpList.SetColumnSpan(Me.lblExcludeSession, 2)
        Me.lblExcludeSession.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblExcludeSession.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblExcludeSession.FixedHeight = False
        Me.lblExcludeSession.FixedWidth = False
        Me.lblExcludeSession.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblExcludeSession.ForeColor = System.Drawing.Color.White
        Me.lblExcludeSession.LineSpacing = 0.0!
        Me.lblExcludeSession.Location = New System.Drawing.Point(7, 11)
        Me.lblExcludeSession.Name = "lblExcludeSession"
        Me.lblExcludeSession.Size = New System.Drawing.Size(79, 29)
        Me.lblExcludeSession.TabIndex = 33
        Me.lblExcludeSession.Text = "F368"
        Me.lblExcludeSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtExcludeSession
        '
        Me.txtExcludeSession.BackColor = System.Drawing.SystemColors.Window
        Me.txtExcludeSession.code = False
        Me.tlpList.SetColumnSpan(Me.txtExcludeSession, 3)
        Me.txtExcludeSession.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtExcludeSession.FixedWidth = False
        Me.txtExcludeSession.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.txtExcludeSession.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtExcludeSession.impossibleinput = "`~!@#$%^&*\{}"
        Me.txtExcludeSession.Location = New System.Drawing.Point(216, 15)
        Me.txtExcludeSession.Name = "txtExcludeSession"
        Me.txtExcludeSession.Necessary = False
        Me.txtExcludeSession.PossibleInput = ""
        Me.txtExcludeSession.Prefix = ""
        Me.txtExcludeSession.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExcludeSession.Size = New System.Drawing.Size(148, 22)
        Me.txtExcludeSession.StatusTip = ""
        Me.txtExcludeSession.TabIndex = 32
        Me.txtExcludeSession.Value = ""
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpList.SetColumnSpan(Me.btnClose, 2)
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(216, 299)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 5
        Me.btnClose.Size = New System.Drawing.Size(118, 32)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.tlpList.SetColumnSpan(Me.btnApply, 2)
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.Transparent
        Me.btnApply.Location = New System.Drawing.Point(92, 299)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 5
        Me.btnApply.Size = New System.Drawing.Size(118, 32)
        Me.btnApply.TabIndex = 26
        Me.btnApply.Text = "F014"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'dgvLongSQLFilterList
        '
        Me.dgvLongSQLFilterList.AllowUserToAddRows = False
        Me.dgvLongSQLFilterList.AllowUserToDeleteRows = False
        Me.dgvLongSQLFilterList.AllowUserToOrderColumns = True
        Me.dgvLongSQLFilterList.AllowUserToResizeRows = False
        Me.dgvLongSQLFilterList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvLongSQLFilterList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLongSQLFilterList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvLongSQLFilterList.ColumnHeadersHeight = 30
        Me.dgvLongSQLFilterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLongSQLFilterList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvLongSQLFilterListCondition, Me.coldgvLongSQLFilterListText, Me.coldgvStatementFilterListDel})
        Me.tlpList.SetColumnSpan(Me.dgvLongSQLFilterList, 8)
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLongSQLFilterList.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvLongSQLFilterList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLongSQLFilterList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvLongSQLFilterList.EnableHeadersVisualStyles = False
        Me.dgvLongSQLFilterList.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvLongSQLFilterList.GridColor = System.Drawing.Color.Black
        Me.dgvLongSQLFilterList.Location = New System.Drawing.Point(7, 44)
        Me.dgvLongSQLFilterList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvLongSQLFilterList.Name = "dgvLongSQLFilterList"
        Me.dgvLongSQLFilterList.RowHeadersVisible = False
        Me.dgvLongSQLFilterList.RowHeadersWidth = 45
        Me.dgvLongSQLFilterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.dgvLongSQLFilterList.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvLongSQLFilterList.RowTemplate.Height = 23
        Me.dgvLongSQLFilterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLongSQLFilterList.Size = New System.Drawing.Size(417, 247)
        Me.dgvLongSQLFilterList.TabIndex = 10
        Me.dgvLongSQLFilterList.TagValueMatchColor = System.Drawing.Color.White
        Me.dgvLongSQLFilterList.UseTagValueMatchColor = False
        '
        'coldgvLongSQLFilterListCondition
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvLongSQLFilterListCondition.DefaultCellStyle = DataGridViewCellStyle8
        Me.coldgvLongSQLFilterListCondition.HeaderText = "F967"
        Me.coldgvLongSQLFilterListCondition.Name = "coldgvLongSQLFilterListCondition"
        Me.coldgvLongSQLFilterListCondition.ReadOnly = True
        Me.coldgvLongSQLFilterListCondition.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'coldgvLongSQLFilterListText
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvLongSQLFilterListText.DefaultCellStyle = DataGridViewCellStyle9
        Me.coldgvLongSQLFilterListText.FillWeight = 131.1306!
        Me.coldgvLongSQLFilterListText.HeaderText = "F332"
        Me.coldgvLongSQLFilterListText.MinimumWidth = 240
        Me.coldgvLongSQLFilterListText.Name = "coldgvLongSQLFilterListText"
        Me.coldgvLongSQLFilterListText.ReadOnly = True
        Me.coldgvLongSQLFilterListText.Width = 240
        '
        'coldgvStatementFilterListDel
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.NullValue = CType(resources.GetObject("DataGridViewCellStyle10.NullValue"), Object)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvStatementFilterListDel.DefaultCellStyle = DataGridViewCellStyle10
        Me.coldgvStatementFilterListDel.HeaderText = ""
        Me.coldgvStatementFilterListDel.Image = CType(resources.GetObject("coldgvStatementFilterListDel.Image"), System.Drawing.Image)
        Me.coldgvStatementFilterListDel.MinimumWidth = 50
        Me.coldgvStatementFilterListDel.Name = "coldgvStatementFilterListDel"
        Me.coldgvStatementFilterListDel.Width = 50
        '
        'tlpDesc
        '
        Me.tlpDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpDesc.ColumnCount = 2
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpDesc.Controls.Add(Me.MsgLabel, 1, 0)
        Me.tlpDesc.Controls.Add(Me.Label1, 0, 0)
        Me.tlpDesc.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpDesc.Location = New System.Drawing.Point(0, 0)
        Me.tlpDesc.Name = "tlpDesc"
        Me.tlpDesc.RowCount = 1
        Me.tlpDesc.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpDesc.Size = New System.Drawing.Size(434, 50)
        Me.tlpDesc.TabIndex = 18
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.Transparent
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(388, 50)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Text"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'frmLongrunSQLFilter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 385)
        Me.Controls.Add(Me.tlpList)
        Me.Controls.Add(Me.tlpDesc)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(200, 0)
        Me.Name = "frmLongrunSQLFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LongrunSQLFilter"
        Me.tlpList.ResumeLayout(False)
        Me.tlpList.PerformLayout()
        CType(Me.dgvLongSQLFilterList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpDesc.ResumeLayout(False)
        Me.tlpDesc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvLongSQLFilterList As eXperDB.BaseControls.DataGridView
    Friend WithEvents tlpList As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents tlpDesc As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtExcludeSession As eXperDB.BaseControls.TextBox
    Friend WithEvents lblExcludeSession As eXperDB.BaseControls.Label
    Friend WithEvents btnAddExcludeSession As eXperDB.BaseControls.Button
    Friend WithEvents cmbExcludeSession As eXperDB.BaseControls.ComboBox
    Friend WithEvents coldgvLongSQLFilterListCondition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvLongSQLFilterListText As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvStatementFilterListDel As System.Windows.Forms.DataGridViewImageColumn

End Class
