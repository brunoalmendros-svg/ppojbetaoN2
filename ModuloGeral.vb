Imports MySql.Data.MySqlClient
Imports System.Data
Module ModuloGeral

    Public conexao As New MySqlConnection(
    "server=localhost;port=3306;database=restaurante;uid=root;pwd=Athena@12;"
)

    Public Sub AbrirConexao()

        Try

            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If
        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

End Module
