'---------------------------------------------------------------------
'  Copyright (C) Microsoft Corporation.  All rights reserved.
' 
'THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
'KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'PARTICULAR PURPOSE.
'---------------------------------------------------------------------

'Imports DataGridViewAutoFilter
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Imports System.Collections
Imports System.Reflection

''' <summary>
''' Provides a drop-down filter list in a DataGridViewColumnHeaderCell.
''' </summary>
Public Class DataGridViewAutoFilterColumnHeaderCell
    Inherits DataGridViewColumnHeaderCell

    ''' <summary>
    ''' The ListBox used for all drop-down lists. 
    ''' </summary>
    Private Shared dropDownListBox As New FilterListBox()

    ''' <summary>
    ''' A list of filters available for the owning column stored as 
    ''' formatted and unformatted string values. 
    ''' </summary>
    Private filters As New System.Collections.Specialized.OrderedDictionary()

    ''' <summary>
    ''' The drop-down list filter value currently in effect for 
    ''' the owning column. 
    ''' </summary>
    Private selectedFilterValue As String = String.Empty

    ''' <summary>
    ''' The complete filter string currently in effect for the owning column. 
    ''' </summary>
    Private currentColumnFilter As String = String.Empty

    ''' <summary>
    ''' Indicates whether the DataGridView is currently filtered by the 
    ''' owning column.  
    ''' </summary>
    Private filtered As Boolean

    ''' <summary>
    ''' Initializes a new instance of the DataGridViewColumnHeaderCell 
    ''' class and sets its property values to the property values of the 
    ''' specified DataGridViewColumnHeaderCell.
    ''' </summary>
    ''' <param name="oldHeaderCell">The DataGridViewColumnHeaderCell to 
    ''' copy property values from.</param>
    Public Sub New(ByVal oldHeaderCell As DataGridViewColumnHeaderCell)

        Me.ContextMenuStrip = oldHeaderCell.ContextMenuStrip
        Me.ErrorText = oldHeaderCell.ErrorText
        Me.Tag = oldHeaderCell.Tag
        Me.ToolTipText = oldHeaderCell.ToolTipText
        Me.Value = oldHeaderCell.Value
        Me.ValueType = oldHeaderCell.ValueType

        ' Use HasStyle to avoid creating a new style object
        ' when the Style property has not previously been set. 
        If oldHeaderCell.HasStyle Then
            Me.Style = oldHeaderCell.Style
        End If

        ' Copy this type's properties if the old cell is an auto-filter cell. 
        ' This enables the Clone method to reuse this constructor. 
        Dim filterCell As DataGridViewAutoFilterColumnHeaderCell = _
            TryCast(oldHeaderCell, DataGridViewAutoFilterColumnHeaderCell)
        If filterCell IsNot Nothing Then
            Me.FilteringEnabled = filterCell.FilteringEnabled
            Me.AutomaticSortingEnabled = filterCell.AutomaticSortingEnabled
            Me.DropDownListBoxMaxLines = filterCell.DropDownListBoxMaxLines
            Me.currentDropDownButtonPaddingOffset = _
                filterCell.currentDropDownButtonPaddingOffset
        End If

    End Sub

    ''' <summary>
    ''' Initializes a new instance of the DataGridViewColumnHeaderCell 
    ''' class. 
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' Creates an exact copy of this cell.
    ''' </summary>
    ''' <returns>An object that represents the cloned 
    ''' DataGridViewAutoFilterColumnHeaderCell.</returns>
    Public Overrides Function Clone() As Object
        Return New DataGridViewAutoFilterColumnHeaderCell(Me)
    End Function

    ''' <summary>
    ''' Called when the value of the DataGridView property changes
    ''' in order to perform initialization that requires access to the 
    ''' owning control and column. 
    ''' </summary>
    Protected Overrides Sub OnDataGridViewChanged()

        ' Continue only if there is a DataGridView. 
        If Me.DataGridView Is Nothing Then
            Return
        End If

        ' Disable sorting and filtering for columns that can't make
        ' effective use of them. 
        If OwningColumn IsNot Nothing Then

            If TypeOf OwningColumn Is DataGridViewImageColumn OrElse _
                (TypeOf OwningColumn Is DataGridViewButtonColumn AndAlso _
                CType(OwningColumn, DataGridViewButtonColumn).UseColumnTextForButtonValue) _
                OrElse (TypeOf OwningColumn Is DataGridViewLinkColumn AndAlso _
                CType(OwningColumn, DataGridViewLinkColumn).UseColumnTextForLinkValue) Then

                AutomaticSortingEnabled = False
                FilteringEnabled = False

            End If

            ' Ensure that the column SortMode property value is not Automatic.
            ' This prevents sorting when the user clicks the drop-down button.
            If OwningColumn.SortMode = DataGridViewColumnSortMode.Automatic Then
                OwningColumn.SortMode = DataGridViewColumnSortMode.Programmatic
            End If

        End If

        ' Confirm that the data source meets requirements. 
        VerifyDataSource()

        ' Add handlers to DataGridView events. 
        HandleDataGridViewEvents()

        ' Initialize the drop-down button bounds so that any initial
        ' column autosizing will accommodate the button width. 
        SetDropDownButtonBounds()

        ' Call the OnDataGridViewChanged method on the base class to 
        ' raise the DataGridViewChanged event.
        MyBase.OnDataGridViewChanged()

    End Sub 'OnDataGridViewChanged

    ''' <summary>
    ''' Confirms that the data source, if it has been set, is a BindingSource.
    ''' </summary>
    Private Sub VerifyDataSource()

        ' Continue only if there is a DataGridView and 
        ' its DataSource has been set.
        If Me.DataGridView Is Nothing OrElse _
            Me.DataGridView.DataSource Is Nothing Then
            Return
        End If

        ' Throw an exception if the data source is not a BindingSource. 
        Dim data As BindingSource = _
            TryCast(Me.DataGridView.DataSource, BindingSource)
        If data Is Nothing Then
            Throw New NotSupportedException( _
                "The DataSource property of the containing DataGridView " & _
                "control must be set to a BindingSource.")
        End If

    End Sub 'VerifyDataSource

