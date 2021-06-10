<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.reportListBox = New System.Windows.Forms.ListBox()
        Me.reportLabel = New System.Windows.Forms.Label()
        Me.reportButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'reportListBox
        '
        Me.reportListBox.FormattingEnabled = True
        Me.reportListBox.Location = New System.Drawing.Point(19, 33)
        Me.reportListBox.Name = "reportListBox"
        Me.reportListBox.Size = New System.Drawing.Size(276, 160)
        Me.reportListBox.TabIndex = 0
        '
        'reportLabel
        '
        Me.reportLabel.AutoSize = True
        Me.reportLabel.Location = New System.Drawing.Point(16, 17)
        Me.reportLabel.Name = "reportLabel"
        Me.reportLabel.Size = New System.Drawing.Size(42, 13)
        Me.reportLabel.TabIndex = 1
        Me.reportLabel.Text = "Report:"
        '
        'reportButton
        '
        Me.reportButton.Location = New System.Drawing.Point(344, 50)
        Me.reportButton.Name = "reportButton"
        Me.reportButton.Size = New System.Drawing.Size(130, 38)
        Me.reportButton.TabIndex = 2
        Me.reportButton.Text = "Display Report"
        Me.reportButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(344, 119)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(130, 33)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 275)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.reportButton)
        Me.Controls.Add(Me.reportLabel)
        Me.Controls.Add(Me.reportListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents reportListBox As System.Windows.Forms.ListBox
    Friend WithEvents reportLabel As System.Windows.Forms.Label
    Friend WithEvents reportButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
