Imports MySql.Data.MySqlClient

Public Class updcourse
    Public adminid As String
    Private Sub updcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        courseshow()
        statusbox.Items.Add("Active")
        statusbox.Items.Add("Deactive")
    End Sub
    Private Sub courseshow()
        Using conn As MySqlConnection = Data.GetConnection()
            coursebox.Items.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT courseid FROM coursetable"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        coursebox.Items.Add(reader("courseid").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub coursebox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles coursebox.SelectedIndexChanged
        inputabbre.Enabled = "true"
        statusbox.Enabled = "true"
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                ' Open connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT * FROM coursetable WHERE CourseId = @course"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@course", coursebox.Text)

                    ' Execute the query and read the data
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' If a record is found, display the role and attempts
                            inputabbre.Text = dr("Course").ToString()
                            statusbox.Text = dr("status").ToString()
                        Else
                            ' If no record is found, display 'No account exists'
                            inputabbre.Text = ""
                        End If
                    End Using
                End Using
            Catch ex As Exception
            Finally
                ' Close connection if it's still open
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

        End Using
    End Sub

    Private Sub courseupd_Click(sender As Object, e As EventArgs) Handles courseupd.Click
        If inputabbre.Text = "" Then
            MsgBox("Error! Missing input!")
            Return
        End If

        If MsgBox("Are you sure you want to update this course?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "Update coursetable set  course=@abbre, status=@status where CourseId = '" & coursebox.Text & "'"

                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@abbre", inputabbre.Text)
                    student1.Parameters.AddWithValue("@status", statusbox.Text)
                    student1.ExecuteNonQuery()
                End Using

                transaction.Commit()

                MessageBox.Show("Request Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                ' Rollback the transaction if any error occurs
                If transaction IsNot Nothing Then
                    Try
                        transaction.Rollback()
                    Catch rollbackEx As Exception
                        MessageBox.Show("Error rolling back transaction: " & rollbackEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                MessageBox.Show("Error submitting request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Ensure the connection is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
            adminmcourse.combobx()
            adminmcourse.dataofdatagrid()
            adminmcourse.adminid = adminid
            adminmcourse.Show()
            Me.Close()
        End Using
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        adminmcourse.Show()
        Me.Close()
    End Sub
End Class