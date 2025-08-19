<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RollableStatButton
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
        BtnSkill = New Button()
        LblModifier = New Label()
        LblStatName = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(BtnSkill, 0, 0)
        TableLayoutPanel1.Controls.Add(LblModifier, 0, 1)
        TableLayoutPanel1.Controls.Add(LblStatName, 0, 2)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 60F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(150, 150)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' BtnSkill
        ' 
        BtnSkill.Dock = DockStyle.Fill
        BtnSkill.Location = New Point(3, 3)
        BtnSkill.Name = "BtnSkill"
        BtnSkill.Size = New Size(144, 84)
        BtnSkill.TabIndex = 0
        BtnSkill.Text = "Button1"
        BtnSkill.UseVisualStyleBackColor = True
        ' 
        ' LblModifier
        ' 
        LblModifier.AutoSize = True
        LblModifier.Dock = DockStyle.Fill
        LblModifier.Location = New Point(3, 90)
        LblModifier.Name = "LblModifier"
        LblModifier.Size = New Size(144, 30)
        LblModifier.TabIndex = 1
        LblModifier.Text = "Label1"
        LblModifier.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblStatName
        ' 
        LblStatName.AutoSize = True
        LblStatName.Dock = DockStyle.Fill
        LblStatName.Location = New Point(3, 120)
        LblStatName.Name = "LblStatName"
        LblStatName.Size = New Size(144, 30)
        LblStatName.TabIndex = 2
        LblStatName.Text = "Label1"
        LblStatName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' RollableStatButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "RollableStatButton"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtnSkill As Button
    Friend WithEvents LblModifier As Label
    Friend WithEvents LblStatName As Label

End Class
