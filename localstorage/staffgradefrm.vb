Imports Guna.UI2.WinForms.Helpers.GraphicsHelper
Imports MySql.Data.MySqlClient
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class staffgradefrm
    Public staffid As String
    Public subcode As String
    Public secget As String
    Private Sub staffgradefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh()
        Label7.Text = subcode
        subjectnameget()
        Label9.Text = secget
        dataingrid()
    End Sub
    Private Sub subjectnameget()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                ' First query: Get login details
                Dim query As String = "SELECT * FROM subjecttable WHERE subjectcode = @scd"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@scd", subcode)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Read()
                            Label8.Text = reader("Subjectname").ToString()
                        End If
                    End Using ' Reader 1 is closed here
                End Using

            Catch ex As Exception
                MessageBox.Show("Error retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Using
    End Sub

    Public Sub dataingrid()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "
            SELECT 
                studenttable.lastname,
                studenttable.firstname,
                subjecttable.subjectname,
                facultytable.lastname as 'Professor', 
                gradetable.prelim,
                gradetable.midterm,
                gradetable.prefinal,
                gradetable.final

            FROM 
                gradetable
            INNER JOIN studenttable ON gradetable.studentid = studenttable.studentid   
            INNER JOIN subjecttable ON gradetable.subjectcode = subjecttable.subjectcode
INNER JOIN facultytable ON facultytable.facultyid = subjecttable.facultyid 
WHERE subjecttable.facultyid = @id and subjecttable.subjectcode = @scd and studenttable.section = @sec
        "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", staffid)
                    cmd.Parameters.AddWithValue("@scd", subcode)
                    cmd.Parameters.AddWithValue("@sec", secget)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(Dataview)
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Error fetching request status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

            If Dataview.Rows.Count > 0 Then
                datav.DataSource = Dataview
            Else
                MessageBox.Show("No Student found for the current data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub



    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        Me.Close()
    End Sub
    Private Sub staff_closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
    End Sub



    Private Sub updbtn_Click(sender As Object, e As EventArgs) Handles updbtn.Click
        If datav.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = datav.SelectedRows(0)
            ' Using conn As MySqlConnection = Data.GetConnection()
            'If conn.State = ConnectionState.Open Then conn.Close()
            ' End Using
            updsgrade.staffid = staffid
            updsgrade.nameget = selectedRow.Cells(0).Value.ToString()
            updsgrade.subget = selectedRow.Cells(2).Value.ToString()
            updsgrade.refresh()
            updsgrade.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        staffsrecord.staffid = staffid
        staffsrecord.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles dashboardbn.Click
        staff.staffid = staffid
        staff.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        staffsrecord.Show()
        Me.Hide()
    End Sub
End Class