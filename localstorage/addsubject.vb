Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class addsubject
    Public adminid As String
    Public whatfrm As String


    Private Sub addsubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lnamebox()
        departmentbox()
    End Sub
    Private Sub lnamebox()
        If whatfrm = "1" Then
            Using conn As MySqlConnection = Data.GetConnection()
                clname.Items.Clear()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT Facultyid FROM facultytable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            clname.Items.Add(reader("Facultyid").ToString())
                        End While
                    End Using
                End Using
                If conn.State = ConnectionState.Open Then conn.Close()
            End Using
        ElseIf whatfrm = "2" Then
            Using conn As MySqlConnection = Data.GetConnection()
                clname.Items.Clear()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT Facultyid FROM facultytable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            clname.Items.Add(reader("Facultyid").ToString())
                        End While
                    End Using
                End Using
                If conn.State = ConnectionState.Open Then conn.Close()
            End Using
        End If

    End Sub
    Private Sub departmentbox()
        cdepartment.Items.Clear()
        If whatfrm = "1" Then
            Using conn As MySqlConnection = Data.GetConnection()
                cdepartment.Items.Clear()
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim query As String = "SELECT DepartmentId FROM deparmenttable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cdepartment.Items.Add(reader("DepartmentId").ToString())
                        End While
                    End Using
                End Using
                If conn.State = ConnectionState.Open Then conn.Close()
            End Using
        ElseIf whatfrm = "2" Then
            Using conn As MySqlConnection = Data.GetConnection()
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "SELECT DeparmentId FROM facultytable WHERE facultyid = @fid"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fid", adminid) ' Add parameter before executing the command

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cdepartment.Items.Add(reader("DeparmentId").ToString())
                        End While
                    End Using
                End Using
            End Using


        End If

    End Sub

    Private Sub cdepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cdepartment.SelectedIndexChanged
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                ' Open connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT departmentname FROM deparmenttable where departmentid = @username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", cdepartment.Text)

                    ' Execute the query and read the data
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' If a record is found, display the role and attempts
                            departname.Text = dr("departmentname").ToString()
                        Else
                            departname.Text = ""
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
    Private Sub inputUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputUnit.KeyPress
        ' Allow only digits and control keys (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If
    End Sub

    Private Sub exfname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clname.SelectedIndexChanged
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                ' Open connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT lastname FROM facultytable where facultyid = @username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", clname.Text)

                    ' Execute the query and read the data
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' If a record is found, display the role and attempts
                            exfname.Text = dr("lastname").ToString()
                        Else
                            exfname.Text = ""
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

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        clrall()
        adminmsubject.adminid = adminid
        adminmsubject.Show()
        Me.Close()
    End Sub
    Private Sub clrall()
        inputsubject.Clear()
        clname.Items.Clear()
        exfname.Text = ""
        inputUnit.Clear()
        cdepartment.Items.Clear()
        departname.Text = ""
    End Sub

    Private Sub subjectadd_Click(sender As Object, e As EventArgs) Handles subjectadd.Click

        If inputsubject.Text = "" Or inputUnit.Text = "" Or exfname.Text = "" Or cdepartment.Text = "" Or scode.Text = "" Then
            MessageBox.Show("Error! Missing Input")
            Return
        End If

        If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM subjecttable WHERE SubjectName = @subject "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@subject", inputsubject.Text)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Error! Same Subject Exist in the Database")
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
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM subjecttable WHERE Subjectcode = @scode "
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@scode", scode.Text)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Error! Same Subjectid Exist in the Database")
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
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim section1table As String = "INSERT INTO subjecttable(SubjectName, Facultyid, Unit, Department, Subjectcode ) " &
                                         "VALUES(@subject, @faculty, @unit, @depart, @scode )"
                Using student1 As New MySqlCommand(section1table, conn, transaction)
                    student1.Parameters.AddWithValue("@subject", inputsubject.Text)
                    student1.Parameters.AddWithValue("@faculty", clname.Text)
                    student1.Parameters.AddWithValue("@unit", inputUnit.Text)
                    student1.Parameters.AddWithValue("@depart", cdepartment.Text)
                    student1.Parameters.AddWithValue("@scode", scode.Text)
                    student1.ExecuteNonQuery()
                End Using

                transaction.Commit()

                MessageBox.Show("Request submitted successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clrall()
                If whatfrm = "1" Then
                    adminmsubject.adminid = adminid
                    adminmsubject.tableofsubject()
                    adminmsubject.Show()
                ElseIf whatfrm = "2" Then
                    DeanSubject.staffid = adminid
                    DeanSubject.tableof()
                    DeanSubject.Show()
                End If
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
End Class