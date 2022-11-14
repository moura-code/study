Imports FirebirdSql.Data.FirebirdClient
Public Class Form8


    Public Class dbconexion

        Dim Conexion As New FbConnection
        Dim fb_string As FbConnectionStringBuilder = New FbConnectionStringBuilder

        Public Sub conectar()
            ' Se forma la cadena de conexion
            fb_string.ServerType = FbServerType.Default
            fb_string.UserID = "sysdba"
            fb_string.Password = "masterkey"
            fb_string.Dialect = 3
            fb_string.Database = "\\ayoserver3\DACASPEL\Sistemas Aspel\NOI8.00\Datos\empresa05\INDAQUING.fdb"
            fb_string.Pooling = False
            ' se realiza la conexion
            Try
                Conexion.ConnectionString = fb_string.ToString
                Conexion.Open()

                If Conexion.State = ConnectionState.Open Then
                    Console.WriteLine("Conexión a [" & fb_string.Database & "] establecida")
                End If

            Catch err As FbException
                Console.WriteLine("Error: No se pudo realizar la conexión a [" & fb_string.Database & "]")
                Console.WriteLine(err.Message)
            End Try

        End Sub
    End Class
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            CenterToScreen()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Me.Hide()
            Form3.Show()

        End Sub

        Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        End Sub

        Private Sub DomainUpDown1_SelectedItemChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
            CenterToScreen()
        End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class