Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroUsuario

    Dim ID As Integer = 0
    Public firstAdmin As Boolean = False

    Private Sub Form_CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()

        sql = "SELECT TOP 1 * FROM tb_LOGIN ORDER BY id_usuario DESC"
        rs = db.Execute(sql)

        If firstAdmin Then
            Cb_TipoConta.SelectedIndex = 0
            Cb_TipoConta.Text = "ADMINISTRADOR GERAL"
            Cb_TipoConta.Enabled = False
            firstAdmin = False
            Exit Sub
        End If

        'Acrescentando 1 no ID do usuário
        If rs.EOF = False Then
            ID = rs.Fields(0).Value + 1
        End If
    End Sub

    Private Sub Btn_Salvar_Click(sender As Object, e As EventArgs) Handles Btn_Salvar.Click
        'Checar se todos os campos foram preenchidos
        If Txt_user.Text = "" Or Txt_senha.Text = " " Or Txt_resposta.Text = "" Or Txt_RepetirSenha.Text = "" Or Txt_email.Text = "" Then
            MessageBox.Show("Preencha todos os campos!", "Aviso")
        Else
            'Checa e-mail
            If Not Txt_email.Text.Contains("@") Then
                MessageBox.Show("O E-Mail inserido não é válido!", "Erro")
                Txt_email.Select()
                Return
            End If

            'Checar se as senhas batem
            If Txt_senha.Text <> Txt_RepetirSenha.Text Then
                MessageBox.Show("As senhas não batem!")
                Txt_RepetirSenha.Select()
            Else
                'Inserção no banco de dados
                sql = "INSERT INTO tb_login (id_usuario,usuario,email,senha,pergunta_secreta,resposta_secreta,status_conta,tipo_conta,num_tentativas) VALUES " +
                    "(" & ID & ",'" & Txt_user.Text & "','" & Txt_email.Text & "','" & Txt_senha.Text & "','" & Cb_Pergunta.Text & "','" & Txt_resposta.Text & "','ATIVA'," +
                " '" & Cb_TipoConta.Text.ToUpper() & "',3)"
                Try
                    rs = db.Execute(sql)
                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso")
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erro")
                End Try
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

    Private Sub Txt_user_Leave(sender As Object, e As EventArgs) Handles Txt_user.Leave
        'Checar se usuário já existe
        sql = "SELECT * FROM TB_LOGIN WHERE USUARIO ='" & Txt_user.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            MessageBox.Show("Já existe uma conta com esse nome de usuário! Por favor, insira outro nome!")
            Txt_user.Select()
        End If
    End Sub
End Class