Public Class details
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        basePage.loadForm(New startPage)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        basePage.loadForm(extras)
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        basePage.loadForm(reviewAndProceed)
    End Sub
End Class