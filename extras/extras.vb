Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports Guna.UI2.WinForms

Public Class extras
    Private selectedCheckboxes As New List(Of Guna2CustomCheckBox)
    Dim database As New database()

    Private Sub extras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExtras()
    End Sub

    Private Sub LoadExtras()
        itemFlowLayoutPanel.Controls.Clear()

        Dim query As String = "SELECT * FROM itemExtras WHERE ixQuantity > 1"
        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim itemPanel As New Panel()
                        itemPanel.Width = 905
                        itemPanel.Height = 70
                        itemPanel.Location = New Point(3, 3)

                        Dim selectCheckBox As New Guna2CustomCheckBox()
                        With selectCheckBox
                            .Tag = itemPanel
                            .Width = 30
                            .Height = 30
                            .Location = New Point(66, 16)

                            .CheckedState.FillColor = Color.Black
                            .CheckedState.BorderColor = Color.Black
                            .CheckedState.BorderRadius = 2
                            .CheckedState.BorderThickness = 3
                            .CheckedState.BorderColor = Color.Black

                            .UncheckedState.FillColor = Color.Transparent
                            .UncheckedState.BorderColor = Color.Black
                            .UncheckedState.BorderRadius = 2
                            .UncheckedState.BorderThickness = 3
                            .UncheckedState.BorderColor = Color.Black
                        End With
                        AddHandler selectCheckBox.CheckedChanged, AddressOf CheckBoxChanged

                        Dim extrasName As New Label()
                        extrasName.Text = reader("ixExtras").ToString()
                        extrasName.Font = New Font("Lato", 24, FontStyle.Regular, GraphicsUnit.Pixel)
                        extrasName.Location = New Point(229, 16)
                        extrasName.Size = New Size(195, 34)
                        extrasName.TextAlign = ContentAlignment.MiddleCenter

                        Dim extrasPrice As New Label()
                        extrasPrice.Text = "₱" & Convert.ToDecimal(reader("ixPrice")).ToString("N2")
                        extrasPrice.Font = New Font("Lato", 24, FontStyle.Regular, GraphicsUnit.Pixel)
                        extrasPrice.Location = New Point(481, 16)
                        extrasPrice.Size = New Size(192, 34)
                        extrasPrice.TextAlign = ContentAlignment.MiddleCenter

                        Dim qtyLabel As New Label()
                        qtyLabel.Text = "0"
                        qtyLabel.Name = "qtyLabel"
                        qtyLabel.Font = New Font("Lato", 24, FontStyle.Regular, GraphicsUnit.Pixel)
                        qtyLabel.Location = New Point(773, 12)
                        qtyLabel.Size = New Size(56, 34)
                        qtyLabel.TextAlign = ContentAlignment.MiddleCenter

                        Dim decrementPic As New Guna.UI2.WinForms.Guna2PictureBox()
                        decrementPic.Image = My.Resources.decrementQtyButton
                        decrementPic.SizeMode = PictureBoxSizeMode.StretchImage
                        decrementPic.Cursor = Cursors.Hand
                        decrementPic.Width = 30
                        decrementPic.Height = 30
                        decrementPic.Location = New Point(737, 16)

                        Dim incrementPic As New Guna.UI2.WinForms.Guna2PictureBox()
                        incrementPic.Image = My.Resources.incrementQtyButton
                        incrementPic.SizeMode = PictureBoxSizeMode.StretchImage
                        incrementPic.Cursor = Cursors.Hand
                        incrementPic.Width = 30
                        incrementPic.Height = 30
                        incrementPic.Location = New Point(835, 16)

                        decrementPic.Tag = qtyLabel
                        incrementPic.Tag = qtyLabel

                        AddHandler decrementPic.Click, AddressOf DecrementQty
                        AddHandler incrementPic.Click, AddressOf IncrementQty

                        itemPanel.Controls.Add(selectCheckBox)
                        itemPanel.Controls.Add(extrasName)
                        itemPanel.Controls.Add(extrasPrice)
                        itemPanel.Controls.Add(decrementPic)
                        itemPanel.Controls.Add(qtyLabel)
                        itemPanel.Controls.Add(incrementPic)

                        itemFlowLayoutPanel.Controls.Add(itemPanel)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private isProgrammaticChange As Boolean = False

    Private Sub CheckBoxChanged(sender As Object, e As EventArgs)
        Dim cb As Guna2CustomCheckBox = CType(sender, Guna2CustomCheckBox)
        If isProgrammaticChange Then Return

        Dim itemPanel As Panel = CType(cb.Tag, Panel)
        Dim nameLabel As Label = itemPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Location = New Point(229, 16))
        Dim priceLabel As Label = itemPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Location = New Point(481, 16))
        Dim qtyLabel As Label = itemPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Name = "qtyLabel")

        If cb.Checked Then
            selectedCheckboxes.Add(cb)

            Dim item As New ExtraItem With {
            .ItemName = nameLabel.Text,
            .ItemPrice = Decimal.Parse(priceLabel.Text.Replace("₱", "")),
            .ItemQuantity = Integer.Parse(qtyLabel.Text)
        }

            SelectedExtras.ItemsSelected.Add(item)
        Else
            selectedCheckboxes.Remove(cb)
            SelectedExtras.ItemsSelected.RemoveAll(Function(x) x.ItemName = nameLabel.Text)

            If qtyLabel IsNot Nothing Then
                qtyLabel.Text = "0"
            End If
        End If
    End Sub

    Private Sub IncrementQty(sender As Object, e As EventArgs)
        Dim pic As Guna2PictureBox = CType(sender, Guna2PictureBox)
        Dim qtyLabel As Label = CType(pic.Tag, Label)
        Dim itemPanel As Panel = CType(qtyLabel.Parent, Panel)

        Dim checkbox As Guna2CustomCheckBox = itemPanel.Controls.OfType(Of Guna2CustomCheckBox)().FirstOrDefault()

        If checkbox IsNot Nothing AndAlso checkbox.Checked Then
            Dim currentQty As Integer = Integer.Parse(qtyLabel.Text)
            qtyLabel.Text = (currentQty + 1).ToString()

            Dim nameLabel As Label = itemPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Location = New Point(229, 16))
            Dim selected = SelectedExtras.ItemsSelected.FirstOrDefault(Function(x) x.ItemName = nameLabel.Text)
            If selected IsNot Nothing Then
                selected.ItemQuantity = currentQty + 1
            End If
        Else
            MessageBox.Show("Please select the item first before adjusting quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub DecrementQty(sender As Object, e As EventArgs)
        Dim pic As Guna2PictureBox = CType(sender, Guna2PictureBox)
        Dim qtyLabel As Label = CType(pic.Tag, Label)
        Dim itemPanel As Panel = CType(qtyLabel.Parent, Panel)

        Dim checkbox As Guna2CustomCheckBox = itemPanel.Controls.OfType(Of Guna2CustomCheckBox)().FirstOrDefault()

        If checkbox IsNot Nothing AndAlso checkbox.Checked Then
            Dim currentQty As Integer = Integer.Parse(qtyLabel.Text)
            If currentQty > 0 Then
                qtyLabel.Text = (currentQty - 1).ToString()

                Dim nameLabel As Label = itemPanel.Controls.OfType(Of Label)().FirstOrDefault(Function(l) l.Location = New Point(229, 16))
                Dim selected = SelectedExtras.ItemsSelected.FirstOrDefault(Function(x) x.ItemName = nameLabel.Text)
                If selected IsNot Nothing Then
                    selected.ItemQuantity = currentQty - 1
                End If
            End If
        Else
            MessageBox.Show("Please select the item first before adjusting quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles backButton.Click
        basePage.loadForm(New selectRoom())
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel the booking process?",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            basePage.loadForm(New startPage())
        End If
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        Dim hasZeroQty = SelectedExtras.ItemsSelected.Any(Function(item) item.ItemQuantity = 0)

        If hasZeroQty Then
            MessageBox.Show("Please make sure all selected items have a quantity greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        basePage.loadForm(New details())
    End Sub
End Class

Public Class ExtraItem
    Public Property ItemName As String
    Public Property ItemPrice As Decimal
    Public Property ItemQuantity As Integer
End Class


Public Class SelectedExtras
    Public Shared Property ItemsSelected As New List(Of ExtraItem)
End Class