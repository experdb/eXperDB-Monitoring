<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindForNtPad
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FindTextBox = New System.Windows.Forms.TextBox()
        Me.NextFindBtn = New System.Windows.Forms.Button()
        Me.MWWO_CHKBOX = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MC_CHKBOX = New System.Windows.Forms.CheckBox()
        Me.PreFindBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CountAllBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "찾을 내용 :"
        '
        'FindTextBox
        '
        Me.FindTextBox.Location = New System.Drawing.Point(89, 9)
        Me.FindTextBox.Name = "FindTextBox"
        Me.FindTextBox.Size = New System.Drawing.Size(209, 21)
        Me.FindTextBox.TabIndex = 1
        '
        'NextFindBtn
        '
        Me.NextFindBtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.NextFindBtn.Location = New System.Drawing.Point(319, 9)
        Me.NextFindBtn.Name = "NextFindBtn"
        Me.NextFindBtn.Size = New System.Drawing.Size(75, 23)
        Me.NextFindBtn.TabIndex = 2
        Me.NextFindBtn.Text = "다음 찾기"
        Me.NextFindBtn.UseVisualStyleBackColor = True
        '
        'MWWO_CHKBOX
        '
        Me.MWWO_CHKBOX.AutoSize = True
        Me.MWWO_CHKBOX.Location = New System.Drawing.Point(6, 20)
        Me.MWWO_CHKBOX.Name = "MWWO_CHKBOX"
        Me.MWWO_CHKBOX.Size = New System.Drawing.Size(159, 16)
        Me.MWWO_CHKBOX.TabIndex = 3
        Me.MWWO_CHKBOX.Text = "Match Whole Word Only"
        Me.MWWO_CHKBOX.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MC_CHKBOX)
        Me.GroupBox1.Controls.Add(Me.MWWO_CHKBOX)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 72)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'MC_CHKBOX
        '
        Me.MC_CHKBOX.AutoSize = True
        Me.MC_CHKBOX.Location = New System.Drawing.Point(6, 43)
        Me.MC_CHKBOX.Name = "MC_CHKBOX"
        Me.MC_CHKBOX.Size = New System.Drawing.Size(93, 16)
        Me.MC_CHKBOX.TabIndex = 4
        Me.MC_CHKBOX.Text = "Match Case"
        Me.MC_CHKBOX.UseVisualStyleBackColor = True
        '
        'PreFindBtn
        '
        Me.PreFindBtn.Location = New System.Drawing.Point(319, 37)
        Me.PreFindBtn.Name = "PreFindBtn"
        Me.PreFindBtn.Size = New System.Drawing.Size(75, 23)
        Me.PreFindBtn.TabIndex = 5
        Me.PreFindBtn.Text = "이전 찾기"
        Me.PreFindBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.Location = New System.Drawing.Point(319, 95)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "종료"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'CountAllBtn
        '
        Me.CountAllBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CountAllBtn.Location = New System.Drawing.Point(319, 66)
        Me.CountAllBtn.Name = "CountAllBtn"
        Me.CountAllBtn.Size = New System.Drawing.Size(75, 23)
        Me.CountAllBtn.TabIndex = 7
        Me.CountAllBtn.Text = "세기"
        Me.CountAllBtn.UseVisualStyleBackColor = True
        '
        'frmFindForNtPad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CancelButton = Me.CloseBtn
        Me.ClientSize = New System.Drawing.Size(403, 135)
        Me.Controls.Add(Me.CountAllBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.PreFindBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NextFindBtn)
        Me.Controls.Add(Me.FindTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmFindForNtPad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "찾기"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FindTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NextFindBtn As System.Windows.Forms.Button
    Friend WithEvents MWWO_CHKBOX As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MC_CHKBOX As System.Windows.Forms.CheckBox
    Friend WithEvents PreFindBtn As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents CountAllBtn As System.Windows.Forms.Button
End Class
