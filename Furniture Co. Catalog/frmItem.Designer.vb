<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItem))
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
        Me.grpProductInformation = New System.Windows.Forms.GroupBox()
        Me.lblDescriptionOutput = New System.Windows.Forms.Label()
        Me.lblCategoryOutput = New System.Windows.Forms.Label()
        Me.lblFeeOutput = New System.Windows.Forms.Label()
        Me.lblStockOutput = New System.Windows.Forms.Label()
        Me.lblPriceOutput = New System.Windows.Forms.Label()
        Me.lblNameOutput = New System.Windows.Forms.Label()
        Me.lblProductIDOutput = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.lblAmountInCart = New System.Windows.Forms.Label()
        Me.updAmountInCart = New System.Windows.Forms.NumericUpDown()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpProductInformation.SuspendLayout()
        CType(Me.updAmountInCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNavigate, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(390, 24)
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
        Me.lblSubTitle.Location = New System.Drawing.Point(28, 84)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(335, 40)
        Me.lblSubTitle.TabIndex = 6
        Me.lblSubTitle.Text = "Below is the information for a selected product" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can add the item to your sho" &
    "pping cart"
        Me.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(169, 46)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(52, 25)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Item"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpProductInformation
        '
        Me.grpProductInformation.Controls.Add(Me.lblDescriptionOutput)
        Me.grpProductInformation.Controls.Add(Me.lblCategoryOutput)
        Me.grpProductInformation.Controls.Add(Me.lblFeeOutput)
        Me.grpProductInformation.Controls.Add(Me.lblStockOutput)
        Me.grpProductInformation.Controls.Add(Me.lblPriceOutput)
        Me.grpProductInformation.Controls.Add(Me.lblNameOutput)
        Me.grpProductInformation.Controls.Add(Me.lblProductIDOutput)
        Me.grpProductInformation.Controls.Add(Me.lblDescription)
        Me.grpProductInformation.Controls.Add(Me.lblCategory)
        Me.grpProductInformation.Controls.Add(Me.lblFee)
        Me.grpProductInformation.Controls.Add(Me.lblStock)
        Me.grpProductInformation.Controls.Add(Me.lblPrice)
        Me.grpProductInformation.Controls.Add(Me.lblName)
        Me.grpProductInformation.Controls.Add(Me.lblProductID)
        Me.grpProductInformation.Location = New System.Drawing.Point(63, 139)
        Me.grpProductInformation.Name = "grpProductInformation"
        Me.grpProductInformation.Size = New System.Drawing.Size(275, 248)
        Me.grpProductInformation.TabIndex = 7
        Me.grpProductInformation.TabStop = False
        Me.grpProductInformation.Text = "Product Information"
        '
        'lblDescriptionOutput
        '
        Me.lblDescriptionOutput.AutoSize = True
        Me.lblDescriptionOutput.Location = New System.Drawing.Point(91, 208)
        Me.lblDescriptionOutput.Name = "lblDescriptionOutput"
        Me.lblDescriptionOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblDescriptionOutput.TabIndex = 13
        '
        'lblCategoryOutput
        '
        Me.lblCategoryOutput.AutoSize = True
        Me.lblCategoryOutput.Location = New System.Drawing.Point(91, 178)
        Me.lblCategoryOutput.Name = "lblCategoryOutput"
        Me.lblCategoryOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblCategoryOutput.TabIndex = 12
        '
        'lblFeeOutput
        '
        Me.lblFeeOutput.AutoSize = True
        Me.lblFeeOutput.Location = New System.Drawing.Point(91, 148)
        Me.lblFeeOutput.Name = "lblFeeOutput"
        Me.lblFeeOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblFeeOutput.TabIndex = 11
        '
        'lblStockOutput
        '
        Me.lblStockOutput.AutoSize = True
        Me.lblStockOutput.Location = New System.Drawing.Point(91, 118)
        Me.lblStockOutput.Name = "lblStockOutput"
        Me.lblStockOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblStockOutput.TabIndex = 10
        '
        'lblPriceOutput
        '
        Me.lblPriceOutput.AutoSize = True
        Me.lblPriceOutput.Location = New System.Drawing.Point(91, 88)
        Me.lblPriceOutput.Name = "lblPriceOutput"
        Me.lblPriceOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblPriceOutput.TabIndex = 9
        '
        'lblNameOutput
        '
        Me.lblNameOutput.AutoSize = True
        Me.lblNameOutput.Location = New System.Drawing.Point(91, 58)
        Me.lblNameOutput.Name = "lblNameOutput"
        Me.lblNameOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblNameOutput.TabIndex = 8
        '
        'lblProductIDOutput
        '
        Me.lblProductIDOutput.AutoSize = True
        Me.lblProductIDOutput.Location = New System.Drawing.Point(91, 28)
        Me.lblProductIDOutput.Name = "lblProductIDOutput"
        Me.lblProductIDOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblProductIDOutput.TabIndex = 7
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(22, 208)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(63, 13)
        Me.lblDescription.TabIndex = 6
        Me.lblDescription.Text = "Description:"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.Location = New System.Drawing.Point(22, 178)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(52, 13)
        Me.lblCategory.TabIndex = 5
        Me.lblCategory.Text = "Category:"
        '
        'lblFee
        '
        Me.lblFee.AutoSize = True
        Me.lblFee.Location = New System.Drawing.Point(22, 148)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(28, 13)
        Me.lblFee.TabIndex = 4
        Me.lblFee.Text = "Fee:"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(22, 118)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(38, 13)
        Me.lblStock.TabIndex = 3
        Me.lblStock.Text = "Stock:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(22, 88)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(34, 13)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "Price:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(22, 58)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(22, 28)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(61, 13)
        Me.lblProductID.TabIndex = 0
        Me.lblProductID.Text = "Product ID:"
        '
        'lblAmountInCart
        '
        Me.lblAmountInCart.AutoSize = True
        Me.lblAmountInCart.Location = New System.Drawing.Point(85, 405)
        Me.lblAmountInCart.Name = "lblAmountInCart"
        Me.lblAmountInCart.Size = New System.Drawing.Size(142, 13)
        Me.lblAmountInCart.TabIndex = 14
        Me.lblAmountInCart.Text = "Amount in the shopping cart:"
        '
        'updAmountInCart
        '
        Me.updAmountInCart.Location = New System.Drawing.Point(233, 403)
        Me.updAmountInCart.Name = "updAmountInCart"
        Me.updAmountInCart.Size = New System.Drawing.Size(51, 20)
        Me.updAmountInCart.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(158, 433)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 479)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.updAmountInCart)
        Me.Controls.Add(Me.lblAmountInCart)
        Me.Controls.Add(Me.grpProductInformation)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmItem"
        Me.Text = "Item"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpProductInformation.ResumeLayout(False)
        Me.grpProductInformation.PerformLayout()
        CType(Me.updAmountInCart, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents grpProductInformation As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblFee As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDescriptionOutput As Label
    Friend WithEvents lblCategoryOutput As Label
    Friend WithEvents lblFeeOutput As Label
    Friend WithEvents lblStockOutput As Label
    Friend WithEvents lblPriceOutput As Label
    Friend WithEvents lblNameOutput As Label
    Friend WithEvents lblProductIDOutput As Label
    Friend WithEvents updAmountInCart As NumericUpDown
    Friend WithEvents lblAmountInCart As Label
    Friend WithEvents btnRefresh As Button
End Class
