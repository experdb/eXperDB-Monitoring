Imports DX.Controls
Imports DX.Database.ClsOdbc
Imports DX.Database
Imports Oracle.DataAccess.Client
Imports System.Threading
Imports System.IO

Public Class frmLoaderReg
    Private COC As New ClsObjectCtl
    Private CGC As New ClsGridCtl
    Private CLFC As New ClsLoadFileCtl
    Private CMPC As New clsMappingCols
    'DB 커넥션
    Private DbConn As ClsCommonConn

    'DB 커넥션 정보
    Private ConnInfo As OdbcDbInfo

    '테이블 리스트 데이터 데이블
    Private TableListDT As DataTable

    Private m_fileName As String = String.Empty
    Private m_Buffers As Integer = 10000
    Private m_Line_Terminator As String = String.Empty
    Private m_Col_Delimiter As String = String.Empty

    Private m_target_tblNm As String = String.Empty
    Private src_colNm_List As DataTable
    Private func_list As New ArrayList
    Private mask_list As New ArrayList

    Private sampletable As DataTable
    Private m_ExcelSheetName As String = String.Empty
    '원본 샘파일 캐리지 리턴 종류
    Private m_CarrigeReturn As String = String.Empty
    '이전 Cell Value 값(MappingcolGV)
    Private beforCellValue As String

    '컬럼별 적용 Func Dictionary
    Private ColFuncList As New Dictionary(Of Integer, clsColFunc())

    'TASK 초기설정
    Private lcts As New LimitedConcurrencyLevelTaskScheduler(1)
    Private factory As New TaskFactory(lcts)
    Private cts As New CancellationTokenSource()

    Private Sub frmLoaderReg_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            DICTIONARY_PATH_LIST.Clear()
            DICTIONARY_PATH_LIST.Add(MASKING_REPLACE_FIXED_TYPE.NAME, System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Shared" & Path.DirectorySeparatorChar & "dictionary" & Path.DirectorySeparatorChar & "name" & Path.DirectorySeparatorChar & "dict_name.txt"))
            DICTIONARY_PATH_LIST.Add(MASKING_REPLACE_FIXED_TYPE.OLD_ADDRESS, System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Shared" & Path.DirectorySeparatorChar & "dictionary" & Path.DirectorySeparatorChar & "old_address" & Path.DirectorySeparatorChar & "dict_old_address.txt"))
            DICTIONARY_PATH_LIST.Add(MASKING_REPLACE_FIXED_TYPE.NEW_ADDRESS, System.IO.Path.Combine(My.Application.Info.DirectoryPath, "Shared" & Path.DirectorySeparatorChar & "dictionary" & Path.DirectorySeparatorChar & "new_address" & Path.DirectorySeparatorChar & "dict_new_address.txt"))

            TabCtlCustom.SimpleMode = True
            '버튼 아이콘
            DbConnBTN.Image = COC.PuplationIco(DX.Resources.iResources.connection).ToBitmap()
            DbEndConnBTN.Image = COC.PuplationIco(DX.Resources.iResources.connection_close).ToBitmap()

            DbConnBTN.Enabled = True
            DbEndConnBTN.Enabled = False

            initTabLoadFile()

            ' Add the events to listen for
            AddHandler MappingColGV.CellValueChanged, New DataGridViewCellEventHandler(AddressOf MappingColGV_CellValueChanged)
            AddHandler MappingColGV.CurrentCellDirtyStateChanged, New EventHandler(AddressOf MappingColGV_CurrentCellDirtyStateChange)


            '함수리스트
            'func_list.Add(New ClsValueDescription("NONE", "NONE"))
            'func_list.Add(New ClsValueDescription("TRIM", "TRIM"))
            'func_list.Add(New ClsValueDescription("RTRIM", "RTRIM"))
            'func_list.Add(New ClsValueDescription("LTRIM", "LTRIM"))
            func_list.Add(New ClsValueDescription(LoadColFuncList.NONE, "NONE"))
            func_list.Add(New ClsValueDescription(LoadColFuncList.TRIM, "TRIM"))
            func_list.Add(New ClsValueDescription(LoadColFuncList.RTRIM, "RTRIM"))
            func_list.Add(New ClsValueDescription(LoadColFuncList.LTRIM, "LTRIM"))

        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub MappingColGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        Dim CLFC As ClsLoadFileCtl = Nothing
        'MappingColGV.EndEdit()
        Try
            If (e.ColumnIndex = 0 Or e.ColumnIndex = 1) And e.RowIndex > -1 Then
                Dim combobox As DataGridViewComboBoxCell = MappingColGV.CurrentRow.Cells(colName.SRC_COL_NAME(0))
                Dim combobox2 As DataGridViewComboBoxCell = MappingColGV.CurrentRow.Cells(colName.FUNC_NAME(0))
                If combobox IsNot Nothing And combobox2 IsNot Nothing Then
                    MappingColGV.Invalidate()
                    RefreshModLoadSetting()
                    COC.DoEvents()
                End If
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
            If CLFC IsNot Nothing Then
                CLFC.Close()
            End If
        End Try
    End Sub

    Private Sub MappingColGV_CurrentCellDirtyStateChange(sender As Object, e As EventArgs)
        Try
            If MappingColGV.IsCurrentCellDirty Then
                beforCellValue = MappingColGV.CurrentCell.Value
                MappingColGV.CommitEdit(DataGridViewDataErrorContexts.Commit)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub CloseBTN_Click(sender As Object, e As EventArgs) Handles CloseBTN.Click
        Try
            Me.Close()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initTabLoadFile()
        Try
            TxtFileTypRB.Checked = True
            m_fileName = String.Empty
            FileNameTBX.Text = m_fileName

            'Back 버튼 Disable
            BackBTN.Enabled = False
            NextBTN.Enabled = False
            AddFileBTN.Enabled = False

            'Line CBX 초기화
            OrgLinesCBX.SelectedIndex = 0
            ModLinesCBX.SelectedIndex = 0

            'result gv 숨기기
            TabResultCTL.SelectedIndex = 0
            HideResultGV()

            'Execute 버튼 숨기기
            ExecBTN.Visible = False

            GrpFileType.Enabled = False
            GrpAddFile.Enabled = False
            GrpExcelSheet.Enabled = False
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub HideResultGV()
        'result gv 숨기기
        SplitContainer2.Panel2.Hide()
        SplitContainer2.Panel2Collapsed = True
    End Sub
    Private Sub ShowResultGV()
        'result gv 보이기
        SplitContainer2.Panel2.Show()
        SplitContainer2.Panel2Collapsed = False
    End Sub
    Private Sub initTabLoadSetting()
        Try
            ShowResultGV()

            'Back 버튼 Enable
            BackBTN.Enabled = True
            OrgTxtTlsRTB.Text = TxtFileRTB.Text

            '변수 초기화
            m_Line_Terminator = String.Empty
            m_Col_Delimiter = String.Empty

            'LT Input TBX 초기화
            LtUserInputTBX.Text = String.Empty

            'Radio버튼 초기화
            CdCommaRB.Checked = False
            CdPipeRB.Checked = False
            CdSpaceRB.Checked = False
            CdTabRB.Checked = False
            CdUserInputRB.Checked = False
            LtCrRB.Checked = False
            LtUserInputRB.Checked = False

            'Line CBX 초기화
            OrgLinesCBX.SelectedIndex = 0
            ModLinesCBX.SelectedIndex = 0

            '소스 컬럼 리스트 초기화
            src_colNm_List = Nothing

            'GV 초기화
            RefreshLoadSetting()
            RefreshModLoadSetting()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initTabTblSetting()
        Try
            'table 정보 수집
            TableListDT = DbConn.DbOp.getTableList(DbConn.getConn, ConnInfo.SCHEMA_NAME)
            initTblListGV(TableListDT)
            initColInfoGV()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initTabColMapping()
        Try
            TabResultCTL.SelectedIndex = 1
            TableNmTBX.Text = m_target_tblNm
            initMappingColGV()
            MatchColGVToResultGV()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub MatchColGVToResultGV()
        Try
            With MappingColGV
                'For Each col As datagridviewcolu
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initTblListGV(Optional dt As DataTable = Nothing)
        Try
            CGC.InitGridForPub(TblListGV, "VIEW")
            With TblListGV
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False

                If (dt IsNot Nothing) Then
                    .DataSource = dt
                Else
                    .DataSource = New DataTable
                End If

                '컬럼추가
                .Columns.Clear()
                .Columns.Add(CGC.RetGvCheckBoxColumn(colName.CHECKBOX(0), False)) '체크박스
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_QUALIFIER(0))) 'DB명(일부 DB에서는 값이 없음)
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_OWNER(0))) '테이블 소유자(스키마)
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_NAME(0))) '테이블명
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_TYPE(0))) '테이블타입
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.REMARKS(0)))

                With .Columns(colName.CHECKBOX(0))
                    .HeaderText = colName.CHECKBOX(1)
                    .Width = 40
                End With
                With .Columns(colName.TABLE_QUALIFIER(0))
                    .DataPropertyName = colName.TABLE_QUALIFIER(0)
                    .Visible = False
                End With

                With .Columns(colName.TABLE_OWNER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_NAME(0))
                    .DataPropertyName = colName.TABLE_NAME(0)
                    .HeaderText = colName.TABLE_NAME(1)
                    .DefaultCellStyle.NullValue = String.Empty
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.TABLE_TYPE(0))
                    .DataPropertyName = colName.TABLE_TYPE(0)
                    .HeaderText = colName.TABLE_TYPE(1)
                    .DefaultCellStyle.NullValue = String.Empty
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.REMARKS(0))
                    .DataPropertyName = colName.REMARKS(0)
                    .Visible = False
                End With
                .EndEdit()
                COC.DoEvents()
            End With
            ExtensionMethods.DoubleBuffered(TblListGV, True)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initColInfoGV(Optional dt As DataTable = Nothing)
        Try
            CGC.InitGridForPub(ColInfoGV, "VIEW")
            With ColInfoGV
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

                If (dt IsNot Nothing) Then
                    .DataSource = dt
                Else
                    .DataSource = New DataTable
                End If

                .Columns.Clear()
                .Columns.Add(CGC.RetGvCheckBoxColumn(colName.CHECKBOX(0), False)) '체크박스
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_QUALIFIER(0))) '새로운 로우인지 여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_OWNER(0))) '테이블명
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_NAME(0))) '주석
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.COLUMN_NAME(0))) '테이블스페이스명
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.DATA_TYPE(0))) '오브젝트상태
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TYPE_NAME(0))) '로깅여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.LENGTH(0))) '평균로우길이
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.PRECISION(0))) '예상로우건수
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SCALE(0))) '사용량
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.RADIX(0))) '로깅여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.NULLABLE(0))) '전환구분
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.REMARKS(0))) '예상로우건수
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.COLUMN_DEF(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SQL_DATA_TYPE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SQL_DATETIME_SUB(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.CHAR_OCTET_LENGTH(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.ORDINAL_POSITION(0))) '평균로우길이
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.IS_NULLABLE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.DISPLAY_SIZE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.FIELD_TYPE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.AUTO_INCREMENT(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.PHYSICAL_NUMBER(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_OID(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.BASE_TYPEID(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TYPMOD(0)))

                With .Columns(colName.CHECKBOX(0))
                    .HeaderText = colName.CHECKBOX(1)
                    .Width = 40
                End With
                With .Columns(colName.TABLE_QUALIFIER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_OWNER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_NAME(0))
                    .Visible = False
                End With
                With .Columns(colName.COLUMN_NAME(0))
                    .HeaderText = colName.COLUMN_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                With .Columns(colName.DATA_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.TYPE_NAME(0))
                    .HeaderText = colName.TYPE_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                With .Columns(colName.PRECISION(0))
                    .HeaderText = colName.PRECISION(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                With .Columns(colName.LENGTH(0))
                    .HeaderText = colName.LENGTH(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                With .Columns(colName.SCALE(0))
                    .HeaderText = colName.SCALE(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                With .Columns(colName.RADIX(0))
                    .Visible = False
                End With
                With .Columns(colName.NULLABLE(0))
                    .HeaderText = colName.NULLABLE(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                With .Columns(colName.REMARKS(0))
                    .Visible = False
                End With
                With .Columns(colName.COLUMN_DEF(0))
                    .Visible = False
                End With
                With .Columns(colName.SQL_DATA_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.SQL_DATETIME_SUB(0))
                    .Visible = False
                End With
                With .Columns(colName.CHAR_OCTET_LENGTH(0))
                    .Visible = False
                End With
                With .Columns(colName.ORDINAL_POSITION(0))
                    .HeaderText = colName.ORDINAL_POSITION(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
                With .Columns(colName.IS_NULLABLE(0))
                    .Visible = False
                End With
                With .Columns(colName.DISPLAY_SIZE(0))
                    .Visible = False
                End With
                With .Columns(colName.FIELD_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.AUTO_INCREMENT(0))
                    .Visible = False
                End With
                With .Columns(colName.PHYSICAL_NUMBER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_OID(0))
                    .Visible = False
                End With
                With .Columns(colName.BASE_TYPEID(0))
                    .Visible = False
                End With
                With .Columns(colName.TYPMOD(0))
                    .Visible = False
                End With

                For Each row As DataGridViewRow In ColInfoGV.Rows
                    If row.Cells(colName.NULLABLE(0)).Value.GetType Is GetType(String) Then
                        If (row.Cells(colName.NULLABLE(0)).Value = "N" Or row.Cells(colName.NULLABLE(0)).Value = "NO") And row.Visible = True Then
                            Dim cell As DataGridViewCheckBoxCell = row.Cells(colName.CHECKBOX(0))
                            cell.Value = True
                            cell.FlatStyle = FlatStyle.Flat
                            cell.Style.ForeColor = Color.DarkGray
                            cell.ReadOnly = True
                        Else
                            Dim cell As DataGridViewCheckBoxCell = row.Cells(colName.CHECKBOX(0))
                            cell.Value = True
                        End If
                    Else
                        If row.Cells(colName.NULLABLE(0)).Value = 0 And row.Visible = True Then
                            Dim cell As DataGridViewCheckBoxCell = row.Cells(colName.CHECKBOX(0))
                            cell.Value = True
                            cell.FlatStyle = FlatStyle.Flat
                            cell.Style.ForeColor = Color.DarkGray
                            cell.ReadOnly = True
                        Else
                            Dim cell As DataGridViewCheckBoxCell = row.Cells(colName.CHECKBOX(0))
                            cell.Value = True
                        End If
                    End If
                Next

                .EndEdit()

                COC.DoEvents()
            End With
            ExtensionMethods.DoubleBuffered(ColInfoGV, True)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initMappingColGV()
        Try
            CGC.InitGridForPub(MappingColGV, "EDIT")
            With MappingColGV
                .RowHeadersVisible = False
                .AllowUserToAddRows = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
                .AllowUserToResizeRows = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White

                .Rows.Clear()
                .Columns.Clear()
                .Columns.Add(CGC.RetGvComboBoxColumn(colName.SRC_COL_NAME(0), src_colNm_List))
                .Columns.Add(CGC.RetGvComboBoxColumn(colName.FUNC_NAME(0), func_list)) '함수
                '.Columns.Add(CGC.RetGvButtonboxColumn(colName.MASKING_BTN(0), colName.MASKING_BTN(1))) 'masking 버튼
                .Columns.Add(CGC.RetGvButtonboxColumn(colName.MASKING_BTN(0), "미설정")) 'masking 버튼
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.MASKING_TYPE(0))) '마스킹 타입
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_QUALIFIER(0))) '새로운 로우인지 여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_OWNER(0))) '테이블명
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_NAME(0))) '주석
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.COLUMN_NAME(0))) '테이블스페이스명
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.DATA_TYPE(0))) '오브젝트상태
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TYPE_NAME(0))) '로깅여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.LENGTH(0))) '평균로우길이
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.PRECISION(0))) '예상로우건수
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SCALE(0))) '사용량
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.RADIX(0))) '로깅여부
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.NULLABLE(0))) '전환구분
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.REMARKS(0))) '예상로우건수
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.COLUMN_DEF(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SQL_DATA_TYPE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.SQL_DATETIME_SUB(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.CHAR_OCTET_LENGTH(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.ORDINAL_POSITION(0))) '평균로우길이
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.IS_NULLABLE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.DISPLAY_SIZE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.FIELD_TYPE(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.AUTO_INCREMENT(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.PHYSICAL_NUMBER(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TABLE_OID(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.BASE_TYPEID(0)))
                .Columns.Add(CGC.RetGvTextBoxColumn(colName.TYPMOD(0)))

                With .Columns(colName.SRC_COL_NAME(0))
                    .HeaderText = colName.SRC_COL_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                With .Columns(colName.FUNC_NAME(0))
                    .HeaderText = colName.FUNC_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                End With
                With .Columns(colName.MASKING_BTN(0))
                    .HeaderText = colName.MASKING_BTN(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                End With
                With .Columns(colName.MASKING_TYPE(0))
                    .HeaderText = colName.MASKING_TYPE(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                    .Visible = False
                End With
                With .Columns(colName.TABLE_QUALIFIER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_OWNER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_NAME(0))
                    .HeaderText = colName.TABLE_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.COLUMN_NAME(0))
                    .HeaderText = colName.COLUMN_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.DATA_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.TYPE_NAME(0))
                    .HeaderText = colName.TYPE_NAME(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.PRECISION(0))
                    .HeaderText = colName.PRECISION(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                    .ReadOnly = True
                End With
                With .Columns(colName.LENGTH(0))
                    .HeaderText = colName.LENGTH(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .ReadOnly = True
                End With
                With .Columns(colName.SCALE(0))
                    .HeaderText = colName.SCALE(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                    .ReadOnly = True
                End With
                With .Columns(colName.RADIX(0))
                    .Visible = False
                End With
                With .Columns(colName.NULLABLE(0))
                    .HeaderText = colName.NULLABLE(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                    .ReadOnly = True
                End With
                With .Columns(colName.REMARKS(0))
                    .Visible = False
                End With
                With .Columns(colName.COLUMN_DEF(0))
                    .Visible = False
                End With
                With .Columns(colName.SQL_DATA_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.SQL_DATETIME_SUB(0))
                    .Visible = False
                End With
                With .Columns(colName.CHAR_OCTET_LENGTH(0))
                    .Visible = False
                End With
                With .Columns(colName.ORDINAL_POSITION(0))
                    .HeaderText = colName.ORDINAL_POSITION(1)
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                    .ReadOnly = True
                End With
                With .Columns(colName.IS_NULLABLE(0))
                    .Visible = False
                End With
                With .Columns(colName.DISPLAY_SIZE(0))
                    .Visible = False
                End With
                With .Columns(colName.FIELD_TYPE(0))
                    .Visible = False
                End With
                With .Columns(colName.AUTO_INCREMENT(0))
                    .Visible = False
                End With
                With .Columns(colName.PHYSICAL_NUMBER(0))
                    .Visible = False
                End With
                With .Columns(colName.TABLE_OID(0))
                    .Visible = False
                End With
                With .Columns(colName.BASE_TYPEID(0))
                    .Visible = False
                End With
                With .Columns(colName.TYPMOD(0))
                    .Visible = False
                End With

            End With

            Dim k As Integer = 0
            For Each row As DataGridViewRow In ColInfoGV.Rows
                If row.Cells(colName.CHECKBOX(0)).Value = True Then
                    Dim arrList As New ArrayList

                    If k < src_colNm_List.Rows.Count - 2 Then
                        'Dim val As ClsValueDescription = src_colNm_List.Rows(k).Item(0)
                        arrList.Add(src_colNm_List.Rows(k).Item(colName.SRC_COL_NAME(0)))
                    Else
                        'Dim val As ClsValueDescription = src_colNm_List(src_colNm_List.Rows.Count - 2).Item(0)
                        arrList.Add(src_colNm_List(src_colNm_List.Rows.Count - 2).Item(colName.SRC_COL_NAME(0)))
                    End If

                    '함수 기본(미사용)
                    arrList.Add(LoadColFuncList.NONE)
                    arrList.Add("NONE")
                    arrList.Add(MASKING_TYPE.NONE)

                    For i As Integer = 1 To row.Cells.Count - 1
                        arrList.Add(row.Cells(i).Value)
                    Next

                    MappingColGV.Rows.Add(arrList.ToArray)
                    k += 1
                End If
            Next
            ExtensionMethods.DoubleBuffered(MappingColGV, True)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initResultModDataGV(Optional dt As DataTable = Nothing)
        Try
            If dt Is Nothing Then
                ResultModDataWB.DocumentText = String.Empty
            Else
                ResultModDataWB.DocumentText = COC.CreateHtmlTable(dt)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub initResultDataGV(Optional dt As DataTable = Nothing)
        Try
            With ResultDataWB
                If dt Is Nothing Then
                    ResultDataWB.DocumentText = String.Empty
                Else
                    ResultDataWB.DocumentText = COC.CreateHtmlTable(dt)

                    '소스 컬럼 리스트 
                    'src_colNm_List = New List(Of ClsValueDescription)


                    src_colNm_List = New DataTable
                    src_colNm_List.Columns.Add(colName.SRC_COL_NAME(0))
                    For i As Integer = 0 To dt.Columns.Count - 1
                        src_colNm_List.Rows.Add(dt.Columns(i).ColumnName)
                        'src_colNm_List.Add(New ClsValueDescription(dt.Columns(i).ColumnName, dt.Columns(i).ColumnName))
                    Next
                    src_colNm_List.Rows.Add("NULL")
                    src_colNm_List.Rows.Add("USER INPUT")

                    'src_colNm_List.Add(New ClsValueDescription("NULL", "NULL"))
                    'src_colNm_List.Add(New ClsValueDescription("USER INPUT", "USER INPUT"))


                    ''NULL컬럼 확인하기 위하여 전역변수로 클론
                    'sampletable = dt.Clone
                End If
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub RefreshLoadSetting()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()

            SetDelimiter()
            If ExcelFileTypRB.Checked = True Then
                initResultDataGV(getSampleExcelData())
            ElseIf (m_Line_Terminator <> String.Empty And m_Col_Delimiter <> String.Empty) Then
                initResultDataGV(getSampleSamData(m_fileName))
            Else
                initResultDataGV(Nothing)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub RefreshModLoadSetting()
        Try
            SetDelimiter()
            If (m_Line_Terminator <> String.Empty And m_Col_Delimiter <> String.Empty) Or ExcelFileTypRB.Checked = True Then
                Dim query As String = MappingColQuery(MappingColGV)

                '소스/타겟 컬럼 리스트 가져오기
                Dim srcColList As String() = New String(MappingColGV.Rows.Count - 1) {}
                Dim targetColList As String() = New String(MappingColGV.Rows.Count - 1) {}
                getBulkMappColList(srcColList, targetColList)

                '매핑 테이블
                Dim mappDt As DataTable = DbConn.CreateMappTable(query, targetColList, True)
                Dim mappColInfoList As ColumnMappingInfo() = CMPC.MappingColInfo(CreateMappingDt(), src_colNm_List, ColFuncList)

                Dim lines As Integer = getShowModLines()
                Dim resultDt As DataTable = Nothing
                Dim task As Task = factory.StartNew(Sub()
                                                        If ExcelFileTypRB.Checked = True Then
                                                            If sampletable Is Nothing OrElse sampletable.Rows.Count = 0 Then
                                                                resultDt = CLFC.LoadExcelFile(m_fileName, m_ExcelSheetName, lines, mappColInfoList, mappDt)
                                                            Else
                                                                resultDt = CLFC.LoadDataTableMapping(sampletable, lines, mappColInfoList, mappDt)
                                                            End If
                                                        Else
                                                            resultDt = CLFC.LoadSamFile(m_fileName, lines, m_Line_Terminator, m_Col_Delimiter, m_Buffers, mappColInfoList, mappDt)
                                                        End If

                                                    End Sub)
                ProcessingLB(task)
                initResultModDataGV(resultDt)
            Else
                initResultModDataGV(Nothing)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Function getShowLines() As Integer
        Dim lines As Integer = 0
        Try
            If OrgLinesCBX.Text = "ALL" Then
                'lines = 0
            Else
                lines = CInt(OrgLinesCBX.Text)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return lines
    End Function
    Private Function getShowModLines() As Integer
        Dim lines As Integer = 0
        Try
            If ModLinesCBX.Text = "ALL" Then
                'lines = 0
            Else
                lines = CInt(ModLinesCBX.Text)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return lines
    End Function
    Private Function getSampleExcelData() As DataTable
        Dim dt As DataTable = Nothing
        Try
            If sampletable Is Nothing OrElse sampletable.Rows.Count = 0 Then
                Dim lines As Integer = 1000
                Dim task As Task = factory.StartNew(Sub()
                                                        dt = CLFC.LoadExcelFile(m_fileName, m_ExcelSheetName, lines)
                                                    End Sub)

                ProcessingLB(task)

                'NULL컬럼 확인하기 위하여 전역변수로 클론
                sampletable = dt
            Else
                Dim lines As Integer = getShowLines()
                'initResultDataGV()
                dt = sampletable.AsEnumerable().Take(lines).CopyToDataTable
            End If

        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return dt
    End Function
    Private Function getSampleSamData(FileName) As DataTable
        Dim dt As DataTable = Nothing
        Try
            Dim lines As Integer = getShowLines()

            Dim task As Task = factory.StartNew(Sub()
                                                    dt = CLFC.LoadSamFile(m_fileName, lines, m_Line_Terminator, m_Col_Delimiter, m_Buffers)
                                                End Sub)
            ProcessingLB(task)
            sampletable = dt
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return dt
    End Function
    Private Function ReplaceCR(delimiter As String) As String
        Try
            delimiter = delimiter.Replace("\r", vbCr)
            delimiter = delimiter.Replace("\n", vbLf)
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return delimiter
    End Function
    Private Sub SetDelimiter()
        Try
            If LtCrRB.Checked = True Then
                m_Line_Terminator = m_CarrigeReturn
                LtUserInputTBX.Enabled = False
            ElseIf LtUserInputRB.Checked = True Then
                LtUserInputTBX.Enabled = True
                m_Line_Terminator = LtUserInputTBX.Text
            Else
                m_Line_Terminator = String.Empty
                LtUserInputTBX.Enabled = False
            End If

            If CdSpaceRB.Checked = True Then
                m_Col_Delimiter = " "
            ElseIf CdTabRB.Checked = True Then
                m_Col_Delimiter = vbTab
            ElseIf CdPipeRB.Checked = True Then
                m_Col_Delimiter = "|"
            ElseIf CdCommaRB.Checked = True Then
                m_Col_Delimiter = ","
            ElseIf CdUserInputRB.Checked = True Then
                CdUserInputTBX.Enabled = True
                m_Col_Delimiter = CdUserInputTBX.Text
                Exit Sub
            Else
                m_Col_Delimiter = String.Empty
            End If

            m_Line_Terminator = ReplaceCR(m_Line_Terminator)
            m_Col_Delimiter = ReplaceCR(m_Col_Delimiter)

            CdUserInputTBX.Enabled = False
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub AddFileBTN_Click(sender As Object, e As EventArgs) Handles AddFileBTN.Click
        'Dim CLFC As ClsLoadFileCtl = Nothing
        Try
            AddFileBTN.Enabled = False

            With OpenFileDialog
                .Title = "Load Data File"
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments

                If TxtFileTypRB.Checked = True Then
                    .Filter = "File (*.txt)|*.txt|File (*.sam)|*.sam|File (*.dat)|*.dat|All files|*.*"

                    If (.ShowDialog(Me) = DialogResult.OK) Then
                        m_fileName = .FileName
                        FileNameTBX.Text = m_fileName

                        'CLFC = New ClsLoadFileCtl()
                        TxtFileRTB.Text = CLFC.ReadOrgFileText(m_fileName, 100)
                        m_CarrigeReturn = CLFC.GetCarrigeReturn(m_fileName)
                        NextBTN.Enabled = True
                    End If
                Else
                    .Filter = "File (*.xlsx)|*.xlsx|File (*.xls)|*.xls"

                    If (.ShowDialog(Me) = DialogResult.OK) Then
                        m_fileName = .FileName
                        FileNameTBX.Text = m_fileName
                        ExcelSheetCBX.Items.Clear()

                        'sample 데이터 테이블 초기화
                        If sampletable IsNot Nothing Then
                            sampletable.Dispose()
                        End If
                        sampletable = New DataTable

                        Dim sheetNames As String() = Nothing
                        Dim task As task = factory.StartNew(Sub()
                                                                sheetNames = CLFC.GetExcelSheetNames(m_fileName)
                                                            End Sub)

                        ProcessingLB(task)

                        For Each sheetNm As String In sheetNames
                            ExcelSheetCBX.Items.Add(sheetNm)
                        Next
                        ExcelSheetCBX.SelectedIndex = 0
                        m_ExcelSheetName = ExcelSheetCBX.Text

                        initResultDataGV(getSampleExcelData())

                        'NULL컬럼 확인하기 위하여 전역변수로 클론
                        'sampletable = dt.Clone
                        NextBTN.Enabled = True
                        ExcelSheetCBX.Enabled = True
                    End If
                End If
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
            m_fileName = String.Empty
            FileNameTBX.Text = String.Empty
            ExcelSheetCBX.Items.Clear()
            ExcelSheetCBX.Enabled = False
            MsgBox("Excel 파일을 로드하는데 실패하였습니다. 엑셀 형식이 정상적인지 확인하여 주세요.")
        Finally
            AddFileBTN.Enabled = True
            StatusLB.Text = String.Empty
        End Try
    End Sub
    Private Sub ProcessingLB(task As Task, Optional msg As String = "Processing")
        Try
            For Each c As Control In TabCtlCustom.SelectedTab.Controls
                c.Enabled = False
            Next
            For Each c As Control In TabResultCTL.Controls
                c.Enabled = False
            Next
            Dim idx As Integer = 0
            While Not task.Wait(100)
                idx = idx Mod 5
                StatusLB.Text = "Processing".PadRight("Processing".Length + idx, ".")
                idx += 1
            End While
            StatusLB.Text = String.Empty
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        Finally
            For Each c As Control In TabCtlCustom.SelectedTab.Controls
                c.Enabled = True
            Next
            For Each c As Control In TabResultCTL.Controls
                c.Enabled = True
            Next
        End Try
    End Sub
    Private Sub NextBTN_Click(sender As Object, e As EventArgs) Handles NextBTN.Click
        Try
            If TabCtlCustom.SelectedTab.Name = "TabLoadFile" Then
                If m_fileName = String.Empty Then
                    MsgBox("파일을 로드하여 주세요.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If TxtFileTypRB.Checked = True And TxtFileRTB.Text = String.Empty Then
                    MsgBox("비어 있는 파일입니다. 데이터가 있는 파일을 선택하여 주세요.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If DbConnBTN.Enabled = True Then
                    MsgBox("DB연결이 되어 있지 않습니다. 연결을 먼저 수행하여 주세요.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If TxtFileTypRB.Checked = True Then
                    initTabLoadSetting()
                    TabCtlCustom.SelectTab("TabLoadSetting")
                Else
                    For Each col As DataColumn In sampletable.Columns
                        If col.ColumnName.StartsWith("NULL") Then
                            If MsgBox("라인 별로 컬럼 갯수가 동일하지 않습니다. 계속 진행하시겟습니까?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                Exit Sub
                            Else
                                Exit For
                            End If
                        End If
                    Next
                    'Back 버튼 Enable
                    BackBTN.Enabled = True
                    TabCtlCustom.SelectTab("TabTblSetting")
                    initTabTblSetting()
                End If

            ElseIf TabCtlCustom.SelectedTab.Name = "TabLoadSetting" Then
                If m_Line_Terminator = String.Empty Then
                    MsgBox("Line Terminator가 선택되어 있지 않습니다.", MsgBoxStyle.Exclamation)
                    Exit Sub
                ElseIf m_Col_Delimiter = String.Empty Then
                    MsgBox("Column Delimiter가 선택되어 있지 않습니다.", MsgBoxStyle.Exclamation)
                    Exit Sub
                ElseIf ResultDataWB.DocumentText = String.Empty Then
                    MsgBox("Parsing된 데이터가 없습니다. Line Terminator와 Column Delimiter를 확인하여 주세요.", MsgBoxStyle.Exclamation)
                    Exit Sub
                Else
                    For Each col As DataColumn In sampletable.Columns
                        If col.ColumnName.StartsWith("NULL") Then
                            If MsgBox("라인 별로 컬럼 갯수가 동일하지 않습니다. 계속 진행하시겟습니까?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                Exit Sub
                            Else
                                Exit For
                            End If
                        End If
                    Next
                End If

                TabCtlCustom.SelectTab("TabTblSetting")
                initTabTblSetting()
            ElseIf TabCtlCustom.SelectedTab.Name = "TabTblSetting" Then
                Dim hasTargetCol As Boolean = False
                For i As Integer = 0 To ColInfoGV.Rows.Count - 1
                    If ColInfoGV.Rows(i).Cells(colName.CHECKBOX(0)).Value = True Then
                        hasTargetCol = True
                        Exit For
                    End If
                Next
                If hasTargetCol = False Then
                    MsgBox("대상 컬럼이 선택되지 않았습니다. 태이블 및 컬럼을 선택하여 주세요..", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                TabCtlCustom.SelectTab("TabColMapping")
                initTabColMapping()
                RefreshModLoadSetting()
            ElseIf TabCtlCustom.SelectedTab.Name = "TabColMapping" Then
                TabCtlCustom.SelectTab("TabOptions")
                HideResultGV()
                FetchCntCBX.SelectedIndex = 0
                ExecBTN.Visible = True
                ParallelCntCBX.SelectedIndex = 0
                ConventRB.Checked = True

                TextBox1.Text = m_fileName
                TextBox2.Text = m_target_tblNm
                TextBox3.Text = ConnInfo.SCHEMA_NAME & "@" & ConnInfo.SERVERIP & ":" & ConnInfo.PORT & "/" & ConnInfo.DBNAME
                If TxtFileTypRB.Checked = True Then
                    TextBox4.Text = "SAM FILE"
                Else
                    TextBox4.Text = "EXCEL"
                End If

                NextBTN.Enabled = False
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub BackBTN_Click(sender As Object, e As EventArgs) Handles BackBTN.Click
        Try
            If TabCtlCustom.SelectedTab.Name = "TabLoadSetting" Then
                TabCtlCustom.SelectTab("TabLoadFile")
                HideResultGV()
                BackBTN.Enabled = False
            ElseIf TabCtlCustom.SelectedTab.Name = "TabTblSetting" Then
                If TxtFileTypRB.Checked = True Then
                    TabCtlCustom.SelectTab("TabLoadSetting")
                    TblNmTBX.Text = String.Empty
                Else
                    BackBTN.Enabled = False
                    TabCtlCustom.SelectTab("TabLoadFile")
                End If

            ElseIf TabCtlCustom.SelectedTab.Name = "TabColMapping" Then
                TabCtlCustom.SelectTab("TabTblSetting")
                TabResultCTL.SelectedIndex = 0
                TableNmTBX.Text = String.Empty
                ColFuncList.Clear()
                initResultModDataGV(Nothing)
            ElseIf TabCtlCustom.SelectedTab.Name = "TabOptions" Then
                ShowResultGV()
                ExecBTN.Visible = False
                NextBTN.Enabled = True
                TabCtlCustom.SelectTab("TabColMapping")
                'ElseIf TabCtlCustom.SelectedTab.Name = "TabFinal" Then
                '    TabCtlCustom.SelectTab("TabOptions")
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub LtCrRB_CheckedChanged(sender As Object, e As EventArgs) Handles LtCrRB.CheckedChanged
        Try
            If LtCrRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub LtCrCBX_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If LtCrRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub LtUserInputRB_CheckedChanged(sender As Object, e As EventArgs) Handles LtUserInputRB.CheckedChanged
        Try
            If LtUserInputRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub LtUserInputTBX_TextChanged(sender As Object, e As EventArgs) Handles LtUserInputTBX.TextChanged
        Try
            If LtUserInputRB.Checked = True And LtUserInputTBX.Text <> String.Empty Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdSpaceRB_CheckedChanged(sender As Object, e As EventArgs) Handles CdSpaceRB.CheckedChanged
        Try
            If CdSpaceRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdCommaRB_CheckedChanged(sender As Object, e As EventArgs) Handles CdCommaRB.CheckedChanged
        Try
            If CdCommaRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdPipeRB_CheckedChanged(sender As Object, e As EventArgs) Handles CdPipeRB.CheckedChanged
        Try
            If CdPipeRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdTabRB_CheckedChanged(sender As Object, e As EventArgs) Handles CdTabRB.CheckedChanged
        Try
            If CdTabRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdUserInputRB_CheckedChanged(sender As Object, e As EventArgs) Handles CdUserInputRB.CheckedChanged
        Try
            If CdUserInputRB.Checked = True Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub CdUserInputTBX_TextChanged(sender As Object, e As EventArgs) Handles CdUserInputTBX.TextChanged
        Try
            If CdUserInputRB.Checked = True And CdUserInputTBX.Text <> String.Empty Then
                RefreshLoadSetting()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub OrgLinesCBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrgLinesCBX.SelectedIndexChanged
        Try
            RefreshLoadSetting()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub ModLinesCBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ModLinesCBX.SelectedIndexChanged
        Try
            RefreshModLoadSetting()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub TblNmTBX_TextChanged(sender As Object, e As EventArgs) Handles TblNmTBX.TextChanged
        Try
            If TblNmTBX.Text = String.Empty Then
                initTblListGV(TableListDT)
            Else
                '텍스트 박스에 입력된 테이블명을 가진 테이블을 GV에서 찾아 셀렉션 위치 변경
                Dim tableNm As String = TblNmTBX.Text

                Dim rows As DataRow() = TableListDT.Select(colName.TABLE_NAME(0) & " LIKE '%" & tableNm & "%'")

                If rows.Count = 0 Then
                    initTblListGV()
                Else
                    initTblListGV(rows.CopyToDataTable)
                End If
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub TblListGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblListGV.CellClick
        Try
            If e.RowIndex > -1 And e.ColumnIndex > -1 Then
                Dim cell As DataGridViewCell = TblListGV.Rows(e.RowIndex).Cells(colName.CHECKBOX(0))

                If cell.Value = True Then
                    cell.Value = False
                    initColInfoGV()
                Else
                    cell.Value = True
                    m_target_tblNm = TblListGV.Rows(e.RowIndex).Cells(colName.TABLE_NAME(0)).Value
                    Dim colDt As DataTable = DbConn.DbOp.getTableColInfo(DbConn.getConn, ConnInfo.SCHEMA_NAME, m_target_tblNm)
                    initColInfoGV(colDt)
                End If

                For Each row As DataGridViewRow In TblListGV.Rows
                    If row.Index <> e.RowIndex Then
                        row.Cells(colName.CHECKBOX(0)).Value = False
                    End If
                Next
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub TblListGV_Sorted(sender As Object, e As EventArgs) Handles TblListGV.Sorted
        Try
            For Each row As DataGridViewRow In TblListGV.Rows
                row.Cells(colName.CHECKBOX(0)).Value = False
            Next
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub ColInfoGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ColInfoGV.CellClick
        Try
            If e.RowIndex > -1 And e.ColumnIndex > -1 Then
                Dim cell As DataGridViewCell = ColInfoGV.Rows(e.RowIndex).Cells(colName.CHECKBOX(0))

                If cell.Value = True Then
                    If ColInfoGV.Rows(e.RowIndex).Cells(colName.NULLABLE(0)).Value.GetType Is GetType(String) Then
                        If ColInfoGV.Rows(e.RowIndex).Cells(colName.NULLABLE(0)).Value = "N" Then
                            cell.Value = True
                        Else
                            cell.Value = False
                        End If
                    Else
                        If ColInfoGV.Rows(e.RowIndex).Cells(colName.NULLABLE(0)).Value = 0 Then
                            cell.Value = True
                        Else
                            cell.Value = False
                        End If
                    End If


                Else
                    cell.Value = True
                End If
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Sub getBulkMappColList(ByRef srcColList As String(), ByRef targetColList As String())
        Try
            For i As Integer = 0 To MappingColGV.Rows.Count - 1
                Dim src_Col_Name As String = MappingColGV.Rows(i).Cells(colName.SRC_COL_NAME(0)).Value
                Dim target_Col_Name As String = MappingColGV.Rows(i).Cells(colName.COLUMN_NAME(0)).Value
                srcColList(i) = target_Col_Name
                targetColList(i) = target_Col_Name
            Next
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Private Function CreateMappingDt() As DataTable
        Dim dt As DataTable = Nothing
        Try
            dt = CMPC.getTemplateMappDt
            With MappingColGV
                dt.BeginLoadData()
                '데이터 로우 추가
                For i As Integer = 0 To .Rows.Count - 1
                    Dim dtNewRow As DataRow = dt.NewRow

                    dtNewRow(colName.SRC_COL_NAME(0)) = .Rows(i).Cells(colName.SRC_COL_NAME(0)).Value
                    dtNewRow(colName.COLUMN_NAME(0)) = .Rows(i).Cells(colName.COLUMN_NAME(0)).Value
                    dtNewRow(colName.ORDINAL_POSITION(0)) = CInt(.Rows(i).Cells(colName.ORDINAL_POSITION(0)).Value)
                    dtNewRow(colName.FUNC_NAME(0)) = CInt(.Rows(i).Cells(colName.FUNC_NAME(0)).Value)
                    dt.Rows.Add(dtNewRow)
                Next
                dt.EndLoadData()
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return dt
    End Function

    'Private Function CreateMappTable(gv As DataGridView, nParamSysTypeList As Dictionary(Of String, Object)) As DataTable
    '    Dim dt As DataTable = Nothing
    '    Try
    '        dt = New DataTable
    '        With gv
    '            For i As Integer = 0 To .Rows.Count - 1
    '                Dim target_Col_Name As String = .Rows(i).Cells(colName.COLUMN_NAME(0)).Value
    '                dt.Columns.Add(target_Col_Name, nParamSysTypeList.Item(target_Col_Name))
    '            Next
    '        End With

    '    Catch ex As Exception
    '        logger.err(ex.Message & ex.StackTrace)
    '    End Try
    '    Return dt
    'End Function
    'Private Function MappingColInfo() As ColumnMappingInfo()
    '    Dim colPos As ColumnMappingInfo() = Nothing
    '    Try
    '        colPos = New ColumnMappingInfo(MappingColGV.Rows.Count - 1) {}

    '        For i As Integer = 0 To MappingColGV.Rows.Count - 1
    '            Dim row As DataGridViewRow = MappingColGV.Rows(i)
    '            Dim srcColNm As String = row.Cells(colName.SRC_COL_NAME(0)).Value
    '            Dim targetColNm As String = row.Cells(colName.COLUMN_NAME(0)).Value
    '            ' Dim funcName As String = row.Cells(colName.FUNC_NAME(0)).Value
    '            Dim tFuncName As Integer = row.Cells(colName.FUNC_NAME(0)).Value

    '            '테스트 용도로 임시로 RTRIM 강제 적용
    '            tFuncName = LoadColFuncList.RTRIM
    '            colPos(i).func = New List(Of clsColFunc)

    '            'Select Case funcName
    '            '    Case "NONE"
    '            '        'tFuncName = LoadColFuncList.NONE
    '            '        tFuncName = LoadColFuncList.RTRIM
    '            '    Case "TRIM"
    '            '        tFuncName = LoadColFuncList.TRIM
    '            '    Case "LTRIM"
    '            '        tFuncName = LoadColFuncList.LTRIM
    '            '    Case "RTRIM"
    '            '        tFuncName = LoadColFuncList.RTRIM
    '            'End Select

    '            If srcColNm = "NULL" Then
    '                colPos(i).index = -1
    '                colPos(i).SrcColName = srcColNm
    '                colPos(i).TargetColName = targetColNm
    '                colPos(i).HasDefaultValue = True
    '                colPos(i).DefaultValue = Nothing
    '                'colPos(i).funcCmd = "NULL"
    '            ElseIf srcColNm = "USER INPUT" Then
    '                colPos(i).index = -1
    '                colPos(i).SrcColName = srcColNm
    '                colPos(i).TargetColName = targetColNm
    '                colPos(i).HasDefaultValue = True
    '            Else
    '                For j As Integer = 0 To src_colNm_List.Count - 1
    '                    Dim tStr As String = src_colNm_List(j).value
    '                    If tStr = srcColNm Then
    '                        colPos(i).index = j
    '                        colPos(i).SrcColName = srcColNm
    '                        colPos(i).TargetColName = targetColNm
    '                        colPos(i).HasDefaultValue = False

    '                        Dim funcStruc As New clsColFunc()
    '                        funcStruc.funcCmd = tFuncName
    '                        colPos(i).func.Add(funcStruc)

    '                        'Dim maskName As String = row.Cells(colName.MASKING_TYPE(0)).Value
    '                        'Dim tMaskName As Integer = 0
    '                        'Select Case maskName
    '                        '    Case MASKING_TYPE.NONE
    '                        '        tMaskName = LoadColFuncList.NONE
    '                        '    Case MASKING_TYPE.NORMAL
    '                        '        tMaskName = LoadColFuncList.MASKING_NORMAL
    '                        '        Dim funcMask As New clsColFunc()
    '                        '        funcMask.funcCmd = tMaskName
    '                        '        funcMask.FuncArgs.Add("*")
    '                        '        funcMask.FuncArgs.Add(1)
    '                        '        funcMask.FuncArgs.Add(3)
    '                        '        colPos(i).func.Add(funcMask)
    '                        '    Case MASKING_TYPE.SWITCH
    '                        '        tMaskName = LoadColFuncList.MASKING_SWITCH
    '                        '    Case MASKING_TYPE.MAPPING
    '                        '        tMaskName = LoadColFuncList.MASKING_MAPPING
    '                        'End Select

    '                        If ColFuncList.ContainsKey(i) Then
    '                            colPos(i).func.AddRange(ColFuncList(i))
    '                        End If

    '                        Exit For
    '                    End If
    '                Next
    '            End If
    '        Next
    '    Catch ex As Exception
    '        logger.err(ex.Message & ex.StackTrace)
    '    End Try
    '    Return colPos
    'End Function
    Private Function MappingColQuery(gv As DataGridView) As String
        Dim query As String = "SELECT "
        Try
            With gv
                For i As Integer = 0 To .Rows.Count - 1
                    Dim row As DataGridViewRow = .Rows(i)
                    Dim targetColName As String = row.Cells(colName.COLUMN_NAME(0)).Value
                    query = query & targetColName & ", " & vbCrLf
                Next
                query = query.TrimEnd().TrimEnd(",") & " FROM " & m_target_tblNm
            End With

        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
        Return query
    End Function

    Private Sub DbConnBTN_Click(sender As Object, e As EventArgs) Handles DbConnBTN.Click
        Try
            '소스DB 로그인창 OPEN
            With New frmMIGLogin
                .Text = "타겟 DB 로그인"
                .StartPosition = FormStartPosition.CenterParent
                .ShowDialog()

                '로그인폼이 OK 클릭되었을 시에 수행
                If (.DialogResult = Windows.Forms.DialogResult.OK) Then
                    'Connection 정보 가져오기
                    ConnInfo = .getConnInfo()

                    'Connection이 정상적으로 변수 할당받게 될 때까지 대기
                    Dim cnt As Integer = 0
                    While (.getConn Is Nothing)
                        COC.Sleep(50)
                        cnt += 1
                        If cnt > 200 Then
                            MsgBox("접속에 대한 응답이 없습니다. 다시 로그인하여 주세요.", MsgBoxStyle.Critical, "경고")
                            Exit Sub
                        End If
                    End While

                    '커넥션 OPEN상태 체크
                    If .getConn.isOpenConn = ConnectionState.Open Then
                        DbConn = .getConn
                        MsgBox("접속이 성공했습니다.", MsgBoxStyle.Information, Me.Text)

                        GrpFileType.Enabled = True
                        GrpAddFile.Enabled = True
                        GrpExcelSheet.Enabled = True
                        'TblNmTBX.Enabled = True
                        DbConnBTN.Enabled = False
                        DbEndConnBTN.Enabled = True
                        AddFileBTN.Enabled = True

                        Me.Text = "Registration - " & ConnInfo.SCHEMA_NAME & "@" & ConnInfo.SERVERIP & ":" & ConnInfo.PORT & "/" & ConnInfo.DBNAME
                    Else
                        MsgBox("접속이 실패했습니다. 다시 로그인하여 주세요.", MsgBoxStyle.Critical, "경고")
                        Me.Text = "Registration"
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub DbEndConnBTN_Click(sender As Object, e As EventArgs) Handles DbEndConnBTN.Click
        Try
            If DbConn IsNot Nothing Then
                DbConn.CloseConnection()
                DbConnBTN.Enabled = True
                DbEndConnBTN.Enabled = False
                GrpFileType.Enabled = False
                GrpAddFile.Enabled = False
                GrpExcelSheet.Enabled = False

                Me.Text = "Registration"

                initAllSetting()
                MsgBox("접속이 종료되었습니다.", MsgBoxStyle.Information, Me.Text)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub initAllSetting()
        Try
            HideResultGV()
            BackBTN.Enabled = True
            BackBTN.Enabled = False
            AddFileBTN.Enabled = False
            TblNmTBX.Text = String.Empty
            TabResultCTL.SelectedIndex = 0
            initResultModDataGV(New DataTable)
            initTabLoadFile()
            OrgTxtTlsRTB.Text = String.Empty
            TxtFileRTB.Text = String.Empty
            TabCtlCustom.SelectedIndex = 0
            m_ExcelSheetName = String.Empty
            ExcelSheetCBX.Items.Clear()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub frmLoaderReg_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            DbConnBTN.PerformClick()
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub LogMsgHandle(ByVal e As String)
        Try
            'LogMsgRTB.Invoke(New LogMsgRTB_Delegate(AddressOf LogMsg), e)
            LogMsgRTB.Text += e & vbCrLf
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub
    'Private Delegate Sub LogMsgRTB_Delegate(ByVal msg As String)
    'Private Sub LogMsg(msg As String)
    '    Try
    '        LogMsgRTB.Text += msg & vbCrLf
    '    Catch ex As Exception
    '        logger.err(ex.Message & ex.StackTrace)
    '    End Try
    'End Sub
    Private Sub ExecBTN_Click(sender As Object, e As EventArgs) Handles ExecBTN.Click
        Try
            LogMsgRTB.Text = String.Empty
            AddHandler logger.LogMsg, AddressOf LogMsgHandle
            logger.Info("Start Load Data - " & DateTime.Now, True)

            TableLayoutPanel1.Enabled = False
            Dim stopwatch As New Stopwatch
            stopwatch.Start()

            logger.Info("Processing Object Type", True)

            Dim query As String = MappingColQuery(MappingColGV)

            '소스/타겟 컬럼 리스트 가져오기
            'Dim srcColList As String() = New String(MappingColGV.Rows.Count - 1) {}
            'Dim targetColList As String() = New String(MappingColGV.Rows.Count - 1) {}
            'getBulkMappColList(srcColList, targetColList)

            '매핑 테이블
            'Dim mappDt As DataTable = DbConn.CreateMappTable(query, targetColList, False, m_target_tblNm)
            Dim mappColInfoList As ColumnMappingInfo() = CMPC.MappingColInfo(CreateMappingDt(), src_colNm_List, ColFuncList)
            Dim mode As New LoadModeInfo

            logger.Info("Start Load Options", True)

            Select Case ConnInfo.ODBCDRIVER
                Case iDAST_OdbcDriver(0, 0) 'Oracle     
                    If ConventRB.Checked = True Then
                        mode.mode = LoadMode.OracleConvention
                    Else
                        mode.mode = LoadMode.OracleBulk
                    End If
                Case iDAST_OdbcDriver(1, 0) 'PostgreSql Ansi
                    If ConventRB.Checked = True Then
                        mode.mode = LoadMode.PgConvention
                    End If
                Case iDAST_OdbcDriver(2, 0) 'PostgreSql Unicode
                    If ConventRB.Checked = True Then
                        mode.mode = LoadMode.PgConvention
                    End If
                Case iDAST_OdbcDriver(3, 0) 'MSSQL
                    If ConventRB.Checked = True Then
                        mode.mode = LoadMode.SqlConvention
                    Else
                        mode.mode = LoadMode.SqlBulk
                    End If
                Case Else
                    If ConventRB.Checked = True Then
                        mode.mode = LoadMode.TiberoConvention
                    End If
            End Select

            Dim FetchCnt As Integer = CInt(FetchCntCBX.Text)
            If ConventRB.Checked = True Then
                mode.ParallelCount = CInt(ParallelCntCBX.Text)
            Else
                mode.ParallelCount = 1
            End If

            ''TASK 초기설정
            'Dim lcts As New LimitedConcurrencyLevelTaskScheduler(mode.ParallelCount)
            'Dim tasks As New List(Of Task)()
            'Dim factory As New TaskFactory(lcts)
            'Dim cts As New CancellationTokenSource()

            logger.Info("Start Load Job", True)

            Dim ret As Integer = 0
            If TxtFileTypRB.Checked = True Then
                Dim task As Task = factory.StartNew(Sub()
                                                        ret = CLFC.LoadSamFileToDb(ConnInfo, m_fileName, FetchCnt, m_Line_Terminator, m_Col_Delimiter, 10000000, mappColInfoList, m_target_tblNm, mode)
                                                    End Sub)

                ProcessingLB(task, "Processing" & ((CLFC.ReadBlocks / CLFC.TotalBlocks) * 100).ToString)
            Else
                Dim task As Task = factory.StartNew(Sub()
                                                        ret = CLFC.LoadExcelFileToDb(ConnInfo, m_fileName, m_ExcelSheetName, FetchCnt, mappColInfoList, m_target_tblNm, mode)
                                                    End Sub)

                'While Not task.Wait(100)
                '    Label7.Text = ((CLFC.ReadBlocks / CLFC.TotalBlocks) * 100).ToString
                'End While
                'Label7.Text = "100"
                ProcessingLB(task, "Processing" & ((CLFC.ReadBlocks / CLFC.TotalBlocks) * 100).ToString)
                StatusLB.Text = "Completed"
            End If

            'CLFC.LoadSamFileToDb(ConnInfo, m_fileName, FetchCnt, m_Line_Terminator, m_Col_Delimiter, 10000000, mappColInfoList, mappDt, mode)
            stopwatch.Stop()
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds)
            logger.Info("Elapsed Time : " & stopwatch.Elapsed.TotalSeconds, True)
            If ret = LoadReturnType.NORMAL_ERROR Then
                StatusLB.Text = "ERROR!!!"
                logger.Info("Fail Load", True)
            ElseIf ret = LoadReturnType.CANCEL Then
                StatusLB.Text = "CANCEL!!!"
                logger.Info("Canceled Load", True)
            Else
                StatusLB.Text = ret.ToString & " Rows Inserted."
                logger.Info(ret.ToString & " Rows Inserted.", True)
                logger.Info("Completed Load - " & DateTime.Now, True)
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace, True)
        Finally
            TableLayoutPanel1.Enabled = True
            RemoveHandler logger.LogMsg, AddressOf LogMsgHandle
        End Try
    End Sub

    Private Sub ConventRB_CheckedChanged(sender As Object, e As EventArgs) Handles ConventRB.CheckedChanged
        Try
            If ConventRB.Checked = True Then
                Select Case ConnInfo.ODBCDRIVER
                    Case iDAST_OdbcDriver(0, 0) 'Oracle     
                        ParallelCntCBX.SelectedIndex = 0
                        ParallelCntCBX.Enabled = False
                    Case iDAST_OdbcDriver(1, 0) 'PostgreSql Ansi
                        BulkLoadRB.Enabled = False
                        ParallelCntCBX.Enabled = True
                    Case iDAST_OdbcDriver(2, 0) 'PostgreSql Unicode
                        BulkLoadRB.Enabled = False
                        ParallelCntCBX.Enabled = True
                    Case iDAST_OdbcDriver(3, 0) 'MSSQL
                        ParallelCntCBX.Enabled = True
                    Case Else
                        BulkLoadRB.Enabled = False
                        ParallelCntCBX.Enabled = True
                End Select
            Else
                ParallelCntCBX.Enabled = False
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub TxtFileTypRB_CheckedChanged(sender As Object, e As EventArgs) Handles TxtFileTypRB.CheckedChanged
        Try
            If DbConnBTN.Enabled = False Then
                FileNameTBX.Text = String.Empty
                TxtFileRTB.Text = String.Empty
                initResultDataGV()
            End If
            If TxtFileTypRB.Checked = True Then
                HideResultGV()
                GroupBox2.Visible = True
                ExcelSheetCBX.Enabled = False
                'TxtFileRTB.Text = String.Empty
            Else
                GroupBox2.Visible = False
                'initResultDataGV()
                ShowResultGV()
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub ExcelSheetCBX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExcelSheetCBX.SelectedIndexChanged
        Try
            If Not m_ExcelSheetName = ExcelSheetCBX.Text Then
                m_ExcelSheetName = ExcelSheetCBX.Text
                If sampletable IsNot Nothing Then
                    sampletable.Dispose()
                    sampletable = Nothing
                End If
                initResultDataGV(getSampleExcelData())
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
        End Try
    End Sub

    Private Sub MappingColGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MappingColGV.CellContentClick
        Try
            If e.ColumnIndex = 2 And e.RowIndex > -1 Then
                Dim query As String = MappingColQuery(MappingColGV)

                '소스/타겟 컬럼 리스트 가져오기
                Dim srcColList As String() = New String(MappingColGV.Rows.Count - 1) {}
                Dim targetColList As String() = New String(MappingColGV.Rows.Count - 1) {}
                getBulkMappColList(srcColList, targetColList)

                '매핑 테이블
                Dim mappDt As DataTable = DbConn.CreateMappTable(query, targetColList, True)
                Dim mappColInfoList As ColumnMappingInfo() = CMPC.MappingColInfo(CreateMappingDt(), src_colNm_List, ColFuncList)
                Dim columnName As String = MappingColGV.Rows(e.RowIndex).Cells(colName.COLUMN_NAME(0)).Value
                Dim colType As String = MappingColGV.Rows(e.RowIndex).Cells(colName.TYPE_NAME(0)).Value
                Dim colLength As String = MappingColGV.Rows(e.RowIndex).Cells(colName.LENGTH(0)).Value
                Dim colSno As String = MappingColGV.Rows(e.RowIndex).Cells(colName.ORDINAL_POSITION(0)).Value
                Dim masktype As String = MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_TYPE(0)).Value

                Dim funcList As clsColFunc() = Nothing

                If ColFuncList.ContainsKey(colSno) Then
                    funcList = ColFuncList(colSno)
                End If

                With New frmRegMasking(masktype, funcList, columnName, colType, colLength, sampletable, mappColInfoList, mappDt)
                    .ShowDialog()
                    If .DialogResult = Windows.Forms.DialogResult.OK Then
                        Dim colFunc As clsColFunc() = .getMaskingList()

                        If colFunc IsNot Nothing Then
                            If colFunc.Count > 0 Then
                                ColFuncList.Remove(colSno)
                                ColFuncList.Add(colSno, colFunc)
                                MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_TYPE(0)).Value = MASKING_TYPE.GetMaskingName(colFunc(0).funcCmd)
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).UseColumnTextForButtonValue = False
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).Value = "설정"
                            Else
                                ColFuncList.Remove(colSno)
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).UseColumnTextForButtonValue = False
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).Value = "미설정"
                            End If

                            RefreshModLoadSetting()
                        Else
                            If ColFuncList.ContainsKey(colSno) Then
                                ColFuncList.Remove(colSno)
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).UseColumnTextForButtonValue = False
                                DirectCast(Me.MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_BTN(0)), DataGridViewButtonCell).Value = "미설정"
                            End If
                        End If

                    End If
                End With
            End If
        Catch ex As Exception
            logger.err(ex.Message & ex.StackTrace)
            ColFuncList.Remove(e.RowIndex)
            MappingColGV.Rows(e.RowIndex).Cells(colName.MASKING_TYPE(0)).Value = LoadColFuncList.NONE
        End Try
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Try
    '        Dim stopWatch As New Stopwatch
    '        stopWatch.Start()
    '        Dim CMC As New clsMaskingCtl

    '        ' For i As Integer = 0 To 100000
    '        Dim result As String = CMC.MappingMasking(TextBox5.Text, MASKING_MAPPING_TYPE.DATE_MM_SL_DD, TextBox6.Text, CInt(TextBox7.Text))
    '        Console.WriteLine(result)
    '        'Next

    '        stopWatch.Stop()
    '        Console.WriteLine(stopWatch.Elapsed.TotalSeconds)
    '    Catch ex As Exception
    '        logger.err(ex.Message & ex.StackTrace)
    '    End Try
    'End Sub
End Class