Imports System.ComponentModel.DataAnnotations

Public Class StatIcon
    Public Property statName As String

    Sub SetValue(value As String)
        LblValue.Text = value
        LblName.Text = statName
    End Sub
End Class
