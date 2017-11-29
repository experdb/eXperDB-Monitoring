Public Class clsEnums
    ''' <summary>
    ''' 언어 상수 
    ''' </summary>
    ''' <remarks></remarks>
    <System.ComponentModel.Category("General")> _
    <System.ComponentModel.Description("Language")> _
    Public Enum AppLanguage
        ''' <summary>
        ''' 한국어 
        ''' </summary>
        ''' <remarks></remarks>
        <System.ComponentModel.Description("Language\Korean.xml")> _
        Korean = 0

        ''' <summary>
        ''' 영어 
        ''' </summary>
        ''' <remarks></remarks>
        <System.ComponentModel.Description("Language\English.xml")> _
        English = 1
    End Enum

    <System.ComponentModel.Category("Size")> _
    <System.ComponentModel.Description("Auto Compute Size")> _
    Public Enum FileSizeUnit
        <System.ComponentModel.Description(" Bytes")> _
        Bytes = 0
        <System.ComponentModel.Description(" KB")> _
        KB = 1
        <System.ComponentModel.Description(" MB")> _
        MB = 2
        <System.ComponentModel.Description(" GB")> _
        GB = 3
        <System.ComponentModel.Description(" TB")> _
        TB = 4
        <System.ComponentModel.Description(" PB")> _
        PB = 5
        <System.ComponentModel.Description(" EB")> _
        EB = 6
        <System.ComponentModel.Description(" ZB")> _
        ZB = 7
        <System.ComponentModel.Description(" YB")> _
        YB = 8
    End Enum

    <System.ComponentModel.Category("General")> _
    <System.ComponentModel.Description("Show Name")> _
    Public Enum ShowName
        <System.ComponentModel.Description("HOST NAME")> _
        HostName = 0
        <System.ComponentModel.Description("ALIAS NAME")> _
        AliasName = 1
    End Enum

  
End Class
