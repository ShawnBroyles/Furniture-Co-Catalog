<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccount))
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
        Me.grpAccountInfo = New System.Windows.Forms.GroupBox()
        Me.lblAccountIDOutput = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnChangeInfo = New System.Windows.Forms.Button()
        Me.lblAccountStatusOutput = New System.Windows.Forms.Label()
        Me.lblAccountStatus = New System.Windows.Forms.Label()
        Me.lblCreationDateOutput = New System.Windows.Forms.Label()
        Me.lblCreationDate = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblMoneyOutput = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpAccountInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNavigate, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(446, 24)
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
        'grpAccountInfo
        '
        Me.grpAccountInfo.Controls.Add(Me.lblAccountIDOutput)
        Me.grpAccountInfo.Controls.Add(Me.btnSave)
        Me.grpAccountInfo.Controls.Add(Me.btnReset)
        Me.grpAccountInfo.Controls.Add(Me.btnChangeInfo)
        Me.grpAccountInfo.Controls.Add(Me.lblAccountStatusOutput)
        Me.grpAccountInfo.Controls.Add(Me.lblAccountStatus)
        Me.grpAccountInfo.Controls.Add(Me.lblCreationDateOutput)
        Me.grpAccountInfo.Controls.Add(Me.lblCreationDate)
        Me.grpAccountInfo.Controls.Add(Me.lblMoney)
        Me.grpAccountInfo.Controls.Add(Me.lblAddress)
        Me.grpAccountInfo.Controls.Add(Me.lblPhone)
        Me.grpAccountInfo.Controls.Add(Me.lblEmail)
        Me.grpAccountInfo.Controls.Add(Me.lblLastName)
        Me.grpAccountInfo.Controls.Add(Me.lblFirstName)
        Me.grpAccountInfo.Controls.Add(Me.lblUsername)
        Me.grpAccountInfo.Controls.Add(Me.lblMoneyOutput)
        Me.grpAccountInfo.Controls.Add(Me.txtAddress)
        Me.grpAccountInfo.Controls.Add(Me.txtPhoneNumber)
        Me.grpAccountInfo.Controls.Add(Me.txtEmail)
        Me.grpAccountInfo.Controls.Add(Me.txtLastName)
        Me.grpAccountInfo.Controls.Add(Me.txtFirstName)
        Me.grpAccountInfo.Controls.Add(Me.txtUsername)
        Me.grpAccountInfo.Controls.Add(Me.lblAccountID)
        Me.grpAccountInfo.Location = New System.Drawing.Point(53, 74)
        Me.grpAccountInfo.Name = "grpAccountInfo"
        Me.grpAccountInfo.Size = New System.Drawing.Size(340, 443)
        Me.grpAccountInfo.TabIndex = 3
        Me.grpAccountInfo.TabStop = False
        Me.grpAccountInfo.Text = "Account Info"
        '
        'lblAccountIDOutput
        '
        Me.lblAccountIDOutput.AutoSize = True
        Me.lblAccountIDOutput.Location = New System.Drawing.Point(110, 27)
        Me.lblAccountIDOutput.Name = "lblAccountIDOutput"
        Me.lblAccountIDOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblAccountIDOutput.TabIndex = 27
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(129, 400)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Enabled = False
        Me.btnReset.Location = New System.Drawing.Point(234, 400)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnChangeInfo
        '
        Me.btnChangeInfo.Location = New System.Drawing.Point(24, 400)
        Me.btnChangeInfo.Name = "btnChangeInfo"
        Me.btnChangeInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnChangeInfo.TabIndex = 7
        Me.btnChangeInfo.Text = "Ch&ange Info"
        Me.btnChangeInfo.UseVisualStyleBackColor = True
        '
        'lblAccountStatusOutput
        '
        Me.lblAccountStatusOutput.AutoSize = True
        Me.lblAccountStatusOutput.Location = New System.Drawing.Point(110, 360)
        Me.lblAccountStatusOutput.Name = "lblAccountStatusOutput"
        Me.lblAccountStatusOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblAccountStatusOutput.TabIndex = 23
        '
        'lblAccountStatus
        '
        Me.lblAccountStatus.AutoSize = True
        Me.lblAccountStatus.Location = New System.Drawing.Point(21, 360)
        Me.lblAccountStatus.Name = "lblAccountStatus"
        Me.lblAccountStatus.Size = New System.Drawing.Size(83, 13)
        Me.lblAccountStatus.TabIndex = 22
        Me.lblAccountStatus.Text = "Account Status:"
        '
        'lblCreationDateOutput
        '
        Me.lblCreationDateOutput.AutoSize = True
        Me.lblCreationDateOutput.Location = New System.Drawing.Point(110, 323)
        Me.lblCreationDateOutput.Name = "lblCreationDateOutput"
        Me.lblCreationDateOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblCreationDateOutput.TabIndex = 21
        '
        'lblCreationDate
        '
        Me.lblCreationDate.AutoSize = True
        Me.lblCreationDate.Location = New System.Drawing.Point(21, 323)
        Me.lblCreationDate.Name = "lblCreationDate"
        Me.lblCreationDate.Size = New System.Drawing.Size(75, 13)
        Me.lblCreationDate.TabIndex = 20
        Me.lblCreationDate.Text = "Creation Date:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(21, 286)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(42, 13)
        Me.lblMoney.TabIndex = 19
        Me.lblMoney.Text = "Money:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(21, 249)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 18
        Me.lblAddress.Text = "Address:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(21, 212)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 17
        Me.lblPhone.Text = "Phone:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(21, 175)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "Email:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(21, 138)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 15
        Me.lblLastName.Text = "Last Name:"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(21, 101)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 14
        Me.lblFirstName.Text = "First Name:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(21, 64)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "Username:"
        '
        'lblMoneyOutput
        '
        Me.lblMoneyOutput.AutoSize = True
        Me.lblMoneyOutput.Location = New System.Drawing.Point(110, 286)
        Me.lblMoneyOutput.Name = "lblMoneyOutput"
        Me.lblMoneyOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblMoneyOutput.TabIndex = 11
        '
        'txtAddress
        '
        Me.txtAddress.Enabled = False
        Me.txtAddress.Location = New System.Drawing.Point(113, 246)
        Me.txtAddress.MaxLength = 80
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 20)
        Me.txtAddress.TabIndex = 6
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Enabled = False
        Me.txtPhoneNumber.Location = New System.Drawing.Point(113, 209)
        Me.txtPhoneNumber.MaxLength = 20
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtPhoneNumber.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Enabled = False
        Me.txtEmail.Location = New System.Drawing.Point(113, 172)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(113, 135)
        Me.txtLastName.MaxLength = 20
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(120, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(113, 98)
        Me.txtFirstName.MaxLength = 20
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(120, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(113, 61)
        Me.txtUsername.MaxLength = 16
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtUsername.TabIndex = 1
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Location = New System.Drawing.Point(21, 27)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(64, 13)
        Me.lblAccountID.TabIndex = 3
        Me.lblAccountID.Text = "Account ID:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(178, 37)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(90, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Account"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 542)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpAccountInfo)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmAccount"
        Me.Text = "Account"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpAccountInfo.ResumeLayout(False)
        Me.grpAccountInfo.PerformLayout()
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
    Friend WithEvents grpAccountInfo As GroupBox
    Friend WithEvents lblAccountID As Label
    Friend WithEvents lblCreationDate As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblMoneyOutput As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAccountIDOutput As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnChangeInfo As Button
    Friend WithEvents lblAccountStatusOutput As Label
    Friend WithEvents lblAccountStatus As Label
    Friend WithEvents lblCreationDateOutput As Label
End Class
