Module modCommon
    ''' <summary>
    ''' PostgresSQL 모니터링용 메시지 박스 
    ''' </summary>
    ''' <param name="strMsg"></param>
    ''' <param name="Title"></param>
    ''' <param name="Buttons"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MsgBox(ByVal strMsg As String, Optional ByVal Title As String = "Message", Optional ByVal Buttons As frmMsgbox.MsgBoxStyle = frmMsgbox.MsgBoxStyle.OKOnly) As frmMsgbox.MsgBoxResult

        Dim frmMsg As New frmMsgbox(strMsg, Title, Buttons)
        Return frmMsg.ShowDialog

    End Function


    ''' <summary>
    ''' Agent 서버 정보 불러오기 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function AgentInfoRead() As eXperDB.ODBC.structConnection
        Dim clsConfigIni As New Common.IniFile(p_AppConfigIni)


        Dim strUsr As String = clsConfigIni.ReadValue("AGENT", "USER", "")
        Dim strPw As String = clsConfigIni.ReadValue("AGENT", "PW", "")
        If strPw <> "" Then
            Dim dec As New eXperDB.Common.ClsCrypt
            strPw = dec.DecryptString(strPw, "cashweb0")
        End If
        Dim strIP As String = clsConfigIni.ReadValue("AGENT", "IP", "")
        Dim strPort As String = clsConfigIni.ReadValue("AGENT", "PORT", "0")
        Dim strDB As String = clsConfigIni.ReadValue("AGENT", "DATABASE", "")
        Dim dbType As eXperDBODBC.enumODBCType = IIf(System.Environment.Is64BitProcess, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicodeX64, eXperDB.ODBC.eXperDBODBC.enumODBCType.PostgreUnicode)
        Dim enmODBC As eXperDBODBC.enumODBCType = clsConfigIni.ReadValue("AGENT", "ODBC", dbType)

        Dim rtnStruct As New eXperDB.ODBC.structConnection(enmODBC, strIP, IIf(strPort = "", 0, CInt(strPort)), strUsr, strDB, strPw)
        Return rtnStruct

    End Function
    ''' <summary>
    ''' Agent 서버 정보 저장 
    ''' </summary>
    ''' <param name="Conn"></param>
    ''' <remarks></remarks>
    Public Sub AgentInfoWrite(ByVal Conn As eXperDB.ODBC.structConnection)
        Dim clsConfigIni As New Common.IniFile(p_AppConfigIni)
        Dim enc As New eXperDB.Common.ClsCrypt

        clsConfigIni.WriteValue("AGENT", "ODBC", Conn.ODBCType)
        clsConfigIni.WriteValue("AGENT", "USER", Conn.UserID)
        clsConfigIni.WriteValue("AGENT", "PW", enc.EncryptString(Conn.Password, "cashweb0"))
        clsConfigIni.WriteValue("AGENT", "IP", Conn.HostIP)
        clsConfigIni.WriteValue("AGENT", "PORT", Conn.Port)
        clsConfigIni.WriteValue("AGENT", "DATABASE", Conn.DBName)
    End Sub


    ''' <summary>
    ''' 그리드 컬러 변경 
    ''' </summary>
    ''' <param name="Dgv"></param>
    ''' <remarks></remarks>
    Public Sub sb_GridProgClrChg(ByVal Dgv As Windows.Forms.DataGridView)
        Threading.Thread.Sleep(1)

        Dim ArrCols As New ArrayList
        For Each tmpCol As DataGridViewColumn In Dgv.Columns
            If TryCast(tmpCol, Controls.DataGridViewPercentageColumn) IsNot Nothing Then
                ArrCols.Add(tmpCol.Index)
            End If
        Next




        For Each tmpRow As DataGridViewRow In Dgv.Rows
            For Each tmpColIdx As Integer In ArrCols
                Dim tmpCellValue As Integer = tmpRow.Cells(tmpColIdx).Value

                For Each tmpStruct As ProgClrArea In p_RageBaseClr
                    If tmpStruct.valueSt - 1 < tmpCellValue AndAlso tmpCellValue <= tmpStruct.valueEd Then
                        tmpRow.DefaultCellStyle.ForeColor = tmpStruct.Color
                        tmpRow.DefaultCellStyle.SelectionForeColor = tmpStruct.Color
                        Exit For
                    End If
                Next
                'If tmpCellValue >= 0 AndAlso tmpCellValue < 60 Then
                '    tmpRow.DefaultCellStyle.ForeColor = Color.Lime
                '    tmpRow.DefaultCellStyle.SelectionForeColor = Color.Lime
                'ElseIf tmpCellValue >= 60 AndAlso tmpCellValue < 90 Then
                '    tmpRow.DefaultCellStyle.ForeColor = Color.Yellow
                '    tmpRow.DefaultCellStyle.SelectionForeColor = Color.Yellow
                'ElseIf tmpCellValue >= 90 AndAlso tmpCellValue <= 100 Then
                '    tmpRow.DefaultCellStyle.ForeColor = Color.Red
                '    tmpRow.DefaultCellStyle.SelectionForeColor = Color.Red
                'End If
            Next
        Next



    End Sub


    Public Structure ProgClrArea
        Dim valueSt As Integer
        Dim valueEd As Integer
        Dim Color As Drawing.Color
        Public Sub New(ByVal stval As Integer, ByVal EdVal As Integer, ByVal Clr As Color)
            valueSt = stval
            valueEd = EdVal
            Color = Clr
        End Sub

    End Structure

    ''' <summary>
    ''' 그리드 컬러 변경 
    ''' </summary>
    ''' <param name="Dgv"></param>
    ''' <remarks></remarks>
    Public Sub sb_GridProgClrChg(ByVal Dgv As Windows.Forms.DataGridView, ByVal ColIndex As Integer, ParamArray Rages() As ProgClrArea)
        Threading.Thread.Sleep(1)



        For Each tmpRow As DataGridViewRow In Dgv.Rows

            Dim tmpCellValue As Object = tmpRow.Cells(ColIndex).Value

            If IsNumeric(tmpCellValue) Then
                For Each tmpStruct As ProgClrArea In Rages
                    If tmpStruct.valueSt - 1 < tmpCellValue AndAlso tmpCellValue <= tmpStruct.valueEd Then
                        tmpRow.DefaultCellStyle.ForeColor = tmpStruct.Color
                        tmpRow.DefaultCellStyle.SelectionForeColor = tmpStruct.Color
                        Exit For
                    End If
                Next
            End If

        Next



    End Sub

    Public Function sb_RageValueColor(ByVal Value As Integer, ParamArray Rages() As ProgClrArea) As Color
        For Each tmpStruct As ProgClrArea In Rages
            If tmpStruct.valueSt - 1 < Value AndAlso Value <= tmpStruct.valueEd Then
                Return tmpStruct.Color
                Exit For
            End If
        Next
        Return Color.Lime

    End Function


    Public Function fn_FormisLock(ByVal frm As Form, ByVal odbcCN As eXperDB.ODBC.eXperDBODBC) As Boolean

        If TryCast(frm, frmMonBase) IsNot Nothing Then
            If DirectCast(frm, frmMonBase).isLock Then
                Dim frmPw As New frmPassword(odbcCN)
                If frmPw.ShowDialog <> Windows.Forms.DialogResult.OK Then
                    Return True
                Else
                    DirectCast(frm, frmMonBase).isLock = False
                    Return False
                End If
            Else
                Return False
            End If

        Else
            Return False
        End If

    End Function




    ' ''' <summary>
    ' ''' DataGridView Sorting Delegate
    ' ''' </summary>
    ' ''' <param name="Dgv"></param>
    ' ''' <param name="colIdx"></param>
    ' ''' <remarks></remarks>
    'Private Delegate Sub dele_sb_GridSortChg(ByVal Dgv As Windows.Forms.DataGridView, ByVal colIdx As Integer)

    ''' <summary>
    ''' DataGridview Sorting Data 
    ''' </summary>
    ''' <param name="Dgv"></param>
    ''' <param name="colIdx">-1 은 자동 설정 </param>
    ''' <remarks></remarks>
    Public Sub sb_GridSortChg(ByVal Dgv As Windows.Forms.DataGridView, Optional ByVal colIdx As Integer = -1)
        Try

            'If Dgv.InvokeRequired = True Then
            '    Dgv.Invoke(New dele_sb_GridSortChg(AddressOf sb_GridSortChg), Dgv, colIdx)

            'Else
            ' 자동일 경우에 

            If colIdx = -1 Then
                If Dgv.SortedColumn IsNot Nothing Then
                    colIdx = Dgv.SortedColumn.Index
                Else
                    Return
                End If

            End If
            If Dgv.SortedColumn Is Nothing Then
                Dgv.Sort(Dgv.Columns(colIdx), System.ComponentModel.ListSortDirection.Descending)
            Else
                If Dgv.SortOrder <> SortOrder.None Then
                    Dgv.Sort(Dgv.SortedColumn, IIf(Dgv.SortOrder = SortOrder.Ascending, System.ComponentModel.ListSortDirection.Ascending, System.ComponentModel.ListSortDirection.Descending))
                End If
            End If
            'End If

        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, "DGV Sort Error" & vbCrLf & ex.ToString)
            GC.Collect()
        End Try

    End Sub

    '' ''' <summary>
    '' ''' DataGridview Sorting Data 
    '' ''' </summary>
    '' ''' <param name="Dgv"></param>
    '' ''' <param name="colIdx">-1 은 자동 설정 </param>
    '' ''' <remarks></remarks>
    ''Public Sub sb_GridSortChg(ByVal Dgv As Windows.Forms.DataGridView, ByVal colIdx As Integer, ByVal SrtOrd As SortOrder)
    ''    Try





    ''        Dgv.Sort(Dgv.Columns(colIdx), IIf(SrtOrd = SortOrder.Ascending, System.ComponentModel.ListSortDirection.Ascending, System.ComponentModel.ListSortDirection.Descending))


    ''    Catch ex As Exception
    ''        p_Log.AddMessage(clsLog4Net.enmType.Error, "DGV Sort Error" & vbCrLf & ex.ToString)
    ''        GC.Collect()
    ''    End Try

    ''End Sub
    Public Function ConvDBL(ByVal DbValue As Object) As Double
        Return CDbl(IIf(IsDBNull(DbValue), 0.0, DbValue))
    End Function
    Public Function ConvDBLKBtoMB(ByVal DbValue As Object) As Double
        Dim tmpValue As Double = ConvDBL(DbValue)
        Return ConvDBL(tmpValue / 1024)
        ' Return CDbl(IIf(IsDBNull(DbValue), 0.0, CDbl(DbValue)))
    End Function

    Public Function ConvULong(ByVal DbValue As Object) As Long
        Dim rtnValue As ULong = 0
        If IsDBNull(DbValue) Then
            rtnValue = 0
        ElseIf IsNumeric(DbValue) Then
            If DbValue < 0 Then
                rtnValue = 0
            Else
                rtnValue = DbValue
            End If
        Else
            rtnValue = 0
        End If

        Return rtnValue 'CLng(IIf(IsDBNull(DbValue), 0.0, DbValue))
    End Function

    Public Function ConvOADate(ByVal DbValue As Object) As Double
        If IsDBNull(DbValue) OrElse Not IsDate(DbValue) Then
            Return DateTime.MinValue.ToOADate
        Else
            Return CDate(DbValue).ToOADate
        End If
    End Function
 
   
    Public Function TranslateFileSizeWithUnit(ByVal size As Int32, Optional ByVal baseUnit As clsEnums.FileSizeUnit = clsEnums.FileSizeUnit.Bytes, Optional ByVal FormatString As String = "f1") As String
        Try

            'Dim strTail As String = Common.ClsConfigure.fn_rtnComponentDescription(AppLang.GetType.GetMember(AppLang.ToString)(0)) '  TryCast(AppLang.GetType().GetMember(AppLang.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
            If IsNumeric(size) AndAlso size > 0 Then
                Dim filesizename() As String = {"Bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"}
                Dim pow As Double = Math.Floor(Math.Log(size, 1024))
                Return String.Concat(CInt(size / Math.Pow(1024, pow)).ToString(FormatString), " ", filesizename(CInt(pow + baseUnit)))
            Else
                Return size
            End If

        Catch ex As Exception
            Return CStr(size)
        End Try
    End Function
     

    Public Function fn_GetHealthName(ByVal Value As Integer) As String
        Select Case Value
            Case 200 : Return p_clsMsgData.fn_GetData("F285")
            Case 300 : Return p_clsMsgData.fn_GetData("F286")
            Case Else : Return p_clsMsgData.fn_GetData("F284")
        End Select
    End Function


    Public Sub FontChange(ByVal Form As Form, ByVal NewFont As String)
        For Each tmpCtl As Control In Form.Controls()
            Select Case tmpCtl.GetType
                Case GetType(BaseControls.GroupBox)
                    With DirectCast(tmpCtl, BaseControls.GroupBox)
                        .TitleFont = New Font(NewFont, .TitleFont.Size, .TitleFont.Style)
                    End With
                Case GetType(System.Windows.Forms.DataVisualization.Charting.Chart)
                    Dim tmpChart As DataVisualization.Charting.Chart = tmpCtl
                    For Each tmpChartArea As DataVisualization.Charting.ChartArea In tmpChart.ChartAreas
                        For Each tmpAxis As DataVisualization.Charting.Axis In tmpChartArea.Axes
                            tmpAxis.TitleFont = New Font(NewFont, tmpAxis.TitleFont.Size, tmpAxis.TitleFont.Style)
                            tmpAxis.LabelStyle.Font = New Font(NewFont, tmpAxis.LabelStyle.Font.Size, tmpAxis.TitleFont.Style)
                        Next

                    Next

                    For Each tmpSeries As DataVisualization.Charting.Series In tmpChart.Series
                        tmpSeries.Font = New Font(NewFont, tmpSeries.Font.Size, tmpSeries.Font.Style)

                    Next

                    For Each tmpChartArea As DataVisualization.Charting.Legend In tmpChart.Legends
                        tmpChartArea.Font = New Font(NewFont, tmpChartArea.Font.Size, tmpChartArea.Font.Style)

                    Next


                     


            End Select
            If Not tmpCtl.Font.Name.Equals(NewFont) Then
                tmpCtl.Font = New Font(NewFont, tmpCtl.Font.Size, tmpCtl.Font.Style)
            End If
            If tmpCtl.Controls.Count > 0 Then
                FontChange(tmpCtl, NewFont)
            End If
        Next
    End Sub

    Private Sub FontChange(ByVal Ctl As Control, ByVal NewFont As String)
        For Each tmpCtl As Control In Ctl.Controls()
            Select Case tmpCtl.GetType
                Case GetType(BaseControls.GroupBox)
                    With DirectCast(tmpCtl, BaseControls.GroupBox)
                        .TitleFont = New Font(NewFont, .TitleFont.Size, .TitleFont.Style)
                    End With

                Case GetType(System.Windows.Forms.DataVisualization.Charting.Chart)
                    Dim tmpChart As DataVisualization.Charting.Chart = tmpCtl
                    For Each tmpChartArea As DataVisualization.Charting.ChartArea In tmpChart.ChartAreas
                        For Each tmpAxis As DataVisualization.Charting.Axis In tmpChartArea.Axes
                            tmpAxis.TitleFont = New Font(NewFont, tmpAxis.TitleFont.Size, tmpAxis.TitleFont.Style)
                            tmpAxis.LabelStyle.Font = New Font(NewFont, tmpAxis.LabelStyle.Font.Size, tmpAxis.LabelStyle.Font.Style)
                        Next

                    Next

                    For Each tmpSeries As DataVisualization.Charting.Series In tmpChart.Series
                        tmpSeries.Font = New Font(NewFont, tmpSeries.Font.Size, tmpSeries.Font.Style)

                    Next

                    For Each tmpChartArea As DataVisualization.Charting.Legend In tmpChart.Legends
                        tmpChartArea.Font = New Font(NewFont, tmpChartArea.Font.Size, tmpChartArea.Font.Style)

                    Next

            End Select
            If tmpCtl.Font.Name.ToUpper <> "WEBDINGS" AndAlso Not tmpCtl.Font.Name.Equals(NewFont) Then
                tmpCtl.Font = New Font(NewFont, tmpCtl.Font.Size, tmpCtl.Font.Style)
            End If

            If tmpCtl.Controls.Count > 0 Then
                FontChange(tmpCtl, NewFont)
            End If
        Next

    End Sub

    'Public Function fn_GetValueCast(ByVal HCHKNM As String, ByVal intValue As Object) As Object
    '    Try


    '        Dim Values As String = p_clsMsgData.fn_GetSpecificData(HCHKNM, "VALUECAST")
    '        If Values.Trim = "" Then Return intValue
    '        Dim arrValues As String() = Values.Split(";")
    '        For Each strVaues As String In arrValues
    '            Dim arrValue As String() = strVaues.Split("|")
    '            If arrValue.Count > 1 Then


    '                Dim OriValue As Object = arrValue(0)
    '                Dim CastValue As Object = arrValue(1)

    '                If Integer.TryParse(OriValue, OriValue) Then
    '                    If CInt(intValue).Equals(CInt(OriValue)) Then
    '                        Return CastValue
    '                    End If
    '                Else
    '                    Return intValue
    '                End If

    '            End If
    '        Next

    '        Return intValue

    '    Catch ex As Exception
    '        Return intValue
    '    End Try

    'End Function

    Public Function fn_GetValueCast(ByVal HCHKNM As String, ByVal intValue As Object) As Object 'temporary
        Try
            Dim Values As String = ""
            If HCHKNM.Equals("LASTANALYZE") Or HCHKNM.Equals("LASTVACUUM") Or _
               HCHKNM.Equals("REPLICATION_SLOT") Or HCHKNM.Equals("VIRTUAL_IP") Or _
               HCHKNM.Equals("HASTATUS") Then
                Values = p_clsMsgData.fn_GetSpecificData(HCHKNM, "VALUECAST")
            Else
                Return intValue
            End If
            Dim arrValues As String() = Values.Split(";")
            For Each strVaues As String In arrValues
                Dim arrValue As String() = strVaues.Split("|")
                If arrValue.Count > 1 Then


                    Dim OriValue As Object = arrValue(0)
                    Dim CastValue As Object = arrValue(1)

                    If Integer.TryParse(OriValue, OriValue) Then
                        If CInt(intValue).Equals(CInt(OriValue)) Then
                            Return CastValue
                        End If
                    Else
                        Return intValue
                    End If

                End If
            Next

            Return intValue

        Catch ex As Exception
            Return intValue
        End Try

    End Function

End Module
