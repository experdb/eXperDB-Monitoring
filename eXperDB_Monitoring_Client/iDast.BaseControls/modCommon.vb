Module modCommon
    Public Sub ShowStatus(ByVal ParentForm As System.Windows.Forms.Form, ByVal StatusMethod As String, ByVal ShowText As String)
        If ParentForm IsNot Nothing AndAlso ParentForm.IsMdiChild = True AndAlso _
           StatusMethod IsNot Nothing AndAlso _
           StatusMethod.Trim <> "" Then

            Dim assy As System.Reflection.Assembly = System.Reflection.Assembly.GetAssembly(ParentForm.GetType)
            For Each tmpModule As System.Type In assy.GetExportedTypes
                If tmpModule.Name.ToUpper = ParentForm.Name.ToUpper Then
                    For Each TMPmod As System.Reflection.MethodInfo In tmpModule.GetMethods
                        If TMPmod.Name.ToUpper = StatusMethod.ToUpper Then
                            TMPmod.Invoke(assy.CreateInstance(tmpModule.FullName), New Object() {ParentForm, ShowText})
                        End If
                    Next
                End If
                'For Each tmpM As System.Reflection.MethodInfo In tmpModle.GetMethods
                '    Debug.Print(tmpM.Name)
                'Next
            Next
        End If
    End Sub
End Module
