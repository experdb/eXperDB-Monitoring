Public Class FlatCombo
    Inherits ComboBox

    Private BorderBrush As Brush = New SolidBrush(SystemColors.Window)
    Private ArrowBrush As Brush = New SolidBrush(SystemColors.ControlText)
    Private DropButtonBrush As Brush = New SolidBrush(SystemColors.Control)
    Private _ButtonColor As Color = SystemColors.Control
    Private _BorderColor As Color = SystemColors.Control

    Public Sub New()
        SetStyle(ControlStyles.DoubleBuffer, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    Public Property ButtonColor() As Color
        Get
            Return _ButtonColor
        End Get
        Set(ByVal Value As Color)
            _ButtonColor = Value
            DropButtonBrush = New SolidBrush(Me.ButtonColor)
            Me.Invalidate()
        End Set
    End Property

    Public Property BorderColor() As Color
        Get
            Return _BorderColor
        End Get
        Set(ByVal Value As Color)
            _BorderColor = Value
            BorderBrush = New SolidBrush(Me._BorderColor)
            Me.Invalidate()
        End Set
    End Property

    Private m_Necessary As Boolean = False
    Public Property Necessary() As Boolean
        Get
            Return m_Necessary
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.BackColor = Drawing.SystemColors.GradientActiveCaption
            Else
                'Me.BackColor = Drawing.SystemColors.Window
            End If

            m_Necessary = value
        End Set
    End Property

    Private _FixedWidth As Boolean = True
    Property FixedWidth As Boolean
        Get
            Return _FixedWidth
        End Get
        Set(value As Boolean)
            If Not _FixedWidth.Equals(value) Then
                _FixedWidth = value
                If value = True Then
                    Me.OnResize(Nothing)

                End If
            End If
        End Set
    End Property

    Private _StatusTip As String = ""
    Property StatusTip As String
        Get
            Return _StatusTip
        End Get
        Set(value As String)
            _StatusTip = value
        End Set
    End Property

    Private _Value As String = ""
    Property ValueText As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            If Not MyBase.Text.Equals(value) Then
                MyBase.Text = value
                _Value = value
            End If
        End Set
    End Property

    Protected Overrides Sub WndProc(ByRef m As Message)

        If m.Msg = &H200 Or m.Msg = &H2A3 Or m.Msg = &H2A1 Then '0x0200, 0x02A3, 0x02A1
            m.Result = 1
            Return
        End If

        MyBase.WndProc(m)
        Select Case m.Msg
            Case &HF
                'Paint the background. Only the borders
                'will show up because the edit
                'box will be overlayed
                Dim g As Graphics = Me.CreateGraphics
                Dim p As Pen = New Pen(Color.White, 1)
                'g.FillRectangle(BorderBrush, Me.ClientRectangle)

                'Draw the background of the dropdown button
                'Dim rect As Rectangle = New Rectangle(Me.Width - 15, 3, 12, Me.Height - 6)
                Dim rect As Rectangle = New Rectangle(Me.Width - 20, 1, 20, Me.Height - 2)
                g.FillRectangle(DropButtonBrush, rect)

                g.DrawLine(New Pen(BorderColor, 2), 0, 0, Me.Width, 0)
                g.DrawLine(New Pen(BorderColor, 2), Me.Width, 0, Me.Width, Me.Height)
                g.DrawLine(New Pen(BorderColor, 2), Me.Width, Me.Height, 0, Me.Height)
                g.DrawLine(New Pen(BorderColor, 2), 0, Me.Height, 0, 0)

                'g.DrawLine(Pens.Yellow, TopLeft1, TopRight1)
                'g.DrawLine(Pens.Yellow, TopRight1, BottomRight1)
                'g.DrawLine(Pens.Yellow, BottomRight1, BottomLeft1)
                'g.DrawLine(Pens.Yellow, BottomLeft1, TopLeft1)


                'Create the path for the arrow
                Dim pth As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath()
                Dim TopLeft As PointF = New PointF(Me.Width - 13, (Me.Height - 5) / 2)
                Dim TopRight As PointF = New PointF(Me.Width - 6, (Me.Height - 5) / 2)
                Dim Bottom As PointF = New PointF(Me.Width - 9, (Me.Height + 2) / 2)
                pth.AddLine(TopLeft, TopRight)
                pth.AddLine(TopRight, Bottom)

                g.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

                'Determine the arrow's color.
                If Me.DroppedDown Then
                    ArrowBrush = New SolidBrush(SystemColors.HighlightText)
                Else
                    ArrowBrush = New SolidBrush(SystemColors.ControlText)
                End If

                'Draw the arrow
                g.FillPath(ArrowBrush, pth)

            Case Else
                Exit Select
        End Select
    End Sub

    'Override mouse and focus events to draw
    'proper borders. Basically, set the color and Invalidate(),
    'In general, Invalidate causes a control to redraw itself.
#Region "Mouse and focus Overrides"
    'Protected Overrides Sub OnMouseEnter(ByVal e As System.EventArgs)
    '    MyBase.OnMouseEnter(e)
    '    'BorderBrush = New SolidBrush(SystemColors.Highlight)
    '    'Me.Invalidate()
    'End Sub

    'Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
    '    MyBase.OnMouseLeave(e)
    '    'If Me.Focused Then Exit Sub
    '    'BorderBrush = New SolidBrush(SystemColors.Window)
    '    'Me.Invalidate()
    'End Sub

    'Protected Overrides Sub OnLostFocus(ByVal e As System.EventArgs)
    '    MyBase.OnLostFocus(e)
    '    'BorderBrush = New SolidBrush(SystemColors.Window)
    '    'Me.Invalidate()
    'End Sub

    'Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
    '    MyBase.OnGotFocus(e)
    '    'BorderBrush = New SolidBrush(SystemColors.Highlight)
    '    'Me.Invalidate()
    'End Sub

    'Protected Overrides Sub OnMouseHover(ByVal e As System.EventArgs)
    '    MyBase.OnMouseHover(e)
    '    'BorderBrush = New SolidBrush(SystemColors.Highlight)
    '    'Me.Invalidate()
    'End Sub
#End Region
End Class
