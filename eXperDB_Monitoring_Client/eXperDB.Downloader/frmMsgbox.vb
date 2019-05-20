Public Class frmMsgbox

    Private Const [cNo] As Integer = 2
    Private Const [cCancel] As Integer = 4
    Private Const [cOK] As Integer = 1
    Public Enum MsgBoxStyle
        OKOnly = cOK
        YesNo = cOK + cNo
        YesNoCancel = cOK + cNo + cCancel
    End Enum

    Public Enum MsgBoxResult
        OK = cOK
        No = cNo
        Cancel = cCancel
        Yes = cOK
    End Enum

    Public Sub New(ByVal Prompt As String, ByVal Title As String, ByVal Buttons As MsgBoxStyle)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        'Me.FormMovePanel2.Font = New Font(p_Font, Me.FormMovePanel2.Font.Size)
        'Me.lblMessage.Font = New Font(p_Font, Me.lblMessage.Font.Size)
        'Me.btn1.Font = New Font(p_Font, Me.btn1.Font.Size)
        'Me.btn2.Font = New Font(p_Font, Me.btn2.Font.Size)
        'Me.btn3.Font = New Font(p_Font, Me.btn3.Font.Size)

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        'FormMovePanel2.Text = Title
        Me.lblMessage.Text = Prompt.Replace("\n", vbCrLf)
        btn1.Visible = False
        btn2.Visible = False
        btn3.Visible = False

        If Buttons And cOK Then
            btn1.Visible = True
            btn1.Tag = MsgBoxResult.OK
            btn1.Text = "OK"
        End If
        If Buttons And cNo Then
            btn2.Visible = True
            btn2.Tag = MsgBoxResult.No
            btn2.Text = "No"
            btn1.Text = "Yes"
        End If

        If Buttons And cCancel Then
            btn3.Visible = True
            btn3.Tag = MsgBoxResult.Cancel
            btn3.Text = "Cancel"
        End If
    End Sub

    Public Overloads Function ShowDialog() As MsgBoxResult
        MyBase.ShowDialog()
        Return _Result
    End Function


    Private _Result As MsgBoxResult = MsgBoxResult.Cancel
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click
        _Result = DirectCast(DirectCast(sender, BaseControls.Button).Tag, MsgBoxResult)
        Me.Close()
    End Sub

    Private Sub frmMsg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        btn1.Focus()

    End Sub

    Private Sub FormMovePanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub frmMsgbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLabel.Text = "eXperDB-Monitoring Message"
    End Sub
End Class