Public Class AlertConfigList

    Private _InstanceID As Integer = -1
    Property InstanceID As Integer
        Get
            Return _InstanceID
        End Get
        Set(value As Integer)
            _InstanceID = value
        End Set
    End Property



    Public Sub New()
        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()
        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.
    End Sub

    Public Sub New(ByVal intInstanceID As Integer, ByVal dtTable As DataTable, ByVal FixedThresholdDT As DataTable)

        ' 이 호출은 디자이너에 필요합니다.
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        _InstanceID = intInstanceID


        Me.dgvAlertList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvAlertList.ColumnHeadersHeight = Me.dgvAlertList.ColumnHeadersHeight * 1.3
        Me.dgvAlertList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter

        For j = 0 To dgvAlertList.ColumnCount - 1
            If j < coldgvAlertTransMethod.Index Then
                Me.dgvAlertList.Columns(j).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
                If j = coldgvAlertWarningThreshold.Index Or j = coldgvAlertCriticalThreshold.Index Then
                    Me.dgvAlertList.Columns(j).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
                End If
            Else
                Me.dgvAlertList.Columns(j).HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
            End If
        Next

        'Dim methods As New List(Of String)(New String() {"none", "SMS"})
        'Dim comboBoxColumn As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        'comboBoxColumn.DataPropertyName = "TRANS_TYPE"
        'comboBoxColumn.DataSource = methods
        ''comboBoxColumn.ValueMember = dtLocations.Columns(0).ColumnName
        ''comboBoxColumn.DisplayMember = dtLocations.Columns(1).ColumnName



        If dtTable IsNot Nothing Then
            Setvalue(dtTable, FixedThresholdDT)
        End If
    End Sub


    Public Sub Setvalue(ByVal DT As DataTable, ByVal FixedThresholdDT As DataTable)
        If DT IsNot Nothing Then
            For Each tmpRow As DataRow In DT.Rows
                Dim idxRow As Integer = dgvAlertList.Rows.Add()
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertSel.Index, True)
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertName.Index, p_clsMsgData.fn_GetData(tmpRow.Item("HCHK_NAME")))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertBizDay.Index, "")
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertBizHour.Index, "")
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertWarningThreshold.Index, CInt(tmpRow.Item("WARNING_THRESHOLD")))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertCriticalThreshold.Index, CInt(tmpRow.Item("CRITICAL_THRESHOLD")))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertDuration.Index, CInt(tmpRow.Item("RETENTION_TIME")))
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTransMethod.Index, 0)
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTransCycle.Index, "")
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTransLevel.Index, "")
                dgvAlertList.fn_DataCellADD(idxRow, coldgvAlertTransUser.Index, "")

                'If strGrp.Trim <> "" Then
                '    DirectCast(dgvSvrLst.Rows(idxRow).Cells(colGrp.Index), DataGridViewComboBoxCell).Value = strGrp
                'Else
                '    DirectCast(dgvSvrLst.Rows(idxRow).Cells(colGrp.Index), DataGridViewComboBoxCell).Value = 1
                'End If
            Next


        End If





        For index = 0 To DT.Rows.Count - 1
            Dim valueLeft As Integer = 0
            Dim ValueRight As Integer = 0
            Dim nudValue As Integer = 0
            Dim nudValue_ As Integer = 0
            Dim retentionTime As Integer = 0

            Dim Check As Boolean = False

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                valueLeft = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If
            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                ValueRight = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                nudValue = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                nudValue_ = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("RETENTION_TIME")) Then
                retentionTime = Convert.ToInt32(DT.Rows(index)("RETENTION_TIME"))
            End If

            If Not IsDBNull(DT.Rows(index)("FIXED_THRESHOLD")) Then
                For index1 = 0 To FixedThresholdDT.Rows.Count - 1
                    If (FixedThresholdDT.Rows(index1)("HCHK_NAME").ToString = DT.Rows(index)("HCHK_NAME").ToString) Then
                        If (DT.Rows(index)("FIXED_THRESHOLD") = FixedThresholdDT.Rows(index1)("FIXED_THRESHOLD").ToString) Then
                            Check = True
                            Exit For
                        Else
                            Check = False
                            Exit For
                        End If
                    End If
                Next
            End If

        Next
    End Sub


    Public Sub Setvalue(ByVal DT As DataTable)

        For index = 0 To DT.Rows.Count - 1
            Dim valueLeft As Integer = 0
            Dim ValueRight As Integer = 0
            Dim nudValue As Integer = 0
            Dim nudValue_ As Integer = 0

            Dim Check As Boolean = False

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                valueLeft = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If
            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                ValueRight = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("WARNING_THRESHOLD")) Then
                nudValue = Convert.ToInt32(DT.Rows(index)("WARNING_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("CRITICAL_THRESHOLD")) Then
                nudValue_ = Convert.ToInt32(DT.Rows(index)("CRITICAL_THRESHOLD"))
            End If

            If Not IsDBNull(DT.Rows(index)("FIXED_THRESHOLD")) Then
                If (DT.Rows(index)("FIXED_THRESHOLD") = "1") Then
                    Check = True
                Else
                    Check = False
                End If
            End If
        Next
    End Sub



    Public Function GetValue(ByVal FixedThresholdDT As DataTable) As GetServerAlertConfig
        Dim tmpClass As New GetServerAlertConfig
        tmpClass.InstanceID = _InstanceID


        Return tmpClass
    End Function


    Public Class GetServerAlertConfig
        Public InstanceID As Integer
        Public BufferRatioNormal As Integer
        Public BufferRatioWarning As Integer
        Public BufferRatioRTime As Integer

        Public CommitRatioNormal As Integer
        Public CommitRatioWarning As Integer
        Public CommitRatioRTime As Integer

        Public ConnectionsNormal As Integer
        Public ConnectionsWarning As Integer
        Public ConnectionsRTime As Integer

        Public CPUwaitRatioNormal As Integer
        Public CPUwaitRatioWarning As Integer
        Public CPUwaitRatioRTime As Integer

        Public SWAPusedRatioNormal As Integer
        Public SWAPusedRatioWarning As Integer
        Public SWAPusedRatioRTime As Integer

        Public DiskusedRatioNormal As Integer
        Public DiskusedRatioWarning As Integer
        Public DiskusedRatioRTime As Integer

        Public ReplicationDelayNormal As Integer
        Public ReplicationDelayWarning As Integer
        Public ReplicationDelayRTime As Integer


        Public LockedTrancCnt As Integer
        Public IdleTransCnt As Integer
        Public LongRunSqlSec As Integer
        Public UnusedIndexCnt As Integer
        Public LastVacuumDay As Integer
        Public LastAnalyzeDay As Integer
        Public ConFailedCnt As Integer

        Public LockedtranccntBool As String
        Public IdletranscntBool As String
        Public LongrunsqlsecBool As String
        Public UnusedindexcntBool As String
        Public LastvacuumDayBool As String
        Public LastAnalyzedayBool As String
        Public ConfailedcntBool As String

    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        ' Dim tmpCls As GetServerAlertConfig = Me.GetValue()

        '  RaiseEvent ABCD(Me, tmpCls)

    End Sub


    Public Event ABCD(ByVal sender As Object, ByVal UsrEvent As GetServerAlertConfig)


    Private Sub dgvAlertList_Paint(sender As Object, e As PaintEventArgs) Handles dgvAlertList.Paint
        Dim transmit As String = "Tansmission"
        Dim alertLevel As String = "Alert Threshold"
        Dim r1 As Rectangle = Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertWarningThreshold.Index, -1, True)
        Dim r2 As Rectangle = Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertTransMethod.Index, -1, True)
        Dim w1 As Integer = Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertWarningThreshold.Index + 1, -1, True).Width
        Dim w2 As Integer = Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertTransMethod.Index + 1, -1, True).Width + _
                            Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertTransMethod.Index + 2, -1, True).Width + _
                            Me.dgvAlertList.GetCellDisplayRectangle(coldgvAlertTransMethod.Index + 3, -1, True).Width
        r1.X += 1
        r1.Y += 1
        r1.Width = r1.Width + w1 - 2
        r1.Height = r1.Height / 2 - 2
        r2.X += 1
        r2.Y += 1
        r2.Width = r2.Width + w2 - 2
        r2.Height = r2.Height / 2 - 2
        e.Graphics.FillRectangle(New SolidBrush(Me.dgvAlertList.ColumnHeadersDefaultCellStyle.BackColor), r1)
        e.Graphics.FillRectangle(New SolidBrush(Me.dgvAlertList.ColumnHeadersDefaultCellStyle.BackColor), r2)
        Dim format As New StringFormat()
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center

        e.Graphics.DrawString(alertLevel, Me.dgvAlertList.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(Me.dgvAlertList.ColumnHeadersDefaultCellStyle.ForeColor), r1, format)
        e.Graphics.DrawString(transmit, Me.dgvAlertList.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(Me.dgvAlertList.ColumnHeadersDefaultCellStyle.ForeColor), r2, format)

        For j = 0 To dgvAlertList.ColumnCount - 1
            If j < 7 Then
                Me.dgvAlertList.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
            End If
        Next
    End Sub

    Private Sub dgvAlertList_CellPainting(sender As Object, e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) 'Handles dgvAlertList.CellPainting

        'If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
        '    Dim r2 As Rectangle = e.CellBounds
        '    r2.Y += e.CellBounds.Height / 2
        '    r2.Height = e.CellBounds.Height / 2
        '    e.PaintBackground(r2, True)
        '    e.PaintContent(r2)
        '    e.Handled = True
        'End If

        'For j = 0 To dgvAlertList.ColumnCount - 1
        '    If j < coldgvAlertTransMethod.Index Then
        '        Me.dgvAlertList.Columns(j).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        '    End If
        'Next
    End Sub
End Class
