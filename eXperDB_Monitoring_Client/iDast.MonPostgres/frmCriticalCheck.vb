Public Class frmCriticalCheck

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
    End Sub

    Private Sub initForm()
        btnSave.Text = "OK"
        btnClose.Text = "Cancel"

        ' 일반설정 탭 
        'FormMovePanel1.Text = p_clsMsgData.fn_GetData("F262")
        Me.Text = p_clsMsgData.fn_GetData("F262")
        StatusLabel.Text = p_clsMsgData.fn_GetData("F262")
        lblPause.Text = p_clsMsgData.fn_GetData("F263")
        lblMsg.Text = p_clsMsgData.fn_GetData("M035")

        cmbPauseTime.SelectedIndex = 0
        modCommon.FontChange(Me, p_Font)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub rtnValue(ByRef intPauseTime As Integer)
        If cmbPauseTime.SelectedIndex > 0 Then
            intPauseTime = Integer.Parse(cmbPauseTime.Text) * 60
        End If
    End Sub
End Class