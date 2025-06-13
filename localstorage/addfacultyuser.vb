Imports MySql.Data.MySqlClient
Imports System.Security.Claims
Imports System.Windows

Public Class addfacultyuser
    Public adminid As String
    Private Sub submitstudent_Click(sender As Object, e As EventArgs) Handles submitstudent.Click
        If facultyID.Text = "" Or FirstName.Text = "" Or LastName.Text = "" Or Position.Text = "" Or UserName.Text = "" Or Password.Text = "" Then
            MsgBox("Error! missing input")
            Return
        End If

        If Password.Text = Cpassword.Text Then
        Else
            MsgBox("Error! Different Password input")
            Return
        End If
        If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            clrall()
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT * FROM facultytable WHERE facultyid= @fid and position = @pos"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fid", facultyID.Text)
                    cmd.Parameters.AddWithValue("@pos", Position.Text)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Error! Same Section Exist in the Database")
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

        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                transaction = conn.BeginTransaction()

                ' Insert into facultytable
                Dim facultytable As String = "INSERT INTO facultytable(facultyid, lastname, firstname, position) " &
                                     "VALUES(@facultyid, @lastname, @firstname, @position)"
                Using student1 As New MySqlCommand(facultytable, conn, transaction)
                    student1.Parameters.AddWithValue("@facultyid", facultyID.Text)
                    student1.Parameters.AddWithValue("@lastname", LastName.Text)
                    student1.Parameters.AddWithValue("@firstname", FirstName.Text)
                    student1.Parameters.AddWithValue("@position", Position.Text)
                    student1.ExecuteNonQuery()
                End Using

                ' Insert into facultylogin
                Dim faculty1table As String = "INSERT INTO facultylogin(username, password, role,  facultyid, attempt, status) " &
                                      "VALUES(@username, @password, @role, @facultyid, @attempt, @status)"
                Using faculty As New MySqlCommand(faculty1table, conn, transaction)
                    faculty.Parameters.AddWithValue("@username", UserName.Text)
                    faculty.Parameters.AddWithValue("@password", Password.Text)
                    faculty.Parameters.AddWithValue("@role", "Professor")
                    faculty.Parameters.AddWithValue("@facultyid", facultyID.Text)
                    faculty.Parameters.AddWithValue("@attempt", "3")
                    faculty.Parameters.AddWithValue("@status", "Active")
                    faculty.ExecuteNonQuery()
                End Using


                Dim insert As String = "INSERT INTO facultyupd(	Facultyid, Input, staffid, Time)" &
                                         "VALUES(@ID, @input,@fid, @time)"
                Using s As New MySqlCommand(insert, conn, transaction)
                    s.Parameters.AddWithValue("@ID", adminid)
                    s.Parameters.AddWithValue("@input", "Add")
                    s.Parameters.AddWithValue("@fid", facultyID.Text)
                    s.Parameters.AddWithValue("@time", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                    s.ExecuteNonQuery()
                End Using

                transaction.Commit()
                MessageBox.Show("Request submitted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clrall()
                adminmcourse.adminid = adminid
                adminmcourse.combobx()
                adminmcourse.Show()
                Me.Close()
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        adminmuser.adminid = adminid
        adminmuser.Show()
        Me.Hide()
    End Sub
    Private Sub clrall()
        facultyID.Clear()
        LastName.Clear()
        FirstName.Clear()
        Position.Text = ""
        UserName.Clear()
        Password.Clear()
    End Sub

    Private Sub addfacultyuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Position.Items.Clear()
        Position.Items.Add("Part-timer")
        Position.Items.Add("Professor")
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked Then
            Password.PasswordChar = ControlChars.NullChar
            Cpassword.PasswordChar = ControlChars.NullChar
        Else
            Password.PasswordChar = "*"
            Cpassword.PasswordChar = "*"
        End If
    End Sub
End Class