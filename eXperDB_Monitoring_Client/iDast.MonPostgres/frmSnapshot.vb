Public Class frmSnapshot

    Private _clsQuery As clsQuerys
    Private _collapseHeight As Integer
    Private _isSnapshot As Boolean = True
    Private _Result As Boolean
    Private _instanceID As Integer
    Private _baselineName As String
    Private _baselineStartSnapshot As Integer
    Private _baselineEndSnapshot As Integer
    Private _baselineKeepDays As Integer

    Private WithEvents _ProgresForm As frmProgres

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal GrpLst As List(Of GroupInfo), ByVal instanceID As Integer)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        initForm()
        _clsQuery = clsQuery

        For Each tmpGrp As GroupInfo In GrpLst
            For Each tmpSvr As GroupInfo.ServerInfo In tmpGrp.Items
                cmbClusters.AddValue(tmpSvr.InstanceID, tmpSvr.ShowNm)
            Next
        Next

        cmbClusters.SelectedValue = instanceID
        Me.ttChart.SetToolTip(Me.btnSnapshot, p_clsMsgData.fn_GetData("F956", "Snapshot"))
    End Sub

    Private Sub initForm()
        TitleLabel.Text = p_clsMsgData.fn_GetData("M102")
        Me.ttChart.SetToolTip(Me.btnSnapshot, p_clsMsgData.fn_GetData("F956", "Snapshot"))
        Me.ttChart.SetToolTip(Me.btnAddBaseline, p_clsMsgData.fn_GetData("F956", "Baseline"))
    End Sub

    Private Sub frmSnapshot_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
    End Sub

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles Me.Load
        _instanceID = cmbClusters.SelectedValue
        ReadSnapshot()
        ReadBaseline()
    End Sub

