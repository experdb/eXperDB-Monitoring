<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddSvrList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddSvrList))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSvrList = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnCancel = New eXperDB.BaseControls.Button()
        Me.btnAdd = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel7 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.dgvSvrLst = New AdvancedDataGridView.TreeGridView()
        Me.dbmsImgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.colHostNm = New AdvancedDataGridView.TreeGridColumn()
        Me.colAliasNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPW = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.colLstIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrp = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colStartTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHARole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCollectPeriod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewPasswordTextBoxColumn1.HeaderText = "F009"
        Me.DataGridViewPasswordTextBoxColumn1.Name = "DataGridViewPasswordTextBoxColumn1"
        Me.DataGridViewPasswordTextBoxColumn1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DataGridViewPasswordTextBoxColumn1.ReadOnly = True
        Me.DataGridViewPasswordTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewPasswordTextBoxColumn1.UseSystemPasswordChar = True
        Me.DataGridViewPasswordTextBoxColumn1.Visible = False
        Me.DataGridViewPasswordTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblSubject, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(768, 44)
        Me.TableLayoutPanel6.TabIndex = 17
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.BackColor = System.Drawing.Color.Transparent
        Me.lblSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSubject.ForeColor = System.Drawing.Color.White
        Me.lblSubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSubject.Location = New System.Drawing.Point(43, 0)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(608, 43)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Text"
        Me.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 43)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "      "
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSvrList, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(768, 40)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "      "
        '
        'lblSvrList
        '
        Me.lblSvrList.AutoSize = True
        Me.lblSvrList.BackColor = System.Drawing.Color.Transparent
        Me.lblSvrList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrList.ForeColor = System.Drawing.Color.White
        Me.lblSvrList.Location = New System.Drawing.Point(43, 0)
        Me.lblSvrList.Name = "lblSvrList"
        Me.lblSvrList.Size = New System.Drawing.Size(722, 40)
        Me.lblSvrList.TabIndex = 3
        Me.lblSvrList.Text = "F013"
        Me.lblSvrList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.btnCancel, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.btnAdd, 1, 0)
        Me.TableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 450)
        Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(768, 46)
        Me.TableLayoutPanel8.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancel.FixedHeight = False
        Me.btnCancel.FixedWidth = False
        Me.btnCancel.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnCancel.LineColor = System.Drawing.Color.Transparent
        Me.btnCancel.Location = New System.Drawing.Point(387, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Radius = 10
        Me.btnCancel.Size = New System.Drawing.Size(114, 40)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "F021"
        Me.btnCancel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCancel.UseRound = True
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdd.FixedHeight = False
        Me.btnAdd.FixedWidth = False
        Me.btnAdd.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAdd.LineColor = System.Drawing.Color.Transparent
        Me.btnAdd.Location = New System.Drawing.Point(267, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Radius = 10
        Me.btnAdd.Size = New System.Drawing.Size(114, 40)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "F016"
        Me.btnAdd.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAdd.UseRound = True
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel8, 0, 3)
        Me.TableLayoutPanel7.Controls.Add(Me.dgvSvrLst, 0, 2)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 4
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(774, 498)
        Me.TableLayoutPanel7.TabIndex = 24
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToOrderColumns = True
        Me.dgvSvrLst.AllowUserToResizeRows = False
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSvrLst.ColumnHeadersHeight = 24
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHostNm, Me.colAliasNm, Me.colDBNm, Me.colUser, Me.colIP, Me.colPort, Me.colPW, Me.colLstIP, Me.colGrp, Me.colStartTime, Me.colHARole, Me.colHAHost, Me.colHAPort, Me.colPGV, Me.colCollectPeriod})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Black
        Me.dgvSvrLst.HideExpandeIcon = False
        Me.dgvSvrLst.ImageList = Nothing
        Me.dgvSvrLst.Location = New System.Drawing.Point(3, 103)
        Me.dgvSvrLst.Name = "dgvSvrLst"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.ShowLines = False
        Me.dgvSvrLst.Size = New System.Drawing.Size(768, 342)
        Me.dgvSvrLst.TabIndex = 19
        '
        'dbmsImgLst
        '
        Me.dbmsImgLst.ImageStream = CType(resources.GetObject("dbmsImgLst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.dbmsImgLst.TransparentColor = System.Drawing.Color.Transparent
        Me.dbmsImgLst.Images.SetKeyName(0, "if_database_green_92629.ico")
        Me.dbmsImgLst.Images.SetKeyName(1, "if_database_link_35958.ico")
        '
        'colHostNm
        '
        Me.colHostNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colHostNm.DataPropertyName = "HOST_NAME"
        Me.colHostNm.DefaultNodeImage = Nothing
        Me.colHostNm.FillWeight = 250.0!
        Me.colHostNm.HeaderText = "HOST_NAME"
        Me.colHostNm.MinimumWidth = 100
        Me.colHostNm.Name = "colHostNm"
        Me.colHostNm.ReadOnly = True
        Me.colHostNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAliasNm
        '
        Me.colAliasNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colAliasNm.DataPropertyName = "CONN_NAME"
        Me.colAliasNm.HeaderText = "F019"
        Me.colAliasNm.MinimumWidth = 80
        Me.colAliasNm.Name = "colAliasNm"
        Me.colAliasNm.ReadOnly = True
        Me.colAliasNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDBNm
        '
        Me.colDBNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDBNm.DataPropertyName = "CONN_DB_NAME"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colDBNm.DefaultCellStyle = DataGridViewCellStyle9
        Me.colDBNm.HeaderText = "F010"
        Me.colDBNm.MinimumWidth = 80
        Me.colDBNm.Name = "colDBNm"
        Me.colDBNm.ReadOnly = True
        Me.colDBNm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colUser
        '
        Me.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colUser.DataPropertyName = "CONN_USER_ID"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colUser.DefaultCellStyle = DataGridViewCellStyle10
        Me.colUser.HeaderText = "F008"
        Me.colUser.MinimumWidth = 50
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        Me.colUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colIP
        '
        Me.colIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colIP.DataPropertyName = "SERVER_IP"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colIP.DefaultCellStyle = DataGridViewCellStyle11
        Me.colIP.HeaderText = "F006"
        Me.colIP.MinimumWidth = 50
        Me.colIP.Name = "colIP"
        Me.colIP.ReadOnly = True
        Me.colIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPort
        '
        Me.colPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPort.DataPropertyName = "SERVICE_PORT"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colPort.DefaultCellStyle = DataGridViewCellStyle12
        Me.colPort.FillWeight = 80.0!
        Me.colPort.HeaderText = "F007"
        Me.colPort.MinimumWidth = 50
        Me.colPort.Name = "colPort"
        Me.colPort.ReadOnly = True
        Me.colPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPW
        '
        Me.colPW.DataPropertyName = "CONN_USER_PWD"
        Me.colPW.HeaderText = "F009"
        Me.colPW.Name = "colPW"
        Me.colPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.colPW.ReadOnly = True
        Me.colPW.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colPW.UseSystemPasswordChar = True
        Me.colPW.Visible = False
        Me.colPW.Width = 5
        '
        'colLstIP
        '
        Me.colLstIP.DataPropertyName = "LAST_MOD_IP"
        Me.colLstIP.HeaderText = "F020"
        Me.colLstIP.Name = "colLstIP"
        Me.colLstIP.ReadOnly = True
        Me.colLstIP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colLstIP.Visible = False
        '
        'colGrp
        '
        Me.colGrp.DataPropertyName = "MON_GROUP"
        Me.colGrp.HeaderText = "F025"
        Me.colGrp.Name = "colGrp"
        Me.colGrp.Visible = False
        Me.colGrp.Width = 134
        '
        'colStartTime
        '
        Me.colStartTime.DataPropertyName = "INSTANCE_UPTIME"
        Me.colStartTime.HeaderText = "STARTTIME"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.ReadOnly = True
        Me.colStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colStartTime.Visible = False
        '
        'colHARole
        '
        Me.colHARole.DataPropertyName = "HA_ROLE"
        Me.colHARole.HeaderText = "HAROLE"
        Me.colHARole.Name = "colHARole"
        Me.colHARole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colHARole.Visible = False
        '
        'colHAHost
        '
        Me.colHAHost.DataPropertyName = "HA_HOST"
        Me.colHAHost.HeaderText = "HAHOST"
        Me.colHAHost.Name = "colHAHost"
        Me.colHAHost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colHAHost.Visible = False
        '
        'colHAPort
        '
        Me.colHAPort.DataPropertyName = "HA_PORT"
        Me.colHAPort.HeaderText = "HAPORT"
        Me.colHAPort.Name = "colHAPort"
        Me.colHAPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colHAPort.Visible = False
        '
        'colPGV
        '
        Me.colPGV.DataPropertyName = "PG_VERSION"
        Me.colPGV.HeaderText = "PGV"
        Me.colPGV.Name = "colPGV"
        Me.colPGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPGV.Visible = False
        '
        'colCollectPeriod
        '
        Me.colCollectPeriod.DataPropertyName = "COLLECT_PERIOD_SEC"
        Me.colCollectPeriod.HeaderText = "PERIOD"
        Me.colCollectPeriod.Name = "colCollectPeriod"
        Me.colCollectPeriod.ReadOnly = True
        Me.colCollectPeriod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCollectPeriod.Visible = False
        '
        'frmAddSvrList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 508)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddSvrList"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Server Setting"
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSvrList As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel8 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnAdd As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel7 As eXperDB.BaseControls.TableLayoutPanel
    'Friend WithEvents dgvSvrLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents dgvSvrLst As AdvancedDataGridView.TreeGridView
    'Friend WithEvents colHostNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As eXperDB.BaseControls.Button
    Friend WithEvents dbmsImgLst As System.Windows.Forms.ImageList
    Friend WithEvents colHostNm As AdvancedDataGridView.TreeGridColumn
    Friend WithEvents colAliasNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPW As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents colLstIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGrp As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colStartTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHARole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPGV As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCollectPeriod As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
