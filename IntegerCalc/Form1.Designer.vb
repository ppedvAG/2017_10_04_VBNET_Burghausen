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
        Me.ModuloButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.DividiertButton = New System.Windows.Forms.Button()
        Me.MalButton = New System.Windows.Forms.Button()
        Me.PlusButton = New System.Windows.Forms.Button()
        Me.Input2TextBox = New System.Windows.Forms.TextBox()
        Me.OutputTextBox = New System.Windows.Forms.TextBox()
        Me.Input1TextBox = New System.Windows.Forms.TextBox()
        Me.Input2Label = New System.Windows.Forms.Label()
        Me.OutputLabel = New System.Windows.Forms.Label()
        Me.Input1Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ModuloButton
        '
        Me.ModuloButton.Location = New System.Drawing.Point(223, 63)
        Me.ModuloButton.Name = "ModuloButton"
        Me.ModuloButton.Size = New System.Drawing.Size(58, 23)
        Me.ModuloButton.TabIndex = 21
        Me.ModuloButton.Text = "Mod"
        Me.ModuloButton.UseVisualStyleBackColor = True
        '
        'MinusButton
        '
        Me.MinusButton.Location = New System.Drawing.Point(255, 6)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(26, 23)
        Me.MinusButton.TabIndex = 20
        Me.MinusButton.Text = "-"
        Me.MinusButton.UseVisualStyleBackColor = True
        '
        'DividiertButton
        '
        Me.DividiertButton.Location = New System.Drawing.Point(255, 34)
        Me.DividiertButton.Name = "DividiertButton"
        Me.DividiertButton.Size = New System.Drawing.Size(26, 23)
        Me.DividiertButton.TabIndex = 19
        Me.DividiertButton.Text = "/"
        Me.DividiertButton.UseVisualStyleBackColor = True
        '
        'MalButton
        '
        Me.MalButton.Location = New System.Drawing.Point(223, 34)
        Me.MalButton.Name = "MalButton"
        Me.MalButton.Size = New System.Drawing.Size(26, 23)
        Me.MalButton.TabIndex = 18
        Me.MalButton.Text = "*"
        Me.MalButton.UseVisualStyleBackColor = True
        '
        'PlusButton
        '
        Me.PlusButton.Location = New System.Drawing.Point(223, 6)
        Me.PlusButton.Name = "PlusButton"
        Me.PlusButton.Size = New System.Drawing.Size(26, 23)
        Me.PlusButton.TabIndex = 17
        Me.PlusButton.Text = "+"
        Me.PlusButton.UseVisualStyleBackColor = True
        '
        'Input2TextBox
        '
        Me.Input2TextBox.Location = New System.Drawing.Point(74, 31)
        Me.Input2TextBox.Name = "Input2TextBox"
        Me.Input2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Input2TextBox.TabIndex = 16
        '
        'OutputTextBox
        '
        Me.OutputTextBox.Enabled = False
        Me.OutputTextBox.Location = New System.Drawing.Point(74, 57)
        Me.OutputTextBox.Name = "OutputTextBox"
        Me.OutputTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OutputTextBox.TabIndex = 15
        '
        'Input1TextBox
        '
        Me.Input1TextBox.Location = New System.Drawing.Point(74, 6)
        Me.Input1TextBox.Name = "Input1TextBox"
        Me.Input1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Input1TextBox.TabIndex = 14
        '
        'Input2Label
        '
        Me.Input2Label.AutoSize = True
        Me.Input2Label.Location = New System.Drawing.Point(12, 34)
        Me.Input2Label.Name = "Input2Label"
        Me.Input2Label.Size = New System.Drawing.Size(40, 13)
        Me.Input2Label.TabIndex = 13
        Me.Input2Label.Text = "Zahl 2:"
        '
        'OutputLabel
        '
        Me.OutputLabel.AutoSize = True
        Me.OutputLabel.Location = New System.Drawing.Point(12, 60)
        Me.OutputLabel.Name = "OutputLabel"
        Me.OutputLabel.Size = New System.Drawing.Size(51, 13)
        Me.OutputLabel.TabIndex = 12
        Me.OutputLabel.Text = "Ergebnis:"
        '
        'Input1Label
        '
        Me.Input1Label.AutoSize = True
        Me.Input1Label.Location = New System.Drawing.Point(12, 9)
        Me.Input1Label.Name = "Input1Label"
        Me.Input1Label.Size = New System.Drawing.Size(40, 13)
        Me.Input1Label.TabIndex = 11
        Me.Input1Label.Text = "Zahl 1:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 94)
        Me.Controls.Add(Me.ModuloButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.DividiertButton)
        Me.Controls.Add(Me.MalButton)
        Me.Controls.Add(Me.PlusButton)
        Me.Controls.Add(Me.Input2TextBox)
        Me.Controls.Add(Me.OutputTextBox)
        Me.Controls.Add(Me.Input1TextBox)
        Me.Controls.Add(Me.Input2Label)
        Me.Controls.Add(Me.OutputLabel)
        Me.Controls.Add(Me.Input1Label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModuloButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents DividiertButton As Button
    Friend WithEvents MalButton As Button
    Friend WithEvents PlusButton As Button
    Friend WithEvents Input2TextBox As TextBox
    Friend WithEvents OutputTextBox As TextBox
    Friend WithEvents Input1TextBox As TextBox
    Friend WithEvents Input2Label As Label
    Friend WithEvents OutputLabel As Label
    Friend WithEvents Input1Label As Label
End Class
