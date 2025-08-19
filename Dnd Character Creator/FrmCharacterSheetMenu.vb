Public Class FrmCharacterSheetMenu
    Dim character As Character
    Dim rnd As New Random

    Sub New(setCharacter As Character)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        character = setCharacter
    End Sub

    Private Sub FrmCharacterSheetMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblInfoName.Text = character.name
        LblInfoRace.Text = character.race.raceName
        LblInfoClass.Text = character.dndClass.className
        LblInfoBackground.Text = character.background.backgroundName
        LblInfoAlignment.Text = character.alignment

        StaAC.SetValue(character.armourClass.ToString())
        StaInitiative.SetValue(character.initiative.ToString())
        StaSpeed.SetValue("30ft")
        StaProficiency.SetValue(character.proficiencyBonus.ToString())
        StaHealth.SetValue(character.maxHp.ToString())

        StaModStr.SetValue(character.stats.strength)
        StaModDex.SetValue(character.stats.dexterity)
        StaModCon.SetValue(character.stats.consititution)
        StaModInt.SetValue(character.stats.intelligence)
        StaModWis.SetValue(character.stats.wisdom)
        StaModCha.SetValue(character.stats.charisma)

        Dim skillDict As Dictionary(Of String, Boolean) = character.skills.GetSkillsValuesAsDict()
        Dim skillRoller As SkillRollButton
        For Each skillName In skillDict.Keys
            skillRoller = New SkillRollButton(skillName, skillDict(skillName))
            AddHandler skillRoller.Roll, AddressOf SkillRoller_Roll
            TblLaySkillProficiencies.Controls.Add(skillRoller)
        Next
    End Sub

    Public Sub SkillRoller_Roll(skill As String, proficient As Boolean)
        Dim rollDetails As String
        Dim profMod As Integer = 0
        If proficient Then
            profMod = character.proficiencyBonus
        End If
        rollDetails = DiceRoller.DetailedSkillRoll(character.stats.GetModifierForSkill(skill), profMod, 0, rnd)
        DiceRoller.DisplayRoll(rollDetails)
    End Sub
End Class