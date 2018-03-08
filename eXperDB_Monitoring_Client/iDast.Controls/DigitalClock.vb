Imports System.ComponentModel

Public Class DigitalClock
    Inherits System.Windows.Forms.Control
    Private _digitColor As Color = Color.Lime
    <Browsable(True), DefaultValue("Color.Lime")> _
    Public Property DigitColor() As Color
        Get
            Return _digitColor
        End Get
        Set(value As Color)
            _digitColor = value
            Invalidate()
        End Set
    End Property
    Private _DigitBlankOpacity As Integer = 30
    Public Property DigitBlankOpacity As Integer
        Get
            Return _DigitBlankOpacity
        End Get
        Set(value As Integer)
            If Not _DigitBlankOpacity.Equals(value) Then
                _DigitBlankOpacity = value
                Me.Invalidate()
            End If

        End Set
    End Property


    'Private _digitText As String = "88:88:88"
    '<Browsable(True), DefaultValue("88:88:88")> _
    'Public Property DigitText() As String
    '    Get
    '        Return _digitText
    '    End Get
    '    Set(value As String)
    '        _digitText = value
    '        Invalidate()
    '    End Set
    'End Property

    Public Sub New()
        Me.SetStyle(ControlStyles.DoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.Black
     

        Tm.Interval = 1000
        Tm.Start()
    End Sub
     


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
     

        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

        Dim sevenSegmentHelper As New SevenSegmentHelper(e.Graphics)

        Dim digitSizeF As SizeF = sevenSegmentHelper.GetStringSize(_strTime, Font)
        Dim scaleFactor As Single = Math.Min(ClientSize.Width / digitSizeF.Width, ClientSize.Height / digitSizeF.Height)
        Dim font__1 As New Font(Font.FontFamily, scaleFactor * Font.SizeInPoints)
        digitSizeF = sevenSegmentHelper.GetStringSize(_strTime, font__1)

        Using brush As New SolidBrush(_digitColor)
            Using lightBrush As New SolidBrush(Color.FromArgb(_DigitBlankOpacity, _digitColor))
                sevenSegmentHelper.DrawDigits(_strTime, font__1, brush, lightBrush, (ClientSize.Width - digitSizeF.Width) / 2, (ClientSize.Height - digitSizeF.Height) / 2)
            End Using
        End Using

    End Sub





    Private WithEvents Tm As New System.Timers.Timer
     

    Private _strTime As String = "88:88:88"
    Private Sub Tm_Tick(sender As Object, e As EventArgs) Handles Tm.Elapsed
        _strTime = Now.ToString("HH:mm:ss")
        Me.Invalidate()
    End Sub
     



End Class


Public Class SevenSegmentHelper
    Private _graphics As Graphics

    ' Indicates what segments are illuminated for all 10 digits
    Shared _segmentData As Byte(,) = {{1, 1, 1, 0, 1, 1, _
        1}, {0, 0, 1, 0, 0, 1, _
        0}, {1, 0, 1, 1, 1, 0, _
        1}, {1, 0, 1, 1, 0, 1, _
        1}, {0, 1, 1, 1, 0, 1, _
        0}, {1, 1, 0, 1, 0, 1, _
        1}, _
        {1, 1, 0, 1, 1, 1, _
        1}, {1, 0, 1, 0, 0, 1, _
        0}, {1, 1, 1, 1, 1, 1, _
        1}, {1, 1, 1, 1, 0, 1, _
        1}}

    ' Points that define each of the seven segments
    ReadOnly _segmentPoints As Point()() = New Point(6)() {}

    Public Sub New(graphics As Graphics)
        Me._graphics = graphics
        _segmentPoints(0) = New Point() {New Point(3, 2), New Point(39, 2), New Point(31, 10), New Point(11, 10)}
        _segmentPoints(1) = New Point() {New Point(2, 3), New Point(10, 11), New Point(10, 31), New Point(2, 35)}
        _segmentPoints(2) = New Point() {New Point(40, 3), New Point(40, 35), New Point(32, 31), New Point(32, 11)}
        _segmentPoints(3) = New Point() {New Point(3, 36), New Point(11, 32), New Point(31, 32), New Point(39, 36), New Point(31, 40), New Point(11, 40)}
        _segmentPoints(4) = New Point() {New Point(2, 37), New Point(10, 41), New Point(10, 61), New Point(2, 69)}
        _segmentPoints(5) = New Point() {New Point(40, 37), New Point(40, 69), New Point(32, 61), New Point(32, 41)}
        _segmentPoints(6) = New Point() {New Point(11, 62), New Point(31, 62), New Point(39, 70), New Point(3, 70)}
    End Sub

    Public Function GetStringSize(text As String, font As Font) As SizeF
        Dim sizef As New SizeF(0, _graphics.DpiX * font.SizeInPoints / 72)

        For i As Integer = 0 To text.Length - 1
            If [Char].IsDigit(text(i)) Then
                sizef.Width += 42 * _graphics.DpiX * font.SizeInPoints / 72 / 72
            ElseIf text(i) = ":"c OrElse text(i) = "."c Then
                sizef.Width += 12 * _graphics.DpiX * font.SizeInPoints / 72 / 72
            End If
        Next
        Return sizef
    End Function

    Public Sub DrawDigits(text As String, font As Font, brush As Brush, brushLight As Brush, x As Single, y As Single)
        For cnt As Integer = 0 To text.Length - 1
            ' For digits 0-9
            If [Char].IsDigit(text.Substring(cnt, 1)) Then
                x = DrawDigit(text.Substring(cnt, 1) - "0", font, brush, brushLight, x, y)
                ' For colon :
            ElseIf text(cnt) = ":"c Then
                x = DrawColon(font, brush, x, y)
                ' For dot .
            ElseIf text(cnt) = "."c Then
                x = DrawDot(font, brush, x, y)
            End If
        Next
    End Sub

    Private Function DrawDigit(num As Integer, font As Font, brush As Brush, brushLight As Brush, x As Single, y As Single) As Single
        For cnt As Integer = 0 To _segmentPoints.Length - 1
            If _segmentData(num, cnt) = 1 Then
                FillPolygon(_segmentPoints(cnt), font, brush, x, y)
            Else
                FillPolygon(_segmentPoints(cnt), font, brushLight, x, y)
            End If
        Next
        Return x + 42 * _graphics.DpiX * font.SizeInPoints / 72 / 72
    End Function

    Private Function DrawDot(font As Font, brush As Brush, x As Single, y As Single) As Single
        Dim dotPoints As Point()() = New Point(0)() {}

        dotPoints(0) = New Point() {New Point(2, 64), New Point(6, 61), New Point(10, 64), New Point(6, 69)}

        For cnt As Integer = 0 To dotPoints.Length - 1
            FillPolygon(dotPoints(cnt), font, brush, x, y)
        Next
        Return x + 12 * _graphics.DpiX * font.SizeInPoints / 72 / 72
    End Function

    Private Function DrawColon(font As Font, brush As Brush, x As Single, y As Single) As Single
        Dim colonPoints As Point()() = New Point(1)() {}

        colonPoints(0) = New Point() {New Point(2, 21), New Point(6, 17), New Point(10, 21), New Point(6, 25)}
        colonPoints(1) = New Point() {New Point(2, 51), New Point(6, 47), New Point(10, 51), New Point(6, 55)}

        For cnt As Integer = 0 To colonPoints.Length - 1
            FillPolygon(colonPoints(cnt), font, brush, x, y)
        Next
        Return x + 12 * _graphics.DpiX * font.SizeInPoints / 72 / 72
    End Function

    Private Sub FillPolygon(polygonPoints As Point(), font As Font, brush As Brush, x As Single, y As Single)
        Dim polygonPointsF As PointF() = New PointF(polygonPoints.Length - 1) {}

        For cnt As Integer = 0 To polygonPoints.Length - 1
            polygonPointsF(cnt).X = x + polygonPoints(cnt).X * _graphics.DpiX * font.SizeInPoints / 72 / 72
            polygonPointsF(cnt).Y = y + polygonPoints(cnt).Y * _graphics.DpiY * font.SizeInPoints / 72 / 72
        Next
        _graphics.FillPolygon(brush, polygonPointsF)
    End Sub
End Class

