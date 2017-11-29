Imports log4net
Imports log4net.Config
Imports System.IO

Public Class ClsLog4jCtl

    '파일경로 변경
    Public Sub ChangeFilePath(ByVal repositoryName As ILog, ByVal appenderName As String, ByVal newFilename As String, ByVal newMaxSizeRollBackups As Integer)
        Dim repository As Repository.ILoggerRepository = repositoryName.Logger.Repository

        For Each appender As Appender.IAppender In repository.GetAppenders()

            'File
            If appender.Name.CompareTo(appenderName) = 0 AndAlso TypeOf appender Is Appender.FileAppender Then
                Dim fileAppender As Appender.FileAppender = DirectCast(appender, Appender.FileAppender)
                fileAppender.File = System.IO.Path.Combine(fileAppender.File, newFilename)
                fileAppender.ActivateOptions()
            End If

            'MaxSizeRollBackups
            If appender.Name.CompareTo(appenderName) = 0 AndAlso TypeOf appender Is Appender.RollingFileAppender Then
                Dim fileBackupsAppender As Appender.RollingFileAppender = DirectCast(appender, Appender.RollingFileAppender)
                fileBackupsAppender.MaxSizeRollBackups = newMaxSizeRollBackups
                fileBackupsAppender.ActivateOptions()
            End If


        Next

    End Sub

End Class

Public Class ClsLog4jXmlCtl
    Private m_XD As XDocument
    Private m_xmlFullPath As String

    Private Function GetProdById_Cfg(ByRef xd As XDocument) As XElement
        Return _
        (From p In xd.Descendants("configuration").Descendants("log4net") _
         Select p).FirstOrDefault
    End Function

    Public Sub setValue(ByVal FirstAttr As String, ByVal elementValue As String, ByVal value As String)
        Dim xeName As XElement
        Dim xeNameSub As XElement

        xeName = Me.GetProdById_Cfg(m_XD)

        For Each appender As XElement In xeName.Elements
            If appender.FirstAttribute = FirstAttr AndAlso appender.Name.LocalName = "appender" Then
                xeNameSub = appender.Element(elementValue)
                xeNameSub.SetAttributeValue("value", value)
            End If
        Next

    End Sub

    Public Function getValue(ByVal FirstAttr As String, ByVal elementValue As String) As String
        Dim xeName As XElement
        Dim xeNameSub As XElement
        Dim outAttValue As String = String.Empty

        xeName = Me.GetProdById_Cfg(m_XD)

        For Each appender As XElement In xeName.Elements
            If appender.FirstAttribute = FirstAttr AndAlso appender.Name.LocalName = "appender" Then
                xeNameSub = appender.Element(elementValue)
                outAttValue = Trim(xeNameSub.Attribute("value").Value)
            End If
        Next
        Return outAttValue

    End Function

    Public Sub New(ByVal xmlName As String)
        m_XD = XDocument.Load(xmlName)
        m_xmlFullPath = xmlName
    End Sub

    Public Sub Save()
        m_XD.Save(m_xmlFullPath)
    End Sub
End Class