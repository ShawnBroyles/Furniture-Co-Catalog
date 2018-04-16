'''-------------------------------------------------------------------------------------------------
''' <summary>   The Checkout form. </summary>
'''
''' <remarks>   This form allows a user to purchase items in the shopping cart. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmCheckout

    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.CHECKOUT
    ''' <summary>   The full price for everything in the shopping cart. </summary>
    Dim _FullPrice As Decimal = gcdecZero
    ''' <summary>   The number of items in the shopping cart. </summary>
    Dim _FullItemCount As Integer = gcintZero

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Welcome ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Welcome form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuWelcome_Click(sender As Object, e As EventArgs) Handles mnuWelcome.Click
        Navigate(Forms.WELCOME, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Registration ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Registration form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuRegistration_Click(sender As Object, e As EventArgs) Handles mnuRegistration.Click
        Navigate(Forms.REGISTRATION, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Login ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Login form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuLogin_Click(sender As Object, e As EventArgs) Handles mnuLogin.Click
        Navigate(Forms.LOGIN, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Catalog ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Catalog form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuCatalog_Click(sender As Object, e As EventArgs) Handles mnuCatalog.Click
        Navigate(Forms.CATALOG, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Checkout ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Checkout form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuCheckout_Click(sender As Object, e As EventArgs) Handles mnuCheckout.Click
        Navigate(Forms.CHECKOUT, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Account ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Account form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuAccount_Click(sender As Object, e As EventArgs) Handles mnuAccount.Click
        Navigate(Forms.ACCOUNT, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Item ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Item form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuItem_Click(sender As Object, e As EventArgs) Handles mnuItem.Click
        Navigate(Forms.ITEM, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Payment ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for navigating the user to the Payment form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuPayment_Click(sender As Object, e As EventArgs) Handles mnuPayment.Click
        Navigate(Forms.PAYMENT, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Reload ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for reloading the current form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuReload_Click(sender As Object, e As EventArgs) Handles mnuReload.Click
        ReloadForm(Me)
        ResetForm()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The SignOut ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for signing out of an account. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuSignOut_Click(sender As Object, e As EventArgs) Handles mnuSignOut.Click
        SignOut()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Exit ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for terminating the application. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ExitApplication()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The About ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for creating a popup that tells the user some information about the current form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        AboutApplication(_cintForm)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Print ToolStripMenuItem on the MenuStrip. </summary>
    '''
    ''' <remarks>   This button is used for creating a print preview of the current form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        PrintForm(pfPrintForm)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The frmCheckout_Load subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for loading the defaults of the current form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ResetForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for resetting the data on the form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub ResetForm()
        GetShoppingCart()
        Dim strFullPrice As String = "Price of all shopping cart items combined: {0}"
        lblFullPriceOutput.Text = String.Format(strFullPrice, _FullPrice.ToString("C2"))
        If (gusrCurrentUser.Money >= _FullPrice) Then
            btnPaymentOptions.Enabled = False
        Else
            btnPaymentOptions.Enabled = True
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetShoppingCart subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for updating the shopping cart. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub GetShoppingCart()
        lstShoppingCart.Items.Clear()
        glstShoppingCartResults.Clear()
        _FullPrice = gcintZero
        Dim itmItem As Item
        Dim strName As String
        Dim intQuantity As Integer
        Dim decPrice As Decimal
        Dim decFee As Decimal
        Dim decTotalPrice As Decimal
        Dim strListItem As String
        glstShoppingCart.ForEach(Sub(sciItem)
                                     If (sciItem.Quantity > gcintZero) Then
                                         GetProduct(sciItem.ID)
                                         itmItem = gitmCurrentItem
                                         strName = itmItem.Name
                                         intQuantity = sciItem.Quantity
                                         decPrice = itmItem.Price
                                         decFee = itmItem.Fee
                                         decTotalPrice = intQuantity * (decPrice + decFee)
                                         _FullPrice += decTotalPrice
                                         _FullItemCount += sciItem.Quantity
                                         strListItem = strName & " = " & decTotalPrice.ToString("C2") & " (" & intQuantity.ToString() & " * (" & decPrice.ToString("C2") & " + " & decFee.ToString("C2") & "))"
                                         lstShoppingCart.Items.Add(strListItem)
                                         glstShoppingCartResults.Add(itmItem)
                                     End If
                                 End Sub)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Remove One button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for removing one of the selected item from the shopping cart. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnRemoveOne_Click(sender As Object, e As EventArgs) Handles btnRemoveOne.Click
        If (MessageBox.Show("Are you sure you want to remove one of the selected item?", "Remove One?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes) And
            lstShoppingCart.SelectedItems.Count > gcintZero) Then
            GetSelectedItem(lstShoppingCart, glstShoppingCartResults)
            GetProduct(gitmCurrentItem.ID)
            If (Not gitmCurrentItem.GetShoppingCartItem().Quantity.Equals(gcintZero)) Then
                gitmCurrentItem.GetShoppingCartItem().Quantity -= 1
                ResetForm()
            End If
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Remove All button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for removing all of the selected item from the shopping cart. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnRemoveAll_Click(sender As Object, e As EventArgs) Handles btnRemoveAll.Click
        If (lstShoppingCart.SelectedItems.Count > gcintZero AndAlso
        MessageBox.Show("Are you sure you want to remove all of the selected item?", "Remove All?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then
            GetSelectedItem(lstShoppingCart, glstShoppingCartResults)
            GetProduct(gitmCurrentItem.ID)
            gitmCurrentItem.GetShoppingCartItem().Quantity = gcintZero
            ResetForm()
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Make Purchase button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for making a purchase. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnMakePurchase_Click(sender As Object, e As EventArgs) Handles btnMakePurchase.Click
        If (gusrCurrentUser.SignedIn.Equals(False) Or gusrCurrentUser.ID.Equals(gcintZero)) Then
            MsgBox("Unable to make purchase." & vbCrLf & "You are not signed in.", , "Error")
        ElseIf (_FullItemCount.Equals(gcintZero)) Then
            MsgBox("You have zero items in your shopping cart.", , "Error")
        ElseIf (gusrCurrentUser.Money < _FullPrice) Then
            MsgBox("Unable to make purchase." & vbCrLf & "You have " & gusrCurrentUser.Money.ToString("C2") & " and the total is " & _FullPrice.ToString("C2") & ".", , "Error")
            btnPaymentOptions.Enabled = True
        ElseIf (MessageBox.Show("Are you sure you want to make this purchase? (Total: " & _FullPrice.ToString("C2") & ")" & vbCrLf & "Your current balance is " & gusrCurrentUser.Money.ToString("C2") & "." & vbCrLf & "Your balance after the transaction will be " & (gusrCurrentUser.Money - _FullPrice).ToString("C2") & ".", "Make Purchase?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then
            Try
                ' Making the payment
                SQLCreatePayment(gusrCurrentUser.ID, _FullItemCount, _FullPrice)
                SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, "ACC_MONEY", (gusrCurrentUser.Money - _FullPrice).ToString())
                Dim itmItem As Item
                Dim strName As String
                Dim intQuantity As Integer
                Dim decPrice As Decimal
                Dim decFee As Decimal
                glstShoppingCart.ForEach(Sub(sciItem)
                                             If (sciItem.Quantity > gcintZero) Then
                                                 GetProduct(sciItem.ID)
                                                 itmItem = gitmCurrentItem
                                                 strName = itmItem.Name
                                                 intQuantity = sciItem.Quantity
                                                 decPrice = itmItem.Price
                                                 decFee = itmItem.Fee
                                                 SQLSetFieldInfo(DatabaseTables.PRODUCT, itmItem.ID, "PROD_STOCK", (itmItem.Stock - sciItem.Quantity).ToString())
                                                 itmItem.GetShoppingCartItem().Quantity = gcintZero
                                                 itmItem.Update()
                                             End If
                                         End Sub)
                gusrCurrentUser.SignIn(gusrCurrentUser.ID)
                ResetForm()
                MsgBox("Purchase successfully made." & vbCrLf & "Your balance is now " & gusrCurrentUser.Money.ToString("C2") & ".", , "Success")
            Catch ex As Exception
                MsgBox("Failed to create payment.", , "Error")
                Console.WriteLine("Unknown error occurred while trying to make a payment.")
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Payment Options button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for navigating the user to the Payment form so that he/she can add money to his/her account. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnPaymentOptions_Click(sender As Object, e As EventArgs) Handles btnPaymentOptions.Click
        Navigate(Forms.PAYMENT, Me)
    End Sub
End Class