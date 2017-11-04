Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
    End Sub

    Private Sub btn_del_prod_Click(sender As Object, e As EventArgs) Handles btn_del_prod.Click
        lst_produtos.Items.Remove(lst_produtos.SelectedIndex)
    End Sub

    Dim Codigo As Integer

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_FORNECEDOR "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value + 1
        End If
        lbl_id_fornecedor.Text = Codigo
    End Sub

    Public Sub InserirDados()
        '?
    End Sub
End Class