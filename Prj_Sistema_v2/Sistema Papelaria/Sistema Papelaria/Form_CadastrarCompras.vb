Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastrarCompras

    Public total As Double = 0.0, user As String, CurrentUser As Integer

    Private Sub Form_CadastrarCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        sql = "SELECT id_usuario FROM tb_login WHERE usuario = '" & user & "'"
        rs = db.Execute(sql)
        CurrentUser = rs.Fields(0).Value
    End Sub

    Private Sub btn_add_produto_Click(sender As Object, e As EventArgs) Handles btn_add_produto.Click
        FormSelProdutos.ShowDialog()
        sql = "SELECT * FROM tb_produto WHERE nome_prod = '" & FormSelProdutos.selProd & "'"
        rs = db.Execute(sql)
        dgv_compra.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, 0, rs.Fields(2).Value)
        total = 0.0
        For i As Integer = 0 To dgv_compra.Rows.Count - 1
            Dim preco = Integer.Parse(dgv_compra.Rows(i).Cells(3).Value.ToString)
            Dim qtd = Double.Parse(dgv_compra.Rows(i).Cells(2).Value.ToString)
            total += (preco * qtd)
        Next
        Lbl_Total.Text = total
    End Sub

    Private Sub Btn_compra_Click(sender As Object, e As EventArgs) Handles Btn_compra.Click
        sql = "INSERT INTO tb_compra(id_vendedor, data, total) VALUES(" & CurrentUser & ", " & DateTime.Today & ", " & total & ")"
        rs = db.Execute(sql)
        Dim mainSql = "INSERT INTO tb_prod_compra(cod_prod, cod_compra, quantidade) VALUES"
        For i As Integer = 0 To dgv_compra.Rows.Count - 1
            mainSql += "(" & dgv_compra.Rows(i).Cells(0).Value & ", " & dgv_compra.Rows(i).Cells(1).Value & ", " & dgv_compra.Rows(i).Cells(2).Value & "),"
        Next
        mainSql = mainSql.Substring(0, mainSql.Length - 1)
        rs = db.Execute(mainSql)
    End Sub

    Private Sub txt_pago_TextChanged(sender As Object, e As EventArgs) Handles txt_pago.TextChanged
        Try
            lbl_troco.Text = "Troco: R$ " & (Convert.ToDouble(txt_pago.Text) - total).ToString
        Catch ex As Exception
            lbl_troco.Text = "Troco: R$ 0,00"
        End Try
    End Sub

    Private Sub dgv_compra_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_compra.CellEndEdit
        For i As Integer = 0 To dgv_compra.Rows.Count - 1
            Dim preco = Integer.Parse(dgv_compra.Rows(i).Cells(3).Value.ToString)
            Dim qtd = Double.Parse(dgv_compra.Rows(i).Cells(2).Value.ToString)
            total += (preco * qtd)
        Next
        Lbl_Total.Text = total
    End Sub
End Class