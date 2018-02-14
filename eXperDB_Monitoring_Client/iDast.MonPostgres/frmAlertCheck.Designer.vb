<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlertCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlertCheck))
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.btnSave = New eXperDB.BaseControls.Button()
        Me.Panel2 = New eXperDB.BaseControls.Panel()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.FormMovePanel1 = New eXperDB.Controls.FormMovePanel()
        Me.FormControlBox1 = New eXperDB.Controls.FormControlBox()
        Me.txtAlertComment = New eXperDB.BaseControls.TextBox()
        Me.lblInstance = New eXperDB.BaseControls.Label()
        Me.GroupBox1 = New eXperDB.BaseControls.GroupBox()
        Me.TableLayoutPanel2 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblAlertUser = New eXperDB.BaseControls.Label()
        Me.lblAlertType = New eXperDB.BaseControls.Label()
        Me.lblAlertComment = New eXperDB.BaseControls.Label()
        Me.lblAlertTime = New eXperDB.BaseControls.Label()
        Me.lblAlertLevel = New eXperDB.BaseControls.Label()
        Me.lblInstanceValue = New eXperDB.BaseControls.Label()
        Me.lblAlertTypeValue = New eXperDB.BaseControls.Label()
        Me.lblAlertTimeValue = New eXperDB.BaseControls.Label()
        Me.lblAlertLevelValue = New eXperDB.BaseControls.Label()
        Me.lblMsgValue = New eXperDB.BaseControls.Label()
        Me.lblAlertMsg = New eXperDB.BaseControls.Label()
        Me.lblPause = New eXperDB.BaseControls.Label()
        Me.cmbPauseTime = New eXperDB.BaseControls.ComboBox()
        Me.txtAlertUser = New eXperDB.BaseControls.TextBox()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FormMovePanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnClose.FixedHeight = False
        Me.btnClose.FixedWidth = False
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClose.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(318, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(104, 28)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "F021"
        Me.btnClose.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClose.UseRound = True
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSave.FixedHeight = False
        Me.btnSave.FixedWidth = False
        Me.btnSave.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSave.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSave.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(208, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Radius = 10
        Me.btnSave.Size = New System.Drawing.Size(104, 28)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "F014"
        Me.btnSave.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.UseRound = True
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 239)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 39)
        Me.Panel2.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnClose, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(425, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FormMovePanel1
        '
        Me.FormMovePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormMovePanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormMovePanel1.Controls.Add(Me.FormControlBox1)
        Me.FormMovePanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormMovePanel1.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormMovePanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormMovePanel1.Location = New System.Drawing.Point(3, 4)
        Me.FormMovePanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormMovePanel1.Name = "FormMovePanel1"
        Me.FormMovePanel1.Size = New System.Drawing.Size(425, 31)
        Me.FormMovePanel1.TabIndex = 8
        Me.FormMovePanel1.Text = "F262"
        '
        'FormControlBox1
        '
        Me.FormControlBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormControlBox1.CloseBox = New System.Drawing.Rectangle(23, 1, 20, 20)
        Me.FormControlBox1.ConfigBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.CriticalBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FormControlBox1.DualBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FormControlBox1.isCritical = False
        Me.FormControlBox1.isLock = False
        Me.FormControlBox1.isPower = False
        Me.FormControlBox1.isRotation = True
        Me.FormControlBox1.LEDColor = System.Drawing.Color.Lime
        Me.FormControlBox1.Location = New System.Drawing.Point(378, 0)
        Me.FormControlBox1.LockBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.FormControlBox1.MaxBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.MinBox = New System.Drawing.Rectangle(1, 1, 20, 20)
        Me.FormControlBox1.Name = "FormControlBox1"
        Me.FormControlBox1.PowerBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.RotationBox = New System.Drawing.Rectangle(0, 0, 0, 0)
        Me.FormControlBox1.ShowRectCnt = 2
        Me.FormControlBox1.Size = New System.Drawing.Size(45, 22)
        Me.FormControlBox1.TabIndex = 1
        Me.FormControlBox1.Text = "FormControlBox1"
        Me.FormControlBox1.UseConfigBox = False
        Me.FormControlBox1.UseCriticalBox = False
        Me.FormControlBox1.UseDualBox = False
        Me.FormControlBox1.UseLockBox = False
        Me.FormControlBox1.UseMaxBox = False
        Me.FormControlBox1.UseMinBox = True
        Me.FormControlBox1.UsePowerBox = False
        Me.FormControlBox1.UseRotationBox = False
        '
        'txtAlertComment
        '
        Me.txtAlertComment.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlertComment.code = False
        Me.txtAlertComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlertComment.FixedWidth = False
        Me.txtAlertComment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlertComment.impossibleinput = ""
        Me.txtAlertComment.Location = New System.Drawing.Point(153, 100)
        Me.txtAlertComment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlertComment.Multiline = True
        Me.txtAlertComment.Name = "txtAlertComment"
        Me.txtAlertComment.Necessary = False
        Me.txtAlertComment.PossibleInput = ""
        Me.txtAlertComment.Prefix = ""
        Me.txtAlertComment.Size = New System.Drawing.Size(263, 62)
        Me.txtAlertComment.StatusTip = ""
        Me.txtAlertComment.TabIndex = 10
        Me.txtAlertComment.Value = ""
        '
        'lblInstance
        '
        Me.lblInstance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInstance.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblInstance.ForeColor = System.Drawing.Color.DarkGray
        Me.lblInstance.Location = New System.Drawing.Point(47, 13)
        Me.lblInstance.Name = "lblInstance"
        Me.lblInstance.Size = New System.Drawing.Size(100, 21)
        Me.lblInstance.TabIndex = 9
        Me.lblInstance.Text = "F033"
        Me.lblInstance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInstance.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.AlignLine = System.Drawing.StringAlignment.Center
        Me.GroupBox1.AlignString = System.Drawing.StringAlignment.Near
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.EdgeRound = Edges1
        Me.GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Icon = Nothing
        Me.GroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.GroupBox1.LineWidth = 1
        Me.GroupBox1.Location = New System.Drawing.Point(3, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 204)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.TitleFont = New System.Drawing.Font("Gulim", 9.0!)
        Me.GroupBox1.TitleGraColor = System.Drawing.Color.DimGray
        Me.GroupBox1.UseGraColor = False
        Me.GroupBox1.UseTitle = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertUser, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lblInstance, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertType, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertComment, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertTime, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertLevel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAlertComment, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.lblInstanceValue, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertTypeValue, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertTimeValue, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertLevelValue, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblMsgValue, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAlertMsg, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPause, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbPauseTime, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAlertUser, 1, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 21)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(419, 180)
        Me.TableLayoutPanel2.TabIndex = 11
        '
        'lblAlertUser
        '
        Me.lblAlertUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAlertUser.FixedWidth = False
        Me.lblAlertUser.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertUser.Location = New System.Drawing.Point(3, 21)
        Me.lblAlertUser.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblAlertUser.Name = "lblAlertUser"
        Me.lblAlertUser.Size = New System.Drawing.Size(144, 21)
        Me.lblAlertUser.TabIndex = 14
        Me.lblAlertUser.Text = "F265"
        Me.lblAlertUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlertType
        '
        Me.lblAlertType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertType.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAlertType.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertType.Location = New System.Drawing.Point(47, 14)
        Me.lblAlertType.Name = "lblAlertType"
        Me.lblAlertType.Size = New System.Drawing.Size(100, 21)
        Me.lblAlertType.TabIndex = 9
        Me.lblAlertType.Text = "F258"
        Me.lblAlertType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlertType.Visible = False
        '
        'lblAlertComment
        '
        Me.lblAlertComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertComment.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAlertComment.FixedHeight = False
        Me.lblAlertComment.FixedWidth = False
        Me.lblAlertComment.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertComment.Location = New System.Drawing.Point(3, 99)
        Me.lblAlertComment.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblAlertComment.Name = "lblAlertComment"
        Me.lblAlertComment.Size = New System.Drawing.Size(144, 21)
        Me.lblAlertComment.TabIndex = 9
        Me.lblAlertComment.Text = "F260"
        Me.lblAlertComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlertTime
        '
        Me.lblAlertTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertTime.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAlertTime.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertTime.Location = New System.Drawing.Point(47, 15)
        Me.lblAlertTime.Name = "lblAlertTime"
        Me.lblAlertTime.Size = New System.Drawing.Size(100, 21)
        Me.lblAlertTime.TabIndex = 9
        Me.lblAlertTime.Text = "F257"
        Me.lblAlertTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlertTime.Visible = False
        '
        'lblAlertLevel
        '
        Me.lblAlertLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertLevel.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAlertLevel.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertLevel.Location = New System.Drawing.Point(47, 16)
        Me.lblAlertLevel.Name = "lblAlertLevel"
        Me.lblAlertLevel.Size = New System.Drawing.Size(100, 21)
        Me.lblAlertLevel.TabIndex = 9
        Me.lblAlertLevel.Text = "F256"
        Me.lblAlertLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlertLevel.Visible = False
        '
        'lblInstanceValue
        '
        Me.lblInstanceValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInstanceValue.FixedWidth = False
        Me.lblInstanceValue.ForeColor = System.Drawing.Color.DarkGray
        Me.lblInstanceValue.Location = New System.Drawing.Point(153, 13)
        Me.lblInstanceValue.Name = "lblInstanceValue"
        Me.lblInstanceValue.Size = New System.Drawing.Size(263, 21)
        Me.lblInstanceValue.TabIndex = 11
        Me.lblInstanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInstanceValue.Visible = False
        '
        'lblAlertTypeValue
        '
        Me.lblAlertTypeValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertTypeValue.FixedWidth = False
        Me.lblAlertTypeValue.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertTypeValue.Location = New System.Drawing.Point(153, 14)
        Me.lblAlertTypeValue.Name = "lblAlertTypeValue"
        Me.lblAlertTypeValue.Size = New System.Drawing.Size(263, 21)
        Me.lblAlertTypeValue.TabIndex = 11
        Me.lblAlertTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlertTypeValue.Visible = False
        '
        'lblAlertTimeValue
        '
        Me.lblAlertTimeValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertTimeValue.FixedWidth = False
        Me.lblAlertTimeValue.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertTimeValue.Location = New System.Drawing.Point(153, 15)
        Me.lblAlertTimeValue.Name = "lblAlertTimeValue"
        Me.lblAlertTimeValue.Size = New System.Drawing.Size(263, 21)
        Me.lblAlertTimeValue.TabIndex = 11
        Me.lblAlertTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlertTimeValue.Visible = False
        '
        'lblAlertLevelValue
        '
        Me.lblAlertLevelValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlertLevelValue.FixedWidth = False
        Me.lblAlertLevelValue.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertLevelValue.Location = New System.Drawing.Point(153, 16)
        Me.lblAlertLevelValue.Name = "lblAlertLevelValue"
        Me.lblAlertLevelValue.Size = New System.Drawing.Size(263, 21)
        Me.lblAlertLevelValue.TabIndex = 11
        Me.lblAlertLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAlertLevelValue.Visible = False
        '
        'lblMsgValue
        '
        Me.lblMsgValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMsgValue.FixedWidth = False
        Me.lblMsgValue.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMsgValue.Location = New System.Drawing.Point(153, 17)
        Me.lblMsgValue.Name = "lblMsgValue"
        Me.lblMsgValue.Size = New System.Drawing.Size(263, 21)
        Me.lblMsgValue.TabIndex = 11
        Me.lblMsgValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMsgValue.Visible = False
        '
        'lblAlertMsg
        '
        Me.lblAlertMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlertMsg.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblAlertMsg.ForeColor = System.Drawing.Color.DarkGray
        Me.lblAlertMsg.Location = New System.Drawing.Point(47, 17)
        Me.lblAlertMsg.Name = "lblAlertMsg"
        Me.lblAlertMsg.Size = New System.Drawing.Size(100, 21)
        Me.lblAlertMsg.TabIndex = 9
        Me.lblAlertMsg.Text = "F259"
        Me.lblAlertMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAlertMsg.Visible = False
        '
        'lblPause
        '
        Me.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPause.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPause.FixedWidth = False
        Me.lblPause.ForeColor = System.Drawing.Color.DarkGray
        Me.lblPause.Location = New System.Drawing.Point(3, 60)
        Me.lblPause.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(144, 21)
        Me.lblPause.TabIndex = 12
        Me.lblPause.Text = "F263"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPauseTime
        '
        Me.cmbPauseTime.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPauseTime.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbPauseTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPauseTime.FixedWidth = False
        Me.cmbPauseTime.FormattingEnabled = True
        Me.cmbPauseTime.Items.AddRange(New Object() {"None", "5", "30", "60", "120"})
        Me.cmbPauseTime.Location = New System.Drawing.Point(153, 61)
        Me.cmbPauseTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbPauseTime.Name = "cmbPauseTime"
        Me.cmbPauseTime.Necessary = False
        Me.cmbPauseTime.Size = New System.Drawing.Size(100, 23)
        Me.cmbPauseTime.StatusTip = ""
        Me.cmbPauseTime.TabIndex = 13
        Me.cmbPauseTime.ValueText = ""
        '
        'txtAlertUser
        '
        Me.txtAlertUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlertUser.code = False
        Me.txtAlertUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlertUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtAlertUser.impossibleinput = ""
        Me.txtAlertUser.Location = New System.Drawing.Point(153, 21)
        Me.txtAlertUser.Name = "txtAlertUser"
        Me.txtAlertUser.Necessary = False
        Me.txtAlertUser.PossibleInput = ""
        Me.txtAlertUser.Prefix = ""
        Me.txtAlertUser.Size = New System.Drawing.Size(150, 25)
        Me.txtAlertUser.StatusTip = ""
        Me.txtAlertUser.TabIndex = 15
        Me.txtAlertUser.Value = ""
        '
        'frmAlertCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(431, 282)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FormMovePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAlertCheck"
        Me.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmConfig"
        Me.Panel2.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.FormMovePanel1.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.TableLayoutPanel2.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Panel2 As eXperDB.BaseControls.Panel
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents btnSave As eXperDB.BaseControls.Button
    Friend WithEvents FormMovePanel1 As eXperDB.Controls.FormMovePanel
    Friend WithEvents FormControlBox1 As eXperDB.Controls.FormControlBox
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents txtAlertComment As eXperDB.BaseControls.TextBox
    Friend WithEvents lblInstance As eXperDB.BaseControls.Label
    Friend WithEvents GroupBox1 As eXperDB.BaseControls.GroupBox
    Friend WithEvents lblAlertTime As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertType As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertComment As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertMsg As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertLevel As eXperDB.BaseControls.Label
    Friend WithEvents TableLayoutPanel2 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblInstanceValue As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertTypeValue As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertTimeValue As eXperDB.BaseControls.Label
    Friend WithEvents lblAlertLevelValue As eXperDB.BaseControls.Label
    Friend WithEvents lblMsgValue As eXperDB.BaseControls.Label
    Friend WithEvents lblPause As eXperDB.BaseControls.Label
    Friend WithEvents cmbPauseTime As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblAlertUser As eXperDB.BaseControls.Label
    Friend WithEvents txtAlertUser As eXperDB.BaseControls.TextBox
End Class
