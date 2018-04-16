'''-------------------------------------------------------------------------------------------------
''' <summary>   The Welcome form. </summary>
'''
''' <remarks>   This form is the application's main form. It's used for letting customers know they're welcome to use the application and it gives options for signing in. </remarks>
'''-------------------------------------------------------------------------------------------------

Public Class frmWelcome

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   Gets the required creation parameters when the control handle is created. The ClassStyle property is overridden to disable the Close button. </summary>
    '''
    ''' <value>
    ''' A <see cref="T:System.Windows.Forms.CreateParams" /> that contains the required creation
    ''' parameters when the handle to the control is created.
    ''' </value>
    '''-------------------------------------------------------------------------------------------------

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myParams As CreateParams = MyBase.CreateParams
            Const cintStyleNoCloseButton As Integer = 512
            myParams.ClassStyle = cintStyleNoCloseButton
            Return myParams
        End Get
    End Property

    ''' <summary>   The constant integer for the current form. </summary>
    Const _cintForm As Integer = Forms.WELCOME

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
    ''' <summary>   The frmWelcome_Load subroutine. </summary>
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

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormDefaults(Me)
        SQLInitializeDatabase()
        AddHandler gusrCurrentUser.UserUpdated, AddressOf UpdateSignedIn
        Console.WriteLine("glstProducts has " & glstProducts.Count() & " items.")
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Register button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for navigating to the Registration form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Navigate(Forms.REGISTRATION, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Sign In button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for navigating to the Login form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Navigate(Forms.LOGIN, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Sign In As Guest button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for signing the user into the guest account and navigating to the catalog form. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSignInAsGuest_Click(sender As Object, e As EventArgs) Handles btnSignInAsGuest.Click
        SignInAsGuest()
        Navigate(Forms.CATALOG, Me)
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The Sign Out button subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for signing out of an account. </remarks>
    '''
    ''' <param name="sender">
    ''' Source of the event.
    ''' </param>
    ''' <param name="e">
    ''' Event information.
    ''' </param>
    '''-------------------------------------------------------------------------------------------------

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        SignOut()
    End Sub

    '''-------------------------------------------------------------------------------------------------
    ''' <summary>   The UpdateSignedIn subroutine. </summary>
    '''
    ''' <remarks>   This subroutine is used for changing objects' properties for when the user signs in and out. </remarks>
    '''-------------------------------------------------------------------------------------------------

    Private Sub UpdateSignedIn()
        Const cstrSignedInFormat As String = "Currently Signed In: {0}"
        Dim strSignedInUsername As String
        If (gusrCurrentUser.SignedIn) Then
            lblCurrentlySignedIn.ForeColor = Color.ForestGreen
            btnRegister.Enabled = False
            btnSignIn.Enabled = False
            btnSignInAsGuest.Enabled = False
            btnSignOut.Enabled = True
            strSignedInUsername = gusrCurrentUser.Username
        Else
            lblCurrentlySignedIn.ForeColor = Color.PaleVioletRed
            btnRegister.Enabled = True
            btnSignIn.Enabled = True
            btnSignInAsGuest.Enabled = True
            btnSignOut.Enabled = False
            strSignedInUsername = "N/A"
        End If
        lblCurrentlySignedIn.Text = String.Format(cstrSignedInFormat, strSignedInUsername)
    End Sub
End Class
