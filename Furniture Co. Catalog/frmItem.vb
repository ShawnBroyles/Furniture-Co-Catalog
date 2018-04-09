' Developed by Shawn Broyles
' The Item form displays information about a specific item in the
' catalog with the option to add the item with a specified quantitiy
' to the shopping cart.

Public Class frmItem

    Const _cintForm As Integer = Forms.ITEM

    Private Sub mnuWelcome_Click(sender As Object, e As EventArgs) Handles mnuWelcome.Click
        Navigate(Forms.WELCOME, Me)
    End Sub

    Private Sub mnuRegistration_Click(sender As Object, e As EventArgs) Handles mnuRegistration.Click
        Navigate(Forms.REGISTRATION, Me)
    End Sub

    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        Navigate(Forms.LOGIN, Me)
    End Sub

    Private Sub mnuCatalog_Click(sender As Object, e As EventArgs) Handles mnuCatalog.Click
        Navigate(Forms.CATALOG, Me)
    End Sub

    Private Sub mnuCheckout_Click(sender As Object, e As EventArgs) Handles mnuCheckout.Click
        Navigate(Forms.CHECKOUT, Me)
    End Sub

    Private Sub mnuAccount_Click(sender As Object, e As EventArgs) Handles mnuAccount.Click
        Navigate(Forms.ACCOUNT, Me)
    End Sub

    Private Sub mnuItem_Click(sender As Object, e As EventArgs) Handles mnuItem.Click
        Navigate(Forms.ITEM, Me)
    End Sub

    Private Sub mnuPayment_Click(sender As Object, e As EventArgs) Handles mnuPayment.Click
        Navigate(Forms.PAYMENT, Me)
    End Sub

    Private Sub mnuReload_Click(sender As Object, e As EventArgs) Handles mnuReload.Click
        ReloadForm(Me)
    End Sub

    Private Sub mnuSignOut_Click(sender As Object, e As EventArgs) Handles mnuSignOut.Click
        SignOut()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ExitApplication()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        AboutApplication(_cintForm)
    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        PrintForm(pfPrintForm)
    End Sub

    Private Sub frmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    Private Sub ResetForm()
        updAmountInCart.Maximum = _CurrentItem.Stock
        updAmountInCart.Value = _CurrentItem.GetShoppingCartItem().Quantity
        lblProductIDOutput.Text = _CurrentItem.ID.ToString()
        lblNameOutput.Text = _CurrentItem.Name
        lblPriceOutput.Text = _CurrentItem.Price.ToString("C2")
        lblStockOutput.Text = _CurrentItem.Stock.ToString()
        lblFeeOutput.Text = _CurrentItem.Fee.ToString("C2")
        lblCategoryOutput.Text = _CurrentItem.Category
        lblDescriptionOutput.Text = _CurrentItem.Description

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ResetForm()
    End Sub

    Private Sub updAmountInCart_ValueChanged(sender As Object, e As EventArgs) Handles updAmountInCart.ValueChanged
        _CurrentItem.GetShoppingCartItem().Quantity = updAmountInCart.Value
    End Sub
End Class