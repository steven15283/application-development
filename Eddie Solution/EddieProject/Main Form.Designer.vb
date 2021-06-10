<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.goButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stopPictureBox = New System.Windows.Forms.PictureBox()
        Me.goPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.stopPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(425, 30)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(75, 35)
        Me.goButton.TabIndex = 0
        Me.goButton.Text = "Go"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(425, 109)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 35)
        Me.stopButton.TabIndex = 1
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(425, 188)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 35)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eddie Rocks!"
        '
        'stopPictureBox
        '
        Me.stopPictureBox.Image = Global.EddieProject.My.Resources.Resources.EddieStop
        Me.stopPictureBox.Location = New System.Drawing.Point(42, 53)
        Me.stopPictureBox.Name = "stopPictureBox"
        Me.stopPictureBox.Size = New System.Drawing.Size(365, 465)
        Me.stopPictureBox.TabIndex = 5
        Me.stopPictureBox.TabStop = False
        '
        'goPictureBox
        '
        Me.goPictureBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.goPictureBox.Image = Global.EddieProject.My.Resources.Resources.EddieGo
        Me.goPictureBox.Location = New System.Drawing.Point(42, 53)
        Me.goPictureBox.Name = "goPictureBox"
        Me.goPictureBox.Size = New System.Drawing.Size(365, 465)
        Me.goPictureBox.TabIndex = 4
        Me.goPictureBox.TabStop = False
        Me.goPictureBox.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 552)
        Me.Controls.Add(Me.stopPictureBox)
        Me.Controls.Add(Me.goPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.goButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eddie"
        CType(Me.stopPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents stopButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents goPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents stopPictureBox As System.Windows.Forms.PictureBox

End Class
