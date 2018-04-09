' Developed by Shawn Broyles
' The Catalog form is used for browsing the catalog. 

Public Class frmCatalog

    Const _cintForm As Integer = Forms.CATALOG

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

    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    Private Sub ResetForm()
        txtSearchQuery.Clear()
        rbCategoryAll.Select()
        GetResults()
    End Sub

    Private Sub GetResults()
        lstProducts.Items.Clear()
        _ProductResults.Clear()
        _Products.ForEach(Sub(itmItem)
                              If (GetSelectedCategory().Equals(ProductCategory.ALL) Or
                                  GetSelectedCategory().Equals(GetProductCategory(itmItem))) Then
                                  If (cbShowItemsOutOfStock.Checked Or Not CheckOutOfStock(itmItem)) Then
                                      If (GetMatch(itmItem, txtSearchQuery.Text)) Then
                                          lstProducts.Items.Add(itmItem.Name & " - " & itmItem.Price.ToString("C2"))
                                          _ProductResults.Add(itmItem)
                                      End If
                                  End If
                                  End If
                          End Sub)
    End Sub

    Function GetSelectedCategory() As Integer
        Dim intCategory As Integer
        If (rbCategoryChair.Checked) Then
            intCategory = ProductCategory.CHAIR
        ElseIf (rbCategoryTable.Checked) Then
            intCategory = ProductCategory.TABLE
        ElseIf (rbCategoryDesk.Checked) Then
            intCategory = ProductCategory.DESK
        ElseIf (rbCategoryCouch.Checked) Then
            intCategory = ProductCategory.COUCH
        ElseIf (rbCategoryCarpet.Checked) Then
            intCategory = ProductCategory.CARPET
        Else
            intCategory = ProductCategory.ALL
        End If
        Return intCategory
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetResults()
    End Sub

    Private Sub btnMoreDetails_Click(sender As Object, e As EventArgs) Handles btnMoreDetails.Click
        GetSelectedItem(lstProducts, _ProductResults)
        Navigate(Forms.ITEM, Me)
    End Sub
End Class