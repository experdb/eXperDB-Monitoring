
Public Class frmLogView


    Private _Elapseinterval As Integer = 3000  ' 2시간을 기본으로 설정 
    Private _InstanceID As Integer = -1
    ReadOnly Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
    End Property
    Private _ServerInfo As GroupInfo.ServerInfo = Nothing

    Private _AgentInfo As structAgent
    ReadOnly Property AgentInfo As structAgent
        Get
            Return _AgentInfo
        End Get
    End Property

    Private _returnValue As clsAgentEMsg.DX006_REP
    Private _currentOffset As Long = 0
    Private DEFAULTREADLENGTH As Long = 5000
    Private WithEvents _AgentObject As clsAgentEMsg

    Public Sub New(ByVal ServerInfo As GroupInfo.ServerInfo, ByVal ElapseInterval As Integer, ByVal clsAgentInfo As structAgent)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = ServerInfo.InstanceID
        _Elapseinterval = ElapseInterval
        _ServerInfo = ServerInfo
        _AgentInfo = clsAgentInfo
        _AgentObject = New clsAgentEMsg(AgentInfo.AgentIP, AgentInfo.AgentPort)




    End Sub
    ''' <summary>
    ''' 화면 초기화 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        'Me.Invoke(New MethodInvoker(Sub()
        '                                btnRefresh.PerformClick()
        '                            End Sub))
    End Sub


    Private Sub InitForm()

        Dim strHeader As String = Common.ClsConfigure.fn_rtnComponentDescription(p_ShowName.GetType.GetMember(p_ShowName.ToString)(0))
        'lblTitle.Text = String.Format("{0} : {1} / IP : {2} / START : {3}", strHeader, _ServerInfo.HostNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"))
        'Me.Text += " [ " + String.Format("{0}({1}) Started on {2}, Ver:{3} ", _ServerInfo.ShowNm, _ServerInfo.IP, _ServerInfo.StartTime.ToString("yyyy-MM-dd HH:mm:ss"), _ServerInfo.PGV) + "]"
        Me.Text += " [ " + String.Format("{0}({1}) ", _ServerInfo.ShowNm, _ServerInfo.IP) + "]"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Talble Information

        grpLogFileList.Text = p_clsMsgData.fn_GetData("F235", 0)
        dgvLogFileList.AutoGenerateColumns = False
        coldgvLogFileListTime.HeaderText = p_clsMsgData.fn_GetData("F237")
        coldgvLogFileListSize.HeaderText = p_clsMsgData.fn_GetData("F238")


        ' Index Information
        grpLogview.Text = p_clsMsgData.fn_GetData("F236", 0)
        dgvLogData.AutoGenerateColumns = False
        dgvLogData.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 40, 80)
        coldgvLogData.HeaderText = p_clsMsgData.fn_GetData("F239")



        'grpLogInfo.Text = p_clsMsgData.fn_GetData("F234")

        'btnRefresh.Text = p_clsMsgData.fn_GetData("F244")
        'btnMore.Text = p_clsMsgData.fn_GetData("F240")
        lblLogReadUnit.Text = p_clsMsgData.fn_GetData("F241")
        cboLogReadUnit.AddValue(5000, "5KB")
        cboLogReadUnit.AddValue(10000, "10KB")
        cboLogReadUnit.AddValue(50000, "50KB")
        cboLogReadUnit.AddValue(100000, "100KB")
        cboLogReadUnit.AddValue(500000, "500KB")
        cboLogReadUnit.AddValue(1000000, "1MB")
        cboLogReadUnit.Enabled = False
        btnMore.Enabled = False

        'btnRefresh.Text = p_clsMsgData.fn_GetData("F137")

        'Me.FormControlBox1.UseConfigBox = False
        'Me.FormControlBox1.UseLockBox = False
        'Me.FormControlBox1.UseCriticalBox = False
        'Me.FormControlBox1.UseRotationBox = False
        'Me.FormControlBox1.UsePowerBox = False

        'modCommon.FontChange(Me, p_Font)
        FileTotalCnt.Text = p_clsMsgData.fn_GetData("F900", 0)
        FileTotalSize.Text = p_clsMsgData.fn_GetData("F901", 0)
        RefreshTime.Text = p_clsMsgData.fn_GetData("F902", 0)
        MsgLabel.Text = p_clsMsgData.fn_GetData("M044")


    End Sub

    Private Sub sb_AddTreeGridDatas(ByVal tvNode As AdvancedDataGridView.TreeGridNode, ByVal ColHashSet As Hashtable, ByVal DtRow As DataRow)
        For Each tmpColIdx As Integer In ColHashSet.Keys
            tvNode.Cells(tmpColIdx).Value = DtRow.Item(ColHashSet.Item(tmpColIdx))
        Next

    End Sub
    ''' <summary>
    '''  log list
    ''' </summary>
    ''' <param name="logFileList"></param>
    ''' <remarks></remarks>
    Public Sub SetLogFileList(ByVal logFileList As List(Of clsAgentEMsg.DATALIST))
        Dim dtTable As DataTable = ConvertToDataTable(logFileList)

        If dtTable Is Nothing Then Return

        Dim dtView As DataView = dtTable.AsEnumerable.AsDataView
        dgvLogFileList.DataSource = dtView
        grpLogFileList.Text = p_clsMsgData.fn_GetData("F235", dtView.Count)
        modCommon.sb_GridSortChg(dgvLogFileList)
        'dgvLogFileList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        'dgvLogFileList.AutoResizeColumns()
        'coldgvLogFileListSize.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    ''' <summary>
    '''  log
    ''' </summary>
    ''' <param name="logLine"></param>
    ''' <param name="offSet"></param>
    ''' <remarks></remarks>
    Public Sub SetLog(ByVal logLine As List(Of clsAgentEMsg.DATALIST), ByVal offSet As Long)
        If logLine.Count <= 0 Then Return

        'Exit For
        For index = 0 To logLine.Count - 1
            dgvLogData.Rows.Add(logLine.Item(index).LOGNAME)
        Next
        modCommon.sb_GridSortChg(dgvLogData)
        dgvLogData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        cboLogReadUnit.Enabled = True
        btnMore.Enabled = True
        _currentOffset += offSet

        Me.dgvLogData.FirstDisplayedScrollingRowIndex = Me.dgvLogData.RowCount - 1
        'dgvLogData.Rows(Me.dgvLogData.RowCount - 1).Selected = True

    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        '_frmWait = New frmWait
        '_frmWait.TopMost = True
        '_frmWait.StartPosition = FormStartPosition.CenterParent
        '_frmWait.Show(Me)

        dgvLogData.Rows.Clear()
        dgvLogFileList.DataSource = Nothing

        cboLogReadUnit.Enabled = False
        btnMore.Enabled = False

        grpLogview.Text = ""


        _AgentObject.SendDX006(Me.InstanceID, "5", "", "", 0, 0)

        'If bckmanual.IsBusy = True Then
        '    bckmanual.CancelAsync()
        '    Return
        'End If
        'bckmanual.RunWorkerAsync()



    End Sub


    Private Sub bckmanual_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bckmanual.DoWork
        'If _frmWait IsNot Nothing Then
        '    _frmWait.AddText("Data select start")
        'End If

        bckmanual.ReportProgress(100)

    End Sub

    Private Sub bckmanual_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bckmanual.ProgressChanged

    End Sub

    Private Sub bckmanual_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bckmanual.RunWorkerCompleted
        If e.Cancelled = False Then
            'If _frmWait IsNot Nothing Then
            '    _frmWait.AddText("Loading log data")
            'End If
            If _returnValue IsNot Nothing Then
                Select Case _returnValue._tran_sub_cd
                    Case "5"
                        Me.SetLogFileList(_returnValue.DATAS)
                    Case "6"
                        Me.SetLog(_returnValue.DATAS, _returnValue.offSet)
                    Case Else
                End Select
            End If
            RefreshTime_lv.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
            FileTotalCnt_lv.Text = dgvLogFileList.Rows.Count

            Dim fileSum As ULong = 0
            For Each tmpRow As DataGridViewRow In dgvLogFileList.Rows
                fileSum += Convert.ToInt64(tmpRow.Cells(2).Value)
            Next
            If fileSum < 1024 Then
                FileTotalSize_lv.Text = Convert.ToSingle(fileSum) & "B"
            ElseIf fileSum < 1024 * 1024 Then
                FileTotalSize_lv.Text = Convert.ToSingle(fileSum / 1024) & " kB"
            Else
                FileTotalSize_lv.Text = Convert.ToSingle(fileSum / (1024 * 1024)) & " MB"
            End If
        End If

        'If _frmWait IsNot Nothing Then
        '    _frmWait.Close()
        'End If

    End Sub

    Private Sub frmLogView_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        'bckmanual.RunWorkerAsync()

        btnRefresh.PerformClick()


    End Sub

    Private Sub AgentObject_Complete(sender As Object, e As Object) Handles _AgentObject.Complete


        If e.GetType.Equals(GetType(clsAgentEMsg.DX001_REP)) Then
            Dim rtnValue As clsAgentEMsg.DX001_REP = DirectCast(e, clsAgentEMsg.DX001_REP)

            If rtnValue._tran_res_data IsNot Nothing AndAlso rtnValue._tran_res_data(0)._error_cd Is Nothing Then
                Me.Invoke(New MethodInvoker(Sub()
                                                If bckmanual.IsBusy = True Then
                                                    bckmanual.CancelAsync()
                                                    Return
                                                End If
                                                bckmanual.RunWorkerAsync()
                                            End Sub))

            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                If _frmWait IsNot Nothing Then
                                                    _frmWait.AddText(String.Format("[{0}]{1}", rtnValue._tran_res_data(0)._error_cd, rtnValue._tran_res_data(1)._error_msg))
                                                End If
                                            End Sub))
            End If
        ElseIf e.GetType.Equals(GetType(clsAgentEMsg.DX006_REP)) Then
            'Dim rtnValue As clsAgentEMsg.DX006_REP = DirectCast(e, clsAgentEMsg.DX006_REP)
            _returnValue = DirectCast(e, clsAgentEMsg.DX006_REP)
            If _returnValue.DATAS IsNot Nothing And _returnValue.DATAS.Count > 0 Then
                Me.Invoke(New MethodInvoker(Sub()
                                                If bckmanual.IsBusy = True Then
                                                    bckmanual.CancelAsync()
                                                    Return
                                                End If
                                                bckmanual.RunWorkerAsync()
                                            End Sub))

            Else
                Me.Invoke(New MethodInvoker(Sub()
                                                If _frmWait IsNot Nothing Then
                                                    _frmWait.AddText(String.Format("[{0}]{1}", _returnValue.ERRORS._error_cd, _returnValue.ERRORS._error_msg))
                                                    If (_returnValue.ERRORS._error_cd = "DX006_E06") Then
                                                        _frmWait.Close()
                                                    End If
                                                End If
                                            End Sub))
            End If
        ElseIf e.GetType.Equals(GetType(clsSocket.Results)) Then
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText(DirectCast(e, clsSocket.Results).ErrorMsg)
                                            End If
                                        End Sub))
        Else
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText("Unknown Error")
                                            End If
                                        End Sub))
        End If



    End Sub
    Private WithEvents _frmWait As frmWait
    Private Sub AgentObject_Progress(sender As Object, e As clsSocket.ProgArgs) Handles _AgentObject.Progress
        If e.Status = clsSocket.enumStatus.Start Then
            Me.Invoke(New MethodInvoker(Sub()
                                            If _frmWait IsNot Nothing Then
                                                _frmWait.AddText("Agent Running")
                                            End If
                                        End Sub))
        End If
    End Sub




    Private Sub _frmWait_FormClosed(sender As Object, e As FormClosedEventArgs) Handles _frmWait.FormClosed
        'If _AgentObject IsNot Nothing Then
        '    _AgentObject.Cancel()
        '    _AgentObject = Nothing
        'End If

        If Me.bckmanual.IsBusy = True Then
            Me.bckmanual.CancelAsync()
        End If
        _frmWait = Nothing
    End Sub


    Private Sub btnPause_Click(sender As Object, e As EventArgs)
        ' Play webding = "4"   Pause Webding = ";"

    End Sub

    Public Shared Function ConvertToDataTable(Of t)(
                                                  ByVal list As IList(Of t)
                                               ) As DataTable
        Dim table As New DataTable()
        If Not list.Any Then
            'don't know schema ....
            Return table
        End If
        Dim fields() = list.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next
        For Each item In list
            Dim row As DataRow = table.NewRow()
            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    Private Sub dgvLogFileList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogFileList.CellClick
        '_frmWait = New frmWait
        '_frmWait.TopMost = True
        '_frmWait.StartPosition = FormStartPosition.CenterParent
        '_frmWait.Show(Me)

        If e.RowIndex >= 0 Then
            dgvLogData.Rows.Clear()
            _currentOffset = 0
            grpLogview.Text = dgvLogFileList.Rows(e.RowIndex).Cells(1).Value

            'For i As Integer = 0 To dgvLogFileList.ColumnCount - 1
            '    dgvLogFileList.Rows(e.RowIndex).Cells(i).Style.SelectionBackColor = Color.FromArgb(0, 40, 80)
            'Next

            '_AgentObject.SendDX006(Me.InstanceID, "6", "", "pg_log/postgresql-2017-05-11_174130.log", 10, 0, 1000)
            _AgentObject.SendDX006(Me.InstanceID, "6", "", dgvLogFileList.Rows(e.RowIndex).Cells(0).Value, 0, DEFAULTREADLENGTH)
        End If

    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        If dgvLogFileList.CurrentRow IsNot Nothing Then
            '_frmWait = New frmWait
            '_frmWait.TopMost = True
            '_frmWait.Show(Me)

            _AgentObject.SendDX006(Me.InstanceID, "6", "", dgvLogFileList.CurrentRow.Cells(0).Value, _currentOffset, CInt(cboLogReadUnit.SelectedValue))
        End If
    End Sub

    Private Sub frmLogView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If _AgentObject IsNot Nothing Then
            _AgentObject.Cancel()
            _AgentObject = Nothing
        End If
    End Sub


    Private Sub dgvLogFileList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogFileList.CellContentClick

    End Sub
End Class
