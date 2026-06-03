Imports MySql.Data.MySqlClient
Imports System.Data
Module ModuloGeral

	Public conexao As New MySqlConnection(
	"server=localhost;port=3306;database=restaurante;uid=root;pwd=1234;"
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


	Sub Limpar_cadastro()
		Try
			With Cadastrar
				.txt_usuario.Clear()
				.txt_nome.Clear()
				.txt_senha.Clear()
				.txt_csenha.Clear()
				.txt_email.Clear()
				.txt_usuario.Focus()
			End With
		Catch ex As Exception
			MsgBox("Erro ao Processar...", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
			Limpar_cadastro()
		End Try

	End Sub

End Module
