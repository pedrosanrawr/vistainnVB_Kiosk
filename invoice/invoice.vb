Public Class invoice
    Private countdown As Integer = 30

    Private Sub okayButton_Click(sender As Object, e As EventArgs) Handles okayButton.Click
        basePage.loadForm(New startPage())
        SystemReset.ResetSystem()
        timer.Stop()
    End Sub

    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        informationLabel.Text = $"Name: {DetailsInformation.FirstName} {DetailsInformation.LastName}" & vbCrLf &
                                $"Phone: {DetailsInformation.PhoneNo}" & vbCrLf &
                                $"Email: {DetailsInformation.Email}"

        referenceNoLabel.Text = LastBookingInfo.ReferenceNo

        dateLabel.Text = DateTime.Now.ToString("MMMM dd, yyyy")

        vatLabel.Text = "₱" & LastBookingInfo.VATAmount.ToString("N2")

        totalPriceLabel.Text = "₱" & LastBookingInfo.TotalPrice.ToString("N2")

        timer.Interval = 1000
        timer.Start()
        redirectLabel.Text = $"Redirecting to the start page in {countdown} seconds..."
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        countdown -= 1
        redirectLabel.Text = $"Redirecting to the start page in {countdown} seconds..."

        If countdown <= 0 Then
            timer.Stop()
            SystemReset.ResetSystem()
            basePage.loadForm(New startPage())
        End If
    End Sub
End Class

Public Module SystemReset
    Public Sub ResetSystem()
        DetailsInformation.FirstName = ""
        DetailsInformation.LastName = ""
        DetailsInformation.PhoneNo = ""
        DetailsInformation.Email = ""

        LastBookingInfo.ReferenceNo = ""
        LastBookingInfo.VATAmount = 0
        LastBookingInfo.TotalPrice = 0
        SelectedExtras.ItemsSelected.Clear()
    End Sub
End Module