Imports log4net
Imports log4net.Config
Imports System.IO
Public Class ClsLoggMig
    '전환 로그 경로
    Public Shared ReadOnly MigLogCfg = System.IO.Path.Combine(iDAST_SharedCfg, "Mig.Log.xml")
    Public Shared Logger As log4net.ILog
    Shared Sub New()
        Dim C4JC As Object = New ClsLog4jXmlCtl(MigLogCfg)
        Dim COC As New ClsObjectCtl
        Dim migLoggPath As String = System.IO.Path.Combine(ClsConfigure.GetValues(ClsConfigure.enumConfig.LogFilePath), "MIGLOG")
        COC.MakeDir(migLoggPath)
        C4JC.setValue("Logging_Mig", "file", migLoggPath & Path.DirectorySeparatorChar & "Logging_Mig.log")
        C4JC.save()
        XmlConfigurator.Configure(New FileInfo(MigLogCfg))
        Logger = log4net.LogManager.GetLogger("Logging_Mig")
    End Sub
End Class