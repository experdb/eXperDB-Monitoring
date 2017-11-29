Option Explicit On
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports CalendarColumn
Imports System.Reflection


Public Class ClsGridCtl

    Private COC As New ClsObjectCtl

    '===================================
    '모니터링용 Grid초기화 (Load시)
    '===================================
    Sub InitGridForMon(ByVal pGrid As DataGridView)
        With pGrid
            .ColumnHeadersVisible = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = False
            .ReadOnly = True
            .RowTemplate.Height = 18
            .BackgroundColor = Color.White
            .Font = New Font(iDAST_FontName, iDAST_FontSize)
            .DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite
            .DefaultCellStyle.SelectionForeColor = Color.DarkRed
        End With
        DoubleBuffered(pGrid, True)
    End Sub

    Public Sub DoubleBuffered(ByVal dgv As DataGridView, ByVal setting As Boolean)
        Dim dgvType As Type = dgv.[GetType]()
        Dim pi As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(dgv, setting, Nothing)
    End Sub

    '===================================
    '일반display용 Grid초기화 (Load시)
    '===================================
    Sub InitGridForPub(ByVal pGrid As DataGridView, ByVal pMode As String)
        With pGrid

            '공통
            .ColumnHeadersVisible = True
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersVisible = True
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
            '.ColumnHeadersHeight = 25
            .AllowUserToResizeColumns = True
            .AllowUserToResizeRows = True
            .RowTemplate.Height = 20
            .BackgroundColor = Color.White
            .Font = New Font(iDAST_FontName, iDAST_FontSize)
            .DefaultCellStyle.SelectionBackColor = Color.AntiqueWhite
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .EditMode = DataGridViewEditMode.EditOnEnter
            .AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.SystemColors.ButtonFace

            If pMode = "VIEW" Then
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            ElseIf pMode = "EDIT" Then
                .AllowUserToAddRows = True
                .AllowUserToDeleteRows = True
                .ReadOnly = False
            End If

        End With
        DoubleBuffered(pGrid, True)
    End Sub

    '===================================
    ' 헤더부분에 순차 번호 붙이기.
    '===================================
    Sub NumberAllRows(ByVal pGrid As DataGridView)
        Dim NumValue As Integer = 0

        With pGrid
            For i As Integer = 0 To .Rows.Count - 1
                NumValue = i + 1
                .Rows(i).HeaderCell.Value = NumValue.ToString()
            Next i
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        End With
    End Sub

    '=======================
    'Grid내에 CheckBox 생성 (파라미터 : 그리드,몇번째컬럼에,초기값)
    '=======================
    Sub PutCheckBoxInGrid(ByVal pGrid As DataGridView, ByVal pColPosion As Integer, ByVal pThreeState As Boolean, ByVal pDefaultValue As Boolean)
        With pGrid
            Dim chkBox As New DataGridViewCheckBoxColumn(pThreeState)
            chkBox.FlatStyle = FlatStyle.Standard
            chkBox.ReadOnly = False
            chkBox.Name = "CHECKBOX"
            .Columns.Insert(pColPosion, chkBox)
            For Each row In .Rows
                row.Cells(pColPosion).Value = pDefaultValue
            Next
        End With
    End Sub

    '=======================
    'Grid내에 Image 생성 (파라미터 : 그리드,몇번째컬럼에,초기값)
    '=======================
    Sub PutImageInGrid(ByVal pGrid As DataGridView, ByVal pIcon As Icon, ByVal pIconName As String, ByVal pColPosion As Integer)
        With pGrid

            Dim GridImg As New DataGridViewImageColumn()
            Dim bmpFind As Bitmap = pIcon.ToBitmap
            Dim ico As Icon = Icon.FromHandle(bmpFind.GetHicon)

            GridImg.ValuesAreIcons = True
            GridImg.Icon = ico
            GridImg.Name = pIconName

            .Columns.Insert(pColPosion, GridImg)

        End With
    End Sub

    '=======================
    ' Grid To Excel
    '=======================
    Public Sub GridToExcel(ByVal pGrid As DataGridView, ByVal pSheetName As String, ByVal pFilePath As String, Optional ByVal pExcludeHiddenColumn As Boolean = True)
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim headerList(pGrid.Columns.Count - 1) As Object
        Dim rowList(pGrid.Rows.Count - 1, pGrid.Columns.Count - 1) As Object
        Dim xlRng As Excel.Range = Nothing
        xlApp = New Excel.Application
        xlApp.Visible = False
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets(1)

        Try

            With xlWorkSheet

                'Sheet명
                .Name = pSheetName
                Dim col_cnt As Integer = 0
                '헤더 등록
                For Each col As DataGridViewColumn In pGrid.Columns
                    If pGrid.Columns(col.Index).Visible = pExcludeHiddenColumn Then
                        headerList(col_cnt) = col.HeaderText.ToString
                        COC.DoEvents()
                        col_cnt = col_cnt + 1
                    End If
                Next

                xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "1:" & COC.GetCornerName(pGrid.Columns.Count) & "1")
                xlRng.Select()
                xlRng.Value = headerList
                xlRng.CurrentRegion.Font.Bold = True
                ReleaseObject(xlRng)
                headerList = Nothing
                Dim obj As Object = Nothing
                Dim vcnt As Integer = 0
                '데이터 등록
                For i = 0 To pGrid.RowCount - 1
                    vcnt = 0
                    For j = 0 To pGrid.ColumnCount - 1
                        If pGrid.Columns(j).Visible = pExcludeHiddenColumn Then
                            If IsNumeric(COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)) And COC.checkDBNull(pGrid(j, i).Value).ToString.Length >= 11 Then
                                Console.WriteLine("NUMBER")
                                obj = "'" & COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)
                            Else
                                obj = COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType).ToString
                            End If
                            rowList(i, vcnt) = COC.checkDBNull(pGrid.Rows(i).Cells(j).Value, ClsObjectCtl.ObjectType.StrType).ToString()
                            vcnt = vcnt + 1
                            COC.DoEvents()
                        End If
                    Next
                    COC.DoEvents()
                Next
                xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "2:" & COC.GetCornerName(pGrid.Columns.Count) & pGrid.RowCount + 1)
                xlRng.Select()
                xlRng.Value = rowList
                ReleaseObject(xlRng)
                headerList = Nothing

                .SaveAs(pFilePath)

            End With
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlRng)
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
        End Try
    End Sub

    Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            End If

            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    '=======================
    ' Grid To Excel
    '=======================
    Public Sub GridToExcelV(ByVal pGrid As DataGridView, ByVal pSheetName As String, ByVal pFilePath As String)
        Dim xlApp As Object = New Object
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        'Dim i As Integer
        'Dim j As Integer
        'Dim headerList(pGrid.Columns.Count - 1) As Object
        'Dim rowList(pGrid.Rows.Count - 1, pGrid.Columns.Count - 1) As Object
        Dim xlRng As Excel.Range = Nothing

        xlApp = CreateObject("Excel.Application")
        ' xlApp = New Excel.ApplicationClass
        xlApp.Visible = False
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets(1)

        Try
            With xlWorkSheet

                'Sheet명
                .Name = pSheetName

                Dim headerList() As Object = GridToColHeaderList(pGrid)
                'Dim col_cnt As Integer = 0
                ''헤더 등록
                'For Each col As DataGridViewColumn In pGrid.Columns
                '    If pGrid.Columns(col.Index).Visible = True And col.HeaderText.ToString <> "선택" Then
                '        headerList(col_cnt) = col.HeaderText.ToString
                '        COC.DoEvents()
                '        col_cnt = col_cnt + 1
                '    End If

                'Next

                xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "1:" & COC.GetCornerName(headerList.Length) & "1")
                xlRng.Select()
                xlRng.Value = headerList
                COC.xlSelectBgColor(xlApp, String.Empty, True, Excel.Constants.xlCenter, False, 1, True, 3)
                xlRng.CurrentRegion.Font.Bold = True
                ReleaseObject(xlRng)
                'headerList = Nothing

                'Dim vcnt As Integer = 0
                ''데이터 등록
                'Dim obj As Object = Nothing
                'For i = 0 To pGrid.RowCount - 1
                '    vcnt = 0
                '    For j = 0 To pGrid.ColumnCount - 1
                '        If pGrid.Columns(j).Visible = True And pGrid.Columns(j).HeaderText.ToString <> "선택" Then
                '            If IsNumeric(COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)) And COC.checkDBNull(pGrid(j, i).Value).ToString.Length >= 11 Then
                '                Console.WriteLine("NUMBER")
                '                obj = "'" & COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)
                '            Else
                '                obj = COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType).ToString
                '            End If
                '            'rowList(i, vcnt) = COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType).ToString
                '            rowList(i, vcnt) = obj
                '            vcnt = vcnt + 1
                '            COC.DoEvents()
                '        End If
                '    Next
                '    COC.DoEvents()
                'Next
                Dim rowList(,) As Object = GridToRowList(pGrid)
                xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "2:" & COC.GetCornerName(headerList.Length) & pGrid.RowCount + 1)
                xlRng.Select()
                xlRng.Value = rowList

                If rowList.Length > 0 Then
                    COC.xlSelectBgColor(xlApp, String.Empty, False, Excel.Constants.xlLeft, False)
                    For k As Integer = 0 To headerList.Length - 1
                        If IsNumeric(COC.checkDBNull(rowList(0, k))) Then
                            xlRng = xlWorkSheet.Range(COC.GetCornerName(k + 1) & "2:" & COC.GetCornerName(k + 1) & pGrid.Rows.Count + 1)
                            xlRng.Select()
                            COC.xlSelectBgColor(xlApp, String.Empty, False, Excel.Constants.xlRight, False)
                            ReleaseObject(xlRng)
                        End If
                    Next
                End If

                ReleaseObject(xlRng)
                headerList = Nothing
                xlApp.DisplayAlerts = False
                .SaveAs(pFilePath)

            End With
        Catch e As Exception
        Finally
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlRng)
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
        End Try

    End Sub

    '=======================
    ' Grid To Excel
    '=======================
    Public Sub GridListToExcelV(ByVal pObjList As ArrayList, ByVal pSheetName As ArrayList, ByVal pFilePath As String)
        Dim xlApp As Object = New Object
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim misValue As Object = System.Reflection.Missing.Value


        Dim xlRng As Excel.Range = Nothing

        xlApp = CreateObject("Excel.Application")
        ' xlApp = New Excel.ApplicationClass
        xlApp.Visible = False

        Try
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            For i As Integer = pObjList.Count - 1 To 0 Step -1
                xlWorkSheet = xlWorkBook.Sheets.Add()

                With xlWorkSheet
                    If pSheetName.Count >= i Then
                        .Name = pSheetName(i).ToString
                    Else
                        .Name = i
                    End If

                    Dim headerList() As Object = GridToColHeaderList(pObjList(i))
                    xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "1:" & COC.GetCornerName(headerList.Length) & "1")
                    xlRng.Select()
                    xlRng.Value = headerList
                    COC.xlSelectBgColor(xlApp, String.Empty, True, Excel.Constants.xlCenter, False, 1, True, 3)
                    xlRng.CurrentRegion.Font.Bold = True
                    ReleaseObject(xlRng)

                    Dim rowList(,) As Object = GridToRowList(pObjList(i))

                    xlRng = xlWorkSheet.Range(COC.GetCornerName(1) & "2:" & COC.GetCornerName(headerList.Length) & pObjList(i).rows.count + 1)
                    xlRng.Select()
                    xlRng.Value = rowList

                    If rowList.Length > 0 Then
                        COC.xlSelectBgColor(xlApp, String.Empty, False, Excel.Constants.xlLeft, False)
                        For k As Integer = 0 To headerList.Length - 1
                            If IsNumeric(COC.checkDBNull(rowList(0, k))) Then
                                xlRng = xlWorkSheet.Range(COC.GetCornerName(k + 1) & "2:" & COC.GetCornerName(k + 1) & pObjList(i).rows.count + 1)
                                xlRng.Select()
                                COC.xlSelectBgColor(xlApp, String.Empty, False, Excel.Constants.xlRight, False)
                                ReleaseObject(xlRng)
                            End If
                        Next
                    End If

                    ReleaseObject(xlRng)
                    headerList = Nothing
                    rowList = Nothing
                    xlApp.DisplayAlerts = False
                End With
            Next

            xlWorkSheet.SaveAs(pFilePath)
        Catch e As Exception
            Console.WriteLine(e.Message)
        Finally
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlRng)
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
        End Try

    End Sub

    Public Function GridToColHeaderList(ByVal pGrid As DataGridView) As Object()
        Try
            Dim col_cnt As Integer = 0
            For Each col As DataGridViewColumn In pGrid.Columns
                If pGrid.Columns(col.Index).Visible = True And col.HeaderText.ToString <> "선택" Then
                    col_cnt = col_cnt + 1
                End If
            Next
            Dim headerList(col_cnt - 1) As Object
            col_cnt = 0
            For Each col As DataGridViewColumn In pGrid.Columns
                If pGrid.Columns(col.Index).Visible = True And col.HeaderText.ToString <> "선택" Then
                    headerList(col_cnt) = col.HeaderText.ToString
                    COC.DoEvents()
                    col_cnt = col_cnt + 1
                End If
            Next
            Return headerList
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GridToRowList(ByVal pGrid As DataGridView) As Object(,)
        Try
            Dim col_cnt As Integer = 0
            For Each col As DataGridViewColumn In pGrid.Columns
                If pGrid.Columns(col.Index).Visible = True And col.HeaderText.ToString <> "선택" Then
                    col_cnt = col_cnt + 1
                End If
            Next

            Dim rowList(pGrid.Rows.Count - 1, col_cnt - 1) As Object
            Dim vcnt As Integer = 0
            '데이터 등록
            Dim obj As Object = Nothing
            For i = 0 To pGrid.RowCount - 1
                vcnt = 0
                For j = 0 To pGrid.ColumnCount - 1
                    If pGrid.Columns(j).Visible = True And pGrid.Columns(j).HeaderText.ToString <> "선택" Then
                        If IsNumeric(COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)) And COC.checkDBNull(pGrid(j, i).Value).ToString.Length >= 11 Then
                            obj = "'" & COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType)
                        Else
                            If pGrid(j, i).GetType Is GetType(DataGridViewComboBoxCell) Then
                                Dim gc As DataGridViewComboBoxCell = pGrid.Rows(i).Cells(j)
                                Dim arrList As ArrayList = gc.DataSource
                                Dim text As String = String.Empty
                                For Each s As ClsValueDescription In arrList
                                    If s.Value = pGrid(j, i).Value Then
                                        text = s.Description
                                        Exit For
                                    End If
                                Next
                                obj = COC.checkDBNull(text, ClsObjectCtl.ObjectType.StrType).ToString
                            Else
                                obj = COC.checkDBNull(pGrid(j, i).Value, ClsObjectCtl.ObjectType.StrType).ToString
                            End If

                        End If
                        rowList(i, vcnt) = obj
                        vcnt = vcnt + 1
                        COC.DoEvents()
                    End If
                Next
                COC.DoEvents()
            Next
            Return rowList
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GridToColHeaderList(ByVal pGrid As DataTable) As Object()
        Try
            Dim headerList(pGrid.Columns.Count - 1) As Object
            Dim col_cnt As Integer = 0
            For Each col As DataColumn In pGrid.Columns
                If col.ColumnName <> "선택" Then
                    headerList(col_cnt) = col.ColumnName.ToString
                    COC.DoEvents()
                    col_cnt = col_cnt + 1
                End If
            Next
            Return headerList
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function GridToRowList(ByVal pGrid As DataTable) As Object(,)
        Try
            Dim rowList(pGrid.Rows.Count - 1, pGrid.Columns.Count - 1) As Object
            Dim vcnt As Integer = 0
            '데이터 등록
            Dim obj As Object = Nothing
            For i = 0 To pGrid.Rows.Count - 1
                vcnt = 0
                For j = 0 To pGrid.Columns.Count - 1
                    If pGrid.Columns(j).ColumnName.ToString <> "선택" Then
                        If IsNumeric(COC.checkDBNull(pGrid.Rows(i).Item(j), ClsObjectCtl.ObjectType.StrType)) And COC.checkDBNull(pGrid.Rows(i).Item(j)).ToString.Length >= 11 Then
                            obj = "'" & COC.checkDBNull(pGrid.Rows(i).Item(j), ClsObjectCtl.ObjectType.StrType)
                        Else
                            obj = COC.checkDBNull(pGrid.Rows(i).Item(j), ClsObjectCtl.ObjectType.StrType).ToString
                        End If
                        rowList(i, vcnt) = obj
                        vcnt = vcnt + 1
                        COC.DoEvents()
                    End If
                Next
                COC.DoEvents()
            Next
            Return rowList
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function
    '=======================
    ' GridList To Excel
    '=======================
    Public Sub GridListToExcel(ByVal pGridList() As DataGridView, ByVal pSheetName As String, ByVal pFilePath As String, Optional ByVal pExcludeHiddenColumn As Boolean = True)
    End Sub

    '=======================
    ' GridList To Excel
    '=======================
    Public Function ExcelToDataTable(ByVal pFileName As String, Optional ByVal limitRowCnt As Integer = 0) As DataSet
        Dim ds As New DataSet
        Dim xlApp = New Excel.Application
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlRng As Excel.Range = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Try
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(pFileName)

            '전환DB정보 로드
            ReleaseObject(xlWorkSheet)
            For i As Integer = 1 To xlApp.Worksheets.Count
                xlWorkSheet = xlApp.Worksheets(i)
                xlWorkSheet.Activate()
                Dim xlStartRow As Integer = 1

                Dim dt As New DataTable(xlWorkSheet.Name)
                Dim idx As Integer = 1
                While True
                    Dim value As String = xlApp.Cells(xlStartRow, idx).value
                    If value Is Nothing Then
                        Exit While
                    End If

                    dt.Columns.Add(value)
                    idx += 1
                End While

                If dt.Columns.Count = 0 Then
                    If ds.Tables.Count = 0 Or ds.Tables.Count <> xlApp.Worksheets.Count Then
                        MsgBox("엑셀 첫 번째 로우의 첫 번째 컬럼이 비어있습니다. 엑셀형식을 확인하여 주세요.", MsgBoxStyle.Critical, "경고")
                        Return Nothing
                    End If
                    Exit For
                End If

                xlStartRow += 1

                Dim arrList As New ArrayList
                While True
                    xlRng = xlApp.Range("A" & xlStartRow & ":" & COC.GetCornerName(dt.Columns.Count) & xlStartRow)
                    With xlRng
                        .Select()
                        Dim migList As Object(,)
                        If IsArray(.Value) Then
                            migList = .Value
                        Else
                            migList = New Object(0, 0) {}
                            migList(0, 0) = .Value
                        End If


                        Dim eof As Integer = 0
                        For k As Integer = 1 To migList.GetLength(1)
                            If migList.GetLength(1) = 1 Then
                                eof += 1
                            ElseIf migList(1, k) Is Nothing Then
                                eof += 1
                            End If

                        Next

                        If eof = migList.GetLength(1) Then
                            ReleaseObject(xlRng)
                            Exit While
                        End If

                        If xlStartRow = 2 Then
                            For k As Integer = 1 To dt.Columns.Count
                                Dim type As Type
                                Dim value As Object = migList(1, k)
                                If value Is Nothing Then
                                    type = GetType(String)
                                ElseIf IsNumeric(value) Then
                                    If value.ToString.Length > 10 Then
                                        type = GetType(String)
                                    Else
                                        type = GetType(Integer)
                                    End If
                                ElseIf IsDate(value) Then
                                    type = GetType(Date)
                                Else
                                    type = GetType(String)
                                End If
                                dt.Columns(k - 1).DataType = type
                            Next
                        End If

                        Dim tArrList As New ArrayList
                        For j As Integer = 1 To migList.GetLength(1)
                            tArrList.Add(migList(1, j))
                        Next
                        'arrList.Add(tArrList.ToArray)
                        dt.Rows.Add(tArrList.ToArray)
                        xlStartRow += 1

                        tArrList.Clear()
                        tArrList = Nothing
                        migList = Nothing

                        If xlStartRow > limitRowCnt And limitRowCnt <> 0 Then
                            ReleaseObject(xlRng)
                            Exit While
                        End If
                    End With
                    ReleaseObject(xlRng)
                End While

                ds.Tables.Add(dt)
                ReleaseObject(xlWorkSheet)
            Next

            Return ds
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        Finally
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlRng)
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
        End Try
    End Function

    '=======================
    ' GridList To Excel(특정 Sheet를 Datatable로. 첫번째 로우 컬럼정보 유무)
    '=======================
    Public Function ExcelToDataTable(ByVal pFileName As String, ByVal sheetIdx As Integer, ByVal colArr As ArrayList) As DataTable
        Dim xlApp = New Excel.Application
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlRng As Excel.Range = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Try
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(pFileName)

            '전환DB정보 로드
            xlWorkSheet = xlApp.Worksheets(sheetIdx)
            xlWorkSheet.Activate()
            Dim xlStartRow As Integer = 1

            Dim dt As New DataTable(xlWorkSheet.Name)
            Dim idx As Integer = 1

            If colArr Is Nothing Then
                While True
                    Dim cell As Excel.Range = xlApp.Cells(xlStartRow, idx)
                    Dim value As String = cell.Value
                    If value Is Nothing Then
                        Exit While
                    End If

                    dt.Columns.Add(value)

                    ReleaseObject(cell)
                    idx += 1
                End While
                xlStartRow += 1
            ElseIf colArr.Count = 0 Then
                MsgBox("컬럼 정보가 없습니다.", MsgBoxStyle.Critical)
                Return Nothing
            Else
                For Each colNm As String In colArr
                    dt.Columns.Add(colNm)
                Next
            End If

            Dim arrList As New ArrayList
            While True
                xlRng = xlApp.Range("A" & xlStartRow & ":" & COC.GetCornerName(dt.Columns.Count) & xlStartRow)
                With xlRng
                    .Select()
                    Dim migList As Object(,) = .Value

                    Dim eof As Integer = 0
                    For k As Integer = 1 To migList.GetLength(1)
                        If migList(1, k) Is Nothing Then
                            eof += 1
                        End If
                    Next

                    If eof = migList.GetLength(1) Then
                        Exit While
                    End If

                    If xlStartRow = 2 Then
                        For k As Integer = 1 To dt.Columns.Count
                            Dim type As Type
                            Dim value As Object = migList(1, k)
                            If value Is Nothing Then
                                type = GetType(String)
                            ElseIf IsNumeric(value) Then
                                type = GetType(Integer)
                            ElseIf IsDate(value) Then
                                type = GetType(Date)
                            Else
                                type = GetType(String)
                            End If
                            dt.Columns(k - 1).DataType = type
                        Next
                    End If

                    Dim tArrList As New ArrayList
                    For j As Integer = 1 To migList.GetLength(1)
                        tArrList.Add(migList(1, j))
                    Next

                    dt.Rows.Add(tArrList.ToArray)
                    xlStartRow += 1

                    tArrList.Clear()
                    tArrList = Nothing
                    migList = Nothing
                End With
                ReleaseObject(xlRng)
            End While

            ReleaseObject(xlWorkSheet)

            Return dt
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        Finally
            xlWorkBook.Close()
            xlApp.Quit()
            ReleaseObject(xlRng)
            ReleaseObject(xlApp)
            ReleaseObject(xlWorkBook)
            ReleaseObject(xlWorkSheet)
        End Try
    End Function

    '======================================
    'CurrentRow 전체 백그라운드 색상 변경
    '======================================
    Sub ChangeRowBackgroundColor(ByVal pGrid As DataGridView, ByVal pCurrentRow As Integer, ByVal pColor As Color)
        With pGrid
            For i As Integer = 0 To .ColumnCount - 1
                .Rows(pCurrentRow).Cells(i).Style.BackColor = pColor
            Next i
        End With
    End Sub

    '======================================
    'CurrentRow 전체 ForCore 색상 변경
    '======================================
    Sub ChangeRowForeColor(ByVal pGrid As DataGridView, ByVal pCurrentRow As Integer, ByVal pColor As Color)
        With pGrid
            For i As Integer = 0 To .ColumnCount - 1
                .Rows(pCurrentRow).Cells(i).Style.ForeColor = pColor
            Next i
        End With
    End Sub


    '======================================
    'CurrentRow 전체 글씨 색상 변경
    '======================================
    Enum TargetGroundType
        ForeColorType = 0
        BackgroundColorType = 1
    End Enum
    Sub ChangeOraTraceInfoColor(ByVal pGrid As DataGridView, ByVal pCurrentRow As Integer, _
                                ByVal pBuff As String, _
                                Optional ByVal pTargetGroundType As TargetGroundType = TargetGroundType.ForeColorType)
        If UCase(Trim(pBuff).Replace(" ", "_")) Like "*TABLE_ACCESS_FULL*" Or UCase(Trim(pBuff).Replace(" ", "_")) Like "*INDEX_FULL_SCAN*" Or _
               UCase(Trim(pBuff).Replace(" ", "_")) Like "*FIXED_TABLE_FULL*" Or UCase(Trim(pBuff).Replace(" ", "_")) Like "*JOIN_CARTESIAN*" Then
            If pTargetGroundType = TargetGroundType.BackgroundColorType Then
                ChangeRowBackgroundColor(pGrid, pCurrentRow, Color.Brown)
                ChangeRowForeColor(pGrid, pCurrentRow, Color.Yellow)
            ElseIf pTargetGroundType = TargetGroundType.ForeColorType Then
                ChangeRowForeColor(pGrid, pCurrentRow, Color.Red)
            End If
        End If
    End Sub

    '**************************************************************
    'Check 버튼 컨트롤 (checked global변수, 그리드명, check위치)
    '**************************************************************
    Public Function CheckedCtl(ByVal pCheckedValue As Boolean, _
                          ByVal pGrid As DataGridView, _
                          ByVal pCheckedPos As Integer) As Boolean
        pGrid.EndEdit()
        If pCheckedValue = False Then
            For Each row As DataGridViewRow In pGrid.SelectedRows
                If row.Cells(pCheckedPos).ReadOnly = False AndAlso row.Visible = True Then
                    row.Cells(pCheckedPos).Value = True
                End If
            Next
            pGrid.EndEdit()
            Return True
        Else
            For Each row As DataGridViewRow In pGrid.SelectedRows
                If row.Cells(pCheckedPos).ReadOnly = False AndAlso row.Visible = True Then
                    row.Cells(pCheckedPos).Value = False
                End If
            Next
            pGrid.EndEdit()
            Return False
        End If

    End Function

    '**************************************************************
    'Check 버튼 컨트롤 (checked global변수, 그리드명, check위치)
    '**************************************************************
    Public Function CheckedGrpCtl(ByVal pCheckedValue As Boolean, _
                          ByVal pGrid As DataGridView, _
                          ByVal pCheckedPos As Integer, _
                          ByVal pFilterColPos As Integer) As Boolean
        Try
            pGrid.EndEdit()
            Dim value As String = pGrid.CurrentRow.Cells(pFilterColPos).Value
            If pCheckedValue = False Then
                For Each row As DataGridViewRow In pGrid.Rows
                    If row.Cells(pCheckedPos).ReadOnly = False And row.Cells(pFilterColPos).Value = value Then
                        row.Cells(pCheckedPos).Value = True
                    End If
                Next
                pGrid.EndEdit()
                Return True
            Else
                For Each row As DataGridViewRow In pGrid.Rows
                    If row.Cells(pCheckedPos).ReadOnly = False And row.Cells(pFilterColPos).Value = value Then
                        row.Cells(pCheckedPos).Value = False
                    End If
                Next
                pGrid.EndEdit()
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    '**************************************************************
    '그리드에 다이나믹하게 ComboxColumn 설정
    '**************************************************************
    Public Function RetGvComboBoxColumn(ByVal pName As String, ByVal pInitValue As ArrayList) As DataGridViewComboBoxColumn
        Dim cc As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
            .DataSource = pInitValue
            .DisplayMember = "Description"
            .ValueMember = "Value"
            .FlatStyle = FlatStyle.Flat
        End With
        Return cc
    End Function
    Public Function RetGvComboBoxColumn(ByVal pName As String, ByVal pInitValue As ClsValueDescription()) As DataGridViewComboBoxColumn
        Dim cc As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
            .DataSource = pInitValue
            .DisplayMember = "Description"
            .ValueMember = "Value"
            .FlatStyle = FlatStyle.Flat
        End With
        Return cc
    End Function
    Public Function RetGvComboBoxColumn(ByVal pName As String, ByVal dt As DataTable) As DataGridViewComboBoxColumn
        Dim cc As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
            .DataSource = dt
            .DisplayMember = pName
            .ValueMember = pName
            .FlatStyle = FlatStyle.Flat
        End With
        Return cc
    End Function
    '**************************************************************
    '그리드에 다이나믹하게 ButtonboxColumn 설정
    '**************************************************************
    Public Function RetGvButtonboxColumn(ByVal pName As String, ByVal pButtonText As String) As DataGridViewButtonColumn
        Dim cc As DataGridViewButtonColumn = New DataGridViewButtonColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
            .Text = pButtonText
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .UseColumnTextForButtonValue = True
            .FlatStyle = FlatStyle.Standard
            .CellTemplate.Style.BackColor = Color.Honeydew
        End With
        Return cc
    End Function

    '**************************************************************
    '그리드에 다이나믹하게 TimePickerColumn 설정
    '**************************************************************
    Public Function RetGvDateTimePickerColumn(ByVal pName As String) As DataGridViewCalendarColumn
        Dim cc As DataGridViewCalendarColumn = New DataGridViewCalendarColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
            .DefaultCellStyle.Format = "yyyy-MM-dd"
        End With
        Return cc
    End Function


    '**************************************************************
    '그리드에 다이나믹하게 TextboxColumn 설정
    '**************************************************************
    Public Function RetGvTextBoxColumn(ByVal pName As String, Optional ByVal pMaxInputLength As Integer = 255) As DataGridViewTextBoxColumn
        Dim cc As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        With cc
            .Name = pName
            .MaxInputLength = pMaxInputLength
            .DataPropertyName = pName
        End With
        Return cc
    End Function

    '**************************************************************
    '그리드에 다이나믹하게 MaskedTextBoxColumn 설정
    '**************************************************************
    Public Function RetGvMaskedTextBoxColumn(ByVal pName As String, Optional ByVal pMaxInputLength As Integer = 255) As DataGridViewMaskedEditColumn
        Dim cc As DataGridViewMaskedEditColumn = New DataGridViewMaskedEditColumn
        With cc
            Dim tStr As String = String.Empty
            tStr = tStr.PadRight(pMaxInputLength, "*")
            .Name = pName
            .Mask = tStr
            .ValidatingType = GetType(String)
            .DataPropertyName = pName
        End With
        Return cc
    End Function

    '**************************************************************
    '그리드에 다이나믹하게 CheckboxColumn 설정
    '**************************************************************
    Public Function RetGvCheckBoxColumn(ByVal pName As String, ByVal pThreeState As Boolean)
        Dim cc As New DataGridViewCheckBoxColumn
        With cc
            .Name = pName
            .ReadOnly = False
            .FlatStyle = FlatStyle.Standard
            .ThreeState = pThreeState
            .TrueValue = True
            .FalseValue = False
            .DataPropertyName = pName
        End With
        Return cc
    End Function

    '**************************************************************
    '특정 컬럼의 데이터를 search하여 해당 row 번호 리턴
    '**************************************************************
    Public Function SearchSqlId(ByVal pGrid As DataGridView, _
                                ByVal pStartRows As Integer, _
                                ByVal pSearchCellIndex As Integer, _
                                ByVal pValue As String) As Integer
        On Error Resume Next
        With pGrid
            For i As Integer = pStartRows To .Rows.Count - 1
                Dim TargetValue As String = .Rows(i).Cells(pSearchCellIndex).Value
                If TargetValue Like "*" & pValue & "*" Then
                    Return i
                End If
            Next i
        End With
    End Function

    '**************************************************************
    '특정 컬럼의 데이터를 search하여 해당 row 번호 리턴(단 조건은 Boolen타입
    '**************************************************************
    Public Sub DeleteRowForCheck(ByVal pDataGridView As DataGridView, ByVal pCellNumber As Integer, ByVal pCellValue As Boolean)

        With pDataGridView
            pDataGridView.EndEdit()

            '삭제할건이 있는지 확인
            Dim DelCnt As Integer = 0
            For Each row As DataGridViewRow In .Rows
                If (row.Cells(0).Value = True) Then
                    DelCnt = DelCnt + 1
                End If
            Next

            If DelCnt = 0 Then
                MsgBox("삭제할 대상이 선택되어 있지 않습니다.", MsgBoxStyle.Information, "정보")
            Else
                '실질적으로 데이터 역순으로 삭제
                Dim cnt As Integer = .Rows.Count - 1
                For i As Integer = cnt To 0 Step -1
                    Dim row As DataGridViewRow = .Rows(i)
                    If (row.Cells(pCellNumber).Value = pCellValue) Then
                        .Rows.Remove(row)
                    End If
                Next

            End If
        End With

    End Sub

    '**************************************************************
    '그리드에 다이나믹하게 ComboxColumn 설정
    '**************************************************************
    Public Function RetGvImageColumn(ByVal pName As String) As DataGridViewImageColumn
        Dim cc As DataGridViewImageColumn = New DataGridViewImageColumn
        With cc
            .Name = pName
            .DataPropertyName = pName
        End With
        Return cc
    End Function

    '**************************************************************
    '데이터그리으를 DATATABLE로 변환
    '**************************************************************
    Public Function ConvertGvToDt(ByRef gv As DataGridView, Optional startIdx As Integer = 0) As DataTable
        Try
            Dim dt As New DataTable
            With gv
                For k As Integer = startIdx To .Columns.Count - 1
                    dt.Columns.Add(.Columns(k).Name)
                Next
                dt.BeginLoadData()
                '데이터 로우 추가
                For i As Integer = 0 To .Rows.Count - 1
                    Dim dtNewRow As DataRow = dt.NewRow
                    For j As Integer = 0 To dt.Columns.Count - 1
                        dtNewRow(j) = gv.Rows(i).Cells(j).Value
                    Next
                    dt.Rows.Add(dtNewRow)
                Next
                dt.EndLoadData()
                Return dt
            End With
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function ResizeDescriptionArea(ByRef grid As PropertyGrid, nNumLines As Integer) As Boolean
        Try
            Dim pi As System.Reflection.PropertyInfo = grid.GetType().GetProperty("Controls")
            Dim cc As Control.ControlCollection = pi.GetValue(grid, Nothing)

            For Each c As Control In cc
                Dim ct As Type = c.GetType
                Dim sName As String = ct.Name

                If sName = "DocComment" Then
                    pi = ct.GetProperty("Lines")
                    pi.SetValue(c, nNumLines, Nothing)

                    Dim fi As System.Reflection.FieldInfo = ct.BaseType.GetField("userSized", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.GetField)
                    fi.SetValue(c, True)
                End If
            Next

            Return True
        Catch ex As Exception

            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    '데이터 그리드 셀 마우스칼라 변경
    Public Sub ChangeColor_MouseMove(ByVal pDGV As DataGridView, e As MouseEventArgs)
        With pDGV
            Dim normalFont = New Font(.DefaultCellStyle.Font, FontStyle.Regular)
            Dim hit As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
            If hit.Type = DataGridViewHitTestType.Cell Then
                If .Rows(hit.RowIndex).Cells(hit.ColumnIndex).FormattedValue.ToString().Trim().Length > 0 Then
                    .Rows(hit.RowIndex).DefaultCellStyle.Font = New Font(.DefaultCellStyle.Font, FontStyle.Bold)
                    .Rows(hit.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke
                Else
                    .Rows(hit.RowIndex).DefaultCellStyle.BackColor = Color.White
                    .Rows(hit.RowIndex).DefaultCellStyle.Font = normalFont
                End If
            End If
        End With
    End Sub

    '데이터 그리드 셀 마우스칼라 원복
    Public Sub ChangeColor_CellMouseLeave(ByVal pDGV As DataGridView, e As DataGridViewCellEventArgs)
        With pDGV
            Dim normalFont = New Font(.DefaultCellStyle.Font, FontStyle.Regular)
            If (e.ColumnIndex > -1) Then
                If e.RowIndex > -1 Then
                    If .Rows(e.RowIndex).Cells(e.ColumnIndex).FormattedValue.ToString().Trim().Length > 0 Then
                        .Rows(e.RowIndex).DefaultCellStyle.Font = normalFont
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                    Else
                        .Rows(e.RowIndex).DefaultCellStyle.Font = normalFont
                        .Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                    End If
                End If
            End If
        End With
    End Sub
End Class




