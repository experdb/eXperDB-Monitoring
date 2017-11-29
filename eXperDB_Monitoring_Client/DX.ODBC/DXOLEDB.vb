Public Class DXOLEDB

    Public Shared Sub SaveExcelData(ByVal FileName As String, ByVal dtSet As DataSet, ByVal Overwrite As Boolean, Optional ByVal srtLstConvert As SortedList = Nothing)
        Try
            If Overwrite = True Then
                If System.IO.File.Exists(FileName) = True Then
                    System.IO.File.Delete(FileName)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            GC.Collect()

        End Try
        Dim HashTbl As New Hashtable
        For i As Integer = 0 To dtSet.Tables.Count - 1
            Dim tmpTable As DataTable = dtSet.Tables(i)
            If HashTbl.Item(tmpTable.TableName) Is Nothing Then
                HashTbl.Add(tmpTable.TableName, "")
            Else
                dtSet.Tables(i).TableName = "Sheet" & i + 1
            End If
        Next

        Dim arrQuery As New ArrayList
        Try

            For Each tmpTable As DataTable In dtSet.Tables

                Dim strQuery As String = ""
                Dim strTblNm As String = tmpTable.TableName
                Dim Fieldinfo As String = ""
                Dim strQryCol As String = ""

                For Each dtCol As DataColumn In tmpTable.Columns
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



                For Each dtRow As DataRow In tmpTable.Rows
                    Dim strQryValue As String = ""
                    For Each dtCol As DataColumn In tmpTable.Columns

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
                Threading.Thread.Sleep(100)
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


            GC.Collect()
            ' rtnResult = SaveResult.Err_Execute
        Finally
            If oleDb.State <> ConnectionState.Closed Then
                oleDb.Close()
                oleDb.Dispose()
            End If

        End Try
    End Sub

    Public Shared Sub SaveExcelData(ByVal FileName As String, ByVal dt As DataTable, ByVal OverWrite As Boolean _
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


            GC.Collect()
            ' rtnResult = SaveResult.Err_Execute
        Finally
            If oleDb.State <> ConnectionState.Closed Then
                oleDb.Close()
                oleDb.Dispose()
            End If

        End Try


    End Sub
End Class
