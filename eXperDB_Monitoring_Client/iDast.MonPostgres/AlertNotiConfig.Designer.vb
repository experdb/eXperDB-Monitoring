<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertNotiConfig
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertNotiConfig))
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tlpUserConfigMain = New System.Windows.Forms.TableLayoutPanel()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.txtSender = New eXperDB.BaseControls.TextBox()
        Me.lblSender = New eXperDB.BaseControls.Label()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.lblStatements = New eXperDB.BaseControls.Label()
        Me.lblPW = New eXperDB.BaseControls.Label()
        Me.lblUser = New eXperDB.BaseControls.Label()
        Me.lblDB = New eXperDB.BaseControls.Label()
        Me.lblPort = New eXperDB.BaseControls.Label()
        Me.lblIP = New eXperDB.BaseControls.Label()
        Me.lblDBMS = New eXperDB.BaseControls.Label()
        Me.RichTextBoxQuery1 = New eXperDB.Controls.RichTextBoxQuery()
        Me.txtPW = New eXperDB.BaseControls.TextBox()
        Me.txtUsr = New eXperDB.BaseControls.TextBox()
        Me.txtDbnm = New eXperDB.BaseControls.TextBox()
        Me.txtPort = New eXperDB.BaseControls.TextBox()
        Me.txtIP = New eXperDB.BaseControls.TextBox()
        Me.cmbDBMS = New eXperDB.BaseControls.ComboBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAccountPolicy = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPercentageColumn1 = New eXperDB.Controls.DataGridViewPercentageColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.tlpUserConfigMain.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpUserConfigMain
        '
        Me.tlpUserConfigMain.BackColor = System.Drawing.Color.Transparent
        Me.tlpUserConfigMain.ColumnCount = 6
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpUserConfigMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.Controls.Add(Me.btnTest, 3, 5)
        Me.tlpUserConfigMain.Controls.Add(Me.btnSave, 4, 5)
        Me.tlpUserConfigMain.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tlpUserConfigMain.Controls.Add(Me.txtSender, 1, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.lblSender, 0, 1)
        Me.tlpUserConfigMain.Controls.Add(Me.GroupBox1, 0, 3)
        Me.tlpUserConfigMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUserConfigMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpUserConfigMain.Name = "tlpUserConfigMain"
        Me.tlpUserConfigMain.RowCount = 7
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpUserConfigMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpUserConfigMain.Size = New System.Drawing.Size(1061, 695)
        Me.tlpUserConfigMain.TabIndex = 3
        '
        'btnTest
        '
        Me.btnTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnTest.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnTest.Location = New System.Drawing.Point(416, 645)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(100, 40)
        Me.btnTest.TabIndex = 43
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(516, 645)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(100, 40)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.tlpUserConfigMain.SetColumnSpan(Me.TableLayoutPanel1, 6)
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusLabel, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1055, 32)
        Me.TableLayoutPanel1.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "      "
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
        Me.StatusLabel.Size = New System.Drawing.Size(879, 32)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Text"
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSender
        '
        Me.txtSender.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSender.code = False
        Me.txtSender.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSender.FixedWidth = False
        Me.txtSender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSender.impossibleinput = ""
        Me.txtSender.Location = New System.Drawing.Point(136, 51)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Necessary = False
        Me.txtSender.PossibleInput = "0123456789."
        Me.txtSender.Prefix = ""
        Me.txtSender.Size = New System.Drawing.Size(194, 21)
        Me.txtSender.StatusTip = ""
        Me.txtSender.TabIndex = 40
        Me.txtSender.Value = ""
        '
        'lblSender
        '
        Me.lblSender.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSender.FixedHeight = False
        Me.lblSender.FixedWidth = False
        Me.lblSender.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSender.ForeColor = System.Drawing.Color.White
        Me.lblSender.LineSpacing = 0.0!
        Me.lblSender.Location = New System.Drawing.Point(3, 55)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(127, 20)
        Me.lblSender.TabIndex = 39
        Me.lblSender.Text = "Sender info"
        Me.lblSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.tlpUserConfigMain.SetColumnSpan(Me.GroupBox1, 6)
        Me.GroupBox1.Controls.Add(Me.tlpSvrChk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges1
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Icon = CType(resources.GetObject("GroupBox1.Icon"), System.Drawing.Icon)
        Me.GroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(3, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(1055, 504)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox1.TitleGraColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.UseGraColor = False
        Me.GroupBox1.UseRound = True
        Me.GroupBox1.UseTitle = False
        '
        'tlpSvrChk
        '
        Me.tlpSvrChk.BackColor = System.Drawing.Color.Transparent
        Me.tlpSvrChk.ColumnCount = 4
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.lblStatements, 0, 9)
        Me.tlpSvrChk.Controls.Add(Me.lblPW, 0, 7)
        Me.tlpSvrChk.Controls.Add(Me.lblUser, 0, 6)
        Me.tlpSvrChk.Controls.Add(Me.lblDB, 0, 5)
        Me.tlpSvrChk.Controls.Add(Me.lblPort, 0, 4)
        Me.tlpSvrChk.Controls.Add(Me.lblIP, 0, 3)
        Me.tlpSvrChk.Controls.Add(Me.lblDBMS, 0, 2)
        Me.tlpSvrChk.Controls.Add(Me.RichTextBoxQuery1, 1, 9)
        Me.tlpSvrChk.Controls.Add(Me.txtPW, 1, 7)
        Me.tlpSvrChk.Controls.Add(Me.txtUsr, 1, 6)
        Me.tlpSvrChk.Controls.Add(Me.txtDbnm, 1, 5)
        Me.tlpSvrChk.Controls.Add(Me.txtPort, 1, 4)
        Me.tlpSvrChk.Controls.Add(Me.txtIP, 1, 3)
        Me.tlpSvrChk.Controls.Add(Me.cmbDBMS, 1, 2)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlpSvrChk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 14)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 11
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(1049, 487)
        Me.tlpSvrChk.TabIndex = 30
        '
        'lblStatements
        '
        Me.lblStatements.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatements.FixedHeight = False
        Me.lblStatements.FixedWidth = False
        Me.lblStatements.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStatements.ForeColor = System.Drawing.Color.White
        Me.lblStatements.LineSpacing = 0.0!
        Me.lblStatements.Location = New System.Drawing.Point(3, 288)
        Me.lblStatements.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblStatements.Name = "lblStatements"
        Me.lblStatements.Size = New System.Drawing.Size(122, 20)
        Me.lblStatements.TabIndex = 71
        Me.lblStatements.Text = "F215"
        Me.lblStatements.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPW
        '
        Me.lblPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPW.FixedHeight = False
        Me.lblPW.FixedWidth = False
        Me.lblPW.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPW.ForeColor = System.Drawing.Color.White
        Me.lblPW.LineSpacing = 0.0!
        Me.lblPW.Location = New System.Drawing.Point(3, 250)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(122, 20)
        Me.lblPW.TabIndex = 70
        Me.lblPW.Text = "F009"
        Me.lblPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUser
        '
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.LineSpacing = 0.0!
        Me.lblUser.Location = New System.Drawing.Point(3, 215)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(122, 20)
        Me.lblUser.TabIndex = 69
        Me.lblUser.Text = "F008"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDB
        '
        Me.lblDB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDB.FixedHeight = False
        Me.lblDB.FixedWidth = False
        Me.lblDB.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.LineSpacing = 0.0!
        Me.lblDB.Location = New System.Drawing.Point(3, 180)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(122, 20)
        Me.lblDB.TabIndex = 68
        Me.lblDB.Text = "F010"
        Me.lblDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPort
        '
        Me.lblPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblPort.FixedHeight = False
        Me.lblPort.FixedWidth = False
        Me.lblPort.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblPort.ForeColor = System.Drawing.Color.White
        Me.lblPort.LineSpacing = 0.0!
        Me.lblPort.Location = New System.Drawing.Point(3, 145)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(122, 20)
        Me.lblPort.TabIndex = 67
        Me.lblPort.Text = "F007"
        Me.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIP
        '
        Me.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblIP.FixedHeight = False
        Me.lblIP.FixedWidth = False
        Me.lblIP.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblIP.ForeColor = System.Drawing.Color.White
        Me.lblIP.LineSpacing = 0.0!
        Me.lblIP.Location = New System.Drawing.Point(3, 110)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(122, 20)
        Me.lblIP.TabIndex = 66
        Me.lblIP.Text = "F006"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDBMS
        '
        Me.lblDBMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDBMS.FixedHeight = False
        Me.lblDBMS.FixedWidth = False
        Me.lblDBMS.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDBMS.ForeColor = System.Drawing.Color.White
        Me.lblDBMS.LineSpacing = 0.0!
        Me.lblDBMS.Location = New System.Drawing.Point(3, 75)
        Me.lblDBMS.Name = "lblDBMS"
        Me.lblDBMS.Size = New System.Drawing.Size(122, 20)
        Me.lblDBMS.TabIndex = 65
        Me.lblDBMS.Text = "DBMS"
        Me.lblDBMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RichTextBoxQuery1
        '
        Me.RichTextBoxQuery1.AutoWordSelection = True
        Me.RichTextBoxQuery1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.RichTextBoxQuery1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpSvrChk.SetColumnSpan(Me.RichTextBoxQuery1, 2)
        Me.RichTextBoxQuery1.Comments = System.Drawing.Color.Green
        Me.RichTextBoxQuery1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxQuery1.ForeColor = System.Drawing.Color.DimGray
        Me.RichTextBoxQuery1.Functions = System.Drawing.Color.Maroon
        Me.RichTextBoxQuery1.HideSelection = False
        Me.RichTextBoxQuery1.KeyWords = System.Drawing.Color.Blue
        Me.RichTextBoxQuery1.Location = New System.Drawing.Point(131, 288)
        Me.RichTextBoxQuery1.Name = "RichTextBoxQuery1"
        Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.Magenta
        Me.RichTextBoxQuery1.Size = New System.Drawing.Size(374, 84)
        Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.Blue
        Me.RichTextBoxQuery1.Strings = System.Drawing.Color.Red
        Me.RichTextBoxQuery1.TabIndex = 64
        Me.RichTextBoxQuery1.Text = ""
        Me.RichTextBoxQuery1.Types = System.Drawing.Color.Brown
        Me.RichTextBoxQuery1.VariableRegex = "\$[a-zA-Z_\d]*\b"
        Me.RichTextBoxQuery1.Variables = System.Drawing.Color.Maroon
        Me.RichTextBoxQuery1.WordWrap = False
        '
        'txtPW
        '
        Me.txtPW.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPW.code = False
        Me.txtPW.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPW.FixedWidth = False
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPW.impossibleinput = ""
        Me.txtPW.Location = New System.Drawing.Point(131, 246)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Necessary = True
        Me.txtPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPW.PossibleInput = ""
        Me.txtPW.Prefix = ""
        Me.txtPW.Size = New System.Drawing.Size(194, 21)
        Me.txtPW.StatusTip = ""
        Me.txtPW.TabIndex = 63
        Me.txtPW.Value = ""
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtUsr.code = False
        Me.txtUsr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUsr.FixedWidth = False
        Me.txtUsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtUsr.impossibleinput = ""
        Me.txtUsr.Location = New System.Drawing.Point(131, 211)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Necessary = True
        Me.txtUsr.PossibleInput = ""
        Me.txtUsr.Prefix = ""
        Me.txtUsr.Size = New System.Drawing.Size(194, 21)
        Me.txtUsr.StatusTip = ""
        Me.txtUsr.TabIndex = 62
        Me.txtUsr.Value = ""
        '
        'txtDbnm
        '
        Me.txtDbnm.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtDbnm.code = False
        Me.txtDbnm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtDbnm.FixedWidth = False
        Me.txtDbnm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDbnm.impossibleinput = ""
        Me.txtDbnm.Location = New System.Drawing.Point(131, 176)
        Me.txtDbnm.Name = "txtDbnm"
        Me.txtDbnm.Necessary = True
        Me.txtDbnm.PossibleInput = ""
        Me.txtDbnm.Prefix = ""
        Me.txtDbnm.Size = New System.Drawing.Size(194, 21)
        Me.txtDbnm.StatusTip = ""
        Me.txtDbnm.TabIndex = 61
        Me.txtDbnm.Value = ""
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtPort.code = False
        Me.txtPort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtPort.FixedWidth = False
        Me.txtPort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPort.impossibleinput = ""
        Me.txtPort.Location = New System.Drawing.Point(131, 141)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Necessary = True
        Me.txtPort.PossibleInput = "0123456789"
        Me.txtPort.Prefix = ""
        Me.txtPort.Size = New System.Drawing.Size(194, 21)
        Me.txtPort.StatusTip = ""
        Me.txtPort.TabIndex = 60
        Me.txtPort.Value = "0"
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtIP.code = False
        Me.txtIP.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtIP.FixedWidth = False
        Me.txtIP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIP.impossibleinput = ""
        Me.txtIP.Location = New System.Drawing.Point(131, 106)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Necessary = True
        Me.txtIP.PossibleInput = "0123456789."
        Me.txtIP.Prefix = ""
        Me.txtIP.Size = New System.Drawing.Size(194, 21)
        Me.txtIP.StatusTip = ""
        Me.txtIP.TabIndex = 59
        Me.txtIP.Value = ""
        '
        'cmbDBMS
        '
        Me.cmbDBMS.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.cmbDBMS.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbDBMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDBMS.FixedWidth = False
        Me.cmbDBMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDBMS.FormattingEnabled = True
        Me.cmbDBMS.Items.AddRange(New Object() {"MSSQL", "ORACLE", "MYSQL"})
        Me.cmbDBMS.Location = New System.Drawing.Point(131, 72)
        Me.cmbDBMS.Name = "cmbDBMS"
        Me.cmbDBMS.Necessary = True
        Me.cmbDBMS.Size = New System.Drawing.Size(194, 20)
        Me.cmbDBMS.StatusTip = ""
        Me.cmbDBMS.TabIndex = 58
        Me.cmbDBMS.ValueText = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.tlpSvrChk.SetColumnSpan(Me.TableLayoutPanel2, 4)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAccountPolicy, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1043, 34)
        Me.TableLayoutPanel2.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 34)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "      "
        '
        'lblAccountPolicy
        '
        Me.lblAccountPolicy.AutoSize = True
        Me.lblAccountPolicy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAccountPolicy.ForeColor = System.Drawing.Color.White
        Me.lblAccountPolicy.Location = New System.Drawing.Point(43, 0)
        Me.lblAccountPolicy.Name = "lblAccountPolicy"
        Me.lblAccountPolicy.Size = New System.Drawing.Size(889, 34)
        Me.lblAccountPolicy.TabIndex = 3
        Me.lblAccountPolicy.Text = "F950"
        Me.lblAccountPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "HOST_NAME"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.FillWeight = 131.1306!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Alert Name"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 95
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "GROUP_NAME"
        DataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.FillWeight = 171.0869!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Biz day"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 120.5725!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Biz hour"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewPercentageColumn1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "P"
        Me.DataGridViewPercentageColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewPercentageColumn1.HeaderText = "Alert Level"
        Me.DataGridViewPercentageColumn1.MinimumWidth = 180
        Me.DataGridViewPercentageColumn1.Name = "DataGridViewPercentageColumn1"
        Me.DataGridViewPercentageColumn1.ReadOnly = True
        Me.DataGridViewPercentageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPercentageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPercentageColumn1.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RETENTION_TIME"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "P"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Alert Level"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 180
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 180
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RETENTION_TIME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Alert duration"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CHECK_USER_ID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Cycle"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 95
        '
        'AlertNotiConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.tlpUserConfigMain)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "AlertNotiConfig"
        Me.Size = New System.Drawing.Size(1061, 695)
        Me.tlpUserConfigMain.ResumeLayout(False)
        Me.tlpUserConfigMain.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpUserConfigMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPercentageColumn1 As eXperDB.Controls.DataGridViewPercentageColumn
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAccountPolicy As System.Windows.Forms.Label
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents lblSender As eXperDB.BaseControls.Label
    Friend WithEvents txtSender As eXperDB.BaseControls.TextBox
    Friend WithEvents cmbDBMS As eXperDB.BaseControls.ComboBox
    Friend WithEvents txtIP As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPort As eXperDB.BaseControls.TextBox
    Friend WithEvents txtDbnm As eXperDB.BaseControls.TextBox
    Friend WithEvents txtUsr As eXperDB.BaseControls.TextBox
    Friend WithEvents txtPW As eXperDB.BaseControls.TextBox
    Friend WithEvents RichTextBoxQuery1 As eXperDB.Controls.RichTextBoxQuery
    Friend WithEvents lblDBMS As eXperDB.BaseControls.Label
    Friend WithEvents lblIP As eXperDB.BaseControls.Label
    Friend WithEvents lblPort As eXperDB.BaseControls.Label
    Friend WithEvents lblDB As eXperDB.BaseControls.Label
    Friend WithEvents lblUser As eXperDB.BaseControls.Label
    Friend WithEvents lblPW As eXperDB.BaseControls.Label
    Friend WithEvents lblStatements As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button

End Class
