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
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.mapleButton = New System.Windows.Forms.Button()
        Me.elmButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.elmPictureBox = New System.Windows.Forms.PictureBox()
        Me.maplePictureBox = New System.Windows.Forms.PictureBox()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.elmPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maplePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addressLabel
        '
        Me.addressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.addressLabel.Location = New System.Drawing.Point(172, 21)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(180, 30)
        Me.addressLabel.TabIndex = 0
        Me.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mapleButton
        '
        Me.mapleButton.Location = New System.Drawing.Point(51, 306)
        Me.mapleButton.Name = "mapleButton"
        Me.mapleButton.Size = New System.Drawing.Size(115, 25)
        Me.mapleButton.TabIndex = 4
        Me.mapleButton.Text = "65 Maple"
        Me.mapleButton.UseVisualStyleBackColor = True
        '
        'elmButton
        '
        Me.elmButton.Location = New System.Drawing.Point(202, 306)
        Me.elmButton.Name = "elmButton"
        Me.elmButton.Size = New System.Drawing.Size(115, 25)
        Me.elmButton.TabIndex = 5
        Me.elmButton.Text = "2323 Elm"
        Me.elmButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(359, 306)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(115, 25)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'elmPictureBox
        '
        Me.elmPictureBox.Image = Global.Jerrod_Project.My.Resources.Resources._2323Elm
        Me.elmPictureBox.Location = New System.Drawing.Point(277, 395)
        Me.elmPictureBox.Name = "elmPictureBox"
        Me.elmPictureBox.Size = New System.Drawing.Size(235, 230)
        Me.elmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.elmPictureBox.TabIndex = 3
        Me.elmPictureBox.TabStop = False
        '
        'maplePictureBox
        '
        Me.maplePictureBox.Image = Global.Jerrod_Project.My.Resources.Resources._65Maple
        Me.maplePictureBox.Location = New System.Drawing.Point(12, 395)
        Me.maplePictureBox.Name = "maplePictureBox"
        Me.maplePictureBox.Size = New System.Drawing.Size(235, 230)
        Me.maplePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maplePictureBox.TabIndex = 2
        Me.maplePictureBox.TabStop = False
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(145, 63)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(235, 230)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 1
        Me.displayPictureBox.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 637)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.elmButton)
        Me.Controls.Add(Me.mapleButton)
        Me.Controls.Add(Me.elmPictureBox)
        Me.Controls.Add(Me.maplePictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.addressLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jerrod Realty"
        CType(Me.elmPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maplePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents addressLabel As System.Windows.Forms.Label
    Friend WithEvents displayPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents maplePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents elmPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents mapleButton As System.Windows.Forms.Button
    Friend WithEvents elmButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
