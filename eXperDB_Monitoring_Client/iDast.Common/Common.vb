 
Public Module Common
    'configure 파일 경로
    Public ReadOnly iDAST_Cfg As String = System.IO.Path.Combine(CurDir(), "Configure.xml")
    'Shared Configure 파일 경로
    Public ReadOnly iDAST_SharedCfg = System.IO.Path.Combine(CurDir(), "Shared" & System.IO.Path.DirectorySeparatorChar & "Cfg")
    'Encoding
    Public ReadOnly iDAST_XmlEncodingType As System.Text.Encoding = System.Text.Encoding.UTF8

End Module
