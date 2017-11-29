<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotePad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotePad))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.NoteRCTextBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ErrTextLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AsIsLineLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsSaveTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrtTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.NoteRCTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.NoteRCTextBox)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.StatusStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(566, 366)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(566, 390)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'NoteRCTextBox
        '
        Me.NoteRCTextBox.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.NoteRCTextBox.BackBrush = Nothing
        Me.NoteRCTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoteRCTextBox.CharHeight = 14
        Me.NoteRCTextBox.CharWidth = 8
        Me.NoteRCTextBox.CommentPrefix = "--"
        Me.NoteRCTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NoteRCTextBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.NoteRCTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NoteRCTextBox.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.NoteRCTextBox.IsReplaceMode = False
        Me.NoteRCTextBox.Language = FastColoredTextBoxNS.Language.SQL
        Me.NoteRCTextBox.LeftBracket = Global.Microsoft.VisualBasic.ChrW(40)
        Me.NoteRCTextBox.Location = New System.Drawing.Point(0, 0)
        Me.NoteRCTextBox.Name = "NoteRCTextBox"
        Me.NoteRCTextBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.NoteRCTextBox.PreferredLineWidth = 80
        Me.NoteRCTextBox.RightBracket = Global.Microsoft.VisualBasic.ChrW(41)
        Me.NoteRCTextBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NoteRCTextBox.Size = New System.Drawing.Size(566, 344)
        Me.NoteRCTextBox.TabIndex = 4
        Me.NoteRCTextBox.Zoom = 100
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrTextLabel, Me.AsIsLineLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 344)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(566, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ErrTextLabel
        '
        Me.ErrTextLabel.AutoSize = False
        Me.ErrTextLabel.ForeColor = System.Drawing.Color.Red
        Me.ErrTextLabel.Name = "ErrTextLabel"
        Me.ErrTextLabel.Size = New System.Drawing.Size(494, 17)
        Me.ErrTextLabel.Spring = True
        Me.ErrTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AsIsLineLabel
        '
        Me.AsIsLineLabel.Name = "AsIsLineLabel"
        Me.AsIsLineLabel.Size = New System.Drawing.Size(57, 17)
        Me.AsIsLineLabel.Text = "줄 0 열 0"
        Me.AsIsLineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILE, Me.EditTSMI})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(566, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILE
        '
        Me.FILE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTSMI, Me.OpenTSMI, Me.ToolStripSeparator4, Me.SaveTSMI, Me.AsSaveTSMI, Me.ToolStripSeparator5, Me.PrtTSMI, Me.ToolStripSeparator6, Me.ExitTSMI})
        Me.FILE.Name = "FILE"
        Me.FILE.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FILE.Size = New System.Drawing.Size(57, 20)
        Me.FILE.Text = "파일(&F)"
        '
        'NewTSMI
        '
        Me.NewTSMI.Name = "NewTSMI"
        Me.NewTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTSMI.Size = New System.Drawing.Size(237, 22)
        Me.NewTSMI.Text = "새로 만들기(N)"
        '
        'OpenTSMI
        '
        Me.OpenTSMI.Name = "OpenTSMI"
        Me.OpenTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenTSMI.Size = New System.Drawing.Size(237, 22)
        Me.OpenTSMI.Text = "열기(O)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(234, 6)
        '
        'SaveTSMI
        '
        Me.SaveTSMI.Name = "SaveTSMI"
        Me.SaveTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveTSMI.Size = New System.Drawing.Size(237, 22)
        Me.SaveTSMI.Text = "저장(S)"
        '
        'AsSaveTSMI
        '
        Me.AsSaveTSMI.Name = "AsSaveTSMI"
        Me.AsSaveTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.AsSaveTSMI.Size = New System.Drawing.Size(237, 22)
        Me.AsSaveTSMI.Text = "다른 이름으로 저장(A)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(234, 6)
        '
        'PrtTSMI
        '
        Me.PrtTSMI.Name = "PrtTSMI"
        Me.PrtTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrtTSMI.Size = New System.Drawing.Size(237, 22)
        Me.PrtTSMI.Text = "인쇄(P)"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(234, 6)
        '
        'ExitTSMI
        '
        Me.ExitTSMI.Name = "ExitTSMI"
        Me.ExitTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitTSMI.Size = New System.Drawing.Size(237, 22)
        Me.ExitTSMI.Text = "종료(Q)"
        '
        'EditTSMI
        '
        Me.EditTSMI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoTSMI, Me.RedoTSMI, Me.ToolStripSeparator1, Me.CutTSMI, Me.CopyTSMI, Me.PasteTSMI, Me.ToolStripSeparator2, Me.SelectAllTSMI, Me.FindToolStripMenuItem})
        Me.EditTSMI.Name = "EditTSMI"
        Me.EditTSMI.Size = New System.Drawing.Size(57, 20)
        Me.EditTSMI.Text = "편집(&E)"
        '
        'UndoTSMI
        '
        Me.UndoTSMI.Name = "UndoTSMI"
        Me.UndoTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoTSMI.Size = New System.Drawing.Size(168, 22)
        Me.UndoTSMI.Text = "실행 취소"
        '
        'RedoTSMI
        '
        Me.RedoTSMI.Name = "RedoTSMI"
        Me.RedoTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoTSMI.Size = New System.Drawing.Size(168, 22)
        Me.RedoTSMI.Text = "다시 실행"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(165, 6)
        '
        'CutTSMI
        '
        Me.CutTSMI.Name = "CutTSMI"
        Me.CutTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutTSMI.Size = New System.Drawing.Size(168, 22)
        Me.CutTSMI.Text = "잘라내기"
        '
        'CopyTSMI
        '
        Me.CopyTSMI.Name = "CopyTSMI"
        Me.CopyTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyTSMI.Size = New System.Drawing.Size(168, 22)
        Me.CopyTSMI.Text = "복사"
        '
        'PasteTSMI
        '
        Me.PasteTSMI.Name = "PasteTSMI"
        Me.PasteTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteTSMI.Size = New System.Drawing.Size(168, 22)
        Me.PasteTSMI.Text = "붙여넣기"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'SelectAllTSMI
        '
        Me.SelectAllTSMI.Name = "SelectAllTSMI"
        Me.SelectAllTSMI.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllTSMI.Size = New System.Drawing.Size(168, 22)
        Me.SelectAllTSMI.Text = "모두 선택"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.FindToolStripMenuItem.Text = "찾기"
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'PrintDocument
        '
        '
        'frmNotePad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 390)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNotePad"
        Me.Text = "Idast-NotePad"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.NoteRCTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsSaveTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrtTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents UndoTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectAllTSMI As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents AsIsLineLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ErrTextLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents NoteRCTextBox As FastColoredTextBoxNS.FastColoredTextBox
End Class
