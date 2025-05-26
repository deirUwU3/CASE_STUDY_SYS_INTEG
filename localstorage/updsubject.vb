Imports System.CodeDom
Imports MySql.Data.MySqlClient

Public Class updsubject
    Public adminid As String
    Public getid As String
    Private numid As String
    Private Sub updsubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combosearch()
        insubject()
    End Sub

    Private Sub combosearch()
        clname.Items.Clear()
        cdepartment.Items.Clear()

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block

                transaction = conn.BeginTransaction()

                Dim query As String = "SELECT facultyid FROM facultytable"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            clname.Items.Add(reader("facultyid").ToString())
                        End While
                    End Using
                End Using

                Dim query1 As String = "SELECT departmentid FROM deparmenttable"
                Using cmd As New MySqlCommand(query1, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            cdepartment.Items.Add(reader("departmentid").ToString())
                        End While
                    End Using
                End Using

                transaction.Commit()
            Catch ex As Exception

            Finally
                ' Close connection if it's still open
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub insubject()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' Begin transaction only if you need atomic reads (not typical for SELECT)
                Dim transaction As MySqlTransaction = conn.BeginTransaction()

                ' First Query - Get subject data
                Dim query As String = "
                SELECT * 
                FROM subjecttable 
                WHERE SubjectName = @Subjectname"
                Using cmd As New MySqlCommand(query, conn, transaction)
                    cmd.Parameters.AddWithValue("@Subjectname", getid)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            inputsubject.Text = reader("SubjectName").ToString()
                            clname.Text = reader("facultyid").ToString()
                            inputUnit.Text = reader("Unit").ToString()
                            cdepartment.Text = reader("department").ToString()
                            numid = reader("subjectid").ToString()
                        End If
                    End Using
                End Using

                ' Second Query - Get faculty last name
                Dim query1 As String = "SELECT lastname FROM facultytable WHERE facultyid = @idname"
                Using cmd As New MySqlCommand(query1, conn, transaction)
                    cmd.Parameters.AddWithValue("@idname", clname.Text)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            exfname.Text = dr("lastname").ToString()
                        Else
                            exfname.Text = ""
                        End If
                    End Using
                End Using

                ' Third Query - Get department name
                Dim query2 As String = "SELECT departmentname FROM deparmenttable WHERE departmentid = @dename"
                Using cmd As New MySqlCommand(query2, conn, transaction)
                    cmd.Parameters.AddWithValue("@dename", cdepartment.Text)
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            departname.Text = dr("departmentname").ToString()
                        Else
                            departname.Text = ""
                        End If
                    End Using
                End Using

                ' If you were using a transaction:
                transaction.Commit()

            Catch ex As Exception
                MessageBox.Show("Error retrieving subject info: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Private Sub inputUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inputUnit.KeyPress
        ' Allow only digits and control keys (like backspace)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block the input
        End If
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

    Private Sub subjectadd_Click(sender As Object, e As EventArgs) Handles subjectadd.Click
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                If inputsubject.Text = "" Or clname.Text = "" Or inputUnit.Text = "" Or cdepartment.Text = "" Then
                    MsgBox("Missing Input try again")
                    Return
                    combosearch()
                    insubject()
                End If

                If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
                    Return
                End If

                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "Update subjecttable set  Subjectname=@subject, Facultyid=@name, Unit=@unit, Department=@department WHERE SubjectId = @id"

                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@subject", inputsubject.Text)
                    student1.Parameters.AddWithValue("@name", clname.Text)
                    student1.Parameters.AddWithValue("@unit", inputUnit.Text)
                    student1.Parameters.AddWithValue("@department", cdepartment.Text)
                    student1.Parameters.AddWithValue("@id", numid)
                    student1.ExecuteNonQuery()
                End Using


                transaction.Commit()
                MessageBox.Show("Request Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clrall()
                adminmsubject.adminid = adminid
                adminmsubject.tableofsubject()
                adminmsubject.Show()
                Me.Close()

            Catch ex As Exception
                        MessageBox.Show("Error loading student data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try


        End Using

    End Sub
End Class