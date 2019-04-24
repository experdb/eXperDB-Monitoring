
Public Class frmUser
    Private _clsQuery As clsQuerys
    Public Sub New(ByVal nRow As Integer, Optional strUserID As String = "", Optional strUserName As String = "", Optional strPhone As String = "", Optional strEmail As String = "")

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblPhone.Text = p_clsMsgData.fn_GetData("F349")
        lblEmail.Text = p_clsMsgData.fn_GetData("F350")
        If nRow >= 0 Then
            btnAct.Text = p_clsMsgData.fn_GetData("F141")
        Else
            btnAct.Text = p_clsMsgData.fn_GetData("F140")
        End If
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)
        _clsQuery = New clsQuerys(tmpCn)

        If nRow < 0 Then
            StatusLabel.Text = p_clsMsgData.fn_GetData("M067")
            txtUserID.Select()
        Else
            StatusLabel.Text = p_clsMsgData.fn_GetData("M067")
            txtUserID.Text = strUserID
            txtUserID.Enabled = False
            txtUserName.Text = strUserName
            txtUserName.Enabled = False
            txtPhone.Text = strPhone
            txtEmail.Text = strEmail
            txtPhone.Select()
        End If

    End Sub

    ''' <summary>
    ''' 서버 목록 추가 버튼 클릭시 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub rtnValue(ByRef intRow As Integer, ByRef strUserID As String, ByRef strUserName As String, ByRef strPhone As String, ByRef strEmail As String)
        strUserID = txtUserID.Text
        strUserName = txtUserName.Text
        strPhone = txtPhone.Text
        strEmail = txtEmail.Text
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        If txtUserID.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "User ID"))
            Return
        End If
        If txtUserName.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "User Name"))
            Return
        End If
        If txtPhone.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Phone number"))
            Return
        End If
        If txtEmail.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", "Email address"))
            Return
        End If

        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Dim nReturn As Integer = 0
        If txtUserID.Enabled = True Then
            nReturn = _clsQuery.insertUser(txtUserID.Text, txtUserName.Text, "", txtPhone.Text, txtEmail.Text, strLocIP)
        Else
            nReturn = _clsQuery.UpdateUser(txtUserID.Text, "", txtPhone.Text, txtEmail.Text, strLocIP)
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
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUserID.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

End Class