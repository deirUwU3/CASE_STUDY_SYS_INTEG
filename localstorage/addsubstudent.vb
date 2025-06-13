Imports System.Transactions
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class addsubstudent
    Public whatfrm As String
    Public adminid As String
    Dim dept As String
    Dim subcode As String
    Private Sub addsubstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ffname.Hide()
        slname.Hide()
        flname.Hide()
        bothcbox()
    End Sub

    Private Sub bothcbox()
        studcbox.Items.Clear()
        subbox.Items.Clear()


        Using conn As MySqlConnection = Data.GetConnection()
            Try

                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block

                transaction = conn.BeginTransaction()

                If whatfrm = "1" Then
                    Dim query As String = "SELECT studentid FROM studenttable"
                    Using cmd As New MySqlCommand(query, conn, transaction)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                studcbox.Items.Add(reader("studentid").ToString())
                            End While
                        End Using
                    End Using
                ElseIf whatfrm = "2" Then
                    Dim query As String = "SELECT studentid FROM studenttable inner join coursetable On studentable.course = coursetable.courseid
                        inner Join facultytable On  coursetable.department =facultytable.deparmentid where facultytable.facultyid =@fid"
                    Using cmd As New MySqlCommand(query, conn, transaction)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                studcbox.Items.Add(reader("studentid").ToString())
                            End While
                        End Using
                    End Using
                End If


            Catch ex As Exception

            Finally
                ' Close connection if it's still open
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub studcbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studcbox.SelectedIndexChanged
        subbox.Items.Clear()
        slname.Show()
        flname.Text = ""
        ffname.Text = ""

        Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                transaction = conn.BeginTransaction()

                Dim selectit As String = "SELECT course FROM studenttable where studentid= '" & studcbox.Text & "'"
                Using cmd As New MySqlCommand(selectit, conn, transaction)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            dept = reader("course").ToString()
                        End While
                    End Using
                End Using


                Dim query1 As String = "SELECT subjecttable.subjectname FROM subjecttable inner join coursetable on subjecttable.department = coursetable.department where subjecttable.department = 'General' or coursetable.courseid = '" & dept & "'"
                Using cmd As New MySqlCommand(query1, conn, transaction)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            subbox.Items.Add(reader("subjectname").ToString())

                        End While
                    End Using
                End Using

                Dim idname As String = "SELECT lastname, firstname FROM studenttable where studentid= '" & studcbox.Text & "'"
                Using cmd As New MySqlCommand(idname, conn, transaction)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim lname As String = reader("lastname").ToString()
                            Dim Fname As String = reader("firstname").ToString()

                            slname.Text = lname + ", " + Fname
                        End While
                    End Using
                End Using

                transaction.Commit()
            Catch ex As Exception
                If transaction IsNot Nothing Then
                    Try
                        transaction.Rollback()
                    Catch rollbackEx As Exception
                        MessageBox.Show("Error rolling back transaction: " & rollbackEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                MessageBox.Show("Error submitting request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()

            End Try

        End Using

    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        adminmsubject.adminid = adminid
        adminmsubject.Show()
        Me.Close()
    End Sub

    Private Sub subbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles subbox.SelectedIndexChanged
        ffname.Show()
        flname.Show()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim idname As String = "SELECT facultytable.facultyid, facultytable.lastname, facultytable.firstname, subjecttable.subjectcode " &
                               "FROM subjecttable " &
                               "INNER JOIN facultytable ON subjecttable.facultyid = facultytable.facultyid " &
                               "WHERE subjecttable.subjectname = @subjectname"

                Using cmd As New MySqlCommand(idname, conn)
                    cmd.Parameters.AddWithValue("@subjectname", subbox.Text)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            flname.Text = reader("facultyid").ToString()

                            Dim lname As String = reader("lastname").ToString()
                            Dim fname As String = reader("firstname").ToString()
                            subcode = reader("subjectcode").ToString()
                            ffname.Text = lname & ", " & fname
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using

    End Sub

    Private Sub subjectadd_Click(sender As Object, e As EventArgs) Handles subjectadd.Click

        If studcbox.Text = "" Or subbox.Text = "" Then
            MessageBox.Show("Error! Missing Input")
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "SELECT * FROM gradetable WHERE Studentid = @student AND subjectcode = @subcode"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@student", studcbox.Text)
                    cmd.Parameters.AddWithValue("@subcode", subcode)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Error! Same Subject Exists in the Database")
                            Return
                        End If
                    End Using ' <-- Reader is now properly closed
                End Using

                If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
                    Return
                End If

                Dim section1table As String = "INSERT INTO gradetable(studentid, subjectcode) VALUES(@student, @code)"
                Using student1 As New MySqlCommand(section1table, conn)
                    student1.Parameters.AddWithValue("@student", studcbox.Text)
                    student1.Parameters.AddWithValue("@code", subcode)
                    student1.ExecuteNonQuery()
                End Using

                MessageBox.Show("Request submitted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clrall()
                If whatfrm = "1" Then
                    adminmsubject.adminid = adminid
                    adminmsubject.tableofsubject()
                    adminmsubject.Show()
                ElseIf whatfrm = "2" Then
                    DeanSubject.staffid = adminid
                    DeanSubject.Show()
                End If

                Me.Close()

            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using

    End Sub
    Private Sub clrall()
        studcbox.Items.Clear()
        slname.Text = ""
        subbox.Items.Clear()
        flname.Text = ""
        ffname.Text = ""
        subcode = ""
    End Sub
End Class