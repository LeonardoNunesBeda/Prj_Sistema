Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastrarCompras

    Public frm As New FormLogin()
    Public Vendedor As String = frm.usuario
    Dim Codigo As Integer
    Dim valor, cont As Integer
    Dim ids As String

    Private Sub Form_CadastrarCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        sql = "SELECT * FROM TB_COMPRA "
        rs = db.Execute(sql)
        If rs.EOF = False Then
            Codigo = rs.Fields(0).Value
        End If
        lbl_codigo.Text = Codigo + 1
    End Sub

    Private Sub btn_add_produto_Click(sender As Object, e As EventArgs) Handles btn_add_produto.Click
        FormListarProdutos.Show()
    End Sub

    Private Sub Btn_compra_Click(sender As Object, e As EventArgs) Handles Btn_compra.Click
        ValidarCompra()
    End Sub

    Public Sub ValidarCompra()
        If Txt_CPF.Text = "" And cb_cpf.Checked = True Then
            MsgBox("Preencha todos os campos necessários *")
        Else
            If lst_produtos.Items.Count = 0 Then
                MsgBox("Carrinho sem produtos")
            Else
                Do While lst_produtos.Items.ToString() <> ""
                    sql = "SELECT * FROM TB_PRODUTOS WHERE NOME_PROD = '" & lst_produtos.ToString() & "'"
                    rs = db.Execute(sql)
                    valor += rs.Fields(2).Value
                    ids += "'" & rs.Fields(0).Value & "',"
                    cont = CInt(lst_produtos.Items.Count.ToString())
                    Dim QTD As Integer = rs.Fields(3).Value
                    sql = "UPDATE TB_PRODUTOS SET QUANTIDADE = '" & (QTD - 1) & "' WHERE ID_PRODUTO = '" & rs.Fields(0).Value & "'"
                    db.Execute(sql)
                Loop
                usuario()
                Dim ide As Integer = rs.Fields(0).Value
                Try
                    sql = "INSERT INTO TB_COMPRA (ID_COMPRA,CLIENTE,ID_VENDEDOR,ID_PRODUTO,QUANTIDADE,VALOR_TOTAL) VALUES ('" & Codigo + 1 & "','" & Txt_CPF.Text & "','" & ide & "','" & ids & "', " +
                        " '" & cont & "','" & valor & "')"
                    rs = db.Execute(sql)
                    MsgBox("Compra efetuada com sucesso")
                Catch ex As System.IO.IOException
                    MsgBox("Error: " + ex.Message)
                End Try
            End If
        End If
    End Sub

    Public Sub usuario()
        Dim frm_login As New FormLogin
        sql = "SELECT * FROM TB_LOGIN WHERE USUARIO='" & frm_login.usuario & "'"
        rs = db.Execute(sql)
    End Sub

    Private Sub cb_cpf_CheckedChanged(sender As Object, e As EventArgs) Handles cb_cpf.CheckedChanged
        Txt_CPF.Enabled = True
    End Sub
End Class