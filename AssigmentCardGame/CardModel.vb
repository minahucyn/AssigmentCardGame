Public Class CardModel
    Private _Rank As CardRank
    Private _Image As Image

    Public Sub New()
        Me.Rank = CardRank.Back
    End Sub
    Public Property Rank As CardRank
        Get
            Return _Rank
        End Get
        Set
            _Rank = Value
            SetCardImage(Value)
        End Set
    End Property

    Public Property Image As Image
        Get
            Return _Image
        End Get
        Private Set
            _Image = Value
        End Set
    End Property

    ''' <summary>
    ''' Sets the card image automatically on setting card rank
    ''' </summary>
    ''' <param name="cardRank">This is the card rank being set</param>
    Private Sub SetCardImage(cardRank As CardRank)
        Select Case cardRank
            Case CardRank.Back
                Me._Image = My.Resources.Back
            Case CardRank.Two
                Me._Image = My.Resources.Two
            Case CardRank.Three
                Me._Image = My.Resources.Three
            Case CardRank.Four
                Me._Image = My.Resources.Four
            Case CardRank.Five
                Me._Image = My.Resources.Five
            Case CardRank.Six
                Me._Image = My.Resources.Six
            Case CardRank.Seven
                Me._Image = My.Resources.Seven
            Case CardRank.Eight
                Me._Image = My.Resources.Eight
            Case CardRank.Nine
                Me._Image = My.Resources.Nine
            Case CardRank.Ten
                Me._Image = My.Resources.Ten
            Case CardRank.Jack
                Me._Image = My.Resources.Jack
            Case CardRank.Queen
                Me._Image = My.Resources.Queen
            Case CardRank.King
                Me._Image = My.Resources.King
            Case CardRank.Ace
                Me._Image = My.Resources.Ace
            Case Else

        End Select
    End Sub
End Class
