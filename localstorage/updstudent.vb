Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls
Imports Org.BouncyCastle.Bcpg
Imports System.Collections.Specialized.BitVector32
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class updstudent
    Public adminid As String
    Public IDget As String
    Dim yr As String
    Dim sec As String

    Private Sub adminmanagestudentupd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()

            Dim query As String = "SELECT courseid FROM coursetable"
            Using cmd As New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Coursebox.Items.Add(reader("courseid").ToString())
                    End While
                End Using
            End Using
            Statusbox.Items.Add("Active").ToString()
            Statusbox.Items.Add("Deactivated").ToString()
            If conn.State = ConnectionState.Open Then conn.Close()
        End Using
        ' Load Student Info + Sections based on Student Course
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "
                SELECT 
                    *
                FROM 
                    Studenttable 
                INNER JOIN 
                    Studentlogin ON Studenttable.StudentId = Studentlogin.StudentId
                WHERE 
                    Studenttable.StudentId = @StudentId
            "

                Dim courseName As String = ""
                Dim sectionName As String = ""

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StudentId", IDget)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()

                            StudentID.Text = IDget
                            Lastname.Text = reader("LastName").ToString()
                            Firstname.Text = reader("FirstName").ToString()
                            Coursebox.Text = reader("Course").ToString()
                            Statusbox.Text = reader("Status").ToString()
                            Tusername.Text = reader("Username").ToString()
                            Tpassword.Text = reader("Password").ToString()
                            sectionName = reader("Section").ToString()
                            courseName = reader("Course").ToString()
                        End If
                    End Using
                End Using

                ' Now load sections after the first reader is finished
                Dim query2 As String = "SELECT section FROM sectiontable WHERE sectioncourse = @CourseName"
                Using cmd2 As New MySqlCommand(query2, conn)
                    cmd2.Parameters.AddWithValue("@CourseName", courseName)

                    Using reader2 As MySqlDataReader = cmd2.ExecuteReader()
                        Sectionbox.Items.Clear()
                        While reader2.Read()
                            Sectionbox.Items.Add(reader2("section").ToString())
                        End While
                    End Using
                End Using

                Sectionbox.Text = sectionName ' Set the selected section

            Catch ex As Exception
                MessageBox.Show("Error loading student data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using

    End Sub


    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            Tpassword.PasswordChar = ControlChars.NullChar
        Else
            Tpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Adminmstudent.Show()
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim try1 As String
        If StudentID.Text = "" Or Lastname.Text = "" Or Firstname.Text = "" Or Tusername.Text = "" Or Tpassword.Text = "" Then
            MsgBox("Error! Missing Information", vbCritical)
            Return
        End If
        If Statusbox.Text = "Active" Then
            try1 = "3"
        Else
            try1 = "0"
        End If
        If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "Update studenttable set  Lastname=@lname, Firstname=@fname, Course=@course, Section=@section, `Year level` = @yr, semester=@sc  where StudentId = @studentID "

                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@lname", Lastname.Text)
                    student1.Parameters.AddWithValue("@FName", Firstname.Text)
                    student1.Parameters.AddWithValue("@course", Coursebox.Text)
                    student1.Parameters.AddWithValue("@Section", Sectionbox.Text)
                    student1.Parameters.AddWithValue("@yr", yr)
                    student1.Parameters.AddWithValue("@sc", sec)
                    student1.Parameters.AddWithValue("@StudentID", StudentID.Text)

                    student1.ExecuteNonQuery()
                End Using

                ' Insert into studentlogin
                Dim studentlogin As String = "Update studentlogin set Username=@username, Password=@Password, Try=@try, Status=@status where StudentId = @studentID "
                Using student2 As New MySqlCommand(studentlogin, conn, transaction)
                    student2.Parameters.AddWithValue("@UserName", Tusername.Text)
                    student2.Parameters.AddWithValue("@Password", Tpassword.Text)
                    student2.Parameters.AddWithValue("@try", try1)
                    student2.Parameters.AddWithValue("@Status", Statusbox.Text)
                    student2.Parameters.AddWithValue("@StudentID", StudentID.Text)
                    student2.ExecuteNonQuery()
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
            Me.Close()
            Adminmstudent.refreshtable()
            Adminmstudent.Show()
        End Using
    End Sub

    Private Sub Sectionbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Sectionbox.SelectedIndexChanged
        Dim sectionVal As String = Sectionbox.Text
        If sectionVal.StartsWith("11") Then
            yr = "1"
            sec = "1"
        ElseIf sectionVal.StartsWith("12") Then
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