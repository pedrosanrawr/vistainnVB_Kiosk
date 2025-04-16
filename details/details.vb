Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class details
    Private WithEvents inCalendar As New MonthCalendar()
    Private WithEvents outCalendar As New MonthCalendar()
    Dim database As New database()

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inCalendar.Visible = False
        inCalendar.MaxSelectionCount = 1
        inCalendar.ShowTodayCircle = True
        inCalendar.ShowWeekNumbers = False
        inCalendar.MinDate = Date.Today
        AddHandler inCalendar.DateSelected, AddressOf inCalendar_DateSelected
        Me.Controls.Add(inCalendar)

        outCalendar.Visible = False
        outCalendar.MaxSelectionCount = 1
        outCalendar.ShowTodayCircle = True
        outCalendar.ShowWeekNumbers = False
        outCalendar.MinDate = Date.Today.AddDays(1)
        AddHandler outCalendar.DateSelected, AddressOf outCalendar_DateSelected
        Me.Controls.Add(outCalendar)

        LoadPaxOptionsBasedOnCategory()
    End Sub


    Private Sub inDatePickerButton_Click(sender As Object, e As EventArgs) Handles inDatePickerButton.Click
        inCalendar.Location = New Point(inDatePickerButton.Left, inDatePickerButton.Bottom)
        inCalendar.Visible = Not inCalendar.Visible
        inCalendar.BringToFront()
    End Sub

    Private Sub inCalendar_DateSelected(sender As Object, e As DateRangeEventArgs)
        inDatePickerButton.Text = e.Start.ToString("dd MMM yyyy")
        inCalendar.Visible = False
    End Sub

    Private Sub outDateTimePicker_Click(sender As Object, e As EventArgs) Handles outDatePickerButton.Click
        outCalendar.Location = New Point(outDatePickerButton.Left, outDatePickerButton.Bottom)
        outCalendar.Visible = Not outCalendar.Visible
        outCalendar.BringToFront()
    End Sub

    Private Sub outCalendar_DateSelected(sender As Object, e As DateRangeEventArgs)
        outDatePickerButton.Text = e.Start.ToString("dd MMM yyyy")
        outCalendar.Visible = False
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        basePage.loadForm(New startPage)
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        basePage.loadForm(extras)
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If ValidateFields() Then
            Dim checkInDate As Date = Date.Parse(inDatePickerButton.Text)
            Dim checkOutDate As Date = Date.Parse(outDatePickerButton.Text)

            If ValidateDateTimeLogic() AndAlso IsBookingConflict(checkInDate, checkOutDate) Then
                DetailsInformation.FirstName = firstNameTextBox.Text
                DetailsInformation.LastName = lastNameTextBox.Text
                DetailsInformation.Email = emailTextBox.Text
                DetailsInformation.PhoneNo = phoneNoTextBox.Text
                DetailsInformation.Pax = Integer.Parse(paxComboBox.Text)
                DetailsInformation.CheckInDate = checkInDate
                DetailsInformation.CheckOutDate = checkOutDate
                DetailsInformation.InTime = inTimeComboBox.Text
                DetailsInformation.OutTime = outTimeComboBox.Text

                basePage.loadForm(reviewAndProceed)
            End If
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(firstNameTextBox.Text) OrElse
       String.IsNullOrWhiteSpace(lastNameTextBox.Text) OrElse
       String.IsNullOrWhiteSpace(emailTextBox.Text) OrElse
       String.IsNullOrWhiteSpace(paxComboBox.Text) OrElse
       String.IsNullOrWhiteSpace(inTimeComboBox.Text) OrElse
       String.IsNullOrWhiteSpace(outTimeComboBox.Text) OrElse
       String.IsNullOrWhiteSpace(inDatePickerButton.Text) OrElse
       String.IsNullOrWhiteSpace(outDatePickerButton.Text) OrElse
       String.IsNullOrWhiteSpace(phoneNoTextBox.Text) Then

            MessageBox.Show("Please fill in all the required fields.")
            Return False
        End If

        Dim nameRegex As New Regex("^[A-Za-z\s]+$")
        If Not nameRegex.IsMatch(firstNameTextBox.Text) Then
            MessageBox.Show("First name must contain only letters.")
            Return False
        End If
        If Not nameRegex.IsMatch(lastNameTextBox.Text) Then
            MessageBox.Show("Last name must contain only letters.")
            Return False
        End If

        Dim emailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If Not emailRegex.IsMatch(emailTextBox.Text) Then
            MessageBox.Show("Please enter a valid email address.")
            Return False
        End If

        Dim phoneRegex As New Regex("^[0-9]+$")
        If Not phoneRegex.IsMatch(phoneNoTextBox.Text) Then
            MessageBox.Show("Phone number must contain only numbers.")
            Return False
        End If

        Return True
    End Function

    Private Function ValidateDateTimeLogic() As Boolean
        Dim checkInDate As Date = Date.Parse(inDatePickerButton.Text)
        Dim checkOutDate As Date = Date.Parse(outDatePickerButton.Text)

        If checkInDate >= checkOutDate Then
            MessageBox.Show("Check-in date must be before check-out date.")
            Return False
        End If

        Return True
    End Function

    Private Function IsBookingConflict(checkIn As Date, checkOut As Date) As Boolean
        Dim query As String = "
            SELECT COUNT(*) FROM bookings b
            INNER JOIN payments p ON b.bId = p.bId
            WHERE b.bRName = @roomName
            AND b.bRoomNo = @roomNo
            AND p.pStatus = 'Paid'
            AND (
                (@inDate BETWEEN b.bCheckInDate AND b.bCheckOutDate)
                OR
                (@outDate BETWEEN b.bCheckInDate AND b.bCheckOutDate)
                OR
                (b.bCheckInDate BETWEEN @inDate AND @outDate)
            )
        "

        Using conn As New SqlConnection(database.connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@roomName", SelectedRooms.RoomName)
                cmd.Parameters.AddWithValue("@roomNo", SelectedRooms.RoomNumber)
                cmd.Parameters.AddWithValue("@inDate", checkIn)
                cmd.Parameters.AddWithValue("@outDate", checkOut)

                conn.Open()
                Dim count As Integer = CInt(cmd.ExecuteScalar())
                If count > 0 Then
                    MessageBox.Show("The dates you selected for " & SelectedRooms.RoomName & " with a room no. of " & SelectedRooms.RoomNumber & " are already booked. Please choose a different date range.")

                    Return False
                End If
            End Using
        End Using

        Return True
    End Function

    Private Sub LoadPaxOptionsBasedOnCategory()
        paxComboBox.Items.Clear()

        Dim maxPax As Integer = 1

        Select Case SelectedRooms.RoomCategory.ToLower()
            Case "single"
                maxPax = 1
            Case "duo"
                maxPax = 2
            Case "family"
                maxPax = 6
            Case "team"
                maxPax = 10
        End Select

        For i As Integer = 1 To maxPax
            paxComboBox.Items.Add(i.ToString())
        Next

        paxComboBox.SelectedIndex = 0
    End Sub
End Class

Public Class DetailsInformation
    Public Shared Property FirstName As String
    Public Shared Property LastName As String
    Public Shared Property Email As String
    Public Shared Property PhoneNo As String
    Public Shared Property Pax As Integer
    Public Shared Property CheckInDate As Date
    Public Shared Property CheckOutDate As Date
    Public Shared Property InTime As String
    Public Shared Property OutTime As String
End Class
