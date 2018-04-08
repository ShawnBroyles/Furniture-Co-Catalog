Public Class frmAccount

    Const _cintForm As Integer = Forms.ACCOUNT

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

    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ResetForm()
    End Sub

    Private Sub ResetForm()
        lblAccountIDOutput.Text = _CurrentUser.ID.ToString()
        txtUsername.Text = _CurrentUser.Username
        txtFirstName.Text = _CurrentUser.FirstName
        txtLastName.Text = _CurrentUser.LastName
        txtEmail.Text = _CurrentUser.Email
        txtPhoneNumber.Text = _CurrentUser.Phone
        txtAddress.Text = _CurrentUser.Address
        lblMoneyOutput.Text = _CurrentUser.Money.ToString("C2")
        lblCreationDateOutput.Text = _CurrentUser.CreationDate
        lblAccountStatusOutput.Text = _CurrentUser.Status
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

    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        If (_CurrentUser.ID = _cintZero Or _CurrentUser.SignedIn = False) Then
            MsgBox("You are not signed in.", , "Error")
        ElseIf (_CurrentUser.Username = "Guest") Then
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (_CurrentUser.ID = _cintZero Or _CurrentUser.SignedIn = False) Then
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

            Dim blnUsernameValidated As Boolean = SQLValidateUserData(strUsername, SQLValidate.USERNAME)
            Dim blnFNameValidated As Boolean = SQLValidateUserData(strFName, SQLValidate.OTHER_EMPTY)
            Dim blnLNameValidated As Boolean = SQLValidateUserData(strLName, SQLValidate.OTHER_EMPTY)
            Dim blnEmailValidated As Boolean = SQLValidateUserData(strEmail, SQLValidate.EMAIL)
            Dim blnPhoneValidated As Boolean = SQLValidateUserData(strPhone, SQLValidate.OTHER_EMPTY)
            Dim blnAddressValidated As Boolean = SQLValidateUserData(strAddress, SQLValidate.OTHER_EMPTY)

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

            If (Not intExistingUsernameRecordID.Equals(cintMissingRecordID) And Not intExistingUsernameRecordID.Equals(_CurrentUser.ID)) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Username already exists in the database"
            End If
            If (Not intExistingEmailRecordID.Equals(cintMissingRecordID) And Not intExistingEmailRecordID.Equals(_CurrentUser.ID)) Then
                strErrorMessage = strErrorMessage & vbCrLf & "Email already exists in the database"
            End If

            If (strErrorMessage.Equals(cstrBaseErrorMessage)) Then

                Try
                    Dim strField As String
                    If (Not _CurrentUser.Username.Equals(strUsername)) Then
                        strField = "ACC_USERNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strUsername)
                    End If
                    If (Not _CurrentUser.FirstName.Equals(strFName)) Then
                        strField = "ACC_FNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strFName)
                    End If
                    If (Not _CurrentUser.FirstName.Equals(strLName)) Then
                        strField = "ACC_LNAME"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strLName)
                    End If
                    If (Not _CurrentUser.FirstName.Equals(strEmail)) Then
                        strField = "ACC_EMAIL"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strEmail)
                    End If
                    If (Not _CurrentUser.FirstName.Equals(strPhone)) Then
                        strField = "ACC_PHONE"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strPhone)
                    End If
                    If (Not _CurrentUser.FirstName.Equals(strAddress)) Then
                        strField = "ACC_ADDRESS"
                        SQLSetFieldInfo(DatabaseTables.ACCOUNT, _CurrentUser.ID, strField, strAddress)
                    End If

                    _CurrentUser.SignIn(_CurrentUser.ID)
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
End Class