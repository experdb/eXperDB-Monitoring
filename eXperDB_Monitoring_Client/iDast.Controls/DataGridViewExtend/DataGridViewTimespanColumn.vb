Imports System.ComponentModel

Public Class DataGridViewTimespanColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewTimespanCell())
      
    End Sub


    Private ReadOnly Property DataSizeCellTemplate() As DataGridViewTimespanCell
        Get
            Return DirectCast(Me.CellTemplate, DataGridViewTimespanCell)
        End Get
    End Property

    ''' <summary>
    ''' Represents the implicit cell that gets cloned when adding rows to the grid.
    ''' </summary>
    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(value As DataGridViewCell)
            Dim dataGridViewNumericUpDownCell As DataGridViewTimespanCell = TryCast(value, DataGridViewTimespanCell)
            If value IsNot Nothing AndAlso dataGridViewNumericUpDownCell Is Nothing Then
                Throw New InvalidCastException("Value provided for CellTemplate must be of type  or derive from it.")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property



    <Category("Data"), Description("기본 설정 사이즈"), RefreshProperties(RefreshProperties.All)> _
    Public Property BaseUnit() As DataGridViewTimespanCell.SizeUnit
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.BaseUnit
        End Get
        Set(value As DataGridViewTimespanCell.SizeUnit)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If

            Me.DataSizeCellTemplate.BaseUnit = value
            If Me.DataGridView IsNot Nothing Then
                Dim dataGridViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rowCount As Integer = dataGridViewRows.Count
                For rowIndex As Integer = 0 To rowCount - 1
                    Dim dataGridViewRow As DataGridViewRow = dataGridViewRows.SharedRow(rowIndex)
                    Dim dataGridViewCell As DataGridViewTimespanCell = TryCast(dataGridViewRow.Cells(Me.Index), DataGridViewTimespanCell)
                    If dataGridViewCell IsNot Nothing Then
                        dataGridViewCell.BaseUnit = value
                    End If
                Next

                Me.DataGridView.InvalidateColumn(Me.Index)
            End If


        End Set
    End Property

    <Category("Data"), Description("출력 형식 Default = T Other = dd\ \d\a\y\ hh\:mm\:ss")> _
    Public Property FormatString As String
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.FormatString
        End Get
        Set(value As String)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Me.DataSizeCellTemplate.FormatString = value
            If Me.DataGridView IsNot Nothing Then
                Dim dtViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rCount As Integer = dtViewRows.Count
                For i As Integer = 0 To rCount - 1
                    Dim dtRow As DataGridViewRow = dtViewRows.SharedRow(i)
                    Dim dtCell As DataGridViewTimespanCell = TryCast(dtRow.Cells(Me.Index), DataGridViewTimespanCell)
                    If dtCell IsNot Nothing Then
                        dtCell.FormatString = value
                    End If
                Next
                Me.DataGridView.InvalidateColumn(Me.Index)
            End If
        End Set
    End Property




End Class


Public Class DataGridViewTimespanCell
    Inherits DataGridViewTextBoxCell
    Private _BaseUnit As SizeUnit = SizeUnit.Seconds
    Public Enum SizeUnit
        ''' <summary>
        ''' Millisecond
        ''' </summary>
        ''' <remarks></remarks>
        Milliseconds = 0
        ''' <summary>
        ''' Second
        ''' </summary>
        ''' <remarks></remarks>
        Seconds = 1
        ''' <summary>
        ''' Minutes
        ''' </summary>
        ''' <remarks></remarks>
        Minutes = 2
        ''' <summary>
        ''' Hour
        ''' </summary>
        ''' <remarks></remarks>
        Hour = 3
    End Enum
    <DefaultValue(1)> _
    Property BaseUnit As SizeUnit
        Get
            Return _BaseUnit
        End Get
        Set(value As SizeUnit)
            If Not _BaseUnit.Equals(value) Then
                _BaseUnit = value
                OwnsEditingDataSize(Me.RowIndex)
                OnCommonChange()
            End If
        End Set
    End Property
    Private _FormatString As String = "%d\.%h\:mm\:ss"
    <DefaultValue("T")> _
    Property FormatString As String
        Get
            Return _FormatString
        End Get
        Set(value As String)
            If Not _FormatString.Equals(value) Then
                _FormatString = value
                OwnsEditingDataSize(Me.RowIndex)
                OnCommonChange()
            End If
        End Set
    End Property


    ''' <summary>
    ''' Determines whether this cell, at the given row index, shows the grid's editing control or not.
    ''' The row index needs to be provided as a parameter because this cell may be shared among multiple rows.
    ''' </summary>
    Private Function OwnsEditingDataSize(rowIndex As Integer) As Boolean
        If rowIndex = -1 OrElse Me.DataGridView Is Nothing Then
            Return False
        End If
        Dim txtEditingControl As DataGridViewTextBoxEditingControl = TryCast(Me.DataGridView.EditingControl, DataGridViewTextBoxEditingControl)
        Return txtEditingControl IsNot Nothing AndAlso rowIndex = DirectCast(txtEditingControl, IDataGridViewEditingControl).EditingControlRowIndex
    End Function
    ''' <summary>
    ''' Called when a cell characteristic that affects its rendering and/or preferred size has changed.
    ''' This implementation only takes care of repainting the cells. The DataGridView's autosizing methods
    ''' also need to be called in cases where some grid elements autosize.
    ''' </summary>
    Private Sub OnCommonChange()
        If Me.DataGridView IsNot Nothing AndAlso Not Me.DataGridView.IsDisposed AndAlso Not Me.DataGridView.Disposing Then
            If Me.RowIndex = -1 Then
                ' Invalidate and autosize column

                ' TODO: Add code to autosize the cell's column, the rows, the column headers 
                ' and the row headers depending on their autosize settings.
                ' The DataGridView control does not expose a public method that takes care of this.
                Me.DataGridView.InvalidateColumn(Me.ColumnIndex)
            Else
                ' The DataGridView control exposes a public method called UpdateCellValue
                ' that invalidates the cell so that it gets repainted and also triggers all
                ' the necessary autosizing: the cell's column and/or row, the column headers
                ' and the row headers are autosized depending on their autosize settings.
                Me.DataGridView.UpdateCellValue(Me.ColumnIndex, Me.RowIndex)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Clones a DataGridViewNumericUpDownCell cell, copies all the custom properties.
    ''' </summary>
    Public Overrides Function Clone() As Object
        Dim dataGridViewCell As DataGridViewTimespanCell = TryCast(MyBase.Clone(), DataGridViewTimespanCell)
        If dataGridViewCell IsNot Nothing Then
            dataGridViewCell.BaseUnit = Me.BaseUnit
            dataGridViewCell.FormatString = Me.FormatString
        End If
        Return dataGridViewCell
    End Function

    Public Function TranslateTimespan(ByVal cellStyle As DataGridViewCellStyle, ByVal size As Object, ByVal baseUnit As SizeUnit) As String
        Try

            If size IsNot Nothing AndAlso IsNumeric(size) AndAlso size > 0 Then



                'Dim pow As Double = Math.Floor(Math.Log(size, 1024))
                'Dim intVal As Double = CInt(size / Math.Pow(1024, pow))
                'Dim strVal As String = intVal

                'strVal = intVal.ToString(cellStyle.Format)
                Dim lngVal As Long = 0
                Dim rtnValue As TimeSpan = Nothing
                Select Case baseUnit
                    Case SizeUnit.Milliseconds
                        rtnValue = TimeSpan.FromMilliseconds(size)
                    Case SizeUnit.Seconds
                        rtnValue = TimeSpan.FromSeconds(size)
                    Case SizeUnit.Minutes
                        rtnValue = TimeSpan.FromMinutes(size)
                    Case SizeUnit.Hour
                        rtnValue = TimeSpan.FromHours(size)
                End Select

                Return rtnValue.ToString(_FormatString)

                'Return String.Concat(strVal, IIf(_ShowUnit, " " & System.Enum.GetName(GetType(SizeUnit), CInt(baseUnit + pow)), ""))
            Else

                Dim rtnValue As TimeSpan = Nothing
                rtnValue = TimeSpan.FromSeconds(0)
                Return rtnValue.ToString(_FormatString)

                'Return CStr(IIf(IIf(IsDBNull(size), Nothing, size) Is Nothing, 0, size))
            End If

        Catch ex As Exception
            GC.Collect()
            Return CStr(size)
        End Try
    End Function




    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        'MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        Try
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
            Dim strValue As String = TranslateTimespan(cellStyle, value, _BaseUnit)
            'strValue = TruncateString(strValue, cellStyle.Font, cellBounds.Width, 1, 1, graphics)
            'Dim szf As SizeF = graphics.MeasureString(strValue, cellStyle.Font)

            'Dim strPt As New Point(cellBounds.X + cellBounds.Width - szf.Width, cellBounds.Y + (cellBounds.Height - szf.Height) / 2)
            'graphics.DrawString(strValue, cellStyle.Font, New SolidBrush(cellStyle.ForeColor), strPt)
            Dim txtFormatFlags As TextFormatFlags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordEllipsis
            TextRenderer.DrawText(graphics, strValue, cellStyle.Font, cellBounds, cellStyle.ForeColor, txtFormatFlags)
        Catch ex As Exception
            GC.Collect()

        End Try




    End Sub

    Public Overrides ReadOnly Property EditType() As System.Type
        Get
            Return Nothing
        End Get
    End Property

End Class
