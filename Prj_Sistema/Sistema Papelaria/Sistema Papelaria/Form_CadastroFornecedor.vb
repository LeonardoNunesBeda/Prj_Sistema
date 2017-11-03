Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroFornecedor
    Public Contador As Integer

    Private Sub Form_CadastroFornecedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        txt_senha.PasswordChar = "*"
        txt_rep_senha.PasswordChar = "*"
    End Sub

    Private Sub Btn_criarConta_Click(sender As Object, e As EventArgs) Handles btn_criarConta.Click
        gravar()
    End Sub

    Private Sub Cb_visualizarSenha_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizarSenha.CheckedChanged
        If cb_visualizarSenha.Checked = False Then
            txt_senha.PasswordChar = "*"
            txt_rep_senha.PasswordChar = "*"
        Else
            txt_senha.PasswordChar = String.Empty
            txt_rep_senha.PasswordChar = String.Empty
        End If
    End Sub

    Sub gravar()
        sql = "SELECT * FROM TB_LOGIN"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Contador = rs.Fields(0).Value.ToString + 1
            MsgBox(Contador)
        End If
        If txt_email.Text = "" Or txt_rep_senha.Text = "" Or txt_resp.Text = "" Or txt_senha.Text = "" Or txt_user.Text = "" Or cmb_conta.Text = "" Then
            MsgBox("Preencha todos os campos")
        Else
            sql = "SELECT * FROM TB_LOGIN WHERE EMAIL = '" & txt_email.Text & "' OR USUARIO = '" & txt_user.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = True Then
                If txt_senha.Text = txt_rep_senha.Text Then
                    Try
                        sql = "insert into tb_login values ('" & Contador & "',' " & txt_user.Text & "'," &
                    "'" & txt_email.Text & "', '" & txt_senha.Text & "', " &
                    "'" & cmb_pergunta.Text & "', '" & txt_resp.Text & "'," &
                    "'Ativo', '" & cmb_conta.Text & "', 3 )"
                        rs = db.Execute(UCase(sql))

                        MsgBox("Dados gravados com sucesso")
                    Catch ex As Exception
                        MsgBox("Erro ao gravar! " + vbNewLine + ex.Message)
                    End Try
                Else
                    MsgBox("As senhas precisam ser iguais")
                End If
            Else
                MsgBox("Usuário Já existente")
            End If
        End If
    End Sub
End Class