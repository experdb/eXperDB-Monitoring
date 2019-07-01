Public Class UserAlertGroup

    Private _clsQuery As clsQuerys
    Public Sub New(ByRef odbcConn As eXperDBODBC)
        ' 이 호출은 디자이너에 필요합니다
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _clsQuery = New clsQuerys(odbcConn)
        initForm()
    End Sub

    Private Sub initForm()
        'Me.dgvUserLst.AutoGenerateColumns = False
        lblUserList.Text = p_clsMsgData.fn_GetData("F351", 0)
        lblGroupUserList.Text = p_clsMsgData.fn_GetData("F026") + " " + p_clsMsgData.fn_GetData("F351", 0)

        coldgvGroupLstName.HeaderText = p_clsMsgData.fn_GetData("F310")

        coldgvUserLstID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvUserLstName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvUserLstTel.HeaderText = p_clsMsgData.fn_GetData("F349")
        coldgvUserLstEmail.HeaderText = p_clsMsgData.fn_GetData("F350")
        coldgvUserLstDept.HeaderText = p_clsMsgData.fn_GetData("F915")

        coldgvGroupUsersID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvGroupUsersName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvGroupUsersTel.HeaderText = p_clsMsgData.fn_GetData("F349")
        coldgvGroupUsersEmail.HeaderText = p_clsMsgData.fn_GetData("F350")
        coldgvGroupUsersDept.HeaderText = p_clsMsgData.fn_GetData("F915")


        '        Me.ttChart.SetToolTip(Me.btnAdd, p_clsMsgData.fn_GetData("F016"))
        Me.ttChart.SetToolTip(Me.btnAddUserGroup, p_clsMsgData.fn_GetData("F016"))
        Me.ttChart.SetToolTip(Me.btnDeleteUserGroup, p_clsMsgData.fn_GetData("F015"))
        Me.ttChart.SetToolTip(Me.btnAddGroup, p_clsMsgData.fn_GetData("F942"))
        Me.ttChart.SetToolTip(Me.btnModifyGroup, p_clsMsgData.fn_GetData("F943"))
        Me.ttChart.SetToolTip(Me.btnDeleteGroup, p_clsMsgData.fn_GetData("F944"))

        'dgvUserLst.Size.Width = Me.Size.Width


        'Me.ttChart.SetToolTip(Me.btnCreate, p_clsMsgData.fn_GetData("F016"))
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadGroupList()
            If dgvGroupLst.Rows.Count > 0 Then
                dgvGroupLst.Rows(0).Selected = True
                ReadUserListbyGroup()
            End If
            ReadUserList()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
    Private Sub ReadGroupList()
        Try
            dgvGroupLst.AutoGenerateColumns = False
            dgvGroupLst.RowTemplate.Height = 30
            Dim dtTable As DataTable = _clsQuery.SelectMonUserGroup()
            If dtTable IsNot Nothing Then
                dgvGroupLst.DataSource = dtTable
                'lGroupList.Text = p_clsMsgData.fn_GetData("F026") + " ( " + dtTable.Rows.Count.ToString() + " ) "
                lblGroupList.Text = p_clsMsgData.fn_GetData("F941")
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
    Private Sub ReadUserList()
        Try
            dgvUserLst.AutoGenerateColumns = False
            Dim groupID As Integer = -1
            If dgvGroupLst.SelectedRows.Count > 0 Then
                groupID = dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstID.Index).Value
            End If
            Dim dtTable As DataTable = _clsQuery.SelectUser(groupID)
            If dtTable IsNot Nothing Then
                Me.dgvUserLst.AutoGenerateColumns = False
                dgvUserLst.DataSource = dtTable
                lblUserList.Text = p_clsMsgData.fn_GetData("F351", dtTable.Rows.Count)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadUserListbyGroup()
        Try
            dgvGroupUsers.AutoGenerateColumns = False
            Dim dtTable = _clsQuery.SelectUserByGroup(dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstID.Index).Value)
            If dtTable IsNot Nothing Then
                dgvGroupUsers.DataSource = dtTable
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        Dim frmUM As New frmGroup(_clsQuery)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReadGroupList()
        End If
    End Sub

    Private Sub btnModifyGroup_Click(sender As Object, e As EventArgs) Handles btnModifyGroup.Click
        Dim frmUM As New frmGroup(_clsQuery, dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstID.Index).Value, dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstName.Index).Value)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReadGroupList()
        End If
    End Sub

    Private Sub dgvGroupLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroupLst.CellClick
        If e.RowIndex >= 0 Then
            ReadUserListbyGroup()
            ReadUserList()
        End If
    End Sub

    Private Sub btnAddUserGroup_Click(sender As Object, e As EventArgs) Handles btnAddUserGroup.Click
        Dim nReturn As Integer = 0
        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        If dgvGroupLst.SelectedRows.Count <= 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M090"))
            Return
        End If
        Dim groupID As Integer = dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstID.Index).Value
        Try
            For Each tmpRow As DataGridViewRow In Me.dgvUserLst.SelectedRows
                nReturn = _clsQuery.insertUserGroup(tmpRow.Cells(coldgvUserLstID.Index).Value, groupID, p_cSession.UserID, strLocIP)
            Next
            ReadUserListbyGroup()
            ReadUserList()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnDeleteUserGroup_Click(sender As Object, e As EventArgs) Handles btnDeleteUserGroup.Click
        Dim nReturn As Integer = 0
        If dgvGroupLst.SelectedRows.Count <= 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M090"))
            Return
        End If
        Dim groupID As Integer = dgvGroupLst.SelectedRows(0).Cells(coldgvGroupLstID.Index).Value
        Dim arrUesrIDs As New ArrayList
        For Each tmpRow As DataGridViewRow In Me.dgvGroupUsers.SelectedRows
            arrUesrIDs.Add(tmpRow.Cells(coldgvGroupLstID.Index).Value)
        Next
        Dim Users As String() = arrUesrIDs.ToArray(GetType(String))
        Dim strUsers = "'" + String.Join("','", Users) + "'"
        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Try
            nReturn = _clsQuery.DeleteUserByGroup(strUsers, groupID)
            ReadUserListbyGroup()
            ReadUserList()
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

End Class
