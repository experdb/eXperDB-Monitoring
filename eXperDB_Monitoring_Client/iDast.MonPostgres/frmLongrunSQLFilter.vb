Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class frmLongrunSQLFilter

    Private _cbCheckAll As New eXperDB.BaseControls.CheckBox()
    Private _longRunSQLCondition As String
    Private _isChangedCond As Boolean
    Public Sub New(ByVal longRunSQLCondition As String)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _longRunSQLCondition = longRunSQLCondition
        _isChangedCond = False
    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmStatementsFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        Try
            dgvLongSQLFilterList.Rows.Clear()
            Dim jsonS As String = _longRunSQLCondition
            'Dim jsonObject As JObject = JObject.Parse(jsonS) 'Object 만 파싱 한다.
            Dim eColList As List(Of ECondition) = JsonConvert.DeserializeObject(Of List(Of ECondition))(jsonS)
            For Each eCol As ECondition In eColList
                Dim idxRow As Integer = dgvLongSQLFilterList.Rows.Add()
                dgvLongSQLFilterList.fn_DataCellADD(idxRow, coldgvLongSQLFilterListCondition.Index, IIf(eCol.coltype.Equals("1"), "user name", IIf(eCol.coltype.Equals("2"), "db name", "client IP addr")))
                dgvLongSQLFilterList.fn_DataCellADD(idxRow, coldgvLongSQLFilterListText.Index, eCol.typestr)
            Next
        Catch ex As Exception
        End Try


        Dim isAllChecked As Boolean = True
        cmbExcludeSession.SelectedIndex = 0
        'For Each tmpSvr As String In _StatementList
        '    Dim idxRow As Integer = dgvStatementFilterList.Rows.Add()
        '    dgvStatementFilterList.fn_DataCellADD(idxRow, coldgvStatementFilterListStatement.Index, tmpSvr)
        'Next

    End Sub

    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))

        btnApply.Text = p_clsMsgData.fn_GetData("F003")
        btnClose.Text = p_clsMsgData.fn_GetData("F021")

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        dgvLongSQLFilterList.AutoGenerateColumns = False

        ' Add Server list into combo
        Dim comboSource As New Dictionary(Of String, String)()

        modCommon.FontChange(Me, p_Font)

        MsgLabel.Text = p_clsMsgData.fn_GetData("M114")
        coldgvLongSQLFilterListCondition.HeaderText = p_clsMsgData.fn_GetData("F369")
        coldgvLongSQLFilterListText.HeaderText = p_clsMsgData.fn_GetData("F370")
        lblExcludeSession.Text = p_clsMsgData.fn_GetData("F369")
        btnAddExcludeSession.Text = p_clsMsgData.fn_GetData("F016")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim eCons As New List(Of ECondition)
        For Each tmpRow As DataGridViewRow In dgvLongSQLFilterList.Rows
            Dim eCon As New ECondition
            eCon.coltype = IIf(tmpRow.Cells(coldgvLongSQLFilterListCondition.Index).Value.Equals("user name"), "1", IIf(tmpRow.Cells(coldgvLongSQLFilterListCondition.Index).Value.Equals("db name"), "2", "3"))
            eCon.typestr = tmpRow.Cells(coldgvLongSQLFilterListText.Index).Value
            eCons.Add(eCon)
        Next
        _longRunSQLCondition = JsonConvert.SerializeObject(eCons)
        _isChangedCond = True
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnAddExcludeSession_Click(sender As Object, e As EventArgs) Handles btnAddExcludeSession.Click
        For i As Integer = 0 To dgvLongSQLFilterList.RowCount - 1
            Dim condition As String = dgvLongSQLFilterList.Rows(i).Cells(coldgvLongSQLFilterListCondition.Index).Value
            If condition.Equals(cmbExcludeSession.Text) Then
                MsgBox(p_clsMsgData.fn_GetData("M115"))
                Return
            End If
        Next

        Dim tempRow = New DataGridViewRow()
        dgvLongSQLFilterList.Rows.Insert(0, tempRow)
        dgvLongSQLFilterList.Rows(0).Cells(coldgvLongSQLFilterListCondition.Index).Value = cmbExcludeSession.Text
        dgvLongSQLFilterList.Rows(0).Cells(coldgvLongSQLFilterListText.Index).Value = txtExcludeSession.Text
    End Sub

    Private Sub dgvStatementFilterList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLongSQLFilterList.CellContentClick
        If dgvLongSQLFilterList.CurrentCell.GetType = GetType(DataGridViewImageCell) Then
            dgvLongSQLFilterList.RefreshEdit()
            dgvLongSQLFilterList.Rows.Remove(dgvLongSQLFilterList.CurrentRow)
            dgvLongSQLFilterList.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Public Sub rtnValue(ByRef longRunSQLCondition As String, ByRef isChangedLongRunCond As Boolean)
        longRunSQLCondition = _longRunSQLCondition
        isChangedLongRunCond = _isChangedCond
    End Sub

End Class

Public Class ECondition
    Public Property coltype
    Public Property typestr
End Class