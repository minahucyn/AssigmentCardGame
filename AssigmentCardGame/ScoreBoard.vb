Public Class ScoreBoard
    Public Sub New()
        Me.PlayerOne = New List(Of CardModel)
        Me.PlayerTwo = New List(Of CardModel)
    End Sub
    Public Property PlayerOne As List(Of CardModel)
    Public Property PlayerTwo As List(Of CardModel)
End Class
