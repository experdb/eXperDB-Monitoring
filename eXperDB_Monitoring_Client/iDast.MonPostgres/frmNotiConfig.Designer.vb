<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotiConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotiConfig))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.txtStatements = New eXperDB.BaseControls.TextBox()
        Me.lblStatements = New eXperDB.BaseControls.Label()
        Me.lblDBMS = New eXperDB.BaseControls.Label()
        Me.cmbDBMS = New eXperDB.BaseControls.ComboBox()
        Me.txtDbnm = New eXperDB.BaseControls.TextBox()
        Me.lblUser = New eXperDB.BaseControls.Label()
        Me.lblPW = New eXperDB.BaseControls.Label()
        Me.lblDB = New eXperDB.BaseControls.Label()
        Me.txtPW = New eXperDB.BaseControls.TextBox()
        Me.lblIP = New eXperDB.BaseControls.Label()
        Me.txtUsr = New eXperDB.BaseControls.TextBox()
        Me.lblPort = New eXperDB.BaseControls.Label()
        Me.txtIP = New eXperDB.BaseControls.TextBox()
        Me.txtPort = New eXperDB.BaseControls.TextBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(489, 50)
        Me.TableLayoutPanel2.TabIndex = 16
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
        Me.StatusLabel.Size = New System.Drawing.Size(443, 50)
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
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTest, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 395)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(489, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.Gray
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(287, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.Gray
        Me.btnAct.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnAct.Location = New System.Drawing.Point(207, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 8
        Me.btnAct.Text = "F014"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.GraColor = System.Drawing.Color.Gray
        Me.btnTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(127, 3)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(74, 39)
        Me.btnTest.TabIndex = 7
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Gray
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.txtStatements, 1, 8)
        Me.tlpSvrChk.Controls.Add(Me.lblStatements, 0, 8)
        Me.tlpSvrChk.Controls.Add(Me.lblDBMS, 0, 1)
        Me.tlpSvrChk.Controls.Add(Me.cmbDBMS, 1, 1)
        Me.tlpSvrChk.Controls.Add(Me.txtDbnm, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblUser, 0, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblPW, 0, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblDB, 0, 4)
        Me.tlpSvrChk.Controls.Add(Me.txtPW, 1, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblIP, 0, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtUsr, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblPort, 0, 3)
        Me.tlpSvrChk.Controls.Add(Me.txtIP, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.txtPort, 1, 3)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 53)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 10
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(489, 342)
        Me.tlpSvrChk.TabIndex = 20
        '
        'txtStatements
        '
        Me.txtStatements.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtStatements.code = False
        Me.tlpSvrChk.SetColumnSpan(Me.txtStatements, 2)
        Me.txtStatements.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtStatements.FixedWidth = False
        Me.txtStatements.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtStatements.impossibleinput = ""
        Me.txtStatements.Location = New System.Drawing.Point(136, 238)
        Me.txtStatements.MaxByteLength = 300
        Me.txtStatements.Multiline = True
        Me.txtStatements.Name = "txtStatements"
        Me.txtStatements.Necessary = True
        Me.txtStatements.PossibleInput = ""
        Me.txtStatements.Prefix = ""
        Me.txtStatements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStatements.Size = New System.Drawing.Size(324, 84)
        Me.txtStatements.StatusTip = ""
        Me.txtStatements.TabIndex = 6
        Me.txtStatements.Value = ""
        '
        'lblStatements
        '
        Me.lblStatements.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatements.FixedHeight = False
        Me.lblStatements.FixedWidth = False
        Me.lblStatements.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStatements.ForeColor = System.Drawing.Color.White
        Me.lblStatements.Location = New System.Drawing.Point(3, 238)
        Me.lblStatements.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblStatements.Name = "lblStatements"
        Me.lblStatements.Size = New System.Drawing.Size(127, 20)
        Me.lblStatements.TabIndex = 11
        Me.lblStatements.Text = "F215"
        Me.lblStatements.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDBMS
        '
        Me.lblDBMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDBMS.FixedHeight = False
        Me.lblDBMS.FixedWidth = False
        Me.lblDBMS.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDBMS.ForeColor = System.Drawing.Color.White
        Me.lblDBMS.Location = New System.Drawing.Point(3, 30)
        Me.lblDBMS.Name = "lblDBMS"
        Me.lblDBMS.Size = New System.Drawing.Size(127, 20)
        Me.lblDBMS.TabIndex = 10
        Me.lblDBMS.Text = "DBMS"
        Me.lblDBMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDBMS
        '
        Me.cmbDBMS.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmbDBMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbDBMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBMS.FixedWidth = False
        Me.cmbDBMS.FormattingEnabled = True
        Me.cmbDBMS.Items.AddRange(New Object() {"MSSQL"})
        Me.cmbDBMS.Location = New System.Drawing.Point(136, 27)
        Me.cmbDBMS.Name = "cmbDBMS"
        Me.cmbDBMS.Necessary = True
        Me.cmbDBMS.Size = New System.Drawing.Size(194, 20)
        Me.cmbDBMS.StatusTip = ""
        Me.cmbDBMS.TabIndex = 0
        Me.cmbDBMS.ValueText = ""
        '
        'txtDbnm
        '
        Me.txtDbnm.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtDbnm.code = False
        Me.txtDbnm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDbnm.FixedWidth = False
        Me.txtDbnm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDbnm.impossibleinput = ""
        Me.txtDbnm.Location = New System.Drawing.Point(136, 131)
        Me.txtDbnm.Name = "txtDbnm"
        Me.txtDbnm.Necessary = True
        Me.txtDbnm.PossibleInput = ""
        Me.txtDbnm.Prefix = ""
        Me.txtDbnm.Size = New System.Drawing.Size(194, 21)
        Me.txtDbnm.StatusTip = ""
        Me.txtDbnm.TabIndex = 3
        Me.txtDbnm.Value = ""
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(3, 170)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(127, 20)
        Me.lblUser.TabIndex = 4
        Me.lblUser.Text = "F008"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPW
        '
        Me.lblPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPW.FixedHeight = False
        Me.lblPW.FixedWidth = False
        Me.lblPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.White
        Me.lblPW.Location = New System.Drawing.Point(3, 205)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(127, 20)
        Me.lblPW.TabIndex = 6
        Me.lblPW.Text = "F009"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDB
        '
        Me.lblDB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDB.FixedHeight = False
        Me.lblDB.FixedWidth = False
        Me.lblDB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.Location = New System.Drawing.Point(3, 135)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(127, 20)
        Me.lblDB.TabIndex = 8
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPW.code = False
        Me.txtPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPW.FixedWidth = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(136, 201)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = True
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(194, 21)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 5
        Me.txtPW.Value = ""
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.Location = New System.Drawing.Point(3, 65)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(127, 20)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "F006"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtUsr.code = False
        Me.txtUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUsr.FixedWidth = False
        Me.txtUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUsr.impossibleinput = ""
        Me.txtUsr.Location = New System.Drawing.Point(136, 166)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Necessary = True
        Me.txtUsr.PossibleInput = ""
        Me.txtUsr.Prefix = ""
        Me.txtUsr.Size = New System.Drawing.Size(194, 21)
        Me.txtUsr.StatusTip = ""
        Me.txtUsr.TabIndex = 4
        Me.txtUsr.Value = ""
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPort.FixedHeight = False
        Me.lblPort.FixedWidth = False
        Me.lblPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.White
        Me.lblPort.Location = New System.Drawing.Point(3, 100)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(127, 20)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "F007"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(136, 61)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = True
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(194, 21)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 1
        Me.txtIP.Value = ""
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPort.code = False
        Me.txtPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPort.FixedWidth = False
        Me.txtPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPort.impossibleinput = ""
        Me.txtPort.Location = New System.Drawing.Point(136, 96)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Necessary = True
        Me.txtPort.PossibleInput = "0123456789"
        Me.txtPort.Prefix = ""
        Me.txtPort.Size = New System.Drawing.Size(194, 21)
        Me.txtPort.StatusTip = ""
        Me.txtPort.TabIndex = 2
        Me.txtPort.Value = "0"
        '
        'frmNotiConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 443)
        Me.Controls.Add(Me.tlpSvrChk)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotiConfig"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Database Information"
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
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblDBMS As eXperDB.BaseControls.Label
    Friend WithEvents cmbDBMS As eXperDB.BaseControls.ComboBox
    Friend WithEvents txtDbnm As eXperDB.BaseControls.TextBox
    Friend WithEvents lblUser As eXperDB.BaseControls.Label
    Friend WithEvents lblPW As eXperDB.BaseControls.Label
    Friend WithEvents lblDB As eXperDB.BaseControls.Label
    Friend WithEvents txtPW As eXperDB.BaseControls.TextBox
    Friend WithEvents lblIP As eXperDB.BaseControls.Label
    Friend WithEvents txtUsr As eXperDB.BaseControls.TextBox
    Friend WithEvents lblPort As eXperDB.BaseControls.Label
    Friend WithEvents txtIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPort As eXperDB.BaseControls.TextBox
    Friend WithEvents txtStatements As eXperDB.BaseControls.TextBox
    Friend WithEvents lblStatements As eXperDB.BaseControls.Label
End Class
