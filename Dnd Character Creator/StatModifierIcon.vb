Imports System.ComponentModel.DataAnnotations
Imports System.Formats.Asn1.AsnWriter

Public Class StatModifierIcon
    Public Property statName As String

    Sub SetValue(value As Integer)
        LblValue.Text = value.ToString()
        LblName.Text = statName
        LblModifier.Text = Math.Floor((value - 10.0) / 2.0).ToString()
    End Sub
End Class
