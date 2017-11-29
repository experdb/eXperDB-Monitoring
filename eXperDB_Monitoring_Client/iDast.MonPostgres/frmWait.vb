Public Class frmWait


    Private _LstDate As DateTime
    Private _LstStr As String = ""

    Public Sub AddText(ByVal str As String)


        _LstStr = str
        Me.Invoke(New MethodInvoker(Sub()
                                        Me.logEvents.AppendTextNewLine(_LstStr & " ......00:00:00")
                                        _LstDate = Now()
                                    End Sub))
    End Sub
     
    Dim stTime As DateTime
    Private Sub frmWait_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        stTime = Now

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim intVal As Long = DateDiff(DateInterval.Second, stTime, Now)
        Dim tmSpan As TimeSpan = TimeSpan.FromSeconds(intVal)

        Me.Invoke(New MethodInvoker(Sub()
                                        LogBox1.Text = "Elapsed Time : " & tmSpan.ToString
                                        Dim arrLines As String() = Me.logEvents.Lines
                                        If arrLines.Count > 1 Then
                                            arrLines(arrLines.Count - 2) = _LstStr & " ......" & TimeSpan.FromSeconds(DateDiff(DateInterval.Second, _LstDate, Now)).ToString

                                            Me.logEvents.Lines = arrLines
                                        End If

                                    End Sub))
        


    End Sub

     
    Private Sub logEvents_TextChanged(sender As Object, e As EventArgs) Handles logEvents.TextChanged

    End Sub
End Class