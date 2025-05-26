Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls

Public Class adminmcourse
    Public adminid As String

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
        adminmsubject.Show()
        Me.Hide()
    End Sub
    Private Sub dashboard_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.Show()
        Me.Hide()
    End Sub
    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        Adminmstudent.adminid = adminid
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
        LocalLogin.Show()
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
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

    Private Sub macayear_Click(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.Show()
        Me.Hide()
    End Sub
End Class