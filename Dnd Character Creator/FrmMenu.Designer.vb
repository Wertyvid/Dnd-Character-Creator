<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TableLayoutPanel1 = New TableLayoutPanel()
        BtnNewCharacter = New Button()
        BtnCharacterSheet = New Button()
        CharacterSheetSelector = New OpenFileDialog()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(BtnNewCharacter, 0, 1)
        TableLayoutPanel1.Controls.Add(BtnCharacterSheet, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Size = New Size(800, 450)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' BtnNewCharacter
        ' 
        BtnNewCharacter.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        BtnNewCharacter.AutoSize = True
        BtnNewCharacter.Location = New Point(274, 228)
        BtnNewCharacter.Name = "BtnNewCharacter"
        BtnNewCharacter.Size = New Size(123, 25)
        BtnNewCharacter.TabIndex = 0
        BtnNewCharacter.Text = "Make new character"
        BtnNewCharacter.UseVisualStyleBackColor = True
        ' 
        ' BtnCharacterSheet
        ' 
        BtnCharacterSheet.AutoSize = True
        BtnCharacterSheet.Location = New Point(403, 228)
        BtnCharacterSheet.Name = "BtnCharacterSheet"
        BtnCharacterSheet.Size = New Size(129, 25)
        BtnCharacterSheet.TabIndex = 1
        BtnCharacterSheet.Text = "Open character sheet"
        BtnCharacterSheet.UseVisualStyleBackColor = True
        ' 
        ' CharacterSheetSelector
        ' 
        CharacterSheetSelector.DefaultExt = "json"
        CharacterSheetSelector.FileName = "OpenFileDialog1"
        CharacterSheetSelector.Filter = "Jsons|*json"
        CharacterSheetSelector.InitialDirectory = "characters"
        CharacterSheetSelector.Title = "Select Character"
        ' 
        ' FrmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "FrmMenu"
        Text = "Form1"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnNewCharacter As Button
    Friend WithEvents BtnCharacterSheet As Button
    Friend WithEvents CharacterSheetSelector As OpenFileDialog

End Class
