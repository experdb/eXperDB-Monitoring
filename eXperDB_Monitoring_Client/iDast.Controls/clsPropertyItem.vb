Imports System.ComponentModel
'PropertyGrid MenuItem Base Class(상속받아 메뉴아이템 생성)
Public Class ClsPropertyItem
    Inherits System.ComponentModel.StringConverter
    Protected _item As Object

    Public Overloads Overrides Function GetStandardValuesSupported( _
        ByVal context As ITypeDescriptorContext) As Boolean
        Return True 'True tells the propertygrid to display a combobox
    End Function

    Public Overloads Overrides Function _
        GetStandardValues(ByVal context As  _
        System.ComponentModel.ITypeDescriptorContext) _
        As System.ComponentModel.TypeConverter.StandardValuesCollection
        Return New StandardValuesCollection(_item)
    End Function

    Public Overloads Overrides Function _
         GetStandardValuesExclusive(ByVal context _
         As System.ComponentModel.ITypeDescriptorContext) _
        As Boolean
        Return True
    End Function
End Class
