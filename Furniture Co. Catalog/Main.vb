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
    End Enum

    Public Sub PositionFormOnLoad(form As Form)
        ' Positioning the form that was passed to this subroutine
        Try
            Dim xCoordinate As Double
            Dim yCoordinate As Double
            xCoordinate = Screen.PrimaryScreen.WorkingArea.Width / 2 - form.Size.Width / 2
            yCoordinate = Screen.PrimaryScreen.WorkingArea.Height / 2 - form.Size.Height / 1.5
            form.Location = New Point(Convert.ToInt32(xCoordinate), Convert.ToInt32(yCoordinate))
        Catch ex As Exception
            ' Writing the error to the output
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Public Sub Navigate(ByVal intForm As Integer, ByVal currentForm As Form)
        Dim formChosen As Form
        Select Case intForm
            Case Forms.REGISTRATION
                formChosen = frmRegistration
            Case Forms.LOGIN
                formChosen = frmLogin
            Case Forms.CATALOG
                formChosen = frmCatalog
            Case Forms.CHECKOUT
                formChosen = frmCheckout
            Case Forms.ACCOUNT
                formChosen = frmAccount
            Case Forms.ITEM
                formChosen = frmItem
            Case Forms.PAYMENT
                formChosen = frmPayment
            Case Else
                formChosen = frmWelcome
        End Select

        If (currentForm.Equals(frmWelcome) And Not formChosen.Equals(frmWelcome)) Then
            formChosen.ShowDialog()
        ElseIf (Not currentForm.Equals(frmWelcome) And formChosen.Equals(frmWelcome)) Then
            currentForm.Dispose()
        ElseIf (Not formChosen.Equals(currentForm)) Then 'And Not formChosen.Equals(frmWelcome)
            currentForm.Dispose()
            formChosen.ShowDialog()
        Else
            MsgBox("Unable to navigate to a form that is already displayed.", , "Error")
        End If
    End Sub

    Public Sub ReloadForm(ByVal currentForm As Form)
        ' stub
        MsgBox("Reloading the form isn't implemented yet.")
    End Sub

    Public Sub SignOut()
        ' stub
        MsgBox("Signing out isn't implemented yet.")
    End Sub

    Public Sub ExitApplication()
        Const cstrMessage As String = "Are you sure you want to exit the application?"
        Const cstrTitle As String = "Exit?"
        Dim intExitApplicationInput As Integer = MessageBox.Show(cstrMessage, cstrTitle, MessageBoxButtons.YesNo)
        If (intExitApplicationInput = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Public Sub AboutApplication()
        Const cstrMessage As String = "Program Name: Furniture Co. Catalog" & vbCrLf &
                              "Developed By: Shawn Broyles" & vbCrLf &
                              "Purpose: This application provides a user-friendly experience for" & vbCrLf &
                              "purchasing items when they are not in stock at a business location."
        Const cstrTitle As String = "About"
        MsgBox(cstrMessage, , cstrTitle)
    End Sub

    Public Sub PrintForm(ByRef pfObject As Object)
        ' When the PrintForm subroutine is invoked, a print preview appears
        pfObject.PrintAction = Printing.PrintAction.PrintToPreview
        pfObject.Print()
    End Sub
End Module
