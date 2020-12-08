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
        Dim Edges1 As eXperDB.BaseControls.GroupBox.Edges = New eXperDB.BaseControls.GroupBox.Edges()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNotiHistory = New eXperDB.BaseControls.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnAct = New eXperDB.BaseControls.Button()
        Me.btnTest = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSender = New eXperDB.BaseControls.Label()
        Me.txtSender = New eXperDB.BaseControls.TextBox()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.tlpSvrChk = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBoxQuery1 = New eXperDB.Controls.RichTextBoxQuery()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAccountPolicy = New System.Windows.Forms.Label()
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
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tlpSvrChk.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnNotiHistory, 2, 0)
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
        'btnNotiHistory
        '
        Me.btnNotiHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNotiHistory.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnNotiHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNotiHistory.FixedHeight = False
        Me.btnNotiHistory.FixedWidth = False
        Me.btnNotiHistory.ForeColor = System.Drawing.Color.White
        Me.btnNotiHistory.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnNotiHistory.LineColor = System.Drawing.Color.Transparent
        Me.btnNotiHistory.Location = New System.Drawing.Point(362, 3)
        Me.btnNotiHistory.Name = "btnNotiHistory"
        Me.btnNotiHistory.Radius = 10
        Me.btnNotiHistory.Size = New System.Drawing.Size(124, 44)
        Me.btnNotiHistory.TabIndex = 4
        Me.btnNotiHistory.Text = "F353"
        Me.btnNotiHistory.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnNotiHistory.UseRound = True
        Me.btnNotiHistory.UseVisualStyleBackColor = False
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
        Me.StatusLabel.Size = New System.Drawing.Size(313, 50)
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
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnAct, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btnTest, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 527)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(489, 45)
        Me.TableLayoutPanel3.TabIndex = 17
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(287, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(74, 39)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnAct
        '
        Me.btnAct.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnAct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAct.FixedHeight = False
        Me.btnAct.FixedWidth = False
        Me.btnAct.ForeColor = System.Drawing.Color.White
        Me.btnAct.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAct.LineColor = System.Drawing.Color.Transparent
        Me.btnAct.Location = New System.Drawing.Point(207, 3)
        Me.btnAct.Name = "btnAct"
        Me.btnAct.Radius = 10
        Me.btnAct.Size = New System.Drawing.Size(74, 39)
        Me.btnAct.TabIndex = 8
        Me.btnAct.Text = "F014"
        Me.btnAct.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAct.UseRound = True
        Me.btnAct.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.btnTest.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTest.FixedHeight = False
        Me.btnTest.FixedWidth = False
        Me.btnTest.ForeColor = System.Drawing.Color.White
        Me.btnTest.GraColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnTest.LineColor = System.Drawing.Color.Transparent
        Me.btnTest.Location = New System.Drawing.Point(127, 3)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Radius = 10
        Me.btnTest.Size = New System.Drawing.Size(74, 39)
        Me.btnTest.TabIndex = 7
        Me.btnTest.Text = "F002"
        Me.btnTest.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTest.UseRound = True
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 53)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(489, 474)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblSender, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtSender, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(483, 64)
        Me.TableLayoutPanel4.TabIndex = 22
        '
        'lblSender
        '
        Me.lblSender.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSender.FixedHeight = False
        Me.lblSender.FixedWidth = False
        Me.lblSender.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSender.ForeColor = System.Drawing.Color.White
        Me.lblSender.LineSpacing = 0.0!
        Me.lblSender.Location = New System.Drawing.Point(3, 30)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(127, 20)
        Me.lblSender.TabIndex = 10
        Me.lblSender.Text = "Sender info"
        Me.lblSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSender
        '
        Me.txtSender.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSender.code = False
        Me.txtSender.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtSender.FixedWidth = False
        Me.txtSender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSender.impossibleinput = ""
        Me.txtSender.Location = New System.Drawing.Point(136, 26)
        Me.txtSender.MaxLength = 30
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Necessary = False
        Me.txtSender.PossibleInput = "0123456789."
        Me.txtSender.Prefix = ""
        Me.txtSender.Size = New System.Drawing.Size(194, 21)
        Me.txtSender.StatusTip = ""
        Me.txtSender.TabIndex = 1
        Me.txtSender.Value = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.tlpSvrChk)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges1
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Icon = Nothing
        Me.GroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(3, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 398)
        Me.GroupBox1.TabIndex = 0
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
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.tlpSvrChk.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Controls.Add(Me.RichTextBoxQuery1, 1, 8)
        Me.tlpSvrChk.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.tlpSvrChk.Controls.Add(Me.txtStatements, 1, 9)
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
        Me.tlpSvrChk.Location = New System.Drawing.Point(3, 17)
        Me.tlpSvrChk.Name = "tlpSvrChk"
        Me.tlpSvrChk.RowCount = 10
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpSvrChk.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSvrChk.Size = New System.Drawing.Size(477, 378)
        Me.tlpSvrChk.TabIndex = 21
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
        Me.RichTextBoxQuery1.Location = New System.Drawing.Point(136, 258)
        Me.RichTextBoxQuery1.MaxLength = 1000
        Me.RichTextBoxQuery1.Name = "RichTextBoxQuery1"
        Me.RichTextBoxQuery1.Numbers = System.Drawing.Color.Magenta
        Me.RichTextBoxQuery1.Size = New System.Drawing.Size(324, 84)
        Me.RichTextBoxQuery1.StateMents = System.Drawing.Color.Blue
        Me.RichTextBoxQuery1.Strings = System.Drawing.Color.Red
        Me.RichTextBoxQuery1.TabIndex = 32
        Me.RichTextBoxQuery1.Text = ""
        Me.RichTextBoxQuery1.Types = System.Drawing.Color.Brown
        Me.RichTextBoxQuery1.VariableRegex = "\$[a-zA-Z_\d]*\b"
        Me.RichTextBoxQuery1.Variables = System.Drawing.Color.Maroon
        Me.RichTextBoxQuery1.WordWrap = False
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel5.ColumnCount = 5
        Me.tlpSvrChk.SetColumnSpan(Me.TableLayoutPanel5, 4)
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblAccountPolicy, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(471, 29)
        Me.TableLayoutPanel5.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 29)
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
        Me.lblAccountPolicy.Size = New System.Drawing.Size(317, 29)
        Me.lblAccountPolicy.TabIndex = 3
        Me.lblAccountPolicy.Text = "Connection setup"
        Me.lblAccountPolicy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtStatements.Location = New System.Drawing.Point(136, 348)
        Me.txtStatements.MaxByteLength = 300
        Me.txtStatements.Multiline = True
        Me.txtStatements.Name = "txtStatements"
        Me.txtStatements.Necessary = True
        Me.txtStatements.PossibleInput = ""
        Me.txtStatements.Prefix = ""
        Me.txtStatements.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStatements.Size = New System.Drawing.Size(324, 27)
        Me.txtStatements.StatusTip = ""
        Me.txtStatements.TabIndex = 6
        Me.txtStatements.Value = ""
        Me.txtStatements.Visible = False
        '
        'lblStatements
        '
        Me.lblStatements.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStatements.FixedHeight = False
        Me.lblStatements.FixedWidth = False
        Me.lblStatements.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStatements.ForeColor = System.Drawing.Color.White
        Me.lblStatements.LineSpacing = 0.0!
        Me.lblStatements.Location = New System.Drawing.Point(3, 258)
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
        Me.lblDBMS.LineSpacing = 0.0!
        Me.lblDBMS.Location = New System.Drawing.Point(3, 50)
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
        Me.cmbDBMS.Items.AddRange(New Object() {"MSSQL", "ORACLE"})
        Me.cmbDBMS.Location = New System.Drawing.Point(136, 47)
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
        Me.txtDbnm.Location = New System.Drawing.Point(136, 151)
        Me.txtDbnm.MaxLength = 50
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
        Me.lblUser.LineSpacing = 0.0!
        Me.lblUser.Location = New System.Drawing.Point(3, 190)
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
        Me.lblPW.LineSpacing = 0.0!
        Me.lblPW.Location = New System.Drawing.Point(3, 225)
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
        Me.lblDB.LineSpacing = 0.0!
        Me.lblDB.Location = New System.Drawing.Point(3, 155)
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
        Me.txtPW.Location = New System.Drawing.Point(136, 221)
        Me.txtPW.MaxLength = 50
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
        Me.lblIP.LineSpacing = 0.0!
        Me.lblIP.Location = New System.Drawing.Point(3, 85)
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
        Me.txtUsr.Location = New System.Drawing.Point(136, 186)
        Me.txtUsr.MaxLength = 50
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
        Me.lblPort.LineSpacing = 0.0!
        Me.lblPort.Location = New System.Drawing.Point(3, 120)
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
        Me.txtIP.Location = New System.Drawing.Point(136, 81)
        Me.txtIP.MaxLength = 15
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
        Me.txtPort.Location = New System.Drawing.Point(136, 116)
        Me.txtPort.MaxLength = 5
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(495, 575)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNotiConfig"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alert link setup"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.tlpSvrChk.ResumeLayout(False)
        Me.tlpSvrChk.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnAct As eXperDB.BaseControls.Button
    Friend WithEvents btnTest As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblSender As eXperDB.BaseControls.Label
    Friend WithEvents txtSender As eXperDB.BaseControls.TextBox
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents tlpSvrChk As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblStatements As eXperDB.BaseControls.Label
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
    Friend WithEvents btnNotiHistory As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAccountPolicy As System.Windows.Forms.Label
    Friend WithEvents RichTextBoxQuery1 As eXperDB.Controls.RichTextBoxQuery
    Friend WithEvents txtStatements As eXperDB.BaseControls.TextBox
End Class
