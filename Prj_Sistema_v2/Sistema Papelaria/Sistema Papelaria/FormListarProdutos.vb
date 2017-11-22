Public Class FormListarProdutos
    Private Sub FormListarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        lst_produtos.Items.Clear()
        'Query para listar os produtos
        sql = "SELECT * FROM TB_PRODUTO"
        rs = db.Execute(sql)
        If rs.Fields(3).Value <> 0 Then
            Do While rs.EOF = False
                lst_produtos.Items.Add(rs.Fields(1).Value.ToString)
                rs.MoveNext()
            Loop
        End If
    End Sub
End Class