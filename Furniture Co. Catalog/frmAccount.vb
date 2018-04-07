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
        txtPhone.Text = _CurrentUser.Phone
        txtAddress.Text = _CurrentUser.Address
        lblMoneyOutput.Text = _CurrentUser.Money.ToString("C2")
        lblCreationDateOutput.Text = _CurrentUser.CreationDate
        lblAccountStatusOutput.Text = _CurrentUser.Status
        txtUsername.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtEmail.Enabled = False
        txtPhone.Enabled = False
        txtAddress.Enabled = False
        btnChangeInfo.Enabled = True
        btnSave.Enabled = False
        btnReset.Enabled = False
    End Sub

    Private Sub btnChangeInfo_Click(sender As Object, e As EventArgs) Handles btnChangeInfo.Click
        If (_CurrentUser.ID = _cstrEmpty Or _CurrentUser.SignedIn = False) Then
            MsgBox("You are not signed in.", , "Error")
        ElseIf (_CurrentUser.Username = "Guest") Then
            MsgBox("You cannot change the info for Guest.", , "Error")
        Else
            txtUsername.Enabled = True
            txtFirstName.Enabled = True
            txtLastName.Enabled = True
            txtEmail.Enabled = True
            txtPhone.Enabled = True
            txtAddress.Enabled = True
            btnChangeInfo.Enabled = False
            btnSave.Enabled = True
            btnReset.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        MsgBox("Feature not yet implemented.")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub
End Class