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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.tbMain = New FlatTabControl.FlatTabControl()
        Me.tp1 = New System.Windows.Forms.TabPage()
        Me.nudGrpRotate = New eXperDB.BaseControls.NumericUpDown()
        Me.lbGrpRatate = New eXperDB.BaseControls.Label()
        Me.rbAlias = New eXperDB.BaseControls.RadioButton()
        Me.rbHostnm = New eXperDB.BaseControls.RadioButton()
        Me.Button2 = New eXperDB.BaseControls.Button()
        Me.Button1 = New eXperDB.BaseControls.Button()
        Me.TextBox2 = New eXperDB.BaseControls.TextBox()
        Me.chkNor = New eXperDB.BaseControls.CheckBox()
        Me.chkWar = New eXperDB.BaseControls.CheckBox()
        Me.chkCri = New eXperDB.BaseControls.CheckBox()
        Me.TextBox1 = New eXperDB.BaseControls.TextBox()
        Me.lblShowNm = New eXperDB.BaseControls.Label()
        Me.lblHealthCheck = New eXperDB.BaseControls.Label()
        Me.lblFont = New eXperDB.BaseControls.Label()
        Me.nudCollect = New eXperDB.BaseControls.NumericUpDown()
        Me.lblCollect = New eXperDB.BaseControls.Label()
        Me.lblLang = New eXperDB.BaseControls.Label()
        Me.cmbFont = New eXperDB.BaseControls.ComboBox()
        Me.cmbLang = New eXperDB.BaseControls.ComboBox()
        Me.tp2 = New System.Windows.Forms.TabPage()
        Me.lblRegex = New eXperDB.BaseControls.Label()
        Me.txtRegex = New eXperDB.BaseControls.TextBox()
        Me.btnQueryInit = New eXperDB.BaseControls.Button()
        Me.grpRaider = New eXperDB.BaseControls.GroupBox()
        Me.chkMemItemReverse = New eXperDB.BaseControls.CheckBox()
        Me.chkCpuItemReverse = New eXperDB.BaseControls.CheckBox()
        Me.lblMemStyle = New eXperDB.BaseControls.Label()
        Me.lblCpuStyle = New eXperDB.BaseControls.Label()
        Me.cmbMemStyle = New eXperDB.BaseControls.ComboBox()
        Me.cmbCpuStyle = New eXperDB.BaseControls.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tbMain.SuspendLayout()
        Me.tp1.SuspendLayout()
        CType(Me.nudGrpRotate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCollect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp2.SuspendLayout()
        Me.grpRaider.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 362)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 41)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(208, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(90, 33)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(304, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(90, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'tbMain
        '
        Me.tbMain.Controls.Add(Me.tp1)
        Me.tbMain.Controls.Add(Me.tp2)
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tbMain.ItemSize = New System.Drawing.Size(150, 21)
        Me.tbMain.Location = New System.Drawing.Point(3, 33)
        Me.tbMain.myBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbMain.Name = "tbMain"
        Me.tbMain.SelectedIndex = 0
        Me.tbMain.Size = New System.Drawing.Size(602, 329)
        Me.tbMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tbMain.TabIndex = 10
        '
        'tp1
        '
        Me.tp1.BackColor = System.Drawing.Color.Gray
        Me.tp1.Controls.Add(Me.nudGrpRotate)
        Me.tp1.Controls.Add(Me.lbGrpRatate)
        Me.tp1.Controls.Add(Me.rbAlias)
        Me.tp1.Controls.Add(Me.rbHostnm)
        Me.tp1.Controls.Add(Me.Button2)
        Me.tp1.Controls.Add(Me.Button1)
        Me.tp1.Controls.Add(Me.TextBox2)
        Me.tp1.Controls.Add(Me.chkNor)
        Me.tp1.Controls.Add(Me.chkWar)
        Me.tp1.Controls.Add(Me.chkCri)
        Me.tp1.Controls.Add(Me.TextBox1)
        Me.tp1.Controls.Add(Me.lblShowNm)
        Me.tp1.Controls.Add(Me.lblHealthCheck)
        Me.tp1.Controls.Add(Me.lblFont)
        Me.tp1.Controls.Add(Me.nudCollect)
        Me.tp1.Controls.Add(Me.lblCollect)
        Me.tp1.Controls.Add(Me.lblLang)
        Me.tp1.Controls.Add(Me.cmbFont)
        Me.tp1.Controls.Add(Me.cmbLang)
        Me.tp1.ForeColor = System.Drawing.Color.White
        Me.tp1.Location = New System.Drawing.Point(4, 25)
        Me.tp1.Name = "tp1"
        Me.tp1.Padding = New System.Windows.Forms.Padding(5)
        Me.tp1.Size = New System.Drawing.Size(594, 300)
        Me.tp1.TabIndex = 0
        Me.tp1.Text = "F024"
        '
        'nudGrpRotate
        '
        Me.nudGrpRotate.BackColor = System.Drawing.SystemColors.Window
        Me.nudGrpRotate.Location = New System.Drawing.Point(114, 250)
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
        'lbGrpRatate
        '
        Me.lbGrpRatate.Location = New System.Drawing.Point(8, 250)
        Me.lbGrpRatate.Name = "lbGrpRatate"
        Me.lbGrpRatate.Size = New System.Drawing.Size(100, 21)
        Me.lbGrpRatate.TabIndex = 8
        Me.lbGrpRatate.Text = "F243"
        Me.lbGrpRatate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbGrpRatate.Visible = False
        '
        'rbAlias
        '
        Me.rbAlias.AutoSize = True
        Me.rbAlias.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbAlias.LineColor = System.Drawing.Color.Gray
        Me.rbAlias.Location = New System.Drawing.Point(215, 220)
        Me.rbAlias.Name = "rbAlias"
        Me.rbAlias.Radius = 10
        Me.rbAlias.Size = New System.Drawing.Size(48, 16)
        Me.rbAlias.TabIndex = 12
        Me.rbAlias.TabStop = True
        Me.rbAlias.Text = "F230"
        Me.rbAlias.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbAlias.UseVisualStyleBackColor = True
        Me.rbAlias.Warning = False
        Me.rbAlias.WarningColor = System.Drawing.Color.Red
        '
        'rbHostnm
        '
        Me.rbHostnm.AutoSize = True
        Me.rbHostnm.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.rbHostnm.LineColor = System.Drawing.Color.Gray
        Me.rbHostnm.Location = New System.Drawing.Point(114, 220)
        Me.rbHostnm.Name = "rbHostnm"
        Me.rbHostnm.Radius = 10
        Me.rbHostnm.Size = New System.Drawing.Size(48, 16)
        Me.rbHostnm.TabIndex = 11
        Me.rbHostnm.TabStop = True
        Me.rbHostnm.Text = "F229"
        Me.rbHostnm.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbHostnm.UseVisualStyleBackColor = True
        Me.rbHostnm.Warning = False
        Me.rbHostnm.WarningColor = System.Drawing.Color.Red
        '
        'Button2
        '
        Me.Button2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button2.FixedWidth = False
        Me.Button2.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button2.LineColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(310, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Radius = 10
        Me.Button2.Size = New System.Drawing.Size(35, 27)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "▶"
        Me.Button2.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.UseRound = True
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Button1.FixedWidth = False
        Me.Button1.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button1.LineColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(269, 178)
        Me.Button1.Name = "Button1"
        Me.Button1.Radius = 10
        Me.Button1.Size = New System.Drawing.Size(35, 27)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "..."
        Me.Button1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.UseRound = True
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.code = False
        Me.TextBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox2.impossibleinput = ""
        Me.TextBox2.Location = New System.Drawing.Point(113, 179)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Necessary = False
        Me.TextBox2.PossibleInput = ""
        Me.TextBox2.Prefix = ""
        Me.TextBox2.Size = New System.Drawing.Size(150, 21)
        Me.TextBox2.StatusTip = ""
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.Value = ""
        '
        'chkNor
        '
        Me.chkNor.AutoSize = True
        Me.chkNor.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkNor.LineColor = System.Drawing.Color.Gray
        Me.chkNor.Location = New System.Drawing.Point(114, 144)
        Me.chkNor.Name = "chkNor"
        Me.chkNor.Radius = 10
        Me.chkNor.Size = New System.Drawing.Size(49, 16)
        Me.chkNor.TabIndex = 5
        Me.chkNor.Text = "F029"
        Me.chkNor.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkNor.UseVisualStyleBackColor = True
        '
        'chkWar
        '
        Me.chkWar.AutoSize = True
        Me.chkWar.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkWar.LineColor = System.Drawing.Color.Gray
        Me.chkWar.Location = New System.Drawing.Point(215, 144)
        Me.chkWar.Name = "chkWar"
        Me.chkWar.Radius = 10
        Me.chkWar.Size = New System.Drawing.Size(49, 16)
        Me.chkWar.TabIndex = 6
        Me.chkWar.Text = "F030"
        Me.chkWar.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkWar.UseVisualStyleBackColor = True
        '
        'chkCri
        '
        Me.chkCri.AutoSize = True
        Me.chkCri.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkCri.LineColor = System.Drawing.Color.Gray
        Me.chkCri.Location = New System.Drawing.Point(318, 144)
        Me.chkCri.Name = "chkCri"
        Me.chkCri.Radius = 10
        Me.chkCri.Size = New System.Drawing.Size(49, 16)
        Me.chkCri.TabIndex = 7
        Me.chkCri.Text = "F031"
        Me.chkCri.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCri.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.code = False
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.impossibleinput = ""
        Me.TextBox1.Location = New System.Drawing.Point(269, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Necessary = False
        Me.TextBox1.PossibleInput = ""
        Me.TextBox1.Prefix = ""
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(150, 21)
        Me.TextBox1.StatusTip = ""
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "가나다AaBbCc123"
        Me.TextBox1.Value = ""
        '
        'lblShowNm
        '
        Me.lblShowNm.Location = New System.Drawing.Point(8, 217)
        Me.lblShowNm.Name = "lblShowNm"
        Me.lblShowNm.Size = New System.Drawing.Size(100, 21)
        Me.lblShowNm.TabIndex = 1
        Me.lblShowNm.Text = "F228"
        Me.lblShowNm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHealthCheck
        '
        Me.lblHealthCheck.Location = New System.Drawing.Point(7, 140)
        Me.lblHealthCheck.Name = "lblHealthCheck"
        Me.lblHealthCheck.Size = New System.Drawing.Size(100, 21)
        Me.lblHealthCheck.TabIndex = 1
        Me.lblHealthCheck.Text = "F189"
        Me.lblHealthCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFont
        '
        Me.lblFont.Location = New System.Drawing.Point(7, 100)
        Me.lblFont.Name = "lblFont"
        Me.lblFont.Size = New System.Drawing.Size(100, 21)
        Me.lblFont.TabIndex = 1
        Me.lblFont.Text = "F191"
        Me.lblFont.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudCollect
        '
        Me.nudCollect.BackColor = System.Drawing.SystemColors.Window
        Me.nudCollect.Location = New System.Drawing.Point(114, 58)
        Me.nudCollect.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nudCollect.Name = "nudCollect"
        Me.nudCollect.Necessary = False
        Me.nudCollect.Size = New System.Drawing.Size(150, 21)
        Me.nudCollect.StatusTip = ""
        Me.nudCollect.TabIndex = 1
        Me.nudCollect.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lblCollect
        '
        Me.lblCollect.Location = New System.Drawing.Point(7, 58)
        Me.lblCollect.Name = "lblCollect"
        Me.lblCollect.Size = New System.Drawing.Size(100, 21)
        Me.lblCollect.TabIndex = 1
        Me.lblCollect.Text = "F190"
        Me.lblCollect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLang
        '
        Me.lblLang.Location = New System.Drawing.Point(7, 18)
        Me.lblLang.Name = "lblLang"
        Me.lblLang.Size = New System.Drawing.Size(100, 21)
        Me.lblLang.TabIndex = 1
        Me.lblLang.Text = "F023"
        Me.lblLang.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFont
        '
        Me.cmbFont.BackColor = System.Drawing.SystemColors.Window
        Me.cmbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFont.FormattingEnabled = True
        Me.cmbFont.Location = New System.Drawing.Point(113, 100)
        Me.cmbFont.Name = "cmbFont"
        Me.cmbFont.Necessary = False
        Me.cmbFont.Size = New System.Drawing.Size(150, 20)
        Me.cmbFont.StatusTip = ""
        Me.cmbFont.TabIndex = 3
        Me.cmbFont.ValueText = ""
        '
        'cmbLang
        '
        Me.cmbLang.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Location = New System.Drawing.Point(114, 18)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Necessary = False
        Me.cmbLang.Size = New System.Drawing.Size(150, 20)
        Me.cmbLang.StatusTip = ""
        Me.cmbLang.TabIndex = 0
        Me.cmbLang.ValueText = ""
        '
        'tp2
        '
        Me.tp2.BackColor = System.Drawing.Color.Gray
        Me.tp2.Controls.Add(Me.lblRegex)
        Me.tp2.Controls.Add(Me.txtRegex)
        Me.tp2.Controls.Add(Me.btnQueryInit)
        Me.tp2.Controls.Add(Me.grpRaider)
        Me.tp2.ForeColor = System.Drawing.Color.White
        Me.tp2.Location = New System.Drawing.Point(4, 25)
        Me.tp2.Name = "tp2"
        Me.tp2.Padding = New System.Windows.Forms.Padding(5)
        Me.tp2.Size = New System.Drawing.Size(594, 300)
        Me.tp2.TabIndex = 1
        Me.tp2.Text = "F038"
        '
        'lblRegex
        '
        Me.lblRegex.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRegex.Location = New System.Drawing.Point(287, 181)
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
        Me.txtRegex.Location = New System.Drawing.Point(287, 205)
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
        Me.btnQueryInit.Location = New System.Drawing.Point(287, 226)
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
        'grpRaider
        '
        Me.grpRaider.AlignLine = System.Drawing.StringAlignment.Center
        Me.grpRaider.AlignString = System.Drawing.StringAlignment.Near
        Me.grpRaider.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRaider.Controls.Add(Me.chkMemItemReverse)
        Me.grpRaider.Controls.Add(Me.chkCpuItemReverse)
        Me.grpRaider.Controls.Add(Me.lblMemStyle)
        Me.grpRaider.Controls.Add(Me.lblCpuStyle)
        Me.grpRaider.Controls.Add(Me.cmbMemStyle)
        Me.grpRaider.Controls.Add(Me.cmbCpuStyle)
        Me.grpRaider.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpRaider.EdgeRound = Edges1
        Me.grpRaider.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grpRaider.ForeColor = System.Drawing.Color.DarkGray
        Me.grpRaider.Icon = Nothing
        Me.grpRaider.LineColor = System.Drawing.Color.DarkGray
        Me.grpRaider.LineWidth = 1
        Me.grpRaider.Location = New System.Drawing.Point(5, 5)
        Me.grpRaider.Name = "grpRaider"
        Me.grpRaider.Size = New System.Drawing.Size(584, 96)
        Me.grpRaider.TabIndex = 3
        Me.grpRaider.TabStop = False
        Me.grpRaider.Text = "F037"
        Me.grpRaider.TitleFont = New System.Drawing.Font("굴림", 9.0!)
        Me.grpRaider.TitleGraColor = System.Drawing.Color.DarkGray
        Me.grpRaider.UseGraColor = True
        Me.grpRaider.UseTitle = False
        '
        'chkMemItemReverse
        '
        Me.chkMemItemReverse.AutoSize = True
        Me.chkMemItemReverse.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkMemItemReverse.ForeColor = System.Drawing.Color.White
        Me.chkMemItemReverse.LineColor = System.Drawing.Color.Gray
        Me.chkMemItemReverse.Location = New System.Drawing.Point(405, 63)
        Me.chkMemItemReverse.Name = "chkMemItemReverse"
        Me.chkMemItemReverse.Radius = 10
        Me.chkMemItemReverse.Size = New System.Drawing.Size(49, 16)
        Me.chkMemItemReverse.TabIndex = 2
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
        Me.chkCpuItemReverse.Location = New System.Drawing.Point(112, 62)
        Me.chkCpuItemReverse.Name = "chkCpuItemReverse"
        Me.chkCpuItemReverse.Radius = 10
        Me.chkCpuItemReverse.Size = New System.Drawing.Size(49, 16)
        Me.chkCpuItemReverse.TabIndex = 2
        Me.chkCpuItemReverse.Text = "F039"
        Me.chkCpuItemReverse.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkCpuItemReverse.UseVisualStyleBackColor = True
        '
        'lblMemStyle
        '
        Me.lblMemStyle.ForeColor = System.Drawing.Color.White
        Me.lblMemStyle.Location = New System.Drawing.Point(299, 37)
        Me.lblMemStyle.Name = "lblMemStyle"
        Me.lblMemStyle.Size = New System.Drawing.Size(100, 21)
        Me.lblMemStyle.TabIndex = 1
        Me.lblMemStyle.Text = "F036"
        Me.lblMemStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCpuStyle
        '
        Me.lblCpuStyle.ForeColor = System.Drawing.Color.White
        Me.lblCpuStyle.Location = New System.Drawing.Point(6, 37)
        Me.lblCpuStyle.Name = "lblCpuStyle"
        Me.lblCpuStyle.Size = New System.Drawing.Size(100, 21)
        Me.lblCpuStyle.TabIndex = 1
        Me.lblCpuStyle.Text = "F035"
        Me.lblCpuStyle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMemStyle
        '
        Me.cmbMemStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbMemStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMemStyle.FormattingEnabled = True
        Me.cmbMemStyle.Location = New System.Drawing.Point(405, 37)
        Me.cmbMemStyle.Name = "cmbMemStyle"
        Me.cmbMemStyle.Necessary = False
        Me.cmbMemStyle.Size = New System.Drawing.Size(150, 20)
        Me.cmbMemStyle.StatusTip = ""
        Me.cmbMemStyle.TabIndex = 0
        Me.cmbMemStyle.ValueText = ""
        '
        'cmbCpuStyle
        '
        Me.cmbCpuStyle.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCpuStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCpuStyle.FormattingEnabled = True
        Me.cmbCpuStyle.Location = New System.Drawing.Point(112, 37)
        Me.cmbCpuStyle.Name = "cmbCpuStyle"
        Me.cmbCpuStyle.Necessary = False
        Me.cmbCpuStyle.Size = New System.Drawing.Size(150, 20)
        Me.cmbCpuStyle.StatusTip = ""
        Me.cmbCpuStyle.TabIndex = 0
        Me.cmbCpuStyle.ValueText = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(602, 30)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.ForeColor = System.Drawing.Color.White
        Me.StatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StatusLabel.Location = New System.Drawing.Point(43, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(556, 30)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(608, 406)
        Me.Controls.Add(Me.tbMain)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConfig"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConfig"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tbMain.ResumeLayout(False)
        Me.tp1.ResumeLayout(False)
        Me.tp1.PerformLayout()
        CType(Me.nudGrpRotate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCollect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp2.ResumeLayout(False)
        Me.tp2.PerformLayout()
        Me.grpRaider.ResumeLayout(False)
        Me.grpRaider.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents tbMain As FlatTabControl.FlatTabControl
    Friend WithEvents tp1 As System.Windows.Forms.TabPage
    Friend WithEvents nudGrpRotate As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents lbGrpRatate As eXperDB.BaseControls.Label
    Friend WithEvents rbAlias As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbHostnm As eXperDB.BaseControls.RadioButton
    Friend WithEvents Button2 As eXperDB.BaseControls.Button
    Friend WithEvents Button1 As eXperDB.BaseControls.Button
    Friend WithEvents TextBox2 As eXperDB.BaseControls.TextBox
    Friend WithEvents chkNor As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkWar As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkCri As eXperDB.BaseControls.CheckBox
    Friend WithEvents TextBox1 As eXperDB.BaseControls.TextBox
    Friend WithEvents lblShowNm As eXperDB.BaseControls.Label
    Friend WithEvents lblHealthCheck As eXperDB.BaseControls.Label
    Friend WithEvents lblFont As eXperDB.BaseControls.Label
    Friend WithEvents nudCollect As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents lblCollect As eXperDB.BaseControls.Label
    Friend WithEvents lblLang As eXperDB.BaseControls.Label
    Friend WithEvents cmbFont As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbLang As eXperDB.BaseControls.ComboBox
    Friend WithEvents tp2 As System.Windows.Forms.TabPage
    Friend WithEvents lblRegex As eXperDB.BaseControls.Label
    Friend WithEvents txtRegex As eXperDB.BaseControls.TextBox
    Friend WithEvents btnQueryInit As eXperDB.BaseControls.Button
    Friend WithEvents grpRaider As eXperDB.BaseControls.GroupBox
    Friend WithEvents chkMemItemReverse As eXperDB.BaseControls.CheckBox
    Friend WithEvents chkCpuItemReverse As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblMemStyle As eXperDB.BaseControls.Label
    Friend WithEvents lblCpuStyle As eXperDB.BaseControls.Label
    Friend WithEvents cmbMemStyle As eXperDB.BaseControls.ComboBox
    Friend WithEvents cmbCpuStyle As eXperDB.BaseControls.ComboBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
