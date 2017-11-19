Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn
    Dim Codigo As Integer

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
        FormListarProdutos.Show()
    End Sub

    Private Sub btn_del_prod_Click(sender As Object, e As EventArgs) Handles btn_del_prod.Click
        lst_produtos.Items.Remove(lst_produtos.SelectedIndex)
    End Sub

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_FORNECEDOR "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value + 1
        End If
        lbl_id_fornecedor.Text = Codigo
    End Sub


    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        If Txt_cnpj.Text <> "" And Txt_nome.Text <> "" And Txt_responsavel.Text <> "" Then
            sql = "INSERT INTO TB_FORNECEDOR (COD_FORN,NOME_FORN, CONTATO,CNPJ,RESPOSAVEL) values ('" & lbl_id_fornecedor.Text & "','" & Txt_nome.Text & "', '" & Txt_tel.Text & "', '" & Txt_responsavel.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Cadastrado com sucesso")
        Else
            MsgBox("Preencha todos os campos")
        End If
    End Sub
End Class