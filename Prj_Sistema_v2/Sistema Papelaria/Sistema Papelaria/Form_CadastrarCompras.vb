Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastrarCompras

    Dim total As Double, CurrentUser As String

    Private Sub Form_CadastrarCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
    End Sub

    Private Sub btn_add_produto_Click(sender As Object, e As EventArgs) Handles btn_add_produto.Click
        FormListarProdutos.Show()
    End Sub

    Private Sub Btn_compra_Click(sender As Object, e As EventArgs) Handles Btn_compra.Click
        sql = "INSERT INTO tb_compra(id_vendedor, data, metodo, total) VALUES(" & CurrentUser & ", " & DateTime.Today & ", '" & cb_metodo.Text & "', " & total & ")"
        rs = db.Execute(sql)
        Dim mainSql = "INSERT INTO tb_prod_compra(cod_prod, cod_compra, quantidade) VALUES"
        For i As Integer = 0 To dgv_compra.Rows.Count - 1
            mainSql += "(" & dgv_compra.Rows(i).Cells(0).Value & ", " & dgv_compra.Rows(i).Cells(1).Value & ", "
        Next
    End Sub

    Private Sub txt_pago_Leave(sender As Object, e As EventArgs) Handles txt_pago.Leave
        Try
            lbl_troco.Text = "Troco: R$ " & (total - Convert.ToDouble(txt_pago.Text)).ToString
        Catch ex As Exception
            lbl_troco.Text = "Troco: R$ 0,00"
        End Try
    End Sub

    Private Sub cb_metodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_metodo.SelectedIndexChanged
        If cb_metodo.SelectedIndex = 0 Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
    End Sub
End Class