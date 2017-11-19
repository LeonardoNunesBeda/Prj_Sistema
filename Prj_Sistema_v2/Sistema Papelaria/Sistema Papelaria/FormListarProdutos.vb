Public Class FormListarProdutos
    Private Sub FormListarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        'Query para listar os produtos
        sql = "SELECT * FROM TB_PRODUTO"
        rs = db.Execute(sql)
        If rs.Fields(3).Value <> 0 Then
            Do While rs.EOF = False
                dgv_prod.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End If
    End Sub
    Dim compra As New Form_CadastrarCompras()
    Dim prod As New Form_CadastroForn()
    Private Sub dgv_prod_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_prod.CellContentClick
        'Precisa de ajustes
        If Application.OpenForms().OfType(Of Form_CadastrarCompras).Any Then
            With compra
                .lst_produtos.Items.Add(dgv_prod.CurrentRow.Cells.ToString())
            End With
        ElseIf Application.OpenForms().OfType(Of Form_CadastroForn).Any Then
            With prod
                .lst_produtos.Items.Add(dgv_prod.CurrentRow.Cells.ToString())
            End With
        End If
    End Sub
    Public Sub recarregar()
        Do While Application.OpenForms().OfType(Of FormListarProdutos).Any
            dgv_prod.DataSource = Nothing
            sql = "SELECT * FROM TB_PRODUTO"
            rs = db.Execute(sql)
            If rs.Fields(3).Value <> 0 Then
                Do While rs.EOF = False
                    dgv_prod.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                    rs.MoveNext()
                Loop
            End If
        Loop
    End Sub
    Private Sub FormListarProdutos_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover

    End Sub
End Class