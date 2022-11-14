Imports System.Data.Sql
Imports System.Data.SqlClient
Imports FirebirdSql
Imports FirebirdSql.Data.FirebirdClient
Imports System.Data.Odbc

Public Class Form3
    Private Sub Button5_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As String = "user=sysdba;Password=masterkey;database=C:\Users\SISTEMAS\Documents\BASES FIREBIR\ETLASG.fdb;datasourse=localhost"
        Dim cone As FbConnection = New FbConnection(conexion)
        Dim cmd As New FbCommand(conexion)
        Dim datos As New FbDataAdapter("Select * from NWNOMINAS08", cone)
        Dim DS As New DataGridTableStyle
        DS = New DataGridTableStyle
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As String = "user=sysdba;Password=masterkey;database=C:\Users\SISTEMAS\Documents\BASES FIREBIR\ETLASG.fdb;datasourse=localhost"
        Dim cone As FbConnection = New FbConnection(conexion)
        Dim cmd As New FbCommand(conexion)
        Dim datos As New FbDataAdapter("Select * from TB31101701", cone)

        Form5.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form7.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click


        Form9.Show()

    End Sub
End Class