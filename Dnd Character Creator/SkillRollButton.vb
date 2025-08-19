Public Class SkillRollButton
    Public proficient As Boolean
    Public skillName As String

    Event Roll(skill As String, proficient As Boolean)

    Sub New(setSkillName As String, setProficient As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        skillName = setSkillName
        proficient = setProficient
        BtnRollSkill.Text = skillName
        ChkProficient.Checked = proficient
    End Sub

    Private Sub BtnRollSkill_Click(sender As Object, e As EventArgs) Handles BtnRollSkill.Click
        RaiseEvent Roll(skillName, proficient)
    End Sub
End Class
