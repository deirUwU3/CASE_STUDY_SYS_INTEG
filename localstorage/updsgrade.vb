Imports MySql.Data.MySqlClient

Public Class updsgrade
    Public staffid As String
    Public nameget As String
    Public subget As String
    Public resultit As String
    Private controlprelim As String
    Private controlmidterm As String
    Private controlprefinal As String
    Private controlfinal As String
    Private cprelim As String
    Private cmidterm As String
    Private cprefinal As String
    Private cfinal As String
    Private Sub updsgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh()
        Lastname.Text = nameget
        oldgrade()
        If cprelim = "lock" Then
            prelim.Enabled = False
        Else
            prelim.Enabled = True
        End If
        If cmidterm = "lock" Then
            midterm.Enabled = False
        Else
            midterm.Enabled = True
        End If
        If cprefinal = "lock" Then
            prefinal.Enabled = False
        Else
            prefinal.Enabled = True
        End If
        If cfinal = "lock" Then
            final.Enabled = False
        Else
            final.Enabled = True
        End If
    End Sub
    Private Sub oldgrade()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                ' Open connection if it's closed
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If

                Dim query As String = "SELECT * FROM gradetable     
   inner join studenttable on gradetable.studentid = studenttable.studentid    
   WHERE studenttable.lastname = @lname"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@lname", nameget)

                    ' Execute the query and read the data
                    Using dr As MySqlDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            ' If a record is found, display the role and attempts
                            StudentID.Text = dr("studentid").ToString()
                            'Lastname.Text = dr("lastname").ToString()
                            prelim.Text = dr("prelim").ToString()
                            equprelim.Text = dr("Prelim grade").ToString()
                            cprelim = dr("cprelim").ToString()
                            midterm.Text = dr("midterm").ToString()
                            equmidterm.Text = dr("Midterm grade").ToString()
                            cmidterm = dr("cmidterm").ToString()
                            prefinal.Text = dr("Prefinal").ToString()
                            equprefinal.Text = dr("Prefinal grade").ToString()
                            cprefinal = dr("cPrefinal").ToString()
                            final.Text = dr("final").ToString()
                            equfinal.Text = dr("final grade").ToString()
                            cfinal = dr("cfinal").ToString()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching request status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Close connection if it's still open
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try

        End Using
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        staffgradefrm.Show()
        Me.Close()

    End Sub

    Private Sub updsgrade_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        staffgradefrm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles updbtn.Click
        If controlprelim = "Invalid" Or controlmidterm = "invalid" Or controlprefinal = "Invalid" Or controlfinal = "invalid" Then
            MsgBox("Invalid Input", vbCritical)
            Return
        End If

        ConfirmPassword.returnit = "1"
        ConfirmPassword.staffid = staffid
        ConfirmPassword.Show()
        If resultit = "return" Then
            Return
        End If
    End Sub

    Public Sub confirmdone()
        Using conn As MySqlConnection = Data.GetConnection()
            Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()
                '
                'Start a transaction
                transaction = conn.BeginTransaction()

                'Insert into studentTable
                Dim studenttable As String = "
                UPDATE gradetable 
                INNER JOIN studenttable ON gradetable.studentid = studenttable.studentid  
                INNER JOIN subjecttable ON gradetable.subjectcode = subjecttable.subjectcode    
                    SET 
                           prelim = @prelim, `Prelim grade` = @eprelim, cprelim = 'lock', 
                           midterm = @midterm, `Midterm grade` = @emidterm, cmidterm = 'lock', 
                           prefinal = @prefinal, `Prefinal grade` = @eprefinal, cprefinal = 'lock',
                           final = @final, `Final grade` = @efinal, cfinal = 'lock'  
                    WHERE 
                           studenttable.lastname = @lname 
                           AND subjecttable.subjectname = @profname"
                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@prelim", prelim.Text)
                    student1.Parameters.AddWithValue("@eprelim", equprelim.Text)
                    student1.Parameters.AddWithValue("@midterm", midterm.Text)
                    student1.Parameters.AddWithValue("@emidterm", equmidterm.Text)
                    student1.Parameters.AddWithValue("@prefinal", prefinal.Text)
                    student1.Parameters.AddWithValue("@eprefinal", equprefinal.Text)
                    student1.Parameters.AddWithValue("@final", final.Text)
                    student1.Parameters.AddWithValue("@efinal", equfinal.Text)
                    student1.Parameters.AddWithValue("@lname", nameget)
                    student1.Parameters.AddWithValue("@profname", subget)
                    student1.ExecuteNonQuery()
                End Using

                transaction.Commit()

                MessageBox.Show("Request Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                staffgradefrm.dataingrid()
                staffgradefrm.staffid = staffid
                staffgradefrm.Show()
                Me.Close()
            Catch ex As Exception
                'Rollback the transaction if any error occurs
                If transaction IsNot Nothing Then
                    Try
                        transaction.Rollback()
                    Catch rollbackEx As Exception
                        MessageBox.Show("Error rolling back transaction: " & rollbackEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                MessageBox.Show("Error submitting request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                'Ensure the connection Is closed
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

        End Using
    End Sub

    Private Sub prelim_TextChanged(sender As Object, e As EventArgs) Handles prelim.TextChanged
        Dim x As String = prelim.Text
        Dim y As String
        Dim numericGrade As Integer
        controlprelim = "ok"

        If Integer.TryParse(x, numericGrade) Then
            Select Case numericGrade
                Case 99 To 100
                    y = "1.0"
                Case 96 To 98
                    y = "1.25"
                Case 93 To 95
                    y = "1.50"
                Case 90 To 92
                    y = "1.75"
                Case 87 To 89
                    y = "2.00"
                Case 84 To 86
                    y = "2.25"
                Case 81 To 83
                    y = "2.50"
                Case 78 To 80
                    y = "2.75"
                Case 75 To 77
                    y = "3.00"
                Case Is <= 74
                    y = "5.00"
                Case Else
                    y = "Invalid Input"
                    controlprelim = "Invalid"
            End Select
        Else
            Select Case x.ToUpper()
                Case ""
                    y = ""
                Case Else
                    y = "Invalid Input"
                    controlprelim = "Invalid"
            End Select
        End If
        equprelim.Text = y
    End Sub

    Private Sub midterm_TextChanged(sender As Object, e As EventArgs) Handles midterm.TextChanged
        Dim x As String = midterm.Text
        Dim y As String
        Dim numericGrade As Integer
        controlmidterm = "ok"

        If Integer.TryParse(x, numericGrade) Then
            Select Case numericGrade
                Case 99 To 100
                    y = "1.0"
                Case 96 To 98
                    y = "1.25"
                Case 93 To 95
                    y = "1.50"
                Case 90 To 92
                    y = "1.75"
                Case 87 To 89
                    y = "2.00"
                Case 84 To 86
                    y = "2.25"
                Case 81 To 83
                    y = "2.50"
                Case 78 To 80
                    y = "2.75"
                Case 75 To 77
                    y = "3.00"
                Case Is <= 74
                    y = "5.00"
                Case Else
                    y = "Invalid Input"
                    controlmidterm = "Invalid"
            End Select
        Else
            Select Case x.ToUpper()
                Case "DRP"
                    y = "Dropped"
                Case "UOD"
                    y = "Unofficially Dropped"
                Case ""
                    y = ""
                Case Else
                    y = "Invalid Input"
                    controlmidterm = "Invalid"
            End Select
        End If
        equmidterm.Text = y

    End Sub

    Private Sub final_TextChanged(sender As Object, e As EventArgs) Handles final.TextChanged
        Dim x As String = final.Text
        Dim y As String
        Dim numericGrade As Integer
        controlfinal = "ok"

        If Integer.TryParse(x, numericGrade) Then
            Select Case numericGrade
                Case 99 To 100
                    y = "1.0"
                Case 96 To 98
                    y = "1.25"
                Case 93 To 95
                    y = "1.50"
                Case 90 To 92
                    y = "1.75"
                Case 87 To 89
                    y = "2.00"
                Case 84 To 86
                    y = "2.25"
                Case 81 To 83
                    y = "2.50"
                Case 78 To 80
                    y = "2.75"
                Case 75 To 77
                    y = "3.00"
                Case Is <= 74
                    y = "5.00"
                Case Else
                    y = "Invalid Input"
                    controlfinal = "Invalid"
            End Select
        Else
            Select Case x.ToUpper()
                Case "INC"
                    y = "Incomplete"
                Case "NFE"
                    y = "No Final Exam"
                Case ""
                    y = ""
                Case Else
                    y = "Invalid Input"
                    controlfinal = "Invalid"
            End Select
        End If
        equfinal.Text = y
    End Sub

    Private Sub prefinal_TextChanged(sender As Object, e As EventArgs) Handles prefinal.TextChanged
        Dim x As String = prefinal.Text
        Dim y As String
        Dim numericGrade As Integer
        controlprefinal = "ok"

        If Integer.TryParse(x, numericGrade) Then
            Select Case numericGrade
                Case 99 To 100
                    y = "1.0"
                Case 96 To 98
                    y = "1.25"
                Case 93 To 95
                    y = "1.50"
                Case 90 To 92
                    y = "1.75"
                Case 87 To 89
                    y = "2.00"
                Case 84 To 86
                    y = "2.25"
                Case 81 To 83
                    y = "2.50"
                Case 78 To 80
                    y = "2.75"
                Case 75 To 77
                    y = "3.00"
                Case Is <= 74
                    y = "5.00"
                Case Else
                    y = "Invalid Input"
                    controlprefinal = "Invalid"
            End Select
        Else
            Select Case x.ToUpper()
                Case "DRP"
                    y = "Dropped"
                Case "UOD"
                    y = "Unofficially Dropped"
                Case ""
                    y = ""
                Case Else
                    y = "Invalid Input"
                    controlprefinal = "Invalid"
            End Select
        End If
        equprefinal.Text = y
    End Sub
End Class