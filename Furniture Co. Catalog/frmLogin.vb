' Developed by Shawn Broyles
' The Login form is used for logging into existing accounts.

Public Class frmLogin

    Const _cintForm As Integer = Forms.LOGIN

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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        txtUsername.Focus()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Const cstrSuccessTitle As String = "Success"
        Const cstrSuccessMessage As String = "Signed in successfully!"
        Const cstrErrorTitle As String = "Error"
        Const cstrBaseErrorMessage As String = "Validation for the following fields failed:"
        Const cstrUnknownErrorMessage As String = "An unknown error has occurred when trying to login."
        Dim strErrorMessage As String = cstrBaseErrorMessage

        Dim strUsername As String = txtUsername.Text
        Dim strPassword As String = txtPassword.Text

        Const cstrEmailField As String = "ACC_EMAIL"
        Const cstrAccountIDField As String = "ACC_ID"
        Const cstrUsernameField As String = "ACC_USERNAME"
        Const cstrPasswordField As String = "ACC_PASSWORD"
        Const cintMissingRecordID As Integer = -1

        Dim strLoginFieldType As String
        Dim strLoginField As String
        Dim intValidateType As Integer

        If (rbEmail.Checked) Then
            strLoginFieldType = "Email"
            strLoginField = cstrEmailField
            intValidateType = RegexValidate.EMAIL
        ElseIf (rbAccountID.Checked) Then
            strLoginFieldType = "Account ID"
            strLoginField = cstrAccountIDField
            intValidateType = RegexValidate.ID
        Else
            strLoginFieldType = "Username"
            strLoginField = cstrUsernameField
            intValidateType = RegexValidate.USERNAME
        End If

        Dim blnUsernameValidated As Boolean = RegexValidateUserData(strUsername, intValidateType)
        Dim blnPasswordValidated As Boolean = RegexValidateUserData(strPassword, RegexValidate.PASSWORD)

        If (Not blnUsernameValidated) Then
            Select Case intValidateType
                Case RegexValidate.EMAIL
                    strErrorMessage = strErrorMessage & vbCrLf & strLoginFieldType & "s only contain A-Z a-z 0-9 . - _ @"
                Case RegexValidate.ID
                    strErrorMessage = strErrorMessage & vbCrLf & strLoginFieldType & "s only contain 0-9"
                Case Else
                    strErrorMessage = strErrorMessage & vbCrLf & strLoginFieldType & "s start with a letter and only contain A-Z a-z 0-9"
            End Select
        End If
        If (Not blnPasswordValidated) Then
            strErrorMessage = strErrorMessage & vbCrLf & "Password field must only contain A-Z a-z 0-9 @ . - _ "
        End If

        Dim blnSignedIn As Boolean = False
        Dim blnAttemptSignIn As Boolean = False
        Dim blnPasswordCaseSensitive As Boolean = True

        If (strErrorMessage.Equals(cstrBaseErrorMessage)) Then
            Try
                blnAttemptSignIn = True
                strErrorMessage = "Logging in failed for the following reason(s):"
                Dim intUsernameRecordID As Integer = SQLGetRecordID(DatabaseTables.ACCOUNT, strLoginField, strUsername)
                If (Not intUsernameRecordID.Equals(cintMissingRecordID)) Then
                    If (SQLGetFieldInfo(DatabaseTables.ACCOUNT, intUsernameRecordID, cstrPasswordField, blnPasswordCaseSensitive).Equals(strPassword)) Then
                        _CurrentUser.SignIn(intUsernameRecordID)
                        blnSignedIn = True
                        MsgBox(cstrSuccessMessage, , cstrSuccessTitle)
                        ClearForm()
                        Navigate(Forms.CATALOG, Me)
                    Else
                        strErrorMessage = strErrorMessage & vbCrLf & "Invalid Password"
                    End If
                Else
                    strErrorMessage = strErrorMessage & vbCrLf & strLoginFieldType & " doesn't exist"
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                MsgBox(cstrUnknownErrorMessage, , cstrErrorTitle)
            End Try

        Else
            MsgBox(strErrorMessage, , cstrErrorTitle)
        End If
        If (blnAttemptSignIn And Not blnSignedIn) Then
            ' Username/Password combo was incorrect
            MsgBox(strErrorMessage, , cstrErrorTitle)
        End If
    End Sub

    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassword.Clear()
        rbUsername.Select()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clearing textboxes and setting the focus to txtUsername
        ClearForm()
        txtUsername.Focus()
    End Sub
End Class