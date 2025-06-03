Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class adminfrm
    Public adminid As String
    Public timenow As String
    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        Adminmstudent.adminid = adminid
        Adminmstudent.timenow = timenow
        Adminmstudent.Show()
        Adminmstudent.mstudent.PerformClick()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click

        Me.Close()

    End Sub


    Private Sub atrail_Click(sender As Object, e As EventArgs) Handles atrail.Click
        admintrail.adminid = adminid
        admintrail.timenow = timenow
        admintrail.Show()
        Me.Hide()
    End Sub

    Private Sub mcourse_Click(sender As Object, e As EventArgs) Handles mcourse.Click
        adminmcourse.adminid = adminid
        adminmcourse.timenow = timenow
        adminmcourse.Show()
        Me.Hide()

    End Sub

    Private Sub adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                cmd.Parameters.AddWithValue("@fid", adminid)
                cmd.Parameters.AddWithValue("@time", timenow)
                cmd.Parameters.AddWithValue("@logout_time", DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub muser_Click_1(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.timenow = timenow
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub msubject_Click_1(sender As Object, e As EventArgs) Handles msubject.Click
        adminmsubject.adminid = adminid
        adminmsubject.timenow = timenow
        adminmsubject.Show()
        Me.Hide()
    End Sub

    Private Sub macayear_Click_1(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.timenow = timenow
        adminmay.Show()
        Me.Hide()
    End Sub
End Class