Imports System.IO
Imports System.Text
Imports gudusoft.gsqlparser
Imports System.Drawing.Printing

Public Class frmNotePad

    Private COC As New ClsObjectCtl
    Private startBlock As Integer = -1
    Private endBlock As Integer = -1
    Private beforIndex As Integer = 0
    Private fileName As String = String.Empty
    Private isSave As Boolean = False
    'DataGridView에서 Load시에 사용
    Private isUsedByGV As Boolean = False 'DataGridView에서 Load하였는가
    Private gvRowindex As Integer = 0     'DataGridVIew Rows인덱스
    Private sqlTextCell As DataGridViewCell = Nothing
    Private FullSqlCell As DataGridViewCell = Nothing
    Private form As Object = Nothing
    Private dbV As TDbVendor = Nothing
    Private ErrMsg As String = String.Empty


    Private bgRcTextBox As New RichTextBox
    Private currText As String = String.Empty

    '2013-12-30 fastcolortextbox 변경으로 인해서 frmFind 수정
    'Private frmFind As frmFindForNtPad = Nothing
    Private frmfind As FastColoredTextBoxNS.FindForm = Nothing

    Private StringToPrint As String = String.Empty

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        Me.isSave = False
        NoteRCTextBox.Font = New Font("돋움체", iDAST_FontSize)
        NoteRCTextBox.IsChanged = False

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
    Public Sub New(ByVal text As String, sqlTextCell As DataGridViewCell, FullSqlCell As DataGridViewCell)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        isUsedByGV = True
        NewTSMI.Visible = False
        OpenTSMI.Visible = False
        AsSaveTSMI.Visible = False
        NoteRCTextBox.Font = New Font("돋움체", iDAST_FontSize)
        OpenText(text, sqlTextCell, FullSqlCell)
        'OpenText(text, rowindex)
    End Sub
    Public Sub New(ByVal fileName As String, Optional ByVal startBlock As Integer = -1, Optional ByVal endBlock As Integer = -1, Optional ByVal err As String = "", Optional ByVal form As Object = Nothing)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Me.Text = COC.FileNameWithExtension(fileName)
        Me.fileName = fileName
        Me.ErrMsg = err
        Me.form = form
        Me.dbV = dbV
        NoteRCTextBox.Font = New Font("돋움체", iDAST_FontSize)
        OpenFile(fileName, startBlock, endBlock, ErrMsg, form)
    End Sub
    Private Sub NewTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTSMI.Click
        NoteRCTextBox.Text = String.Empty
        Me.isSave = False
        NoteRCTextBox.IsChanged = False
    End Sub

    Private Sub OpenTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenTSMI.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All Files |*.*"
        ofd.ShowDialog()
        If ofd.FileName = String.Empty Then
            MsgBox("빈 이름 경로를 가진 파일을 열려고 합니다.", MsgBoxStyle.Critical, "경고 메시지")
            Exit Sub
        End If
        OpenFile(ofd.FileName)
    End Sub

    Private Sub SaveTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTSMI.Click
        Try
            If (isUsedByGV = False) Then
                If fileName <> "" Then

                    Try
                        If bgRcTextBox.Text <> String.Empty Then
                            bgRcTextBox.SelectedText = bgRcTextBox.SelectedText.Replace(bgRcTextBox.SelectedText, NoteRCTextBox.Text)
                            Me.endBlock = NoteRCTextBox.Text.Length
                            bgRcTextBox.Select(Me.startBlock, Me.endBlock)
                        Else
                            bgRcTextBox.Text = NoteRCTextBox.Text
                            bgRcTextBox.SelectAll()
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try

                    Using FWriter As New StreamWriter(fileName, False)
                        FWriter.WriteLine(bgRcTextBox.Text)
                    End Using

                    If (form IsNot Nothing) Then
                        'form.reparseSqlGV(NoteRCTextBox.Text)
                        form.reparseSqlGV(bgRcTextBox.SelectedText, Me.startBlock, Me.startBlock + Me.endBlock - 1)
                    End If
                Else
                    If (Not AsSave()) Then
                        MsgBox("저장이 실패했습니다.", MsgBoxStyle.Critical, "경고")
                    End If
                End If
            Else
                If (FullSqlCell IsNot Nothing) Then
                    FullSqlCell.Value = NoteRCTextBox.Text
                End If
                If (sqlTextCell IsNot Nothing) Then
                    sqlTextCell.Value = NoteRCTextBox.Text.Substring(0, 99)
                End If
            End If
            Me.isSave = True
            NoteRCTextBox.IsChanged = False
            MsgBox("정상적으로 저장되었습니다.", MsgBoxStyle.Information, "정보")

        Catch ex As Exception
            Me.isSave = False
            NoteRCTextBox.IsChanged = False
            MsgBox("저장이 실패했습니다.", MsgBoxStyle.Critical, "경고")
        End Try
    End Sub
    Private Sub AsSaveTSMI_Click(sender As System.Object, e As System.EventArgs) Handles AsSaveTSMI.Click
        If (Not AsSave()) Then
            MsgBox("저장이 실패했습니다.", MsgBoxStyle.Critical, "경고")
        End If
    End Sub
    Private Function AsSave() As Boolean
        Try
            SaveFileDialog.Filter = "Sql Files(*.sql)|*.sql|Text Files(*.txt)|*.txt|All Files(*.*)|*.*"
            SaveFileDialog.FileName = Me.Text
            SaveFileDialog.ShowDialog()
            If SaveFileDialog.FileName <> "" Then
                fileName = SaveFileDialog.FileName
                Using FWriter As New StreamWriter(fileName, False)
                    FWriter.WriteLine(NoteRCTextBox.Text)
                End Using
                Me.isSave = True
                NoteRCTextBox.IsChanged = False
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Me.isSave = False
            NoteRCTextBox.IsChanged = False
            Return False
        End Try
    End Function
    Public Function GetSaveFileName() As String
        Return fileName
    End Function
    Private Sub PrtTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrtTSMI.Click
        Try
            Dim result As DialogResult = PrintDialog.ShowDialog()
            If (result = Windows.Forms.DialogResult.OK) Then
                'NoteRCTextBox.Text = PrintDialog.PrintToFile
                StringToPrint = NoteRCTextBox.Text
                PrintDocument.Print()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "경고 메시지")
        End Try
    End Sub

    Private Sub ExitTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitTSMI.Click
        Close()
    End Sub
    Public Function OpenText(ByVal text As String, sqlTextCell As DataGridViewCell, fullSqlCell As DataGridViewCell) As Boolean ', rowindex As Integer) As Boolean
        NoteRCTextBox.Text = text
        'gvRowindex = rowindex
        Me.sqlTextCell = sqlTextCell
        Me.FullSqlCell = fullSqlCell
        Me.isSave = False
        NoteRCTextBox.IsChanged = False
        Return True
    End Function
    Public Function OpenFile(ByVal filePath As String, Optional ByVal startBlock As Integer = -1, Optional ByVal endBlock As Integer = -1, Optional ByVal err As String = "", Optional ByVal form As Object = Nothing) As Boolean
        'Dim AllText As String = "", Lineoftext As String = ""
        Dim fr As StreamReader = Nothing
        Me.fileName = filePath
        Me.Text = COC.FileNameWithExtension(fileName)
        Me.form = form
        Try

            ErrTextLabel.Text = err




            'fr = New StreamReader(filePath)


            fr = New StreamReader(filePath, COC.DetectEnc(filePath), True)
            'fr = New StreamReader(filePath, System.Text.Encoding.Default, True)
            'fr = New StreamReader(filePath, System.Text.Encoding.UTF8, True)
            Dim AllText As String = fr.ReadToEnd

            If (startBlock <> -1 And endBlock <> -1) Then

                If (Me.startBlock <> -1 And Me.endBlock <> -1) Then

                    '2013-12-30 fastcolortextbox 변경으로 인해서  주석처리함.
                    'NoteRCTextBox.Select(startBlock, endBlock - startBlock + 1)


                    'NoteRCTextBox.SelectionBackColor = Color.White
                End If
                Me.startBlock = startBlock
                Me.endBlock = endBlock

                'bgRcTextBox.Text = AllText.Replace(vbTab, " ").Replace(vbCrLf, " " & vbNewLine).Replace("\t", " ")
                If AllText.IndexOf(vbCrLf) >= 0 Then
                    bgRcTextBox.Text = AllText.Replace(vbTab, " ").Replace(vbCrLf, " " & vbNewLine).Replace("\t", " ")
                    'ElseIf AllText.IndexOf(vbLf) >= 0 Then
                    '    bgRcTextBox.Text = AllText.Replace(vbTab, " ").Replace(vbLf, " " & vbNewLine).Replace("\t", " ")
                Else
                    bgRcTextBox.Text = AllText
                    'Dim cnt As Integer = 0
                    'Dim idx As Integer = 0
                    'idx = AllText.IndexOf(" ")
                    'While idx > -1
                    '    idx = AllText.IndexOf(" ", idx + 1)
                    '    cnt += 1
                    'End While

                    'endBlock += cnt
                End If
                'bgRcTextBox.Text = AllText.Replace(vbTab, " ").Replace(vbCrLf, " " & vbNewLine).Replace("\t", " ")
                'bgRcTextBox.Text = AllText
                bgRcTextBox.Select(startBlock, endBlock - startBlock + 1)
                NoteRCTextBox.Text = bgRcTextBox.SelectedText

                Me.isSave = False

                '2013-12-30 fastcolortextbox 변경으로 인해서  Modified -> IsChanged 코드수정
                'NoteRCTextBox.Modified = False
                NoteRCTextBox.IsChanged = False


            Else
                bgRcTextBox.Text = String.Empty
                NoteRCTextBox.Text = AllText

                Me.isSave = False

                '2013-12-30 fastcolortextbox 변경으로 인해서  Modified -> IsChanged 코드수정
                'NoteRCTextBox.Modified = False
                NoteRCTextBox.IsChanged = False
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "경고 메시지")
            Return False
        Finally
            fr.Close()
        End Try
    End Function


    Private Sub UndoTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoTSMI.Click
        NoteRCTextBox.Undo()
    End Sub

    Private Sub RedoTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoTSMI.Click
        NoteRCTextBox.Redo()
    End Sub

    Private Sub CutTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutTSMI.Click
        NoteRCTextBox.Cut()
    End Sub

    Private Sub CopyTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyTSMI.Click
        NoteRCTextBox.Copy()
    End Sub

    Private Sub PasteTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteTSMI.Click
        NoteRCTextBox.Paste()
    End Sub

    Private Sub SelectAllTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllTSMI.Click
        NoteRCTextBox.SelectAll()
    End Sub

    'Private Sub ClearAllTSMI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAllTSMI.Click
    '    NoteRCTextBox.Clear()
    'End Sub




    'Private Sub SqlText_SelectionChanged(sender As Object, e As EventArgs) Handles SqlText.SelectionChanged
    '    Try
    '        Console.WriteLine(SqlText.LinesCount)
    '        Console.WriteLine(SqlText.LineInfos)
    '        Console.WriteLine(Now.ToString("yyyyMMdd"))
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '    End Try
    'End Sub
    Private Sub frmNotePad_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try

            '2013-12-30 fastcolortextbox 변경으로 인해서  Modified -> IsChanged 코드수정
            'If (NoteRCTextBox.Modified And isSave = False) Then
            'If (NoteRCTextBox.IsChanged And isSave = False) Then


            If (NoteRCTextBox.IsChanged) Then
                Dim result As MsgBoxResult = MsgBox("변경된 사항을 저장하지 않았습니다. 저장하시겠습니까?", MsgBoxStyle.YesNo, "저장확인")
                If (result = MsgBoxResult.Yes) Then
                    If (isUsedByGV) Then
                        FullSqlCell.Value = NoteRCTextBox.Text
                        sqlTextCell.Value = NoteRCTextBox.Text.Substring(0, 99)
                    Else
                        If (Not AsSave()) Then
                            MsgBox("저장이 실패했습니다.", MsgBoxStyle.Critical, "경고")
                        End If
                    End If
                End If
            End If


            'If (NoteRCTextBox.IsChanged And isSave = False) Then
            '    Dim result As MsgBoxResult = MsgBox("변경된 사항을 저장하지 않았습니다. 저장하시겠습니까?", MsgBoxStyle.YesNo, "저장확인")
            '    If (result = MsgBoxResult.Yes) Then
            '        If (isUsedByGV) Then
            '            FullSqlCell.Value = NoteRCTextBox.Text
            '            sqlTextCell.Value = NoteRCTextBox.Text.Substring(0, 99)
            '        Else
            '            If (Not AsSave()) Then
            '                MsgBox("저장이 실패했습니다.", MsgBoxStyle.Critical, "경고")
            '            End If
            '        End If
            '    End If
            'End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub ErrTextLabel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ErrTextLabel.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left And e.Clicks = 2) Then
            MsgBox(ErrTextLabel.Text, MsgBoxStyle.Information, "Parsing Error Message")
        End If
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Try
            'Dim frmFind As frmFindForNtPad = New frmFindForNtPad(NoteRCTextBox)
            If (frmFind Is Nothing) Then

                '2013-12-30 fastcolortextbox 변경으로 인해서  frmFind 수정
                'frmFind = New frmFindForNtPad(NoteRCTextBox)
                frmFind = New FastColoredTextBoxNS.FindForm(NoteRCTextBox)

            ElseIf (frmFind.IsDisposed) Then

                '2013-12-30 fastcolortextbox 변경으로 인해서 frmFind 수정
                'frmFind = New frmFindForNtPad(NoteRCTextBox)
                frmFind = New FastColoredTextBoxNS.FindForm(NoteRCTextBox)

            End If

            frmFind.Show()
            frmFind.Focus()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub frmNotePad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            NewTSMI.Image = COC.PuplationIco(eXperDB.Resources.iResources.document).ToBitmap
            OpenTSMI.Image = COC.PuplationIco(eXperDB.Resources.iResources.document).ToBitmap
            SaveTSMI.Image = COC.PuplationIco(eXperDB.Resources.iResources.save).ToBitmap
            PrtTSMI.Image = COC.PuplationIco(eXperDB.Resources.iResources.print).ToBitmap

            '폰트변환 막기
            '2013-12-30 fastcolortextbox 변경으로 인해서  주석처리함.
            'NoteRCTextBox.LanguageOption = 0


            'COC.SetSqlTextBox(SqlText)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Try
            Dim numChars As Integer
            Dim numLines As Integer
            Dim stringForPage As String
            Dim strFormat As New StringFormat()
            Dim PrintFont As Font
            PrintFont = NoteRCTextBox.Font
            Dim rectDraw As New RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height)
            Dim sizeMeasure As New SizeF(e.MarginBounds.Width, e.MarginBounds.Height - PrintFont.GetHeight(e.Graphics))

            strFormat.Trimming = StringTrimming.Word
            e.Graphics.MeasureString(StringToPrint, PrintFont, sizeMeasure, strFormat, numChars, numLines)
            stringForPage = StringToPrint.Substring(0, numChars)
            e.Graphics.DrawString(stringForPage, PrintFont, Brushes.Black, rectDraw, strFormat)

            If numChars < StringToPrint.Length Then
                StringToPrint = StringToPrint.Substring(numChars)
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub NoteRCTextBox_CursorChanged(sender As Object, e As EventArgs) Handles NoteRCTextBox.CursorChanged
        Try
            '2013-12-30 fastcolortextbox 변경으로 인해서  주석처리함.
            'Dim index As Integer = NoteRCTextBox.SelectionStart
            'Dim line As Integer = NoteRCTextBox.GetLineFromCharIndex(index)
            'Dim colIndex As Integer = index - index - NoteRCTextBox.GetFirstCharIndexFromLine(line)

            Dim line As Integer = NoteRCTextBox.Selection.Start.iLine
            Dim colIndex As Integer = NoteRCTextBox.Selection.Start.iChar
            Dim lineInfo As String = "줄 " & line & " 열 " & colIndex
            AsIsLineLabel.Text = lineInfo
            COC.DoEvents()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub NoteRCTextBox_SelectionChanged(sender As Object, e As EventArgs) Handles NoteRCTextBox.SelectionChanged
        Try
            '마우스 드래그 및 Key로 위치 변경 시에 Column 위치 텍스트 변경
            Dim index As Integer = NoteRCTextBox.SelectionStart

            '현재 위치보다 증가 시에
            If (beforIndex = index) Then
                beforIndex = index
                index = index + NoteRCTextBox.SelectionLength
                '현재 위치보다 적어 질 때
            Else
                beforIndex = index
                index = index
            End If

            '2013-12-30 fastcolortextbox 변경으로 인해서  주석처리함.
            'Dim line As Integer = NoteRCTextBox.GetLineFromCharIndex(index)
            'Dim colIndex As Integer = index - NoteRCTextBox.GetFirstCharIndexFromLine(line)

            Dim line As Integer = NoteRCTextBox.Selection.Start.iLine
            Dim colIndex As Integer = NoteRCTextBox.Selection.Start.iChar
            Dim lineInfo As String = "줄 " & line + 1 & " 열 " & colIndex + 1
            AsIsLineLabel.Text = lineInfo
            COC.DoEvents()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class