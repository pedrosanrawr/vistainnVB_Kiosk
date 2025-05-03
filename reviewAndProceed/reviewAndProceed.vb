Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class reviewAndProceed
    Dim database As New database()

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel the booking process?",
                                                     "Confirm Cancel",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            basePage.loadForm(New startPage())
        End If
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        basePage.loadForm(New details())
    End Sub

    Private Sub bookButton_Click(sender As Object, e As EventArgs) Handles bookButton.Click
        Dim referenceNo As String = GenerateReferenceNo()
        Dim bookingId As Integer = 0
        Dim extrasTotal As Decimal = SelectedExtras.ItemsSelected.Sum(Function(i) i.ItemPrice * i.ItemQuantity)
        Dim hourlyRate As Decimal = 300D
        Dim vatRate As Decimal = 0.08D
        Dim roomPrice As Decimal = SelectedRooms.RoomPrice
        Dim subtotal As Decimal = roomPrice + hourlyRate + extrasTotal
        Dim vatAmount As Decimal = subtotal * vatRate
        Dim totalPrice As Decimal = subtotal + vatAmount

        Dim daysAhead As Integer = (DetailsInformation.CheckInDate - Date.Now.Date).Days
        Dim downPayment As Decimal = If(daysAhead >= 14, totalPrice * 0.5D, 0D)
        Dim amountDue As Decimal = totalPrice

        Using conn As New SqlConnection(database.connectionString)
            conn.Open()
            Dim tran As SqlTransaction = conn.BeginTransaction()

            Try
                Dim insertBooking As String = "
            INSERT INTO bookings 
            (bFname, bLname, bEmail, bPhoneNo, bRoomNo, bRName, bPax, bCheckInDate, bCheckInTime, bCheckOutDate, bCheckOutTime, bReferenceNo)
            OUTPUT INSERTED.bId
            VALUES 
            (@fname, @lname, @email, @phone, @roomNo, @roomName, @pax, @checkInDate, @checkInTime, @checkOutDate, @checkOutTime, @refNo)"

                Using cmd As New SqlCommand(insertBooking, conn, tran)
                    cmd.Parameters.AddWithValue("@fname", DetailsInformation.FirstName)
                    cmd.Parameters.AddWithValue("@lname", DetailsInformation.LastName)
                    cmd.Parameters.AddWithValue("@email", DetailsInformation.Email)
                    cmd.Parameters.AddWithValue("@phone", DetailsInformation.PhoneNo)
                    cmd.Parameters.AddWithValue("@roomNo", SelectedRooms.RoomNumber)
                    cmd.Parameters.AddWithValue("@roomName", SelectedRooms.RoomName)
                    cmd.Parameters.AddWithValue("@pax", DetailsInformation.Pax)
                    cmd.Parameters.AddWithValue("@checkInDate", DetailsInformation.CheckInDate)
                    cmd.Parameters.AddWithValue("@checkInTime", DetailsInformation.InTime)
                    cmd.Parameters.AddWithValue("@checkOutDate", DetailsInformation.CheckOutDate)
                    cmd.Parameters.AddWithValue("@checkOutTime", DetailsInformation.OutTime)
                    cmd.Parameters.AddWithValue("@refNo", referenceNo)

                    bookingId = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                For Each item In SelectedExtras.ItemsSelected
                    Dim insertExtras As String = "
                    INSERT INTO orderExtras (bId, oxExtras, oxQuantity) 
                    VALUES (@bId, @extraName, @qty)"
                    Using cmd As New SqlCommand(insertExtras, conn, tran)
                        cmd.Parameters.AddWithValue("@bId", bookingId)
                        cmd.Parameters.AddWithValue("@extraName", item.ItemName)
                        cmd.Parameters.AddWithValue("@qty", item.ItemQuantity)
                        cmd.ExecuteNonQuery()
                    End Using

                    Dim updateStock As String = "
                    UPDATE itemExtras 
                    SET ixQuantity = ixQuantity - @qty 
                    WHERE ixExtras = @extraName AND ixQuantity >= @qty"

                    Using updateCmd As New SqlCommand(updateStock, conn, tran)
                        updateCmd.Parameters.AddWithValue("@qty", item.ItemQuantity)
                        updateCmd.Parameters.AddWithValue("@extraName", item.ItemName)
                        updateCmd.ExecuteNonQuery()
                    End Using

                Next

                Dim insertPayment As String = "
                INSERT INTO payments 
                (bId, pPaymentMethod, pTotalPrice, pDownPayment, pAmountDue, pStatus, pOxPrice) 
                VALUES 
                (@bId, @method, @totalPrice, @downPayment, @amountDue, 'Pending', @extrasTotal)"

                Using cmd As New SqlCommand(insertPayment, conn, tran)
                    cmd.Parameters.AddWithValue("@bId", bookingId)
                    cmd.Parameters.AddWithValue("@method", SelectedRooms.PaymentOption)
                    cmd.Parameters.AddWithValue("@totalPrice", totalPrice)
                    cmd.Parameters.AddWithValue("@downPayment", downPayment)
                    cmd.Parameters.AddWithValue("@amountDue", amountDue)
                    cmd.Parameters.AddWithValue("@extrasTotal", extrasTotal)
                    cmd.ExecuteNonQuery()
                End Using

                tran.Commit()

                LastBookingInfo.ReferenceNo = referenceNo
                LastBookingInfo.TotalPrice = amountDue
                LastBookingInfo.VATAmount = vatAmount

                SendBookingEmail(DetailsInformation.Email, DetailsInformation.FirstName, referenceNo, amountDue, vatAmount, downPayment)

                MessageBox.Show($"Booking successful!" & vbCrLf & $"Reference No: {referenceNo}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                basePage.loadForm(New invoice())

            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show("Booking failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub reviewAndProceed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nameLabel.Text = $"{DetailsInformation.FirstName} {DetailsInformation.LastName}"
        emailLabel.Text = DetailsInformation.Email
        phoneNoLabel.Text = DetailsInformation.PhoneNo
        checkInLabel.Text = $"{DetailsInformation.CheckInDate:MMMM dd, yyyy} {DetailsInformation.InTime}"
        checkOutLabel.Text = $"{DetailsInformation.CheckOutDate:MMMM dd, yyyy} {DetailsInformation.OutTime}"
        paxLabel.Text = DetailsInformation.Pax.ToString()

        roomLabel.Text = SelectedRooms.RoomName
        roomNoLabel.Text = SelectedRooms.RoomNumber
        paymentOptionLabel.Text = SelectedRooms.PaymentOption

        extrasLabel.Text = ""
        Dim extrasTotal As Decimal = 0D
        For Each item In SelectedExtras.ItemsSelected
            extrasLabel.Text &= $"{item.ItemName} - {item.ItemQuantity}" & Environment.NewLine
            extrasTotal += item.ItemPrice * item.ItemQuantity
        Next

        Dim hourlyRate As Decimal = 300D
        Dim baseRoomPrice As Decimal = SelectedRooms.RoomPrice
        Dim vatRate As Decimal = 0.08D
        Dim subtotal As Decimal = baseRoomPrice + hourlyRate + extrasTotal
        Dim vatAmount As Decimal = subtotal * vatRate
        Dim totalBeforeDiscount As Decimal = subtotal + vatAmount

        Dim daysAhead As Integer = (DetailsInformation.CheckInDate - Date.Now.Date).Days
        Dim downpayment As Decimal = 0D
        If daysAhead >= 14 Then
            downpayment = totalBeforeDiscount * 0.5D
        End If

        downPaymentLabel.Text = "₱" & downpayment.ToString("N2")
        totalPriceLabel.Text = "₱" & totalBeforeDiscount.ToString("N2")

        Dim tooltipText As String = ""
        If daysAhead >= 14 Then
            tooltipText = $"Room Price: ₱{baseRoomPrice:N2}" & Environment.NewLine &
                  $"Hourly Rate: ₱{hourlyRate:N2}" & Environment.NewLine &
                  $"Extras Total: ₱{extrasTotal:N2}" & Environment.NewLine &
                  $"Subtotal: ₱{subtotal:N2}" & Environment.NewLine &
                  $"VAT (8%): ₱{vatAmount:N2}" & Environment.NewLine &
                  $"Total: ₱{totalBeforeDiscount:N2}" & Environment.NewLine &
                  $"➤ 50% Downpayment: ₱{downpayment:N2}"
        Else
            tooltipText = $"Room Price: ₱{baseRoomPrice:N2}" & Environment.NewLine &
                  $"Hourly Rate: ₱{hourlyRate:N2}" & Environment.NewLine &
                  $"Extras Total: ₱{extrasTotal:N2}" & Environment.NewLine &
                  $"Subtotal: ₱{subtotal:N2}" & Environment.NewLine &
                  $"VAT (8%): ₱{vatAmount:N2}" & Environment.NewLine &
                  $"➤ Total Price: ₱{totalBeforeDiscount:N2}"
        End If

        ToolTip.SetToolTip(iTooltip, tooltipText)
    End Sub

    Private Function GenerateReferenceNo() As String
        Return "VRN" & DateTime.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub SendBookingEmail(email As String, name As String, referenceNo As String, totalPrice As Decimal, vatAmount As Decimal, downpayment As Decimal)
        Try
            Dim smtpClient As New Net.Mail.SmtpClient("smtp.gmail.com")
            smtpClient.Port = 587
            smtpClient.Credentials = New Net.NetworkCredential("vistainnmanager0@gmail.com", "vder sozj geky cnzr")
            smtpClient.EnableSsl = True

            Dim message As New Net.Mail.MailMessage()
            message.From = New Net.Mail.MailAddress("vistainnmanager0@gmail.com", "VistaInn Hotel")
            message.To.Add(email)
            message.Subject = "Your Booking Confirmation - VistaInn Hotel"

            Dim extrasText As String = If(SelectedExtras.ItemsSelected.Count > 0,
            $"Extras: {String.Join(", ", SelectedExtras.ItemsSelected.Select(Function(i) $"{i.ItemName} x{i.ItemQuantity}"))}" & vbCrLf,
            "")

            Dim bodyText As String = $"Dear {name}," & vbCrLf & vbCrLf &
                                 $"Thank you for booking with VistaInn Hotel!" & vbCrLf & vbCrLf &
                                 $"Here are your booking details:" & vbCrLf &
                                 $"Reference No: {referenceNo}" & vbCrLf &
                                 $"Room: {SelectedRooms.RoomName} (#{SelectedRooms.RoomNumber})" & vbCrLf &
                                 $"Guests: {DetailsInformation.Pax}" & vbCrLf &
                                 $"Check-in: {DetailsInformation.CheckInDate:MMMM dd, yyyy} at {DetailsInformation.InTime}" & vbCrLf &
                                 $"Check-out: {DetailsInformation.CheckOutDate:MMMM dd, yyyy} at {DetailsInformation.OutTime}" & vbCrLf &
                                 extrasText &
                                 $"VAT (8%): ₱{vatAmount:N2}" & vbCrLf &
                                 $"Total Price: ₱{totalPrice:N2}" & vbCrLf

            If downpayment > 0 Then
                bodyText &= $"Down Payment Paid: ₱{downpayment:N2}" & vbCrLf &
                        $"Amount Due Upon Arrival: ₱{totalPrice - downpayment:N2}" & vbCrLf & vbCrLf &
                        $"Please settle the remaining balance at the front desk during check-in." & vbCrLf
            Else
                bodyText &= vbCrLf & $"You may complete your payment via: {SelectedRooms.PaymentOption}" & vbCrLf
            End If

            bodyText &= vbCrLf & $"If you have any questions, feel free to reach out to us." & vbCrLf & vbCrLf &
                     $"Warm regards," & vbCrLf &
                     $"VistaInn Hotel"

            message.Body = bodyText
            smtpClient.Send(message)

        Catch ex As Exception
            MessageBox.Show("Failed to send confirmation email: " & ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class

Public Class LastBookingInfo
    Public Shared Property ReferenceNo As String
    Public Shared Property TotalPrice As Decimal
    Public Shared Property VATAmount As Decimal
End Class
