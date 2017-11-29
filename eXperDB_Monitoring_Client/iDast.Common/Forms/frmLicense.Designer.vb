<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicense
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicense))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LicenseNote = New System.Windows.Forms.Label()
        Me.gubActive = New System.Windows.Forms.GroupBox()
        Me.txtActiveCD = New System.Windows.Forms.TextBox()
        Me.btnProductActive = New System.Windows.Forms.Button()
        Me.gubSerialKey = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnActiveBe = New System.Windows.Forms.Button()
        Me.MaskSerialKey = New System.Windows.Forms.MaskedTextBox()
        Me.btnReqActiveCreate = New System.Windows.Forms.Button()
        Me.txtUserNM = New System.Windows.Forms.TextBox()
        Me.txtPhoneNO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCompanyNM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.gubActive.SuspendLayout()
        Me.gubSerialKey.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LicenseNote)
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'LicenseNote
        '
        resources.ApplyResources(Me.LicenseNote, "LicenseNote")
        Me.LicenseNote.Name = "LicenseNote"
        '
        'gubActive
        '
        Me.gubActive.Controls.Add(Me.txtActiveCD)
        Me.gubActive.Controls.Add(Me.btnProductActive)
        resources.ApplyResources(Me.gubActive, "gubActive")
        Me.gubActive.Name = "gubActive"
        Me.gubActive.TabStop = False
        '
        'txtActiveCD
        '
        resources.ApplyResources(Me.txtActiveCD, "txtActiveCD")
        Me.txtActiveCD.Name = "txtActiveCD"
        '
        'btnProductActive
        '
        resources.ApplyResources(Me.btnProductActive, "btnProductActive")
        Me.btnProductActive.Name = "btnProductActive"
        Me.btnProductActive.UseVisualStyleBackColor = True
        '
        'gubSerialKey
        '
        Me.gubSerialKey.Controls.Add(Me.LinkLabel1)
        Me.gubSerialKey.Controls.Add(Me.lblEmail)
        Me.gubSerialKey.Controls.Add(Me.Label1)
        Me.gubSerialKey.Controls.Add(Me.btnActiveBe)
        Me.gubSerialKey.Controls.Add(Me.MaskSerialKey)
        Me.gubSerialKey.Controls.Add(Me.btnReqActiveCreate)
        Me.gubSerialKey.Controls.Add(Me.txtUserNM)
        Me.gubSerialKey.Controls.Add(Me.txtPhoneNO)
        Me.gubSerialKey.Controls.Add(Me.Label13)
        Me.gubSerialKey.Controls.Add(Me.Label12)
        Me.gubSerialKey.Controls.Add(Me.txtCompanyNM)
        Me.gubSerialKey.Controls.Add(Me.Label10)
        Me.gubSerialKey.Controls.Add(Me.Label11)
        Me.gubSerialKey.Controls.Add(Me.txtEmail)
        resources.ApplyResources(Me.gubSerialKey, "gubSerialKey")
        Me.gubSerialKey.Name = "gubSerialKey"
        Me.gubSerialKey.TabStop = False
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'lblEmail
        '
        resources.ApplyResources(Me.lblEmail, "lblEmail")
        Me.lblEmail.Name = "lblEmail"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnActiveBe
        '
        resources.ApplyResources(Me.btnActiveBe, "btnActiveBe")
        Me.btnActiveBe.Name = "btnActiveBe"
        Me.btnActiveBe.UseVisualStyleBackColor = True
        '
        'MaskSerialKey
        '
        resources.ApplyResources(Me.MaskSerialKey, "MaskSerialKey")
        Me.MaskSerialKey.Name = "MaskSerialKey"
        '
        'btnReqActiveCreate
        '
        resources.ApplyResources(Me.btnReqActiveCreate, "btnReqActiveCreate")
        Me.btnReqActiveCreate.Name = "btnReqActiveCreate"
        Me.btnReqActiveCreate.UseVisualStyleBackColor = True
        '
        'txtUserNM
        '
        resources.ApplyResources(Me.txtUserNM, "txtUserNM")
        Me.txtUserNM.Name = "txtUserNM"
        '
        'txtPhoneNO
        '
        resources.ApplyResources(Me.txtPhoneNO, "txtPhoneNO")
        Me.txtPhoneNO.Name = "txtPhoneNO"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'txtCompanyNM
        '
        resources.ApplyResources(Me.txtCompanyNM, "txtCompanyNM")
        Me.txtCompanyNM.Name = "txtCompanyNM"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'txtEmail
        '
        resources.ApplyResources(Me.txtEmail, "txtEmail")
        Me.txtEmail.Name = "txtEmail"
        '
        'frmLicense
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gubSerialKey)
        Me.Controls.Add(Me.gubActive)
        Me.Name = "frmLicense"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gubActive.ResumeLayout(False)
        Me.gubActive.PerformLayout()
        Me.gubSerialKey.ResumeLayout(False)
        Me.gubSerialKey.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LicenseNote As System.Windows.Forms.Label
    Friend WithEvents gubActive As System.Windows.Forms.GroupBox
    Friend WithEvents txtActiveCD As System.Windows.Forms.TextBox
    Friend WithEvents btnProductActive As System.Windows.Forms.Button
    Friend WithEvents gubSerialKey As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnActiveBe As System.Windows.Forms.Button
    Friend WithEvents MaskSerialKey As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnReqActiveCreate As System.Windows.Forms.Button
    Friend WithEvents txtUserNM As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCompanyNM As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
End Class
