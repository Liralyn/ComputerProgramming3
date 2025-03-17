Imports MySql.Data.MySqlClient
Imports System.Net.Mail ' Import for email validation

Public Class Booking
    Dim connectionString As String = "server=localhost;userid=root;password=;database=visual_basic_ticketing_system"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = TextBox1txt.Text.Trim()
        Dim email As String = TextBox2txt.Text.Trim()
        Dim tickets As Integer = NumericUpDown1txt.Value

        ' Validate email format
        If Not IsValidEmail(email) Then
            MessageBox.Show("Please enter a valid email address.")
            Exit Sub
        End If

        ' Validation for empty fields
        If name = "" Or email = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        ' Validate ticket limits
        If tickets < 1 Or tickets > 10 Then
            MessageBox.Show("You can only purchase between 1 and 10 tickets per transaction.")
            Exit Sub
        End If

        Me.ActiveControl = Nothing

        ' Open Terms & Conditions Form
        Dim termsForm As New TermsAndConditions_Form()
        termsForm.ShowDialog()

        ' If the user did not accept, stop the process
        If Not termsForm.IsAccepted Then
            MessageBox.Show("You must accept the Terms and Conditions to proceed.", "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Database Connection
        Using conn As New MySqlConnection(connectionString)
            conn.Open()

            ' Check total tickets sold
            Dim totalTicketsQuery As String = "SELECT SUM(tickets) FROM Bookings"
            Using cmd As New MySqlCommand(totalTicketsQuery, conn)
                Dim totalTickets As Object = cmd.ExecuteScalar()
                Dim currentTotal As Integer = If(IsDBNull(totalTickets), 0, Convert.ToInt32(totalTickets))

                If (currentTotal + tickets) > 400 Then
                    MessageBox.Show("Total ticket limit of 400 reached. Cannot process this transaction.")
                    Exit Sub
                End If
            End Using

            ' Check if the name already exists with the same email
            Dim checkNameQuery As String = "SELECT id, tickets FROM Bookings WHERE name = @name AND email = @email"
            Using cmd As New MySqlCommand(checkNameQuery, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@email", email)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' If name exists with the same email, update ticket count
                    Dim existingId As Integer = reader.GetInt32(0)
                    reader.Close()

                    Dim updateQuery As String = "UPDATE Bookings SET tickets = tickets + @tickets WHERE id = @id"
                    Using updateCmd As New MySqlCommand(updateQuery, conn)
                        updateCmd.Parameters.AddWithValue("@tickets", tickets)
                        updateCmd.Parameters.AddWithValue("@id", existingId)
                        updateCmd.ExecuteNonQuery()
                    End Using

                Else
                    ' If name does not exist with this email, insert a new record
                    reader.Close()
                    Dim insertQuery As String = "INSERT INTO Bookings (name, email, tickets) VALUES (@name, @email, @tickets)"
                    Using insertCmd As New MySqlCommand(insertQuery, conn)
                        insertCmd.Parameters.AddWithValue("@name", name)
                        insertCmd.Parameters.AddWithValue("@email", email)
                        insertCmd.Parameters.AddWithValue("@tickets", tickets)
                        insertCmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Booking successful!")
                End If
            End Using
        End Using
    End Sub

    ' Function to validate email format using MailAddress class (No Regex)
    Private Function IsValidEmail(email As String) As Boolean
        Try
            Dim mail As New MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2txt_TextChanged(sender As Object, e As EventArgs) Handles TextBox2txt.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
