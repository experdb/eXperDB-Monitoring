Imports System.ComponentModel

Public Class DataGridViewDataSizeColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewDataSizeCell())
    End Sub


    Private ReadOnly Property DataSizeCellTemplate() As DataGridViewDataSizeCell
        Get
            Return DirectCast(Me.CellTemplate, DataGridViewDataSizeCell)
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
            Dim dataGridViewNumericUpDownCell As DataGridViewDataSizeCell = TryCast(value, DataGridViewDataSizeCell)
            If value IsNot Nothing AndAlso dataGridViewNumericUpDownCell Is Nothing Then
                Throw New InvalidCastException("Value provided for CellTemplate must be of type  or derive from it.")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property



    <Category("Data"), Description("기본 설정 사이즈"), RefreshProperties(RefreshProperties.All)> _
    Public Property BaseUnit() As DataGridViewDataSizeCell.SizeUnit
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.BaseUnit
        End Get
        Set(value As DataGridViewDataSizeCell.SizeUnit)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If

            Me.DataSizeCellTemplate.BaseUnit = value
            If Me.DataGridView IsNot Nothing Then
                Dim dataGridViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rowCount As Integer = dataGridViewRows.Count
                For rowIndex As Integer = 0 To rowCount - 1
                    Dim dataGridViewRow As DataGridViewRow = dataGridViewRows.SharedRow(rowIndex)
                    Dim dataGridViewCell As DataGridViewDataSizeCell = TryCast(dataGridViewRow.Cells(Me.Index), DataGridViewDataSizeCell)
                    If dataGridViewCell IsNot Nothing Then
                        dataGridViewCell.BaseUnit = value
                    End If
                Next

                Me.DataGridView.InvalidateColumn(Me.Index)
            End If


        End Set
    End Property

    <Category("Data"), Description("사이즈 보일지 여부")> _
    Public Property ShowUnit As Boolean
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.ShowUnit
        End Get
        Set(value As Boolean)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Me.DataSizeCellTemplate.ShowUnit = value
            If Me.DataGridView IsNot Nothing Then
                Dim dtViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rCount As Integer = dtViewRows.Count
                For i As Integer = 0 To rCount - 1
                    Dim dtRow As DataGridViewRow = dtViewRows.SharedRow(i)
                    Dim dtCell As DataGridViewDataSizeCell = TryCast(dtRow.Cells(Me.Index), DataGridViewDataSizeCell)
                    If dtCell IsNot Nothing Then
                        dtCell.ShowUnit = value
                    End If
                Next
                Me.DataGridView.InvalidateColumn(Me.Index)
            End If
        End Set
    End Property

    <Category("Data")> _
    <Description("머리말")> _
    Public Property HeaderWord As String
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.HeaderWord
        End Get
        Set(value As String)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Me.DataSizeCellTemplate.HeaderWord = value
            If Me.DataGridView IsNot Nothing Then
                Dim dtViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rCount As Integer = dtViewRows.Count
                For i As Integer = 0 To rCount - 1
                    Dim dtRow As DataGridViewRow = dtViewRows.SharedRow(i)
                    Dim dtCell As DataGridViewDataSizeCell = TryCast(dtRow.Cells(Me.Index), DataGridViewDataSizeCell)
                    If dtCell IsNot Nothing Then
                        dtCell.HeaderWord = value
                    End If
                Next
                Me.DataGridView.InvalidateColumn(Me.Index)
            End If

        End Set
    End Property
    <Category("Data")> _
    <Description("꼬리말")> _
    Public Property TailWord As String
        Get
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Return Me.DataSizeCellTemplate.TailWord
        End Get
        Set(value As String)
            If Me.DataSizeCellTemplate Is Nothing Then
                Throw New InvalidOperationException("Operation cannot be completed because this does not have a CellTemplate.")
            End If
            Me.DataSizeCellTemplate.TailWord = value
            If Me.DataGridView IsNot Nothing Then
                Dim dtViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rCount As Integer = dtViewRows.Count
                For i As Integer = 0 To rCount - 1
                    Dim dtRow As DataGridViewRow = dtViewRows.SharedRow(i)
                    Dim dtCell As DataGridViewDataSizeCell = TryCast(dtRow.Cells(Me.Index), DataGridViewDataSizeCell)
                    If dtCell IsNot Nothing Then
                        dtCell.TailWord = value
                    End If
                Next
                Me.DataGridView.InvalidateColumn(Me.Index)
            End If
        End Set
    End Property



End Class


