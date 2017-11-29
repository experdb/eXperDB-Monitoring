<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCCerti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCCerti))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.EncryptTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.UseMode = New System.Windows.Forms.CheckedListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ReCustPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UnlimitedCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CertiString = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MacAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DecryptTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ResultRTB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DeCustPassword = New System.Windows.Forms.TextBox()
        Me.DeCertiInfo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MetaResultRTB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.OdbcDriverCB = New System.Windows.Forms.ComboBox()
        Me.DbNameTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ServerIpTB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UserIdTB = New System.Windows.Forms.TextBox()
        Me.PortTB = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.MetaCofRTB = New System.Windows.Forms.RichTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colDgvAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDgvDatas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmbDB = New System.Windows.Forms.ComboBox()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtPw = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ExecButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CertiPw = New System.Windows.Forms.ToolStripTextBox()
        Me.GetCerty = New System.Windows.Forms.ToolStripButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.EncryptTabPage.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.DecryptTabPage.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(555, 394)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(555, 419)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.EncryptTabPage)
        Me.TabControl.Controls.Add(Me.DecryptTabPage)
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPage3)
        Me.TabControl.Controls.Add(Me.TabPage4)
        Me.TabControl.Location = New System.Drawing.Point(3, 3)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(552, 387)
        Me.TabControl.TabIndex = 0
        '
        'EncryptTabPage
        '
        Me.EncryptTabPage.Controls.Add(Me.GroupBox2)
        Me.EncryptTabPage.Controls.Add(Me.GroupBox1)
        Me.EncryptTabPage.Location = New System.Drawing.Point(4, 22)
        Me.EncryptTabPage.Name = "EncryptTabPage"
        Me.EncryptTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.EncryptTabPage.Size = New System.Drawing.Size(544, 361)
        Me.EncryptTabPage.TabIndex = 0
        Me.EncryptTabPage.Text = "인증 생성"
        Me.EncryptTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.UseMode)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.ReCustPassword)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CustPassword)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(530, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "고객정보"
        '
        'UseMode
        '
        Me.UseMode.CheckOnClick = True
        Me.UseMode.FormattingEnabled = True
        Me.UseMode.Location = New System.Drawing.Point(93, 80)
        Me.UseMode.Name = "UseMode"
        Me.UseMode.Size = New System.Drawing.Size(310, 84)
        Me.UseMode.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 12)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "고객암호확인"
        '
        'ReCustPassword
        '
        Me.ReCustPassword.Location = New System.Drawing.Point(93, 47)
        Me.ReCustPassword.MaxLength = 18
        Me.ReCustPassword.Name = "ReCustPassword"
        Me.ReCustPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ReCustPassword.Size = New System.Drawing.Size(133, 21)
        Me.ReCustPassword.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "(숫자18자리)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "패키지"
        '
        'CustPassword
        '
        Me.CustPassword.Location = New System.Drawing.Point(93, 20)
        Me.CustPassword.MaxLength = 18
        Me.CustPassword.Name = "CustPassword"
        Me.CustPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CustPassword.Size = New System.Drawing.Size(133, 21)
        Me.CustPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "고객암호"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.UnlimitedCheckBox)
        Me.GroupBox1.Controls.Add(Me.ExpireDate)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CertiString)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.MacAddress)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(530, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "기본정보"
        '
        'UnlimitedCheckBox
        '
        Me.UnlimitedCheckBox.AutoSize = True
        Me.UnlimitedCheckBox.Location = New System.Drawing.Point(263, 54)
        Me.UnlimitedCheckBox.Name = "UnlimitedCheckBox"
        Me.UnlimitedCheckBox.Size = New System.Drawing.Size(76, 16)
        Me.UnlimitedCheckBox.TabIndex = 11
        Me.UnlimitedCheckBox.Text = "Unlimited"
        Me.UnlimitedCheckBox.UseVisualStyleBackColor = True
        '
        'ExpireDate
        '
        Me.ExpireDate.Location = New System.Drawing.Point(93, 50)
        Me.ExpireDate.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.ExpireDate.Name = "ExpireDate"
        Me.ExpireDate.Size = New System.Drawing.Size(164, 21)
        Me.ExpireDate.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(263, 26)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 12)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "('-'  미포함)"
        '
        'CertiString
        '
        Me.CertiString.Location = New System.Drawing.Point(93, 80)
        Me.CertiString.Multiline = True
        Me.CertiString.Name = "CertiString"
        Me.CertiString.ReadOnly = True
        Me.CertiString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CertiString.Size = New System.Drawing.Size(310, 79)
        Me.CertiString.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "인증정보"
        '
        'MacAddress
        '
        Me.MacAddress.Location = New System.Drawing.Point(93, 20)
        Me.MacAddress.Name = "MacAddress"
        Me.MacAddress.Size = New System.Drawing.Size(164, 21)
        Me.MacAddress.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "만 료 일"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mac주소"
        '
        'DecryptTabPage
        '
        Me.DecryptTabPage.Controls.Add(Me.GroupBox4)
        Me.DecryptTabPage.Controls.Add(Me.GroupBox3)
        Me.DecryptTabPage.Location = New System.Drawing.Point(4, 22)
        Me.DecryptTabPage.Name = "DecryptTabPage"
        Me.DecryptTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.DecryptTabPage.Size = New System.Drawing.Size(544, 361)
        Me.DecryptTabPage.TabIndex = 1
        Me.DecryptTabPage.Text = "인증 확인"
        Me.DecryptTabPage.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ResultRTB)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(407, 185)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "결과"
        '
        'ResultRTB
        '
        Me.ResultRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultRTB.Location = New System.Drawing.Point(3, 17)
        Me.ResultRTB.Name = "ResultRTB"
        Me.ResultRTB.ReadOnly = True
        Me.ResultRTB.Size = New System.Drawing.Size(401, 165)
        Me.ResultRTB.TabIndex = 12
        Me.ResultRTB.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DeCustPassword)
        Me.GroupBox3.Controls.Add(Me.DeCertiInfo)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 158)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "기본정보"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(206, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 12)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "(18자리)"
        '
        'DeCustPassword
        '
        Me.DeCustPassword.Location = New System.Drawing.Point(67, 20)
        Me.DeCustPassword.MaxLength = 18
        Me.DeCustPassword.Name = "DeCustPassword"
        Me.DeCustPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.DeCustPassword.Size = New System.Drawing.Size(133, 21)
        Me.DeCustPassword.TabIndex = 8
        '
        'DeCertiInfo
        '
        Me.DeCertiInfo.Location = New System.Drawing.Point(67, 47)
        Me.DeCertiInfo.Multiline = True
        Me.DeCertiInfo.Name = "DeCertiInfo"
        Me.DeCertiInfo.Size = New System.Drawing.Size(323, 97)
        Me.DeCertiInfo.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "인증정보"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "고객암호"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(544, 361)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "메타정보생성"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MetaResultRTB)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 203)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(407, 152)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "결과"
        '
        'MetaResultRTB
        '
        Me.MetaResultRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetaResultRTB.Location = New System.Drawing.Point(3, 17)
        Me.MetaResultRTB.Name = "MetaResultRTB"
        Me.MetaResultRTB.ReadOnly = True
        Me.MetaResultRTB.Size = New System.Drawing.Size(401, 132)
        Me.MetaResultRTB.TabIndex = 13
        Me.MetaResultRTB.Text = ""
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.OdbcDriverCB)
        Me.GroupBox5.Controls.Add(Me.DbNameTB)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.ServerIpTB)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.UserIdTB)
        Me.GroupBox5.Controls.Add(Me.PortTB)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.PasswordLabel)
        Me.GroupBox5.Controls.Add(Me.UsernameLabel)
        Me.GroupBox5.Controls.Add(Me.PasswordTB)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(407, 191)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "메타시스템 접속 정보"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(311, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 23)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "(20자리이하)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(311, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 23)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "(20자리이하)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OdbcDriverCB
        '
        Me.OdbcDriverCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OdbcDriverCB.FormattingEnabled = True
        Me.OdbcDriverCB.Location = New System.Drawing.Point(121, 74)
        Me.OdbcDriverCB.Name = "OdbcDriverCB"
        Me.OdbcDriverCB.Size = New System.Drawing.Size(183, 20)
        Me.OdbcDriverCB.TabIndex = 42
        '
        'DbNameTB
        '
        Me.DbNameTB.Location = New System.Drawing.Point(121, 127)
        Me.DbNameTB.MaxLength = 20
        Me.DbNameTB.Name = "DbNameTB"
        Me.DbNameTB.Size = New System.Drawing.Size(148, 21)
        Me.DbNameTB.TabIndex = 44
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 12)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Database Name"
        '
        'ServerIpTB
        '
        Me.ServerIpTB.Location = New System.Drawing.Point(121, 100)
        Me.ServerIpTB.MaxLength = 15
        Me.ServerIpTB.Name = "ServerIpTB"
        Me.ServerIpTB.Size = New System.Drawing.Size(148, 21)
        Me.ServerIpTB.TabIndex = 43
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(19, 103)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 12)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Server IP"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 12)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "ODBC Driver"
        '
        'UserIdTB
        '
        Me.UserIdTB.Location = New System.Drawing.Point(121, 20)
        Me.UserIdTB.MaxLength = 20
        Me.UserIdTB.Name = "UserIdTB"
        Me.UserIdTB.Size = New System.Drawing.Size(183, 21)
        Me.UserIdTB.TabIndex = 40
        '
        'PortTB
        '
        Me.PortTB.Location = New System.Drawing.Point(121, 154)
        Me.PortTB.MaxLength = 6
        Me.PortTB.Name = "PortTB"
        Me.PortTB.Size = New System.Drawing.Size(73, 21)
        Me.PortTB.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(27, 12)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Port"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(19, 47)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(65, 23)
        Me.PasswordLabel.TabIndex = 47
        Me.PasswordLabel.Text = "Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(19, 20)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(96, 23)
        Me.UsernameLabel.TabIndex = 46
        Me.UsernameLabel.Text = "User/Schema"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(121, 47)
        Me.PasswordTB.MaxLength = 20
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTB.Size = New System.Drawing.Size(183, 21)
        Me.PasswordTB.TabIndex = 41
        Me.PasswordTB.UseSystemPasswordChar = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(544, 361)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "메타정보확인"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.MetaCofRTB)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 203)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(407, 152)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "결과"
        '
        'MetaCofRTB
        '
        Me.MetaCofRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetaCofRTB.Location = New System.Drawing.Point(3, 17)
        Me.MetaCofRTB.Name = "MetaCofRTB"
        Me.MetaCofRTB.ReadOnly = True
        Me.MetaCofRTB.Size = New System.Drawing.Size(401, 132)
        Me.MetaCofRTB.TabIndex = 13
        Me.MetaCofRTB.Text = ""
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(17, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 12)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "메타정보 파일 경로"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(354, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 33)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(329, 21)
        Me.TextBox1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(544, 361)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "다중메타정보"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDgvAlias, Me.colDgvDatas})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.Size = New System.Drawing.Size(407, 120)
        Me.DataGridView1.TabIndex = 17
        '
        'colDgvAlias
        '
        Me.colDgvAlias.HeaderText = "별칭"
        Me.colDgvAlias.Name = "colDgvAlias"
        '
        'colDgvDatas
        '
        Me.colDgvDatas.HeaderText = "Datas"
        Me.colDgvDatas.Name = "colDgvDatas"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button2)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.cmbDB)
        Me.GroupBox8.Controls.Add(Me.txtDB)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.txtIP)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.txtAlias)
        Me.GroupBox8.Controls.Add(Me.txtUser)
        Me.GroupBox8.Controls.Add(Me.txtPort)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.Label30)
        Me.GroupBox8.Controls.Add(Me.Label29)
        Me.GroupBox8.Controls.Add(Me.txtPw)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(407, 223)
        Me.GroupBox8.TabIndex = 16
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "메타시스템 접속 정보"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(328, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 25)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(311, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 23)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "(20자리이하)"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(311, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 23)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "(20자리이하)"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbDB
        '
        Me.cmbDB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDB.FormattingEnabled = True
        Me.cmbDB.Location = New System.Drawing.Point(121, 96)
        Me.cmbDB.Name = "cmbDB"
        Me.cmbDB.Size = New System.Drawing.Size(183, 20)
        Me.cmbDB.TabIndex = 42
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(121, 149)
        Me.txtDB.MaxLength = 20
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(148, 21)
        Me.txtDB.TabIndex = 44
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(19, 152)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(96, 12)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "Database Name"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(121, 122)
        Me.txtIP.MaxLength = 15
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(148, 21)
        Me.txtIP.TabIndex = 43
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(19, 125)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 12)
        Me.Label25.TabIndex = 50
        Me.Label25.Text = "Server IP"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(19, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 12)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "ODBC Driver"
        '
        'txtAlias
        '
        Me.txtAlias.Location = New System.Drawing.Point(121, 15)
        Me.txtAlias.MaxLength = 20
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(183, 21)
        Me.txtAlias.TabIndex = 40
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(121, 42)
        Me.txtUser.MaxLength = 20
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(183, 21)
        Me.txtUser.TabIndex = 40
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(121, 176)
        Me.txtPort.MaxLength = 6
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(73, 21)
        Me.txtPort.TabIndex = 45
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(19, 179)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(27, 12)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Port"
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(19, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 23)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Password"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(19, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 23)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "Alias"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(19, 42)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(96, 23)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "User/Schema"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPw
        '
        Me.txtPw.Location = New System.Drawing.Point(121, 69)
        Me.txtPw.MaxLength = 20
        Me.txtPw.Name = "txtPw"
        Me.txtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPw.Size = New System.Drawing.Size(183, 21)
        Me.txtPw.TabIndex = 41
        Me.txtPw.UseSystemPasswordChar = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox9)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.Button3)
        Me.TabPage4.Controls.Add(Me.TextBox2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(544, 361)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "다중메타정보확인"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.RichTextBox1)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 54)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(470, 295)
        Me.GroupBox9.TabIndex = 21
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "결과"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 17)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(464, 275)
        Me.RichTextBox1.TabIndex = 13
        Me.RichTextBox1.Text = ""
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(76, 12)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(109, 12)
        Me.Label31.TabIndex = 20
        Me.Label31.Text = "메타정보 파일 경로"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(413, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 22)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(329, 21)
        Me.TextBox2.TabIndex = 18
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecButton, Me.ToolStripSeparator1, Me.CloseButton, Me.ToolStripSeparator2, Me.CertiPw, Me.GetCerty})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(291, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'ExecButton
        '
        Me.ExecButton.Image = CType(resources.GetObject("ExecButton.Image"), System.Drawing.Image)
        Me.ExecButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExecButton.Name = "ExecButton"
        Me.ExecButton.Size = New System.Drawing.Size(51, 22)
        Me.ExecButton.Text = "수행"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'CloseButton
        '
        Me.CloseButton.Image = CType(resources.GetObject("CloseButton.Image"), System.Drawing.Image)
        Me.CloseButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(51, 22)
        Me.CloseButton.Text = "닫기"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CertiPw
        '
        Me.CertiPw.MaxLength = 30
        Me.CertiPw.Name = "CertiPw"
        Me.CertiPw.Size = New System.Drawing.Size(100, 25)
        '
        'GetCerty
        '
        Me.GetCerty.Image = CType(resources.GetObject("GetCerty.Image"), System.Drawing.Image)
        Me.GetCerty.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetCerty.Name = "GetCerty"
        Me.GetCerty.Size = New System.Drawing.Size(63, 22)
        Me.GetCerty.Text = "활성화"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(357, 80)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 21)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "...."
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(93, 80)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(263, 21)
        Me.TextBox5.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "파일경로"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(203, 50)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 21)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "달력"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(93, 50)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(110, 21)
        Me.TextBox6.TabIndex = 4
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(93, 20)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(310, 21)
        Me.TextBox7.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 12)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "만 료 일"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Mac주소"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmCCerti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 419)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCCerti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iDAST 인증"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.EncryptTabPage.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.DecryptTabPage.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents EncryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents DecryptTabPage As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustPassword As System.Windows.Forms.TextBox
    Friend WithEvents MacAddress As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CertiString As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DeCustPassword As System.Windows.Forms.TextBox
    Friend WithEvents DeCertiInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ExecButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents CloseButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ResultRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ReCustPassword As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CertiPw As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GetCerty As System.Windows.Forms.ToolStripButton
    Friend WithEvents UnlimitedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents UseMode As System.Windows.Forms.CheckedListBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents OdbcDriverCB As System.Windows.Forms.ComboBox
    Friend WithEvents DbNameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ServerIpTB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UserIdTB As System.Windows.Forms.TextBox
    Friend WithEvents PortTB As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents MetaResultRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents MetaCofRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents colDgvAlias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDgvDatas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbDB As System.Windows.Forms.ComboBox
    Friend WithEvents txtDB As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtPw As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox

End Class
