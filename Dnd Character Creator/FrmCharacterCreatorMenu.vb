Imports System.IO
Imports System.Reflection.PortableExecutable
Imports System.Text.Json.Nodes
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class FrmCharacterCreatorMenu
    Dim classes As List(Of DndClass)
    Dim races As List(Of Race)
    Dim backgrounds As List(Of Background)
    Dim alignments As String() = New String() {"Lawful Good", "Neutral Good", "Chaotic Good", "Lawful Neutral", "True Neutral", "Chaotic Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil"}
    Dim character As Character = New Character()
    Private Sub FrmCharacterCreatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        races = JsonConvert.DeserializeObject(Of List(Of Race))(IO.File.OpenText("jsons/races.json").ReadToEnd())
        classes = JsonConvert.DeserializeObject(Of List(Of DndClass))(IO.File.OpenText("jsons/classes.json").ReadToEnd())
        backgrounds = JsonConvert.DeserializeObject(Of List(Of Background))(IO.File.OpenText("jsons/backgrounds.json").ReadToEnd())
        For Each race In races
            CmbBoxRaceSelect.Items.Add(race.raceName)
        Next
        For Each dndClass In classes
            CmbBoxClassSelect.Items.Add(dndClass.className)
        Next
        For Each background In backgrounds
            CmbBoxBackgroundSelect.Items.Add(background.backgroundName)
        Next
        For Each alignment In alignments
            CmbBoxAlignmentSelect.Items.Add(alignment)
        Next
    End Sub

    Private Sub BtnApplyClassRace_Click(sender As Object, e As EventArgs) Handles BtnApplyClassRace.Click
        Try
            character.dndClass = classes(CmbBoxClassSelect.SelectedIndex)
            character.race = races(CmbBoxRaceSelect.SelectedIndex)
            character.background = backgrounds(CmbBoxBackgroundSelect.SelectedIndex)
            FillSkillOptions()
            UpdateStats()
        Catch ex As Exception
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

    Public Sub FillSkillOptions()
        FlwLaySkillOptions.Controls.Clear()
        Dim newSkillPicker As ComboBox
        For n As Integer = 1 To character.dndClass.skillCount
            newSkillPicker = New ComboBox()
            For Each skill In character.dndClass.skillOptions
                newSkillPicker.Items.Add(skill)
            Next
            FlwLaySkillOptions.Controls.Add(newSkillPicker)
        Next
    End Sub

    Private Sub BtnApplySkills_Click(sender As Object, e As EventArgs) Handles BtnApplySkills.Click
        If Not IsNothing(character.dndClass) Then
            Try
                character.skills = New Skills(FlwLaySkillOptions, character.dndClass, character.background)
            Catch ex As Exception
                MessageBox.Show("Choose skills before applying!!")
            End Try
        Else
            MessageBox.Show("Pick a class, background, and skills before applying!")
        End If
        'character.skills.GetType()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            character.FinishCreation()
            Dim characterFile As New StreamWriter(IO.File.Create("characters/goober.json"))
            characterFile.WriteLine(JsonConvert.SerializeObject(character, Formatting.Indented))
            characterFile.Close()
        Catch ex As Exception
            MessageBox.Show("Creation incomplete!")
        End Try
    End Sub

    Private Sub BtnApplyDetails_Click(sender As Object, e As EventArgs) Handles BtnApplyDetails.Click
        character.name = TxtBoxName.Text
        character.alignment = CmbBoxAlignmentSelect.Text
    End Sub
End Class