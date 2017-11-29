Imports DX.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaderReg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoaderReg))
        Me.BackBTN = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabCtlCustom = New DX.Controls.ClsTabCtlNoHeader()
        Me.TabLoadFile = New System.Windows.Forms.TabPage()
        Me.GrpExcelSheet = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ExcelSheetCBX = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtFileRTB = New System.Windows.Forms.RichTextBox()
        Me.GrpFileType = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExcelFileTypRB = New System.Windows.Forms.RadioButton()
        Me.TxtFileTypRB = New System.Windows.Forms.RadioButton()
        Me.GrpAddFile = New System.Windows.Forms.GroupBox()
        Me.AddFileBTN = New System.Windows.Forms.Button()
        Me.FileNameTBX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabLoadSetting = New System.Windows.Forms.TabPage()
        Me.GrpOrgTxt = New System.Windows.Forms.GroupBox()
        Me.OrgTxtTlsRTB = New System.Windows.Forms.RichTextBox()
        Me.GrpCD = New System.Windows.Forms.GroupBox()
        Me.CdUserInputTBX = New System.Windows.Forms.TextBox()
        Me.CdUserInputRB = New System.Windows.Forms.RadioButton()
        Me.CdPipeRB = New System.Windows.Forms.RadioButton()
        Me.CdCommaRB = New System.Windows.Forms.RadioButton()
        Me.CdTabRB = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CdSpaceRB = New System.Windows.Forms.RadioButton()
        Me.GrpLT = New System.Windows.Forms.GroupBox()
        Me.LtUserInputTBX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LtUserInputRB = New System.Windows.Forms.RadioButton()
        Me.LtCrRB = New System.Windows.Forms.RadioButton()
        Me.TabTblSetting = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ColInfoGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.GrpDbConn = New System.Windows.Forms.GroupBox()
        Me.TblListGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.TblNmTBX = New System.Windows.Forms.ToolStripTextBox()
        Me.TabColMapping = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.MappingColGV = New System.Windows.Forms.DataGridView()
        Me.ToolStrip5 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.TableNmTBX = New System.Windows.Forms.ToolStripTextBox()
        Me.TabOptions = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LogMsgRTB = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GrpLoadMethod = New System.Windows.Forms.GroupBox()
        Me.ParallelCntCBX = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FetchCntCBX = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BulkLoadRB = New System.Windows.Forms.RadioButton()
        Me.ConventRB = New System.Windows.Forms.RadioButton()
        Me.TabFinal = New System.Windows.Forms.TabPage()
        Me.TabResultCTL = New System.Windows.Forms.TabControl()
        Me.TabResult = New System.Windows.Forms.TabPage()
        Me.GrpResultData = New System.Windows.Forms.GroupBox()
        Me.ResultDataWB = New System.Windows.Forms.WebBrowser()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.OrgLinesCBX = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.OrgRowCntLB = New System.Windows.Forms.ToolStripLabel()
        Me.TabModSampleData = New System.Windows.Forms.TabPage()
        Me.GrpModData = New System.Windows.Forms.GroupBox()
        Me.ResultModDataWB = New System.Windows.Forms.WebBrowser()
        Me.ToolStript2 = New System.Windows.Forms.ToolStrip()
        Me.ModLinesCBX = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ModRowCntLB = New System.Windows.Forms.ToolStripLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusLB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExecBTN = New System.Windows.Forms.Button()
        Me.CloseBTN = New System.Windows.Forms.Button()
        Me.NextBTN = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.LoadRegMainTS = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.DbConnBTN = New System.Windows.Forms.ToolStripButton()
        Me.DbEndConnBTN = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabCtlCustom.SuspendLayout()
        Me.TabLoadFile.SuspendLayout()
        Me.GrpExcelSheet.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrpFileType.SuspendLayout()
        Me.GrpAddFile.SuspendLayout()
        Me.TabLoadSetting.SuspendLayout()
        Me.GrpOrgTxt.SuspendLayout()
        Me.GrpCD.SuspendLayout()
        Me.GrpLT.SuspendLayout()
        Me.TabTblSetting.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ColInfoGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip4.SuspendLayout()
        Me.GrpDbConn.SuspendLayout()
        CType(Me.TblListGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabColMapping.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        CType(Me.MappingColGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip5.SuspendLayout()
        Me.TabOptions.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GrpLoadMethod.SuspendLayout()
        Me.TabResultCTL.SuspendLayout()
        Me.TabResult.SuspendLayout()
        Me.GrpResultData.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabModSampleData.SuspendLayout()
        Me.GrpModData.SuspendLayout()
        Me.ToolStript2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.LoadRegMainTS.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackBTN
        '
        Me.BackBTN.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BackBTN.Location = New System.Drawing.Point(88, 3)
        Me.BackBTN.Name = "BackBTN"
        Me.BackBTN.Size = New System.Drawing.Size(75, 23)
        Me.BackBTN.TabIndex = 0
        Me.BackBTN.Text = "< Back"
        Me.BackBTN.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(979, 710)
        Me.SplitContainer1.SplitterDistance = 680
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TabCtlCustom)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabResultCTL)
        Me.SplitContainer2.Size = New System.Drawing.Size(979, 680)
        Me.SplitContainer2.SplitterDistance = 219
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 4
        '
        'TabCtlCustom
        '
        Me.TabCtlCustom.Controls.Add(Me.TabLoadFile)
        Me.TabCtlCustom.Controls.Add(Me.TabLoadSetting)
        Me.TabCtlCustom.Controls.Add(Me.TabTblSetting)
        Me.TabCtlCustom.Controls.Add(Me.TabColMapping)
        Me.TabCtlCustom.Controls.Add(Me.TabOptions)
        Me.TabCtlCustom.Controls.Add(Me.TabFinal)
        Me.TabCtlCustom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCtlCustom.Location = New System.Drawing.Point(0, 0)
        Me.TabCtlCustom.Name = "TabCtlCustom"
        Me.TabCtlCustom.SelectedIndex = 0
        Me.TabCtlCustom.SimpleMode = False
        Me.TabCtlCustom.SimpleModeInDesign = True
        Me.TabCtlCustom.Size = New System.Drawing.Size(979, 219)
        Me.TabCtlCustom.TabIndex = 1
        '
        'TabLoadFile
        '
        Me.TabLoadFile.BackColor = System.Drawing.SystemColors.Control
        Me.TabLoadFile.Controls.Add(Me.GrpExcelSheet)
        Me.TabLoadFile.Controls.Add(Me.GroupBox2)
        Me.TabLoadFile.Controls.Add(Me.GrpFileType)
        Me.TabLoadFile.Controls.Add(Me.GrpAddFile)
        Me.TabLoadFile.Location = New System.Drawing.Point(4, 22)
        Me.TabLoadFile.Name = "TabLoadFile"
        Me.TabLoadFile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLoadFile.Size = New System.Drawing.Size(971, 193)
        Me.TabLoadFile.TabIndex = 0
        Me.TabLoadFile.Text = "TabLoadFile"
        '
        'GrpExcelSheet
        '
        Me.GrpExcelSheet.Controls.Add(Me.Label9)
        Me.GrpExcelSheet.Controls.Add(Me.Label8)
        Me.GrpExcelSheet.Controls.Add(Me.ExcelSheetCBX)
        Me.GrpExcelSheet.Location = New System.Drawing.Point(491, 133)
        Me.GrpExcelSheet.Name = "GrpExcelSheet"
        Me.GrpExcelSheet.Size = New System.Drawing.Size(474, 100)
        Me.GrpExcelSheet.TabIndex = 4
        Me.GrpExcelSheet.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 12)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Select Excel Sheet"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 12)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Sheet Name"
        '
        'ExcelSheetCBX
        '
        Me.ExcelSheetCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExcelSheetCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExcelSheetCBX.FormattingEnabled = True
        Me.ExcelSheetCBX.Location = New System.Drawing.Point(110, 45)
        Me.ExcelSheetCBX.Name = "ExcelSheetCBX"
        Me.ExcelSheetCBX.Size = New System.Drawing.Size(324, 20)
        Me.ExcelSheetCBX.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.TxtFileRTB)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(954, 353)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File Contents"
        '
        'TxtFileRTB
        '
        Me.TxtFileRTB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtFileRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtFileRTB.Location = New System.Drawing.Point(3, 17)
        Me.TxtFileRTB.Name = "TxtFileRTB"
        Me.TxtFileRTB.ReadOnly = True
        Me.TxtFileRTB.Size = New System.Drawing.Size(948, 333)
        Me.TxtFileRTB.TabIndex = 2
        Me.TxtFileRTB.Text = ""
        Me.TxtFileRTB.WordWrap = False
        '
        'GrpFileType
        '
        Me.GrpFileType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpFileType.Controls.Add(Me.Label1)
        Me.GrpFileType.Controls.Add(Me.ExcelFileTypRB)
        Me.GrpFileType.Controls.Add(Me.TxtFileTypRB)
        Me.GrpFileType.Location = New System.Drawing.Point(9, 6)
        Me.GrpFileType.Name = "GrpFileType"
        Me.GrpFileType.Size = New System.Drawing.Size(956, 120)
        Me.GrpFileType.TabIndex = 0
        Me.GrpFileType.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select a File Type"
        '
        'ExcelFileTypRB
        '
        Me.ExcelFileTypRB.AutoSize = True
        Me.ExcelFileTypRB.Location = New System.Drawing.Point(7, 80)
        Me.ExcelFileTypRB.Name = "ExcelFileTypRB"
        Me.ExcelFileTypRB.Size = New System.Drawing.Size(79, 16)
        Me.ExcelFileTypRB.TabIndex = 1
        Me.ExcelFileTypRB.TabStop = True
        Me.ExcelFileTypRB.Text = "Excel File"
        Me.ExcelFileTypRB.UseVisualStyleBackColor = True
        '
        'TxtFileTypRB
        '
        Me.TxtFileTypRB.AutoSize = True
        Me.TxtFileTypRB.Location = New System.Drawing.Point(7, 48)
        Me.TxtFileTypRB.Name = "TxtFileTypRB"
        Me.TxtFileTypRB.Size = New System.Drawing.Size(72, 16)
        Me.TxtFileTypRB.TabIndex = 0
        Me.TxtFileTypRB.TabStop = True
        Me.TxtFileTypRB.Text = "Text File"
        Me.TxtFileTypRB.UseVisualStyleBackColor = True
        '
        'GrpAddFile
        '
        Me.GrpAddFile.Controls.Add(Me.AddFileBTN)
        Me.GrpAddFile.Controls.Add(Me.FileNameTBX)
        Me.GrpAddFile.Controls.Add(Me.Label2)
        Me.GrpAddFile.Location = New System.Drawing.Point(9, 132)
        Me.GrpAddFile.Name = "GrpAddFile"
        Me.GrpAddFile.Size = New System.Drawing.Size(476, 102)
        Me.GrpAddFile.TabIndex = 1
        Me.GrpAddFile.TabStop = False
        '
        'AddFileBTN
        '
        Me.AddFileBTN.Location = New System.Drawing.Point(431, 46)
        Me.AddFileBTN.Name = "AddFileBTN"
        Me.AddFileBTN.Size = New System.Drawing.Size(27, 23)
        Me.AddFileBTN.TabIndex = 5
        Me.AddFileBTN.Text = "..."
        Me.AddFileBTN.UseVisualStyleBackColor = True
        '
        'FileNameTBX
        '
        Me.FileNameTBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.FileNameTBX.Location = New System.Drawing.Point(7, 47)
        Me.FileNameTBX.Name = "FileNameTBX"
        Me.FileNameTBX.ReadOnly = True
        Me.FileNameTBX.Size = New System.Drawing.Size(418, 21)
        Me.FileNameTBX.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Add Input File"
        '
        'TabLoadSetting
        '
        Me.TabLoadSetting.BackColor = System.Drawing.SystemColors.Menu
        Me.TabLoadSetting.Controls.Add(Me.GrpOrgTxt)
        Me.TabLoadSetting.Controls.Add(Me.GrpCD)
        Me.TabLoadSetting.Controls.Add(Me.GrpLT)
        Me.TabLoadSetting.Location = New System.Drawing.Point(4, 22)
        Me.TabLoadSetting.Name = "TabLoadSetting"
        Me.TabLoadSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLoadSetting.Size = New System.Drawing.Size(971, 193)
        Me.TabLoadSetting.TabIndex = 1
        Me.TabLoadSetting.Text = "TabLoadSetting"
        '
        'GrpOrgTxt
        '
        Me.GrpOrgTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpOrgTxt.Controls.Add(Me.OrgTxtTlsRTB)
        Me.GrpOrgTxt.Location = New System.Drawing.Point(407, 7)
        Me.GrpOrgTxt.Name = "GrpOrgTxt"
        Me.GrpOrgTxt.Size = New System.Drawing.Size(558, 240)
        Me.GrpOrgTxt.TabIndex = 2
        Me.GrpOrgTxt.TabStop = False
        Me.GrpOrgTxt.Text = "Original File Contents"
        '
        'OrgTxtTlsRTB
        '
        Me.OrgTxtTlsRTB.BackColor = System.Drawing.SystemColors.Window
        Me.OrgTxtTlsRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrgTxtTlsRTB.Location = New System.Drawing.Point(3, 17)
        Me.OrgTxtTlsRTB.Name = "OrgTxtTlsRTB"
        Me.OrgTxtTlsRTB.ReadOnly = True
        Me.OrgTxtTlsRTB.Size = New System.Drawing.Size(552, 220)
        Me.OrgTxtTlsRTB.TabIndex = 0
        Me.OrgTxtTlsRTB.Text = ""
        Me.OrgTxtTlsRTB.WordWrap = False
        '
        'GrpCD
        '
        Me.GrpCD.Controls.Add(Me.CdUserInputTBX)
        Me.GrpCD.Controls.Add(Me.CdUserInputRB)
        Me.GrpCD.Controls.Add(Me.CdPipeRB)
        Me.GrpCD.Controls.Add(Me.CdCommaRB)
        Me.GrpCD.Controls.Add(Me.CdTabRB)
        Me.GrpCD.Controls.Add(Me.Label4)
        Me.GrpCD.Controls.Add(Me.CdSpaceRB)
        Me.GrpCD.Location = New System.Drawing.Point(6, 6)
        Me.GrpCD.Name = "GrpCD"
        Me.GrpCD.Size = New System.Drawing.Size(193, 237)
        Me.GrpCD.TabIndex = 1
        Me.GrpCD.TabStop = False
        Me.GrpCD.Text = "Column Delimiter"
        '
        'CdUserInputTBX
        '
        Me.CdUserInputTBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CdUserInputTBX.Location = New System.Drawing.Point(22, 165)
        Me.CdUserInputTBX.Name = "CdUserInputTBX"
        Me.CdUserInputTBX.Size = New System.Drawing.Size(143, 21)
        Me.CdUserInputTBX.TabIndex = 5
        '
        'CdUserInputRB
        '
        Me.CdUserInputRB.AutoSize = True
        Me.CdUserInputRB.Location = New System.Drawing.Point(6, 145)
        Me.CdUserInputRB.Name = "CdUserInputRB"
        Me.CdUserInputRB.Size = New System.Drawing.Size(80, 16)
        Me.CdUserInputRB.TabIndex = 4
        Me.CdUserInputRB.TabStop = True
        Me.CdUserInputRB.Text = "User Input"
        Me.CdUserInputRB.UseVisualStyleBackColor = True
        '
        'CdPipeRB
        '
        Me.CdPipeRB.AutoSize = True
        Me.CdPipeRB.Location = New System.Drawing.Point(6, 120)
        Me.CdPipeRB.Name = "CdPipeRB"
        Me.CdPipeRB.Size = New System.Drawing.Size(64, 16)
        Me.CdPipeRB.TabIndex = 8
        Me.CdPipeRB.TabStop = True
        Me.CdPipeRB.Text = "Pipe(|)"
        Me.CdPipeRB.UseVisualStyleBackColor = True
        '
        'CdCommaRB
        '
        Me.CdCommaRB.AutoSize = True
        Me.CdCommaRB.Location = New System.Drawing.Point(6, 95)
        Me.CdCommaRB.Name = "CdCommaRB"
        Me.CdCommaRB.Size = New System.Drawing.Size(82, 16)
        Me.CdCommaRB.TabIndex = 7
        Me.CdCommaRB.TabStop = True
        Me.CdCommaRB.Text = "Comma(,)"
        Me.CdCommaRB.UseVisualStyleBackColor = True
        '
        'CdTabRB
        '
        Me.CdTabRB.AutoSize = True
        Me.CdTabRB.Location = New System.Drawing.Point(6, 70)
        Me.CdTabRB.Name = "CdTabRB"
        Me.CdTabRB.Size = New System.Drawing.Size(69, 16)
        Me.CdTabRB.TabIndex = 6
        Me.CdTabRB.TabStop = True
        Me.CdTabRB.Text = "Tab(\t)"
        Me.CdTabRB.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Select Column Delimiter"
        '
        'CdSpaceRB
        '
        Me.CdSpaceRB.AutoSize = True
        Me.CdSpaceRB.Location = New System.Drawing.Point(6, 45)
        Me.CdSpaceRB.Name = "CdSpaceRB"
        Me.CdSpaceRB.Size = New System.Drawing.Size(73, 16)
        Me.CdSpaceRB.TabIndex = 4
        Me.CdSpaceRB.TabStop = True
        Me.CdSpaceRB.Text = "Space( )"
        Me.CdSpaceRB.UseVisualStyleBackColor = True
        '
        'GrpLT
        '
        Me.GrpLT.Controls.Add(Me.LtUserInputTBX)
        Me.GrpLT.Controls.Add(Me.Label3)
        Me.GrpLT.Controls.Add(Me.LtUserInputRB)
        Me.GrpLT.Controls.Add(Me.LtCrRB)
        Me.GrpLT.Location = New System.Drawing.Point(207, 6)
        Me.GrpLT.Name = "GrpLT"
        Me.GrpLT.Size = New System.Drawing.Size(193, 237)
        Me.GrpLT.TabIndex = 0
        Me.GrpLT.TabStop = False
        Me.GrpLT.Text = "Line Terminator"
        '
        'LtUserInputTBX
        '
        Me.LtUserInputTBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.LtUserInputTBX.Location = New System.Drawing.Point(22, 92)
        Me.LtUserInputTBX.Name = "LtUserInputTBX"
        Me.LtUserInputTBX.Size = New System.Drawing.Size(144, 21)
        Me.LtUserInputTBX.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 12)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Select Line Terminator"
        '
        'LtUserInputRB
        '
        Me.LtUserInputRB.AutoSize = True
        Me.LtUserInputRB.Location = New System.Drawing.Point(8, 70)
        Me.LtUserInputRB.Name = "LtUserInputRB"
        Me.LtUserInputRB.Size = New System.Drawing.Size(80, 16)
        Me.LtUserInputRB.TabIndex = 2
        Me.LtUserInputRB.TabStop = True
        Me.LtUserInputRB.Text = "User Input"
        Me.LtUserInputRB.UseVisualStyleBackColor = True
        '
        'LtCrRB
        '
        Me.LtCrRB.AutoSize = True
        Me.LtCrRB.Location = New System.Drawing.Point(8, 45)
        Me.LtCrRB.Name = "LtCrRB"
        Me.LtCrRB.Size = New System.Drawing.Size(104, 16)
        Me.LtCrRB.TabIndex = 0
        Me.LtCrRB.TabStop = True
        Me.LtCrRB.Text = "Carrige Return"
        Me.LtCrRB.UseVisualStyleBackColor = True
        '
        'TabTblSetting
        '
        Me.TabTblSetting.BackColor = System.Drawing.SystemColors.Control
        Me.TabTblSetting.Controls.Add(Me.GroupBox4)
        Me.TabTblSetting.Controls.Add(Me.GrpDbConn)
        Me.TabTblSetting.Location = New System.Drawing.Point(4, 22)
        Me.TabTblSetting.Name = "TabTblSetting"
        Me.TabTblSetting.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTblSetting.Size = New System.Drawing.Size(971, 193)
        Me.TabTblSetting.TabIndex = 2
        Me.TabTblSetting.Text = "TabTblSetting"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.ColInfoGV)
        Me.GroupBox4.Controls.Add(Me.ToolStrip4)
        Me.GroupBox4.Location = New System.Drawing.Point(357, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(605, 241)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Column Infomation"
        '
        'ColInfoGV
        '
        Me.ColInfoGV.AllowUserToAddRows = False
        Me.ColInfoGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ColInfoGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColInfoGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ColInfoGV.Location = New System.Drawing.Point(3, 42)
        Me.ColInfoGV.Name = "ColInfoGV"
        Me.ColInfoGV.ReadOnly = True
        Me.ColInfoGV.RowHeadersVisible = False
        Me.ColInfoGV.RowTemplate.Height = 23
        Me.ColInfoGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ColInfoGV.Size = New System.Drawing.Size(599, 196)
        Me.ColInfoGV.TabIndex = 1
        '
        'ToolStrip4
        '
        Me.ToolStrip4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel5})
        Me.ToolStrip4.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip4.Size = New System.Drawing.Size(599, 25)
        Me.ToolStrip4.Stretch = True
        Me.ToolStrip4.TabIndex = 0
        Me.ToolStrip4.Text = "ToolStrip4"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(246, 22)
        Me.ToolStripLabel5.Text = "입력 테이블의 대상 컬럼을 선택하여 주세요."
        '
        'GrpDbConn
        '
        Me.GrpDbConn.Controls.Add(Me.TblListGV)
        Me.GrpDbConn.Controls.Add(Me.ToolStrip2)
        Me.GrpDbConn.Location = New System.Drawing.Point(8, 6)
        Me.GrpDbConn.Name = "GrpDbConn"
        Me.GrpDbConn.Size = New System.Drawing.Size(343, 241)
        Me.GrpDbConn.TabIndex = 4
        Me.GrpDbConn.TabStop = False
        Me.GrpDbConn.Text = "Table Infomation"
        '
        'TblListGV
        '
        Me.TblListGV.AllowUserToAddRows = False
        Me.TblListGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.TblListGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblListGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblListGV.Location = New System.Drawing.Point(3, 42)
        Me.TblListGV.Name = "TblListGV"
        Me.TblListGV.ReadOnly = True
        Me.TblListGV.RowHeadersVisible = False
        Me.TblListGV.RowTemplate.Height = 23
        Me.TblListGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblListGV.Size = New System.Drawing.Size(337, 196)
        Me.TblListGV.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel3, Me.TblNmTBX})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip2.Size = New System.Drawing.Size(337, 25)
        Me.ToolStrip2.Stretch = True
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel3.Text = "테이블명"
        '
        'TblNmTBX
        '
        Me.TblNmTBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TblNmTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TblNmTBX.Name = "TblNmTBX"
        Me.TblNmTBX.Size = New System.Drawing.Size(120, 25)
        '
        'TabColMapping
        '
        Me.TabColMapping.BackColor = System.Drawing.SystemColors.Control
        Me.TabColMapping.Controls.Add(Me.GroupBox3)
        Me.TabColMapping.Location = New System.Drawing.Point(4, 22)
        Me.TabColMapping.Name = "TabColMapping"
        Me.TabColMapping.Padding = New System.Windows.Forms.Padding(3)
        Me.TabColMapping.Size = New System.Drawing.Size(971, 193)
        Me.TabColMapping.TabIndex = 3
        Me.TabColMapping.Text = "TabColMapping"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ToolStripContainer2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(965, 187)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Column Mapping"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.MappingColGV)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(959, 142)
        Me.ToolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer2.Location = New System.Drawing.Point(3, 17)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(959, 167)
        Me.ToolStripContainer2.TabIndex = 1
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'ToolStripContainer2.TopToolStripPanel
        '
        Me.ToolStripContainer2.TopToolStripPanel.Controls.Add(Me.ToolStrip5)
        '
        'MappingColGV
        '
        Me.MappingColGV.AllowUserToAddRows = False
        Me.MappingColGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.MappingColGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MappingColGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MappingColGV.Location = New System.Drawing.Point(0, 0)
        Me.MappingColGV.Name = "MappingColGV"
        Me.MappingColGV.RowHeadersVisible = False
        Me.MappingColGV.RowTemplate.Height = 23
        Me.MappingColGV.Size = New System.Drawing.Size(959, 142)
        Me.MappingColGV.TabIndex = 0
        '
        'ToolStrip5
        '
        Me.ToolStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel7, Me.TableNmTBX})
        Me.ToolStrip5.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip5.Name = "ToolStrip5"
        Me.ToolStrip5.Size = New System.Drawing.Size(959, 25)
        Me.ToolStrip5.Stretch = True
        Me.ToolStrip5.TabIndex = 0
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(86, 22)
        Me.ToolStripLabel7.Text = "TABLE NAME  "
        '
        'TableNmTBX
        '
        Me.TableNmTBX.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableNmTBX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableNmTBX.Name = "TableNmTBX"
        Me.TableNmTBX.ReadOnly = True
        Me.TableNmTBX.Size = New System.Drawing.Size(100, 25)
        '
        'TabOptions
        '
        Me.TabOptions.BackColor = System.Drawing.SystemColors.Control
        Me.TabOptions.Controls.Add(Me.GroupBox5)
        Me.TabOptions.Controls.Add(Me.GroupBox1)
        Me.TabOptions.Controls.Add(Me.GrpLoadMethod)
        Me.TabOptions.Location = New System.Drawing.Point(4, 22)
        Me.TabOptions.Name = "TabOptions"
        Me.TabOptions.Size = New System.Drawing.Size(971, 193)
        Me.TabOptions.TabIndex = 5
        Me.TabOptions.Text = "TabOptions"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LogMsgRTB)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 224)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(948, 282)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Log Message"
        '
        'LogMsgRTB
        '
        Me.LogMsgRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogMsgRTB.Location = New System.Drawing.Point(3, 17)
        Me.LogMsgRTB.Name = "LogMsgRTB"
        Me.LogMsgRTB.Size = New System.Drawing.Size(942, 262)
        Me.LogMsgRTB.TabIndex = 0
        Me.LogMsgRTB.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(469, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(494, 199)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load Infomation"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.42857!))
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(488, 179)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox4.Location = New System.Drawing.Point(142, 90)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(343, 21)
        Me.TextBox4.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(3, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 29)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "FILE TYPE"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Location = New System.Drawing.Point(142, 61)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(343, 21)
        Me.TextBox3.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(3, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 29)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "DB INFO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Location = New System.Drawing.Point(142, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(343, 21)
        Me.TextBox2.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Location = New System.Drawing.Point(3, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 29)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "TABLE NAME"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 29)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "SOURCE FILE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(142, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(343, 21)
        Me.TextBox1.TabIndex = 1
        '
        'GrpLoadMethod
        '
        Me.GrpLoadMethod.Controls.Add(Me.ParallelCntCBX)
        Me.GrpLoadMethod.Controls.Add(Me.Label6)
        Me.GrpLoadMethod.Controls.Add(Me.FetchCntCBX)
        Me.GrpLoadMethod.Controls.Add(Me.Label5)
        Me.GrpLoadMethod.Controls.Add(Me.BulkLoadRB)
        Me.GrpLoadMethod.Controls.Add(Me.ConventRB)
        Me.GrpLoadMethod.Location = New System.Drawing.Point(9, 4)
        Me.GrpLoadMethod.Name = "GrpLoadMethod"
        Me.GrpLoadMethod.Size = New System.Drawing.Size(454, 199)
        Me.GrpLoadMethod.TabIndex = 0
        Me.GrpLoadMethod.TabStop = False
        Me.GrpLoadMethod.Text = "Load Method"
        '
        'ParallelCntCBX
        '
        Me.ParallelCntCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ParallelCntCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ParallelCntCBX.FormattingEnabled = True
        Me.ParallelCntCBX.Items.AddRange(New Object() {"1", "2", "4", "8", "16", "32", "64"})
        Me.ParallelCntCBX.Location = New System.Drawing.Point(124, 61)
        Me.ParallelCntCBX.Name = "ParallelCntCBX"
        Me.ParallelCntCBX.Size = New System.Drawing.Size(121, 20)
        Me.ParallelCntCBX.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Parallel Count "
        '
        'FetchCntCBX
        '
        Me.FetchCntCBX.BackColor = System.Drawing.SystemColors.Window
        Me.FetchCntCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FetchCntCBX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FetchCntCBX.FormattingEnabled = True
        Me.FetchCntCBX.Items.AddRange(New Object() {"1000", "2000", "3000", "5000", "10000", "50000", "100000", "1000000"})
        Me.FetchCntCBX.Location = New System.Drawing.Point(100, 145)
        Me.FetchCntCBX.Name = "FetchCntCBX"
        Me.FetchCntCBX.Size = New System.Drawing.Size(121, 20)
        Me.FetchCntCBX.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fetch Size "
        '
        'BulkLoadRB
        '
        Me.BulkLoadRB.AutoSize = True
        Me.BulkLoadRB.Location = New System.Drawing.Point(7, 99)
        Me.BulkLoadRB.Name = "BulkLoadRB"
        Me.BulkLoadRB.Size = New System.Drawing.Size(79, 16)
        Me.BulkLoadRB.TabIndex = 1
        Me.BulkLoadRB.TabStop = True
        Me.BulkLoadRB.Text = "Bulk Load"
        Me.BulkLoadRB.UseVisualStyleBackColor = True
        '
        'ConventRB
        '
        Me.ConventRB.AutoSize = True
        Me.ConventRB.Location = New System.Drawing.Point(7, 32)
        Me.ConventRB.Name = "ConventRB"
        Me.ConventRB.Size = New System.Drawing.Size(128, 16)
        Me.ConventRB.TabIndex = 0
        Me.ConventRB.TabStop = True
        Me.ConventRB.Text = "Conventional Load"
        Me.ConventRB.UseVisualStyleBackColor = True
        '
        'TabFinal
        '
        Me.TabFinal.BackColor = System.Drawing.SystemColors.Control
        Me.TabFinal.Location = New System.Drawing.Point(4, 22)
        Me.TabFinal.Name = "TabFinal"
        Me.TabFinal.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFinal.Size = New System.Drawing.Size(971, 193)
        Me.TabFinal.TabIndex = 4
        Me.TabFinal.Text = "TabFinal"
        '
        'TabResultCTL
        '
        Me.TabResultCTL.Controls.Add(Me.TabResult)
        Me.TabResultCTL.Controls.Add(Me.TabModSampleData)
        Me.TabResultCTL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabResultCTL.Location = New System.Drawing.Point(0, 0)
        Me.TabResultCTL.Name = "TabResultCTL"
        Me.TabResultCTL.SelectedIndex = 0
        Me.TabResultCTL.Size = New System.Drawing.Size(979, 460)
        Me.TabResultCTL.TabIndex = 2
        '
        'TabResult
        '
        Me.TabResult.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabResult.Controls.Add(Me.GrpResultData)
        Me.TabResult.Location = New System.Drawing.Point(4, 22)
        Me.TabResult.Name = "TabResult"
        Me.TabResult.Padding = New System.Windows.Forms.Padding(3)
        Me.TabResult.Size = New System.Drawing.Size(971, 434)
        Me.TabResult.TabIndex = 0
        Me.TabResult.Text = "Original Sample Data"
        '
        'GrpResultData
        '
        Me.GrpResultData.BackColor = System.Drawing.SystemColors.Control
        Me.GrpResultData.Controls.Add(Me.ResultDataWB)
        Me.GrpResultData.Controls.Add(Me.ToolStrip1)
        Me.GrpResultData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpResultData.Location = New System.Drawing.Point(3, 3)
        Me.GrpResultData.Name = "GrpResultData"
        Me.GrpResultData.Size = New System.Drawing.Size(965, 428)
        Me.GrpResultData.TabIndex = 3
        Me.GrpResultData.TabStop = False
        Me.GrpResultData.Text = "Result Sample Data"
        '
        'ResultDataWB
        '
        Me.ResultDataWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultDataWB.Location = New System.Drawing.Point(3, 42)
        Me.ResultDataWB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ResultDataWB.Name = "ResultDataWB"
        Me.ResultDataWB.Size = New System.Drawing.Size(959, 383)
        Me.ResultDataWB.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrgLinesCBX, Me.ToolStripLabel1, Me.OrgRowCntLB})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(959, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'OrgLinesCBX
        '
        Me.OrgLinesCBX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.OrgLinesCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OrgLinesCBX.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.OrgLinesCBX.Items.AddRange(New Object() {"10", "100", "1000"})
        Me.OrgLinesCBX.Name = "OrgLinesCBX"
        Me.OrgLinesCBX.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripLabel1.Text = "Line"
        '
        'OrgRowCntLB
        '
        Me.OrgRowCntLB.Name = "OrgRowCntLB"
        Me.OrgRowCntLB.Size = New System.Drawing.Size(54, 22)
        Me.OrgRowCntLB.Text = "(0) Rows"
        '
        'TabModSampleData
        '
        Me.TabModSampleData.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabModSampleData.Controls.Add(Me.GrpModData)
        Me.TabModSampleData.Location = New System.Drawing.Point(4, 22)
        Me.TabModSampleData.Name = "TabModSampleData"
        Me.TabModSampleData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabModSampleData.Size = New System.Drawing.Size(971, 434)
        Me.TabModSampleData.TabIndex = 1
        Me.TabModSampleData.Text = "Modified Sample Data"
        '
        'GrpModData
        '
        Me.GrpModData.BackColor = System.Drawing.SystemColors.Control
        Me.GrpModData.Controls.Add(Me.ResultModDataWB)
        Me.GrpModData.Controls.Add(Me.ToolStript2)
        Me.GrpModData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpModData.Location = New System.Drawing.Point(3, 3)
        Me.GrpModData.Name = "GrpModData"
        Me.GrpModData.Size = New System.Drawing.Size(965, 428)
        Me.GrpModData.TabIndex = 4
        Me.GrpModData.TabStop = False
        Me.GrpModData.Text = "Modified Sample Data"
        '
        'ResultModDataWB
        '
        Me.ResultModDataWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResultModDataWB.Location = New System.Drawing.Point(3, 42)
        Me.ResultModDataWB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.ResultModDataWB.Name = "ResultModDataWB"
        Me.ResultModDataWB.Size = New System.Drawing.Size(959, 383)
        Me.ResultModDataWB.TabIndex = 2
        '
        'ToolStript2
        '
        Me.ToolStript2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStript2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStript2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModLinesCBX, Me.ToolStripLabel4, Me.ModRowCntLB})
        Me.ToolStript2.Location = New System.Drawing.Point(3, 17)
        Me.ToolStript2.Name = "ToolStript2"
        Me.ToolStript2.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStript2.Size = New System.Drawing.Size(959, 25)
        Me.ToolStript2.Stretch = True
        Me.ToolStript2.TabIndex = 0
        Me.ToolStript2.Text = "ToolStrip5"
        '
        'ModLinesCBX
        '
        Me.ModLinesCBX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ModLinesCBX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ModLinesCBX.FlatStyle = System.Windows.Forms.FlatStyle.Standard
        Me.ModLinesCBX.Items.AddRange(New Object() {"10", "100", "1000"})
        Me.ModLinesCBX.Name = "ModLinesCBX"
        Me.ModLinesCBX.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripLabel4.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripLabel4.Text = "Line"
        '
        'ModRowCntLB
        '
        Me.ModRowCntLB.Name = "ModRowCntLB"
        Me.ModRowCntLB.Size = New System.Drawing.Size(54, 22)
        Me.ModRowCntLB.Text = "(0) Rows"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(636, 29)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLB
        '
        Me.StatusLB.Name = "StatusLB"
        Me.StatusLB.Size = New System.Drawing.Size(0, 24)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ExecBTN, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CloseBTN, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BackBTN, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NextBTN, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(636, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(343, 29)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'ExecBTN
        '
        Me.ExecBTN.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ExecBTN.Location = New System.Drawing.Point(3, 3)
        Me.ExecBTN.Name = "ExecBTN"
        Me.ExecBTN.Size = New System.Drawing.Size(75, 23)
        Me.ExecBTN.TabIndex = 3
        Me.ExecBTN.Text = "Execute"
        Me.ExecBTN.UseVisualStyleBackColor = True
        '
        'CloseBTN
        '
        Me.CloseBTN.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CloseBTN.Location = New System.Drawing.Point(258, 3)
        Me.CloseBTN.Name = "CloseBTN"
        Me.CloseBTN.Size = New System.Drawing.Size(75, 23)
        Me.CloseBTN.TabIndex = 2
        Me.CloseBTN.Text = "Close"
        Me.CloseBTN.UseVisualStyleBackColor = True
        '
        'NextBTN
        '
        Me.NextBTN.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.NextBTN.Location = New System.Drawing.Point(173, 3)
        Me.NextBTN.Name = "NextBTN"
        Me.NextBTN.Size = New System.Drawing.Size(75, 23)
        Me.NextBTN.TabIndex = 1
        Me.NextBTN.Text = "Next >"
        Me.NextBTN.UseVisualStyleBackColor = True
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.BackColor = System.Drawing.Color.Transparent
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(246, 3)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.miniToolStrip.Size = New System.Drawing.Size(599, 25)
        Me.miniToolStrip.Stretch = True
        Me.miniToolStrip.TabIndex = 2
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(246, 22)
        Me.ToolStripLabel2.Text = "입력 테이블의 대상 컬럼을 선택하여 주세요."
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip3.Location = New System.Drawing.Point(3, 17)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip3.Size = New System.Drawing.Size(599, 25)
        Me.ToolStrip3.Stretch = True
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(979, 710)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(979, 735)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.LoadRegMainTS)
        '
        'LoadRegMainTS
        '
        Me.LoadRegMainTS.Dock = System.Windows.Forms.DockStyle.None
        Me.LoadRegMainTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.LoadRegMainTS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel6, Me.DbConnBTN, Me.DbEndConnBTN})
        Me.LoadRegMainTS.Location = New System.Drawing.Point(0, 0)
        Me.LoadRegMainTS.Name = "LoadRegMainTS"
        Me.LoadRegMainTS.Size = New System.Drawing.Size(979, 25)
        Me.LoadRegMainTS.Stretch = True
        Me.LoadRegMainTS.TabIndex = 0
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(11, 22)
        Me.ToolStripLabel6.Text = " "
        '
        'DbConnBTN
        '
        Me.DbConnBTN.Image = CType(resources.GetObject("DbConnBTN.Image"), System.Drawing.Image)
        Me.DbConnBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbConnBTN.Name = "DbConnBTN"
        Me.DbConnBTN.Size = New System.Drawing.Size(56, 22)
        Me.DbConnBTN.Text = "Conn"
        '
        'DbEndConnBTN
        '
        Me.DbEndConnBTN.Image = CType(resources.GetObject("DbEndConnBTN.Image"), System.Drawing.Image)
        Me.DbEndConnBTN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DbEndConnBTN.Name = "DbEndConnBTN"
        Me.DbEndConnBTN.Size = New System.Drawing.Size(80, 22)
        Me.DbEndConnBTN.Text = "End Conn"
        '
        'frmLoaderReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 735)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.KeyPreview = True
        Me.Name = "frmLoaderReg"
        Me.Text = "Registration"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabCtlCustom.ResumeLayout(False)
        Me.TabLoadFile.ResumeLayout(False)
        Me.GrpExcelSheet.ResumeLayout(False)
        Me.GrpExcelSheet.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GrpFileType.ResumeLayout(False)
        Me.GrpFileType.PerformLayout()
        Me.GrpAddFile.ResumeLayout(False)
        Me.GrpAddFile.PerformLayout()
        Me.TabLoadSetting.ResumeLayout(False)
        Me.GrpOrgTxt.ResumeLayout(False)
        Me.GrpCD.ResumeLayout(False)
        Me.GrpCD.PerformLayout()
        Me.GrpLT.ResumeLayout(False)
        Me.GrpLT.PerformLayout()
        Me.TabTblSetting.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ColInfoGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
        Me.GrpDbConn.ResumeLayout(False)
        Me.GrpDbConn.PerformLayout()
        CType(Me.TblListGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabColMapping.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer2.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        CType(Me.MappingColGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip5.ResumeLayout(False)
        Me.ToolStrip5.PerformLayout()
        Me.TabOptions.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.GrpLoadMethod.ResumeLayout(False)
        Me.GrpLoadMethod.PerformLayout()
        Me.TabResultCTL.ResumeLayout(False)
        Me.TabResult.ResumeLayout(False)
        Me.GrpResultData.ResumeLayout(False)
        Me.GrpResultData.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabModSampleData.ResumeLayout(False)
        Me.GrpModData.ResumeLayout(False)
        Me.GrpModData.PerformLayout()
        Me.ToolStript2.ResumeLayout(False)
        Me.ToolStript2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.LoadRegMainTS.ResumeLayout(False)
        Me.LoadRegMainTS.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackBTN As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CloseBTN As System.Windows.Forms.Button
    Friend WithEvents NextBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFileRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents GrpAddFile As System.Windows.Forms.GroupBox
    Friend WithEvents AddFileBTN As System.Windows.Forms.Button
    Friend WithEvents FileNameTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpFileType As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ExcelFileTypRB As System.Windows.Forms.RadioButton
    Friend WithEvents TxtFileTypRB As System.Windows.Forms.RadioButton
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TabCtlCustom As ClsTabCtlNoHeader
    Friend WithEvents TabLoadFile As System.Windows.Forms.TabPage
    Friend WithEvents TabLoadSetting As System.Windows.Forms.TabPage
    Friend WithEvents GrpResultData As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents OrgLinesCBX As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GrpOrgTxt As System.Windows.Forms.GroupBox
    Friend WithEvents GrpCD As System.Windows.Forms.GroupBox
    Friend WithEvents CdUserInputTBX As System.Windows.Forms.TextBox
    Friend WithEvents CdUserInputRB As System.Windows.Forms.RadioButton
    Friend WithEvents CdPipeRB As System.Windows.Forms.RadioButton
    Friend WithEvents CdCommaRB As System.Windows.Forms.RadioButton
    Friend WithEvents CdTabRB As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CdSpaceRB As System.Windows.Forms.RadioButton
    Friend WithEvents GrpLT As System.Windows.Forms.GroupBox
    Friend WithEvents LtUserInputTBX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LtUserInputRB As System.Windows.Forms.RadioButton
    Friend WithEvents LtCrRB As System.Windows.Forms.RadioButton
    Friend WithEvents OrgTxtTlsRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabTblSetting As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GrpDbConn As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents TblListGV As System.Windows.Forms.DataGridView
    Friend WithEvents TblNmTBX As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ColInfoGV As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip4 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents TabColMapping As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MappingColGV As System.Windows.Forms.DataGridView
    Friend WithEvents TabFinal As System.Windows.Forms.TabPage
    Friend WithEvents OrgRowCntLB As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GrpModData As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStript2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ModLinesCBX As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ModRowCntLB As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabResultCTL As System.Windows.Forms.TabControl
    Friend WithEvents TabResult As System.Windows.Forms.TabPage
    Friend WithEvents TabModSampleData As System.Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents LoadRegMainTS As System.Windows.Forms.ToolStrip
    Friend WithEvents DbConnBTN As System.Windows.Forms.ToolStripButton
    Friend WithEvents DbEndConnBTN As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabOptions As System.Windows.Forms.TabPage
    Friend WithEvents GrpLoadMethod As System.Windows.Forms.GroupBox
    Friend WithEvents BulkLoadRB As System.Windows.Forms.RadioButton
    Friend WithEvents ConventRB As System.Windows.Forms.RadioButton
    Friend WithEvents ParallelCntCBX As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FetchCntCBX As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ResultDataWB As System.Windows.Forms.WebBrowser
    Friend WithEvents ResultModDataWB As System.Windows.Forms.WebBrowser
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExecBTN As System.Windows.Forms.Button
    Friend WithEvents ExcelSheetCBX As System.Windows.Forms.ComboBox
    Friend WithEvents GrpExcelSheet As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLB As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip5 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TableNmTBX As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LogMsgRTB As System.Windows.Forms.RichTextBox
End Class
