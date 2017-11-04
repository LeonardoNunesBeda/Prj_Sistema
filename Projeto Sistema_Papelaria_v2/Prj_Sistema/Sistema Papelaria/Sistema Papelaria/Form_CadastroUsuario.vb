Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroUsuario

    Dim ID As Integer

    Private Sub Form_CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT  * FROM TB_LOGIN"
        rs = db.Execute(sql)
        'Acrescentando 1 no ID do usuário
        If rs.EOF = False Then
            ID = rs.Fields(0).Value + 1
        End If
    End Sub

    Private Sub Txt_user_TextChanged(sender As Object, e As EventArgs) Handles Txt_user.TextChanged
        'Checar se usuário já existe
        sql = "SELECT * FROM TB_LOGIN WHERE USUARIO='" & Txt_user.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            MsgBox("Usuário já existente!")
        End If
    End Sub

    Private Sub Btn_Salvar_Click(sender As Object, e As EventArgs) Handles Btn_Salvar.Click
        'Checar se todos os campos foram preenchidos
        If Txt_user.Text = "" Or Txt_senha.Text = " " Or Txt_resposta.Text = "" Or Txt_RepetirSenha.Text = "" Or Txt_email.Text = "" Then
            MsgBox("Preencha todos os campos")
        Else
            'Checar se as senhas batem
            If Txt_senha.Text <> Txt_RepetirSenha.Text Then
                MsgBox("As senhas devem ser as mesmas")
            Else
                'Inserção no banco de dados
                sql = "INSERT INTO TB_LOGIN (ID_USUARIO,USUARIO,EMAIL,SENHA,PERGUNTA_SECRETA,RESPOSTA_SECRETA,STATUS_CONTA,TIPO_CONTA,NUM_TENTATIVAS) VALUES " +
                    "('" & ID & "','" & Txt_user.Text & "','" & Txt_email.Text & "','" & Txt_senha.Text & "','" & Cb_Pergunta.Text & "','" & Txt_resposta.Text & "','ATIVO'," +
                " '" & Cb_TipoConta.Text & "',3)"
            End If
        End If
    End Sub

    Private Sub Checkbox_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_visualizar.CheckedChanged
        If Checkbox_visualizar.Checked = False Then
            Txt_senha.PasswordChar = "*"
            Txt_RepetirSenha.PasswordChar = "*"
        Else
            Txt_senha.PasswordChar = ""
            Txt_RepetirSenha.PasswordChar = ""
        End If
    End Sub
End Class