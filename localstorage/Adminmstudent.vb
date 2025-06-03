Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Adminmstudent
    Public adminid As String
    Public timenow As String
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        managerstudenthide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
    End Sub

    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        refreshtable()
    End Sub
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        adminfrm.adminid = adminid
        adminfrm.timenow = timenow
        adminfrm.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles mcourse.Click
        adminmcourse.adminid = adminid
        adminmcourse.timenow = timenow
        adminmcourse.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles msubject.Click
        adminmsubject.adminid = adminid
        adminmsubject.timenow = timenow
        adminmsubject.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.timenow = timenow
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.timenow = timenow
        adminmay.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles atrail.Click
        admintrail.adminid = adminid
        admintrail.timenow = timenow
        admintrail.Show()
        Me.Hide()
    End Sub

    Private Sub addstudent1(sender As Object, e As EventArgs) Handles addstudent.Click
        Addstudentfrm.adminid = adminid
        Addstudentfrm.Show()
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles actstudent.Click

        If datagridv.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = datagridv.SelectedRows(0)
            ' Using conn As MySqlConnection = Data.GetConnection()
            'If conn.State = ConnectionState.Open Then conn.Close()
            ' End Using
            updstudent.adminid = adminid
            updstudent.IDget = selectedRow.Cells(0).Value.ToString()
            updstudent.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub managerstudenthide()
        datagridv.Hide()
        addstudent.Hide()
        actstudent.Hide()

        search.Hide()
        Searchid.Hide()
    End Sub
    Public Sub refreshtable()
        datagridv.Show()
        addstudent.Show()
        actstudent.Show()
        search.Show()
        Searchid.Show()
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
     INNER JOIN Studentlogin ON Studenttable.StudentId = Studentlogin.StudentId"

                Using cmd As New MySqlCommand(query, conn)

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

    Private Sub Searchid_TextChanged(sender As Object, e As EventArgs)
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


End Class