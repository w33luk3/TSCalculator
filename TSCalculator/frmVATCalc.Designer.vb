<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVATCalc
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
        Me.salePriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.vatOwedTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.costPriceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.profitTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'salePriceTextBox
        '
        Me.salePriceTextBox.Location = New System.Drawing.Point(97, 10)
        Me.salePriceTextBox.Name = "salePriceTextBox"
        Me.salePriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.salePriceTextBox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show Me"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'vatOwedTextBox
        '
        Me.vatOwedTextBox.Location = New System.Drawing.Point(97, 79)
        Me.vatOwedTextBox.Name = "vatOwedTextBox"
        Me.vatOwedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.vatOwedTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item sell price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Item VAT cost"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Item cost price"
        '
        'costPriceTextBox
        '
        Me.costPriceTextBox.Location = New System.Drawing.Point(97, 45)
        Me.costPriceTextBox.Name = "costPriceTextBox"
        Me.costPriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.costPriceTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Profit"
        '
        'profitTextBox
        '
        Me.profitTextBox.Location = New System.Drawing.Point(97, 118)
        Me.profitTextBox.Name = "profitTextBox"
        Me.profitTextBox.Size = New System.Drawing.Size(100, 20)
        Me.profitTextBox.TabIndex = 7
        '
        'frmVATCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(210, 181)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.profitTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.costPriceTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vatOwedTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.salePriceTextBox)
        Me.Name = "frmVATCalc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents salePriceTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents vatOwedTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents costPriceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents profitTextBox As TextBox
End Class
