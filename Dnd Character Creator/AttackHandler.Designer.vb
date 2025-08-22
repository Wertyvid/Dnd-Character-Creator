<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttackHandler
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        CmbBoxDamageType = New ComboBox()
        TxtBoxWeaponName = New TextBox()
        CmbBoxModfierStat = New ComboBox()
        ChkProficient = New CheckBox()
        ChkIsSpell = New CheckBox()
        SpnBoxPlusXWeapon = New NumericUpDown()
        CmbBoxDamageDie = New ComboBox()
        SpnBoxDamageDieCount = New NumericUpDown()
        BtnAttack = New Button()
        TableLayoutPanel1.SuspendLayout()
        CType(SpnBoxPlusXWeapon, ComponentModel.ISupportInitialize).BeginInit()
        CType(SpnBoxDamageDieCount, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 9
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.Controls.Add(CmbBoxDamageType, 5, 0)
        TableLayoutPanel1.Controls.Add(TxtBoxWeaponName, 1, 0)
        TableLayoutPanel1.Controls.Add(CmbBoxModfierStat, 2, 0)
        TableLayoutPanel1.Controls.Add(ChkProficient, 7, 0)
        TableLayoutPanel1.Controls.Add(ChkIsSpell, 8, 0)
        TableLayoutPanel1.Controls.Add(SpnBoxPlusXWeapon, 6, 0)
        TableLayoutPanel1.Controls.Add(CmbBoxDamageDie, 3, 0)
        TableLayoutPanel1.Controls.Add(SpnBoxDamageDieCount, 4, 0)
        TableLayoutPanel1.Controls.Add(BtnAttack, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(881, 150)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' CmbBoxDamageType
        ' 
        CmbBoxDamageType.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        CmbBoxDamageType.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxDamageType.FormattingEnabled = True
        CmbBoxDamageType.Items.AddRange(New Object() {"Piercing", "Bludgeoning", "Slashing", "Cold", "Fire", "Lightning", "Thunder", "Poison", "Acid", "Necrotic", "Radiant", "Force", "Psychic"})
        CmbBoxDamageType.Location = New Point(488, 63)
        CmbBoxDamageType.Name = "CmbBoxDamageType"
        CmbBoxDamageType.Size = New Size(91, 23)
        CmbBoxDamageType.TabIndex = 7
        ' 
        ' TxtBoxWeaponName
        ' 
        TxtBoxWeaponName.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        TxtBoxWeaponName.Location = New Point(100, 63)
        TxtBoxWeaponName.Name = "TxtBoxWeaponName"
        TxtBoxWeaponName.Size = New Size(91, 23)
        TxtBoxWeaponName.TabIndex = 0
        ' 
        ' CmbBoxModfierStat
        ' 
        CmbBoxModfierStat.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        CmbBoxModfierStat.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxModfierStat.FormattingEnabled = True
        CmbBoxModfierStat.Items.AddRange(New Object() {"Str", "Dex", "Con", "Int", "Wis", "Cha"})
        CmbBoxModfierStat.Location = New Point(197, 63)
        CmbBoxModfierStat.Name = "CmbBoxModfierStat"
        CmbBoxModfierStat.Size = New Size(91, 23)
        CmbBoxModfierStat.TabIndex = 1
        ' 
        ' ChkProficient
        ' 
        ChkProficient.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ChkProficient.AutoSize = True
        ChkProficient.Location = New Point(682, 65)
        ChkProficient.Name = "ChkProficient"
        ChkProficient.Size = New Size(91, 19)
        ChkProficient.TabIndex = 3
        ChkProficient.Text = "Proficient"
        ChkProficient.UseVisualStyleBackColor = True
        ' 
        ' ChkIsSpell
        ' 
        ChkIsSpell.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        ChkIsSpell.AutoSize = True
        ChkIsSpell.Location = New Point(779, 65)
        ChkIsSpell.Name = "ChkIsSpell"
        ChkIsSpell.Size = New Size(99, 19)
        ChkIsSpell.TabIndex = 6
        ChkIsSpell.Text = "Spell"
        ChkIsSpell.UseVisualStyleBackColor = True
        ' 
        ' SpnBoxPlusXWeapon
        ' 
        SpnBoxPlusXWeapon.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        SpnBoxPlusXWeapon.Location = New Point(585, 63)
        SpnBoxPlusXWeapon.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        SpnBoxPlusXWeapon.Name = "SpnBoxPlusXWeapon"
        SpnBoxPlusXWeapon.Size = New Size(91, 23)
        SpnBoxPlusXWeapon.TabIndex = 4
        ' 
        ' CmbBoxDamageDie
        ' 
        CmbBoxDamageDie.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        CmbBoxDamageDie.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxDamageDie.FormattingEnabled = True
        CmbBoxDamageDie.Items.AddRange(New Object() {"4", "6", "8", "10", "12"})
        CmbBoxDamageDie.Location = New Point(294, 63)
        CmbBoxDamageDie.Name = "CmbBoxDamageDie"
        CmbBoxDamageDie.Size = New Size(91, 23)
        CmbBoxDamageDie.TabIndex = 8
        ' 
        ' SpnBoxDamageDieCount
        ' 
        SpnBoxDamageDieCount.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        SpnBoxDamageDieCount.Location = New Point(391, 63)
        SpnBoxDamageDieCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        SpnBoxDamageDieCount.Name = "SpnBoxDamageDieCount"
        SpnBoxDamageDieCount.Size = New Size(91, 23)
        SpnBoxDamageDieCount.TabIndex = 9
        SpnBoxDamageDieCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BtnAttack
        ' 
        BtnAttack.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        BtnAttack.Location = New Point(3, 63)
        BtnAttack.Name = "BtnAttack"
        BtnAttack.Size = New Size(91, 23)
        BtnAttack.TabIndex = 10
        BtnAttack.Text = "Attack!"
        BtnAttack.UseVisualStyleBackColor = True
        ' 
        ' AttackHandler
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "AttackHandler"
        Size = New Size(881, 150)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(SpnBoxPlusXWeapon, ComponentModel.ISupportInitialize).EndInit()
        CType(SpnBoxDamageDieCount, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TxtBoxWeaponName As TextBox
    Friend WithEvents CmbBoxModfierStat As ComboBox
    Friend WithEvents ChkProficient As CheckBox
    Friend WithEvents SpnBoxPlusXWeapon As NumericUpDown
    Friend WithEvents ChkIsSpell As CheckBox
    Friend WithEvents CmbBoxDamageType As ComboBox
    Friend WithEvents CmbBoxDamageDie As ComboBox
    Friend WithEvents SpnBoxDamageDieCount As NumericUpDown
    Friend WithEvents BtnAttack As Button

End Class
