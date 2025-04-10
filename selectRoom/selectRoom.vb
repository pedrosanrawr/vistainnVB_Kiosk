Imports System.Data.SqlClient

Public Class selectRoom
    Private selectedPanel As Guna.UI2.WinForms.Guna2Panel = Nothing
    Private selectedButton As Guna.UI2.WinForms.Guna2Button = Nothing
    Private radioButtons As New List(Of Guna.UI2.WinForms.Guna2Button)
    Private selectedCategory As String = ""
    Private selectedRoomName_ As String


    Private Sub selectRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toolTip.SetToolTip(iToottip, "Hourly Rate: ₱300.00")
        radioButtons.Add(singleButton)
        radioButtons.Add(doubleButton)
        radioButtons.Add(familyButton)
        radioButtons.Add(teamButton)

        selectedCategory = "Single"
        selectedRoomName_ = GetFirstRoomName(selectedCategory)
        SelectButton(singleButton)
        LoadRooms()
    End Sub

    Private Sub SelectPicture(selected As Guna.UI2.WinForms.Guna2Panel)
        If selectedPanel IsNot Nothing Then
            selectedPanel.FillColor = Color.Transparent
            selectedPanel.BorderRadius = 5
        End If

        selectedPanel = selected
        selectedPanel.FillColor = Color.FromArgb(206, 204, 204)
        selectedPanel.BorderRadius = 5

        For Each control As Control In selected.Controls
            If TypeOf control Is Label Then
                Dim label As Label = CType(control, Label)
                If label.Font.Style = FontStyle.Regular Then
                    selectedRoomName_ = label.Text
                End If
            End If
        Next

        For Each control As Control In selected.Controls
            If TypeOf control Is Guna.UI2.WinForms.Guna2PictureBox Then
                Dim selectedRoomPicture As Guna.UI2.WinForms.Guna2PictureBox = CType(control, Guna.UI2.WinForms.Guna2PictureBox)
                roomPhotoPictureBox.Image = selectedRoomPicture.Image
                roomPhotoPictureBox.SizeMode = ImageLayout.Tile
                Exit For
            End If
        Next
    End Sub

    Public Sub LoadRooms()
        selectedRoomFlowLayoutPanel.Controls.Clear()

        Dim db As New database()
        Dim con As New SqlConnection(db.connectionString)

        Dim query As String = "SELECT rName, rCategory, MAX(rPrice) as rPrice, MAX(rImage) as rImage FROM rooms "

        If Not String.IsNullOrEmpty(selectedCategory) Then
            query &= "WHERE rCategory = @category "
        End If

        query &= "GROUP BY rName, rCategory"

        Dim cmd As New SqlCommand(query, con)
        If Not String.IsNullOrEmpty(selectedCategory) Then
            cmd.Parameters.AddWithValue("@category", selectedCategory)
        End If

        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            Dim roomPanels As New List(Of Guna.UI2.WinForms.Guna2Panel)

            While reader.Read()
                Dim roomName As String = reader("rName").ToString()
                Dim roomPrice As Double = Convert.ToDouble(reader("rPrice"))

                Dim roomPanel As New Guna.UI2.WinForms.Guna2Panel()
                roomPanel.Width = 171
                roomPanel.Height = 247
                roomPanel.BorderRadius = 5
                roomPanel.Margin = New Padding(5)
                roomPanel.BackColor = Color.Transparent

                Dim selectedRoomPicture As New Guna.UI2.WinForms.Guna2PictureBox()
                selectedRoomPicture.SizeMode = PictureBoxSizeMode.StretchImage
                selectedRoomPicture.Width = 171
                selectedRoomPicture.Height = 180
                selectedRoomPicture.BorderRadius = 5
                selectedRoomPicture.ShadowDecoration.Enabled = True
                selectedRoomPicture.ShadowDecoration.BorderRadius = 5
                selectedRoomPicture.ShadowDecoration.Depth = 30
                selectedRoomPicture.ShadowDecoration.Shadow = New Padding(0, 0, 0, 4)
                selectedRoomPicture.Location = New Point(0, 0)

                AddHandler selectedRoomPicture.Click, Sub(sender As Object, e As EventArgs)
                                                          SelectPicture(roomPanel)
                                                      End Sub

                If Not IsDBNull(reader("rImage")) Then
                    Dim imageBytes As Byte() = CType(reader("rImage"), Byte())
                    If imageBytes.Length > 0 Then
                        Using ms As New IO.MemoryStream(imageBytes)
                            selectedRoomPicture.Image = Image.FromStream(ms)
                        End Using
                    End If
                End If

                Dim selectedRoomName As New Label()
                selectedRoomName.Text = roomName
                selectedRoomName.AutoSize = True
                selectedRoomName.Font = New Font("Lato", 20.25, GraphicsUnit.Pixel)
                selectedRoomName.Location = New Point(0, 186)
                selectedRoomName.BackColor = Color.Transparent

                Dim selectedRoomPrice As New Label()
                selectedRoomPrice.Text = "₱" & roomPrice.ToString("N2")
                selectedRoomPrice.AutoSize = True
                selectedRoomPrice.Font = New Font("Lato", 20.25, FontStyle.Bold, GraphicsUnit.Pixel)
                selectedRoomPrice.Location = New Point(0, 214)
                selectedRoomPrice.BackColor = Color.Transparent

                roomPanel.Controls.Add(selectedRoomPicture)
                roomPanel.Controls.Add(selectedRoomName)
                roomPanel.Controls.Add(selectedRoomPrice)

                selectedRoomFlowLayoutPanel.Controls.Add(roomPanel)

                roomPanels.Add(roomPanel)
            End While
            reader.Close()

            Dim foundMatch As Boolean = False
            For Each panel In roomPanels
                For Each ctrl As Control In panel.Controls
                    If TypeOf ctrl Is Label Then
                        Dim lbl As Label = CType(ctrl, Label)
                        If lbl.Text = selectedRoomName_ Then
                            SelectPicture(panel)
                            foundMatch = True
                            Exit For
                        End If
                    End If
                Next
                If foundMatch Then Exit For
            Next

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
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

    Private Function GetFirstRoomName(category As String) As String
        Dim db As New database()
        Using con As New SqlConnection(db.connectionString)
            Dim query As String = "SELECT TOP 1 rName FROM rooms WHERE rCategory = @category ORDER BY rName"
            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@category", category)

            Try
                con.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Return reader("rName").ToString()
                End If
            Catch ex As Exception
                MessageBox.Show("Error getting first room: " & ex.Message)
            End Try
        End Using
        Return ""
    End Function


    Private Sub singleButton_Click(sender As Object, e As EventArgs) Handles singleButton.Click
        SelectButton(sender)
        selectedCategory = "Single"
        LoadRooms()
    End Sub

    Private Sub doubleButton_Click(sender As Object, e As EventArgs) Handles doubleButton.Click
        SelectButton(sender)
        selectedCategory = "Double"
        LoadRooms()
    End Sub

    Private Sub familyButton_Click(sender As Object, e As EventArgs) Handles familyButton.Click
        SelectButton(sender)
        selectedCategory = "Family"
        LoadRooms()
    End Sub

    Private Sub teamButton_Click(sender As Object, e As EventArgs) Handles teamButton.Click
        SelectButton(sender)
        selectedCategory = "Team"
        LoadRooms()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        basePage.loadForm(extras)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        basePage.loadForm(New startPage())
    End Sub
End Class