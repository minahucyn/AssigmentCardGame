''' <summary>
''' This class will have methods handling the logic of the game
''' </summary>
Public Class GameActions
    Private _cardMaxValue As Integer = 14
    Private _cardMinValue As Integer = 2
    Private _random As Random = New Random()
    ''' <summary>
    ''' Shuffles a card deck and returns an array of CardModel
    ''' </summary>
    ''' <param name="numberOfRounds">Number of rounds to be played.</param>
    ''' <returns>An array of shuffled cards depending on the number of rounds</returns>
    Public Function ShuffleCards(numberOfRounds As Integer) As CardModel()

        'Generate random numbers for to simulate shuffling
        Dim ShuffledCardRanks As Integer() = Me.SimulateShuffling(numberOfRounds)
        Dim ShuffledCardArray(ShuffledCardRanks.Count - 1) As CardModel

        'Add cards to the array
        For index = 0 To ShuffledCardRanks.Count - 1

            'Create an instance of a new card
            Dim newCard As CardModel = New CardModel() With {.Rank = ShuffledCardRanks(index)}

            'Add the card to the card model array
            ShuffledCardArray(index) = newCard
        Next

        Return ShuffledCardArray

    End Function

    ''' <summary>
    ''' Shuffles by getting an array of random numbers between 2 and 13 inclusively
    ''' </summary>
    ''' <param name="numberOfRounds"></param>
    ''' <returns>A distinct integer array of ints between 2 and 13</returns>
    Private Function SimulateShuffling(numberOfRounds As Integer) As Integer()
        Dim ShuffledCardArray(numberOfRounds - 1) As Integer

        Dim Counter As Integer = 0

        Do While Counter < numberOfRounds
            Dim RandomCardNumber As Integer = _random.Next(_cardMinValue, _cardMaxValue)

            'Check whether the card is already present on array
            If IsCardDublicated(ShuffledCardArray, RandomCardNumber) = True Then
                'Card is already present on array, Ignore this case
            Else
                'Add the card to array
                ShuffledCardArray(Counter) = RandomCardNumber
                Counter += 1

            End If
        Loop

        Return ShuffledCardArray
    End Function

    ''' <summary>
    ''' Checks whether the random new card is already present in array and returns a boolean 
    ''' indicating the same
    ''' </summary>
    ''' <param name="cardArray">The array of cards</param>
    ''' <param name="newCard">The new random card</param>
    ''' <returns>Returns true if the new card is already present on array</returns>
    Private Function IsCardDublicated(cardArray As Integer(), newCard As Integer) As Boolean
        'Check whether the number is already present on array
        Dim isDublicated As Boolean = False

        For Each item In cardArray
            If item = newCard Then isDublicated = True
        Next

        Return isDublicated
    End Function
End Class
