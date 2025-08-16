Imports System.Text.Json.Nodes
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json

Public Class FrmCharacterCreatorMenu
    Dim classes As List(Of DndClass)
    Dim races As List(Of Race)
    Dim character As Character = New Character()
    Private Sub FrmCharacterCreatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        races = JsonConvert.DeserializeObject(Of List(Of Race))(IO.File.OpenText("jsons/races.json").ReadToEnd())
        classes = JsonConvert.DeserializeObject(Of List(Of DndClass))(IO.File.OpenText("jsons/classes.json").ReadToEnd())
        For Each race In races
            CmbBoxRaceSelect.Items.Add(race.raceName)
        Next
        For Each dndClass In classes
            CmbBoxClassSelect.Items.Add(dndClass.className)
        Next
    End Sub

    Private Sub BtnApplyClassRace_Click(sender As Object, e As EventArgs) Handles BtnApplyClassRace.Click
        Try
            character.dndClass = classes(CmbBoxClassSelect.SelectedIndex)
            character.race = races(CmbBoxRaceSelect.SelectedIndex)
            UpdateStats()
            MessageBox.Show(JsonConvert.SerializeObject(character))
        Catch
            MessageBox.Show("Select a class and a race before applying!")
        End Try
    End Sub

    Private Overloads Sub UpdateStats(sender As Object, e As EventArgs) Handles BtnApplyStats.Click
        character.stats = GetBaseStatChoices()
        If Not IsNothing(character.race) Then
            character.stats.BoostFromStats(character.race.statBoosts)
        End If
    End Sub

    Private Overloads Sub UpdateStats()
        character.stats = GetBaseStatChoices()
        If Not IsNothing(character.race) Then
            character.stats.BoostFromStats(character.race.statBoosts)
        End If
    End Sub

    Private Function GetBaseStatChoices() As Stats
        Dim baseStats As Stats = New Stats()
        baseStats.strength = NumStr.Value
        baseStats.dexterity = NumDex.Value
        baseStats.consititution = NumCon.Value
        baseStats.intelligence = NumInt.Value
        baseStats.wisdom = NumWis.Value
        baseStats.charisma = NumCha.Value
        Return baseStats
    End Function

    Private Sub StatChooser_ValueChanged(sender As Object, e As EventArgs) Handles NumInt.ValueChanged, NumCon.ValueChanged, NumDex.ValueChanged, NumStr.ValueChanged, NumWis.ValueChanged, NumCha.ValueChanged
        LblPointsRemaining.Text = $"Don't go above 15 if using point buy!{vbCrLf}Point Buy Points remaining: {GetRemainingPointBuyPoints()}"
    End Sub

    Private Function GetRemainingPointBuyPoints()
        Dim remainingPoints As Integer = 27
        Dim pointCosts As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer) From {{0, 0}, {8, 0}, {9, 1}, {10, 2}, {11, 3}, {12, 4}, {13, 5}, {14, 7}, {15, 9}}
        For Each spinBox In {NumStr, NumDex, NumCon, NumInt, NumWis, NumCha}
            remainingPoints -= pointCosts(spinBox.Value)
        Next
        Return remainingPoints
    End Function
End Class