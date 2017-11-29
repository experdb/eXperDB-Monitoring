Public Class TextBox
    Inherits System.Windows.Forms.TextBox



#Region " Property "

    Private m_code As Boolean = False
    Private m_prefix As String = ""
    Private m_possibleInput As String = ""
    Private _MaxByteLength As Integer = 50
    Private m_impossibleinput As String = ""  '  \/:*?"<>|
    Private m_Necessary As Boolean = False
    Private m_UseByteLength As Boolean = True

    <ComponentModel.DefaultValue(True), _
    ComponentModel.Description("MaxByteLength 기능 사용여부")> _
    Public Property UseByteLength As Boolean
        Get
            Return m_UseByteLength
        End Get
        Set(value As Boolean)
            m_UseByteLength = value
        End Set
    End Property

    <ComponentModel.DefaultValue(50), _
    ComponentModel.Description("시스템 기본 언어의 지원 언어의 길이를 바이트로 계산하여 입력길이 조절")> _
    Public Property MaxByteLength() As Integer
        Get
            Return Me._MaxByteLength
        End Get

        Set(ByVal Value As Integer)
            If Me._MaxByteLength <> Value Then
                Me._MaxByteLength = Value
            End If
        End Set
    End Property

    <ComponentModel.Description("입력가능한 문자를 지정합니다.")> _
    Public Property PossibleInput() As String
        Get
            Return m_possibleInput
        End Get
        Set(ByVal Value As String)
            m_possibleInput = Value
        End Set
    End Property
    <ComponentModel.Description("입력불가능한 문자를 지정합니다.")> _
    Public Property impossibleinput() As String
        Get
            Return m_impossibleinput
        End Get
        Set(ByVal Value As String)
            m_impossibleinput = Value
        End Set
    End Property
    <ComponentModel.Description("숫자와 영문 대문자입력으로 변경합니다. EngLower : 영문 소문자 EngNormal : 영문 대/소문자 EngUpper : 영문 대문자 hangle : 한글 입력 가능")> _
    Public Property code() As Boolean
        Get
            Return m_code

        End Get
        Set(ByVal value As Boolean)
            m_code = value
            If m_code = True Then
                Me.ImeMode = Windows.Forms.ImeMode.Disable
                Me.CharacterCasing = Windows.Forms.CharacterCasing.Upper
            Else
                Me.ImeMode = Windows.Forms.ImeMode.NoControl
                Me.CharacterCasing = Windows.Forms.CharacterCasing.Normal
            End If
        End Set
    End Property

    <ComponentModel.Description("컨트롤의 고정 문자를 지정합니다.")> _
    Public Property Prefix() As String
        Get
            Return m_prefix
        End Get
        Set(ByVal Value As String)
            m_prefix = Value
            Me.Text = m_prefix
            Me.SelectionStart = Me.Text.Length
        End Set
    End Property
    Private _BackColor As Drawing.Color = Drawing.SystemColors.Window
    Overrides Property BackColor As Drawing.Color
        Get
            Return MyBase.BackColor
        End Get
        Set(value As Drawing.Color)
            If Not _BackColor.Equals(value) Then
                _BackColor = value
                MyBase.BackColor = value
                Me.Invalidate()
            End If
        End Set
    End Property



    <ComponentModel.Description("필수 입력 사항 여부 표시")> _
    Public Property Necessary() As Boolean
        Get
            Return m_Necessary
        End Get
        Set(ByVal value As Boolean)
            If value = True Then
                MyBase.BackColor = Drawing.SystemColors.GradientActiveCaption
            Else
                MyBase.BackColor = _BackColor
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

    Private _AutoReturnTabIndex As Boolean = True
    <ComponentModel.DefaultValue(True) _
    , ComponentModel.Description("Return 자동 TabIndex")> _
    Property AutoReturnTabIndex() As Boolean
        Get
            Return _AutoReturnTabIndex
        End Get
        Set(value As Boolean)
            _AutoReturnTabIndex = value
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

