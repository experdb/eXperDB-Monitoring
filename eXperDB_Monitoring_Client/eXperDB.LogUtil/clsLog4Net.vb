Public Class clsLog4Net
    Private mLog As log4net.ILog
    Public Sub New()
        mLog = log4net.LogManager.GetLogger("DataExper")
        ' 로그 설정 파일은 LogCongiguration.xml 
        ' 로그는 Project\Assemblyinfo.vb 코딩함 
        '    <Assembly: log4net.Config.XmlConfigurator(ConfigFile:="logConfiguration.xml", watch:=True)> 
    End Sub

    Public Enum enmType
        [Information]
        [Error]
        [Debug]
        [Fatal]
        [Warning]
    End Enum

    Public Sub AddMessage(ByVal Type As enmType, ByVal Message As String)
        Select Case Type
            Case enmType.Information
                mLog.Info(Message)
            Case enmType.Debug
                mLog.Debug(Message)
            Case enmType.Error
                mLog.Error(Message)
            Case enmType.Fatal
                mLog.Fatal(Message)
            Case enmType.Warning
                mLog.Warn(Message)
        End Select
    End Sub



End Class
