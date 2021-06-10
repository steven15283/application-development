<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.businessRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentialRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalLabelBox = New System.Windows.Forms.Label()
        Me.premiumChannelsListBox = New System.Windows.Forms.ListBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.connectionsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'businessRadioButton
        '
        Me.businessRadioButton.AutoSize = True
        Me.businessRadioButton.Checked = True
        Me.businessRadioButton.Location = New System.Drawing.Point(24, 28)
        Me.businessRadioButton.Name = "businessRadioButton"
        Me.businessRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.businessRadioButton.TabIndex = 0
        Me.businessRadioButton.TabStop = True
        Me.businessRadioButton.Text = "Business" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.businessRadioButton.UseVisualStyleBackColor = True
        '
        'residentialRadioButton
        '
        Me.residentialRadioButton.Location = New System.Drawing.Point(24, 60)
        Me.residentialRadioButton.Name = "residentialRadioButton"
        Me.residentialRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.residentialRadioButton.TabIndex = 0
        Me.residentialRadioButton.Text = "Residential"
        Me.residentialRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Due:"
        '
        'totalLabelBox
        '
        Me.totalLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalLabelBox.Location = New System.Drawing.Point(24, 191)
        Me.totalLabelBox.Name = "totalLabelBox"
        Me.totalLabelBox.Size = New System.Drawing.Size(86, 33)
        Me.totalLabelBox.TabIndex = 3
        '
        'premiumChannelsListBox
        '
        Me.premiumChannelsListBox.FormattingEnabled = True
        Me.premiumChannelsListBox.HorizontalScrollbar = True
        Me.premiumChannelsListBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.premiumChannelsListBox.Location = New System.Drawing.Point(140, 37)
        Me.premiumChannelsListBox.Name = "premiumChannelsListBox"
        Me.premiumChannelsListBox.Size = New System.Drawing.Size(85, 82)
        Me.premiumChannelsListBox.TabIndex = 5
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(148, 198)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(133, 26)
        Me.calculateButton.TabIndex = 6
        Me.calculateButton.Text = "Calculate Total Due"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(329, 200)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Premium channels:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Connections:"
        '
        'connectionsListBox
        '
        Me.connectionsListBox.FormattingEnabled = True
        Me.connectionsListBox.HorizontalScrollbar = True
        Me.connectionsListBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.connectionsListBox.Location = New System.Drawing.Point(319, 37)
        Me.connectionsListBox.Name = "connectionsListBox"
        Me.connectionsListBox.Size = New System.Drawing.Size(85, 82)
        Me.connectionsListBox.TabIndex = 11
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 279)
        Me.Controls.Add(Me.residentialRadioButton)
        Me.Controls.Add(Me.businessRadioButton)
        Me.Controls.Add(Me.connectionsListBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.premiumChannelsListBox)
        Me.Controls.Add(Me.totalLabelBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form"
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents businessRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents residentialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalLabelBox As System.Windows.Forms.Label
    Friend WithEvents premiumChannelsListBox As System.Windows.Forms.ListBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents connectionsListBox As System.Windows.Forms.ListBox

End Class
