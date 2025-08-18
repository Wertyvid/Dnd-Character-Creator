<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCharacterSheetMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        TabLayMain = New TabControl()
        TabPgeInfo = New TabPage()
        TabPgeSkills = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        TblLayInfoTop = New TableLayoutPanel()
        LblInfoName = New Label()
        LblInfoAlignment = New Label()
        LblInfoRace = New Label()
        LblInfoBackground = New Label()
        LblInfoClass = New Label()
        TblLayInfo = New TableLayoutPanel()
        StaModStr = New StatModifierIcon()
        StaModInt = New StatModifierIcon()
        StaModCha = New StatModifierIcon()
        StaModWis = New StatModifierIcon()
        StaModDex = New StatModifierIcon()
        StaModCon = New StatModifierIcon()
        TblLayStats = New TableLayoutPanel()
        StaAC = New StatIcon()
        StaInitiative = New StatIcon()
        StaSpeed = New StatIcon()
        StaProficiency = New StatIcon()
        TblLayMiscStats = New TableLayoutPanel()
        TblLayHealth = New TableLayoutPanel()
        Label1 = New Label()
        TabLayMain.SuspendLayout()
        TabPgeInfo.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TblLayInfoTop.SuspendLayout()
        TblLayInfo.SuspendLayout()
        TblLayStats.SuspendLayout()
        TblLayMiscStats.SuspendLayout()
        TblLayHealth.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabLayMain
        ' 
        TabLayMain.Controls.Add(TabPgeInfo)
        TabLayMain.Controls.Add(TabPgeSkills)
        TabLayMain.Dock = DockStyle.Fill
        TabLayMain.Location = New Point(0, 0)
        TabLayMain.Name = "TabLayMain"
        TabLayMain.SelectedIndex = 0
        TabLayMain.Size = New Size(919, 532)
        TabLayMain.TabIndex = 0
        ' 
        ' TabPgeInfo
        ' 
        TabPgeInfo.Controls.Add(TblLayInfo)
        TabPgeInfo.Location = New Point(4, 24)
        TabPgeInfo.Name = "TabPgeInfo"
        TabPgeInfo.Padding = New Padding(3)
        TabPgeInfo.Size = New Size(911, 504)
        TabPgeInfo.TabIndex = 0
        TabPgeInfo.Text = "Info"
        TabPgeInfo.UseVisualStyleBackColor = True
        ' 
        ' TabPgeSkills
        ' 
        TabPgeSkills.Location = New Point(4, 24)
        TabPgeSkills.Name = "TabPgeSkills"
        TabPgeSkills.Padding = New Padding(3)
        TabPgeSkills.Size = New Size(911, 504)
        TabPgeSkills.TabIndex = 1
        TabPgeSkills.Text = "Skills"
        TabPgeSkills.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TblLayStats, 0, 0)
        TableLayoutPanel1.Controls.Add(TblLayMiscStats, 1, 1)
        TableLayoutPanel1.Controls.Add(TblLayHealth, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 102)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(899, 393)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' TblLayInfoTop
        ' 
        TblLayInfoTop.ColumnCount = 5
        TblLayInfoTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayInfoTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayInfoTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayInfoTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayInfoTop.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayInfoTop.Controls.Add(LblInfoClass, 2, 0)
        TblLayInfoTop.Controls.Add(LblInfoBackground, 3, 0)
        TblLayInfoTop.Controls.Add(LblInfoRace, 1, 0)
        TblLayInfoTop.Controls.Add(LblInfoAlignment, 4, 0)
        TblLayInfoTop.Controls.Add(LblInfoName, 0, 0)
        TblLayInfoTop.Dock = DockStyle.Fill
        TblLayInfoTop.Location = New Point(3, 3)
        TblLayInfoTop.Name = "TblLayInfoTop"
        TblLayInfoTop.RowCount = 1
        TblLayInfoTop.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLayInfoTop.Size = New Size(899, 93)
        TblLayInfoTop.TabIndex = 0
        ' 
        ' LblInfoName
        ' 
        LblInfoName.AutoSize = True
        LblInfoName.Dock = DockStyle.Fill
        LblInfoName.Location = New Point(3, 0)
        LblInfoName.Name = "LblInfoName"
        LblInfoName.Size = New Size(173, 93)
        LblInfoName.TabIndex = 4
        LblInfoName.Text = "Label5"
        LblInfoName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoAlignment
        ' 
        LblInfoAlignment.AutoSize = True
        LblInfoAlignment.Dock = DockStyle.Fill
        LblInfoAlignment.Location = New Point(719, 0)
        LblInfoAlignment.Name = "LblInfoAlignment"
        LblInfoAlignment.Size = New Size(177, 93)
        LblInfoAlignment.TabIndex = 3
        LblInfoAlignment.Text = "Label4"
        LblInfoAlignment.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoRace
        ' 
        LblInfoRace.AutoSize = True
        LblInfoRace.Dock = DockStyle.Fill
        LblInfoRace.Location = New Point(182, 0)
        LblInfoRace.Name = "LblInfoRace"
        LblInfoRace.Size = New Size(173, 93)
        LblInfoRace.TabIndex = 2
        LblInfoRace.Text = "Label3"
        LblInfoRace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoBackground
        ' 
        LblInfoBackground.AutoSize = True
        LblInfoBackground.Dock = DockStyle.Fill
        LblInfoBackground.Location = New Point(540, 0)
        LblInfoBackground.Name = "LblInfoBackground"
        LblInfoBackground.Size = New Size(173, 93)
        LblInfoBackground.TabIndex = 1
        LblInfoBackground.Text = "Label2"
        LblInfoBackground.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoClass
        ' 
        LblInfoClass.AutoSize = True
        LblInfoClass.Dock = DockStyle.Fill
        LblInfoClass.Location = New Point(361, 0)
        LblInfoClass.Name = "LblInfoClass"
        LblInfoClass.Size = New Size(173, 93)
        LblInfoClass.TabIndex = 0
        LblInfoClass.Text = "Label1"
        LblInfoClass.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TblLayInfo
        ' 
        TblLayInfo.ColumnCount = 1
        TblLayInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TblLayInfo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TblLayInfo.Controls.Add(TblLayInfoTop, 0, 0)
        TblLayInfo.Controls.Add(TableLayoutPanel1, 0, 1)
        TblLayInfo.Dock = DockStyle.Fill
        TblLayInfo.Location = New Point(3, 3)
        TblLayInfo.Name = "TblLayInfo"
        TblLayInfo.RowCount = 2
        TblLayInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TblLayInfo.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TblLayInfo.Size = New Size(905, 498)
        TblLayInfo.TabIndex = 0
        ' 
        ' StaModStr
        ' 
        StaModStr.Dock = DockStyle.Fill
        StaModStr.Location = New Point(3, 3)
        StaModStr.Name = "StaModStr"
        StaModStr.Size = New Size(141, 89)
        StaModStr.statName = "Strength"
        StaModStr.TabIndex = 5
        ' 
        ' StaModInt
        ' 
        StaModInt.Dock = DockStyle.Fill
        StaModInt.Location = New Point(3, 98)
        StaModInt.Name = "StaModInt"
        StaModInt.Size = New Size(141, 89)
        StaModInt.statName = "Intelligence"
        StaModInt.TabIndex = 4
        ' 
        ' StaModCha
        ' 
        StaModCha.Dock = DockStyle.Fill
        StaModCha.Location = New Point(297, 98)
        StaModCha.Name = "StaModCha"
        StaModCha.Size = New Size(143, 89)
        StaModCha.statName = "Charisma"
        StaModCha.TabIndex = 3
        ' 
        ' StaModWis
        ' 
        StaModWis.Dock = DockStyle.Fill
        StaModWis.Location = New Point(150, 98)
        StaModWis.Name = "StaModWis"
        StaModWis.Size = New Size(141, 89)
        StaModWis.statName = "Wisdom"
        StaModWis.TabIndex = 2
        ' 
        ' StaModDex
        ' 
        StaModDex.Dock = DockStyle.Fill
        StaModDex.Location = New Point(150, 3)
        StaModDex.Name = "StaModDex"
        StaModDex.Size = New Size(141, 89)
        StaModDex.statName = "Dexterity"
        StaModDex.TabIndex = 1
        ' 
        ' StaModCon
        ' 
        StaModCon.Dock = DockStyle.Fill
        StaModCon.Location = New Point(297, 3)
        StaModCon.Name = "StaModCon"
        StaModCon.Size = New Size(143, 89)
        StaModCon.statName = "Consitution"
        StaModCon.TabIndex = 0
        ' 
        ' TblLayStats
        ' 
        TblLayStats.ColumnCount = 3
        TblLayStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TblLayStats.Controls.Add(StaModCon, 2, 0)
        TblLayStats.Controls.Add(StaModDex, 1, 0)
        TblLayStats.Controls.Add(StaModWis, 1, 1)
        TblLayStats.Controls.Add(StaModCha, 2, 1)
        TblLayStats.Controls.Add(StaModInt, 0, 1)
        TblLayStats.Controls.Add(StaModStr, 0, 0)
        TblLayStats.Dock = DockStyle.Fill
        TblLayStats.Location = New Point(3, 3)
        TblLayStats.Name = "TblLayStats"
        TblLayStats.RowCount = 2
        TblLayStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayStats.Size = New Size(443, 190)
        TblLayStats.TabIndex = 1
        ' 
        ' StaAC
        ' 
        StaAC.Dock = DockStyle.Fill
        StaAC.Location = New Point(3, 3)
        StaAC.Name = "StaAC"
        StaAC.Size = New Size(105, 89)
        StaAC.statName = "AC"
        StaAC.TabIndex = 1
        ' 
        ' StaInitiative
        ' 
        StaInitiative.Dock = DockStyle.Fill
        StaInitiative.Location = New Point(114, 3)
        StaInitiative.Name = "StaInitiative"
        StaInitiative.Size = New Size(105, 89)
        StaInitiative.statName = "Initiative"
        StaInitiative.TabIndex = 2
        ' 
        ' StaSpeed
        ' 
        StaSpeed.Dock = DockStyle.Fill
        StaSpeed.Location = New Point(225, 3)
        StaSpeed.Name = "StaSpeed"
        StaSpeed.Size = New Size(105, 89)
        StaSpeed.statName = "Speed"
        StaSpeed.TabIndex = 3
        ' 
        ' StaProficiency
        ' 
        StaProficiency.Dock = DockStyle.Fill
        StaProficiency.Location = New Point(336, 3)
        StaProficiency.Name = "StaProficiency"
        StaProficiency.Size = New Size(105, 89)
        StaProficiency.statName = "Proficiency Bonus"
        StaProficiency.TabIndex = 4
        ' 
        ' TblLayMiscStats
        ' 
        TblLayMiscStats.ColumnCount = 4
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TblLayMiscStats.Controls.Add(StaProficiency, 3, 0)
        TblLayMiscStats.Controls.Add(StaSpeed, 2, 0)
        TblLayMiscStats.Controls.Add(StaInitiative, 1, 0)
        TblLayMiscStats.Controls.Add(StaAC, 0, 0)
        TblLayMiscStats.Location = New Point(452, 199)
        TblLayMiscStats.Name = "TblLayMiscStats"
        TblLayMiscStats.RowCount = 2
        TblLayMiscStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayMiscStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayMiscStats.Size = New Size(444, 190)
        TblLayMiscStats.TabIndex = 0
        ' 
        ' TblLayHealth
        ' 
        TblLayHealth.ColumnCount = 2
        TblLayHealth.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayHealth.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayHealth.Controls.Add(Label1, 0, 0)
        TblLayHealth.Dock = DockStyle.Fill
        TblLayHealth.Location = New Point(452, 3)
        TblLayHealth.Name = "TblLayHealth"
        TblLayHealth.RowCount = 2
        TblLayHealth.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealth.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealth.Size = New Size(444, 190)
        TblLayHealth.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' FrmCharacterSheetMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(919, 532)
        Controls.Add(TabLayMain)
        Name = "FrmCharacterSheetMenu"
        Text = "FrmCharacterSheetMenu"
        TabLayMain.ResumeLayout(False)
        TabPgeInfo.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TblLayInfoTop.ResumeLayout(False)
        TblLayInfoTop.PerformLayout()
        TblLayInfo.ResumeLayout(False)
        TblLayStats.ResumeLayout(False)
        TblLayMiscStats.ResumeLayout(False)
        TblLayHealth.ResumeLayout(False)
        TblLayHealth.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabLayMain As TabControl
    Friend WithEvents TabPgeInfo As TabPage
    Friend WithEvents TabPgeSkills As TabPage
    Friend WithEvents TblLayInfo As TableLayoutPanel
    Friend WithEvents TblLayInfoTop As TableLayoutPanel
    Friend WithEvents LblInfoClass As Label
    Friend WithEvents LblInfoBackground As Label
    Friend WithEvents LblInfoRace As Label
    Friend WithEvents LblInfoAlignment As Label
    Friend WithEvents LblInfoName As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TblLayStats As TableLayoutPanel
    Friend WithEvents StaModCon As StatModifierIcon
    Friend WithEvents StaModDex As StatModifierIcon
    Friend WithEvents StaModWis As StatModifierIcon
    Friend WithEvents StaModCha As StatModifierIcon
    Friend WithEvents StaModInt As StatModifierIcon
    Friend WithEvents StaModStr As StatModifierIcon
    Friend WithEvents TblLayMiscStats As TableLayoutPanel
    Friend WithEvents StaProficiency As StatIcon
    Friend WithEvents StaSpeed As StatIcon
    Friend WithEvents StaInitiative As StatIcon
    Friend WithEvents StaAC As StatIcon
    Friend WithEvents TblLayHealth As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
