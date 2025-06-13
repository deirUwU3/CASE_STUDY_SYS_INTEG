Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class DeanSubject
    Public staffid As String
    Public timenow As String
    Private Sub changepass_Click(sender As Object, e As EventArgs) Handles changepass.Click
        changepassstaff.staffid = staffid
        changepassstaff.key = "7"
        changepassstaff.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dean.staffid = staffid
        Dean.timenow = timenow
        Dean.Show()
        Me.Hide()
    End Sub
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

    Private Sub regrec_Click(sender As Object, e As EventArgs) Handles regrec.Click

    End Sub

    Private Sub DeanSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableof()
    End Sub
    Public Sub tableof()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                ' Query to fetch data from the RequestStatusTable only for the current user
                Dim query As String = "
                 SELECT 
     Studenttable.StudentId,
     Studenttable.LastName,
     Studenttable.FirstName,
     Studenttable.Course,
     Studenttable.Section,
     Studentlogin.Username,
     Studentlogin.Status
 FROM 
     Studenttable 
     INNER JOIN Studentlogin ON Studenttable.StudentId = Studentlogin.StudentId
     where Studenttable.StudentId like @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", xbox.Text & "%")
                    cmd.ExecuteNonQuery()
                    Using adapter As New MySqlDataAdapter(cmd)
                        ' Fill the DataTable with the query results
                        adapter.Fill(Dataview)
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any errors during the database operation
                MessageBox.Show("Error fetching request status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            If Dataview.Rows.Count > 0 Then
                datav.DataSource = Dataview
            Else
                MessageBox.Show("No Student found for the current Data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        addsubject.adminid = staffid
        addsubject.whatfrm = "2"
        addsubject.Show()
        Me.Hide()
    End Sub

    Private Sub xbox_TextChanged(sender As Object, e As EventArgs) Handles xbox.TextChanged
        tableof()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        addsubstudent.adminid = staffid
        addsubstudent.whatfrm = "2"
        addsubstudent.Show()
        Me.Hide()
    End Sub
End Class