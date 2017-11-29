Imports System.Text

Public Class frmRegMasking
    Private CLFC As New ClsLoadFileCtl
    Private COC As New ClsObjectCtl
    Private CGC As New ClsGridCtl
    Private CMC As New clsMaskingCtl

    Private tblDt As DataTable
    Private LoadDt As DataTable
    Private colName As String
    Private colType As String
    Private colLength As Integer
    Private isNew As Boolean = False
    Private mappColInfoList() As ColumnMappingInfo
    Private MsgStrBuilder As New StringBuilder

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(MaskingType As String, FuncList As clsColFunc(), colName As String, colType As String, colLength As Integer, sampleDt As DataTable, mappColInfoList() As ColumnMappingInfo, LoadDt As DataTable)
        Try
            InitializeComponent()
            tblDt = sampleDt
            Me.LoadDt = LoadDt
            Me.colName = colName
            Me.colType = colType
            Me.colLength = colLength
            Me.mappColInfoList = mappColInfoList

            TabMainCTL.SimpleMode = True
            TabMainCTL.SimpleModeInDesign = True

            With MaskingTypCBX
                .Items.Clear()
                .Items.AddRange(MASKING_CBX_LIST.GetMaskingTypeCBX_LIST)
            End With
            With MappingCBX
                .Items.Clear()
                .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_MAPP_FIXED_LIST)
            End With

            Select Case MASKING_TYPE.GetMaskingCode(MaskingType)
                Case LoadColFuncList.NONE
                    MaskingTypCBX.SelectedIndex = 0
                    'initMaskListGV()
                    isNew = True
                Case LoadColFuncList.MASKING_NORMAL
                    MaskingTypCBX.SelectedIndex = 1
                    'initMaskListGV()
                Case LoadColFuncList.MASKING_SWITCH
                    MaskingTypCBX.SelectedIndex = 2
                Case LoadColFuncList.MASKING_MAPPING_FIXED
                    MaskingTypCBX.SelectedIndex = 3
                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_MAPP_FIXED_LIST)
                    End With
                Case LoadColFuncList.MASKING_MAPPING_NONFIXED
                    MaskingTypCBX.SelectedIndex = 4
                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_MAPP_FIXED_LIST)
                    End With
                Case LoadColFuncList.MASKING_REPLACE_FIXED, LoadColFuncList.MASKING_REPLACE_NONFIXED
                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_REP_FIX_LIST)
                    End With
                    MaskingTypCBX.SelectedIndex = 5
                Case LoadColFuncList.MASKING_REPLACE_FIXED, LoadColFuncList.MASKING_REPLACE_NONFIXED
                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_REP_FIX_LIST)
                    End With
                    MaskingTypCBX.SelectedIndex = 6
                Case Else
                    MaskingTypCBX.SelectedIndex = 0
                    isNew = True
            End Select

            MappingCBX.SelectedIndex = 0
            initMaskListGV()
            AddMaskListGV(FuncList)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub SaveBTN_Click(sender As Object, e As EventArgs) Handles SaveBTN.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Public Function getMaskingList() As clsColFunc()
        Dim argList As New List(Of clsColFunc)
        Try
            Dim func As clsColFunc = Nothing
            For Each row As DataGridViewRow In MaskListGV.Rows
                func = New clsColFunc
                func.funcCmd = MASKING_TYPE.GetMaskingCode(row.Cells("TYPE").Value)
                'For i As Integer = 2 To row.Cells.Count - 1
                '    func.FuncArgs.Add(row.Cells(i).Value)
                'Next
                Select Case func.funcCmd
                    Case LoadColFuncList.NONE

                    Case LoadColFuncList.MASKING_NORMAL
                        func.FuncArgs.Add(row.Cells("CHARACTER").Value)
                    Case LoadColFuncList.MASKING_SWITCH

                    Case LoadColFuncList.MASKING_MAPPING_FIXED, LoadColFuncList.MASKING_MAPPING_NONFIXED
                        Dim idx As Integer = MappingCBX.Items.IndexOf(row.Cells("MTYPE").Value)
                        func.FuncArgs.Add(idx)
                    Case LoadColFuncList.MASKING_REPLACE_FIXED, LoadColFuncList.MASKING_REPLACE_NONFIXED
                        Dim idx As Integer = MappingCBX.Items.IndexOf(row.Cells("MTYPE").Value)
                        func.FuncArgs.Add(idx)
                End Select

                func.FuncArgs.Add(row.Cells("START").Value)

                If row.Cells("END").Value = "LAST" Then
                    func.FuncArgs.Add(-1)
                Else
                    func.FuncArgs.Add(row.Cells("END").Value)
                End If

                argList.Add(func)
            Next
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return argList.ToArray
    End Function
    Private Sub AddMaskListGV(funcList As clsColFunc())
        Try
            If funcList IsNot Nothing Then
                Dim arr As Object() = Nothing
                For i As Integer = 0 To funcList.Count - 1
                    Select Case funcList(i).funcCmd
                        Case LoadColFuncList.MASKING_NORMAL
                            Dim StartPos As Integer = funcList(i).FuncArgs(1)
                            Dim EndPos As String = funcList(i).FuncArgs(2)
                            If EndPos = -1 Then
                                EndPos = "LAST"
                            End If
                            arr = New Object(5) {False, MASKING_TYPE.GetMaskingName(funcList(i).funcCmd), "N/A", funcList(i).FuncArgs(0), StartPos, EndPos}
                        Case LoadColFuncList.MASKING_SWITCH
                            Dim StartPos As Integer = funcList(i).FuncArgs(0)
                            Dim EndPos As String = funcList(i).FuncArgs(1)
                            If EndPos = -1 Then
                                EndPos = "LAST"
                            End If
                            arr = New Object(5) {False, MASKING_TYPE.GetMaskingName(funcList(i).funcCmd), "N/A", "N/A", StartPos, EndPos}
                        Case LoadColFuncList.MASKING_MAPPING_FIXED, LoadColFuncList.MASKING_MAPPING_NONFIXED
                            Dim StartPos As Integer = funcList(i).FuncArgs(1)
                            Dim EndPos As String = funcList(i).FuncArgs(2)
                            If EndPos = -1 Then
                                EndPos = "LAST"
                            End If
                            arr = New Object(5) {False, MASKING_TYPE.GetMaskingName(funcList(i).funcCmd), MappingCBX.Items(funcList(i).FuncArgs(0)), "N/A", StartPos, EndPos}
                        Case LoadColFuncList.MASKING_REPLACE_FIXED, LoadColFuncList.MASKING_REPLACE_NONFIXED
                            Dim StartPos As Integer = funcList(i).FuncArgs(1)
                            Dim EndPos As String = funcList(i).FuncArgs(2)
                            If EndPos = -1 Then
                                EndPos = "LAST"
                            End If
                            arr = New Object(5) {False, MASKING_TYPE.GetMaskingName(funcList(i).funcCmd), MappingCBX.Items(funcList(i).FuncArgs(0)), "N/A", StartPos, EndPos}
                    End Select
                    MaskListGV.Rows.Add(arr)
                Next
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub frmRegMasking_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            TabMainCTL.SimpleMode = True
            LinesCBX.SelectedIndex = 0
            ReplaceCharCBX.SelectedIndex = 0

            InsertPosCBX(0, colLength)

            initColInfoGV()
            'initMaskListGV()
            initResultDataWB(tblDt)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub LogMsgHandle(ByVal e As String)
        Try
            MsgStrBuilder.AppendLine(e)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub InsertPosCBX(startPos As Integer, endPos As Integer)
        Try
            If startPos > endPos Then
                Throw New Exception("Str StartPos is great than EndPos")
            End If

            StartPosStrCBX.Items.Clear()
            EndPosStrCBX.Items.Clear()

            For i As Integer = 0 To endPos - 1
                StartPosStrCBX.Items.Add(i)
            Next
            For i As Integer = startPos To endPos - 1
                EndPosStrCBX.Items.Add(i)
            Next
            EndPosStrCBX.Items.Add("LAST")
            StartPosStrCBX.Text = startPos
            EndPosStrCBX.Text = "LAST"
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initResultDataWB(tblDt As DataTable)
        Try
            MsgStrBuilder.Clear()
            For i As Integer = 0 To mappColInfoList.Count - 1
                If mappColInfoList(i).TargetColName = colName Then
                    For j As Integer = mappColInfoList(i).func.Count - 1 To 0 Step -1
                        If mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_NORMAL Or _
                           mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_SWITCH Or _
                           mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_MAPPING_FIXED Or _
                           mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_MAPPING_NONFIXED Or _
                           mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_REPLACE_FIXED Or _
                           mappColInfoList(i).func(j).funcCmd = LoadColFuncList.MASKING_REPLACE_NONFIXED Then
                            mappColInfoList(i).func.RemoveAt(j)
                        End If
                    Next
                    mappColInfoList(i).func.AddRange(getMaskingList())
                End If
            Next

            Dim dt As DataTable = CLFC.LoadDataTableMapping(tblDt, tblDt.Rows.Count, mappColInfoList, LoadDt)
            With dt
                For i As Integer = .Columns.Count - 1 To 0 Step -1
                    If .Columns(i).ColumnName <> colName Then
                        .Columns.RemoveAt(i)
                    End If
                Next
            End With

            ResultDataWB.DocumentText = COC.CreateHtmlTable(dt)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initColInfoGV()
        Try
            With ColInfoGV
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

                .Columns.Clear()
                .Columns.Add(CGC.RetGvTextBoxColumn("NAME", False)) '체크박스
                .Columns.Add(CGC.RetGvTextBoxColumn("VALUE")) '새로운 로우인지 여부


                Dim list As New List(Of String)

                list.Add("COLUMN_NAME")
                list.Add(colName)
                ColInfoGV.Rows.Add(list.ToArray)
                list.Clear()
                list.Add("COLUMN TYPE")
                list.Add(colType)
                ColInfoGV.Rows.Add(list.ToArray)
                list.Clear()
                list.Add("COLUMN LENGTH")
                list.Add(colLength)
                ColInfoGV.Rows.Add(list.ToArray)
                list.Clear()

                With .Columns(0)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
                With .Columns(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initMaskListGV()
        Try
            With MaskListGV
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

                .Columns.Clear()
                .Columns.Add(CGC.RetGvCheckBoxColumn("CHECK", True))
                .Columns.Add(CGC.RetGvTextBoxColumn("TYPE"))  '마스킹 타입
                .Columns.Add(CGC.RetGvTextBoxColumn("MTYPE")) 'MATCH 마스킹 내부 타입
                .Columns.Add(CGC.RetGvTextBoxColumn("CHARACTER")) 'NORMAL 마스킹 대체 문자
                .Columns.Add(CGC.RetGvTextBoxColumn("START")) '문자열 시작위치
                .Columns.Add(CGC.RetGvTextBoxColumn("END")) '문자열 종료 위치

                With .Columns("CHECK")
                    .Width = 60
                End With
                With .Columns("TYPE")
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
                With .Columns("MTYPE")
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
                With .Columns("CHARACTER")
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
                With .Columns("START")
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
                With .Columns("END")
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End With
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click
        Try
            If ChkStrLength() = False Then
                Exit Sub
            End If

            With MaskListGV
                'initMaskListGV()
                Dim arr As Object() = Nothing
                Select Case MaskingTypCBX.Text
                    Case MASKING_TYPE.NORMAL
                        arr = New Object(5) {False, MaskingTypCBX.Text, "N/A", ReplaceCharCBX.Text, StartPosStrCBX.Text, EndPosStrCBX.Text}
                    Case MASKING_TYPE.SWITCH
                        arr = New Object(5) {False, MaskingTypCBX.Text, "N/A", "N/A", StartPosStrCBX.Text, EndPosStrCBX.Text}
                    Case MASKING_TYPE.MAPPING_FIXED, MASKING_TYPE.MAPPING_NONFIXED
                        arr = New Object(5) {False, MaskingTypCBX.Text, MappingCBX.Text, "N/A", StartPosStrCBX.Text, EndPosStrCBX.Text}
                    Case MASKING_TYPE.REPLACE_FIXED, MASKING_TYPE.REPLACE_NONFIXED
                        arr = New Object(5) {False, MaskingTypCBX.Text, MappingCBX.Text, "N/A", StartPosStrCBX.Text, EndPosStrCBX.Text}
                End Select

                .Rows.Add(arr)
            End With
            initResultDataWB(tblDt)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Function ChkStrLength() As Boolean
        Try
            If EndPosStrCBX.Text <> "LAST" Then
                If CInt(StartPosStrCBX.Text) > CInt(EndPosStrCBX.Text) Then
                    MsgBox("MASKING 시작 위치가 종료 위치보다 더 큽니다.", MsgBoxStyle.Exclamation)
                    Return False
                End If

                Select Case MappingCBX.SelectedIndex
                    Case MASKING_MAPPING_TYPE.SOCIAL_SECURITY_NUMBER
                        If (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 < 13 Or (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 > 14 Then
                            MsgBox("주민등록번호 타입은 13~14자리의 자리 길이를 가져야 합니다.", MsgBoxStyle.Exclamation)
                            Return False
                        End If
                    Case MASKING_MAPPING_TYPE.CARD_NO
                        If (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 < 13 Or (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 > 16 Then
                            MsgBox("카드번호 타입은 13~16자리의 자리 길이를 가져야 합니다.", MsgBoxStyle.Exclamation)
                            Return False
                        End If
                    Case MASKING_MAPPING_TYPE.EMAIL
                        If (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 < 4 Then
                            MsgBox("이메일 주소 타입은 4자리 이상의 길이를 가져야 합니다.", MsgBoxStyle.Exclamation)
                            Return False
                        End If
                    Case MASKING_MAPPING_TYPE.DATE_MMDD
                        If (CInt(EndPosStrCBX.Text) - CInt(StartPosStrCBX.Text)) + 1 < 4 Then
                            MsgBox("날짜 타입은 4자리 길이를 가져야 합니다.", MsgBoxStyle.Exclamation)
                            Return False
                        End If
                End Select
            End If
            Return True
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
            Return False
        End Try
    End Function
    Private Sub RemoveBTN_Click(sender As Object, e As EventArgs) Handles RemoveBTN.Click
        Try
            For i As Integer = MaskListGV.Rows.Count - 1 To 0 Step -1
                If MaskListGV.Rows(i).Cells("CHECK").Value = True Then
                    MaskListGV.Rows.RemoveAt(i)
                End If
            Next
            initResultDataWB(tblDt)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    'Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
    '    Try
    '        initResultDataWB(tblDt)
    '    Catch ex As Exception
    '        logger.err(ex.Message & ex.StackTrace)
    '    End Try
    'End Sub

    Private Sub MaskListGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaskListGV.CellContentClick
        Try
            If e.RowIndex > -1 And e.ColumnIndex = 0 Then
                If MaskListGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True Then
                    MaskListGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False
                Else
                    MaskListGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = True
                End If
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub MaskingTypCBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaskingTypCBX.SelectedIndexChanged
        Try
            Select Case MaskingTypCBX.Text
                Case MASKING_TYPE.NONE
                    TabMainCTL.Enabled = False
                    MaskListGV.Rows.Clear()
                Case MASKING_TYPE.NORMAL
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = True
                    MappingCBX.Enabled = False
                Case MASKING_TYPE.SWITCH
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = False
                    MappingCBX.Enabled = False
                Case MASKING_TYPE.MAPPING_FIXED
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = False
                    MappingCBX.Enabled = True

                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_MAPP_FIXED_LIST)
                        .SelectedIndex = 0
                    End With
                Case MASKING_TYPE.MAPPING_NONFIXED
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = False
                    MappingCBX.Enabled = True

                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_MAPP_FIXED_LIST)
                        .SelectedIndex = 0
                    End With
                Case MASKING_TYPE.REPLACE_FIXED, MASKING_TYPE.REPLACE_NONFIXED
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = False
                    MappingCBX.Enabled = True

                    With MappingCBX
                        .Items.Clear()
                        .Items.AddRange(MASKING_CBX_LIST.GetMAPPINGCBX_REP_FIX_LIST)
                        .SelectedIndex = 0
                    End With
                Case Else
                    TabMainCTL.Enabled = True
                    ReplaceCharCBX.Enabled = False
                    MappingCBX.Enabled = False
            End Select
            'If MaskingTypCBX.SelectedIndex = 0 Then
            '    TabMainCTL.Enabled = False
            'ElseIf MaskingTypCBX.SelectedIndex = 1 Then
            '    TabMainCTL.Enabled = True
            '    ReplaceCharCBX.Enabled = True
            '    MappingCBX.Enabled = False
            'ElseIf MaskingTypCBX.SelectedIndex = 3 Or MaskingTypCBX.SelectedIndex = 4 Then
            '    TabMainCTL.Enabled = True
            '    ReplaceCharCBX.Enabled = False
            '    MappingCBX.Enabled = True
            'Else
            '    TabMainCTL.Enabled = True
            '    ReplaceCharCBX.Enabled = False
            '    MappingCBX.Enabled = False
            'End If
            initResultDataWB(tblDt)

        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub Cancel_BTN_Click(sender As Object, e As EventArgs) Handles Cancel_BTN.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LinesCBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LinesCBX.SelectedIndexChanged
        Try
            initResultDataWB(tblDt)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
End Class