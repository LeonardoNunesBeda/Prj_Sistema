Public Class FormMenu
    Public frm As New FormLogin()
    Public tipo_conta2 As String = frm.tipo_conta
    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        FormCadastroConta.Show()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
        lbl_nome.Text = frm.usuario
        If tipo_conta2 = "ADMINISTRADOR" Then
            ManutençãoDeContasToolStripMenuItem.Visible = True
        Else
            ManutençãoDeContasToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub ListaDeStatusDeContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeStatusDeContaToolStripMenuItem.Click
        FormStatus.Show()
    End Sub
End Class