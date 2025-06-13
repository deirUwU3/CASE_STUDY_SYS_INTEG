Imports MySql.Data.MySqlClient

Public Class regisstudent
    Public staffid As String
    Public timenow As String
    Private Sub regisstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        seeer()
    End Sub

    Public Sub seeer()
        Dim Dataview As New DataTable()

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "
            SELECT 
                Studenttable.StudentId,
                Studenttable.LastName,
                Studenttable.FirstName,
                Studenttable.Course,
                Studenttable.Section,
                Studentlogin.Status
            FROM 
                Studenttable 
                INNER JOIN Studentlogin ON Studenttable.StudentId = Studentlogin.StudentId
            WHERE 
                Studenttable.StudentId LIKE @id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Searchid.Text & "%")

                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(Dataview)
                    End Using
                End Using

                If Dataview.Rows.Count > 0 Then
                    datav.DataSource = Dataview

                    ' Optional: Formatting to fix layout
                    With datav
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                        .MultiSelect = False
                        .ReadOnly = True
                    End With
                Else
                    MessageBox.Show("No student found for the current data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Catch ex As Exception
                MessageBox.Show("Error fetching request status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub
    Private Sub Searchid_TextChanged(sender As Object, e As EventArgs) Handles Searchid.TextChanged
        seeer()

    End Sub

    Private Sub addstudent_Click(sender As Object, e As EventArgs) Handles addstudent.Click
        Addstudentfrm.whatfrm = "2"
        Addstudentfrm.adminid = staffid
        Addstudentfrm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        regis.staffid = staffid
        regis.timenow = timenow
        regis.Show()
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

    Private Sub changepass_Click(sender As Object, e As EventArgs) Handles changepass.Click
        changepassstaff.staffid = staffid
        changepassstaff.key = "5"
        changepassstaff.Show()
        Me.Hide()
    End Sub
End Class