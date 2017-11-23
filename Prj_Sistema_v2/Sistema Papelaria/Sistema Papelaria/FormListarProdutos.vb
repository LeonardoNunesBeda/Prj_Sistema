Public Class FormListarProdutos
    Private Sub FormListarProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        'Query para listar os produtos
        gerar_dados(False)
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        gerar_dados(True)
    End Sub

    Sub gerar_dados(Filter As Boolean)
        With dgv_dados
            .Rows.Clear()
            If Filter Then
                Dim campo As String = "cod_prod"
                Select Case cb_selecione.SelectedIndex
                    Case 0
                        campo = "cod_prod"
                    Case 1
                        campo = "nome_prod"
                    Case 2
                        campo = "categoria"
                    Case 2
                        campo = "fornecedor_cnpj"
                End Select

                sql = "SELECT * FROM tb_produto WHERE " & campo & " LIKE '%" & txt_parametro.Text.ToUpper & "%'"
            Else
                sql = "SELECT * FROM tb_produto"
            End If

            'Ordenação por preço
            If cb_preço.Checked Then
                sql += " ORDER BY valor ASC"
            End If

            rs = db.Execute(sql)
            If rs.EOF Then
                MessageBox.Show("Não foram encontrados resultados!")
            Else
                Do While rs.EOF = False
                    dgv_dados.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value)
                    rs.MoveNext()
                Loop
            End If
        End With
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados
                If .CurrentRow.Cells(5).Selected Then
                    'Editar registro
                    gerar_dados(False)
                End If
                If .CurrentRow.Cells(6).Selected Then
                    Dim resp = MsgBox("Deseja excluir o produto " & .CurrentRow.Cells(1).Value & "?", MsgBoxStyle.YesNo)
                    If resp = MsgBoxResult.Yes Then
                        sql = "DELETE * FROM tb_produtos WHERE cod_prod = '" & .CurrentRow.Cells(0).Value & "'"
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