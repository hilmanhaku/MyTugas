Public Class Form1
    txtUang.Focus()
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim Uang, Hari, Total As Double
        Uang = txtUang.Text
        Hari = txtHari.Text
        Total = Uang * Hari
        lblTotal.Text = Total
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtUang.Text = ""
        txtHari.Text = ""
        ' Reset label hasil
        lblTotal.Text = "0"
        txtUang.Focus()
    End Sub

    Private Sub Bu_Click(sender As Object, e As EventArgs) Handles Bu.Click
        Application.Exit()
    End Sub
End Class
