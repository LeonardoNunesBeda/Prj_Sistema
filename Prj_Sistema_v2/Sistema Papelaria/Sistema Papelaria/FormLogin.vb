Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb

Public Class FormLogin
    Public cont As Integer = 3
    Public tipo_conta As String
    Public usuario As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        cmb_acesso.SelectedIndex = 0
    End Sub

    Private Sub Btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If Validar() Then
            'Usuário existe, senha correta
            FormMenu.tipo_conta = tipo_conta
            FormMenu.user = usuario
            FormMenu.Show()
            Close()
        End If
    End Sub

    Private Function Validar() As Boolean

        'Validação básica
        If txt_user.Text = "" Then 'Usuário
            MessageBox.Show("Insira seu nome de usuário!", "Erro")
            Return False
        End If
        If txt_senha.Text = "" Then 'Senha
            MessageBox.Show("Insira sua senha", "Erro")
            Return False
        End If

        'Validação por Query 

        'Busca usuários existentes
        sql = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & txt_user.Text & "'"
        rs = db.Execute(sql)

        'Usuário inserido não existe
        If rs.EOF Then
            MessageBox.Show("O usuário inserido não foi encontrado, certifique-se de preencher os campos corretamente", "Erro")
            txt_user.Select()
            Return False
        Else 'Usuário existe
            sql = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & txt_user.Text & "' AND SENHA = '" & txt_senha.Text & "'"
            rs = db.Execute(sql)

            'Carrega tipo de usuário
            cmb_acesso.SelectedIndex = 0
            If rs.EOF = False Then
                If rs.Fields(7).Value = "ADMINISTRADOR" Then
                    cmb_acesso.SelectedIndex = 1
                End If
            End If

            'Usuário existe, Senha incorreta
            If rs.EOF Then
                MessageBox.Show("A senha inserida está incorreta!", "Erro")
                txt_senha.Select()
                DimTentativa()
                Return False
            End If
        End If

        usuario = rs.Fields(1).Value
        tipo_conta = rs.Fields(7).Value

        Return True
    End Function

    Sub DimTentativa()
        If cont <= 1 Then
            cont = 0
            lbl_tentativas.Text = "0"
            BloquearUser()
            Return
        Else
            cont -= 1
            lbl_tentativas.Text = cont
            sql = "UPDATE tb_login SET num_tentativas = " & cont & " WHERE usuario = '" & txt_user.Text & "'"
            rs = db.Execute(sql)
            End If
            End Sub

    Sub BloquearUser()
        MessageBox.Show("O limite de tentativas foi excedido!" & vbCrLf & "Usuário " & txt_user.Text & " Bloqueado!", "Erro")
        sql = "UPDATE tb_login SET status_conta = 'BLOQUEADA', num_tentativas = 0 WHERE usuario = '" & txt_user.Text & "'"
        rs = db.Execute(sql)
        txt_user.Clear()
        txt_user.Select()
        txt_senha.Clear()
        cmb_acesso.SelectedIndex = 0
    End Sub

    Private Sub lbl_senha_Click(sender As Object, e As EventArgs) Handles lbl_senha.Click
        FormRecuperarSenha.ShowDialog()
    End Sub

    Private Sub txt_user_Leave(sender As Object, e As EventArgs) Handles txt_user.Leave
        If txt_user.Text = "" Then
            Return
        Else
            sql = "SELECT status_conta, num_tentativas, tipo_conta FROM tb_login WHERE usuario = '" & txt_user.Text & "'"
            rs = db.Execute(sql)

            'Usuário inserido não existe
            If rs.EOF Then
                Return
            Else 'Usuário inserido existe, retorna o num de tentativas do db
                If rs.Fields(0).Value = "BLOQUEADA" Then
                    'Impede o acesso do usuário bloqueado
                    MessageBox.Show("A conta inserida foi bloqueada temporiariamente.\nContate o Administrador do Sistema para desbloqueá-la", "Erro")
                    txt_user.Clear()
                    txt_senha.Clear()
                    txt_user.Select()
                Else
                    'Carrega tipo de usuário
                    cmb_acesso.SelectedIndex = 0
                    If rs.Fields(2).Value = "Administrador" Then
                        cmb_acesso.SelectedIndex = 1
                    End If

                    'Carrega cont do usuario
                    cont = rs.Fields(1).Value
                    lbl_tentativas.Text = cont
                End If
            End If
        End If
    End Sub

End Class
