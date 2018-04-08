<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.mnuMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuNavigate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWelcome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegistration = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCatalog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccount = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReload = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSignOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.pfPrintForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.grpLogin = New System.Windows.Forms.GroupBox()
        Me.rbEmail = New System.Windows.Forms.RadioButton()
        Me.lblLoginType = New System.Windows.Forms.Label()
        Me.rbUsername = New System.Windows.Forms.RadioButton()
        Me.rbAccountID = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNavigate, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(439, 24)
        Me.mnuMenuStrip.TabIndex = 1
        Me.mnuMenuStrip.Text = "MenuStrip1"
        '
        'mnuNavigate
        '
        Me.mnuNavigate.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWelcome, Me.mnuRegistration, Me.mnuLogin, Me.mnuCatalog, Me.mnuCheckout, Me.mnuAccount, Me.mnuItem, Me.mnuPayment})
        Me.mnuNavigate.Name = "mnuNavigate"
        Me.mnuNavigate.Size = New System.Drawing.Size(66, 20)
        Me.mnuNavigate.Text = "&Navigate"
        '
        'mnuWelcome
        '
        Me.mnuWelcome.Name = "mnuWelcome"
        Me.mnuWelcome.Size = New System.Drawing.Size(137, 22)
        Me.mnuWelcome.Text = "&Welcome"
        '
        'mnuRegistration
        '
        Me.mnuRegistration.Name = "mnuRegistration"
        Me.mnuRegistration.Size = New System.Drawing.Size(137, 22)
        Me.mnuRegistration.Text = "&Registration"
        '
        'mnuLogin
        '
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(137, 22)
        Me.mnuLogin.Text = "&Login"
        '
        'mnuCatalog
        '
        Me.mnuCatalog.Name = "mnuCatalog"
        Me.mnuCatalog.Size = New System.Drawing.Size(137, 22)
        Me.mnuCatalog.Text = "&Catalog"
        '
        'mnuCheckout
        '
        Me.mnuCheckout.Name = "mnuCheckout"
        Me.mnuCheckout.Size = New System.Drawing.Size(137, 22)
        Me.mnuCheckout.Text = "Check&out"
        '
        'mnuAccount
        '
        Me.mnuAccount.Name = "mnuAccount"
        Me.mnuAccount.Size = New System.Drawing.Size(137, 22)
        Me.mnuAccount.Text = "&Account"
        '
        'mnuItem
        '
        Me.mnuItem.Name = "mnuItem"
        Me.mnuItem.Size = New System.Drawing.Size(137, 22)
        Me.mnuItem.Text = "&Item"
        '
        'mnuPayment
        '
        Me.mnuPayment.Name = "mnuPayment"
        Me.mnuPayment.Size = New System.Drawing.Size(137, 22)
        Me.mnuPayment.Text = "&Payment"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReload, Me.mnuSignOut, Me.mnuExit})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuReload
        '
        Me.mnuReload.Name = "mnuReload"
        Me.mnuReload.Size = New System.Drawing.Size(141, 22)
        Me.mnuReload.Text = "&Reload Form"
        '
        'mnuSignOut
        '
        Me.mnuSignOut.Name = "mnuSignOut"
        Me.mnuSignOut.Size = New System.Drawing.Size(141, 22)
        Me.mnuSignOut.Text = "&Sign Out"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(141, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout, Me.mnuPrint})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "&About"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(107, 22)
        Me.mnuPrint.Text = "&Print"
        '
        'pfPrintForm
        '
        Me.pfPrintForm.DocumentName = "Furniture Co. Catalog"
        Me.pfPrintForm.Form = Me
        Me.pfPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.pfPrintForm.PrinterSettings = CType(resources.GetObject("pfPrintForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.pfPrintForm.PrintFileName = "Furniture Co. Catalog"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(187, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(65, 25)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Login"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(36, 79)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(367, 20)
        Me.lblSubTitle.TabIndex = 4
        Me.lblSubTitle.Text = "Use the form below to sign into an existing account"
        '
        'grpLogin
        '
        Me.grpLogin.Controls.Add(Me.rbEmail)
        Me.grpLogin.Controls.Add(Me.lblLoginType)
        Me.grpLogin.Controls.Add(Me.rbUsername)
        Me.grpLogin.Controls.Add(Me.rbAccountID)
        Me.grpLogin.Controls.Add(Me.btnClear)
        Me.grpLogin.Controls.Add(Me.btnSubmit)
        Me.grpLogin.Controls.Add(Me.txtPassword)
        Me.grpLogin.Controls.Add(Me.txtUsername)
        Me.grpLogin.Controls.Add(Me.lblPassword)
        Me.grpLogin.Controls.Add(Me.lblUsername)
        Me.grpLogin.Location = New System.Drawing.Point(40, 117)
        Me.grpLogin.Name = "grpLogin"
        Me.grpLogin.Size = New System.Drawing.Size(363, 222)
        Me.grpLogin.TabIndex = 5
        Me.grpLogin.TabStop = False
        Me.grpLogin.Text = "Login"
        '
        'rbEmail
        '
        Me.rbEmail.AutoSize = True
        Me.rbEmail.Location = New System.Drawing.Point(128, 122)
        Me.rbEmail.Name = "rbEmail"
        Me.rbEmail.Size = New System.Drawing.Size(50, 17)
        Me.rbEmail.TabIndex = 4
        Me.rbEmail.Text = "Email"
        Me.rbEmail.UseVisualStyleBackColor = True
        '
        'lblLoginType
        '
        Me.lblLoginType.AutoSize = True
        Me.lblLoginType.Location = New System.Drawing.Point(34, 101)
        Me.lblLoginType.Name = "lblLoginType"
        Me.lblLoginType.Size = New System.Drawing.Size(63, 13)
        Me.lblLoginType.TabIndex = 8
        Me.lblLoginType.Text = "Login Type:"
        '
        'rbUsername
        '
        Me.rbUsername.AutoSize = True
        Me.rbUsername.Checked = True
        Me.rbUsername.Location = New System.Drawing.Point(128, 99)
        Me.rbUsername.Name = "rbUsername"
        Me.rbUsername.Size = New System.Drawing.Size(73, 17)
        Me.rbUsername.TabIndex = 3
        Me.rbUsername.TabStop = True
        Me.rbUsername.Text = "Username"
        Me.rbUsername.UseVisualStyleBackColor = True
        '
        'rbAccountID
        '
        Me.rbAccountID.AutoSize = True
        Me.rbAccountID.Location = New System.Drawing.Point(128, 145)
        Me.rbAccountID.Name = "rbAccountID"
        Me.rbAccountID.Size = New System.Drawing.Size(79, 17)
        Me.rbAccountID.TabIndex = 5
        Me.rbAccountID.Text = "Account ID"
        Me.rbAccountID.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(197, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(90, 177)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(128, 64)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(128, 29)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(34, 67)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(34, 32)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(88, 13)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Username/Email:"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 359)
        Me.Controls.Add(Me.grpLogin)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpLogin.ResumeLayout(False)
        Me.grpLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenuStrip As MenuStrip
    Friend WithEvents mnuNavigate As ToolStripMenuItem
    Friend WithEvents mnuWelcome As ToolStripMenuItem
    Friend WithEvents mnuRegistration As ToolStripMenuItem
    Friend WithEvents mnuLogin As ToolStripMenuItem
    Friend WithEvents mnuCatalog As ToolStripMenuItem
    Friend WithEvents mnuCheckout As ToolStripMenuItem
    Friend WithEvents mnuAccount As ToolStripMenuItem
    Friend WithEvents mnuItem As ToolStripMenuItem
    Friend WithEvents mnuPayment As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuReload As ToolStripMenuItem
    Friend WithEvents mnuSignOut As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents pfPrintForm As PowerPacks.Printing.PrintForm
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpLogin As GroupBox
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents rbAccountID As RadioButton
    Friend WithEvents rbEmail As RadioButton
    Friend WithEvents rbUsername As RadioButton
    Friend WithEvents lblLoginType As Label
End Class
