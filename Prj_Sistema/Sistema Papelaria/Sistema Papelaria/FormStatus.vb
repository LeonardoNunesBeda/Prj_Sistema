Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With .dgv_dados
            .Rows.Clear()
            sql = "SELECT * FROM TB_lOGIN "
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub

    Private Sub Txt_parametro_TextChanged(sender As Object, e As EventArgs) Handles txt_parametro.TextChanged
        gerar_dados()
    End Sub
End Class