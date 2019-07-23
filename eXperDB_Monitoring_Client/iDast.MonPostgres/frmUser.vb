Imports System.Text.RegularExpressions
Public Class frmUser
    Private _clsQuery As clsQuerys
    Private _crypt As New eXperDB.Common.ClsCrypt

    Private _PasswordLength As Integer
    Private _isCombine As Boolean

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal nRow As Integer, Optional strUserID As String = "", Optional strUserName As String = "", _
                   Optional strPhone As String = "", Optional strPhone2 As String = "", Optional nUserNotiPhone As Integer = 0, _
                   Optional strEmail As String = "", Optional strDept As String = "", Optional IsAdmin As Boolean = False, Optional IsLock As Boolean = False)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblPassword.Text = p_clsMsgData.fn_GetData("F004")
        lblPasswordConfirm.Text = p_clsMsgData.fn_GetData("F276")
        lblPhone.Text = p_clsMsgData.fn_GetData("F349")
        lblPhone2.Text = p_clsMsgData.fn_GetData("F349") + "2"
        lblEmail.Text = p_clsMsgData.fn_GetData("F350")
        lblDept.Text = p_clsMsgData.fn_GetData("F915")
        lblAdmin.Text = p_clsMsgData.fn_GetData("F920")
        rbUseNoti1.Text = p_clsMsgData.fn_GetData("F922")
        rbUseNoti2.Text = p_clsMsgData.fn_GetData("F922")
        btnPassword.Text = p_clsMsgData.fn_GetData("F279")
        lblLock.Text = p_clsMsgData.fn_GetSpecificData("M084", "DESC")

        _clsQuery = clsQuery
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        If nRow < 0 Then
            btnAct.Text = p_clsMsgData.fn_GetData("F140")
            StatusLabel.Text = p_clsMsgData.fn_GetData("M067") + " " + p_clsMsgData.fn_GetData("F140")
            Dim posC1 As TableLayoutPanelCellPosition = tlpSvrChk.GetCellPosition(btnPassword)
            Dim posC2 As TableLayoutPanelCellPosition = tlpSvrChk.GetCellPosition(txtPassword)
            posC1.Column = 3
            posC2.Column = 2
            tlpSvrChk.SetCellPosition(btnPassword, posC1)
            tlpSvrChk.SetCellPosition(txtPassword, posC2)
            txtUserID.Select()
            rbUseNoti1.Checked = False
        Else
            btnAct.Text = p_clsMsgData.fn_GetData("F141")
            StatusLabel.Text = p_clsMsgData.fn_GetData("M067") + " " + p_clsMsgData.fn_GetData("F141")
            txtUserID.Text = strUserID
            txtUserID.Enabled = False
            txtUserName.Text = strUserName
            txtPhone.Text = strPhone
            txtPhone2.Text = strPhone2
            txtEmail.Text = strEmail
            txtDept.Text = strDept
            chkAdmin.Checked = IsAdmin
            chkLock.Checked = IsLock
            btnPassword.Visible = True
            Dim posC1 As TableLayoutPanelCellPosition = tlpSvrChk.GetCellPosition(btnPassword)
            Dim posC2 As TableLayoutPanelCellPosition = tlpSvrChk.GetCellPosition(txtPassword)
            posC1.Column = 2
            posC2.Column = 3
            tlpSvrChk.SetCellPosition(btnPassword, posC1)
            tlpSvrChk.SetCellPosition(txtPassword, posC2)
            txtPassword.Visible = False
            txtPasswordConfirm.Visible = False
            lblPassword.Visible = False
            lblPasswordConfirm.Visible = False
            If nUserNotiPhone = 0 Then
                rbUseNoti1.Checked = True
            Else
                rbUseNoti2.Checked = True
            End If

            txtPhone.Select()
        End If

    End Sub

    Public Sub rtnValue(ByRef intRow As Integer, ByRef strUserID As String, ByRef strUserName As String, ByRef strPhone As String, ByRef strEmail As String)
        strUserID = txtUserID.Text
        strUserName = txtUserName.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If ReadSecurityPolicy() = False Then Return

        'check empty
        If txtUserID.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F347")))
            txtUserID.Focus()
            Return
        End If
        If txtUserName.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F348")))
            txtUserName.Focus()
            Return
        End If
        If txtUserID.Enabled = True Then
            If txtPassword.Text = "" Then
                MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F004")))
                txtPassword.Focus()
                Return
            End If
            If txtPasswordConfirm.Text = "" Then
                MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F276")))
                txtPasswordConfirm.Focus()
                Return
            End If
            If txtPassword.Text.Equals(txtPasswordConfirm.Text) = False Then
                MsgBox(p_clsMsgData.fn_GetData("M036"))
                txtPasswordConfirm.Focus()
                Return
            End If
        End If

        'If txtPassword.Text.Length < _PasswordLength Or txtPassword.Text.Length > 16 Then
        '    Dim strMSg As String = p_clsMsgData.fn_GetData(IIf(_isCombine, "M081", "M037"), _PasswordLength)
        '    MsgBox(strMSg)
        '    txtPassword.Focus()
        '    Return
        'End If

        'If fn_CheckEnglishNumber(txtPassword.Text) = False Then
        '    Dim strMSg As String = p_clsMsgData.fn_GetData(IIf(_isCombine, "M081", "M037"), _PasswordLength)
        '    MsgBox(strMSg)
        '    txtPassword.Focus()
        '    Return
        'End If


        'Dim strkey = fn_GetSerial()
        '_crypt.TDESImplementation(strkey.Substring(0, 24), strkey.Substring(0, 8))
        'Dim strPw = _crypt.EncryptTDES(txtPassword.Text)
        Dim strPw = _crypt.EncryptStringSHA256(txtPassword.Text)

        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Dim nReturn As Integer = 0
        If txtUserID.Enabled = True Then
            nReturn = _clsQuery.insertUser(txtUserID.Text, txtUserName.Text, strPw, txtPhone.Text, txtPhone2.Text, IIf(rbUseNoti1.Checked, 0, 1), txtEmail.Text, txtDept.Text, chkAdmin.Checked, chkLock.Checked, p_cSession.UserID, strLocIP)
        Else
            nReturn = _clsQuery.UpdateUser(txtUserID.Text, txtUserName.Text, txtPhone.Text, txtPhone2.Text, IIf(rbUseNoti1.Checked, 0, 1), txtEmail.Text, txtDept.Text, strLocIP, IIf(chkAdmin.Checked, 1, 0), IIf(chkLock.Checked, 1, 0))
        End If
        Select Case nReturn
            Case -23505
                MsgBox(p_clsMsgData.fn_GetData("M070"))
                txtUserID.Select()
                Return
            Case -1
                MsgBox(p_clsMsgData.fn_GetData("M029"))
                Return
        End Select

        _clsQuery.InsertMonUserConfigDefault(txtUserID.Text)
        If txtUserID.Enabled = False Then
            MsgBox(p_clsMsgData.fn_GetData("M082"))
        Else
            MsgBox(p_clsMsgData.fn_GetData("M091"))
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnPassword_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        Dim strkey = fn_GetSerial()
        Dim frmPassword As New frmUserPassword(_clsQuery, txtUserID.Text, False)
        frmPassword.ShowDialog()
    End Sub

#Region "Internal functions"
    Private Function fn_GetSerial() As String
        Dim strKey As String
        Try
            Dim dtTable As DataTable = _clsQuery.SelectSerialKey()
            If dtTable IsNot Nothing Then
                Dim dtRow As DataRow = dtTable.Rows(0)
                strKey = dtRow.Item("LICDATA")
                If strKey.Length < 24 Then
                    Return ""
                End If
                Return strKey
            End If
            Return ""
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return ""
        End Try
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
#End Region


End Class