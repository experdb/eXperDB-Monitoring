Imports System.ComponentModel
Imports System.Drawing.Drawing2D

Public Class Areaitem

    Private _ColorGraUse As Boolean = False
    <Category("Area"), Description("그라 사용여부")> _
    Property ColorGraUse As Boolean
        Get
            Return _ColorGraUse
        End Get
        Set(value As Boolean)
            If Not _ColorGraUse.Equals(value) Then
                _ColorGraUse = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _ColorGraIn As Color = Color.WhiteSmoke
    <Category("Area"), Description("그라 안쪽")> _
    Property ColorGraIn() As Color
        Get
            Return _ColorGraIn
        End Get
        Set(value As Color)
            If Not _ColorGraIn.Equals(value) Then
                _ColorGraIn = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property
    Private _OpacityIn As Integer = 128
    <Category("Area"), Description("안쪽 투명도")> _
    Property OpacityIn As Integer
        Get
            Return _OpacityIn
        End Get
        Set(value As Integer)
            If Not _OpacityIn.Equals(value) Then
                _OpacityIn = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _ColorGraOut As Color = Color.DarkBlue
    <Category("Area"), Description("그라 바깥쪽")> _
    Property ColorGraOut As Color
        Get
            Return _ColorGraOut
        End Get
        Set(value As Color)
            If Not _ColorGraOut.Equals(value) Then
                _ColorGraOut = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property
    Private _OpacityOut As Integer = 128
    <Category("Area"), Description("바깥쪽 투명도")> _
    Property OpacityOut As Integer
        Get
            Return _OpacityOut
        End Get
        Set(value As Integer)
            If Not _OpacityOut.Equals(value) Then
                _OpacityOut = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _Value As Integer = 100
    <Category("Area"), Description("값")> _
    Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            If Not _Value.Equals(value) Then
                _Value = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _Line As Color = Color.DarkBlue
    <Category("Area"), Description("테두리 선")> _
    Property Line As Color
        Get
            Return _Line
        End Get
        Set(value As Color)
            If Not _Line.Equals(value) Then
                _Line = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _LineOpacity As Integer = 128
    <Category("Area"), Description("테두리 선 투명도")> _
    Property LineOpacity As Integer
        Get
            Return _LineOpacity
        End Get
        Set(value As Integer)
            If Not _LineOpacity.Equals(value) Then
                _LineOpacity = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _LineWidth As Integer = 2
    <Category("Area"), Description("테두리 선 두께")> _
    Property LineWidth As Integer
        Get
            Return _LineWidth
        End Get
        Set(value As Integer)
            If Not _LineWidth.Equals(value) Then
                _LineWidth = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If


        End Set
    End Property


    Private _LinePenStyle As DashStyle = DashStyle.Solid
    <Category("Line")> _
    Property LinePenStyle As DashStyle
        Get
            Return _LinePenStyle
        End Get
        Set(value As DashStyle)
            If Not _LinePenStyle.Equals(value) Then
                _LinePenStyle = value
                If _LinePattern Is Nothing OrElse _LinePattern.Length = 0 Then
                    _LinePattern = New Single() {10, 10}
                    If Me._parent IsNot Nothing Then Me._parent.Invalidate()
                End If
            End If

        End Set
    End Property
    Private _LinePattern As Single()

    <Category("Line")> _
    Property LinePattern As Single()
        Get
            Return _LinePattern
        End Get
        Set(value As Single())
            If Not _LinePattern.Equals(value) Then
                _LinePattern = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property



    Private _parent As Raider = Nothing
    Public Sub SetParent(ByVal parent As Raider)
        _parent = parent
    End Sub
    ReadOnly Property isParent() As Boolean
        Get
            Return _parent IsNot Nothing
        End Get
    End Property

    Public Sub New()
        _LinePattern = New Single() {10, 10}
    End Sub
End Class
