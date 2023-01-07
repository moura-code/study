Imports System.Data.Sql
Imports System.Data.SqlClient
Imports FirebirdSql
Imports FirebirdSql.Data.FirebirdClient
Imports System.Data.Odbc



Public Class Class1
    Dim conexion As New fbconnection
    Dim fb_string As New fbconnectionstringbuilder
    Dim fb_conexion As New odbc.odbcconnection
    Public Sub conectar()
        Try
            conexion.connectionstring = "dsn=firebirdodbc;uid=sysdba;pwd=masterkey"
            conexion.open()
            Msgbox("conexion exitosa!")
        Catch ex As Exception
            msg("error en la conexion")
        End Try
    End Sub



End Class
