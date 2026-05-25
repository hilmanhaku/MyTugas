Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Dim Username, Password As String
        Username = TextBox1.Text
        Password = TextBox2.Text
        Try
            Konek()
            cmd = New MySqlCommand("SELECT * FROM users WHERE username = '" & Username & "' AND password ='" & Password & "' ", Koneksi)
            'Dim reader As MySqlDataReader
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                ' Username dan password ditemukan
                MessageBox.Show("Login Sukses, Akses Telah Diberikan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Buka Form Tujuan

                Dim MainMenu As New Formutama
                MainMenu.Show()
                Hide()
            Else

                ' Username dan password tidak ditemukan
                MessageBox.Show("Login gagal ! UserXname atau password salah.", "Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Diskonek()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
