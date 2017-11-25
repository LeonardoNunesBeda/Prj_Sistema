Public Class FormListarFornecedores
    Private Sub FormListarFornecedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        gerar_dados(False)
    End Sub

    Sub gerar_dados(Filter As Boolean)
        With dgv_forn
            .Rows.Clear()
            If Filter Then
                Dim campo As String = "cnpj"
                Select Case cb_selecione.SelectedIndex
                    Case 0
                        campo = "cnpj"
                    Case 1
                        campo = "nome_forn"
                    Case 2
                        campo = "responsavel"
                End Select

                sql = "SELECT * FROM TB_FORNECEDOR WHERE " & campo & " LIKE '%" & txt_parametro.Text.ToUpper & "%'"
            Else
                sql = "SELECT * FROM TB_FORNECEDOR"
            End If

            rs = db.Execute(sql)
            If rs.EOF Then
                MessageBox.Show("Não foram encontrados resultados!")
            Else
                Do While rs.EOF = False
                    dgv_forn.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value)
                    rs.MoveNext()
                Loop
            End If
        End With
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        gerar_dados(True)
    End Sub

    Private Sub dgv_forn_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_forn.CellContentClick
        Try
            With dgv_forn
                If .CurrentRow.Cells(5).Selected Then
                    Form_CadastroForn.editarUser = True
                    Form_CadastroForn.editID = .CurrentRow.Cells(0).Value
                    Form_CadastroForn.ShowDialog()
                    gerar_dados(False)
                End If
                If .CurrentRow.Cells(4).Selected Then
                    FormListarProdutos.txt_parametro.Enabled = False
                    FormListarProdutos.cb_selecione.Enabled = False
                    sql = "SELECT * FROM tb_produto WHERE fornecedor_cnpj = '" & .CurrentRow.Cells(0).Value & "'"
                    rs = db.Execute(sql)
                    With FormListarProdutos.dgv_dados
                        .Rows.Clear()
                        Do While rs.EOF = False
                            .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                            rs.MoveNext()
                        Loop
                    End With
                    FormListarProdutos.ShowDialog()
                    gerar_dados(False)
                End If
                If .CurrentRow.Cells(6).Selected Then
                    Dim resp = MsgBox("Deseja excluir o fornecedor " & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_fornecedor WHERE CNPJ = '" & .CurrentRow.Cells(0).Value & "'"
                        rs = db.Execute(sql)
                        gerar_dados(False)
                    End If
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message, "Erro")
        End Try
    End Sub
End Class