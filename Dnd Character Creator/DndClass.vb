
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class DndClass
    Public Property className As String
    Public Property hitDiceSize As Integer
    Public Property savingThrows As List(Of String)
    Public Property skillCount As Integer
    Public Property skillOptions As List(Of String)
    Public Property features As List(Of String)
End Class


Public Class Race
    Public Property raceName As String
    Public Property statBoosts As Stats
    Public Property features As List(Of String)
End Class

Public Class Stats
    Private statSkillAssociations As Dictionary(Of String, String) = New Dictionary(Of String, String) From {{"Acrobatics", "Dex"}, {"Animal Handling", "Wis"}, {"Arcana", "Int"}, {"Athletics", "Str"}, {"Deception", "Cha"}, {"History", "Int"},
        {"Insight", "Wis"}, {"Intimidation", "Cha"}, {"Investigation", "Int"}, {"Medicine", "Wis"}, {"Nature", "Int"}, {"Perception", "Wis"}, {"Performance", "Cha"}, {"Persuasion", "Cha"}, {"Religion", "Int"}, {"Sleight Of Hand", "Dex"},
        {"Stealth", "Dex"}, {"Survival", "Wis"}}

    Public strength As Integer = 0
    Public dexterity As Integer = 0
    Public consititution As Integer = 0
    Public intelligence As Integer = 0
    Public wisdom As Integer = 0
    Public charisma As Integer = 0

    Public Sub BoostFromStats(statBoost As Stats)
        strength += statBoost.strength
        dexterity += statBoost.dexterity
        consititution += statBoost.consititution
        intelligence += statBoost.intelligence
        wisdom += statBoost.wisdom
        charisma += statBoost.charisma
    End Sub

    Shared Function GetModifierFromScore(score As Integer) As Integer
        Return Math.Floor((score - 10.0) / 2.0)
    End Function

    Public Function GetModifierForSkill(skillName As String) As Integer
        Dim skillStat As String
        If {"Str", "Dex", "Con", "Int", "Wis", "Cha"}.Contains(skillName) Then
            skillStat = skillName
        Else
            skillStat = statSkillAssociations(skillName)
        End If
        Select Case skillStat
            Case "Str"
                Return Stats.GetModifierFromScore(strength)
            Case "Dex"
                Return Stats.GetModifierFromScore(dexterity)
            Case "Con"
                Return Stats.GetModifierFromScore(consititution)
            Case "Int"
                Return Stats.GetModifierFromScore(intelligence)
            Case "Wis"
                Return Stats.GetModifierFromScore(wisdom)
            Case "Cha"
                Return Stats.GetModifierFromScore(charisma)
            Case Else
                Return 0
        End Select
    End Function
End Class

