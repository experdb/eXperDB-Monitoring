Imports System.ComponentModel

Public Class RaiderItem
    Private _GraColorin As Color = Drawing.Color.White
    Public Sub New()
        Dim Rnd As New Random()
        _GraColorOut = Color.FromArgb(Rnd.Next(255), Rnd.Next(255), Rnd.Next(255))

    End Sub
    <Category("Gradation"), Description("안쪽색상")> _
    Property GraColorin As Color
        Get
            Return _GraColorin
        End Get
        Set(value As Color)
            If Not _GraColorin.Equals(value) Then
                _GraColorin = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property
    Private _OpacityIn As Integer = 128
    <Category("Gradation"), Description("안쪽 투명도 255까지")> _
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

    Private _GraColorOut As Color = Color.WhiteSmoke
    <Category("Gradation"), Description("바깥색상")> _
    Property GraColorOut As Color
        Get
            Return _GraColorOut
        End Get
        Set(value As Color)
            If Not _GraColorOut.Equals(value) Then
                _GraColorOut = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property
    Private _OpacityOut As Integer = 128
    <Category("Gradation"), Description("바깥 투명도 255까지")> _
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
    Private _BefValue As Integer = 0
    Friend ReadOnly Property BefValue As Integer
        Get
            Return _BefValue
        End Get
    End Property

    Private _Value As Integer = 0
    <Category("Data"), Description("값 비율로 자동으로 길이계산되어 들어감")> _
    Property Value As Integer
        Get
            Return _Value
        End Get
        Set(value As Integer)
            If Not _Value.Equals(value) Or _UseBeforeValue = False Then

                If _UseBeforeValue = True Then
                    _BefValue = _Value
                Else
                    _BefValue = 0
                End If


                _Value = value
                If _parent IsNot Nothing Then _parent.Invalidate()
            End If

        End Set
    End Property


    Friend Sub IncBeforeBalue(ByVal incValue As Integer)
        Dim tmpVector As Integer = 1
        If _BefValue > Value Then
            tmpVector = -1
        Else
            tmpVector = 1
        End If


        If _BefValue <> Value Then
            _BefValue += incValue * tmpVector
        End If

        If _BefValue < 0 Then
            _BefValue = 0
        ElseIf _BefValue > 100 Then
            _BefValue = 100

        End If


    End Sub

    Private _Text As String = String.Empty
    Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            If Not _Text.Equals(value) Then
                _Text = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _Image As Image = Nothing
    Property Image As Image
        Get
            Return _Image
        End Get
        Set(value As Image)
            If _Image Is Nothing Then
                _Image = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _Seq As String = String.Empty
    Property Seq As String
        Get
            Return _Seq
        End Get
        Set(value As String)
            If Not _Seq.Equals(value) Then
                _Seq = value
                If Me._parent IsNot Nothing Then Me._parent.Invalidate()
            End If

        End Set
    End Property

    Private _Name As String = Nothing

    Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value

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


    Private _UseBeforeValue As Boolean = True
    <System.ComponentModel.Description("이전값 사용여부 사용하지 않을 경우 0부터 무조건 다시 그림")> _
    <System.ComponentModel.DefaultValue("True")> _
    Property UseBeforeValue As Boolean
        Get
            Return _UseBeforeValue
        End Get
        Set(value As Boolean)
            _usebeforevalue = value
        End Set
    End Property
End Class