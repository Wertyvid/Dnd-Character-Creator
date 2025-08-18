
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
End Class

Public Class Background
    Public backgroundName As String
    Public skills As List(Of String)
    Public feature As String
End Class

Public Class Character
    Public name As String
    Public alignment As String
    Public dndClass As DndClass
    Public background As Background
    Public race As Race
    Public stats As Stats
    Public skills As Skills

    Public maxHp As Integer
    Public armourClass As Integer
    Public initiative As Integer
    Public proficiencyBonus As Integer
    Public features As List(Of String) = New List(Of String)


    Public Sub FinishCreation()
        For Each feature In dndClass.features
            features.Add(feature)
        Next
        For Each feature In race.features
            features.Add(feature)
        Next
        features.Add(background.feature)
        maxHp = dndClass.hitDiceSize + GetModifierFromScore(stats.consititution)
        armourClass = 10 + GetModifierFromScore(stats.dexterity)
        initiative = 10 + GetModifierFromScore(stats.dexterity)
        proficiencyBonus = 2

    End Sub

    Private Function GetModifierFromScore(score As Integer) As Integer
        Return Math.Floor((score - 10.0) / 2.0)
    End Function
End Class

