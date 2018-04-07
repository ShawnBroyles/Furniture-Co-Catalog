' Program:  Furniture Co. Catalog
' Version:  0.3
' Author:   Shawn Broyles
' Date:     TBD
' Purpose:  This application provides a user-friendly experience for
'           purchasing items when they are not in stock at a business
'           location.

Public Class frmWelcome

    ' Overriding the ClassStyle property of CreateParams() to disable
    ' the close window button
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myParams As CreateParams = MyBase.CreateParams
            Const cintStyleNoCloseButton As Integer = 512
            myParams.ClassStyle = cintStyleNoCloseButton
            Return myParams
        End Get
    End Property

    Const _cintForm As Integer = Forms.WELCOME

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

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        SQLInitializeDatabase()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Navigate(Forms.REGISTRATION, Me)
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Navigate(Forms.LOGIN, Me)
    End Sub

    Private Sub btnSignInAsGuest_Click(sender As Object, e As EventArgs) Handles btnSignInAsGuest.Click
        SignInAsGuest()
        UpdateSignedIn()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        SignOut()
        UpdateSignedIn()
    End Sub

    Private Sub UpdateSignedIn()
        Const cstrSignedInFormat As String = "Currently Signed In: {0}"
        Dim strSignedInUsername As String = ""
        If (_CurrentUser.SignedIn) Then
            strSignedInUsername = _CurrentUser.Username
            lblCurrentlySignedIn.ForeColor = Color.ForestGreen
            btnRegister.Enabled = False
            btnSignIn.Enabled = False
            btnSignInAsGuest.Enabled = False
            btnSignOut.Enabled = True
        Else
            strSignedInUsername = "N/A"
            lblCurrentlySignedIn.ForeColor = Color.PaleVioletRed
            btnRegister.Enabled = True
            btnSignIn.Enabled = True
            btnSignInAsGuest.Enabled = True
            btnSignOut.Enabled = False
        End If
        lblCurrentlySignedIn.Text = String.Format(cstrSignedInFormat, strSignedInUsername)
    End Sub
End Class