#Region "DataGridView events: HandleDataGridViewEvents, DataGridView event handlers, ResetDropDown, ResetFilter"

    ''' <summary>
    ''' Add handlers to various DataGridView events, primarily to invalidate 
    ''' the drop-down button bounds, hide the drop-down list, and reset 
    ''' cached filter values when changes in the DataGridView require it.
    ''' </summary>
    Private Sub HandleDataGridViewEvents()
        AddHandler Me.DataGridView.Scroll, AddressOf DataGridView_Scroll
        AddHandler Me.DataGridView.ColumnDisplayIndexChanged, AddressOf DataGridView_ColumnDisplayIndexChanged
        AddHandler Me.DataGridView.ColumnWidthChanged, AddressOf DataGridView_ColumnWidthChanged
        AddHandler Me.DataGridView.ColumnHeadersHeightChanged, AddressOf DataGridView_ColumnHeadersHeightChanged
        AddHandler Me.DataGridView.SizeChanged, AddressOf DataGridView_SizeChanged
        AddHandler Me.DataGridView.DataSourceChanged, AddressOf DataGridView_DataSourceChanged
        AddHandler Me.DataGridView.DataBindingComplete, AddressOf DataGridView_DataBindingComplete

        ' Add a handler for the ColumnSortModeChanged event to prevent the
        ' column SortMode property from being inadvertently set to Automatic.
        AddHandler Me.DataGridView.ColumnSortModeChanged, AddressOf DataGridView_ColumnSortModeChanged
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds when 
    ''' the user scrolls horizontally.
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A ScrollEventArgs that contains the event data.</param>
    Private Sub DataGridView_Scroll( _
        ByVal sender As Object, ByVal e As ScrollEventArgs)
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then
            ResetDropDown()
        End If
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds when 
    ''' the column display index changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DataGridView_ColumnDisplayIndexChanged( _
        ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)
        ResetDropDown()
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds when a column width changes
    ''' in the DataGridView control. A width change in any column of the 
    ''' control has the potential to affect the drop-down button location, 
    ''' depending on the current horizontal scrolling position and whether
    ''' the changed column is to the left or right of the current column. 
    ''' It is easier to invalidate the button in all cases. 
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A DataGridViewColumnEventArgs that contains the event data.</param>
    Private Sub DataGridView_ColumnWidthChanged( _
        ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)
        ResetDropDown()
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds when the height of the column headers changes.
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DataGridView_ColumnHeadersHeightChanged( _
        ByVal sender As Object, ByVal e As EventArgs)
        ResetDropDown()
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds when the size of the DataGridView changes.
    ''' This prevents a painting issue that occurs when the right edge of the control moves 
    ''' to the right and the control contents have previously been scrolled to the right.
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DataGridView_SizeChanged( _
        ByVal sender As Object, ByVal e As EventArgs)
        ResetDropDown()
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds, hides the drop-down 
    ''' filter list, if it is showing, and resets the cached filter values
    ''' if the filter has been removed. 
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A DataGridViewBindingCompleteEventArgs that contains the event data.</param>
    Private Sub DataGridView_DataBindingComplete( _
        ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs)
        If e.ListChangedType = ListChangedType.Reset Then
            ResetDropDown()
            ResetFilter()
        End If
    End Sub

    ''' <summary>
    ''' Verifies that the data source meets requirements, invalidates the 
    ''' drop-down button bounds, hides the drop-down filter list if it is 
    ''' showing, and resets the cached filter values if the filter has been removed. 
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DataGridView_DataSourceChanged( _
        ByVal sender As Object, ByVal e As EventArgs)
        VerifyDataSource()
        ResetDropDown()
        ResetFilter()
    End Sub

    ''' <summary>
    ''' Invalidates the drop-down button bounds and hides the filter
    ''' list if it is showing.
    ''' </summary>
    Private Sub ResetDropDown()
        InvalidateDropDownButtonBounds()
        If dropDownListBoxShowing Then
            HideDropDownList()
        End If
    End Sub

    ''' <summary>
    ''' Resets the cached filter values if the filter has been removed.
    ''' </summary>
    Private Sub ResetFilter()
        If Me.DataGridView Is Nothing Then Return
        Dim source As BindingSource = _
            TryCast(Me.DataGridView.DataSource, BindingSource)
        If source Is Nothing OrElse String.IsNullOrEmpty(source.Filter) Then
            filtered = False
            selectedFilterValue = "(All)"
            currentColumnFilter = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Throws an exception when the column sort mode is changed to Automatic.
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A DataGridViewColumnEventArgs that contains the event data.</param>
    Private Sub DataGridView_ColumnSortModeChanged( _
        ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)

        If e.Column Is OwningColumn AndAlso _
            e.Column.SortMode = DataGridViewColumnSortMode.Automatic Then
            Throw New InvalidOperationException( _
                "A SortMode value of Automatic is incompatible with " & _
                "the DataGridViewAutoFilterColumnHeaderCell type. " & _
                "Use the AutomaticSortingEnabled property instead.")
        End If

    End Sub

#End Region 'DataGridView events

    ''' <summary>
    ''' Paints the column header cell, including the drop-down button. 
    ''' </summary>
    ''' <param name="graphics">The Graphics used to paint the DataGridViewCell.</param>
    ''' <param name="clipBounds">A Rectangle that represents the area of the DataGridView that needs to be repainted.</param>
    ''' <param name="cellBounds">A Rectangle that contains the bounds of the DataGridViewCell that is being painted.</param>
    ''' <param name="rowIndex">The row index of the cell that is being painted.</param>
    ''' <param name="cellState">A bitwise combination of DataGridViewElementStates values that specifies the state of the cell.</param>
    ''' <param name="value">The data of the DataGridViewCell that is being painted.</param>
    ''' <param name="formattedValue">The formatted data of the DataGridViewCell that is being painted.</param>
    ''' <param name="errorText">An error message that is associated with the cell.</param>
    ''' <param name="cellStyle">A DataGridViewCellStyle that contains formatting and style information about the cell.</param>
    ''' <param name="advancedBorderStyle">A DataGridViewAdvancedBorderStyle that contains border styles for the cell that is being painted.</param>
    ''' <param name="paintParts">A bitwise combination of the DataGridViewPaintParts values that specifies which parts of the cell need to be painted.</param>
    Protected Overrides Sub Paint( _
        ByVal graphics As Graphics, _
        ByVal clipBounds As Rectangle, _
        ByVal cellBounds As Rectangle, _
        ByVal rowIndex As Integer, _
        ByVal cellState As DataGridViewElementStates, _
        ByVal value As Object, _
        ByVal formattedValue As Object, _
        ByVal errorText As String, _
        ByVal cellStyle As DataGridViewCellStyle, _
        ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
        ByVal paintParts As DataGridViewPaintParts)

        ' Use the base method to paint the default appearance. 
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, _
            cellState, value, formattedValue, errorText, cellStyle, _
            advancedBorderStyle, paintParts)

        ' Continue only if filtering is enabled and ContentBackground is 
        ' part of the paint request. 
        If Not FilteringEnabled OrElse (paintParts And _
            DataGridViewPaintParts.ContentBackground) = 0 Then
            Return
        End If

        ' Retrieve the current button bounds. 
        Dim buttonBounds As Rectangle = DropDownButtonBounds

        ' Continue only if the buttonBounds is big enough to draw.
        If buttonBounds.Width < 1 OrElse buttonBounds.Height < 1 Then Return

        ' Paint the button manually or using visual styles if visual styles 
        ' are enabled, using the correct state depending on whether the 
        ' filter list is showing and whether there is a filter in effect 
        ' for the current column. 
        If Application.RenderWithVisualStyles Then
            Dim state As ComboBoxState = ComboBoxState.Normal

            If dropDownListBoxShowing Then
                state = ComboBoxState.Pressed
            ElseIf filtered Then
                state = ComboBoxState.Hot
            End If
            ComboBoxRenderer.DrawDropDownButton(graphics, buttonBounds, state)
        Else
            ' Determine the pressed state in order to paint the button 
            ' correctly and to offset the down arrow. 
            Dim pressedOffset As Int32 = 0
            Dim state As PushButtonState = PushButtonState.Normal
            If dropDownListBoxShowing Then
                state = PushButtonState.Pressed
                pressedOffset = 1
            End If
            ButtonRenderer.DrawButton(graphics, buttonBounds, state)

            ' If there is a filter in effect for the column, paint the 
            ' down arrow as an unfilled triangle. If there is no filter 
            ' in effect, paint the down arrow as a filled triangle.
            If filtered Then
                graphics.DrawPolygon(SystemPens.ControlText, New Point() { _
                    New Point( _
                        buttonBounds.Width \ 2 + _
                            buttonBounds.Left - 1 + pressedOffset, _
                        buttonBounds.Height * 3 \ 4 + _
                            buttonBounds.Top - 1 + pressedOffset), _
                    New Point( _
                        buttonBounds.Width \ 4 + _
                            buttonBounds.Left + pressedOffset, _
                        buttonBounds.Height \ 2 + _
                            buttonBounds.Top - 1 + pressedOffset), _
                    New Point( _
                        buttonBounds.Width * 3 \ 4 + _
                            buttonBounds.Left - 1 + pressedOffset, _
                        buttonBounds.Height \ 2 + _
                            buttonBounds.Top - 1 + pressedOffset) _
                })
            Else
                graphics.FillPolygon(SystemBrushes.ControlText, New Point() { _
                    New Point( _
                        buttonBounds.Width \ 2 + _
                            buttonBounds.Left - 1 + pressedOffset, _
                        buttonBounds.Height * 3 \ 4 + _
                            buttonBounds.Top - 1 + pressedOffset), _
                    New Point( _
                        buttonBounds.Width \ 4 + _
                            buttonBounds.Left + pressedOffset, _
                        buttonBounds.Height \ 2 + _
                            buttonBounds.Top - 1 + pressedOffset), _
                    New Point( _
                        buttonBounds.Width * 3 \ 4 + _
                            buttonBounds.Left - 1 + pressedOffset, _
                        buttonBounds.Height \ 2 + _
                            buttonBounds.Top - 1 + pressedOffset) _
                })
            End If
        End If

    End Sub 'Paint

    ''' <summary>
    ''' Handles mouse clicks to the header cell, displaying the 
    ''' drop-down list or sorting the owning column as appropriate. 
    ''' </summary>
    ''' <param name="e">A DataGridViewCellMouseEventArgs that contains the event data.</param>
    Protected Overrides Sub OnMouseDown(ByVal e As DataGridViewCellMouseEventArgs)

        Debug.Assert(Me.DataGridView IsNot Nothing, "DataGridView is null")

        ' Continue only if the user did not click the drop-down button 
        ' while the drop-down list was displayed. This prevents the 
        ' drop-down list from being redisplayed after being hidden in 
        ' the LostFocus event handler. 
        If lostFocusOnDropDownButtonClick Then
            lostFocusOnDropDownButtonClick = False
            Return
        End If

        ' Retrieve the current size and location of the header cell,
        ' excluding any portion that is scrolled off screen. 
        Dim cellBounds As Rectangle = Me.DataGridView _
            .GetCellDisplayRectangle(e.ColumnIndex, -1, False)

        ' Continue only if the column is not manually resizable or the
        ' mouse coordinates are not within the column resize zone. 
        If Me.OwningColumn.Resizable = DataGridViewTriState.True AndAlso _
            (Me.DataGridView.RightToLeft = RightToLeft.No AndAlso _
            cellBounds.Width - e.X < 6 OrElse e.X < 6) Then
            Return
        End If

        ' Unless RightToLeft is enabled, store the width of the portion
        ' that is scrolled off screen. 
        Dim scrollingOffset As Int32 = 0
        If Me.DataGridView.RightToLeft = RightToLeft.No AndAlso _
            Me.DataGridView.FirstDisplayedScrollingColumnIndex = Me.ColumnIndex Then
            scrollingOffset = Me.DataGridView.FirstDisplayedScrollingColumnHiddenWidth
        End If

        ' Show the drop-down list if filtering is enabled and the mouse click occurred
        ' within the drop-down button bounds. Otherwise, if sorting is enabled and the
        ' click occurred outside the drop-down button bounds, sort by the owning column. 
        ' The mouse coordinates are relative to the cell bounds, so the cell location
        ' and the scrolling offset are needed to determine the client coordinates.
        If FilteringEnabled AndAlso _
            DropDownButtonBounds.Contains( _
            e.X + cellBounds.Left - scrollingOffset, e.Y + cellBounds.Top) Then

            ' If the current cell is in edit mode, commit the edit. 
            If Me.DataGridView.IsCurrentCellInEditMode Then
                ' Commit and end the cell edit.  
                Me.DataGridView.EndEdit()

                ' Commit any change to the underlying data source. 
                Dim source As BindingSource = _
                    TryCast(Me.DataGridView.DataSource, BindingSource)
                If source IsNot Nothing Then
                    source.EndEdit()
                End If
            End If
            ShowDropDownList()

        ElseIf AutomaticSortingEnabled AndAlso _
            Me.DataGridView.SelectionMode <> _
            DataGridViewSelectionMode.ColumnHeaderSelect Then

            SortByColumn()

        End If

        MyBase.OnMouseDown(e)

    End Sub 'OnMouseDown

    ''' <summary>
    ''' Sorts the DataGridView by the current column if AutomaticSortingEnabled is true.
    ''' </summary>
    Private Sub SortByColumn()

        Debug.Assert(Me.DataGridView IsNot Nothing AndAlso _
            OwningColumn IsNot Nothing, "DataGridView or OwningColumn is null")

        ' Continue only if the data source supports sorting. 
        Dim sortList As IBindingList = _
            TryCast(Me.DataGridView.DataSource, IBindingList)
        If sortList Is Nothing OrElse _
            Not sortList.SupportsSorting OrElse _
            Not AutomaticSortingEnabled Then
            Return
        End If

        ' Determine the sort direction and sort by the owning column. 
        If Me.DataGridView.RowCount > 0 Then
            Dim direction As ListSortDirection = ListSortDirection.Ascending
            If Me.DataGridView.SortedColumn Is OwningColumn AndAlso _
                Me.DataGridView.SortOrder = SortOrder.Ascending Then
                direction = ListSortDirection.Descending
            End If
            Me.DataGridView.Sort(OwningColumn, direction)
        End If

    End Sub

#Region "drop-down list: Show/HideDropDownListBox, SetDropDownListBoxBounds, DropDownListBoxMaxHeightInternal"

    ''' <summary>
    ''' Indicates whether dropDownListBox is currently displayed 
    ''' for this header cell. 
    ''' </summary>
    Private dropDownListBoxShowing As Boolean

    ''' <summary>
    ''' Displays the drop-down filter list. 
    ''' </summary>
    Public Sub ShowDropDownList()

        Debug.Assert(Me.DataGridView IsNot Nothing, "DataGridView is null")

        ' Ensure that the current row is not the row for new records.
        ' This prevents the new row from affecting the filter list and also 
        ' prevents the new row from being added when the filter changes.
        If Me.DataGridView.CurrentRow IsNot Nothing AndAlso _
            Me.DataGridView.CurrentRow.IsNewRow Then
            Me.DataGridView.CurrentCell = Nothing
        End If

        ' Populate the filters dictionary, then copy the filter values 
        ' from the filters.Keys collection into the ListBox.Items collection, 
        ' selecting the current filter if there is one in effect. 
        PopulateFilters()

        Dim filterArray As String() = New String(filters.Count - 1) {}
        filters.Keys.CopyTo(filterArray, 0)
        dropDownListBox.Items.Clear()
        dropDownListBox.Items.AddRange(filterArray)
        dropDownListBox.SelectedItem = selectedFilterValue
        dropDownListBox.Font = New Font("Gulim", 9.2, System.Drawing.FontStyle.Regular)

        ' Add handlers to dropDownListBox events. 
        HandleDropDownListBoxEvents()

        ' Set the size and location of dropDownListBox, then display it. 
        SetDropDownListBoxBounds()
        dropDownListBox.Visible = True
        dropDownListBoxShowing = True

        Debug.Assert(dropDownListBox.Parent Is Nothing, _
            "ShowDropDownListBox has been called multiple times before HideDropDownListBox")

        ' Add dropDownListBox to the DataGridView. 
        Me.DataGridView.Controls.Add(dropDownListBox)

        ' Set the input focus to dropDownListBox. 
        dropDownListBox.Focus()

        ' Invalidate the cell so that the drop-down button will repaint
        ' in the pressed state. 
        Me.DataGridView.InvalidateCell(Me)

    End Sub

    ''' <summary>
    ''' Hides the drop-down filter list. 
    ''' </summary>
    Public Sub HideDropDownList()

        Debug.Assert(Me.DataGridView IsNot Nothing, "DataGridView is null")

        ' Hide dropDownListBox, remove handlers from its events, and remove 
        ' it from the DataGridView control. 
        dropDownListBoxShowing = False
        dropDownListBox.Visible = False
        UnhandleDropDownListBoxEvents()
        Me.DataGridView.Controls.Remove(dropDownListBox)

        ' Invalidate the cell so that the drop-down button will repaint
        ' in the unpressed state. 
        Me.DataGridView.InvalidateCell(Me)

    End Sub

    ''' <summary>
    ''' Sets the dropDownListBox size and position based on the formatted 
    ''' values in the filters dictionary and the position of the drop-down 
    ''' button. Called only by ShowDropDownListBox.  
    ''' </summary>
    Private Sub SetDropDownListBoxBounds()

        Debug.Assert(filters.Count > 0, "filters.Count <= 0")

        ' Declare variables that will be used in the calculation, 
        ' initializing dropDownListBoxHeight to account for the 
        ' ListBox borders.
        Dim dropDownListBoxHeight As Int32 = 2
        Dim currentWidth As Int32 = 0
        Dim dropDownListBoxWidth As Int32 = 0
        Dim dropDownListBoxLeft As Int32 = 0

        ' For each formatted value in the filters dictionary Keys collection,
        ' add its height to dropDownListBoxHeight and, if it is wider than 
        ' all previous values, set dropDownListBoxWidth to its width.
        Dim graphics As Graphics = dropDownListBox.CreateGraphics()
        Try
            Dim filter As String
            For Each filter In filters.Keys
                Dim stringSizeF As SizeF = _
                    graphics.MeasureString(filter, dropDownListBox.Font)
                dropDownListBoxHeight += CInt(Int(stringSizeF.Height) + 10)
                currentWidth = CType(stringSizeF.Width, Int32)
                If dropDownListBoxWidth < currentWidth Then
                    dropDownListBoxWidth = currentWidth
                End If
            Next filter
        Finally
            graphics.Dispose()
        End Try

        ' Increase the width to allow for horizontal margins and borders. 
        dropDownListBoxWidth += 20

        ' Constrain the dropDownListBox height to the 
        ' DropDownListBoxMaxHeightInternal value, which is based on 
        ' the DropDownListBoxMaxLines property value but constrained by
        ' the maximum height available in the DataGridView control.
        If dropDownListBoxHeight > DropDownListBoxMaxHeightInternal Then

            dropDownListBoxHeight = DropDownListBoxMaxHeightInternal

            ' If the preferred height is greater than the available height,
            ' adjust the width to accommodate the vertical scroll bar. 
            dropDownListBoxWidth += SystemInformation.VerticalScrollBarWidth

        End If

        ' Calculate the ideal location of the left edge of dropDownListBox 
        ' based on the location of the drop-down button and taking the 
        ' RightToLeft property value into consideration. 
        If Me.DataGridView.RightToLeft = RightToLeft.No Then
            dropDownListBoxLeft = DropDownButtonBounds.Right - dropDownListBoxWidth + 1
        Else
            dropDownListBoxLeft = DropDownButtonBounds.Left - 1
        End If

        ' Determine the left and right edges of the available horizontal
        ' width of the DataGridView control. 
        Dim clientLeft As Int32 = 1
        Dim clientRight As Int32 = Me.DataGridView.ClientRectangle.Right
        If Me.DataGridView.DisplayedRowCount(False) < Me.DataGridView.RowCount Then
            If Me.DataGridView.RightToLeft = RightToLeft.Yes Then
                clientLeft += SystemInformation.VerticalScrollBarWidth
            Else
                clientRight -= SystemInformation.VerticalScrollBarWidth
            End If
        End If

        ' Adjust the dropDownListBox location and/or width if it would
        ' otherwise overlap the left or right edge of the DataGridView.
        If dropDownListBoxLeft < clientLeft Then
            dropDownListBoxLeft = clientLeft
        End If
        Dim dropDownListBoxRight As Int32 = _
            dropDownListBoxLeft + dropDownListBoxWidth + 1
        If dropDownListBoxRight > clientRight Then
            If dropDownListBoxLeft = clientLeft Then
                dropDownListBoxWidth -= dropDownListBoxRight - clientRight
            Else
                dropDownListBoxLeft -= dropDownListBoxRight - clientRight
                If dropDownListBoxLeft < clientLeft Then
                    dropDownListBoxWidth -= clientLeft - dropDownListBoxLeft
                    dropDownListBoxLeft = clientLeft
                End If
            End If
        End If

        ' Set the ListBox.Bounds property using the calculated values. 
        dropDownListBox.Bounds = New Rectangle(dropDownListBoxLeft, _
            DropDownButtonBounds.Bottom, dropDownListBoxWidth, _
            dropDownListBoxHeight)

    End Sub 'SetDropDownListBoxBounds

    ''' <summary>
    ''' Gets the actual maximum height of the drop-down list, in pixels.
    ''' The maximum height is calculated from the DropDownListBoxMaxLines 
    ''' property value, but is limited to the available height of the 
    ''' DataGridView control. 
    ''' </summary>
    Protected ReadOnly Property DropDownListBoxMaxHeightInternal() As Int32
        Get
            ' Calculate the height of the available client area
            ' in the DataGridView control, taking the horizontal
            ' scroll bar into consideration and leaving room
            ' for the ListBox bottom border. 
            Dim dataGridViewMaxHeight As Int32 = _
                Me.DataGridView.Height - Me.DataGridView.ColumnHeadersHeight - 1
            If Me.DataGridView.DisplayedColumnCount(False) < _
                Me.DataGridView.ColumnCount Then
                dataGridViewMaxHeight -= SystemInformation.HorizontalScrollBarHeight
            End If

            ' Calculate the height of the list box, using the combined 
            ' height of all items plus 2 for the top and bottom border. 
            Dim listMaxHeight As Int32 = _
                dropDownListBoxMaxLinesValue * dropDownListBox.ItemHeight + 2

            ' Return the smaller of the two values. 
            If listMaxHeight < dataGridViewMaxHeight Then
                Return listMaxHeight
            Else
                Return dataGridViewMaxHeight
            End If
        End Get
    End Property

