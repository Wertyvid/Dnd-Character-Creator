
Public Class DndClass
    Public Property className As String
    Public Property hitDiceSize As Integer
    Public Property features As List(Of String)
End Class


Public Class Race
    Public Property raceName As String
    Public Property statBoosts As Stats
    Public Property features As List(Of String)
End Class

Public Class Stats
    Public strength As Integer = 0
    Public dexterity As Integer = 0
    Public consititution As Integer = 0
    Public intelligence As Integer = 0
    Public wisdom As Integer = 0
    Public charisma As Integer = 0

    Private Sub BoostFromStats(statBoost As Stats)
        strength += statBoost.strength
        dexterity += statBoost.dexterity
        consititution += statBoost.consititution
        intelligence += statBoost.intelligence
        wisdom += statBoost.wisdom
        charisma += statBoost.charisma
    End Sub
End Class

Public Class Character
    Public dndClass As DndClass
    Public race As Race
    Public stats As Stats
End Class