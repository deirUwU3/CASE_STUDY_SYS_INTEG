Public Class changepassstaff
    Public staffid As String
    Public timenow As String
    Public key As String
    Private Sub changepasssttaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub returnbtn_Click(sender As Object, e As EventArgs) Handles returnbtn.Click
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
End Class