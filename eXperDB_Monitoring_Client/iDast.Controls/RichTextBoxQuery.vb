Imports System.Text.RegularExpressions
Imports System.ComponentModel

Public Class RichTextBoxQuery
    Inherits RichTextBox

    <Category("Colors")> _
    Private _Strings As Color = Color.Red
    Property Strings As Color
        Get
            Return _Strings
        End Get
        Set(value As Color)
            If Not _Strings.Equals(value) Then
                _Strings = value
                RegexClrChg()
            End If
        End Set
    End Property


    Private _Comments As Color = Color.Green
    <Category("Colors")> _
    Property Comments As Color
        Get
            Return _Comments
        End Get
        Set(value As Color)
            If Not _comments.equals(value) Then
                _Comments = value
                RegexClrChg()
               
            End If
        End Set
    End Property


    Private _Numbers As Color = Color.Magenta
    <Category("Colors")> _
    Property Numbers As Color
        Get
            Return _Numbers
        End Get
        Set(value As Color)
            If Not _Numbers.Equals(value) Then
                _Numbers = value
                RegexClrChg()
            End If
        End Set
    End Property

    Private _KeyWords As Color = Color.Blue
    <Category("Colors")> _
    Property KeyWords As Color
        Get
            Return _KeyWords
        End Get
        Set(value As Color)
            If Not _KeyWords.Equals(value) Then
                _KeyWords = value
                RegexClrChg()
            End If
        End Set
    End Property

    Private _Statements As Color = Color.Blue
    <Category("Colors")> _
    Property StateMents As Color
        Get
            Return _Statements
        End Get
        Set(value As Color)
            If Not _Statements.Equals(value) Then
                _Statements = value
                RegexClrChg()
            End If
        End Set
    End Property

    Private _Functions As Color = Color.Maroon
    <Category("Colors")> _
    Property Functions As Color
        Get
            Return _Functions
        End Get
        Set(value As Color)
            If Not _Functions.Equals(value) Then
                _Functions = value
                RegexClrChg()
            End If
        End Set
    End Property

    Private _Variables As Color = Color.Maroon
    <Category("Colors")> _
    Property Variables As Color
        Get
            Return _Variables
        End Get
        Set(value As Color)
            If Not _Variables.Equals(value) Then
                _Variables = value
                RegexClrChg()
            End If
        End Set
    End Property

    Private _Types As Color = Color.Brown
    <Category("Colors")> _
    Property Types As Color
        Get
            Return _Types
        End Get
        Set(value As Color)
            If Not _Types.Equals(value) Then
                _Types = value
                RegexClrChg()
            End If
        End Set
    End Property


    

    Private _VariableRegex As String = "\$[a-zA-Z_\d]*\b"
    Property VariableRegex As String
        Get
            Return _VariableRegex
        End Get
        Set(value As String)
            If Not _VariableRegex.Equals(value) Then
                SQLVarRegex = Nothing
                SQLVarRegex = New Regex(value)
                RegexClrChg()
            End If
        End Set
    End Property
     



    Dim SQlStringRegex As New Regex("""""|''|"".*?[^\\]""|'.*?[^\\]'")
    Dim SQLNumberRegex As New Regex("\b\d+[\.]?\d*([eE]\-?\d+)?\b")
    Dim SQLCommentRegex1 As New Regex("--.*$", RegexOptions.Multiline)
    Dim SQLCommentRegex2 As New Regex("(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
    Dim SQLCommentRegex3 As New Regex("(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
    Dim SQLVarRegex As New Regex("\$[a-zA-Z_\d]*\b")
    Dim SQLStatementsRegex As New Regex("\b(ALTER APPLICATION ROLE|ALTER ASSEMBLY|ALTER ASYMMETRIC KEY|ALTER AUTHORIZATION|ALTER BROKER PRIORITY|ALTER CERTIFICATE|ALTER CREDENTIAL|ALTER CRYPTOGRAPHIC PROVIDER|ALTER DATABASE|ALTER DATABASE AUDIT SPECIFICATION|ALTER DATABASE ENCRYPTION KEY|ALTER ENDPOINT|ALTER EVENT SESSION|ALTER FULLTEXT CATALOG|ALTER FULLTEXT INDEX|ALTER FULLTEXT STOPLIST|ALTER FUNCTION|ALTER INDEX|ALTER LOGIN|ALTER MASTER KEY|ALTER MESSAGE TYPE|ALTER PARTITION FUNCTION|ALTER PARTITION SCHEME|ALTER PROCEDURE|ALTER QUEUE|ALTER REMOTE SERVICE BINDING|ALTER RESOURCE GOVERNOR|ALTER RESOURCE POOL|ALTER ROLE|ALTER ROUTE|ALTER SCHEMA|ALTER SERVER AUDIT|ALTER SERVER AUDIT SPECIFICATION|ALTER SERVICE|ALTER SERVICE MASTER KEY|ALTER SYMMETRIC KEY|ALTER TABLE|ALTER TRIGGER|ALTER USER|ALTER VIEW|ALTER WORKLOAD GROUP|ALTER XML SCHEMA COLLECTION|BULK INSERT|CREATE AGGREGATE|CREATE APPLICATION ROLE|CREATE ASSEMBLY|CREATE ASYMMETRIC KEY|CREATE BROKER PRIORITY|CREATE CERTIFICATE|CREATE CONTRACT|CREATE CREDENTIAL|CREATE CRYPTOGRAPHIC PROVIDER|CREATE DATABASE|CREATE DATABASE AUDIT SPECIFICATION|CREATE DATABASE ENCRYPTION KEY|CREATE DEFAULT|CREATE ENDPOINT|CREATE EVENT NOTIFICATION|CREATE EVENT SESSION|CREATE FULLTEXT CATALOG|CREATE FULLTEXT INDEX|CREATE FULLTEXT STOPLIST|CREATE FUNCTION|CREATE INDEX|CREATE LOGIN|CREATE MASTER KEY|CREATE MESSAGE TYPE|CREATE PARTITION FUNCTION|CREATE PARTITION SCHEME|CREATE PROCEDURE|CREATE QUEUE|CREATE REMOTE SERVICE BINDING|CREATE RESOURCE POOL|CREATE ROLE|CREATE ROUTE|CREATE RULE|CREATE SCHEMA|CREATE SERVER AUDIT|CREATE SERVER AUDIT SPECIFICATION|CREATE SERVICE|CREATE SPATIAL INDEX|CREATE STATISTICS|CREATE SYMMETRIC KEY|CREATE SYNONYM|CREATE TABLE|CREATE TRIGGER|CREATE TYPE|CREATE USER|CREATE VIEW|CREATE WORKLOAD GROUP|CREATE XML INDEX|CREATE XML SCHEMA COLLECTION|DELETE|DISABLE TRIGGER|DROP AGGREGATE|DROP APPLICATION ROLE|DROP ASSEMBLY|DROP ASYMMETRIC KEY|DROP BROKER PRIORITY|DROP CERTIFICATE|DROP CONTRACT|DROP CREDENTIAL|DROP CRYPTOGRAPHIC PROVIDER|DROP DATABASE|DROP DATABASE AUDIT SPECIFICATION|DROP DATABASE ENCRYPTION KEY|DROP DEFAULT|DROP ENDPOINT|DROP EVENT NOTIFICATION|DROP EVENT SESSION|DROP FULLTEXT CATALOG|DROP FULLTEXT INDEX|DROP FULLTEXT STOPLIST|DROP FUNCTION|DROP INDEX|DROP LOGIN|DROP MASTER KEY|DROP MESSAGE TYPE|DROP PARTITION FUNCTION|DROP PARTITION SCHEME|DROP PROCEDURE|DROP QUEUE|DROP REMOTE SERVICE BINDING|DROP RESOURCE POOL|DROP ROLE|DROP ROUTE|DROP RULE|DROP SCHEMA|DROP SERVER AUDIT|DROP SERVER AUDIT SPECIFICATION|DROP SERVICE|DROP SIGNATURE|DROP STATISTICS|DROP SYMMETRIC KEY|DROP SYNONYM|DROP TABLE|DROP TRIGGER|DROP TYPE|DROP USER|DROP VIEW|DROP WORKLOAD GROUP|DROP XML SCHEMA COLLECTION|ENABLE TRIGGER|EXEC|EXECUTE|FROM|INSERT|MERGE|OPTION|OUTPUT|SELECT|TOP|TRUNCATE TABLE|UPDATE|UPDATE STATISTICS|WHERE|WITH)\b", RegexOptions.IgnoreCase)
    Dim SQLKeywordsRegex As New Regex("\b(ADD|ALL|AND|ANY|AS|ASC|AUTHORIZATION|BACKUP|BEGIN|BETWEEN|BREAK|BROWSE|BY|CASCADE|CHECK|CHECKPOINT|CLOSE|CLUSTERED|COLLATE|COLUMN|COMMIT|COMPUTE|CONSTRAINT|CONTAINS|CONTINUE|CROSS|CURRENT|CURRENT_DATE|CURRENT_TIME|CURSOR|DATABASE|DBCC|DEALLOCATE|DECLARE|DEFAULT|DENY|DESC|DISK|DISTINCT|DISTRIBUTED|DOUBLE|DUMP|ELSE|END|ERRLVL|ESCAPE|EXCEPT|EXISTS|EXIT|EXTERNAL|FETCH|FILE|FILLFACTOR|FOR|FOREIGN|FREETEXT|FULL|FUNCTION|GOTO|GRANT|GROUP|HAVING|HOLDLOCK|IDENTITY|IDENTITY_INSERT|IDENTITYCOL|IF|IN|INDEX|INNER|INTERSECT|INTO|IS|JOIN|KEY|KILL|LIKE|LINENO|LOAD|NATIONAL|NOCHECK|NONCLUSTERED|NOT|NULL|OF|OFF|OFFSETS|ON|OPEN|OR|ORDER|OUTER|OVER|PERCENT|PIVOT|PLAN|PRECISION|PRIMARY|PRINT|PROC|PROCEDURE|PUBLIC|RAISERROR|READ|READTEXT|RECONFIGURE|REFERENCES|REPLICATION|RESTORE|RESTRICT|RETURN|REVERT|REVOKE|ROLLBACK|ROWCOUNT|ROWGUIDCOL|RULE|SAVE|SCHEMA|SECURITYAUDIT|SET|SHUTDOWN|SOME|STATISTICS|TABLE|TABLESAMPLE|TEXTSIZE|THEN|TO|TRAN|TRANSACTION|TRIGGER|TSEQUAL|UNION|UNIQUE|UNPIVOT|UPDATETEXT|USE|USER|VALUES|VARYING|VIEW|WAITFOR|WHEN|WHILE|WRITETEXT)\b", RegexOptions.IgnoreCase)
    Dim SQLFunctionsRegex As New Regex("(NOW|@@CONNECTIONS|@@CPU_BUSY|@@CURSOR_ROWS|@@DATEFIRST|@@DATEFIRST|@@DBTS|@@ERROR|@@FETCH_STATUS|@@IDENTITY|@@IDLE|@@IO_BUSY|@@LANGID|@@LANGUAGE|@@LOCK_TIMEOUT|@@MAX_CONNECTIONS|@@MAX_PRECISION|@@NESTLEVEL|@@OPTIONS|@@PACKET_ERRORS|@@PROCID|@@REMSERVER|@@ROWCOUNT|@@SERVERNAME|@@SERVICENAME|@@SPID|@@TEXTSIZE|@@TRANCOUNT|@@VERSION)\b|\b(ABS|ACOS|APP_NAME|ASCII|ASIN|ASSEMBLYPROPERTY|AsymKey_ID|ASYMKEY_ID|asymkeyproperty|ASYMKEYPROPERTY|ATAN|ATN2|AVG|CASE|CAST|CEILING|Cert_ID|Cert_ID|CertProperty|CHAR|CHARINDEX|CHECKSUM_AGG|COALESCE|COL_LENGTH|COL_NAME|COLLATIONPROPERTY|COLLATIONPROPERTY|COLUMNPROPERTY|COLUMNS_UPDATED|COLUMNS_UPDATED|CONTAINSTABLE|CONVERT|COS|COT|COUNT|COUNT_BIG|CRYPT_GEN_RANDOM|CURRENT_TIMESTAMP|CURRENT_TIMESTAMP|CURRENT_USER|CURRENT_USER|CURSOR_STATUS|DATABASE_PRINCIPAL_ID|DATABASE_PRINCIPAL_ID|DATABASEPROPERTY|DATABASEPROPERTYEX|DATALENGTH|DATALENGTH|DATEADD|DATEDIFF|DATENAME|DATEPART|DAY|DB_ID|DB_NAME|DECRYPTBYASYMKEY|DECRYPTBYCERT|DECRYPTBYKEY|DECRYPTBYKEYAUTOASYMKEY|DECRYPTBYKEYAUTOCERT|DECRYPTBYPASSPHRASE|DEGREES|DENSE_RANK|DIFFERENCE|ENCRYPTBYASYMKEY|ENCRYPTBYCERT|ENCRYPTBYKEY|ENCRYPTBYPASSPHRASE|ERROR_LINE|ERROR_MESSAGE|ERROR_NUMBER|ERROR_PROCEDURE|ERROR_SEVERITY|ERROR_STATE|EVENTDATA|EXP|FILE_ID|FILE_IDEX|FILE_NAME|FILEGROUP_ID|FILEGROUP_NAME|FILEGROUPPROPERTY|FILEPROPERTY|FLOOR|fn_helpcollations|fn_listextendedproperty|fn_servershareddrives|fn_virtualfilestats|fn_virtualfilestats|FORMATMESSAGE|FREETEXTTABLE|FULLTEXTCATALOGPROPERTY|FULLTEXTSERVICEPROPERTY|GETANSINULL|GETDATE|GETUTCDATE|GROUPING|HAS_PERMS_BY_NAME|HOST_ID|HOST_NAME|IDENT_CURRENT|IDENT_CURRENT|IDENT_INCR|IDENT_INCR|IDENT_SEED|IDENTITY\(|INDEX_COL|INDEXKEY_PROPERTY|INDEXPROPERTY|IS_MEMBER|IS_OBJECTSIGNED|IS_SRVROLEMEMBER|ISDATE|ISDATE|ISNULL|ISNUMERIC|Key_GUID|Key_GUID|Key_ID|Key_ID|KEY_NAME|KEY_NAME|LEFT|LEN|LOG|LOG10|LOWER|LTRIM|MAX|MIN|MONTH|NCHAR|NEWID|NTILE|NULLIF|OBJECT_DEFINITION|OBJECT_ID|OBJECT_NAME|OBJECT_SCHEMA_NAME|OBJECTPROPERTY|OBJECTPROPERTYEX|OPENDATASOURCE|OPENQUERY|OPENROWSET|OPENXML|ORIGINAL_LOGIN|ORIGINAL_LOGIN|PARSENAME|PATINDEX|PATINDEX|PERMISSIONS|PI|POWER|PUBLISHINGSERVERNAME|PWDCOMPARE|PWDENCRYPT|QUOTENAME|RADIANS|RAND|RANK|REPLACE|REPLICATE|REVERSE|RIGHT|ROUND|ROW_NUMBER|ROWCOUNT_BIG|RTRIM|SCHEMA_ID|SCHEMA_ID|SCHEMA_NAME|SCHEMA_NAME|SCOPE_IDENTITY|SERVERPROPERTY|SESSION_USER|SESSION_USER|SESSIONPROPERTY|SETUSER|SIGN|SignByAsymKey|SignByCert|SIN|SOUNDEX|SPACE|SQL_VARIANT_PROPERTY|SQRT|SQUARE|STATS_DATE|STDEV|STDEVP|STR|STUFF|SUBSTRING|SUM|SUSER_ID|SUSER_NAME|SUSER_SID|SUSER_SNAME|SWITCHOFFSET|SYMKEYPROPERTY|symkeyproperty|sys\.dm_db_index_physical_stats|sys\.fn_builtin_permissions|sys\.fn_my_permissions|SYSDATETIME|SYSDATETIMEOFFSET|SYSTEM_USER|SYSTEM_USER|SYSUTCDATETIME|TAN|TERTIARY_WEIGHTS|TEXTPTR|TODATETIMEOFFSET|TRIGGER_NESTLEVEL|TYPE_ID|TYPE_NAME|TYPEPROPERTY|UNICODE|UPDATE\(|UPPER|USER_ID|USER_NAME|USER_NAME|VAR|VARP|VerifySignedByAsymKey|VerifySignedByCert|XACT_STATE|YEAR)\b", RegexOptions.IgnoreCase)
    Dim SQLTypesRegex As New Regex("\b(BIGINT|NUMERIC|BIT|SMALLINT|DECIMAL|SMALLMONEY|INT|TINYINT|MONEY|FLOAT|REAL|DATE|DATETIMEOFFSET|DATETIME2|SMALLDATETIME|DATETIME|TIME|CHAR|VARCHAR|TEXT|NCHAR|NVARCHAR|NTEXT|BINARY|VARBINARY|IMAGE|TIMESTAMP|HIERARCHYID|TABLE|UNIQUEIDENTIFIER|SQL_VARIANT|XML)\b", RegexOptions.IgnoreCase)



    'Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
    '    MyBase.OnKeyDown(e)
    '    If e.KeyCode = Keys.Space Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
    '        Dim intSt As Integer = Me.SelectionStart

    '        Me.SelectAll()
    '        Me.SelectionColor = Me.ForeColor
    '        Me.SelectionBackColor = Me.BackColor


    '        RegexClrChg()
    '        Me.SelectionStart = intSt
    '    End If
    'End Sub

    'Overloads Property Text As String
    '    Get
    '        Return MyBase.Text
    '    End Get
    '    Set(value As String)
    '        MyBase.Text = value
    '        RegexClrChg()
    '        Me.Select(0, 0)
    '    End Set
    'End Property


    Private ClrChanging As Boolean = False
    Public Sub RegexClrChg()
        If Me.Text.Trim = "" Then Return
        Dim intStart As Integer = Me.SelectionStart
        Me.SelectionStart = 0
        Me.SelectionLength = Me.Text.Length
        Me.SelectionColor = MyBase.ForeColor


        RegexClrChg(SQlStringRegex, _Strings)
        RegexClrChg(SQLNumberRegex, _Numbers)
        RegexClrChg(SQLStatementsRegex, _Statements)
        RegexClrChg(SQLKeywordsRegex, _KeyWords)
        RegexClrChg(SQLFunctionsRegex, _Functions)
        RegexClrChg(SQLTypesRegex, _Types)
        RegexClrChg(SQLVarRegex, _Variables)
        RegexClrChg(SQLCommentRegex1, _Comments)
        RegexClrChg(SQLCommentRegex2, _Comments)
        RegexClrChg(SQLCommentRegex3, _Comments)
        Me.SelectionLength = 0
        Me.SelectionStart = intStart

    End Sub

    Private Sub RegexClrChg(ByVal clsRegex As Regex, ByVal Clr As Color)
        If Me.Text.Trim = "" Then Return
        If clsRegex IsNot Nothing Then

            Dim Matches As MatchCollection = clsRegex.Matches(Me.Text)
            For Each tmpMatch As Match In Matches
                Dim pos As Integer = 0


                Me.Select(tmpMatch.Index, tmpMatch.Length)
                ClrChanging = True
                Me.SelectionColor = Clr
                ClrChanging = False
            Next
        End If

    End Sub
     

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        MyBase.OnTextChanged(e)
        If Me.IsHandleCreated AndAlso ClrChanging = False Then
            RegexClrChg()
        End If


    End Sub
End Class




