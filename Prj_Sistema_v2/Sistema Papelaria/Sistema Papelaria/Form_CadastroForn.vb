Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroForn

    Private Sub btn_add_prod_Click(sender As Object, e As EventArgs) Handles btn_add_prod.Click
        Form_CadastrarProdutos.ShowDialog()
    End Sub

    Private Sub btn_del_prod_Click(sender As Object, e As EventArgs)
        lst_produtos.Items.Remove(lst_produtos.SelectedIndex)
    End Sub

    Private Sub Form_CadastroForn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        loadLstProdutos()
    End Sub

    Private Sub btn_salvar_Click(sender As Object, e As EventArgs) Handles btn_salvar.Click
        'Valida produtos
        sql = "SELECT COUNT(*) AS qtd FROM tb_produto"
        rs = db.Execute(sql)

        If rs.Fields(0).Value <= 0 Then
            MessageBox.Show("Não há produtos cadastrados! Cadastre ao menos um produto e o selecione na lista!")
            Form_CadastrarProdutos.ShowDialog()
            loadLstProdutos()
            Exit Sub
        End If

        If lst_produtos.SelectedItems.Count <= 0 Then
            MessageBox.Show("Selecione pelo menos um produto na lista!")
            loadLstProdutos()
            Exit Sub
        End If

        Txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        Dim cnpjNoFormat As String = Txt_cnpj.Text
        Txt_cnpj.TextMaskFormat = MaskFormat.IncludePromptAndLiterals

        If Txt_cnpj.Text <> "" And Txt_nome.Text <> "" And Txt_responsavel.Text <> "" Then
            sql = "INSERT INTO TB_FORNECEDOR (CNPJ, NOME_FORN, CONTATO,RESPONSAVEL) VALUES ('" & cnpjNoFormat & "','" & Txt_nome.Text & "', '" & Txt_tel.Text & "', '" & Txt_responsavel.Text & "')"
            rs = db.Execute(sql)

            For Each item As String In lst_produtos.SelectedItems
                sql = "SELECT cod_prod FROM tb_produto WHERE nome_prod = '" & item & "'"
                rs = db.Execute(sql)
                sql = "INSERT INTO tb_prod_forn(cod_prod, cnpj_forn) VALUES(" & rs.Fields(0).Value & ", '" & cnpjNoFormat & "')"
                rs = db.Execute(sql)
            Next

            MsgBox("Cadastrado com sucesso!")
            lst_produtos.SelectedItems.Clear()
            Txt_cnpj.Clear()
            Txt_nome.Clear()
            Txt_responsavel.Clear()
            Txt_tel.Clear()
        Else
            MsgBox("Preencha todos os campos!")
        End If

    End Sub

    Public Sub loadLstProdutos()
        lst_produtos.Items.Clear()

        sql = "SELECT nome_prod FROM tb_produto"
        rs = db.Execute(sql)

        If Not rs.EOF Then
            While Not rs.EOF
                lst_produtos.Items.Add(rs.Fields(0).Value)
                rs.MoveNext()
            End While
        End If

        lst_produtos.SelectedItems.Clear()

    End Sub
End Class