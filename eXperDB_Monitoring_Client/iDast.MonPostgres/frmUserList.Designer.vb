<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserList))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlB = New System.Windows.Forms.TableLayoutPanel()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvUserLst = New eXperDB.BaseControls.DataGridView()
        Me.coldgvUserLstID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvUserLstEdit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.coldgvUserLstDelete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCreate = New eXperDB.BaseControls.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUserList = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvUserLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewPasswordTextBoxColumn1.HeaderText = "F009"
        Me.DataGridViewPasswordTextBoxColumn1.Name = "DataGridViewPasswordTextBoxColumn1"
        Me.DataGridViewPasswordTextBoxColumn1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DataGridViewPasswordTextBoxColumn1.ReadOnly = True
        Me.DataGridViewPasswordTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPasswordTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPasswordTextBoxColumn1.UseSystemPasswordChar = True
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'pnlB
        '
        Me.pnlB.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlB.ColumnCount = 2
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.pnlB.Controls.Add(Me.btnApply, 0, 0)
        Me.pnlB.Controls.Add(Me.btnClose, 1, 0)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(2, 537)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.RowCount = 1
        Me.pnlB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlB.Size = New System.Drawing.Size(954, 44)
        Me.pnlB.TabIndex = 18
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnApply.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.LightGray
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.Transparent
        Me.btnApply.Location = New System.Drawing.Point(380, 3)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 10
        Me.btnApply.Size = New System.Drawing.Size(94, 38)
        Me.btnApply.TabIndex = 6
        Me.btnApply.Text = "F016"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(480, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(94, 38)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvUserLst)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(954, 485)
        Me.SplitContainer1.SplitterDistance = 456
        Me.SplitContainer1.TabIndex = 19
        '
        'dgvUserLst
        '
        Me.dgvUserLst.AllowUserToAddRows = False
        Me.dgvUserLst.AllowUserToDeleteRows = False
        Me.dgvUserLst.AllowUserToResizeRows = False
        Me.dgvUserLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvUserLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUserLst.ColumnHeadersHeight = 30
        Me.dgvUserLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvUserLstID, Me.coldgvUserLstName, Me.coldgvUserLstPassword, Me.coldgvUserLstTel, Me.coldgvUserLstEmail, Me.coldgvUserLstEdit, Me.coldgvUserLstDelete})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserLst.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvUserLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserLst.EnableHeadersVisualStyles = False
        Me.dgvUserLst.GridColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvUserLst.Location = New System.Drawing.Point(0, 40)
        Me.dgvUserLst.Name = "dgvUserLst"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvUserLst.RowHeadersVisible = False
        Me.dgvUserLst.RowTemplate.Height = 23
        Me.dgvUserLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserLst.Size = New System.Drawing.Size(954, 445)
        Me.dgvUserLst.TabIndex = 12
        Me.dgvUserLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvUserLst.UseTagValueMatchColor = True
        '
        'coldgvUserLstID
        '
        Me.coldgvUserLstID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvUserLstID.DataPropertyName = "USER_ID"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvUserLstID.DefaultCellStyle = DataGridViewCellStyle9
        Me.coldgvUserLstID.FillWeight = 20.0!
        Me.coldgvUserLstID.Frozen = True
        Me.coldgvUserLstID.HeaderText = "F019"
        Me.coldgvUserLstID.MinimumWidth = 100
        Me.coldgvUserLstID.Name = "coldgvUserLstID"
        Me.coldgvUserLstID.ReadOnly = True
        '
        'coldgvUserLstName
        '
        Me.coldgvUserLstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvUserLstName.DataPropertyName = "USER_NAME"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvUserLstName.DefaultCellStyle = DataGridViewCellStyle10
        Me.coldgvUserLstName.FillWeight = 40.54054!
        Me.coldgvUserLstName.Frozen = True
        Me.coldgvUserLstName.HeaderText = "F011"
        Me.coldgvUserLstName.MinimumWidth = 100
        Me.coldgvUserLstName.Name = "coldgvUserLstName"
        Me.coldgvUserLstName.ReadOnly = True
        Me.coldgvUserLstName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvUserLstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvUserLstName.Width = 183
        '
        'coldgvUserLstPassword
        '
        Me.coldgvUserLstPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvUserLstPassword.DefaultCellStyle = DataGridViewCellStyle11
        Me.coldgvUserLstPassword.FillWeight = 45.0!
        Me.coldgvUserLstPassword.HeaderText = "F342"
        Me.coldgvUserLstPassword.MinimumWidth = 110
        Me.coldgvUserLstPassword.Name = "coldgvUserLstPassword"
        Me.coldgvUserLstPassword.ReadOnly = True
        Me.coldgvUserLstPassword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.coldgvUserLstPassword.Visible = False
        '
        'coldgvUserLstTel
        '
        Me.coldgvUserLstTel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvUserLstTel.DataPropertyName = "USER_PHONE"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvUserLstTel.DefaultCellStyle = DataGridViewCellStyle12
        Me.coldgvUserLstTel.FillWeight = 50.0!
        Me.coldgvUserLstTel.Frozen = True
        Me.coldgvUserLstTel.HeaderText = "F010"
        Me.coldgvUserLstTel.MinimumWidth = 120
        Me.coldgvUserLstTel.Name = "coldgvUserLstTel"
        Me.coldgvUserLstTel.ReadOnly = True
        Me.coldgvUserLstTel.Width = 226
        '
        'coldgvUserLstEmail
        '
        Me.coldgvUserLstEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvUserLstEmail.DataPropertyName = "USER_EMAIL"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvUserLstEmail.DefaultCellStyle = DataGridViewCellStyle13
        Me.coldgvUserLstEmail.FillWeight = 80.0!
        Me.coldgvUserLstEmail.Frozen = True
        Me.coldgvUserLstEmail.HeaderText = "F006"
        Me.coldgvUserLstEmail.MinimumWidth = 100
        Me.coldgvUserLstEmail.Name = "coldgvUserLstEmail"
        Me.coldgvUserLstEmail.ReadOnly = True
        Me.coldgvUserLstEmail.Width = 362
        '
        'coldgvUserLstEdit
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.NullValue = CType(resources.GetObject("DataGridViewCellStyle14.NullValue"), Object)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.coldgvUserLstEdit.DefaultCellStyle = DataGridViewCellStyle14
        Me.coldgvUserLstEdit.Frozen = True
        Me.coldgvUserLstEdit.HeaderText = ""
        Me.coldgvUserLstEdit.Image = CType(resources.GetObject("coldgvUserLstEdit.Image"), System.Drawing.Image)
        Me.coldgvUserLstEdit.Name = "coldgvUserLstEdit"
        Me.coldgvUserLstEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvUserLstEdit.Width = 40
        '
        'coldgvUserLstDelete
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.NullValue = CType(resources.GetObject("DataGridViewCellStyle15.NullValue"), Object)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.coldgvUserLstDelete.DefaultCellStyle = DataGridViewCellStyle15
        Me.coldgvUserLstDelete.Frozen = True
        Me.coldgvUserLstDelete.HeaderText = ""
        Me.coldgvUserLstDelete.Image = CType(resources.GetObject("coldgvUserLstDelete.Image"), System.Drawing.Image)
        Me.coldgvUserLstDelete.Name = "coldgvUserLstDelete"
        Me.coldgvUserLstDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.coldgvUserLstDelete.Width = 40
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreate, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUserList, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 40)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.LightGray
        Me.btnCreate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreate.FixedHeight = False
        Me.btnCreate.FixedWidth = False
        Me.btnCreate.Font = New System.Drawing.Font("Webdings", 12.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
        Me.btnCreate.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(912, 3)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Radius = 5
        Me.btnCreate.Size = New System.Drawing.Size(39, 34)
        Me.btnCreate.TabIndex = 4
        Me.btnCreate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreate.UseVisualStyleBackColor = False
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
        'lblUserList
        '
        Me.lblUserList.AutoSize = True
        Me.lblUserList.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUserList.ForeColor = System.Drawing.Color.White
        Me.lblUserList.Location = New System.Drawing.Point(43, 0)
        Me.lblUserList.Name = "lblUserList"
        Me.lblUserList.Size = New System.Drawing.Size(763, 40)
        Me.lblUserList.TabIndex = 3
        Me.lblUserList.Text = "Users"
        Me.lblUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 8
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(954, 50)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(448, 50)
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
        'frmUserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.pnlB)
        Me.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserList"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User list"
        Me.pnlB.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvUserLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents dgvUserLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUserList As System.Windows.Forms.Label
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents btnCreate As eXperDB.BaseControls.Button
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents coldgvUserLstID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvUserLstEdit As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents coldgvUserLstDelete As System.Windows.Forms.DataGridViewImageColumn
End Class
