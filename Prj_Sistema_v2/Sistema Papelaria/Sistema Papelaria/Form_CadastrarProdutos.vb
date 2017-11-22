Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Imports System.IO.IOException

Public Class Form_CadastrarProdutos

    Dim Codigo As Integer

    Private Sub Form_CadastrarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_PRODUTO "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value
        End If
        lbl_codProd.Text = Codigo + 1

        Carregar_Forn()
    End Sub

    Private Sub Btn_salvar_Click(sender As Object, e As EventArgs) Handles Btn_salvar.Click
        ValidarCompra()
    End Sub
    Public Sub ValidarCompra()
        If Txt_Prod.Text = "" Or Txt_valor.Text = "" Or NUD_qtdProd.Value = 0 Or Txt_categoria.Text = "" Then
            MsgBox("Preencha todos os campos necessários *")
        Else
            If NUD_qtdProd.Value < 1 Then
                MsgBox("Coloque somente valores positivos no estoque")
            Else
                Try
                    sql = "INSERT INTO TB_PRODUTO (COD_PRODUTO,NOME_PROD,VALOR,QUANTIDADE,FORNECEDOR,CATEGORIA) VALUES ('" & Codigo + 1 & "','" & Txt_Prod.Text & "','" & Txt_valor.Text & "','" & NUD_qtdProd.Value & "', " +
                    " '" & cb_fornecedor.Text & "','" & Txt_categoria.Text & "')"
                    rs = db.Execute(sql)
                Catch ex As System.IO.IOException
                    MsgBox("Error: " + ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Carregar_Forn()
        cb_fornecedor.Items.Clear()
        sql = "SELECT * FROM TB_FORNECEDOR"
        rs = db.Execute(sql)
        'Não está funcionando, Form para de responder
        'Do While rs.EOF = False
        'cb_fornecedor.Items.Add(rs.Fields(1).Value)
        'Loop
    End Sub

    Private Sub btn_add_fornecedor_Click(sender As Object, e As EventArgs) Handles btn_add_fornecedor.Click
        Form_CadastroForn.Show()
        Do While Application.OpenForms().OfType(Of Form_CadastroForn).Any
            Carregar_Forn()
        Loop
    End Sub
End Class