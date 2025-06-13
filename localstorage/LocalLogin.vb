Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class LocalLogin

    Private Sub LocalLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblrole.Text = ""
        lblattempts.Text = ""
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        tpassword.Clear()
        tusername.Clear()
        lblattempts.Text = ""
        lblrole.Text = ""
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Dim username As String = tusername.Text
        Dim password As String = tpassword.Text

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MsgBox("Please enter both 
username and password.", vbCritical)
            Return
        End If

        If lblattempts.Text = "0" Then
            MsgBox("Your Account is Disable, Ask the Admin to Update", vbCritical)
            Return
        End If
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM facultylogin WHERE Username = @username AND Password = @password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Dim role As String = reader("Role").ToString()
                            Dim aid As String = reader("FacultyID").ToString()
                            Dim attempts As Integer = Convert.ToInt32(reader("Attempt"))
                            Dim status As String = reader("Status").ToString().ToLower()
                            Dim timenow As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                            If attempts = 0 Or status = "deactivated" Then
                                lblrole.Text = "Your account is disabled."
                                tusername.Clear()
                                tpassword.Clear()
                                Return
                            End If

                            ' Proceed to dashboard
                            If role = "Admin" Then
                                adminfrm.adminid = aid
                                adminfrm.timenow = timenow
                                reader.Close()
                                LogLoginTime(aid, role, timenow, conn)
                                adminfrm.Show()
                            ElseIf role = "Professor" Then
                                staff.staffid = aid
                                staff.timenow = timenow
                                reader.Close()
                                LogLoginTime(aid, role, timenow, conn)
                                staff.Show()
                            ElseIf role = "Registar" Then
                                regis.staffid = aid
                                regis.timenow = timenow
                                reader.Close()
                                LogLoginTime(aid, role, timenow, conn)
                                regis.Show()
                            End If
                            Me.Hide()
                            b2.PerformClick()
                            Return
                        End If
                    End Using ' Close reader before running new query

                    ' If login fails, check if username exists and manage attempts
                    Dim queryFailed As String = "SELECT * FROM facultylogin WHERE Username = @username"
                    Using cmdFailed As New MySqlCommand(queryFailed, conn)
                        cmdFailed.Parameters.AddWithValue("@username", username)
                        Using readerFailed As MySqlDataReader = cmdFailed.ExecuteReader()
                            If readerFailed.HasRows Then
                                readerFailed.Read()
                                Dim attempts As Integer = Convert.ToInt32(readerFailed("Attempt"))

                                If attempts <= 0 Then
                                    readerFailed.Close()
                                    updatestatus(username, conn)
                                    MsgBox("You have reached the maximum attempts! Your account is now disabled.")
                                    Me.Close()
                                Else
                                    readerFailed.Close()
                                    MsgBox("Login Failed!", MsgBoxStyle.Critical)
                                    lblattempts.Text = (attempts - 1).ToString()
                                    updateattempts(username, lblattempts.Text, conn)
                                End If
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                lblrole.Text = "Database error: " & ex.Message
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Private Sub LogLoginTime(username As String, role As String, timenow As String, conn As MySqlConnection)
        Try
            Dim sql As String = "INSERT INTO facultytrail (Facultyid, Role, LoginTime) VALUES (@username, @role, @login_time)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@role", role) ' ← ito ang tamang parameter name
                cmd.Parameters.AddWithValue("@login_time", timenow)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            lblrole.Text = "Error logging login time: " & ex.Message
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub updateattempts(username As String, attempts As String, conn As MySqlConnection)
        Try
            Dim sql As String = "UPDATE facultylogin SET attempt = @attempts WHERE username = @username"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@attempts", attempts)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            lblrole.Text = "Error updating attempts: " & ex.Message
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub updatestatus(username As String, conn As MySqlConnection)
        Try

            Dim sql As String = "Update facultylogin SET Status = 'Deactivated' WHERE Username = @username"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            lblrole.Text = "Error updating status: " & ex.Message
            MessageBox.Show("Error details: " & ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            tpassword.PasswordChar = ControlChars.NullChar
        Else
            tpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub tusername_TextChanged(sender As Object, e As EventArgs) Handles tusername.TextChanged
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                ' Open connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT role, attempt FROM facultylogin WHERE Username = @username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", tusername.Text)

                    ' Execute the query and read the data
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' If a record is found, display the role and attempts
                            lblrole.Text = dr("role").ToString()
                            lblattempts.Text = dr("attempt").ToString()
                        Else
                            ' If no record is found, display 'No account exists'
                            lblrole.Text = ""
                            lblattempts.Text = ""
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
End Class