#End Region 'drop-down list

#Region "ListBox events: HandleDropDownListBoxEvents, UnhandleDropDownListBoxEvents, ListBox event handlers"

    ''' <summary>
    ''' Adds handlers to ListBox events for handling mouse
    ''' and keyboard input.
    ''' </summary>
    Private Sub HandleDropDownListBoxEvents()
        AddHandler dropDownListBox.MouseClick, AddressOf DropDownListBox_MouseClick
        AddHandler dropDownListBox.LostFocus, AddressOf DropDownListBox_LostFocus
        AddHandler dropDownListBox.KeyDown, AddressOf DropDownListBox_KeyDown
    End Sub

    ''' <summary>
    ''' Removes the ListBox event handlers. 
    ''' </summary>
    Private Sub UnhandleDropDownListBoxEvents()
        RemoveHandler dropDownListBox.MouseClick, AddressOf DropDownListBox_MouseClick
        RemoveHandler dropDownListBox.LostFocus, AddressOf DropDownListBox_LostFocus
        RemoveHandler dropDownListBox.KeyDown, AddressOf DropDownListBox_KeyDown
    End Sub

    ''' <summary>
    ''' Adjusts the filter in response to a user selection from the drop-down list. 
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A MouseEventArgs that contains the event data.</param>
    Private Sub DropDownListBox_MouseClick( _
        ByVal sender As Object, ByVal e As MouseEventArgs)

        Debug.Assert(Me.DataGridView IsNot Nothing, "DataGridView is null")

        ' Continue only if the mouse click was in the content area
        ' and not on the scroll bar. 
        If Not dropDownListBox.DisplayRectangle.Contains(e.X, e.Y) Then
            Return
        End If

        UpdateFilter()
        HideDropDownList()

    End Sub

    ''' <summary>
    ''' Indicates whether the drop-down list lost focus because the
    ''' user clicked the drop-down button. 
    ''' </summary>
    Private lostFocusOnDropDownButtonClick As Boolean

    ''' <summary>
    ''' Hides the drop-down list when it loses focus. 
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">An EventArgs that contains the event data.</param>
    Private Sub DropDownListBox_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
        ' If the focus was lost because the user clicked the drop-down
        ' button, store a value that prevents the subsequent OnMouseDown
        ' call from displaying the drop-down list again. 
        If DropDownButtonBounds.Contains( _
            Me.DataGridView.PointToClient( _
            New Point(Control.MousePosition.X, Control.MousePosition.Y))) Then
            lostFocusOnDropDownButtonClick = True
        End If
        HideDropDownList()
    End Sub

    ''' <summary>
    ''' Handles the ENTER and ESC keys.
    ''' </summary>
    ''' <param name="sender">The object that raised the event.</param>
    ''' <param name="e">A KeyEventArgs that contains the event data.</param>
    Sub DropDownListBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter
                UpdateFilter()
                HideDropDownList()
            Case Keys.Escape
                HideDropDownList()
        End Select
    End Sub

