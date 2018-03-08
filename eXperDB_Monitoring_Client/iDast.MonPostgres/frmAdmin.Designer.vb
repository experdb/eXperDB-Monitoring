<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.grpSvrLst = New eXperDB.BaseControls.GroupBox()
        Me.pnlSvr = New eXperDB.BaseControls.Panel()
        Me.CircularProgressControl1 = New ProgressControl.CircularProgressControl()
        Me.dgvSvrLst = New eXperDB.BaseControls.DataGridView()
        Me.colCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colCollectYN = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAliasNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCollectSecond = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDBNm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSchema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPW = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.colLstIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPWCH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlSvtLst = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnDelete = New eXperDB.BaseControls.Button()
        Me.btnCreate = New eXperDB.BaseControls.Button()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.lblLogBatchM = New eXperDB.BaseControls.Label()
        Me.btnModify = New eXperDB.BaseControls.Button()
        Me.lblHealthTime = New eXperDB.BaseControls.Label()
        Me.cmbHealthTime = New eXperDB.BaseControls.ComboBox()
        Me.cmbLogBatchM = New eXperDB.BaseControls.ComboBox()
        Me.lblLogSaveDly = New eXperDB.BaseControls.Label()
        Me.lblLogBatchH = New eXperDB.BaseControls.Label()
        Me.nudLogSaveDly = New eXperDB.BaseControls.NumericUpDown()
        Me.cmbLogBatchH = New eXperDB.BaseControls.ComboBox()
        Me.lblLogBatch = New eXperDB.BaseControls.Label()
        Me.pnlB = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnAdminPW = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.FormMovePanel2 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox2 = New eXperDB.Controls.FormControlBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpSvrLst.SuspendLayout()
        Me.pnlSvr.SuspendLayout()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSvtLst.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudLogSaveDly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlB.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FormMovePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSvrLst
        '
        Me.grpSvrLst.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpSvrLst.AlignString = System.Drawing.StringAlignment.Near
        Me.grpSvrLst.BackColor = System.Drawing.Color.Black
        Me.grpSvrLst.Controls.Add(Me.pnlSvr)
        Me.grpSvrLst.Controls.Add(Me.pnlB)
        Me.grpSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Edges1.LeftBottom = 0
        Edges1.LeftTop = 20
        Edges1.RightBottom = 0
        Edges1.RightTop = 20
        Me.grpSvrLst.EdgeRound = Edges1
        Me.grpSvrLst.FillColor = System.Drawing.Color.Black
        Me.grpSvrLst.Icon = Nothing
        Me.grpSvrLst.LineColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.grpSvrLst.LineWidth = 1
        Me.grpSvrLst.Location = New System.Drawing.Point(2, 33)
        Me.grpSvrLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSvrLst.Name = "grpSvrLst"
        Me.grpSvrLst.Padding = New System.Windows.Forms.Padding(3, 12, 3, 3)
        Me.grpSvrLst.Size = New System.Drawing.Size(1252, 735)
        Me.grpSvrLst.TabIndex = 4
        Me.grpSvrLst.TabStop = False
        Me.grpSvrLst.Text = "F13"
        Me.grpSvrLst.TitleFont = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.grpSvrLst.TitleGraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.grpSvrLst.UseGraColor = True
        Me.grpSvrLst.UseRound = True
        Me.grpSvrLst.UseTitle = True
        '
        'pnlSvr
        '
        Me.pnlSvr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSvr.Controls.Add(Me.CircularProgressControl1)
        Me.pnlSvr.Controls.Add(Me.dgvSvrLst)
        Me.pnlSvr.Controls.Add(Me.pnlSvtLst)
        Me.pnlSvr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSvr.Location = New System.Drawing.Point(3, 30)
        Me.pnlSvr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSvr.Name = "pnlSvr"
        Me.pnlSvr.Size = New System.Drawing.Size(1246, 652)
        Me.pnlSvr.TabIndex = 8
        '
        'CircularProgressControl1
        '
        Me.CircularProgressControl1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressControl1.Interval = 60
        Me.CircularProgressControl1.Location = New System.Drawing.Point(461, 195)
        Me.CircularProgressControl1.MinimumSize = New System.Drawing.Size(28, 28)
        Me.CircularProgressControl1.Name = "CircularProgressControl1"
        Me.CircularProgressControl1.Rotation = ProgressControl.CircularProgressControl.Direction.CLOCKWISE
        Me.CircularProgressControl1.Size = New System.Drawing.Size(257, 185)
        Me.CircularProgressControl1.StartAngle = 270
        Me.CircularProgressControl1.TabIndex = 9
        Me.CircularProgressControl1.TickColor = System.Drawing.Color.FromArgb(CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.CircularProgressControl1.Visible = False
        '
        'dgvSvrLst
        '
        Me.dgvSvrLst.AllowUserToAddRows = False
        Me.dgvSvrLst.AllowUserToDeleteRows = False
        Me.dgvSvrLst.AllowUserToResizeRows = False
        Me.dgvSvrLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvSvrLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colCollectYN, Me.colAliasNm, Me.colCollectSecond, Me.colDBNm, Me.colIP, Me.colPort, Me.colSchema, Me.colUser, Me.colPW, Me.colLstIP, Me.colPWCH})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Gulim", 8.25!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Black
        Me.dgvSvrLst.Location = New System.Drawing.Point(0, 0)
        Me.dgvSvrLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.RowTemplate.Height = 23
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.Size = New System.Drawing.Size(1244, 595)
        Me.dgvSvrLst.TabIndex = 8
        Me.dgvSvrLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvSvrLst.UseTagValueMatchColor = True
        '
        'colCheck
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = False
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.colCheck.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCheck.FalseValue = "N"
        Me.colCheck.HeaderText = "F017"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.TrueValue = "Y"
        Me.colCheck.Width = 50
        '
        'colCollectYN
        '
        Me.colCollectYN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.NullValue = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.colCollectYN.DefaultCellStyle = DataGridViewCellStyle3
        Me.colCollectYN.FalseValue = "N"
        Me.colCollectYN.HeaderText = "F207"
        Me.colCollectYN.Name = "colCollectYN"
        Me.colCollectYN.TrueValue = "Y"
        Me.colCollectYN.Width = 44
        '
        'colAliasNm
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.colAliasNm.DefaultCellStyle = DataGridViewCellStyle4
        Me.colAliasNm.HeaderText = "F019"
        Me.colAliasNm.Name = "colAliasNm"
        Me.colAliasNm.ReadOnly = True
        '
        'colCollectSecond
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.colCollectSecond.DefaultCellStyle = DataGridViewCellStyle5
        Me.colCollectSecond.HeaderText = "F011"
        Me.colCollectSecond.Name = "colCollectSecond"
        Me.colCollectSecond.ReadOnly = True
        Me.colCollectSecond.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCollectSecond.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDBNm
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.colDBNm.DefaultCellStyle = DataGridViewCellStyle6
        Me.colDBNm.HeaderText = "F010"
        Me.colDBNm.Name = "colDBNm"
        Me.colDBNm.ReadOnly = True
        Me.colDBNm.Width = 121
        '
        'colIP
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.colIP.DefaultCellStyle = DataGridViewCellStyle7
        Me.colIP.HeaderText = "F006"
        Me.colIP.Name = "colIP"
        Me.colIP.ReadOnly = True
        Me.colIP.Width = 120
        '
        'colPort
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.colPort.DefaultCellStyle = DataGridViewCellStyle8
        Me.colPort.HeaderText = "F007"
        Me.colPort.Name = "colPort"
        Me.colPort.ReadOnly = True
        '
        'colSchema
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.colSchema.DefaultCellStyle = DataGridViewCellStyle9
        Me.colSchema.HeaderText = "F074"
        Me.colSchema.Name = "colSchema"
        Me.colSchema.ReadOnly = True
        '
        'colUser
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.colUser.DefaultCellStyle = DataGridViewCellStyle10
        Me.colUser.HeaderText = "F008"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'colPW
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        Me.colPW.DefaultCellStyle = DataGridViewCellStyle11
        Me.colPW.HeaderText = "F009"
        Me.colPW.Name = "colPW"
        Me.colPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.colPW.ReadOnly = True
        Me.colPW.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPW.UseSystemPasswordChar = True
        '
        'colLstIP
        '
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.colLstIP.DefaultCellStyle = DataGridViewCellStyle12
        Me.colLstIP.HeaderText = "F020"
        Me.colLstIP.Name = "colLstIP"
        Me.colLstIP.ReadOnly = True
        Me.colLstIP.Width = 120
        '
        'colPWCH
        '
        Me.colPWCH.HeaderText = "PWCH"
        Me.colPWCH.MaxInputLength = 2
        Me.colPWCH.MinimumWidth = 2
        Me.colPWCH.Name = "colPWCH"
        Me.colPWCH.Visible = False
        Me.colPWCH.Width = 5
        '
        'pnlSvtLst
        '
        Me.pnlSvtLst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSvtLst.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlSvtLst.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSvtLst.Location = New System.Drawing.Point(0, 595)
        Me.pnlSvtLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlSvtLst.Name = "pnlSvtLst"
        Me.pnlSvtLst.Size = New System.Drawing.Size(1244, 55)
        Me.pnlSvtLst.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 18
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDelete, 16, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCreate, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnApply, 15, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogBatchM, 13, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnModify, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHealthTime, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbHealthTime, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLogBatchM, 12, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogSaveDly, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogBatchH, 11, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudLogSaveDly, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbLogBatchH, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblLogBatch, 9, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1242, 53)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnDelete.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDelete.FixedHeight = False
        Me.btnDelete.FixedWidth = False
        Me.btnDelete.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.LightGray
        Me.btnDelete.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(1145, 4)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Radius = 10
        Me.btnDelete.Size = New System.Drawing.Size(84, 32)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "F015"
        Me.btnDelete.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.UseRound = True
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnCreate.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCreate.FixedHeight = False
        Me.btnCreate.FixedWidth = False
        Me.btnCreate.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.LightGray
        Me.btnCreate.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCreate.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(3, 4)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Radius = 10
        Me.btnCreate.Size = New System.Drawing.Size(84, 32)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "F140"
        Me.btnCreate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCreate.UseRound = True
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnApply.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.LightGray
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnApply.Location = New System.Drawing.Point(1055, 4)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 10
        Me.btnApply.Size = New System.Drawing.Size(84, 32)
        Me.btnApply.TabIndex = 0
        Me.btnApply.Text = "F014"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblLogBatchM
        '
        Me.lblLogBatchM.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatchM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogBatchM.FixedHeight = False
        Me.lblLogBatchM.FixedWidth = False
        Me.lblLogBatchM.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatchM.ForeColor = System.Drawing.Color.Gray
        Me.lblLogBatchM.Location = New System.Drawing.Point(1004, 0)
        Me.lblLogBatchM.Name = "lblLogBatchM"
        Me.lblLogBatchM.Size = New System.Drawing.Size(29, 40)
        Me.lblLogBatchM.TabIndex = 14
        Me.lblLogBatchM.Text = "F145"
        Me.lblLogBatchM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModify
        '
        Me.btnModify.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnModify.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnModify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModify.FixedHeight = False
        Me.btnModify.FixedWidth = False
        Me.btnModify.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.LightGray
        Me.btnModify.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModify.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnModify.Location = New System.Drawing.Point(93, 4)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Radius = 10
        Me.btnModify.Size = New System.Drawing.Size(84, 32)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "F141"
        Me.btnModify.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModify.UseRound = True
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'lblHealthTime
        '
        Me.lblHealthTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHealthTime.FixedHeight = False
        Me.lblHealthTime.FixedWidth = False
        Me.lblHealthTime.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHealthTime.ForeColor = System.Drawing.Color.Gray
        Me.lblHealthTime.Location = New System.Drawing.Point(195, 0)
        Me.lblHealthTime.Name = "lblHealthTime"
        Me.lblHealthTime.Size = New System.Drawing.Size(144, 40)
        Me.lblHealthTime.TabIndex = 2
        Me.lblHealthTime.Text = "F200"
        Me.lblHealthTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHealthTime
        '
        Me.cmbHealthTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbHealthTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbHealthTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHealthTime.FixedWidth = False
        Me.cmbHealthTime.FormattingEnabled = True
        Me.cmbHealthTime.Items.AddRange(New Object() {"30"})
        Me.cmbHealthTime.Location = New System.Drawing.Point(345, 13)
        Me.cmbHealthTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbHealthTime.Name = "cmbHealthTime"
        Me.cmbHealthTime.Necessary = False
        Me.cmbHealthTime.Size = New System.Drawing.Size(94, 23)
        Me.cmbHealthTime.StatusTip = ""
        Me.cmbHealthTime.TabIndex = 13
        Me.cmbHealthTime.ValueText = ""
        '
        'cmbLogBatchM
        '
        Me.cmbLogBatchM.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLogBatchM.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbLogBatchM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLogBatchM.FixedWidth = False
        Me.cmbLogBatchM.FormattingEnabled = True
        Me.cmbLogBatchM.Location = New System.Drawing.Point(954, 13)
        Me.cmbLogBatchM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbLogBatchM.Name = "cmbLogBatchM"
        Me.cmbLogBatchM.Necessary = False
        Me.cmbLogBatchM.Size = New System.Drawing.Size(44, 23)
        Me.cmbLogBatchM.StatusTip = ""
        Me.cmbLogBatchM.TabIndex = 13
        Me.cmbLogBatchM.ValueText = ""
        '
        'lblLogSaveDly
        '
        Me.lblLogSaveDly.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogSaveDly.FixedHeight = False
        Me.lblLogSaveDly.FixedWidth = False
        Me.lblLogSaveDly.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogSaveDly.ForeColor = System.Drawing.Color.Gray
        Me.lblLogSaveDly.Location = New System.Drawing.Point(457, 0)
        Me.lblLogSaveDly.Name = "lblLogSaveDly"
        Me.lblLogSaveDly.Size = New System.Drawing.Size(144, 40)
        Me.lblLogSaveDly.TabIndex = 2
        Me.lblLogSaveDly.Text = "F012"
        Me.lblLogSaveDly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogBatchH
        '
        Me.lblLogBatchH.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatchH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogBatchH.FixedHeight = False
        Me.lblLogBatchH.FixedWidth = False
        Me.lblLogBatchH.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatchH.ForeColor = System.Drawing.Color.Gray
        Me.lblLogBatchH.Location = New System.Drawing.Point(919, 0)
        Me.lblLogBatchH.Name = "lblLogBatchH"
        Me.lblLogBatchH.Size = New System.Drawing.Size(29, 40)
        Me.lblLogBatchH.TabIndex = 14
        Me.lblLogBatchH.Text = "F144"
        Me.lblLogBatchH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudLogSaveDly
        '
        Me.nudLogSaveDly.BackColor = System.Drawing.SystemColors.Window
        Me.nudLogSaveDly.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudLogSaveDly.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudLogSaveDly.FixedWidth = False
        Me.nudLogSaveDly.Location = New System.Drawing.Point(607, 11)
        Me.nudLogSaveDly.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudLogSaveDly.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudLogSaveDly.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLogSaveDly.Name = "nudLogSaveDly"
        Me.nudLogSaveDly.Necessary = False
        Me.nudLogSaveDly.Size = New System.Drawing.Size(94, 25)
        Me.nudLogSaveDly.StatusTip = ""
        Me.nudLogSaveDly.TabIndex = 9
        Me.nudLogSaveDly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLogSaveDly.ThousandsSeparator = True
        Me.nudLogSaveDly.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbLogBatchH
        '
        Me.cmbLogBatchH.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLogBatchH.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbLogBatchH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLogBatchH.FixedWidth = False
        Me.cmbLogBatchH.FormattingEnabled = True
        Me.cmbLogBatchH.Location = New System.Drawing.Point(869, 13)
        Me.cmbLogBatchH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbLogBatchH.Name = "cmbLogBatchH"
        Me.cmbLogBatchH.Necessary = False
        Me.cmbLogBatchH.Size = New System.Drawing.Size(44, 23)
        Me.cmbLogBatchH.StatusTip = ""
        Me.cmbLogBatchH.TabIndex = 13
        Me.cmbLogBatchH.ValueText = ""
        '
        'lblLogBatch
        '
        Me.lblLogBatch.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLogBatch.FixedHeight = False
        Me.lblLogBatch.FixedWidth = False
        Me.lblLogBatch.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatch.ForeColor = System.Drawing.Color.Gray
        Me.lblLogBatch.Location = New System.Drawing.Point(719, 0)
        Me.lblLogBatch.Name = "lblLogBatch"
        Me.lblLogBatch.Size = New System.Drawing.Size(144, 40)
        Me.lblLogBatch.TabIndex = 12
        Me.lblLogBatch.Text = "F143"
        Me.lblLogBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlB
        '
        Me.pnlB.Controls.Add(Me.TableLayoutPanel2)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(3, 682)
        Me.pnlB.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.Size = New System.Drawing.Size(1246, 50)
        Me.pnlB.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnAdminPW, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1246, 50)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnAdminPW
        '
        Me.btnAdminPW.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAdminPW.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAdminPW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAdminPW.FixedHeight = False
        Me.btnAdminPW.FixedWidth = False
        Me.btnAdminPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAdminPW.ForeColor = System.Drawing.Color.LightGray
        Me.btnAdminPW.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdminPW.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAdminPW.Location = New System.Drawing.Point(3, 4)
        Me.btnAdminPW.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdminPW.Name = "btnAdminPW"
        Me.btnAdminPW.Radius = 10
        Me.btnAdminPW.Size = New System.Drawing.Size(144, 32)
        Me.btnAdminPW.TabIndex = 11
        Me.btnAdminPW.Text = "F004"
        Me.btnAdminPW.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdminPW.UseRound = True
        Me.btnAdminPW.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.LightGray
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(1119, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(114, 32)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormMovePanel2
        '
        Me.FormMovePanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel2.Controls.Add(Me.FormControlBox2)
        Me.FormMovePanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel2.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel2.Location = New System.Drawing.Point(2, 2)
        Me.FormMovePanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel2.Name = "FormMovePanel2"
        Me.FormMovePanel2.Size = New System.Drawing.Size(1252, 31)
        Me.FormMovePanel2.TabIndex = 18
        Me.FormMovePanel2.Text = "eXperDB-Monitoring"
        '
        'FormControlBox2
        '
        Me.FormControlBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox2.CloseBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox2.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox2.isCritical = True
        Me.FormControlBox2.isLock = False
        Me.FormControlBox2.isPower = True
        Me.FormControlBox2.isRotation = True
        Me.FormControlBox2.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox2.Location = New System.Drawing.Point(1227, 0)
        Me.FormControlBox2.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox2.MaxBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.MinBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.Name = "FormControlBox2"
        Me.FormControlBox2.PowerBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox2.ShowRectCnt = 1
        Me.FormControlBox2.Size = New System.Drawing.Size(23, 22)
        Me.FormControlBox2.TabIndex = 1
        Me.FormControlBox2.Text = "FormControlBox2"
        Me.FormControlBox2.UseConfigBox = False
        Me.FormControlBox2.UseCriticalBox = False
        Me.FormControlBox2.UseDualBox = False
        Me.FormControlBox2.UseLockBox = False
        Me.FormControlBox2.UseMaxBox = False
        Me.FormControlBox2.UseMinBox = False
        Me.FormControlBox2.UsePowerBox = False
        Me.FormControlBox2.UseRotationBox = True
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn1.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn2.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle19
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
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1256, 770)
        Me.Controls.Add(Me.grpSvrLst)
        Me.Controls.Add(Me.FormMovePanel2)
        Me.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        Me.grpSvrLst.ResumeLayout(False)
        Me.pnlSvr.ResumeLayout(False)
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSvtLst.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nudLogSaveDly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlB.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FormMovePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogSaveDly As eXperDB.BaseControls.Label
    Friend WithEvents grpSvrLst As eXperDB.BaseControls.GroupBox
    Friend WithEvents pnlSvr As eXperDB.BaseControls.Panel
    Friend WithEvents pnlSvtLst As eXperDB.BaseControls.Panel
    Friend WithEvents btnDelete As eXperDB.BaseControls.Button
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents pnlB As eXperDB.BaseControls.Panel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents dgvSvrLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents nudLogSaveDly As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormMovePanel2 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox2 As eXperDB.Controls.FormControlBox
    Friend WithEvents btnModify As eXperDB.BaseControls.Button
    Friend WithEvents btnCreate As eXperDB.BaseControls.Button
    Friend WithEvents lblLogBatchM As eXperDB.BaseControls.Label
    Friend WithEvents lblLogBatchH As eXperDB.BaseControls.Label
    Friend WithEvents cmbLogBatchM As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbLogBatchH As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblLogBatch As eXperDB.BaseControls.Label
    Friend WithEvents cmbHealthTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblHealthTime As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As eXperDB.BaseControls.TableLayoutPanel
    Private WithEvents CircularProgressControl1 As ProgressControl.CircularProgressControl
    Friend WithEvents colCheck As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colCollectYN As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAliasNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCollectSecond As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDBNm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSchema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPW As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents colLstIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPWCH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdminPW As eXperDB.BaseControls.Button
End Class
