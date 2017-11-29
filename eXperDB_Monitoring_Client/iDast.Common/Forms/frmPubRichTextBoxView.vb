Public Class frmPubRichTextBoxView
    Private COC As New ClsObjectCtl

    Private Sub RichTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox.KeyDown
        SqlLineLabel.Text = COC.GetLineNumberString(sender)
    End Sub

    Private Sub RichTextBox_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox.KeyUp
        SqlLineLabel.Text = COC.GetLineNumberString(sender)
    End Sub

    Private Sub RichTextBox_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox.MouseClick
        SqlLineLabel.Text = COC.GetLineNumberString(sender)
    End Sub

End Class