Imports System.Drawing
Imports System.Windows.Forms

Public Class iDastDataGridView
    Inherits System.Windows.Forms.DataGridView


    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If keyData = Keys.Enter Or keyData = Keys.Return Then
            Try
                MyBase.EndEdit()
                MyBase.ProcessCmdKey(msg, keyData)
                ' 자동 Row Add 가 아니고 , 선택된 Row가 있으면서 , 데이터 내용이 비워져 있지 않고 , 마지막 데이터 인 경우 
                If Me.AllowUserToAddRows = False _
                    AndAlso Me.SelectedRows.Count > 0 _
                    AndAlso Me.CurrentCell.RowIndex = Me.Rows.Count - 1 Then

                    If Me.DataSource IsNot Nothing Then
                        Select Case Me.DataSource.GetType
                            Case GetType(System.Windows.Forms.BindingSource)
                                Dim dtV As DataRowView = CType(DirectCast(Me.DataSource, System.Windows.Forms.BindingSource).AddNew(), DataRowView)


                            Case Else
                                MsgBox("아직 지원하지 않습니다.")
                        End Select


                    Else
                        Me.Rows.Add()

                    End If
                    Return True
                Else
                    If Me.CurrentCell.RowIndex + 1 <= Me.Rows.Count - 1 Then
                        Me.Rows(Me.CurrentCell.RowIndex + 1).Cells(Me.CurrentCell.ColumnIndex).Selected = True
                    End If

                    Return True
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
                Return False
            End Try
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

    End Function

    Protected Overrides Function ProcessDialogKey(keyData As Keys) As Boolean

        Return MyBase.ProcessDialogKey(keyData)

    End Function



    Public Sub New()
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)
        MyBase.SetStyle(ControlStyles.UserPaint, True)

        MyBase.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        MyBase.SetStyle(DoubleBuffered, True)
        MyBase.DoubleBuffered = True
    End Sub
End Class
