Imports System.ComponentModel

Public Class FinalScoreBoard
    Private _scoreBoard As ScoreBoard

    Public Sub New(scoreData As ScoreBoard)
        InitializeComponent()
        Me._scoreBoard = scoreData
        InitializeDisplayData()

        'Handling Events
        AddHandler Me.FormClosing, AddressOf Me.FinalScoreBoard_Closing
        AddHandler Me.ButtonQuit.Click, AddressOf QuitGame
        AddHandler Me.ButtonTryAgain.Click, AddressOf TryAgain

    End Sub

    Private Sub TryAgain(sender As Object, e As EventArgs)
        Dim mainView As New MainView
        mainView.Show()
        _scoreBoard = Nothing

        'Lets' do some clean up
        Me.PictureBoxP1R1.Image = Nothing
        Me.PictureBoxP1R2.Image = Nothing
        Me.PictureBoxP1R3.Image = Nothing
        Me.PictureBoxP1R4.Image = Nothing
        Me.PictureBoxP1R5.Image = Nothing
        Me.PictureBoxP1R6.Image = Nothing
        Me.PictureBoxP2R1.Image = Nothing
        Me.PictureBoxP2R2.Image = Nothing
        Me.PictureBoxP2R3.Image = Nothing
        Me.PictureBoxP2R4.Image = Nothing
        Me.PictureBoxP2R5.Image = Nothing
        Me.PictureBoxP2R6.Image = Nothing

        'Some garbage stuff || not important enough to bother to name
        Me.PictureBox1.Image = Nothing
        Me.PictureBox2.Image = Nothing
        Me.PictureBox3.Image = Nothing


        GC.Collect()
        Me.Hide()
    End Sub

    Private Sub QuitGame(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub InitializeDisplayData()
        'Display Round Scores
        DisplayRoundsData(_scoreBoard.PlayerOne, Player.One)
        DisplayRoundsData(_scoreBoard.PlayerTwo, Player.Two)

        'Display total scores
        DisplayTotalRoundScore(_scoreBoard.PlayerOne, Player.One)
        DisplayTotalRoundScore(_scoreBoard.PlayerTwo, Player.Two)


        DisplayWinningPlayer()
    End Sub

    ''' <summary>
    ''' Compares the values on labels for total score and updates the label 
    ''' which indicates the overall winning player.
    ''' </summary>
    Private Sub DisplayWinningPlayer()
        Dim PlayerOneScore As Integer = LabelFinalScorePlayerOne.Text
        Dim PlayerTwoScore As Integer = LabelFinalScorePlayerTwo.Text

        Select Case True
            Case PlayerOneScore > PlayerTwoScore
                LabelWinningPlayerNumber.Text = "1"
            Case PlayerTwoScore > PlayerOneScore
                LabelWinningPlayerNumber.Text = "2"
            Case PlayerOneScore = PlayerTwoScore
                LabelWinningPlayerNumber.Text = ""
                LabelPlayer.Text = "Both "
        End Select
    End Sub

    Private Sub DisplayTotalRoundScore(playerCards As List(Of CardModel), player As Player)

        Dim PlayerScore As Integer = 0

        Select Case player

            Case Player.One
                For index = 1 To playerCards.Count
                    PlayerScore += CalculatePlayerRoundScore(index, Player.One)
                Next

                LabelFinalScorePlayerOne.Text = PlayerScore
            Case Player.Two
                For index = 1 To playerCards.Count
                    PlayerScore += CalculatePlayerRoundScore(index, Player.Two)
                Next

                LabelFinalScorePlayerTwo.Text = PlayerScore
        End Select


    End Sub

    Private Sub DisplayRoundsData(playerData As List(Of CardModel), player As Player)

        Select Case player
            Case Player.One
                For index = 1 To playerData.Count
                    Select Case index
                        Case 1
                            PictureBoxP1R1.Image = playerData.ElementAt(index - 1).Image
                            LabelPlayerOneRoundOne.Text = CalculatePlayerRoundScore(index, Player.One)
                        Case 2
                            PictureBoxP1R2.Image = playerData.ElementAt(index - 1).Image
                            LabelPlayerOneRoundTwo.Text = CalculatePlayerRoundScore(index, Player.One)
                        Case 3
                            PictureBoxP1R3.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP1R3.Visible = True
                            LabelPlayerOneRoundThree.Text = CalculatePlayerRoundScore(index, Player.One)
                            LabelPlayerOneRoundThree.Visible = True
                        Case 4
                            PictureBoxP1R4.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP1R4.Visible = True
                            LabelPlayerOneRoundFour.Text = CalculatePlayerRoundScore(index, Player.One)
                            LabelPlayerOneRoundFour.Visible = True
                        Case 5
                            PictureBoxP1R5.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP1R5.Visible = True
                            LabelPlayerOneRoundFive.Text = CalculatePlayerRoundScore(index, Player.One)
                            LabelPlayerOneRoundFive.Visible = True
                        Case 6

                            PictureBoxP1R6.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP1R6.Visible = True
                            LabelPlayerOneRoundSix.Text = CalculatePlayerRoundScore(index, Player.One)
                            LabelPlayerOneRoundSix.Visible = True

                    End Select
                Next

            Case Player.Two

                For index = 1 To playerData.Count
                    Select Case index
                        Case 1
                            PictureBoxP2R1.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R1.Visible = True
                            LabelPlayerTwoRoundOne.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundOne.Visible = True

                        Case 2
                            PictureBoxP2R2.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R2.Visible = True
                            LabelPlayerTwoRoundTwo.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundTwo.Visible = True
                        Case 3
                            PictureBoxP2R3.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R3.Visible = True
                            LabelPlayerTwoRoundThree.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundThree.Visible = True
                        Case 4
                            PictureBoxP2R4.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R4.Visible = True
                            LabelPlayerTwoRoundFour.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundFour.Visible = True
                        Case 5
                            PictureBoxP2R5.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R5.Visible = True
                            LabelPlayerTwoRoundFive.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundFive.Visible = True
                        Case 6
                            PictureBoxP2R6.Image = playerData.ElementAt(index - 1).Image
                            PictureBoxP2R6.Visible = True
                            LabelPlayerTwoRoundSix.Text = CalculatePlayerRoundScore(index, Player.Two)
                            LabelPlayerTwoRoundSix.Visible = True

                    End Select
                Next

        End Select
    End Sub

    Private Sub FinalScoreBoard_Closing(sender As Object, e As CancelEventArgs)
        Dim a As MsgBoxResult = MsgBox("Are you sure that you want to exit the game?", MsgBoxStyle.YesNo)
        If a = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Environment.Exit(0)
            Application.Exit()
            Me.Close()
            Me.Dispose()
            GC.Collect()
        End If

    End Sub

    ''' <summary>
    ''' Calculate score for individual rounds
    ''' </summary>
    ''' <param name="round">The round number</param>
    ''' <param name="player">Player identification by enum</param>
    ''' <returns></returns>
    Private Function CalculatePlayerRoundScore(round As Integer, player As Player) As Integer
        Dim playerOneRank As Integer = _scoreBoard.PlayerOne.ElementAt(round - 1).Rank
        Dim playerTwoRank As Integer = _scoreBoard.PlayerTwo.ElementAt(round - 1).Rank
        Dim roundScore As Integer = 0

        Select Case player
            Case Player.One
                If playerOneRank > playerTwoRank Then roundScore = 1
                If playerOneRank = playerTwoRank Then roundScore = 1
            Case Player.Two
                If playerOneRank < playerTwoRank Then roundScore = 1
                If playerOneRank = playerTwoRank Then roundScore = 1
        End Select

        Return roundScore
    End Function

    Private Enum Player
        One
        Two
    End Enum


End Class