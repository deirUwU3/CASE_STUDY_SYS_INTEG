Imports MySql.Data.MySqlClient

Public Class updfacultyuser
    Public adminid As String
    Public idget As String

    Private Sub updfacultyuser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Position.Items.Clear()
        Position.Items.Add("Part-timer")
        Position.Items.Add("Professor")
        Position.Items.Add("Dean")
        statusb()
        updpart()
    End Sub
    Private Sub updpart()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' First query: Get login details
                Dim query As String = "SELECT * FROM facultylogin WHERE facultyid = @fid"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fid", idget)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            facultyID.Text = idget
                            UserName.Text = reader("Username").ToString()
                            Password.Text = reader("Password").ToString()
                            statusbox1.Text = reader("Status").ToString()
                        End If
                    End Using ' Reader 1 is closed here
                End Using

                ' Second query: Get profile details
                Dim query1 As String = "SELECT * FROM facultytable WHERE facultyid = @fid"
                Using cmd As New MySqlCommand(query1, conn)
                    cmd.Parameters.AddWithValue("@fid", idget)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            LastName.Text = reader("LastName").ToString()
                            FirstName.Text = reader("FirstName").ToString()
                            Position.Text = reader("Position").ToString()
                        End If
                    End Using ' Reader 2
                End Using

            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub
    Private Sub statusb()
        statusbox1.Items.Clear()
        statusbox1.Items.Add("Active")
        statusbox1.Items.Add("Deactive")
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        adminmuser.adminid = adminid
        adminmuser.Show()
        Me.Close()
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked Then
            Password.PasswordChar = ControlChars.NullChar
        Else
            Password.PasswordChar = "*"
        End If
    End Sub

    Private Sub submitstudent_Click(sender As Object, e As EventArgs) Handles submitstudent.Click
        Dim try1 As String
        If LastName.Text = "" Or FirstName.Text = "" Or Position.Text = "" Or UserName.Text = "" Or Password.Text = "" Or statusbox1.Text = "" Then
            MsgBox("Error! missing input")
            Return
        End If

        If statusbox1.Text = "Active" Then
            try1 = "3"
        Else
            try1 = "0"
        End If

        If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            clrall()
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim facultytable As String = "Update facultytable set  Lastname=@lname, Firstname=@fname, Position=@pos where facultyId = @fID "

                Using student1 As New MySqlCommand(facultytable, conn, transaction)
                    student1.Parameters.AddWithValue("@lname", LastName.Text)
                    student1.Parameters.AddWithValue("@FName", FirstName.Text)
                    student1.Parameters.AddWithValue("@pos", Position.Text)
                    student1.Parameters.AddWithValue("@fID", facultyID.Text)
                    student1.ExecuteNonQuery()
                End Using

                ' Insert into studentlogin
                Dim facultylogin As String = "Update facultylogin set Username=@username, Password=@Password, attempt=@try, Status=@status where facultyId = @fID "
                Using student2 As New MySqlCommand(facultylogin, conn, transaction)
                    student2.Parameters.AddWithValue("@UserName", UserName.Text)
                    student2.Parameters.AddWithValue("@Password", Password.Text)
                    student2.Parameters.AddWithValue("@try", try1)
                    student2.Parameters.AddWithValue("@Status", statusbox1.Text)
                    student2.Parameters.AddWithValue("@fID", facultyID.Text)
                    student2.ExecuteNonQuery()
                End Using

                transaction.Commit()

                MessageBox.Show("Request Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clrall2()

                Me.Close()
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
        End Using

    End Sub
    Private Sub clrall()
        updpart()
    End Sub
    Private Sub clrall2()
        facultyID.Clear()
        LastName.Clear()
        FirstName.Clear()
        Position.Text = ""
        UserName.Clear()
        Password.Clear()
        statusbox1.Text = ""
    End Sub
    Private Sub updfacultyuser_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        adminmuser.adminid = adminid
        adminmuser.dataingrid()
        adminmuser.Show()
    End Sub


End Class