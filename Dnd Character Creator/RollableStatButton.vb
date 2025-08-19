Public Class RollableStatButton
    Public Property StatName As String

    Event Roll(statName As String)

    Sub Setup() Handles MyBase.Load
        LblStatName.Text = StatName
    End Sub

    Sub ShowModifier(modifier As Integer, value As Integer)
        LblModifier.Text = modifier.ToString()
        BtnSkill.Text = value.ToString()
    End Sub

    Private Sub BtnSkill_Click(sender As Object, e As EventArgs) Handles BtnSkill.Click
        RaiseEvent Roll(StatName)
    End Sub
End Class
