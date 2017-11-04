Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormMenu

    Public frm As New FormLogin()
    Public tipo_conta2 As String = frm.tipo_conta

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        'Nome do Olá
        lbl_nome.Text = frm.usuario

        'Permissão Para ver o MenuStrip de Manutenção de contas
        If tipo_conta2 = "ADMINISTRADOR" Then
            ManutençãoDeContasToolStripMenuItem.Visible = True
        Else
            ManutençãoDeContasToolStripMenuItem.Visible = False
        End If

        'Query para Carregar os dados nos DGV's
        sql = "SELECT * FROM TB_FORNECEDORES"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            dgv_forn.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
            rs.MoveNext()
        Loop
        sql = "SELECT * FROM TB_PRODUTOS"
        rs = db.Execute(sql)
        Do While rs.EOF = False
            dgv_prod.Rows.Add(rs.Fields(0).Value, rs.Fields(7).Value, rs.Fields(4).Value, rs.Fields(2).Value)
            rs.MoveNext()
        Loop
    End Sub
    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        Form_CadastroUsuario.Show()
    End Sub

    Private Sub ListaDeStatusDeContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeStatusDeContaToolStripMenuItem.Click
        FormStatus.Show()
    End Sub

    Private Sub CadastrarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarCompraToolStripMenuItem.Click
        Form_CadastrarCompras.Show()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        FormLogin.Show()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CadastroDeFornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeFornecedoresToolStripMenuItem.Click
        Form_CadastroForn.Show()
    End Sub

    Private Sub VerComprasRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerComprasRealizadasToolStripMenuItem.Click
        Form_CarregarCompras.Show()
    End Sub
End Class