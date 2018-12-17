'---------------------------------------------------------------------
'  Copyright (C) Microsoft Corporation.  All rights reserved.
' 
'THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
'KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
'IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
'PARTICULAR PURPOSE.
'---------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.ComponentModel

''' <summary>
''' Represents a DataGridViewTextBoxColumn with a drop-down filter list accessible from the header cell.  
''' </summary>
Public Class DataGridViewAutoFilterTextBoxColumn
    Inherits DataGridViewTextBoxColumn

    ''' <summary>
    ''' Initializes a new instance of the DataGridViewAutoFilterTextBoxColumn class.
    ''' </summary>
    Public Sub New()
        MyBase.DefaultHeaderCellType = GetType(DataGridViewAutoFilterColumnHeaderCell)
        MyBase.SortMode = DataGridViewColumnSortMode.Programmatic
    End Sub

#Region "public properties that hide inherited, non-virtual properties: DefaultHeaderCellType and SortMode"

    ''' <summary>
    ''' Returns the AutoFilter header cell type. This property hides the 
    ''' non-virtual DefaultHeaderCellType property inherited from the 
    ''' DataGridViewBand class. The inherited property is set in the 
    ''' DataGridViewAutoFilterTextBoxColumn constructor. 
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Never), Browsable(False), _
    DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Shadows ReadOnly Property DefaultHeaderCellType() As Type
        Get
            Return GetType(DataGridViewAutoFilterColumnHeaderCell)
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the sort mode for the column and prevents it from being 
    ''' set to Automatic, which would interfere with the proper functioning 
    ''' of the drop-down button. This property hides the non-virtual 
    ''' DataGridViewColumn.SortMode property from the designer. The inherited 
    ''' property is set in the DataGridViewAutoFilterTextBoxColumn constructor.
    ''' </summary>
    <EditorBrowsable(EditorBrowsableState.Advanced), Browsable(False), _
    DefaultValue(DataGridViewColumnSortMode.Programmatic)> _
    Public Shadows Property SortMode() As DataGridViewColumnSortMode
        Get
            Return MyBase.SortMode
        End Get
        Set(ByVal value As DataGridViewColumnSortMode)
            If value = DataGridViewColumnSortMode.Automatic Then
                Throw New InvalidOperationException( _
                    "A SortMode value of Automatic is incompatible with " & _
                    "the DataGridViewAutoFilterColumnHeaderCell type. " & _
                    "Use the AutomaticSortingEnabled property instead.")
            Else
                MyBase.SortMode = value
            End If
        End Set
    End Property

#End Region 'public properties that hide inherited, non-virtual properties

#Region "public properties: FilteringEnabled, AutomaticSortingEnabled, DropDownListBoxMaxLines"

    ''' <summary>
    ''' Gets or sets a value indicating whether filtering is enabled for this column. 
    ''' </summary>
    <DefaultValue(True)> _
    Public Property FilteringEnabled() As Boolean
        Get
            ' Return the header-cell value.
            Return CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).FilteringEnabled
        End Get
        Set(ByVal value As Boolean)
            ' Set the header-cell property. 
            CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).FilteringEnabled = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating whether automatic sorting is enabled for this column. 
    ''' </summary>
    <DefaultValue(True)> _
    Public Property AutomaticSortingEnabled() As Boolean
        Get
            ' Return the header-cell value.
            Return CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).AutomaticSortingEnabled
        End Get
        Set(ByVal value As Boolean)
            ' Set the header-cell property.
            CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).AutomaticSortingEnabled = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the maximum height of the drop-down filter list for this column. 
    ''' </summary>
    <DefaultValue(20)> _
    Public Property DropDownListBoxMaxLines() As Int32
        Get
            ' Return the header-cell value.
            Return CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).DropDownListBoxMaxLines
        End Get
        Set(ByVal value As Int32)
            ' Set the header-cell property.
            CType(HeaderCell, DataGridViewAutoFilterColumnHeaderCell).DropDownListBoxMaxLines = value
        End Set
    End Property

#End Region 'public properties

#Region "public, static, convenience methods: RemoveFilter and GetFilterStatus"

    ''' <summary>
    ''' Removes the filter from the BindingSource bound to the specified DataGridView. 
    ''' </summary>
    ''' <param name="dataGridView">The DataGridView bound to the BindingSource to unfilter.</param>
    Public Shared Sub RemoveFilter(ByVal dataGridView As DataGridView)
        DataGridViewAutoFilterColumnHeaderCell.RemoveFilter(dataGridView)
    End Sub

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
    Public Shared Function GetFilterStatus(ByVal dataGridView As DataGridView) As String
        Return DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView)
    End Function

#End Region 'public, static, convenience methods

End Class 'DataGridViewAutoFilterTextBoxColumn

