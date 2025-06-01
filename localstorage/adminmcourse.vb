Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls

Public Class adminmcourse
    Public adminid As String
    Public timenow As String
    Private Sub adminmanagecourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataofdatagrid()
        combobx()

    End Sub
    Public Sub combobx()
        Using conn As MySqlConnection = Data.GetConnection()
            Searchid.Items.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT courseid FROM coursetable where status = 'Active'"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Searchid.Items.Add(reader("courseid").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub msubject_Click(sender As Object, e As EventArgs) Handles msubject.Click
        adminmsubject.adminid = adminid
        adminmsubject.timenow = timenow
        adminmsubject.Show()
        Me.Hide()
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
    Public Sub dataofdatagrid()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                ' Query to fetch data from the RequestStatusTable only for the current user
                Dim query As String = "
                 SELECT 
     coursetable.CourseId,
     sectiontable.Section,
     coursetable.Course
 FROM 
     coursetable
     INNER JOIN sectiontable  ON coursetable.CourseId = sectiontable.sectioncourse where coursetable.status = 'Active' and coursetable.CourseId like @id  "

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
                MessageBox.Show("No SCourse found for the current Data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
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

    Private Sub Searchid_SelectedIndexChanged(sender As Object, e As EventArgs)
        dataofdatagrid()
    End Sub

    Private Sub mcourse_Click(sender As Object, e As EventArgs) Handles mcourse.Click

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles addcourse1.Click
        addcourse.adminid = adminid
        addcourse.Show()
        Me.Hide()
    End Sub

    Private Sub addsection_Click(sender As Object, e As EventArgs) Handles updsection1.Click
        addsection.adminid = adminid
        addsection.Show()
        Me.Hide()
    End Sub

    Private Sub updcourse_Click(sender As Object, e As EventArgs) Handles updcourse1.Click
        updcourse.adminid = adminid
        updcourse.Show()
        Me.Hide()
    End Sub

    Private Sub muser_Click(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.timenow = timenow
        adminmuser.Show()
        Me.Hide()
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
End Class