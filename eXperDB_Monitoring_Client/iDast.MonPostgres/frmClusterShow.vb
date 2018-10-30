Public Class frmClusterShow

    Private _SvrpList As List(Of GroupInfo.ServerInfo)
    Private _instanceColors() As Color
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

    Public Sub New(ByVal GrpLst As List(Of GroupInfo.ServerInfo), ByVal instanceColors() As Color)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _SvrpList = GrpLst
        _instanceColors = instanceColors
    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmClusterShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()

        Dim isAllChecked As Boolean = True

        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            Dim idxRow As Integer = dgvClusterList.Rows.Add()
            dgvClusterList.Rows(idxRow).Tag = tmpSvr.InstanceID
            dgvClusterList.fn_DataCellADD(idxRow, coldgvClusterListHostName.Index, tmpSvr.HostNm)
            dgvClusterList.Rows(idxRow).DefaultCellStyle.ForeColor = _instanceColors(idxRow)
            dgvClusterList.Rows(idxRow).DefaultCellStyle.SelectionForeColor = _instanceColors(idxRow)
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(idxRow).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
            checkBox.ReadOnly = True
            checkBox.Value = tmpSvr.Reserved
            checkBox.ReadOnly = False
            If checkBox.Value = False Then
                isAllChecked = False
            End If
        Next
        _cbCheckAll.Checked = isAllChecked

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
        If e.ColumnIndex = 0 AndAlso e.RowIndex = -1 Then
            e.PaintBackground(e.ClipBounds, False)
            Dim pt As New Point()
            pt = e.CellBounds.Location ' where you want the bitmap in the cell

            Dim nChkBoxWidth As Integer = 20
            Dim nChkBoxHeight As Integer = 20
            Dim offsetx As Integer = (e.CellBounds.Width - nChkBoxWidth) / 2
            Dim offsety As Integer = (e.CellBounds.Height - nChkBoxHeight) / 2

            pt.X += offsetx
            pt.Y += offsety

            _cbCheckAll.Location = pt
            _cbCheckAll.Size = New Size(nChkBoxWidth, nChkBoxHeight)
            _cbCheckAll.BackColor = Color.DimGray

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
        For Each tmpSvr As GroupInfo.ServerInfo In _SvrpList
            Dim checkBox As DataGridViewCheckBoxCell = (TryCast(dgvClusterList.Rows(idxRow).Cells(coldgvClusterListSel.Index), DataGridViewCheckBoxCell))
            tmpSvr.Reserved = checkBox.Value
            idxRow += 1
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dgvClusterList_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClusterList.CellValueChanged
        If e.RowIndex >= 0 Then
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
End Class
