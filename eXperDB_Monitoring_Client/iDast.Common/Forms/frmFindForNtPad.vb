Imports System.Windows.Forms

Public Class frmFindForNtPad
    Private rtb As RichTextBox = Nothing
    Private findPos As Integer = 0
    Private findEndPos As Integer = 0
    Public Sub New(ByVal rtb As RichTextBox)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.     
        Me.rtb = rtb
        Me.TopLevel = True
    End Sub
    Private Sub NextFindBtn_Click(sender As System.Object, e As System.EventArgs) Handles NextFindBtn.Click
        Try
            Dim findText As String = FindTextBox.Text
            rtb.Focus()

            If (findPos <> rtb.SelectionStart + rtb.SelectionLength) Then
                findPos = rtb.SelectionStart
            End If
            Dim currFindPos As Integer = 0
            If (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = True) Then
                currFindPos = rtb.Find(findText, findPos, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
            ElseIf (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = False) Then
                currFindPos = rtb.Find(findText, findPos, RichTextBoxFinds.WholeWord)
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = True) Then
                currFindPos = rtb.Find(findText, findPos, RichTextBoxFinds.MatchCase)
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = False) Then
                currFindPos = rtb.Find(findText, findPos, RichTextBoxFinds.None)
            End If


            If (currFindPos = -1) Then
                MsgBox("해당 단어를 찾을 수 없습니다.", MsgBoxStyle.Information, "알림")
            Else
                findPos = currFindPos
                rtb.Select(findPos, findText.Length)
                findPos += findText.Length
            End If
        Catch ex As Exception
            MsgBox("해당 단어를 찾을 수 없습니다.", MsgBoxStyle.Critical, "경고")
        End Try

    End Sub

    Private Sub CloseBtn_Click(sender As System.Object, e As System.EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub PreFindBtn_Click(sender As System.Object, e As System.EventArgs) Handles PreFindBtn.Click
        Try
            Dim findText As String = FindTextBox.Text
            rtb.Focus()

            If (findPos <> rtb.SelectionStart + rtb.SelectionLength) Then
                findPos = rtb.SelectionStart
            End If
            Dim currFindPos As Integer = 0
            Dim options As RichTextBoxFinds
            If (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = True) Then
                options = RichTextBoxFinds.WholeWord Or RichTextBoxFinds.MatchCase Or RichTextBoxFinds.Reverse
            ElseIf (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = False) Then
                options = RichTextBoxFinds.WholeWord Or RichTextBoxFinds.Reverse
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = True) Then
                options = RichTextBoxFinds.MatchCase Or RichTextBoxFinds.Reverse
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = False) Then
                options = RichTextBoxFinds.None Or RichTextBoxFinds.Reverse
            End If
            currFindPos = rtb.Find(findText, 1, findPos, options)

            If (currFindPos = -1) Then
                MsgBox("해당 단어를 찾을 수 없습니다.", MsgBoxStyle.Information, "알림")
            Else
                findPos = currFindPos
                rtb.Select(findPos, findText.Length)
            End If
        Catch ex As Exception
            MsgBox("해당 단어를 찾을 수 없습니다.", MsgBoxStyle.Critical, "경고")
        End Try
    End Sub

    Private Sub CountAllBtn_Click(sender As System.Object, e As System.EventArgs) Handles CountAllBtn.Click
        Try
            Dim findText As String = FindTextBox.Text
            Dim options As RichTextBoxFinds
            If (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = True) Then
                options = RichTextBoxFinds.WholeWord Or RichTextBoxFinds.MatchCase
            ElseIf (MWWO_CHKBOX.Checked = True And MC_CHKBOX.Checked = False) Then
                options = RichTextBoxFinds.WholeWord
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = True) Then
                options = RichTextBoxFinds.MatchCase
            ElseIf (MWWO_CHKBOX.Checked = False And MC_CHKBOX.Checked = False) Then
                options = RichTextBoxFinds.None
            End If
            Dim currFindPos As Integer = 1
            Dim cnt As Integer = -1
            While (currFindPos <> -1)
                currFindPos = rtb.Find(findText, currFindPos + findText.Length, options)
                'currFindPos += findText.Length
                cnt += 1
            End While
            MsgBox(cnt & "개의 로우를 찾았습니다.", MsgBoxStyle.Information, "알림")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class