Imports MySql.Data.MySqlClient

Public Class Cadastrar

    Private Sub Cadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            AbrirConexao()
        Catch ex As Exception
            MessageBox.Show($"Erro ao conectar: {ex.Message}")
        End Try

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click
        Dim sql As String
        Dim cmd As New MySqlCommand

        Dim usuario As String = txt_usuario.Text
        Dim nome As String = txt_nome.Text
        Dim email As String = txt_email.Text
        Dim senha As String = txt_senha.Text
        If txt_csenha.Text = senha Then

            sql = "INSERT INTO usuarios (nome,usuario, senha, email) VALUES (@nome,@usuario, @senha, @email)"

            Try
                AbrirConexao()

                cmd = New MySqlCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@nome", nome)
                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@senha", senha)
                cmd.Parameters.AddWithValue("@email", email)


                cmd.ExecuteNonQuery()

                MessageBox.Show("Usuário cadastrado com sucesso!")

            Catch ex As Exception
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}")

            Finally
                conexao.Close()
            End Try

        Else
            MessageBox.Show("As senhas não coincidem.")
        End If
    End Sub

    Private Sub txt_email_TextChanged(sender As Object, e As EventArgs) Handles txt_email.TextChanged

    End Sub
End Class