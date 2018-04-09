<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckout
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckout))
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
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpShoppingCart = New System.Windows.Forms.GroupBox()
        Me.lstShoppingCart = New System.Windows.Forms.ListBox()
        Me.lblCalculation = New System.Windows.Forms.Label()
        Me.lblFullPriceOutput = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnRemoveOne = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnMakePurchase = New System.Windows.Forms.Button()
        Me.btnPaymentOptions = New System.Windows.Forms.Button()
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpShoppingCart.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNavigate, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(485, 24)
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
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(177, 80)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(131, 20)
        Me.lblSubTitle.TabIndex = 7
        Me.lblSubTitle.Text = "Make a purchase"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(191, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(103, 25)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "Checkout"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpShoppingCart
        '
        Me.grpShoppingCart.Controls.Add(Me.btnPaymentOptions)
        Me.grpShoppingCart.Controls.Add(Me.btnMakePurchase)
        Me.grpShoppingCart.Controls.Add(Me.btnRemoveAll)
        Me.grpShoppingCart.Controls.Add(Me.btnRemoveOne)
        Me.grpShoppingCart.Controls.Add(Me.btnRefresh)
        Me.grpShoppingCart.Controls.Add(Me.lblFullPriceOutput)
        Me.grpShoppingCart.Controls.Add(Me.lblCalculation)
        Me.grpShoppingCart.Controls.Add(Me.lstShoppingCart)
        Me.grpShoppingCart.Location = New System.Drawing.Point(26, 114)
        Me.grpShoppingCart.Name = "grpShoppingCart"
        Me.grpShoppingCart.Size = New System.Drawing.Size(433, 345)
        Me.grpShoppingCart.TabIndex = 9
        Me.grpShoppingCart.TabStop = False
        Me.grpShoppingCart.Text = "Shopping Cart"
        '
        'lstShoppingCart
        '
        Me.lstShoppingCart.FormattingEnabled = True
        Me.lstShoppingCart.Location = New System.Drawing.Point(36, 52)
        Me.lstShoppingCart.Name = "lstShoppingCart"
        Me.lstShoppingCart.Size = New System.Drawing.Size(361, 147)
        Me.lstShoppingCart.TabIndex = 0
        '
        'lblCalculation
        '
        Me.lblCalculation.AutoSize = True
        Me.lblCalculation.Location = New System.Drawing.Point(33, 36)
        Me.lblCalculation.Name = "lblCalculation"
        Me.lblCalculation.Size = New System.Drawing.Size(208, 13)
        Me.lblCalculation.TabIndex = 1
        Me.lblCalculation.Text = "Item = Total Price (Quantity * (Price + Fee))"
        '
        'lblFullPriceOutput
        '
        Me.lblFullPriceOutput.Location = New System.Drawing.Point(68, 268)
        Me.lblFullPriceOutput.Name = "lblFullPriceOutput"
        Me.lblFullPriceOutput.Size = New System.Drawing.Size(297, 13)
        Me.lblFullPriceOutput.TabIndex = 2
        Me.lblFullPriceOutput.Text = "Price of all shopping cart items combined: $?.??"
        Me.lblFullPriceOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(36, 217)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 23)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "&Refresh"
        Me.ToolTip1.SetToolTip(Me.btnRefresh, "Refresh all of the data on the form")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnRemoveOne
        '
        Me.btnRemoveOne.Location = New System.Drawing.Point(168, 217)
        Me.btnRemoveOne.Name = "btnRemoveOne"
        Me.btnRemoveOne.Size = New System.Drawing.Size(97, 23)
        Me.btnRemoveOne.TabIndex = 4
        Me.btnRemoveOne.Text = "Remove &One"
        Me.ToolTip1.SetToolTip(Me.btnRemoveOne, "Remove one item from your shopping cart")
        Me.btnRemoveOne.UseVisualStyleBackColor = True
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(300, 217)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(97, 23)
        Me.btnRemoveAll.TabIndex = 5
        Me.btnRemoveAll.Text = "Remove &All"
        Me.ToolTip1.SetToolTip(Me.btnRemoveAll, "Remove all items of one type from your shopping cart")
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnMakePurchase
        '
        Me.btnMakePurchase.Location = New System.Drawing.Point(110, 299)
        Me.btnMakePurchase.Name = "btnMakePurchase"
        Me.btnMakePurchase.Size = New System.Drawing.Size(97, 23)
        Me.btnMakePurchase.TabIndex = 6
        Me.btnMakePurchase.Text = "&Make Purchase"
        Me.ToolTip1.SetToolTip(Me.btnMakePurchase, "Purchase all of the items in the shopping cart")
        Me.btnMakePurchase.UseVisualStyleBackColor = True
        '
        'btnPaymentOptions
        '
        Me.btnPaymentOptions.Enabled = False
        Me.btnPaymentOptions.Location = New System.Drawing.Point(226, 299)
        Me.btnPaymentOptions.Name = "btnPaymentOptions"
        Me.btnPaymentOptions.Size = New System.Drawing.Size(97, 23)
        Me.btnPaymentOptions.TabIndex = 7
        Me.btnPaymentOptions.Text = "&Payment Options"
        Me.ToolTip1.SetToolTip(Me.btnPaymentOptions, "Navigate to the Payment form")
        Me.btnPaymentOptions.UseVisualStyleBackColor = True
        '
        'frmCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 486)
        Me.Controls.Add(Me.grpShoppingCart)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmCheckout"
        Me.Text = "Checkout"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpShoppingCart.ResumeLayout(False)
        Me.grpShoppingCart.PerformLayout()
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
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpShoppingCart As GroupBox
    Friend WithEvents lblCalculation As Label
    Friend WithEvents lstShoppingCart As ListBox
    Friend WithEvents lblFullPriceOutput As Label
    Friend WithEvents btnMakePurchase As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnRemoveOne As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnPaymentOptions As Button
End Class
