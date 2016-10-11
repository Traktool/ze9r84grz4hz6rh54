Imports MySql.Data.MySqlClient

Public Class Manager
    Public Shared Accounts As New MySqlConnection
    Public Shared AccountsSync As New Object
    Public Shared Sub OpenConnexion()

        Try

            Dim ConnexionString As String = "server=localhost;" _
                                    & "uid=root;" _
                                    & "pwd=root;" _
                                    & "database=spyritia_others;"

            Accounts.ConnectionString = ConnexionString
            Accounts.Open()

            frmHome.RichTextBox1.AppendText("Connected to MySQL server." & vbCrLf)


        Catch ex As MySqlException
            frmHome.RichTextBox1.AppendText("Can't connect to MySQL server : " & vbCrLf & ex.ToString)

        End Try

    End Sub


End Class
