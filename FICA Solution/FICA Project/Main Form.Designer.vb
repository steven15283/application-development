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
        Me.year2DateEarnings = New System.Windows.Forms.TextBox()
        Me.currentEarningsBox = New System.Windows.Forms.TextBox()
        Me.year2Date = New System.Windows.Forms.Label()
        Me.currentEarningsLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.currentFICATax = New System.Windows.Forms.Label()
        Me.currentFICATaxLabel = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'year2DateEarnings
        '
        Me.year2DateEarnings.Location = New System.Drawing.Point(25, 64)
        Me.year2DateEarnings.Name = "year2DateEarnings"
        Me.year2DateEarnings.Size = New System.Drawing.Size(148, 20)
        Me.year2DateEarnings.TabIndex = 0
        '
        'currentEarningsBox
        '
        Me.currentEarningsBox.Location = New System.Drawing.Point(278, 64)
        Me.currentEarningsBox.Name = "currentEarningsBox"
        Me.currentEarningsBox.Size = New System.Drawing.Size(140, 20)
        Me.currentEarningsBox.TabIndex = 1
        '
        'year2Date
        '
        Me.year2Date.AutoSize = True
        Me.year2Date.Location = New System.Drawing.Point(43, 19)
        Me.year2Date.Name = "year2Date"
        Me.year2Date.Size = New System.Drawing.Size(111, 13)
        Me.year2Date.TabIndex = 2
        Me.year2Date.Text = "Year-to-date earnings:"
        '
        'currentEarningsLabel
        '
        Me.currentEarningsLabel.AutoSize = True
        Me.currentEarningsLabel.Location = New System.Drawing.Point(307, 19)
        Me.currentEarningsLabel.Name = "currentEarningsLabel"
        Me.currentEarningsLabel.Size = New System.Drawing.Size(84, 13)
        Me.currentEarningsLabel.TabIndex = 3
        Me.currentEarningsLabel.Text = "Current earnings"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FICA_Project.My.Resources.Resources.FICA
        Me.PictureBox1.Location = New System.Drawing.Point(35, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'currentFICATax
        '
        Me.currentFICATax.AutoSize = True
        Me.currentFICATax.Location = New System.Drawing.Point(304, 145)
        Me.currentFICATax.Name = "currentFICATax"
        Me.currentFICATax.Size = New System.Drawing.Size(87, 13)
        Me.currentFICATax.TabIndex = 5
        Me.currentFICATax.Text = "Current FICA tax:"
        '
        'currentFICATaxLabel
        '
        Me.currentFICATaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.currentFICATaxLabel.Location = New System.Drawing.Point(264, 172)
        Me.currentFICATaxLabel.Name = "currentFICATaxLabel"
        Me.currentFICATaxLabel.Size = New System.Drawing.Size(154, 44)
        Me.currentFICATaxLabel.TabIndex = 6
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(550, 48)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 7
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(550, 135)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 252)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.currentFICATaxLabel)
        Me.Controls.Add(Me.currentFICATax)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.currentEarningsLabel)
        Me.Controls.Add(Me.year2Date)
        Me.Controls.Add(Me.currentEarningsBox)
        Me.Controls.Add(Me.year2DateEarnings)
        Me.Name = "Form1"
        Me.Text = "FICA Tax Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents year2DateEarnings As System.Windows.Forms.TextBox
    Friend WithEvents currentEarningsBox As System.Windows.Forms.TextBox
    Friend WithEvents year2Date As System.Windows.Forms.Label
    Friend WithEvents currentEarningsLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents currentFICATax As System.Windows.Forms.Label
    Friend WithEvents currentFICATaxLabel As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
