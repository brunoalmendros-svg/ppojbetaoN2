Imports Microsoft.Data.SqlClient

Public Class Form1

    ' Variável global da conexão
    Private conexao As SqlConnection

    ' Função para abrir a conexão
    Private Sub AbrirConexao()
        Try
            Dim strConexao As String = "Server=.\SQLEXPRESS;Database=restaurante;Trusted_Connection=True;TrustServerCertificate=True;"
            conexao = New SqlConnection(strConexao)
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao conectar ao banco de dados: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicialização do formulário
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim sql As String
        Dim cmd As SqlCommand
        Dim leitor As SqlDataReader

        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        If usuario = "" Or senha = "" Then
            MessageBox.Show("Preencha usuário e senha.")
            Exit Sub
        End If

        sql = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha"

        Try
            AbrirConexao()
            cmd = New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@usuario", usuario)
            cmd.Parameters.AddWithValue("@senha", senha)

            leitor = cmd.ExecuteReader()

            If leitor.HasRows Then
                MessageBox.Show("Login realizado com sucesso!")
                leitor.Close()
                Dim tela As New Cadastrar
                tela.Show()
                Me.Hide()
            Else
                MessageBox.Show("Usuário ou senha incorretos.")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao fazer login: " & ex.Message)
        Finally
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try
    End Sub

    Private Sub LinkLabel1_Click(sender As Object, e As EventArgs) Handles LinkLabel1.Click
        ' Solicita ao usuário que digite seu nome de usuário
        Dim usuario As String = InputBox("Digite seu nome de usuário para recuperar a senha:", "Recuperar Senha")

        If usuario = "" Then
            MessageBox.Show("Você precisa digitar um nome de usuário.")
            Exit Sub
        End If

        Dim sql As String
        Dim cmd As SqlCommand
        Dim leitor As SqlDataReader

        sql = "SELECT senha FROM usuarios WHERE usuario = @usuario"

        Try
            AbrirConexao()
            cmd = New SqlCommand(sql, conexao)
            cmd.Parameters.AddWithValue("@usuario", usuario)

            leitor = cmd.ExecuteReader()

            If leitor.HasRows Then
                leitor.Read()
                Dim senha As String = leitor("senha").ToString()
                MessageBox.Show("Sua senha é: " & senha, "Senha Recuperada")
            Else
                MessageBox.Show("Usuário não encontrado.", "Erro")
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao recuperar senha: " & ex.Message)
        Finally
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        End Try
    End Sub

End Class