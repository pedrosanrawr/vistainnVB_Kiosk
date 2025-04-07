Public Class startPage
    Private Sub bookNowButton_Click(sender As Object, e As EventArgs) Handles bookNowButton.Click
        basePage.loadForm(New selectRoom())
    End Sub
End Class