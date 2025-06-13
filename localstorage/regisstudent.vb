Imports MySql.Data.MySqlClient

Public Class regisstudent
    Public staffid As String
    Public timenow As String
    Private Sub regisstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Searchid_TextChanged(sender As Object, e As EventArgs) Handles Searchid.TextChanged
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
End Class