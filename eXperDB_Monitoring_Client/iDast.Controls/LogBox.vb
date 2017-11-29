Public Class LogBox
    Inherits RichTextBox
    Private _LimitLineCount As Integer = 1000
    Property LimitLineCount As Integer
        Get
            Return _LimitLineCount
        End Get
        Set(value As Integer)
            _LimitLineCount = value

        End Set
    End Property

    Private Sub RemoveLine()

        Dim lng As Long = Me.Lines.LongCount
        If lng > _LimitLineCount Then
            SyncLock Me
                MyBase.SuspendLayout()
                For i As Integer = 0 To lng - _LimitLineCount - 1
                    Me.SelectionStart = 0
                    Me.SelectionLength = Me.Text.IndexOf(vbLf, 0) + 1
                    Me.SelectedText = String.Empty
                Next
                MyBase.ResumeLayout()
            End SyncLock
        End If


    End Sub

    Public Overloads Sub AppendText(ByVal Text As String)
        ''MsgQueue.Enqueue(New AAA(Text, Me.ForeColor))
        AppendText(Text, Me.ForeColor)
        'Me.SelectionStart = Me.TextLength
        'Me.SelectionColor = Me.ForeColor
        'MyBase.AppendText(Text)
        'RemoveLine()
        'Me.SelectionStart = Me.TextLength
        'Me.ScrollToCaret()

    End Sub
    Private MsgQueue As New Queue(Of AAA)

    Private Structure AAA
        Dim Text As String
        Dim txtClr As Color
        Public Sub New(ByVal strText As String, ByVal clrTxtClr As Color)
            Text = strtext
            txtClr = clrTxtClr
        End Sub


    End Structure
    Public Overloads Sub AppendText(ByVal Text As String, ByVal txtClr As Color)
      
        'Me.SelectionStart = Me.TextLength
        'Me.SelectionColor = txtClr
        'MyBase.AppendText(Text)
        'RemoveLine()
        'Me.SelectionStart = Me.TextLength
        'Me.SelectionColor = Me.ForeColor
        'Me.ScrollToCaret()
                                                                      

        MsgQueue.Enqueue(New AAA(Text, txtClr))
        Try

       
            If BCK.IsBusy = False Then

                BCK.RunWorkerAsync()
            End If
        Catch ex As Exception
            GC.Collect()
        End Try

    End Sub


    Public Sub AppendNewLineText(ByVal Text As String)
        Me.AppendText(vbNewLine & Text)
    End Sub
    Public Sub AppendNewLineText(ByVal Text As String, ByVal txtClr As Color)
        Me.AppendText(vbNewLine & Text, txtClr)
    End Sub


    Public Sub AppendTextNewLine(ByVal Text As String)
        Me.AppendText(Text & vbNewLine)

    End Sub
    Public Sub AppendTextNewLine(ByVal Text As String, ByVal txtClr As Color)
        Me.AppendText(Text & vbNewLine, txtClr)
    End Sub


    Private WithEvents BCK As New System.ComponentModel.BackgroundWorker


    Private Sub BCK_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BCK.DoWork
        Try

      
        Do Until MsgQueue.Count = 0
            Me.Invoke(New MethodInvoker(Sub()
                                            Dim A As AAA = MsgQueue.Dequeue
                                            Me.SelectionStart = Me.TextLength
                                            Me.SelectionColor = A.txtClr
                                            MyBase.AppendText(A.Text)
                                            Me.SelectionStart = Me.TextLength
                                            Me.SelectionColor = Me.ForeColor
                                            Me.ScrollToCaret()

                                        End Sub))

            Threading.Thread.Sleep(1)
            Loop
            Me.Invoke(New MethodInvoker(Sub()
                                            RemoveLine()
                                            Me.SelectionStart = Me.TextLength
                                            Me.SelectionColor = Me.ForeColor
                                            Me.ScrollToCaret()
                                        End Sub))
       
        Catch ex As Exception
            GC.Collect()
        Finally

        End Try
    End Sub


     
    Private Sub BCK_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BCK.RunWorkerCompleted

    End Sub
End Class
