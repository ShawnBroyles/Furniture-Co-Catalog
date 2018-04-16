'''-------------------------------------------------------------------------------------------------
''' <summary>   The Catalog form. </summary>
'''
''' <remarks>   This form is used for browsing the catalog. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmCatalog

    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.CATALOG

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
    ''' <remarks>   This button is used for reloading the currently displayed form. </remarks>
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
    ''' <remarks>   This button is used for signing the user out of his/her account. </remarks>
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
    ''' <remarks>   This button is used for telling the user information about the currently displayed form. </remarks>
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
    ''' <remarks>   This button is used for creating a print preview popup of the current form. </remarks>
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
    ''' <summary>   The frmCatalog_Load subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for loading the defaults of this form when it is loaded. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ResetForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine resets all of the data on the form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub ResetForm()
        txtSearchQuery.Clear()
        rbCategoryAll.Select()
        GetResults()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetResults subroutine. </summary>
    '''
    ''' <remarks>   This subroutines retrieves and displays information about items in the catalog. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub GetResults()
        lstProducts.Items.Clear()
        glstProductResults.Clear()
        glstProducts.ForEach(Sub(itmItem)
                                 If (GetSelectedCategory().Equals(ProductCategory.ALL) Or
                                  GetSelectedCategory().Equals(GetProductCategory(itmItem))) Then
                                     If (cbShowItemsOutOfStock.Checked Or Not CheckOutOfStock(itmItem)) Then
                                         If (GetMatch(itmItem, txtSearchQuery.Text)) Then
                                             lstProducts.Items.Add(itmItem.Name & " - " & itmItem.Price.ToString("C2"))
                                             glstProductResults.Add(itmItem)
                                         End If
                                     End If
                                 End If
                             End Sub)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetSelectedCategory subroutine. </summary>
    '''
    ''' <remarks>   This subroutine get the category of an item. </remarks>
    '''
    ''' <returns>   The category of an item as an integer. </returns>
    '''-------------------------------------------------------------------------------------------------

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

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Search button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine retrieves and displays the results of a search. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        GetResults()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The More details button. </summary>
    '''
    ''' <remarks>   This button navigates the user to a form that displays details about the selected item in the catalog. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnMoreDetails_Click(sender As Object, e As EventArgs) Handles btnMoreDetails.Click
        GetSelectedItem(lstProducts, glstProductResults)
        Navigate(Forms.ITEM, Me)
    End Sub
End Class