Imports System.IO
Imports gudusoft.gsqlparser
Imports gudusoft.gsqlparser.Units
Imports System.Windows.Forms
Imports System.Drawing


Public Class frmCatchSqlInfo
    Private CGC As New ClsGridCtl
    Private COC As New ClsObjectCtl
    Private CSF As New ClsSqlFormat

    Dim ManualButton As New ToolStripButton
    Public ReadOnly iDAST_LogFilePath As String = ClsConfigure.GetValues(ClsConfigure.enumConfig.LogFilePath)
    Private ReadOnly CapturePath As String = iDAST_LogFilePath & Path.DirectorySeparatorChar & "CAPTURE" & Path.DirectorySeparatorChar & "ORACLE"

    Private Sub frmCatchSqlInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim nf As Form = Me.MdiParent
        If nf IsNot Nothing Then
            For Each tmpCtl As Control In nf.Controls
                If tmpCtl.GetType.Equals(GetType(ToolStrip)) Then
                    If tmpCtl.Name.ToUpper.Equals("MAINTOOLSTRIP") Then
                        COC.ToolStripRemoveButton(tmpCtl, ManualButton)
                        RemoveHandler ManualButton.Click, AddressOf ManualButton_Action
                    End If
                End If
            Next

            ' 공통화 폼으로 삭제처리함. 
            'COC.ToolStripRemoveButton(nf.MainToolStrip, ManualButton)
            'RemoveHandler ManualButton.Click, AddressOf ManualButton_Action
        End If

    End Sub

    Private Sub frmCatchSqlInfo_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Toolstrip 등록
        If ManualButton IsNot Nothing Then
            Dim nf As Form = Me.MdiParent
            If nf IsNot Nothing Then
                For Each tmpCtl As Control In nf.Controls
                    If tmpCtl.GetType.Equals(GetType(ToolStrip)) Then
                        If tmpCtl.Name.ToUpper.Equals("MAINTOOLSTRIP") Then
                            COC.ToolStripAddButton(tmpCtl, ManualButton, Me.Name, Me.Text, DX.Resources.iResources.application)
                            AddHandler ManualButton.Click, AddressOf ManualButton_Action
                        End If
                    End If
                Next

                ' 공통화 폼으로 삭제 처리 
                'COC.ToolStripAddButton(nf.MainToolStrip, ManualButton, Me.Name, Me.Text, iDast.Resources.iResources.application)
                'AddHandler ManualButton.Click, AddressOf ManualButton_Action
            End If

        End If
    End Sub

    Private Sub ManualButton_Action(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Focus()
    End Sub

    Private Sub frmCatchSqlInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '그리드 초기화
        CGC.InitGridForPub(DataGV, "VIEW")
        With DataGV
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DataSource = GetSQLBasicInfo(DirSqlComboBox.ComboBox.SelectedValue)
        End With
        SqlBasicInfoTitle()


        CGC.InitGridForPub(TraceGV, "VIEW")
        With TraceGV
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .MultiSelect = True
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .DefaultCellStyle.Font = New System.Drawing.Font("굴림체", 9.0!)
        End With

        '캡쳐디렉토리정보 가져오기
        GetDirSqlInfo(CapturePath)
        TraceInfoTitle()

        '버튼 이미지 넣기
        ExecButton.Image = COC.PuplationIco(DX.Resources.iResources.play).ToBitmap
        ChangeDirButton.Image = COC.PuplationIco(DX.Resources.iResources.folder_open).ToBitmap

        InfoImg.ForeColor = Color.Thistle
        WarningImg.ForeColor = Color.Red

        COC.SetSqlTextBox(SqlRTB)
        SqlRTB.ReadOnly = True

    End Sub

    Private Sub GetDirSqlInfo(ByVal pTargetPath As String)

        Dim DirVarry As New ArrayList
        DirVarry.Add(New ClsValueDescription("NONE", "선택"))

        '디렉토리 조회
        If (Directory.Exists(pTargetPath)) Then

            For Each fDirName As String In Directory.GetDirectories(pTargetPath)
                DirVarry.Add(New ClsValueDescription(fDirName, System.IO.Path.GetFileName(fDirName)))
            Next

        End If

        With DirSqlComboBox.ComboBox
            .DisplayMember = "Description"
            .ValueMember = "Value"
            .DataSource = DirVarry
            .SelectedIndex = 0
        End With

    End Sub

    Private Sub GetTraceInfo(ByVal pTargetPath As String)

        Dim fReader As StreamReader = Nothing
        Dim Str As String = String.Empty
        Dim StrCatValue As Boolean = False

        Try
            TraceGV.Rows.Clear()
            If File.Exists(pTargetPath) Then

                fReader = New StreamReader(pTargetPath)
                Str = fReader.ReadLine
                Do While Not fReader.Peek = -1
                    Dim buff As String = fReader.ReadLine

                    If UCase(Trim(buff).Replace(" ", "_")) Like "*PLAN_HASH_VALUE:*" Then
                        StrCatValue = True
                    End If

                    If StrCatValue = True Then

                        Dim currRow As Integer = TraceGV.Rows.Add(buff)
                        CGC.ChangeOraTraceInfoColor(TraceGV, currRow, buff)

                    End If

                Loop
                fReader.Close()
            Else
                Dim currRow As Integer = TraceGV.Rows.Add("Not found trace data file!")
                CGC.ChangeRowBackgroundColor(TraceGV, currRow, WarningImg.ForeColor)
                CGC.ChangeRowForeColor(TraceGV, currRow, Color.Yellow)
            End If

        Catch ex As Exception

        End Try

    End Sub


    'Catch XML 파일경로를 입력받아 해당정보 취득후 그리드에 출력
    Public Function GetSQLBasicInfo(ByVal pTargetPath As String) As DataTable
        Dim rFileName As String = String.Empty
        Dim strTmp() As String
        Dim l_sql_id As String
        Dim l_sqlchild_number As Integer

        Dim l_CatchPath As String = pTargetPath & System.IO.Path.DirectorySeparatorChar & "CATCH"
        Dim l_TracePath As String = pTargetPath & System.IO.Path.DirectorySeparatorChar & "TRACE"


        Dim outDt As DataTable = New DataTable
        With outDt
            .Clear()
            .Columns.Add(New DataColumn("SCHEMA", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("SQL_ID", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("CHILD_ID", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("AVG_USE", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("AVG_USE_TIME", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("PROGRAM", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("TRACE_YN", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("UPT_DT", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("SQL_STMT", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("SQL_TRACE_INFO", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("SQL_PATH_INFO", System.Type.GetType("System.String")))
            .Columns.Add(New DataColumn("AVG_DISK_READS", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("AVG_BUFFER_GETS", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("AVG_ROWS_PROCESSED", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("AVG_CPU_TIME", System.Type.GetType("System.Double")))
            .Columns.Add(New DataColumn("EXECUTIONS", System.Type.GetType("System.Double")))
        End With

        If pTargetPath = "NONE" Then
            Return outDt
        End If

        Try
            If (Directory.Exists(l_CatchPath)) Then

                For Each fName As String In Directory.GetFiles(l_CatchPath)
                    If File.Exists(fName) Then

                        '파일명만 취득
                        rFileName = COC.FileNameWithoutExtension(fName)
                        Dim TraceName As String = l_TracePath & System.IO.Path.DirectorySeparatorChar & rFileName & ".log"

                        '파일명의 SQLID 및 Child-ID 취득
                        strTmp = Split(rFileName, "_")
                        l_sql_id = strTmp(0)
                        l_sqlchild_number = CInt(strTmp(1))

                        'Trace 정보가져오기
                        Dim xd As XDocument = XDocument.Load(fName)
                        Dim xeTrace As XElement = Me.GetProdById(xd, "SQL_INFO")

                        Dim SchemaValue As String = Trim(xeTrace.Element("SCHEMA").Value)
                        Dim UsedValue As Double = Trim(xeTrace.Element("USED").Value)
                        Dim AvgSecValue As Double = Trim(xeTrace.Element("AVGSEC").Value)
                        Dim ProgramValue As String = Trim(xeTrace.Element("PROGRAM").Value)
                        Dim SqlValue As String = Trim(xeTrace.Element("SQL").Value)
                        Dim trcValue As String = Trim(xeTrace.Element("TRACE").Value)

                        Dim AvgDiskReadsValue As String = Trim(xeTrace.Element("AVG_DISK_READS").Value)
                        Dim AvgBufferGetsValue As String = Trim(xeTrace.Element("AVG_BUFFER_GETS").Value)
                        Dim AvgRowsProcessedValue As String = Trim(xeTrace.Element("AVG_ROWS_PROCESSED").Value)
                        Dim AvgCpuTimeValue As String = Trim(xeTrace.Element("AVG_CPU_TIME").Value)
                        Dim AvgExecutionsValue As String = Trim(xeTrace.Element("EXECUTIONS").Value)

                        outDt.Rows.Add(SchemaValue, _
                                        l_sql_id, _
                                        l_sqlchild_number, _
                                        UsedValue, _
                                        AvgSecValue, _
                                        ProgramValue, _
                                        trcValue, _
                                        Directory.GetLastAccessTime(fName), _
                                        SqlValue, _
                                        TraceName, _
                                        fName, _
                                        AvgDiskReadsValue, _
                                        AvgBufferGetsValue, _
                                        AvgRowsProcessedValue, _
                                        AvgCpuTimeValue, _
                                        AvgExecutionsValue)

                    End If
                Next
            End If
            Return outDt
        Catch ex As Exception

            Return outDt
        End Try

    End Function

    Private Function GetProdById(ByRef xd As XDocument, ByVal strld0 As String) As XElement
        Return _
        (From p In xd.Descendants("MAIN").Descendants(strld0) _
         Select p).FirstOrDefault()
    End Function

    Private Sub TraceInfoTitle()
        With TraceGV
            .ColumnCount = 1
            With .Columns(0)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .HeaderText = "상세 정보"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .SortMode = DataGridViewColumnSortMode.NotSortable
            End With
        End With
    End Sub

    Private Sub SqlBasicInfoTitle()

        With DataGV
            '.ColumnCount = 11

            With .Columns(0)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "계정"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With .Columns(1)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "SQL ID"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With .Columns(2)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Child ID"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With .Columns(3)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "평균사용율"
                .DefaultCellStyle.NullValue = 0
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(4)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "평균수행시간(초)"
                .DefaultCellStyle.NullValue = 0
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(5)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "프로그램명"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            End With

            With .Columns(6)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                .HeaderText = "TRACE 여부"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With .Columns(7)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "최근갱신일시"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

            With .Columns(8)
                .HeaderText = "SQL"
                .DefaultCellStyle.NullValue = String.Empty
                .Visible = False
            End With

            With .Columns(9)
                .HeaderText = "TRACE 결과 경로"
                .DefaultCellStyle.NullValue = String.Empty
                .Visible = False
            End With

            With .Columns(10)
                .HeaderText = "SQL정보 경로"
                .DefaultCellStyle.NullValue = String.Empty
                .Visible = False
            End With

            With .Columns(11)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Avg Disk Reads"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(12)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Avg Buffer Gets"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(13)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Avg Rows Processed"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(14)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Avg CPU Time"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With

            With .Columns(15)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                .HeaderText = "Executions"
                .DefaultCellStyle.NullValue = String.Empty
                .DefaultCellStyle.Format = "#,##0"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End With



        End With
    End Sub

    Private Sub ExecButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecButton.Click
        SqlRTB.Clear()

        TraceGV.EndEdit()
        TraceGV.Rows.Clear()

        DataGV.EndEdit()
        DataGV.Columns.Clear()

        '그리드에 데이터 등록
        DataGV.DataSource = GetSQLBasicInfo(DirSqlComboBox.ComboBox.SelectedValue)
        SqlBasicInfoTitle()
    End Sub

    Private Sub PopulateSqlAndTraceData(ByVal pCurrentRow As Integer)
        Try
            'SQL 가져오고 Format 지정하기
            Dim dbV As TDbVendor = TDbVendor.DbVOracle
            Dim CurrSQL As String = DataGV.Rows(pCurrentRow).Cells(8).Value
            Dim sP As TGSqlParser = CSF.SetSqlFormatting(dbV, CurrSQL)

            '색상 넣기 수행
            With SqlRTB
                .Clear()
                .Text = sP.FormattedSqlText.Text
            End With

            'Trace 정보 가져오기
            GetTraceInfo(DataGV.Rows(pCurrentRow).Cells(9).Value)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub StartStatus()
        Me.Cursor = Cursors.WaitCursor
        DirSqlComboBox.Enabled = False
        ExecButton.Enabled = False
        ChangeDirButton.Enabled = False
    End Sub

    Private Sub StopStatus()
        Me.Cursor = Cursors.Default
        DirSqlComboBox.Enabled = True
        ExecButton.Enabled = True
        ChangeDirButton.Enabled = True
    End Sub

    Private Sub ChangeDirButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDirButton.Click
        Dim MyFolderBrowser As New System.Windows.Forms.FolderBrowserDialog

        MyFolderBrowser.Description = "Select the Folder include CATCH and TRACE folder!"
        'MyFolderBrowser.RootFolder = iDAST_ResentFolderOpen
        Dim dlgResult As DialogResult = MyFolderBrowser.ShowDialog()

        If dlgResult = Windows.Forms.DialogResult.OK Then
            GetDirSqlInfo(MyFolderBrowser.SelectedPath)
        End If

    End Sub

    Private Sub DataGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGV.CellClick

        Try
            StartStatus()
            If e.RowIndex >= 0 Then
                PopulateSqlAndTraceData(e.RowIndex)
            End If
        Catch ex As Exception
        Finally
            StopStatus()
        End Try


    End Sub

    Private Sub DataGV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGV.KeyDown
        'Try
        ' If DataGV.RowCount > 0 Then
        ' If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
        ' PopulateSqlAndTraceData(DataGV.CurrentRow.Index)
        ' End If
        ' End If

        'Catch ex As Exception
        'End Try        
    End Sub

    Private Sub DataGV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGV.MouseDown
        If e.Button = MouseButtons.Right Then
            TreeContextMenuStrip.Show(DataGV, New Point(e.X, e.Y))
        End If

    End Sub

    Private Sub NodeDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NodeDelete.Click
        Dim i As Integer = 0

        Try
            Dim SelTot As Integer = DataGV.SelectedRows.Count

            Dim MsgResult = MessageBox.Show("선택된 데이터(" & SelTot & ") 건을 삭제 할까요? ", _
                                        "Important Question", _
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If MsgResult = DialogResult.No Then
                Exit Sub
            Else

                DataGV.EndEdit()
                CtlToolStrip.Enabled = False

                For Each row As DataGridViewRow In DataGV.SelectedRows

                    'XML 데이터 삭제
                    Dim TargetXmlPath As String = row.Cells(10).Value
                    If File.Exists(TargetXmlPath) Then
                        File.Delete(TargetXmlPath)
                    End If

                    'Trace 데이터 삭제
                    Dim TargetTracePath As String = row.Cells(9).Value
                    If File.Exists(TargetTracePath) Then
                        File.Delete(TargetTracePath)
                    End If

                    '그리드내에서 삭제
                    DataGV.Rows.Remove(row)

                    RunProgressBar.Value = ((i + 1) / SelTot) * RunProgressBar.Maximum
                    RunCountStatusLabel.Text = "(" & SelTot - i & "/" & SelTot & ")"
                    COC.DoEvents()
                    i = i + 1
                Next
            End If

        Catch ex As Exception

        End Try

        CtlToolStrip.Enabled = True
        RunProgressBar.Value = RunProgressBar.Minimum

    End Sub

End Class