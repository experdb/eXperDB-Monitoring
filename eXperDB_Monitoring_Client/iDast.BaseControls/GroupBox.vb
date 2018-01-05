Imports System.Drawing
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms

Public Class GroupBox
    Inherits System.Windows.Forms.GroupBox

    Public Class EdgeConverter
        Inherits ExpandableObjectConverter

        Public Overrides Function CanConvertTo(context As ITypeDescriptorContext, destinationType As Type) As Boolean
            If (destinationType Is GetType(Edges)) Then
                Return True
            End If
            Return MyBase.CanConvertTo(context, destinationType)
        End Function

        Public Overrides Function ConvertTo(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As Object, destinationType As Type) As Object
            If destinationType Is GetType(String) AndAlso TypeOf value Is Edges Then
                Dim edge As Edges = CType(value, Edges)
                Return String.Format("{0},{1},{2},{3}", edge.LeftTop, edge.RightTop, edge.LeftBottom, edge.RightBottom)

            End If
            Return MyBase.ConvertTo(context, culture, value, destinationType)
        End Function

        Public Overrides Function CanConvertFrom(context As ITypeDescriptorContext, sourceType As Type) As Boolean
            If sourceType Is GetType(Edges) Then
                Return True
            End If
            Return MyBase.CanConvertFrom(context, sourceType)
        End Function

        Public Overrides Function ConvertFrom(context As ITypeDescriptorContext, culture As Globalization.CultureInfo, value As Object) As Object
            If TypeOf value Is String Then
                Try
                    Dim s As String = value
                    Dim strValue() As String = s.Split(",")
                    Dim edge As New Edges
                    edge.LeftTop = strValue(0)
                    edge.RightTop = strValue(1)
                    edge.LeftBottom = strValue(2)
                    edge.RightBottom = strValue(3)

                    Return edge

                Catch ex As Exception

                End Try
            End If
            Return MyBase.ConvertFrom(context, culture, value)
        End Function

    End Class

    <TypeConverter(GetType(EdgeConverter))> _
    Public Class Edges
        Private _LeftTop As Integer = 10
        <DefaultValue(10)> _
        Property LeftTop As Integer
            Get
                Return _LeftTop
            End Get
            Set(value As Integer)
                _LeftTop = value
            End Set
        End Property
        Private _RightTop As Integer = 10
        <DefaultValue(10)> _
        Property RightTop As Integer
            Get
                Return _RightTop
            End Get
            Set(value As Integer)
                _RightTop = value
            End Set
        End Property
        Private _LeftBommon As Integer = 10
        <DefaultValue(10)> _
        Property LeftBottom As Integer
            Get
                Return _LeftBommon
            End Get
            Set(value As Integer)
                _LeftBommon = value
            End Set
        End Property
        Private _RightBottom As Integer = 10
        <DefaultValue(10)> _
        Property RightBottom As Integer
            Get
                Return _RightBottom
            End Get
            Set(value As Integer)
                _RightBottom = value
            End Set
        End Property

    End Class

    Private _EdgeRound As Edges = New Edges
    <Category("RoundBox")> _
    Property EdgeRound As Edges
        Get
            Return _EdgeRound
        End Get
        Set(value As Edges)
            _EdgeRound = value
            Me.Invalidate()
        End Set
    End Property




    Private _TitleFont As New Font(MyBase.Font.FontFamily, MyBase.Font.Size)
    <Category("RoundBox")> _
    Property TitleFont As Font
        Get
            Return _TitleFont
        End Get
        Set(value As Font)
            If Not _TitleFont.Equals(value) Then
                _TitleFont = value
                changePadding()
                Me.Invalidate()
            End If
        End Set
    End Property
    Private Sub ChangePadding()

        If _UseTitle = True Then
            Dim newPadding As Windows.Forms.Padding = MyBase.Padding
            newPadding.Top = _TitleFont.SizeInPoints
            MyBase.Padding = newPadding

        Else
            MyBase.Padding = MyBase.DefaultPadding
        End If

    End Sub


    Private _UseTitle As Boolean = False
    <Category("RoundBox")> _
    Property UseTitle As Boolean
        Get
            Return _UseTitle
        End Get
        Set(value As Boolean)
            If Not _UseTitle.Equals(value) Then
                _UseTitle = value
                ChangePadding()
                Me.Invalidate()
            End If
        End Set
    End Property



    Private _AlignString As StringAlignment = StringAlignment.Near
    <Category("RoundBox")> _
    Property AlignString As StringAlignment
        Get
            Return _AlignString
        End Get
        Set(value As StringAlignment)
            If Not _AlignString.Equals(value) Then
                _AlignString = value
                Me.Invalidate()
            End If
        End Set
    End Property
    Private _AlignLine As StringAlignment = StringAlignment.Center
    <Category("RoundBox")> _
    Property AlignLine As StringAlignment
        Get
            Return _AlignLine
        End Get
        Set(value As StringAlignment)
            If Not _AlignLine.Equals(value) Then
                _AlignLine = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _UseRound As Boolean = False

    <Category("RoundBox")> _
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




    Private _LineColor As Color = Color.FromArgb(128, 180, 180, 180)
    <Category("RoundBox")> _
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
    Private _LineWidth As Integer = 1
    <Category("RoundBox")> _
    Property LineWidth As Integer
        Get
            Return _LineWidth
        End Get
        Set(value As Integer)
            If Not _LineWidth.Equals(value) Then
                _LineWidth = value
                Me.Invalidate()
            End If
        End Set
    End Property


    Private _FillColor As Color = Color.FromArgb(255, 38, 38, 38)
    <Category("RoundBox")> _
    Property FillColor As Color
        Get
            Return _FillColor
        End Get
        Set(value As Color)
            If Not _FillColor.Equals(value) Then
                _FillColor = value
                MyBase.Invalidate()

            End If
        End Set
    End Property

    'Private _Radius As Integer = 10
    '<Category("RoundBox")> _
    'Property Radius As Integer
    '    Get
    '        Return _Radius
    '    End Get
    '    Set(value As Integer)
    '        If Not _Radius.Equals(value) Then
    '            _Radius = value
    '            Me.Invalidate()
    '        End If
    '    End Set
    'End Property

    Private _UseGraColor As Boolean = True
    <Category("RoundBox")> _
    Property UseGraColor As Boolean
        Get
            Return _UseGraColor
        End Get
        Set(value As Boolean)
            If Not _UseGraColor.Equals(value) Then
                _UseGraColor = value
                Me.Invalidate()
            End If
        End Set
    End Property

    Private _TitleGraColor As Color = Color.DimGray
    <Category("RoundBox")> _
    Property TitleGraColor As Color
        Get
            Return _TitleGraColor
        End Get
        Set(value As Color)

            If Not _TitleGraColor.Equals(value) Then
                _TitleGraColor = value
                Me.Invalidate()
            End If
        End Set
    End Property








    Protected Overrides Sub OnPaint(e As Windows.Forms.PaintEventArgs)
        If _UseRound = False Then

            MyBase.OnPaint(e)
        Else
            'Application.RenderWithVisualStyles

            Dim intFontHeight As Integer = _TitleFont.Height + 4

            Dim Gr As Graphics = e.Graphics
            Gr.SmoothingMode = SmoothingMode.AntiAlias
            Dim RectText As New Rectangle(0, 0, 0, 0)

            Dim BaseRect As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
            'Dim intDiameter As Integer = _Radius * 2
            BaseRect.Inflate(-2, -2)





            Dim grPath As New System.Drawing.Drawing2D.GraphicsPath
            If _EdgeRound.LeftTop <= 0 Then
                grPath.AddLine(New Point(BaseRect.X, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width - _EdgeRound.RightTop, BaseRect.Y))
            Else
                grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y, _EdgeRound.LeftTop, _EdgeRound.LeftTop), 180, 90)
            End If


            If _EdgeRound.RightTop <= 0 Then
                grPath.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Y - _EdgeRound.RightBottom))
            Else
                grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - _EdgeRound.RightTop, BaseRect.Y, _EdgeRound.RightTop, _EdgeRound.RightTop), 270, 90)
            End If


            If _EdgeRound.RightBottom <= 0 Then
                grPath.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Height), New Point(BaseRect.X - _EdgeRound.LeftBottom, BaseRect.Y + BaseRect.Height))
            Else

                grPath.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - _EdgeRound.RightBottom, BaseRect.Y + BaseRect.Height - _EdgeRound.RightBottom, _EdgeRound.RightBottom, _EdgeRound.RightBottom), 0, 90)
            End If
            If _EdgeRound.LeftBottom <= 0 Then
                grPath.AddLine(New Point(BaseRect.X, BaseRect.Y + BaseRect.Height), New Point(BaseRect.X, BaseRect.Y + _EdgeRound.LeftTop))
            Else

                grPath.AddArc(New Rectangle(BaseRect.X, BaseRect.Y + BaseRect.Height - _EdgeRound.LeftBottom, _EdgeRound.LeftBottom, _EdgeRound.LeftBottom), 90, 90)
            End If

            grPath.CloseAllFigures()

            Gr.FillPath(New SolidBrush(_FillColor), grPath)

            If _UseTitle AndAlso _UseGraColor Then

                Dim grTitle As New GraphicsPath
                If _EdgeRound.LeftTop <= 0 Then
                    grTitle.AddLine(New Point(BaseRect.X, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width - _EdgeRound.RightTop, BaseRect.Y))
                Else
                    grTitle.AddArc(New Rectangle(BaseRect.X, BaseRect.Y, _EdgeRound.LeftTop, _EdgeRound.LeftTop), 180, 90)
                End If
                If _EdgeRound.RightTop <= 0 Then
                    grTitle.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y), New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + BaseRect.Y - _EdgeRound.RightBottom))
                Else
                    grTitle.AddArc(New Rectangle(BaseRect.X + BaseRect.Width - _EdgeRound.RightTop, BaseRect.Y, _EdgeRound.RightTop, _EdgeRound.RightTop), 270, 90)
                End If
                grTitle.AddLine(New Point(BaseRect.X + BaseRect.Width, BaseRect.Y + intFontHeight), New Point(BaseRect.X, BaseRect.Y + intFontHeight))
                grTitle.CloseAllFigures()
                Dim graBrush As New Drawing2D.LinearGradientBrush(New Rectangle(BaseRect.X, BaseRect.Y, BaseRect.Width, intFontHeight), MyBase.BackColor, MyBase.BackColor, LinearGradientMode.Vertical)
                Dim ClrBlend As New ColorBlend
                ClrBlend.Positions = New Single() {0, 1}
                ClrBlend.Colors = New Color() {_TitleGraColor, _FillColor}
                graBrush.InterpolationColors = ClrBlend
                Gr.FillPath(graBrush, grTitle)

            End If


            Gr.DrawPath(New Pen(_LineColor, _LineWidth), grPath)


            If _UseTitle Then


                Dim strFormat As StringFormat = New StringFormat
                strFormat.Alignment = _AlignString
                strFormat.LineAlignment = _AlignLine

                If _Icon IsNot Nothing AndAlso MyBase.Width >= 10 AndAlso MyBase.Height >= 10 Then
                    ' Draw the entire control
                    Gr.DrawString(MyBase.Text, _TitleFont, New SolidBrush(_LineColor), New Rectangle(New Point(BaseRect.X + _EdgeRound.LeftTop / 2 + _Icon.Width + 5, BaseRect.Y + 2), New Size(BaseRect.Width - _EdgeRound.RightTop * 2, intFontHeight - 4)), strFormat)
                    DrawGroupBox(e.Graphics, BaseRect)
                Else
                    Gr.DrawString(MyBase.Text, _TitleFont, New SolidBrush(_LineColor), New Rectangle(New Point(BaseRect.X + _EdgeRound.LeftTop, BaseRect.Y + 2), New Size(BaseRect.Width - _EdgeRound.RightTop * 2, intFontHeight - 4)), strFormat)
                End If
                'Gr.DrawLine(New Pen(_LineColor, _LineWidth), New Point(BaseRect.X + _Radius, BaseRect.Y + intFontHeight), New Point(BaseRect.X + BaseRect.Width - _Radius, BaseRect.Y + intFontHeight))


            End If

            End If

    End Sub
    Private _Icon As Icon
    <Category("RoundBox")> _
    Property Icon As Icon
        Get
            Return _Icon
        End Get
        Set(value As Icon)
            _Icon = value
            Me.Invalidate()
        End Set
    End Property

    Private _Renderer As VisualStyleRenderer
    Private Sub DrawGroupBox(grfx As Graphics, ByVal BaseRect As Rectangle)
        'Set the enabled state of the control
        Dim state As GroupBoxState = IIf(MyBase.Enabled, GroupBoxState.Normal, GroupBoxState.Disabled)
        'The rectangle that bounds the control
        Dim bounds As Rectangle = New Rectangle(0, 0, MyBase.Width, MyBase.Height)
        ' Initialize the renderer for visual styles
        InitializeRenderer(CInt(state))
        ' Define the rectangle for the icon
        Dim iconrect As Rectangle = New Rectangle(BaseRect.X + _EdgeRound.LeftTop / 2, BaseRect.Y + 2, _Icon.Width, _Icon.Height)
        ' Draw the icon
        DrawIcon(grfx, _Icon, iconrect, state)
        ' Clean up
        grfx.Dispose()
    End Sub
    Private Sub InitializeRenderer(state As Integer)
        Dim visualstyleelement As VisualStyleElement = visualstyleelement.Button.GroupBox.Normal
        If _Renderer Is Nothing Then
            _Renderer = New VisualStyleRenderer(visualstyleelement.ClassName, visualstyleelement.Part, state)
        Else
            _Renderer.SetParameters(visualstyleelement.ClassName, visualstyleelement.Part, state)
        End If
    End Sub
    Private Sub DrawIcon(grfx As Graphics, icon As Icon, rc As Rectangle, state As GroupBoxState)
        If state = GroupBoxState.Disabled Then
            Using image As Image = _Icon.ToBitmap()
                ' Draw the disabled icon
                ControlPaint.DrawImageDisabled(grfx, image, rc.Left, rc.Top, Color.Empty)
            End Using
        Else
            ' Draw the enabled icon
            grfx.DrawIcon(icon, rc)
        End If
    End Sub
End Class
