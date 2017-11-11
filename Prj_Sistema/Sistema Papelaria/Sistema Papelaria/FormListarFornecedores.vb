Public Class FormListarFornecedores
    Private Sub FormListarFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        'Query para Carregar os dados nos DGV's
        sql = "SELECT * FROM TB_FORNECEDOR"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            dgv_forn.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
            rs.MoveNext()
        Loop
    End Sub
End Class