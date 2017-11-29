Imports System.Drawing

Public Class Label
    Inherits Windows.Forms.Label

    Private _FixHeight As Integer = 21

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Label
        '
        'Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        'Me.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AutoSize = False
        Me.ResumeLayout(False)

    End Sub

    Public Sub New()
        Me.InitializeComponent()

    End Sub

    Protected Overrides Sub OnCreateControl()

        MyBase.OnCreateControl()
        Me.InitializeComponent()
    End Sub


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
        If _FixedHeight = True Or _FixedWidth = True Then
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
        Else
            MyBase.OnResize(e)
        End If


    End Sub


    Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            If Me.InvokeRequired Then
                Me.Invoke(New InvokeChangeText(AddressOf ChangeText), value)
            Else
                ChangeText(value)
            End If


        End Set
    End Property

    Private Delegate Sub InvokeChangeText(ByVal Text As String)
    Private Sub ChangeText(ByVal strText As String)
        MyBase.Text = strText
    End Sub

    Private _AutoSizeHeight As Boolean = False
    <System.ComponentModel.DefaultValue(False)> _
    Property AutoSizeHeight As Boolean
        Get
            Return _AutoSizeHeight
        End Get
        Set(value As Boolean)
            _AutoSizeHeight = value
            Me.OnTextChanged(Nothing)
        End Set
    End Property



    Protected Overrides Sub OnTextChanged(e As EventArgs)
        If _AutoSizeHeight = True Then

            Me.Height = MyBase.Font.Height * Me.Text.Split(Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)).Count


        End If
        MyBase.OnTextChanged(e)

    End Sub


End Class
