Imports MySql.Data.MySqlClient

Public Class changepassstaff
    Public staffid As String
    Public timenow As String
    Public key As String
    Public passhold As String
    Private Sub changepasssttaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordget()
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        returntopage()
    End Sub

    Private Sub returntopage()
        If key = "1" Then
            staff.staffid = staffid
            staff.Show()
            Me.Hide()
        ElseIf key = "2" Then
            staffgradefrm.staffid = staffid
            staffgradefrm.Show()
            Me.Hide()
        ElseIf key = "3" Then
            staffsrecord.staffid = staffid
            staffsrecord.Show()
            Me.Hide()
        ElseIf key = "4" Then
            regis.staffid = staffid
            regis.Show()
            Me.Hide()
        ElseIf key = "5" Then
            regisstudent.staffid = staffid
            regisstudent.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            pass.PasswordChar = ControlChars.NullChar
            pass2.PasswordChar = ControlChars.NullChar
            pass3.PasswordChar = ControlChars.NullChar
        Else
            pass.PasswordChar = "*"
            pass2.PasswordChar = "*"
            pass3.PasswordChar = "*"
        End If
    End Sub

    Private Sub courseupd_Click(sender As Object, e As EventArgs) Handles courseupd.Click

        If pass.Text = "" Or pass2.Text = "" Or pass3.Text = "" Then
            MsgBox("Missing Input try again", vbCritical)
            Return
        End If
        If pass2.Text = pass3.Text Then
        Else
            MsgBox("Password Mismatch!!", vbCritical)
            Return
        End If
        If pass.Text = passhold Then
            MsgBox("Incorrect Password", vbCritical)
            Return
        End If

        If MsgBox("Are you sure you want to update your password?", vbYesNo + vbQuestion, "Confirmation") = vbNo Then
            Return
        End If

        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                ' Start a transaction
                transaction = conn.BeginTransaction()

                ' Insert into studentTable
                Dim studenttable As String = "Update facultylogin set  Password=@npass WHERE facultyId = @id"

                Using student1 As New MySqlCommand(studenttable, conn, transaction)
                    student1.Parameters.AddWithValue("@npass", pass2.Text)
                    student1.Parameters.AddWithValue("@id", staffid)
                    student1.ExecuteNonQuery()
                End Using

                transaction.Commit()
                MessageBox.Show("Request Updated successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                clrall()
                returntopage()

            Catch ex As Exception
                MessageBox.Show("Error loading student data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try


        End Using


    End Sub

    Private Sub passwordget()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' First query: Get login details
                Dim query As String = "SELECT Password FROM facultylogin WHERE facultyid = @sid"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@sid", staffid)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            passhold = reader("Password").ToString()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

        End Using
    End Sub

    Private Sub clrall()
        pass.Clear()
        pass2.Clear()
        pass3.Clear()
    End Sub
End Class