#End Region 'ListBox events

#Region "filtering: PopulateFilters, FilterWithoutCurrentColumn, UpdateFilter, RemoveFilter, AvoidNewRowWhenFiltering, GetFilterStatus"

    ''' <summary>
    ''' Populates the filters dictionary with formatted and unformatted string
    ''' representations of each unique value in the column, accounting for all 
    ''' filters except the current column's. Also adds special filter options. 
    ''' </summary>
    Private Sub PopulateFilters()

        ' Continue only if there is a DataGridView.
        If Me.DataGridView Is Nothing Or Me.DataGridView.DataSource Is Nothing Then
            Return
        End If

        ' Cast the data source to a BindingSource. 
        Dim data As BindingSource = _
            TryCast(Me.DataGridView.DataSource, BindingSource)

        ' return no data
        If data.Count <= 0 Then Return

        Debug.Assert(data IsNot Nothing AndAlso _
            data.SupportsFiltering AndAlso OwningColumn IsNot Nothing, _
            "DataSource is not a BindingSource, or does not support filtering, or OwningColumn is null")

        ' Prevent the data source from notifying the DataGridView of changes. 
        data.RaiseListChangedEvents = False

        ' Cache the current BindingSource.Filter value and then change 
        ' the Filter property to temporarily remove any filter for the 
        ' current column. 
        Dim oldFilter As String = data.Filter
        data.Filter = FilterWithoutCurrentColumn(oldFilter)

        ' Reset the filters dictionary and initialize some flags
        ' to track whether special filter options are needed. 
        filters.Clear()
        Dim containsBlanks As Boolean = False
        Dim containsNonBlanks As Boolean = False

        ' Initialize an ArrayList to store the values in their original
        ' types. This enables the values to be sorted appropriately.  
        Dim list As New ArrayList(data.Count)

        ' Retrieve each value and add it to the ArrayList if it isn't
        ' already present. 
        Dim item As Object
        For Each item In data
            Dim value As Object = Nothing

            ' Use the ICustomTypeDescriptor interface to retrieve properties
            ' if it is available otherwise, use reflection. The 
            ' ICustomTypeDescriptor interface is useful to customize 
            ' which values are exposed as properties. For example, the 
            ' DataRowView class implements ICustomTypeDescriptor to expose 
            ' cell values as property values.                
            ' 
            ' Iterate through the property names to find a case-insensitive
            ' match with the DataGridViewColumn.DataPropertyName value.
            ' This is necessary because DataPropertyName is case-
            ' insensitive, but the GetProperties and GetProperty methods
            ' used below are case-sensitive.
            Dim ictd As ICustomTypeDescriptor = TryCast(item, ICustomTypeDescriptor)
            If ictd IsNot Nothing Then

                Dim properties As PropertyDescriptorCollection = ictd.GetProperties()
                For Each prop As PropertyDescriptor In properties

                    If (String.Compare(Me.OwningColumn.DataPropertyName, _
                        prop.Name, True, _
                        System.Globalization.CultureInfo.InvariantCulture) = 0) Then

                        value = prop.GetValue(item)
                        Exit For

                    End If

                Next

            Else

                Dim properties As PropertyInfo() = item.GetType().GetProperties( _
                    BindingFlags.Public Or BindingFlags.Instance)
                For Each prop As PropertyInfo In properties

                    If (String.Compare(Me.OwningColumn.DataPropertyName, _
                        prop.Name, True, _
                        System.Globalization.CultureInfo.InvariantCulture) = 0) Then

                        value = prop.GetValue(item, Nothing)
                        Exit For

                    End If
                Next

            End If

            ' Skip empty values, but note that they are present. 
            If value Is Nothing OrElse value Is DBNull.Value Then
                containsBlanks = True
                Continue For
            End If

            ' Add values to the ArrayList if they are not already there.
            If Not list.Contains(value) Then
                list.Add(value)
            End If
        Next item

        ' Sort the ArrayList. The default Sort method uses the IComparable 
        ' implementation of the stored values so that string, numeric, and 
        ' date values will all be sorted correctly. 
        list.Sort()

        ' Convert each value in the ArrayList to its formatted representation
        ' and store both the formatted and unformatted string representations
        ' in the filters dictionary. 
        For Each value As Object In list
            ' Use the cell's GetFormattedValue method with the column's
            ' InheritedStyle property so that the dropDownListBox format
            ' will match the display format used for the column's cells. 
            Dim formattedValue As String = Nothing
            Dim style As DataGridViewCellStyle = OwningColumn.InheritedStyle
            formattedValue = CStr(GetFormattedValue(value, -1, style, _
                Nothing, Nothing, DataGridViewDataErrorContexts.Formatting))

            If String.IsNullOrEmpty(formattedValue) Then
                ' Skip empty values, but note that they are present.
                containsBlanks = True
            ElseIf Not filters.Contains(formattedValue) Then
                ' Note whether non-empty values are present. 
                containsNonBlanks = True

                ' For all non-empty values, add the formatted and 
                ' unformatted string representations to the filters 
                ' dictionary.
                filters.Add(formattedValue, value.ToString())
            End If
        Next value

        ' Restore the filter to the cached filter string and 
        ' re-enable data source change notifications. 
        If oldFilter IsNot Nothing Then data.Filter = oldFilter
        data.RaiseListChangedEvents = True

        ' Add special filter options to the filters dictionary
        ' along with null values, since unformatted representations
        ' are not needed. 
        filters.Insert(0, "(All)", Nothing)
        If containsBlanks AndAlso containsNonBlanks Then
            filters.Add("(Blanks)", Nothing)
            filters.Add("(NonBlanks)", Nothing)
        End If

    End Sub 'PopulateFilters

    ''' <summary>
    ''' Returns a copy of the specified filter string after removing the 
    ''' part that filters the current column, if present. 
    ''' </summary>
    ''' <param name="filter">The filter string to parse.</param>
    ''' <returns>A copy of the specified filter string 
    ''' without the current column's filter.</returns>
    Private Function FilterWithoutCurrentColumn(ByVal filter As String) As String

        ' If there is no filter in effect, return String.Empty. 
        If String.IsNullOrEmpty(filter) Then
            Return String.Empty
        End If

        ' If the column is not filtered, return the filter string unchanged. 
        If Not filtered Then
            Return filter
        End If

        If filter.IndexOf(currentColumnFilter) > 0 Then
            ' If the current column filter is not the first filter, return
            ' the specified filter value without the current column filter 
            ' and without the preceding " AND ". 
            Return filter.Replace(" AND " & currentColumnFilter, String.Empty)
        Else
            If filter.Length > currentColumnFilter.Length Then
                ' If the current column filter is the first of multiple 
                ' filters, return the specified filter value without the 
                ' current column filter and without the subsequent " AND ". 
                Return filter.Replace(currentColumnFilter & " AND ", String.Empty)
            Else
                ' If the current column filter is the only filter, 
                ' return the empty string.
                Return String.Empty
            End If
        End If

    End Function 'FilterWithoutCurrentColumn

    ''' <summary>
    ''' Updates the BindingSource.Filter value based on a user selection
    ''' from the drop-down filter list. 
    ''' </summary>
    Private Sub UpdateFilter()

        ' Continue only if the selection has changed.
        If dropDownListBox.SelectedItem.ToString().Equals(selectedFilterValue) Then
            Return
        End If

        ' Store the new selection value. 
        selectedFilterValue = dropDownListBox.SelectedItem.ToString()

        ' Cast the data source to an IBindingListView.
        Dim data As IBindingListView = _
            TryCast(Me.DataGridView.DataSource, IBindingListView)

        Debug.Assert(data IsNot Nothing AndAlso data.SupportsFiltering, _
            "DataSource is not an IBindingListView or does not support filtering")

        ' If the user selection is (All), remove any filter currently 
        ' in effect for the column. 
        If selectedFilterValue.Equals("(All)") Then
            data.Filter = FilterWithoutCurrentColumn(data.Filter)
            filtered = False
            currentColumnFilter = String.Empty
            Return
        End If

        ' Declare a variable to store the filter string for this column.
        Dim newColumnFilter As String = Nothing

        ' Store the column name in a form acceptable to the Filter property, 
        ' using a backslash to escape any closing square brackets. 
        Dim columnProperty As String = OwningColumn.DataPropertyName.Replace("]", "\]")

        ' Determine the column filter string based on the user selection.
        ' For (Blanks) and (NonBlanks), the filter string determines whether
        ' the column value is null or an empty string. Otherwise, the filter
        ' string determines whether the column value is the selected value. 
        Select Case selectedFilterValue
            Case "(Blanks)"
                newColumnFilter = String.Format( _
                    "LEN(ISNULL(CONVERT([{0}],'System.String'),''))=0", columnProperty)
            Case "(NonBlanks)"
                newColumnFilter = String.Format( _
                    "LEN(ISNULL(CONVERT([{0}],'System.String'),''))>0", columnProperty)
            Case Else
                newColumnFilter = String.Format("[{0}]='{1}'", columnProperty, _
                    CStr(filters(selectedFilterValue)).Replace("'", "''"))
        End Select

        ' Determine the new filter string by removing the previous column 
        ' filter string from the BindingSource.Filter value, then appending 
        ' the new column filter string, using " AND " as appropriate. 
        Dim newFilter As String = FilterWithoutCurrentColumn(data.Filter)
        If String.IsNullOrEmpty(newFilter) Then
            newFilter &= newColumnFilter
        Else
            newFilter &= " AND " & newColumnFilter
        End If

        ' Set the filter to the new value.
        Try
            data.Filter = newFilter
        Catch ex As InvalidExpressionException
            Throw New NotSupportedException("Invalid expression: " & newFilter, ex)
        End Try

        ' Indicate that the column is currently filtered
        ' and store the new column filter for use by subsequent
        ' calls to the FilterWithoutCurrentColumn method. 
        filtered = True
        currentColumnFilter = newColumnFilter

    End Sub 'UpdateFilter

    ''' <summary>
    ''' Removes the filter from the BindingSource bound to the specified DataGridView. 
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView bound to the BindingSource to unfilter.</param>
    Public Shared Sub RemoveFilter(ByVal dataGridView As DataGridView)

        If dataGridView Is Nothing Then
            Throw New ArgumentNullException("dataGridView")
        End If

        ' Cast the data source to a BindingSource.
        Dim data As BindingSource = _
            TryCast(dataGridView.DataSource, BindingSource)

        ' Confirm that the data source is a BindingSource that 
        ' supports filtering.
        If data Is Nothing OrElse _
            data.DataSource Is Nothing OrElse _
            Not data.SupportsFiltering Then
            Throw New ArgumentException("The DataSource property of the " & _
            "specified DataGridView is not set to a BindingSource " & _
            "with a SupportsFiltering property value of true.")
        End If

        ' Ensure that the current row is not the row for new records.
        ' This prevents the new row from being added when the filter changes.
        If dataGridView.CurrentRow IsNot Nothing AndAlso _
            dataGridView.CurrentRow.IsNewRow Then
            dataGridView.CurrentCell = Nothing
        End If

        ' Remove the filter. 
        data.Filter = Nothing

    End Sub 'RemoveFilter

    ''' <summary>
    ''' Gets a status string for the specified DataGridView indicating the 
    ''' number of visible rows in the bound, filtered BindingSource, or 
    ''' String.Empty if all rows are currently visible. 
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView bound to the 
    ''' BindingSource to return the filter status for.</param>
    ''' <returns>A string in the format "x of y records found" where x is 
    ''' the number of rows currently displayed and y is the number of rows 
    ''' available, or String.Empty if all rows are currently displayed.</returns>
    Public Shared Function GetFilterStatus( _
        ByVal dataGridView As DataGridView) As String

        ' Continue only if the specified value is valid. 
        If dataGridView Is Nothing Then
            Throw New ArgumentNullException("dataGridView")
        End If

        ' Cast the data source to a BindingSource.
        Dim data As BindingSource = _
            TryCast(dataGridView.DataSource, BindingSource)

        ' Return String.Empty if there is no appropriate data source or
        ' there is no filter in effect. 
        If String.IsNullOrEmpty(data.Filter) OrElse _
            data Is Nothing OrElse _
            data.DataSource Is Nothing OrElse _
            Not data.SupportsFiltering Then
            Return String.Empty
        End If

        ' Retrieve the filtered row count. 
        Dim currentRowCount As Int32 = data.Count

        ' Retrieve the unfiltered row count by 
        ' temporarily unfiltering the data.
        data.RaiseListChangedEvents = False
        Dim oldFilter As String = data.Filter
        data.Filter = Nothing
        Dim unfilteredRowCount As Int32 = data.Count
        data.Filter = oldFilter
        data.RaiseListChangedEvents = True

        Debug.Assert(currentRowCount <= unfilteredRowCount, _
            "current count is greater than unfiltered count")

        ' Return String.Empty if the filtered and unfiltered counts
        ' are the same, otherwise, return the status string. 
        If currentRowCount = unfilteredRowCount Then
            Return String.Empty
        End If
        Return String.Format("{0} of {1} records found", _
            currentRowCount, unfilteredRowCount)

    End Function 'GetFilterStatus

