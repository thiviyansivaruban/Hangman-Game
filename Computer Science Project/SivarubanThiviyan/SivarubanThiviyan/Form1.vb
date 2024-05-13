Public Class Form1
    'Thiviyan Sivaruban
    'January 7, 2023
    Private Sub btnPlayGame_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click

        Me.Hide()
        Form2.Show() 'Switch to game page when play game button is clicked

    End Sub

    Private Sub btnHowToPlay_Click(sender As Object, e As EventArgs) Handles btnHowToPlay.Click

        Me.Hide()
        Form3.Show() 'Switch to how to play page when how to play button is clicked

    End Sub

    Private Sub mnuCredits_Click(sender As Object, e As EventArgs) Handles mnuCredits.Click

        Me.Hide()
        Form4.Show() 'Switch to credits page when credits button in the menu is clicked

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End 'End the program when exit button in the menu is clicked

    End Sub
End Class
