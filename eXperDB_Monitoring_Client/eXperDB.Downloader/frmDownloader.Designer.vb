<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDownloader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDownloader))
        Me.bgmanual = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1 = New eXperDB.BaseControls.TableLayoutPanel()
        Me.lblStatus = New eXperDB.BaseControls.Label()
        Me.PBDownloader = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New eXperDB.BaseControls.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bgmanual
        '
        Me.bgmanual.WorkerReportsProgress = True
        Me.bgmanual.WorkerSupportsCancellation = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PBDownloader, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblProgress, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(540, 114)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.FixedHeight = False
        Me.lblStatus.FixedWidth = False
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(173, 13)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(194, 24)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Downloading setup file..."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBDownloader
        '
        Me.PBDownloader.BackColor = System.Drawing.Color.AliceBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.PBDownloader, 3)
        Me.PBDownloader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PBDownloader.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PBDownloader.Location = New System.Drawing.Point(23, 51)
        Me.PBDownloader.Name = "PBDownloader"
        Me.PBDownloader.Size = New System.Drawing.Size(494, 23)
        Me.PBDownloader.Step = 1
        Me.PBDownloader.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PBDownloader.TabIndex = 1
        '
        'lblProgress
        '
        Me.lblProgress.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProgress.FixedHeight = False
        Me.lblProgress.FixedWidth = False
        Me.lblProgress.ForeColor = System.Drawing.Color.White
        Me.lblProgress.Location = New System.Drawing.Point(173, 77)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(194, 35)
        Me.lblProgress.TabIndex = 0
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDownloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(540, 114)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDownloader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eXperDB-Downloader"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bgmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblProgress As eXperDB.BaseControls.Label
    Friend WithEvents PBDownloader As System.Windows.Forms.ProgressBar
    Friend WithEvents TableLayoutPanel1 As eXperDB.BaseControls.TableLayoutPanel
    Friend WithEvents lblStatus As eXperDB.BaseControls.Label
End Class
