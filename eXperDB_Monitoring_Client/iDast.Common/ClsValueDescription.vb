Public Class ClsValueDescription
    Private m_Value As Object
    Private m_Description As String

    Public ReadOnly Property Value() As Object
        Get
            Return m_Value
        End Get
    End Property

    Public ReadOnly Property Description() As String
        Get
            Return m_Description
        End Get
    End Property

    Public Sub New(ByVal NewValue As Object, ByVal NewDescription As String)
        m_Value = NewValue
        m_Description = NewDescription
    End Sub

    Public Overrides Function ToString() As String
        Return m_Description
    End Function
End Class