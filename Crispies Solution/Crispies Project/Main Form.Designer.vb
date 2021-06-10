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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.fontButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.bagelLabel = New System.Windows.Forms.Label()
        Me.donutsLabel = New System.Windows.Forms.Label()
        Me.coffeeLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.bagelTextBox = New System.Windows.Forms.TextBox()
        Me.coffeeTextBox = New System.Windows.Forms.TextBox()
        Me.donutsTextBox = New System.Windows.Forms.TextBox()
        Me.pricecolorLabel = New System.Windows.Forms.Label()
        Me.fontDialog = New System.Windows.Forms.FontDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Crispies_Project.My.Resources.Resources.Crispies
        Me.PictureBox1.Location = New System.Drawing.Point(12, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 213)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.calculateButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.colorButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.fontButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.exitButton, 0, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(570, 97)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 240)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'calculateButton
        '
        Me.calculateButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calculateButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(3, 3)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(194, 54)
        Me.calculateButton.TabIndex = 2
        Me.calculateButton.Text = "Calculate Price"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'colorButton
        '
        Me.colorButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorButton.Location = New System.Drawing.Point(3, 63)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(194, 54)
        Me.colorButton.TabIndex = 3
        Me.colorButton.Text = "Color"
        Me.colorButton.UseVisualStyleBackColor = True
        '
        'fontButton
        '
        Me.fontButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fontButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontButton.Location = New System.Drawing.Point(3, 123)
        Me.fontButton.Name = "fontButton"
        Me.fontButton.Size = New System.Drawing.Size(194, 54)
        Me.fontButton.TabIndex = 4
        Me.fontButton.Text = "Font"
        Me.fontButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(3, 183)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(194, 54)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'bagelLabel
        '
        Me.bagelLabel.AutoSize = True
        Me.bagelLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagelLabel.Location = New System.Drawing.Point(193, 97)
        Me.bagelLabel.Name = "bagelLabel"
        Me.bagelLabel.Size = New System.Drawing.Size(80, 30)
        Me.bagelLabel.TabIndex = 2
        Me.bagelLabel.Text = "Bagels:"
        '
        'donutsLabel
        '
        Me.donutsLabel.AutoSize = True
        Me.donutsLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donutsLabel.Location = New System.Drawing.Point(193, 151)
        Me.donutsLabel.Name = "donutsLabel"
        Me.donutsLabel.Size = New System.Drawing.Size(87, 30)
        Me.donutsLabel.TabIndex = 3
        Me.donutsLabel.Text = "Donuts:"
        '
        'coffeeLabel
        '
        Me.coffeeLabel.AutoSize = True
        Me.coffeeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coffeeLabel.Location = New System.Drawing.Point(193, 201)
        Me.coffeeLabel.Name = "coffeeLabel"
        Me.coffeeLabel.Size = New System.Drawing.Size(80, 30)
        Me.coffeeLabel.TabIndex = 4
        Me.coffeeLabel.Text = "Coffee:"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceLabel.Location = New System.Drawing.Point(193, 307)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(64, 30)
        Me.priceLabel.TabIndex = 5
        Me.priceLabel.Text = "Price:"
        '
        'bagelTextBox
        '
        Me.bagelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagelTextBox.Location = New System.Drawing.Point(295, 97)
        Me.bagelTextBox.Name = "bagelTextBox"
        Me.bagelTextBox.Size = New System.Drawing.Size(72, 40)
        Me.bagelTextBox.TabIndex = 6
        '
        'coffeeTextBox
        '
        Me.coffeeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coffeeTextBox.Location = New System.Drawing.Point(295, 201)
        Me.coffeeTextBox.Name = "coffeeTextBox"
        Me.coffeeTextBox.Size = New System.Drawing.Size(72, 40)
        Me.coffeeTextBox.TabIndex = 7
        '
        'donutsTextBox
        '
        Me.donutsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donutsTextBox.Location = New System.Drawing.Point(295, 151)
        Me.donutsTextBox.Name = "donutsTextBox"
        Me.donutsTextBox.Size = New System.Drawing.Size(72, 40)
        Me.donutsTextBox.TabIndex = 8
        '
        'pricecolorLabel
        '
        Me.pricecolorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pricecolorLabel.Location = New System.Drawing.Point(271, 305)
        Me.pricecolorLabel.Name = "pricecolorLabel"
        Me.pricecolorLabel.Size = New System.Drawing.Size(188, 43)
        Me.pricecolorLabel.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 423)
        Me.Controls.Add(Me.pricecolorLabel)
        Me.Controls.Add(Me.donutsTextBox)
        Me.Controls.Add(Me.coffeeTextBox)
        Me.Controls.Add(Me.bagelTextBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.coffeeLabel)
        Me.Controls.Add(Me.donutsLabel)
        Me.Controls.Add(Me.bagelLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents fontButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents bagelLabel As System.Windows.Forms.Label
    Friend WithEvents donutsLabel As System.Windows.Forms.Label
    Friend WithEvents coffeeLabel As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents bagelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents coffeeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents donutsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents pricecolorLabel As System.Windows.Forms.Label
    Friend WithEvents fontDialog As System.Windows.Forms.FontDialog

End Class
