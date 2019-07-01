Imports System.Text.RegularExpressions
Public Class frmUserPassword
    Private _clsQuery As clsQuerys
    Private _isMyUserInfo As Boolean
    Private _strUserID As String = ""
    Private _PasswordLength As Integer
    Private _isCombine As Boolean

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal isMyUserInfo As Boolean)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = clsQuery
        _strUserID = p_cSession.UserID
        _isMyUserInfo = isMyUserInfo

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblAdminOldPassword.Text = p_clsMsgData.fn_GetData("F004")
        lblAdminNewPassword.Text = p_clsMsgData.fn_GetData("F275")
        lblAdminRepeatPassword.Text = p_clsMsgData.fn_GetData("F276")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnAct.Text = p_clsMsgData.fn_GetData("F003")
    End Sub

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal strUserID As String, ByVal isMyUserInfo As Boolean)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = clsQuery
        _isMyUserInfo = isMyUserInfo
        _strUserID = strUserID

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        If isMyUserInfo Then
            lblAdminOldPassword.Text = p_clsMsgData.fn_GetData("F004")
        Else
            lblAdminOldPassword.Visible = False
            txtAdminOldPassword.Visible = False
        End If
        lblAdminNewPassword.Text = p_clsMsgData.fn_GetData("F275")
        lblAdminRepeatPassword.Text = p_clsMsgData.fn_GetData("F276")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        btnAct.Text = p_clsMsgData.fn_GetData("F003")
    End Sub

    Private Function fn_ChkSvrTestBef() As Boolean
        If _isMyUserInfo Then
            If txtAdminOldPassword.Text = "" Then
                Dim strMsg As String = p_clsMsgData.fn_GetData("M001", lblAdminOldPassword.Text)
                MsgBox(strMsg)
                txtAdminOldPassword.Focus()
                Return False
            End If
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

        If txtAdminNewPassword.Text.Length < _PasswordLength Or txtAdminNewPassword.Text.Length > 16 Then
            Dim strMSg As String = p_clsMsgData.fn_GetData(IIf(_isCombine, "M081", "M037"), _PasswordLength)
            MsgBox(strMSg)
            txtAdminNewPassword.Focus()
            Return False
        End If

        If fn_CheckEnglishNumber(txtAdminNewPassword.Text) = False Then
            Dim strMSg As String = p_clsMsgData.fn_GetData(IIf(_isCombine, "M081", "M037"), _PasswordLength)
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

    Private Function ReadSecurityPolicy() As Boolean
        Dim dtTable As DataTable = _clsQuery.SelectSecurityConfig()
        Dim AgentInfo As structAgent = Nothing
        If dtTable IsNot Nothing AndAlso dtTable.Rows.Count > 0 Then
            _PasswordLength = Integer.Parse(dtTable.Rows(0).Item("PW_MIN_LENGTH").ToString())
            _isCombine = IIf(dtTable.Rows(0).Item("NONALPHANUMERIC_TF").ToString() = "1", True, False)
            Return True
        Else
            Return False
        End If
    End Function

    Private Function fn_CheckEnglishNumber(ByVal letter As String) As Boolean
        Dim IsCheck As Boolean = False
        Dim engRegex As Regex = New Regex("[a-zA-Z]", RegexOptions.IgnoreCase)
        Dim ismatch As Boolean = engRegex.IsMatch(letter)
        Dim numRegex As Regex = New Regex("[0-9]")
        Dim ismatchNum As Boolean = numRegex.IsMatch(letter)
        If _isCombine Then
            Dim nonAlphaRegex As Regex = New Regex("[`~!@#\$%\^&\*\(\)_\-\+=\{\}\[\]\\\|:;""'<>,\.\?/]")
            Dim ismatchNonAlpha As Boolean = nonAlphaRegex.IsMatch(letter)
            If ismatch = True AndAlso ismatchNum = True AndAlso ismatchNonAlpha = True Then
                IsCheck = True
            End If
        Else
            If ismatch = True OrElse ismatchNum = True Then
                IsCheck = True
            End If
        End If
        Return IsCheck
    End Function

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If ReadSecurityPolicy() = False Then Return
        If fn_ChkSvrTestBef() = False Then Return

        ' 추가적으로 모두 업데이트에 대한 로직 필요 
        If _clsQuery IsNot Nothing Then
            Dim crypt As New eXperDB.Common.ClsCrypt

            Dim strNewPw As String = crypt.EncryptStringSHA256(txtAdminRepeatPassword.Text)
            If _isMyUserInfo Then
                Try
                    Dim strOldPw As String = crypt.EncryptStringSHA256(txtAdminOldPassword.Text)
                    Dim dataTable As DataTable = _clsQuery.CheckLogin(_strUserID, strOldPw)
                    If dataTable Is Nothing OrElse dataTable.Rows.Count = 0 Then
                        MsgBox(p_clsMsgData.fn_GetData("M005"))
                        'If Not txtAdminOldPassword.Text.Equals("k4m") Or _clsQuery.CheckPassword(p_UseID, txtAdminOldPassword.Text) = False Then
                        '    Dim strMsg As String = p_clsMsgData.fn_GetData("M005")
                        '    MsgBox(strMsg)
                        '    txtAdminOldPassword.Focus()
                        '    Return
                        'End If
                    End If
                Catch ex As Exception
                    Console.WriteLine(e.ToString)
                    MsgBox(p_clsMsgData.fn_GetData("M029"))
                    Return
                End Try
            End If

            Try
                _clsQuery.UpdatePassword(_strUserID, strNewPw)
                p_cSession.UserPassword = strNewPw
            Catch ex As Exception
                Console.WriteLine(e.ToString)
                MsgBox(p_clsMsgData.fn_GetData("M029"))
                Return
            End Try

        End If
        MsgBox(p_clsMsgData.fn_GetData("M028"))
        AccessLog("change_user_pwd", 0, _strUserID)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmUserConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StatusLabel.Text = p_clsMsgData.fn_GetData("M056")
    End Sub

    Private Sub AccessLog(ByVal strAccessType As String, ByVal intStatus As Integer, _
                  Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertUserAccessInfo(p_cSession.UserID, strAccessType, intStatus, strLog, strLocIP)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
End Class