Public Class Form2
    'Thiviyan Sivaruban
    'Pokemon Word Guess
    'Start Date: December 27, 2022
    'Due Date: January 18, 2023
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnPlayGame.Click

        'Declare constants
        Const chrFLAG1 As Char = "!"        'declare constant for character to guess word
        Const chrFLAG2 As Char = "@"        'declare constant for character to display hint
        Const strGuessPrompt As String = "Enter a letter, or enter an " & chrFLAG1 & " to guess the word, or enter an " & chrFLAG2 & " for a hint. "    'declare constant for prompt shown in inputbox
        'Declare variables
        Dim strSecretWord As String = ""    'declare variable for secret word and initialize to empty string
        Dim intNumGuesses As Integer = 0    'declare variable for number of guesses and initialize to 0
        Dim chrLetterGuess As Char          'declare variable for letter guessed by user
        Dim strWordGuess As String          'declare variable for word guessed by user
        Dim intLetterPos As Integer         'declare variable for position of letter
        Dim strTempWord As String           'declare variable for temporary word
        Dim blnEndGame As Boolean = False   'declare variable for the game ending
        Dim intScore As Integer = 50        'declare variable for score and initialize to 50
        Dim blnCorrectGuess As Boolean      'declare variable for correct guess
        Dim Hint As System.Drawing.Bitmap = Nothing     'declare variable for hint and initialize to nothing

        Me.lblScore.Text = "Score: " & intScore 'Display score in label
        lstLettersGuessed.Items.Clear() 'Clear listbox
        picHint.Image = Nothing 'Clear picturebox
        Me.lblHint.Text = "" 'Clear hint label

        Randomize()
        strSecretWord = Int(40 * Rnd() + 1) 'Get new word each round

        'List of words and assign hint to each word
        Select Case strSecretWord
            Case 1
                strSecretWord = "BULBASAUR"
                Hint = My.Resources.Bulbasaur
            Case 2
                strSecretWord = "IVYSAUR"
                Hint = My.Resources.Ivysaur
            Case 3
                strSecretWord = "VENUSAUR"
                Hint = My.Resources.Venusaur
            Case 4
                strSecretWord = "CHARMANDER"
                Hint = My.Resources.Charmander
            Case 5
                strSecretWord = "CHARMELEON"
                Hint = My.Resources.Charmeleon
            Case 6
                strSecretWord = "CHARIZARD"
                Hint = My.Resources.Charizard
            Case 7
                strSecretWord = "SQUIRTLE"
                Hint = My.Resources.Squirtle
            Case 8
                strSecretWord = "WARTORTLE"
                Hint = My.Resources.Wartortle
            Case 9
                strSecretWord = "BLASTOISE"
                Hint = My.Resources.Blastoise
            Case 10
                strSecretWord = "CATERPIE"
                Hint = My.Resources.Caterpie
            Case 11
                strSecretWord = "METAPOD"
                Hint = My.Resources.Metapod
            Case 12
                strSecretWord = "BUTTERFREE"
                Hint = My.Resources.Butterfree
            Case 13
                strSecretWord = "WEEDLE"
                Hint = My.Resources.Weedle
            Case 14
                strSecretWord = "KAKUNA"
                Hint = My.Resources.Kakuna
            Case 15
                strSecretWord = "BEEDRILL"
                Hint = My.Resources.Beedrill
            Case 16
                strSecretWord = "PIDGEY"
                Hint = My.Resources.Pidgey
            Case 17
                strSecretWord = "PIDGEOTTO"
                Hint = My.Resources.Pidgeotto
            Case 18
                strSecretWord = "PIDGEOT"
                Hint = My.Resources.Pidgeot
            Case 19
                strSecretWord = "RATTATA"
                Hint = My.Resources.Rattata
            Case 20
                strSecretWord = "RATICATE"
                Hint = My.Resources.Raticate
            Case 21
                strSecretWord = "SPEAROW"
                Hint = My.Resources.Spearow
            Case 22
                strSecretWord = "FEAROW"
                Hint = My.Resources.Fearow
            Case 23
                strSecretWord = "EKANS"
                Hint = My.Resources.Ekans
            Case 24
                strSecretWord = "ARBOK"
                Hint = My.Resources.Arbok
            Case 25
                strSecretWord = "PIKACHU"
                Hint = My.Resources.Pikachu
            Case 26
                strSecretWord = "RAICHU"
                Hint = My.Resources.Raichu
            Case 27
                strSecretWord = "SANDSHREW"
                Hint = My.Resources.Sandshrew
            Case 28
                strSecretWord = "SANDSLASH"
                Hint = My.Resources.Sandslash
            Case 29
                strSecretWord = "NIDORAN F"
                Hint = My.Resources.Nidoran_F
            Case 30
                strSecretWord = "NIDORINA"
                Hint = My.Resources.Nidorina
            Case 31
                strSecretWord = "NIDOQUEEN"
                Hint = My.Resources.Nidoqueen
            Case 32
                strSecretWord = "NIDORAN M"
                Hint = My.Resources.Nidoran
            Case 33
                strSecretWord = "NIDORINO"
                Hint = My.Resources.Nidorino
            Case 34
                strSecretWord = "NIDOKING"
                Hint = My.Resources.Nidoking
            Case 35
                strSecretWord = "CLEFAIRY"
                Hint = My.Resources.Clefairy
            Case 36
                strSecretWord = "CLEFABLE"
                Hint = My.Resources.Clefable
            Case 37
                strSecretWord = "MEGA VENUSAUR"
                Hint = My.Resources.Mega_Venusaur
            Case 38
                strSecretWord = "MEGA CHARIZARD X"
                Hint = My.Resources.Mega_Charizard_X
            Case 39
                strSecretWord = "MEGA CHARIZARD Y"
                Hint = My.Resources.Mega_Charizard_Y
            Case 40
                strSecretWord = "MEGA BLASTOISE"
                Hint = My.Resources.Mega_Blastoise
        End Select

        'Set same number of dashes as letters in strSecretWord
        Dim strWordGuessedSoFar As String = ""      'declare variable for word guessed so far and initialize to empty string
        Dim intLength As Integer = strSecretWord.Length     'declare variable for length of secret word
        strWordGuessedSoFar = strWordGuessedSoFar.PadLeft(intLength, "-")

        For intLetterPos = 0 To strSecretWord.Length - 1
            If strSecretWord(intLetterPos) = " " Then
                strTempWord = strWordGuessedSoFar.Remove(intLetterPos, 1)
                strWordGuessedSoFar = strTempWord.Insert(intLetterPos, " ")   'If word has spaces then insert spaces in word label
            End If
        Next

        Me.lblSecretWord.Text = strWordGuessedSoFar  'Initialize game

        'Get first guess
        Dim strTempLetterGuess = InputBox(strGuessPrompt, Me.Text)  'declare variable for temporary letter guess and set its value to inputted character
        'Test data entered
        If strTempLetterGuess = Nothing Then 'Cancel or empty text box
            blnEndGame = True
        Else                                 'user entered a letter
            chrLetterGuess = strTempLetterGuess
        End If

        Do While chrLetterGuess <> chrFLAG1 And strWordGuessedSoFar <> strSecretWord _
        And Not blnEndGame
            intNumGuesses = intNumGuesses + 1       'increase number of guessses by 1
            blnCorrectGuess = False                 'guess is incorrect
            For intLetterPos = 0 To strSecretWord.Length - 1
                If strSecretWord.Chars(intLetterPos) = Char.ToUpper(chrLetterGuess) Then
                    'remove dash at position of letter guessed
                    strTempWord = strWordGuessedSoFar.Remove(intLetterPos, 1)
                    'insert guessed letter
                    strWordGuessedSoFar = strTempWord.Insert(intLetterPos, Char.ToUpper(chrLetterGuess))
                    Me.lblSecretWord.Text = strWordGuessedSoFar      'update interface
                    blnCorrectGuess = True          'guess is correct
                End If
            Next intLetterPos

            If Not lstLettersGuessed.Items.Contains(Char.ToUpper(chrLetterGuess)) AndAlso Not lstLettersGuessed.Items.Contains(Char.ToLower(chrLetterGuess)) _
                AndAlso Char.IsLetter(chrLetterGuess) Then
                lstLettersGuessed.Items.Add(Char.ToUpper(chrLetterGuess))
                'Letters guessed are displayed in a listbox
            ElseIf Not Char.IsLetter(chrLetterGuess) And Not chrLetterGuess = "@" Then
                MessageBox.Show("Please enter a letter.")
                'Displayed when the character entered is not a letter
            ElseIf lstLettersGuessed.Items.Contains(Char.ToUpper(chrLetterGuess)) OrElse lstLettersGuessed.Items.Contains(Char.ToLower(chrLetterGuess)) Then
                MessageBox.Show("This letter has been already guessed.")
                'Displayed when the letter entered has already been guessed
            End If

            If blnCorrectGuess = False And Char.IsLetter(chrLetterGuess) Then
                intScore = intScore - 2     'Score decreases by 2 for every incorrect guess
                Me.lblScore.Text = "Score: " & intScore     'Show score in label
            End If

            If intScore = 0 Then
                MessageBox.Show("No more guesses, you lose.")   'Show this message when score reaches 0
                blnEndGame = True   'End game when score reaches 0
                End
            End If

            'A hint is displayed when @ is entered
            If chrLetterGuess = chrFLAG2 Then
                Me.lblHint.Text = "← Hint" 'Set hint label
                picHint.Image = Hint 'Set hint image in picturebox
            End If

            'Get next letter if word hasn't been guessed
            If strWordGuessedSoFar <> strSecretWord Then
                'Get user guess
                strTempLetterGuess = InputBox(strGuessPrompt, Me.Text)
                'Test data entered
                If strTempLetterGuess = Nothing Then   'Cancel or empty text box
                    blnEndGame = True
                Else                                   'user entered a letter
                    chrLetterGuess = strTempLetterGuess
                End If
            End If
        Loop

        If strWordGuessedSoFar = strSecretWord Then                 'user guessed all letters
            MessageBox.Show("You guessed it in " & intNumGuesses & " guesses!")
        ElseIf chrLetterGuess = chrFLAG1 Then                       'user tries to guess word
            strWordGuess = InputBox("Enter a word:", Me.Text)
            If strWordGuess.ToUpper = strSecretWord Then            'user guessed word correctly
                Me.lblSecretWord.Text = strSecretWord
                MessageBox.Show("You guessed it in " & intNumGuesses & " guesses!")         'number of guesses are displayed
            Else                                                    'user guessed word incorrectly
                MessageBox.Show("Sorry you lose.")
                Me.lblSecretWord.Text = strSecretWord
            End If
        Else                                                        'end game
            MessageBox.Show("Game over.")
            Me.lblSecretWord.Text = strSecretWord
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        Form1.Show() 'Switch to home page when back button is clicked

    End Sub

    Private Sub mnuCredits_Click(sender As Object, e As EventArgs) Handles mnuCredits.Click

        Me.Hide()
        Form4.Show() 'Switch to credits page when credits button in the menu is clicked

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        End 'End the program when the exit button in the menu is clicked

    End Sub
End Class