Public Class FrmCharacterSheetMenu
    Dim character As Character

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

        StaModStr.SetValue(character.stats.strength)
        StaModDex.SetValue(character.stats.dexterity)
        StaModCon.SetValue(character.stats.consititution)
        StaModInt.SetValue(character.stats.intelligence)
        StaModWis.SetValue(character.stats.wisdom)
        StaModCha.SetValue(character.stats.charisma)
    End Sub
End Class