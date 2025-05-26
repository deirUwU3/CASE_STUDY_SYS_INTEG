Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Addstudentfrm
    Public adminid As String
    Dim yr As String
    Dim sec As String
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        clrall()
    End Sub


    Private Sub clrall()
        StudentID.Clear()
        LastName.Clear()
        FirstName.Clear()
        course.Text = ""
        Section.Text = ""
        UserName.Clear()
        Password.Clear()
        Cpassword.Clear()
    End Sub

    Private Sub Addstudentfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Closed
        clrall()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles submitstudent.Click


        Using conn As MySqlConnection = Data.GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM studenttable WHERE StudentId = @StudentId"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentId", StudentID.Text)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        MessageBox.Show("Error! Same Student ID Exist in the Database")
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

        If Password.Text = Cpassword.Text Then
        Else
            MessageBox.Show("Error! Password Mismatch!")
            clrall()
            Return
        End If

        If StudentID.Text = "" Or LastName.Text = "" Or FirstName.Text = "" Or course.Text = "" Or Section.Text = "" Or UserName.Text = "" Or Password.Text = "" Or Cpassword.Text = "" Then
            MessageBox.Show("Error! Missing some information")
            Return
        End If
        If MsgBox("Are you sure you want to add this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "INSERT INTO studenttable(StudentId, Lastname, Firstname, Course, Section, `Year level` , semester " &
                                         "VALUES(@StudentID, @lastname, @firstname, @course, @Section, @yr, @sec)"
                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@StudentID", StudentID.Text)
                    student1.Parameters.AddWithValue("@lastname", LastName.Text)
                    student1.Parameters.AddWithValue("@FirstName", FirstName.Text)
                    student1.Parameters.AddWithValue("@course", course.Text)
                    student1.Parameters.AddWithValue("@Section", Section.Text)
                    student1.Parameters.AddWithValue("@yr", yr)
                    student1.Parameters.AddWithValue("@sec", sec)
                    student1.ExecuteNonQuery()
                End Using

                ' Insert into studentlogin
                Dim studentlogin As String = "INSERT INTO studentlogin(Username, Password, StudentId, Try, Status)" &
                                         "VALUES(@Username, @Password, @StudentID, @try, @Status)"
                Using student2 As New MySqlCommand(studentlogin, conn, transaction)
                    student2.Parameters.AddWithValue("@UserName", UserName.Text)
                    student2.Parameters.AddWithValue("@Password", Password.Text)
                    student2.Parameters.AddWithValue("@StudentID", StudentID.Text)
                    student2.Parameters.AddWithValue("@try", "3")
                    student2.Parameters.AddWithValue("@Status", "Active")
                    student2.ExecuteNonQuery()
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
        End Using

        clrall()
        Me.Close()
        Adminmstudent.refreshtable()
        Adminmstudent.Show()
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

    Private Sub Addstudentfrm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT courseid FROM coursetable"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        course.Items.Add(reader("courseid").ToString())
                    End While
                End Using
            End Using


            If conn.State = ConnectionState.Open Then conn.Close()
        End Using

    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        Section.Enabled = True
        Section.Items.Clear()
        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT section FROM sectiontable where sectioncourse = '" & course.Text & "'"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Section.Items.Add(reader("section").ToString())
                    End While
                End Using
            End Using


            If conn.State = ConnectionState.Open Then conn.Close()
        End Using

    End Sub

    Private Sub Section_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Section.SelectedIndexChanged
        Dim sectionVal As String = Section.Text
        If sectionVal.StartsWith("11") Then
            yr = "1"
            sec = "1"
        ElseIf Sectionval.StartsWith("12") Then
            yr = "1"
            sec = "2"
        ElseIf sectionVal.StartsWith("21") Then
            yr = "2"
            sec = "1"
        ElseIf sectionVal.StartsWith("22") Then
            yr = "2"
            sec = "2"
        ElseIf sectionVal.StartsWith("31") Then
            yr = "3"
            sec = "1"
        ElseIf sectionVal.StartsWith("32") Then
            yr = "3"
            sec = "2"
        ElseIf sectionVal.StartsWith("41") Then
            yr = "4"
            sec = "1"
        ElseIf sectionVal.StartsWith("42") Then
            yr = "4"
            sec = "2"
        End If
    End Sub
End Class