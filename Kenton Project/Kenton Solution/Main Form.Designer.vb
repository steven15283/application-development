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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.store1Textbox = New System.Windows.Forms.TextBox()
        Me.store2Textbox = New System.Windows.Forms.TextBox()
        Me.store3Textbox = New System.Windows.Forms.TextBox()
        Me.companyTextbox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PayRoll amounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Store1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Store3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Store2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Company:"
        '
        'store1Textbox
        '
        Me.store1Textbox.Location = New System.Drawing.Point(88, 72)
        Me.store1Textbox.Name = "store1Textbox"
        Me.store1Textbox.Size = New System.Drawing.Size(100, 20)
        Me.store1Textbox.TabIndex = 5
        '
        'store2Textbox
        '
        Me.store2Textbox.Location = New System.Drawing.Point(88, 119)
        Me.store2Textbox.Name = "store2Textbox"
        Me.store2Textbox.Size = New System.Drawing.Size(100, 20)
        Me.store2Textbox.TabIndex = 6
        '
        'store3Textbox
        '
        Me.store3Textbox.Location = New System.Drawing.Point(88, 166)
        Me.store3Textbox.Name = "store3Textbox"
        Me.store3Textbox.Size = New System.Drawing.Size(100, 20)
        Me.store3Textbox.TabIndex = 7
        '
        'companyTextbox
        '
        Me.companyTextbox.Location = New System.Drawing.Point(88, 213)
        Me.companyTextbox.Name = "companyTextbox"
        Me.companyTextbox.Size = New System.Drawing.Size(100, 20)
        Me.companyTextbox.TabIndex = 8
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(329, 40)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(85, 31)
        Me.calcButton.TabIndex = 9
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(329, 104)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(85, 31)
        Me.exitButton.TabIndex = 10
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 262)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.companyTextbox)
        Me.Controls.Add(Me.store3Textbox)
        Me.Controls.Add(Me.store2Textbox)
        Me.Controls.Add(Me.store1Textbox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kenton Incorporated"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents store1Textbox As System.Windows.Forms.TextBox
    Friend WithEvents store2Textbox As System.Windows.Forms.TextBox
    Friend WithEvents store3Textbox As System.Windows.Forms.TextBox
    Friend WithEvents companyTextbox As System.Windows.Forms.TextBox
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
