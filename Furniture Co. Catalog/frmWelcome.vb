' Program:  Furniture Co. Catalog
' Version:  0.1
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
            Case Else ' Forms.WELCOME
                formChosen = Me
        End Select

        If (currentForm.Equals(Me) And Not formChosen.Equals(Me)) Then
            formChosen.ShowDialog()
        ElseIf (Not currentForm.Equals(Me) And formChosen.Equals(Me)) Then
            currentForm.Dispose()
        ElseIf (Not formChosen.Equals(currentForm)) Then 'And Not formChosen.Equals(Me)
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

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PositionFormOnLoad(Me)

    End Sub

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
        AboutApplication()
    End Sub

    Private Sub mnuPrint_Click(sender As Object, e As EventArgs) Handles mnuPrint.Click
        PrintForm(pfPrintForm)
    End Sub
End Class

