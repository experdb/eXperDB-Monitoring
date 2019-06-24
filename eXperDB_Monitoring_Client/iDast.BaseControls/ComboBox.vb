Public Class ComboBox
    Inherits System.Windows.Forms.ComboBox

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


    ''' <summary>
    ''' Class로 값을 넣는다. Enum Type의 경우 Class에 Enum을 넣을 경우 자동으로 생성함.
    ''' </summary>
    ''' <param name="ValueDesc"></param>
    ''' <remarks></remarks>
    Public Sub SetValues(ByVal ValueDesc As ValueDescription)

        Dim dtTable As DataTable = ValueDesc.GetDataTable



        Me.DataSource = dtTable
        Me.DisplayMember = "DESC"
        Me.ValueMember = "VALUE"
    End Sub
    ''' <summary>
    ''' Datatable로 값을 넣는다. 
    ''' </summary>
    ''' <param name="dtTable">데이터 테이블</param>
    ''' <param name="DispMember">출력컬럼</param>
    ''' <param name="ValueMember">값컬럼</param>
    ''' <remarks></remarks>
    Public Sub SetValues(ByVal dtTable As DataTable, ByVal DispMember As String, ByVal ValueMember As String)
        Me.DataSource = dtTable
        Me.DisplayMember = DispMember
        Me.ValueMember = ValueMember
    End Sub
    ''' <summary>
    ''' 값으로 데이터를 넣는다. 
    ''' </summary>
    ''' <param name="Value">값</param>
    ''' <param name="Desc">표시이름</param>
    ''' <remarks></remarks>
    Public Sub AddValue(ByVal Value As String, ByVal Desc As String)
        Dim dtTable As DataTable
        If Me.DataSource Is Nothing Then
            dtTable = New DataTable
            dtTable.Columns.Add("DESC")
            dtTable.Columns.Add("VALUE")
        Else
            dtTable = Me.DataSource

        End If

        Dim dtRow As DataRow = dtTable.Rows.Add()
        dtRow.Item("DESC") = Desc
        dtRow.Item("VALUE") = Value
        Me.DataSource = dtTable
        Me.DisplayMember = "DESC"
        Me.ValueMember = "VALUE"


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

    Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
        MyBase.OnSelectedIndexChanged(e)
        If m_Necessary = True Then
            If Me.SelectedIndex > 0 Then
                Me.BackColor = Drawing.SystemColors.Highlight

            Else
                Me.BackColor = Drawing.SystemColors.Window
            End If

        End If
    End Sub



    Protected Overrides Sub OnGotFocus(e As EventArgs)
        MyBase.OnGotFocus(e)
        modCommon.ShowStatus(Me.FindForm, _StatusAssemblyMethod, _StatusTip)

    End Sub

    Private _SelectedValue As Object
    Protected Overloads Property SelectedValue As Object
        Get
            Return MyBase.SelectedValue
        End Get
        Set(value As Object)
            If MyBase.SelectedValue IsNot Nothing AndAlso Not MyBase.SelectedValue.Equals(value) Then
                MyBase.SelectedValue = value
                _SelectedValue = value
            End If

        End Set
    End Property
    Private _Value As String = ""
    Property ValueText As String
        Get
            Return MyBase.Text
        End Get
        Set(value As String)
            If Not MyBase.Text.Equals(value) Then
                MyBase.Text = value
                _Value = value
            End If
        End Set
    End Property


    ReadOnly Property CheckValueText As Boolean
        Get
            Return _Value.Equals(MyBase.Text) OrElse _SelectedValue IsNot Nothing AndAlso _SelectedValue.Equals(MyBase.SelectedValue)
        End Get
    End Property


    'Private _PopupKey As System.Windows.Forms.Keys = Windows.Forms.Keys.ShiftKey

    '<ComponentModel.DefaultValue("Windows.Forms.Keys.ShiftKey")> _
    'Property PopupKey As System.Windows.Forms.Keys
    '    Get
    '        Return _PopupKey
    '    End Get
    '    Set(value As System.Windows.Forms.Keys)
    '        _PopupKey = value
    '    End Set
    'End Property

    Protected Overrides Sub OnKeyDown(e As Windows.Forms.KeyEventArgs)
        'If e.KeyCode.Equals(_PopupKey) Then
        '    Dim dtTable As DataTable
        '    Dim strDispMember As String = ""
        '    If Me.DataSource Is Nothing Then
        '        dtTable = New DataTable
        '        dtTable.Columns.Add("Value")
        '        strDispMember = "Value"
        '        For Each tmpStr As String In Me.Items
        '            dtTable.Rows.Add(tmpStr)
        '        Next
        '    Else
        '        dtTable = Me.DataSource
        '        strDispMember = Me.DisplayMember
        '    End If

        '    Dim frmPopup As New frmPopup(dtTable, strDispMember)
        '    If frmPopup.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        Me.Text = frmPopup.rtnValue
        '    End If

        'End If
        If e.KeyCode = Windows.Forms.Keys.Return Or e.KeyCode = Windows.Forms.Keys.Enter Then
            Windows.Forms.SendKeys.Send("{TAB}")
        End If
        MyBase.OnKeyDown(e)

    End Sub



End Class
