Public Class adminfrm
    Public adminid As String
    Private Sub mstudent_Click(sender As Object, e As EventArgs) Handles mstudent.Click
        Adminmstudent.adminid = adminid

        Adminmstudent.Show()
        Adminmstudent.mstudent.PerformClick()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click

        Me.Close()

    End Sub

    Private Sub msubject_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub muser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub macayear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub atrail_Click(sender As Object, e As EventArgs) Handles atrail.Click

    End Sub

    Private Sub mcourse_Click(sender As Object, e As EventArgs) Handles mcourse.Click
        adminmcourse.adminid = adminid
        adminmcourse.Show()
        Me.Hide()

    End Sub

    Private Sub adminfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub me_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub muser_Click_1(sender As Object, e As EventArgs) Handles muser.Click
        adminmuser.adminid = adminid
        adminmuser.Show()
        Me.Hide()
    End Sub

    Private Sub msubject_Click_1(sender As Object, e As EventArgs) Handles msubject.Click
        adminmsubject.adminid = adminid
        adminmsubject.Show()
        Me.Hide()
    End Sub

    Private Sub macayear_Click_1(sender As Object, e As EventArgs) Handles macayear.Click
        adminmay.adminid = adminid
        adminmay.Show()
        Me.Hide()
    End Sub
End Class