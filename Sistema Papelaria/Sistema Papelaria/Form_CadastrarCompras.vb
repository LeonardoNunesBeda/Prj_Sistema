Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastrarCompras

    Public frm As New FormLogin()
    Public Vendedor As String = frm.usuario
    Dim Codigo As Integer

    Private Sub Form_CadastrarCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_COMPRA "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value + 1
        End If
        lbl_codigo.Text = Codigo
        Txt_vendendor.Text = Vendedor
        Txt_vendendor.Enabled = False
    End Sub
End Class