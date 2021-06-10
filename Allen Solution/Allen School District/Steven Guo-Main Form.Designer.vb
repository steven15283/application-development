<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principalName
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
        Me.primarycenterButton = New System.Windows.Forms.Button()
        Me.lewisButton = New System.Windows.Forms.Button()
        Me.kaufmanButton = New System.Windows.Forms.Button()
        Me.allenButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.principalLabel = New System.Windows.Forms.Label()
        Me.principalTextBox = New System.Windows.Forms.Label()
        Me.phoneLabel = New System.Windows.Forms.Label()
        Me.phoneTextBox = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'primarycenterButton
        '
        Me.primarycenterButton.Location = New System.Drawing.Point(78, 111)
        Me.primarycenterButton.Name = "primarycenterButton"
        Me.primarycenterButton.Size = New System.Drawing.Size(297, 57)
        Me.primarycenterButton.TabIndex = 0
        Me.primarycenterButton.Text = "Primary Center"
        Me.primarycenterButton.UseVisualStyleBackColor = True
        '
        'lewisButton
        '
        Me.lewisButton.Location = New System.Drawing.Point(78, 192)
        Me.lewisButton.Name = "lewisButton"
        Me.lewisButton.Size = New System.Drawing.Size(297, 57)
        Me.lewisButton.TabIndex = 1
        Me.lewisButton.Text = "Lewis Midle School"
        Me.lewisButton.UseVisualStyleBackColor = True
        '
        'kaufmanButton
        '
        Me.kaufmanButton.Location = New System.Drawing.Point(78, 301)
        Me.kaufmanButton.Name = "kaufmanButton"
        Me.kaufmanButton.Size = New System.Drawing.Size(297, 57)
        Me.kaufmanButton.TabIndex = 2
        Me.kaufmanButton.Text = "Kaufman Junior High"
        Me.kaufmanButton.UseVisualStyleBackColor = True
        '
        'allenButton
        '
        Me.allenButton.Location = New System.Drawing.Point(78, 380)
        Me.allenButton.Name = "allenButton"
        Me.allenButton.Size = New System.Drawing.Size(297, 57)
        Me.allenButton.TabIndex = 3
        Me.allenButton.Text = "Allen High School"
        Me.allenButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(78, 480)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(297, 57)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'principalLabel
        '
        Me.principalLabel.Location = New System.Drawing.Point(507, 111)
        Me.principalLabel.Name = "principalLabel"
        Me.principalLabel.Size = New System.Drawing.Size(131, 30)
        Me.principalLabel.TabIndex = 5
        Me.principalLabel.Text = "Principal:"
        '
        'principalTextBox
        '
        Me.principalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.principalTextBox.Location = New System.Drawing.Point(507, 141)
        Me.principalTextBox.Name = "principalTextBox"
        Me.principalTextBox.Size = New System.Drawing.Size(335, 56)
        Me.principalTextBox.TabIndex = 6
        Me.principalTextBox.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'phoneLabel
        '
        Me.phoneLabel.AutoSize = True
        Me.phoneLabel.Location = New System.Drawing.Point(507, 257)
        Me.phoneLabel.Name = "phoneLabel"
        Me.phoneLabel.Size = New System.Drawing.Size(46, 15)
        Me.phoneLabel.TabIndex = 7
        Me.phoneLabel.Text = "Phone:"
        '
        'phoneTextBox
        '
        Me.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.phoneTextBox.Location = New System.Drawing.Point(507, 285)
        Me.phoneTextBox.Name = "phoneTextBox"
        Me.phoneTextBox.Size = New System.Drawing.Size(334, 57)
        Me.phoneTextBox.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Allen_School_District.My.Resources.Resources.School
        Me.PictureBox1.Location = New System.Drawing.Point(648, 416)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 202)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'principalName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 648)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.phoneTextBox)
        Me.Controls.Add(Me.phoneLabel)
        Me.Controls.Add(Me.principalTextBox)
        Me.Controls.Add(Me.principalLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.allenButton)
        Me.Controls.Add(Me.kaufmanButton)
        Me.Controls.Add(Me.lewisButton)
        Me.Controls.Add(Me.primarycenterButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "principalName"
        Me.Text = "Allen School District"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents primarycenterButton As System.Windows.Forms.Button
    Friend WithEvents lewisButton As System.Windows.Forms.Button
    Friend WithEvents kaufmanButton As System.Windows.Forms.Button
    Friend WithEvents allenButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents principalLabel As System.Windows.Forms.Label
    Friend WithEvents principalTextBox As System.Windows.Forms.Label
    Friend WithEvents phoneLabel As System.Windows.Forms.Label
    Friend WithEvents phoneTextBox As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
