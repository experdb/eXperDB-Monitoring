Imports System.Windows.Forms
Imports System.Threading
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Net
Imports System.Xml
Imports System.Net.NetworkInformation
Imports FastColoredTextBoxNS
Imports AdvancedDataGridView
Imports System.Drawing
Imports System.Data
Imports System.Collections

Public Class ClsObjectCtl

    'Public logger As log4net.ILog = log4net.LogManager.GetLogger("Log1")

    '==================================================
    'ObjName이라는 특정 콤보박스에 DataArry의 값을 넣기
    '==================================================
    Sub PutComboBoxData(ByVal ObjName As ComboBox, ByVal DataArry() As String, ByVal SelectIndex As Integer, Optional ByVal isAddSelect As Boolean = True)
        Dim i As Integer = 0
        ObjName.Items.Clear()
        If isAddSelect = True Then
            ObjName.Items.Add("선택")
        End If
        For i = LBound(DataArry) To UBound(DataArry)
            If DataArry(i) <> "" Then
                ObjName.Items.Add(DataArry(i))
            End If
        Next i
        ObjName.SelectedIndex = SelectIndex
    End Sub

    ''==================================================
    '' Utility to shift a value into an array
    ''==================================================
    'Sub shiftData(ByVal data As Object, ByVal NewValue As Object)
    '    Dim i As Integer
    '    For i = LBound(data) + 1 To UBound(data)
    '        data(i - 1) = data(i)
    '    Next
    '    data(UBound(data)) = NewValue
    'End Sub

    Sub shiftData(ByRef data() As Double, ByVal NewValue As Double)

        Dim tmpArr(data.Length - 1) As Double
        Array.Copy(data, 1, tmpArr, 0, data.Length - 1)
        tmpArr(tmpArr.Length - 1) = NewValue
        data = tmpArr.Clone

    End Sub
    Sub shiftData(ByRef data() As Date, ByVal NewValue As Date)

        Dim tmpArr(data.Length - 1) As Date
        Array.Copy(data, 1, tmpArr, 0, data.Length - 1)
        tmpArr(tmpArr.Length - 1) = NewValue
        data = tmpArr.Clone

    End Sub

    '==================================================
    ' 2차원 배열 Utility to shift a value into an array
    '==================================================
    Sub shiftData2(ByVal data() As Object, ByVal NewValue As Object, ByVal pVp As Integer)
        Dim i As Integer
        For i = LBound(data(pVp)) + 1 To UBound(data(pVp))
            data(pVp)(i - 1) = data(pVp)(i)
        Next
        data(pVp)(UBound(data(pVp))) = NewValue
    End Sub

    '==================================================
    ' DoEvents
    '==================================================
    Sub DoEvents()
        Application.DoEvents()
    End Sub

    '==================================================
    ' Sleep
    '==================================================
    Sub Sleep(ByVal pValue As Integer)
        Thread.Sleep(pValue)
    End Sub

    '==================================================
    ' Forms가 로드 되었는지 확인
    '==================================================
    Overloads Function FormIsLoaded(ByRef pstrFormName As String) As Form



        For Each objForm In System.Windows.Forms.Application.OpenForms
            If objForm.Name = pstrFormName Then
                Return objForm
            End If
        Next objForm
        Return Nothing
    End Function

    '==================================================
    ' Forms가 로드 되었는지 확인(tag값과 같이 비교)
    '==================================================
    Overloads Function FormIsLoaded(ByRef pstrFormName As String, ByVal pTag As String) As Form
        For Each objForm As Form In System.Windows.Forms.Application.OpenForms
            If objForm.Name = pstrFormName And objForm.Tag = pTag Then
                Return objForm
            End If
        Next objForm
        Return Nothing
    End Function

    '==================================================
    ' ToolStrip의 다이나믹하게 버튼 추가
    '==================================================
    Public Sub ToolStripAddButton(ByVal pToolStript As ToolStrip, _
                                  ByVal pToolStriptButton As ToolStripButton, _
                                  ByVal pButtonName As String, _
                                  ByVal pButtonText As String, _
                                  ByVal pIcon As Icon)

        With pToolStriptButton
            .Name = pButtonName
            .Text = pButtonText
            .Image = PuplationIco(pIcon).ToBitmap
            .TextImageRelation = TextImageRelation.ImageBeforeText
        End With
        pToolStript.Items.Add(pToolStriptButton)
    End Sub

    '==================================================
    ' ToolStrip의 다이나믹하게 버튼 제거
    '==================================================
    Public Sub ToolStripRemoveButton(ByVal pToolStript As ToolStrip, ByVal pToolStriptButton As ToolStripButton)
        pToolStript.Items.Remove(pToolStriptButton)
    End Sub

    '==================================================
    ' 아이콘 리턴
    '==================================================
    Function PuplationIco(ByVal pIconName As Icon) As Icon
        'Dim img As Icon = pIconName
        'Return img
        Return New Icon(pIconName, New Size(16, 16))
    End Function

    '==================================================
    ' 파일 삭제
    '==================================================
    Public Sub DeleteFiles(ByVal pFile As String)
        If File.Exists(pFile) Then
            File.Delete(pFile)
        End If
    End Sub

    '==================================================
    ' 디렉토리내에 파일 전체 삭제
    '==================================================
    Public Sub DeleteFilesFromFolders(ByVal sourcePath As String)
        If (Directory.Exists(sourcePath)) Then
            For Each fName As String In Directory.GetFiles(sourcePath)
                If File.Exists(fName) Then
                    File.Delete(fName)
                End If
            Next
        End If
    End Sub

    '==================================================
    ' Full 경로로 입력받아 확장자 빼고 파일명만 리턴
    '==================================================
    Public Function FileNameWithoutExtension(ByVal FullPath As String) As String
        Return Path.GetFileNameWithoutExtension(FullPath)
    End Function

    '==================================================
    ' Full 경로로 입력받아 파일명만 리턴
    '==================================================
    Public Function FileNameWithExtension(ByVal FullPath As String) As String
        Return Path.GetFileName(FullPath)
    End Function

    '==================================================
    ' Full 경로로 입력받아 확장자 리턴
    '==================================================
    Public Function FileNameExtension(ByVal FullPath As String) As String
        Return Path.GetExtension(FullPath).TrimStart(".")
    End Function

    '*****************************************
    'input 경로로 폴더생성
    '*****************************************
    Public Sub MakeDir(ByVal Path As String)
        On Error Resume Next
        Dim strTmp() As String
        Dim i As Long, J As Long
        Dim sDir As String

        Path = Replace(Path, "/", System.IO.Path.DirectorySeparatorChar)
        strTmp = Split(Path, System.IO.Path.DirectorySeparatorChar)

        'RmDir(Path)
        For i = 0 To UBound(strTmp)
            sDir = ""
            For J = 0 To i
                sDir = sDir & strTmp(J) & System.IO.Path.DirectorySeparatorChar
            Next

            If System.IO.Directory.Exists(sDir) = False Then
                MkDir(sDir)
            End If
        Next i
        Exit Sub
    End Sub

    '========================
    'DBNull Check
    '========================
    Enum ObjectType
        StrType = 0
        IntType = 1
        DblType = 2
    End Enum

    Public Function checkDBNull(ByVal obj As Object, _
                                Optional ByVal ObjectType As ObjectType = ObjectType.StrType) As Object
        Dim objReturn As Object
        objReturn = obj

        If ObjectType = ObjectType.StrType And IsDBNull(obj) Then
            objReturn = ""
        ElseIf ObjectType = ObjectType.StrType And obj Is Nothing Then
            objReturn = ""
        ElseIf ObjectType = ObjectType.IntType And IsDBNull(obj) Then
            objReturn = 0
        ElseIf ObjectType = ObjectType.DblType And IsDBNull(obj) Then
            objReturn = 0.0
        End If

        Return objReturn
    End Function

    '====================================
    'Treeview CheckChange
    '====================================
    Public Sub TreeViewCheckChange(ByVal pNodeCollection As TreeNodeCollection, ByVal pValue As Boolean)
        For Each c As TreeNode In pNodeCollection
            c.Checked = pValue
            TreeViewCheckChange(c.Nodes, pValue)
        Next
    End Sub

    '====================================
    '데이터테이블 중복 제거후 리턴
    '====================================
    Public Function RemoveDuplicateRows(ByVal pdt As DataTable, ByVal colName As String)
        Dim hTable As Hashtable = New Hashtable
        Dim duplicateList As ArrayList = New ArrayList
        For Each row As DataRow In pdt.Rows
            If (hTable.Contains(row(colName))) Then
                duplicateList.Add(row)
            Else
                hTable.Add(row(colName), String.Empty)
            End If
        Next

        For Each drow As DataRow In duplicateList
            pdt.Rows.Remove(drow)
        Next
        Return pdt
    End Function

    '====================================
    '텍스트 개행처리
    '====================================
    Public Function ReplaceRF(ByVal pText As String) As String
        Return pText.Replace(Chr(13) & Chr(10), " ")
    End Function

    '====================================
    '엑셀파일을 grid에 넣기
    '====================================
    Public Function ImportAttendence(ByVal PrmPathExcelFile As String, ByVal pSheetName As String) As DataTable

        Try
            Dim MyConnection As New OleDbConnection
            Dim DtSet As DataTable
            Dim MyCommand As OleDbDataAdapter

            Dim fileInfo As New FileInfo(PrmPathExcelFile)
            Dim ConnectString As String = String.Empty
            If fileInfo.Extension.ToUpper = ".XLSX" Then
                ConnectString = "Provider=Microsoft.ACE.OLEDB.12.0; " & "data source='" & PrmPathExcelFile & " '; " & "Extended Properties='Excel 12.0;HDR=Yes;IMEX=1';"
            Else
                ConnectString = "Provider=Microsoft.Jet.OLEDB.4.0; " & "data source='" & PrmPathExcelFile & " '; " & "Extended Properties='Excel 8.0;HDR=Yes;IMEX=1';"
            End If

            MyConnection = New OleDbConnection(ConnectString)

            If MyConnection.State = ConnectionState.Closed Then
                MyConnection.Open()
            End If

            ' Select the data from Sheet1 of the workbook.
            MyCommand = New OleDbDataAdapter("select * from [" & pSheetName & "$]", MyConnection)
            'MyCommand.TableMappings.Add("Table", "TestTable")
            DtSet = New DataTable

            MyCommand.Fill(DtSet)
            MyConnection.Close()
            Return DtSet

        Catch ex As Exception
            MsgBox("Connection Error!" & vbCrLf & _
                   "[파일]" & PrmPathExcelFile & "=> Open이 되어 있어야 합니다.", MsgBoxStyle.Critical)
            Return Nothing
        End Try

    End Function

    '********************************************************
    ' 길이를 바이너리로 구하기
    '********************************************************
    Public Function LenB(ByVal ObjStr As String) As Integer
        If Len(ObjStr) = 0 Then Return 0
        Return System.Text.Encoding.Default.GetBytes(ObjStr).Length
    End Function

    '********************************************************
    '숫자 검증
    '********************************************************
    Public Function IsNumeric(ByVal value As String) As Boolean
        For Each _char As Char In value
            If Not Char.IsNumber(_char) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Function GetProdById(ByRef xd As XDocument, ByVal strld0 As String, ByVal strId1 As String) As XElement
        Return _
        (From p In xd.Descendants("MAIN").Descendants(strld0) _
         Where (p.Element("ID").Value.Equals(strId1)) _
         Select p).FirstOrDefault()
    End Function

    Public Function GetNumElements(ByRef xd As XDocument) As Integer
        Return _
           (From prod In xd.Descendants("MAIN") Select prod.Elements().Count()).First()
    End Function

    '********************************************************
    'xml노드 추가
    '********************************************************
    Public Sub XmlNodeAdd(ByVal pXmlWriter As XmlTextWriter, _
                           ByVal pStartEleName As String, _
                           ByVal pID As String, _
                           ByVal pValue As String)
        Try
            With pXmlWriter
                .WriteStartElement(pStartEleName)

                .WriteStartElement("ID")
                .WriteString(pID)
                .WriteEndElement()

                .WriteStartElement("VALUE")
                .WriteString(pValue)
                .WriteEndElement()

                .WriteEndElement()
            End With
        Catch ex As Exception

        End Try

    End Sub

    '********************************************************
    'resource 에서 파일 실행하기
    '********************************************************
    Public Sub ExecFileFromResource(ByVal pResourceFullName As Byte(), ByVal FilePath As String, ByVal pTempFileName As String)
        Dim tmpFileName As String = System.IO.Path.Combine(FilePath, pTempFileName)

        MakeDir(FilePath)
        IO.File.WriteAllBytes(tmpFileName, pResourceFullName)
        If IO.File.Exists(tmpFileName) Then System.Diagnostics.Process.Start(tmpFileName)
    End Sub

    '********************************************************
    '리소스에서 파일을 읽어 Temp로 저장후 파일경로 리턴
    '********************************************************
    Public Function getExecFileFromResource(ByVal pResourceFullName As Byte(), ByVal FilePath As String, ByVal pTempFileName As String) As String
        Dim tmpFileName As String = System.IO.Path.Combine(FilePath, pTempFileName)
        MakeDir(FilePath)
        IO.File.WriteAllBytes(tmpFileName, pResourceFullName)
        If Not IO.File.Exists(tmpFileName) Then
            Return String.Empty
        End If
        Return tmpFileName
    End Function

    '********************************************************
    'item GotFocus시 텍스트Box 전체 select
    '********************************************************
    Public Sub TxBSelAllGotFocus(ByVal pForm As Object, ByVal pText As TextBox)
        Dim TargetTextBox As TextBox = pText
        TargetTextBox.SelectionStart = 0
        TargetTextBox.SelectionLength = Len(TargetTextBox.Text)
    End Sub

    '********************************************************
    '로컬 IP얻기
    '********************************************************
    Public Function GetLocalIP() As String
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName)
        Dim IpAddr() As IPAddress = ipEntry.AddressList
        Dim ip As String = String.Empty

        For Each addr As IPAddress In ipEntry.AddressList
            If addr.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Dim ipAddress As String = addr.ToString
                ip = ipAddress
                Exit For
            End If
        Next

        If ip = "" Then
            Throw New Exception("No 10. IP found!")
        End If

        Return ip

    End Function
    ''' <summary>
    ''' 사용자 IP 형식이 맞는지 확인 
    ''' </summary>
    ''' <param name="strIP">IP주소</param>
    ''' <returns>Boolean</returns>
    ''' <remarks>RegexPattern으로 검색함.</remarks>
    Public Shared Function fn_CheckIPAddress(ByVal strIP As String) As Boolean
        Dim Rgx As New System.Text.RegularExpressions.Regex("\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b")
        If Rgx.IsMatch(strIP) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    '********************************************************
    '오토이미지사이즈 
    '********************************************************
    Public Sub AutosizeImage(ByVal ImageName As Bitmap, ByVal picBox As PictureBox, Optional ByVal pSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.CenterImage)
        Try
            picBox.Image = Nothing
            picBox.SizeMode = pSizeMode

            Dim imgOrg As Bitmap
            Dim imgShow As Bitmap
            Dim g As Graphics
            Dim divideBy, divideByH, divideByW As Double
            imgOrg = ImageName 'DirectCast(Bitmap.FromFile(ImagePath), Bitmap)

            divideByW = imgOrg.Width / picBox.Width
            divideByH = imgOrg.Height / picBox.Height
            If divideByW > 1 Or divideByH > 1 Then
                If divideByW > divideByH Then
                    divideBy = divideByW
                Else
                    divideBy = divideByH
                End If

                imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                g = Graphics.FromImage(imgShow)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                g.Dispose()
            Else
                imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                g = Graphics.FromImage(imgShow)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                g.Dispose()
            End If
            imgOrg.Dispose()

            picBox.Image = imgShow

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    '********************************************************
    '엑셀 타이틀 백그라운드컬라
    '********************************************************
    Public Sub xlTitleBgColor(ByVal pXlApp As Excel.Application, ByVal temp As String, ByVal pAlign As Excel.Constants)
        With pXlApp
            With .Selection
                .HorizontalAlignment = pAlign 'Excel.Constants.xlCenter
                .VerticalAlignment = Excel.Constants.xlCenter
                .WrapText = False
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = False
            End With
            .Selection.Merge()
            With .Selection.Font
                .Name = "맑은 고딕"
                .Size = 15
                .Strikethrough = False
                .Superscript = False
                .Subscript = False
                .OutlineFont = False
                .Shadow = False
                .Underline = Excel.XlUnderlineStyle.xlUnderlineStyleNone
                .ThemeColor = Excel.XlThemeColor.xlThemeColorLight1
                .TintAndShade = 0
                .ThemeFont = Excel.XlThemeFont.xlThemeFontMinor
            End With
            With .Selection.Interior
                .Pattern = Excel.Constants.xlSolid
                .PatternColorIndex = Excel.Constants.xlAutomatic
                .ThemeColor = Excel.XlThemeColor.xlThemeColorLight1
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With
            With .Selection.Font
                .ThemeColor = Excel.XlThemeColor.xlThemeColorDark1
                .TintAndShade = 0
            End With
            .ActiveCell.FormulaR1C1 = temp
        End With

    End Sub

    '********************************************************
    '엑셀 cell 머지
    '********************************************************
    Public Sub xlSelectMerge(ByVal pXlApp As Excel.Application)
        With pXlApp
            .Selection.Merge()
        End With
    End Sub

    '********************************************************
    '엑셀 라인생성
    '********************************************************
    Public Function createBgLine(ByVal xlApp As Excel.Application, _
                                  ByVal xlStartRow As Integer, _
                                  Optional ByVal pos As Char = "I") As Integer
        xlStartRow = xlStartRow + 1
        xlApp.Range("A" & xlStartRow & ":" & pos & xlStartRow).Select()
        xlApp.Rows(xlStartRow & ":" & xlStartRow).RowHeight = 7.5
        With xlApp.Selection.Interior
            .Pattern = Excel.Constants.xlSolid
            .PatternColorIndex = Excel.Constants.xlAutomatic
            .ThemeColor = Excel.XlThemeColor.xlThemeColorLight1
            .TintAndShade = 0
            .PatternTintAndShade = 0
        End With
        Return xlStartRow
    End Function

    '********************************************************
    '엑셀 컬럼 백그라운드컬라
    '********************************************************
    Public Sub xlSelectBgColor(ByVal pXlApp As Excel.Application, _
                               ByVal temp As String, _
                               ByVal pFillColor As Boolean, _
                               ByVal pAlign As Excel.Constants, _
                               Optional ByRef Merge As Boolean = True, _
                               Optional ByRef ColorIndex As Integer = 1, _
                               Optional ByRef border As Boolean = True, _
                               Optional ByRef CellColor As Integer = 3, _
                               Optional ByRef TintAndShade As Double = -0.249977111117893)

        With pXlApp
            With .Selection.Font
                .Name = "굴림체"
                .Size = 9
                .Strikethrough = False
                .Superscript = False
                .Subscript = False
                .OutlineFont = False
                .Shadow = False
                .ColorIndex = ColorIndex
                .TintAndShade = 0
            End With
            With .Selection
                .HorizontalAlignment = pAlign 'Excel.Constants.xlCenter
                .VerticalAlignment = Excel.Constants.xlCenter
                .WrapText = False
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = False
            End With

            If Merge = True Then
                .Selection.Merge()
            End If

            If pFillColor = True Then
                With .Selection.Interior
                    .Pattern = Excel.Constants.xlSolid
                    .PatternColorIndex = Excel.Constants.xlAutomatic
                    '.ThemeColor = Excel.XlThemeColor.xlThemeColorDark2
                    '.ThemeColor = Excel.XlThemeColor.xlThemeColorAccent6
                    .ThemeColor = CellColor
                    .TintAndShade = TintAndShade
                    '.TintAndShade = -0.249977111117893
                    .PatternTintAndShade = 0
                End With
            End If
            .Selection.Borders(Excel.XlBordersIndex.xlDiagonalDown).LineStyle = Excel.Constants.xlNone
            .Selection.Borders(Excel.XlBordersIndex.xlDiagonalUp).LineStyle = Excel.Constants.xlNone

            If (border = True) Then
                With .Selection.Borders(Excel.XlBordersIndex.xlEdgeLeft)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
                With .Selection.Borders(Excel.XlBordersIndex.xlEdgeTop)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
                With .Selection.Borders(Excel.XlBordersIndex.xlEdgeBottom)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
                With .Selection.Borders(Excel.XlBordersIndex.xlEdgeRight)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
                With .Selection.Borders(Excel.XlBordersIndex.xlInsideVertical)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
                With .Selection.Borders(Excel.XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = Excel.XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = Excel.XlBorderWeight.xlThin
                End With
            End If

            If temp <> String.Empty Or temp <> "" Then
                .ActiveCell.FormulaR1C1 = temp
            End If


        End With

    End Sub

    '********************************************************
    'richtextbox 의 Current한 row 및 column의 상태 텍스트 리턴
    '********************************************************
    Public Function GetLineNumberString(ByVal rtb As RichTextBox) As String
        Try
            Dim Position As Integer = 0
            Dim LIne As Integer = 0
            Dim Col As Integer = 0
            With rtb
                Position = .SelectionStart
                LIne = .GetLineFromCharIndex(Position)
                Col = Position - .GetFirstCharIndexOfCurrentLine
            End With
            Return "줄 " & LIne + 1 & " " & "열 " & Col + 1
        Catch ex As Exception
            Return "줄 0 열 0"
        End Try
    End Function

    '********************************************************
    '파일 컨트롤
    '********************************************************
    Public Sub FileCopy(ByVal pFromFullPathName As String, ByVal pToFullPathName As String, ByVal pDelete As Boolean)
        'pdelete is true  => 기존파일 삭제후 복사
        'pdelete is false => 기존파일 있으면 Path 없으면 복사
        On Error Resume Next
        If File.Exists(pToFullPathName) Then
            If pDelete = True Then
                '삭제후복사
                File.Delete(pToFullPathName)
                File.Copy(pFromFullPathName, pToFullPathName)
            End If
        Else
            File.Copy(pFromFullPathName, pToFullPathName)
        End If
    End Sub

    '********************************************************
    'Datatable을 filter에 따라 조회
    '********************************************************
    Public Function SelectIntoDataTable(ByVal selectFilter As String, ByVal sourceDataTable As DataTable) As DataTable
        Dim newDataTable As DataTable = sourceDataTable.Clone
        Dim dataRows As DataRow() = sourceDataTable.Select(selectFilter)
        Dim typeDataRow As DataRow

        For Each typeDataRow In dataRows
            newDataTable.ImportRow(typeDataRow)
        Next

        Return newDataTable

    End Function

    '********************************************************
    'Text파일의 인코딩 타입을 탐지
    '********************************************************
    Public Function GetFileEncoding(ByVal path As String) As Encoding
        If path Is Nothing Then
            Throw New ArgumentNullException("path")
        End If
        Dim encodings = System.Text.Encoding.GetEncodings().[Select](Function(e) e.GetEncoding()).[Select](Function(e) New With { _
                                                                                         Key .Encoding = e, _
                                                                                         Key .Preamble = e.GetPreamble() _
                                                                                        }).Where(Function(e) e.Preamble.Any()).ToArray()
        Dim maxPrembleLength = encodings.Max(Function(e) e.Preamble.Length)
        Dim buffer As Byte() = New Byte(maxPrembleLength - 1) {}
        Using stream = File.OpenRead(path)
            stream.Read(buffer, 0, CInt(Math.Min(maxPrembleLength, stream.Length)))
        End Using
        Return If(encodings.Where(Function(enc) enc.Preamble.SequenceEqual(buffer.Take(enc.Preamble.Length))).[Select](Function(enc) enc.Encoding).FirstOrDefault(), Encoding.[Default])
    End Function

    '********************************************************
    '사용자 Mac 주소 리턴
    '********************************************************
    Public Function GetMacAddress() As DataTable
        Dim nic As NetworkInterface = Nothing
        Dim outDt As DataTable = New DataTable

        Try
            With outDt
                .Clear()
                .Columns.Add(New DataColumn("IF_NAME", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("MAC_ADDRESS", System.Type.GetType("System.String")))
                .Columns.Add(New DataColumn("IF_TYPE", System.Type.GetType("System.String")))
            End With

            For Each nic In NetworkInterface.GetAllNetworkInterfaces
                If nic.GetPhysicalAddress.ToString IsNot Nothing Then
                    outDt.Rows.Add(nic.Name.ToString, _
                                   nic.GetPhysicalAddress.ToString, _
                                   nic.NetworkInterfaceType.ToString)
                End If
            Next
        Catch ex As Exception
            Return Nothing
        End Try
        Return outDt

    End Function

    ''********************************************************
    ''XML파일에서 SQL얻기
    ''********************************************************
    'Public Function GetSql(ByVal xmlFilename As String, ByVal GroupName As String, ByVal sqlid As String) As String
    '    Dim doc As New XmlDocument()
    '    Try
    '        doc.Load(Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(xmlFilename))
    '        Dim test As XmlNode = doc.SelectSingleNode("root").SelectSingleNode("itemgroups").SelectSingleNode(GroupName)
    '        Dim sql As XmlNode = doc.SelectSingleNode("root").SelectSingleNode("itemgroups").SelectSingleNode(GroupName).SelectSingleNode(sqlid).SelectSingleNode("sql")
    '        Dim sqlText As String = sql.InnerText.TrimEnd().TrimEnd(";")
    '        Return sqlText
    '    Catch ex As Exception
    '        Console.WriteLine(ex.Message)
    '        Return String.Empty
    '    End Try
    'End Function

    '********************************************************
    'XML파일에서 SQL얻기
    '********************************************************
    Public Function GetSql(ByVal xmlStream As System.IO.Stream, ByVal GroupName As String, ByVal sqlid As String) As String
        Dim doc As New XmlDocument()
        Try
            SyncLock xmlStream
                xmlStream.Position = 0
                doc.Load(xmlStream)
                Dim test As XmlNode = doc.SelectSingleNode("root").SelectSingleNode("itemgroups").SelectSingleNode(GroupName)
                Dim sql As XmlNode = doc.SelectSingleNode("root").SelectSingleNode("itemgroups").SelectSingleNode(GroupName).SelectSingleNode(sqlid).SelectSingleNode("sql")
                Dim sqlText As String = sql.InnerText.TrimEnd().TrimEnd(";")
                Return sqlText
            End SyncLock

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    '**************************************************************
    'Excel에서 Cell 숫자를 특정이름으로 변환
    '**************************************************************
    Public Function GetCornerName(ByVal Idx As Integer) As String
        Dim share As Integer = Math.Truncate(Idx / 26)
        Dim rest As Integer = Idx Mod 26
        If rest = 0 Then
            rest = 1
        End If

        Dim retStr As String = String.Empty
        If (share >= 26) Then
            retStr = GetCornerName(share)
        ElseIf (Not share = 0) Then
            retStr = retStr + Chr(64 + share)
        End If

        Return retStr + Chr(64 + rest)
    End Function

    '********************************************************
    'String을 UTF8 캐릭터셋으로 변경
    '********************************************************
    Public Function encode(ByVal str As String) As String
        'supply True as the construction parameter to indicate 
        'that you wanted the class to emit BOM (Byte Order Mark) 
        'NOTE: this BOM value is the indicator of a UTF-8 string 
        Dim utf8Encoding As New System.Text.UTF8Encoding(True)
        Dim encodedString() As Byte

        encodedString = utf8Encoding.GetBytes(str)

        Return utf8Encoding.GetString(encodedString)
    End Function

    '===================
    'StatusBar Step별 증가
    '===================
    Public Sub IncreProgressBar(ByVal pProgressBar As ToolStripProgressBar)
        If pProgressBar.Value < pProgressBar.Maximum Then
            pProgressBar.Increment(pProgressBar.Step)
        Else
            pProgressBar.Value = pProgressBar.Minimum
        End If
    End Sub



    '********************************************************
    'UTF8 String을 EUC-KR 캐릭터셋으로 변경
    '********************************************************
    Public Function encodeEucKr(ByVal str As String) As String
        'supply True as the construction parameter to indicate 
        'that you wanted the class to emit BOM (Byte Order Mark) 
        'NOTE: this BOM value is the indicator of a UTF-8 string 
        Dim utf8Encoding As New System.Text.UTF8Encoding(True)
        Dim euckrEncoding As System.Text.Encoding = Encoding.GetEncoding(51949)
        'Dim encodedString() As Byte = Encoding.Convert(Encoding.UTF8, euckrEncoding, utf8Encoding.GetBytes(str))
        Dim encodedString() As Byte = euckrEncoding.GetBytes(str)
        Dim eucstr As String = euckrEncoding.GetString(encodedString)
        'Dim psUnicode As Char() = utf8Encoding.UTF8.GetChars(Encoding.Convert(Encoding.GetEncoding("euc-kr"), Encoding.UTF8, utf8Encoding.GetBytes(str)))
        'Return New String(psUnicode)

        Return eucstr
    End Function

    '********************************************************
    'UTF8 String을 EUC-KR 캐릭터셋으로 변경
    '********************************************************
    Public Function encodeMswin949(ByVal str As String) As String
        'supply True as the construction parameter to indicate 
        'that you wanted the class to emit BOM (Byte Order Mark) 
        'NOTE: this BOM value is the indicator of a UTF-8 string 
        Dim utf8Encoding As New System.Text.UTF8Encoding(True)
        Dim win949Encoding As System.Text.Encoding = Encoding.GetEncoding("ks_c_5601-1987")
        'Dim encodedString() As Byte = Encoding.Convert(Encoding.UTF8, euckrEncoding, utf8Encoding.GetBytes(str))
        Dim encodedString() As Byte = win949Encoding.GetBytes(str)
        Dim eucstr As String = win949Encoding.GetString(encodedString)
        'Dim psUnicode As Char() = utf8Encoding.UTF8.GetChars(Encoding.Convert(Encoding.GetEncoding("euc-kr"), Encoding.UTF8, utf8Encoding.GetBytes(str)))
        'Return New String(psUnicode)

        Return eucstr
    End Function

    'Encoding Detect
    Public Function DetectEnc(ByVal FilePath As String) As Encoding
        Dim enc As Encoding = Encoding.Default
        Try
            Dim buffer() As Byte = New Byte(5) {}
            Dim file As FileStream = New FileStream(FilePath, FileMode.Open)
            file.Read(buffer, 0, 5)
            file.Close()

            If buffer(0) = &HEF And buffer(1) = &HBB And buffer(2) = &HBF Then   'UTF8 BOM
                enc = Encoding.UTF8
            ElseIf buffer(0) = &HFF And buffer(1) = &HFE And buffer(2) = 0 And buffer(3) = 0 Then   'UTF32 Little Endian
                enc = Encoding.UTF32
            ElseIf buffer(0) = 0 And buffer(1) = 0 And buffer(2) = &HFE And buffer(3) = &HFF Then   'UTF32 Bigendian
                enc = New UTF32Encoding(True, True)
            ElseIf buffer(0) = &H2B And buffer(1) = &H2F And buffer(2) = &H76 Then
                enc = Encoding.UTF7
            ElseIf buffer(0) = &HFE And buffer(1) = &HFF Then   'UTF16 BigEndian
                enc = Encoding.BigEndianUnicode
            ElseIf buffer(0) = &HFF And buffer(1) = &HFE Then   'UTF16 Little Endian
                enc = Encoding.Unicode
            ElseIf buffer(0) = &HC4 And buffer(1) = &HAE And buffer(2) = &HB6 And buffer(3) = &HF3 Then  'DEFAULT/ASCII
                enc = Encoding.ASCII
            Else  'UTF8 NO BOM
                ' enc = New UTF8Encoding(False)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return enc
    End Function
    '********************************************************
    'DataTable의 특정 컬럼 데이터를 Array로 변환
    '********************************************************
    Public Function ConvDtToArray(dt As DataTable, columnName As String) As Object()
        Dim arrayList As New ArrayList
        Try
            For Each row As DataRow In dt.Rows
                arrayList.Add(row.Item(columnName))
            Next
            Return arrayList.ToArray
        Catch ex As Exception
            Return arrayList.ToArray
        End Try
    End Function

    '********************************************************
    'SQL 텍스박스 초기화
    '********************************************************
    Public Sub SetSqlTextBox(ByVal pFTB As FastColoredTextBoxNS.FastColoredTextBox)
        Dim SameWordsStyle As New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))
        With pFTB
            .ClearStylesBuffer()
            .Range.ClearStyle(StyleIndex.All)
            .AddStyle(SameWordsStyle)
            .Language = Language.SQL
            .OnSyntaxHighlight(New TextChangedEventArgs(.Range))
            .CurrentLineColor = Color.FromArgb(100, 210, 210, 255)
        End With
    End Sub

    '********************************************************
    'Treegridview 노드 전체 펼치기
    '********************************************************
    Public Sub TreeGridViewAllExpand(ByVal pGrid As TreeGridView)
        For Each row As TreeGridNode In pGrid.Rows
            If row.HasChildren Then
                row.Expand()
            End If
        Next
    End Sub

    '********************************************************
    'Treegridview 노드 전체 닫기
    '********************************************************
    Public Sub TreeGridViewAllCollapse(ByVal pGrid As TreeGridView)
        For Each row As TreeGridNode In pGrid.Rows
            If row.HasChildren Then
                row.Collapse()
            End If
        Next
    End Sub

    Private Function RemoveComment(stmt As String) As String
        Try
            Dim RegExPattern As String = "(--[^\r\n]*)|(/\*[\w\W]*?(?=\*/)\*/)"

            Dim m As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(stmt, RegExPattern)
            For iCount = 0 To m.Count - 1
                stmt = stmt.Replace(m(iCount).Value, String.Empty)
            Next
            stmt = stmt.Replace(vbCrLf, " ")

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return stmt
    End Function
    Private Function subObjName(tStr As String) As String
        Try
            Dim pidx As Integer = tStr.IndexOf(".")

            If pidx > 0 Then
                tStr = tStr.Substring(pidx + 1)
            End If

            Dim sidx As Integer = tStr.IndexOf("(")
            If sidx > 0 Then
                tStr = tStr.Substring(0, sidx)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return tStr
    End Function
    Private Function subSchName(tStr As String) As String
        Try
            Dim pidx As Integer = tStr.IndexOf(".")

            If pidx > 0 Then
                tStr = tStr.Substring(0, pidx)
            Else
                tStr = String.Empty
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return tStr
    End Function
    'UDF 소스를 분석하여 오브젝트 명을 추출
    Private Function getObjectString(Stmt As String) As String
        Dim objNm As String = String.Empty
        Try
            Stmt = RemoveComment(Stmt)
            If Stmt <> String.Empty Then

                Dim token As String() = Stmt.Split(" ".ToCharArray, 10, StringSplitOptions.RemoveEmptyEntries)
                If token(0).Trim.ToUpper = "CREATE" And token.Count > 1 Then
                    If token(1).Trim.ToUpper = "OR" And token.Count > 2 Then
                        If token(2).Trim.ToUpper = "REPLACE" And token.Count > 3 Then
                            If token(3).Trim.ToUpper = "PACKAGE" And token.Count > 4 Then
                                If token(4).Trim.ToUpper = "BODY" And token.Count > 5 Then
                                    objNm = token(5)
                                ElseIf token.Count > 0 Then
                                    objNm = token(4)
                                End If
                            ElseIf (token(3).Trim.ToUpper = "FUNCTION" Or token(3).Trim.ToUpper = "PROCEDURE") And token.Count > 4 Then
                                objNm = token(4)
                            End If

                        End If
                    ElseIf (token(1).Trim.ToUpper = "FUNCTION" Or token(1).Trim.ToUpper = "PROCEDURE") And token.Count > 2 Then
                        objNm = token(2)
                    ElseIf token(1).Trim.ToUpper = "PACKAGE" And token.Count > 2 Then
                        If token(2).Trim.ToUpper = "BODY" And token.Count > 3 Then
                            objNm = token(3)
                        ElseIf token.Count > 2 Then
                            objNm = token(2)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return objNm
    End Function
    Public Function getObjectName(Stmt As String) As String
        Dim obj As String = String.Empty
        Try
            obj = getObjectString(Stmt)
            If Not obj = String.Empty Then
                obj = subObjName(obj)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return obj
    End Function
    Public Function getSchemaName(Stmt As String) As String
        Dim obj As String = String.Empty
        Try
            obj = getObjectString(Stmt)
            If Not obj = String.Empty Then
                obj = subSchName(obj)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return obj
    End Function
    Public Function getStmtValidChkSql(Stmt As String) As String
        Dim obj As String = String.Empty
        Dim ddl As String = Stmt
        Dim schemaNm As String = String.Empty
        Dim type As String = String.Empty
        Try
            obj = getObjectString(Stmt)
            type = getUdfType(Stmt)
            ddl = ddl.Substring(ddl.ToUpper.IndexOf(type))
            If Not obj = String.Empty Then
                schemaNm = subSchName(obj) & "."
                Dim pad As String = "".PadRight(schemaNm.Length + 1)
                ddl = ddl.Replace(schemaNm, pad)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return ddl
    End Function
    'UDF 소스를 분석하여 오브젝트 타입을 추출
    Public Function getUdfType(Stmt As String) As String
        Dim objNm As String = String.Empty
        Try
            Stmt = RemoveComment(Stmt)
            If Stmt <> String.Empty Then

                Dim token As String() = Stmt.Split(" ".ToCharArray, 10, StringSplitOptions.RemoveEmptyEntries)
                If token(0).Trim.ToUpper = "CREATE" And token.Count > 1 Then
                    If token(1).Trim.ToUpper = "OR" And token.Count > 2 Then
                        If token(2).Trim.ToUpper = "REPLACE" And token.Count > 3 Then
                            If token(3).Trim.ToUpper = "PACKAGE" And token.Count > 4 Then
                                'If token(4).Trim.ToUpper = "BODY" And token.Count > 5 Then
                                '    objNm = subObjName(token(5))
                                'ElseIf token.Count > 0 Then
                                '    objNm = subObjName(token(4))
                                'End If
                                objNm = "PACKAGE"
                            ElseIf token(3).Trim.ToUpper = "FUNCTION" And token.Count > 4 Then
                                objNm = "FUNCTION"
                            ElseIf token(3).Trim.ToUpper = "PROCEDURE" And token.Count > 4 Then
                                objNm = "PROCEDURE"
                            End If
                        End If
                    ElseIf token(1).Trim.ToUpper = "FUNCTION" And token.Count > 2 Then
                        objNm = "FUNCTION"
                    ElseIf token(1).Trim.ToUpper = "PROCEDURE" And token.Count > 2 Then
                        objNm = "PROCEDURE"
                    ElseIf token(1).Trim.ToUpper = "PACKAGE" And token.Count > 2 Then
                        'If token(2).Trim.ToUpper = "BODY" And token.Count > 3 Then
                        '    objNm = subObjName(token(3))
                        'ElseIf token.Count > 2 Then
                        '    objNm = subObjName(token(2))
                        'End If
                        objNm = "PACKAGE"
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return objNm
    End Function
    'UDF 소스를 분석하여 아규먼트를 추출
    Public Function getArgs(Stmt As String) As String
        Dim args As String = String.Empty
        Try
            Stmt = RemoveComment(Stmt)
            If Stmt <> String.Empty Then
                Dim token As String() = Stmt.Split(" ".ToCharArray, 10, StringSplitOptions.RemoveEmptyEntries)
                Dim hasArgs As Boolean = False

                If token(0).Trim.ToUpper = "CREATE" And token.Count > 1 Then
                    If token(1).Trim.ToUpper = "OR" And token.Count > 2 Then
                        If token(2).Trim.ToUpper = "REPLACE" And token.Count > 3 Then
                            If token(3).Trim.ToUpper = "PACKAGE" And token.Count > 4 Then
                                If token(4).Trim.ToUpper = "BODY" And token.Count > 6 Then
                                    If token(5).IndexOf("(") > -1 Or token(6).IndexOf("(") > -1 Then
                                        hasArgs = True
                                    End If
                                ElseIf token.Count > 5 Then
                                    If token(4).IndexOf("(") > -1 Or token(5).IndexOf("(") > -1 Then
                                        hasArgs = True
                                    End If
                                End If
                            ElseIf (token(3).Trim.ToUpper = "FUNCTION" Or token(3).Trim.ToUpper = "PROCEDURE") And token.Count > 5 Then
                                If token(4).IndexOf("(") > -1 Or token(5).IndexOf("(") > -1 Then
                                    hasArgs = True
                                End If
                            End If
                        End If
                    ElseIf (token(1).Trim.ToUpper = "FUNCTION" Or token(1).Trim.ToUpper = "PROCEDURE") And token.Count > 3 Then
                        If token(2).IndexOf("(") > -1 Or token(3).IndexOf("(") > -1 Then
                            hasArgs = True
                        End If
                    ElseIf token(1).Trim.ToUpper = "PACKAGE" And token.Count > 2 Then
                        If token(2).Trim.ToUpper = "BODY" And token.Count > 4 Then
                            If token(3).IndexOf("(") > -1 Or token(4).IndexOf("(") > -1 Then
                                hasArgs = True
                            End If
                        ElseIf token.Count > 3 Then
                            If token(2).IndexOf("(") > -1 Or token(3).IndexOf("(") > -1 Then
                                hasArgs = True
                            End If
                        End If
                    End If
                End If

                'If token.Count > 5 Then
                '    If token(0).Trim.ToUpper = "CREATE" Then
                '        If token(1).Trim.ToUpper = "OR" Then
                '            If token(2).Trim.ToUpper = "REPLACE" Then
                '                If token(3).Trim.ToUpper = "PACKAGE" Then
                '                    If token(4).Trim.ToUpper = "BODY" Then
                '                        If token(5).IndexOf("(") > -1 Or token(6).IndexOf("(") > -1 Then
                '                            hasArgs = True
                '                        End If
                '                    Else
                '                        If token(4).IndexOf("(") > -1 Or token(5).IndexOf("(") > -1 Then
                '                            hasArgs = True
                '                        End If
                '                    End If
                '                Else
                '                    If token(4).IndexOf("(") > -1 Or token(5).IndexOf("(") > -1 Then
                '                        hasArgs = True
                '                    End If
                '                End If
                '            End If
                '        ElseIf token(1).Trim.ToUpper = "FUNCTION" Or token(1).Trim.ToUpper = "PROCEDURE" Then
                '            If token(2).IndexOf("(") > -1 Or token(3).IndexOf("(") > -1 Then
                '                hasArgs = True
                '            End If
                '        ElseIf token(1).Trim.ToUpper = "PACKAGE" Then
                '            If token(2).Trim.ToUpper = "BODY" Then
                '                If token(3).IndexOf("(") > -1 Or token(4).IndexOf("(") > -1 Then
                '                    hasArgs = True
                '                End If
                '            Else
                '                If token(2).IndexOf("(") > -1 Or token(3).IndexOf("(") > -1 Then
                '                    hasArgs = True
                '                End If
                '            End If
                '        End If
                '    End If
                'End If
                If hasArgs = True Then
                    Dim stIdx As Integer = Stmt.IndexOf("(")
                    Dim edIdx As Integer = Stmt.IndexOf(")", stIdx)

                    If edIdx > -1 Then
                        Dim length As Integer = edIdx - stIdx + 1
                        args = Stmt.Substring(stIdx, length)
                        Console.WriteLine("ARGS : " & args)
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return args
    End Function

    Public Function ConvMilNum(num As Double) As String
        Dim tNum As String = String.Empty
        Try
            Dim int_num As Double = num / 1000
            Dim danw As String = String.Empty
            If num = 0 Then
                int_num = 0
            ElseIf num < 1000 Then
                int_num = num
            ElseIf num < 1000000 Then
                danw = "K"
                int_num = num / 1000
            ElseIf num >= 1000000 Then
                danw = "M"
                int_num = num / 1000 / 1000
            End If
            tNum = Math.Round(int_num, 2) & danw
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return tNum
    End Function

    Public Function CreateHtmlTable(ByRef dt As DataTable) As String
        Dim strBuilder As New System.Text.StringBuilder
        Try
            If dt.Rows.Count = 0 Then
                Return String.Empty
            ElseIf dt.Columns.Count = 1 Then
                If dt.Rows(0).Item(0).ToString = String.Empty Then
                    Return String.Empty
                End If
            End If

            strBuilder.AppendLine("<html lang=""en""><head><title>AWR Report for DB: CHOBITS, Inst: CHOBITS, Snaps: 210-212</title>")
            strBuilder.AppendLine("<style type=""text/css"">")
            strBuilder.AppendLine("body.awr {font:bold 10pt Arial,Helvetica,Geneva,sans-serif;color:black; background:White;}")
            strBuilder.AppendLine("pre.awr  {font:8pt Courier;color:black; background:White;}")
            strBuilder.AppendLine("h1.awr   {font:bold 20pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;border-bottom:1px solid #cccc99;margin-top:0pt; margin-bottom:0pt;padding:0px 0px 0px 0px;}")
            strBuilder.AppendLine("h2.awr   {font:bold 18pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;margin-top:4pt; margin-bottom:0pt;}")
            strBuilder.AppendLine("h3.awr {font:bold 16pt Arial,Helvetica,Geneva,sans-serif;color:#336699;background-color:White;margin-top:4pt; margin-bottom:0pt;}")
            strBuilder.AppendLine("li.awr {font: 8pt Arial,Helvetica,Geneva,sans-serif; color:black; background:White;}")
            strBuilder.AppendLine("th.awrnobg {font:bold 8pt Arial,Helvetica,Geneva,sans-serif; color:black; background:White;padding-left:4px; padding-right:4px;padding-bottom:2px}")
            strBuilder.AppendLine("th.awrbg {font:bold 8pt Arial,Helvetica,Geneva,sans-serif; color:White; background:#0066CC;padding-left:4px; padding-right:4px;padding-bottom:2px}")
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

            strBuilder.AppendLine("<table border=""1"" summary=""This table displays Foreground Wait Events and their wait statistics"">")

            Dim length As Integer = 0
            Dim times As Integer = 180

            strBuilder.AppendLine("<tr>")
            For i As Integer = 0 To dt.Columns.Count - 1
                strBuilder.Append("<th class=""awrbg"" scope=""col"">")
                strBuilder.Append(dt.Columns(i).ColumnName)
                strBuilder.AppendLine("</th>")
            Next
            strBuilder.AppendLine("</tr>")

            Dim tStr As String = String.Empty
            Dim class_str As String() = New String() {"awrc", "awrnc"}

            For i As Integer = 0 To dt.Rows.Count - 1
                strBuilder.Append("<tr>")
                For j As Integer = 0 To dt.Columns.Count - 1
                    tStr = dt.Rows(i).Item(j).ToString()
                    If j = 0 Then
                        strBuilder.Append("<td scope=""row"" class='" & class_str(i Mod 2) & "'>" & _
                                          tStr.Replace(" ", "<font color='#C0C0C0'>_</font>").Replace(vbCrLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbCr, "<font color='#C0C0C0'>$<br></font>") & "</td>")
                    Else
                        'strBuilder.Append("<td class='" & class_str(i Mod 2) & "'>" & tStr & "</td>")
                        strBuilder.Append("<td class='" & class_str(i Mod 2) & "'>" & tStr.Replace(" ", "<font color='#C0C0C0'>_</font>").Replace(vbCrLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbLf, "<font color='#C0C0C0'>$<br></font>").Replace(vbCr, "<font color='#C0C0C0'>$<br></font>") & "</td>")
                    End If
                Next
                strBuilder.AppendLine("</tr>")
            Next
            strBuilder.AppendLine("</table><p />")
            strBuilder.Append("</body></html>  ")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return strBuilder.ToString
    End Function
    Public Function ConvertChartToInteger(ByRef chr As Char) As Integer
        Try
            Dim num As Integer = Convert.ToInt32(chr)
            If num >= 48 And num <= 57 Then
                num -= 48
            ElseIf num < 0 Or num > 9 Then
                num -= 65296
            End If
            Return num
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
