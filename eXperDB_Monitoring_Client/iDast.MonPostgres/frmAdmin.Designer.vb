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
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
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
        Me.colHARole = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAPort = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHAREPLHost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblHealthTime = New eXperDB.BaseControls.Label()
        Me.cmbHealthTime = New eXperDB.BaseControls.ComboBox()
        Me.lblLogSaveDly = New eXperDB.BaseControls.Label()
        Me.lblLogBatchH = New eXperDB.BaseControls.Label()
        Me.nudLogSaveDly = New eXperDB.BaseControls.NumericUpDown()
        Me.lblLogBatch = New eXperDB.BaseControls.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlB = New System.Windows.Forms.TableLayoutPanel()
        Me.btnAdminPW = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmbObjectTime = New eXperDB.BaseControls.ComboBox()
        Me.lblObjectTime = New eXperDB.BaseControls.Label()
        Me.lblLogBatchM = New eXperDB.BaseControls.Label()
        Me.cmbLogBatchM = New eXperDB.BaseControls.ComboBox()
        Me.cmbLogBatchH = New eXperDB.BaseControls.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBasicConfig = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSvrLst = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCreate = New eXperDB.BaseControls.Button()
        Me.btnModify = New eXperDB.BaseControls.Button()
        Me.btnApply = New eXperDB.BaseControls.Button()
        Me.btnDelete = New eXperDB.BaseControls.Button()
        Me.lblStmtTime = New eXperDB.BaseControls.Label()
        Me.cmbStmtTime = New eXperDB.BaseControls.ComboBox()
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLogSaveDly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CircularProgressControl1
        '
        Me.CircularProgressControl1.BackColor = System.Drawing.Color.Transparent
        Me.CircularProgressControl1.Interval = 60
        Me.CircularProgressControl1.Location = New System.Drawing.Point(243, 210)
        Me.CircularProgressControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CircularProgressControl1.MinimumSize = New System.Drawing.Size(24, 22)
        Me.CircularProgressControl1.Name = "CircularProgressControl1"
        Me.CircularProgressControl1.Rotation = ProgressControl.CircularProgressControl.Direction.CLOCKWISE
        Me.CircularProgressControl1.Size = New System.Drawing.Size(113, 92)
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
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSvrLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvSvrLst.ColumnHeadersHeight = 30
        Me.dgvSvrLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSvrLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCheck, Me.colCollectYN, Me.colAliasNm, Me.colCollectSecond, Me.colDBNm, Me.colIP, Me.colPort, Me.colSchema, Me.colUser, Me.colPW, Me.colLstIP, Me.colPWCH, Me.colHARole, Me.colHAHost, Me.colHAPort, Me.colHAREPLHost})
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle33.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSvrLst.DefaultCellStyle = DataGridViewCellStyle33
        Me.dgvSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSvrLst.EnableHeadersVisualStyles = False
        Me.dgvSvrLst.GridColor = System.Drawing.Color.Gray
        Me.dgvSvrLst.Location = New System.Drawing.Point(0, 40)
        Me.dgvSvrLst.MultiSelect = False
        Me.dgvSvrLst.Name = "dgvSvrLst"
        Me.dgvSvrLst.RowHeadersVisible = False
        Me.dgvSvrLst.RowTemplate.Height = 23
        Me.dgvSvrLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSvrLst.Size = New System.Drawing.Size(717, 445)
        Me.dgvSvrLst.TabIndex = 8
        Me.dgvSvrLst.TagValueMatchColor = System.Drawing.Color.Red
        Me.dgvSvrLst.UseTagValueMatchColor = True
        '
        'colCheck
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.NullValue = False
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White
        Me.colCheck.DefaultCellStyle = DataGridViewCellStyle22
        Me.colCheck.FalseValue = "N"
        Me.colCheck.HeaderText = "F017"
        Me.colCheck.Name = "colCheck"
        Me.colCheck.TrueValue = "Y"
        Me.colCheck.Visible = False
        Me.colCheck.Width = 50
        '
        'colCollectYN
        '
        Me.colCollectYN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.NullValue = False
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White
        Me.colCollectYN.DefaultCellStyle = DataGridViewCellStyle23
        Me.colCollectYN.FalseValue = "N"
        Me.colCollectYN.HeaderText = "F207"
        Me.colCollectYN.MinimumWidth = 60
        Me.colCollectYN.Name = "colCollectYN"
        Me.colCollectYN.TrueValue = "Y"
        Me.colCollectYN.Width = 60
        '
        'colAliasNm
        '
        Me.colAliasNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White
        Me.colAliasNm.DefaultCellStyle = DataGridViewCellStyle24
        Me.colAliasNm.FillWeight = 575.6757!
        Me.colAliasNm.HeaderText = "F019"
        Me.colAliasNm.MinimumWidth = 100
        Me.colAliasNm.Name = "colAliasNm"
        Me.colAliasNm.ReadOnly = True
        '
        'colCollectSecond
        '
        Me.colCollectSecond.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White
        Me.colCollectSecond.DefaultCellStyle = DataGridViewCellStyle25
        Me.colCollectSecond.FillWeight = 40.54054!
        Me.colCollectSecond.HeaderText = "F011"
        Me.colCollectSecond.MinimumWidth = 100
        Me.colCollectSecond.Name = "colCollectSecond"
        Me.colCollectSecond.ReadOnly = True
        Me.colCollectSecond.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCollectSecond.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDBNm
        '
        Me.colDBNm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        Me.colDBNm.DefaultCellStyle = DataGridViewCellStyle26
        Me.colDBNm.FillWeight = 40.54054!
        Me.colDBNm.HeaderText = "F010"
        Me.colDBNm.MinimumWidth = 120
        Me.colDBNm.Name = "colDBNm"
        Me.colDBNm.ReadOnly = True
        '
        'colIP
        '
        Me.colIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White
        Me.colIP.DefaultCellStyle = DataGridViewCellStyle27
        Me.colIP.FillWeight = 40.54054!
        Me.colIP.HeaderText = "F006"
        Me.colIP.MinimumWidth = 100
        Me.colIP.Name = "colIP"
        Me.colIP.ReadOnly = True
        '
        'colPort
        '
        Me.colPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        Me.colPort.DefaultCellStyle = DataGridViewCellStyle28
        Me.colPort.FillWeight = 40.54054!
        Me.colPort.HeaderText = "F007"
        Me.colPort.MinimumWidth = 100
        Me.colPort.Name = "colPort"
        Me.colPort.ReadOnly = True
        '
        'colSchema
        '
        Me.colSchema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White
        Me.colSchema.DefaultCellStyle = DataGridViewCellStyle29
        Me.colSchema.FillWeight = 40.54054!
        Me.colSchema.HeaderText = "F074"
        Me.colSchema.MinimumWidth = 100
        Me.colSchema.Name = "colSchema"
        Me.colSchema.ReadOnly = True
        '
        'colUser
        '
        Me.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White
        Me.colUser.DefaultCellStyle = DataGridViewCellStyle30
        Me.colUser.FillWeight = 40.54054!
        Me.colUser.HeaderText = "F008"
        Me.colUser.MinimumWidth = 100
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        '
        'colPW
        '
        Me.colPW.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White
        Me.colPW.DefaultCellStyle = DataGridViewCellStyle31
        Me.colPW.FillWeight = 40.54054!
        Me.colPW.HeaderText = "F009"
        Me.colPW.MinimumWidth = 100
        Me.colPW.Name = "colPW"
        Me.colPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.colPW.ReadOnly = True
        Me.colPW.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPW.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPW.UseSystemPasswordChar = True
        '
        'colLstIP
        '
        Me.colLstIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White
        Me.colLstIP.DefaultCellStyle = DataGridViewCellStyle32
        Me.colLstIP.FillWeight = 40.54054!
        Me.colLstIP.HeaderText = "F020"
        Me.colLstIP.MinimumWidth = 100
        Me.colLstIP.Name = "colLstIP"
        Me.colLstIP.ReadOnly = True
        '
        'colPWCH
        '
        Me.colPWCH.HeaderText = "PWCH"
        Me.colPWCH.MaxInputLength = 2
        Me.colPWCH.MinimumWidth = 100
        Me.colPWCH.Name = "colPWCH"
        Me.colPWCH.Visible = False
        '
        'colHARole
        '
        Me.colHARole.HeaderText = "HARole"
        Me.colHARole.Name = "colHARole"
        Me.colHARole.ReadOnly = True
        Me.colHARole.Visible = False
        '
        'colHAHost
        '
        Me.colHAHost.HeaderText = "HAHost"
        Me.colHAHost.Name = "colHAHost"
        Me.colHAHost.ReadOnly = True
        Me.colHAHost.Visible = False
        '
        'colHAPort
        '
        Me.colHAPort.HeaderText = "HAPort"
        Me.colHAPort.Name = "colHAPort"
        Me.colHAPort.ReadOnly = True
        Me.colHAPort.Visible = False
        '
        'colHAREPLHost
        '
        Me.colHAREPLHost.HeaderText = "HAREPLHost"
        Me.colHAREPLHost.Name = "colHAREPLHost"
        Me.colHAREPLHost.ReadOnly = True
        Me.colHAREPLHost.Visible = False
        '
        'lblHealthTime
        '
        Me.lblHealthTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHealthTime.FixedHeight = False
        Me.lblHealthTime.FixedWidth = False
        Me.lblHealthTime.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblHealthTime.ForeColor = System.Drawing.Color.White
        Me.lblHealthTime.Location = New System.Drawing.Point(3, 20)
        Me.lblHealthTime.Name = "lblHealthTime"
        Me.lblHealthTime.Size = New System.Drawing.Size(129, 28)
        Me.lblHealthTime.TabIndex = 2
        Me.lblHealthTime.Text = "F200"
        Me.lblHealthTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHealthTime
        '
        Me.cmbHealthTime.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel5.SetColumnSpan(Me.cmbHealthTime, 2)
        Me.cmbHealthTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbHealthTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHealthTime.FixedWidth = False
        Me.cmbHealthTime.FormattingEnabled = True
        Me.cmbHealthTime.Items.AddRange(New Object() {"30"})
        Me.cmbHealthTime.Location = New System.Drawing.Point(138, 23)
        Me.cmbHealthTime.Name = "cmbHealthTime"
        Me.cmbHealthTime.Necessary = False
        Me.cmbHealthTime.Size = New System.Drawing.Size(92, 20)
        Me.cmbHealthTime.StatusTip = ""
        Me.cmbHealthTime.TabIndex = 13
        Me.cmbHealthTime.ValueText = ""
        '
        'lblLogSaveDly
        '
        Me.lblLogSaveDly.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLogSaveDly.FixedHeight = False
        Me.lblLogSaveDly.FixedWidth = False
        Me.lblLogSaveDly.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogSaveDly.ForeColor = System.Drawing.Color.White
        Me.lblLogSaveDly.Location = New System.Drawing.Point(3, 140)
        Me.lblLogSaveDly.Name = "lblLogSaveDly"
        Me.lblLogSaveDly.Size = New System.Drawing.Size(129, 28)
        Me.lblLogSaveDly.TabIndex = 2
        Me.lblLogSaveDly.Text = "F012"
        Me.lblLogSaveDly.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogBatchH
        '
        Me.lblLogBatchH.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatchH.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLogBatchH.FixedHeight = False
        Me.lblLogBatchH.FixedWidth = False
        Me.lblLogBatchH.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatchH.ForeColor = System.Drawing.Color.White
        Me.lblLogBatchH.Location = New System.Drawing.Point(216, 180)
        Me.lblLogBatchH.Name = "lblLogBatchH"
        Me.lblLogBatchH.Size = New System.Drawing.Size(14, 28)
        Me.lblLogBatchH.TabIndex = 14
        Me.lblLogBatchH.Text = "F144"
        Me.lblLogBatchH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudLogSaveDly
        '
        Me.nudLogSaveDly.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel5.SetColumnSpan(Me.nudLogSaveDly, 2)
        Me.nudLogSaveDly.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudLogSaveDly.Dock = System.Windows.Forms.DockStyle.Top
        Me.nudLogSaveDly.FixedWidth = False
        Me.nudLogSaveDly.Location = New System.Drawing.Point(138, 143)
        Me.nudLogSaveDly.Maximum = New Decimal(New Integer() {93, 0, 0, 0})
        Me.nudLogSaveDly.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLogSaveDly.Name = "nudLogSaveDly"
        Me.nudLogSaveDly.Necessary = False
        Me.nudLogSaveDly.Size = New System.Drawing.Size(92, 21)
        Me.nudLogSaveDly.StatusTip = ""
        Me.nudLogSaveDly.TabIndex = 9
        Me.nudLogSaveDly.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLogSaveDly.ThousandsSeparator = True
        Me.nudLogSaveDly.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblLogBatch
        '
        Me.lblLogBatch.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatch.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLogBatch.FixedHeight = False
        Me.lblLogBatch.FixedWidth = False
        Me.lblLogBatch.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatch.ForeColor = System.Drawing.Color.White
        Me.lblLogBatch.Location = New System.Drawing.Point(3, 180)
        Me.lblLogBatch.Name = "lblLogBatch"
        Me.lblLogBatch.Size = New System.Drawing.Size(129, 20)
        Me.lblLogBatch.TabIndex = 12
        Me.lblLogBatch.Text = "F143"
        Me.lblLogBatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle34.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn1.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridViewTextBoxColumn2.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle36.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle36
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle37.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle37
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle38
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle39.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle39.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle39
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
        DataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle40.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle40
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'pnlB
        '
        Me.pnlB.ColumnCount = 2
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.Controls.Add(Me.btnAdminPW, 0, 0)
        Me.pnlB.Controls.Add(Me.btnClose, 1, 0)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(2, 537)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.RowCount = 1
        Me.pnlB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlB.Size = New System.Drawing.Size(954, 44)
        Me.pnlB.TabIndex = 18
        '
        'btnAdminPW
        '
        Me.btnAdminPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAdminPW.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAdminPW.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnAdminPW.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdminPW.FixedHeight = False
        Me.btnAdminPW.FixedWidth = False
        Me.btnAdminPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnAdminPW.ForeColor = System.Drawing.Color.White
        Me.btnAdminPW.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdminPW.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAdminPW.Location = New System.Drawing.Point(334, 3)
        Me.btnAdminPW.Name = "btnAdminPW"
        Me.btnAdminPW.Radius = 10
        Me.btnAdminPW.Size = New System.Drawing.Size(140, 38)
        Me.btnAdminPW.TabIndex = 0
        Me.btnAdminPW.Text = "F004"
        Me.btnAdminPW.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAdminPW.UseRound = True
        Me.btnAdminPW.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(480, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(140, 38)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 52)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CircularProgressControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvSvrLst)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(954, 485)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 19
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.cmbStmtTime, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.lblStmtTime, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbObjectTime, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblObjectTime, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblLogBatchM, 2, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbLogBatchM, 1, 6)
        Me.TableLayoutPanel5.Controls.Add(Me.lblLogBatchH, 2, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.lblLogBatch, 0, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbLogBatchH, 1, 5)
        Me.TableLayoutPanel5.Controls.Add(Me.lblLogSaveDly, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.nudLogSaveDly, 1, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.lblHealthTime, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cmbHealthTime, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 40)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 8
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(233, 445)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'cmbObjectTime
        '
        Me.cmbObjectTime.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel5.SetColumnSpan(Me.cmbObjectTime, 2)
        Me.cmbObjectTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbObjectTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbObjectTime.FixedWidth = False
        Me.cmbObjectTime.FormattingEnabled = True
        Me.cmbObjectTime.Items.AddRange(New Object() {"30"})
        Me.cmbObjectTime.Location = New System.Drawing.Point(138, 63)
        Me.cmbObjectTime.Name = "cmbObjectTime"
        Me.cmbObjectTime.Necessary = False
        Me.cmbObjectTime.Size = New System.Drawing.Size(92, 20)
        Me.cmbObjectTime.StatusTip = ""
        Me.cmbObjectTime.TabIndex = 17
        Me.cmbObjectTime.ValueText = ""
        '
        'lblObjectTime
        '
        Me.lblObjectTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObjectTime.FixedHeight = False
        Me.lblObjectTime.FixedWidth = False
        Me.lblObjectTime.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblObjectTime.ForeColor = System.Drawing.Color.White
        Me.lblObjectTime.Location = New System.Drawing.Point(3, 60)
        Me.lblObjectTime.Name = "lblObjectTime"
        Me.lblObjectTime.Size = New System.Drawing.Size(129, 28)
        Me.lblObjectTime.TabIndex = 16
        Me.lblObjectTime.Text = "F315"
        Me.lblObjectTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLogBatchM
        '
        Me.lblLogBatchM.ControlLength = eXperDB.BaseControls.Label.enmLength.[Long]
        Me.lblLogBatchM.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLogBatchM.FixedHeight = False
        Me.lblLogBatchM.FixedWidth = False
        Me.lblLogBatchM.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLogBatchM.ForeColor = System.Drawing.Color.White
        Me.lblLogBatchM.Location = New System.Drawing.Point(216, 220)
        Me.lblLogBatchM.Name = "lblLogBatchM"
        Me.lblLogBatchM.Size = New System.Drawing.Size(14, 28)
        Me.lblLogBatchM.TabIndex = 15
        Me.lblLogBatchM.Text = "F145"
        Me.lblLogBatchM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLogBatchM
        '
        Me.cmbLogBatchM.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLogBatchM.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbLogBatchM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLogBatchM.FixedWidth = False
        Me.cmbLogBatchM.FormattingEnabled = True
        Me.cmbLogBatchM.Location = New System.Drawing.Point(138, 223)
        Me.cmbLogBatchM.Name = "cmbLogBatchM"
        Me.cmbLogBatchM.Necessary = False
        Me.cmbLogBatchM.Size = New System.Drawing.Size(72, 20)
        Me.cmbLogBatchM.StatusTip = ""
        Me.cmbLogBatchM.TabIndex = 13
        Me.cmbLogBatchM.ValueText = ""
        '
        'cmbLogBatchH
        '
        Me.cmbLogBatchH.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLogBatchH.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbLogBatchH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLogBatchH.FixedWidth = False
        Me.cmbLogBatchH.FormattingEnabled = True
        Me.cmbLogBatchH.Location = New System.Drawing.Point(138, 183)
        Me.cmbLogBatchH.Name = "cmbLogBatchH"
        Me.cmbLogBatchH.Necessary = False
        Me.cmbLogBatchH.Size = New System.Drawing.Size(72, 20)
        Me.cmbLogBatchH.StatusTip = ""
        Me.cmbLogBatchH.TabIndex = 13
        Me.cmbLogBatchH.ValueText = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBasicConfig, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(233, 40)
        Me.TableLayoutPanel2.TabIndex = 11
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
        'lblBasicConfig
        '
        Me.lblBasicConfig.AutoSize = True
        Me.lblBasicConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBasicConfig.ForeColor = System.Drawing.Color.White
        Me.lblBasicConfig.Location = New System.Drawing.Point(43, 0)
        Me.lblBasicConfig.Name = "lblBasicConfig"
        Me.lblBasicConfig.Size = New System.Drawing.Size(187, 40)
        Me.lblBasicConfig.TabIndex = 3
        Me.lblBasicConfig.Text = "기본세팅"
        Me.lblBasicConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSvrLst, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(717, 40)
        Me.TableLayoutPanel1.TabIndex = 10
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
        'lblSvrLst
        '
        Me.lblSvrLst.AutoSize = True
        Me.lblSvrLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSvrLst.ForeColor = System.Drawing.Color.White
        Me.lblSvrLst.Location = New System.Drawing.Point(43, 0)
        Me.lblSvrLst.Name = "lblSvrLst"
        Me.lblSvrLst.Size = New System.Drawing.Size(671, 40)
        Me.lblSvrLst.TabIndex = 3
        Me.lblSvrLst.Text = "F077"
        Me.lblSvrLst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.TableLayoutPanel3.Controls.Add(Me.btnCreate, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnModify, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnApply, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnDelete, 7, 0)
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
        Me.MsgLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCreate.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnCreate.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnCreate.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCreate.FixedHeight = False
        Me.btnCreate.FixedWidth = False
        Me.btnCreate.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnCreate.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(557, 9)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Radius = 10
        Me.btnCreate.Size = New System.Drawing.Size(94, 38)
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "F140"
        Me.btnCreate.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreate.UseRound = True
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnModify.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnModify.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnModify.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnModify.FixedHeight = False
        Me.btnModify.FixedWidth = False
        Me.btnModify.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnModify.ForeColor = System.Drawing.Color.White
        Me.btnModify.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnModify.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnModify.Location = New System.Drawing.Point(657, 9)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Radius = 10
        Me.btnModify.Size = New System.Drawing.Size(94, 38)
        Me.btnModify.TabIndex = 3
        Me.btnModify.Text = "F141"
        Me.btnModify.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnModify.UseRound = True
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnApply.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnApply.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnApply.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnApply.FixedHeight = False
        Me.btnApply.FixedWidth = False
        Me.btnApply.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.White
        Me.btnApply.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnApply.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnApply.Location = New System.Drawing.Point(757, 9)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Radius = 10
        Me.btnApply.Size = New System.Drawing.Size(94, 38)
        Me.btnApply.TabIndex = 4
        Me.btnApply.Text = "F014"
        Me.btnApply.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnApply.UseRound = True
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnDelete.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnDelete.ControlLength = eXperDB.BaseControls.Button.enmLength.[Short]
        Me.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDelete.FixedHeight = False
        Me.btnDelete.FixedWidth = False
        Me.btnDelete.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnDelete.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnDelete.Location = New System.Drawing.Point(857, 9)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Radius = 10
        Me.btnDelete.Size = New System.Drawing.Size(94, 38)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "F015"
        Me.btnDelete.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDelete.UseRound = True
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblStmtTime
        '
        Me.lblStmtTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStmtTime.FixedHeight = False
        Me.lblStmtTime.FixedWidth = False
        Me.lblStmtTime.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStmtTime.ForeColor = System.Drawing.Color.White
        Me.lblStmtTime.Location = New System.Drawing.Point(3, 100)
        Me.lblStmtTime.Name = "lblStmtTime"
        Me.lblStmtTime.Size = New System.Drawing.Size(129, 28)
        Me.lblStmtTime.TabIndex = 18
        Me.lblStmtTime.Text = "F326"
        Me.lblStmtTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbStmtTime
        '
        Me.cmbStmtTime.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel5.SetColumnSpan(Me.cmbStmtTime, 2)
        Me.cmbStmtTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbStmtTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStmtTime.FixedWidth = False
        Me.cmbStmtTime.FormattingEnabled = True
        Me.cmbStmtTime.Items.AddRange(New Object() {"30"})
        Me.cmbStmtTime.Location = New System.Drawing.Point(138, 103)
        Me.cmbStmtTime.Name = "cmbStmtTime"
        Me.cmbStmtTime.Necessary = False
        Me.cmbStmtTime.Size = New System.Drawing.Size(92, 20)
        Me.cmbStmtTime.StatusTip = ""
        Me.cmbStmtTime.TabIndex = 19
        Me.cmbStmtTime.ValueText = ""
        '
        'frmAdmin
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
        Me.Name = "frmAdmin"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Management"
        CType(Me.dgvSvrLst, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLogSaveDly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlB.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblLogSaveDly As eXperDB.BaseControls.Label
    Friend WithEvents dgvSvrLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents nudLogSaveDly As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblLogBatchH As eXperDB.BaseControls.Label
    Friend WithEvents lblLogBatch As eXperDB.BaseControls.Label
    Friend WithEvents cmbHealthTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblHealthTime As eXperDB.BaseControls.Label
    Private WithEvents CircularProgressControl1 As ProgressControl.CircularProgressControl
    Friend WithEvents pnlB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnAdminPW As eXperDB.BaseControls.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSvrLst As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBasicConfig As System.Windows.Forms.Label
    Friend WithEvents btnCreate As eXperDB.BaseControls.Button
    Friend WithEvents btnModify As eXperDB.BaseControls.Button
    Friend WithEvents btnApply As eXperDB.BaseControls.Button
    Friend WithEvents btnDelete As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents lblLogBatchM As eXperDB.BaseControls.Label
    Friend WithEvents cmbLogBatchM As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbLogBatchH As eXperDB.BaseControls.ComboBox
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
    Friend WithEvents colHARole As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAPort As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHAREPLHost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbObjectTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblObjectTime As eXperDB.BaseControls.Label
    Friend WithEvents cmbStmtTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblStmtTime As eXperDB.BaseControls.Label
End Class
