Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Public Class Form_CadastroUsuario
    Private Sub Form_CadastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conecta_banco()
    End Sub
End Class