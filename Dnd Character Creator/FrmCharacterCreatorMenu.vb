Imports System.Text.Json.Nodes
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json

Public Class FrmCharacterCreatorMenu
    Dim classes As List(Of DndClass)
    Dim character As Character = New Character()
    Private Sub FrmCharacterCreatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        classes = JsonConvert.DeserializeObject(Of List(Of DndClass))(IO.File.OpenText("jsons/classes.json").ReadToEnd())
        For Each dndClass In classes
            CmbBoxClassSelect.Items.Add(dndClass.className)
        Next
    End Sub

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        Try
            character.dndClass = classes(CmbBoxClassSelect.SelectedIndex)
        Catch
            MessageBox.Show("Select a class and a race before applying!")
        End Try
    End Sub
End Class