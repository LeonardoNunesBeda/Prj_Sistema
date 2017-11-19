Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormRecuperarSenha

    Private Sub btn_recuperar_Click(sender As Object, e As EventArgs) Handles btn_recuperar.Click
        sql = "SELECT*FROM TB_LOGIN WHERE USUARIO='" & txt_user.Text & "'"
        rs = db.Execute(sql)
        If rs.EOF = False Then
            If cmb_pergunta.Text = rs.Fields(4).Value And txt_resp.Text = rs.Fields(5).Value Then
                MsgBox("Sua senha é: " + (rs.Fields(3).Value).ToString + ".")
            Else
                MsgBox("Resposta ou pergunta incorreta")
            End If
        Else
            MsgBox("Conta Inexistente")
        End If
    End Sub

    Private Sub FormRecuperarSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
    End Sub
End Class