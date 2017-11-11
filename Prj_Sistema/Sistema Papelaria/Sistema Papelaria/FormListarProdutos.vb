Public Class FormListarProdutos
    Private Sub FormListarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        'Query para listar os produtos
        sql = "SELECT * FROM TB_PRODUTO"
        rs = db.Execute(sql)

        While rs.EOF = False
            dgv_prod.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
            rs.MoveNext()
        End While
    End Sub
End Class