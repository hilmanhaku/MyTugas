Public Class Formutama
    Private Sub Formutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserLogin.Text =
        "Login Sebagai : " &
        SessionUsername
    End Sub
End Class