Public Class staff
    Public staffid As String
    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Me.Close()
    End Sub

    Private Sub staff_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
        Me.Hide()
    End Sub

    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        staffsrecord.staffid = staffid
        staffsrecord.Show()
        Me.Hide()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        changepassstaff.staffid = staffid
        changepassstaff.Show()
        Me.Hide()
    End Sub
End Class