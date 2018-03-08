Imports System.ComponentModel
Public Class DigitalNumber
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


      
    End Sub
    Private _Value As String = "0"

    Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)

            If Not IsNumeric(value) Then
                Throw New Exception("Not Numeric")
                Return
            End If
            If Not _Value.Equals(value) Then
                _Value = value
                Me.Invalidate()
            End If
        End Set
    End Property




    Protected Overrides Sub OnPaint(e As PaintEventArgs)


        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

        Dim sevenSegmentHelper As New SevenSegmentHelper(e.Graphics)

        Dim digitSizeF As SizeF = sevenSegmentHelper.GetStringSize(_Value, Font)
        Dim scaleFactor As Single = Math.Min(ClientSize.Width / digitSizeF.Width, ClientSize.Height / digitSizeF.Height)
        Dim font__1 As New Font(Font.FontFamily, scaleFactor * Font.SizeInPoints)
        digitSizeF = sevenSegmentHelper.GetStringSize(_Value, font__1)

        Using brush As New SolidBrush(_digitColor)
            Using lightBrush As New SolidBrush(Color.FromArgb(_DigitBlankOpacity, _digitColor))
                sevenSegmentHelper.DrawDigits(_Value, font__1, brush, lightBrush, (ClientSize.Width - digitSizeF.Width) / 2, (ClientSize.Height - digitSizeF.Height) / 2)
            End Using
        End Using

    End Sub

     


End Class
