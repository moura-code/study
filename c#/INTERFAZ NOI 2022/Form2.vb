Imports System.Data.Sql
Imports System.Data.SqlClient
Imports FirebirdSql
Imports FirebirdSql.Data.FirebirdClient
Imports System.Data.Odbc

Public Class Form2
    Dim fb_string As New FbConnectionStringBuilder
    Dim fb_conexion As New Odbc.OdbcConnection
    Dim conexion As String = "user=sysdba;Password=masterkey;database=C:\Users\SISTEMAS\Documents\BASES FIREBIR\IMAGENF.fdb;datasourse=localhost"
    Dim cone As FbConnection = New FbConnection(conexion)

    Private datagridview1 As Object
    Private Firebird As Integer
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cone.Open()
        fb_conexion.ConnectionString = fb_string.ToString
        Try
            MsgBox("Conexion Exitosa!")
        Catch ex As Exception
            MsgBox("Conexion Fallida!")
        End Try


        Form8.Show()



    End Sub

    Private Function InterBase(r As Object) As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        End

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class