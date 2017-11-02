Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn

    Dim Codigo As Integer

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_FORNECEDOR "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value + 1
        End If
        Txt_codigo.Text = Codigo
        Txt_codigo.Enabled = False
    End Sub
End Class