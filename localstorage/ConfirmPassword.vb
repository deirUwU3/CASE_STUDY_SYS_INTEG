Imports MySql.Data.MySqlClient

Public Class ConfirmPassword
    Public staffid As String
    Public passhold As String
    Public returnit As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passwordget()
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles enterbtn.Click
        If inppass.Text = passhold Then
            updsgrade.resultit = "pass"
            updsgrade.confirmdone()
            staffgradefrm.staffid = staffid
            staffgradefrm.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Pass")
            updsgrade.staffid = "false"
            updsgrade.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles retunbtn.Click

        If returnit = "1" Then
            updsgrade.staffid = staffid
            updsgrade.staffid = "false"
            updsgrade.refresh()
            updsgrade.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            inppass.PasswordChar = ControlChars.NullChar
        Else
            inppass.PasswordChar = "*"
        End If
    End Sub

    Private Sub inppass_TextChanged(sender As Object, e As EventArgs) Handles inppass.TextChanged

    End Sub
End Class