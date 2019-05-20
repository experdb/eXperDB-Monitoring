<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotiHistory
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotiHistory))
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlB = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClose = New eXperDB.BaseControls.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvNotificationLst = New eXperDB.BaseControls.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNotiList = New System.Windows.Forms.Label()
        Me.tlpHead = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblUser = New eXperDB.BaseControls.Label()
        Me.cmbUser = New eXperDB.BaseControls.ComboBox()
        Me.lblServer = New eXperDB.BaseControls.Label()
        Me.cmbServer = New eXperDB.BaseControls.ComboBox()
        Me.lblLevel = New eXperDB.BaseControls.Label()
        Me.cmbLevel = New eXperDB.BaseControls.ComboBox()
        Me.lblStatus = New eXperDB.BaseControls.Label()
        Me.cmbResults = New eXperDB.BaseControls.ComboBox()
        Me.lblDuration = New eXperDB.BaseControls.Label()
        Me.dtpSt = New eXperDB.BaseControls.DateTimePicker()
        Me.lblDuration2 = New eXperDB.BaseControls.Label()
        Me.dtpEd = New eXperDB.BaseControls.DateTimePicker()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnQuery = New eXperDB.BaseControls.Button()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ttChart = New System.Windows.Forms.ToolTip(Me.components)
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstHostName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstINSTANCEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstSender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstReceiver = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstMessages = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstIsSuccess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvNotificationLstCollectDt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewPasswordTextBoxColumn1 = New eXperDB.Controls.DataGridViewPasswordTextBoxColumn()
        Me.pnlB.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvNotificationLst, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpHead.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlB
        '
        Me.pnlB.ColumnCount = 3
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.pnlB.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlB.Controls.Add(Me.btnClose, 1, 0)
        Me.pnlB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlB.Location = New System.Drawing.Point(2, 537)
        Me.pnlB.Name = "pnlB"
        Me.pnlB.RowCount = 1
        Me.pnlB.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlB.Size = New System.Drawing.Size(1043, 44)
        Me.pnlB.TabIndex = 18
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
        Me.btnClose.Location = New System.Drawing.Point(474, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Radius = 10
        Me.btnClose.Size = New System.Drawing.Size(94, 38)
        Me.btnClose.TabIndex = 5
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
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvNotificationLst)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpHead)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(1043, 485)
        Me.SplitContainer1.SplitterDistance = 456
        Me.SplitContainer1.TabIndex = 19
        '
        'dgvNotificationLst
        '
        Me.dgvNotificationLst.AllowUserToAddRows = False
        Me.dgvNotificationLst.AllowUserToDeleteRows = False
        Me.dgvNotificationLst.AllowUserToOrderColumns = True
        Me.dgvNotificationLst.AllowUserToResizeRows = False
        Me.dgvNotificationLst.BackgroundColor = System.Drawing.Color.Black
        Me.dgvNotificationLst.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotificationLst.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotificationLst.ColumnHeadersHeight = 30
        Me.dgvNotificationLst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvNotificationLst.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvNotificationLstHostName, Me.coldgvNotificationLstINSTANCEID, Me.coldgvNotificationLstSender, Me.coldgvNotificationLstLevel, Me.coldgvNotificationLstUserID, Me.coldgvNotificationLstReceiver, Me.coldgvNotificationLstMessages, Me.coldgvNotificationLstIsSuccess, Me.coldgvNotificationLstError, Me.coldgvNotificationLstCollectDt})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Gulim", 8.320187!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotificationLst.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvNotificationLst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNotificationLst.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvNotificationLst.EnableHeadersVisualStyles = False
        Me.dgvNotificationLst.Font = New System.Drawing.Font("Gulim", 8.320187!)
        Me.dgvNotificationLst.GridColor = System.Drawing.Color.Gray
        Me.dgvNotificationLst.Location = New System.Drawing.Point(0, 136)
        Me.dgvNotificationLst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvNotificationLst.Name = "dgvNotificationLst"
        Me.dgvNotificationLst.RowHeadersVisible = False
        Me.dgvNotificationLst.RowHeadersWidth = 45
        Me.dgvNotificationLst.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvNotificationLst.RowTemplate.Height = 23
        Me.dgvNotificationLst.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotificationLst.Size = New System.Drawing.Size(1043, 349)
        Me.dgvNotificationLst.TabIndex = 14
        Me.dgvNotificationLst.TagValueMatchColor = System.Drawing.Color.White
        Me.dgvNotificationLst.UseTagValueMatchColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Gray
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblNotiList, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 96)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1043, 40)
        Me.TableLayoutPanel1.TabIndex = 11
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
        'lblNotiList
        '
        Me.lblNotiList.AutoSize = True
        Me.lblNotiList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNotiList.ForeColor = System.Drawing.Color.White
        Me.lblNotiList.Location = New System.Drawing.Point(43, 0)
        Me.lblNotiList.Name = "lblNotiList"
        Me.lblNotiList.Size = New System.Drawing.Size(997, 40)
        Me.lblNotiList.TabIndex = 3
        Me.lblNotiList.Text = "Notification history"
        Me.lblNotiList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpHead
        '
        Me.tlpHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tlpHead.ColumnCount = 7
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHead.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHead.Controls.Add(Me.lblUser, 4, 0)
        Me.tlpHead.Controls.Add(Me.cmbUser, 5, 0)
        Me.tlpHead.Controls.Add(Me.lblServer, 0, 0)
        Me.tlpHead.Controls.Add(Me.cmbServer, 1, 0)
        Me.tlpHead.Controls.Add(Me.lblLevel, 2, 0)
        Me.tlpHead.Controls.Add(Me.cmbLevel, 3, 0)
        Me.tlpHead.Controls.Add(Me.lblStatus, 4, 1)
        Me.tlpHead.Controls.Add(Me.cmbResults, 5, 1)
        Me.tlpHead.Controls.Add(Me.lblDuration, 0, 1)
        Me.tlpHead.Controls.Add(Me.dtpSt, 1, 1)
        Me.tlpHead.Controls.Add(Me.lblDuration2, 2, 1)
        Me.tlpHead.Controls.Add(Me.dtpEd, 3, 1)
        Me.tlpHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpHead.Font = New System.Drawing.Font("Gulim", 12.27167!)
        Me.tlpHead.Location = New System.Drawing.Point(0, 0)
        Me.tlpHead.Name = "tlpHead"
        Me.tlpHead.RowCount = 3
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpHead.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpHead.Size = New System.Drawing.Size(1043, 96)
        Me.tlpHead.TabIndex = 13
        '
        'lblUser
        '
        Me.lblUser.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblUser.FixedHeight = False
        Me.lblUser.FixedWidth = False
        Me.lblUser.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblUser.Location = New System.Drawing.Point(455, 11)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 29)
        Me.lblUser.TabIndex = 27
        Me.lblUser.Text = "F348"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbUser
        '
        Me.cmbUser.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUser.DisplayMember = "All"
        Me.cmbUser.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUser.FixedWidth = False
        Me.cmbUser.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbUser.FormattingEnabled = True
        Me.cmbUser.Items.AddRange(New Object() {"All"})
        Me.cmbUser.Location = New System.Drawing.Point(525, 16)
        Me.cmbUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbUser.Name = "cmbUser"
        Me.cmbUser.Necessary = False
        Me.cmbUser.Size = New System.Drawing.Size(150, 20)
        Me.cmbUser.StatusTip = ""
        Me.cmbUser.TabIndex = 26
        Me.cmbUser.ValueText = ""
        '
        'lblServer
        '
        Me.lblServer.BackColor = System.Drawing.Color.Transparent
        Me.lblServer.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblServer.FixedHeight = False
        Me.lblServer.FixedWidth = False
        Me.lblServer.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblServer.ForeColor = System.Drawing.Color.White
        Me.lblServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblServer.Location = New System.Drawing.Point(3, 11)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(64, 29)
        Me.lblServer.TabIndex = 23
        Me.lblServer.Text = "F033"
        Me.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbServer
        '
        Me.cmbServer.BackColor = System.Drawing.SystemColors.Window
        Me.cmbServer.DisplayMember = "All"
        Me.cmbServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServer.FixedWidth = False
        Me.cmbServer.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Location = New System.Drawing.Point(73, 16)
        Me.cmbServer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Necessary = False
        Me.cmbServer.Size = New System.Drawing.Size(150, 20)
        Me.cmbServer.StatusTip = ""
        Me.cmbServer.TabIndex = 17
        Me.cmbServer.ValueText = ""
        '
        'lblLevel
        '
        Me.lblLevel.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLevel.FixedHeight = False
        Me.lblLevel.FixedWidth = False
        Me.lblLevel.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLevel.Location = New System.Drawing.Point(229, 11)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(64, 29)
        Me.lblLevel.TabIndex = 23
        Me.lblLevel.Text = "F256"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbLevel
        '
        Me.cmbLevel.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLevel.DisplayMember = "All"
        Me.cmbLevel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLevel.FixedWidth = False
        Me.cmbLevel.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"Critical", "Warning"})
        Me.cmbLevel.Location = New System.Drawing.Point(299, 15)
        Me.cmbLevel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Necessary = False
        Me.cmbLevel.Size = New System.Drawing.Size(150, 20)
        Me.cmbLevel.StatusTip = ""
        Me.cmbLevel.TabIndex = 17
        Me.cmbLevel.ValueText = ""
        '
        'lblStatus
        '
        Me.lblStatus.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.FixedHeight = False
        Me.lblStatus.FixedWidth = False
        Me.lblStatus.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblStatus.Location = New System.Drawing.Point(455, 51)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 29)
        Me.lblStatus.TabIndex = 23
        Me.lblStatus.Text = "F247"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbResults
        '
        Me.cmbResults.BackColor = System.Drawing.SystemColors.Window
        Me.cmbResults.DisplayMember = "All"
        Me.cmbResults.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbResults.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbResults.FixedWidth = False
        Me.cmbResults.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.cmbResults.FormattingEnabled = True
        Me.cmbResults.Items.AddRange(New Object() {"All", "Success", "Error"})
        Me.cmbResults.Location = New System.Drawing.Point(525, 55)
        Me.cmbResults.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbResults.Name = "cmbResults"
        Me.cmbResults.Necessary = False
        Me.cmbResults.Size = New System.Drawing.Size(150, 20)
        Me.cmbResults.StatusTip = ""
        Me.cmbResults.TabIndex = 17
        Me.cmbResults.ValueText = ""
        '
        'lblDuration
        '
        Me.lblDuration.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration.FixedHeight = False
        Me.lblDuration.FixedWidth = False
        Me.lblDuration.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDuration.ForeColor = System.Drawing.Color.White
        Me.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDuration.Location = New System.Drawing.Point(3, 51)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(64, 29)
        Me.lblDuration.TabIndex = 25
        Me.lblDuration.Text = "F254"
        Me.lblDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpSt
        '
        Me.dtpSt.BackColor = System.Drawing.SystemColors.Window
        Me.dtpSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpSt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpSt.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSt.Location = New System.Drawing.Point(73, 54)
        Me.dtpSt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpSt.Name = "dtpSt"
        Me.dtpSt.Necessary = False
        Me.dtpSt.Size = New System.Drawing.Size(150, 22)
        Me.dtpSt.StatusTip = ""
        Me.dtpSt.TabIndex = 19
        Me.dtpSt.Value = New Date(2018, 3, 19, 15, 15, 0, 0)
        '
        'lblDuration2
        '
        Me.lblDuration2.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblDuration2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblDuration2.FixedHeight = False
        Me.lblDuration2.FixedWidth = False
        Me.lblDuration2.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblDuration2.ForeColor = System.Drawing.Color.White
        Me.lblDuration2.Location = New System.Drawing.Point(229, 51)
        Me.lblDuration2.Name = "lblDuration2"
        Me.lblDuration2.Size = New System.Drawing.Size(64, 29)
        Me.lblDuration2.TabIndex = 20
        Me.lblDuration2.Text = "~"
        Me.lblDuration2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEd
        '
        Me.dtpEd.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEd.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpEd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dtpEd.Font = New System.Drawing.Font("Gulim", 9.2638!)
        Me.dtpEd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEd.Location = New System.Drawing.Point(299, 54)
        Me.dtpEd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpEd.Name = "dtpEd"
        Me.dtpEd.Necessary = False
        Me.dtpEd.Size = New System.Drawing.Size(150, 22)
        Me.dtpEd.StatusTip = ""
        Me.dtpEd.TabIndex = 21
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnQuery, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1043, 50)
        Me.TableLayoutPanel3.TabIndex = 20
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnQuery.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnQuery.FixedHeight = False
        Me.btnQuery.FixedWidth = False
        Me.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuery.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnQuery.ForeColor = System.Drawing.Color.White
        Me.btnQuery.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnQuery.LineColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.btnQuery.Location = New System.Drawing.Point(946, 14)
        Me.btnQuery.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Radius = 5
        Me.btnQuery.Size = New System.Drawing.Size(94, 32)
        Me.btnQuery.TabIndex = 11
        Me.btnQuery.Text = "F151"
        Me.btnQuery.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnQuery.UseRound = True
        Me.btnQuery.UseVisualStyleBackColor = True
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
        Me.MsgLabel.Size = New System.Drawing.Size(897, 50)
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
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERVER_NAME"
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn1.HeaderText = "F010"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "INSTANCE_ID"
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn2.HeaderText = "F019"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SENDER"
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn3.HeaderText = "F008"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EXPORT_LEVEL"
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn4.HeaderText = "F006"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "USER_NAME"
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn5.HeaderText = "F007"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RECIEVER"
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn6.HeaderText = "F020"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MESSAGES"
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn7.HeaderText = "F260"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 220
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 220
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ISSUCCESS"
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn8.HeaderText = "F247"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 70
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 70
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ERROR"
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn9.HeaderText = "F258"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "COLLECT_DT"
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn10.HeaderText = "F257"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'coldgvNotificationLstHostName
        '
        Me.coldgvNotificationLstHostName.DataPropertyName = "SERVER_NAME"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstHostName.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvNotificationLstHostName.HeaderText = "F033"
        Me.coldgvNotificationLstHostName.MinimumWidth = 100
        Me.coldgvNotificationLstHostName.Name = "coldgvNotificationLstHostName"
        Me.coldgvNotificationLstHostName.ReadOnly = True
        '
        'coldgvNotificationLstINSTANCEID
        '
        Me.coldgvNotificationLstINSTANCEID.DataPropertyName = "INSTANCE_ID"
        Me.coldgvNotificationLstINSTANCEID.HeaderText = "coldgvAlertINSTANCEID"
        Me.coldgvNotificationLstINSTANCEID.Name = "coldgvNotificationLstINSTANCEID"
        Me.coldgvNotificationLstINSTANCEID.ReadOnly = True
        Me.coldgvNotificationLstINSTANCEID.Visible = False
        '
        'coldgvNotificationLstSender
        '
        Me.coldgvNotificationLstSender.DataPropertyName = "SENDER"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstSender.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvNotificationLstSender.HeaderText = "F354"
        Me.coldgvNotificationLstSender.MinimumWidth = 100
        Me.coldgvNotificationLstSender.Name = "coldgvNotificationLstSender"
        Me.coldgvNotificationLstSender.ReadOnly = True
        '
        'coldgvNotificationLstLevel
        '
        Me.coldgvNotificationLstLevel.DataPropertyName = "EXPORT_LEVEL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstLevel.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvNotificationLstLevel.HeaderText = "F247"
        Me.coldgvNotificationLstLevel.MinimumWidth = 80
        Me.coldgvNotificationLstLevel.Name = "coldgvNotificationLstLevel"
        Me.coldgvNotificationLstLevel.ReadOnly = True
        Me.coldgvNotificationLstLevel.Width = 80
        '
        'coldgvNotificationLstUserID
        '
        Me.coldgvNotificationLstUserID.DataPropertyName = "USER_NAME"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstUserID.DefaultCellStyle = DataGridViewCellStyle5
        Me.coldgvNotificationLstUserID.HeaderText = "F348"
        Me.coldgvNotificationLstUserID.MinimumWidth = 80
        Me.coldgvNotificationLstUserID.Name = "coldgvNotificationLstUserID"
        Me.coldgvNotificationLstUserID.ReadOnly = True
        Me.coldgvNotificationLstUserID.Width = 80
        '
        'coldgvNotificationLstReceiver
        '
        Me.coldgvNotificationLstReceiver.DataPropertyName = "RECIEVER"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstReceiver.DefaultCellStyle = DataGridViewCellStyle6
        Me.coldgvNotificationLstReceiver.HeaderText = "F355"
        Me.coldgvNotificationLstReceiver.MinimumWidth = 100
        Me.coldgvNotificationLstReceiver.Name = "coldgvNotificationLstReceiver"
        Me.coldgvNotificationLstReceiver.ReadOnly = True
        '
        'coldgvNotificationLstMessages
        '
        Me.coldgvNotificationLstMessages.DataPropertyName = "MESSAGES"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstMessages.DefaultCellStyle = DataGridViewCellStyle7
        Me.coldgvNotificationLstMessages.HeaderText = "F260"
        Me.coldgvNotificationLstMessages.MinimumWidth = 220
        Me.coldgvNotificationLstMessages.Name = "coldgvNotificationLstMessages"
        Me.coldgvNotificationLstMessages.ReadOnly = True
        Me.coldgvNotificationLstMessages.Width = 220
        '
        'coldgvNotificationLstIsSuccess
        '
        Me.coldgvNotificationLstIsSuccess.DataPropertyName = "ISSUCCESS"
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstIsSuccess.DefaultCellStyle = DataGridViewCellStyle8
        Me.coldgvNotificationLstIsSuccess.HeaderText = "F247"
        Me.coldgvNotificationLstIsSuccess.MinimumWidth = 70
        Me.coldgvNotificationLstIsSuccess.Name = "coldgvNotificationLstIsSuccess"
        Me.coldgvNotificationLstIsSuccess.ReadOnly = True
        Me.coldgvNotificationLstIsSuccess.Width = 70
        '
        'coldgvNotificationLstError
        '
        Me.coldgvNotificationLstError.DataPropertyName = "ERROR"
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstError.DefaultCellStyle = DataGridViewCellStyle9
        Me.coldgvNotificationLstError.HeaderText = "F258"
        Me.coldgvNotificationLstError.MinimumWidth = 200
        Me.coldgvNotificationLstError.Name = "coldgvNotificationLstError"
        Me.coldgvNotificationLstError.ReadOnly = True
        Me.coldgvNotificationLstError.Width = 200
        '
        'coldgvNotificationLstCollectDt
        '
        Me.coldgvNotificationLstCollectDt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvNotificationLstCollectDt.DataPropertyName = "COLLECT_DT"
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Format = "yyyy-MM-dd HH:mm:ss"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.coldgvNotificationLstCollectDt.DefaultCellStyle = DataGridViewCellStyle10
        Me.coldgvNotificationLstCollectDt.HeaderText = "F257"
        Me.coldgvNotificationLstCollectDt.MinimumWidth = 150
        Me.coldgvNotificationLstCollectDt.Name = "coldgvNotificationLstCollectDt"
        Me.coldgvNotificationLstCollectDt.ReadOnly = True
        '
        'DataGridViewPasswordTextBoxColumn1
        '
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewPasswordTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewPasswordTextBoxColumn1.HeaderText = "F009"
        Me.DataGridViewPasswordTextBoxColumn1.Name = "DataGridViewPasswordTextBoxColumn1"
        Me.DataGridViewPasswordTextBoxColumn1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DataGridViewPasswordTextBoxColumn1.ReadOnly = True
        Me.DataGridViewPasswordTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewPasswordTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewPasswordTextBoxColumn1.UseSystemPasswordChar = True
        '
        'frmNotiHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1047, 583)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.pnlB)
        Me.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNotiHistory"
        Me.Padding = New System.Windows.Forms.Padding(2)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Management"
        Me.pnlB.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvNotificationLst, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpHead.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewPasswordTextBoxColumn1 As eXperDB.Controls.DataGridViewPasswordTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlB As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNotiList As System.Windows.Forms.Label
    Friend WithEvents ttChart As System.Windows.Forms.ToolTip
    Friend WithEvents tlpHead As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblServer As eXperDB.BaseControls.Label
    Friend WithEvents cmbServer As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblLevel As eXperDB.BaseControls.Label
    Friend WithEvents cmbLevel As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblStatus As eXperDB.BaseControls.Label
    Friend WithEvents cmbResults As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblDuration As eXperDB.BaseControls.Label
    Friend WithEvents dtpSt As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblDuration2 As eXperDB.BaseControls.Label
    Friend WithEvents dtpEd As eXperDB.BaseControls.DateTimePicker
    Friend WithEvents lblUser As eXperDB.BaseControls.Label
    Friend WithEvents cmbUser As eXperDB.BaseControls.ComboBox
    Friend WithEvents btnQuery As eXperDB.BaseControls.Button
    Friend WithEvents dgvNotificationLst As eXperDB.BaseControls.DataGridView
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents coldgvNotificationLstHostName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstINSTANCEID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstSender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstLevel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstUserID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstReceiver As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstMessages As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstIsSuccess As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstError As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvNotificationLstCollectDt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
