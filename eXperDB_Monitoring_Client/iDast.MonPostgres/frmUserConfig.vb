Imports System.Text.RegularExpressions
Public Class frmUserConfig
    Private _strSerial As String = ""

    Private _odbcConn As eXperDB.ODBC.DXODBC
    Public Sub New(ByVal odbcConn As eXperDB.ODBC.DXODBC, ByVal strSerial As String)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _odbcConn = odbcConn
        _strSerial = strSerial

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblAdminOldPassword.Text = p_clsMsgData.fn_GetData("F004")
        lblAdminNewPassword.Text = p_clsMsgData.fn_GetData("F275")
        lblAdminRepeatPassword.Text = p_clsMsgData.fn_GetData("F276")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnAct.Text = p_clsMsgData.fn_GetData("F003")
    End Sub

    Private Function fn_ChkSvrTestBef() As Boolean
        If txtAdminOldPassword.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", lblAdminOldPassword.Text)
            MsgBox(strMsg)
            txtAdminOldPassword.Focus()
            Return False
        End If

        If txtAdminNewPassword.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", lblAdminNewPassword.Text)
            MsgBox(strMsg)
            txtAdminNewPassword.Focus()
            Return False
        End If

        If txtAdminRepeatPassword.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", lblAdminRepeatPassword.Text)
            MsgBox(strMSg)
            txtAdminRepeatPassword.Focus()
            Return False
        End If

        If txtAdminNewPassword.Text.Length < 8 Or txtAdminNewPassword.Text.Length > 12 Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M037")
            MsgBox(strMSg)
            txtAdminNewPassword.Focus()
            Return False
        End If

        If fn_CheckEnglishNumber(txtAdminNewPassword.Text) = False Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M037")
            MsgBox(strMSg)
            txtAdminNewPassword.Focus()
            Return False
        End If

        If txtAdminNewPassword.Text.Equals(txtAdminRepeatPassword.Text) = False Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M036")
            MsgBox(strMSg)
            txtAdminRepeatPassword.Focus()
            Return False
        End If

        Return True

    End Function

    Private Function fn_CheckEnglishNumber(ByVal letter As String) As Boolean
        Dim IsCheck As Boolean = True
        Dim engRegex As Regex = New Regex("[a-zA-Z]", RegexOptions.IgnoreCase)
        Dim ismatch As Boolean = engRegex.IsMatch(letter)
        Dim numRegex As Regex = New Regex("[0-9]")
        Dim ismatchNum As Boolean = numRegex.IsMatch(letter)
        If ismatch = False Or ismatchNum = False Then
            IsCheck = False
        End If
        Return IsCheck
    End Function

    Private Sub btnAct_Click(sender As Object, e As EventArgs)
        If fn_ChkSvrTestBef() = False Then Return

        ' 추가적으로 모두 업데이트에 대한 로직 필요 

        If _odbcConn IsNot Nothing Then

            Dim ClsQuery As New clsQuerys(_odbcConn)

            Dim crypt As New eXperDB.Common.ClsCrypt

            crypt.TDESImplementation(_strSerial.Substring(0, 24), _strSerial.Substring(0, 8))
            Dim strOldPw As String = crypt.EncryptTDES(txtAdminOldPassword.Text)
            Dim strNewPw As String = crypt.EncryptTDES(txtAdminRepeatPassword.Text)

            Try
                If ClsQuery.CheckPassword(p_UseID, strOldPw) = False Then
                    Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
                    MsgBox(strMsg)
                    txtAdminOldPassword.Focus()
                    Return
                End If
            Catch ex As Exception
                Console.WriteLine(e.ToString)
                MsgBox(p_clsMsgData.fn_GetData("M029"))
                Return
            End Try

            Try
                ClsQuery.UpdatePassword(p_UseID, strNewPw)
            Catch ex As Exception
                Console.WriteLine(e.ToString)
                MsgBox(p_clsMsgData.fn_GetData("M029"))
                Return
            End Try

        End If
        MsgBox(p_clsMsgData.fn_GetData("M028"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class