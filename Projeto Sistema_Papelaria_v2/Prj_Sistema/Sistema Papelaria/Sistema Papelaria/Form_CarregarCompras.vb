Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CarregarCompras
    Private Sub Form_CarregarCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_COMPRA"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            Dgv_Compras.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If Txt_cliente.Text <> "" Then
            sql = "SELECT * FROM TB_COMPRA WHERE CLIENTE = '" & Txt_cliente.Text & "'"
            rs = db.Execute(sql)
            Dgv_Compras.DataSource = Nothing
            Do While rs.EOF = False
                Dgv_Compras.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            'Carregar no DGV
        ElseIf Txt_CodigoCompra.Text <> "" Then
            sql = "SELECT * FROM TB_COMPRA WHERE COD-COMPRA = '" & Txt_CodigoCompra.Text & "'"
            rs = db.Execute(sql)
            Dgv_Compras.DataSource = Nothing
            Do While rs.EOF = False
                Dgv_Compras.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            'Carregar no DGV
        ElseIf cmb_produto.Text <> "" Then
            sql = "SELECT * FROM TB_COMPRA WHERE NOME_PRODUTO = '" & cmb_produto.Text & "'"
            rs = db.Execute(sql)
            Dgv_Compras.DataSource = Nothing
            Do While rs.EOF = False
                Dgv_Compras.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
                rs.MoveNext()
            Loop
            'Carregar no DGV
        End If
    End Sub
End Class