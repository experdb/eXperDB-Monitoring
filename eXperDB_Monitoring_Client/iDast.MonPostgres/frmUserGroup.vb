Public Class frmUserGroup


    Private _AgentIP As String
    Private _AgentPort As Integer
    Private _checkAgentInterval As Integer = 1000
    Private _startDt As String
    Private _applyCount As Integer = 0
    Private crypt As New eXperDB.Common.ClsCrypt
    Private _clsQuery As clsQuerys
    Private _groupID As Integer = -1

#Region "Form Initialize"


    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        initForm()

    End Sub

    Private Sub initForm()

        'Me.grpAgentSvr.Text = p_clsMsgData.fn_GetData("F001")
        'btnConTest.Text = p_clsMsgData.fn_GetData("F002")
        'btnConSave.Text = p_clsMsgData.fn_GetData("F003")
        'lblSvrIP.Text = p_clsMsgData.fn_GetData("F006")
        'lblSvrPort.Text = p_clsMsgData.fn_GetData("F007")
        'lblSvrUsr.Text = p_clsMsgData.fn_GetData("F008")
        'lblSvrPwd.Text = p_clsMsgData.fn_GetData("F009")
        'lblSvrDBNm.Text = p_clsMsgData.fn_GetData("F010")
        Me.dgvGroupLst.AutoGenerateColumns = False
        Me.dgvUserLst.AutoGenerateColumns = False

        coldgvGroupLstID.HeaderText = p_clsMsgData.fn_GetData("F346")
        coldgvGroupLstName.HeaderText = p_clsMsgData.fn_GetData("F310")

        coldgvUserLstID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvUserLstName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvUserLstTel.HeaderText = p_clsMsgData.fn_GetData("F349")
        coldgvUserLstEmail.HeaderText = p_clsMsgData.fn_GetData("F350")

        btnApply.Text = p_clsMsgData.fn_GetData("F352")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        lblGroupList.Text = p_clsMsgData.fn_GetData("F026")
        lblUserList.Text = p_clsMsgData.fn_GetData("F351")

        modCommon.FontChange(Me, p_Font)

        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)
        _clsQuery = New clsQuerys(tmpCn)
        If tmpCn.ConnectionCheck = True Then
            lblUserList.Tag = tmpCn
            ReadGroupList()
        Else
            lblUserList.Enabled = False
            btnApply.Tag = Nothing
            ' 접속 실패시 
            MsgBox(p_clsMsgData.fn_GetData("M004"))
            Return
        End If

        If dgvGroupLst.Rows.Count > 0 Then
            dgvGroupLst.Rows(0).Selected = True
            _groupID = 0
            ReadUserListbyGroup()
        End If
    End Sub

    Private Sub frmUserGroup_Load(sender As Object, e As EventArgs) Handles Me.Load
        MsgLabel.Text = p_clsMsgData.fn_GetData("M072")
    End Sub


#End Region

#Region "Group List"
    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadGroupList()
        dgvGroupLst.Rows.Clear()

        Try
            Dim dtTable As DataTable = _clsQuery.SelectUserGroup()
            If dtTable IsNot Nothing Then
                dgvGroupLst.DataSource = dtTable
                lblGroupList.Text = p_clsMsgData.fn_GetData("F026") + " ( " + dtTable.Rows.Count.ToString() + " ) "
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region


