Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb.OleDbConnection
Imports System.Data.OleDb
Module MOD_CONEX

    Public db As New ADODB.connection
    Public rs As New adodb.recordset
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
    Sub gerar_dados()
        With FormStatus.dgv_dados
            .Rows.Clear()
            sql = "SELECT * FROM TB_lOGIN WHERE " & FormLogin.cb_selecione.Text & " LIKE %'" & FormLogin.txt_parametro.Text & "'%"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Module
