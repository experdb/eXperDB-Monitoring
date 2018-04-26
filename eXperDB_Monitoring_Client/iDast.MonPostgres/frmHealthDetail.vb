Public Class frmHealthDetail
    Private _IntInstanceID As Integer = 0
    Private _HealthSeq As String = ""
    Private _HealthItem As String = ""
    Private _Th As Threading.Thread = Nothing
    Private _RegDate As String = Now.ToString("yyyyMMdd")
    Private _AgentCn As eXperDB.ODBC.DXODBC = Nothing
    Private _SQLCols As New List(Of SQLInfo)
    Private _AgentInfo As structAgent = Nothing
    Private _WMargin As Integer = 50
    Private _HMargin As Integer = 50
    Private _HealthLevel As Integer = 0
    Private Class SQLInfo
        Dim _SQL As Integer
        ReadOnly Property SQL As Integer
            Get
                Return _sql
            End Get
        End Property
        Dim _User As Integer
        ReadOnly Property User As Integer
            Get
                Return _USer
            End Get
        End Property
        Dim _DB As Integer
        ReadOnly Property DB As Integer
            Get
                Return _DB
            End Get
        End Property
        Public Sub New(ByVal colSQL As Integer, ByVal colUser As Integer, ByVal colDBNm As Integer)
            _SQL = colSQL
            _User = colUser
            _DB = colDBNm
        End Sub
    End Class



    Public Sub New(ByVal AgentCn As eXperDB.ODBC.DXODBC, ByVal intInstance As Integer, ByVal RegDate As String, ByVal HealthItem As String, ByVal HealthSeq As String, ByVal ShowValue As String, ByVal AgentInfo As structAgent, ByVal intLevel As Integer)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
        _IntInstanceID = intInstance
        _HealthSeq = HealthSeq
        _HealthItem = HealthItem
        _RegDate = RegDate
        _AgentCn = New DXODBC(AgentCn.ODBCConninfo, 30)
        _AgentInfo = AgentInfo
        _HealthLevel = intLevel
        dgvinfo.AutoGenerateColumns = False

        lblitmNm.Text = p_clsMsgData.fn_GetData("F201", p_clsMsgData.fn_GetData(_HealthItem))
        'lblDesc.Text = p_clsMsgData.fn_GetData("F202", "")
        lblDesc.Text = p_clsMsgData.fn_GetData("F202", p_clsMsgData.fn_GetSpecificData(_HealthItem, "DESC"))
        lblResult.Text = p_clsMsgData.fn_GetData("F203", ShowValue)
        lblinfo.Text = p_clsMsgData.fn_GetData("F204")
        lblParameter.Text = p_clsMsgData.fn_GetData("F205", p_clsMsgData.fn_GetSpecificData(_HealthItem, "COMMENTS"))
        lblCurTime.Text = p_clsMsgData.fn_GetData("F206", "0000-00-00 00:00:00")

        Me.Text = "Health detail"

        btnClose.Text = p_clsMsgData.fn_GetData("F021")
    End Sub

    Public Sub AddColumns(ByVal Dgv As BaseControls.DataGridView, ByVal PropNm As String, ByVal Caption As String, ByVal Type As String, ByVal strFormat As String, ByVal intWidth As Integer)


        Select Case Type.ToUpper
            Case "TEXT"
                Dim tmpCol As New DataGridViewTextBoxColumn
                tmpCol.Name = "colDgv" & PropNm
                tmpCol.DataPropertyName = PropNm
                tmpCol.HeaderText = Caption
                tmpCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                tmpCol.DefaultCellStyle.Format = strFormat
                tmpCol.ReadOnly = True
                tmpCol.Width = intWidth
                tmpCol.MinimumWidth = intWidth
                tmpCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                tmpCol.DefaultCellStyle.ForeColor = System.Drawing.Color.White
                tmpCol.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
                tmpCol.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
                Dgv.Columns.Add(tmpCol)


            Case "DATASIZE"
                Dim tmpCol As New DataGridViewDataSizeColumn
                tmpCol.Name = "colDgv" & PropNm
                tmpCol.DataPropertyName = PropNm
                tmpCol.HeaderText = Caption
                tmpCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                tmpCol.DefaultCellStyle.Format = strFormat
                tmpCol.BaseUnit = DataGridViewDataSizeCell.SizeUnit.KB
                tmpCol.SortMode = DataGridViewColumnSortMode.Automatic
                tmpCol.ReadOnly = True
                tmpCol.Width = intWidth
                tmpCol.MinimumWidth = intWidth
                tmpCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                tmpCol.DefaultCellStyle.ForeColor = System.Drawing.Color.White
                tmpCol.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
                tmpCol.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
                Dgv.Columns.Add(tmpCol)

            Case "NUMBER"
                Dim tmpCol As New DataGridViewTextBoxColumn
                tmpCol.Name = "colDgv" & PropNm
                tmpCol.DataPropertyName = PropNm
                tmpCol.HeaderText = Caption
                tmpCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                tmpCol.DefaultCellStyle.Format = strFormat
                tmpCol.ReadOnly = True
                tmpCol.Width = intWidth
                tmpCol.MinimumWidth = intWidth
                tmpCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                tmpCol.DefaultCellStyle.ForeColor = System.Drawing.Color.White
                tmpCol.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
                tmpCol.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
                Dgv.Columns.Add(tmpCol)
            Case "TIMESTAMP"
                Dim tmpCol As New DataGridViewTimespanColumn
                tmpCol.Name = "colDgv" & PropNm
                tmpCol.DataPropertyName = PropNm
                tmpCol.HeaderText = Caption
                tmpCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                tmpCol.FormatString = strFormat
                tmpCol.ReadOnly = True
                tmpCol.Width = intWidth
                tmpCol.MinimumWidth = intWidth
                tmpCol.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
                tmpCol.DefaultCellStyle.ForeColor = System.Drawing.Color.White
                tmpCol.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
                tmpCol.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
                Dgv.Columns.Add(tmpCol)

        End Select

    End Sub

    Private Sub sb_Search()

        Me.Invoke(Sub()
                      If _AgentCn.ODBCConninfo.ConnectionString <> "" Then
                          Dim clsQuery As New clsQuerys(_AgentCn)
                          'Dim CurDate As DateTime = Date.MinValue
                          Dim dtTable As DataTable = Nothing
                          Select Case _HealthItem.ToUpper
                              Case "BUFFERHITRATIO"
                                  dtTable = clsQuery.SelectHCHKBufferHitRatio(_IntInstanceID, _RegDate, _HealthSeq)
                              Case "ACTIVECONNECTION"
                                  dtTable = clsQuery.SelectHCHKActiveConnection(_RegDate, _HealthSeq)
                              Case "COMMITRATIO"
                                  dtTable = clsQuery.SelectHCHKCommitRatio(_RegDate, _HealthSeq)
                              Case "CONNECTIONFAIL"
                                  Dim arrValues As String() = _HealthSeq.Split(",")
                                  If arrValues.Length < 3 Then
                                      lblitmNm.Text += " - ERROR"
                                  Else
                                      dtTable = clsQuery.SelectHCHKConnectionFail(_IntInstanceID, _RegDate, arrValues(0), arrValues(1), arrValues(2))
                                  End If
                              Case "DISKUSAGE"
                                  dtTable = clsQuery.SelectHCHKDiskUsage(_RegDate, _HealthSeq)
                              Case "LOCKCNT"
                                  dtTable = clsQuery.SelectHCHKLockCnt(_RegDate, _HealthSeq)
                                  ' 하드 코딩이외에는 MakeLanguage 가 너무 복잡해짐 ㅠㅠ 형식은 colDgv + "SQL COLUMN NAME"
                                  _SQLCols.Add(New SQLInfo(dgvinfo.Columns("colDgvBLOCKED_STATEMENT").Index, -1, -1))
                                  _SQLCols.Add(New SQLInfo(dgvinfo.Columns("colDgvBLOCKING_STATEMENT").Index, -1, -1))
                              Case "LASTANALYZE"
                                  dtTable = clsQuery.SelectHCHKLastAnalyze(_IntInstanceID, _RegDate, _HealthSeq)
                              Case "LASTVACUUM"
                                  dtTable = clsQuery.SelectHCHKLastVacuum(_IntInstanceID, _RegDate, _HealthSeq)
                              Case "LONGRUNSQL"
                                  dtTable = clsQuery.SelectHCHKLongRunSql(_IntInstanceID, _RegDate, _HealthSeq)
                                  ' 하드 코딩이외에는 MakeLanguage 가 너무 복잡해짐 ㅠㅠ 형식은 colDgv + "SQL COLUMN NAME"
                                  _SQLCols.Add(New SQLInfo(dgvinfo.Columns("colDgvSQL").Index, dgvinfo.Columns("colDgvUSER_NAME").Index, dgvinfo.Columns("colDgvDB_NAME").Index))
                              Case "TRAXIDLECNT"
                                  dtTable = clsQuery.SelectHCHKTranxIDLECnt(_RegDate, _HealthSeq)
                              Case "UNUSEDINDEX"
                                  dtTable = clsQuery.SelectHCHKUnusedIndex(_RegDate, _HealthSeq)
                              Case "HASTATUS"
                                  dtTable = clsQuery.SelectHCHKHAStatus(_IntInstanceID, _RegDate)
                              Case Else
                                  lblitmNm.Text += " - ERROR"

                          End Select
                          Dim strCurDate As String = ""
                          If dtTable IsNot Nothing AndAlso dtTable.Columns.Contains("COLLECT_DT") AndAlso dtTable.Rows.Count > 0 Then
                              strCurDate = IIf(IsDBNull(dtTable.Rows(0).Item("COLLECT_DT")), "-", CDate(dtTable.Rows(0).Item("COLLECT_DT")).ToString("yyyy-MM-dd HH:mm:ss"))
                          End If

                          lblCurTime.Text = p_clsMsgData.fn_GetData("F206", strCurDate)
                          Me.dgvinfo.DataSource = dtTable


                          Dim intRows As Integer = Me.dgvinfo.DisplayedRowCount(False)
                          Dim DisplayHeight As Integer = 0

                          If Me.dgvinfo.Rows.Count > 0 Then
                              Dim tmpRect As Rectangle = dgvinfo.GetCellDisplayRectangle(0, IIf(intRows < Me.dgvinfo.Rows.Count - 1, intRows, Me.dgvinfo.Rows.Count - 1), True)

                              ' HS Scroll 
                              If tmpRect.Top + tmpRect.Height < Me.Height Then
                                  dgvinfo.Height = tmpRect.Top + tmpRect.Height + 1 + IIf(dgvinfo.Controls(0).Visible, dgvinfo.Controls(0).Height, 0) + _HMargin
                              End If
                              ' VS Scroll 
                              If dgvinfo.Controls(1).Visible = True Then
                                  Me.Width += dgvinfo.Controls(1).Width
                              End If
                          Else
                              dgvinfo.Height = dgvinfo.ColumnHeadersHeight + dgvinfo.RowTemplate.Height + IIf(dgvinfo.Controls(0).Visible, dgvinfo.Controls(0).Height, 0) + _HMargin
                          End If




                      End If

                  End Sub)




    End Sub


    Private Sub frmHealthDetail_Shown(sender As Object, e As EventArgs) Handles Me.Shown




        Dim strColumns As String = p_clsMsgData.fn_GetSpecificData(_HealthItem, "COLUMNS")
        For Each strColumn As String In strColumns.Split(";")
            Dim arrColumn As String() = strColumn.Split("|")
            If arrColumn.Count > 3 Then
                ReDim Preserve arrColumn(4)
                Dim PropNm As String = arrColumn(0)
                Dim Caption As String = arrColumn(1)
                Dim Type As String = arrColumn(2)
                Dim strFormat As String = arrColumn(3)
                Dim intWidth As Integer = IIf(arrColumn(4) = "", 10, arrColumn(4))
                AddColumns(dgvinfo, PropNm, Caption, Type, strFormat, intWidth)
            End If
        Next

        'If dgvinfo.ColumnCount > 0 Then
        '    dgvinfo.Columns(dgvinfo.ColumnCount - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        '    dgvinfo.Columns(dgvinfo.ColumnCount - 1).MinimumWidth = 100
        'End If



        If dgvinfo.ColumnCount > 0 Then
            Dim dgvWidth As Integer = 0
            For i As Integer = 0 To dgvinfo.ColumnCount - 1
                dgvWidth += dgvinfo.Columns(i).Width
            Next
            dgvWidth += 1
            Dim tmpCtl As Control = dgvinfo.Parent

            Do Until tmpCtl Is Nothing
                dgvWidth += tmpCtl.Padding.Left + tmpCtl.Padding.Right + 1
                tmpCtl = tmpCtl.Parent
            Loop

            Me.Width = dgvWidth + _WMargin + 40

        End If




        _Th = New Threading.Thread(AddressOf sb_Search)
        _Th.Start()
    End Sub

    Private Sub lblParameter_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblParameter_LocationChanged(sender As Object, e As EventArgs)
        Dim tmpCtl As Control = lblParameter.Parent
        Dim intHeight As Integer = lblParameter.Top + lblParameter.Height
        Do Until tmpCtl Is Nothing
            intHeight += tmpCtl.Padding.Bottom + tmpCtl.Padding.Top + 1
            tmpCtl = tmpCtl.Parent
        Loop
        Me.Height = intHeight + _HMargin
    End Sub

    Private Sub dgvinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvinfo_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs)
        'SQL POPUP 
        Dim Bret As Boolean = False
        Dim intSql As Integer = -1
        Dim intUser As Integer = -1
        Dim intDB As Integer = -1
        For Each tmpCls As SQLInfo In _SQLCols
            If tmpCls.SQL = e.ColumnIndex Then
                intSql = tmpCls.SQL
                intUser = tmpCls.User
                intDB = tmpCls.DB
            End If
        Next
        If e.RowIndex < 0 Or intSql <= 0 Or intUser <= 0 Or intDB <= 0 Then
            Return
        End If
        Dim strQry As String = IIf(intSql <> -1, dgvinfo.Rows(e.RowIndex).Cells(intSql).Value, "")
        Dim strUsr As String = IIf(intUser <> -1, dgvinfo.Rows(e.RowIndex).Cells(intUser).Value, "")
        Dim strDB As String = IIf(intDB <> -1, dgvinfo.Rows(e.RowIndex).Cells(intDB).Value, "")
        If strQry <> "" Then
            Dim frmQuery As New frmQueryView(strQry, strDB, _IntInstanceID, IIf(strDB = "", Nothing, _AgentInfo), strUsr)

            frmQuery.Show()
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub frmHealthDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class