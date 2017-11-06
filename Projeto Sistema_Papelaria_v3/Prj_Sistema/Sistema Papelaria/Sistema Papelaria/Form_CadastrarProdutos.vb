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
            Codigo = rs.Fields(0).Value + 1
        End If
        lbl_codProd.Text = Codigo
    End Sub

    Private Sub Btn_salvar_Click(sender As Object, e As EventArgs) Handles Btn_salvar.Click

    End Sub
    Public Sub ValidarCompra()
        If Txt_Prod.Text = "" Or Txt_valor.Text = "" Or NUD_qtdProd.Value = 0 Then
            MsgBox("Preencha todos os campos necessários *")
        Else
            If NUD_qtdProd.Value < 1 Then
                MsgBox("Coloque somente valores positivos no estoque")
            Else
                Try
                    sql = "INSERT INTO TB_PRODUTOS (COD_PRODUTO,NOME_PROD,VALOR,QUANTIDADE,FORNECEDOR) VALUES ('" & Codigo & "','" & Txt_Prod.Text & "','" & Txt_valor.Text & "','" & NUD_qtdProd.Value & "', " +
                    " '" & cb_fornecedor.Text & "')"
                    rs = db.Execute(sql)
                Catch ex As System.IO.IOException
                    MsgBox("Error: " + ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub btn_add_fornecedor_Click(sender As Object, e As EventArgs) Handles btn_add_fornecedor.Click
        Form_CadastroForn.Show()
    End Sub
End Class