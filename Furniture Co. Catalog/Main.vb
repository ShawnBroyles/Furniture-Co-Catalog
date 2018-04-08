﻿' Program:  Furniture Co. Catalog
' Version:  0.5
' Author:   Shawn Broyles
' Date:     TBD
' Purpose:  This application provides a user-friendly experience for
'           purchasing items when they are not in stock at a business
'           location.

' The Main module contains public methods that are used by other forms
' in the application.

Module Main
    ' Enumeration for the forms in the application
    Enum Forms
        WELCOME
        REGISTRATION
        LOGIN
        CATALOG
        CHECKOUT
        ACCOUNT
        ITEM
        PAYMENT
        NULL
    End Enum

    Public Const _cintZero As Integer = 0
    Public Const _cdecZero As Decimal = 0.00D
    Public Const _cstrEmpty As String = ""

    Public Sub PositionFormOnLoad(ByVal frmCurrentForm As Form)
        ' Positioning the form that was passed to this subroutine
        Try
            Dim xCoordinate As Double
            Dim yCoordinate As Double
            xCoordinate = Screen.PrimaryScreen.WorkingArea.Width / 2 - frmCurrentForm.Size.Width / 2
            yCoordinate = Screen.PrimaryScreen.WorkingArea.Height / 2 - frmCurrentForm.Size.Height / 1.5
            frmCurrentForm.Location = New Point(Convert.ToInt32(xCoordinate), Convert.ToInt32(yCoordinate))
        Catch ex As Exception
            ' Writing the error to the output
            Console.WriteLine("Position Form Error = " & ex.Message)
        End Try
    End Sub

    Public Sub Navigate(ByVal intForm As Integer, ByVal frmCurrentForm As Form, Optional ByVal intItem As Integer = _cintZero)
        Dim frmChosenForm As Form
        Dim blnSignedOutRequired As Boolean = False
        Dim blnSignedInRequired As Boolean = False
        Dim blnPasswordRequired As Boolean = False
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
            Case Forms.ACCOUNT
                frmChosenForm = frmAccount
                blnSignedInRequired = True
                blnPasswordRequired = True
            Case Forms.ITEM
                frmChosenForm = frmItem
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
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired) Then
                frmChosenForm.ShowDialog()
            End If
        ElseIf (Not frmCurrentForm.Equals(frmWelcome) And frmChosenForm.Equals(frmWelcome)) Then
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired) Then
                frmCurrentForm.Dispose()
            End If
        ElseIf (Not frmChosenForm.Equals(frmCurrentForm)) Then
            If NavigatePrerequisite(blnSignedOutRequired, blnSignedInRequired, blnPasswordRequired) Then
                frmCurrentForm.Dispose()
                frmChosenForm.ShowDialog()
            End If
        Else
            MsgBox(strMessage, , cstrTitle)
        End If
    End Sub

    Function NavigatePrerequisite(ByVal blnSignedOutRequired As Boolean, ByVal blnSignedInRequired As Boolean, ByVal blnPasswordRequired As Boolean) As Boolean
        Dim blnNavigate As Boolean = True
        Dim strMessage As String = ""
        Dim cstrTitle As String = "Error"
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

        Return blnNavigate

    End Function

    Public Sub ReloadForm(ByVal frmCurrentForm As Form)
        ' stub
        MsgBox("Reloading the form isn't implemented yet.")
    End Sub

    Public Sub SignOut()
        If (_CurrentUser.SignedIn) Then
            Dim strUserSigningOut As String = _CurrentUser.Username
            _CurrentUser.SignOut()
            MsgBox("You are now signed out.", , "Sign Out Success")
        Else
            MsgBox("You are not signed in.", , "Sign Out Error")
        End If
    End Sub

    Public Sub SignInAsGuest()
        ' Hard-coded guest sign-in (no SQL validation)
        _CurrentUser.SignIn(SQLGetRecordID(DatabaseTables.ACCOUNT, "ACC_USERNAME", "Guest"))
    End Sub

    Public Function GetSignedInUsername() As String
        Dim strUsername As String
        If (_CurrentUser.SignedIn) Then
            strUsername = _CurrentUser.Username
        Else
            strUsername = "N/A"
        End If
        Return strUsername
    End Function

    Function ConfirmPasswordPopup() As Boolean
        Dim blnConfirmed As Boolean = False
        Dim strPassword As String = InputBox("Re-Enter your password to confirm your identity.", "Re-Enter Password")
        ' SQL validation is not required here because User.Password is in memory
        blnConfirmed = strPassword.Equals(_CurrentUser.Password)
        Return blnConfirmed
    End Function

    Public Sub ExitApplication()
        Const cstrMessage As String = "Are you sure you want to exit the application?"
        Const cstrTitle As String = "Exit?"
        Dim intExitApplicationInput As Integer = MessageBox.Show(cstrMessage, cstrTitle, MessageBoxButtons.YesNo)
        If (intExitApplicationInput = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

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
                                "cart. There are options for removing items and changing the" & vbCrLf &
                                "quantities of items."
            Case Forms.ACCOUNT
                strMessageEnd = "The Account form provides options for changing the user's" & vbCrLf &
                                "account information."
            Case Forms.ITEM
                strMessageEnd = "The Item form displays information about a specific item in the" & vbCrLf &
                                "catalog with the option to add the item with a specified quantitiy" & vbCrLf &
                                "to the shopping cart."
            Case Forms.PAYMENT
                strMessageEnd = "Use the Payment form to make a purchase with money from your account."
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

    Public Sub PrintForm(ByRef pfObject As Object)
        ' When the PrintForm subroutine is invoked, a print preview appears
        pfObject.PrintAction = Printing.PrintAction.PrintToPreview
        pfObject.Print()
    End Sub

    Public Sub LoadFormDefaults(ByVal frmCurrentForm As Form)
        frmCurrentForm.ForeColor = My.Settings.ForeColor
        frmCurrentForm.BackColor = My.Settings.BackColor

        PositionFormOnLoad(frmCurrentForm)
    End Sub

    ' Array of ShoppingCartItems
    Public _ShoppingCart As ShoppingCartItem()

    Public Sub AddToShoppingCart(ByRef sciNewItem As ShoppingCartItem)
        Array.Resize(_ShoppingCart, _ShoppingCart.Length + 1)
        _ShoppingCart(_ShoppingCart.Length - 1) = sciNewItem
    End Sub

    ' Array of Items
    Public _Products As Item()

    Public Sub AddToProducts(ByRef itmNewItem As Item)
        Array.Resize(_Products, _Products.Length + 1)
        _Products(_Products.Length - 1) = itmNewItem
    End Sub

    Public Sub UpdateProducts() ' stub
        ' for each record
        Dim intID As Integer = _cintZero
        Dim strName As String = _cstrEmpty
        Dim decPrice As Decimal = _cdecZero
        Dim intStock As Integer = _cintZero
        Dim decFee As Decimal = _cdecZero
        Dim strCategory As String = _cstrEmpty
        Dim strDescription As String = _cstrEmpty
        Dim itmProduct As Item = New Item(intID, strName, decPrice, intStock, decFee, strCategory, strDescription)
        Try
            AddToProducts(itmProduct)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Console.WriteLine("Unable to add product to the products array")
        End Try
        ' loop
    End Sub

    Public Class Item
        Public Property ID As Integer
        Public Property Name As String
        Public Property Price As Decimal
        Public Property Stock As Integer
        Public Property Fee As Decimal
        Public Property Category As String
        Public Property Description As String

        Public Sub New()
            ID = _cintZero
            Name = _cstrEmpty
            Price = _cdecZero
            Stock = _cintZero
            Fee = _cdecZero
            Category = _cstrEmpty
            Description = _cstrEmpty
        End Sub

        Public Sub New(ByVal intID As Integer, ByVal strName As String, ByVal decPrice As Decimal, ByVal intStock As Integer, ByVal decFee As Decimal, ByVal strCategory As String, ByVal strDescription As String)
            ID = intID
            Name = strName
            Price = decPrice
            Stock = intStock
            Fee = decFee
            Category = strCategory
            Description = strDescription
        End Sub

    End Class

    Public Class ShoppingCartItem
        Public Property Item As Item
        Public Property Quantity As Integer

        Public Sub New()
            Item = New Item()
            Quantity = _cintZero
        End Sub

        Public Sub New(ByRef itmItem As Item, ByVal intQuantity As Integer)
            Item = itmItem
            Quantity = intQuantity
        End Sub
    End Class

    Public _CurrentUser As User = New User()

    Public Class User
        Public Property ID As Integer
        Public Property Username As String
        Public Property Password As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Email As String
        Public Property Phone As String
        Public Property Address As String
        Public Property Money As Decimal
        Public Property CreationDate As String
        Public Property Status As String
        Public Property SignedIn As Boolean

        Public Event UserUpdated()

        Const cstrStatusUnknown As String = "Unknown"

        Public Sub New()
            ID = _cintZero
            Username = _cstrEmpty
            Password = _cstrEmpty
            FirstName = _cstrEmpty
            LastName = _cstrEmpty
            Email = _cstrEmpty
            Phone = _cstrEmpty
            Address = _cstrEmpty
            Money = _cdecZero
            CreationDate = _cstrEmpty
            Status = _cstrEmpty
            SignedIn = False
        End Sub

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

        Public Sub SignOut()
            Dim strUserSigningOut As String = _CurrentUser.Username
            ID = _cintZero
            Username = _cstrEmpty
            Password = _cstrEmpty
            FirstName = _cstrEmpty
            LastName = _cstrEmpty
            Email = _cstrEmpty
            Phone = _cstrEmpty
            Address = _cstrEmpty
            Money = _cdecZero
            CreationDate = _cstrEmpty
            Status = _cstrEmpty
            SignedIn = False
            Console.WriteLine("Signed in = " & _CurrentUser.SignedIn & " (Signed out of " & strUserSigningOut & ")")
            RaiseEvent UserUpdated()
        End Sub

    End Class

End Module
