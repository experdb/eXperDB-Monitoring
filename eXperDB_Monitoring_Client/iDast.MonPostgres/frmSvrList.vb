Public Class frmSvrList


#Region "Agent"

    Private Sub btnConTest_Click(sender As Object, e As EventArgs) Handles btnConTest.Click




        If fn_ChkTestBef() = False Then Return
        Dim strIp As String = txtSvrIP.Text
        Dim strPort As Integer = txtSvrPort.Text
        Dim strID As String = txtSvrUsr.Text
        Dim strPw As String = txtSvrPwd.Text
        Dim DBName As String = cmbSvrDBNm.Text
        Dim tmpCtl As BaseControls.RadioButton

        Dim dbType As DXODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.DXODBC.enumODBCType.PostgreUnicode)
        Dim tmpCn As New DXODBC(dbtype, strIp, strPort, strID, strPw, DBName)
        If tmpCn.ConnectionCheck = True Then
            MsgBox(p_clsMsgData.fn_GetData("M003"))
            ' R-Start 그룹명 조회
            Dim ClsQuery As New clsQuerys(tmpCn)
            cmbGrp.Items.Clear()
            '그룹명 
            Dim dtTable As DataTable = ClsQuery.SelectGroupName(0)
            If dtTable IsNot Nothing Then
                For Each tmpRow As DataRow In dtTable.Rows
                    cmbGrp.Items.Add(tmpRow.Item("GROUP_NAME"))
                Next
            End If

            '커넥트 테스트 후 조회그룹을 선택 from ini
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            Dim groupIndex As String = clsIni.ReadValue("GROUP", "MONGROUP", 0)
            tmpCtl = grpMonGrp.Controls.Find("rbGrp" & groupIndex + 1, True)(0)
            tmpCtl.Checked = True
            cmbGrp.SelectedIndex = groupIndex
            sb_Ctlenabled(True)
            'ReadSvrList(tmpCn)
            ReadSvrListbyGroup(tmpCn, groupIndex + 1)
            LoadMonList(groupIndex + 1)
            'R-End
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
    'R-Start ReadSvrListbyGroup
    Private Sub ReadSvrListbyGroup(ByVal conODBC As eXperDB.ODBC.DXODBC, ByVal groupIndex As Integer)
        dgvSvrLst.Rows.Clear()

        If conODBC Is Nothing Then Return

        Dim clsIni As New Common.IniFile(p_AppConfigIni)

        Dim ClsQuery As New clsQuerys(conODBC)
        '그룹명 
        Dim dtTable As DataTable = ClsQuery.SelectGroupName(groupIndex)
        If dtTable IsNot Nothing Then
            txtGrp1.Text = IIf(IsDBNull(dtTable.Rows(0).Item("GROUP_NAME")), "", dtTable.Rows(0).Item("GROUP_NAME"))
        End If

        dtTable = ClsQuery.SelectServerListByGroup()
        If dtTable IsNot Nothing Then
            For Each tmpRow As DataRow In dtTable.Rows
                Dim idxRow As Integer = dgvSvrLst.Rows.Add()
                ' Tag에는 Instance ID를 넣은다. 
                ' Add시에는 Instance ID = -1 
                ' Delete 시에는 Visible를 꺼서 삭제 목록을 가져온다. 
                dgvSvrLst.Rows(idxRow).Tag = tmpRow.Item("INSTANCE_ID")
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 
                dgvSvrLst.Rows(idxRow).DefaultCellStyle.ForeColor = Color.White
                dgvSvrLst.Rows(idxRow).DefaultCellStyle.SelectionForeColor = Color.White
                If IsDBNull(tmpRow.Item("MON_GROUP")) Then
                    dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "N")
                ElseIf tmpRow.Item("MON_GROUP") = 0 Then
                    dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "N")
                ElseIf tmpRow.Item("MON_GROUP") = groupIndex Then
                    dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "Y")
                Else
                    dgvSvrLst.fn_DataCellADD(idxRow, colCollectYN.Index, "Y")
                    dgvSvrLst.Rows(idxRow).ReadOnly = True
                    dgvSvrLst.Rows(idxRow).DefaultCellStyle.ForeColor = Color.Gray
                    dgvSvrLst.Rows(idxRow).DefaultCellStyle.SelectionForeColor = Color.Gray
                End If

                dgvSvrLst.fn_DataCellADD(idxRow, colIP.Index, tmpRow.Item("SERVER_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPort.Index, tmpRow.Item("SERVICE_PORT"))
                dgvSvrLst.fn_DataCellADD(idxRow, colUser.Index, tmpRow.Item("CONN_USER_ID"))
                dgvSvrLst.fn_DataCellADD(idxRow, colPW.Index, tmpRow.Item("CONN_USER_PWD"))
                dgvSvrLst.fn_DataCellADD(idxRow, colDBNm.Index, tmpRow.Item("CONN_DB_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colAliasNm.Index, tmpRow.Item("CONN_NAME"))
                dgvSvrLst.fn_DataCellADD(idxRow, colLstIP.Index, tmpRow.Item("LAST_MOD_IP"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHostNm.Index, IIf(IsDBNull(tmpRow.Item("HOST_NAME")), "", tmpRow.Item("HOST_NAME")))
                dgvSvrLst.fn_DataCellADD(idxRow, colStartTime.Index, IIf(IsDBNull(tmpRow.Item("INSTANCE_UPTIME")), DateTime.MinValue, tmpRow.Item("INSTANCE_UPTIME")))
                dgvSvrLst.fn_DataCellADD(idxRow, colHARole.Index, tmpRow.Item("HA_ROLE"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAHost.Index, tmpRow.Item("HA_HOST"))
                dgvSvrLst.fn_DataCellADD(idxRow, colHAPort.Index, tmpRow.Item("HA_PORT"))
            Next
        End If
    End Sub
    Private Sub LoadMonList(ByVal groupIndex As Integer)
        dgvMonLst.Rows.Clear()

        'Master node를 먼저 add
        For Each tmpRow As DataGridViewRow In dgvSvrLst.Rows
            If tmpRow.ReadOnly = True Or tmpRow.Cells(colCollectYN.Index).Value = "N" Then
                Continue For
            End If
            If IsDBNull(tmpRow.Cells(colHARole.Index).Value) Then
                Continue For
            End If
            ' Tag에는 Instance ID를 넣은다. 
            ' Add시에는 Instance ID = -1 
            ' Delete 시에는 Visible를 꺼서 삭제 목록을 가져온다. 
            Dim strHARole = tmpRow.Cells(colHARole.Index).Value
            If strHARole = "M" Then
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 
                Dim idxRow As Integer = dgvMonLst.Rows.Add()
                dgvMonLst.Rows(idxRow).Tag = tmpRow.Tag
                dgvMonLst.Rows(idxRow).DefaultCellStyle.ForeColor = Color.White
                dgvMonLst.Rows(idxRow).DefaultCellStyle.SelectionForeColor = Color.White
                dgvMonLst.fn_DataCellADD(idxRow, colMonIP.Index, tmpRow.Cells(colIP.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonPort.Index, tmpRow.Cells(colPort.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonUser.Index, tmpRow.Cells(colUser.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonPW.Index, tmpRow.Cells(colPW.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonDBNm.Index, tmpRow.Cells(colDBNm.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonAliasNm.Index, tmpRow.Cells(colAliasNm.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonLstIP.Index, tmpRow.Cells(colLstIP.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonHostNm.Index, IIf(IsDBNull(tmpRow.Cells(colHostNm.Index).Value), "", tmpRow.Cells(colHostNm.Index).Value))
                dgvMonLst.fn_DataCellADD(idxRow, colMonStartTime.Index, IIf(IsDBNull(tmpRow.Cells(colStartTime.Index).Value), DateTime.MinValue, tmpRow.Cells(colStartTime.Index).Value))
                dgvMonLst.fn_DataCellADD(idxRow, colMonHARole.Index, tmpRow.Cells(colHARole.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonHAHost.Index, tmpRow.Cells(colHAHost.Index).Value)
                dgvMonLst.fn_DataCellADD(idxRow, colMonHAPort.Index, tmpRow.Cells(colHAPort.Index).Value)
            End If
        Next

        'Slave node를 insert
        For Each tmpRow As DataGridViewRow In dgvSvrLst.Rows
            If tmpRow.ReadOnly = True Or tmpRow.Cells(colCollectYN.Index).Value = "N" Then
                Continue For
            End If
            If IsDBNull(tmpRow.Cells(colHARole.Index).Value) Then
                Continue For
            End If
            ' Tag에는 Instance ID를 넣은다. 
            ' Add시에는 Instance ID = -1 
            ' Delete 시에는 Visible를 꺼서 삭제 목록을 가져온다. 
            Dim strHARole = tmpRow.Cells(colHARole.Index).Value
            If strHARole = "S" Then
                Dim idxRow As Integer = tmpRow.Index
                Dim idxMonRow As Integer = -1
                'tmpRow.Cells(colHAPort.Index).Value
                For Each tmpMonRow As DataGridViewRow In dgvMonLst.Rows
                    If tmpMonRow.Cells(colMonHostNm.Index).Value = tmpRow.Cells(colHAHost.Index).Value Or _
                       tmpMonRow.Cells(colMonIP.Index).Value = tmpRow.Cells(colHAHost.Index).Value Then
                        If tmpMonRow.Cells(colMonPort.Index).Value = tmpRow.Cells(colHAPort.Index).Value Then
                            idxMonRow = tmpMonRow.Index
                            Exit For
                        End If
                    End If
                Next
                ' 데이터 비교를 위해서 반드시 Controls.iDastDataGridView의 fn_DataCellADD를 사용한다. => Check 같은것을 수행하기 위함. 
                If idxMonRow < 0 Then
                    'MsgBox(p_clsMsgData.fn_GetData("M026"))
                    Exit For
                End If
                idxMonRow += 1
                dgvMonLst.Rows.Insert(idxMonRow)
                dgvMonLst.Rows(idxMonRow).Tag = tmpRow.Tag
                dgvMonLst.Rows(idxMonRow).DefaultCellStyle.ForeColor = Color.White
                dgvMonLst.Rows(idxMonRow).DefaultCellStyle.SelectionForeColor = Color.White
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonIP.Index, tmpRow.Cells(colIP.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonPort.Index, tmpRow.Cells(colPort.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonUser.Index, tmpRow.Cells(colUser.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonPW.Index, tmpRow.Cells(colPW.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonDBNm.Index, tmpRow.Cells(colDBNm.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonAliasNm.Index, tmpRow.Cells(colAliasNm.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonLstIP.Index, tmpRow.Cells(colLstIP.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonHostNm.Index, IIf(IsDBNull(tmpRow.Cells(colHostNm.Index).Value), "", tmpRow.Cells(colHostNm.Index).Value))
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonStartTime.Index, IIf(IsDBNull(tmpRow.Cells(colStartTime.Index).Value), DateTime.MinValue, tmpRow.Cells(colStartTime.Index).Value))
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonHARole.Index, tmpRow.Cells(colHARole.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonHAHost.Index, tmpRow.Cells(colHAHost.Index).Value)
                dgvMonLst.fn_DataCellADD(idxMonRow, colMonHAPort.Index, tmpRow.Cells(colHAPort.Index).Value)
            End If
        Next
    End Sub
    'R-End



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

        Dim DisplayHeight = Screen.AllScreens(0).WorkingArea.Height
        If DisplayHeight >= 1080 Then
            Me.Height += 30
        End If

        Me.grpAgentSVR.Text = p_clsMsgData.fn_GetData("F001")
        btnConTest.Text = p_clsMsgData.fn_GetData("F309")
        btnConSave.Text = p_clsMsgData.fn_GetData("F003")
        lblSvrIP.Text = p_clsMsgData.fn_GetData("F006")
        lblSvrPort.Text = p_clsMsgData.fn_GetData("F007")
        lblSvrUsr.Text = p_clsMsgData.fn_GetData("F008")
        lblSvrPwd.Text = p_clsMsgData.fn_GetData("F009")
        lblSvrDBNm.Text = p_clsMsgData.fn_GetData("F010")
        'grpSvrLst.Text = p_clsMsgData.fn_GetData("F013")


        grpMonGrp.Text = p_clsMsgData.fn_GetData("F025")
        Dim tmpGrpNm As String = p_clsMsgData.fn_GetData("F026")
        rbGrp1.Text = tmpGrpNm & " 1"
        rbGrp2.Text = tmpGrpNm & " 2"
        rbGrp3.Text = tmpGrpNm & " 3"
        rbGrp4.Text = tmpGrpNm & " 4"


        btnGrpSave.Text = p_clsMsgData.fn_GetData("F003")
        Dim clsIni As New Common.IniFile(p_AppConfigIni)


        txtGrp1.Text = clsIni.ReadValue("GROUP", "GROUP1", tmpGrpNm & " 1")
        lblGroupName.Text = p_clsMsgData.fn_GetData("F310")
        'txtGrp2.Text = clsIni.ReadValue("GROUP", "GROUP2", tmpGrpNm & " 2")
        'txtGrp3.Text = clsIni.ReadValue("GROUP", "GROUP3", tmpGrpNm & " 3")
        'txtGrp4.Text = clsIni.ReadValue("GROUP", "GROUP4", tmpGrpNm & " 4")

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

        lblSvrList.Text = p_clsMsgData.fn_GetData("F013")
        lblMonList.Text = p_clsMsgData.fn_GetData("F311")
        colMonAliasNm.HeaderText = p_clsMsgData.fn_GetData("F019")
        colMonIP.HeaderText = p_clsMsgData.fn_GetData("F006")
        colMonPort.HeaderText = p_clsMsgData.fn_GetData("F007")

        modCommon.FontChange(Me, p_Font)
    End Sub


    Private Sub sb_Ctlenabled(ByVal Bret As Boolean)
        'grpSvrLst.Enabled = Bret
        'pnlB.Enabled = Bret
        btnConSave.Enabled = Bret
        grpMonGrp.Enabled = Bret
        dgvSvrLst.Rows.Clear()
        btnStart.Enabled = Bret

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
            'ReadSvrList(btnConTest.Tag)
            '커넥트 테스트 후 조회그룹을 선택 from ini
            Dim tmpCtl As BaseControls.RadioButton
            Dim clsIni As New Common.IniFile(p_AppConfigIni)
            Dim groupIndex As String = clsIni.ReadValue("GROUP", "MONGROUP", 0)
            tmpCtl = grpMonGrp.Controls.Find("rbGrp" & groupIndex + 1, True)(0)
            tmpCtl.Checked = True
            cmbGrp.SelectedIndex = groupIndex
            sb_Ctlenabled(True)
            'ReadSvrList(tmpCn)
            ReadSvrListbyGroup(btnConTest.Tag, groupIndex + 1)
            LoadMonList(groupIndex + 1)
            'btnConTest.PerformClick()
        End If


    End Sub

#End Region


    Private Sub ReadGrpComboList()
        Dim tmpValDesc As New BaseControls.ValueDescription()
        tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(1, txtGrp1.Text))
        'tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(2, txtGrp2.Text))
        'tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(3, txtGrp3.Text))
        'tmpValDesc.Add(New BaseControls.ValueDescription.ValueDesc(4, txtGrp4.Text))

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

        'Dim clsIni As New Common.IniFile(p_AppConfigIni)
        'clsIni.WriteValue("GROUP", "GROUP1", txtGrp1.Text)
        ''clsIni.WriteValue("GROUP", "GROUP2", txtGrp2.Text)
        ''clsIni.WriteValue("GROUP", "GROUP3", txtGrp3.Text)
        ''clsIni.WriteValue("GROUP", "GROUP4", txtGrp4.Text)
        'ReadGrpComboList()
        
        ' 추가적으로 모두 업데이트에 대한 로직 필요 
        Try
            If sb_SaveGrpMonLst() = True Then
                MsgBox(p_clsMsgData.fn_GetData("M023"))
                sb_ReloadcmbGrp()
            Else
                MsgBox(p_clsMsgData.fn_GetData("M024"))
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try

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
    '''  모니터링 시작전 정합성 체크 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function fn_StartBefChk2() As Boolean
        '1.  모니터링 을 선택하였으나 서버그룹이 설정되지 않았는지 확인한다.
        '2. 그룹 1개당 서버는 8개로 제한이므로 설정되어있는지 확인한다. 


        Dim tmpSrt As New SortedList

        For Each tmpRow As DataGridViewRow In Me.dgvSvrLst.Rows
            If tmpRow.Cells(colCollectYN.Index).Value = "Y" And tmpRow.ReadOnly = False Then
                ' 그룹에 10개가 넘는지 확인하기 위한 배열 등록 
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
        clsIni.WriteValue("GROUP", "MONGROUP", cmbGrp.SelectedIndex)

    End Sub
    ''' <summary>
    ''' 서버 목록의 그룹명 로컬 저장 
    ''' </summary>
    ''' <remarks></remarks>
    Private Function sb_SaveGrpMonLst() As Boolean
        ' 상단의 Agent 서버 접속 정보테스트 완료 시 해당하는 접속 정보를 Grid Tag에 넣어 두었음. 
        Dim odbcCon As eXperDB.ODBC.DXODBC = TryCast(btnConTest.Tag, eXperDB.ODBC.DXODBC)

        ' 추가적으로 모두 업데이트에 대한 로직 필요 
        Try
            If odbcCon IsNot Nothing Then
                Dim ClsQuery As New clsQuerys(odbcCon)
                Dim COC As New Common.ClsObjectCtl
                Dim strLocIP As String = COC.GetLocalIP
                Dim groupName As String = txtGrp1.Text
                Dim groupId As Integer
                For i As Integer = 0 To 3
                    Dim tmpCtl As BaseControls.RadioButton = grpMonGrp.Controls.Find("rbGrp" & i + 1, True)(0)
                    If tmpCtl.Checked = True Then
                        groupId = i + 1
                        Exit For
                    End If
                Next

                ' Instance 별 조회 그룹을 업데이트 한다. 
                For Each tmpRow As DataGridViewRow In dgvSvrLst.Rows
                    Dim intInstID As Integer = IIf(tmpRow.Tag Is Nothing, -1, tmpRow.Tag)
                    If tmpRow.Cells(colCollectYN.Index).Value = "N" Then
                        ClsQuery.UpdateMonGroup(intInstID, 0, strLocIP)
                    Else
                        If tmpRow.ReadOnly = False Then
                            ClsQuery.UpdateMonGroup(intInstID, groupId, strLocIP)
                        End If
                    End If
                Next

                ' Instance 별 조회 그룹을 업데이트 한다. 
                ClsQuery.UpdateGroup(groupId, groupName, strLocIP)

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Function
    Private Function sb_ReloadcmbGrp() As Boolean
        Dim conODBC As eXperDB.ODBC.DXODBC = btnConTest.Tag
        Dim ClsQuery As New clsQuerys(conODBC)
        Dim groupIndex As Integer = cmbGrp.SelectedIndex
        cmbGrp.Items.Clear()
        '그룹명 
        Dim dtTable As DataTable = ClsQuery.SelectGroupName(0)
        If dtTable IsNot Nothing Then
            For Each tmpRow As DataRow In dtTable.Rows
                cmbGrp.Items.Add(tmpRow.Item("GROUP_NAME"))
            Next
        End If
        cmbGrp.SelectedIndex = groupIndex
    End Function
    ''' <summary>
    ''' 시작 버튼 클릭 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' 버튼 클릭전 서버가 그룹에 속하였는지 확인 
        'If fn_StartBefChk() = False Then Return
        If fn_StartBefChk2() = False Then Return

        '모니터링 매핑 목록 저장
        If sb_SaveGrpMonLst() = False Then
            MsgBox(p_clsMsgData.fn_GetData("M024"))
            Return
        End If
        If dgvMonLst.Rows.Count <= 0 Then
            MsgBox(p_clsMsgData.fn_GetData("M027"))
            Return
        End If
        'Reload combo
        sb_ReloadcmbGrp()

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

        Dim grpIdx As Integer = 0
        rtnSrt.Add(New GroupInfo(cmbGrp.SelectedIndex, cmbGrp.SelectedItem))
        grpIdx = rtnSrt.Count - 1

        For Each tmpRow As DataGridViewRow In Me.dgvMonLst.Rows
            ' 그룹이 선택되어 있을 경우 
            Dim intInstanceID As Integer = tmpRow.Tag
            arrInstanceIDs.Add(intInstanceID)
            Dim strIP As String = tmpRow.Cells(colMonIP.Index).Value
            Dim strPort As Integer = tmpRow.Cells(colMonPort.Index).Value
            Dim strID As String = tmpRow.Cells(colMonUser.Index).Value
            Dim strDBNm As String = tmpRow.Cells(colMonDBNm.Index).Value
            Dim strAliasNm As String = tmpRow.Cells(colMonAliasNm.Index).Value
            Dim strHostNm As String = tmpRow.Cells(colMonHostNm.Index).Value
            Dim stTime As DateTime = tmpRow.Cells(colMonStartTime.Index).Value
            Dim strHARole As String = tmpRow.Cells(colMonHARole.Index).Value
            Dim strHAHost As String = tmpRow.Cells(colMonHAHost.Index).Value
            Dim strHAPort As String = tmpRow.Cells(colMonHAPort.Index).Value

            rtnSrt.Item(grpIdx).Items.Add(New GroupInfo.ServerInfo(intInstanceID, strIP, strID, strPort, strDBNm, strAliasNm, strHostNm, stTime, strHARole, strHAHost, strHAPort))
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
    Private Sub dgvSvrLst_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvSvrLst.DataError
        e.Cancel = True
    End Sub

    Private Sub txtSvrUsr_TextChanged(sender As Object, e As EventArgs) Handles txtSvrUsr.TextChanged

    End Sub
    'R-Start
    Private Sub rbGrp_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrp2.CheckedChanged, rbGrp4.CheckedChanged, rbGrp3.CheckedChanged, rbGrp1.CheckedChanged
        Dim tmpCtl As BaseControls.RadioButton
        Dim groupIndex As Integer = 0
        For i As Integer = 0 To 3
            tmpCtl = grpMonGrp.Controls.Find("rbGrp" & i + 1, True)(0)
            If tmpCtl.Checked = True Then
                tmpCtl.ForeColor = System.Drawing.Color.White
                tmpCtl.BackColor = System.Drawing.Color.Black
                groupIndex = i
                cmbGrp.SelectedIndex = groupIndex
            Else
                tmpCtl.ForeColor = System.Drawing.Color.Black
                tmpCtl.BackColor = System.Drawing.Color.Black
            End If
        Next
        ReadSvrListbyGroup(btnConTest.Tag, groupIndex + 1)
        LoadMonList(groupIndex + 1)
    End Sub
    ' R-End

    Private Sub cmbGrp_Click(sender As Object, e As EventArgs) Handles cmbGrp.Click
        sb_ReloadcmbGrp()
    End Sub

    Private Sub cmbGrp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrp.SelectedIndexChanged
        Dim tmpCtl As BaseControls.RadioButton
        tmpCtl = grpMonGrp.Controls.Find("rbGrp" & cmbGrp.SelectedIndex + 1, True)(0)
        If tmpCtl.Checked = False Then
            tmpCtl.Checked = True
        End If
    End Sub

    Private Sub dgvSvrLst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSvrLst.CellContentClick
        If dgvSvrLst.CurrentCell.GetType = GetType(DataGridViewCheckBoxCell) Then
            If dgvSvrLst.CurrentCell.IsInEditMode = True Then
                If dgvSvrLst.IsCurrentCellDirty = True Then
                    dgvSvrLst.CommitEdit(DataGridViewDataErrorContexts.Commit)
                    If dgvSvrLst.Rows(e.RowIndex).Cells(colCollectYN.Index).Value = "Y" Then
                        If IsDBNull(dgvSvrLst.Rows(e.RowIndex).Cells(colHARole.Index).Value) = False AndAlso _
                           (dgvSvrLst.Rows(e.RowIndex).Cells(colHARole.Index).Value) = "S" Then
                            If dgvMonLst.Rows.Count <= 0 Then
                                MsgBox(p_clsMsgData.fn_GetData("M026"))
                                dgvSvrLst.CurrentCell.Value = "N"
                                dgvSvrLst.CurrentCell.Tag = "N"
                                dgvSvrLst.RefreshEdit()
                                Return
                            End If
                        End If
                    End If
                    LoadMonList(cmbGrp.SelectedIndex + 1)
                End If
            End If
        End If
    End Sub
End Class
