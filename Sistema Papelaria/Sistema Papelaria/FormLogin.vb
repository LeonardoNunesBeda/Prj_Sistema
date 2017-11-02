Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormLogin
    Public cont As Integer
    Public tipo_conta As String
    Public usuario As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        cont = 3
        lbl_tentativas.Text = cont
    End Sub

    Private Sub Btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Validar()
    End Sub

    Private Function Validar() As Boolean

        'Validação básica
        If txt_user.Text = "" Then
            MessageBox.Show("Insira seu nome de usuário!", "Erro")
            Return False
        End If

        'Validação por query
        If txt_senha.Text = "" Then
            MessageBox.Show("Insira sua senha", "Erro")
            Return False
        End If

        'Query para Buscar usuários existentes
        sql = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & txt_user.Text & "' AND SENHA ='" & txt_senha.Text & "'"
        rs = db.Execute(sql)
        'Validação de usuário
        If rs.EOF = False Then
            If txt_user.Text = rs.Fields(1).Value Or txt_user.Text = rs.Fields(2).Value And txt_senha.Text = rs.Fields(3).Value Then
                'Verificação Verdadeira de usuário
                If rs.EOF = True Then
                    'Query de insert para a quantidade de tentativas
                    sql = "UPDATE TB_LOGIN SET NUM_TENTATIVAS = '" & cont & "' WHERE USUARIO = '" & txt_user.Text & "'"
                    rs = db.Execute(sql)
                    sql = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & txt_user.Text & "' AND SENHA ='" & txt_senha.Text & "'"
                    rs = db.Execute(sql)
                    tipo_conta = rs.Fields(7).Value
                    usuario = txt_user.Text
                    FormMenu.Show()
                End If
            Else
                MsgBox("Usuário ou senha incorretos" + vbNewLine + "Tente novamente.")
                cont = cont - 1
                lbl_tentativas.Text = cont
                If cont < 1 Then
                    btn_entrar.Enabled = False
                    MsgBox("Você excedeu o limite de tentativas , sua conta foi bloqueada" + vbNewLine + "Contacte o Administrador", "Limite de tentativas Excedido")
                End If
            End If
        Else
            cont = cont - 1
            lbl_tentativas.Text = cont
            If cont < 1 Then
                btn_entrar.Enabled = False
                MsgBox("Você excedeu o limite de tentativas , sua conta foi bloqueada" + vbNewLine + "Contacte o Administrador", "Limite de tentativas Excedido")
            End If
        End If
        Return False

    End Function

    Private Sub Txt_user_TextChanged(sender As Object, e As EventArgs) Handles txt_user.TextChanged
        sql = "SELECT * FROM TB_LOGIN WHERE usuario = '" & txt_user.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Dim nome As String = rs.Fields(3).ToString
            lbl_tentativas.Text = rs.Fields(8).Value
            Lbl_acesso.Text = rs.Fields(7).Value
            If Lbl_acesso.Text = "ADMINISTRADOR" Then
                cmb_acesso.SelectedIndex(0)
            Else
                cmb_acesso.SelectedIndex(2)
            End If
        End If

    End Sub

    Private Sub Txt_senha_TextChanged(sender As Object, e As EventArgs) Handles txt_senha.TextChanged
        If btn_entrar.Enabled = False Then
            sql = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & txt_user.Text & "' TIPO_CONTA = Administrador"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                If txt_user.Text = rs.Fields(1).Value Or txt_user.Text = rs.Fields(2).Value And txt_senha.Text = rs.Fields(3).Value Then
                    btn_entrar.Enabled = True
                    cont = 3
                    lbl_tentativas.Text = cont
                End If
            End If
        End If


    End Sub

    Private Sub lbl_senha_Click(sender As Object, e As EventArgs) Handles lbl_senha.Click
        FormRecuperarSenha.Show()
    End Sub
End Class
