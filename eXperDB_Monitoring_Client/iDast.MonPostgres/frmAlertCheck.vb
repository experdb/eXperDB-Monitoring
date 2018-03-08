Public Class frmAlertCheck

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
    End Sub

    Private Sub initForm()
        btnSave.Text = p_clsMsgData.fn_GetData("F014")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        ' 일반설정 탭 
        FormMovePanel1.Text = p_clsMsgData.fn_GetData("F262")
        lblInstance.Text = p_clsMsgData.fn_GetData("F033")
        lblAlertType.Text = p_clsMsgData.fn_GetData("F258")
        lblAlertTime.Text = p_clsMsgData.fn_GetData("F257")
        lblAlertLevel.Text = p_clsMsgData.fn_GetData("F256")
        lblAlertMsg.Text = p_clsMsgData.fn_GetData("F259")
        lblAlertComment.Text = p_clsMsgData.fn_GetData("F260")
        lblPause.Text = p_clsMsgData.fn_GetData("F263")
        lblAlertUser.Text = p_clsMsgData.fn_GetData("F265")

        cmbPauseTime.SelectedIndex = 0
        modCommon.FontChange(Me, p_Font)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox(p_clsMsgData.fn_GetData("M006"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub rtnValue(ByRef intPauseTime As Integer, ByRef strCheckComment As String, ByRef strUserName As String)
        If cmbPauseTime.SelectedIndex > 0 Then
            intPauseTime = Integer.Parse(cmbPauseTime.Text) * 60
        End If
        strCheckComment = txtAlertComment.Text
        strUserName = txtAlertUser.Text
    End Sub
End Class