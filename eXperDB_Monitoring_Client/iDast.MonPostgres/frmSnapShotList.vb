Imports System.Text.RegularExpressions
Imports Microsoft.Win32
Public Class frmSnapshotList
    Private _clsQuery As clsQuerys
    Private _instanceID As Integer
    Private _isSnapshot As Boolean

    Private _rtnSnapshot As Integer
    Private _rtnSnapshotTime As String
    Private _rtnBaselineName As String
    Private _rtnMinSnapshot As Integer
    Private _rtnMinTime As String
    Private _rtnMaxSnapshot As Integer
    Private _rtnMaxTime As String
    Public Sub New(ByRef clsQuery As clsQuerys, ByVal instanceID As Integer, ByVal isSnapshot As Boolean)
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        _clsQuery = clsQuery
        _instanceID = instanceID
        _isSnapshot = isSnapshot
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        btnClose.Text = p_clsMsgData.fn_GetData("F021")
    End Sub

    Private Sub frmUserConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadSnapshot()
    End Sub

    Private Sub ReadSnapshot()
        Try
            Dim dtTable As DataTable
            If _isSnapshot Then
                dgvBaselineList.Visible = False
                dgvSnapshotList.Visible = True
                Me.Width = 230
                dtTable = _clsQuery.SelectSnapshotList(_instanceID)
                If dtTable IsNot Nothing Then
                    dgvSnapshotList.DataSource = dtTable
                End If
            Else
                dgvBaselineList.Visible = True
                dgvSnapshotList.Visible = False
                Me.Width = 640
                dtTable = _clsQuery.SelectBaselineList(_instanceID)
                If dtTable IsNot Nothing Then
                    dgvBaselineList.DataSource = dtTable
                End If
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Public Sub rtnValue(ByRef rtnSnapshot As Integer, ByRef rtnSnapshotTime As String, _
                        ByRef rtnBaselineName As String, ByRef rtnMinSnapshot As Integer, ByRef rtnMinTime As String, _
                        ByRef rtnMaxSnapshot As Integer, ByRef rtnMaxTime As String)
        rtnSnapshot = _rtnSnapshot
        rtnSnapshotTime = _rtnSnapshotTime
        rtnBaselineName = _rtnBaselineName
        rtnMinSnapshot = _rtnMinSnapshot
        rtnMinTime = _rtnMinTime
        rtnMaxSnapshot = _rtnMaxSnapshot
        rtnMaxTime = _rtnMaxTime
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub dgvBaselineList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaselineList.CellDoubleClick
        If dgvBaselineList.RowCount <= 0 Then Return
        If e.RowIndex >= 0 Then
            _rtnBaselineName = dgvBaselineList.Rows(e.RowIndex).Cells(0).Value
            _rtnMinSnapshot = dgvBaselineList.Rows(e.RowIndex).Cells(1).Value
            _rtnMinTime = CType(dgvBaselineList.Rows(e.RowIndex).Cells(2).Value, Date).ToString("yyyy-MM-dd HH:mm:ss")
            _rtnMaxSnapshot = dgvBaselineList.Rows(e.RowIndex).Cells(3).Value
            _rtnMaxTime = CType(dgvBaselineList.Rows(e.RowIndex).Cells(4).Value, Date).ToString("yyyy-MM-dd HH:mm:ss")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub dgvSnapshotList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSnapshotList.CellDoubleClick
        If dgvSnapshotList.RowCount <= 0 Then Return
        If e.RowIndex >= 0 Then
            _rtnSnapshot = dgvSnapshotList.Rows(e.RowIndex).Cells(0).Value
            _rtnSnapshotTime = CType(dgvSnapshotList.Rows(e.RowIndex).Cells(1).Value, Date).ToString("yyyy-MM-dd HH:mm:ss")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class