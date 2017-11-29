Imports System.Windows.Forms
Imports System.Drawing

Public Class DataGridView
    Inherits System.Windows.Forms.DataGridView

    Public Enum DataGridViewColumnType
        ''' <summary>
        ''' xptmx
        ''' </summary>
        ''' <remarks></remarks>
        TextBox
        ComboBox
        Image
        Button

    End Enum


    Private _UseTagValueMatchColor As Boolean = False
    ''' <summary>
    ''' Tag와 Value를 비교하여 다를경우 EndEdit에서 색상 변경을 사용할지 여부 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.Category("CUSTOM")> _
    Property UseTagValueMatchColor() As Boolean
        Get
            Return _UseTagValueMatchColor
        End Get
        Set(value As Boolean)
            If Not _UseTagValueMatchColor.Equals(value) Then
                _UseTagValueMatchColor = value
            End If
        End Set
    End Property

    Private _TagValueMatchColor As Color = Color.Red
    ''' <summary>
    ''' Tag와 Value를 비교하여 다를경우 EndEdit 이벤트에서 변경할 색상 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.Category("CUSTOM")> _
    <System.ComponentModel.Description("Method :: fn_DataCellADD을 사용할것")> _
    Property TagValueMatchColor As Color
        Get
            Return _TagValueMatchColor
        End Get
        Set(value As Color)
            If Not _TagValueMatchColor.Equals(value) Then
                _TagValueMatchColor = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' Tag와 Value를 비교하여 셀의 값이 변경되었는지 확인한다 
    ''' </summary>
    ''' <param name="intRow"></param>
    ''' <param name="intCol"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_DataCellChangeCheck(ByVal intRow As Integer, ByVal intCol As Integer) As Boolean
        Dim Valuetag As Object = MyBase.Item(intCol, intRow).Tag
        Dim Value As Object = MyBase.Item(intCol, intRow).Value

        If Valuetag IsNot Value AndAlso Not Value.Equals(Valuetag) Then
            Return True
        Else
            Return False
        End If
    End Function
    ''' <summary>
    ''' Tag 와 Value를 비교하여 특정 Row가 변경사항이 있는지 확인한다. 
    ''' </summary>
    ''' <param name="intRow"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_DataRowChangeCheck(ByVal intRow As Integer) As Boolean
        For i As Integer = 0 To MyBase.ColumnCount - 1
            Dim Valuetag As Object = MyBase.Item(i, intRow).Tag
            Dim Value As Object = MyBase.Item(i, intRow).Value
            If Valuetag IsNot Value AndAlso Not Value.Equals(Valuetag) Then
                Return True
                Exit For
            End If
        Next

        Return False
    End Function
    ''' <summary>
    ''' Tag와 Value를 비교하여 값이 다른것이 있는 Row들을 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_DataCellChangeRows() As List(Of DataGridViewRow)
        Dim rtnArr As New List(Of DataGridViewRow)

        For i As Integer = 0 To MyBase.Rows.Count - 1
            For j As Integer = 0 To MyBase.Columns.Count - 1
                If fn_DataCellChangeCheck(i, j) = True Then
                    rtnArr.Add(MyBase.Rows(i))
                    Exit For
                End If
            Next
        Next

        Return rtnArr

    End Function

    Private Delegate Sub DelegateCellValueTag(ByVal intRow As Integer, ByVal intCol As Integer, ByVal Value As Object)


    ''' <summary>
    ''' Tag 와 Value에 값을 동시에 넣는다. 
    ''' </summary>
    ''' <param name="intRow"></param>
    ''' <param name="intCol"></param>
    ''' <param name="Value"></param>
    ''' <remarks></remarks>
    Public Sub fn_DataCellADD(ByVal intRow As Integer, ByVal intCol As Integer, ByVal Value As Object)
        If Me.InvokeRequired Then
            Me.Invoke(New DelegateCellValueTag(AddressOf fn_DataCellADD), intRow, intCol, Value)
        Else

            MyBase.Item(intCol, intRow).Value = Value
            MyBase.Item(intCol, intRow).Tag = Value
        End If



    End Sub
    ''' <summary>
    ''' 사용자 삭제 Row 목록 
    ''' </summary>
    ''' <remarks></remarks>
    Private _UserDelete As New List(Of DataGridViewRow)
    ''' <summary>
    ''' 사용자 삭제 Row 리스트
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub fn_UserRemoveListClear()
        _UserDelete.Clear()
    End Sub


    Public Sub fn_UserAddListClear()
        _UserAdd.Clear()
    End Sub
    ''' <summary>
    ''' 사용자 삭제 이벤트 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnUserDeletedRow(e As DataGridViewRowEventArgs)
        _UserDelete.Add(e.Row)
        MyBase.OnUserDeletedRow(e)
    End Sub

    Private _UserAdd As New List(Of DataGridViewRow)

    Protected Overrides Sub OnUserAddedRow(e As DataGridViewRowEventArgs)
        _UserAdd.Add(e.Row)
        MyBase.OnUserAddedRow(e)
    End Sub

    ''' <summary>
    ''' 그리드 초기화 시 반드시 fn_UserRemoveListClear  , sub clear 사용해서 초기화 할 것 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function fn_DataDeleteRows() As List(Of DataGridViewRow)
        Return _UserDelete
    End Function

    Public Function fn_DataAddRows() As List(Of DataGridViewRow)
        Return _UserAdd
    End Function


    ''' <summary>
    ''' TagValueMatch를 사용할 경우 자동으로 색상을 변경 컬러 색상으로 표시한다. 
    ''' </summary>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Overrides Sub OnCellEndEdit(e As DataGridViewCellEventArgs)
        MyBase.OnCellEndEdit(e)
        If _UseTagValueMatchColor = True Then
            Dim Valuetag As Object = MyBase.Item(e.ColumnIndex, e.RowIndex).Tag
            Dim Value As Object = MyBase.Item(e.ColumnIndex, e.RowIndex).Value
            If Valuetag IsNot Value AndAlso Not Value.Equals(Valuetag) Then
                MyBase.Item(e.ColumnIndex, e.RowIndex).Style.ForeColor = _TagValueMatchColor
            Else
                MyBase.Item(e.ColumnIndex, e.RowIndex).Style.ForeColor = MyBase.Columns(e.ColumnIndex).DefaultCellStyle.ForeColor
            End If
        End If
    End Sub

    '그리드 초기화
    ''' <summary>
    ''' 컬럼 추가
    ''' </summary>
    ''' <param name="cellType">DataGridViewColumnType</param>
    ''' <param name="Name">바인딩 컬럼</param>
    ''' <param name="HeaderText">컬럼헤더명</param>
    ''' <param name="Width">넓이</param>
    ''' <param name="Alignment">위치</param>
    ''' <remarks></remarks>
    Public Sub AddColumn(ByVal cellType As DataGridViewColumnType, ByVal Name As String, ByVal HeaderText As String, ByVal Width As Integer, ByVal Alignment As Windows.Forms.DataGridViewContentAlignment)

        Select Case cellType
            Case DataGridViewColumnType.TextBox
                '테스트박스 
                Dim index As Integer = Me.Columns.Add(Name, HeaderText)
                Me.Columns(index).DataPropertyName = Name
                Me.Columns(index).DefaultCellStyle.Alignment = Alignment
                Me.Columns(index).HeaderCell.Style.Alignment = Alignment
                Me.Columns(index).Width = Width
            Case DataGridViewColumnType.Button
                '버튼
                Dim dgvbtn_ As New Windows.Forms.DataGridViewButtonColumn
                dgvbtn_.HeaderText = HeaderText
                dgvbtn_.Text = HeaderText
                dgvbtn_.Width = Width
                dgvbtn_.UseColumnTextForButtonValue = True
                Me.Columns.Add(dgvbtn_)
            Case Else
        End Select
    End Sub

    '그리드 초기화
    ''' <summary>
    ''' 컬럼 추가
    ''' </summary>
    ''' <param name="cellType">DataGridViewColumnType</param>
    ''' <param name="Name">바인딩 컬럼</param>
    ''' <param name="HeaderText">컬럼헤더명</param>
    ''' <param name="Width">넓이</param>
    ''' <param name="Alignment">위치</param>
    ''' <remarks></remarks>
    Public Sub AddColumn(ByVal cellType As DataGridViewColumnType, ByVal Name As String, ByVal HeaderText As String, ByVal Width As Integer, ByVal Alignment As Windows.Forms.DataGridViewContentAlignment, ByVal hiddenCol As Boolean)

        Select Case cellType
            Case DataGridViewColumnType.TextBox
                '테스트박스 
                Dim index As Integer = Me.Columns.Add(Name, HeaderText)
                Me.Columns(index).DataPropertyName = Name
                Me.Columns(index).DefaultCellStyle.Alignment = Alignment
                Me.Columns(index).HeaderCell.Style.Alignment = Alignment
                Me.Columns(index).Width = Width
                Me.Columns(index).Visible = hiddenCol
            Case DataGridViewColumnType.Button
                '버튼
                Dim dgvbtn_ As New Windows.Forms.DataGridViewButtonColumn
                dgvbtn_.HeaderText = HeaderText
                dgvbtn_.Text = HeaderText
                dgvbtn_.Width = Width
                dgvbtn_.UseColumnTextForButtonValue = True
                Me.Columns.Add(dgvbtn_)
            Case Else
        End Select
    End Sub

    Public Sub SaveExcelData(ByVal FileName As String, ByVal dt As DataTable, ByVal OverWrite As Boolean _
                               , Optional ByVal srtLstConvert As SortedList = Nothing)
        Try
            If OverWrite = True Then
                If System.IO.File.Exists(FileName) = True Then
                    System.IO.File.Delete(FileName)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            GC.Collect()

        End Try

        If dt.TableName.ToUpper.Equals("TABLE") Then
            dt.TableName = "SHEET1"
        End If

        Dim arrQuery As New ArrayList
        Try


            Dim strQuery As String = ""
            Dim strTblNm As String = dt.TableName
            Dim Fieldinfo As String = ""
            Dim strQryCol As String = ""

            For Each dtCol As DataColumn In dt.Columns
                If Fieldinfo.Length > 0 Then
                    Fieldinfo += ","
                    strQryCol += ","
                End If
                'Fieldinfo += "[" & dtCol.ColumnName.Replace("'", "''").Replace("`", "''") & "] VARCHAR(255)"
                'strQryCol += "[" & dtCol.ColumnName.Replace("'", "''").Replace("`", "''") & "]"
                Fieldinfo += "[" & dtCol.ColumnName.Replace("`", "").Replace("'", "") & "] TEXT"
                strQryCol += "[" & dtCol.ColumnName.Replace("`", "").Replace("'", "") & "]"
            Next

            strQuery = "CREATE TABLE "
            strQuery += strTblNm
            strQuery += " (" & Fieldinfo & ")"
            arrQuery.Add(strQuery)

            'oleDbCmd = New System.Data.OleDb.OleDbCommand(strQuery, oleDb)
            'oleDbCmd.ExecuteNonQuery()
            'oleDbCmd.Dispose()



            For Each dtRow As DataRow In dt.Rows
                Dim strQryValue As String = ""
                For Each dtCol As DataColumn In dt.Columns

                    If strQryValue.Length > 0 Then
                        strQryValue += ","
                    End If

                    Dim strValue As String = dtRow(dtCol.ColumnName).ToString

                    If Not srtLstConvert Is Nothing Then
                        For Each strKey As String In srtLstConvert
                            If strValue.IndexOf(strKey) >= 0 Then
                                strValue = strValue.Replace(strKey, srtLstConvert.Item(strKey))
                            End If
                        Next
                    End If

                    strQryValue += "'" & strValue.Replace("'", "''") & "'"
                Next
                strQuery = "INSERT INTO [" & strTblNm & "$]"
                strQuery += " (" & strQryCol & ")"
                strQuery += " VALUES "
                strQuery += " (" & strQryValue & ")"
                'oleDbCmd = New System.Data.OleDb.OleDbCommand(strQuery, oleDb)
                arrQuery.Add(strQuery)
            Next





        Catch ex As Exception
            MsgBox(ex.ToString)
            GC.Collect()

        Finally

        End Try
        'Dim ConnectStrFrm_Excel_2007 As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
        '                                            "Data Source={0};" & _
        '                                            "Mode=ReadWrite|Share Deny None;" & _
        '                                            "Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';" & _
        '                                            "Persist Security Info=False" '
        Dim ConnectStrFrm_Excel97_2003 As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                                      "Data Source={0};" & _
                                                      "Mode=ReadWrite|Share Deny None;" & _
                                                      "Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';" & _
                                                      "Persist Security Info=False"
        Dim strCon As String = ""
        'Select Case VerType
        '    Case SaveType.Excel97_2003
        strCon = String.Format(ConnectStrFrm_Excel97_2003, FileName, "YES", 0)
        '    Case SaveType.Excel2007
        '       strCon = String.Format(ConnectStrFrm_Excel_2007, FileName, "YES", 0)
        'End Select

        Dim oleDb As System.Data.OleDb.OleDbConnection = Nothing
        Dim oledbTrans As System.Data.OleDb.OleDbTransaction = Nothing
        Try

            oleDb = New System.Data.OleDb.OleDbConnection(strCon)
            Dim oleDbCmd As New System.Data.OleDb.OleDbCommand

            oleDb.Open()
            oledbTrans = oleDb.BeginTransaction
            Do While oleDb.State = ConnectionState.Connecting

            Loop
            If oleDb.State = ConnectionState.Open Then
                oleDbCmd.Connection = oleDb
                oleDbCmd.Transaction = oledbTrans
                For Each strQuery As String In arrQuery
                    oleDbCmd.CommandText = strQuery
                    oleDbCmd.ExecuteNonQuery()
                Next
            End If
            oledbTrans.Commit()
        Catch ex As Exception
            If oleDb.State <> ConnectionState.Closed Then
                oledbTrans.Rollback()
            End If

            MsgBox(ex.ToString)
            GC.Collect()
            ' rtnResult = SaveResult.Err_Execute
        Finally
            If oleDb.State <> ConnectionState.Closed Then
                oleDb.Close()
                oleDb.Dispose()
            End If

        End Try


    End Sub


    Public Sub SaveExcelData(ByVal FileName As String, ByVal OverWrite As Boolean _
                              , Optional ByVal srtLstConvert As SortedList = Nothing)
        Try
            If OverWrite = True Then
                If System.IO.File.Exists(FileName) = True Then
                    System.IO.File.Delete(FileName)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            GC.Collect()

        End Try



        Dim arrQuery As New ArrayList
        Try


            Dim strQuery As String = ""
            Dim strTblNm As String = "Sheet1"
            Dim Fieldinfo As String = ""
            Dim strQryCol As String = ""

            For Each dtCol As Windows.Forms.DataGridViewColumn In Me.Columns
                If Fieldinfo.Length > 0 Then
                    Fieldinfo += ","
                    strQryCol += ","
                End If
                'Fieldinfo += "[" & dtCol.ColumnName.Replace("'", "''").Replace("`", "''") & "] VARCHAR(255)"
                'strQryCol += "[" & dtCol.ColumnName.Replace("'", "''").Replace("`", "''") & "]"
                Fieldinfo += "[" & dtCol.HeaderText.Replace("`", "").Replace("'", "") & "] TEXT"
                strQryCol += "[" & dtCol.HeaderText.Replace("`", "").Replace("'", "") & "]"
            Next

            strQuery = "CREATE TABLE "
            strQuery += strTblNm
            strQuery += " (" & Fieldinfo & ")"
            arrQuery.Add(strQuery)

            'oleDbCmd = New System.Data.OleDb.OleDbCommand(strQuery, oleDb)
            'oleDbCmd.ExecuteNonQuery()
            'oleDbCmd.Dispose()



            For Each dtRow As Windows.Forms.DataGridViewRow In Me.Rows
                Dim strQryValue As String = ""
                For Each dtCol As Windows.Forms.DataGridViewColumn In Me.Columns

                    If strQryValue.Length > 0 Then
                        strQryValue += ","
                    End If

                    Dim strValue As String = IIf(IsDBNull(dtRow.Cells(dtCol.Name).Value), "", dtRow.Cells(dtCol.Name).Value)

                    If Not srtLstConvert Is Nothing Then
                        For Each strKey As String In srtLstConvert
                            If strValue.IndexOf(strKey) >= 0 Then
                                strValue = strValue.Replace(strKey, srtLstConvert.Item(strKey))
                            End If
                        Next
                    End If

                    strQryValue += "'" & strValue.Replace("'", "''") & "'"
                Next
                strQuery = "INSERT INTO [" & strTblNm & "$]"
                strQuery += " (" & strQryCol & ")"
                strQuery += " VALUES "
                strQuery += " (" & strQryValue & ")"
                'oleDbCmd = New System.Data.OleDb.OleDbCommand(strQuery, oleDb)
                arrQuery.Add(strQuery)
            Next





        Catch ex As Exception
            MsgBox(ex.ToString)
            GC.Collect()

        Finally

        End Try
        'Dim ConnectStrFrm_Excel_2007 As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
        '                                            "Data Source={0};" & _
        '                                            "Mode=ReadWrite|Share Deny None;" & _
        '                                            "Extended Properties='Excel 12.0; HDR={1}; IMEX={2}';" & _
        '                                            "Persist Security Info=False" '
        Dim ConnectStrFrm_Excel97_2003 As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                                      "Data Source={0};" & _
                                                      "Mode=ReadWrite|Share Deny None;" & _
                                                      "Extended Properties='Excel 8.0; HDR={1}; IMEX={2}';" & _
                                                      "Persist Security Info=False"
        Dim strCon As String = ""
        'Select Case VerType
        '    Case SaveType.Excel97_2003
        strCon = String.Format(ConnectStrFrm_Excel97_2003, FileName, "YES", 0)
        '    Case SaveType.Excel2007
        '       strCon = String.Format(ConnectStrFrm_Excel_2007, FileName, "YES", 0)
        'End Select

        Dim oleDb As System.Data.OleDb.OleDbConnection = Nothing
        Dim oledbTrans As System.Data.OleDb.OleDbTransaction = Nothing
        Try

            oleDb = New System.Data.OleDb.OleDbConnection(strCon)
            Dim oleDbCmd As New System.Data.OleDb.OleDbCommand

            oleDb.Open()
            oledbTrans = oleDb.BeginTransaction
            Do While oleDb.State = ConnectionState.Connecting

            Loop
            If oleDb.State = ConnectionState.Open Then
                oleDbCmd.Connection = oleDb
                oleDbCmd.Transaction = oledbTrans
                For Each strQuery As String In arrQuery
                    oleDbCmd.CommandText = strQuery
                    oleDbCmd.ExecuteNonQuery()
                Next
            End If
            oledbTrans.Commit()
        Catch ex As Exception
            If oleDb.State <> ConnectionState.Closed Then
                oledbTrans.Rollback()
            End If

            MsgBox(ex.ToString)
            GC.Collect()
            ' rtnResult = SaveResult.Err_Execute
        Finally
            If oleDb.State <> ConnectionState.Closed Then
                oleDb.Close()
                oleDb.Dispose()
            End If

        End Try


    End Sub


    Public Function DataToString(ByVal ColumnDelimiter As String, ByVal RowDelimiter As String, Optional ByVal includeColumnHeader As Boolean = True) As String
        Dim arrResult As New ArrayList
        Dim arrData(Me.ColumnCount - 1) As String
        If includeColumnHeader = True Then

            For i As Integer = 0 To Me.ColumnCount - 1
                arrData(i) = (Me.Columns(i).HeaderText)
            Next
            arrResult.Add(String.Join(ColumnDelimiter, arrData))
        End If


        For Each tmpRow As Windows.Forms.DataGridViewRow In Me.Rows
            If tmpRow.IsNewRow = False Then
                For i As Integer = 0 To Me.ColumnCount - 1
                    arrData(i) = tmpRow.Cells(i).Value
                Next
                arrResult.Add(String.Join(ColumnDelimiter, arrData))
            End If

        Next
        Return String.Join(RowDelimiter, arrResult.ToArray())
    End Function
    ''' <summary>
    ''' 데이터를 삽입한다. Column HeaderText
    ''' </summary>
    ''' <param name="StringData"></param>
    ''' <param name="ColumnDelimiter"></param>
    ''' <param name="RowDelimiter"></param>
    ''' <param name="includeColumnHeader"></param>
    ''' <remarks></remarks>
    Public Sub StringToData(ByVal StringData As String, ByVal ColumnDelimiter As String, ByVal RowDelimiter As String, Optional ByVal includeColumnHeader As Boolean = True)
        Me.Rows.Clear()

        ' Rows로 쪼갠다. 
        Dim ArrRows() As String = Split(StringData, RowDelimiter)
        ' Column Mapping 
        Dim colMap As New SortedList


        ' Header 맞추기 
        Dim strCols As String = ArrRows(0)
        Dim tmpArr() As String = Split(strCols, ColumnDelimiter)
        For i As Integer = 0 To tmpArr.Length - 1
            If includeColumnHeader = True Then
                Dim strCol As String = tmpArr(i)
                If Me.Columns(strCol) Is Nothing Then
                    Dim intIdx As Integer = Me.Columns.Add(strCol, strCol)
                    colMap.Add(i, intIdx)
                Else
                    colMap.Add(i, Me.Columns(strCol).Index)
                End If
            Else
                If i > Me.Columns.Count - 1 Then
                    Dim intIdx As Integer = Me.Columns.Add(ChrW(65 + i), ChrW(65 + i))
                    colMap.Add(i, intIdx)
                Else
                    colMap.Add(i, i)
                End If
            End If
        Next




        For i As Integer = IIf(includeColumnHeader = True, 1, 0) To ArrRows.Length - 1
            Dim idxRow As Integer = Me.Rows.Add()
            Dim newRow As Windows.Forms.DataGridViewRow = Me.Rows(idxRow)

            Dim arrData() As String = Split(ArrRows(i), ColumnDelimiter)

            For j As Integer = 0 To arrData.Length - 1
                Dim strValue As String = arrData(j)
                If colMap.Item(j) IsNot Nothing Then
                    Dim colidx As Integer = colMap.Item(j)
                    newRow.Cells(colidx).Value = strValue
                End If
            Next
        Next

    End Sub
    ''' <summary>
    ''' 아직 준비중입니다. DataSource를 사용하는 것 처럼 Column의 DataProperty를 기준으로 삽입한다. 없는것은 삽입되지 않도록 
    ''' </summary>
    ''' <param name="StringData"></param>
    ''' <param name="ColumnDelimiter"></param>
    ''' <param name="RowDelimiter"></param>
    ''' <remarks></remarks>
    Public Sub StringToDataUsingDataProperty(ByVal StringData As String, ByVal ColumnDelimiter As String, ByVal RowDelimiter As String)

    End Sub


    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        MyBase.SetStyle(DoubleBuffered, True)
        MyBase.DoubleBuffered = True
    End Sub

    ''' <summary>
    ''' 조건에 충족하는 Row 첫번째 를 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FindFirstRow(ByVal Value As Object, ByVal ColumnIdx As Integer, Optional ByVal includeHiddenRow As Boolean = True) As DataGridViewRow
        For Each tmpRow As DataGridViewRow In Me.Rows
            If IIf(includeHiddenRow, tmpRow.Visible = True, True) Then
                If tmpRow.Cells(ColumnIdx).Value IsNot Nothing AndAlso tmpRow.Cells(ColumnIdx).Value.ToString.Equals(Value.ToString) Then
                    Return tmpRow
                End If
            End If
        Next

        Return Nothing

    End Function

    ''' <summary>
    ''' 조건에 충족하는 Row 첫번째 를 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FindFirstRow(ByVal Value As Object, Optional ByVal includeHiddenRow As Boolean = True, Optional ByVal includeHiddenColumn As Boolean = True) As DataGridViewRow
        For Each tmpRow As DataGridViewRow In Me.Rows
            If IIf(includeHiddenRow, tmpRow.Visible = True, True) Then

                For Each tmpColumn As DataGridViewColumn In Me.Columns
                    If IIf(includeHiddenColumn, tmpColumn.Visible = True, True) Then
                        If tmpRow.Cells(tmpColumn.Index).Value IsNot Nothing AndAlso tmpRow.Cells(tmpColumn.Index).Value.Equals(Value) Then
                            Return tmpRow
                        End If
                    End If
                Next
            End If
        Next

        Return Nothing

    End Function

    ''' <summary>
    ''' 조건에 충족하는 Row 첫번째 를 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FindFirstRows(ByVal Value As Object, ByVal ColumnIdx As Integer, Optional ByVal includeHiddenRow As Boolean = True) As DataGridViewRow()
        Dim rtnArrLst As New ArrayList
        For Each tmpRow As DataGridViewRow In Me.Rows
            If IIf(includeHiddenRow, tmpRow.Visible = True, True) Then
                If tmpRow.Cells(ColumnIdx).Value IsNot Nothing AndAlso tmpRow.Cells(ColumnIdx).Value.Equals(Value) Then
                    rtnArrLst.Add(tmpRow)
                End If
            End If
        Next

        Return rtnArrLst.ToArray(GetType(DataGridViewRow))

    End Function

    ''' <summary>
    ''' 조건에 충족하는 Row 첫번째 를 가져온다. 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function FindFirstRows(ByVal Value As Object, Optional ByVal includeHiddenRow As Boolean = True, Optional ByVal includeHiddenColumn As Boolean = True) As DataGridViewRow()
        Dim rtnArrLst As New ArrayList
        For Each tmpRow As DataGridViewRow In Me.Rows
            If IIf(includeHiddenRow, tmpRow.Visible = True, True) Then

                For Each tmpColumn As DataGridViewColumn In Me.Columns
                    If IIf(includeHiddenColumn, tmpColumn.Visible = True, True) Then
                        If tmpRow.Cells(tmpColumn.Index).Value IsNot Nothing AndAlso tmpRow.Cells(tmpColumn.Index).Value.Equals(Value) Then
                            rtnArrLst.Add(tmpRow)
                        End If
                    End If
                Next
            End If
        Next

        Return rtnArrLst.ToArray(GetType(DataGridViewRow))

    End Function




    'Private Delegate Function DelegateInvokeRowsAdd() As Integer


    ' ''' <summary>
    ' ''' Row를 생성한다.  
    ' ''' </summary>
    ' ''' <remarks></remarks>
    'Public Function InvokeRowsAdd() As Integer


    '    'If Me.InvokeRequired = True Then
    '    '    Return Me.Invoke(New DelegateInvokeRowsAdd(AddressOf InvokeRowsAdd))

    '    'Else
    '    Try


    '        If Me.Rows IsNot Nothing Then
    '            SyncLock Me.Rows
    '                Dim intidx As Integer = MyBase.Rows.Add()
    '                'For i As Integer = 0 To Values.Count - 1
    '                '    If i <= Me.ColumnCount - 1 Then
    '                '        MyBase.Rows(intidx).Cells(i).Value = Values(i)
    '                '        MyBase.Rows(intidx).Cells(i).Tag = Values(i)
    '                '    End If
    '                'Next
    '                Return intidx
    '            End SyncLock
    '        Else
    '            Return -1
    '        End If
    '    Catch ex As Exception
    '        Console.WriteLine(Me.Name & vbCrLf & ex.ToString)
    '    End Try

    '    'End If




    'End Function

    'Private Delegate Sub DelegateInvokeRowsClear()
    'Public Sub InvokeRowsClear()
    '    'If Me.InvokeRequired = True Then
    '    '    Me.Invoke(New DelegateInvokeRowsClear(AddressOf InvokeRowsClear))
    '    'Else
    '    Dim BefRow As Integer = Me.Rows.Count
    '    Try




    '        If Me.Rows IsNot Nothing Then
    '            SyncLock Me.Rows
    '                Me.Rows.Clear()
    '                Me.Refresh()
    '            End SyncLock
    '        End If
    '    Catch ex As Exception
    '        Console.WriteLine(Me.Name & vbCrLf & ex.ToString)
    '    End Try

    '    If BefRow > 0 AndAlso BefRow = Me.Rows.Count Then
    '        Debug.Print("No Clear ROW  : = " & Me.Rows.Count & " :" & Me.Name)
    '    End If


    '    'End If

    'End Sub



    'Private Delegate Sub DelegateInvokeRowsRemoveAt(ByVal RowIndex As Integer)
    Public Sub InvokeRowsRemoveAt(ByVal RowIndex As Integer)
        'If Me.InvokeRequired = True Then
        '    Me.Invoke(New DelegateInvokeRowsRemoveAt(AddressOf InvokeRowsRemoveAt), RowIndex)
        'Else
        SyncLock Me.Rows
            Me.Rows.RemoveAt(RowIndex)
        End SyncLock

        'End If

    End Sub



    'Private Delegate Sub DelegateInvokeRowsRemoves(ByVal ColValue As Object, ByVal ColumnIndex As Integer, ByVal EqualsRemove As Boolean)
    Public Sub invokeRowsRemoves(ByVal ColValue As Object, ByVal ColumnIndex As Integer, ByVal EqualsRemove As Boolean)
        'If Me.InvokeRequired = True Then
        '    Me.Invoke(New DelegateInvokeRowsRemoves(AddressOf invokeRowsRemoves), ColValue, ColumnIndex, EqualsRemove)
        'Else
        For i As Integer = Me.Rows.Count - 1 To 0 Step -1
            If EqualsRemove = True Then



                If Me.Rows(i).Cells(ColumnIndex).Value Is Nothing OrElse Me.Rows(i).Cells(ColumnIndex).Value.Equals(ColValue) Then
                    SyncLock Me.Rows
                        Me.Rows.RemoveAt(i)
                    End SyncLock
                End If

            Else

                If Me.Rows(i).Cells(ColumnIndex).Value Is Nothing OrElse Not Me.Rows(i).Cells(ColumnIndex).Value.Equals(ColValue) Then
                    SyncLock Me.Rows
                        Me.Rows.RemoveAt(i)
                    End SyncLock
                End If



            End If

        Next


        'End If

    End Sub


    Private Sub DataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Me.DataError
        'Console.WriteLine(Me.Rows.Count)
        'Console.WriteLine(DirectCast(sender, DataGridView).FindForm.Text & "," & sender.name & ":" & e.RowIndex & "," & e.ColumnIndex & vbCrLf & e.Context & vbCrLf & e.Exception.ToString)
        e.Cancel = True


    End Sub

    Overloads Property DataSource As Object
        Get
            Return MyBase.DataSource
        End Get
        Set(value As Object)
            Dim srtCol As DataGridViewColumn = Me.SortedColumn
            Dim srtOrd As SortOrder = Me.SortOrder

            MyBase.DataSource = value
            If srtCol IsNot Nothing Then
                Me.Sort(srtCol, IIf(srtOrd = SortOrder.Ascending, System.ComponentModel.ListSortDirection.Ascending, System.ComponentModel.ListSortDirection.Descending))
            End If

        End Set
    End Property


    Public Function GetDataTable(ByVal strTblNm As String, Optional ByVal UseDataProperty As Boolean = True) As System.Data.DataTable
        If strTblNm = "" Then
            strTblNm = Me.Name
        End If




        Dim dtTable As System.Data.DataTable = New System.Data.DataTable(strTblNm)
        For Each tmpCol As DataGridViewColumn In Me.Columns
            If tmpCol.Visible = True Then
                If UseDataProperty = True Then
                    If tmpCol.DataPropertyName IsNot Nothing AndAlso tmpCol.DataPropertyName <> String.Empty Then
                        dtTable.Columns.Add(tmpCol.DataPropertyName)
                    Else
                        dtTable.Columns.Add("COL" & tmpCol.Index + 1)

                    End If

                Else
                    dtTable.Columns.Add(tmpCol.HeaderText)
                End If

            End If
        Next

        For Each tmpRow As DataGridViewRow In Me.Rows

            Dim dtRow As Data.DataRow = dtTable.NewRow
            For Each tmpCol As DataGridViewColumn In Me.Columns
                If tmpCol.Visible = True Then
                    Dim strValue As String = IIf(IsDBNull(tmpRow.Cells(tmpCol.Index).Value), "", tmpRow.Cells(tmpCol.Index).Value)
                    'Dim treeSpacing As String = ""
                    'If tmpCol.Index = ctlFlexGrid.Tree.Column Then
                    '    If strValue.Trim = "" Then
                    '        strValue = "Null"
                    '    End If
                    '    For i As Integer = 1 To tmpRow.Node.Level
                    '        treeSpacing += "  "
                    '    Next
                    'End If





                    dtRow.Item(tmpCol.HeaderText) = strValue

                End If

            Next
            dtTable.Rows.Add(dtRow)



        Next

        Return dtTable
    End Function


    Public Sub sb_Clear()
        Me.Rows.Clear()
        fn_UserRemoveListClear()
        fn_UserAddListClear()


    End Sub
     
End Class
