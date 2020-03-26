Imports AssigmentCardGame

Public Class MainView
    Private _gameActions As GameActions = New GameActions()
    Private _selectedCardHolder As PictureBox
    Private _currentCardSetPlayerOne As CardModel()
    Private _currentCardSetPlayerTwo As CardModel()
    Private _selectedCardPositionPlayerOne As SelectedCardHolderPosition = SelectedCardHolderPosition.None
    Private _selectedCardPositionPlayerTwo As SelectedCardHolderPosition = SelectedCardHolderPosition.None
    Private _selectedCardPlayerOne As CardModel
    Private _selectedCardPlayerTwo As CardModel
    Private _roundStatus As RoundState = RoundState.NotFlipped
    Private _hiddenLocation = New Point(588, 29)
    Private _ViewLocation = New Point(3, 5)
    Private _scoreData As ScoreBoard = New ScoreBoard()

    'Events
    'NOTE: 1. Declare event 2. Subscibe to the event 3. Raise the event
    Private Event RoundCompleted()

    Public Sub New()

        'Initialize all form controls
        InitializeComponent()
        InitializeUserInterface(ViewState.Greet)

        'listen to events
        AddHandler ButtonStart.Click, AddressOf InitializeGame
        AddHandler ButtonQuit.Click, AddressOf QuitGame
        AddHandler ButtonFlipCardPlayerTwo.Click, AddressOf PrepareForFlippingSelectedCard
        AddHandler ButtonFlipCardPlayerOne.Click, AddressOf PrepareForFlippingSelectedCard


        'Handle Click events of cards player 1
        AddHandler PictureBoxCardOneOne.Click, AddressOf PlayerOneCardSelected
        AddHandler PictureBoxCardOneTwo.Click, AddressOf PlayerOneCardSelected
        AddHandler PictureBoxCardOneThree.Click, AddressOf PlayerOneCardSelected
        AddHandler PictureBoxCardOneFour.Click, AddressOf PlayerOneCardSelected
        AddHandler PictureBoxCardOneFive.Click, AddressOf PlayerOneCardSelected
        AddHandler PictureBoxCardOneSix.Click, AddressOf PlayerOneCardSelected

        'Handle Click events of cards player 2
        AddHandler PictureBoxCardTwoOne.Click, AddressOf PlayerTwoCardSelected
        AddHandler PictureBoxCardTwoTwo.Click, AddressOf PlayerTwoCardSelected
        AddHandler PictureBoxCardTwoThree.Click, AddressOf PlayerTwoCardSelected
        AddHandler PictureBoxCardTwoFour.Click, AddressOf PlayerTwoCardSelected
        AddHandler PictureBoxCardTwoFive.Click, AddressOf PlayerTwoCardSelected
        AddHandler PictureBoxCardTwoSix.Click, AddressOf PlayerTwoCardSelected

        'Manage score with custom event
        AddHandler Me.RoundCompleted, AddressOf OnRoundCompleted

    End Sub

    Private Sub OnRoundCompleted()
        _scoreData.PlayerOne.Add(_selectedCardPlayerOne)
        _scoreData.PlayerTwo.Add(_selectedCardPlayerTwo)

        'Calculate live score
        Dim score As LiveScore = CalculateLiveScore(_scoreData)

        'Display live score
        DisplayLiveScore(score)

        'Is final round completed / Is Game Over?
        DetermineGameCompletion()


    End Sub

    Private Sub DetermineGameCompletion()
        If _currentCardSetPlayerOne.Count = _scoreData.PlayerOne.Count Then
            Dim finalScoreBoard = New FinalScoreBoard(_scoreData)
            Me.Hide()
            GC.Collect()
            finalScoreBoard.Show()

        End If

    End Sub

    Private Sub DisplayLiveScore(score As LiveScore)
        LabelPlayerOneScore.Text = LabelPlayerOneScore.Tag & score.PlayerOneScore
        LabelPlayerTwoScore.Text = LabelPlayerTwoScore.Tag & score.PlayerTwoScore
    End Sub

    Private Function CalculateLiveScore(scoreData As ScoreBoard) As LiveScore
        Dim currentScore = New LiveScore

        For index = 1 To scoreData.PlayerOne.Count

            Debug.WriteLine("Player one Rank: " & scoreData.PlayerOne.ElementAt(index - 1).Rank)
            Debug.WriteLine("Player one Rank: " & scoreData.PlayerTwo.ElementAt(index - 1).Rank)

            'compare the cards
            If scoreData.PlayerOne.ElementAt(index - 1).Rank = scoreData.PlayerTwo.ElementAt(index - 1).Rank Then
                currentScore.PlayerOneScore += 1
                currentScore.PlayerTwoScore += 1

                Debug.WriteLine("Both Equal, gave 1 and 1")
            ElseIf scoreData.PlayerOne.ElementAt(index - 1).Rank > scoreData.PlayerTwo.ElementAt(index - 1).Rank Then
                currentScore.PlayerOneScore += 1
                Debug.WriteLine("Player 1 : Player 2 | 1 : 0")

            ElseIf scoreData.PlayerOne.ElementAt(index - 1).Rank < scoreData.PlayerTwo.ElementAt(index - 1).Rank Then
                currentScore.PlayerTwoScore += 1
                Debug.WriteLine("Player 1 : Player 2 | 0 : 1")
            End If
            Debug.WriteLine($"Total Score (P1 : P2) {currentScore.PlayerOneScore} : {currentScore.PlayerTwoScore}")

        Next

        Return currentScore

    End Function

    Private Sub PrepareForFlippingSelectedCard(sender As Object, e As EventArgs)
        'Flip the card 
        FlipNow(_selectedCardHolder.Tag)

        'Hide the button
        Dim button As Button = sender
        FlipButtonVisibleState(button, False)
    End Sub

    Private Sub FlipNow(cardHolderTag As Integer)

        Select Case True
            Case cardHolderTag < 17
                _selectedCardPlayerOne = _currentCardSetPlayerOne(cardHolderTag - 11)
                _selectedCardHolder.Image = _selectedCardPlayerOne.Image
                _selectedCardPositionPlayerOne = _selectedCardPlayerOne.Rank
                _selectedCardHolder.Enabled = False

            Case cardHolderTag > 20
                _selectedCardPlayerTwo = _currentCardSetPlayerTwo(cardHolderTag - 21)
                _selectedCardHolder.Image = _selectedCardPlayerTwo.Image
                _selectedCardPositionPlayerTwo = _selectedCardPlayerTwo.Rank
                _selectedCardHolder.Enabled = False

        End Select

        'Set the round state
        ManageRoundStateOnFlippingCard(cardHolderTag)

    End Sub

    Private Sub ManageRoundStateOnFlippingCard(cardHolderTag As Integer)
        Select Case True
            Case cardHolderTag < 17
                If _roundStatus = RoundState.PlayerOneFlipped Then
                    ShowPrompt_NextPlayerTurn()
                ElseIf _roundStatus = RoundState.NotFlipped Then
                    _roundStatus = RoundState.PlayerOneFlipped

                ElseIf _roundStatus = RoundState.PlayTwoFlipped Then
                    _roundStatus = RoundState.NotFlipped
                    RaiseEvent RoundCompleted()
                End If
            Case cardHolderTag > 20
                If _roundStatus = RoundState.PlayTwoFlipped Then
                    ShowPrompt_NextPlayerTurn()
                ElseIf _roundStatus = RoundState.NotFlipped Then
                    _roundStatus = RoundState.PlayTwoFlipped

                ElseIf _roundStatus = RoundState.PlayerOneFlipped Then
                    _roundStatus = RoundState.NotFlipped
                    RaiseEvent RoundCompleted()
                End If
        End Select

        Debug.WriteLine(_roundStatus.ToString)
    End Sub

    Private Sub PlayerTwoCardSelected(sender As Object, e As EventArgs)

        'Check whether the player already flipped
        If _roundStatus = RoundState.PlayTwoFlipped Then
            ShowPrompt_NextPlayerTurn()
            Return
        End If

        _selectedCardHolder = sender
        ButtonFlipCardPlayerTwo.Location = New Point(_selectedCardHolder.Location.X, 130)

        'Show the button if hidden
        If ButtonFlipCardPlayerTwo.Visible = False Then FlipButtonVisibleState(ButtonFlipCardPlayerTwo, True)

    End Sub

    Private Sub PlayerOneCardSelected(sender As Object, e As EventArgs)

        'Check whether the player already flipped
        If _roundStatus = RoundState.PlayerOneFlipped Then
            ShowPrompt_NextPlayerTurn()
            Return
        End If
        _selectedCardHolder = sender
        ButtonFlipCardPlayerOne.Location = New Point(_selectedCardHolder.Location.X, 127)

        'Show the button if hidden
        If ButtonFlipCardPlayerOne.Visible = False Then FlipButtonVisibleState(ButtonFlipCardPlayerOne, True)

    End Sub

    Private Sub ShowPrompt_NextPlayerTurn()
        MsgBox("You've already flipped. Now it is the turn for the other player!")
    End Sub
    Private Sub FlipButtonVisibleState(button As Button, isVisible As Boolean)
        button.Visible = isVisible
    End Sub

    Private Sub QuitGame(sender As Object, e As EventArgs)
        Dim QuitVerify As MsgBoxResult = MsgBox("Are you sure that you want to quit the game?",
                                 MsgBoxStyle.YesNo, "Exit Game?")

        If QuitVerify = MsgBoxResult.Yes Then Environment.Exit(0)


    End Sub

    Private Sub InitializeGame(sender As Object, e As EventArgs)
        'Verify that the number of rounds is specified.
        If ComboBoxNumberOfRounds.Text = Nothing Then
            MsgBox("Please select the number of rounds to play!", MsgBoxStyle.Exclamation)
            Return
        End If

        'Do stuff here
        InitializeGamePlay(New GameStartArgs() With {.NumberOfRounds = ComboBoxNumberOfRounds.Text})
        'start the game
        InitializeUserInterface(ViewState.Game)


    End Sub

    Private Sub InitializeGamePlay(gameStartArgs As GameStartArgs)

        'Shuffle the cards
        Me._currentCardSetPlayerOne = _gameActions.ShuffleCards(gameStartArgs.NumberOfRounds)
        Me._currentCardSetPlayerTwo = _gameActions.ShuffleCards(gameStartArgs.NumberOfRounds)

        'Display card back sides on screen
        InitializeCardDisplay(gameStartArgs)

    End Sub

    Private Sub InitializeCardDisplay(gameStartArgs As GameStartArgs)
        Select Case gameStartArgs.NumberOfRounds

            Case NumberOfRounds.Three
                InitializeThreeCardsDisplay()

            Case NumberOfRounds.Four
                InitializeThreeCardsDisplay()
                InitializeFourthCardDisplay()

            Case NumberOfRounds.Five
                InitializeThreeCardsDisplay()
                InitializeFourthCardDisplay()
                InitializeFifthCardDisplay()

            Case NumberOfRounds.Six
                InitializeThreeCardsDisplay()
                InitializeFourthCardDisplay()
                InitializeFifthCardDisplay()
                InitializeSixthCardDisplay()

        End Select
    End Sub


    ''' <summary>
    ''' Displays the back side of sixth card
    ''' </summary>
    Private Sub InitializeSixthCardDisplay()
        PictureBoxCardOneSix.Image = New CardModel().Image

        'Player 2
        PictureBoxCardTwoSix.Image = New CardModel().Image

    End Sub

    ''' <summary>
    ''' Displays the back side of fourth card
    ''' </summary>
    Private Sub InitializeFourthCardDisplay()
        'Player 1
        PictureBoxCardOneFour.Image = New CardModel().Image

        'Player 2
        PictureBoxCardTwoFour.Image = New CardModel().Image

    End Sub

    ''' <summary>
    ''' Displays the back side of Fifth card
    ''' </summary>
    Private Sub InitializeFifthCardDisplay()

        'Player 1
        PictureBoxCardOneFive.Image = New CardModel().Image

        'Player 2
        PictureBoxCardTwoFive.Image = New CardModel().Image

    End Sub

    ''' <summary>
    ''' Displays the back side of first three cards
    ''' </summary>
    Private Sub InitializeThreeCardsDisplay()
        'Player 1
        PictureBoxCardOneOne.Image = New CardModel().Image
        PictureBoxCardOneTwo.Image = New CardModel().Image
        PictureBoxCardOneThree.Image = New CardModel().Image

        'Player 2
        PictureBoxCardTwoOne.Image = New CardModel().Image
        PictureBoxCardTwoTwo.Image = New CardModel().Image
        PictureBoxCardTwoThree.Image = New CardModel().Image
    End Sub

    ''' <summary>
    ''' Sets the games play state to show the game or the greet screen
    ''' </summary>
    ''' <param name="requiredViewState">Game or Greet</param>
    Private Sub InitializeUserInterface(requiredViewState As ViewState)
        Select Case requiredViewState
            Case ViewState.Game
                PanelGreet.Location = _hiddenLocation
                PanelGame.Location = _ViewLocation
                FlipButtonVisibleState(ButtonFlipCardPlayerOne, False)
                FlipButtonVisibleState(ButtonFlipCardPlayerTwo, False)

            Case ViewState.Greet
                PanelGreet.Location = _ViewLocation
                PanelGame.Location = _hiddenLocation
        End Select
    End Sub

    Private Enum ViewState
        Game
        Greet
    End Enum

    Private Enum Player
        One
        Two
    End Enum

    Private Enum NumberOfRounds
        Three = 3
        Four = 4
        Five = 5
        Six = 6
    End Enum

    Private Enum SelectedCardHolderPosition
        None
        One
        Two
        Three
        Four
        Five
        Six
    End Enum

    Private Enum RoundState
        NotFlipped
        PlayerOneFlipped
        PlayTwoFlipped
        RoundComplete
    End Enum
End Class
