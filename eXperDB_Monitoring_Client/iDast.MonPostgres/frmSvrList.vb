Public Class frmSvrList


#Region "Agent"

    Private Sub btnConTest_Click(sender As Object, e As EventArgs) Handles btnConTest.Click




        If fn_ChkTestBef() = False Then Return
        Dim strIp As String = txtSvrIP.Text
        Dim strPort As Integer = txtSvrPort.Text
        Dim strID As String = txtSvrUsr.Text
        Dim strPw As String = txtSvrPwd.Text
        Dim DBName As String = cmbSvrDBNm.Text


        Dim dbType As DXODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New DXODBC(dbtype, strIp, strPort, strID, strPw, DBName)
        If tmpCn.ConnectionCheck = True Then
            MsgBox(p_clsMsgData.fn_GetData("M003"))
            sb_Ctlenabled(True)
            ReadSvrList(tmpCn)
            btnConTest.Tag = tmpCn

        Else
            MsgBox(p_clsMsgData.fn_GetData("M004"))
            sb_Ctlenabled(False)
            Return
        End If


    End Sub

    ''' <summary>
    ''' 서버리스트를 불러온다. 
    ''' </summary>
    ''' <param name="conODBC"></param>
    ''' <remarks></remarks>
    Private Sub ReadSvrList(ByVal conODBC As eXperDB.ODBC.DXODBC)
        dgvSvrLst.Rows.Clear()

        If conODBC Is Nothing Then Return

        Dim clsIni As New Common.IniFile(p_AppConfigIni)

        Dim ClsQuery As New clsQuerys(conODBC)
        Dim dtTable As DataTable = ClsQuery.SelectServerList()
        If dtTable IsNot Nothing Then
            For Each tmpRow As DataRow In dtTable.Rows
                Dim idxRow As Integer = dgvSvrLst.Rows.Add()
                ' Tag에는 Instance ID를 넣은다. 
                ' Add시에는 Instance ID = -1 
                ' Delete 시에는 Visible를 꺼서 삭제 목록을 가져온다. 
                dgvSvrLst.Rows(idxRow).Tag = tmpRow.Item("INSTANCE_ID")
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 

                dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, tmpRow.Item("COLLECT_YN"))
                dgvSvrLst.fn_DataCellADD(idxRow, colIP.Index, tmpRow.Item("SERVER_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPort.Index, tmpRow.Item("SERVICE_PORT"))
                dgvSvrLst.fn_DataCellADD(idxRow, colUser.Index, tmpRow.Item("CONN_USER_ID"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPW.Index, tmpRow.Item("CONN_USER_PWD"))
                dgvSvrLst.fn_DataCellADD(idxRow, colDBNm.Index, tmpRow.Item("CONN_DB_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colAliasNm.Index, tmpRow.Item("CONN_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colLstIP.Index, tmpRow.Item("LAST_MOD_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHostNm.Index, IIf(IsDBNull(tmpRow.Item("HOST_NAME")), "", tmpRow.Item("HOST_NAME")))
                dgvSvrLst.fn_DataCellADD(idxRow, colStartTime.Index, IIf(IsDBNull(tmpRow.Item("INSTANCE_UPTIME")), DateTime.MinValue, tmpRow.Item("INSTANCE_UPTIME")))


                Dim strGrp As String = clsIni.ReadValue("SERVER GROUP", tmpRow.Item("INSTANCE_ID"), 0)
                If strGrp.Trim <> "" Then
                    DirectCast(dgvSvrLst.Rows(idxRow).Cells(colGrp.Index), DataGridViewComboBoxCell).Value = strGrp
                Else
                    DirectCast(dgvSvrLst.Rows(idxRow).Cells(colGrp.Index), DataGridViewComboBoxCell).Value = 1
                End If




            Next


        End If



    End Sub




    Private Function fn_ChkTestBef() As Boolean
        If txtSvrIP.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "IP")
            MsgBox(strMsg)
            txtSvrIP.Focus()
            Return False
        Else
            If Common.ClsObjectCtl.fn_CheckIPAddress(txtSvrIP.Text) = False Then
                Dim strMsg As String = p_clsMsgData.fn_GetData("M002")
                MsgBox(strMsg)
                txtSvrIP.Focus()
                Return False
            End If
        End If


        If txtSvrPort.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "PORT")
            MsgBox(strMsg)
            txtSvrPort.Focus()
            Return False

        End If


        If txtSvrUsr.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "User")
            MsgBox(strMSg)
            txtSvrUsr.Focus()
            Return False
        End If

        If cmbSvrDBNm.Text = "" Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M001", "Password")
            MsgBox(strMsg)
            cmbSvrDBNm.Focus()
            Return False
        End If

        If cmbSvrDBNm.Text = "" Then
            Dim strMSg As String = p_clsMsgData.fn_GetData("M001", "Database Name")
            MsgBox(strMSg)
            cmbSvrDBNm.Focus()
            Return False
        End If

        Return True

    End Function

    ''' <summary>
    ''' Agent 서버 접속 정보 저장 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnConSave_Click(sender As Object, e As EventArgs) Handles btnConSave.Click

        If btnConTest.Tag IsNot Nothing AndAlso btnConTest.Tag.GetType Is GetType(eXperDB.ODBC.DXODBC) Then
            modCommon.AgentInfoWrite(DirectCast(btnConTest.Tag, eXperDB.ODBC.DXODBC).ODBCConninfo)
            MsgBox(p_clsMsgData.fn_GetData("M021"))
        Else
            MsgBox(p_clsMsgData.fn_GetData("M022"))
        End If

    End Sub
#End Region


#Region "Form Initialize"

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        InitForm()

    End Sub


    Private Sub InitForm()



        Me.grpAgentSVR.Text = p_clsMsgData.fn_GetData("F001")
        btnConTest.Text = p_clsMsgData.fn_GetData("F309")
        btnConSave.Text = p_clsMsgData.fn_GetData("F003")
        lblSvrIP.Text = p_clsMsgData.fn_GetData("F006")
        lblSvrPort.Text = p_clsMsgData.fn_GetData("F007")
        lblSvrUsr.Text = p_clsMsgData.fn_GetData("F008")
        lblSvrPwd.Text = p_clsMsgData.fn_GetData("F009")
        lblSvrDBNm.Text = p_clsMsgData.fn_GetData("F010")
        grpSvrLst.Text = p_clsMsgData.fn_GetData("F013")


        grpMonGrp.Text = p_clsMsgData.fn_GetData("F025")
        Dim tmpGrpNm As String = p_clsMsgData.fn_GetData("F026")
        lblGrp1.Text = tmpGrpNm & " 1"
        lblGrp2.Text = tmpGrpNm & " 2"
        lblGrp3.Text = tmpGrpNm & " 3"
        lblGrp4.Text = tmpGrpNm & " 4"


        btnGrpSave.Text = p_clsMsgData.fn_GetData("F003")
        Dim clsIni As New Common.IniFile(p_AppConfigIni)


        txtGrp1.Text = clsIni.ReadValue("GROUP", "GROUP1", tmpGrpNm & " 1")
        txtGrp2.Text = clsIni.ReadValue("GROUP", "GROUP2", tmpGrpNm & " 2")
        txtGrp3.Text = clsIni.ReadValue("GROUP", "GROUP3", tmpGrpNm & " 3")
        txtGrp4.Text = clsIni.ReadValue("GROUP", "GROUP4", tmpGrpNm & " 4")

        ReadGrpComboList()

        btnStart.Text = p_clsMsgData.fn_GetData("F027")


        sb_Ctlenabled(False)

        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        Dim dec As New eXperDB.Common.ClsCrypt

        txtSvrIP.Text = tmpStruct.HostIP
        txtSvrPwd.Text = tmpStruct.Password
        txtSvrUsr.Text = tmpStruct.UserID
        txtSvrPort.Text = tmpStruct.Port
        txtSvr_LostFocus(txtSvrIP, Nothing)
        cmbSvrDBNm.Text = tmpStruct.DBName

        colCollectYN.HeaderText = p_clsMsgData.fn_GetData("F018")
        colDBNm.HeaderText = p_clsMsgData.fn_GetData("F010")
        colAliasNm.HeaderText = p_clsMsgData.fn_GetData("F019")
        colUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        colIP.HeaderText = p_clsMsgData.fn_GetData("F006")
        colPort.HeaderText = p_clsMsgData.fn_GetData("F007")
        colPW.HeaderText = p_clsMsgData.fn_GetData("F009")
        colLstIP.HeaderText = p_clsMsgData.fn_GetData("F020")
        colGrp.HeaderText = p_clsMsgData.fn_GetData("F025")

        modCommon.FontChange(Me, p_Font)
    End Sub


    Private Sub sb_Ctlenabled(ByVal Bret As Boolean)
        grpSvrLst.Enabled = Bret
        pnlB.Enabled = Bret
        btnConSave.Enabled = Bret
        grpMonGrp.Enabled = Bret
        dgvSvrLst.Rows.Clear()

    End Sub

#End Region

#Region "Form Event"

    Private Sub FormControlBox1_ButtonConfigClick(sender As Object, e As Rectangle) Handles FormControlBox2.ButtonConfigClick

        If btnConTest.Tag Is Nothing OrElse TryCast(btnConTest.Tag, eXperDB.ODBC.DXODBC) Is Nothing Then
            Dim strMsg As String = p_clsMsgData.fn_GetData("M010")
            MsgBox(strMsg)
        Else
            Dim frmPw As New frmPassword(DirectCast(btnConTest.Tag, eXperDB.ODBC.DXODBC))
            If frmPw.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim frmAdmin As New frmAdmin
                frmAdmin.ShowDialog(Me)
            End If
            ReadSvrList(btnConTest.Tag)
            'btnConTest.PerformClick()
        End If


    End Sub

#End Region


    Private Sub ReadGrpComboList()
        Dim tmpValDesc As New BaseControls.ValueDescription()
        tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(1, txtGrp1.Text))
        tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(2, txtGrp2.Text))
        tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(3, txtGrp3.Text))
        tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(4, txtGrp4.Text))

        Dim tmpDtTable As New DataTable
        tmpDtTable.Columns.Add("VALUE")
        tmpDtTable.Columns.Add("DESC")
        Dim dtTable As DataTable = tmpValDesc.GetDataTable


        If dtTable IsNot Nothing AndAlso TryCast(dgvSvrLst.Columns(colGrp.Index), DataGridViewComboBoxColumn) IsNot Nothing Then
            DirectCast(dgvSvrLst.Columns(colGrp.Index), DataGridViewComboBoxColumn).DataSource = dtTable
            DirectCast(dgvSvrLst.Columns(colGrp.Index), DataGridViewComboBoxColumn).DisplayMember = "DESC"
            DirectCast(dgvSvrLst.Columns(colGrp.Index), DataGridViewComboBoxColumn).ValueMember = "VALUE"
        End If





    End Sub

    Private Sub btnGrpSave_Click(sender As Object, e As EventArgs) Handles btnGrpSave.Click

        Dim clsIni As New Common.IniFile(p_AppConfigIni)
        clsIni.WriteValue("GROUP", "GROUP1", txtGrp1.Text)
        clsIni.WriteValue("GROUP", "GROUP2", txtGrp2.Text)
        clsIni.WriteValue("GROUP", "GROUP3", txtGrp3.Text)
        clsIni.WriteValue("GROUP", "GROUP4", txtGrp4.Text)
        ReadGrpComboList()





    End Sub

    ''' <summary>
    '''  모니터링 시작전 정합성 체크 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fn_StartBefChk() As Boolean
        '1.  모니터링 을 선택하였으나 서버그룹이 설정되지 않았는지 확인한다.
        '2. 그룹 1개당 서버는 8개로 제한이므로 설정되어있는지 확인한다. 


        Dim tmpSrt As New SortedList

        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Cells(colCollectYN.Index).Value = "Y" Then
                If tmpRow.Cells(colGrp.Index).Value = 0 Then
                    ' 선택 되었으나 그룹이 없는 경우 
                    tmpRow.Selected = True
                    dgvSvrLst.FirstDisplayedScrollingRowIndex = tmpRow.Index
                    MsgBox(p_clsMsgData.fn_GetData("M007", tmpRow.Cells(colAliasNm.Index).Value))
                    Return False
                Else
                    ' 선택되었으나 그룹에 수량이 8개가 넘는지 확인하기 위한 배열 등록 
                    Dim intInstanceID As Integer = tmpRow.Tag
                    Dim intGrpID As Integer = tmpRow.Cells(colGrp.Index).Value
                    If tmpSrt.Item(intGrpID) Is Nothing Then
                        Dim tmpArr As New ArrayList
                        tmpArr.Add(intInstanceID)
                        tmpSrt.Add(intGrpID, tmpArr)
                    Else
                        Dim tmpArr As ArrayList = tmpSrt.Item(intGrpID)
                        tmpArr.Add(intInstanceID)
                        tmpSrt.Item(intGrpID) = tmpArr
                    End If
                End If
            End If
        Next


        For Each tmpKey As Integer In tmpSrt.GetKeyList
            If DirectCast(tmpSrt.Item(tmpKey), ArrayList).Count > 16 Then
                MsgBox(p_clsMsgData.fn_GetData("M008"))


                Return False
            End If
        Next




        Return True
    End Function


    ''' <summary>
    ''' 서버 목록의 그룹명 로컬 저장 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub sb_SaveGrpSvrLst()
        ' 설정 저장 파일 
        Dim clsIni As New Common.IniFile(p_AppConfigIni)

        ' 돌면서 저장 한다. 
        For Each tmpRow As DataGridViewRow In dgvSvrLst.Rows
            If tmpRow.Cells(colGrp.Index).Value IsNot Nothing Then
                Dim intInstanceID As Integer = tmpRow.Tag
                Dim intGrpID As Integer = tmpRow.Cells(colGrp.Index).Value
                clsIni.WriteValue("SERVER GROUP", intInstanceID, intGrpID)
            End If
        Next




    End Sub
    ''' <summary>
    ''' 시작 버튼 클릭 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' 버튼 클릭전 서버가 그룹에 속하였는지 확인 
        If fn_StartBefChk() = False Then Return

        '서버 매핑 목록 저장 
        sb_SaveGrpSvrLst()

        ' 최초 Connection 시에 해당 Connection 정보를 테스트 버튼에 넣어 두었음. 
        Dim AgentCn As eXperDB.ODBC.DXODBC = btnConTest.Tag
        ' 붙어 있는 서버 정보가 없을 경우 종료 
        If AgentCn Is Nothing Then Return

        ' 반환 Group Server 목록 반들기 
        ' 체크 목록에서 데이터를 모두 거증 하였으므로 그냥 넣기만 한다. 

        Dim rtnSrt As New List(Of GroupInfo)



        Dim arrInstanceIDs As New ArrayList

        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            ' 그룹이 선택되어 있을 경우 
            If tmpRow.Cells(colCollectYN.Index).Value = "Y" Then
                Dim intInstanceID As Integer = tmpRow.Tag
                arrInstanceIDs.Add(intInstanceID)
                Dim strIP As String = tmpRow.Cells(colIP.Index).Value
                Dim strPort As Integer = tmpRow.Cells(colPort.Index).Value
                Dim strID As String = tmpRow.Cells(colUser.Index).Value
                Dim strDBNm As String = tmpRow.Cells(colDBNm.Index).Value
                Dim strAliasNm As String = tmpRow.Cells(colAliasNm.Index).Value
                Dim strHostNm As String = tmpRow.Cells(colhostnm.index).value
                Dim tmpValue As Integer = tmpRow.Cells(colGrp.Index).Value
                Dim tmpName As String = tmpRow.Cells(colGrp.Index).FormattedValue
                Dim stTime As DateTime = tmpRow.Cells(colStartTime.Index).Value


                Dim grpIdx As Integer = rtnSrt.FindIndex(Function(tmpGrpinfo As GroupInfo)
                                                             If tmpGrpinfo.ID = tmpValue Then
                                                                 Return True
                                                             End If
                                                             Return False
                                                         End Function)
                If grpIdx = -1 Then
                    rtnSrt.Add(New GroupInfo(tmpValue, tmpName))
                    grpIdx = rtnSrt.Count - 1
                End If

                rtnSrt.Item(grpIdx).Items.Add(New GroupInfo.ServerInfo(intInstanceID, strIP, strID, strPort, strDBNm, strAliasNm, strHostNm, stTime))

            End If

        Next


        If rtnSrt.Count = 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M009"))
            Return
        Else
            For Each tmpGrp As GroupInfo In rtnSrt
                If tmpGrp.Items.Count > 16 Then
                    MsgBox(p_clsMsgData.fn_GetData("M017"))
                    Return

                End If
            Next
        End If

        Dim clsConfig As New Common.IniFile(p_AppConfigIni)
        Dim tmpElapseInterval As Integer = clsConfig.ReadValue("General", "ELAPSE", 3000)
        Dim tmpGroupRatateInterval As Integer = clsConfig.ReadValue("General", "GRPROTATE", 120000)
        ' Server Configuration  Start 
        Dim clsQuery As New clsQuerys(AgentCn)
        Dim dtTable As DataTable = clsQuery.SelectConfig

        Dim AgentInfo As structAgent = Nothing
        If dtTable IsNot Nothing Then
            Dim strIp As String = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_IP")), "", dtTable.Rows(0).Item("AGENT_IP"))
            Dim intPort As Integer = IIf(IsDBNull(dtTable.Rows(0).Item("AGENT_PORT")), 0, dtTable.Rows(0).Item("AGENT_PORT"))
            If strIp = "" Or intPort = 0 Then
                MsgBox(p_clsMsgData.fn_GetData("M016"))
                Return
            Else
                AgentInfo = New structAgent(dtTable.Rows(0).Item("AGENT_IP"), intPort)
            End If

        Else
            MsgBox(p_clsMsgData.fn_GetData("M016"))
            Return
        End If
        ' Server Configuration  End 


        p_clsAgentCollect = New clsCollect(arrInstanceIDs.ToArray(GetType(Integer)))
        p_clsAgentCollect.Start(AgentCn, tmpElapseInterval, p_ShowName)



        Me.DialogResult = Windows.Forms.DialogResult.OK
        Dim frmMain As New frmMonMain(AgentCn, rtnSrt, tmpElapseInterval, tmpGroupRatateInterval, AgentInfo)
        frmMain.Show()

        Me.Hide()

    End Sub
    ''' <summary>
    ''' 서버 정보 입력시 활성화 비활성화 이벤트 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSvr_LostFocus(sender As Object, e As EventArgs) Handles txtSvrIP.LostFocus, txtSvrPort.LostFocus, txtSvrPwd.LostFocus, txtSvrUsr.LostFocus
        'If btnConTest.Tag IsNot Nothing Then
        '    btnConTest.Tag = Nothing
        '    sb_Ctlenabled(False)

        'End If

        'Dim BefStr As String = cmbSvrDBNm.Text
        'cmbSvrDBNm.Items.Clear()
        'If txtSvrIP.Text.Trim <> "" _
        '    AndAlso txtSvrPort.Text.Trim <> "" _
        '    AndAlso txtSvrUsr.Text.Trim <> "" _
        '    AndAlso txtSvrPwd.Text.Trim <> "" Then

        '    ' POSTGRES DATABASE는 권한이 없어도 접속이 가능함.  대소문자 구분을 하므로 주의할 것 
        '    Dim dbType As DXODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, ODBC.DXODBC.enumODBCType.PostgreUnicodeX64, ODBC.DXODBC.enumODBCType.PostgreUnicode)
        '    Dim tmpCn As New ODBC.DXODBC(dbtype, txtSvrIP.Text, CInt(txtSvrPort.Text), txtSvrUsr.Text, txtSvrPwd.Text, "postgres")
        '    If tmpCn.ConnectionCheck = True Then

        '        Dim tmpCls As New clsQuerys(tmpCn)
        '        Dim dtTable As DataTable = tmpCls.GetDatabaseLIst
        '        If dtTable IsNot Nothing Then
        '            For Each tmpStr As DataRow In dtTable.Rows
        '                cmbSvrDBNm.Items.Add(tmpStr.Item(0))
        '            Next
        '        End If

        '        cmbSvrDBNm.Text = BefStr

        '    Else

        '    End If
        'End If

    End Sub




    Private Sub dgvSvrLst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSvrLst.CellContentClick

    End Sub

    Private Sub dgvSvrLst_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSvrLst.DataError
        e.Cancel = True
    End Sub

    Private Sub txtSvrUsr_TextChanged(sender As Object, e As EventArgs) Handles txtSvrUsr.TextChanged

    End Sub

End Class
