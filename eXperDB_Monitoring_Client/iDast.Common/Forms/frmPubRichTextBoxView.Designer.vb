<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPubRichTextBoxView
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
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SqlStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.SqlLineLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SqlStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox
        '
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(511, 247)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = ""
        '
        'SqlStatusStrip
        '
        Me.SqlStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SqlLineLabel})
        Me.SqlStatusStrip.Location = New System.Drawing.Point(0, 247)
        Me.SqlStatusStrip.Name = "SqlStatusStrip"
        Me.SqlStatusStrip.Size = New System.Drawing.Size(511, 22)
        Me.SqlStatusStrip.TabIndex = 9
        Me.SqlStatusStrip.Text = "StatusStrip2"
        '
        'SqlLineLabel
        '
        Me.SqlLineLabel.Name = "SqlLineLabel"
        Me.SqlLineLabel.Size = New System.Drawing.Size(57, 17)
        Me.SqlLineLabel.Text = "줄 0 열 0"
        '
        'frmPubRichTextBoxView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 269)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.SqlStatusStrip)
        Me.Name = "frmPubRichTextBoxView"
        Me.Text = "frmPubRichBoxView"
        Me.SqlStatusStrip.ResumeLayout(False)
        Me.SqlStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SqlStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents SqlLineLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents RichTextBox As System.Windows.Forms.RichTextBox
End Class
