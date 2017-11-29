Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class Button
    Inherits Windows.Forms.Button


    Private _FixHeight As Integer = 27

    Public Enum enmLength
        [Short] = 0
        [Middle] = 1
        [Long] = 2
    End Enum
    Private _ControlLength As enmLength = enmLength.Middle
    <ComponentModel.DefaultValue(GetType(enmLength), "Middle") _
    , ComponentModel.Description("지정된 컨트롤 길이")> _
    Public Property ControlLength() As enmLength
        Get
            Return _ControlLength
        End Get
        Set(value As enmLength)
            If Not _ControlLength.Equals(value) Then
                _ControlLength = value
                Me.OnResize(Nothing)
            End If

        End Set
    End Property

    Private _FixedWidth As Boolean = True
    <ComponentModel.DefaultValue(True) _
    , ComponentModel.Description("지정된 컨트롤 길이 사용여부")> _
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

    Private _FixedHeight As Boolean = True
    <ComponentModel.DefaultValue(True) _
    , ComponentModel.Description("지정된 컨트롤 높이 사용여부")> _
    Property FixedHeight() As Boolean
        Get
            Return _FixedHeight
        End Get
        Set(value As Boolean)
            If Not _FixedHeight.Equals(value) Then
                _FixedHeight = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Protected Overrides Sub OnResize(e As EventArgs)
        If _FixedHeight = True Then
            Me.Height = _FixHeight
        End If

        If _FixedWidth = True Then
            Select Case _ControlLength
                Case enmLength.Short : Me.Width = 70
                Case enmLength.Middle : Me.Width = 100
                Case enmLength.Long : Me.Width = 150
            End Select
        End If
        MyBase.OnResize(e)

    End Sub


    Private _UseRound As Boolean = False


    <Category("RoundButton")> _
    <DefaultValue(False)> _
    Property UseRound As Boolean
        Get
            Return _UseRound
        End Get
        Set(value As Boolean)
            If Not _UseRound.Equals(value) Then
                _UseRound = value
                MyBase.Invalidate()
            End If
        End Set
    End Property


    Private _LineColor As Color = Color.Gray
    <Category("RoundButton")> _
    Property LineColor As Color
        Get
            Return _LineColor
        End Get
        Set(value As Color)
            If Not _LineColor.Equals(value) Then
                _LineColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property


    Private _UnCheckFillColor As Color = Color.FromArgb(255, 64, 64, 64)
    <Category("RoundButton")> _
    Property UnCheckFillColor As Color
        Get
            Return _UnCheckFillColor
        End Get
        Set(value As Color)
            If Not _UnCheckFillColor.Equals(value) Then
                _UnCheckFillColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property


    Private _CheckFillColor As Color = Color.FromArgb(255, 127, 127, 127)
    <Category("RoundButton")> _
    Property CheckFillColor As Color
        Get
            Return _CheckFillColor
        End Get
        Set(value As Color)
            If Not _CheckFillColor.Equals(value) Then
                _CheckFillColor = value
                MyBase.Invalidate()
            End If
        End Set
    End Property

    Private _Radius As Integer = 10
    <Category("RoundButton")> _
    Property Radius As Integer
        Get
            Return _Radius
        End Get
        Set(value As Integer)
            If Not _Radius.Equals(value) Then
                _Radius = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _GraColor As Color = Color.FromArgb(255, 70, 70, 70)
    Property GraColor As Color
        Get
            Return _GraColor
        End Get
        Set(value As Color) '
            If Not _GraColor.Equals(value) Then
                _GraColor = value
                Me.Invalidate()
            End If

        End Set
    End Property



    Protected Overrides Sub OnPaint(e As Windows.Forms.PaintEventArgs)
        If _UseRound = False Then

            MyBase.OnPaint(e)
        Else

          

            'MyBase.Appearance = Windows.Forms.Appearance.Button
            MyBase.AutoSize = False
            Dim BaseRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
            Dim intDiameter As Integer = _Radius * 2
            BaseRect.Inflate(-2, -2)

            Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
            grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y, intDiameter, intDiameter), 180, 90)
            grPath.AddLine(New Point(BaseRect.X + _Radius, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y))
            grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y, intDiameter, intDiameter), 270, 90)
            grPath.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + _Radius), New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Height - _Radius))
            grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - intDiameter, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 0, 90)
            grPath.AddLine(New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + BaseRect.Height), New Point(BaseRect.X + _Radius, BaseRect.Y + BaseRect.Height))
            grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y + BaseRect.Height - intDiameter, intDiameter, intDiameter), 90, 90)
            grPath.CloseAllFigures()


            Dim Gr As Graphics = e.Graphics
            Gr.Clear(MyBase.BackColor)
            Gr.SmoothingMode = SmoothingMode.AntiAlias

            Dim graFille As New System.Drawing.Drawing2D.LinearGradientBrush(BaseRect, _GraColor, _UnCheckFillColor, 90)


            Gr.FillPath(graFille, grPath)
            'Gr.FillPath(New SolidBrush(_UnCheckFillColor), grPath)

            Gr.DrawPath(New Pen(_LineColor, 1), grPath)


            'Dim formGraphics As System.Drawing.Graphics = Me.CreateGraphics()
            'Dim drawString As String = ""
            'Dim drawFont As System.Drawing.Font = MyBase.Font
            'Dim drawBrush As New  _
            '    System.Drawing.SolidBrush(System.Drawing.Color.Black)
            'Dim x As Single = 150.0
            'Dim y As Single = 50.0

            ''Dim drawFormat As New System.Drawing.StringFormat
            ''drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
            ''formGraphics.DrawString(drawString, drawFont, drawBrush, _
            ''x, y, drawFormat)
            'drawFont.Dispose()
            'drawBrush.Dispose()
            'formGraphics.Dispose()


            ' DrawString 
            Dim strText As String = MyBase.Text
            Dim txtRect As Rectangle = BaseRect
            'txtRect.Inflate(_Radius / 2 * -1, _Radius / 2 * -1)

            Dim txtSize As SizeF = Gr.MeasureString(strText, MyBase.Font)

            Dim tmpWid As Single = 0
            Dim tmphgt As Single = 0
            'Dim NewStr As String = ""


            'For Each tmpStr As Char In strText.ToCharArray
            '    Dim Szf As SizeF = Gr.MeasureString(tmpStr.ToString, MyBase.Font)
            '    If tmpWid + Szf.Width <= txtRect.Width Then
            '        NewStr += tmpStr.ToString
            '        tmpWid += Szf.Width
            '    Else

            '        If tmphgt + Szf.Height <= txtRect.Height Then
            '            NewStr += vbCrLf & tmpStr.ToString
            '            tmpWid = Szf.Width
            '            tmphgt += Szf.Height
            '        Else
            '            Exit For
            '        End If
            '    End If


            'Next
            'Dim incHgt As Single = 0
            ''For Each tmpStr As String In MyBase.Text
            'Dim szf As SizeF = Gr.MeasureString(MyBase.Text, MyBase.Font)
            'Dim tmpL As Single = txtRect.Left + (txtRect.Width - szf.Width) / 2
            'Dim tmpT As Single = txtRect.Top + (txtRect.Height - szf.Height) / 2
            'Gr.DrawString(MyBase.Text, MyBase.Font, New SolidBrush(MyBase.ForeColor), New Point(tmpL, tmpT))

            Dim txtFormatFlags As Windows.Forms.TextFormatFlags = Windows.Forms.TextFormatFlags.HorizontalCenter Or Windows.Forms.TextFormatFlags.VerticalCenter Or Windows.Forms.TextFormatFlags.WordEllipsis
            Windows.Forms.TextRenderer.DrawText(Gr, MyBase.Text, MyBase.Font, txtRect, MyBase.ForeColor, txtFormatFlags)
            'incHgt += szf.Height
            'Next

            If _OnClick = True Then
                Gr.FillPath(New SolidBrush(Color.FromArgb(30, 0, 0, 0)), grPath)

            End If

            If Me.Enabled = False Then
                Gr.FillPath(New SolidBrush(Color.FromArgb(128, MyBase.BackColor.R, MyBase.BackColor.G, MyBase.BackColor.B)), grPath)
            End If
        End If

    End Sub
    Private _OnClick As Boolean = False
    Protected Overrides Sub OnMouseDown(mevent As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(mevent)
        _OnClick = True
        Me.Invalidate()
    End Sub


    Protected Overrides Sub OnMouseUp(mevent As Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(mevent)
        _OnClick = False
        Me.Invalidate()
    End Sub

    Private Sub OnMouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover
        Me.Cursor = Windows.Forms.Cursors.Hand
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Button
        '
        Me.ResumeLayout(False)

    End Sub
End Class
