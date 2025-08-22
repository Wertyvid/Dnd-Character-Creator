<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCharacterCreatorMenu
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
        TabPgeClass = New TabPage()
        TableLayoutPanel1 = New TableLayoutPanel()
        CmbBoxClassSelect = New ComboBox()
        BtnApplyClassRace = New Button()
        CmbBoxRaceSelect = New ComboBox()
        CmbBoxBackgroundSelect = New ComboBox()
        TabPgeStats = New TabPage()
        TableLayoutPanel2 = New TableLayoutPanel()
        TableLayoutPanel3 = New TableLayoutPanel()
        LblPointsRemaining = New Label()
        LblStandardArray = New Label()
        TableLayoutPanel4 = New TableLayoutPanel()
        BtnApplyStats = New Button()
        NumWis = New NumericUpDown()
        NumCha = New NumericUpDown()
        NumInt = New NumericUpDown()
        NumCon = New NumericUpDown()
        NumDex = New NumericUpDown()
        NumStr = New NumericUpDown()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TabPgeSkills = New TabPage()
        TableLayoutPanel5 = New TableLayoutPanel()
        FlwLaySkillOptions = New FlowLayoutPanel()
        Label7 = New Label()
        BtnApplySkills = New Button()
        TabPgeDetails = New TabPage()
        TableLayoutPanel7 = New TableLayoutPanel()
        TxtBoxName = New TextBox()
        Label8 = New Label()
        BtnApplyDetails = New Button()
        Label9 = New Label()
        CmbBoxAlignmentSelect = New ComboBox()
        TabPgeSave = New TabPage()
        TableLayoutPanel6 = New TableLayoutPanel()
        BtnSave = New Button()
        SaveCharacterSelector = New SaveFileDialog()
        TabLayMain.SuspendLayout()
        TabPgeClass.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        TabPgeStats.SuspendLayout()
        TableLayoutPanel2.SuspendLayout()
        TableLayoutPanel3.SuspendLayout()
        TableLayoutPanel4.SuspendLayout()
        CType(NumWis, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumCha, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumInt, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumCon, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumDex, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumStr, ComponentModel.ISupportInitialize).BeginInit()
        TabPgeSkills.SuspendLayout()
        TableLayoutPanel5.SuspendLayout()
        FlwLaySkillOptions.SuspendLayout()
        TabPgeDetails.SuspendLayout()
        TableLayoutPanel7.SuspendLayout()
        TabPgeSave.SuspendLayout()
        TableLayoutPanel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabLayMain
        ' 
        TabLayMain.Controls.Add(TabPgeClass)
        TabLayMain.Controls.Add(TabPgeStats)
        TabLayMain.Controls.Add(TabPgeSkills)
        TabLayMain.Controls.Add(TabPgeDetails)
        TabLayMain.Controls.Add(TabPgeSave)
        TabLayMain.Dock = DockStyle.Fill
        TabLayMain.Location = New Point(0, 0)
        TabLayMain.Name = "TabLayMain"
        TabLayMain.SelectedIndex = 0
        TabLayMain.Size = New Size(800, 450)
        TabLayMain.TabIndex = 0
        ' 
        ' TabPgeClass
        ' 
        TabPgeClass.Controls.Add(TableLayoutPanel1)
        TabPgeClass.Location = New Point(4, 24)
        TabPgeClass.Name = "TabPgeClass"
        TabPgeClass.Padding = New Padding(3)
        TabPgeClass.Size = New Size(792, 422)
        TabPgeClass.TabIndex = 0
        TabPgeClass.Text = "Class & Race"
        TabPgeClass.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(CmbBoxClassSelect, 0, 0)
        TableLayoutPanel1.Controls.Add(BtnApplyClassRace, 1, 0)
        TableLayoutPanel1.Controls.Add(CmbBoxRaceSelect, 0, 1)
        TableLayoutPanel1.Controls.Add(CmbBoxBackgroundSelect, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(786, 416)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' CmbBoxClassSelect
        ' 
        CmbBoxClassSelect.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxClassSelect.FormattingEnabled = True
        CmbBoxClassSelect.Location = New Point(3, 3)
        CmbBoxClassSelect.Name = "CmbBoxClassSelect"
        CmbBoxClassSelect.Size = New Size(121, 23)
        CmbBoxClassSelect.TabIndex = 1
        ' 
        ' BtnApplyClassRace
        ' 
        BtnApplyClassRace.Location = New Point(396, 3)
        BtnApplyClassRace.Name = "BtnApplyClassRace"
        BtnApplyClassRace.Size = New Size(75, 23)
        BtnApplyClassRace.TabIndex = 2
        BtnApplyClassRace.Text = "Apply!"
        BtnApplyClassRace.UseVisualStyleBackColor = True
        ' 
        ' CmbBoxRaceSelect
        ' 
        CmbBoxRaceSelect.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxRaceSelect.FormattingEnabled = True
        CmbBoxRaceSelect.Location = New Point(3, 141)
        CmbBoxRaceSelect.Name = "CmbBoxRaceSelect"
        CmbBoxRaceSelect.Size = New Size(121, 23)
        CmbBoxRaceSelect.TabIndex = 3
        ' 
        ' CmbBoxBackgroundSelect
        ' 
        CmbBoxBackgroundSelect.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxBackgroundSelect.FormattingEnabled = True
        CmbBoxBackgroundSelect.Location = New Point(3, 279)
        CmbBoxBackgroundSelect.Name = "CmbBoxBackgroundSelect"
        CmbBoxBackgroundSelect.Size = New Size(121, 23)
        CmbBoxBackgroundSelect.TabIndex = 4
        ' 
        ' TabPgeStats
        ' 
        TabPgeStats.Controls.Add(TableLayoutPanel2)
        TabPgeStats.Location = New Point(4, 24)
        TabPgeStats.Name = "TabPgeStats"
        TabPgeStats.Padding = New Padding(3)
        TabPgeStats.Size = New Size(792, 422)
        TabPgeStats.TabIndex = 1
        TabPgeStats.Text = "Stats"
        TabPgeStats.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 1
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Controls.Add(TableLayoutPanel3, 0, 1)
        TableLayoutPanel2.Controls.Add(TableLayoutPanel4, 0, 0)
        TableLayoutPanel2.Dock = DockStyle.Fill
        TableLayoutPanel2.Location = New Point(3, 3)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(786, 416)
        TableLayoutPanel2.TabIndex = 0
        ' 
        ' TableLayoutPanel3
        ' 
        TableLayoutPanel3.ColumnCount = 2
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Controls.Add(LblPointsRemaining, 1, 0)
        TableLayoutPanel3.Controls.Add(LblStandardArray, 0, 0)
        TableLayoutPanel3.Dock = DockStyle.Fill
        TableLayoutPanel3.Location = New Point(3, 211)
        TableLayoutPanel3.Name = "TableLayoutPanel3"
        TableLayoutPanel3.RowCount = 1
        TableLayoutPanel3.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel3.Size = New Size(780, 202)
        TableLayoutPanel3.TabIndex = 0
        ' 
        ' LblPointsRemaining
        ' 
        LblPointsRemaining.AutoSize = True
        LblPointsRemaining.Location = New Point(393, 0)
        LblPointsRemaining.Name = "LblPointsRemaining"
        LblPointsRemaining.Size = New Size(202, 30)
        LblPointsRemaining.TabIndex = 0
        LblPointsRemaining.Text = "Don't go above 15 if using point buy!" & vbCrLf & "Point Buy Points remaining:"
        ' 
        ' LblStandardArray
        ' 
        LblStandardArray.AutoSize = True
        LblStandardArray.Location = New Point(3, 0)
        LblStandardArray.Name = "LblStandardArray"
        LblStandardArray.Size = New Size(141, 105)
        LblStandardArray.TabIndex = 1
        LblStandardArray.Text = "Standard array values are:" & vbCrLf & "15" & vbCrLf & "14" & vbCrLf & "13" & vbCrLf & "12" & vbCrLf & "10" & vbCrLf & "8" & vbCrLf
        ' 
        ' TableLayoutPanel4
        ' 
        TableLayoutPanel4.ColumnCount = 7
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.28571F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.2857161F))
        TableLayoutPanel4.Controls.Add(BtnApplyStats, 6, 0)
        TableLayoutPanel4.Controls.Add(NumWis, 4, 1)
        TableLayoutPanel4.Controls.Add(NumCha, 5, 1)
        TableLayoutPanel4.Controls.Add(NumInt, 3, 1)
        TableLayoutPanel4.Controls.Add(NumCon, 2, 1)
        TableLayoutPanel4.Controls.Add(NumDex, 1, 1)
        TableLayoutPanel4.Controls.Add(NumStr, 0, 1)
        TableLayoutPanel4.Controls.Add(Label1, 5, 0)
        TableLayoutPanel4.Controls.Add(Label2, 4, 0)
        TableLayoutPanel4.Controls.Add(Label3, 3, 0)
        TableLayoutPanel4.Controls.Add(Label4, 2, 0)
        TableLayoutPanel4.Controls.Add(Label5, 1, 0)
        TableLayoutPanel4.Controls.Add(Label6, 0, 0)
        TableLayoutPanel4.Dock = DockStyle.Fill
        TableLayoutPanel4.Location = New Point(3, 3)
        TableLayoutPanel4.Name = "TableLayoutPanel4"
        TableLayoutPanel4.RowCount = 2
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel4.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel4.Size = New Size(780, 202)
        TableLayoutPanel4.TabIndex = 1
        ' 
        ' BtnApplyStats
        ' 
        BtnApplyStats.Location = New Point(669, 3)
        BtnApplyStats.Name = "BtnApplyStats"
        BtnApplyStats.Size = New Size(75, 23)
        BtnApplyStats.TabIndex = 6
        BtnApplyStats.Text = "Apply!"
        BtnApplyStats.UseVisualStyleBackColor = True
        ' 
        ' NumWis
        ' 
        NumWis.Anchor = AnchorStyles.None
        NumWis.Location = New Point(447, 109)
        NumWis.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumWis.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumWis.Name = "NumWis"
        NumWis.Size = New Size(105, 23)
        NumWis.TabIndex = 2
        NumWis.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumCha
        ' 
        NumCha.Anchor = AnchorStyles.None
        NumCha.Location = New Point(558, 109)
        NumCha.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumCha.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumCha.Name = "NumCha"
        NumCha.Size = New Size(105, 23)
        NumCha.TabIndex = 3
        NumCha.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumInt
        ' 
        NumInt.Anchor = AnchorStyles.None
        NumInt.Location = New Point(336, 109)
        NumInt.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumInt.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumInt.Name = "NumInt"
        NumInt.Size = New Size(105, 23)
        NumInt.TabIndex = 0
        NumInt.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumCon
        ' 
        NumCon.Anchor = AnchorStyles.None
        NumCon.Location = New Point(225, 109)
        NumCon.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumCon.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumCon.Name = "NumCon"
        NumCon.Size = New Size(105, 23)
        NumCon.TabIndex = 1
        NumCon.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumDex
        ' 
        NumDex.Anchor = AnchorStyles.None
        NumDex.Location = New Point(114, 109)
        NumDex.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumDex.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumDex.Name = "NumDex"
        NumDex.Size = New Size(105, 23)
        NumDex.TabIndex = 4
        NumDex.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' NumStr
        ' 
        NumStr.Anchor = AnchorStyles.None
        NumStr.Location = New Point(3, 109)
        NumStr.Maximum = New Decimal(New Integer() {15, 0, 0, 0})
        NumStr.Minimum = New Decimal(New Integer() {8, 0, 0, 0})
        NumStr.Name = "NumStr"
        NumStr.Size = New Size(105, 23)
        NumStr.TabIndex = 5
        NumStr.Value = New Decimal(New Integer() {8, 0, 0, 0})
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(558, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 15)
        Label1.TabIndex = 7
        Label1.Text = "Charisma"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(447, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 8
        Label2.Text = "Wisdom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(336, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 15)
        Label3.TabIndex = 9
        Label3.Text = "Intelligence"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(225, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 15)
        Label4.TabIndex = 10
        Label4.Text = "Constitution"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(114, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 15)
        Label5.TabIndex = 11
        Label5.Text = "Dexterity"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 12
        Label6.Text = "Strength"
        ' 
        ' TabPgeSkills
        ' 
        TabPgeSkills.Controls.Add(TableLayoutPanel5)
        TabPgeSkills.Location = New Point(4, 24)
        TabPgeSkills.Name = "TabPgeSkills"
        TabPgeSkills.Padding = New Padding(3)
        TabPgeSkills.Size = New Size(792, 422)
        TabPgeSkills.TabIndex = 2
        TabPgeSkills.Text = "Proficiences"
        TabPgeSkills.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel5
        ' 
        TableLayoutPanel5.ColumnCount = 2
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Controls.Add(FlwLaySkillOptions, 0, 0)
        TableLayoutPanel5.Controls.Add(BtnApplySkills, 1, 0)
        TableLayoutPanel5.Dock = DockStyle.Fill
        TableLayoutPanel5.Location = New Point(3, 3)
        TableLayoutPanel5.Name = "TableLayoutPanel5"
        TableLayoutPanel5.RowCount = 2
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel5.Size = New Size(786, 416)
        TableLayoutPanel5.TabIndex = 0
        ' 
        ' FlwLaySkillOptions
        ' 
        FlwLaySkillOptions.Controls.Add(Label7)
        FlwLaySkillOptions.Location = New Point(3, 3)
        FlwLaySkillOptions.Name = "FlwLaySkillOptions"
        FlwLaySkillOptions.Size = New Size(128, 202)
        FlwLaySkillOptions.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(103, 30)
        Label7.TabIndex = 1
        Label7.Text = "Pick a class to see your skill options!"
        ' 
        ' BtnApplySkills
        ' 
        BtnApplySkills.Location = New Point(396, 3)
        BtnApplySkills.Name = "BtnApplySkills"
        BtnApplySkills.Size = New Size(75, 23)
        BtnApplySkills.TabIndex = 1
        BtnApplySkills.Text = "Apply!"
        BtnApplySkills.UseVisualStyleBackColor = True
        ' 
        ' TabPgeDetails
        ' 
        TabPgeDetails.Controls.Add(TableLayoutPanel7)
        TabPgeDetails.Location = New Point(4, 24)
        TabPgeDetails.Name = "TabPgeDetails"
        TabPgeDetails.Padding = New Padding(3)
        TabPgeDetails.Size = New Size(792, 422)
        TabPgeDetails.TabIndex = 4
        TabPgeDetails.Text = "Details"
        TabPgeDetails.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel7
        ' 
        TableLayoutPanel7.ColumnCount = 3
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25F))
        TableLayoutPanel7.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel7.Controls.Add(TxtBoxName, 1, 0)
        TableLayoutPanel7.Controls.Add(Label8, 0, 0)
        TableLayoutPanel7.Controls.Add(BtnApplyDetails, 2, 0)
        TableLayoutPanel7.Controls.Add(Label9, 0, 1)
        TableLayoutPanel7.Controls.Add(CmbBoxAlignmentSelect, 1, 1)
        TableLayoutPanel7.Dock = DockStyle.Fill
        TableLayoutPanel7.Location = New Point(3, 3)
        TableLayoutPanel7.Name = "TableLayoutPanel7"
        TableLayoutPanel7.RowCount = 3
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel7.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel7.Size = New Size(786, 416)
        TableLayoutPanel7.TabIndex = 0
        ' 
        ' TxtBoxName
        ' 
        TxtBoxName.Location = New Point(199, 3)
        TxtBoxName.Name = "TxtBoxName"
        TxtBoxName.Size = New Size(100, 23)
        TxtBoxName.TabIndex = 0
        TxtBoxName.Text = "Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 1
        Label8.Text = "Name:"
        ' 
        ' BtnApplyDetails
        ' 
        BtnApplyDetails.Location = New Point(395, 3)
        BtnApplyDetails.Name = "BtnApplyDetails"
        BtnApplyDetails.Size = New Size(75, 23)
        BtnApplyDetails.TabIndex = 2
        BtnApplyDetails.Text = "Apply!"
        BtnApplyDetails.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(3, 138)
        Label9.Name = "Label9"
        Label9.Size = New Size(63, 15)
        Label9.TabIndex = 3
        Label9.Text = "Alignment"
        ' 
        ' CmbBoxAlignmentSelect
        ' 
        CmbBoxAlignmentSelect.DropDownStyle = ComboBoxStyle.DropDownList
        CmbBoxAlignmentSelect.FormattingEnabled = True
        CmbBoxAlignmentSelect.Location = New Point(199, 141)
        CmbBoxAlignmentSelect.Name = "CmbBoxAlignmentSelect"
        CmbBoxAlignmentSelect.Size = New Size(121, 23)
        CmbBoxAlignmentSelect.TabIndex = 4
        ' 
        ' TabPgeSave
        ' 
        TabPgeSave.Controls.Add(TableLayoutPanel6)
        TabPgeSave.Location = New Point(4, 24)
        TabPgeSave.Name = "TabPgeSave"
        TabPgeSave.Padding = New Padding(3)
        TabPgeSave.Size = New Size(792, 422)
        TabPgeSave.TabIndex = 3
        TabPgeSave.Text = "Save!"
        TabPgeSave.UseVisualStyleBackColor = True
        ' 
        ' TableLayoutPanel6
        ' 
        TableLayoutPanel6.ColumnCount = 2
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Controls.Add(BtnSave, 1, 0)
        TableLayoutPanel6.Dock = DockStyle.Fill
        TableLayoutPanel6.Location = New Point(3, 3)
        TableLayoutPanel6.Name = "TableLayoutPanel6"
        TableLayoutPanel6.RowCount = 2
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel6.Size = New Size(786, 416)
        TableLayoutPanel6.TabIndex = 0
        ' 
        ' BtnSave
        ' 
        BtnSave.Location = New Point(396, 3)
        BtnSave.Name = "BtnSave"
        BtnSave.Size = New Size(75, 23)
        BtnSave.TabIndex = 0
        BtnSave.Text = "Save!"
        BtnSave.UseVisualStyleBackColor = True
        ' 
        ' SaveCharacterSelector
        ' 
        SaveCharacterSelector.DefaultExt = "json"
        SaveCharacterSelector.Filter = "json|*.json"
        ' 
        ' FrmCharacterCreatorMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabLayMain)
        Name = "FrmCharacterCreatorMenu"
        Text = "FrmCharacterCreatorMenu"
        TabLayMain.ResumeLayout(False)
        TabPgeClass.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TabPgeStats.ResumeLayout(False)
        TableLayoutPanel2.ResumeLayout(False)
        TableLayoutPanel3.ResumeLayout(False)
        TableLayoutPanel3.PerformLayout()
        TableLayoutPanel4.ResumeLayout(False)
        TableLayoutPanel4.PerformLayout()
        CType(NumWis, ComponentModel.ISupportInitialize).EndInit()
        CType(NumCha, ComponentModel.ISupportInitialize).EndInit()
        CType(NumInt, ComponentModel.ISupportInitialize).EndInit()
        CType(NumCon, ComponentModel.ISupportInitialize).EndInit()
        CType(NumDex, ComponentModel.ISupportInitialize).EndInit()
        CType(NumStr, ComponentModel.ISupportInitialize).EndInit()
        TabPgeSkills.ResumeLayout(False)
        TableLayoutPanel5.ResumeLayout(False)
        FlwLaySkillOptions.ResumeLayout(False)
        FlwLaySkillOptions.PerformLayout()
        TabPgeDetails.ResumeLayout(False)
        TableLayoutPanel7.ResumeLayout(False)
        TableLayoutPanel7.PerformLayout()
        TabPgeSave.ResumeLayout(False)
        TableLayoutPanel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabLayMain As TabControl
    Friend WithEvents TabPgeClass As TabPage
    Friend WithEvents TabPgeStats As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CmbBoxClassSelect As ComboBox
    Friend WithEvents BtnApplyClassRace As Button
    Friend WithEvents CmbBoxRaceSelect As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LblPointsRemaining As Label
    Friend WithEvents LblStandardArray As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents NumCon As NumericUpDown
    Friend WithEvents NumDex As NumericUpDown
    Friend WithEvents NumStr As NumericUpDown
    Friend WithEvents BtnApplyStats As Button
    Friend WithEvents NumWis As NumericUpDown
    Friend WithEvents NumCha As NumericUpDown
    Friend WithEvents NumInt As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TabPgeSkills As TabPage
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents FlwLaySkillOptions As FlowLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnApplySkills As Button
    Friend WithEvents TabPgeSave As TabPage
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents BtnSave As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CmbBoxBackgroundSelect As ComboBox
    Friend WithEvents TabPgeDetails As TabPage
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TxtBoxName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnApplyDetails As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents CmbBoxAlignmentSelect As ComboBox
    Friend WithEvents SaveCharacterSelector As SaveFileDialog
End Class
