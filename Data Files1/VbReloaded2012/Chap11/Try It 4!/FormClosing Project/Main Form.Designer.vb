﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.membersListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Members:"
        '
        'membersListBox
        '
        Me.membersListBox.FormattingEnabled = True
        Me.membersListBox.ItemHeight = 17
        Me.membersListBox.Items.AddRange(New Object() {"Abby", "Barbara", "Connie", "Donald", "Edward"})
        Me.membersListBox.Location = New System.Drawing.Point(44, 34)
        Me.membersListBox.Name = "membersListBox"
        Me.membersListBox.Size = New System.Drawing.Size(87, 89)
        Me.membersListBox.TabIndex = 1
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(189, 34)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 27)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 149)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.membersListBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormClosing Examples"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents membersListBox As System.Windows.Forms.ListBox
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
