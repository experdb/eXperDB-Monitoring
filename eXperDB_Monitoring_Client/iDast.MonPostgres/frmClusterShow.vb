Public Class frmClusterShow

    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    Private _instanceColors() As Color
    Private _checkToApply As Boolean
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property SvrpList As List(Of GroupInfo.ServerInfo)
        Get
            Return _SvrpList
        End Get
    End Property

    Private _cbCheckAll As New eXperDB.BaseControls.CheckBox()

    Public Sub New(ByVal GrpLst As List(Of GroupInfo.ServerInfo), ByVal instanceColors() As Color, Optional checkToApply As Boolean = False)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _SvrpList = GrpLst
        _instanceColors = instanceColors
        _checkToApply = checkToApply
    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmClusterShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        sb_SetInstanceStatus(_SvrpList)

        'For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
        '    Dim idxRow As Integer = dgvClusterList.Rows.Add()
        '    dgvClusterList.Rows(idxRow).Tag = tmpSvr.InstanceID
        '    dgvClusterList.fn_DataCellADD(idxRow, coldgvClusterListHostName.Index, tmpSvr.HostNm)
        '    dgvClusterList.Rows(idxRow).DefaultCellStyle.ForeColor = _instanceColors(idxRow)
        '    dgvClusterList.Rows(idxRow).DefaultCellStyle.SelectionForeColor = _instanceColors(idxRow)
        '    Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(idxRow).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
        '    checkBox.ReadOnly = True
        '    checkBox.Value = tmpSvr.Reserved
        '    checkBox.ReadOnly = False
        '    If checkBox.Value = False Then
        '        isAllChecked = False
        '    End If
        'Next

    End Sub


    ''' <summary>
    ''' 인스턴스 상태 표시 컨트롤을 변경 
    ''' </summary>
    ''' <param name="svrLst"></param>
    ''' <remarks></remarks>
    Private Sub sb_SetInstanceStatus(ByVal svrLst As List(Of GroupInfo.ServerInfo))
        ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
        Try
            Dim isAllChecked As Boolean = True
            For i As Integer = 0 To svrLst.Count - 1
                Dim topNode As AdvancedDataGridView.TreeGridNode
                If svrLst.Item(i).HARole = "P" Or svrLst.Item(i).HARole = "A" Then
                    topNode = dgvClusterList.Nodes.Add(svrLst.Item(i).ShowNm)
                    topNode.Tag = svrLst.Item(i)
                    topNode.Height = 30
                    topNode.Cells(coldgvClusterListShowName.Index).Value = svrLst.Item(i).ShowNm
                    topNode.Cells(coldgvClusterListHostName.Index).Value = svrLst.Item(i).HostNm
                    topNode.Cells(coldgvClusterListHostName.Index).Tag = svrLst.Item(i).IP
                    If _instanceColors IsNot Nothing Then
                        topNode.DefaultCellStyle.ForeColor = _instanceColors(i)
                        topNode.DefaultCellStyle.SelectionForeColor = _instanceColors(i)
                    End If
                    Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(i).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
                    checkBox.ReadOnly = True
                    checkBox.Value = svrLst.Item(i).Reserved
                    checkBox.ReadOnly = False
                    If checkBox.Value = False Then
                        isAllChecked = False
                    End If

                    topNode.Expand()
                Else
                    For Each tmpRow In Me.dgvClusterList.Rows
                        Dim tmpNode As AdvancedDataGridView.TreeGridNode = tmpRow
                        If svrLst.Item(i).HAHost = tmpNode.Cells(coldgvClusterListHostName.Index).Value Or _
                           svrLst.Item(i).HAHost = tmpNode.Cells(coldgvClusterListHostName.Index).Tag Then
                            Dim cNOde As AdvancedDataGridView.TreeGridNode = tmpNode.Nodes.Add(svrLst.Item(i).ShowNm)
                            cNOde.Tag = svrLst.Item(i)
                            cNOde.Height = 30
                            cNOde.Cells(coldgvClusterListShowName.Index).Value = svrLst.Item(i).ShowNm
                            cNOde.Cells(coldgvClusterListHostName.Index).Value = svrLst.Item(i).HostNm
                            cNOde.Cells(coldgvClusterListHostName.Index).Tag = svrLst.Item(i).IP
                            If _instanceColors IsNot Nothing Then
                                cNOde.DefaultCellStyle.ForeColor = _instanceColors(i)
                                cNOde.DefaultCellStyle.SelectionForeColor = _instanceColors(i)
                            End If
                            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(i).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
                            checkBox.ReadOnly = True
                            checkBox.Value = svrLst.Item(i).Reserved
                            'checkBox.Value = tmpNode.Cells(coldgvClusterListSel.Index).Value
                            checkBox.ReadOnly = False
                            If checkBox.Value = False Then
                                isAllChecked = False
                            End If
                            cNOde.Expand()
                            Exit For
                        End If
                    Next
                End If
            Next
            _cbCheckAll.Checked = isAllChecked
            Me.dgvClusterList.Columns(0).SortMode = DataGridViewColumnSortMode.Automatic
        Catch ex As Exception
            GC.Collect()
        End Try
        ''''''''''''''''''''''''''''<instance to gridview>'''''''''''''''''''''''''''''''''''
    End Sub

    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))

        btnApply.Text = p_clsMsgData.fn_GetData("F014")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dgvClusterList.AutoGenerateColumns = False

        ' Add Server list into combo
        Dim comboSource As New Dictionary(Of String, String)()

        comboSource.Add(0, "All")
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            comboSource.Add(tmpSvr.InstanceID, tmpSvr.HostNm)
        Next

        modCommon.FontChange(Me, p_Font)

        MsgLabel.Text = p_clsMsgData.fn_GetData("M060")

    End Sub

    Private Sub dgvClusterList_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvClusterList.CellPainting
        If e.ColumnIndex = 1 AndAlso e.RowIndex = -1 Then
            e.PaintBackground(e.ClipBounds, False)
            Dim pt As New Point()
            pt = e.CellBounds.Location ' where you want the bitmap in the cell

            Dim nChkBoxWidth As Integer = 20
            Dim nChkBoxHeight As Integer = 20
            Dim offsetx As Integer = (e.CellBounds.Width - nChkBoxWidth) / 2 + 2
            Dim offsety As Integer = (e.CellBounds.Height - nChkBoxHeight) / 2

            pt.X += offsetx
            pt.Y += offsety

            _cbCheckAll.Location = pt
            _cbCheckAll.Size = New Size(nChkBoxWidth, nChkBoxHeight)
            _cbCheckAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))

            AddHandler _cbCheckAll.Click, AddressOf dgvClusterListCheckBox_CheckedChanged
            dgvClusterList.Controls.Add(_cbCheckAll)

            e.Handled = True
        End If
        dgvClusterList.EndEdit()
    End Sub
    Private Sub dgvClusterListCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        dgvClusterList.EndEdit()

        RemoveHandler dgvClusterList.CellValueChanged, AddressOf dgvClusterList_CellValueChanged
        For Each row As DataGridViewRow In dgvClusterList.Rows
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(row.Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
            checkBox.ReadOnly = True
            checkBox.Value = _cbCheckAll.Checked
            checkBox.ReadOnly = False
        Next
        AddHandler dgvClusterList.CellValueChanged, AddressOf dgvClusterList_CellValueChanged
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmClusterList_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RemoveHandler _cbCheckAll.CheckedChanged, AddressOf dgvClusterListCheckBox_CheckedChanged
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim idxRow As Integer = 0
        If _checkToApply Then
            If MsgBox(p_clsMsgData.fn_GetData("M093"), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) <> frmMsgbox.MsgBoxResult.Yes Then Return
        End If
        Try
            For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
                Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(idxRow).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
                tmpSvr.Reserved = checkBox.Value
                idxRow += 1
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub dgvClusterList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClusterList.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim topNode As AdvancedDataGridView.TreeGridNode = TryCast(dgvClusterList.Rows(e.RowIndex), AdvancedDataGridView.TreeGridNode)
            If topNode.HasChildren Then
                For Each tmpNode As AdvancedDataGridView.TreeGridNode In topNode.Nodes
                    tmpNode.Cells(coldgvClusterListSel.Index).Value = topNode.Cells(coldgvClusterListSel.Index).Value
                Next
            End If
            Dim isAllChecked As Boolean = True
            For Each tmpRow As DataGridViewRow In Me.dgvClusterList.Rows
                If tmpRow.Cells(coldgvClusterListSel.Index).Value = False Then
                    isAllChecked = False
                    Exit For
                End If
            Next
            _cbCheckAll.Checked = isAllChecked
        End If
    End Sub

    Private Sub dgvClusterList_NodeCollapsing(sender As Object, e As AdvancedDataGridView.CollapsingEventArgs) Handles dgvClusterList.NodeCollapsing
        e.Cancel = True
    End Sub
End Class
