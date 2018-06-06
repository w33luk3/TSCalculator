<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtVAT = New System.Windows.Forms.TextBox()
        Me.txtRetail = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.chkVAT = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkPer = New System.Windows.Forms.CheckBox()
        Me.chkGBP = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLabour = New System.Windows.Forms.TextBox()
        Me.txtTotes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCost
        '
        Me.txtCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCost.Location = New System.Drawing.Point(159, 17)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 29)
        Me.txtCost.TabIndex = 0
        '
        'txtVAT
        '
        Me.txtVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVAT.Location = New System.Drawing.Point(159, 59)
        Me.txtVAT.Name = "txtVAT"
        Me.txtVAT.Size = New System.Drawing.Size(100, 29)
        Me.txtVAT.TabIndex = 1
        '
        'txtRetail
        '
        Me.txtRetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetail.Location = New System.Drawing.Point(159, 101)
        Me.txtRetail.Name = "txtRetail"
        Me.txtRetail.Size = New System.Drawing.Size(100, 29)
        Me.txtRetail.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(24, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(288, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(288, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Answers Please"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'chkVAT
        '
        Me.chkVAT.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkVAT.AutoSize = True
        Me.chkVAT.BackColor = System.Drawing.SystemColors.Control
        Me.chkVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVAT.Location = New System.Drawing.Point(265, 17)
        Me.chkVAT.Name = "chkVAT"
        Me.chkVAT.Size = New System.Drawing.Size(47, 23)
        Me.chkVAT.TabIndex = 12
        Me.chkVAT.Text = "+ VAT"
        Me.ToolTip1.SetToolTip(Me.chkVAT, "Tick this to add VAT to the current cost price")
        Me.chkVAT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Vat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Retail"
        '
        'chkPer
        '
        Me.chkPer.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkPer.AutoSize = True
        Me.chkPer.BackColor = System.Drawing.SystemColors.Control
        Me.chkPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPer.Location = New System.Drawing.Point(265, 143)
        Me.chkPer.Name = "chkPer"
        Me.chkPer.Size = New System.Drawing.Size(25, 23)
        Me.chkPer.TabIndex = 20
        Me.chkPer.Text = "%"
        Me.ToolTip1.SetToolTip(Me.chkPer, "Tick this to add VAT to the current cost price")
        Me.chkPer.UseVisualStyleBackColor = False
        '
        'chkGBP
        '
        Me.chkGBP.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkGBP.AutoSize = True
        Me.chkGBP.BackColor = System.Drawing.SystemColors.Control
        Me.chkGBP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGBP.Location = New System.Drawing.Point(289, 143)
        Me.chkGBP.Name = "chkGBP"
        Me.chkGBP.Size = New System.Drawing.Size(23, 23)
        Me.chkGBP.TabIndex = 21
        Me.chkGBP.Text = "£"
        Me.ToolTip1.SetToolTip(Me.chkGBP, "Tick this to add VAT to the current cost price")
        Me.chkGBP.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.SystemColors.Control
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(10, 3)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(53, 23)
        Me.CheckBox2.TabIndex = 25
        Me.CheckBox2.Text = "On Top"
        Me.ToolTip1.SetToolTip(Me.CheckBox2, "Tick this to add VAT to the current cost price")
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 24)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Add Labour"
        '
        'txtLabour
        '
        Me.txtLabour.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabour.Location = New System.Drawing.Point(159, 143)
        Me.txtLabour.Name = "txtLabour"
        Me.txtLabour.Size = New System.Drawing.Size(100, 29)
        Me.txtLabour.TabIndex = 22
        '
        'txtTotes
        '
        Me.txtTotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotes.Location = New System.Drawing.Point(159, 235)
        Me.txtTotes.Name = "txtTotes"
        Me.txtTotes.Size = New System.Drawing.Size(100, 29)
        Me.txtTotes.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 24)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Total Sale Price"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 357)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.txtTotes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLabour)
        Me.Controls.Add(Me.chkGBP)
        Me.Controls.Add(Me.chkPer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkVAT)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtRetail)
        Me.Controls.Add(Me.txtVAT)
        Me.Controls.Add(Me.txtCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtVAT As TextBox
    Friend WithEvents txtRetail As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents chkVAT As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents chkPer As CheckBox
    Friend WithEvents chkGBP As CheckBox
    Friend WithEvents txtLabour As TextBox
    Friend WithEvents txtTotes As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox2 As CheckBox
End Class
