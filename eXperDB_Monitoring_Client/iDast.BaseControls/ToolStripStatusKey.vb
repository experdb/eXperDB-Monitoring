
Imports System.Windows.Forms.Control
Imports System.Windows.Forms
Imports System.Drawing

Public Class ToolStripStatusKey
    Inherits System.Windows.Forms.ToolStripStatusLabel

    Public Event KeyStateChange(ByVal KeyOn As Boolean)

    Public Enum KeyStatePanelStyle As Integer
        CapsLock = Keys.CapsLock
        NumLock = Keys.NumLock
        Insert = Keys.Insert
        ScrollLock = Keys.Scroll
    End Enum

    Private m_KeyState As Boolean = True

    Public Property KeyState() As Boolean
        Get
            Return m_KeyState
        End Get
        Set(ByVal Value As Boolean)
            m_KeyState = Value
            RaiseEvent KeyStateChange(Value)
        End Set
    End Property

    Private m_CheckKey As KeyStatePanelStyle = KeyStatePanelStyle.CapsLock

    Public Property CheckKey() As KeyStatePanelStyle
        Get
            Return m_CheckKey
        End Get
        Set(ByVal Value As KeyStatePanelStyle)
            m_CheckKey = Value
            Me.Text = CheckKey.ToString
            m_KeyState = IsKeyLocked(m_CheckKey)
            RaiseEvent KeyStateChange(Value)
        End Set
    End Property

    Public Sub Update()
        RaiseEvent KeyStateChange(IsKeyLocked(m_CheckKey))
    End Sub

    Public Sub New(ByVal Key As KeyStatePanelStyle)
        Me.CheckKey = Key
        AddHandler Application.Idle, AddressOf Application_Idle
    End Sub

    Public Sub New()
        Me.New(KeyStatePanelStyle.CapsLock)
    End Sub

    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        Me.KeyState = IsKeyLocked(CheckKey)
    End Sub
     
    Private Sub KeyStatePanel_KeyStateChange(ByVal KeyOn As Boolean) Handles Me.KeyStateChange
        If KeyOn Then
            Me.ForeColor = _KeyOnColor
        Else
            Me.ForeColor = _KeyOffColor
        End If
    End Sub

    Private _KeyOffColor As System.Drawing.Color = Color.Gray
    Public Property KeyOffColor() As System.Drawing.Color
        Get
            Return _KeyOffColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            _KeyOffColor = Value
            RaiseEvent KeyStateChange(m_CheckKey)
        End Set
    End Property

    Private _KeyOnColor As System.Drawing.Color = SystemColors.ControlLightLight
    Public Property KeyOnColor() As System.Drawing.Color
        Get
            Return _KeyOnColor
        End Get
        Set(ByVal Value As System.Drawing.Color)
            _KeyOnColor = Value
            RaiseEvent KeyStateChange(m_CheckKey)
        End Set
    End Property


    Protected Overrides Sub OnVisibleChanged(ByVal e As System.EventArgs)
        MyBase.OnVisibleChanged(e)
        Update()

    End Sub

End Class