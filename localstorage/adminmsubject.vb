Imports MySql.Data.MySqlClient

Public Class adminmsubject
    Public adminid As String
    Public timenow As String
    Private Sub adminmanagesubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tableofsubject()
    End Sub
    Private Sub subjectname_TextChanged(sender As Object, e As EventArgs) Handles subjectname.TextChanged
        tableofsubject()
    End Sub
    Public Sub tableofsubject()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT subjecttable.subjectname As 'Subject Name', facultytable.LastName, subjecttable.Unit, subjecttable.Department 
             FROM subjecttable 
             inner join facultytable
             on  subjecttable.facultyId = facultytable.FacultyId
            where subjecttable.SubjectName like @name"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", subjectname.Text & "%")
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
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            If Dataview.Rows.Count > 0 Then
                datagridv.DataSource = Dataview
            Else
                MessageBox.Show("No Student found for the current Data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
    Public Sub deparmentbox()
        Using conn As MySqlConnection = Data.GetConnection()

        End Using
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

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.timenow = timenow
        adminfrm.Show()
        Me.Hide()
    End Sub

    Private Sub muser_Click(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.timenow = timenow
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub macayear_Click(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.timenow = timenow
        adminmay.Show()
        Me.Hide()
    End Sub

    Private Sub msubject_Click(sender As Object, e As EventArgs) Handles msubject.Click

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
                cmd.Parameters.AddWithValue("@fid", adminid)
                cmd.Parameters.AddWithValue("@time", timenow)
                cmd.Parameters.AddWithValue("@logout_time", DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss"))
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub addsubject_Click(sender As Object, e As EventArgs) Handles addsubject1.Click
        addsubject.Show()
        addsubject.adminid = adminid
        Me.Hide()
    End Sub

    Private Sub actstudent_Click(sender As Object, e As EventArgs) Handles actstudent.Click
        If datagridv.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = datagridv.SelectedRows(0)
            ' Using conn As MySqlConnection = Data.GetConnection()
            'If conn.State = ConnectionState.Open Then conn.Close()
            ' End Using
            updsubject.adminid = adminid
            updsubject.getid = selectedRow.Cells(0).Value.ToString()
            updsubject.Show()

            Me.Hide()
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles addsubstudentbtn.Click

        addsubstudent.adminid = adminid
        addsubstudent.Show()

        Me.Hide()

    End Sub

    Private Sub adminmanagesubject_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
    End Sub

    Private Sub atrail_Click(sender As Object, e As EventArgs) Handles atrail.Click
        admintrail.adminid = adminid
        admintrail.timenow = timenow
        admintrail.Show()
        Me.Hide()
    End Sub
End Class