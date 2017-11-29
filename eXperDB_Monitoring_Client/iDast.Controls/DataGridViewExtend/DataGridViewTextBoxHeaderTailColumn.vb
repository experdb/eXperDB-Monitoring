Imports System.ComponentModel

Public Class DataGridViewTextBoxHeaderTailColumn
    Inherits DataGridViewColumn

    Public Sub New()
        MyBase.New(New DataGridViewTextBoxHeaderTailCell())
    End Sub


    Private ReadOnly Property DataSizeCellTemplate() As DataGridViewTextBoxHeaderTailCell
        Get
            Return DirectCast(Me.CellTemplate, DataGridViewTextBoxHeaderTailCell)
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
            Dim dataGridViewNumericUpDownCell As DataGridViewTextBoxHeaderTailCell = TryCast(value, DataGridViewTextBoxHeaderTailCell)
            If value IsNot Nothing AndAlso dataGridViewNumericUpDownCell Is Nothing Then
                Throw New InvalidCastException("Value provided for CellTemplate must be of type  or derive from it.")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property



    <Category("Data"), Description("머리말"), RefreshProperties(RefreshProperties.All)> _
    Public Property HeaderWord() As String
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
                Dim dataGridViewRows As DataGridViewRowCollection = Me.DataGridView.Rows
                Dim rowCount As Integer = dataGridViewRows.Count
                For rowIndex As Integer = 0 To rowCount - 1
                    Dim dataGridViewRow As DataGridViewRow = dataGridViewRows.SharedRow(rowIndex)
                    Dim dataGridViewCell As DataGridViewTextBoxHeaderTailCell = TryCast(dataGridViewRow.Cells(Me.Index), DataGridViewTextBoxHeaderTailCell)
                    If dataGridViewCell IsNot Nothing Then
                        dataGridViewCell.HeaderWord = value
                    End If
                Next

                Me.DataGridView.InvalidateColumn(Me.Index)
            End If


        End Set
    End Property

    <Category("Data"), Description("꼬리말")> _
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
                    Dim dtCell As DataGridViewTextBoxHeaderTailCell = TryCast(dtRow.Cells(Me.Index), DataGridViewTextBoxHeaderTailCell)
                    If dtCell IsNot Nothing Then
                        dtCell.TailWord = value
                    End If
                Next
                Me.DataGridView.InvalidateColumn(Me.Index)
            End If
        End Set
    End Property




End Class


Public Class DataGridViewTextBoxHeaderTailCell
    Inherits DataGridViewTextBoxCell
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
    <DefaultValue(True)> _
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
        Dim dataGridViewCell As DataGridViewTextBoxHeaderTailCell = TryCast(MyBase.Clone(), DataGridViewTextBoxHeaderTailCell)
        If dataGridViewCell IsNot Nothing Then
            dataGridViewCell.HeaderWord = Me.HeaderWord
            dataGridViewCell.TailWord = Me.TailWord
        End If
        Return dataGridViewCell
    End Function

    Public Function TranslateFileSizeWithUnit(ByVal cellStyle As DataGridViewCellStyle, ByVal Value As Object) As String
        If IsDBNull(Value) Or Value Is Nothing Then
            Value = ""
        End If
        Try

            Return String.Concat(Me._HeaderWord, Value, Me._TailWord)


        Catch ex As Exception
            Return Value
        End Try
    End Function




    Protected Overrides Sub Paint(graphics As Graphics, clipBounds As Rectangle, cellBounds As Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object, formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        'MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        Try
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, "", formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Background Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus Or DataGridViewPaintParts.SelectionBackground)
            Dim strValue As String = TranslateFileSizeWithUnit(cellStyle, formattedValue)
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

    Public Overrides ReadOnly Property EditType As Type
        Get
            Return MyBase.EditType
        End Get
    End Property

End Class
