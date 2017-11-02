Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastrarProdutos

    Dim Codigo As Integer

    Private Sub Form_CadastrarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_PRODUTO "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value + 1
        End If
        Txt_codprod.Text = Codigo
        Txt_codprod.Enabled = False
    End Sub
End Class