
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports FirebirdSql
Imports FirebirdSql.Data.FirebirdClient
Imports System.Data.Odbc
Public Class Form1
    Dim conexion As String = "user=sysdba;Password=masterkey;database=C:\Users\SISTEMAS\Documents\BASES FIREBIR\ETLASG.fdb;datasourse=localhost"
    Dim cone As FbConnection = New FbConnection(conexion)
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Contador < 100 Then
            ProgressBar1.Value = Contador
            Contador += 3
        Else
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()

        End If
    End Sub
    Dim Contador As Integer
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterToScreen()

    End Sub
End Class
