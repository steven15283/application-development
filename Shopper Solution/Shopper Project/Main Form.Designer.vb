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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.totalmonthlypurchase = New System.Windows.Forms.Label()
        Me.rewardpoints = New System.Windows.Forms.Label()
        Me.monthlyPurchase = New System.Windows.Forms.TextBox()
        Me.rewardLabel = New System.Windows.Forms.Label()
        Me.basiccheckBox = New System.Windows.Forms.RadioButton()
        Me.standardcheckBox = New System.Windows.Forms.RadioButton()
        Me.premiumcheckBox = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(222, 174)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(351, 174)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(73, 23)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'totalmonthlypurchase
        '
        Me.totalmonthlypurchase.AutoSize = True
        Me.totalmonthlypurchase.Location = New System.Drawing.Point(31, 47)
        Me.totalmonthlypurchase.Name = "totalmonthlypurchase"
        Me.totalmonthlypurchase.Size = New System.Drawing.Size(135, 13)
        Me.totalmonthlypurchase.TabIndex = 5
        Me.totalmonthlypurchase.Text = "Total monthly purchase ($):"
        '
        'rewardpoints
        '
        Me.rewardpoints.AutoSize = True
        Me.rewardpoints.Location = New System.Drawing.Point(34, 142)
        Me.rewardpoints.Name = "rewardpoints"
        Me.rewardpoints.Size = New System.Drawing.Size(79, 13)
        Me.rewardpoints.TabIndex = 6
        Me.rewardpoints.Text = "Reward Points:"
        '
        'monthlyPurchase
        '
        Me.monthlyPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthlyPurchase.Location = New System.Drawing.Point(35, 81)
        Me.monthlyPurchase.Name = "monthlyPurchase"
        Me.monthlyPurchase.Size = New System.Drawing.Size(112, 35)
        Me.monthlyPurchase.TabIndex = 7
        '
        'rewardLabel
        '
        Me.rewardLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rewardLabel.Location = New System.Drawing.Point(33, 164)
        Me.rewardLabel.Name = "rewardLabel"
        Me.rewardLabel.Size = New System.Drawing.Size(114, 33)
        Me.rewardLabel.TabIndex = 8
        '
        'basiccheckBox
        '
        Me.basiccheckBox.AutoSize = True
        Me.basiccheckBox.Checked = True
        Me.basiccheckBox.Location = New System.Drawing.Point(351, 45)
        Me.basiccheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.basiccheckBox.Name = "basiccheckBox"
        Me.basiccheckBox.Size = New System.Drawing.Size(51, 17)
        Me.basiccheckBox.TabIndex = 9
        Me.basiccheckBox.TabStop = True
        Me.basiccheckBox.Text = "&Basic"
        Me.basiccheckBox.UseVisualStyleBackColor = True
        '
        'standardcheckBox
        '
        Me.standardcheckBox.AutoSize = True
        Me.standardcheckBox.Location = New System.Drawing.Point(351, 82)
        Me.standardcheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.standardcheckBox.Name = "standardcheckBox"
        Me.standardcheckBox.Size = New System.Drawing.Size(68, 17)
        Me.standardcheckBox.TabIndex = 10
        Me.standardcheckBox.TabStop = True
        Me.standardcheckBox.Text = "Standard"
        Me.standardcheckBox.UseVisualStyleBackColor = True
        '
        'premiumcheckBox
        '
        Me.premiumcheckBox.AutoSize = True
        Me.premiumcheckBox.Location = New System.Drawing.Point(351, 119)
        Me.premiumcheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.premiumcheckBox.Name = "premiumcheckBox"
        Me.premiumcheckBox.Size = New System.Drawing.Size(65, 17)
        Me.premiumcheckBox.TabIndex = 11
        Me.premiumcheckBox.TabStop = True
        Me.premiumcheckBox.Text = "Premium"
        Me.premiumcheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 237)
        Me.Controls.Add(Me.premiumcheckBox)
        Me.Controls.Add(Me.standardcheckBox)
        Me.Controls.Add(Me.basiccheckBox)
        Me.Controls.Add(Me.rewardLabel)
        Me.Controls.Add(Me.monthlyPurchase)
        Me.Controls.Add(Me.rewardpoints)
        Me.Controls.Add(Me.totalmonthlypurchase)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Name = "Form1"
        Me.Text = "Main Form.vb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents totalmonthlypurchase As System.Windows.Forms.Label
    Friend WithEvents rewardpoints As System.Windows.Forms.Label
    Friend WithEvents monthlyPurchase As System.Windows.Forms.TextBox
    Friend WithEvents rewardLabel As System.Windows.Forms.Label
    Friend WithEvents basiccheckBox As System.Windows.Forms.RadioButton
    Friend WithEvents standardcheckBox As System.Windows.Forms.RadioButton
    Friend WithEvents premiumcheckBox As System.Windows.Forms.RadioButton

End Class
