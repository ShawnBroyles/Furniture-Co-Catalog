<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalog))
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
        Me.grpCatalog = New System.Windows.Forms.GroupBox()
        Me.lblOther = New System.Windows.Forms.Label()
        Me.cbShowItemsOutOfStock = New System.Windows.Forms.CheckBox()
        Me.grpSearchResults = New System.Windows.Forms.GroupBox()
        Me.btnMoreDetails = New System.Windows.Forms.Button()
        Me.lblMatchingProducts = New System.Windows.Forms.Label()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.rbCategoryChair = New System.Windows.Forms.RadioButton()
        Me.rbCategoryCarpet = New System.Windows.Forms.RadioButton()
        Me.rbCategoryCouch = New System.Windows.Forms.RadioButton()
        Me.rbCategoryDesk = New System.Windows.Forms.RadioButton()
        Me.rbCategoryTable = New System.Windows.Forms.RadioButton()
        Me.rbCategoryAll = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchQuery = New System.Windows.Forms.TextBox()
        Me.lblSearchQuery = New System.Windows.Forms.Label()
        Me.mnuMenuStrip.SuspendLayout()
        Me.grpCatalog.SuspendLayout()
        Me.grpSearchResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuStrip
        '
        Me.mnuMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNavigate, Me.mnuEdit, Me.mnuHelp})
        Me.mnuMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuStrip.Name = "mnuMenuStrip"
        Me.mnuMenuStrip.Size = New System.Drawing.Size(623, 24)
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
        Me.lblTitle.Location = New System.Drawing.Point(268, 47)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(86, 25)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Catalog"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTitle.Location = New System.Drawing.Point(76, 87)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(471, 20)
        Me.lblSubTitle.TabIndex = 5
        Me.lblSubTitle.Text = "Do a search then click on an item to see more information about it"
        '
        'grpCatalog
        '
        Me.grpCatalog.Controls.Add(Me.lblOther)
        Me.grpCatalog.Controls.Add(Me.cbShowItemsOutOfStock)
        Me.grpCatalog.Controls.Add(Me.grpSearchResults)
        Me.grpCatalog.Controls.Add(Me.rbCategoryChair)
        Me.grpCatalog.Controls.Add(Me.rbCategoryCarpet)
        Me.grpCatalog.Controls.Add(Me.rbCategoryCouch)
        Me.grpCatalog.Controls.Add(Me.rbCategoryDesk)
        Me.grpCatalog.Controls.Add(Me.rbCategoryTable)
        Me.grpCatalog.Controls.Add(Me.rbCategoryAll)
        Me.grpCatalog.Controls.Add(Me.Label1)
        Me.grpCatalog.Controls.Add(Me.btnSearch)
        Me.grpCatalog.Controls.Add(Me.txtSearchQuery)
        Me.grpCatalog.Controls.Add(Me.lblSearchQuery)
        Me.grpCatalog.Location = New System.Drawing.Point(45, 126)
        Me.grpCatalog.Name = "grpCatalog"
        Me.grpCatalog.Size = New System.Drawing.Size(532, 397)
        Me.grpCatalog.TabIndex = 6
        Me.grpCatalog.TabStop = False
        Me.grpCatalog.Text = "Browsing the Catalog"
        '
        'lblOther
        '
        Me.lblOther.AutoSize = True
        Me.lblOther.Location = New System.Drawing.Point(34, 91)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.Size = New System.Drawing.Size(36, 13)
        Me.lblOther.TabIndex = 13
        Me.lblOther.Text = "Other:"
        '
        'cbShowItemsOutOfStock
        '
        Me.cbShowItemsOutOfStock.AutoSize = True
        Me.cbShowItemsOutOfStock.Checked = True
        Me.cbShowItemsOutOfStock.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbShowItemsOutOfStock.Location = New System.Drawing.Point(115, 90)
        Me.cbShowItemsOutOfStock.Name = "cbShowItemsOutOfStock"
        Me.cbShowItemsOutOfStock.Size = New System.Drawing.Size(139, 17)
        Me.cbShowItemsOutOfStock.TabIndex = 12
        Me.cbShowItemsOutOfStock.Text = "Show &items out of stock"
        Me.cbShowItemsOutOfStock.UseVisualStyleBackColor = True
        '
        'grpSearchResults
        '
        Me.grpSearchResults.Controls.Add(Me.btnMoreDetails)
        Me.grpSearchResults.Controls.Add(Me.lblMatchingProducts)
        Me.grpSearchResults.Controls.Add(Me.lstProducts)
        Me.grpSearchResults.Location = New System.Drawing.Point(119, 126)
        Me.grpSearchResults.Name = "grpSearchResults"
        Me.grpSearchResults.Size = New System.Drawing.Size(295, 250)
        Me.grpSearchResults.TabIndex = 10
        Me.grpSearchResults.TabStop = False
        Me.grpSearchResults.Text = "Search Results"
        '
        'btnMoreDetails
        '
        Me.btnMoreDetails.Location = New System.Drawing.Point(110, 209)
        Me.btnMoreDetails.Name = "btnMoreDetails"
        Me.btnMoreDetails.Size = New System.Drawing.Size(75, 23)
        Me.btnMoreDetails.TabIndex = 11
        Me.btnMoreDetails.Text = "&More Details"
        Me.btnMoreDetails.UseVisualStyleBackColor = True
        '
        'lblMatchingProducts
        '
        Me.lblMatchingProducts.AutoSize = True
        Me.lblMatchingProducts.Location = New System.Drawing.Point(55, 27)
        Me.lblMatchingProducts.Name = "lblMatchingProducts"
        Me.lblMatchingProducts.Size = New System.Drawing.Size(96, 13)
        Me.lblMatchingProducts.TabIndex = 10
        Me.lblMatchingProducts.Text = "Matching Products"
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(58, 43)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(182, 160)
        Me.lstProducts.TabIndex = 9
        '
        'rbCategoryChair
        '
        Me.rbCategoryChair.AutoSize = True
        Me.rbCategoryChair.Location = New System.Drawing.Point(168, 58)
        Me.rbCategoryChair.Name = "rbCategoryChair"
        Me.rbCategoryChair.Size = New System.Drawing.Size(49, 17)
        Me.rbCategoryChair.TabIndex = 4
        Me.rbCategoryChair.Text = "&Chair"
        Me.rbCategoryChair.UseVisualStyleBackColor = True
        '
        'rbCategoryCarpet
        '
        Me.rbCategoryCarpet.AutoSize = True
        Me.rbCategoryCarpet.Location = New System.Drawing.Point(443, 58)
        Me.rbCategoryCarpet.Name = "rbCategoryCarpet"
        Me.rbCategoryCarpet.Size = New System.Drawing.Size(56, 17)
        Me.rbCategoryCarpet.TabIndex = 8
        Me.rbCategoryCarpet.Text = "Ca&rpet"
        Me.rbCategoryCarpet.UseVisualStyleBackColor = True
        '
        'rbCategoryCouch
        '
        Me.rbCategoryCouch.AutoSize = True
        Me.rbCategoryCouch.Location = New System.Drawing.Point(370, 58)
        Me.rbCategoryCouch.Name = "rbCategoryCouch"
        Me.rbCategoryCouch.Size = New System.Drawing.Size(56, 17)
        Me.rbCategoryCouch.TabIndex = 7
        Me.rbCategoryCouch.Text = "C&ouch"
        Me.rbCategoryCouch.UseVisualStyleBackColor = True
        '
        'rbCategoryDesk
        '
        Me.rbCategoryDesk.AutoSize = True
        Me.rbCategoryDesk.Location = New System.Drawing.Point(303, 58)
        Me.rbCategoryDesk.Name = "rbCategoryDesk"
        Me.rbCategoryDesk.Size = New System.Drawing.Size(50, 17)
        Me.rbCategoryDesk.TabIndex = 6
        Me.rbCategoryDesk.Text = "&Desk"
        Me.rbCategoryDesk.UseVisualStyleBackColor = True
        '
        'rbCategoryTable
        '
        Me.rbCategoryTable.AutoSize = True
        Me.rbCategoryTable.Location = New System.Drawing.Point(234, 58)
        Me.rbCategoryTable.Name = "rbCategoryTable"
        Me.rbCategoryTable.Size = New System.Drawing.Size(52, 17)
        Me.rbCategoryTable.TabIndex = 5
        Me.rbCategoryTable.Text = "&Table"
        Me.rbCategoryTable.UseVisualStyleBackColor = True
        '
        'rbCategoryAll
        '
        Me.rbCategoryAll.AutoSize = True
        Me.rbCategoryAll.Checked = True
        Me.rbCategoryAll.Location = New System.Drawing.Point(115, 58)
        Me.rbCategoryAll.Name = "rbCategoryAll"
        Me.rbCategoryAll.Size = New System.Drawing.Size(36, 17)
        Me.rbCategoryAll.TabIndex = 3
        Me.rbCategoryAll.TabStop = True
        Me.rbCategoryAll.Text = "&All"
        Me.rbCategoryAll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Category:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(424, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchQuery
        '
        Me.txtSearchQuery.Enabled = False
        Me.txtSearchQuery.Location = New System.Drawing.Point(115, 27)
        Me.txtSearchQuery.MaxLength = 200
        Me.txtSearchQuery.Name = "txtSearchQuery"
        Me.txtSearchQuery.Size = New System.Drawing.Size(300, 20)
        Me.txtSearchQuery.TabIndex = 1
        '
        'lblSearchQuery
        '
        Me.lblSearchQuery.AutoSize = True
        Me.lblSearchQuery.Location = New System.Drawing.Point(34, 30)
        Me.lblSearchQuery.Name = "lblSearchQuery"
        Me.lblSearchQuery.Size = New System.Drawing.Size(75, 13)
        Me.lblSearchQuery.TabIndex = 0
        Me.lblSearchQuery.Text = "Search Query:"
        '
        'frmCatalog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 539)
        Me.Controls.Add(Me.grpCatalog)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuMenuStrip)
        Me.Name = "frmCatalog"
        Me.Text = "Catalog"
        Me.mnuMenuStrip.ResumeLayout(False)
        Me.mnuMenuStrip.PerformLayout()
        Me.grpCatalog.ResumeLayout(False)
        Me.grpCatalog.PerformLayout()
        Me.grpSearchResults.ResumeLayout(False)
        Me.grpSearchResults.PerformLayout()
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
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents grpCatalog As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchQuery As TextBox
    Friend WithEvents lblSearchQuery As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbCategoryAll As RadioButton
    Friend WithEvents rbCategoryChair As RadioButton
    Friend WithEvents rbCategoryCarpet As RadioButton
    Friend WithEvents rbCategoryCouch As RadioButton
    Friend WithEvents rbCategoryDesk As RadioButton
    Friend WithEvents rbCategoryTable As RadioButton
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents grpSearchResults As GroupBox
    Friend WithEvents btnMoreDetails As Button
    Friend WithEvents lblMatchingProducts As Label
    Friend WithEvents cbShowItemsOutOfStock As CheckBox
    Friend WithEvents lblOther As Label
End Class
