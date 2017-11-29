Imports System.Windows.Forms.DataVisualization.Charting
Imports System.IO

Public Class frmPrint
    'Dim strBuilder As New System.Text.StringBuilder
    Dim ChartimgArry As ArrayList = New ArrayList()

    Dim _TempPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "temp")



    Public Sub New(ByVal HostName As String, _
                   ByVal Snapshot As String, _
                    ByVal ParamArray groups() As eXperDB.BaseControls.GroupBox)



        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        If Not System.IO.Directory.Exists(_TempPath) Then
            System.IO.Directory.CreateDirectory(_TempPath)
        Else
            System.IO.Directory.Delete(_TempPath, True)
            System.IO.Directory.CreateDirectory(_TempPath)
        End If

        Dim strBuilder As New System.Text.StringBuilder
        strBuilder.AppendLine(InitHtml().ToString)

        strBuilder.AppendLine("<P>HOSTNAME : " & HostName & " </P>")
        strBuilder.AppendLine("<P>SNAPSHOT : " & Snapshot & " </P>")

        For i As Integer = 0 To groups.Length - 1
            Dim grp As BaseControls.GroupBox = groups(i)
            strBuilder.AppendLine(PrintGroupbox(grp, grp.Text, "P" & i.ToString("000")).ToString & "<p />")
        Next


        Me.Text = "HOSTNAME : " & HostName

        EndHtml()

        WebBrowser1.DocumentText = strBuilder.ToString




    End Sub


    Private Function Ctls(ByVal Grp As BaseControls.GroupBox) As Control()
        Dim arrCtls As New ArrayList
        For Each tmpCtl As Control In Grp.Controls
            Select Case tmpCtl.GetType
                Case GetType(BaseControls.FlowLayoutPanel)
                    arrCtls.Add(tmpCtl)
                Case GetType(BaseControls.DataGridView)
                    arrCtls.Add(tmpCtl)
                Case GetType(ctlChart)
                    arrCtls.Add(tmpCtl)
                Case GetType(BaseControls.Panel)

                    If tmpCtl.GetType.Equals(GetType(BaseControls.Panel)) Then
                        Dim tmpCtls As Control() = Ctls(DirectCast(tmpCtl, BaseControls.Panel))
                        For Each tmpSubCt As Control In tmpCtls
                            arrCtls.Add(tmpSubCt)
                        Next
                    End If
            End Select
        Next
        Return arrCtls.ToArray(GetType(Control))

    End Function

    Private Function Ctls(ByVal Pnl As BaseControls.Panel) As Control()
        Dim arrCtls As New ArrayList
        For Each tmpCtl As Control In Pnl.Controls
            Select Case tmpCtl.GetType
                Case GetType(BaseControls.FlowLayoutPanel)
                    arrCtls.Add(tmpCtl)
                Case GetType(BaseControls.DataGridView)
                    arrCtls.Add(tmpCtl)
                Case GetType(ctlChart)
                    arrCtls.Add(tmpCtl)
                Case GetType(BaseControls.Panel)

                    If tmpCtl.GetType.Equals(GetType(BaseControls.Panel)) Then
                        Dim tmpCtls As Control() = Ctls(DirectCast(tmpCtl, BaseControls.Panel))
                        For Each tmpSubCt As Control In tmpCtls
                            arrCtls.Add(tmpSubCt)
                        Next
                    End If
            End Select
        Next
        Return arrCtls.ToArray(GetType(Control))
    End Function


    Public Function PrintGroupbox(ByVal groupbox As eXperDB.BaseControls.GroupBox, ByVal groupboxNM As String, ByVal PicNM As String) As System.Text.StringBuilder



        Dim ctlchartarr As ArrayList = New ArrayList()

        Dim strBuilder As New System.Text.StringBuilder

        Dim strTItle As String = groupbox.Text
        Dim arrDatas As New ArrayList

        Dim arrCtls As Control() = Ctls(groupbox)

        Dim intNum As Integer = 0

        If (groupbox.Controls.Count > 0) Then
            For Each tmpCtl As Control In arrCtls
                Select Case tmpCtl.GetType
                    Case GetType(BaseControls.DataGridView)
                        Dim dgv As BaseControls.DataGridView = tmpCtl
                        arrDatas.Add(CreateHtmlTable(dgv).ToString)
                    Case GetType(eXperDB.Monitoring.ctlChart)
                        intNum += 1
                        arrDatas.Add(CreateHtmlChart(tmpCtl, PicNM & "_" & intNum.ToString("00")).ToString)
                    Case GetType(BaseControls.FlowLayoutPanel)
                        Dim flp As BaseControls.FlowLayoutPanel = TryCast(tmpCtl, BaseControls.FlowLayoutPanel)

                        If flp IsNot Nothing Then
                            If flp.Controls.Count > 0 Then
                                Dim bretChk As Boolean = False
                                If flp.Controls(0).GetType.Equals(GetType(BaseControls.CheckBox)) Then
                                    bretChk = True
                                Else
                                    bretChk = False
                                End If
                                Dim arrGrpTitles As New ArrayList
                                If bretChk = False Then
                                    ' RadioButton 
                                    For Each ctlRb As BaseControls.RadioButton In flp.Controls
                                        If ctlRb.Checked Then
                                            arrGrpTitles.Add(ctlRb.Text)
                                            Exit For
                                        End If
                                    Next
                                Else
                                    ' CheckBox

                                    For Each ctlChk As BaseControls.CheckBox In flp.Controls
                                        If ctlChk.Checked Then
                                            arrGrpTitles.Add(ctlChk.Text)
                                        End If
                                    Next
                                End If
                                strTItle += " - " & String.Join(" , ", arrGrpTitles.ToArray())
                            End If
                        End If
                End Select
            Next
        End If

        strBuilder.AppendLine("<table width=""100%"" border=""1"" cellpadding=""0"" bordercolor=""black""  cellspacing=""1"" bgcolor=""cacaca"">")
        strBuilder.AppendLine(String.Format("<tr><td class=""title"">{0}</td></tr>", strTItle))
        For i As Integer = arrDatas.Count - 1 To 0 Step -1
            strBuilder.AppendLine("<tr><td class=""title"">")
            strBuilder.AppendLine(arrDatas(i))
            strBuilder.AppendLine("</td></tr>")
        Next


        strBuilder.AppendLine("</table>")



        Return strBuilder


    End Function

    'Public  CreateHtmlTableChart(ByRef dgv As BaseControls.DataGridView, ByRef chartArr As ArrayList, ByVal groupboxNM As String, ByVal PicNM As String)

    '    Try

    '        strBuilder.AppendLine("<table width=""100%"" border=""1"" cellpadding=""0"" bordercolor=""black""  cellspacing=""1"" bgcolor=""cacaca"">")
    '        Dim colIndex As Integer = 1
    '        Dim colspan As Integer = dgv.Columns.Count - 1
    '        If (PicNM = "P002") Then
    '            colIndex = 2
    '            colspan = dgv.Columns.Count - 2
    '        End If

    '        If (dgv Is Nothing) Then
    '        Else
    '            strBuilder.AppendLine("<tr>")
    '            strBuilder.Append("<td class=""title"" colspan='" & colspan & "'>" & groupboxNM & "")
    '            strBuilder.AppendLine("</td></tr>")


    '            strBuilder.AppendLine("<tr>")
    '            For i As Integer = colIndex To dgv.Columns.Count - 1
    '                strBuilder.Append("<th class=""title"" scope=""col"">")
    '                strBuilder.Append(dgv.Columns(i).HeaderText)
    '                strBuilder.AppendLine("</th>")
    '            Next
    '            strBuilder.AppendLine("</tr>")

    '            'Dim tStr As String = String.Empty
    '            Dim tStr As Object
    '            'Dim class_str As String() = New String() {"awrc", "awrnc"}
    '            Dim class_str As String() = New String() {"bg2", "bg2"}

    '            For i As Integer = 0 To dgv.Rows.Count - 1
    '                strBuilder.Append("<tr>")
    '                For j As Integer = colIndex To dgv.Columns.Count - 1
    '                    If (dgv.Rows(i).Cells(j).Value IsNot Nothing) Then
    '                        tStr = dgv.Rows(i).Cells(j).Value
    '                    Else
    '                        tStr = "&nbsp;"
    '                    End If
    'Dim dgvc As DataGridViewColumn = dgv.Columns(j)
    '                    If (dgvc.GetType = GetType(eXperDB.Controls.DataGridViewDataSizeColumn)) Then
    '                        Dim dgvdsc As eXperDB.Controls.DataGridViewDataSizeColumn = dgvc
    '                        tStr = TranslateFileSizeWithUnit(dgvdsc.ShowUnit, dgv.Columns(j).DefaultCellStyle, tStr, dgvdsc.BaseUnit)
    '                    Else
    '                        If tStr IsNot Nothing AndAlso IsNumeric(tStr) AndAlso tStr > 0 Then
    '                            If Not dgv.Columns(j).DefaultCellStyle.Format = "" Then
    '                                Dim intVal As Double = CDbl(tStr)
    '                                tStr = intVal.ToString(dgv.Columns(j).DefaultCellStyle.Format)
    '                            End If
    '                        End If
    '                    End If


    '                    If (j = colIndex) Then
    '                        If (dgv.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight) Then
    '                            strBuilder.Append("<td class=""bg2Right"">" & tStr.ToString & "</td>")
    '                        Else
    '                            strBuilder.Append("<td class=""bg2Left"">" & tStr.ToString & "</td>")
    '                        End If

    '                    Else
    '                        strBuilder.Append("<td class=""bg2Right"">" & tStr.ToString & "</td>")
    '                    End If
    '                Next
    '                strBuilder.AppendLine("</tr>")
    '            Next
    '        End If


    '        If (chartArr.Count > 0) Then
    '            Dim imgseq As Integer = 1
    '            For Each tmpCtl As Control In chartArr
    '                Select Case tmpCtl.GetType
    '                    Case GetType(eXperDB.Monitoring.ctlChart)
    '                        Dim ctlChart As eXperDB.Monitoring.ctlChart = Nothing
    '                        ctlChart = tmpCtl
    '                        ChartPrintSetting(ctlChart, True)


    '                        Dim strurl = System.IO.Path.Combine(Path.GetFullPath(Environment.GetEnvironmentVariable("temp")), PicNM & imgseq.ToString & ".jpg")

    '                        ChartimgArry.Add(strurl)
    '                        ctlChart.MainChart.SaveImage(strurl, ChartImageFormat.Jpeg)

    '                        ChartPrintSetting(ctlChart, False)

    '                        strBuilder.AppendLine("<tr>")
    '                        strBuilder.Append("<td class=""bg2"" colspan='" & colspan & "'><IMG SRC='" & strurl & "' width=""100%"">")
    '                        strBuilder.AppendLine("</td></tr>")

    '                        ' End If
    '                        imgseq += imgseq
    '                End Select
    '            Next
    '            strBuilder.AppendLine("</table><p />")
    '        Else
    '            strBuilder.AppendLine("</table><p />")
    '        End If



    '        strBuilder.AppendLine("<table width=""100%"" border=""0"" cellpadding=""0""  cellspacing=""0"">")
    '        strBuilder.AppendLine("<tr><td>&nbsp;</td></tr></table>")


    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '    End Try


    'End Sub


    Public Sub ChartPrintSetting(ByRef chart1 As eXperDB.Monitoring.ctlChart, ByVal Reverse As Boolean)

        If (Reverse) Then
            If (chart1.MainChart.ChartAreas.Count > 0) Then
                chart1.BackColor = System.Drawing.Color.White
                For Each ChartAreas_ As ChartArea In chart1.MainChart.ChartAreas
                    ChartAreas_.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Black
                    ChartAreas_.AxisX.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisX.MajorGrid.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY.MajorGrid.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY.TitleForeColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY2.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Black
                    ChartAreas_.AxisY2.TitleForeColor = System.Drawing.Color.Black
                    ChartAreas_.BackColor = System.Drawing.Color.White
                Next
            End If
            If chart1.MainChart.Legends.Count > 0 Then
                For Each Legend_ As Legend In chart1.MainChart.Legends
                    Legend_.ForeColor = System.Drawing.Color.Black
                    Legend_.TitleForeColor = System.Drawing.Color.Black
                    Legend_.TitleSeparatorColor = System.Drawing.Color.Black
                    Legend_.BackColor = System.Drawing.Color.White
                    For Each LegendCellColumn_ As LegendCellColumn In Legend_.CellColumns
                        LegendCellColumn_.ForeColor = System.Drawing.Color.Black
                        LegendCellColumn_.HeaderForeColor = System.Drawing.Color.Black
                    Next
                Next
            End If
            If chart1.MainChart.Series.Count > 0 Then
                For Each Series_ As Series In chart1.MainChart.Series
                    Series_.LabelForeColor = Color.Black
                Next
            End If

            Dim series_S As Series = chart1.MainChart.Series.FindByName("USED")
            If series_S IsNot Nothing Then
                If series_S.Points.Count > &H0 Then
                    Dim tmpDtPt As DataPoint = series_S.Points.FindMaxByValue
                    tmpDtPt.MarkerStyle = MarkerStyle.Star10
                    tmpDtPt.MarkerSize = 20
                    tmpDtPt.MarkerColor = Color.Black
                    tmpDtPt.Label = tmpDtPt.YValues(0)

                End If
            End If

        Else ''되돌리기.

            Dim color1 As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
            Dim color2 As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))

            If (chart1.MainChart.ChartAreas.Count > 0) Then
                chart1.BackColor = System.Drawing.Color.Black
                For Each ChartAreas_ As ChartArea In chart1.MainChart.ChartAreas
                    ChartAreas_.AxisX.LabelStyle.ForeColor = color1
                    ChartAreas_.AxisX.LineColor = color2
                    ChartAreas_.AxisX.MajorGrid.LineColor = color2
                    ChartAreas_.AxisY.LabelStyle.ForeColor = color1
                    ChartAreas_.AxisY.LineColor = color2
                    ChartAreas_.AxisY.MajorGrid.LineColor = color2
                    ChartAreas_.AxisY.TitleForeColor = color1

                    ChartAreas_.AxisY2.LabelStyle.ForeColor = color1
                    ChartAreas_.AxisY2.LineColor = color2
                    ChartAreas_.AxisY2.MajorGrid.LineColor = color2
                    ChartAreas_.AxisY2.TitleForeColor = color1
                    ChartAreas_.BackColor = System.Drawing.Color.Black
                Next
            End If
            If chart1.MainChart.Legends.Count > 0 Then
                For Each Legend_ As Legend In chart1.MainChart.Legends
                    Legend_.ForeColor = color1
                    Legend_.TitleForeColor = color1
                    Legend_.TitleSeparatorColor = color1
                    Legend_.BackColor = System.Drawing.Color.Black
                    For Each LegendCellColumn_ As LegendCellColumn In Legend_.CellColumns
                        LegendCellColumn_.ForeColor = color1
                        LegendCellColumn_.HeaderForeColor = color2
                    Next
                Next
            End If
            If chart1.MainChart.Series.Count > 0 Then
                For Each Series_ As Series In chart1.MainChart.Series
                    Series_.LabelForeColor = Color.White
                Next
            End If

            Dim series_S As Series = chart1.MainChart.Series.FindByName("USED")
            If series_S IsNot Nothing Then
                If series_S.Points.Count > &H0 Then

                    Dim tmpDtPt As DataPoint = series_S.Points.FindMaxByValue
                    tmpDtPt.MarkerStyle = MarkerStyle.Star10
                    tmpDtPt.MarkerSize = 20
                    tmpDtPt.MarkerColor = Color.White
                    tmpDtPt.Label = tmpDtPt.YValues(0)
                End If
            End If
        End If

    End Sub

    Public Function CreateHtmlTable(ByRef dgv As BaseControls.DataGridView) As System.Text.StringBuilder
        Dim strBuilder As New System.Text.StringBuilder



        Try


            strBuilder.AppendLine("<table width=""100%"" border=""1"" cellpadding=""0"" bordercolor=""black""  cellspacing=""1"" bgcolor=""cacaca"">")

            strBuilder.AppendLine("<tr>")
            'strBuilder.Append("<th class=""title"">")
            strBuilder.Append("<td class=""bg2"" colspan='" & dgv.Columns.Count & "'>")
            strBuilder.AppendLine("</td></tr>")


            Dim length As Integer = 0
            Dim times As Integer = 180



            strBuilder.AppendLine("<tr>")
            For i As Integer = 0 To dgv.Columns.Count - 1
                strBuilder.Append("<th class=""title"" scope=""col"">")
                strBuilder.Append(dgv.Columns(i).HeaderText)
                strBuilder.AppendLine("</th>")
            Next
            strBuilder.AppendLine("</tr>")

            Dim tStr As String = String.Empty
            'Dim class_str As String() = New String() {"awrc", "awrnc"}
            Dim class_str As String() = New String() {"bg2", "bg2"}

            For i As Integer = 0 To dgv.Rows.Count - 1
                strBuilder.Append("<tr>")
                For j As Integer = 0 To dgv.Columns.Count - 1
                    If (dgv.Rows(i).Cells(j).Value IsNot Nothing) Then
                        tStr = dgv.Rows(i).Cells(j).Value.ToString()
                    Else
                        tStr = "&nbsp;"
                    End If
                    'If j = 0 Then
                    '    strBuilder.Append("<td scope=""row"" class='" & class_str(i Mod 2) & "'>" & _
                    '                      tStr.Replace(" ", "<font color='#C0C0C0'>_</font>").Replace(vbCrLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbCr, "<font color='#C0C0C0'>$<br></font>") & "</td>")
                    'Else
                    'strBuilder.Append("<td class='" & class_str(i Mod 2) & "'>" & tStr & "</td>")
                    strBuilder.Append("<td class='" & class_str(i Mod 2) & "'>" & tStr.Replace(" ", "<font color='#C0C0C0'>_</font>").Replace(vbCrLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbCr, "<font color='#C0C0C0'>$<br></font>") & "</td>")

                    'End If
                Next
                strBuilder.AppendLine("</tr>")
            Next
            strBuilder.AppendLine("</table>")
        Catch ex As Exception
            p_Log.AddMessage(clsLog4Net.enmType.Error, ex.ToString)
            GC.Collect()
        End Try

        Return strBuilder

    End Function

    Public Function CreateHtmlChart(ByVal cChart As ctlChart, ByVal PicNM As String) As System.Text.StringBuilder
        Dim strBuilder As New System.Text.StringBuilder


        ChartPrintSetting(cChart, True)


        Dim strurl = System.IO.Path.Combine(_TempPath, PicNM & ".jpg")
        cChart.MainChart.SaveImage(strurl, ChartImageFormat.Jpeg)
        ChartimgArry.Add(strurl)
        ChartPrintSetting(cChart, False)
        strBuilder.AppendLine("<table width=""100%"" border=""1"" cellpadding=""0"" bordercolor=""black""  cellspacing=""1"" bgcolor=""cacaca"">")
        strBuilder.AppendLine("<tr>")
        strBuilder.Append("<th class=""title"" scope=""col"">")
        strBuilder.Append("<td class=""bg2""><IMG SRC='" & strurl & "' width=""100%"">")
        strBuilder.AppendLine("</td></tr>")
        strBuilder.AppendLine("</table>")


        Return strBuilder
    End Function

    Public Function InitHtml() As System.Text.StringBuilder
        Dim strBuilder As New System.Text.StringBuilder
        strBuilder.AppendLine("<html lang=""en""><head><title>Report</title>")
        strBuilder.AppendLine("<style type=""text/css"">")

        strBuilder.AppendLine("th.title {font-weight:bold; color:#58646d; text-align:center; background-color:#f2f2f2; height:26px; padding-top:3px;}")
        strBuilder.AppendLine("td.bg2  {background-color:#FFFFFF; padding:1px;}")

        strBuilder.AppendLine("td.bg2Left  {background-color:#FFFFFF; text-align:left; padding:1px;}")
        strBuilder.AppendLine("td.bg2Right  {background-color:#FFFFFF;text-align:right;  padding:1px;}")
        strBuilder.AppendLine("td.bg2Center  {background-color:#FFFFFF;text-align:center;  padding:1px;}")


        strBuilder.AppendLine("body.awr {font:bold 10pt Arial,Helvetica,Geneva,sans-serif;color:black; background:White;}")
        strBuilder.AppendLine("pre.awr  {font:8pt Courier;color:black; background:White;}")
        strBuilder.AppendLine("h1.awr   {font:bold 20pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;border-bottom:1px solid #cccc99;margin-top:0pt; margin-bottom:0pt;padding:0px 0px 0px 0px;}")
        strBuilder.AppendLine("h2.awr   {font:bold 18pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;margin-top:4pt; margin-bottom:0pt;}")
        strBuilder.AppendLine("h3.awr {font:bold 16pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;margin-top:4pt; margin-bottom:0pt;}")
        strBuilder.AppendLine("li.awr {font: 8pt Arial,Helvetica,Geneva,sans-serif; color:black; background:White;}")
        strBuilder.AppendLine("th.awrnobg {font:bold 8pt Arial,Helvetica,Geneva,sans-serif; color:black; background:White;padding-left:4px; padding-right:4px;padding-bottom:2px}")
        strBuilder.AppendLine("th.awrbg {font:bold 10pt Arial,Helvetica,Geneva,sans-serif; color:black; background:White;}")
        strBuilder.AppendLine("td.awrnc {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;}")
        strBuilder.AppendLine("td.awrc    {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;}")
        strBuilder.AppendLine("td.awrnclb {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-left: thin solid black;}")
        strBuilder.AppendLine("td.awrncbb {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-left: thin solid black;border-right: thin solid black;}")
        strBuilder.AppendLine("td.awrncrb {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-right: thin solid black;}")
        strBuilder.AppendLine("td.awrcrb    {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-right: thin solid black;}")
        strBuilder.AppendLine("td.awrclb    {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-left: thin solid black;}")
        strBuilder.AppendLine("td.awrcbb    {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-left: thin solid black;border-right: thin solid black;}")
        strBuilder.AppendLine("a.awr {font:bold 8pt Arial,Helvetica,sans-serif;color:#663300; vertical-align:top;margin-top:0pt; margin-bottom:0pt;}")
        strBuilder.AppendLine("td.awrnct {font:8pt Arial,Helvetica,Geneva,sans-serif;border-top: thin solid black;color:black;background:White;vertical-align:top;}")
        strBuilder.AppendLine("td.awrct   {font:8pt Arial,Helvetica,Geneva,sans-serif;border-top: thin solid black;color:black;background:#FFFFCC; vertical-align:top;}")
        strBuilder.AppendLine("td.awrnclbt  {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-top: thin solid black;border-left: thin solid black;}")
        strBuilder.AppendLine("td.awrncbbt  {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-left: thin solid black;border-right: thin solid black;border-top: thin solid black;}")
        strBuilder.AppendLine("td.awrncrbt {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:White;vertical-align:top;border-top: thin solid black;border-right: thin solid black;}")
        strBuilder.AppendLine("td.awrcrbt     {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-top: thin solid black;border-right: thin solid black;}")
        strBuilder.AppendLine("td.awrclbt     {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-top: thin solid black;border-left: thin solid black;}")
        strBuilder.AppendLine("td.awrcbbt   {font:8pt Arial,Helvetica,Geneva,sans-serif;color:black;background:#FFFFCC; vertical-align:top;border-top: thin solid black;border-left: thin solid black;border-right: thin solid black;}")
        strBuilder.AppendLine("table.tdiff {  border_collapse: collapse; }")
        strBuilder.AppendLine(".hidden   {position:absolute;left:-10000px;top:auto;width:1px;height:1px;overflow:hidden;}")
        strBuilder.AppendLine(".pad   {margin-left:17px;}")
        strBuilder.AppendLine(".doublepad {margin-left:34px;}")
        strBuilder.AppendLine("</style></head><body class=""awr"">")
        Return strBuilder
    End Function

    Public Function EndHtml() As System.Text.StringBuilder
        Dim strBuilder As New System.Text.StringBuilder
        strBuilder.Append("</body></html>  ")
        Return strBuilder
    End Function

    Private Sub tsmiPrint_Click(sender As Object, e As EventArgs) Handles tsmiPrint.Click
        WebBrowser1.Print()
    End Sub

    Private Sub tsmiPageSetup_Click(sender As Object, e As EventArgs) Handles tsmiPageSetup.Click
        WebBrowser1.ShowPageSetupDialog()
    End Sub

    Private Sub tsmiPreview_Click(sender As Object, e As EventArgs) Handles tsmiPreview.Click
        WebBrowser1.ShowPrintPreviewDialog()
    End Sub

    Private Sub tsmiSave_Click(sender As Object, e As EventArgs) Handles tsmiSave.Click
        Dim fsd As New SaveFileDialog
        fsd.Filter = "HTML|*.html"
        fsd.DefaultExt = "*.html"

        If fsd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim savePath As String = Path.GetDirectoryName(fsd.FileName)  '현재위치
            Directory.CreateDirectory(savePath & "\Chart_img")
            If (Directory.Exists(savePath & "\Chart_img")) Then
                If (ChartimgArry.Count > 0) Then
                    For index = 0 To ChartimgArry.Count - 1
                        Dim path1 As String = Path.GetDirectoryName(ChartimgArry(index).ToString)
                        Dim path2 As String = ChartimgArry(index).ToString.Replace(path1, savePath & "\Chart_img")
                        File.Copy(ChartimgArry(index).ToString, path2, True)
                    Next
                End If
            Else
            End If


            Dim streamstring As String = WebBrowser1.DocumentText.Replace(_TempPath, ".\Chart_img")

            Using FWriter As New StreamWriter(fsd.FileName, False, System.Text.Encoding.Default)
                FWriter.WriteLine(streamstring)
            End Using

        End If


    End Sub
End Class