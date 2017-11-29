Imports System.ComponentModel

Public Class RaiderRangeitem
    Public Sub New()
        Dim Rnd As New Random()
        _GraColorOut = Color.FromArgb(Rnd.Next(255), Rnd.Next(255), Rnd.Next(255))
    End Sub
    Public Sub New(startValue As [Single], endValue As [Single])
        MyBase.New()
        _StartValue = startValue
        _EndValue = endValue

    End Sub

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Design"), System.ComponentModel.DisplayName("(Name)"), System.ComponentModel.Description("Instance Name.")> _
    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property
    Private m_Name As String


    Private Owner As Raider
    <System.ComponentModel.Browsable(False)> _
    Public Sub SetOwner(value As Raider)
        Owner = value
    End Sub
    Private Sub NotifyOwner()
        If Owner IsNot Nothing Then
            Owner.Invalidate()
        End If
    End Sub



    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Limits"), System.ComponentModel.Description("The start value of the range, must be less than RangeEndValue.")> _
    Public Property StartValue() As [Single]
        Get
            Return _StartValue
        End Get
        Set(value As [Single])
            _StartValue = value
            NotifyOwner()
        End Set
    End Property

    Private _StartValue As [Single]

    <System.ComponentModel.Browsable(True), System.ComponentModel.Category("Limits"), System.ComponentModel.Description("The end value of the range. Must be greater than RangeStartValue.")> _
    Public Property EndValue() As [Single]
        Get
            Return _EndValue
        End Get
        Set(value As [Single])

            _EndValue = value
            NotifyOwner()
        End Set
    End Property

    Private _EndValue As [Single]

    Private _GraColorin As Color = Drawing.Color.White
    <Category("Gradation"), Description("안쪽색상")> _
    Property GraColorin As Color
        Get
            Return _GraColorin
        End Get
        Set(value As Color)
            _GraColorin = value
        End Set
    End Property
    Private _OpacityIn As Integer = 128
    <Category("Gradation"), Description("안쪽 투명도 255까지")> _
    Property OpacityIn As Integer
        Get
            Return _OpacityIn
        End Get
        Set(value As Integer)
            _OpacityIn = value

        End Set
    End Property

    Private _GraColorOut As Color = Color.WhiteSmoke
    <Category("Gradation"), Description("바깥색상")> _
    Property GraColorOut As Color
        Get
            Return _GraColorOut
        End Get
        Set(value As Color)
            _GraColorOut = value
        End Set
    End Property
    Private _OpacityOut As Integer = 128
    <Category("Gradation"), Description("바깥 투명도 255까지")> _
    Property OpacityOut As Integer
        Get
            Return _OpacityOut
        End Get
        Set(value As Integer)
            _OpacityOut = value

        End Set
    End Property


End Class

