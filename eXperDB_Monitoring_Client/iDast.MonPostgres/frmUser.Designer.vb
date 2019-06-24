<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUser))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPassword = New eXperDB.BaseControls.Button()
        Me.rbUseNoti2 = New eXperDB.BaseControls.RadioButton()
        Me.rbUseNoti1 = New eXperDB.BaseControls.RadioButton()
        Me.lblAdmin = New eXperDB.BaseControls.Label()
        Me.chkAdmin = New eXperDB.BaseControls.CheckBox()
        Me.txtPasswordConfirm = New eXperDB.BaseControls.TextBox()
        Me.txtPassword = New eXperDB.BaseControls.TextBox()
        Me.lblPasswordConfirm = New eXperDB.BaseControls.Label()
        Me.lblPassword = New eXperDB.BaseControls.Label()
        Me.txtDept = New eXperDB.BaseControls.TextBox()
        Me.lblDept = New eXperDB.BaseControls.Label()
        Me.lblPhone2 = New eXperDB.BaseControls.Label()
        Me.txtPhone2 = New eXperDB.BaseControls.TextBox()
        Me.txtEmail = New eXperDB.BaseControls.TextBox()
        Me.lblEmail = New eXperDB.BaseControls.Label()
        Me.txtPhone = New eXperDB.BaseControls.TextBox()
        Me.lblPhone = New eXperDB.BaseControls.Label()
        Me.lblUserID = New eXperDB.BaseControls.Label()
        Me.lblUserName = New eXperDB.BaseControls.Label()
        Me.txtUserID = New eXperDB.BaseControls.TextBox()
        Me.txtUserName = New eXperDB.BaseControls.TextBox()
        Me.lblLock = New eXperDB.BaseControls.Label()
        Me.chkLock = New eXperDB.BaseControls.CheckBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(442, 50)
        Me.TableLayoutPanel2.TabIndex = 16
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
        Me.StatusLabel.Size = New System.Drawing.Size(396, 50)
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
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 448)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(442, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.CheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(223, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnAct
        '
        Me.btnAct.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.Transparent
        Me.btnAct.Location = New System.Drawing.Point(143, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 0
        Me.btnAct.Text = "F140/F141"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 6
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.tlpSvrChk.Controls.Add(Me.chkLock, 2, 10)
        Me.tlpSvrChk.Controls.Add(Me.lblLock, 1, 10)
        Me.tlpSvrChk.Controls.Add(Me.btnPassword, 3, 3)
        Me.tlpSvrChk.Controls.Add(Me.rbUseNoti2, 3, 6)
        Me.tlpSvrChk.Controls.Add(Me.rbUseNoti1, 3, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblAdmin, 1, 9)
        Me.tlpSvrChk.Controls.Add(Me.chkAdmin, 2, 9)
        Me.tlpSvrChk.Controls.Add(Me.txtPasswordConfirm, 2, 4)
        Me.tlpSvrChk.Controls.Add(Me.txtPassword, 2, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblPasswordConfirm, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblPassword, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtDept, 2, 8)
        Me.tlpSvrChk.Controls.Add(Me.lblDept, 1, 8)
        Me.tlpSvrChk.Controls.Add(Me.lblPhone2, 1, 6)
        Me.tlpSvrChk.Controls.Add(Me.txtPhone2, 2, 6)
        Me.tlpSvrChk.Controls.Add(Me.txtEmail, 2, 7)
        Me.tlpSvrChk.Controls.Add(Me.lblEmail, 1, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtPhone, 2, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblPhone, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblUserID, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.lblUserName, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtUserID, 2, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtUserName, 2, 2)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 12
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(442, 395)
        Me.tlpSvrChk.TabIndex = 20
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPassword.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPassword.FixedHeight = False
        Me.btnPassword.FixedWidth = False
        Me.btnPassword.ForeColor = System.Drawing.Color.White
        Me.btnPassword.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnPassword.LineColor = System.Drawing.Color.Transparent
        Me.btnPassword.Location = New System.Drawing.Point(303, 88)
        Me.btnPassword.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Radius = 10
        Me.btnPassword.Size = New System.Drawing.Size(27, 27)
        Me.btnPassword.TabIndex = 22
        Me.btnPassword.Text = "F279"
        Me.btnPassword.UnCheckFillColor = System.Drawing.Color.Transparent
        Me.btnPassword.UseRound = True
        Me.btnPassword.UseVisualStyleBackColor = False
        Me.btnPassword.Visible = False
        '
        'rbUseNoti2
        '
        Me.rbUseNoti2.AutoSize = True
        Me.rbUseNoti2.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.tlpSvrChk.SetColumnSpan(Me.rbUseNoti2, 3)
        Me.rbUseNoti2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbUseNoti2.ForeColor = System.Drawing.Color.White
        Me.rbUseNoti2.LineColor = System.Drawing.Color.Gray
        Me.rbUseNoti2.Location = New System.Drawing.Point(303, 201)
        Me.rbUseNoti2.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbUseNoti2.Name = "rbUseNoti2"
        Me.rbUseNoti2.Radius = 10
        Me.rbUseNoti2.Size = New System.Drawing.Size(136, 16)
        Me.rbUseNoti2.TabIndex = 7
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
        Me.tlpSvrChk.SetColumnSpan(Me.rbUseNoti1, 3)
        Me.rbUseNoti1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbUseNoti1.ForeColor = System.Drawing.Color.White
        Me.rbUseNoti1.LineColor = System.Drawing.Color.Gray
        Me.rbUseNoti1.Location = New System.Drawing.Point(303, 166)
        Me.rbUseNoti1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.rbUseNoti1.Name = "rbUseNoti1"
        Me.rbUseNoti1.Radius = 10
        Me.rbUseNoti1.Size = New System.Drawing.Size(136, 16)
        Me.rbUseNoti1.TabIndex = 6
        Me.rbUseNoti1.TabStop = True
        Me.rbUseNoti1.Text = "F922"
        Me.rbUseNoti1.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rbUseNoti1.UseVisualStyleBackColor = True
        Me.rbUseNoti1.Warning = False
        Me.rbUseNoti1.WarningColor = System.Drawing.Color.Red
        '
        'lblAdmin
        '
        Me.lblAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAdmin.FixedHeight = False
        Me.lblAdmin.FixedWidth = False
        Me.lblAdmin.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.White
        Me.lblAdmin.LineSpacing = 0.0!
        Me.lblAdmin.Location = New System.Drawing.Point(23, 305)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(134, 20)
        Me.lblAdmin.TabIndex = 21
        Me.lblAdmin.Text = "F920"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAdmin
        '
        Me.chkAdmin.AutoSize = True
        Me.chkAdmin.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkAdmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkAdmin.ForeColor = System.Drawing.Color.White
        Me.chkAdmin.LineColor = System.Drawing.Color.Gray
        Me.chkAdmin.Location = New System.Drawing.Point(163, 308)
        Me.chkAdmin.Name = "chkAdmin"
        Me.chkAdmin.Radius = 10
        Me.chkAdmin.Size = New System.Drawing.Size(134, 14)
        Me.chkAdmin.TabIndex = 10
        Me.chkAdmin.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkAdmin.UseVisualStyleBackColor = True
        '
        'txtPasswordConfirm
        '
        Me.txtPasswordConfirm.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPasswordConfirm.code = False
        Me.txtPasswordConfirm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPasswordConfirm.FixedWidth = False
        Me.txtPasswordConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPasswordConfirm.impossibleinput = ""
        Me.txtPasswordConfirm.Location = New System.Drawing.Point(163, 126)
        Me.txtPasswordConfirm.Name = "txtPasswordConfirm"
        Me.txtPasswordConfirm.Necessary = True
        Me.txtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasswordConfirm.PossibleInput = ""
        Me.txtPasswordConfirm.Prefix = ""
        Me.txtPasswordConfirm.Size = New System.Drawing.Size(134, 21)
        Me.txtPasswordConfirm.StatusTip = ""
        Me.txtPasswordConfirm.TabIndex = 3
        Me.txtPasswordConfirm.Value = ""
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPassword.code = False
        Me.txtPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPassword.FixedWidth = False
        Me.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPassword.impossibleinput = ""
        Me.txtPassword.Location = New System.Drawing.Point(163, 91)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Necessary = True
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PossibleInput = ""
        Me.txtPassword.Prefix = ""
        Me.txtPassword.Size = New System.Drawing.Size(134, 21)
        Me.txtPassword.StatusTip = ""
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Value = ""
        '
        'lblPasswordConfirm
        '
        Me.lblPasswordConfirm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPasswordConfirm.FixedHeight = False
        Me.lblPasswordConfirm.FixedWidth = False
        Me.lblPasswordConfirm.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPasswordConfirm.ForeColor = System.Drawing.Color.White
        Me.lblPasswordConfirm.LineSpacing = 0.0!
        Me.lblPasswordConfirm.Location = New System.Drawing.Point(23, 130)
        Me.lblPasswordConfirm.Name = "lblPasswordConfirm"
        Me.lblPasswordConfirm.Size = New System.Drawing.Size(134, 20)
        Me.lblPasswordConfirm.TabIndex = 16
        Me.lblPasswordConfirm.Text = "F276"
        Me.lblPasswordConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassword
        '
        Me.lblPassword.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPassword.FixedHeight = False
        Me.lblPassword.FixedWidth = False
        Me.lblPassword.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.LineSpacing = 0.0!
        Me.lblPassword.Location = New System.Drawing.Point(23, 95)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(134, 20)
        Me.lblPassword.TabIndex = 15
        Me.lblPassword.Text = "F004"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDept
        '
        Me.txtDept.BackColor = System.Drawing.SystemColors.Control
        Me.txtDept.code = False
        Me.txtDept.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDept.FixedWidth = False
        Me.txtDept.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDept.impossibleinput = "!#$%^&*() \/:*?""<>|'`~"
        Me.txtDept.Location = New System.Drawing.Point(163, 266)
        Me.txtDept.MaxByteLength = 100
        Me.txtDept.Name = "txtDept"
        Me.txtDept.Necessary = False
        Me.txtDept.PossibleInput = ""
        Me.txtDept.Prefix = ""
        Me.txtDept.Size = New System.Drawing.Size(134, 21)
        Me.txtDept.StatusTip = ""
        Me.txtDept.TabIndex = 9
        Me.txtDept.Value = ""
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
        Me.lblDept.Size = New System.Drawing.Size(134, 20)
        Me.lblDept.TabIndex = 13
        Me.lblDept.Text = "F915"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone2
        '
        Me.lblPhone2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPhone2.FixedHeight = False
        Me.lblPhone2.FixedWidth = False
        Me.lblPhone2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPhone2.ForeColor = System.Drawing.Color.White
        Me.lblPhone2.LineSpacing = 0.0!
        Me.lblPhone2.Location = New System.Drawing.Point(23, 200)
        Me.lblPhone2.Name = "lblPhone2"
        Me.lblPhone2.Size = New System.Drawing.Size(134, 20)
        Me.lblPhone2.TabIndex = 12
        Me.lblPhone2.Text = "F349"
        Me.lblPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPhone2
        '
        Me.txtPhone2.BackColor = System.Drawing.SystemColors.Control
        Me.txtPhone2.code = False
        Me.txtPhone2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPhone2.FixedWidth = False
        Me.txtPhone2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPhone2.impossibleinput = ""
        Me.txtPhone2.Location = New System.Drawing.Point(163, 196)
        Me.txtPhone2.Name = "txtPhone2"
        Me.txtPhone2.Necessary = False
        Me.txtPhone2.PossibleInput = "0123456789+"
        Me.txtPhone2.Prefix = ""
        Me.txtPhone2.Size = New System.Drawing.Size(134, 21)
        Me.txtPhone2.StatusTip = ""
        Me.txtPhone2.TabIndex = 5
        Me.txtPhone2.Value = ""
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Control
        Me.txtEmail.code = False
        Me.tlpSvrChk.SetColumnSpan(Me.txtEmail, 2)
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtEmail.FixedWidth = False
        Me.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmail.impossibleinput = "!#$%^&*() \/:*?""<>|'`~"
        Me.txtEmail.Location = New System.Drawing.Point(163, 231)
        Me.txtEmail.MaxByteLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Necessary = False
        Me.txtEmail.PossibleInput = ""
        Me.txtEmail.Prefix = ""
        Me.txtEmail.Size = New System.Drawing.Size(167, 21)
        Me.txtEmail.StatusTip = ""
        Me.txtEmail.TabIndex = 8
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
        Me.lblEmail.Location = New System.Drawing.Point(23, 235)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(134, 20)
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
        Me.txtPhone.Location = New System.Drawing.Point(163, 161)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Necessary = False
        Me.txtPhone.PossibleInput = "0123456789+"
        Me.txtPhone.Prefix = ""
        Me.txtPhone.Size = New System.Drawing.Size(134, 21)
        Me.txtPhone.StatusTip = ""
        Me.txtPhone.TabIndex = 4
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
        Me.lblPhone.Location = New System.Drawing.Point(23, 165)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(134, 20)
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
        Me.lblUserID.Location = New System.Drawing.Point(23, 25)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(134, 20)
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
        Me.lblUserName.Location = New System.Drawing.Point(23, 60)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(134, 20)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "F348"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtUserID.code = False
        Me.txtUserID.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUserID.FixedWidth = False
        Me.txtUserID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUserID.impossibleinput = "!@#$%^&*() \/:*?""<>|'`~"
        Me.txtUserID.Location = New System.Drawing.Point(163, 21)
        Me.txtUserID.MaxByteLength = 16
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Necessary = True
        Me.txtUserID.PossibleInput = ""
        Me.txtUserID.Prefix = ""
        Me.txtUserID.Size = New System.Drawing.Size(134, 21)
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
        Me.txtUserName.Location = New System.Drawing.Point(163, 56)
        Me.txtUserName.MaxByteLength = 30
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Necessary = True
        Me.txtUserName.PossibleInput = ""
        Me.txtUserName.Prefix = ""
        Me.txtUserName.Size = New System.Drawing.Size(134, 21)
        Me.txtUserName.StatusTip = ""
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Value = ""
        '
        'lblLock
        '
        Me.lblLock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLock.FixedHeight = False
        Me.lblLock.FixedWidth = False
        Me.lblLock.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLock.ForeColor = System.Drawing.Color.White
        Me.lblLock.LineSpacing = 0.0!
        Me.lblLock.Location = New System.Drawing.Point(23, 340)
        Me.lblLock.Name = "lblLock"
        Me.lblLock.Size = New System.Drawing.Size(134, 20)
        Me.lblLock.TabIndex = 23
        Me.lblLock.Text = "M084"
        Me.lblLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkLock
        '
        Me.chkLock.AutoSize = True
        Me.chkLock.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.chkLock.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.chkLock.ForeColor = System.Drawing.Color.White
        Me.chkLock.LineColor = System.Drawing.Color.Gray
        Me.chkLock.Location = New System.Drawing.Point(163, 343)
        Me.chkLock.Name = "chkLock"
        Me.chkLock.Radius = 10
        Me.chkLock.Size = New System.Drawing.Size(134, 14)
        Me.chkLock.TabIndex = 24
        Me.chkLock.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkLock.UseVisualStyleBackColor = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(448, 496)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUser"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "User Information"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPhone As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPhone As eXperDB.BaseControls.Label
    Friend WithEvents lblUserID As eXperDB.BaseControls.Label
    Friend WithEvents lblUserName As eXperDB.BaseControls.Label
    Friend WithEvents txtUserID As eXperDB.BaseControls.TextBox
    Friend WithEvents txtUserName As eXperDB.BaseControls.TextBox
    Friend WithEvents txtEmail As eXperDB.BaseControls.TextBox
    Friend WithEvents lblEmail As eXperDB.BaseControls.Label
    Friend WithEvents txtDept As eXperDB.BaseControls.TextBox
    Friend WithEvents lblDept As eXperDB.BaseControls.Label
    Friend WithEvents lblPhone2 As eXperDB.BaseControls.Label
    Friend WithEvents txtPhone2 As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPassword As eXperDB.BaseControls.Label
    Friend WithEvents lblPasswordConfirm As eXperDB.BaseControls.Label
    Friend WithEvents txtPassword As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPasswordConfirm As eXperDB.BaseControls.TextBox
    Friend WithEvents chkAdmin As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblAdmin As eXperDB.BaseControls.Label
    Friend WithEvents rbUseNoti2 As eXperDB.BaseControls.RadioButton
    Friend WithEvents rbUseNoti1 As eXperDB.BaseControls.RadioButton
    Friend WithEvents btnPassword As eXperDB.BaseControls.Button
    Friend WithEvents chkLock As eXperDB.BaseControls.CheckBox
    Friend WithEvents lblLock As eXperDB.BaseControls.Label
End Class