#End Region


    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        modCommon.ShowStatus(Me.FindForm, _StatusAssemblyMethod, _StatusTip)
    End Sub



    Protected Overrides Sub OnKeyPress(e As Windows.Forms.KeyPressEventArgs)
        If code Then
            Select Case Asc(e.KeyChar())
                Case 8, 9
                Case 13
                Case 45, 95     '"-", "_"
                Case 48 To 57   '숫자
                Case 65 To 90   '영문대문자
                Case 97 To 122  '영문소문자
                Case Else
                    e.Handled = True
            End Select
        ElseIf m_possibleInput <> "" Or m_impossibleinput <> "" Then
            Select Case Asc(e.KeyChar())
                Case 8, 9
                Case 13
                Case Else
                    If m_possibleInput <> "" Then
                        If m_possibleInput.IndexOf(e.KeyChar()) < 0 Then
                            e.Handled = True
                        End If
                    End If
                    If m_impossibleinput <> "" Then

                        If m_impossibleinput.IndexOf(e.KeyChar()) > -1 Then
                            e.Handled = True
                        End If
                    End If

            End Select

        End If

        If m_prefix <> "" Then
            Select Case Asc(e.KeyChar())
                Case 9, 13
                Case Else
                    If Me.SelectionStart < m_prefix.Length Then
                        e.Handled = True
                    ElseIf Me.SelectionStart = m_prefix.Length Then
                        If Asc(e.KeyChar()) = 8 Then
                            e.Handled = True
                        End If
                    End If
            End Select
        End If
        MyBase.OnKeyPress(e)

    End Sub


    Protected Overrides Sub OnKeyDown(e As Windows.Forms.KeyEventArgs)
        If m_prefix <> "" Then
            If Me.SelectionStart < m_prefix.Length Then
                If e.KeyCode = Windows.Forms.Keys.Delete Then
                    e.Handled = True
                End If
            End If
        End If

        If e.KeyCode = Windows.Forms.Keys.Return Or e.KeyCode = Windows.Forms.Keys.Enter Then
            Windows.Forms.SendKeys.Send("{TAB}")
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Private _Value As String = ""
    Shadows Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            _Value = value
            MyBase.Text = value

        End Set
    End Property

    ReadOnly Property CheckValueText As Boolean
        Get
            Return _Value.Equals(Me.Text)
        End Get
    End Property
    Property Value As String
        Get
            Return _Value
        End Get
        Set(value As String)
            _Value = value
        End Set
    End Property



#Region "MaxByteLength"





    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_CHAR As Integer = &H102
        Const WM_PASTE As Integer = &H302

        Select Case m.Msg
            Case WM_CHAR
                Dim eKeyPress As New Windows.Forms.KeyPressEventArgs(Microsoft.VisualBasic.ChrW(m.WParam.ToInt32()))
                Me.OnChar(eKeyPress)

                If eKeyPress.Handled Then
                    Return
                End If
            Case WM_PASTE
                If UseByteLength = True Then
                    If Me.MaxLength * 2 > Me.MaxByteLength Then
                        Me.OnPaste(New System.EventArgs)
                        Return
                    End If
                Else
                    Me.OnPaste(New System.EventArgs)
                End If

        End Select

        MyBase.WndProc(m)
    End Sub

    Protected Overridable Sub OnChar(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If
        If UseByteLength = True Then

            Dim sjisEncoding As System.Text.Encoding = System.Text.Encoding.Default
            Dim textByteCount As Integer = sjisEncoding.GetByteCount(Me.Text)
            Dim inputByteCount As Integer = sjisEncoding.GetByteCount(e.KeyChar.ToString())
            Dim selectedTextByteCount As Integer = sjisEncoding.GetByteCount(Me.SelectedText)

            If textByteCount + inputByteCount - selectedTextByteCount > Me.MaxByteLength Then
                e.Handled = True
            End If
        End If

    End Sub

    Protected Overridable Sub OnPaste(ByVal e As System.EventArgs)
        If UseByteLength = True Then
            Dim clipboardText As Object = Windows.Forms.Clipboard.GetDataObject().GetData(System.Windows.Forms.DataFormats.Text)

            If clipboardText Is Nothing Then
                Return
            End If

            Dim sjisEncoding As System.Text.Encoding = System.Text.Encoding.Default
            Dim inputText As String = clipboardText.ToString()
            Dim textByteCount As Integer = sjisEncoding.GetByteCount(Me.Text)
            Dim inputByteCount As Integer = sjisEncoding.GetByteCount(inputText)
            Dim selectedTextByteCount As Integer = sjisEncoding.GetByteCount(Me.SelectedText)
            Dim remainByteCount As Integer = Me.MaxByteLength - (textByteCount - selectedTextByteCount)

            If remainByteCount <= 0 Then
                Return
            End If

            If remainByteCount >= inputByteCount Then
                Me.SelectedText = inputText
            Else
                Me.SelectedText = inputText.Substring(0, remainByteCount)
            End If
        End If

    End Sub

#End Region


    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        If m_Necessary = True Then
            If Me.Text = "" Then
                MyBase.BackColor = Drawing.SystemColors.Highlight

            Else
                MyBase.BackColor = Drawing.SystemColors.Window
            End If

        End If
    End Sub


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
