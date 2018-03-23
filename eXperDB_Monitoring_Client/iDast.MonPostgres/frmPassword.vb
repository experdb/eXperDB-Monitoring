Public Class frmPassword
    Private _Odbc As eXperDB.ODBC.DXODBC = Nothing
    Public Sub New(ByVal objCn As eXperDB.ODBC.DXODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _Odbc = objCn

        'FormMovePanel1.Text = p_clsMsgData.fn_GetData("F004")
        btnOK.Text = p_clsMsgData.fn_GetData("F005")


        'modCommon.FontChange(Me, p_Font)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPw_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPw.KeyDown
        If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
            btnOK.PerformClick()
        End If
    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim clsQu As New clsQuerys(_Odbc)
        Dim strKey As String = Nothing
        Try
            Dim dtTable As DataTable = clsQu.SelectSerialKey()
            If dtTable IsNot Nothing Then
                Dim dtRow As DataRow = dtTable.Rows(0)
                strKey = dtRow.Item("LICDATA")
                If strKey.Length < 24 Then
                    MsgBox(p_clsMsgData.fn_GetData("M018"))
                    Return
                End If

            End If
        Catch ex As Exception
            Console.WriteLine(e.ToString)
            MsgBox(p_clsMsgData.fn_GetData("M018"))
            Return
        End Try

        Dim crypt As New eXperDB.Common.ClsCrypt

        crypt.TDESImplementation(strKey.Substring(0, 24), strKey.Substring(0, 8))
        Dim strPw As String = crypt.EncryptTDES(txtPw.Text)

        If clsQu.CheckPassword(p_UseID, strPw) = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            If txtPw.Text.Equals("k4m") AndAlso clsQu.CheckPassword(p_UseID, txtPw.Text) = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
                Return
            End If
            Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
            MsgBox(strMsg)
            Return
        End If
    End Sub

    Private Sub frmPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLabel.Text = p_clsMsgData.fn_GetData("M052")

    End Sub

    Private Sub frmPassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtPw.Focus()
    End Sub
End Class