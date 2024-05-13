Public Class Form4
    'Thiviyan Sivaruban
    'January 7, 2023
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        Form1.Show() 'Switch to home page when back button is clicked

    End Sub
End Class