Public Class DataGridViewDataSizeCell
    Inherits DataGridViewTextBoxCell
    Private _BaseUnit As SizeUnit = SizeUnit.KB
    Public Enum SizeUnit
        ''' <summary>
        ''' Bytes
        ''' </summary>
        ''' <remarks></remarks>
        Bytes = 0
        ''' <summary>
        ''' Kilobyte
        ''' </summary>
        ''' <remarks></remarks>
        KB = 1
        ''' <summary>
        ''' Megabyte
        ''' </summary>
        ''' <remarks></remarks>
        MB = 2
        ''' <summary>
        ''' Gigabyte
        ''' </summary>
        ''' <remarks></remarks>
        GB = 3
        ''' <summary>
        ''' Terabyte
        ''' </summary>
        ''' <remarks></remarks>
        TB = 4
        ''' <summary>
        ''' Petabyte
        ''' </summary>
        ''' <remarks></remarks>
        PB = 5
        ''' <summary>
        ''' Exabyte
        ''' </summary>
        ''' <remarks></remarks>
        EB = 6
        ''' <summary>
        ''' Zetabyte
        ''' </summary>
        ''' <remarks></remarks>
        ZB = 7
        ''' <summary>
        ''' Yottabyte
        ''' </summary>
        ''' <remarks></remarks>
        YB = 8
    End Enum
    <DefaultValue(1)> _
    Property BaseUnit As SizeUnit
        Get
            Return _BaseUnit
        End Get
        Set(value As SizeUnit)
            If Not _BaseUnit.Equals(value) Then
                Me._BaseUnit = value
                OwnsEditingDataSize(RowIndex)
                OnCommonChange()
            End If
        End Set
    End Property
    Private _ShowUnit As Boolean = True
    <DefaultValue(True)> _
    Property ShowUnit As Boolean
        Get
            Return _ShowUnit
        End Get
        Set(value As Boolean)
            If Not _ShowUnit.Equals(value) Then
                Me._ShowUnit = value
                OwnsEditingDataSize(RowIndex)
                OnCommonChange()
            End If
        End Set
    End Property

    Private _HeaderWord As String = ""
    <DefaultValue("")> _
    Property HeaderWord As String
        Get
            Return _HeaderWord
        End Get
        Set(value As String)
            If Not _HeaderWord.Equals(value) Then
                _HeaderWord = value
                OwnsEditingDataSize(RowIndex)
                OnCommonChange()
            End If
        End Set
    End Property


    Private _TailWord As String = ""
    <DefaultValue("")> _
    Property TailWord As String
        Get
            Return _TailWord
        End Get
        Set(value As String)
            If Not _TailWord.Equals(value) Then
                _TailWord = value
                OwnsEditingDataSize(RowIndex)
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
        Dim dataGridViewCell As DataGridViewDataSizeCell = TryCast(MyBase.Clone(), DataGridViewDataSizeCell)
        If dataGridViewCell IsNot Nothing Then
            dataGridViewCell.BaseUnit = Me.BaseUnit
            dataGridViewCell.ShowUnit = Me.ShowUnit
            dataGridViewCell.HeaderWord = Me.HeaderWord
            dataGridViewCell.TailWord = Me.TailWord

        End If
        Return dataGridViewCell
    End Function

    Public Function TranslateFileSizeWithUnit(ByVal cellStyle As DataGridViewCellStyle, ByVal size As Object, ByVal baseUnit As SizeUnit) As String

        Try
            If IsDBNull(size) Or size Is Nothing Then
                size = 0
            End If

            If size IsNot Nothing AndAlso IsNumeric(size) AndAlso size > 0 Then
                Dim pow As Double = Math.Floor(Math.Log(size, 1024))
                Dim intVal As Double = CInt(size / Math.Pow(1024, pow))
                Dim strVal As String = intVal

                strVal = intVal.ToString(cellStyle.Format)

                Return String.Concat(Me._HeaderWord, strVal, IIf(_ShowUnit, " " & System.Enum.GetName(GetType(SizeUnit), CInt(baseUnit + pow)), ""), Me._TailWord)
            Else

                Return String.Concat(Me._HeaderWord, 0 & " " & System.Enum.GetName(GetType(SizeUnit), baseUnit), Me._TailWord)
            End If

        Catch ex As Exception
            Return CStr(size)
        End Try
    End Function




    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        'MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        Try
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
            Dim strValue As String = TranslateFileSizeWithUnit(cellStyle, value, _BaseUnit)
            'strValue = TruncateString(strValue, cellStyle.Font, cellBounds.Width, 1, 1, graphics)
            'Dim szf As SizeF = graphics.MeasureString(strValue, cellStyle.Font)

            'Dim strPt As New Point(cellBounds.X + cellBounds.Width - szf.Width, cellBounds.Y + (cellBounds.Height - szf.Height) / 2)
            'graphics.DrawString(strValue, cellStyle.Font, New SolidBrush(cellStyle.ForeColor), strPt)
            Dim txtFormatFlags As TextFormatFlags = TextFormatFlags.Right Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordEllipsis
            TextRenderer.DrawText(graphics, strValue, cellStyle.Font, cellBounds, cellStyle.ForeColor, txtFormatFlags)
        Catch ex As Exception
            GC.Collect()

        End Try




    End Sub


End Class