#Region "Internal functions"

    Private Sub ReportLog(ByVal intAccessType As Integer, ByVal intStatus As Integer, _
                      Optional strLog As String = "", Optional intInstanceID As Integer = -1)
        Try
            Dim COC As New Common.ClsObjectCtl
            Dim strLocIP As String = COC.GetLocalIP
            _clsQuery.InsertReportInfo(p_cSession.UserID, intAccessType, intStatus, strLog, strLocIP, intInstanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadSnapshot()
        Try
            Dim dtTable As DataTable
            dtTable = _clsQuery.SelectSnapshotList(cmbClusters.SelectedValue)
            If dtTable IsNot Nothing Then
                dgvSnapshotList.DataSource = dtTable
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Sub ReadBaseline()
        Try
            Dim dtTable As DataTable
            dtTable = _clsQuery.SelectBaselineList(cmbClusters.SelectedValue)
            If dtTable IsNot Nothing Then
                dgvBaselineList.DataSource = dtTable
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
    End Sub

    Private Function Snapshot() As Boolean
        Try
            Return _clsQuery.InsertSnapshot(_instanceID)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function

    Private Function Baseline() As Boolean
        Try
            Return _clsQuery.InsertBaseline(_instanceID, _baselineName, _baselineStartSnapshot, _baselineEndSnapshot, _baselineKeepDays)
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            Return False
        End Try
    End Function
#End Region

    Private Sub cmbClusters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClusters.SelectedIndexChanged
        _instanceID = cmbClusters.SelectedValue
        ReadSnapshot()
        ReadBaseline()
    End Sub

    Private Sub btnSnapshot_Click(sender As Object, e As EventArgs) Handles btnSnapshot.Click
        _isSnapshot = True
        makeProgress()
    End Sub

    Private Sub btnAddBaseline_Click(sender As Object, e As EventArgs) Handles btnAddBaseline.Click
        Dim frmAddBaseline As New frmSnapAddBL(_clsQuery, cmbClusters.SelectedValue)
        If frmAddBaseline.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmAddBaseline.rtnValue(_baselineName, _baselineStartSnapshot, _baselineEndSnapshot, _baselineKeepDays)
            _isSnapshot = False
            makeProgress()
        End If
    End Sub

    Private Sub makeProgress()
        If _ProgresForm Is Nothing Then
            _ProgresForm = New frmProgres()
            _ProgresForm.Owner = Me
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
        _ProgresForm.Show()
        Me.BringToFront()
        Me.Activate()

        If bgmanual.IsBusy = True Then
            bgmanual.CancelAsync()
            Return
        End If
        bgmanual.RunWorkerAsync()
    End Sub

    Private Sub bgmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgmanual.DoWork
        bgmanual.ReportProgress(0)
        If _isSnapshot Then
            _Result = Snapshot()
            ReportLog(0, 1, IIf(_Result, "Success", "Failure"), _instanceID)
        Else
            _Result = Baseline()
            ReportLog(0, 2, IIf(_Result, "Success", "Failure"), _instanceID)
        End If
        bgmanual.ReportProgress(100)
    End Sub

    Private Sub bgmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgmanual.ProgressChanged
        Select Case e.ProgressPercentage
            Case 100
                If _ProgresForm IsNot Nothing Then
                    _ProgresForm.Addtext("Complete")
                End If
        End Select
    End Sub

    Private Sub bgmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgmanual.RunWorkerCompleted
        If _Result = False Then
            MsgBox(p_clsMsgData.fn_GetData("M097"))
            _ProgresForm.Close()
            Return
        End If
        ReadSnapshot()
        ReadBaseline()
        _ProgresForm.Close()
    End Sub

    Private Sub _ProgresForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _ProgresForm.FormClosed
        _clsQuery.CancelCommand()
        If Me.bgmanual.IsBusy = True Then
            Me.bgmanual.CancelAsync()
        End If
        _ProgresForm = Nothing
    End Sub

    Private Sub frmSnapshot_Move(sender As Object, e As EventArgs) Handles Me.Move
        If _ProgresForm IsNot Nothing Then
            Dim titleHeight As Integer = Me.Height - Me.ClientRectangle.Height
            _ProgresForm.Location = New Point(Me.Location.X, Me.Location.Y + titleHeight)
            _ProgresForm.Size = Me.Size
            _ProgresForm.Height = _ProgresForm.Height - titleHeight
        End If
    End Sub

    Private Sub dgvBaselineList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBaselineList.CellClick
        If e.RowIndex < 0 Then Return
        If e.ColumnIndex = colDGVBLEdit.Index Then
            Try
                Dim frmAddBaseline As New frmSnapAddBL(_clsQuery, cmbClusters.SelectedValue, _
                                       dgvBaselineList.Rows(e.RowIndex).Cells(2).Value, _
                                       dgvBaselineList.Rows(e.RowIndex).Cells(3).Value, _
                                       dgvBaselineList.Rows(e.RowIndex).Cells(4).Value, _
                                       dgvBaselineList.Rows(e.RowIndex).Cells(5).Value, _
                                       dgvBaselineList.Rows(e.RowIndex).Cells(6).Value, _
                                       IIf(IsDBNull(dgvBaselineList.Rows(e.RowIndex).Cells(7).Value), Date.Today, dgvBaselineList.Rows(e.RowIndex).Cells(7).Value))
                If frmAddBaseline.ShowDialog = Windows.Forms.DialogResult.OK Then
                    frmAddBaseline.rtnValue(_baselineName, _baselineStartSnapshot, _baselineEndSnapshot, _baselineKeepDays)
                    Dim nReturn As Boolean = _clsQuery.UpdateBaseline(_instanceID, _baselineName, _baselineKeepDays)
                    If nReturn = False Then
                        ReportLog(0, 4, "Failure", _instanceID)
                        MsgBox(p_clsMsgData.fn_GetData("M029"))
                    Else
                        ReportLog(0, 4, "Success", _instanceID)
                        ReadBaseline()
                    End If
                End If
            Catch ex As Exception
                p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            End Try

        ElseIf e.ColumnIndex = colDGVBLDelete.Index Then
            If MsgBox(p_clsMsgData.fn_GetData("M103", dgvBaselineList.Rows(e.RowIndex).Cells(colDGVBLBaseline.Index + 2).Value), Buttons:=frmMsgbox.MsgBoxStyle.YesNo) = frmMsgbox.MsgBoxResult.Yes Then
                Try
                    Dim nReturn As Integer = _clsQuery.DeleteBaseline(_instanceID, dgvBaselineList.Rows(e.RowIndex).Cells(colDGVBLBaseline.Index + 2).Value)
                    If nReturn <= 0 Then
                        ReportLog(0, 3, "Failure", _instanceID)
                        MsgBox(p_clsMsgData.fn_GetData("M029"))
                    Else
                        ReportLog(0, 3, "Success", _instanceID)
                        ReadBaseline()
                    End If
                Catch ex As Exception
                    p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
                End Try

            End If
        End If
    End Sub
End Class