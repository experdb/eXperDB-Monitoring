Imports System.ComponentModel
Imports System.Reflection
'PropertyGrid의 Property Base 클래스(해상 클래스를 상속받아 Property 클래스를 생성)
Public Class ClsProperty
    'Property의 속성을 ReadOnly 설정(True : ReadOnly, false : Read and Write)
    Protected Sub setReadOnlyProperty(propertyNm As String, mode As Boolean)
        Try
            Dim descriptor As PropertyDescriptor = TypeDescriptor.GetProperties(Me.GetType())(propertyNm)
            Dim attribute As ReadOnlyAttribute = descriptor.Attributes()(GetType(ReadOnlyAttribute))
            Dim fieldToChange As FieldInfo = attribute.GetType.GetField("isReadOnly", (BindingFlags.NonPublic Or BindingFlags.Instance))
            fieldToChange.SetValue(attribute, mode)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class
