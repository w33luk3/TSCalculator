Public Class frmVATCalc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            vatOwedTextBox.Text = FormatCurrency((salePriceTextBox.Text / 100) * 9.5)


            profitTextBox.Text = FormatCurrency(salePriceTextBox.Text - costPriceTextBox.Text - vatOwedTextBox.Text)


        Catch ex As Exception

        End Try
    End Sub
End Class