Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class TermsAndConditions_Form
    Public IsAccepted As Boolean = False ' Track if user accepts terms

    Private Sub TermsAndConditions_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Example Terms and Conditions (You can replace this with actual text)
        TextBox_Terms.Text = "Terms and Conditions:" & Environment.NewLine &
            "1. Tickets are non-refundable." & Environment.NewLine &
            "2. A maximum of 10 tickets per transaction is allowed." & Environment.NewLine &
            "3. Each customer must provide a valid email address." & Environment.NewLine &
            "4. The system will store your email for record-keeping." & Environment.NewLine &
            "5. Total ticket sales are limited to 400." & Environment.NewLine &
            "6. By proceeding, you agree to these terms."

        TextBox_Terms.ReadOnly = True
        TextBox_Terms.ScrollBars = ScrollBars.Vertical
    End Sub

    ' Accept Button
    Private Sub Button_Accept_Click(sender As Object, e As EventArgs) Handles Button_Accept.Click
        If CheckBox_Agree.Checked Then
            IsAccepted = True
            Me.Close()
        Else
            MessageBox.Show("You must agree to the Terms & Conditions to proceed.", "Agreement Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Cancel Button
    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        IsAccepted = False
        Me.Close()
    End Sub

    Private Sub TextBox_Terms_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Terms.TextChanged

    End Sub

    Private Sub CheckBox_Agree_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Agree.CheckedChanged

    End Sub
End Class
