<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.tbMain = New FlatTabControl.FlatTabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.rbUseNoti2 = New eXperDB.BaseControls.RadioButton()
        Me.rbUseNoti1 = New eXperDB.BaseControls.RadioButton()
        Me.TableLayoutPanel7 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnUserSave = New eXperDB.BaseControls.Button()
        Me.btnPassword = New eXperDB.BaseControls.Button()
        Me.lblDept = New eXperDB.BaseControls.Label()
        Me.txtDept = New eXperDB.BaseControls.TextBox()
        Me.txtPhone2 = New eXperDB.BaseControls.TextBox()
        Me.lblPhone2 = New eXperDB.BaseControls.Label()
        Me.txtEmail = New eXperDB.BaseControls.TextBox()
        Me.lblEmail = New eXperDB.BaseControls.Label()
        Me.txtPhone = New eXperDB.BaseControls.TextBox()
        Me.lblPhone = New eXperDB.BaseControls.Label()
        Me.lblUserID = New eXperDB.BaseControls.Label()
        Me.lblUserName = New eXperDB.BaseControls.Label()
        Me.txtUserID = New eXperDB.BaseControls.TextBox()
        Me.txtUserName = New eXperDB.BaseControls.TextBox()
        Me.chkNor = New eXperDB.BaseControls.CheckBox()
        Me.chkWar = New eXperDB.BaseControls.CheckBox()
        Me.chkCri = New eXperDB.BaseControls.CheckBox()
        Me.lblHealthCheck = New eXperDB.BaseControls.Label()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel6 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblSound = New eXperDB.BaseControls.Label()
        Me.lbGrpRatate = New eXperDB.BaseControls.Label()
        Me.Button2 = New eXperDB.BaseControls.Button()
        Me.rbAlias = New eXperDB.BaseControls.RadioButton()
        Me.Button1 = New eXperDB.BaseControls.Button()
        Me.chkUseDefaultAccount = New eXperDB.BaseControls.CheckBox()
        Me.cmbLang = New eXperDB.BaseControls.ComboBox()
        Me.lblLang = New eXperDB.BaseControls.Label()
        Me.lblCollect = New eXperDB.BaseControls.Label()
        Me.nudCollect = New eXperDB.BaseControls.NumericUpDown()
        Me.txtSound = New eXperDB.BaseControls.TextBox()
        Me.rbHostnm = New eXperDB.BaseControls.RadioButton()
        Me.lblSQLPlan = New eXperDB.BaseControls.Label()
        Me.nudGrpRotate = New eXperDB.BaseControls.NumericUpDown()
        Me.lblShowNm = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel3 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRaider = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.chkMemItemReverse = New eXperDB.BaseControls.CheckBox()
        Me.chkCpuItemReverse = New eXperDB.BaseControls.CheckBox()
        Me.lblMemStyle = New eXperDB.BaseControls.Label()
        Me.lblCpuStyle = New eXperDB.BaseControls.Label()
        Me.cmbMemStyle = New eXperDB.BaseControls.ComboBox()
        Me.cmbCpuStyle = New eXperDB.BaseControls.ComboBox()
        Me.lblRegex = New eXperDB.BaseControls.Label()
        Me.txtRegex = New eXperDB.BaseControls.TextBox()
        Me.btnQueryInit = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatCombo1 = New FlatCombobox.FlatCombo()
        Me.tbMain.SuspendLayout()
        Me.tp1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.tp2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.nudCollect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGrpRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.tp1)
        Me.tbMain.Controls.Add(Me.tp2)
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tbMain.ItemSize = New System.Drawing.Size(150, 21)
        Me.tbMain.Location = New System.Drawing.Point(3, 53)
        Me.tbMain.myBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(604, 422)
        Me.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbMain.TabIndex = 10
        '
        'tp1
        '
        Me.tp1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tp1.Controls.Add(Me.tlpSvrChk)
        Me.tp1.Controls.Add(Me.chkNor)
        Me.tp1.Controls.Add(Me.chkWar)
        Me.tp1.Controls.Add(Me.chkCri)
        Me.tp1.Controls.Add(Me.lblHealthCheck)
        Me.tp1.ForeColor = System.Drawing.Color.White
        Me.tp1.Location = New System.Drawing.Point(4, 25)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(5)
        Me.tp1.Size = New System.Drawing.Size(596, 393)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "F024"
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tlpSvrChk.ColumnCount = 5
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.rbUseNoti2, 3, 5)
        Me.tlpSvrChk.Controls.Add(Me.rbUseNoti1, 3, 4)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel7, 0, 8)
        Me.tlpSvrChk.Controls.Add(Me.btnPassword, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblDept, 1, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtDept, 2, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtPhone2, 2, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblPhone2, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.txtEmail, 2, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblEmail, 1, 6)
        Me.tlpSvrChk.Controls.Add(Me.txtPhone, 2, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblPhone, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblUserID, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblUserName, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtUserID, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtUserName, 2, 2)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(5, 5)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 9
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(586, 383)
        Me.tlpSvrChk.TabIndex = 22
        '
        'rbUseNoti2
        '
        Me.rbUseNoti2.AutoSize = True
        Me.rbUseNoti2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbUseNoti2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbUseNoti2.ForeColor = System.Drawing.Color.White
        Me.rbUseNoti2.LineColor = System.Drawing.Color.Gray
        Me.rbUseNoti2.Location = New System.Drawing.Point(305, 191)
        Me.rbUseNoti2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbUseNoti2.Name = "rbUseNoti2"
        Me.rbUseNoti2.Radius = 10
        Me.rbUseNoti2.Size = New System.Drawing.Size(169, 16)
        Me.rbUseNoti2.TabIndex = 21
        Me.rbUseNoti2.TabStop = True
        Me.rbUseNoti2.Text = "F922"
        Me.rbUseNoti2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbUseNoti2.UseVisualStyleBackColor = True
        Me.rbUseNoti2.Warning = False
        Me.rbUseNoti2.WarningColor = System.Drawing.Color.Red
        '
        'rbUseNoti1
        '
        Me.rbUseNoti1.AutoSize = True
        Me.rbUseNoti1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbUseNoti1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbUseNoti1.ForeColor = System.Drawing.Color.White
        Me.rbUseNoti1.LineColor = System.Drawing.Color.Gray
        Me.rbUseNoti1.Location = New System.Drawing.Point(305, 151)
        Me.rbUseNoti1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbUseNoti1.Name = "rbUseNoti1"
        Me.rbUseNoti1.Radius = 10
        Me.rbUseNoti1.Size = New System.Drawing.Size(169, 16)
        Me.rbUseNoti1.TabIndex = 20
        Me.rbUseNoti1.TabStop = True
        Me.rbUseNoti1.Text = "F922"
        Me.rbUseNoti1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbUseNoti1.UseVisualStyleBackColor = True
        Me.rbUseNoti1.Warning = False
        Me.rbUseNoti1.WarningColor = System.Drawing.Color.Red
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel7.ColumnCount = 3
        Me.tlpSvrChk.SetColumnSpan(Me.TableLayoutPanel7, 5)
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnUserSave, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel7.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 336)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(580, 45)
        Me.TableLayoutPanel7.TabIndex = 18
        '
        'btnUserSave
        '
        Me.btnUserSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnUserSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnUserSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnUserSave.FixedHeight = False
        Me.btnUserSave.FixedWidth = False
        Me.btnUserSave.ForeColor = System.Drawing.Color.White
        Me.btnUserSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnUserSave.LineColor = System.Drawing.Color.Transparent
        Me.btnUserSave.Location = New System.Drawing.Point(247, 4)
        Me.btnUserSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUserSave.Name = "btnUserSave"
        Me.btnUserSave.Radius = 10
        Me.btnUserSave.Size = New System.Drawing.Size(90, 37)
        Me.btnUserSave.TabIndex = 0
        Me.btnUserSave.Text = "F014"
        Me.btnUserSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUserSave.UseRound = True
        Me.btnUserSave.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPassword.FixedHeight = False
        Me.btnPassword.FixedWidth = False
        Me.btnPassword.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnPassword.LineColor = System.Drawing.Color.Transparent
        Me.btnPassword.Location = New System.Drawing.Point(143, 97)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Radius = 10
        Me.btnPassword.Size = New System.Drawing.Size(156, 30)
        Me.btnPassword.TabIndex = 16
        Me.btnPassword.Text = "F279"
        Me.btnPassword.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPassword.UseRound = True
        Me.btnPassword.UseVisualStyleBackColor = True
        '
        'lblDept
        '
        Me.lblDept.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDept.FixedHeight = False
        Me.lblDept.FixedWidth = False
        Me.lblDept.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDept.ForeColor = System.Drawing.Color.White
        Me.lblDept.LineSpacing = 0.0!
        Me.lblDept.Location = New System.Drawing.Point(23, 270)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(114, 20)
        Me.lblDept.TabIndex = 14
        Me.lblDept.Text = "F915"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.Control
        Me.txtDept.code = False
        Me.txtDept.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDept.FixedWidth = False
        Me.txtDept.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDept.impossibleinput = "!#$%^&*() \/:*?""<>|'`~"
        Me.txtDept.Location = New System.Drawing.Point(143, 266)
        Me.txtDept.MaxByteLength = 100
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Necessary = False
        Me.txtDept.PossibleInput = ""
        Me.txtDept.Prefix = ""
        Me.txtDept.Size = New System.Drawing.Size(156, 21)
        Me.txtDept.StatusTip = ""
        Me.txtDept.TabIndex = 13
        Me.txtDept.Value = ""
        '
        'txtPhone2
        '
        Me.txtPhone2.BackColor = System.Drawing.SystemColors.Control
        Me.txtPhone2.code = False
        Me.txtPhone2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPhone2.FixedWidth = False
        Me.txtPhone2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPhone2.impossibleinput = ""
        Me.txtPhone2.Location = New System.Drawing.Point(143, 186)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Necessary = False
        Me.txtPhone2.PossibleInput = "0123456789+"
        Me.txtPhone2.Prefix = ""
        Me.txtPhone2.Size = New System.Drawing.Size(156, 21)
        Me.txtPhone2.StatusTip = ""
        Me.txtPhone2.TabIndex = 12
        Me.txtPhone2.Value = ""
        '
        'lblPhone2
        '
        Me.lblPhone2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPhone2.FixedHeight = False
        Me.lblPhone2.FixedWidth = False
        Me.lblPhone2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPhone2.ForeColor = System.Drawing.Color.White
        Me.lblPhone2.LineSpacing = 0.0!
        Me.lblPhone2.Location = New System.Drawing.Point(23, 190)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(114, 20)
        Me.lblPhone2.TabIndex = 11
        Me.lblPhone2.Text = "F349"
        Me.lblPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmail.code = False
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtEmail.FixedWidth = False
        Me.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmail.impossibleinput = "!#$%^&*() \/:*?""<>|'`~"
        Me.txtEmail.Location = New System.Drawing.Point(143, 226)
        Me.txtEmail.MaxByteLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Necessary = False
        Me.txtEmail.PossibleInput = ""
        Me.txtEmail.Prefix = ""
        Me.txtEmail.Size = New System.Drawing.Size(156, 21)
        Me.txtEmail.StatusTip = ""
        Me.txtEmail.TabIndex = 9
        Me.txtEmail.Value = ""
        '
        'lblEmail
        '
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblEmail.FixedHeight = False
        Me.lblEmail.FixedWidth = False
        Me.lblEmail.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.LineSpacing = 0.0!
        Me.lblEmail.Location = New System.Drawing.Point(23, 230)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(114, 20)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "F350"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Control
        Me.txtPhone.code = False
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPhone.FixedWidth = False
        Me.txtPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPhone.impossibleinput = ""
        Me.txtPhone.Location = New System.Drawing.Point(143, 146)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Necessary = False
        Me.txtPhone.PossibleInput = "0123456789+"
        Me.txtPhone.Prefix = ""
        Me.txtPhone.Size = New System.Drawing.Size(156, 21)
        Me.txtPhone.StatusTip = ""
        Me.txtPhone.TabIndex = 8
        Me.txtPhone.Value = ""
        '
        'lblPhone
        '
        Me.lblPhone.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPhone.FixedHeight = False
        Me.lblPhone.FixedWidth = False
        Me.lblPhone.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPhone.ForeColor = System.Drawing.Color.White
        Me.lblPhone.LineSpacing = 0.0!
        Me.lblPhone.Location = New System.Drawing.Point(23, 150)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(114, 20)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "F349"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserID
        '
        Me.lblUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserID.FixedHeight = False
        Me.lblUserID.FixedWidth = False
        Me.lblUserID.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserID.ForeColor = System.Drawing.Color.White
        Me.lblUserID.LineSpacing = 0.0!
        Me.lblUserID.Location = New System.Drawing.Point(23, 30)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(114, 20)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "F347"
        Me.lblUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserName
        '
        Me.lblUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUserName.FixedHeight = False
        Me.lblUserName.FixedWidth = False
        Me.lblUserName.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.White
        Me.lblUserName.LineSpacing = 0.0!
        Me.lblUserName.Location = New System.Drawing.Point(23, 70)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(114, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "F348"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Control
        Me.txtUserID.code = False
        Me.txtUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserID.Enabled = False
        Me.txtUserID.FixedWidth = False
        Me.txtUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserID.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtUserID.Location = New System.Drawing.Point(143, 26)
        Me.txtUserID.MaxByteLength = 16
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Necessary = False
        Me.txtUserID.PossibleInput = ""
        Me.txtUserID.Prefix = ""
        Me.txtUserID.Size = New System.Drawing.Size(156, 21)
        Me.txtUserID.StatusTip = ""
        Me.txtUserID.TabIndex = 0
        Me.txtUserID.Value = ""
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtUserName.code = False
        Me.txtUserName.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserName.FixedWidth = False
        Me.txtUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserName.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtUserName.Location = New System.Drawing.Point(143, 66)
        Me.txtUserName.MaxByteLength = 30
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Necessary = True
        Me.txtUserName.PossibleInput = ""
        Me.txtUserName.Prefix = ""
        Me.txtUserName.Size = New System.Drawing.Size(156, 21)
        Me.txtUserName.StatusTip = ""
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Value = ""
        '
        'chkNor
        '
        Me.chkNor.AutoSize = True
        Me.chkNor.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkNor.LineColor = System.Drawing.Color.Gray
        Me.chkNor.Location = New System.Drawing.Point(428, 409)
        Me.chkNor.Name = "chkNor"
        Me.chkNor.Radius = 10
        Me.chkNor.Size = New System.Drawing.Size(49, 16)
        Me.chkNor.TabIndex = 5
        Me.chkNor.Text = "F029"
        Me.chkNor.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkNor.UseVisualStyleBackColor = True
        Me.chkNor.Visible = False
        '
        'chkWar
        '
        Me.chkWar.AutoSize = True
        Me.chkWar.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkWar.LineColor = System.Drawing.Color.Gray
        Me.chkWar.Location = New System.Drawing.Point(529, 409)
        Me.chkWar.Name = "chkWar"
        Me.chkWar.Radius = 10
        Me.chkWar.Size = New System.Drawing.Size(49, 16)
        Me.chkWar.TabIndex = 6
        Me.chkWar.Text = "F030"
        Me.chkWar.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkWar.UseVisualStyleBackColor = True
        Me.chkWar.Visible = False
        '
        'chkCri
        '
        Me.chkCri.AutoSize = True
        Me.chkCri.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCri.LineColor = System.Drawing.Color.Gray
        Me.chkCri.Location = New System.Drawing.Point(632, 409)
        Me.chkCri.Name = "chkCri"
        Me.chkCri.Radius = 10
        Me.chkCri.Size = New System.Drawing.Size(49, 16)
        Me.chkCri.TabIndex = 7
        Me.chkCri.Text = "F031"
        Me.chkCri.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCri.UseVisualStyleBackColor = True
        Me.chkCri.Visible = False
        '
        'lblHealthCheck
        '
        Me.lblHealthCheck.LineSpacing = 0.0!
        Me.lblHealthCheck.Location = New System.Drawing.Point(321, 405)
        Me.lblHealthCheck.Name = "lblHealthCheck"
        Me.lblHealthCheck.Size = New System.Drawing.Size(100, 21)
        Me.lblHealthCheck.TabIndex = 1
        Me.lblHealthCheck.Text = "F189"
        Me.lblHealthCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblHealthCheck.Visible = False
        '
        'tp2
        '
        Me.tp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tp2.Controls.Add(Me.TableLayoutPanel5)
        Me.tp2.Controls.Add(Me.lblRegex)
        Me.tp2.Controls.Add(Me.txtRegex)
        Me.tp2.Controls.Add(Me.btnQueryInit)
        Me.tp2.ForeColor = System.Drawing.Color.White
        Me.tp2.Location = New System.Drawing.Point(4, 25)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(5)
        Me.tp2.Size = New System.Drawing.Size(596, 393)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "F038"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 4
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(586, 383)
        Me.TableLayoutPanel5.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel5.SetColumnSpan(Me.TableLayoutPanel1, 4)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 336)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(580, 45)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.Transparent
        Me.btnSave.Location = New System.Drawing.Point(247, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(90, 37)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 7
        Me.TableLayoutPanel5.SetColumnSpan(Me.TableLayoutPanel6, 4)
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.FlatCombo1, 6, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblSound, 1, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.lbGrpRatate, 1, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.Button2, 5, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.rbAlias, 3, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.Button1, 4, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.chkUseDefaultAccount, 2, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.cmbLang, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLang, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblCollect, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.nudCollect, 2, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txtSound, 2, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.rbHostnm, 2, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.lblSQLPlan, 1, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.nudGrpRotate, 2, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.lblShowNm, 1, 4)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 7
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(586, 221)
        Me.TableLayoutPanel6.TabIndex = 16
        '
        'lblSound
        '
        Me.lblSound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSound.FixedWidth = False
        Me.lblSound.LineSpacing = 0.0!
        Me.lblSound.Location = New System.Drawing.Point(23, 109)
        Me.lblSound.Name = "lblSound"
        Me.lblSound.Size = New System.Drawing.Size(114, 21)
        Me.lblSound.TabIndex = 15
        Me.lblSound.Text = "F938"
        Me.lblSound.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbGrpRatate
        '
        Me.lbGrpRatate.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbGrpRatate.LineSpacing = 0.0!
        Me.lbGrpRatate.Location = New System.Drawing.Point(37, 210)
        Me.lbGrpRatate.Name = "lbGrpRatate"
        Me.lbGrpRatate.Size = New System.Drawing.Size(100, 21)
        Me.lbGrpRatate.TabIndex = 8
        Me.lbGrpRatate.Text = "F243"
        Me.lbGrpRatate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbGrpRatate.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button2.FixedWidth = False
        Me.Button2.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button2.LineColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(354, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Radius = 10
        Me.Button2.Size = New System.Drawing.Size(44, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "▶"
        Me.Button2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.UseRound = True
        Me.Button2.UseVisualStyleBackColor = False
        '
        'rbAlias
        '
        Me.rbAlias.AutoSize = True
        Me.rbAlias.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.TableLayoutPanel6.SetColumnSpan(Me.rbAlias, 2)
        Me.rbAlias.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbAlias.LineColor = System.Drawing.Color.Gray
        Me.rbAlias.Location = New System.Drawing.Point(243, 151)
        Me.rbAlias.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbAlias.Name = "rbAlias"
        Me.rbAlias.Radius = 10
        Me.rbAlias.Size = New System.Drawing.Size(105, 16)
        Me.rbAlias.TabIndex = 12
        Me.rbAlias.TabStop = True
        Me.rbAlias.Text = "F230"
        Me.rbAlias.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbAlias.UseVisualStyleBackColor = True
        Me.rbAlias.Warning = False
        Me.rbAlias.WarningColor = System.Drawing.Color.Red
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FixedWidth = False
        Me.Button1.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Button1.LineColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(305, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Radius = 10
        Me.Button1.Size = New System.Drawing.Size(43, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.UseRound = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkUseDefaultAccount
        '
        Me.chkUseDefaultAccount.AutoSize = True
        Me.chkUseDefaultAccount.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.TableLayoutPanel6.SetColumnSpan(Me.chkUseDefaultAccount, 2)
        Me.chkUseDefaultAccount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkUseDefaultAccount.ForeColor = System.Drawing.Color.White
        Me.chkUseDefaultAccount.LineColor = System.Drawing.Color.Gray
        Me.chkUseDefaultAccount.Location = New System.Drawing.Point(143, 191)
        Me.chkUseDefaultAccount.Name = "chkUseDefaultAccount"
        Me.chkUseDefaultAccount.Radius = 10
        Me.chkUseDefaultAccount.Size = New System.Drawing.Size(156, 16)
        Me.chkUseDefaultAccount.TabIndex = 13
        Me.chkUseDefaultAccount.Text = "F330"
        Me.chkUseDefaultAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkUseDefaultAccount.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkUseDefaultAccount.UseVisualStyleBackColor = True
        '
        'cmbLang
        '
        Me.cmbLang.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel6.SetColumnSpan(Me.cmbLang, 2)
        Me.cmbLang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Location = New System.Drawing.Point(143, 27)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Necessary = False
        Me.cmbLang.Size = New System.Drawing.Size(150, 20)
        Me.cmbLang.StatusTip = ""
        Me.cmbLang.TabIndex = 0
        Me.cmbLang.ValueText = ""
        '
        'lblLang
        '
        Me.lblLang.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLang.FixedWidth = False
        Me.lblLang.LineSpacing = 0.0!
        Me.lblLang.Location = New System.Drawing.Point(23, 29)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(114, 21)
        Me.lblLang.TabIndex = 1
        Me.lblLang.Text = "F023"
        Me.lblLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCollect
        '
        Me.lblCollect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCollect.FixedWidth = False
        Me.lblCollect.LineSpacing = 0.0!
        Me.lblCollect.Location = New System.Drawing.Point(23, 69)
        Me.lblCollect.Name = "lblCollect"
        Me.lblCollect.Size = New System.Drawing.Size(114, 21)
        Me.lblCollect.TabIndex = 1
        Me.lblCollect.Text = "F190"
        Me.lblCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCollect
        '
        Me.nudCollect.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel6.SetColumnSpan(Me.nudCollect, 2)
        Me.nudCollect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudCollect.Location = New System.Drawing.Point(143, 66)
        Me.nudCollect.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudCollect.Name = "nudCollect"
        Me.nudCollect.Necessary = False
        Me.nudCollect.Size = New System.Drawing.Size(150, 21)
        Me.nudCollect.StatusTip = ""
        Me.nudCollect.TabIndex = 1
        Me.nudCollect.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'txtSound
        '
        Me.txtSound.BackColor = System.Drawing.SystemColors.Window
        Me.txtSound.code = False
        Me.TableLayoutPanel6.SetColumnSpan(Me.txtSound, 2)
        Me.txtSound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSound.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSound.impossibleinput = ""
        Me.txtSound.Location = New System.Drawing.Point(143, 106)
        Me.txtSound.Name = "txtSound"
        Me.txtSound.Necessary = False
        Me.txtSound.PossibleInput = ""
        Me.txtSound.Prefix = ""
        Me.txtSound.Size = New System.Drawing.Size(150, 21)
        Me.txtSound.StatusTip = ""
        Me.txtSound.TabIndex = 8
        Me.txtSound.Value = ""
        '
        'rbHostnm
        '
        Me.rbHostnm.AutoSize = True
        Me.rbHostnm.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbHostnm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbHostnm.LineColor = System.Drawing.Color.Gray
        Me.rbHostnm.Location = New System.Drawing.Point(143, 151)
        Me.rbHostnm.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbHostnm.Name = "rbHostnm"
        Me.rbHostnm.Radius = 10
        Me.rbHostnm.Size = New System.Drawing.Size(94, 16)
        Me.rbHostnm.TabIndex = 11
        Me.rbHostnm.TabStop = True
        Me.rbHostnm.Text = "F229"
        Me.rbHostnm.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbHostnm.UseVisualStyleBackColor = True
        Me.rbHostnm.Warning = False
        Me.rbHostnm.WarningColor = System.Drawing.Color.Red
        '
        'lblSQLPlan
        '
        Me.lblSQLPlan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSQLPlan.FixedWidth = False
        Me.lblSQLPlan.LineSpacing = 0.0!
        Me.lblSQLPlan.Location = New System.Drawing.Point(23, 189)
        Me.lblSQLPlan.Name = "lblSQLPlan"
        Me.lblSQLPlan.Size = New System.Drawing.Size(114, 21)
        Me.lblSQLPlan.TabIndex = 14
        Me.lblSQLPlan.Text = "F329"
        Me.lblSQLPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudGrpRotate
        '
        Me.nudGrpRotate.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel6.SetColumnSpan(Me.nudGrpRotate, 2)
        Me.nudGrpRotate.Location = New System.Drawing.Point(143, 213)
        Me.nudGrpRotate.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.nudGrpRotate.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudGrpRotate.Name = "nudGrpRotate"
        Me.nudGrpRotate.Necessary = False
        Me.nudGrpRotate.Size = New System.Drawing.Size(150, 21)
        Me.nudGrpRotate.StatusTip = ""
        Me.nudGrpRotate.TabIndex = 2
        Me.nudGrpRotate.Value = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudGrpRotate.Visible = False
        '
        'lblShowNm
        '
        Me.lblShowNm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblShowNm.FixedWidth = False
        Me.lblShowNm.LineSpacing = 0.0!
        Me.lblShowNm.Location = New System.Drawing.Point(23, 144)
        Me.lblShowNm.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.lblShowNm.Name = "lblShowNm"
        Me.lblShowNm.Size = New System.Drawing.Size(114, 21)
        Me.lblShowNm.TabIndex = 1
        Me.lblShowNm.Text = "F228"
        Me.lblShowNm.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel5.SetColumnSpan(Me.TableLayoutPanel3, 4)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 224)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(580, 106)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.lblRaider, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(574, 27)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'lblRaider
        '
        Me.lblRaider.AutoSize = True
        Me.lblRaider.BackColor = System.Drawing.Color.Transparent
        Me.lblRaider.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRaider.ForeColor = System.Drawing.Color.White
        Me.lblRaider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblRaider.Location = New System.Drawing.Point(33, 0)
        Me.lblRaider.Name = "lblRaider"
        Me.lblRaider.Size = New System.Drawing.Size(538, 27)
        Me.lblRaider.TabIndex = 0
        Me.lblRaider.Text = "Text"
        Me.lblRaider.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 27)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "      "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.chkMemItemReverse)
        Me.Panel1.Controls.Add(Me.chkCpuItemReverse)
        Me.Panel1.Controls.Add(Me.lblMemStyle)
        Me.Panel1.Controls.Add(Me.lblCpuStyle)
        Me.Panel1.Controls.Add(Me.cmbMemStyle)
        Me.Panel1.Controls.Add(Me.cmbCpuStyle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(574, 75)
        Me.Panel1.TabIndex = 16
        '
        'chkMemItemReverse
        '
        Me.chkMemItemReverse.AutoSize = True
        Me.chkMemItemReverse.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkMemItemReverse.ForeColor = System.Drawing.Color.White
        Me.chkMemItemReverse.LineColor = System.Drawing.Color.Gray
        Me.chkMemItemReverse.Location = New System.Drawing.Point(374, 45)
        Me.chkMemItemReverse.Name = "chkMemItemReverse"
        Me.chkMemItemReverse.Radius = 10
        Me.chkMemItemReverse.Size = New System.Drawing.Size(49, 16)
        Me.chkMemItemReverse.TabIndex = 7
        Me.chkMemItemReverse.Text = "F039"
        Me.chkMemItemReverse.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkMemItemReverse.UseVisualStyleBackColor = True
        '
        'chkCpuItemReverse
        '
        Me.chkCpuItemReverse.AutoSize = True
        Me.chkCpuItemReverse.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCpuItemReverse.ForeColor = System.Drawing.Color.White
        Me.chkCpuItemReverse.LineColor = System.Drawing.Color.Gray
        Me.chkCpuItemReverse.Location = New System.Drawing.Point(110, 44)
        Me.chkCpuItemReverse.Name = "chkCpuItemReverse"
        Me.chkCpuItemReverse.Radius = 10
        Me.chkCpuItemReverse.Size = New System.Drawing.Size(49, 16)
        Me.chkCpuItemReverse.TabIndex = 8
        Me.chkCpuItemReverse.Text = "F039"
        Me.chkCpuItemReverse.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCpuItemReverse.UseVisualStyleBackColor = True
        '
        'lblMemStyle
        '
        Me.lblMemStyle.ForeColor = System.Drawing.Color.White
        Me.lblMemStyle.LineSpacing = 0.0!
        Me.lblMemStyle.Location = New System.Drawing.Point(268, 19)
        Me.lblMemStyle.Name = "lblMemStyle"
        Me.lblMemStyle.Size = New System.Drawing.Size(100, 21)
        Me.lblMemStyle.TabIndex = 5
        Me.lblMemStyle.Text = "F036"
        Me.lblMemStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCpuStyle
        '
        Me.lblCpuStyle.ForeColor = System.Drawing.Color.White
        Me.lblCpuStyle.LineSpacing = 0.0!
        Me.lblCpuStyle.Location = New System.Drawing.Point(4, 19)
        Me.lblCpuStyle.Name = "lblCpuStyle"
        Me.lblCpuStyle.Size = New System.Drawing.Size(100, 21)
        Me.lblCpuStyle.TabIndex = 6
        Me.lblCpuStyle.Text = "F035"
        Me.lblCpuStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMemStyle
        '
        Me.cmbMemStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMemStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMemStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbMemStyle.FormattingEnabled = True
        Me.cmbMemStyle.Location = New System.Drawing.Point(374, 19)
        Me.cmbMemStyle.Name = "cmbMemStyle"
        Me.cmbMemStyle.Necessary = False
        Me.cmbMemStyle.Size = New System.Drawing.Size(150, 20)
        Me.cmbMemStyle.StatusTip = ""
        Me.cmbMemStyle.TabIndex = 3
        Me.cmbMemStyle.ValueText = ""
        '
        'cmbCpuStyle
        '
        Me.cmbCpuStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCpuStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCpuStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCpuStyle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCpuStyle.FormattingEnabled = True
        Me.cmbCpuStyle.Location = New System.Drawing.Point(110, 19)
        Me.cmbCpuStyle.Name = "cmbCpuStyle"
        Me.cmbCpuStyle.Necessary = False
        Me.cmbCpuStyle.Size = New System.Drawing.Size(150, 20)
        Me.cmbCpuStyle.StatusTip = ""
        Me.cmbCpuStyle.TabIndex = 4
        Me.cmbCpuStyle.ValueText = ""
        '
        'lblRegex
        '
        Me.lblRegex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegex.LineSpacing = 0.0!
        Me.lblRegex.Location = New System.Drawing.Point(439, 355)
        Me.lblRegex.Name = "lblRegex"
        Me.lblRegex.Size = New System.Drawing.Size(100, 21)
        Me.lblRegex.TabIndex = 8
        Me.lblRegex.Text = "F209"
        Me.lblRegex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblRegex.Visible = False
        '
        'txtRegex
        '
        Me.txtRegex.BackColor = System.Drawing.SystemColors.Window
        Me.txtRegex.code = False
        Me.txtRegex.ControlLength = eXperDB.BaseControls.TextBox.enmLength.[Long]
        Me.txtRegex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRegex.impossibleinput = ""
        Me.txtRegex.Location = New System.Drawing.Point(439, 379)
        Me.txtRegex.Name = "txtRegex"
        Me.txtRegex.Necessary = False
        Me.txtRegex.PossibleInput = ""
        Me.txtRegex.Prefix = ""
        Me.txtRegex.Size = New System.Drawing.Size(200, 21)
        Me.txtRegex.StatusTip = ""
        Me.txtRegex.TabIndex = 7
        Me.txtRegex.Value = ""
        Me.txtRegex.Visible = False
        '
        'btnQueryInit
        '
        Me.btnQueryInit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueryInit.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnQueryInit.FixedHeight = False
        Me.btnQueryInit.FixedWidth = False
        Me.btnQueryInit.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQueryInit.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQueryInit.Location = New System.Drawing.Point(289, 362)
        Me.btnQueryInit.Name = "btnQueryInit"
        Me.btnQueryInit.Radius = 10
        Me.btnQueryInit.Size = New System.Drawing.Size(273, 27)
        Me.btnQueryInit.TabIndex = 4
        Me.btnQueryInit.Text = "F226"
        Me.btnQueryInit.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQueryInit.UseRound = True
        Me.btnQueryInit.UseVisualStyleBackColor = True
        Me.btnQueryInit.Visible = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(604, 50)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(558, 50)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'FlatCombo1
        '
        Me.FlatCombo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.FlatCombo1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.FlatCombo1.ButtonColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.FlatCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FlatCombo1.FixedWidth = True
        Me.FlatCombo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FlatCombo1.ForeColor = System.Drawing.Color.White
        Me.FlatCombo1.FormattingEnabled = True
        Me.FlatCombo1.Items.AddRange(New Object() {"1", "2"})
        Me.FlatCombo1.Location = New System.Drawing.Point(404, 13)
        Me.FlatCombo1.Name = "FlatCombo1"
        Me.FlatCombo1.Necessary = False
        Me.FlatCombo1.Size = New System.Drawing.Size(121, 20)
        Me.FlatCombo1.StatusTip = ""
        Me.FlatCombo1.TabIndex = 9
        Me.FlatCombo1.ValueText = ""
        Me.FlatCombo1.Visible = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 478)
        Me.Controls.Add(Me.tbMain)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConfig"
        Me.tbMain.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.tp1.PerformLayout()
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.tp2.ResumeLayout(False)
        Me.tp2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.nudCollect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGrpRotate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbMain As FlatTabControl.FlatTabControl
    Friend WithEvents tp1 As System.Windows.Forms.TabPage
    Friend WithEvents chkNor As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkWar As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkCri As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblHealthCheck As eXperDB.BaseControls.Label
    Friend WithEvents tp2 As System.Windows.Forms.TabPage
    Friend WithEvents lblRegex As eXperDB.BaseControls.Label
    Friend WithEvents txtRegex As eXperDB.BaseControls.TextBox
    Friend WithEvents btnQueryInit As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblRaider As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents chkMemItemReverse As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkCpuItemReverse As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblMemStyle As eXperDB.BaseControls.Label
    Friend WithEvents lblCpuStyle As eXperDB.BaseControls.Label
    Friend WithEvents cmbMemStyle As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbCpuStyle As eXperDB.BaseControls.ComboBox
    Friend WithEvents TableLayoutPanel5 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lbGrpRatate As eXperDB.BaseControls.Label
    Friend WithEvents Button2 As eXperDB.BaseControls.Button
    Friend WithEvents rbAlias As eXperDB.BaseControls.RadioButton
    Friend WithEvents Button1 As eXperDB.BaseControls.Button
    Friend WithEvents chkUseDefaultAccount As eXperDB.BaseControls.CheckBox
    Friend WithEvents cmbLang As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblLang As eXperDB.BaseControls.Label
    Friend WithEvents lblCollect As eXperDB.BaseControls.Label
    Friend WithEvents nudCollect As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents txtSound As eXperDB.BaseControls.TextBox
    Friend WithEvents rbHostnm As eXperDB.BaseControls.RadioButton
    Friend WithEvents lblSQLPlan As eXperDB.BaseControls.Label
    Friend WithEvents nudGrpRotate As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents lblShowNm As eXperDB.BaseControls.Label
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPhone2 As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPhone2 As eXperDB.BaseControls.Label
    Friend WithEvents txtEmail As eXperDB.BaseControls.TextBox
    Friend WithEvents lblEmail As eXperDB.BaseControls.Label
    Friend WithEvents txtPhone As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPhone As eXperDB.BaseControls.Label
    Friend WithEvents lblUserID As eXperDB.BaseControls.Label
    Friend WithEvents lblUserName As eXperDB.BaseControls.Label
    Friend WithEvents txtUserID As eXperDB.BaseControls.TextBox
    Friend WithEvents txtUserName As eXperDB.BaseControls.TextBox
    Friend WithEvents lblDept As eXperDB.BaseControls.Label
    Friend WithEvents txtDept As eXperDB.BaseControls.TextBox
    Friend WithEvents btnPassword As eXperDB.BaseControls.Button
    Friend WithEvents FlatCombo1 As FlatCombobox.FlatCombo
    Friend WithEvents TableLayoutPanel7 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnUserSave As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents rbUseNoti1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbUseNoti2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents lblSound As eXperDB.BaseControls.Label
End Class
