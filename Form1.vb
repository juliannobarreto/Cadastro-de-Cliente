Imports BancoVBA
Public Class Form1
    Private banco As New Cliente
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        Try
            banco.Nome = txtNome.Text
            banco.Endereco = txtEndereco.Text
            banco.Numero = txtNumero.Text
            If banco.NovoCliente = True Then
                MessageBox.Show("Cliente incluído.")
            Else
                MessageBox.Show("Cliente não incluído.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btn_Editar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            banco.Id = txtNome.Text
            banco.Nome = txtNome.Text
            banco.Endereco = txtEndereco.Text
            banco.Numero = txtNumero.Text
            If banco.AtualizaCliente = True Then
                MessageBox.Show("Cliente incluído.")
            Else
                MessageBox.Show("Cliente não incluído.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
End Class
