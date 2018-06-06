Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox2.Checked = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim diff As Decimal
        Dim decLabourPercent As Decimal
        If txtCost.Text = "" Then

        Else


            If chkVAT.Checked <> True Then
                diff = Val(txtCost.Text) / 1.2

                txtVAT.Text = Val(txtCost.Text) - Val(diff).ToString("#.##")
                txtCost.Text = diff.ToString("#.##")

                txtRetail.Text = Val(txtVAT.Text) + Val(txtCost.Text).ToString("#.##")



            Else

                diff = Val(txtCost.Text) * 1.2

                txtVAT.Text = Val(diff) - Val(txtCost.Text).ToString("#.##")


                txtRetail.Text = Val(txtVAT.Text) + Val(txtCost.Text).ToString("#.##")


            End If



            If chkGBP.Checked = True Then
                txtTotes.Text = Val(txtRetail.Text) + Val(txtLabour.Text).ToString("#.##")
            End If


            If chkPer.Checked = True Then
                decLabourPercent = Val(txtRetail.Text / Val(100) * (txtLabour.Text))
                txtTotes.Text = Val(txtRetail.Text) + Val(decLabourPercent).ToString("#.##")
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim labourCost As String
        labourCost = InputBox("How much labour to add?", "Add Labour Cost", "0.00")

        If labourCost = " " Then
            MessageBox.Show("You must enter a Labour cost.")
            Exit Sub
        ElseIf labourCost = "" Then
            Exit Sub

        End If

        txtRetail.Text = Val(txtRetail.Text) + Val(labourCost).ToString("#.##")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkVAT.CheckedChanged
        If chkVAT.Checked = True Then
            chkVAT.BackColor = SystemColors.Highlight
        Else
            chkVAT.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCost.Text = ""
        txtVAT.Text = ""
        txtRetail.Text = ""
        txtLabour.Text = ""
        txtTotes.Text = ""
        chkPer.Checked = False
        chkGBP.Checked = False
        chkVAT.Checked = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Clipboard.SetText(txtCost.Text)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Clipboard.SetText(txtVAT.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Clipboard.SetText(txtRetail.Text)
    End Sub

    Private Sub CheckBox1_MouseHover(sender As Object, e As EventArgs) Handles chkVAT.MouseHover
        If chkVAT.Checked = True Then
            ToolTip1.SetToolTip(sender, "I wll now add VAT to the current cost price.")
        Else
            ToolTip1.SetToolTip(sender, "I will now remove the VAT from the current cost price.")
        End If
    End Sub

    Private Sub percentCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkPer.CheckedChanged
        If chkPer.Checked = True Then
            chkPer.BackColor = SystemColors.Highlight
            chkGBP.Checked = False
            btnAdd.Enabled = True
        Else
            chkPer.BackColor = SystemColors.Control
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub poundsCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles chkGBP.CheckedChanged
        If chkGBP.Checked = True Then
            chkGBP.BackColor = SystemColors.Highlight
            chkPer.Checked = False
            btnAdd.Enabled = True
        Else
            chkGBP.BackColor = SystemColors.Control
            btnAdd.Enabled = False
        End If
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Clipboard.SetText(txtTotes.Text)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox2.BackColor = SystemColors.Highlight
            Me.TopMost = True
        Else
            CheckBox2.BackColor = SystemColors.Control
            Me.TopMost = False
        End If
    End Sub

    Private Sub txtLabour_TextChanged(sender As Object, e As EventArgs) Handles txtLabour.TextChanged
        If txtLabour.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If


    End Sub

    Private Sub txtLabour_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabour.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Clipboard.SetText(txtLabour.Text)
    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged

    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtVAT_TextChanged(sender As Object, e As EventArgs) Handles txtVAT.TextChanged

    End Sub

    Private Sub txtVAT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVAT.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtRetail_TextChanged(sender As Object, e As EventArgs) Handles txtRetail.TextChanged

    End Sub

    Private Sub txtRetail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRetail.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtTotes_TextChanged(sender As Object, e As EventArgs) Handles txtTotes.TextChanged

    End Sub

    Private Sub txtTotes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotes.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsControl(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub
End Class