#Region "User List"
    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadUserListbyGroup()
        Try
            Dim dtTable = _clsQuery.SelectUserByGroup(_groupID)
            If dtTable IsNot Nothing Then
                dgvUserLst.DataSource = dtTable
                lblUserList.Text = p_clsMsgData.fn_GetData("F013") + " ( " + dtTable.Rows.Count.ToString + " ) "
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region


    ''' <summary>
    ''' 서버 목록을 선택 하였을 경우 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvUserLst_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvUserLst.CellMouseDown
        'If e.Button = Windows.Forms.MouseButtons.Left Then

        'End If
    End Sub

    ''' <summary>
    ''' 적용 버튼을 클릭 하엿을 경우 해당 복록을 DB에 저장한다. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub AddData(ByVal intRow As Integer, ByVal strUserID As String, ByVal strUserName As String, ByRef strPhone As String, ByRef strEmail As String)
        If intRow >= 0 Then
            Dim tmpRow As DataGridViewRow = dgvUserLst.Rows(intRow)

            tmpRow.Cells(coldgvUserLstID.Index).Value = strUserID
            tmpRow.Cells(coldgvUserLstName.Index).Value = strUserName
            tmpRow.Cells(coldgvUserLstTel.Index).Value = strPhone
            tmpRow.Cells(coldgvUserLstEmail.Index).Value = strEmail
        Else
            Dim tmpIpRow As DataGridViewRow = dgvUserLst.FindFirstRow(strUserID, coldgvUserLstID.Index, True)
            If tmpIpRow Is Nothing Then
                Dim idxRow As Integer = dgvUserLst.Rows.Add()
                dgvUserLst.fn_DataCellADD(idxRow, coldgvUserLstID.Index, strUserID)
                dgvUserLst.fn_DataCellADD(idxRow, coldgvUserLstName.Index, strUserName)
                dgvUserLst.fn_DataCellADD(idxRow, coldgvUserLstTel.Index, strPhone)
                dgvUserLst.fn_DataCellADD(idxRow, coldgvUserLstEmail.Index, strEmail)
                dgvUserLst.Rows(idxRow).Tag = -1
            Else
                Dim strMsg As String = p_clsMsgData.fn_GetData("M011")
                MsgBox(strMsg)
            End If

        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim intCnt As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvUserLst.Rows
            If tmpRow.Visible = True Then
                intCnt += 1
            End If
        Next

        Dim frmUM As New frmUserList(_groupID)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReadUserListbyGroup()
        End If

        Dim nCount As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvUserLst.Rows
            If tmpRow.Visible = True Then
                nCount += 1
            End If
        Next

        lblUserList.Text = p_clsMsgData.fn_GetData("F351") + " ( " + nCount.ToString + " ) "

    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs)
        If dgvUserLst.SelectedRows.Count <= 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M034"))
            Return
        End If

        Dim tmpRow As DataGridViewRow = dgvUserLst.SelectedRows(0)
        Dim intSelRow As Integer = tmpRow.Index
        Dim strUserID As String = tmpRow.Cells(coldgvUserLstID.Index).Value
        Dim strUserName As String = tmpRow.Cells(coldgvUserLstName.Index).Value
        Dim strUserPhone As String = tmpRow.Cells(coldgvUserLstTel.Index).Value
        Dim strUserEmail As String = tmpRow.Cells(coldgvUserLstEmail.Index).Value

        Dim intCnt As Integer = 0
        For Each cntRow As DataGridViewRow In Me.dgvUserLst.Rows
            If cntRow.Visible = True Then
                intCnt += 1
            End If
        Next
        Dim frmUM As New frmUser(intSelRow, strUserID, strUserName, strUserPhone, strUserEmail)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim rtnUserID As String = ""
            Dim rtnUserName As String = ""
            Dim rtnUserPhone As String = ""
            Dim rtnUserEmail As String = ""

            frmUM.rtnValue(-1, rtnUserID, rtnUserName, rtnUserPhone, rtnUserEmail)
            AddData(tmpRow.Index, rtnUserID, rtnUserName, rtnUserPhone, rtnUserEmail)
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim nCount As Integer = 0
        For Each tmpRow As DataGridViewRow In Me.dgvUserLst.Rows
            If tmpRow.Selected = True Then
                tmpRow.Visible = False
            Else
                nCount += 1
            End If
        Next
        lblUserList.Text = p_clsMsgData.fn_GetData("F013") + " ( " + nCount.ToString + " ) "
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvGroupLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroupLst.CellClick
        If e.RowIndex >= 0 Then
            _groupID = dgvGroupLst.Rows(e.RowIndex).Cells(coldgvGroupLstID.Index).Value
            ReadUserListbyGroup()
        End If
    End Sub

    Private Sub dgvUserLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserLst.CellClick
        If e.ColumnIndex = coldgvUserLstDelete.Index Then
            If MsgBox(p_clsMsgData.fn_GetData("M071", dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                Dim COC As New Common.ClsObjectCtl
                Dim strLocIP As String = COC.GetLocalIP
                Dim nReturn As Integer = _clsQuery.DeleteUserByGroup(dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value, _groupID)
                If nReturn <= 0 Then
                    MsgBox(p_clsMsgData.fn_GetData("M029"))
                Else
                    ReadUserListbyGroup()
                End If
            End If
        End If
    End Sub

    Public Sub rtnValue(ByRef intUserGroup As Integer)
        intUserGroup = _groupID
    End Sub
End Class