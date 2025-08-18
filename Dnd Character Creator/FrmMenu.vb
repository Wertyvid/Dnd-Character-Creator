Imports Newtonsoft.Json

Public Class FrmMenu
    Private Sub BtnNewCharacter_Click(sender As Object, e As EventArgs) Handles BtnNewCharacter.Click
        Dim characterCreatorForm As FrmCharacterCreatorMenu = New FrmCharacterCreatorMenu()
        characterCreatorForm.Show()
    End Sub

    Private Sub BtnCharacterSheet_Click(sender As Object, e As EventArgs) Handles BtnCharacterSheet.Click
        CharacterSheetSelector.ShowDialog()

    End Sub

    Private Sub CharacterSheetSelector_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CharacterSheetSelector.FileOk
        MessageBox.Show(CharacterSheetSelector.FileName)
        If CharacterSheetSelector.FileName.EndsWith(".json") Then
            Dim characterSheetForm As FrmCharacterSheetMenu = New FrmCharacterSheetMenu(JsonConvert.DeserializeObject(Of Character)(IO.File.OpenText(CharacterSheetSelector.FileName).ReadToEnd()))
            characterSheetForm.Show()
        End If
    End Sub
End Class
