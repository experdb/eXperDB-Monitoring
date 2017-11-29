Public Class frmPubWebBrowserView
    Dim COC As New ClsObjectCtl

    Private Sub PrintToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
        WebBrowser.ShowPrintDialog()
    End Sub

    Private Sub PreViewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreViewToolStripButton.Click
        WebBrowser.ShowPrintPreviewDialog()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        WebBrowser.ShowSaveAsDialog()
    End Sub

    Private Sub frmPubView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SaveToolStripButton.Image = COC.PuplationIco(eXperDB.Resources.iResources.save).ToBitmap
        PrintToolStripButton.Image = COC.PuplationIco(eXperDB.Resources.iResources.print).ToBitmap
        PreViewToolStripButton.Image = COC.PuplationIco(eXperDB.Resources.iResources.document).ToBitmap
    End Sub
End Class