Public Class Skills
    Public acrobatics As Boolean = False
    Public animalHandling As Boolean = False
    Public arcana As Boolean = False
    Public athletics As Boolean = False
    Public deception As Boolean = False
    Public history As Boolean = False
    Public insight As Boolean = False
    Public intimidation As Boolean = False
    Public investigation As Boolean = False
    Public medicine As Boolean = False
    Public nature As Boolean = False
    Public perception As Boolean = False
    Public performance As Boolean = False
    Public persuasion As Boolean = False
    Public religion As Boolean = False
    Public sleightOfHand As Boolean = False
    Public stealth As Boolean = False
    Public survival As Boolean = False

    Public saveStr As Boolean = False
    Public saveDex As Boolean = False
    Public saveCon As Boolean = False
    Public saveInt As Boolean = False
    Public saveWis As Boolean = False
    Public saveCha As Boolean = False



    Sub New(selectionsPanel As FlowLayoutPanel, selectedClass As DndClass, selectedBackground As Background)
        Dim duplicateSkill As Boolean = False
        For Each selectionBox In selectionsPanel.Controls
            If AddSkill(selectedClass.skillOptions(selectionBox.SelectedIndex)) Then
                duplicateSkill = True
            End If
        Next
        For Each skill In selectedBackground.skills
            If duplicateSkill = AddSkill(skill) Then
                duplicateSkill = True
            End If
        Next
        For Each savingThrow In selectedClass.savingThrows
            AddSkill(savingThrow)
        Next
        If duplicateSkill Then
            MessageBox.Show("You have a duplicate selected skill! You could have more proficiencies if you select unique skills.")
        End If
    End Sub

    Sub New()
        'Important!!!!
    End Sub

    Function AddSkill(skillName As String) As Boolean
        Dim isDuplicateSkill As Boolean = False
        'there's probably a better way to do this. idc
        Select Case skillName.ToLower
            Case "acrobatics"
                If acrobatics Then
                    isDuplicateSkill = True
                End If
                acrobatics = True
            Case "animal handling"
                If animalHandling Then
                    isDuplicateSkill = True
                End If
                animalHandling = True
            Case "arcana"
                If arcana Then
                    isDuplicateSkill = True
                End If
                arcana = True
            Case "athletics"
                If athletics Then
                    isDuplicateSkill = True
                End If
                athletics = True
            Case "deception"
                If deception Then
                    isDuplicateSkill = True
                End If
                deception = True
            Case "history"
                If history Then
                    isDuplicateSkill = True
                End If
                history = True
            Case "insight"
                If insight Then
                    isDuplicateSkill = True
                End If
                insight = True
            Case "intimidation"
                If intimidation Then
                    isDuplicateSkill = True
                End If
                intimidation = True
            Case "investigation"
                If investigation Then
                    isDuplicateSkill = True
                End If
                investigation = True
            Case "medicine"
                If medicine Then
                    isDuplicateSkill = True
                End If
                medicine = True
            Case "nature"
                If nature Then
                    isDuplicateSkill = True
                End If
                nature = True
            Case "perception"
                If perception Then
                    isDuplicateSkill = True
                End If
                perception = True
            Case "performance"
                If performance Then
                    isDuplicateSkill = True
                End If
                performance = True
            Case "persuasion"
                If persuasion Then
                    isDuplicateSkill = True
                End If
                persuasion = True
            Case "religion"
                If religion Then
                    isDuplicateSkill = True
                End If
                religion = True
            Case "sleight of hand"
                If sleightOfHand Then
                    isDuplicateSkill = True
                End If
                sleightOfHand = True
            Case "stealth"
                If stealth Then
                    isDuplicateSkill = True
                End If
                stealth = True
            Case "survival"
                If survival Then
                    isDuplicateSkill = True
                End If
                survival = True
            Case "strength"
                saveStr = True
            Case "dexterity"
                saveDex = True
            Case "constitution"
                saveCon = True
            Case "intelligence"
                saveInt = True
            Case "wisdom"
                saveWis = True
            Case "charisma"
                saveCha = True
        End Select
        Return isDuplicateSkill
    End Function

    Public Function GetSkillsValuesAsDict() As Dictionary(Of String, Boolean)
        Dim skillDict As Dictionary(Of String, Boolean) = New Dictionary(Of String, Boolean) From {{"Acrobatics", acrobatics}, {"Str", saveStr}, {"Animal Handling", animalHandling}, {"Dex", saveDex}, {"Arcana", arcana}, {"Con", saveCon}, {"Athletics", athletics}, {"Int", saveInt}, {"Deception", deception}, {"Wis", saveWis}, {"History", history}, {"Cha", saveCha}, {"Insight", insight}, {"Intimidation", intimidation},
            {"Investigation", investigation}, {"Medicine", medicine}, {"Nature", nature}, {"Perception", perception}, {"Performance", performance}, {"Persuasion", persuasion}, {"Religion", religion}, {"Sleight Of Hand", sleightOfHand}, {"Stealth", stealth}, {"Survival", survival}}
        Return skillDict
    End Function
End Class

Public Class Background
    Public backgroundName As String
    Public skills As List(Of String)
    Public feature As String
End Class

Public Class Armour
    Public armourName As String
    Public baseAC As Integer
    Public stealthDisadvantage As Boolean
    Public maxDexGain As Integer


End Class

Public Class Character
    Public name As String
    Public alignment As String
    Public dndClass As DndClass
    Public background As Background
    Public race As Race
    Public stats As Stats
    Public skills As Skills
    Public armour As Armour

    Public maxHp As Integer
    Public armourClass As Integer
    Public initiative As Integer
    Public proficiencyBonus As Integer
    Public features As List(Of String) = New List(Of String)

    Public currentHp As Integer


    Public Sub FinishCreation()
        For Each feature In dndClass.features
            features.Add(feature)
        Next
        For Each feature In race.features
            features.Add(feature)
        Next
        features.Add(background.feature)
        maxHp = dndClass.hitDiceSize + Stats.GetModifierFromScore(stats.consititution)
        initiative = 10 + Stats.GetModifierFromScore(stats.dexterity)
        proficiencyBonus = 2
        If armour.maxDexGain = 0 Then
            armourClass = armour.baseAC
        Else
            armourClass = armour.baseAC + Math.Clamp(Stats.GetModifierFromScore(stats.dexterity), -100, armour.maxDexGain)
        End If


        currentHp = maxHp
    End Sub

    Public Sub AdjustHp(changeToHp As Integer)
        currentHp -= changeToHp
    End Sub


