Imports System.Diagnostics.Eventing.Reader

Public Class AttackHandler
    Public toHitStat As String
    Public damageDie As Integer
    Public damageDieCount As Integer
    Public plusXWeapon As Integer
    Public damageType As String
    Private proficient As Boolean
    Private spell As Boolean

    Public Property IsProficient As Boolean
        Get
            Return proficient
        End Get
        Set(value As Boolean)
            ChkProficient.Checked = value
            proficient = value
        End Set
    End Property

    Public Property IsSpell As Boolean
        Get
            Return spell
        End Get
        Set(value As Boolean)
            spell = value
            If spell Then
                IsProficient = False
                ChkProficient.Enabled = False
                SpnBoxPlusXWeapon.Value = 0
                plusXWeapon = value
                SpnBoxPlusXWeapon.Enabled = False
            Else
                ChkProficient.Enabled = True
                SpnBoxPlusXWeapon.Enabled = True
            End If
        End Set
    End Property

    Event SpellAttack(toHitStat As String, damageDie As Integer, damageDieCount As Integer, damageType As String)
    Event WeaponAttack(toHitStat As String, damageDie As Integer, damageDieCount As Integer, proficient As Boolean, plusXWeapon As Integer, damageType As String)

    Private Sub ChkProficient_CheckedChanged(sender As CheckBox, e As EventArgs) Handles ChkProficient.CheckedChanged
        IsProficient = sender.Checked
    End Sub

    Private Sub ChkIsSpell_CheckedChanged(sender As CheckBox, e As EventArgs) Handles ChkIsSpell.CheckedChanged
        IsSpell = sender.Checked
    End Sub

    Private Sub CmbBoxModfierStat_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CmbBoxModfierStat.SelectedIndexChanged
        toHitStat = sender.Text
    End Sub

    Private Sub CmbBoxDamageDie_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CmbBoxDamageDie.SelectedIndexChanged
        damageDie = sender.Text.ToString()
    End Sub

    Private Sub SpnBoxDamageDieCount_ValueChanged(sender As NumericUpDown, e As EventArgs) Handles SpnBoxDamageDieCount.ValueChanged
        damageDieCount = sender.Value
    End Sub

    Private Sub SpnBoxPlusXWeapon_ValueChanged(sender As NumericUpDown, e As EventArgs) Handles SpnBoxPlusXWeapon.ValueChanged
        plusXWeapon = sender.Value
    End Sub

    Private Sub CmbBoxDamageType_SelectedIndexChanged(sender As ComboBox, e As EventArgs) Handles CmbBoxDamageType.SelectedIndexChanged
        damageType = sender.Text
    End Sub

    Private Sub BtnAttack_Click(sender As Object, e As EventArgs) Handles BtnAttack.Click
        If CmbBoxModfierStat.Text <> "" Or CmbBoxDamageDie.Text <> "" Then
            If IsSpell Then
                RaiseEvent SpellAttack(toHitStat, damageDie, damageDieCount, damageType)
            Else
                RaiseEvent WeaponAttack(toHitStat, damageDie, damageDieCount, proficient, plusXWeapon, damageType)
            End If
        End If
    End Sub


End Class
