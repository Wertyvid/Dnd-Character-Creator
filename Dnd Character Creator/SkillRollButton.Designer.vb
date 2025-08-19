<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkillRollButton
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
        BtnRollSkill = New Button()
        ChkProficient = New CheckBox()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 11.1111107F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 88.8888855F))
        TableLayoutPanel1.Controls.Add(BtnRollSkill, 1, 0)
        TableLayoutPanel1.Controls.Add(ChkProficient, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Size = New Size(621, 50)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' BtnRollSkill
        ' 
        BtnRollSkill.Dock = DockStyle.Fill
        BtnRollSkill.Location = New Point(71, 3)
        BtnRollSkill.Name = "BtnRollSkill"
        BtnRollSkill.Size = New Size(547, 44)
        BtnRollSkill.TabIndex = 0
        BtnRollSkill.Text = "Button1"
        BtnRollSkill.UseVisualStyleBackColor = True
        ' 
        ' ChkProficient
        ' 
        ChkProficient.AutoSize = True
        ChkProficient.Dock = DockStyle.Fill
        ChkProficient.Enabled = False
        ChkProficient.Location = New Point(3, 3)
        ChkProficient.Name = "ChkProficient"
        ChkProficient.Size = New Size(62, 44)
        ChkProficient.TabIndex = 1
        ChkProficient.TextAlign = ContentAlignment.MiddleCenter
        ChkProficient.UseVisualStyleBackColor = True
        ' 
        ' SkillRollButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "SkillRollButton"
        Size = New Size(621, 50)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnRollSkill As Button
    Friend WithEvents ChkProficient As CheckBox

End Class
