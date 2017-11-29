Public Class DateTimePicker
    Inherits System.Windows.Forms.DateTimePicker
    Private m_Necessary As Boolean = False
    <ComponentModel.Description("필수 입력 사항 여부 표시")> _
    Public Property Necessary() As Boolean
        Get
            Return m_Necessary
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                Me.BackColor = Drawing.SystemColors.GradientActiveCaption
            Else
                Me.BackColor = Drawing.SystemColors.Window
            End If

            m_Necessary = value
        End Set
    End Property

    Public Enum enmLength
        [Short] = 0
        [Middle] = 1
        [Long] = 2
    End Enum
    Private _ControlLength As enmLength = enmLength.Middle

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
    Private _StatusTip As String = ""
    <ComponentModel.Description("Status Bar Tip 이벤트 GETFOCUS에서 StatusAssemblyMethod의 함수를 호출합니다.")> _
    Property StatusTip As String
        Get
            Return _StatusTip
        End Get
        Set(value As String)
            _StatusTip = value
        End Set
    End Property
    Private _StatusAssemblyMethod As String = "ShowStatus"
    <ComponentModel.Description("Status Bar Tip이 GOTFOCUS에서 호출할 Method 명칭입니다.") _
        , ComponentModel.DefaultValue("ShowStatus")> _
    Property StatusAssemblyMethod As String
        Get
            Return _StatusAssemblyMethod
        End Get
        Set(value As String)
            _StatusAssemblyMethod = value
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
 

    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        modCommon.ShowStatus(Me.FindForm, _StatusAssemblyMethod, _StatusTip)

    End Sub

End Class
