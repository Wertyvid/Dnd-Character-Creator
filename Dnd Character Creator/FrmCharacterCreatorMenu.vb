Imports System.Text.Json.Nodes
Imports System.Text.Json.Serialization
Imports Newtonsoft.Json

Public Class FrmCharacterCreatorMenu
    Private Sub FrmCharacterCreatorMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim classes As List(Of DndClass)

        classes = JsonConvert.DeserializeObject(Of List(Of DndClass))(IO.File.OpenText("class jsons/all classes.json").ReadToEnd())
        MessageBox.Show(classes(1).features(1))

        For Each dndClass In classes
            CmbBoxClassSelect.Items.Add(dndClass.className)
        Next
    End Sub
End Class