Imports MySql.Data.MySqlClient
Imports System.Collections.Specialized.BitVector32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class addcourse
    Public adminid As String
    Private Sub addcourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles courseadd.Click

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                conn.Open()

                Dim query As String = "SELECT * FROM coursetable WHERE courseId= @StudentId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentId", inputabbre.Text)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        MessageBox.Show("Error! Same Course Exist in the Database")
                        clrall()
                        Return
                    End If


                End Using
            Catch ex As Exception

            Finally
                ' Close connection if it's still open
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using

        If inputcourse.Text = "" Then
            MessageBox.Show("Error! Missing Input")
            Return
        End If
        If inputabbre.Text = "" Then
            MessageBox.Show("Error! Missing Input")
            Return
        End If
        If MsgBox("Are you sure you want to add this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        ''in working
        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "INSERT INTO coursetable(courseId, course, status)" &
                                         "VALUES(@ID, @course, @status)"
                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@ID", inputcourse.Text)
                    student1.Parameters.AddWithValue("@course", inputabbre.Text)
                    student1.Parameters.AddWithValue("@status", "Active")
                    student1.ExecuteNonQuery()
                End Using

                Dim insert As String = "INSERT INTO facultyupd(	Facultyid, Input, courseid, Time)" &
                                         "VALUES(@ID, @input,@course, @time)"
                Using s As New MySqlCommand(insert, conn, transaction)
                    s.Parameters.AddWithValue("@ID", adminid)
                    s.Parameters.AddWithValue("@input", "Add")
                    s.Parameters.AddWithValue("@course", inputcourse.Text)
                    s.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    s.ExecuteNonQuery()
                End Using


                transaction.Commit()

                MessageBox.Show("Request submitted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            clrall()
            adminmcourse.adminid = adminid
            adminmcourse.combobx()
            adminmcourse.Show()

            Me.Close()
        End Using
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        adminmcourse.Show()
        clrall()
        Me.Close()
    End Sub
    Public Sub clrall()
        inputabbre.Text = ""
        inputabbre.Text = ""
    End Sub


End Class