Public Class selectRoom
    Private selectedButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private radioButtons As New List(Of Guna.UI2.WinForms.Guna2Button)

    Private Sub selectRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radioButtons.Add(singleButton)
        radioButtons.Add(doubleButton)
        radioButtons.Add(familyButton)
        radioButtons.Add(S)

        toolTip.SetToolTip(iToottip, "Hourly Rate: $300.00")
    End Sub

    Private Sub SelectButton(selected As Guna.UI2.WinForms.Guna2Button)
        If selectedButton IsNot Nothing Then
            selectedButton.FillColor = Color.Empty
            selectedButton.ForeColor = Color.Black
        End If

        selectedButton = selected
        selectedButton.FillColor = Color.Black
        selectedButton.ForeColor = Color.White
    End Sub

    Private Sub singleButton_Click(sender As Object, e As EventArgs) Handles singleButton.Click
        SelectButton(sender)
    End Sub

    Private Sub doubleButton_Click(sender As Object, e As EventArgs) Handles doubleButton.Click
        SelectButton(sender)
    End Sub

    Private Sub familyButton_Click(sender As Object, e As EventArgs) Handles familyButton.Click
        SelectButton(sender)
    End Sub

    Private Sub teamButton_Click(sender As Object, e As EventArgs) Handles S.Click
        SelectButton(sender)
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        basePage.loadForm(extras)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        basePage.loadForm(New startPage())
    End Sub
End Class