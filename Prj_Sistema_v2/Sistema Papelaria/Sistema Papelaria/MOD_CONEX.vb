Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Module MOD_CONEX

    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, diretorio As String
    Public conexao = Application.StartupPath & "\papelariaDB.mdb"
    Public cont As Long

    Sub Conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("provider = Microsoft.Jet.OLEDB.4.0;Data Source=" & conexao)
        Catch ex As Exception
            MsgBox("Conexão falhou!")
        End Try

    End Sub
End Module
