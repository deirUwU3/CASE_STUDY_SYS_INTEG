Imports MySql.Data.MySqlClient

Public Class termfrm
    Public adminid As String
    Private Sub courseupd_Click(sender As Object, e As EventArgs) Handles courseupd.Click

        ConfirmPassword.staffid = adminid
        ConfirmPassword.returnit = "2"
        ConfirmPassword.Show()

    End Sub
    Public Sub changeallterm()
        If chsterm.Text = "Prelim" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim studenttable As String = "Update gradetable set  cprelim='unlock', cmidterm='lock', cprefinal='lock', cfinal = 'lock' "
                    Using student1 As New MySqlCommand(studenttable, conn, transaction)
                        student1.ExecuteNonQuery()
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
            End Using
        ElseIf chsterm.Text = "Midterm" Then
            Using conn As MySqlConnection = Data.GetConnection()


                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim studenttable As String = "Update gradetable set  cprelim='lock', cmidterm='unlock', cprefinal='lock', cfinal = 'lock' "
                    Using student1 As New MySqlCommand(studenttable, conn, transaction)
                        student1.ExecuteNonQuery()
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
            End Using
        ElseIf chsterm.Text = "Prefinal" Then
            Using conn As MySqlConnection = Data.GetConnection()
                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim studenttable As String = "Update gradetable set  cprelim='lock', cmidterm='lock', cprefinal='unlock', cfinal = 'lock' "
                    Using student1 As New MySqlCommand(studenttable, conn, transaction)
                        student1.ExecuteNonQuery()
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
            End Using
        ElseIf chsterm.Text = "Final" Then
            Using conn As MySqlConnection = Data.GetConnection()


                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim studenttable As String = "Update gradetable set  cprelim='lock', cmidterm='lock', cprefinal='lock', cfinal = 'unlock' "
                    Using student1 As New MySqlCommand(studenttable, conn, transaction)
                        student1.ExecuteNonQuery()
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
            End Using
        Else
            Using conn As MySqlConnection = Data.GetConnection()


                Dim transaction As MySqlTransaction = Nothing ' Declare transaction outside of Try block
                Try
                    If conn.State = ConnectionState.Closed Then conn.Open()

                    ' Start a transaction
                    transaction = conn.BeginTransaction()

                    ' Insert into studentTable
                    Dim studenttable As String = "Update gradetable set  cprelim='lock', cmidterm='lock', cprefinal='lock', cfinal = 'lock' "
                    Using student1 As New MySqlCommand(studenttable, conn, transaction)
                        student1.ExecuteNonQuery()
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
            End Using
        End If
        adminmay.Show()
        Me.Close()
    End Sub
    Private Sub termfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chsterm.Items.Clear()
        termin()
    End Sub

    Private Sub termin()
        chsterm.Items.Add("Prelim")
        chsterm.Items.Add("Midterm")
        chsterm.Items.Add("Prefinal")
        chsterm.Items.Add("Final")
        chsterm.Items.Add("Lock All")
        chsterm.Text = "Prelim"
    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
        Me.Close()
    End Sub

    Private Sub termfrm_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        adminmay.Show()
    End Sub
End Class