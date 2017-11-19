Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormMenu

    Public tipo_conta, user As String

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        'Nome do Olá
        lbl_user_name.Text = "Olá, " & user & "."

        'Permissão Para ver o MenuStrip de Manutenção de contas
        If tipo_conta = "ADMINISTRADOR" Then
            ManutençãoDeContasToolStripMenuItem.Visible = True
            FornToolStripMenuItem.Visible = True
            VerComprasRealizadasToolStripMenuItem.Visible = True
            CadastrarProdutosToolStripMenuItem.Visible = True
            Btn_Contas.Visible = True
            Btn_Cadastrar.Visible = True
        Else
            ManutençãoDeContasToolStripMenuItem.Visible = False
            FornToolStripMenuItem.Visible = False
            VerComprasRealizadasToolStripMenuItem.Visible = False
            CadastrarProdutosToolStripMenuItem.Visible = False
            Btn_Contas.Visible = False
            Btn_Cadastrar.Visible = False
        End If
    End Sub

    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        Form_CadastroUsuario.ShowDialog()
    End Sub

    Private Sub ListaDeStatusDeContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeStatusDeContaToolStripMenuItem.Click
        FormStatus.ShowDialog()
    End Sub

    Private Sub CadastrarCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarCompraToolStripMenuItem.Click
        Form_CadastrarCompras.ShowDialog()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        FormLogin.Show()
        Close()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CadastroDeFornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeFornecedoresToolStripMenuItem.Click
        Form_CadastroForn.ShowDialog()
    End Sub

    Private Sub VerComprasRealizadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerComprasRealizadasToolStripMenuItem.Click
        Form_CarregarCompras.ShowDialog()
    End Sub

    Private Sub ListarFornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarFornecedoresToolStripMenuItem.Click
        FormListarFornecedores.ShowDialog()
    End Sub

    Private Sub Btn_Comprar_Click(sender As Object, e As EventArgs) Handles Btn_Comprar.Click
        Form_CadastrarCompras.ShowDialog()
    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click
        Form_CadastrarProdutos.ShowDialog()
    End Sub

    Private Sub Btn_Contas_Click(sender As Object, e As EventArgs) Handles Btn_Contas.Click
        FormStatus.ShowDialog()
    End Sub

    Private Sub Btn_Sair_Click(sender As Object, e As EventArgs) Handles Btn_Sair.Click
        FormLogin.Show()
        Close()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles CadastrarProdutosToolStripMenuItem.Click
        Form_CadastrarProdutos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        FormListarProdutos.ShowDialog()
    End Sub

    Private Sub RelatórioDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDeComprasToolStripMenuItem.Click
        Form_RelatorioDeCompras.Show()
    End Sub

    Private Sub Btn_Encerrar_Click(sender As Object, e As EventArgs) Handles Btn_Encerrar.Click
        Application.Exit()
    End Sub
End Class