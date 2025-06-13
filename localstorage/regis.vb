Imports MySql.Data.MySqlClient

Public Class regis
    Public staffid As String
    Public timenow As String








    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

    Private Sub me_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Using conn As MySqlConnection = Data.GetConnection()
            conn.Open()
            LogLogoutTime(conn)
            conn.Close()
        End Using

        LocalLogin.Show()
    End Sub

    Private Sub LogLogoutTime(conn As MySqlConnection)
        Try
            Dim sql As String = "UPDATE facultytrail SET logouttime = @logout_time WHERE facultyid = @fid and loginTime = @time "
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@fid", staffid)
                cmd.Parameters.AddWithValue("@time", timenow)
                cmd.Parameters.AddWithValue("@logout_time", DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles regrec.Click

    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles changepass.Click

    End Sub

    Private Sub regis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class