#End Region 'filtering

#Region "button bounds: DropDownButtonBounds, InvalidateDropDownButtonBounds, SetDropDownButtonBounds, AdjustPadding"

    ''' <summary>
    ''' The bounds of the drop-down button, or Rectangle.Empty if filtering 
    ''' is disabled or the button bounds need to be recalculated. 
    ''' </summary>
    Private dropDownButtonBoundsValue As Rectangle = Rectangle.Empty

    ''' <summary>
    ''' The bounds of the drop-down button, or Rectangle.Empty if filtering
    ''' is disabled. Recalculates the button bounds if filtering is enabled
    ''' and the bounds are empty.
    ''' </summary>
    Protected ReadOnly Property DropDownButtonBounds() As Rectangle
        Get
            If Not FilteringEnabled Then
                Return Rectangle.Empty
            End If
            If dropDownButtonBoundsValue = Rectangle.Empty Then
                SetDropDownButtonBounds()
            End If
            Return dropDownButtonBoundsValue
        End Get
    End Property

    ''' <summary>
    ''' Sets dropDownButtonBoundsValue to Rectangle.Empty if it isn't already empty. 
    ''' This indicates that the button bounds should be recalculated. 
    ''' </summary>
    Private Sub InvalidateDropDownButtonBounds()
        If Not dropDownButtonBoundsValue.IsEmpty Then
            dropDownButtonBoundsValue = Rectangle.Empty
        End If
    End Sub

    ''' <summary>
    ''' Sets the position and size of dropDownButtonBoundsValue based on the current 
    ''' cell bounds and the preferred cell height for a single line of header text. 
    ''' </summary>
    Private Sub SetDropDownButtonBounds()

        ' Retrieve the cell display rectangle, which is used to 
        ' set the position of the drop-down button. 
        Dim cellBounds As Rectangle = _
            Me.DataGridView.GetCellDisplayRectangle(Me.ColumnIndex, -1, False)

        ' Initialize a variable to store the button edge length,
        ' setting its initial value based on the font height. 
        Dim buttonEdgeLength As Int32 = Me.InheritedStyle.Font.Height + 5

        ' Calculate the height of the cell borders and padding.
        Dim borderRect As Rectangle = BorderWidths( _
            Me.DataGridView.AdjustColumnHeaderBorderStyle( _
            Me.DataGridView.AdvancedColumnHeadersBorderStyle, _
            New DataGridViewAdvancedBorderStyle(), False, False))
        Dim borderAndPaddingHeight As Int32 = 2 + _
            borderRect.Top + borderRect.Height + _
            Me.InheritedStyle.Padding.Vertical
        Dim visualStylesEnabled As Boolean = _
            Application.RenderWithVisualStyles AndAlso _
            Me.DataGridView.EnableHeadersVisualStyles
        If visualStylesEnabled Then
            borderAndPaddingHeight += 3
        End If

        ' Constrain the button edge length to the height of the 
        ' column headers minus the border and padding height. 
        If buttonEdgeLength > _
            Me.DataGridView.ColumnHeadersHeight - _
            borderAndPaddingHeight Then
            buttonEdgeLength = _
                Me.DataGridView.ColumnHeadersHeight - borderAndPaddingHeight
        End If

        ' Constrain the button edge length to the
        ' width of the cell minus three.
        If buttonEdgeLength > cellBounds.Width - 3 Then
            buttonEdgeLength = cellBounds.Width - 3
        End If

        ' Calculate the location of the drop-down button, with adjustments
        ' based on whether visual styles are enabled. 
        Dim topOffset As Int32
        If visualStylesEnabled Then
            topOffset = 4
        Else
            topOffset = 1
        End If

        Dim top As Int32 = cellBounds.Bottom - buttonEdgeLength - topOffset

        Dim leftOffset As Int32
        If visualStylesEnabled Then
            leftOffset = 3
        Else
            leftOffset = 1
        End If

        Dim left As Int32 = 0

        If Me.DataGridView.RightToLeft = RightToLeft.No Then
            left = cellBounds.Right - buttonEdgeLength - leftOffset
        Else
            left = cellBounds.Left + leftOffset
        End If

        ' Set the dropDownButtonBoundsValue value using the calculated 
        ' values, and adjust the cell padding accordingly.  
        dropDownButtonBoundsValue = New Rectangle(left, top, buttonEdgeLength, buttonEdgeLength)
        AdjustPadding((buttonEdgeLength + leftOffset))

    End Sub 'SetDropDownButtonBounds

    ''' <summary>
    ''' Adjusts the cell padding to widen the header by the drop-down button width.
    ''' </summary>
    ''' <param name="newDropDownButtonPaddingOffset">The new drop-down button width.</param>
    Private Sub AdjustPadding(ByVal newDropDownButtonPaddingOffset As Int32)

        ' Determine the difference between the new and current 
        ' padding adjustment.
        Dim widthChange As Int32 = newDropDownButtonPaddingOffset - _
            currentDropDownButtonPaddingOffset

        ' If the padding needs to change, store the new value and 
        ' make the change.
        If widthChange <> 0 Then
            ' Store the offset for the drop-down button separately from 
            ' the padding in case the client needs additional padding.
            currentDropDownButtonPaddingOffset = newDropDownButtonPaddingOffset

            ' Create a new Padding using the adjustment amount, then add it
            ' to the cell's existing Style.Padding property value. 
            Dim dropDownPadding As Padding = New Padding(0, 0, widthChange, 0)
            Me.Style.Padding = _
                Padding.Add(Me.InheritedStyle.Padding, dropDownPadding)
        End If

    End Sub

    ''' <summary>
    ''' The current width of the drop-down button. This field is used to adjust the cell padding.  
    ''' </summary>
    Private currentDropDownButtonPaddingOffset As Int32

