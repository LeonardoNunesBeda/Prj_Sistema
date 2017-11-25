Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Imports System.IO.IOException

Public Class Form_CadastrarProdutos
    Public editarProd As Boolean = False
    Public editId As Integer

    Private Sub Form_CadastrarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        Carregar_Forn()
        Carregar_Categorias()

        If editarProd Then
            sql = "SELECT * FROM tb_produto WHERE cod_prod = " & editId
            rs = db.Execute(sql)

            Txt_Prod.Text = rs.Fields(1).Value
            Txt_valor.Text = rs.Fields(2).Value
            NUD_qtdProd.Value = rs.Fields(3).Value
            cmb_categoria.Text = rs.Fields(4).Value

            sql = "SELECT nome_forn FROM tb_fornecedor WHERE cnpj = '" & rs.Fields(5).Value & "'"
            rs = db.Execute(sql)
            cb_fornecedor.Text = rs.Fields(0).Value
            editarProd = False
        End If
    End Sub

    Private Sub Btn_salvar_Click(sender As Object, e As EventArgs) Handles Btn_salvar.Click
        If Txt_Prod.Text = "" Or Txt_valor.Text = "" Or NUD_qtdProd.Value = 0 Or cmb_categoria.Text = "" Or cb_fornecedor.Text = "" Or Not IsNumeric(Txt_valor.Text) Then
            MsgBox("Preencha todos os campos necessários! (*)")
        Else
            Try
                sql = "SELECT cnpj FROM tb_fornecedor WHERE nome_forn = '" & cb_fornecedor.Text & "'"
                rs = db.Execute(sql)
                Dim cnpj As String = rs.Fields(0).Value

                If editarProd Then
                    sql = "UPDATE TB_PRODUTO SET NOME_PROD = '" & Txt_Prod.Text & "',VALOR = '" & Txt_valor.Text & "', QUANTIDADE = '" & NUD_qtdProd.Value & "', CATEGORIA = '" & cmb_categoria.Text & "', FORNECEDOR_CNPJ = '" & cnpj & "' WHERE cod_prod = " & editId
                    rs = db.Execute(sql)
                    MessageBox.Show("Produto editado com sucesso!")
                Else
                    sql = "INSERT INTO TB_PRODUTO (NOME_PROD,VALOR,QUANTIDADE,CATEGORIA,FORNECEDOR_CNPJ) VALUES ('" & Txt_Prod.Text & "','" & Txt_valor.Text & "','" & NUD_qtdProd.Value & "', " +
                    " '" & cmb_categoria.Text & "','" & cnpj & "')"
                    rs = db.Execute(sql)
                    MessageBox.Show("Produto cadastrado com sucesso!")
                End If
                Txt_Prod.Clear()
                Txt_valor.Clear()
                NUD_qtdProd.Value = 1
                cmb_categoria.SelectedIndex = -1
                cb_fornecedor.SelectedIndex = -1
            Catch ex As Exception
                MsgBox("Error: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub Carregar_Categorias()
        cmb_categoria.Items.Clear()
        sql = "SELECT DISTINCT categoria FROM tb_produto"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            While rs.EOF = False
                cmb_categoria.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub Carregar_Forn()
        cb_fornecedor.Items.Clear()
        sql = "SELECT nome_forn FROM TB_FORNECEDOR"
        rs = db.Execute(sql)
        If Not rs.EOF Then
            While rs.EOF = False
                cb_fornecedor.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub lbl_new_forn_Click(sender As Object, e As EventArgs) Handles lbl_new_forn.Click
        Form_CadastroForn.ShowDialog()
        cb_fornecedor.SelectedIndex = -1
        Carregar_Forn()
    End Sub
End Class