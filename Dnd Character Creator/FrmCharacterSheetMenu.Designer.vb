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
        TblLayInfo = New TableLayoutPanel()
        TblLayInfoTop = New TableLayoutPanel()
        LblInfoClass = New Label()
        LblInfoBackground = New Label()
        LblInfoRace = New Label()
        LblInfoAlignment = New Label()
        LblInfoName = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        TblLayStats = New TableLayoutPanel()
        StaModCon = New StatModifierIcon()
        StaModDex = New StatModifierIcon()
        StaModWis = New StatModifierIcon()
        StaModCha = New StatModifierIcon()
        StaModInt = New StatModifierIcon()
        StaModStr = New StatModifierIcon()
        TblLayMiscStats = New TableLayoutPanel()
        StaHealth = New StatIcon()
        StaProficiency = New StatIcon()
        StaSpeed = New StatIcon()
        StaInitiative = New StatIcon()
        StaAC = New StatIcon()
        TabPgeSkills = New TabPage()
        TblLaySkillsMain = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        StaBtnStr = New RollableStatButton()
        StaBtnDex = New RollableStatButton()
        StaBtnCon = New RollableStatButton()
        StaBtnInt = New RollableStatButton()
        StaBtnWis = New RollableStatButton()
        StaBtnCha = New RollableStatButton()
        TblLaySkillProficiencies = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel10 = New Panel()
        Panel11 = New Panel()
        Panel12 = New Panel()
        TabLayMain.SuspendLayout()
        TabPgeInfo.SuspendLayout()
        TblLayInfo.SuspendLayout()
        TblLayInfoTop.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TblLayStats.SuspendLayout()
        TblLayMiscStats.SuspendLayout()
        TabPgeSkills.SuspendLayout()
        TblLaySkillsMain.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TblLaySkillProficiencies.SuspendLayout()
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
        TabLayMain.Size = New Size(1453, 682)
        TabLayMain.TabIndex = 0
        ' 
        ' TabPgeInfo
        ' 
        TabPgeInfo.Controls.Add(TblLayInfo)
        TabPgeInfo.Location = New Point(4, 24)
        TabPgeInfo.Name = "TabPgeInfo"
        TabPgeInfo.Padding = New Padding(3)
        TabPgeInfo.Size = New Size(1445, 654)
        TabPgeInfo.TabIndex = 0
        TabPgeInfo.Text = "Info"
        TabPgeInfo.UseVisualStyleBackColor = True
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
        TblLayInfo.Size = New Size(1439, 648)
        TblLayInfo.TabIndex = 0
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
        TblLayInfoTop.Size = New Size(1433, 123)
        TblLayInfoTop.TabIndex = 0
        ' 
        ' LblInfoClass
        ' 
        LblInfoClass.AutoSize = True
        LblInfoClass.Dock = DockStyle.Fill
        LblInfoClass.Location = New Point(575, 0)
        LblInfoClass.Name = "LblInfoClass"
        LblInfoClass.Size = New Size(280, 123)
        LblInfoClass.TabIndex = 0
        LblInfoClass.Text = "Label1"
        LblInfoClass.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoBackground
        ' 
        LblInfoBackground.AutoSize = True
        LblInfoBackground.Dock = DockStyle.Fill
        LblInfoBackground.Location = New Point(861, 0)
        LblInfoBackground.Name = "LblInfoBackground"
        LblInfoBackground.Size = New Size(280, 123)
        LblInfoBackground.TabIndex = 1
        LblInfoBackground.Text = "Label2"
        LblInfoBackground.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoRace
        ' 
        LblInfoRace.AutoSize = True
        LblInfoRace.Dock = DockStyle.Fill
        LblInfoRace.Location = New Point(289, 0)
        LblInfoRace.Name = "LblInfoRace"
        LblInfoRace.Size = New Size(280, 123)
        LblInfoRace.TabIndex = 2
        LblInfoRace.Text = "Label3"
        LblInfoRace.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoAlignment
        ' 
        LblInfoAlignment.AutoSize = True
        LblInfoAlignment.Dock = DockStyle.Fill
        LblInfoAlignment.Location = New Point(1147, 0)
        LblInfoAlignment.Name = "LblInfoAlignment"
        LblInfoAlignment.Size = New Size(283, 123)
        LblInfoAlignment.TabIndex = 3
        LblInfoAlignment.Text = "Label4"
        LblInfoAlignment.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' LblInfoName
        ' 
        LblInfoName.AutoSize = True
        LblInfoName.Dock = DockStyle.Fill
        LblInfoName.Location = New Point(3, 0)
        LblInfoName.Name = "LblInfoName"
        LblInfoName.Size = New Size(280, 123)
        LblInfoName.TabIndex = 4
        LblInfoName.Text = "Label5"
        LblInfoName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(TblLayStats, 0, 0)
        TableLayoutPanel1.Controls.Add(TblLayMiscStats, 1, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 132)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(1433, 513)
        TableLayoutPanel1.TabIndex = 1
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
        TblLayStats.Size = New Size(710, 250)
        TblLayStats.TabIndex = 1
        ' 
        ' StaModCon
        ' 
        StaModCon.Dock = DockStyle.Fill
        StaModCon.Location = New Point(475, 3)
        StaModCon.Name = "StaModCon"
        StaModCon.Size = New Size(232, 119)
        StaModCon.statName = "Consitution"
        StaModCon.TabIndex = 0
        ' 
        ' StaModDex
        ' 
        StaModDex.Dock = DockStyle.Fill
        StaModDex.Location = New Point(239, 3)
        StaModDex.Name = "StaModDex"
        StaModDex.Size = New Size(230, 119)
        StaModDex.statName = "Dexterity"
        StaModDex.TabIndex = 1
        ' 
        ' StaModWis
        ' 
        StaModWis.Dock = DockStyle.Fill
        StaModWis.Location = New Point(239, 128)
        StaModWis.Name = "StaModWis"
        StaModWis.Size = New Size(230, 119)
        StaModWis.statName = "Wisdom"
        StaModWis.TabIndex = 2
        ' 
        ' StaModCha
        ' 
        StaModCha.Dock = DockStyle.Fill
        StaModCha.Location = New Point(475, 128)
        StaModCha.Name = "StaModCha"
        StaModCha.Size = New Size(232, 119)
        StaModCha.statName = "Charisma"
        StaModCha.TabIndex = 3
        ' 
        ' StaModInt
        ' 
        StaModInt.Dock = DockStyle.Fill
        StaModInt.Location = New Point(3, 128)
        StaModInt.Name = "StaModInt"
        StaModInt.Size = New Size(230, 119)
        StaModInt.statName = "Intelligence"
        StaModInt.TabIndex = 4
        ' 
        ' StaModStr
        ' 
        StaModStr.Dock = DockStyle.Fill
        StaModStr.Location = New Point(3, 3)
        StaModStr.Name = "StaModStr"
        StaModStr.Size = New Size(230, 119)
        StaModStr.statName = "Strength"
        StaModStr.TabIndex = 5
        ' 
        ' TblLayMiscStats
        ' 
        TblLayMiscStats.ColumnCount = 5
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayMiscStats.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayMiscStats.Controls.Add(StaHealth, 4, 0)
        TblLayMiscStats.Controls.Add(StaProficiency, 3, 0)
        TblLayMiscStats.Controls.Add(StaSpeed, 2, 0)
        TblLayMiscStats.Controls.Add(StaInitiative, 1, 0)
        TblLayMiscStats.Controls.Add(StaAC, 0, 0)
        TblLayMiscStats.Dock = DockStyle.Fill
        TblLayMiscStats.Location = New Point(719, 3)
        TblLayMiscStats.Name = "TblLayMiscStats"
        TblLayMiscStats.RowCount = 2
        TblLayMiscStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayMiscStats.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayMiscStats.Size = New Size(711, 250)
        TblLayMiscStats.TabIndex = 0
        ' 
        ' StaHealth
        ' 
        StaHealth.Dock = DockStyle.Fill
        StaHealth.Location = New Point(571, 3)
        StaHealth.Name = "StaHealth"
        StaHealth.Size = New Size(137, 119)
        StaHealth.statName = "Health"
        StaHealth.TabIndex = 7
        ' 
        ' StaProficiency
        ' 
        StaProficiency.Dock = DockStyle.Fill
        StaProficiency.Location = New Point(429, 3)
        StaProficiency.Name = "StaProficiency"
        StaProficiency.Size = New Size(136, 119)
        StaProficiency.statName = "Proficiency Bonus"
        StaProficiency.TabIndex = 4
        ' 
        ' StaSpeed
        ' 
        StaSpeed.Dock = DockStyle.Fill
        StaSpeed.Location = New Point(287, 3)
        StaSpeed.Name = "StaSpeed"
        StaSpeed.Size = New Size(136, 119)
        StaSpeed.statName = "Speed"
        StaSpeed.TabIndex = 3
        ' 
        ' StaInitiative
        ' 
        StaInitiative.Dock = DockStyle.Fill
        StaInitiative.Location = New Point(145, 3)
        StaInitiative.Name = "StaInitiative"
        StaInitiative.Size = New Size(136, 119)
        StaInitiative.statName = "Initiative"
        StaInitiative.TabIndex = 2
        ' 
        ' StaAC
        ' 
        StaAC.Dock = DockStyle.Fill
        StaAC.Location = New Point(3, 3)
        StaAC.Name = "StaAC"
        StaAC.Size = New Size(136, 119)
        StaAC.statName = "AC"
        StaAC.TabIndex = 1
        ' 
        ' TabPgeSkills
        ' 
        TabPgeSkills.Controls.Add(TblLaySkillsMain)
        TabPgeSkills.Location = New Point(4, 24)
        TabPgeSkills.Name = "TabPgeSkills"
        TabPgeSkills.Padding = New Padding(3)
        TabPgeSkills.Size = New Size(1445, 654)
        TabPgeSkills.TabIndex = 1
        TabPgeSkills.Text = "Skills"
        TabPgeSkills.UseVisualStyleBackColor = True
        ' 
        ' TblLaySkillsMain
        ' 
        TblLaySkillsMain.ColumnCount = 3
        TblLaySkillsMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLaySkillsMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        TblLaySkillsMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TblLaySkillsMain.Controls.Add(TableLayoutPanel3, 1, 0)
        TblLaySkillsMain.Controls.Add(TblLaySkillProficiencies, 0, 0)
        TblLaySkillsMain.Dock = DockStyle.Fill
        TblLaySkillsMain.Location = New Point(3, 3)
        TblLaySkillsMain.Name = "TblLaySkillsMain"
        TblLaySkillsMain.RowCount = 1
        TblLaySkillsMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLaySkillsMain.Size = New Size(1439, 648)
        TblLaySkillsMain.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 20F))
        TableLayoutPanel3.Controls.Add(StaBtnStr, 0, 0)
        TableLayoutPanel3.Controls.Add(StaBtnDex, 0, 1)
        TableLayoutPanel3.Controls.Add(StaBtnCon, 0, 2)
        TableLayoutPanel3.Controls.Add(StaBtnInt, 0, 3)
        TableLayoutPanel3.Controls.Add(StaBtnWis, 0, 4)
        TableLayoutPanel3.Controls.Add(StaBtnCha, 0, 5)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(722, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 6
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 14.2857141F))
        TableLayoutPanel3.Size = New Size(137, 642)
        TableLayoutPanel3.TabIndex = 4
        ' 
        ' StaBtnStr
        ' 
        StaBtnStr.Location = New Point(3, 3)
        StaBtnStr.Name = "StaBtnStr"
        StaBtnStr.Size = New Size(131, 97)
        StaBtnStr.StatName = "Str"
        StaBtnStr.TabIndex = 0
        ' 
        ' StaBtnDex
        ' 
        StaBtnDex.Location = New Point(3, 110)
        StaBtnDex.Name = "StaBtnDex"
        StaBtnDex.Size = New Size(131, 97)
        StaBtnDex.StatName = "Dex"
        StaBtnDex.TabIndex = 1
        ' 
        ' StaBtnCon
        ' 
        StaBtnCon.Location = New Point(3, 217)
        StaBtnCon.Name = "StaBtnCon"
        StaBtnCon.Size = New Size(131, 97)
        StaBtnCon.StatName = "Con"
        StaBtnCon.TabIndex = 2
        ' 
        ' StaBtnInt
        ' 
        StaBtnInt.Location = New Point(3, 324)
        StaBtnInt.Name = "StaBtnInt"
        StaBtnInt.Size = New Size(131, 97)
        StaBtnInt.StatName = "Int"
        StaBtnInt.TabIndex = 3
        ' 
        ' StaBtnWis
        ' 
        StaBtnWis.Location = New Point(3, 431)
        StaBtnWis.Name = "StaBtnWis"
        StaBtnWis.Size = New Size(131, 97)
        StaBtnWis.StatName = "Wis"
        StaBtnWis.TabIndex = 4
        ' 
        ' StaBtnCha
        ' 
        StaBtnCha.Location = New Point(3, 538)
        StaBtnCha.Name = "StaBtnCha"
        StaBtnCha.Size = New Size(131, 97)
        StaBtnCha.StatName = "Cha"
        StaBtnCha.TabIndex = 5
        ' 
        ' TblLaySkillProficiencies
        ' 
        TblLaySkillProficiencies.ColumnCount = 2
        TblLaySkillProficiencies.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLaySkillProficiencies.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLaySkillProficiencies.Controls.Add(Panel1, 1, 6)
        TblLaySkillProficiencies.Controls.Add(Panel2, 1, 7)
        TblLaySkillProficiencies.Controls.Add(Panel3, 1, 8)
        TblLaySkillProficiencies.Controls.Add(Panel4, 1, 9)
        TblLaySkillProficiencies.Controls.Add(Panel5, 1, 10)
        TblLaySkillProficiencies.Controls.Add(Panel6, 1, 11)
        TblLaySkillProficiencies.Controls.Add(Panel7, 1, 12)
        TblLaySkillProficiencies.Controls.Add(Panel8, 1, 13)
        TblLaySkillProficiencies.Controls.Add(Panel9, 1, 14)
        TblLaySkillProficiencies.Controls.Add(Panel10, 1, 15)
        TblLaySkillProficiencies.Controls.Add(Panel11, 1, 16)
        TblLaySkillProficiencies.Controls.Add(Panel12, 1, 17)
        TblLaySkillProficiencies.Dock = DockStyle.Fill
        TblLaySkillProficiencies.Location = New Point(3, 3)
        TblLaySkillProficiencies.Name = "TblLaySkillProficiencies"
        TblLaySkillProficiencies.RowCount = 18
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.16666746F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.RowStyles.Add(New RowStyle(SizeType.Percent, 4.166667F))
        TblLaySkillProficiencies.Size = New Size(713, 642)
        TblLaySkillProficiencies.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(359, 213)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 28)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(359, 248)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 28)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(359, 283)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 28)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(359, 318)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 28)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(359, 353)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 28)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(359, 388)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(200, 28)
        Panel6.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(359, 423)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(200, 28)
        Panel7.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(359, 458)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 28)
        Panel8.TabIndex = 7
        ' 
        ' Panel9
        ' 
        Panel9.Location = New Point(359, 493)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(200, 28)
        Panel9.TabIndex = 8
        ' 
        ' Panel10
        ' 
        Panel10.Location = New Point(359, 528)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(200, 28)
        Panel10.TabIndex = 9
        ' 
        ' Panel11
        ' 
        Panel11.Location = New Point(359, 563)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(200, 28)
        Panel11.TabIndex = 10
        ' 
        ' Panel12
        ' 
        Panel12.Location = New Point(359, 598)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(200, 34)
        Panel12.TabIndex = 11
        ' 
        ' FrmCharacterSheetMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1453, 682)
        Controls.Add(TabLayMain)
        Name = "FrmCharacterSheetMenu"
        Text = "FrmCharacterSheetMenu"
        TabLayMain.ResumeLayout(False)
        TabPgeInfo.ResumeLayout(False)
        TblLayInfo.ResumeLayout(False)
        TblLayInfoTop.ResumeLayout(False)
        TblLayInfoTop.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TblLayStats.ResumeLayout(False)
        TblLayMiscStats.ResumeLayout(False)
        TabPgeSkills.ResumeLayout(False)
        TblLaySkillsMain.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TblLaySkillProficiencies.ResumeLayout(False)
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
    Friend WithEvents TblLaySkillsMain As TableLayoutPanel
    Friend WithEvents TblLaySkillProficiencies As TableLayoutPanel
    Friend WithEvents StaHealth As StatIcon
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents StaBtnStr As RollableStatButton
    Friend WithEvents StaBtnDex As RollableStatButton
    Friend WithEvents StaBtnCon As RollableStatButton
    Friend WithEvents StaBtnInt As RollableStatButton
    Friend WithEvents StaBtnWis As RollableStatButton
    Friend WithEvents StaBtnCha As RollableStatButton
End Class
