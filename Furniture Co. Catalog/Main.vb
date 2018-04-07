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
            Console.WriteLine(ex.Message)
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

        If (blnSignedInRequired And _CurrentUser.SignedIn.Equals(False)) Then
            strMessage = "You must be signed in to navigate to this form."
            MsgBox(strMessage, , cstrTitle)
        ElseIf (blnSignedOutRequired And _CurrentUser.SignedIn.Equals(True)) Then
            strMessage = "You must be signed out to navigate to this form."
            MsgBox(strMessage, , cstrTitle)
        ElseIf (blnPasswordRequired AndAlso ConfirmPasswordPopup().Equals(False)) Then
            strMessage = "Invalid Password."
            MsgBox(strMessage, , cstrTitle)
        Else
            ' Navigating
            If (frmCurrentForm.Equals(frmWelcome) And Not frmChosenForm.Equals(frmWelcome)) Then
                frmChosenForm.ShowDialog()
            ElseIf (Not frmCurrentForm.Equals(frmWelcome) And frmChosenForm.Equals(frmWelcome)) Then
                frmCurrentForm.Dispose()
            ElseIf (Not frmChosenForm.Equals(frmCurrentForm)) Then
                frmCurrentForm.Dispose()
                frmChosenForm.ShowDialog()
            Else
                strMessage = "Unable to navigate to the displayed form."
                MsgBox(strMessage, , cstrTitle)
            End If
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
