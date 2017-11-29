Imports log4net
Imports log4net.Config
Imports System.IO
Public Class ClsLog
    '전환 로그 경로
    Public ReadOnly MigLogCfg = System.IO.Path.Combine(iDAST_SharedCfg, "Mig.Log.xml")
    Private Logger As log4net.ILog

    Public Event LogMsg(ByVal msg As String)
    Public Sub New(DirNm As String, LogFileNm As String)
        Try
            Dim C4JC As Object = New ClsLog4jXmlCtl(MigLogCfg)
            Dim COC As New ClsObjectCtl
            Dim migLoggPath As String = System.IO.Path.Combine(ClsConfigure.GetValues(ClsConfigure.enumConfig.LogFilePath), DirNm)
            COC.MakeDir(migLoggPath)
            C4JC.setValue(LogFileNm, "file", migLoggPath & Path.DirectorySeparatorChar & LogFileNm & ".log")
            C4JC.save()
            XmlConfigurator.Configure(New FileInfo(MigLogCfg))
            Logger = log4net.LogManager.GetLogger(LogFileNm)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Sub err(msg As String, Optional type As Boolean = False)
        Try
            Logger.Error(msg)
            If type Then
                RaiseEvent LogMsg(msg)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message & ex.StackTrace)
        End Try
    End Sub
    Public Sub info(msg As String, Optional type As Boolean = False)
        Try
            Logger.Info(msg)
            If type Then
                RaiseEvent LogMsg(msg)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message & ex.StackTrace)
        End Try
    End Sub
End Class
