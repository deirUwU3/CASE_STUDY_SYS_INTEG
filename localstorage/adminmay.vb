Imports System.Web.UI.WebControls
Imports MySql.Data.MySqlClient

Public Class adminmay
    Public adminid As String
    Public timenow As String
    Private Sub Terms_Click(sender As Object, e As EventArgs) Handles Terms.Click
        termfrm.Show()
        Me.Hide()
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

    Private Sub muser_Click(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.timenow = timenow
        adminmuser.Show()
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

    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        Adminmstudent.adminid = adminid
        Adminmstudent.timenow = timenow
        Adminmstudent.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.timenow = timenow
        adminfrm.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

    Private Sub semlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles semlist.SelectedIndexChanged
        dataintable()
    End Sub

    Private Sub yearlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearlist.SelectedIndexChanged
        dataintable()
    End Sub

    Private Sub dataintable()
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
     where Studenttable.`Year level` like @ylist and Studenttable.Semester like @slist "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ylist", yearlist.Text & "%")
                    cmd.Parameters.AddWithValue("@slist", semlist.Text & "%")
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

    Private Sub adminmay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ylist()
        slist()
        dataintable()
    End Sub

    Public Sub ylist()
        yearlist.Items.Clear()

        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT `Year level` from studenttable order by `Year level` asc
        "
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sectionValue As String = reader("Year level").ToString()
                        ' Add only if it's not already in the list
                        If Not yearlist.Items.Contains(sectionValue) Then
                            yearlist.Items.Add(sectionValue)
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub slist()
        semlist.Items.Clear()

        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT semester from studenttable  
        "
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim sectionValue As String = reader("semester").ToString()
                        ' Add only if it's not already in the list
                        If Not semlist.Items.Contains(sectionValue) Then
                            semlist.Items.Add(sectionValue)
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub atrail_Click(sender As Object, e As EventArgs) Handles atrail.Click
        admintrail.adminid = adminid
        admintrail.timenow = timenow
        admintrail.Show()
        Me.Hide()
    End Sub
End Class