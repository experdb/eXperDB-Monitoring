Public Class MaskedTextBox
    Inherits Windows.Forms.MaskedTextBox
    Public Enum enmLength
        [Short] = 0
        [Middle] = 1
        [Long] = 2
    End Enum
    Private _ControlLength As enmLength

    <ComponentModel.DefaultValue(GetType(enmLength), "Middle") _
    , ComponentModel.Description("컨트롤 지정된 길이")> _
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
    , ComponentModel.Description("컨트롤 지정 길이 사용여부")> _
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

    Protected Overrides Sub OnResize(e As EventArgs)
        If _FixedWidth = True Then
            Select Case _ControlLength
                Case enmLength.Short : Me.Width = 100
                Case enmLength.Middle : Me.Width = 150
                Case enmLength.Long : Me.Width = 200
            End Select
        End If
        MyBase.OnResize(e)

    End Sub

End Class
