Public Class DataGridViewMaskedEditColumn
    Inherits DataGridViewColumn
    Public Sub New()
        MyBase.New(New DataGridViewMaskedEditCell())
    End Sub
    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)

            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso _
                Not value.GetType().IsAssignableFrom(GetType(DataGridViewMaskedEditCell)) _
                Then
                Throw New InvalidCastException("Must be a MaskedEditCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
    Private m_strMask As String
    Public Property Mask() As String
        Get
            Return m_strMask
        End Get
        Set(ByVal value As String)
            m_strMask = value
        End Set
    End Property
    Private m_tyValidatingType As Type
    Public Property ValidatingType() As Type
        Get
            Return m_tyValidatingType
        End Get
        Set(ByVal value As Type)
            m_tyValidatingType = value
        End Set
    End Property
    Private m_cPromptChar As Char = "_"c
    Public Property PromptChar() As Char
        Get
            Return m_cPromptChar
        End Get
        Set(ByVal value As Char)
            m_cPromptChar = value
        End Set
    End Property
    Private ReadOnly Property MaskedEditCellTemplate() As DataGridViewMaskedEditCell
        Get
            Return TryCast(Me.CellTemplate, DataGridViewMaskedEditCell)
        End Get
    End Property
End Class
