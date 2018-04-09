' Developed by Shawn Broyles
' The Registration form is used by customers to create accounts.

Public Class frmRegistration
    Const _cintForm As Integer = Forms.REGISTRATION

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
        ClearForm()
        txtUsername.Focus()
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

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        txtUsername.Focus()
    End Sub

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
                _CurrentUser.SignIn(SQLGetRecordID(DatabaseTables.ACCOUNT, cstrUsernameField, strUsername))
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

    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassword.Clear()
        txtConfirmPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtAddress.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clearing textboxes and setting the focus to txtUsername
        ClearForm()
        txtUsername.Focus()
    End Sub
End Class