#End Region 'button bounds

#Region "public properties: FilteringEnabled, AutomaticSortingEnabled, DropDownListBoxMaxLines" '

    ''' <summary>
    ''' Indicates whether filtering is enabled for the owning column. 
    ''' </summary>
    Private filteringEnabledValue As Boolean = True

    ''' <summary>
    ''' Gets or sets a value indicating whether filtering is enabled.
    ''' </summary>
    <DefaultValue(True)> _
    Public Property FilteringEnabled() As Boolean
        Get
            ' Return filteringEnabledValue if there is no DataGridView
            ' or if its DataSource property has not been set. 
            If Me.DataGridView Is Nothing OrElse _
                Me.DataGridView.DataSource Is Nothing Then
                Return filteringEnabledValue
            End If

            ' If the DataSource property has been set, return a value that combines 
            ' the filteringEnabledValue and BindingSource.SupportsFiltering values.
            Dim data As BindingSource = _
                TryCast(Me.DataGridView.DataSource, BindingSource)
            Debug.Assert(data IsNot Nothing)
            Return filteringEnabledValue AndAlso data.SupportsFiltering
        End Get

        Set(ByVal value As Boolean)
            ' If filtering is disabled, remove the padding adjustment
            ' and invalidate the button bounds. 
            If Not value Then
                AdjustPadding(0)
                InvalidateDropDownButtonBounds()
            End If

            filteringEnabledValue = value
        End Set
    End Property

    ''' <summary>
    ''' Indicates whether automatic sorting is enabled. 
    ''' </summary>
    Private automaticSortingEnabledValue As Boolean = True

    ''' <summary>
    ''' Gets or sets a value indicating whether automatic sorting is 
    ''' enabled for the owning column. 
    ''' </summary>
    <DefaultValue(True)> _
    Public Property AutomaticSortingEnabled() As Boolean
        Get
            Return automaticSortingEnabledValue
        End Get
        Set(ByVal value As Boolean)
            automaticSortingEnabledValue = value
            If OwningColumn IsNot Nothing Then
                If value Then
                    OwningColumn.SortMode = _
                        DataGridViewColumnSortMode.Programmatic
                Else
                    OwningColumn.SortMode = _
                        DataGridViewColumnSortMode.NotSortable
                End If
            End If
        End Set
    End Property

    ''' <summary>
    ''' The maximum number of lines in the drop-down list. 
    ''' </summary>
    Private dropDownListBoxMaxLinesValue As Int32 = 20

    ''' <summary>
    ''' Gets or sets the maximum number of lines to display in the drop-down filter list. 
    ''' The actual height of the drop-down list is constrained by the DataGridView height. 
    ''' </summary>
    <DefaultValue(20)> _
    Public Property DropDownListBoxMaxLines() As Int32
        Get
            Return dropDownListBoxMaxLinesValue
        End Get
        Set(ByVal value As Int32)
            dropDownListBoxMaxLinesValue = value
        End Set
    End Property

