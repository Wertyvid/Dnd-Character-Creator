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
        TabPgeFeatures = New TabPage()
        TblLayFeaturesMain = New TableLayoutPanel()
        TxtBoxFeatures = New TextBox()
        TabPgeSkills = New TabPage()
        TblLaySkillsMain = New TableLayoutPanel()
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
        TableLayoutPanel3 = New TableLayoutPanel()
        StaBtnCha = New RollableStatButton()
        StaBtnWis = New RollableStatButton()
        StaBtnInt = New RollableStatButton()
        StaBtnCon = New RollableStatButton()
        StaBtnDex = New RollableStatButton()
        StaBtnStr = New RollableStatButton()
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
        TabLayMain = New TabControl()
        TabPgeHealth = New TabPage()
        TblLayHealthMain = New TableLayoutPanel()
        TableLayoutPanel4 = New TableLayoutPanel()
        TblLayHealthPoints = New TableLayoutPanel()
        Label1 = New Label()
        SpnBoxHealth = New NumericUpDown()
        LblHealthMax = New Label()
        SpnBoxHealthMod = New NumericUpDown()
        Label3 = New Label()
        BtnApplyHealthModify = New Button()
        TableLayoutPanel2 = New TableLayoutPanel()
        SpnBoxTempHp = New NumericUpDown()
        Label2 = New Label()
        TblLayDeathSaves = New TableLayoutPanel()
        Label5 = New Label()
        ChkListsDeathSavesN = New CheckedListBox()
        ChkLstDeathSavesN = New CheckedListBox()
        Label4 = New Label()
        ChkListConditions = New CheckedListBox()
        TabPgeAttacks = New TabPage()
        TableLayoutPanel5 = New TableLayoutPanel()
        TableLayoutPanel6 = New TableLayoutPanel()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        AttackHandler1 = New AttackHandler()
        AttackHandler2 = New AttackHandler()
        AttackHandler3 = New AttackHandler()
        TableLayoutPanel7 = New TableLayoutPanel()
        SpnBoxDXroll = New NumericUpDown()
        BtnBasicDiceRoll = New Button()
        TabPgeFeatures.SuspendLayout()
        TblLayFeaturesMain.SuspendLayout()
        TabPgeSkills.SuspendLayout()
        TblLaySkillsMain.SuspendLayout()
        TblLaySkillProficiencies.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TabPgeInfo.SuspendLayout()
        TblLayInfo.SuspendLayout()
        TblLayInfoTop.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TblLayStats.SuspendLayout()
        TblLayMiscStats.SuspendLayout()
        TabLayMain.SuspendLayout()
        TabPgeHealth.SuspendLayout()
        TblLayHealthMain.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        TblLayHealthPoints.SuspendLayout()
        CType(SpnBoxHealth, ComponentModel.ISupportInitialize).BeginInit()
        CType(SpnBoxHealthMod, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel2.SuspendLayout()
        CType(SpnBoxTempHp, ComponentModel.ISupportInitialize).BeginInit()
        TblLayDeathSaves.SuspendLayout()
        TabPgeAttacks.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        CType(SpnBoxDXroll, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabPgeFeatures
        ' 
        TabPgeFeatures.Controls.Add(TblLayFeaturesMain)
        TabPgeFeatures.Location = New Point(4, 24)
        TabPgeFeatures.Name = "TabPgeFeatures"
        TabPgeFeatures.Padding = New Padding(3)
        TabPgeFeatures.Size = New Size(192, 72)
        TabPgeFeatures.TabIndex = 2
        TabPgeFeatures.Text = "Features"
        TabPgeFeatures.UseVisualStyleBackColor = True
        ' 
        ' TblLayFeaturesMain
        ' 
        TblLayFeaturesMain.ColumnCount = 1
        TblLayFeaturesMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayFeaturesMain.Controls.Add(TxtBoxFeatures, 0, 0)
        TblLayFeaturesMain.Dock = DockStyle.Fill
        TblLayFeaturesMain.Location = New Point(3, 3)
        TblLayFeaturesMain.Name = "TblLayFeaturesMain"
        TblLayFeaturesMain.RowCount = 1
        TblLayFeaturesMain.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayFeaturesMain.Size = New Size(186, 66)
        TblLayFeaturesMain.TabIndex = 0
        ' 
        ' TxtBoxFeatures
        ' 
        TxtBoxFeatures.Dock = DockStyle.Fill
        TxtBoxFeatures.Location = New Point(3, 3)
        TxtBoxFeatures.Multiline = True
        TxtBoxFeatures.Name = "TxtBoxFeatures"
        TxtBoxFeatures.ReadOnly = True
        TxtBoxFeatures.ScrollBars = ScrollBars.Vertical
        TxtBoxFeatures.Size = New Size(180, 60)
        TxtBoxFeatures.TabIndex = 0
        ' 
        ' TabPgeSkills
        ' 
        TabPgeSkills.Controls.Add(TblLaySkillsMain)
        TabPgeSkills.Location = New Point(4, 24)
        TabPgeSkills.Name = "TabPgeSkills"
        TabPgeSkills.Padding = New Padding(3)
        TabPgeSkills.Size = New Size(192, 72)
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
        TblLaySkillsMain.Controls.Add(TblLaySkillProficiencies, 0, 0)
        TblLaySkillsMain.Controls.Add(TableLayoutPanel3, 1, 0)
        TblLaySkillsMain.Dock = DockStyle.Fill
        TblLaySkillsMain.Location = New Point(3, 3)
        TblLaySkillsMain.Name = "TblLaySkillsMain"
        TblLaySkillsMain.RowCount = 1
        TblLaySkillsMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TblLaySkillsMain.Size = New Size(186, 66)
        TblLaySkillsMain.TabIndex = 0
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
        TblLaySkillProficiencies.Size = New Size(87, 60)
        TblLaySkillProficiencies.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(46, 21)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(38, 1)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(46, 24)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(38, 1)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Location = New Point(46, 27)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(38, 1)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Location = New Point(46, 30)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(38, 1)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Location = New Point(46, 33)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(38, 1)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.Location = New Point(46, 36)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(38, 1)
        Panel6.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.Location = New Point(46, 39)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(38, 1)
        Panel7.TabIndex = 6
        ' 
        ' Panel8
        ' 
        Panel8.Location = New Point(46, 42)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(38, 1)
        Panel8.TabIndex = 7
        ' 
        ' Panel9
        ' 
        Panel9.Location = New Point(46, 45)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(38, 1)
        Panel9.TabIndex = 8
        ' 
        ' Panel10
        ' 
        Panel10.Location = New Point(46, 48)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(38, 1)
        Panel10.TabIndex = 9
        ' 
        ' Panel11
        ' 
        Panel11.Location = New Point(46, 51)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(38, 1)
        Panel11.TabIndex = 10
        ' 
        ' Panel12
        ' 
        Panel12.Location = New Point(46, 54)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(38, 3)
        Panel12.TabIndex = 11
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 1
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel3.Controls.Add(StaBtnCha, 0, 5)
        TableLayoutPanel3.Controls.Add(StaBtnWis, 0, 4)
        TableLayoutPanel3.Controls.Add(StaBtnInt, 0, 3)
        TableLayoutPanel3.Controls.Add(StaBtnCon, 0, 2)
        TableLayoutPanel3.Controls.Add(StaBtnDex, 0, 1)
        TableLayoutPanel3.Controls.Add(StaBtnStr, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(96, 3)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 6
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel3.Size = New Size(12, 60)
        TableLayoutPanel3.TabIndex = 2
        ' 
        ' StaBtnCha
        ' 
        StaBtnCha.Location = New Point(3, 53)
        StaBtnCha.Name = "StaBtnCha"
        StaBtnCha.Size = New Size(6, 4)
        StaBtnCha.StatName = "Cha"
        StaBtnCha.TabIndex = 6
        ' 
        ' StaBtnWis
        ' 
        StaBtnWis.Location = New Point(3, 43)
        StaBtnWis.Name = "StaBtnWis"
        StaBtnWis.Size = New Size(6, 4)
        StaBtnWis.StatName = "Wis"
        StaBtnWis.TabIndex = 5
        ' 
        ' StaBtnInt
        ' 
        StaBtnInt.Location = New Point(3, 33)
        StaBtnInt.Name = "StaBtnInt"
        StaBtnInt.Size = New Size(6, 4)
        StaBtnInt.StatName = "Int"
        StaBtnInt.TabIndex = 4
        ' 
        ' StaBtnCon
        ' 
        StaBtnCon.Location = New Point(3, 23)
        StaBtnCon.Name = "StaBtnCon"
        StaBtnCon.Size = New Size(6, 4)
        StaBtnCon.StatName = "Con"
        StaBtnCon.TabIndex = 3
        ' 
        ' StaBtnDex
        ' 
        StaBtnDex.Location = New Point(3, 13)
        StaBtnDex.Name = "StaBtnDex"
        StaBtnDex.Size = New Size(6, 4)
        StaBtnDex.StatName = "Dex"
        StaBtnDex.TabIndex = 2
        ' 
        ' StaBtnStr
        ' 
        StaBtnStr.Location = New Point(3, 3)
        StaBtnStr.Name = "StaBtnStr"
        StaBtnStr.Size = New Size(6, 4)
        StaBtnStr.StatName = "Str"
        StaBtnStr.TabIndex = 1
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
        ' TabLayMain
        ' 
        TabLayMain.Controls.Add(TabPgeInfo)
        TabLayMain.Controls.Add(TabPgeHealth)
        TabLayMain.Controls.Add(TabPgeSkills)
        TabLayMain.Controls.Add(TabPgeAttacks)
        TabLayMain.Controls.Add(TabPgeFeatures)
        TabLayMain.Dock = DockStyle.Fill
        TabLayMain.Location = New Point(0, 0)
        TabLayMain.Name = "TabLayMain"
        TabLayMain.SelectedIndex = 0
        TabLayMain.Size = New Size(1453, 682)
        TabLayMain.TabIndex = 0
        ' 
        ' TabPgeHealth
        ' 
        TabPgeHealth.Controls.Add(TblLayHealthMain)
        TabPgeHealth.Location = New Point(4, 24)
        TabPgeHealth.Name = "TabPgeHealth"
        TabPgeHealth.Size = New Size(1445, 654)
        TabPgeHealth.TabIndex = 3
        TabPgeHealth.Text = "Health"
        TabPgeHealth.UseVisualStyleBackColor = True
        ' 
        ' TblLayHealthMain
        ' 
        TblLayHealthMain.ColumnCount = 2
        TblLayHealthMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayHealthMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayHealthMain.Controls.Add(TableLayoutPanel4, 0, 0)
        TblLayHealthMain.Controls.Add(ChkListConditions, 1, 0)
        TblLayHealthMain.Dock = DockStyle.Fill
        TblLayHealthMain.Location = New Point(0, 0)
        TblLayHealthMain.Name = "TblLayHealthMain"
        TblLayHealthMain.RowCount = 2
        TblLayHealthMain.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealthMain.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealthMain.Size = New Size(1445, 654)
        TblLayHealthMain.TabIndex = 0
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 2
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Controls.Add(TblLayHealthPoints, 0, 0)
        TableLayoutPanel4.Controls.Add(TableLayoutPanel2, 1, 0)
        TableLayoutPanel4.Controls.Add(TblLayDeathSaves, 0, 1)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel4.Size = New Size(716, 321)
        TableLayoutPanel4.TabIndex = 0
        ' 
        ' TblLayHealthPoints
        ' 
        TblLayHealthPoints.ColumnCount = 3
        TblLayHealthPoints.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TblLayHealthPoints.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20F))
        TblLayHealthPoints.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TblLayHealthPoints.Controls.Add(Label1, 0, 0)
        TblLayHealthPoints.Controls.Add(SpnBoxHealth, 1, 0)
        TblLayHealthPoints.Controls.Add(LblHealthMax, 2, 0)
        TblLayHealthPoints.Controls.Add(SpnBoxHealthMod, 1, 1)
        TblLayHealthPoints.Controls.Add(Label3, 0, 1)
        TblLayHealthPoints.Controls.Add(BtnApplyHealthModify, 2, 1)
        TblLayHealthPoints.Dock = DockStyle.Fill
        TblLayHealthPoints.Location = New Point(3, 3)
        TblLayHealthPoints.Name = "TblLayHealthPoints"
        TblLayHealthPoints.RowCount = 2
        TblLayHealthPoints.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealthPoints.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TblLayHealthPoints.Size = New Size(352, 154)
        TblLayHealthPoints.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 77)
        Label1.TabIndex = 1
        Label1.Text = "Health: "
        Label1.TextAlign = ContentAlignment.TopRight
        ' 
        ' SpnBoxHealth
        ' 
        SpnBoxHealth.Dock = DockStyle.Top
        SpnBoxHealth.Font = New Font("Segoe UI", 9F)
        SpnBoxHealth.Location = New Point(143, 3)
        SpnBoxHealth.Maximum = New Decimal(New Integer() {0, 0, 0, 0})
        SpnBoxHealth.Name = "SpnBoxHealth"
        SpnBoxHealth.Size = New Size(64, 23)
        SpnBoxHealth.TabIndex = 1
        ' 
        ' LblHealthMax
        ' 
        LblHealthMax.AutoSize = True
        LblHealthMax.Dock = DockStyle.Fill
        LblHealthMax.Font = New Font("Segoe UI", 12F)
        LblHealthMax.Location = New Point(213, 0)
        LblHealthMax.Name = "LblHealthMax"
        LblHealthMax.Size = New Size(136, 77)
        LblHealthMax.TabIndex = 2
        LblHealthMax.Text = "Label2"
        ' 
        ' SpnBoxHealthMod
        ' 
        SpnBoxHealthMod.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SpnBoxHealthMod.Location = New Point(143, 80)
        SpnBoxHealthMod.Minimum = New Decimal(New Integer() {100, 0, 0, Integer.MinValue})
        SpnBoxHealthMod.Name = "SpnBoxHealthMod"
        SpnBoxHealthMod.Size = New Size(64, 23)
        SpnBoxHealthMod.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(66, 77)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 21)
        Label3.TabIndex = 4
        Label3.Text = "Damage:"
        ' 
        ' BtnApplyHealthModify
        ' 
        BtnApplyHealthModify.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        BtnApplyHealthModify.AutoSize = True
        BtnApplyHealthModify.Location = New Point(213, 80)
        BtnApplyHealthModify.Name = "BtnApplyHealthModify"
        BtnApplyHealthModify.Size = New Size(136, 25)
        BtnApplyHealthModify.TabIndex = 5
        BtnApplyHealthModify.Text = "Apply!"
        BtnApplyHealthModify.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(SpnBoxTempHp, 1, 0)
        TableLayoutPanel2.Controls.Add(Label2, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(361, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(352, 154)
        TableLayoutPanel2.TabIndex = 3
        ' 
        ' SpnBoxTempHp
        ' 
        SpnBoxTempHp.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SpnBoxTempHp.Location = New Point(179, 3)
        SpnBoxTempHp.Minimum = New Decimal(New Integer() {10000, 0, 0, Integer.MinValue})
        SpnBoxTempHp.Name = "SpnBoxTempHp"
        SpnBoxTempHp.Size = New Size(170, 23)
        SpnBoxTempHp.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(62, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 21)
        Label2.TabIndex = 1
        Label2.Text = "Temporary HP:"
        ' 
        ' TblLayDeathSaves
        ' 
        TblLayDeathSaves.ColumnCount = 2
        TblLayDeathSaves.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayDeathSaves.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TblLayDeathSaves.Controls.Add(Label5, 1, 0)
        TblLayDeathSaves.Controls.Add(ChkListsDeathSavesN, 1, 1)
        TblLayDeathSaves.Controls.Add(ChkLstDeathSavesN, 0, 1)
        TblLayDeathSaves.Controls.Add(Label4, 0, 0)
        TblLayDeathSaves.Dock = DockStyle.Fill
        TblLayDeathSaves.Location = New Point(3, 163)
        TblLayDeathSaves.Name = "TblLayDeathSaves"
        TblLayDeathSaves.RowCount = 2
        TblLayDeathSaves.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TblLayDeathSaves.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TblLayDeathSaves.Size = New Size(352, 155)
        TblLayDeathSaves.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Location = New Point(179, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 15)
        Label5.TabIndex = 3
        Label5.Text = "|Failed Death Saves"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ChkListsDeathSavesN
        ' 
        ChkListsDeathSavesN.CheckOnClick = True
        ChkListsDeathSavesN.Dock = DockStyle.Fill
        ChkListsDeathSavesN.FormattingEnabled = True
        ChkListsDeathSavesN.Items.AddRange(New Object() {"1", "2", "3"})
        ChkListsDeathSavesN.Location = New Point(179, 34)
        ChkListsDeathSavesN.Name = "ChkListsDeathSavesN"
        ChkListsDeathSavesN.Size = New Size(170, 118)
        ChkListsDeathSavesN.TabIndex = 0
        ' 
        ' ChkLstDeathSavesN
        ' 
        ChkLstDeathSavesN.CheckOnClick = True
        ChkLstDeathSavesN.Dock = DockStyle.Fill
        ChkLstDeathSavesN.FormattingEnabled = True
        ChkLstDeathSavesN.Items.AddRange(New Object() {"1", "2", "3"})
        ChkLstDeathSavesN.Location = New Point(3, 34)
        ChkLstDeathSavesN.Name = "ChkLstDeathSavesN"
        ChkLstDeathSavesN.RightToLeft = RightToLeft.Yes
        ChkLstDeathSavesN.Size = New Size(170, 118)
        ChkLstDeathSavesN.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(43, 8)
        Label4.Name = "Label4"
        Label4.Size = New Size(130, 15)
        Label4.TabIndex = 2
        Label4.Text = "Succeded Death  Saves|"
        Label4.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ChkListConditions
        ' 
        ChkListConditions.CheckOnClick = True
        ChkListConditions.Dock = DockStyle.Fill
        ChkListConditions.FormattingEnabled = True
        ChkListConditions.Items.AddRange(New Object() {"Blinded", "Charmed", "Deafened", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralysed", "Petrified", "Poisoned", "Prone", "Restrained", "Stunned"})
        ChkListConditions.Location = New Point(725, 3)
        ChkListConditions.Name = "ChkListConditions"
        ChkListConditions.RightToLeft = RightToLeft.Yes
        ChkListConditions.Size = New Size(717, 321)
        ChkListConditions.TabIndex = 1
        ' 
        ' TabPgeAttacks
        ' 
        TabPgeAttacks.Controls.Add(TableLayoutPanel5)
        TabPgeAttacks.Location = New Point(4, 24)
        TabPgeAttacks.Name = "TabPgeAttacks"
        TabPgeAttacks.Size = New Size(192, 72)
        TabPgeAttacks.TabIndex = 4
        TabPgeAttacks.Text = "Attacks"
        TabPgeAttacks.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 40F))
        TableLayoutPanel5.Controls.Add(TableLayoutPanel6, 0, 0)
        TableLayoutPanel5.Controls.Add(AttackHandler1, 0, 1)
        TableLayoutPanel5.Controls.Add(AttackHandler2, 0, 2)
        TableLayoutPanel5.Controls.Add(AttackHandler3, 0, 3)
        TableLayoutPanel5.Controls.Add(TableLayoutPanel7, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(0, 0)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 5
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel5.Size = New Size(192, 72)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 9
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel6.Controls.Add(Label12, 6, 0)
        TableLayoutPanel6.Controls.Add(Label11, 5, 0)
        TableLayoutPanel6.Controls.Add(Label10, 4, 0)
        TableLayoutPanel6.Controls.Add(Label9, 3, 0)
        TableLayoutPanel6.Controls.Add(Label8, 2, 0)
        TableLayoutPanel6.Controls.Add(Label7, 1, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 1
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel6.Size = New Size(109, 8)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Location = New Point(75, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(6, 8)
        Label12.TabIndex = 6
        Label12.Text = "Weapon +X"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.Location = New Point(63, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(6, 8)
        Label11.TabIndex = 5
        Label11.Text = "Damage Type"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(51, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(6, 8)
        Label10.TabIndex = 4
        Label10.Text = "Xd"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(39, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(6, 8)
        Label9.TabIndex = 3
        Label9.Text = "dX"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(27, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(6, 8)
        Label8.TabIndex = 2
        Label8.Text = "Stat"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(15, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(6, 8)
        Label7.TabIndex = 1
        Label7.Text = "Name"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' AttackHandler1
        ' 
        AttackHandler1.Dock = DockStyle.Fill
        AttackHandler1.IsProficient = False
        AttackHandler1.IsSpell = False
        AttackHandler1.Location = New Point(3, 17)
        AttackHandler1.Name = "AttackHandler1"
        AttackHandler1.Size = New Size(109, 8)
        AttackHandler1.TabIndex = 1
        ' 
        ' AttackHandler2
        ' 
        AttackHandler2.Dock = DockStyle.Fill
        AttackHandler2.IsProficient = False
        AttackHandler2.IsSpell = False
        AttackHandler2.Location = New Point(3, 31)
        AttackHandler2.Name = "AttackHandler2"
        AttackHandler2.Size = New Size(109, 8)
        AttackHandler2.TabIndex = 2
        ' 
        ' AttackHandler3
        ' 
        AttackHandler3.Dock = DockStyle.Fill
        AttackHandler3.IsProficient = False
        AttackHandler3.IsSpell = False
        AttackHandler3.Location = New Point(3, 45)
        AttackHandler3.Name = "AttackHandler3"
        AttackHandler3.Size = New Size(109, 8)
        AttackHandler3.TabIndex = 3
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 2
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(SpnBoxDXroll, 1, 0)
        TableLayoutPanel7.Controls.Add(BtnBasicDiceRoll, 0, 0)
        TableLayoutPanel7.Dock = DockStyle.Right
        TableLayoutPanel7.Location = New Point(118, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 2
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Size = New Size(71, 8)
        TableLayoutPanel7.TabIndex = 4
        ' 
        ' SpnBoxDXroll
        ' 
        SpnBoxDXroll.Location = New Point(38, 3)
        SpnBoxDXroll.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        SpnBoxDXroll.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        SpnBoxDXroll.Name = "SpnBoxDXroll"
        SpnBoxDXroll.Size = New Size(30, 23)
        SpnBoxDXroll.TabIndex = 0
        SpnBoxDXroll.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' BtnBasicDiceRoll
        ' 
        BtnBasicDiceRoll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnBasicDiceRoll.Location = New Point(3, 3)
        BtnBasicDiceRoll.Name = "BtnBasicDiceRoll"
        BtnBasicDiceRoll.Size = New Size(29, 1)
        BtnBasicDiceRoll.TabIndex = 1
        BtnBasicDiceRoll.Text = "Roll D"
        BtnBasicDiceRoll.TextAlign = ContentAlignment.MiddleRight
        BtnBasicDiceRoll.UseVisualStyleBackColor = True
        ' 
        ' FrmCharacterSheetMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1453, 682)
        Controls.Add(TabLayMain)
        Name = "FrmCharacterSheetMenu"
        Text = "FrmCharacterSheetMenu"
        TabPgeFeatures.ResumeLayout(False)
        TblLayFeaturesMain.ResumeLayout(False)
        TblLayFeaturesMain.PerformLayout()
        TabPgeSkills.ResumeLayout(False)
        TblLaySkillsMain.ResumeLayout(False)
        TblLaySkillProficiencies.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TabPgeInfo.ResumeLayout(False)
        TblLayInfo.ResumeLayout(False)
        TblLayInfoTop.ResumeLayout(False)
        TblLayInfoTop.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TblLayStats.ResumeLayout(False)
        TblLayMiscStats.ResumeLayout(False)
        TabLayMain.ResumeLayout(False)
        TabPgeHealth.ResumeLayout(False)
        TblLayHealthMain.ResumeLayout(False)
        TableLayoutPanel4.ResumeLayout(False)
        TblLayHealthPoints.ResumeLayout(False)
        TblLayHealthPoints.PerformLayout()
        CType(SpnBoxHealth, ComponentModel.ISupportInitialize).EndInit()
        CType(SpnBoxHealthMod, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel2.PerformLayout()
        CType(SpnBoxTempHp, ComponentModel.ISupportInitialize).EndInit()
        TblLayDeathSaves.ResumeLayout(False)
        TblLayDeathSaves.PerformLayout()
        TabPgeAttacks.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        TableLayoutPanel6.PerformLayout()
        TableLayoutPanel7.ResumeLayout(False)
        CType(SpnBoxDXroll, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabPgeFeatures As TabPage
    Friend WithEvents TblLayFeaturesMain As TableLayoutPanel
    Friend WithEvents TabPgeSkills As TabPage
    Friend WithEvents TblLaySkillsMain As TableLayoutPanel
    Friend WithEvents TblLaySkillProficiencies As TableLayoutPanel
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
    Friend WithEvents TabPgeInfo As TabPage
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
    Friend WithEvents StaHealth As StatIcon
    Friend WithEvents StaProficiency As StatIcon
    Friend WithEvents StaSpeed As StatIcon
    Friend WithEvents StaInitiative As StatIcon
    Friend WithEvents StaAC As StatIcon
    Friend WithEvents TabLayMain As TabControl
    Friend WithEvents FlwLayFeatures As FlowLayoutPanel
    Friend WithEvents TxtBoxFeatures As TextBox
    Friend WithEvents TabPgeHealth As TabPage
    Friend WithEvents TblLayHealthMain As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents SpnBoxHealth As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents TblLayHealthPoints As TableLayoutPanel
    Friend WithEvents LblHealthMax As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SpnBoxTempHp As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents SpnBoxHealthMod As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnApplyHealthModify As Button
    Friend WithEvents TblLayDeathSaves As TableLayoutPanel
    Friend WithEvents ChkListConditions As CheckedListBox
    Friend WithEvents ChkListsDeathSavesN As CheckedListBox
    Friend WithEvents ChkLstDeathSavesN As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPgeAttacks As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents AttackHandler1 As AttackHandler
    Friend WithEvents AttackHandler2 As AttackHandler
    Friend WithEvents AttackHandler3 As AttackHandler
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents SpnBoxDXroll As NumericUpDown
    Friend WithEvents BtnBasicDiceRoll As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents StaBtnCha As RollableStatButton
    Friend WithEvents StaBtnWis As RollableStatButton
    Friend WithEvents StaBtnInt As RollableStatButton
    Friend WithEvents StaBtnCon As RollableStatButton
    Friend WithEvents StaBtnDex As RollableStatButton
    Friend WithEvents StaBtnStr As RollableStatButton
End Class
