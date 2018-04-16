'''-------------------------------------------------------------------------------------------------
''' <summary>   The Account form. </summary>
'''
''' <remarks>   This form displays the user's account information and provides options for changing them. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmAccount

    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.ACCOUNT

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
        ResetForm()
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
    ''' <summary>   The frmAccount_Load subroutine. </summary>
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

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ResetForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine resets all of the data on the form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub ResetForm()
        lblAccountIDOutput.Text = gusrCurrentUser.ID.ToString()
        txtUsername.Text = gusrCurrentUser.Username
        txtFirstName.Text = gusrCurrentUser.FirstName
        txtLastName.Text = gusrCurrentUser.LastName
        txtEmail.Text = gusrCurrentUser.Email
        txtPhoneNumber.Text = gusrCurrentUser.Phone
        txtAddress.Text = gusrCurrentUser.Address
        lblMoneyOutput.Text = gusrCurrentUser.Money.ToString("C2")
        lblCreationDateOutput.Text = gusrCurrentUser.CreationDate
        lblAccountStatusOutput.Text = gusrCurrentUser.Status
        txtUsername.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtEmail.Enabled = False
        txtPhoneNumber.Enabled = False
        txtAddress.Enabled = False
        btnChangeInfo.Enabled = True
        btnSave.Enabled = False
        btnReset.Enabled = False
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Change Info button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine allows the user to change his/her account information. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        If (gusrCurrentUser.ID = gcintZero Or gusrCurrentUser.SignedIn = False) Then
            MsgBox("You are not signed in.", , "Error")
        ElseIf (gusrCurrentUser.Username = "Guest") Then
            MsgBox("You cannot change the info for Guest.", , "Error")
        Else
            txtUsername.Enabled = True
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            txtEmail.Enabled = True
            txtPhoneNumber.Enabled = True
            txtAddress.Enabled = True
            btnChangeInfo.Enabled = False
            btnSave.Enabled = True
            btnReset.Enabled = True
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Save button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine commits new data to the database for the user's account. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (gusrCurrentUser.ID = gcintZero Or gusrCurrentUser.SignedIn = False) Then
            MsgBox("You are not signed in.", , "Error")
        Else
            Const cstrSuccessTitle As String = "Success"
            Const cstrSuccessMessage As String = "Account info changed."
            Const cstrErrorTitle As String = "Error"
            Const cstrBaseErrorMessage As String = "Validation for the following fields failed:"
            Const cstrUnknownErrorMessage As String = "An unknown error has occurred when trying to change account info."
            Dim strErrorMessage As String = cstrBaseErrorMessage

            Dim strUsername As String = txtUsername.Text
            Dim strFName As String = txtFirstName.Text
            Dim strLName As String = txtLastName.Text
            Dim strEmail As String = txtEmail.Text
            Dim strPhone As String = txtPhoneNumber.Text
            Dim strAddress As String = txtAddress.Text

            Dim blnUsernameValidated As Boolean = RegexValidateUserData(strUsername, RegexValidate.USERNAME)
            Dim blnFNameValidated As Boolean = RegexValidateUserData(strFName, RegexValidate.OTHER_EMPTY)
            Dim blnLNameValidated As Boolean = RegexValidateUserData(strLName, RegexValidate.OTHER_EMPTY)
            Dim blnEmailValidated As Boolean = RegexValidateUserData(strEmail, RegexValidate.EMAIL)
            Dim blnPhoneValidated As Boolean = RegexValidateUserData(strPhone, RegexValidate.OTHER_EMPTY)
            Dim blnAddressValidated As Boolean = RegexValidateUserData(strAddress, RegexValidate.OTHER_EMPTY)

            If (Not blnUsernameValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Username must be 4-16 characters, start with a letter, and only contain A-Z a-z 0-9"
            End If
            If (Not blnFNameValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "First Name is optional. Can only contain spaces and A-Z a-z 0-9 @ . - _ ( )"
            End If
            If (Not blnLNameValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Last Name is optional. Can only contain spaces and A-Z a-z 0-9 @ . - _ ( )"
            End If
            If (Not blnEmailValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Email must be 5-50 characters and contain @ and . characters"
            End If
            If (Not blnPhoneValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Phone Number is optional. Can only contain spaces and A-Z a-z 0-9 @ . - _ ( )"
            End If
            If (Not blnAddressValidated) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Address is optional. Can only contain spaces and A-Z a-z 0-9 @ . - _ ( )"
            End If

            Const cstrEmailField As String = "ACC_EMAIL"
            Const cstrUsernameField As String = "ACC_USERNAME"
            Const cintMissingRecordID As Integer = -1
            Dim intExistingUsernameRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, cstrUsernameField, strUsername)
            Dim intExistingEmailRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, cstrEmailField, strEmail)

            If (Not intExistingUsernameRecordID.Equals(cintMissingRecordID) And Not intExistingUsernameRecordID.Equals(gusrCurrentUser.ID)) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Username already exists in the database"
            End If
            If (Not intExistingEmailRecordID.Equals(cintMissingRecordID) And Not intExistingEmailRecordID.Equals(gusrCurrentUser.ID)) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Email already exists in the database"
            End If

            If (strErrorMessage.Equals(cstrBaseErrorMessage)) Then

                Try
                    Dim strField As String
                    If (Not gusrCurrentUser.Username.Equals(strUsername)) Then
                        strField = "ACC_USERNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strUsername)
                    End If
                    If (Not gusrCurrentUser.FirstName.Equals(strFName)) Then
                        strField = "ACC_FNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strFName)
                    End If
                    If (Not gusrCurrentUser.FirstName.Equals(strLName)) Then
                        strField = "ACC_LNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strLName)
                    End If
                    If (Not gusrCurrentUser.FirstName.Equals(strEmail)) Then
                        strField = "ACC_EMAIL"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strEmail)
                    End If
                    If (Not gusrCurrentUser.FirstName.Equals(strPhone)) Then
                        strField = "ACC_PHONE"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strPhone)
                    End If
                    If (Not gusrCurrentUser.FirstName.Equals(strAddress)) Then
                        strField = "ACC_ADDRESS"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, gusrCurrentUser.ID, strField, strAddress)
                    End If

                    gusrCurrentUser.SignIn(gusrCurrentUser.ID)
                    ResetForm()
                    MsgBox(cstrSuccessMessage, , cstrSuccessTitle)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                    MsgBox(cstrUnknownErrorMessage, , cstrErrorTitle)
                End Try

            Else
                strErrorMessage = strErrorMessage & vbCrLf & vbCrLf & "No changes were made."
                MsgBox(strErrorMessage, , cstrErrorTitle)
            End If
        End If
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Reset button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine resets all of the data on the form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
End Class