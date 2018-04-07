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

    Const _cintZero As Integer = 0

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
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub Navigate(ByVal intForm As Integer, ByVal frmCurrentForm As Form, Optional ByVal intItem As Integer = _cintZero)
        Dim frmChosenForm As Form
        Select Case intForm
            Case Forms.REGISTRATION
                frmChosenForm = frmRegistration
            Case Forms.LOGIN
                frmChosenForm = frmLogin
            Case Forms.CATALOG
                frmChosenForm = frmCatalog
            Case Forms.CHECKOUT
                frmChosenForm = frmCheckout
            Case Forms.ACCOUNT
                frmChosenForm = frmAccount
            Case Forms.ITEM
                frmChosenForm = frmItem
            Case Forms.PAYMENT
                frmChosenForm = frmPayment
            Case Else
                frmChosenForm = frmWelcome
        End Select

        If (frmCurrentForm.Equals(frmWelcome) And Not frmChosenForm.Equals(frmWelcome)) Then
            frmChosenForm.ShowDialog()
        ElseIf (Not frmCurrentForm.Equals(frmWelcome) And frmChosenForm.Equals(frmWelcome)) Then
            frmCurrentForm.Dispose()
        ElseIf (Not frmChosenForm.Equals(frmCurrentForm)) Then
            frmCurrentForm.Dispose()
            frmChosenForm.ShowDialog()
        Else
            Const cstrMessage As String = "Unable to navigate to a form that is already displayed."
            Const cstrTitle As String = "Error"
            MsgBox(cstrMessage, , cstrTitle)
        End If
    End Sub

    Public Sub ReloadForm(ByVal frmCurrentForm As Form)
        ' stub
        MsgBox("Reloading the form isn't implemented yet.")
    End Sub

    Public Sub SignOut()
        If (_CurrentUser.SignedIn) Then
            Dim strUserSigningOut As String = _CurrentUser.Username
            _CurrentUser.SignOut()
            Console.WriteLine("Signed in = " & _CurrentUser.SignedIn & " (Signed out of " & strUserSigningOut & ")")
        Else
            MsgBox("You are not signed in.", , "Sign Out Error")
        End If
    End Sub

    Public Sub SignInAsGuest()
        _CurrentUser.SignIn(SQLGetRecordID(DatabaseTables.ACCOUNT, "ACC_USERNAME", "Guest"))
        Console.WriteLine("Signed in = " & _CurrentUser.SignedIn & " (Signed in as " & _CurrentUser.Username & ")")
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

    Public Sub SignedInPopup()
        If (_CurrentUser.SignedIn = True) Then
            Const cstrErrorTitle As String = "Error"
            Const cstrErrorMessage As String = "A user is already signed in." & vbCrLf &
                                               "Do you want to sign out?"
            Dim intSignOut As Integer = MessageBox.Show(cstrErrorMessage, cstrErrorTitle, MessageBoxButtons.YesNo)
            If (intSignOut = DialogResult.Yes) Then
                _CurrentUser.SignOut()
            End If
        End If
    End Sub

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

        Const cintZero As Integer = 0
        Const cdecZero As Decimal = 0.00D
        Const cstrEmpty As String = ""
        Const cstrStatusUnknown As String = "Unknown"

        Public Sub New()
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
            RaiseEvent UserUpdated()
        End Sub

        Public Sub SignOut()
            ID = cintZero
            Username = cstrEmpty
            Password = cstrEmpty
            FirstName = cstrEmpty
            LastName = cstrEmpty
            Email = cstrEmpty
            Phone = cstrEmpty
            Address = cstrEmpty
            Money = cdecZero
            CreationDate = cstrEmpty
            Status = cstrEmpty
            SignedIn = False
            RaiseEvent UserUpdated()
        End Sub

    End Class

End Module
