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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.orchestraLabel = New System.Windows.Forms.Label()
        Me.mainfloorLabel = New System.Windows.Forms.Label()
        Me.balconyLabel = New System.Windows.Forms.Label()
        Me.ticketsLabel = New System.Windows.Forms.Label()
        Me.revenueLabel = New System.Windows.Forms.Label()
        Me.percentOfRevenueLabel = New System.Windows.Forms.Label()
        Me.numberOfOrchestra = New System.Windows.Forms.TextBox()
        Me.numberOfMainFloor = New System.Windows.Forms.TextBox()
        Me.numberOfBalcony = New System.Windows.Forms.TextBox()
        Me.totalRevenueLabel = New System.Windows.Forms.Label()
        Me.revenueOfOrchestra = New System.Windows.Forms.Label()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.revenueOfMainFloor = New System.Windows.Forms.Label()
        Me.revenueOfBalcony = New System.Windows.Forms.Label()
        Me.totalRevenueLabelBox = New System.Windows.Forms.Label()
        Me.percentOfBalcony = New System.Windows.Forms.Label()
        Me.percentOfMainFloor = New System.Windows.Forms.Label()
        Me.percentOfOrchestra = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Myran_Project.My.Resources.Resources.Notes
        Me.PictureBox1.Location = New System.Drawing.Point(10, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 146)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'orchestraLabel
        '
        Me.orchestraLabel.AutoSize = True
        Me.orchestraLabel.Location = New System.Drawing.Point(105, 44)
        Me.orchestraLabel.Name = "orchestraLabel"
        Me.orchestraLabel.Size = New System.Drawing.Size(56, 13)
        Me.orchestraLabel.TabIndex = 1
        Me.orchestraLabel.Text = "Orchestra:"
        '
        'mainfloorLabel
        '
        Me.mainfloorLabel.AutoSize = True
        Me.mainfloorLabel.Location = New System.Drawing.Point(102, 109)
        Me.mainfloorLabel.Name = "mainfloorLabel"
        Me.mainfloorLabel.Size = New System.Drawing.Size(59, 13)
        Me.mainfloorLabel.TabIndex = 2
        Me.mainfloorLabel.Text = "Main Floor:"
        '
        'balconyLabel
        '
        Me.balconyLabel.AutoSize = True
        Me.balconyLabel.Location = New System.Drawing.Point(102, 182)
        Me.balconyLabel.Name = "balconyLabel"
        Me.balconyLabel.Size = New System.Drawing.Size(48, 13)
        Me.balconyLabel.TabIndex = 3
        Me.balconyLabel.Text = "Balcony:"
        '
        'ticketsLabel
        '
        Me.ticketsLabel.AutoSize = True
        Me.ticketsLabel.Location = New System.Drawing.Point(184, 19)
        Me.ticketsLabel.Name = "ticketsLabel"
        Me.ticketsLabel.Size = New System.Drawing.Size(42, 13)
        Me.ticketsLabel.TabIndex = 4
        Me.ticketsLabel.Text = "Tickets"
        '
        'revenueLabel
        '
        Me.revenueLabel.AutoSize = True
        Me.revenueLabel.Location = New System.Drawing.Point(320, 19)
        Me.revenueLabel.Name = "revenueLabel"
        Me.revenueLabel.Size = New System.Drawing.Size(51, 13)
        Me.revenueLabel.TabIndex = 5
        Me.revenueLabel.Text = "Revenue"
        '
        'percentOfRevenueLabel
        '
        Me.percentOfRevenueLabel.AutoSize = True
        Me.percentOfRevenueLabel.Location = New System.Drawing.Point(475, 19)
        Me.percentOfRevenueLabel.Name = "percentOfRevenueLabel"
        Me.percentOfRevenueLabel.Size = New System.Drawing.Size(74, 13)
        Me.percentOfRevenueLabel.TabIndex = 6
        Me.percentOfRevenueLabel.Text = "% of Revenue"
        '
        'numberOfOrchestra
        '
        Me.numberOfOrchestra.Location = New System.Drawing.Point(167, 41)
        Me.numberOfOrchestra.Name = "numberOfOrchestra"
        Me.numberOfOrchestra.Size = New System.Drawing.Size(72, 20)
        Me.numberOfOrchestra.TabIndex = 8
        '
        'numberOfMainFloor
        '
        Me.numberOfMainFloor.Location = New System.Drawing.Point(167, 109)
        Me.numberOfMainFloor.Name = "numberOfMainFloor"
        Me.numberOfMainFloor.Size = New System.Drawing.Size(72, 20)
        Me.numberOfMainFloor.TabIndex = 9
        '
        'numberOfBalcony
        '
        Me.numberOfBalcony.Location = New System.Drawing.Point(167, 182)
        Me.numberOfBalcony.Name = "numberOfBalcony"
        Me.numberOfBalcony.Size = New System.Drawing.Size(72, 20)
        Me.numberOfBalcony.TabIndex = 10
        '
        'totalRevenueLabel
        '
        Me.totalRevenueLabel.AutoSize = True
        Me.totalRevenueLabel.Location = New System.Drawing.Point(102, 262)
        Me.totalRevenueLabel.Name = "totalRevenueLabel"
        Me.totalRevenueLabel.Size = New System.Drawing.Size(76, 13)
        Me.totalRevenueLabel.TabIndex = 11
        Me.totalRevenueLabel.Text = "Total revenue:"
        '
        'revenueOfOrchestra
        '
        Me.revenueOfOrchestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.revenueOfOrchestra.Location = New System.Drawing.Point(293, 41)
        Me.revenueOfOrchestra.Name = "revenueOfOrchestra"
        Me.revenueOfOrchestra.Size = New System.Drawing.Size(119, 36)
        Me.revenueOfOrchestra.TabIndex = 13
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(404, 262)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(96, 43)
        Me.calcButton.TabIndex = 17
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(534, 262)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(96, 43)
        Me.exitButton.TabIndex = 18
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'revenueOfMainFloor
        '
        Me.revenueOfMainFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.revenueOfMainFloor.Location = New System.Drawing.Point(293, 108)
        Me.revenueOfMainFloor.Name = "revenueOfMainFloor"
        Me.revenueOfMainFloor.Size = New System.Drawing.Size(119, 36)
        Me.revenueOfMainFloor.TabIndex = 19
        '
        'revenueOfBalcony
        '
        Me.revenueOfBalcony.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.revenueOfBalcony.Location = New System.Drawing.Point(293, 181)
        Me.revenueOfBalcony.Name = "revenueOfBalcony"
        Me.revenueOfBalcony.Size = New System.Drawing.Size(119, 36)
        Me.revenueOfBalcony.TabIndex = 20
        '
        'totalRevenueLabelBox
        '
        Me.totalRevenueLabelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalRevenueLabelBox.Location = New System.Drawing.Point(252, 261)
        Me.totalRevenueLabelBox.Name = "totalRevenueLabelBox"
        Me.totalRevenueLabelBox.Size = New System.Drawing.Size(119, 36)
        Me.totalRevenueLabelBox.TabIndex = 21
        '
        'percentOfBalcony
        '
        Me.percentOfBalcony.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.percentOfBalcony.Location = New System.Drawing.Point(454, 181)
        Me.percentOfBalcony.Name = "percentOfBalcony"
        Me.percentOfBalcony.Size = New System.Drawing.Size(119, 36)
        Me.percentOfBalcony.TabIndex = 24
        '
        'percentOfMainFloor
        '
        Me.percentOfMainFloor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.percentOfMainFloor.Location = New System.Drawing.Point(454, 108)
        Me.percentOfMainFloor.Name = "percentOfMainFloor"
        Me.percentOfMainFloor.Size = New System.Drawing.Size(119, 36)
        Me.percentOfMainFloor.TabIndex = 23
        '
        'percentOfOrchestra
        '
        Me.percentOfOrchestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.percentOfOrchestra.Location = New System.Drawing.Point(454, 41)
        Me.percentOfOrchestra.Name = "percentOfOrchestra"
        Me.percentOfOrchestra.Size = New System.Drawing.Size(119, 36)
        Me.percentOfOrchestra.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 332)
        Me.Controls.Add(Me.percentOfBalcony)
        Me.Controls.Add(Me.percentOfMainFloor)
        Me.Controls.Add(Me.percentOfOrchestra)
        Me.Controls.Add(Me.totalRevenueLabelBox)
        Me.Controls.Add(Me.revenueOfBalcony)
        Me.Controls.Add(Me.revenueOfMainFloor)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.revenueOfOrchestra)
        Me.Controls.Add(Me.totalRevenueLabel)
        Me.Controls.Add(Me.numberOfBalcony)
        Me.Controls.Add(Me.numberOfMainFloor)
        Me.Controls.Add(Me.numberOfOrchestra)
        Me.Controls.Add(Me.percentOfRevenueLabel)
        Me.Controls.Add(Me.revenueLabel)
        Me.Controls.Add(Me.ticketsLabel)
        Me.Controls.Add(Me.balconyLabel)
        Me.Controls.Add(Me.mainfloorLabel)
        Me.Controls.Add(Me.orchestraLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents orchestraLabel As System.Windows.Forms.Label
    Friend WithEvents mainfloorLabel As System.Windows.Forms.Label
    Friend WithEvents balconyLabel As System.Windows.Forms.Label
    Friend WithEvents ticketsLabel As System.Windows.Forms.Label
    Friend WithEvents revenueLabel As System.Windows.Forms.Label
    Friend WithEvents percentOfRevenueLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfOrchestra As System.Windows.Forms.TextBox
    Friend WithEvents numberOfMainFloor As System.Windows.Forms.TextBox
    Friend WithEvents numberOfBalcony As System.Windows.Forms.TextBox
    Friend WithEvents totalRevenueLabel As System.Windows.Forms.Label
    Friend WithEvents revenueOfOrchestra As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents revenueOfMainFloor As System.Windows.Forms.Label
    Friend WithEvents revenueOfBalcony As System.Windows.Forms.Label
    Friend WithEvents totalRevenueLabelBox As System.Windows.Forms.Label
    Friend WithEvents percentOfBalcony As System.Windows.Forms.Label
    Friend WithEvents percentOfMainFloor As System.Windows.Forms.Label
    Friend WithEvents percentOfOrchestra As System.Windows.Forms.Label

End Class
