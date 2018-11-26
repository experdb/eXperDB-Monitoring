Public Class frmStatementsFilter

    Private _StatementList As List(Of String)
    ''' <summary>
    ''' Group List Items 안에 서버 리스트가 있음. 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ReadOnly Property StatementList As List(Of String)
        Get
            Return _StatementList
        End Get
    End Property

    Private _cbCheckAll As New eXperDB.BaseControls.CheckBox()

    Public Sub New(ByVal StatementLst As List(Of String))

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _StatementList = StatementLst
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmStatementsFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()

        Dim isAllChecked As Boolean = True

        For Each tmpSvr As String In _StatementList
            Dim idxRow As Integer = dgvStatementFilterList.Rows.Add()
            dgvStatementFilterList.fn_DataCellADD(idxRow, coldgvStatementFilterListStatement.Index, tmpSvr)
        Next

    End Sub

    Private Sub InitForm()


        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))

        btnApply.Text = p_clsMsgData.fn_GetData("F014")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dgvStatementFilterList.AutoGenerateColumns = False

        ' Add Server list into combo
        Dim comboSource As New Dictionary(Of String, String)()

        modCommon.FontChange(Me, p_Font)

        MsgLabel.Text = p_clsMsgData.fn_GetData("M061")
        coldgvStatementFilterListStatement.HeaderText = p_clsMsgData.fn_GetData("F332")
        lblServer.Text = p_clsMsgData.fn_GetData("F332")
        btnAddStatement.Text = p_clsMsgData.fn_GetData("F016")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        _StatementList.Clear()
        For i As Integer = 0 To dgvStatementFilterList.RowCount - 1
            Dim StatementFilter As String = dgvStatementFilterList.Rows(i).Cells(coldgvStatementFilterListStatement.Index).Value
            _StatementList.Add(StatementFilter)
        Next
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnAddStatement_Click(sender As Object, e As EventArgs) Handles btnAddStatement.Click
        Dim tempRow = New DataGridViewRow()
        dgvStatementFilterList.Rows.Insert(0, tempRow)
        dgvStatementFilterList.Rows(0).Cells(coldgvStatementFilterListStatement.Index).Value = txtSQL.Text
    End Sub

    Private Sub dgvStatementFilterList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStatementFilterList.CellContentClick
        If dgvStatementFilterList.CurrentCell.GetType = GetType(DataGridViewImageCell) Then
            dgvStatementFilterList.RefreshEdit()
            dgvStatementFilterList.Rows.Remove(dgvStatementFilterList.CurrentRow)
            dgvStatementFilterList.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class
