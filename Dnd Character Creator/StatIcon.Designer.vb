﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatIcon
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
        LblName = New Label()
        LblValue = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 1
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.Controls.Add(LblName, 0, 1)
        TableLayoutPanel1.Controls.Add(LblValue, 0, 0)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 80F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 20F))
        TableLayoutPanel1.Size = New Size(75, 75)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Dock = DockStyle.Fill
        LblName.Location = New Point(3, 60)
        LblName.Name = "LblName"
        LblName.Size = New Size(69, 15)
        LblName.TabIndex = 0
        LblName.Text = "LblName"
        LblName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblValue
        ' 
        LblValue.AutoSize = True
        LblValue.Dock = DockStyle.Fill
        LblValue.Font = New Font("Segoe UI", 9F)
        LblValue.Location = New Point(3, 0)
        LblValue.Name = "LblValue"
        LblValue.Size = New Size(69, 60)
        LblValue.TabIndex = 1
        LblValue.Text = "LblValue"
        LblValue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' StatIcon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(TableLayoutPanel1)
        Name = "StatIcon"
        Size = New Size(75, 75)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LblName As Label
    Friend WithEvents LblValue As Label

End Class
