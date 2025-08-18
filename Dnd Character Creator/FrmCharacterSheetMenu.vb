Public Class FrmCharacterSheetMenu
    Dim character As Character

    Sub New(setCharacter As Character)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        character = setCharacter
    End Sub
End Class