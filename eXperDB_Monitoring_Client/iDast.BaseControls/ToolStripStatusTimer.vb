
Imports System.Windows.Forms.Control
Imports System.Windows.Forms
Imports System.Drawing
Public Class ToolStripStatusTimer
    Inherits System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer As Timer

    Private _DateTimeStyle As DateTimeStyle

    Public Enum DateTimeStyle
        ShortDate = 0
        ShortTime = 1
        DateTime = 2
    End Enum
    <System.ComponentModel.DefaultValue(DateTimeStyle.ShortDate)> _
    Public Property DateTimeStype() As DateTimeStyle
        Get
            Return _DateTimeStyle
        End Get
        Set(ByVal Value As DateTimeStyle)
            If _DateTimeStyle.Equals(Value) = False Then
                _DateTimeStyle = Value
            End If
        End Set
    End Property





    Public Sub New()

        Timer = New Timer
        Timer.Interval = 700
        Timer.Enabled = True





    End Sub

    Private Sub Timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Me.DesignMode = False Then
            Dim strValue As String = ""

            Select Case _DateTimeStyle
                Case DateTimeStyle.DateTime : strValue = DateTime.Now.ToString
                Case DateTimeStyle.ShortDate : strValue = DateTime.Now.ToShortDateString
                Case DateTimeStyle.ShortTime : strValue = DateTime.Now.ToShortTimeString
            End Select

            Me.Text = strValue
        End If

    End Sub

End Class
