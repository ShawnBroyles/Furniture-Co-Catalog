' Developed by Shawn Broyles
' The Checkout form displays a list of items in the user's shopping
' cart. There are options for removing items and making purchases.

Public Class frmCheckout

    Const _cintForm As Integer = Forms.CHECKOUT
    Dim _FullPrice As Decimal = _cdecZero
    Dim _FullItemCount As Integer = _cintZero

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
        ResetForm()
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

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    Private Sub ResetForm()
        GetShoppingCart()
        Dim strFullPrice As String = "Price of all shopping cart items combined: {0}"
        lblFullPriceOutput.Text = String.Format(strFullPrice, _FullPrice.ToString("C2"))
        If (_CurrentUser.Money >= _FullPrice) Then
            btnPaymentOptions.Enabled = False
        Else
            btnPaymentOptions.Enabled = True
        End If
    End Sub

    Private Sub GetShoppingCart()
        lstShoppingCart.Items.Clear()
        _ShoppingCartResults.Clear()
        _FullPrice = _cintZero
        Dim itmItem As Item
        Dim strName As String
        Dim intQuantity As Integer
        Dim decPrice As Decimal
        Dim decFee As Decimal
        Dim decTotalPrice As Decimal
        Dim strListItem As String
        _ShoppingCart.ForEach(Sub(sciItem)
                                  If (sciItem.Quantity > _cintZero) Then
                                      GetProduct(sciItem.ID)
                                      itmItem = _CurrentItem
                                      strName = itmItem.Name
                                      intQuantity = sciItem.Quantity
                                      decPrice = itmItem.Price
                                      decFee = itmItem.Fee
                                      decTotalPrice = intQuantity * (decPrice + decFee)
                                      _FullPrice += decTotalPrice
                                      _FullItemCount += sciItem.Quantity
                                      strListItem = strName & " = " & decTotalPrice.ToString("C2") & " (" & intQuantity.ToString() & " * (" & decPrice.ToString("C2") & " + " & decFee.ToString("C2") & "))"
                                      lstShoppingCart.Items.Add(strListItem)
                                      _ShoppingCartResults.Add(itmItem)
                                  End If
                              End Sub)
    End Sub

    Private Sub btnRemoveOne_Click(sender As Object, e As EventArgs) Handles btnRemoveOne.Click
        If (MessageBox.Show("Are you sure you want to remove one of the selected item?", "Remove One?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes) And
            lstShoppingCart.SelectedItems.Count > _cintZero) Then
            GetSelectedItem(lstShoppingCart, _ShoppingCartResults)
            GetProduct(_CurrentItem.ID)
            If (Not _CurrentItem.GetShoppingCartItem().Quantity.Equals(_cintZero)) Then
                _CurrentItem.GetShoppingCartItem().Quantity -= 1
                ResetForm()
            End If
        End If
    End Sub

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If (lstShoppingCart.SelectedItems.Count > _cintZero AndAlso
        MessageBox.Show("Are you sure you want to remove all of the selected item?", "Remove All?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then
            GetSelectedItem(lstShoppingCart, _ShoppingCartResults)
            GetProduct(_CurrentItem.ID)
            _CurrentItem.GetShoppingCartItem().Quantity = _cintZero
            ResetForm()
        End If
    End Sub

    Private Sub btnMakePurchase_Click(sender As Object, e As EventArgs) Handles btnMakePurchase.Click
        If (_CurrentUser.SignedIn.Equals(False) Or _CurrentUser.ID.Equals(_cintZero)) Then
            MsgBox("Unable to make purchase." & vbCrLf & "You are not signed in.", , "Error")
        ElseIf (_FullItemCount.Equals(_cintZero)) Then
            MsgBox("You have zero items in your shopping cart.", , "Error")
        ElseIf (_CurrentUser.Money < _FullPrice) Then
            MsgBox("Unable to make purchase." & vbCrLf & "You have " & _CurrentUser.Money.ToString("C2") & " and the total is " & _FullPrice.ToString("C2") & ".", , "Error")
            btnPaymentOptions.Enabled = True
        ElseIf (MessageBox.Show("Are you sure you want to make this purchase? (Total: " & _FullPrice.ToString("C2") & ")" & vbCrLf & "Your current balance is " & _CurrentUser.Money.ToString("C2") & "." & vbCrLf & "Your balance after the transaction will be " & (_CurrentUser.Money - _FullPrice).ToString("C2") & ".", "Make Purchase?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then
            Try
                ' Making the payment
                SQLCreatePayment(_CurrentUser.ID, _FullItemCount, _FullPrice)
                SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, "ACC_MONEY", (_CurrentUser.Money - _FullPrice).ToString())
                Dim itmItem As Item
                Dim strName As String
                Dim intQuantity As Integer
                Dim decPrice As Decimal
                Dim decFee As Decimal
                _ShoppingCart.ForEach(Sub(sciItem)
                                          If (sciItem.Quantity > _cintZero) Then
                                              GetProduct(sciItem.ID)
                                              itmItem = _CurrentItem
                                              strName = itmItem.Name
                                              intQuantity = sciItem.Quantity
                                              decPrice = itmItem.Price
                                              decFee = itmItem.Fee
                                              SQLSetFieldInfo(DatabaseTables.PRODUCT, itmItem.ID, "PROD_STOCK", (itmItem.Stock - sciItem.Quantity).ToString())
                                              itmItem.GetShoppingCartItem().Quantity = _cintZero
                                              itmItem.Update()
                                          End If
                                      End Sub)
                _CurrentUser.SignIn(_CurrentUser.ID)
                ResetForm()
                MsgBox("Purchase successfully made." & vbCrLf & "Your balance is now " & _CurrentUser.Money.ToString("C2") & ".", , "Success")
            Catch ex As Exception
                MsgBox("Failed to create payment.", , "Error")
                Console.WriteLine("Unknown error occurred while trying to make a payment.")
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnPaymentOptions_Click(sender As Object, e As EventArgs) Handles btnPaymentOptions.Click
        Navigate(Forms.PAYMENT, Me)
    End Sub
End Class