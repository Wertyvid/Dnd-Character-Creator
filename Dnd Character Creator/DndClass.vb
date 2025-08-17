
Imports System.Windows.Forms.VisualStyles

Public Class DndClass
    Public Property className As String
    Public Property hitDiceSize As Integer
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

    Sub New(selectionsPanel As FlowLayoutPanel, selectedClass As DndClass, selectedBackground As Background)
        For Each selectionBox As ComboBox In selectionsPanel.Controls
            AddSkill(selectedClass.skillOptions(selectionBox.SelectedIndex))
        Next
        For Each skill In selectedBackground.skills
            AddSkill(skill)
        Next
    End Sub

    Sub AddSkill(skillName As String)
        Dim duplicateSkill As Boolean = False
        'there's probably a better way to do this. idc
        Select Case skillName.ToLower
            Case "acrobatics"
                If acrobatics Then
                    duplicateSkill = True
                End If
                acrobatics = True
            Case "animal handling"
                If animalHandling Then
                    duplicateSkill = True
                End If
                animalHandling = True
            Case "arcana"
                If arcana Then
                    duplicateSkill = True
                End If
                arcana = True
            Case "athletics"
                If athletics Then
                    duplicateSkill = True
                End If
                athletics = True
            Case "deception"
                If deception Then
                    duplicateSkill = True
                End If
                deception = True
            Case "history"
                If history Then
                    duplicateSkill = True
                End If
                history = True
            Case "insight"
                If insight Then
                    duplicateSkill = True
                End If
                insight = True
            Case "intimidation"
                If intimidation Then
                    duplicateSkill = True
                End If
                intimidation = True
            Case "investigation"
                If investigation Then
                    duplicateSkill = True
                End If
                investigation = True
            Case "medicine"
                If medicine Then
                    duplicateSkill = True
                End If
                medicine = True
            Case "nature"
                If nature Then
                    duplicateSkill = True
                End If
                nature = True
            Case "perception"
                If perception Then
                    duplicateSkill = True
                End If
                perception = True
            Case "performance"
                If performance Then
                    duplicateSkill = True
                End If
                performance = True
            Case "persuasion"
                If persuasion Then
                    duplicateSkill = True
                End If
                persuasion = True
            Case "religion"
                If religion Then
                    duplicateSkill = True
                End If
                religion = True
            Case "sleight of hand"
                If sleightOfHand Then
                    duplicateSkill = True
                End If
                sleightOfHand = True
            Case "stealth"
                If stealth Then
                    duplicateSkill = True
                End If
                stealth = True
            Case "survival"
                If survival Then
                    duplicateSkill = True
                End If
                survival = True
        End Select
        If duplicateSkill Then
            MessageBox.Show("You have a duplicate selected skill! You could have more proficiencies if you select unique skills.")
        End If

    End Sub
End Class

Public Class Background
    Public backgroundName As String
    Public skills As List(Of String)
    Public feature As String
End Class

Public Class Character
    Public dndClass As DndClass
    Public background As Background
    Public race As Race
    Public stats As Stats
    Public skills As Skills
End Class

