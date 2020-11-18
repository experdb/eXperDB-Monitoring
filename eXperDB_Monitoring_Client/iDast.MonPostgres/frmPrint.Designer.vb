<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.mnuChartMenu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsmiPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPageSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiPreview = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.mnuChartMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuChartMenu
        '
        Me.mnuChartMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuChartMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.mnuChartMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuChartMenu.Name = "mnuChartMenu"
        Me.mnuChartMenu.Size = New System.Drawing.Size(722, 27)
        Me.mnuChartMenu.TabIndex = 3
        Me.mnuChartMenu.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiPrint, Me.tsmiPageSetup, Me.tsmiPreview, Me.tsmiSave})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(98, 24)
        Me.ToolStripDropDownButton1.Text = "인쇄&&저장"
        '
        'tsmiPrint
        '
        Me.tsmiPrint.Name = "tsmiPrint"
        Me.tsmiPrint.Size = New System.Drawing.Size(138, 22)
        Me.tsmiPrint.Text = "인쇄"
        '
        'tsmiPageSetup
        '
        Me.tsmiPageSetup.Name = "tsmiPageSetup"
        Me.tsmiPageSetup.Size = New System.Drawing.Size(138, 22)
        Me.tsmiPageSetup.Text = "페이지 설정"
        '
        'tsmiPreview
        '
        Me.tsmiPreview.Name = "tsmiPreview"
        Me.tsmiPreview.Size = New System.Drawing.Size(138, 22)
        Me.tsmiPreview.Text = "미리보기"
        '
        'tsmiSave
        '
        Me.tsmiSave.Name = "tsmiSave"
        Me.tsmiSave.Size = New System.Drawing.Size(138, 22)
        Me.tsmiSave.Text = "저장하기"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 27)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(722, 578)
        Me.WebBrowser1.TabIndex = 4
        Me.WebBrowser1.Url = New System.Uri("http://www.experdb.com", System.UriKind.Absolute)
        '
        'frmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 605)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.mnuChartMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrint"
        Me.Text = "frmPrint"
        Me.mnuChartMenu.ResumeLayout(False)
        Me.mnuChartMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuChartMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tsmiPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPageSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiPreview As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
End Class
