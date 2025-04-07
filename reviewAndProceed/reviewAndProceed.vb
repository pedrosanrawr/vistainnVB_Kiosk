Public Class reviewAndProceed
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        basePage.loadForm(New startPage())
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        basePage.loadForm(details)
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        basePage.loadForm(invoice)
    End Sub
End Class