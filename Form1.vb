Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs)

        Dim tela As New Cadastrar
        tela.Show()
        Hide()

    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click

        Dim sql As String
        Dim cmd As MySqlCommand
        Dim leitor As MySqlDataReader

        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        If txt_usuario.Text = "" Or txt_senha.Text = "" Then
            MessageBox.Show("Preencha usuário e senha.")
        Else

            sql = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha"

            Try
                AbrirConexao()

                cmd = New MySqlCommand(sql, conexao)

                cmd.Parameters.AddWithValue("@usuario", usuario)
                cmd.Parameters.AddWithValue("@senha", senha)

                leitor = cmd.ExecuteReader()

                If leitor.HasRows Then
                    MessageBox.Show("Login realizado com sucesso!")

                    Cadastrar.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Usuário ou senha incorretos.")
                End If

            Catch ex As Exception
                MessageBox.Show($"Erro ao fazer login: {ex.Message}")

            Finally
                conexao.Close()
            End Try

        End If

    End Sub
End Class