#End Region 'public properties

    ''' <summary>
    ''' Represents a ListBox control used as a drop-down filter list
    ''' in a DataGridView control.
    ''' </summary>
    Private Class FilterListBox
        Inherits ListBox

        ''' <summary>
        ''' Initializes a new instance of the FilterListBox class.
        ''' </summary>
        Public Sub New()
            Visible = False
            IntegralHeight = True
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            TabStop = False
        End Sub

        ''' <summary>
        ''' Indicates that the FilterListBox will handle (or ignore) all 
        ''' keystrokes that are not handled by the operating system. 
        ''' </summary>
        ''' <param name="keyData">A Keys value that represents the keyboard input.</param>
        ''' <returns>true in all cases.</returns>
        Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
            Return True
        End Function

        ''' <summary>
        ''' Processes a keyboard message directly, preventing it from being
        ''' intercepted by the parent DataGridView control.
        ''' </summary>
        ''' <param name="m">A Message, passed by reference, that 
        ''' represents the window message to process.</param>
        ''' <returns>true if the message was processed by the control;
        ''' otherwise, false.</returns>
        Protected Overrides Function ProcessKeyMessage( _
            ByRef m As Message) As Boolean
            Return ProcessKeyEventArgs(m)
        End Function

    End Class 'FilterListBox

End Class 'DataGridViewAutoFilterColumnHeaderCell

