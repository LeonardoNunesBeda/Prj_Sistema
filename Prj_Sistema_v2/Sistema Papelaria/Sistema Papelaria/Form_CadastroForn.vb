Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs)
        Form_CadastrarProdutos.ShowDialog()
    End Sub

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Dim cnpjNoFormat As String = Txt_cnpj.Text
        Txt_cnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

        If Txt_cnpj.Text <> "" And Txt_nome.Text <> "" And Txt_responsavel.Text <> "" Then
            sql = "INSERT INTO TB_FORNECEDOR (CNPJ, NOME_FORN, CONTATO,RESPONSAVEL) VALUES ('" & cnpjNoFormat & "','" & Txt_nome.Text & "', '" & Txt_tel.Text & "', '" & Txt_responsavel.Text & "')"
            rs = db.Execute(sql)

            MsgBox("Cadastrado com sucesso!")
            Txt_cnpj.Clear()
            Txt_nome.Clear()
            Txt_responsavel.Clear()
            Txt_tel.Clear()
        Else
            MsgBox("Preencha todos os campos!")
        End If

    End Sub
End Class