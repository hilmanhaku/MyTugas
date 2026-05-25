Imports MySql.Data.MySqlClient

Module ModuleKoneksi

    Dim MySQLKonek =
        "Server=localhost;
         Database=db_laundry;
         User=root;
         Password=root"

    Public Koneksi As New MySqlConnection(MySQLKonek)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public Status As Boolean = False

    Public SessionIDUser As String
    Public SessionUsername As String
    Public SessionLevel As String

    Public Sub Konek()

        Try

            If Koneksi.State =
                ConnectionState.Open Then

                Koneksi.Close()

            End If

            Koneksi.Open()

        Catch ex As Exception

            MsgBox(
                "Koneksi Gagal : " &
                ex.Message
            )

        End Try

    End Sub

    Function Diskonek()

        Koneksi.Close()

        Return Koneksi

    End Function

End Module