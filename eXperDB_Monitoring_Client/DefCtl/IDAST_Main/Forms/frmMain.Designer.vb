<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.LicenseRTB = New System.Windows.Forms.RichTextBox()
        Me.ActionGB = New System.Windows.Forms.GroupBox()
        Me.ModeCase7 = New System.Windows.Forms.Button()
        Me.ModeCase6 = New System.Windows.Forms.Button()
        Me.ModeCase5 = New System.Windows.Forms.Button()
        Me.ModeCase4 = New System.Windows.Forms.Button()
        Me.ModeCase1 = New System.Windows.Forms.Button()
        Me.ModeCase3 = New System.Windows.Forms.Button()
        Me.ModeCase0 = New System.Windows.Forms.Button()
        Me.ModeCase2 = New System.Windows.Forms.Button()
        Me.PasswdToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CertiPw = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.OkBt = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MsgTSSL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ActionGB.SuspendLayout()
        Me.PasswdToolStrip.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LicenseRTB
        '
        Me.LicenseRTB.BackColor = System.Drawing.Color.White
        Me.LicenseRTB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LicenseRTB.Location = New System.Drawing.Point(0, 0)
        Me.LicenseRTB.Name = "LicenseRTB"
        Me.LicenseRTB.ReadOnly = True
        Me.LicenseRTB.Size = New System.Drawing.Size(574, 163)
        Me.LicenseRTB.TabIndex = 6
        Me.LicenseRTB.Text = ""
        '
        'ActionGB
        '
        Me.ActionGB.Controls.Add(Me.ModeCase7)
        Me.ActionGB.Controls.Add(Me.ModeCase6)
        Me.ActionGB.Controls.Add(Me.ModeCase5)
        Me.ActionGB.Controls.Add(Me.ModeCase4)
        Me.ActionGB.Controls.Add(Me.ModeCase1)
        Me.ActionGB.Controls.Add(Me.ModeCase3)
        Me.ActionGB.Controls.Add(Me.ModeCase0)
        Me.ActionGB.Controls.Add(Me.ModeCase2)
        Me.ActionGB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ActionGB.Location = New System.Drawing.Point(0, 163)
        Me.ActionGB.Name = "ActionGB"
        Me.ActionGB.Size = New System.Drawing.Size(574, 245)
        Me.ActionGB.TabIndex = 11
        Me.ActionGB.TabStop = False
        '
        'ModeCase7
        '
        Me.ModeCase7.Location = New System.Drawing.Point(434, 131)
        Me.ModeCase7.Name = "ModeCase7"
        Me.ModeCase7.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase7.TabIndex = 14
        Me.ModeCase7.Text = "Meta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "System"
        Me.ModeCase7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase7.UseVisualStyleBackColor = True
        '
        'ModeCase6
        '
        Me.ModeCase6.Location = New System.Drawing.Point(296, 131)
        Me.ModeCase6.Name = "ModeCase6"
        Me.ModeCase6.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase6.TabIndex = 13
        Me.ModeCase6.Text = "SQL Extractor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On Source"
        Me.ModeCase6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase6.UseVisualStyleBackColor = True
        '
        'ModeCase5
        '
        Me.ModeCase5.Location = New System.Drawing.Point(158, 131)
        Me.ModeCase5.Name = "ModeCase5"
        Me.ModeCase5.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase5.TabIndex = 12
        Me.ModeCase5.Text = "CRUD/SQL Analyzer"
        Me.ModeCase5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase5.UseVisualStyleBackColor = True
        '
        'ModeCase4
        '
        Me.ModeCase4.Location = New System.Drawing.Point(20, 131)
        Me.ModeCase4.Name = "ModeCase4"
        Me.ModeCase4.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase4.TabIndex = 11
        Me.ModeCase4.Text = "Ansi Join Converter"
        Me.ModeCase4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase4.UseVisualStyleBackColor = True
        '
        'ModeCase1
        '
        Me.ModeCase1.Location = New System.Drawing.Point(158, 25)
        Me.ModeCase1.Name = "ModeCase1"
        Me.ModeCase1.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase1.TabIndex = 8
        Me.ModeCase1.Text = "Operation For Tibero"
        Me.ModeCase1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase1.UseVisualStyleBackColor = True
        '
        'ModeCase3
        '
        Me.ModeCase3.Location = New System.Drawing.Point(434, 25)
        Me.ModeCase3.Name = "ModeCase3"
        Me.ModeCase3.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase3.TabIndex = 10
        Me.ModeCase3.Text = "SQL Name Mapper"
        Me.ModeCase3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase3.UseVisualStyleBackColor = True
        '
        'ModeCase0
        '
        Me.ModeCase0.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ModeCase0.Location = New System.Drawing.Point(20, 25)
        Me.ModeCase0.Name = "ModeCase0"
        Me.ModeCase0.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase0.TabIndex = 7
        Me.ModeCase0.Text = "Operation For Oracle"
        Me.ModeCase0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase0.UseVisualStyleBackColor = True
        '
        'ModeCase2
        '
        Me.ModeCase2.Location = New System.Drawing.Point(296, 25)
        Me.ModeCase2.Name = "ModeCase2"
        Me.ModeCase2.Size = New System.Drawing.Size(120, 100)
        Me.ModeCase2.TabIndex = 9
        Me.ModeCase2.Text = "Data " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Migration"
        Me.ModeCase2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ModeCase2.UseVisualStyleBackColor = True
        '
        'PasswdToolStrip
        '
        Me.PasswdToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.PasswdToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.PasswdToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.CertiPw, Me.ToolStripSeparator1, Me.OkBt})
        Me.PasswdToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.PasswdToolStrip.Name = "PasswdToolStrip"
        Me.PasswdToolStrip.Size = New System.Drawing.Size(373, 25)
        Me.PasswdToolStrip.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 22)
        Me.ToolStripLabel1.Text = "패스워드"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CertiPw
        '
        Me.CertiPw.MaxLength = 18
        Me.CertiPw.Name = "CertiPw"
        Me.CertiPw.Size = New System.Drawing.Size(250, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'OkBt
        '
        Me.OkBt.Image = CType(resources.GetObject("OkBt.Image"), System.Drawing.Image)
        Me.OkBt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OkBt.Name = "OkBt"
        Me.OkBt.Size = New System.Drawing.Size(51, 22)
        Me.OkBt.Text = "확인"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip1)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.LicenseRTB)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.ActionGB)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(574, 408)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(574, 455)
        Me.ToolStripContainer1.TabIndex = 12
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.PasswdToolStrip)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsgTSSL})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(574, 22)
        Me.StatusStrip1.TabIndex = 0
        '
        'MsgTSSL
        '
        Me.MsgTSSL.Name = "MsgTSSL"
        Me.MsgTSSL.Size = New System.Drawing.Size(53, 17)
        Me.MsgTSSL.Text = "Message"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(574, 455)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Title"
        Me.ActionGB.ResumeLayout(False)
        Me.PasswdToolStrip.ResumeLayout(False)
        Me.PasswdToolStrip.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LicenseRTB As System.Windows.Forms.RichTextBox
    Friend WithEvents PasswdToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OkBt As System.Windows.Forms.ToolStripButton
    Friend WithEvents CertiPw As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModeCase3 As System.Windows.Forms.Button
    Friend WithEvents ModeCase2 As System.Windows.Forms.Button
    Friend WithEvents ModeCase1 As System.Windows.Forms.Button
    Friend WithEvents ModeCase0 As System.Windows.Forms.Button
    Friend WithEvents ActionGB As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MsgTSSL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ModeCase7 As System.Windows.Forms.Button
    Friend WithEvents ModeCase6 As System.Windows.Forms.Button
    Friend WithEvents ModeCase5 As System.Windows.Forms.Button
    Friend WithEvents ModeCase4 As System.Windows.Forms.Button
End Class