End Class

Public Class DiceRoller

    Shared Function RollDice(rnd As Random, Optional dX As Integer = 20)
        Return rnd.Next(1, dX + 1)
    End Function
    Shared Function DetailedSkillRoll(skillModifier As Integer, proficiencyModifier As Integer, extraModifier As Integer, rnd As Random) As String
        Dim rollResult As Integer
        Dim rawRollResult As Integer
        Dim rollDetails As String = ""
        For r As Integer = 0 To 1
            rawRollResult = RollDice(rnd)
            rollResult = rawRollResult + skillModifier + proficiencyModifier + extraModifier
            rollDetails = rollDetails & $"{rollResult.ToString()} = {rawRollResult} + {skillModifier} + {proficiencyModifier} + {extraModifier}{vbCrLf}"
        Next
        Return rollDetails
    End Function

    Shared Function DetailedStatRoll(statModifier As Integer, extraModifier As Integer, rnd As Random)
        Dim rollResult As Integer
        Dim rawRollResult As Integer
        Dim rollDetails As String = ""
        For r As Integer = 0 To 1
            rawRollResult = RollDice(rnd)
            rollResult = rawRollResult + statModifier + extraModifier
            rollDetails = rollDetails & $"{rollResult.ToString()} = {rawRollResult} + {statModifier} + {extraModifier}{vbCrLf}"
        Next
        Return rollDetails
    End Function

    Shared Function DetailedSpellAttack(toHitModifier As Integer, damageDie As Integer, damageDieCount As Integer, damageType As String, rnd As Random)
        Dim toHitRollResult As Integer
        Dim rawRollResult As Integer
        Dim attackDetails As String = ""
        Dim crit As Boolean = False
        For r As Integer = 0 To 1
            rawRollResult = RollDice(rnd)
            If rawRollResult = 20 Then
                crit = True
            End If
            toHitRollResult = rawRollResult + toHitModifier
            attackDetails = attackDetails & $"{toHitRollResult.ToString()} = {rawRollResult.ToString()} + {toHitModifier.ToString()}{vbCrLf}"
        Next
        Dim dealtDamage As Integer = 0
        Dim damageDetails As String = "= "
        Dim rawAttackRoll As Integer
        If crit Then
            damageDieCount *= 2
        End If
        For r As Integer = 1 To damageDieCount
            rawAttackRoll = RollDice(rnd, damageDie)
            dealtDamage += rawAttackRoll
            damageDetails = damageDetails & $"+ {rawAttackRoll}"
        Next
        damageDetails = $"{dealtDamage.ToString()} {damageDetails}"
        attackDetails = attackDetails & $"{damageType} Damage:{vbCrLf}" & damageDetails
        Return attackDetails
    End Function

    Shared Function DetailedWeaponAttack(statModfier As Integer, proficiencyBonus As Integer, damageDie As Integer, damageDieCount As Integer, plusXWeapon As Integer, damageType As String, rnd As Random)
        Dim toHitRollResult As Integer
        Dim rawRollResult As Integer
        Dim attackDetails As String = ""
        Dim crit As Boolean = False
        For r As Integer = 0 To 1
            rawRollResult = RollDice(rnd)
            If rawRollResult = 20 Then
                crit = True
            End If
            toHitRollResult = rawRollResult + statModfier + proficiencyBonus + plusXWeapon
            attackDetails = attackDetails & $"{toHitRollResult.ToString()} = {rawRollResult.ToString()} + {statModfier.ToString()} + {proficiencyBonus.ToString()} + {plusXWeapon.ToString}{vbCrLf}"
        Next
        Dim dealtDamage As Integer = 0
        Dim damageDetails As String = "= "
        Dim rawAttackRoll As Integer
        If crit Then
            damageDieCount *= 2
        End If
        For r As Integer = 1 To damageDieCount
            rawAttackRoll = RollDice(rnd, damageDie)
            dealtDamage += rawAttackRoll
            damageDetails = damageDetails & $"+ {rawAttackRoll}"
        Next
        dealtDamage += statModfier + plusXWeapon
        damageDetails = damageDetails & $"+ {statModfier} + {plusXWeapon}"
        damageDetails = $"{dealtDamage.ToString()} {damageDetails}"
        attackDetails = attackDetails & $"{damageType} Damage:{vbCrLf}" & damageDetails
        Return attackDetails
    End Function
    Shared Sub DisplayRoll(rollDetails As String)
        MessageBox.Show(rollDetails, "Roll Result!")
    End Sub

End Class