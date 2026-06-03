Imports Microsoft.Data.SqlClient

Public Class Cadastrar

    Private conexao As SqlConnection

    Private Sub AbrirConexao()
        Dim strConexao As String = "Server=.\SQLEXPRESS;Database=restaurante;Trusted_Connection=True;TrustServerCertificate=True;"
        conexao = New SqlConnection(strConexao)
        conexao.Open()
    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        Dim usuario As String = txt_usuario.Text.Trim()
        Dim nome As String = txt_nome.Text.Trim()
        Dim email As String = txt_email.Text.Trim()
        Dim senha As String = txt_senha.Text

        If txt_csenha.Text <> senha Then
            MessageBox.Show("As senhas não coincidem.")
            Exit Sub
        End If

        If senha.Length < 8 Then
            MessageBox.Show("A senha deve possuir pelo menos 8 caracteres.")
            Exit Sub
        End If

        Try
            AbrirConexao()

            Dim sql As String = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario OR email = @email"

            Dim cmd As New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@email", email)

            Dim qtd As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            If qtd > 0 Then
                MessageBox.Show("Este usuário já está cadastrado.")
                Exit Sub
            End If

            sql = "INSERT INTO usuarios (nome, usuario, senha, email) VALUES (@nome, @usuario, @senha, @email)"

            cmd = New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@nome", nome)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)
            cmd.Parameters.AddWithValue("@email", email)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Usuário cadastrado com sucesso!")
            Limpar_cadastro()

        Catch ex As Exception
            MessageBox.Show("Erro ao cadastrar: " & ex.Message)

        Finally
            If conexao IsNot Nothing AndAlso conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try

    End Sub

End Class