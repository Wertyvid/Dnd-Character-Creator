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
        BtnApply = New Button()
        CmbBoxRaceSelect = New ComboBox()
        TabPgeStats = New TabPage()
        TabLayMain.SuspendLayout()
        TabPgeClass.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabLayMain
        ' 
        TabLayMain.Controls.Add(TabPgeClass)
        TabLayMain.Controls.Add(TabPgeStats)
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
        TableLayoutPanel1.Controls.Add(BtnApply, 1, 0)
        TableLayoutPanel1.Controls.Add(CmbBoxRaceSelect, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(3, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(786, 416)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' CmbBoxClassSelect
        ' 
        CmbBoxClassSelect.FormattingEnabled = True
        CmbBoxClassSelect.Location = New Point(3, 3)
        CmbBoxClassSelect.Name = "CmbBoxClassSelect"
        CmbBoxClassSelect.Size = New Size(121, 23)
        CmbBoxClassSelect.TabIndex = 1
        ' 
        ' BtnApply
        ' 
        BtnApply.Location = New Point(396, 3)
        BtnApply.Name = "BtnApply"
        BtnApply.Size = New Size(75, 23)
        BtnApply.TabIndex = 2
        BtnApply.Text = "Apply!"
        BtnApply.UseVisualStyleBackColor = True
        ' 
        ' CmbBoxRaceSelect
        ' 
        CmbBoxRaceSelect.FormattingEnabled = True
        CmbBoxRaceSelect.Location = New Point(3, 211)
        CmbBoxRaceSelect.Name = "CmbBoxRaceSelect"
        CmbBoxRaceSelect.Size = New Size(121, 23)
        CmbBoxRaceSelect.TabIndex = 3
        ' 
        ' TabPgeStats
        ' 
        TabPgeStats.Location = New Point(4, 24)
        TabPgeStats.Name = "TabPgeStats"
        TabPgeStats.Padding = New Padding(3)
        TabPgeStats.Size = New Size(792, 422)
        TabPgeStats.TabIndex = 1
        TabPgeStats.Text = "Stats"
        TabPgeStats.UseVisualStyleBackColor = True
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabLayMain As TabControl
    Friend WithEvents TabPgeClass As TabPage
    Friend WithEvents TabPgeStats As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CmbBoxClassSelect As ComboBox
    Friend WithEvents BtnApply As Button
    Friend WithEvents CmbBoxRaceSelect As ComboBox
End Class
