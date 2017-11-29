Imports System.IO
Imports System.Text
Imports System.Xml

Public Class ClsConfigure
   
    Public Enum enumConfig
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("TnsFullPath")> _
        OracleTnsFilePath = 0
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("TempPath")> _
        TempFilePath = 1
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("LogPath")> _
        LogFilePath = 2
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("UserPath")> _
        UserFilePath = 3
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("Certification")> _
        CertKey = 4
        <System.ComponentModel.Category("cfgAppender") _
        , System.ComponentModel.Description("BackupPath")> _
        BackupFilePath = 5

    End Enum
    
    Public Shared Function GetValues(ByVal enmCfg As enumConfig) As String
        Dim cfgXml As New ClsConfigureCtl(iDAST_Cfg)

        Dim strAttr As String = TryCast(enmCfg.GetType().GetMember(enmCfg.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
        Dim strElem As String = TryCast(enmCfg.GetType().GetMember(enmCfg.ToString)(0).GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
        Dim tmpStr As String = cfgXml.getValue(strAttr, strElem)
        Return tmpStr

    End Function


    ''' <summary>
    ''' System.Componentmodel.category 의 내용을 가져온다. 
    ''' 보편적인 용도 
    ''' </summary>
    ''' <param name="enmType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fn_rtnComponentCategory(ByVal enmType As Type) As String

        If enmType.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False).Count > 0 Then

            If TryCast(enmType.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute) IsNot Nothing Then
                Return TryCast(enmType.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
            Else
                Return ""
            End If
        Else
            Return ""
        End If


    End Function
    ''' <summary>
    ''' System.Componentmodel.category 의 내용을 가져온다. 
    ''' Enum 내부용 
    ''' </summary>
    ''' <param name="enmType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fn_rtnComponentCategory(ByVal Obj As System.Reflection.MemberInfo) As String
        If Obj.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False).Count > 0 Then
            If TryCast(Obj.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute) IsNot Nothing Then
                Return TryCast(Obj.GetCustomAttributes(GetType(System.ComponentModel.CategoryAttribute), False)(0), System.ComponentModel.CategoryAttribute).Category
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function


    ''' <summary>
    ''' system.componentmodel.description 의 내용을 가져온다. 
    ''' 보편적 용도 
    ''' </summary>
    ''' <param name="objType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fn_rtnComponentDescription(ByVal objType As Type) As String
        If objType.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False).Count > 0 Then

            If TryCast(objType.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute) IsNot Nothing Then
                Return TryCast(objType.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
            Else
                Return ""
            End If
        Else

            Return ""
        End If

    End Function

    ''' <summary>
    ''' system.componentmodel.description 의 내용을 가져온다. 
    ''' Enum 안에 Enum 용 
    ''' </summary>
    ''' <param name="objType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function fn_rtnComponentDescription(ByVal Obj As System.Reflection.MemberInfo) As String
        If Obj.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False).Count > 0 Then
            If TryCast(Obj.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute) IsNot Nothing Then
                Return TryCast(Obj.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), False)(0), System.ComponentModel.DescriptionAttribute).Description
            Else
                Return ""
            End If
        Else
            Return ""
        End If
    End Function

End Class

Public Class ClsConfigureCtl

    Private m_XD As XDocument
    Private m_xmlFullPath As String

    Private Function GetProdById_Cfg(ByRef xd As XDocument) As XElement
        Return _
        (From p In xd.Descendants("configuration").Descendants("public") _
         Select p).FirstOrDefault
    End Function

    Public Sub setValue(ByVal FirstAttr As String, ByVal elementValue As String, ByVal value As String)
        Dim xeName As XElement = Nothing
        Dim xeNameSub As XElement = Nothing

        xeName = Me.GetProdById_Cfg(m_XD)
        For Each appender As XElement In xeName.Elements
            If appender.FirstAttribute = FirstAttr Then
                xeNameSub = appender.Element(elementValue)
                If xeNameSub Is Nothing Then
                    xeNameSub = New System.Xml.Linq.XElement(elementValue)
                    appender.Add(xeNameSub)
                End If
                xeNameSub.SetAttributeValue("value", value)
            End If
        Next

        If xeNameSub Is Nothing Then

            Dim newXmlAppender As New XElement("appender")
            newXmlAppender.SetAttributeValue("name", FirstAttr)
            Dim newCXmlAppender As New XElement(elementValue)
            newCXmlAppender.SetAttributeValue("value", value)
            newXmlAppender.Add(newCXmlAppender)
            xeName.Add(newXmlAppender)



        End If

    End Sub

    Public Function getValue(ByVal FirstAttr As String, ByVal elementValue As String, Optional ByVal DefaultValue As String = "") As String
        Dim xeName As XElement
        Dim xeNameSub As XElement
        Dim outAttValue As String = String.Empty

        xeName = Me.GetProdById_Cfg(m_XD)

        For Each appender As XElement In xeName.Elements
            If appender.FirstAttribute = FirstAttr Then
                xeNameSub = appender.Element(elementValue)
                If xeNameSub IsNot Nothing Then

                    outAttValue = Trim(xeNameSub.Attribute("value").Value)
                End If

            End If
        Next
        Return IIf(outAttValue Is String.Empty, DefaultValue, outAttValue)

    End Function

    Public Sub New(ByVal xmlName As String)
        If System.IO.File.Exists(xmlName) = False Then
            If CreateXML(xmlName) = False Then
                Return
            End If
        End If

        ' ' "<?xml version="1.0" encoding="utf-8"?>" 







        m_XD = XDocument.Load(xmlName)
        m_xmlFullPath = xmlName
    End Sub

    Private Function CreateXML(ByVal Filenm As String) As Boolean

        If System.IO.File.Exists(Filenm) = False Then
            Dim XmlW As XmlWriter = XmlWriter.Create(Filenm)
            XmlW.WriteStartDocument()
            XmlW.WriteStartElement("configuration")
            XmlW.WriteEndElement()
            XmlW.WriteEndDocument()
            XmlW.Flush()
            XmlW.Close()




            Return True
        End If


        Return True
    End Function

    Public Sub Save()
        m_XD.Save(m_xmlFullPath)
    End Sub

End Class

