Imports MySql.Data.MySqlClient

Public Class adminmuser
    Public adminid As String
    Public timenow As String
    Private Sub adminmanageuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataingrid()
    End Sub
    Public Sub dataingrid()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                ' Query to fetch data from the RequestStatusTable only for the current user
                Dim query As String = "
                 SELECT 
     facultylogin.FacultyId,
     facultytable.LastName,
     facultytable.FirstName,
     facultytable.Position,
     facultylogin.Username,
     facultylogin.Status
         FROM 
     facultytable
     INNER JOIN facultylogin  ON facultytable.FacultyId = facultylogin.FacultyId  where facultytable.FacultyId like @id  "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Searchid.Text & "%")
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
                datagridv.DataSource = Dataview
            Else
                MessageBox.Show("No Student found for the current Data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub

    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.timenow = timenow
        adminfrm.Show()
        Me.Hide()
    End Sub

    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        Adminmstudent.adminid = adminid
        Adminmstudent.timenow = timenow
        Adminmstudent.Show()
        Me.Hide()
    End Sub

    Private Sub mcourse_Click(sender As Object, e As EventArgs) Handles mcourse.Click
        adminmcourse.adminid = adminid
        adminmcourse.timenow = timenow
        adminmcourse.Show()
        Me.Hide()
    End Sub

    Private Sub msubject_Click(sender As Object, e As EventArgs) Handles msubject.Click
        adminmsubject.adminid = adminid
        adminmsubject.timenow = timenow
        adminmsubject.Show()
        Me.Hide()
    End Sub

    Private Sub updUser_Click(sender As Object, e As EventArgs) Handles updUser.Click
        ''unfinish
        If datagridv.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = datagridv.SelectedRows(0)
            updfacultyuser.adminid = adminid
            updfacultyuser.idget = selectedRow.Cells(0).Value.ToString()
            updfacultyuser.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub addsection1_Click(sender As Object, e As EventArgs) Handles adduser.Click

        addfacultyuser.adminid = adminid
        addfacultyuser.Show()
        Me.Hide()
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
    Private Sub me_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Using conn As MySqlConnection = Data.GetConnection()
            conn.Open()
            LogLogoutTime(conn)
            conn.Close()
        End Using

        LocalLogin.Show()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()

    End Sub

    Private Sub macayear_Click(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.timenow = timenow
        adminmay.Show()
        Me.Hide()
    End Sub

    Private Sub atrail_Click(sender As Object, e As EventArgs) Handles atrail.Click
        admintrail.adminid = adminid
        admintrail.timenow = timenow
        admintrail.Show()
        Me.Hide()
    End Sub

    Private Sub Searchid_TextChanged(sender As Object, e As EventArgs) Handles Searchid.TextChanged
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                ' Query to fetch data from the RequestStatusTable only for the current user
                Dim query As String = "
                 SELECT 
     facultylogin.FacultyId,
     facultytable.LastName,
     facultytable.FirstName,
     facultytable.Position,
     facultylogin.Username,
     facultylogin.Status
         FROM 
     facultytable
     INNER JOIN facultylogin  ON facultytable.FacultyId = facultylogin.FacultyId  where facultytable.LastName like @id  "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Searchid.Text & "%")
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
                datagridv.DataSource = Dataview
            Else
                MessageBox.Show("No Student found for the current Data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
End Class