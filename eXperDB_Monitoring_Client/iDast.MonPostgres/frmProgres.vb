Public Class frmProgres


    Private Sub frmProgres_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Close()
    End Sub

    Private Sub frmProgres_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If Me.Owner IsNot Nothing Then
            Me.Owner.Enabled = False
        End If
    End Sub
    Private Sub frmProgres_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If Me.Owner IsNot Nothing Then
            Me.Owner.Enabled = True
        End If
    End Sub

    Private Sub frmProgres_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CircularProgressControl1.Visible = False
        CircularProgressControl1.Stop()
        If Me.Owner IsNot Nothing Then
            Me.Owner.Enabled = True
        End If
    End Sub

    Private Sub frmProgres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressControl1.Start()

        Dim ConfigIni As New Common.IniFile(p_AppConfigIni)

        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        MyBase.SetStyle(DoubleBuffered, True)
        Me.Location = Me.Owner.Location
        Me.Size = Me.Owner.Size
        CircularProgressControl1.Location = New Point(Me.Owner.Size.Width / 2 - CircularProgressControl1.Size.Width / 2, Me.Owner.Size.Height / 2 - CircularProgressControl1.Size.Height / 2 + 30)
        CircularProgressControl1.Visible = True
        lblProgresText.Location = New Point(Me.Owner.Size.Width / 2 - lblProgresText.Size.Width / 2, Me.Owner.Size.Height / 2 + CircularProgressControl1.Size.Height / 2 + 30)
        pnlProgres.Visible = True
    End Sub

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        'lblProgresText.Text = "12345"
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
    End Sub

    Private Sub frmProgres_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    End Sub

    Private _LstStr As String = ""
    Public Sub Addtext(ByVal strText As String)
        If lblProgresText IsNot Nothing Then
            lblProgresText.Text = strText
            CircularProgressControl1.Invalidate()
        End If
    End Sub

    Private Sub pnlProgres_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlProgres.MouseClick, CircularProgressControl1.MouseClick, lblProgresText.Click
        If MsgBox(p_clsMsgData.fn_GetData("M064"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class