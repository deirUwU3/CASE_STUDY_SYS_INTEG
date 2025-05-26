Imports MySql.Data.MySqlClient

Public Class adminmsubject
    Public adminid As String
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
        Adminmstudent.Show()
        Me.Hide()
    End Sub

    Private Sub mcourse_Click(sender As Object, e As EventArgs) Handles mcourse.Click
        adminmcourse.adminid = adminid
        adminmcourse.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.Show()
        Me.Hide()
    End Sub

    Private Sub muser_Click(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub macayear_Click(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.Show()
        Me.Hide()
    End Sub

    Private Sub msubject_Click(sender As Object, e As EventArgs) Handles msubject.Click

    End Sub


    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

    Private Sub adminmanagesubject_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
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
End Class