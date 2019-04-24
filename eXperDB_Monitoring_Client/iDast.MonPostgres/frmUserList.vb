Public Class frmUserList


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

    Public Sub New(ByVal groupID As Integer)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _groupID = groupID

        initForm()
    End Sub

    Private Sub initForm()
        Me.dgvUserLst.AutoGenerateColumns = False

        coldgvUserLstID.HeaderText = p_clsMsgData.fn_GetData("F347")
        coldgvUserLstName.HeaderText = p_clsMsgData.fn_GetData("F348")
        coldgvUserLstTel.HeaderText = p_clsMsgData.fn_GetData("F349")
        coldgvUserLstEmail.HeaderText = p_clsMsgData.fn_GetData("F350")

        btnApply.Text = p_clsMsgData.fn_GetData("F016")

        btnClose.Text = p_clsMsgData.fn_GetData("F021")
        MsgLabel.Text = p_clsMsgData.fn_GetData("M069")

        modCommon.FontChange(Me, p_Font)

        'Me.ttChart.SetToolTip(Me.btnDelete, p_clsMsgData.fn_GetData("F015"))
        'Me.ttChart.SetToolTip(Me.btnModify, p_clsMsgData.fn_GetData("F141"))
        Me.ttChart.SetToolTip(Me.btnCreate, p_clsMsgData.fn_GetData("F016"))
    End Sub

    Private Sub frmUserGroup_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New eXperDBODBC(dbType, tmpStruct.HostIP, tmpStruct.Port, tmpStruct.UserID, tmpStruct.Password, tmpStruct.DBName)
        _clsQuery = New clsQuerys(tmpCn)
        If tmpCn.ConnectionCheck = True Then
            lblUserList.Tag = tmpCn
            ReadUserList()
        Else
            lblUserList.Enabled = False
            btnApply.Tag = Nothing
            ' 접속 실패시 
            MsgBox(p_clsMsgData.fn_GetData("M004"))
            Return
        End If
    End Sub


#End Region


#Region "User List"
    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReadUserList()
        Try
            Dim dtTable As DataTable = _clsQuery.SelectUser(_groupID)
            If dtTable IsNot Nothing Then
                dgvUserLst.DataSource = dtTable
                lblUserList.Text = p_clsMsgData.fn_GetData("F351") + " ( " + dtTable.Rows.Count + " ) "
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
#End Region
    Private Sub dgvUserLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserLst.CellClick
        If e.ColumnIndex = coldgvUserLstEdit.Index Then
            Dim frmUM As New frmUser(e.RowIndex, dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstID.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstName.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstTel.Index).Value, _
                                    dgvUserLst.Rows(e.RowIndex).Cells(coldgvUserLstEmail.Index).Value)
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
        End If
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

        Dim frmUM As New frmUser(-1)
        If frmUM.ShowDialog = Windows.Forms.DialogResult.OK Then
            ReadUserList()
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim COC As New Common.ClsObjectCtl
        Dim strLocIP As String = COC.GetLocalIP

        For Each tmpRow As DataGridViewRow In dgvUserLst.Rows
            If tmpRow.Selected = True Then
                Dim strUserID As String = tmpRow.Cells(coldgvUserLstID.Index).Value
                Dim strGroupID As String = _groupID
                Dim nReturn As Integer = _clsQuery.insertUserGroup(strUserID, strGroupID, strLocIP)
                Select Case nReturn
                    Case -1
                        MsgBox(p_clsMsgData.fn_GetData("M029"))
                        Return
                End Select
            End If
        Next
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
        lblUserList.Text = p_clsMsgData.fn_GetData("F351") + " ( " + nCount.ToString + " ) "
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class