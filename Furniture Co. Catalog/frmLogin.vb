'''-------------------------------------------------------------------------------------------------
''' <summary>   The Login form. </summary>
'''
''' <remarks>   This form is used for logging into existing accounts. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmLogin

    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.LOGIN

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
        ClearForm()
        ReloadForm(Me)
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
    ''' <summary>   The frmLogin_Load subroutine. </summary>
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

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        ClearForm()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Submit button subroutine. </summary>
    '''
    ''' <remarks>   This button is used for submitting the form and logging into an account. </remarks>
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
                        gusrCurrentUser.SignIn(intUsernameRecordID)
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

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The ClearForm subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for clearing the text on the form. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub ClearForm()
        txtUsername.Clear()
        txtPassword.Clear()
        rbUsername.Select()
        txtUsername.Focus()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Clear button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for clearing the text on the form. </remarks>
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
    End Sub
End Class