' Program:  Furniture Co. Catalog
' Version:  1.0
' Author:   Shawn Broyles
' Date:     4/9/2018
' Purpose:  This application provides a user-friendly experience for
'           purchasing items when they are not in stock at a business
'           location.

' The Main module contains public methods that are used by other forms
' in the application.

Module Main
    ' Enumeration for the forms in the application

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   Values that represent the forms in the application. </summary>
    '''
    ''' <remarks>
    ''' The values are used for determining which form the user is currently at and also which form
    ''' the user wants to navigate to.
    ''' </remarks>
    '''-------------------------------------------------------------------------------------------------

    Enum Forms
        ''' <summary>   An enum constant representing the Welcome form. </summary>
        WELCOME
        ''' <summary>   An enum constant representing the Registration form. </summary>
        REGISTRATION
        ''' <summary>   An enum constant representing the Login form. </summary>
        LOGIN
        ''' <summary>   An enum constant representing the Catalog form. </summary>
        CATALOG
        ''' <summary>   An enum constant representing the Checkout form. </summary>
        CHECKOUT
        ''' <summary>   An enum constant representing the Account form. </summary>
        ACCOUNT
        ''' <summary>   An enum constant representing the Item form. </summary>
        ITEM
        ''' <summary>   An enum constant representing the Payment form. </summary>
        PAYMENT
        ''' <summary>   An enum constant representing no form. </summary>
        NULL
    End Enum

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   Values that represent product categories. </summary>
    '''
    ''' <remarks>   The values are used for filtering products listed in the Catalog form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Enum ProductCategory
        ''' <summary>   An enum constant representing All categories. </summary>
        ALL
        ''' <summary>   An enum constant representing the Chair category. </summary>
        CHAIR
        ''' <summary>   An enum constant representing the Table category. </summary>
        TABLE
        ''' <summary>   An enum constant representing the Desk category. </summary>
        DESK
        ''' <summary>   An enum constant representing the Couch category. </summary>
        COUCH
        ''' <summary>   An enum constant representing the Carpet category. </summary>
        CARPET
    End Enum

    ''' <summary>   The global constant integer variable for zero. </summary>
    Public Const gcintZero As Integer = 0
    ''' <summary>   The global constant decimal variable for zero. </summary>
    Public Const gcdecZero As Decimal = 0.00D
    ''' <summary>   The global constant string variable for empty. </summary>
    Public Const gcstrEmpty As String = ""

    ''' <summary>   The currently logged in user. </summary>
    Public _CurrentUser As User = New User()
    ''' <summary>   The List of ShoppingCartItems. </summary>
    Public _ShoppingCart As New List(Of ShoppingCartItem)()
    ''' <summary>   The List of all Items from the database. </summary>
    Public _Products As New List(Of Item)()
    ''' <summary>   The List of Items from the search results on the Category form. </summary>
    Public _ProductResults As New List(Of Item)()
    ''' <summary>   The List of Items in the shopping cart. </summary>
    Public _ShoppingCartResults As New List(Of Item)()
    ''' <summary>   The current Item displayed on the Item form. </summary>
    Public _CurrentItem As New Item()

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The PositionForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for positioning the form on the screen when it is loaded or reset. </remarks>
    '''
    ''' <param name="frmCurrentForm">
    ''' The form that is currently displayed.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub PositionForm(ByVal frmCurrentForm As Form)
        ' Setting the form's size back to its default
        frmCurrentForm.Size = frmCurrentForm.RestoreBounds.Size

        ' Positioning the form 
        Try
            Dim xCoordinate As Double
            Dim yCoordinate As Double
            xCoordinate = Screen.PrimaryScreen.WorkingArea.Width / 2 - frmCurrentForm.Size.Width / 2
            yCoordinate = Screen.PrimaryScreen.WorkingArea.Height / 2 - frmCurrentForm.Size.Height / 1.5
            ' Making sure the entire title bar of the window is shown
            If (yCoordinate < gcintZero) Then
                yCoordinate = gcintZero
            End If
            frmCurrentForm.Location = New Point(Convert.ToInt32(xCoordinate), Convert.ToInt32(yCoordinate))
        Catch ex As Exception
            ' Writing the error to the output
            Console.WriteLine("Position Form Error = " & ex.Message)
        End Try
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Navigate subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for navigating between the forms in the application. </remarks>
    '''
    ''' <param name="intForm">
    ''' The form that the user wants to navigate to.
    ''' </param>
    ''' <param name="frmCurrentForm">
    ''' The currently displayed form.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub Navigate(ByVal intForm As Integer, ByVal frmCurrentForm As Form)
        Dim frmChosenForm As Form
        Dim blnSignedOutRequired As Boolean = False
        Dim blnSignedInRequired As Boolean = False
        Dim blnPasswordRequired As Boolean = False
        Dim blnItemRequired As Boolean = False
        Select Case intForm
            Case Forms.REGISTRATION
                frmChosenForm = frmRegistration
                blnSignedOutRequired = True
            Case Forms.LOGIN
                frmChosenForm = frmLogin
                blnSignedOutRequired = True
            Case Forms.CATALOG
                frmChosenForm = frmCatalog
                blnSignedInRequired = True
            Case Forms.CHECKOUT
                frmChosenForm = frmCheckout
                blnSignedInRequired = True
                blnPasswordRequired = True
            Case Forms.ACCOUNT
                frmChosenForm = frmAccount
                blnSignedInRequired = True
                blnPasswordRequired = True
            Case Forms.ITEM
                frmChosenForm = frmItem
                blnItemRequired = True
                blnSignedInRequired = True
            Case Forms.PAYMENT
                frmChosenForm = frmPayment
                blnSignedInRequired = True
                blnPasswordRequired = True
            Case Else
                frmChosenForm = frmWelcome
        End Select

        Dim strMessage As String = "Unable to navigate to the displayed form."
        Dim cstrTitle As String = "Error"

        ' Navigating
        If (frmCurrentForm.Equals(frmWelcome) And Not frmChosenForm.Equals(frmWelcome)) Then
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired, blnItemRequired) Then
                frmChosenForm.ShowDialog()
            End If
        ElseIf (Not frmCurrentForm.Equals(frmWelcome) And frmChosenForm.Equals(frmWelcome)) Then
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired, blnItemRequired) Then
                frmCurrentForm.Dispose()
            End If
        ElseIf (Not frmChosenForm.Equals(frmCurrentForm)) Then
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired, blnItemRequired) Then
                frmCurrentForm.Dispose()
                frmChosenForm.ShowDialog()
            End If
        Else
            MsgBox(strMessage, , cstrTitle)
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The NavigatePrerequisite function. </summary>
    ''' <remarks>
    ''' This function is used to check if the user is required to sign out, sign in, re-enter a
    ''' password, or choose an Item's details before navigating to a form.
    ''' </remarks>
    ''' <param name="blnSignedOutRequired">
    ''' True if the user has to be signed out.
    ''' </param>
    ''' <param name="blnSignedInRequired">
    ''' True if the user has to be signed in.
    ''' </param>
    ''' <param name="blnPasswordRequired">
    ''' True if the user has to re-enter a password.
    ''' </param>
    ''' <param name="blnItemRequired">
    ''' True if the user has to select an Item for its details to be displayed.
    ''' </param>
    ''' <returns>   True if the user meets the prerequisites, false if not. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function NavigatePrerequisite(ByVal blnSignedOutRequired As Boolean, ByVal blnSignedInRequired As Boolean, ByVal blnPasswordRequired As Boolean, ByVal blnItemRequired As Boolean) As Boolean
        Dim blnNavigate As Boolean = True
        Dim strMessage As String = ""
        Dim cstrTitle As String = "Error"
        If (blnItemRequired AndAlso _CurrentItem.ID.Equals(gcintZero)) Then
            AskForItem()
        End If
        If (Not blnItemRequired Or _CurrentItem.ID.Equals(gcintZero)) Then
            If (blnSignedInRequired And _CurrentUser.SignedIn.Equals(False)) Then
                blnNavigate = False
                strMessage = "You must be signed in to navigate to this form."
                MsgBox(strMessage, , cstrTitle)
            ElseIf (blnSignedOutRequired And _CurrentUser.SignedIn.Equals(True)) Then
                blnNavigate = False
                strMessage = "You must be signed out to navigate to this form."
                MsgBox(strMessage, , cstrTitle)
            ElseIf (blnPasswordRequired AndAlso ConfirmPasswordPopup().Equals(False)) Then
                blnNavigate = False
                strMessage = "Invalid Password."
                MsgBox(strMessage, , cstrTitle)
            End If
        End If

        Return blnNavigate

    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ReloadForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine reloads the currently displayed form. </remarks>
    '''
    ''' <param name="frmCurrentForm">
    ''' The currently displayed form.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub ReloadForm(ByVal frmCurrentForm As Form)
        PositionForm(frmCurrentForm)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The SignOut subroutine. </summary>
    '''
    ''' <remarks>   This subroutine signs the user out of his/her account. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Sub SignOut()
        If (_CurrentUser.SignedIn) Then
            Dim strUserSigningOut As String = _CurrentUser.Username
            _CurrentUser.SignOut()
            ClearShoppingCart()
            _CurrentItem = New Item()
            MsgBox("You are now signed out.", , "Sign Out Success")
        Else
            MsgBox("You are not signed in.", , "Sign Out Error")
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The CreateShoppingCart subroutine. </summary>
    '''
    ''' <remarks>   This subroutine adds products to the shopping cart with zero quantity. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Sub CreateShoppingCart()
        Dim sciItem As ShoppingCartItem
        _Products.ForEach(Sub(itmItem)
                              sciItem = New ShoppingCartItem(itmItem, gcintZero)
                              _ShoppingCart.Add(sciItem)
                          End Sub)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ClearShoppingCart subroutine. </summary>
    '''
    ''' <remarks>   This subroutine empties the shopping cart after the user confirms his/her intention. </remarks>
    '''
    ''' <param name="blnConfirmIntention">
    ''' (Optional) True if the user has to confirm his/her intention to clear the shopping cart.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub ClearShoppingCart(Optional ByVal blnConfirmIntention As Boolean = False)
        If (_ShoppingCart.Count > gcintZero) Then
            If (blnConfirmIntention AndAlso MessageBox.Show("Are you sure you want to empty the shopping cart?", "Empty Shopping Cart?", MessageBoxButtons.YesNo).Equals(DialogResult.Yes)) Then
                _ShoppingCart.ForEach(Sub(sciItem)
                                          sciItem.Quantity = gcintZero
                                      End Sub)
            Else
                _ShoppingCart.ForEach(Sub(sciItem)
                                          sciItem.Quantity = gcintZero
                                      End Sub)
            End If
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The SignInAsGuest subroutine. </summary>
    '''
    ''' <remarks>   This subroutine signs the user into the guest account. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Sub SignInAsGuest()
        ' Hard-coded guest sign-in (no SQL validation)
        _CurrentUser.SignIn(SQLGetRecordID(DatabaseTables.ACCOUNT, "ACC_USERNAME", "Guest"))
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The AskForItem function. </summary>
    '''
    ''' <remarks>   This function asks the user to enter the name or ID of a product. </remarks>
    '''
    ''' <returns>   True if the item is valid, false otherwise. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function AskForItem() As Boolean
        Dim blnValidItem As Boolean = False
        Dim strProduct As String
        strProduct = InputBox("Enter the name or ID of a product.", "Unknown Item")
        If (RegexValidateUserData(strProduct, RegexValidate.ID)) Then
            GetProduct(Convert.ToInt32(strProduct))
        Else
            GetProduct(strProduct)
        End If
        If (_CurrentItem.ID.Equals(gcintZero)) Then
            MsgBox("Item not found.", , "Error")
        Else
            blnValidItem = True
        End If
        Return blnValidItem
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ConfirmPasswordPopup function. </summary>
    '''
    ''' <remarks>   This function asks the user to re-enter his/her password. </remarks>
    '''
    ''' <returns>   True if the entered password is correct, false otherwise. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function ConfirmPasswordPopup() As Boolean
        Dim blnConfirmed As Boolean = False
        Dim strPassword As String = InputBox("Re-Enter your password to confirm your identity.", "Re-Enter Password")
        ' SQL validation is not required here because User.Password is in memory
        blnConfirmed = strPassword.Equals(_CurrentUser.Password)
        Return blnConfirmed
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ExitApplication subroutine. </summary>
    '''
    ''' <remarks>   This subroutine terminates the application after the user confirms his/her intention. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Sub ExitApplication()
        Const cstrMessage As String = "Are you sure you want to exit the application?"
        Const cstrTitle As String = "Exit?"
        Dim intExitApplicationInput As Integer = MessageBox.Show(cstrMessage, cstrTitle, MessageBoxButtons.YesNo)
        If (intExitApplicationInput = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The AboutApplication subroutine. </summary>
    '''
    ''' <remarks>   This subroutine creates a popup that gives the user some information about the program and the form that is currently displayed. </remarks>
    '''
    ''' <param name="intForm">
    ''' (Optional) The form that the user wants information about.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub AboutApplication(Optional ByVal intForm As Integer = Forms.NULL)
        Dim strMessageEnd As String = ""
        Select Case intForm
            Case Forms.WELCOME
                strMessageEnd = "The Welcome form is used for letting customers know they're" & vbCrLf &
                                "welcomed to use the application. Also, it gives options for" & vbCrLf &
                                "signing in."
            Case Forms.REGISTRATION
                strMessageEnd = "The Registration form is used by customers to create accounts." & vbCrLf &
                                "Fill out the form to create an account."
            Case Forms.LOGIN
                strMessageEnd = "The Login form is used for logging into existing accounts." & vbCrLf &
                                "Fill out the form to login if you have an existing account."
            Case Forms.CATALOG
                strMessageEnd = "The Catalog form is used for browsing the catalog. Search for" & vbCrLf &
                                "items in the catalog with the search bar. Use the buttons to" & vbCrLf &
                                "filter results, go to the next page of results, or go to the" & vbCrLf &
                                "previous page of results. Then, click on an item to navigate to" & vbCrLf &
                                "a form that has more details for it."
            Case Forms.CHECKOUT
                strMessageEnd = "The Checkout form displays a list of items in the user's shopping" & vbCrLf &
                                "cart. There are options for removing items and making purchases."
            Case Forms.ACCOUNT
                strMessageEnd = "The Account form provides options for changing the user's" & vbCrLf &
                                "account information."
            Case Forms.ITEM
                strMessageEnd = "The Item form displays information about a specific item in the" & vbCrLf &
                                "catalog with the option to add the item with a specified quantitiy" & vbCrLf &
                                "to the shopping cart."
            Case Forms.PAYMENT
                strMessageEnd = "Use the Payment form to exchange real money for account money."
        End Select
        Const cstrMessage As String = "Program Name: Furniture Co. Catalog" & vbCrLf &
                                      "Developed By: Shawn Broyles" & vbCrLf &
                                      "Purpose: This application provides a user-friendly experience for" & vbCrLf &
                                      "purchasing items when they are not in stock at a business location." & vbCrLf & vbCrLf &
                                      "Use the Navigate item in the MenuStrip to navigate between the forms" & vbCrLf &
                                      "(It's located to the left of Help)."
        Const cstrTitle As String = "About"
        If String.IsNullOrWhiteSpace(strMessageEnd) Then
            MsgBox(cstrMessage, , cstrTitle)
        Else
            MsgBox(cstrMessage & vbCrLf & vbCrLf & strMessageEnd, , cstrTitle)
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The PrintForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine creates a print preview of the current form. </remarks>
    '''
    ''' <param name="pfObject">
    ''' The PrintForm object that on the currently displayed form.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub PrintForm(ByRef pfObject As Object)
        ' When the PrintForm subroutine is invoked, a print preview appears
        pfObject.PrintAction = Printing.PrintAction.PrintToPreview
        pfObject.Print()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The LoadFormDefaults subroutine. </summary>
    '''
    ''' <remarks>   This subroutine changes the colors of the form and positions the form when its loaded. </remarks>
    '''
    ''' <param name="frmCurrentForm">
    ''' The currently displayed form.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub LoadFormDefaults(ByVal frmCurrentForm As Form)
        frmCurrentForm.ForeColor = My.Settings.ForeColor
        frmCurrentForm.BackColor = My.Settings.BackColor

        PositionForm(frmCurrentForm)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The AddToShoppingCart subroutine. </summary>
    '''
    ''' <remarks>   This subroutine adds a ShoppingCartItem to the shopping cart list. </remarks>
    '''
    ''' <param name="sciNewItem">
    ''' The new ShoppingCartItem.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub AddToShoppingCart(ByRef sciNewItem As ShoppingCartItem)
        _ShoppingCart.Add(sciNewItem)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The AddToProducts subroutine. </summary>
    '''
    ''' <remarks>   This subroutine adds a product to the products list. </remarks>
    '''
    ''' <param name="itmNewItem">
    ''' The new Item.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub AddToProducts(ByRef itmNewItem As Item)
        _Products.Add(itmNewItem)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetSelectedItem subroutine. </summary>
    '''
    ''' <remarks>   This subroutine changes the current item to the selected item in the results list on the catalog form. </remarks>
    '''
    ''' <param name="lstListBox">
    ''' The ListBox object on the catalog form.
    ''' </param>
    ''' <param name="Results">
    ''' The search results List from searching on the catalog form.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub GetSelectedItem(ByRef lstListBox As ListBox, ByRef Results As List(Of Item))
        Try
            If (Not String.IsNullOrWhiteSpace(lstListBox.SelectedItem)) Then
                _CurrentItem = Results(lstListBox.SelectedIndex())
            End If
        Catch ex As Exception
            Console.WriteLine("Error occurred when attempting to get the current item from the selected item.")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetProduct subroutine. </summary>
    '''
    ''' <remarks>   This subroutine changes the current item to an Item from the products List based off of its ID. </remarks>
    '''
    ''' <param name="intID">
    ''' The ID of an Item.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub GetProduct(ByVal intID As Integer)
        Try
            _Products.ForEach(Sub(itmItem)
                                  If (itmItem.ID.Equals(intID)) Then
                                      _CurrentItem = itmItem
                                  End If
                              End Sub)
        Catch ex As Exception
            MsgBox("An unknown error has occurred when trying to get product information.", , "Error")
            Console.WriteLine("Failed at getting product information for ID: " & intID.ToString())
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetProduct subroutine. </summary>
    '''
    ''' <remarks>   This subroutine changes the current item to an Item from the products List based off of its ID. </remarks>
    '''
    ''' <param name="strName">
    ''' The Name of an Item.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Public Sub GetProduct(ByVal strName As String)
        Try
            _Products.ForEach(Sub(itmItem)
                                  If (itmItem.Name.Equals(strName)) Then
                                      _CurrentItem = itmItem
                                  End If
                              End Sub)
        Catch ex As Exception
            MsgBox("An unknown error has occurred when trying to get product information.", , "Error")
            Console.WriteLine("Failed at getting product information for Name: " & strName.ToString())
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetProductCategory function. </summary>
    '''
    ''' <remarks>   This function gets the category of an item. </remarks>
    '''
    ''' <param name="itmItem">
    ''' The Item whose category we want to retrieve.
    ''' </param>
    '''
    ''' <returns>   The category of an item. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function GetProductCategory(ByRef itmItem As Item) As Integer
        Dim intCategory As Integer
        If (itmItem.Category.Equals("Chair")) Then
            intCategory = ProductCategory.CHAIR
        ElseIf (itmItem.Category.Equals("Table")) Then
            intCategory = ProductCategory.TABLE
        ElseIf (itmItem.Category.Equals("Desk")) Then
            intCategory = ProductCategory.DESK
        ElseIf (itmItem.Category.Equals("Couch")) Then
            intCategory = ProductCategory.COUCH
        ElseIf (itmItem.Category.Equals("Carpet")) Then
            intCategory = ProductCategory.CARPET
        Else
            intCategory = ProductCategory.ALL
        End If
        Return intCategory
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The CheckOutOfStock function. </summary>
    '''
    ''' <remarks>   This function determines if a product in the catalog is out of stock. </remarks>
    '''
    ''' <param name="itmItem">
    ''' The Item in question.
    ''' </param>
    '''
    ''' <returns>   True if the Item is out of stock, false otherwise. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function CheckOutOfStock(ByRef itmItem As Item) As Boolean
        Dim blnItemOutOfStock As Boolean
        blnItemOutOfStock = itmItem.Stock.Equals(gcintZero)
        Return blnItemOutOfStock
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The UpdateProducts subroutine. </summary>
    '''
    ''' <remarks>   This subroutine reads from the database and updates values in memory. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Sub UpdateProducts()
        Try
            _Products.ForEach(Sub(itmItem)
                                  itmItem.Update()
                              End Sub)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Unable to update products list.")
        End Try
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The GetMatch function. </summary>
    '''
    ''' <remarks>   This function is used for searching for items in the database. </remarks>
    '''
    ''' <param name="itmItem">
    ''' An item in the catalog.
    ''' </param>
    ''' <param name="strSearchQuery">
    ''' The regular expression search query from the catalog form.
    ''' </param>
    '''
    ''' <returns>   True if a property of the Item matches the regular expression, false otherwise. </returns>
    '''-------------------------------------------------------------------------------------------------

    Function GetMatch(ByRef itmItem As Item, ByVal strSearchQuery As String) As Boolean
        Dim blnMatched As Boolean = False
        If (System.Text.RegularExpressions.Regex.IsMatch(itmItem.ID.ToString(), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Name, strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Price.ToString(), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Price.ToString("C2"), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Stock.ToString(), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Fee.ToString(), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Fee.ToString("C2"), strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Category, strSearchQuery) OrElse
            System.Text.RegularExpressions.Regex.IsMatch(itmItem.Description, strSearchQuery)) Then
            blnMatched = True
        End If
        Return blnMatched
    End Function

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Item class. </summary>
    '''
    ''' <remarks>   This class is used for creating objects for products that the company is selling. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Class Item

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the ID. </summary>
        '''
        ''' <value> The unique ID of an Item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property ID As Integer

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Name. </summary>
        '''
        ''' <value> The name of an Item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Name As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Price. </summary>
        '''
        ''' <value> The price of an item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Price As Decimal

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Stock. </summary>
        '''
        ''' <value> The stock of an item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Stock As Integer

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Fee. </summary>
        '''
        ''' <value> The fee of an item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Fee As Decimal

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Category. </summary>
        '''
        ''' <value> The category of an item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Category As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Description. </summary>
        '''
        ''' <value> The description of an item. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Description As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The default constructor for creating an Item. </summary>
        '''
        ''' <remarks>   This constructor sets the properties of an Item to zeros and empty strings. </remarks>
        '''-------------------------------------------------------------------------------------------------

        Public Sub New()
            ID = gcintZero
            Name = gcstrEmpty
            Price = gcdecZero
            Stock = gcintZero
            Fee = gcdecZero
            Category = gcstrEmpty
            Description = gcstrEmpty
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The parameterized constructor for creating an Item. </summary>
        '''
        ''' <remarks>   This constructor allows the program to create an Item with properties. </remarks>
        '''
        ''' <param name="intID">
        ''' The unique ID of an Item.
        ''' </param>
        ''' <param name="strName">
        ''' The name of an Item.
        ''' </param>
        ''' <param name="decPrice">
        ''' The price of an Item.
        ''' </param>
        ''' <param name="intStock">
        ''' The stock of an Item.
        ''' </param>
        ''' <param name="decFee">
        ''' The fee of an Item.
        ''' </param>
        ''' <param name="strCategory">
        ''' The category of an Item.
        ''' </param>
        ''' <param name="strDescription">
        ''' The description of an Item.
        ''' </param>
        '''-------------------------------------------------------------------------------------------------

        Public Sub New(ByVal intID As Integer, ByVal strName As String, ByVal decPrice As Decimal, ByVal intStock As Integer, ByVal decFee As Decimal, ByVal strCategory As String, ByVal strDescription As String)
            ID = intID
            Name = strName
            Price = decPrice
            Stock = intStock
            Fee = decFee
            Category = strCategory
            Description = strDescription
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The Update subroutine of an Item. </summary>
        '''
        ''' <remarks>   This subroutine updates an Item with information from the database. </remarks>
        '''-------------------------------------------------------------------------------------------------

        Public Sub Update()
            Dim intRecordID As Integer = ID
            Name = SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_NAME")
            Price = Convert.ToDecimal(SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_PRICE"))
            Stock = Convert.ToInt32(SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_STOCK"))
            Fee = Convert.ToDecimal(SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_FEE"))
            Category = SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_CATEGORY")
            Description = SQLGetFieldInfo(DatabaseTables.PRODUCT, intRecordID, "PROD_DESCRIPTION")
            Console.WriteLine("Product " & Name & " was updated.")
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The GetShoppingCartItem function of an Item. </summary>
        '''
        ''' <remarks>   This function gets the ShoppingCartItem equivalent of an Item. </remarks>
        '''
        ''' <returns>   The ShoppingCartItem equivalent of an Item. </returns>
        '''-------------------------------------------------------------------------------------------------

        Function GetShoppingCartItem() As ShoppingCartItem
            Dim sciRelatedItem As New ShoppingCartItem()
            _ShoppingCart.ForEach(Sub(sciItem)
                                      If (sciItem.ID.Equals(ID)) Then
                                          sciRelatedItem = sciItem
                                      End If
                                  End Sub)
            Return sciRelatedItem
        End Function
    End Class

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ShoppingCartItem class. </summary>
    '''
    ''' <remarks>   This class is used for creating objects for products in the shopping cart. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Class ShoppingCartItem

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the ID. </summary>
        '''
        ''' <value> The unique ID of a ShoppingCartItem. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property ID As Integer

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Quantity. </summary>
        '''
        ''' <value> The quantity of an Item in the shopping cart. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Quantity As Integer

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The default constructor of ShoppingCartItem. </summary>
        '''
        ''' <remarks>   This constructor creates a new ShoppingCartItem with properties set to zero. </remarks>
        '''-------------------------------------------------------------------------------------------------

        Public Sub New()
            ID = gcintZero
            Quantity = gcintZero
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The parameterized constructor of ShoppingCartItem. </summary>
        '''
        ''' <remarks>   This constructor creates a new ShoppingCartItem with properties set from arguments. </remarks>
        '''
        ''' <param name="itmItem">
        ''' The Item that represents a new ShoppingCartItem.
        ''' </param>
        ''' <param name="intQuantity">
        ''' The quantity of the Item that is being added to the shopping cart.
        ''' </param>
        '''-------------------------------------------------------------------------------------------------

        Public Sub New(ByRef itmItem As Item, ByVal intQuantity As Integer)
            ID = itmItem.ID
            Quantity = intQuantity
        End Sub
    End Class

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The User class. </summary>
    '''
    ''' <remarks>   This class is used for creating a User object that represents the signed in user. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Public Class User

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the ID. </summary>
        '''
        ''' <value> The unique ID of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property ID As Integer

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Username. </summary>
        '''
        ''' <value> The username of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Username As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Password. </summary>
        '''
        ''' <value> The password of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Password As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the First name. </summary>
        '''
        ''' <value> The first name of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property FirstName As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Last name. </summary>
        '''
        ''' <value> The last name of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property LastName As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Email. </summary>
        '''
        ''' <value> The email of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Email As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Phone. </summary>
        '''
        ''' <value> The phone of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Phone As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Address. </summary>
        '''
        ''' <value> The address of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Address As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Money. </summary>
        '''
        ''' <value> The amount of money on a User's account. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Money As Decimal

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Creation date. </summary>
        '''
        ''' <value> The creation date of a User. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property CreationDate As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Status. </summary>
        '''
        ''' <value> The status of a User's account. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property Status As String

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   Gets or sets the Signed in property. </summary>
        '''
        ''' <value> The signed in property says if a User is signed in or not. </value>
        '''-------------------------------------------------------------------------------------------------

        Public Property SignedIn As Boolean

        ''' <summary>   The UserUpdated event of a User. </summary>
        Public Event UserUpdated()

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The default constructor of a User. </summary>
        '''
        ''' <remarks>   This constructor sets the properties of a User to zeros and empty strings. </remarks>
        '''-------------------------------------------------------------------------------------------------

        Public Sub New()
            ID = gcintZero
            Username = gcstrEmpty
            Password = gcstrEmpty
            FirstName = gcstrEmpty
            LastName = gcstrEmpty
            Email = gcstrEmpty
            Phone = gcstrEmpty
            Address = gcstrEmpty
            Money = gcdecZero
            CreationDate = gcstrEmpty
            Status = gcstrEmpty
            SignedIn = False
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The SignIn subroutine of a User. </summary>
        '''
        ''' <remarks>   This subroutine changes a User object's properties to that of a user from the database. </remarks>
        '''
        ''' <param name="intRecordID">
        ''' The unique ID of a record in the ACCOUNT table in the database.
        ''' </param>
        '''-------------------------------------------------------------------------------------------------

        Public Sub SignIn(ByVal intRecordID As Integer)
            ID = intRecordID
            Username = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_USERNAME")
            Password = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_PASSWORD")
            FirstName = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_FNAME")
            LastName = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_LNAME")
            Email = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_EMAIL")
            Phone = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_PHONE")
            Address = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_ADDRESS")
            Money = Convert.ToDecimal(SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_MONEY"))
            CreationDate = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_CREATION_DATE")
            Status = SQLGetFieldInfo(DatabaseTables.ACCOUNT, intRecordID, "ACC_STATUS")
            SignedIn = True
            Console.WriteLine("Signed in = " & _CurrentUser.SignedIn & " (Signed in as " & _CurrentUser.Username & ")")
            RaiseEvent UserUpdated()
        End Sub

        '''-------------------------------------------------------------------------------------------------
        ''' <summary>   The SignOut subroutine of a User. </summary>
        '''
        ''' <remarks>   This subroutine sets the properties of a User to zeros and empty strings. </remarks>
        '''-------------------------------------------------------------------------------------------------

        Public Sub SignOut()
            Dim strUserSigningOut As String = _CurrentUser.Username
            ID = gcintZero
            Username = gcstrEmpty
            Password = gcstrEmpty
            FirstName = gcstrEmpty
            LastName = gcstrEmpty
            Email = gcstrEmpty
            Phone = gcstrEmpty
            Address = gcstrEmpty
            Money = gcdecZero
            CreationDate = gcstrEmpty
            Status = gcstrEmpty
            SignedIn = False
            Console.WriteLine("Signed in = " & _CurrentUser.SignedIn & " (Signed out of " & strUserSigningOut & ")")
            RaiseEvent UserUpdated()
        End Sub

    End Class

End Module
