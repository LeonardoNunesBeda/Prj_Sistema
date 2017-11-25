Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn

    Public editarUser As Boolean = False
    Public editID As Integer

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs)
        Form_CadastrarProdutos.ShowDialog()
    End Sub

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        If editarUser Then
            sql = "SELECT * FROM tb_fornecedor WHERE cnpj = '" & editID & "'"
            rs = db.Execute(sql)
            Txt_cnpj.Text = rs.Fields(0).Value
            Txt_nome.Text = rs.Fields(1).Value
            Txt_tel.Text = rs.Fields(2).Value
            Txt_responsavel.Text = rs.Fields(3).Value
        End If
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        Txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Dim cnpjNoFormat As String = Txt_cnpj.Text
        Txt_cnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

        If Txt_cnpj.Text <> "" And Txt_nome.Text <> "" And Txt_responsavel.Text <> "" Then
            If Not editarUser Then
                sql = "INSERT INTO TB_FORNECEDOR (CNPJ, NOME_FORN, CONTATO,RESPONSAVEL) VALUES ('" & cnpjNoFormat & "','" & Txt_nome.Text & "', '" & Txt_tel.Text & "', '" & Txt_responsavel.Text & "')"
            Else
                sql = "UPDATE tb_fornecedor set CNPJ = '" & cnpjNoFormat & "', nome_forn = '" & Txt_nome.Text & "', contato = '" & Txt_tel.Text & "', responsavel = '" & Txt_responsavel.Text & "' WHERE cpnj = '" & editID & "'"
            End If
            rs = db.Execute(sql)

            If editarUser Then
                MsgBox("Editado com sucesso!")
            Else
                MsgBox("Cadastrado com sucesso!")
            End If
            Txt_cnpj.Clear()
                Txt_nome.Clear()
                Txt_responsavel.Clear()
                Txt_tel.Clear()
            Else
                MsgBox("Preencha todos os campos!")
        End If

    End Sub
End Class