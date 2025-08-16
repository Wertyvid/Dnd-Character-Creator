Public Class FrmMenu
    Private Sub BtnNewCharacter_Click(sender As Object, e As EventArgs) Handles BtnNewCharacter.Click
        Dim characterCreatorForm As FrmCharacterCreatorMenu = New FrmCharacterCreatorMenu()
        characterCreatorForm.Show()
    End Sub
End Class
