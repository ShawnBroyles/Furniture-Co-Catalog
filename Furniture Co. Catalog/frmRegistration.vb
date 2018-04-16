'''-------------------------------------------------------------------------------------------------
''' <summary>   The Registration form. </summary>
'''
''' <remarks>   This form is used by customers to create accounts. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmRegistration
    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.REGISTRATION

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
        ClearForm()
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
    ''' <summary>   The frmRegistration_Load subroutine. </summary>
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

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        txtUsername.Focus()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Submit button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for creating a new account in the database. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Const cstrSuccessTitle As String = "Success"
        Const cstrSuccessMessage As String = "Account successfully created!"
        Const cstrErrorTitle As String = "Error"
        Const cstrBaseErrorMessage As String = "Validation for the following fields failed:"
        Const cstrUnknownErrorMessage As String = "An unknown error has occurred when trying to create an account."
        Dim strErrorMessage As String = cstrBaseErrorMessage

        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text
        Dim strConfirmPassword As String = txtConfirmPassword.Text
        Dim strFName As String = txtFirstName.Text
        Dim strLName As String = txtLastName.Text
        Dim strEmail As String = txtEmail.Text
        Dim strPhone As String = txtPhoneNumber.Text
        Dim strAddress As String = txtAddress.Text

        Dim blnUsernameValidated As Boolean = RegexValidateUserData(strUsername, RegexValidate.USERNAME)
        Dim blnPasswordValidated As Boolean = RegexValidateUserData(strPassword, RegexValidate.PASSWORD)
        Dim blnFNameValidated As Boolean = RegexValidateUserData(strFName, RegexValidate.OTHER_EMPTY)
        Dim blnLNameValidated As Boolean = RegexValidateUserData(strLName, RegexValidate.OTHER_EMPTY)
        Dim blnEmailValidated As Boolean = RegexValidateUserData(strEmail, RegexValidate.EMAIL)
        Dim blnPhoneValidated As Boolean = RegexValidateUserData(strPhone, RegexValidate.OTHER_EMPTY)
        Dim blnAddressValidated As Boolean = RegexValidateUserData(strAddress, RegexValidate.OTHER_EMPTY)

        If (Not blnUsernameValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Username must be 4-16 characters, start with a letter, and only contain A-Z a-z 0-9"
        End If
        If (Not blnPasswordValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Password must be 6-20 characters and only contain A-Z a-z 0-9 @ . - _ "
        End If
        If (Not blnFNameValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "First Name is optional. Only contains spaces and A-Z a-z 0-9 @ . - _ ( )"
        End If
        If (Not blnLNameValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Last Name is optional. Only contains spaces and A-Z a-z 0-9 @ . - _ ( )"
        End If
        If (Not blnEmailValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Email must be 5-50 characters and contain @ and . characters"
        End If
        If (Not blnPhoneValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Phone Number is optional. Only contains spaces and A-Z a-z 0-9 @ . - _ ( )"
        End If
        If (Not blnAddressValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Address is optional. Onlys contain spaces and A-Z a-z 0-9 @ . - _ ( )"
        End If
        If (Not strPassword.Equals(strConfirmPassword)) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Password and Confirm Password fields do not match"
        End If

        Const cstrEmailField As String = "ACC_EMAIL"
        Const cstrUsernameField As String = "ACC_USERNAME"
        Const cintMissingRecordID As Integer = -1
        Dim intExistingUsernameRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, cstrUsernameField, strUsername)
        Dim intExistingEmailRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, cstrEmailField, strEmail)

        If (Not intExistingUsernameRecordID.Equals(cintMissingRecordID)) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Username already exists in the database"
        End If
        If (Not intExistingEmailRecordID.Equals(cintMissingRecordID)) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Email already exists in the database"
        End If

        If (strErrorMessage.Equals(cstrBaseErrorMessage)) Then
            Try
                SQLCreateAccount(strUsername, strPassword, strFName, strLName, strEmail, strPhone, strAddress)
                gusrCurrentUser.SignIn(SQLGetRecordID(DatabaseTables.ACCOUNT, cstrUsernameField, strUsername))
                MsgBox(cstrSuccessMessage, , cstrSuccessTitle)
                ClearForm()
                Navigate(Forms.CATALOG, Me)
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(cstrUnknownErrorMessage, , cstrErrorTitle)
            End Try

        Else
            MsgBox(strErrorMessage, , cstrErrorTitle)
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ClearForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for clearing the form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtAddress.Clear()
        txtUsername.Focus()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Clear button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for clearing the form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clearing textboxes and setting the focus to txtUsername
        ClearForm()
        txtUsername.Focus()
    End Sub
End Class