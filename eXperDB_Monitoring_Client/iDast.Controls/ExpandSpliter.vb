Public Class ExpandSpliter
    Inherits System.Windows.Forms.Splitter

    Private _ExpandImage As System.Drawing.Image = Nothing
    Property ExpandImage As Drawing.Image
        Get
            Return _ExpandImage
        End Get
        Set(value As Drawing.Image)
            If _ExpandImage Is Nothing OrElse Not _ExpandImage.Equals(value) Then
                _ExpandImage = value
                _DefImage = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _CollapseImage As System.Drawing.Image = Nothing
    Property CollapseImage As Drawing.Image
        Get
            Return _CollapseImage
        End Get
        Set(value As Drawing.Image)
            If _CollapseImage Is Nothing OrElse Not _CollapseImage.Equals(value) Then
                _CollapseImage = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _Expand As Boolean = True
    Property Expand As Boolean
        Get
            Return _Expand
        End Get
        Set(value As Boolean)
            If Not _Expand.Equals(value) Then
                _Expand = value
                ExpandChange(value)

            End If
        End Set
    End Property

    Private ImgArea As New Drawing.Rectangle(0, 0, 0, 0)


    Private _DefImage As System.Drawing.Image = Nothing

    Protected Overrides Sub OnPaint(e As Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If _DefImage IsNot Nothing Then
            Dim gr As System.Drawing.Graphics = e.Graphics
            gr.DrawImage(_DefImage, New Drawing.Point(0, (Me.Height - _DefImage.Height) / 2))
            ImgArea = New Drawing.Rectangle(0, (Me.Height - _DefImage.Height) / 2, _DefImage.Width, _DefImage.Height)
        End If
    End Sub

    


    Protected Overrides Sub OnMouseMove(e As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)
        If ImgArea.Contains(New Drawing.Point(e.X, e.Y)) Then
            Me.Cursor = Windows.Forms.Cursors.Hand
        Else
            If Me.Dock = Windows.Forms.DockStyle.Left Or Me.Dock = Windows.Forms.DockStyle.Right Then
                Me.Cursor = Windows.Forms.Cursors.VSplit
            Else
                Me.Cursor = Windows.Forms.Cursors.HSplit
            End If


        End If
    End Sub

    Protected Overrides Sub OnMouseDown(e As Windows.Forms.MouseEventArgs)

        If ImgArea.Contains(New Drawing.Point(e.X, e.Y)) Then
            ExpandChange(Not _Expand)
        Else
            MyBase.OnMouseDown(e)
        End If
    End Sub


    Private Sub ExpandChange(ByVal Bret As Boolean)
        If Me.Parent IsNot Nothing Then
            Dim pCtl As System.Windows.Forms.Control = Me.Parent.Controls(Me.Parent.Controls.IndexOfKey(Me.Name) + 1)
            pCtl.Visible = Bret
            If Bret = False Then
                _DefImage = _ExpandImage
            Else

                _DefImage = _CollapseImage
            End If
            _Expand = Bret
            Me.Invalidate()
        End If

    End Sub


End Class
