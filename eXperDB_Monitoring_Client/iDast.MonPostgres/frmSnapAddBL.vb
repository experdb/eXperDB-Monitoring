Public Class frmSnapAddBL

    Private _instanceID As Integer
    Private _clsQuery As clsQuerys
    Private _isCreation As Boolean

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal instanceID As Integer)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _isCreation = True
        initForm()
        _clsQuery = clsQuery
        _instanceID = instanceID
    End Sub

    Public Sub New(ByRef clsQuery As clsQuerys, ByVal instanceID As Integer, ByRef baselineName As String, _
                   ByRef snapshotStart As Integer, ByRef snapshotStartTime As String, _
                   ByRef snapshotEnd As Integer, ByRef snapshotEndTime As String, _
                   ByRef keepUntilTime As DateTime)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _isCreation = False
        initForm()
        _clsQuery = clsQuery
        _instanceID = instanceID
        txtBaselineName.Text = baselineName
        txtSnapFrom.Text = snapshotStartTime
        txtSnapFrom.Tag = snapshotStart
        txtSnapTo.Text = snapshotEndTime
        txtSnapTo.Tag = snapshotEnd
        txtBaselineName.Enabled = False
        dtpKeepTime.Value = keepUntilTime
        btnFrom.Enabled = False
        btnTo.Enabled = False
    End Sub

    Private Sub initForm()
        If _isCreation Then
            btnGenerate.Text = p_clsMsgData.fn_GetData("F956", "Baseline")
        Else
            btnGenerate.Text = p_clsMsgData.fn_GetData("F961")
        End If
        btnClose.Text = p_clsMsgData.fn_GetData("F923")
        StatusLabel.Text = p_clsMsgData.fn_GetData("M098")
        lblKeepTime.Text = p_clsMsgData.fn_GetData("F958")
        lblBaselineName.Text = p_clsMsgData.fn_GetData("F962")
        Me.ttChart.SetToolTip(Me.btnFrom, p_clsMsgData.fn_GetData("F963"))
        Me.ttChart.SetToolTip(Me.btnTo, p_clsMsgData.fn_GetData("F963"))
    End Sub


    Private Sub frmSnapAddBL_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If _isCreation = False Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Return
        End If

        If txtBaselineName.Text.Equals("") Then
            MsgBox(p_clsMsgData.fn_GetData("M100"))
            txtBaselineName.Focus()
            Return
        End If

        If txtSnapFrom.Text.Equals("") Then
            MsgBox(p_clsMsgData.fn_GetData("M101"))
            txtSnapFrom.Focus()
            Return
        End If

        If txtSnapTo.Text.Equals("") Then
            MsgBox(p_clsMsgData.fn_GetData("M101"))
            txtSnapTo.Focus()
            Return
        End If

        If isExistsBaseline() = True Then
            MsgBox(p_clsMsgData.fn_GetData("M099"))
            txtBaselineName.Focus()
            Return
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function isExistsBaseline() As Boolean
        Try
            Dim dtTable As DataTable
            dtTable = _clsQuery.SelectCheckBaseline(_instanceID, txtBaselineName.Text)
            If dtTable IsNot Nothing And dtTable.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
        End Try
        Return False
    End Function

    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click, btnTo.Click
        Dim btnTemp = DirectCast(sender, System.Windows.Forms.Button)
        Dim frmSnapList As New frmSnapshotList(_clsQuery, _instanceID, True)
        frmSnapList.Location = MousePosition()
        If frmSnapList.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim snapshot As Integer = 0
            Dim snapshottime As String = ""
            Dim baselinename As String = ""
            Dim minsnapshot As Integer = 0
            Dim mintime As String = ""
            Dim maxsnapshot As Integer = 0
            Dim maxtime As String = ""
            frmSnapList.rtnValue(snapshot, snapshottime, baselinename, minsnapshot, mintime, maxsnapshot, maxtime)
            If btnTemp.Name.Equals("btnFrom") Then
                txtSnapFrom.Text = snapshottime
                txtSnapFrom.Tag = snapshot
            Else
                txtSnapTo.Text = snapshottime
                txtSnapTo.Tag = snapshot
            End If
        End If
    End Sub


    Public Sub rtnValue(ByRef rtnBaselineName As String, ByRef rtnBaselineFrom As Integer, ByRef rtnBaselineTo As Integer, ByRef rtnKeepUntilTime As Integer)
        rtnBaselineName = txtBaselineName.Text
        rtnBaselineFrom = txtSnapFrom.Tag
        rtnBaselineTo = txtSnapTo.Tag
        rtnKeepUntilTime = IIf(DateDiff(DateInterval.Day, Date.Today, dtpKeepTime.Value) < 0, 0, DateDiff(DateInterval.Day, Date.Today, dtpKeepTime.Value))
    End Sub
End Class