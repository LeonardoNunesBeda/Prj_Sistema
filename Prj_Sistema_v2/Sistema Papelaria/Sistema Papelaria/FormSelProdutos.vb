Public Class FormSelProdutos
    Public selProd As String
    Private Sub FormSelProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT nome_prod FROM tb_produto"
        rs = db.Execute(sql)

        While rs.EOF = False
            lst_produtos.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub btn_add_produto_Click(sender As Object, e As EventArgs) Handles btn_add_produto.Click
        selProd = lst_produtos.SelectedItem
        Close()
    End Sub
End Class