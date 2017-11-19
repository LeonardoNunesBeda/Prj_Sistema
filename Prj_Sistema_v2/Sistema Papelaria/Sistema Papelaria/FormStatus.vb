Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Não está carregando nenhum usuário
        With dgv_dados
            .Rows.Clear()
            sql = "SELECT * FROM TB_lOGIN "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            Loop
            cb_selecione.SelectedIndex = 0
        End With
    End Sub

    Private Sub Txt_parametro_TextChanged(sender As Object, e As EventArgs) Handles txt_parametro.TextChanged
        dgv_dados.Rows.Clear()
        sql = "SELECT * FROM TB_lOGIN WHERE '" & cb_selecione.Text & "' LIKE %'" & txt_parametro.Text & "'%"
            rs = db.Execute(sql)
        Do While rs.EOF = False
            dgv_dados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
            rs.MoveNext()
        Loop
    End Sub

    Private Sub cb_selecione_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_selecione.SelectedIndexChanged
        gerar_dados()
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                Dim aux = .CurrentRow.Cells(1).Value.ToString
                If .CurrentRow.Cells(5).Selected = True Then
                    sql = "UPDATE * from tb_login set STATUS_CONTA ='ATIVA' AND NUM_TENTATIVAS = 3 where ID_USUARIO='" & aux & "'"
                    rs = db.Execute(sql)
                    MsgBox("Conta atualizada com sucesso")
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    Dim resp = MsgBox("Deseja Excluir" + vbNewLine + "Id:" & aux & "?", MsgBoxStyle.Question)
                    If resp = MsgBoxResult.Yes Then
                        sql = "delete * from tb_login where ID_USUARIO= '" & aux & "'"
                        rs = db.Execute(sql)
                        gerar_dados()
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro: ", ex.Message)
        End Try
    End Sub

    Sub gerar_dados()
        With dgv_dados
            .Rows.Clear()
            sql = "SELECT * FROM TB_LOGIN WHERE  '" & (cb_selecione.Text).ToUpper & "' ='%" & (txt_parametro.Text).ToUpper & "%'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                dgv_dados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class