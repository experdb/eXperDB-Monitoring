Public Class frmAddSvrList

    Private _dgvMon As AdvancedDataGridView.TreeGridView
    Private _conODBC As eXperDB.ODBC.eXperDBODBC = Nothing
    Private _intHostIndex As Integer = 0
    Private _intPortIndex As Integer = 0

    Public Sub New()

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        InitForm()

    End Sub

    'Public Sub New(ByVal conODBC As eXperDB.ODBC.DXODBC, ByRef dgvMon As eXperDB.BaseControls.DataGridView)
    Public Sub New(ByVal conODBC As eXperDB.ODBC.eXperDBODBC)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        InitForm()
        'dtView.ToTable.AsEnumerable.Take(200).CopyToDataTable

        Me._conODBC = conODBC

    End Sub

    Private Sub frmAddSvrList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me._dgvMon = TryCast(Me.Owner, frmSvrList).dgvMonLst
        lblSubject.Text = p_clsMsgData.fn_GetData("F281")
        lblSvrList.Text = p_clsMsgData.fn_GetData("F013")
        dgvSvrLst.ClearSelection()
        searchKeyColumnIndex()
        ReadSvrList()
    End Sub

    Private Sub searchKeyColumnIndex()
        For Each sColumn As DataGridViewColumn In _dgvMon.Columns
            If sColumn.Name.Equals("colMonHostNm") Then
                _intHostIndex = sColumn.Index
            End If
            If sColumn.Name.Equals("colMonPort") Then
                _intPortIndex = sColumn.Index
            End If
        Next
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'R-Start ReadSvrListbyGroup
    Private Sub ReadSvrList()
        If _conODBC Is Nothing Then Return
        Dim Dgv As AdvancedDataGridView.TreeGridView = dgvSvrLst
        Dgv.Nodes.Clear()

        Dim HashTbl As New Hashtable
        For Each tmpCol As DataGridViewColumn In Dgv.Columns
            If Not tmpCol.GetType.Equals(GetType(AdvancedDataGridView.TreeGridColumn)) Then
                HashTbl.Add(tmpCol.Index, tmpCol.DataPropertyName)
            End If
        Next

        Dim ClsQuery As New clsQuerys(_conODBC)
        Try
            Dim dtTable As DataTable = ClsQuery.SelectServerListByGroup()
            If dtTable IsNot Nothing Then
                Dim dtView As DataView = dtTable.AsEnumerable.AsDataView
                For Each tmpRow As DataRow In dtView.ToTable.Select("HA_ROLE = 'P' OR HA_ROLE = 'A'")
                    Dim bFoundSvr As Boolean = False
                    For Each tmpMonRow As DataGridViewRow In _dgvMon.Rows
                        If tmpMonRow.Cells(_intHostIndex).Value = tmpRow.Item("HOST_NAME") AndAlso _
                           tmpMonRow.Cells(_intPortIndex).Value = tmpRow.Item("SERVICE_PORT") Then
                            bFoundSvr = True
                            Exit For
                        End If
                    Next

                    If bFoundSvr = True Then Continue For

                    Dim topNode As AdvancedDataGridView.TreeGridNode = Dgv.Nodes.Add(tmpRow.Item("HOST_NAME"))
                    topNode.Tag = tmpRow.Item("INSTANCE_ID")
                    topNode.Image = dbmsImgLst.Images(0)

                    sb_AddTreeGridDatas(topNode, HashTbl, tmpRow)

                    Dim newNode As AdvancedDataGridView.TreeGridNode = topNode
                    Dim prevNode As AdvancedDataGridView.TreeGridNode = Nothing
                    newNode.Expand()
                    For i As Integer = 1 To p_NodeLevel - 1
                        If newNode IsNot Nothing Then
                            prevNode = newNode
                            newNode = sb_AddChildNode(newNode, HashTbl, dtView.Table.Select("HA_ROLE = 'S'"))
                            If prevNode.HasChildren = True Then
                                prevNode.Expand()
                            End If
                        End If
                    Next

                    'If topNode.Cells(colHostNm.Index).Value.ToString() <> "" Then
                    '    Dim c1NOde As AdvancedDataGridView.TreeGridNode = Nothing
                    '    Dim c2NOde As AdvancedDataGridView.TreeGridNode = Nothing
                    '    Dim c3NOde As AdvancedDataGridView.TreeGridNode = Nothing
                    '    For Each tmpChild As DataRow In dtView.Table.Select("HA_ROLE = 'S'")
                    '        If (tmpChild.Item("HA_HOST") Like (topNode.Cells(colHostNm.Index).Value + "*")) = True Or _
                    '            tmpChild.Item("HA_HOST") = topNode.Cells(colIP.Index).Value Then
                    '            c1NOde = topNode.Nodes.Add(tmpChild.Item("HOST_NAME"))
                    '            c1NOde.Tag = tmpChild.Item("INSTANCE_ID")
                    '            c1NOde.Image = dbmsImgLst.Images(1)
                    '            sb_AddTreeGridDatas(c1NOde, HashTbl, tmpChild)
                    '            'Dim cNOde1 As AdvancedDataGridView.TreeGridNode = cNOde.Nodes.Add(tmpChild.Item("HOST_NAME"))
                    '            'cNOde1.Tag = tmpChild.Item("INSTANCE_ID")
                    '            'cNOde1.Image = dbmsImgLst.Images(1)
                    '            'sb_AddTreeGridDatas(cNOde1, HashTbl, tmpChild)
                    '        End If
                    '    Next
                    '    topNode.Expand()
                    '    'topNode.Cells(0).Value = tmpRow.Item("HOST_NAME") & " (" & topNode.Nodes.Count & ")"
                    '    'topNode.Cells(0).Value = tmpRow.Item("HOST_NAME")
                    '    If c1NOde IsNot Nothing AndAlso c1NOde.Cells(colHostNm.Index).Value.ToString() <> "" Then
                    '        For Each tmpChild As DataRow In dtView.Table.Select("HA_ROLE = 'S'")
                    '            If (tmpChild.Item("HA_HOST") Like (c1NOde.Cells(colHostNm.Index).Value + "*")) = True Or _
                    '                tmpChild.Item("HA_HOST") = c1NOde.Cells(colIP.Index).Value Then
                    '                c2NOde = c1NOde.Nodes.Add(tmpChild.Item("HOST_NAME"))
                    '                c2NOde.Tag = tmpChild.Item("INSTANCE_ID")
                    '                c2NOde.Image = dbmsImgLst.Images(1)
                    '                sb_AddTreeGridDatas(c2NOde, HashTbl, tmpChild)
                    '            End If
                    '        Next
                    '        c1NOde.Expand()
                    '    End If

                    '    If c2NOde IsNot Nothing AndAlso c2NOde.Cells(colHostNm.Index).Value.ToString() <> "" Then
                    '        For Each tmpChild As DataRow In dtView.Table.Select("HA_ROLE = 'S'")
                    '            If (tmpChild.Item("HA_HOST") Like (c2NOde.Cells(colHostNm.Index).Value + "*")) = True Or _
                    '                tmpChild.Item("HA_HOST") = c2NOde.Cells(colIP.Index).Value Then
                    '                c3NOde = c2NOde.Nodes.Add(tmpChild.Item("HOST_NAME"))
                    '                c3NOde.Tag = tmpChild.Item("INSTANCE_ID")
                    '                c3NOde.Image = dbmsImgLst.Images(1)
                    '                sb_AddTreeGridDatas(c3NOde, HashTbl, tmpChild)
                    '            End If
                    '        Next
                    '        c2NOde.Expand()
                    '    End If

                    'End If
                Next
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub
    'R-End

    Private Sub InitForm()

        Dim tmpStruct As eXperDB.ODBC.structConnection = modCommon.AgentInfoRead()

        Dim dec As New eXperDB.Common.ClsCrypt

        colHostNm.HeaderText = p_clsMsgData.fn_GetData("F229")
        'colCollectYN.HeaderText = p_clsMsgData.fn_GetData("F018")
        colDBNm.HeaderText = p_clsMsgData.fn_GetData("F010")
        colAliasNm.HeaderText = p_clsMsgData.fn_GetData("F019")
        colUser.HeaderText = p_clsMsgData.fn_GetData("F008")
        colIP.HeaderText = p_clsMsgData.fn_GetData("F006")
        colPort.HeaderText = p_clsMsgData.fn_GetData("F007")
        colPW.HeaderText = p_clsMsgData.fn_GetData("F009")
        colLstIP.HeaderText = p_clsMsgData.fn_GetData("F020")
        colGrp.HeaderText = p_clsMsgData.fn_GetData("F025")

        btnAdd.Text = p_clsMsgData.fn_GetData("F016")
        btnCancel.Text = p_clsMsgData.fn_GetData("F021")
    End Sub

    Private Sub dgvSvrLst_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        e.Cancel = True
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next
    End Sub

    Private Function sb_AddChildNode(ByVal pNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtView As System.Data.DataRow()) As AdvancedDataGridView.TreeGridNode
        Dim newNode As AdvancedDataGridView.TreeGridNode = Nothing
        If pNode.Cells(colHostNm.Index).Value.ToString() <> "" Then
            For Each tmpChild As DataRow In DtView
                If (tmpChild.Item("HA_HOST") Like (pNode.Cells(colHostNm.Index).Value + "*")) = True Or _
                    tmpChild.Item("HA_HOST") = pNode.Cells(colIP.Index).Value Then
                    newNode = pNode.Nodes.Add(tmpChild.Item("HOST_NAME"))
                    newNode.Tag = tmpChild.Item("INSTANCE_ID")
                    newNode.Image = dbmsImgLst.Images(1)
                    sb_AddTreeGridDatas(newNode, ColHashSet, tmpChild)
                End If
            Next
        End If
        Return newNode
    End Function



    Private Sub dgvSvrLst_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSvrLst.SelectionChanged
        'If dgvSvrLst.Nodes.Count > 0 Then
        '    For Each tmpRow As DataGridViewRow In dgvSvrLst.SelectedRows
        '        If dgvSvrLst.Nodes(tmpRow.Index).HasChildren Then
        '            For Each tempRow As DataGridViewRow In dgvSvrLst.Rows
        '                If (tempRow.Cells(colHAHost.Index).Value Like (tmpRow.Cells(colHostNm.Index).Value + "*")) = True Or _
        '                    tempRow.Cells(colIP.Index).Value = tmpRow.Cells(colHAHost.Index).Value Then
        '                    If tempRow.Cells(colPort.Index).Value = tmpRow.Cells(colPort.Index).Value Then
        '                        tempRow.Selected = True
        '                    End If
        '                End If
        '            Next
        '        End If
        '    Next
        'End If
    End Sub

    Private Sub dgvSvrLst_NodeCollapsing(sender As Object, e As AdvancedDataGridView.CollapsingEventArgs) Handles dgvSvrLst.NodeCollapsing
        e.Cancel = True
    End Sub
End Class
