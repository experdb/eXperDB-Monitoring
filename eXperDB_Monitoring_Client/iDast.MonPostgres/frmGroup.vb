
Public Class frmGroup
    Private _clsQuery As clsQuerys
    Private _crypt As New eXperDB.Common.ClsCrypt

    Public Sub New(ByRef clsQuery As clsQuerys, Optional nGroupID As Integer = -1, Optional strGroupName As String = "")

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _clsQuery = clsQuery
        lblGroupName.Text = p_clsMsgData.fn_GetData("F310")
        If nGroupID < 0 Then
            StatusLabel.Text = p_clsMsgData.fn_GetData("F941") + " " + p_clsMsgData.fn_GetData("F140")
            btnAct.Text = p_clsMsgData.fn_GetData("F140")
            btnAct.Tag = 0
        Else
            btnAct.Text = p_clsMsgData.fn_GetData("F141")
            StatusLabel.Text = p_clsMsgData.fn_GetData("F941") + " " + p_clsMsgData.fn_GetData("F141")
            txtGroupName.Tag = nGroupID
            txtGroupName.Text = strGroupName
            btnAct.Tag = 1
        End If

        btnClose.Text = p_clsMsgData.fn_GetData("F021")

    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        'check empty
        If txtGroupName.Text = "" Then
            MsgBox(p_clsMsgData.fn_GetData("M001", p_clsMsgData.fn_GetData("F348")))
            txtGroupName.Focus()
            Return
        End If
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            Dim nReturn As Integer = 0
            If btnAct.Tag = 0 Then
                nReturn = _clsQuery.InsertMonUserGroup(txtGroupName.Text, p_cSession.UserID, strLocIP)
            Else
                nReturn = _clsQuery.UpdateMonUserGroup(txtGroupName.Tag, txtGroupName.Text, p_cSession.UserID, strLocIP)
            End If
            Select Case nReturn
                Case -23505
                    MsgBox(p_clsMsgData.fn_GetData("M070"))
                    txtGroupName.Select()
                    Return
                Case -1
                    MsgBox(p_clsMsgData.fn_GetData("M029"))
                    Return
            End Select
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
        'MsgBox(p_clsMsgData.fn_GetData("M082"))
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtGroupName.Select()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub




End Class