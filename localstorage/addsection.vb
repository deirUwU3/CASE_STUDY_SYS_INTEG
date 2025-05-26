Imports MySql.Data.MySqlClient

Public Class addsection
    Public adminid As String
    Private Sub addsection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideinput()
        sectionnum.Items.Add("1")
        sectionnum.Items.Add("2")
        sectionnum.Items.Add("3")
        sectionnum.Items.Add("4")
        courseshow()
    End Sub
    Private Sub hideinput()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        input1.Hide()
        input2.Hide()
        input3.Hide()
        input4.Hide()
    End Sub
    Private Sub sectionnum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionnum.SelectedIndexChanged
        If sectionnum.Text = "1" Then
            Label1.Show()
            input1.Show()
            Label2.Hide()
            input2.Hide()
            Label3.Hide()
            input3.Hide()
            Label4.Hide()
            input4.Hide()
        ElseIf sectionnum.Text = "2" Then
            Label1.Show()
            input1.Show()
            Label2.Show()
            input2.Show()
            Label3.Hide()
            input3.Hide()
            Label4.Hide()
            input4.Hide()
        ElseIf sectionnum.Text = "3" Then
            Label1.Show()
            input1.Show()
            Label2.Show()
            input2.Show()
            Label3.Show()
            input3.Show()
            Label4.Hide()
            input4.Hide()
        ElseIf sectionnum.Text = "4" Then
            Label1.Show()
            input1.Show()
            Label2.Show()
            input2.Show()
            Label3.Show()
            input3.Show()
            Label4.Show()
            input4.Show()
        Else
            hideinput()
        End If
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

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        adminmcourse.adminid = adminid
        adminmcourse.Show()
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If coursebox.Text = "" Then
            MsgBox("Error! missing input")
            Return
        End If

        If MsgBox("Are you sure you want to update this student?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        If sectionnum.Text = "1" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM sectiontable WHERE section= @section and sectioncourse = '" & coursebox.Text & "'"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@section", input1.Text)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Error! Same Section Exist in the Database")
                            input1.Clear()
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
            If input1.Text = "" Then
            Else
                MessageBox.Show("Error! Missing Input")
                Return
            End If

            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim section1table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section1table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input1.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
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
        ElseIf sectionnum.Text = "2" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM sectiontable WHERE (section = @section OR section = @section2) and sectioncourse = '" & coursebox.Text & "'"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@section", input1.Text)
                        cmd.Parameters.AddWithValue("@section2", input2.Text)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Error! Same Section Exist in the Database")
                            input1.Clear()
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
            If input1.Text = "" Or input2.Text = "" Then
            Else
                MessageBox.Show("Error! Missing Input")
                Return
            End If

            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim section1table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section1table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input1.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section2table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section2table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input2.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
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

        ElseIf sectionnum.Text = "3" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM sectiontable WHERE (section = @section OR section = @section2 OR section = @section3) and sectioncourse = '" & coursebox.Text & "'"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@section", input1.Text)
                        cmd.Parameters.AddWithValue("@section2", input2.Text)
                        cmd.Parameters.AddWithValue("@section2", input3.Text)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Error! Same Section Exist in the Database")
                            input1.Clear()
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
            If input1.Text = "" Or input2.Text = "" Or input3.Text = "" Then
            Else
                MessageBox.Show("Error! Missing Input")
                Return
            End If

            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim section1table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section1table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input1.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section2table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section2table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input2.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section3table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section3table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input3.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
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

        ElseIf sectionnum.Text = "4" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Try
                    conn.Open()
                    Dim query As String = "SELECT * FROM sectiontable WHERE (section = @section OR section = @section2 OR section = @section3 OR section = @section4) and sectioncourse = '" & coursebox.Text & "'"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@section", input1.Text)
                        cmd.Parameters.AddWithValue("@section2", input2.Text)
                        cmd.Parameters.AddWithValue("@section3", input3.Text)
                        cmd.Parameters.AddWithValue("@section4", input4.Text)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Error! Same Section Exist in the Database")
                            input1.Clear()
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
            If input1.Text = "" Or input2.Text = "" Or input3.Text = "" Or input4.Text = "" Then
            Else
                MessageBox.Show("Error! Missing Input")
                Return
            End If

            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim section1table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section1table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input1.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section2table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section2table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input2.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section3table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section3table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input3.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
                    End Using

                    Dim section4table As String = "INSERT INTO sectiontable(section, sectioncourse)" &
                                             "VALUES(@section, @course)"
                    Using student1 As New MySqlCommand(section4table, conn, transaction)
                        student1.Parameters.AddWithValue("@section", input4.Text)
                        student1.Parameters.AddWithValue("@course", coursebox.Text)
                        student1.ExecuteNonQuery()
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
        Else
            Return
        End If
    End Sub

    Private Sub clrall()
        input1.Clear()
        input2.Clear()
        input3.Clear()
        input4.Clear()
    End Sub
End Class