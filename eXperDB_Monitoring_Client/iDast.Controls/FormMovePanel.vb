Public Class FormMovePanel
    Inherits Windows.Forms.Panel
    Private _OffLocation As New Point(0, 0)
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If Me.Cursor = Cursors.SizeAll Then
            Debug.Print(e.Clicks)
            _OffLocation = New Point(e.X, e.Y)
            Me.FindForm.SuspendLayout()

        End If
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        If Me.Cursor = Cursors.SizeAll Then
            Me.Cursor = Cursors.Default
            Me.FindForm.ResumeLayout()
        End If
    End Sub
 
    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

        If Me.FindForm.WindowState = FormWindowState.Normal Then
            Me.Cursor = Cursors.SizeAll
        End If

        If Me.Cursor = Cursors.SizeAll AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            Me.FindForm.Location = Me.PointToScreen(New Point(e.X - _OffLocation.X, e.Y - _OffLocation.Y))
        End If
    End Sub

    Private _Text As String = ""
    <System.ComponentModel.Browsable(True)> _
    Overrides Property Text As String
        Get
            Return _Text
        End Get
        Set(value As String)
            If Not _Text.Equals(value) Then
                _Text = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        If _Text <> "" Then
            e.Graphics.DrawString(_Text, MyBase.Font, New SolidBrush(MyBase.ForeColor), New Point(2, (MyBase.Height - MyBase.Font.Height) / 2))

        End If

    End Sub

End Class
