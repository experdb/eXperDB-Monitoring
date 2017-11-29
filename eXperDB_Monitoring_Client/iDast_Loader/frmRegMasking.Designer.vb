<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegMasking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegMasking))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabMainCTL = New DX.Controls.ClsTabCtlNoHeader()
        Me.TabNormalMask = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MappingCBX = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EndPosStrCBX = New System.Windows.Forms.ComboBox()
        Me.StartPosStrCBX = New System.Windows.Forms.ComboBox()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.ReplaceCharCBX = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStripContainer4 = New System.Windows.Forms.ToolStripContainer()
        Me.MaskListGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.RemoveBTN = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer3 = New System.Windows.Forms.ToolStripContainer()
        Me.ColInfoGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.ResultDataWB = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.LinesCBX = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Cancel_BTN = New System.Windows.Forms.Button()
        Me.SaveBTN = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.MaskingTypCBX = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabMainCTL.SuspendLayout()
        Me.TabNormalMask.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStripContainer4.ContentPanel.SuspendLayout()
        Me.ToolStripContainer4.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer4.SuspendLayout()
        CType(Me.MaskListGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ToolStripContainer3.ContentPanel.SuspendLayout()
        Me.ToolStripContainer3.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer3.SuspendLayout()
        CType(Me.ColInfoGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(776, 447)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(776, 472)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TabMainCTL)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Cancel_BTN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SaveBTN)
        Me.SplitContainer1.Size = New System.Drawing.Size(776, 447)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 1
        '
        'TabMainCTL
        '
        Me.TabMainCTL.Controls.Add(Me.TabNormalMask)
        Me.TabMainCTL.Controls.Add(Me.TabPage2)
        Me.TabMainCTL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabMainCTL.Location = New System.Drawing.Point(0, 0)
        Me.TabMainCTL.Name = "TabMainCTL"
        Me.TabMainCTL.SelectedIndex = 0
        Me.TabMainCTL.SimpleMode = False
        Me.TabMainCTL.SimpleModeInDesign = False
        Me.TabMainCTL.Size = New System.Drawing.Size(776, 409)
        Me.TabMainCTL.TabIndex = 0
        '
        'TabNormalMask
        '
        Me.TabNormalMask.BackColor = System.Drawing.SystemColors.Control
        Me.TabNormalMask.Controls.Add(Me.SplitContainer2)
        Me.TabNormalMask.Location = New System.Drawing.Point(4, 22)
        Me.TabNormalMask.Name = "TabNormalMask"
        Me.TabNormalMask.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNormalMask.Size = New System.Drawing.Size(768, 383)
        Me.TabNormalMask.TabIndex = 0
        Me.TabNormalMask.Text = "TabNormalMask"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer2.Size = New System.Drawing.Size(762, 377)
        Me.SplitContainer2.SplitterDistance = 189
        Me.SplitContainer2.TabIndex = 1
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.ToolStripContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(762, 189)
        Me.SplitContainer3.SplitterDistance = 332
        Me.SplitContainer3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MappingCBX)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.EndPosStrCBX)
        Me.GroupBox1.Controls.Add(Me.StartPosStrCBX)
        Me.GroupBox1.Controls.Add(Me.AddBTN)
        Me.GroupBox1.Controls.Add(Me.ReplaceCharCBX)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(332, 189)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseCompatibleTextRendering = True
        '
        'MappingCBX
        '
        Me.MappingCBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MappingCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MappingCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MappingCBX.FormattingEnabled = True
        Me.MappingCBX.Items.AddRange(New Object() {"FIXED", "DATE(MMDD)", "DATE(MM/DD)", "DATE(MM-DD)", "DATE(DDMM)", "DATE(DD/MM)", "DATE(DD-MM)"})
        Me.MappingCBX.Location = New System.Drawing.Point(141, 56)
        Me.MappingCBX.Name = "MappingCBX"
        Me.MappingCBX.Size = New System.Drawing.Size(121, 20)
        Me.MappingCBX.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mapping Format"
        '
        'EndPosStrCBX
        '
        Me.EndPosStrCBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EndPosStrCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EndPosStrCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EndPosStrCBX.FormattingEnabled = True
        Me.EndPosStrCBX.Items.AddRange(New Object() {"*", "$", "!", "#"})
        Me.EndPosStrCBX.Location = New System.Drawing.Point(141, 125)
        Me.EndPosStrCBX.Name = "EndPosStrCBX"
        Me.EndPosStrCBX.Size = New System.Drawing.Size(121, 20)
        Me.EndPosStrCBX.TabIndex = 9
        '
        'StartPosStrCBX
        '
        Me.StartPosStrCBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.StartPosStrCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StartPosStrCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartPosStrCBX.FormattingEnabled = True
        Me.StartPosStrCBX.Items.AddRange(New Object() {"*", "$", "!", "#"})
        Me.StartPosStrCBX.Location = New System.Drawing.Point(141, 91)
        Me.StartPosStrCBX.Name = "StartPosStrCBX"
        Me.StartPosStrCBX.Size = New System.Drawing.Size(121, 20)
        Me.StartPosStrCBX.TabIndex = 8
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(188, 158)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(75, 23)
        Me.AddBTN.TabIndex = 7
        Me.AddBTN.Text = "Add"
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'ReplaceCharCBX
        '
        Me.ReplaceCharCBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReplaceCharCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReplaceCharCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReplaceCharCBX.FormattingEnabled = True
        Me.ReplaceCharCBX.Items.AddRange(New Object() {"*", "$", "!", "#"})
        Me.ReplaceCharCBX.Location = New System.Drawing.Point(141, 20)
        Me.ReplaceCharCBX.Name = "ReplaceCharCBX"
        Me.ReplaceCharCBX.Size = New System.Drawing.Size(121, 20)
        Me.ReplaceCharCBX.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Replace Character"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start Position"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "End Position"
        '
        'ToolStripContainer4
        '
        '
        'ToolStripContainer4.ContentPanel
        '
        Me.ToolStripContainer4.ContentPanel.Controls.Add(Me.MaskListGV)
        Me.ToolStripContainer4.ContentPanel.Size = New System.Drawing.Size(426, 164)
        Me.ToolStripContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer4.Name = "ToolStripContainer4"
        Me.ToolStripContainer4.Size = New System.Drawing.Size(426, 189)
        Me.ToolStripContainer4.TabIndex = 7
        Me.ToolStripContainer4.Text = "ToolStripContainer4"
        '
        'ToolStripContainer4.TopToolStripPanel
        '
        Me.ToolStripContainer4.TopToolStripPanel.Controls.Add(Me.ToolStrip4)
        '
        'MaskListGV
        '
        Me.MaskListGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaskListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaskListGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MaskListGV.Location = New System.Drawing.Point(0, 0)
        Me.MaskListGV.Name = "MaskListGV"
        Me.MaskListGV.RowTemplate.Height = 23
        Me.MaskListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MaskListGV.Size = New System.Drawing.Size(426, 164)
        Me.MaskListGV.TabIndex = 6
        '
        'ToolStrip4
        '
        Me.ToolStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5, Me.RemoveBTN})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(426, 25)
        Me.ToolStrip4.Stretch = True
        Me.ToolStrip4.TabIndex = 0
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel5.Text = "Masking List"
        '
        'RemoveBTN
        '
        Me.RemoveBTN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.RemoveBTN.Image = CType(resources.GetObject("RemoveBTN.Image"), System.Drawing.Image)
        Me.RemoveBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveBTN.Name = "RemoveBTN"
        Me.RemoveBTN.Size = New System.Drawing.Size(70, 22)
        Me.RemoveBTN.Text = "Remove"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.ToolStripContainer3)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ToolStripContainer2)
        Me.SplitContainer4.Size = New System.Drawing.Size(762, 184)
        Me.SplitContainer4.SplitterDistance = 432
        Me.SplitContainer4.TabIndex = 0
        '
        'ToolStripContainer3
        '
        '
        'ToolStripContainer3.ContentPanel
        '
        Me.ToolStripContainer3.ContentPanel.Controls.Add(Me.ColInfoGV)
        Me.ToolStripContainer3.ContentPanel.Size = New System.Drawing.Size(432, 159)
        Me.ToolStripContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer3.Name = "ToolStripContainer3"
        Me.ToolStripContainer3.Size = New System.Drawing.Size(432, 184)
        Me.ToolStripContainer3.TabIndex = 0
        Me.ToolStripContainer3.Text = "ToolStripContainer3"
        '
        'ToolStripContainer3.TopToolStripPanel
        '
        Me.ToolStripContainer3.TopToolStripPanel.Controls.Add(Me.ToolStrip3)
        '
        'ColInfoGV
        '
        Me.ColInfoGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ColInfoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColInfoGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColInfoGV.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.ColInfoGV.Location = New System.Drawing.Point(0, 0)
        Me.ColInfoGV.Name = "ColInfoGV"
        Me.ColInfoGV.RowTemplate.Height = 23
        Me.ColInfoGV.Size = New System.Drawing.Size(432, 159)
        Me.ColInfoGV.TabIndex = 0
        '
        'ToolStrip3
        '
        Me.ToolStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(432, 25)
        Me.ToolStrip3.Stretch = True
        Me.ToolStrip3.TabIndex = 0
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripLabel2.Text = "Column Infomation"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.ResultDataWB)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(326, 159)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(326, 184)
        Me.ToolStripContainer2.TabIndex = 0
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip2)
        '
        'ResultDataWB
        '
        Me.ResultDataWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultDataWB.Location = New System.Drawing.Point(0, 0)
        Me.ResultDataWB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ResultDataWB.Name = "ResultDataWB"
        Me.ResultDataWB.Size = New System.Drawing.Size(326, 159)
        Me.ResultDataWB.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.LinesCBX, Me.ToolStripLabel4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(326, 25)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 0
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel3.Text = "Sample Data"
        '
        'LinesCBX
        '
        Me.LinesCBX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LinesCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LinesCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LinesCBX.Items.AddRange(New Object() {"10", "100", "1000"})
        Me.LinesCBX.Name = "LinesCBX"
        Me.LinesCBX.Size = New System.Drawing.Size(75, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel4.Text = "Lines"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(768, 382)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Cancel_BTN
        '
        Me.Cancel_BTN.Location = New System.Drawing.Point(576, 5)
        Me.Cancel_BTN.Name = "Cancel_BTN"
        Me.Cancel_BTN.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_BTN.TabIndex = 1
        Me.Cancel_BTN.Text = "CANCEL"
        Me.Cancel_BTN.UseVisualStyleBackColor = True
        '
        'SaveBTN
        '
        Me.SaveBTN.Location = New System.Drawing.Point(495, 5)
        Me.SaveBTN.Name = "SaveBTN"
        Me.SaveBTN.Size = New System.Drawing.Size(75, 23)
        Me.SaveBTN.TabIndex = 0
        Me.SaveBTN.Text = "SAVE"
        Me.SaveBTN.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.MaskingTypCBX})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(776, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(90, 22)
        Me.ToolStripLabel1.Text = "MASKING TYPE"
        '
        'MaskingTypCBX
        '
        Me.MaskingTypCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaskingTypCBX.Items.AddRange(New Object() {"NONE", "NORMAL", "SWITCH", "MAPPING", "REPLACE_FIXED"})
        Me.MaskingTypCBX.Name = "MaskingTypCBX"
        Me.MaskingTypCBX.Size = New System.Drawing.Size(121, 25)
        '
        'frmRegMasking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 472)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "frmRegMasking"
        Me.Text = "Register Masking Function"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabMainCTL.ResumeLayout(False)
        Me.TabNormalMask.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStripContainer4.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer4.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer4.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer4.ResumeLayout(False)
        Me.ToolStripContainer4.PerformLayout()
        CType(Me.MaskListGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ToolStripContainer3.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer3.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer3.ResumeLayout(False)
        Me.ToolStripContainer3.PerformLayout()
        CType(Me.ColInfoGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabMainCTL As DX.Controls.ClsTabCtlNoHeader
    Friend WithEvents TabNormalMask As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ReplaceCharCBX As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Cancel_BTN As System.Windows.Forms.Button
    Friend WithEvents SaveBTN As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MaskingTypCBX As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AddBTN As System.Windows.Forms.Button
    Friend WithEvents MaskListGV As System.Windows.Forms.DataGridView
    Friend WithEvents ResultDataWB As System.Windows.Forms.WebBrowser
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripContainer4 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripContainer3 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ColInfoGV As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LinesCBX As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents RemoveBTN As System.Windows.Forms.ToolStripButton
    Friend WithEvents EndPosStrCBX As System.Windows.Forms.ComboBox
    Friend WithEvents StartPosStrCBX As System.Windows.Forms.ComboBox
    Friend WithEvents MappingCBX As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
