Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gerar_dados(False)
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                Dim id_user = .CurrentRow.Cells(0).Value
                If .CurrentRow.Cells(5).Selected Then
                    If .CurrentRow.Cells(2).Value = "ATIVA" Then
                        sql = "UPDATE tb_login set STATUS_CONTA = 'BLOQUEADA', NUM_TENTATIVAS = 0 where ID_USUARIO= " & id_user
                        MsgBox("Conta bloqueada com sucesso!")
                    Else
                        sql = "UPDATE tb_login set STATUS_CONTA = 'ATIVA', NUM_TENTATIVAS = 3 where ID_USUARIO= " & id_user
                        MsgBox("Conta ativada com sucesso!")
                    End If
                    rs = db.Execute(sql)
                    gerar_dados(False)
                End If
                If .CurrentRow.Cells(6).Selected Then
                    Dim resp = MsgBox("Deseja excluir o usuário " & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_login WHERE id_usuario = " & id_user
                        rs = db.Execute(sql)
                        gerar_dados(False)
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Erro: ", ex.Message)
        End Try
    End Sub

    Sub gerar_dados(Filter As Boolean)
        With dgv_dados
            .Rows.Clear()
            If Filter Then
                sql = "SELECT * FROM TB_LOGIN WHERE " & cb_selecione.Text & " LIKE '%" & txt_parametro.Text.ToUpper & "%'"
            Else
                sql = "SELECT * FROM TB_LOGIN"
            End If

            rs = db.Execute(sql)
            If rs.EOF Then
                MessageBox.Show("Não foram encontrados resultados!")
            Else
                Do While rs.EOF = False
                    .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                    rs.MoveNext()
                Loop
            End If
        End With
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        gerar_dados(True)
    End Sub
End Class