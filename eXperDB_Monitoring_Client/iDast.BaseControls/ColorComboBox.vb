Imports System.Windows.Forms
Imports System.Drawing

Public Class ColorCombobox
    Inherits System.Windows.Forms.ComboBox


    Public Sub New()
        MyBase.New()
        Me.DrawMode = Windows.Forms.DrawMode.OwnerDrawFixed
        Me.DropDownStyle = ComboBoxStyle.DropDownList

        Dim arrColor As New ArrayList
        Dim clrType As Type = GetType(System.Drawing.Color)
        Dim PropInfo As System.Reflection.PropertyInfo() = clrType.GetProperties(Reflection.BindingFlags.Static Or Reflection.BindingFlags.DeclaredOnly Or Reflection.BindingFlags.Public)
        For Each tmpProp As System.Reflection.PropertyInfo In PropInfo
            If tmpProp.Name.ToUpper <> "TRANSPARENT" Then
                MyBase.Items.Add(tmpProp.Name)
            End If

        Next


    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        Dim Gr As Graphics = e.Graphics
        Dim Rect As Rectangle = e.Bounds
        If e.Index >= 0 Then
            Dim strValue As String = MyBase.Items(e.Index).ToString
            Dim clr As Color = Color.FromName(strValue)

            Gr.FillRectangle(New SolidBrush(clr), Rect.X + 10, Rect.Y + 5, 50, Rect.Height - 10)
            Gr.DrawString(strValue, MyBase.Font, New SolidBrush(Color.Black), Rect.X + 65, Rect.Top)
        End If
    End Sub
End Class
