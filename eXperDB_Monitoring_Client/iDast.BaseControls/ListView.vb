Public Class ListView
    Inherits System.Windows.Forms.ListView


    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.MultiSelect = False
        Me.View = System.Windows.Forms.View.Details
        Me.ResumeLayout(False)

    End Sub


    Private M_Sort As Boolean = True

    <ComponentModel.Category("Add Property"), _
     ComponentModel.Description("숫자와 영문 대문자입력으로 변경합니다."), ComponentModel.DefaultValue(True)> _
    Public Property ColumnSort() As Boolean
        Get
            Return M_Sort
        End Get
        Set(ByVal Value As Boolean)
            M_Sort = Value
        End Set
    End Property
    Private m_SortingColumn As Windows.Forms.ColumnHeader


    Protected Overrides Sub OnColumnClick(e As Windows.Forms.ColumnClickEventArgs)
        MyBase.OnColumnClick(e)
        If M_Sort = True Then
            Dim new_sorting_column As Windows.Forms.ColumnHeader = Me.Columns(e.Column)

            ' Figure out the new sorting order.
            Dim sort_order As System.Windows.Forms.SortOrder
            If m_SortingColumn Is Nothing Then
                ' New column. Sort ascending.
                sort_order = Windows.Forms.SortOrder.Ascending
            Else
                ' See if this is the same column.
                If new_sorting_column.Equals(m_SortingColumn) Then
                    ' Same column. Switch the sort order.
                    If m_SortingColumn.Text.StartsWith("△ ") Then
                        sort_order = Windows.Forms.SortOrder.Descending
                    Else
                        sort_order = Windows.Forms.SortOrder.Ascending
                    End If
                Else
                    ' New column. Sort ascending.
                    sort_order = Windows.Forms.SortOrder.Ascending
                End If

                ' Remove the old sort indicator.
                m_SortingColumn.Text = _
                    m_SortingColumn.Text.Substring(2)
            End If

            ' Display the new sort order.
            m_SortingColumn = new_sorting_column
            If sort_order = Windows.Forms.SortOrder.Ascending Then
                m_SortingColumn.Text = "△ " & m_SortingColumn.Text
            Else
                m_SortingColumn.Text = "▽ " & m_SortingColumn.Text
            End If

            ' Create a comparer.
            Me.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

            ' Sort.
            Me.Sort()

        End If
    End Sub

End Class

Class ListViewComparer
    Implements IComparer

    Private m_ColumnNumber As Integer
    Private m_SortOrder As Windows.Forms.SortOrder

    Public Sub New(ByVal column_number As Integer, ByVal _
        sort_order As Windows.Forms.SortOrder)
        m_ColumnNumber = column_number
        m_SortOrder = sort_order
    End Sub

    ' Compare the items in the appropriate column
    ' for objects x and y.
    Public Function Compare(ByVal x As Object, ByVal y As _
        Object) As Integer Implements _
        System.Collections.IComparer.Compare
        Dim item_x As Windows.Forms.ListViewItem = DirectCast(x,  _
            Windows.Forms.ListViewItem)
        Dim item_y As Windows.Forms.ListViewItem = DirectCast(y,  _
            Windows.Forms.ListViewItem)

        ' Get the sub-item values.
        Dim string_x As String
        If item_x.SubItems.Count <= m_ColumnNumber Then
            string_x = ""
        Else
            string_x = item_x.SubItems(m_ColumnNumber).Text
        End If

        Dim string_y As String
        If item_y.SubItems.Count <= m_ColumnNumber Then
            string_y = ""
        Else
            string_y = item_y.SubItems(m_ColumnNumber).Text
        End If

        ' Compare them.
        If m_SortOrder = Windows.Forms.SortOrder.Ascending Then
            If IsNumeric(string_x) And IsNumeric(string_y) _
                Then
                Return Val(string_x).CompareTo(Val(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) _
                Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        Else
            If IsNumeric(string_x) And IsNumeric(string_y) _
                Then
                Return Val(string_y).CompareTo(Val(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) _
                Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If
    End Function
End Class

