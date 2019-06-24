
Public Class frmAllowIP
    Private _clsQuery As clsQuerys
    Private _crypt As New eXperDB.Common.ClsCrypt

    Public Sub New(ByVal intRow As Integer)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        lblUserID.Text = p_clsMsgData.fn_GetData("F347")
        lblUserName.Text = p_clsMsgData.fn_GetData("F348")
        lblIP.Text = p_clsMsgData.fn_GetData("F935")

        btnUser.Text = p_clsMsgData.fn_GetData("F008")
        If intRow < 0 Then
            btnAct.Text = p_clsMsgData.fn_GetData("F140")
            cmbCIDR.SelectedIndex = 0
        Else
            btnAct.Text = p_clsMsgData.fn_GetData("F141")
        End If
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        StatusLabel.Text = p_clsMsgData.fn_GetData("F934") + " " + p_clsMsgData.fn_GetData("F016")

    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        'check empty
        If txtUserID.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F347")))
            txtUserID.Focus()
            Return
        End If
        If txtIP.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F935")))
            txtIP.Focus()
            Return
        End If
        If cmbCIDR.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F935")))
            cmbCIDR.Focus()
            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        Dim frmUM As New frmUserList()
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmUM.rtnValue(txtUserID.Text, txtUserName.Text)
        End If
    End Sub

    Public Sub rtnValue(ByRef strUserID As String, ByRef strUserName As String, ByRef strIP As String, ByRef strCIDR As String)
        strUserID = txtUserID.Text
        strUserName = txtUserName.Text
        strIP = txtIP.Text
        strCIDR = cmbCIDR.Text
    End Sub

#Region "Internal functions"

#End Region

End Class