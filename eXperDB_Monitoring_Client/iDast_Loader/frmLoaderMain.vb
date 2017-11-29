Public Class frmLoaderMain
    Private Sub frmLoaderMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Try
            'With New frmLoaderReg
            '    .StartPosition = FormStartPosition.CenterParent
            '    If .ShowDialog = Windows.Forms.DialogResult.OK Then

            '    End If
            'End With

            With New frmRegMasking
                .StartPosition = FormStartPosition.CenterParent
                If .ShowDialog = Windows.Forms.DialogResult.OK Then

                End If
            End With
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub

    Private Sub frmLoaderMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            AddBtn.PerformClick()
        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
End Class