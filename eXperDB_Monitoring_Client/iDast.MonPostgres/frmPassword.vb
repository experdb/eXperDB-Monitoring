Public Class frmPassword
    Private _Odbc As eXperDB.ODBC.DXODBC = Nothing
    Public Sub New(ByVal objCn As eXperDB.ODBC.DXODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _Odbc = objCn

        FormMovePanel1.Text = p_clsMsgData.fn_GetData("F004")
        btnOK.Text = p_clsMsgData.fn_GetData("F005")


        modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim clsQu As New clsQuerys(_Odbc)
        If clsQu.CheckPassword(p_UseID, txtPw.Text) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
            MsgBox(strMsg)
            Return
        End If

    End Sub

    Private Sub txtPw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPw.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub txtPw_TextChanged(sender As Object, e As EventArgs) Handles txtPw.TextChanged

    End Sub
End Class