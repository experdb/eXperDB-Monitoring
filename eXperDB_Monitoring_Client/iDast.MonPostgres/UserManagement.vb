Public Class UserManagement

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
        lblPrivileges.Text = p_clsMsgData.fn_GetData("F918", 0)

        coldgvUserLstID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvUserLstName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvUserLstTel.HeaderText = p_clsMsgData.fn_GetData("F349")
        coldgvUserLstTel2.HeaderText = p_clsMsgData.fn_GetData("F349") + "2"
        coldgvUserLstEmail.HeaderText = p_clsMsgData.fn_GetData("F350")
        coldgvUserLstDept.HeaderText = p_clsMsgData.fn_GetData("F915")
        coldgvUserLstAdmin.HeaderText = p_clsMsgData.fn_GetData("F920")

        coldgvPrivilegesGroupName.HeaderText = p_clsMsgData.fn_GetData("F026")

        Me.ttChart.SetToolTip(Me.btnUserCreate, p_clsMsgData.fn_GetData("F016"))
        Me.ttChart.SetToolTip(Me.btnPrivApply, p_clsMsgData.fn_GetData("F014"))

        ReadPrivileges()
        'dgvUserLst.Size.Width = Me.Size.Width


        'Me.ttChart.SetToolTip(Me.btnCreate, p_clsMsgData.fn_GetData("F016"))
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ReadUserList()
            ReadPrivilegesByUser(dgvUserLst.Rows(0).Cells(coldgvUserLstID.Index).Value)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnUserCreate.Click
        Dim intCnt As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvUserLst.Rows
            If tmpRow.Visible = True Then
                intCnt += 1
            End If
        Next

        Dim frmUM As New frmUser(_clsQuery, -1)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReadUserList()
        End If
    End Sub
    Private Sub btnPrivApply_Click(sender As Object, e As EventArgs) Handles btnPrivApply.Click
        'dgvPrivileges

        ' 저장하겠냐는 메시지 출력 
        'If MsgBox(p_clsMsgData.fn_GetData("M006"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then Return
        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP
        Dim nPermCount = dgvPrivileges.ColumnCount - 4
        For Each tmpRow As DataGridViewRow In dgvPrivileges.fn_DataCellChangeRows
            Dim nGroupID As Integer = tmpRow.Cells(coldgvPrivilegesGroupID.Index).Value
            For i As Integer = coldgvPrivilegesGroupID.Index + 2 To nPermCount + 1
                Dim nPermID As Integer = i - 1
                Dim nPermValue As Boolean = IIf(IsDBNull(tmpRow.Cells(i).Value), False, tmpRow.Cells(i).Value)
                Try
                    If nPermValue = True Then
                        _clsQuery.InsertUserPermission(dgvUserLst.SelectedRows(0).Cells(coldgvUserLstID.Index).Value, nGroupID, nPermID, p_cSession.UserID, strLocIP)
                    Else
                        _clsQuery.DeleteUserPermission(dgvUserLst.SelectedRows(0).Cells(coldgvUserLstID.Index).Value, nGroupID, nPermID)
                    End If
                Catch ex As Exception
                    Console.WriteLine(e.ToString)
                    MsgBox(p_clsMsgData.fn_GetData("M029"))
                    Return
                End Try
            Next
        Next
        MsgBox(p_clsMsgData.fn_GetData("M082"))
    End Sub

    Private Sub dgvUserLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserLst.CellClick
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = coldgvUserLstEdit.Index Then
            Dim frmUM As New frmUser(_clsQuery, e.RowIndex, dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstName.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstTel.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstTel2.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstNotiPhone.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstEmail.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstDept.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstAdmin.Index).Value = "Admin", _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstLock.Index).Value = "Locked")
            If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
                ReadUserList()
            End If
        ElseIf e.ColumnIndex = coldgvUserLstDelete.Index Then
            If MsgBox(p_clsMsgData.fn_GetData("M071", dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                Dim COC As New Common.ClsObjectCtl
                Dim strLocIP As String = COC.GetLocalIP
                Dim nReturn As Integer = _clsQuery.DeleteUser(dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value, strLocIP)
                If nReturn <= 0 Then
                    MsgBox(p_clsMsgData.fn_GetData("M029"))
                Else
                    ReadUserList()
                End If
            End If
        Else
            ReadPrivilegesByUser(dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value)
        End If
    End Sub

    Private Sub ReadUserList()
        Try
            Dim dtTable As DataTable = _clsQuery.SelectUser(-1)
            If dtTable IsNot Nothing Then
                Me.dgvUserLst.AutoGenerateColumns = False
                dgvUserLst.DataSource = dtTable
                lblUserList.Text = p_clsMsgData.fn_GetData("F351", dtTable.Rows.Count)
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadPrivileges()
        Try
            Dim dtTable As DataTable = _clsQuery.SelectPrivileges()
            If dtTable IsNot Nothing Then
                Dim index As Integer = 2
                For Each tmpRow As DataRow In dtTable.Rows
                    Dim dtCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
                    dtCol.Name = "coldgvPrivileges" + index.ToString()
                    dtCol.CellTemplate = New DataGridViewCheckBoxCell()
                    dtCol.DataPropertyName = tmpRow.Item("PERM_NAME").ToString()
                    dtCol.Width = 200
                    dtCol.HeaderText = tmpRow.Item("PERM_NAME").ToString()
                    dgvPrivileges.Columns.Insert(index, dtCol)
                    index += 1
                Next
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadPrivilegesByUser(ByVal UserID As String)
        Try
            Dim dtTable As DataTable = _clsQuery.SelectPrivilegesByUser(UserID)
            Me.dgvPrivileges.AutoGenerateColumns = False
            dgvPrivileges.DataSource = dtTable
            lblPrivileges.Text = p_clsMsgData.fn_GetData("F918", dtTable.Rows.Count)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub


End Class
