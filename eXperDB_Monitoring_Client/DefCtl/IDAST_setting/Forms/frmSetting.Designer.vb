<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogOpenDirButton = New System.Windows.Forms.Button()
        Me.LogPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UserOpenDirButton = New System.Windows.Forms.Button()
        Me.UserPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TempOpenDirButton = New System.Windows.Forms.Button()
        Me.TempPath = New System.Windows.Forms.TextBox()
        Me.InfoTextBox = New System.Windows.Forms.TextBox()
        Me.TnsOpenDirButton = New System.Windows.Forms.Button()
        Me.TnsPath = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SettingButton = New System.Windows.Forms.ToolStripButton()
        Me.ClearButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseTSB = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.IPTextBox = New System.Windows.Forms.TextBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.SSLComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckMetaFile = New System.Windows.Forms.CheckBox()
        Me.MetaFilePath = New System.Windows.Forms.TextBox()
        Me.MetaOpenDirButton = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "로그 경로"
        '
        'LogOpenDirButton
        '
        Me.LogOpenDirButton.Location = New System.Drawing.Point(359, 70)
        Me.LogOpenDirButton.Name = "LogOpenDirButton"
        Me.LogOpenDirButton.Size = New System.Drawing.Size(35, 21)
        Me.LogOpenDirButton.TabIndex = 15
        Me.LogOpenDirButton.UseVisualStyleBackColor = True
        '
        'LogPath
        '
        Me.LogPath.Location = New System.Drawing.Point(97, 70)
        Me.LogPath.Name = "LogPath"
        Me.LogPath.ReadOnly = True
        Me.LogPath.Size = New System.Drawing.Size(259, 21)
        Me.LogPath.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "사용자 경로"
        '
        'UserOpenDirButton
        '
        Me.UserOpenDirButton.Location = New System.Drawing.Point(359, 43)
        Me.UserOpenDirButton.Name = "UserOpenDirButton"
        Me.UserOpenDirButton.Size = New System.Drawing.Size(35, 21)
        Me.UserOpenDirButton.TabIndex = 12
        Me.UserOpenDirButton.UseVisualStyleBackColor = True
        '
        'UserPath
        '
        Me.UserPath.Location = New System.Drawing.Point(97, 43)
        Me.UserPath.Name = "UserPath"
        Me.UserPath.ReadOnly = True
        Me.UserPath.Size = New System.Drawing.Size(259, 21)
        Me.UserPath.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "임시 경로"
        '
        'TempOpenDirButton
        '
        Me.TempOpenDirButton.Location = New System.Drawing.Point(359, 15)
        Me.TempOpenDirButton.Name = "TempOpenDirButton"
        Me.TempOpenDirButton.Size = New System.Drawing.Size(35, 21)
        Me.TempOpenDirButton.TabIndex = 9
        Me.TempOpenDirButton.UseVisualStyleBackColor = True
        '
        'TempPath
        '
        Me.TempPath.Location = New System.Drawing.Point(97, 16)
        Me.TempPath.Name = "TempPath"
        Me.TempPath.ReadOnly = True
        Me.TempPath.Size = New System.Drawing.Size(259, 21)
        Me.TempPath.TabIndex = 8
        '
        'InfoTextBox
        '
        Me.InfoTextBox.ForeColor = System.Drawing.Color.Blue
        Me.InfoTextBox.Location = New System.Drawing.Point(5, 28)
        Me.InfoTextBox.Multiline = True
        Me.InfoTextBox.Name = "InfoTextBox"
        Me.InfoTextBox.ReadOnly = True
        Me.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InfoTextBox.Size = New System.Drawing.Size(402, 57)
        Me.InfoTextBox.TabIndex = 7
        '
        'TnsOpenDirButton
        '
        Me.TnsOpenDirButton.Location = New System.Drawing.Point(361, 171)
        Me.TnsOpenDirButton.Name = "TnsOpenDirButton"
        Me.TnsOpenDirButton.Size = New System.Drawing.Size(35, 21)
        Me.TnsOpenDirButton.TabIndex = 6
        Me.TnsOpenDirButton.UseVisualStyleBackColor = True
        Me.TnsOpenDirButton.Visible = False
        '
        'TnsPath
        '
        Me.TnsPath.Location = New System.Drawing.Point(99, 172)
        Me.TnsPath.Name = "TnsPath"
        Me.TnsPath.ReadOnly = True
        Me.TnsPath.Size = New System.Drawing.Size(259, 21)
        Me.TnsPath.TabIndex = 5
        Me.TnsPath.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tns 경로"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "인증 정보"
        '
        'KeyTextBox
        '
        Me.KeyTextBox.Location = New System.Drawing.Point(97, 97)
        Me.KeyTextBox.Multiline = True
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KeyTextBox.Size = New System.Drawing.Size(297, 76)
        Me.KeyTextBox.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingButton, Me.ClearButton, Me.CloseTSB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(419, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'SettingButton
        '
        Me.SettingButton.Image = CType(resources.GetObject("SettingButton.Image"), System.Drawing.Image)
        Me.SettingButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SettingButton.Name = "SettingButton"
        Me.SettingButton.Size = New System.Drawing.Size(51, 22)
        Me.SettingButton.Text = "적용"
        '
        'ClearButton
        '
        Me.ClearButton.Image = CType(resources.GetObject("ClearButton.Image"), System.Drawing.Image)
        Me.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(63, 22)
        Me.ClearButton.Text = "초기화"
        '
        'CloseTSB
        '
        Me.CloseTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CloseTSB.Image = CType(resources.GetObject("CloseTSB.Image"), System.Drawing.Image)
        Me.CloseTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CloseTSB.Name = "CloseTSB"
        Me.CloseTSB.Size = New System.Drawing.Size(51, 22)
        Me.CloseTSB.Text = "닫기"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "IP 주소"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "포트"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "SSL사용여부"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 95)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "업데이트 서버 설정"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.IPTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PortTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SSLComboBox, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(396, 75)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'IPTextBox
        '
        Me.IPTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.IPTextBox.Location = New System.Drawing.Point(103, 3)
        Me.IPTextBox.Name = "IPTextBox"
        Me.IPTextBox.Size = New System.Drawing.Size(211, 21)
        Me.IPTextBox.TabIndex = 20
        '
        'PortTextBox
        '
        Me.PortTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PortTextBox.Location = New System.Drawing.Point(103, 28)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(76, 21)
        Me.PortTextBox.TabIndex = 21
        '
        'SSLComboBox
        '
        Me.SSLComboBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.SSLComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SSLComboBox.FormattingEnabled = True
        Me.SSLComboBox.Items.AddRange(New Object() {"Y", "N"})
        Me.SSLComboBox.Location = New System.Drawing.Point(103, 53)
        Me.SSLComboBox.Name = "SSLComboBox"
        Me.SSLComboBox.Size = New System.Drawing.Size(76, 20)
        Me.SSLComboBox.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TempPath)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TempOpenDirButton)
        Me.GroupBox2.Controls.Add(Me.LogOpenDirButton)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.LogPath)
        Me.GroupBox2.Controls.Add(Me.UserPath)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.KeyTextBox)
        Me.GroupBox2.Controls.Add(Me.UserOpenDirButton)
        Me.GroupBox2.Controls.Add(Me.TnsPath)
        Me.GroupBox2.Controls.Add(Me.TnsOpenDirButton)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 184)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "프로그램 기본 설정"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckMetaFile)
        Me.GroupBox3.Controls.Add(Me.MetaFilePath)
        Me.GroupBox3.Controls.Add(Me.MetaOpenDirButton)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 408)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(399, 50)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "      메타시스템 정보 파일"
        '
        'CheckMetaFile
        '
        Me.CheckMetaFile.AutoSize = True
        Me.CheckMetaFile.Location = New System.Drawing.Point(12, 0)
        Me.CheckMetaFile.Name = "CheckMetaFile"
        Me.CheckMetaFile.Size = New System.Drawing.Size(15, 14)
        Me.CheckMetaFile.TabIndex = 9
        Me.CheckMetaFile.UseVisualStyleBackColor = True
        '
        'MetaFilePath
        '
        Me.MetaFilePath.Location = New System.Drawing.Point(8, 23)
        Me.MetaFilePath.Name = "MetaFilePath"
        Me.MetaFilePath.ReadOnly = True
        Me.MetaFilePath.Size = New System.Drawing.Size(344, 21)
        Me.MetaFilePath.TabIndex = 7
        '
        'MetaOpenDirButton
        '
        Me.MetaOpenDirButton.Enabled = False
        Me.MetaOpenDirButton.Location = New System.Drawing.Point(358, 23)
        Me.MetaOpenDirButton.Name = "MetaOpenDirButton"
        Me.MetaOpenDirButton.Size = New System.Drawing.Size(35, 21)
        Me.MetaOpenDirButton.TabIndex = 8
        Me.MetaOpenDirButton.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.InfoTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SettingButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KeyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TnsOpenDirButton As System.Windows.Forms.Button
    Friend WithEvents TnsPath As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents InfoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempOpenDirButton As System.Windows.Forms.Button
    Friend WithEvents TempPath As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents UserOpenDirButton As System.Windows.Forms.Button
    Friend WithEvents UserPath As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LogOpenDirButton As System.Windows.Forms.Button
    Friend WithEvents LogPath As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CloseTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents IPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SSLComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents MetaFilePath As System.Windows.Forms.TextBox
    Friend WithEvents MetaOpenDirButton As System.Windows.Forms.Button
    Friend WithEvents CheckMetaFile As System.Windows.Forms.CheckBox

End Class
