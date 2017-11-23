Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Imports System.IO.IOException

Public Class Form_CadastrarProdutos

    Private Sub Form_CadastrarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        Carregar_Forn()
    End Sub

    Private Sub Btn_salvar_Click(sender As Object, e As EventArgs) Handles Btn_salvar.Click
        If Txt_Prod.Text = "" Or Txt_valor.Text = "" Or NUD_qtdProd.Value = 0 Or cmb_categoria.Text = "" Or cb_fornecedor.Text = "" Then
            MsgBox("Preencha todos os campos necessários! (*)")
        Else
            Try
                sql = "SELECT cnpj FROM tb_fornecedor WHERE nome_forn = '" & cb_fornecedor.Text & "'"
                rs = db.Execute(sql)
                Dim cnpj As String = rs.Fields(0).Value

                sql = "INSERT INTO TB_PRODUTO (NOME_PROD,VALOR,QUANTIDADE,CATEGORIA,FORNECEDOR_CNPJ) VALUES ('" & Txt_Prod.Text & "','" & Txt_valor.Text & "','" & NUD_qtdProd.Value & "', " +
                    " '" & cmb_categoria.Text & "','" & cnpj & "')"
                rs = db.Execute(sql)
                MessageBox.Show("Produto cadastrado com sucesso!")
                Txt_Prod.Clear()
                Txt_valor.Clear()
                NUD_qtdProd.Value = 0
                cmb_categoria.SelectedIndex = -1
                cb_fornecedor.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Carregar_Categorias()
        cb_fornecedor.Items.Clear()
        sql = "SELECT DISTINCT categoria FROM TB_FORNECEDOR"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            While rs.EOF = False
                cb_fornecedor.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
            End While
        End If
    End Sub

    Private Sub Carregar_Forn()
        cb_fornecedor.Items.Clear()
        sql = "SELECT nome_forn, responsavel FROM TB_FORNECEDOR"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            While rs.EOF = False
                cb_fornecedor.Items.Add(rs.Fields(0).Value & " - " & rs.Fields(1).Value)
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub lbl_new_forn_Click(sender As Object, e As EventArgs) Handles lbl_new_forn.Click
        Form_CadastroForn.ShowDialog()
        cb_fornecedor.SelectedIndex = -1
    End Sub
End Class