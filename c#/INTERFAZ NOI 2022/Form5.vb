Imports System.Data.Sql
Imports System.Data.SqlClient
Imports FirebirdSql
Imports FirebirdSql.Data.FirebirdClient
Imports System.Data.Odbc



Public Class Form5


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        End
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CenterToScreen()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As String = "user=sysdba;Password=masterkey;database=C:\Users\SISTEMAS\Documents\BASES FIREBIR\ETLASG.fdb;datasourse=localhost"
        Dim cone As OdbcConnection = New OdbcConnection(conexion)
        Dim da As OdbcDataAdapter
        da = New Odbc.OdbcDataAdapter("select * from TB31101701", conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub


End Class