Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class staffsrecord
    Public staffid As String
    Private Sub staffsrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Private Sub refresh()
        seclist.Items.Clear()
        seclist.Enabled = False
        gradebtn.Enabled = False
        subjectlist()
        datav.DataSource = Nothing
    End Sub

    Public Sub subjectlist()
        Using conn As MySqlConnection = Data.GetConnection()
            sublist.Items.Clear()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT subjectcode FROM subjecttable where facultyid =@fid "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", staffid)
                cmd.ExecuteNonQuery()
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        sublist.Items.Add(reader("subjectcode").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub dataoftable()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "
            SELECT 
                studenttable.lastname,
                studenttable.firstname,
                subjecttable.subjectname,
                facultytable.lastname as 'Professor'
            FROM  
                gradetable 
            INNER JOIN studenttable ON gradetable.studentid = studenttable.studentid   
            INNER JOIN subjecttable ON gradetable.subjectcode = subjecttable.subjectcode
INNER JOIN facultytable ON facultytable.facultyid = subjecttable.facultyid 
WHERE subjecttable.facultyid = @id and gradetable.subjectcode =@sub
        "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", staffid)
                    cmd.Parameters.AddWithValue("@sub", sublist.Text)
                    cmd.ExecuteNonQuery()
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

    Public Sub dataoftable1()
        Dim Dataview As New DataTable()
        Using conn As MySqlConnection = Data.GetConnection()
            Try
                If conn.State = ConnectionState.Closed Then conn.Open()

                Dim query As String = "
            SELECT 
                studenttable.lastname,
                studenttable.firstname,
                
                subjecttable.subjectname,
                facultytable.lastname as 'Professor'

            FROM 
                gradetable
            INNER JOIN studenttable ON gradetable.studentid = studenttable.studentid   
            INNER JOIN subjecttable ON gradetable.subjectcode = subjecttable.subjectcode
INNER JOIN facultytable ON facultytable.facultyid = subjecttable.facultyid 
WHERE subjecttable.facultyid = @id and gradetable.subjectcode =@sub and studenttable.section = @sec 
        "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", staffid)
                    cmd.Parameters.AddWithValue("@sub", sublist.Text)
                    cmd.Parameters.AddWithValue("@sec", seclist.Text)
                    cmd.ExecuteNonQuery()
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

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click

    End Sub

    Private Sub sublist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sublist.SelectedIndexChanged
        seclist.Enabled = "true"
        dataoftable()
        sectionlist()
    End Sub
    Private Sub staffsrecord_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        LocalLogin.Show()
    End Sub

    Private Sub seclist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles seclist.SelectedIndexChanged
        dataoftable1()
        If seclist.Text IsNot "" Then
            gradebtn.Enabled = True
        End If
    End Sub
    Public Sub sectionlist()
        Using conn As MySqlConnection = Data.GetConnection()
            If conn.State = ConnectionState.Closed Then conn.Open()
            Dim query As String = "SELECT studenttable.section from gradetable 
            INNER JOIN studenttable ON gradetable.studentid = studenttable.studentid    
            INNER JOIN subjecttable ON gradetable.subjectcode = subjecttable.subjectcode 
INNER JOIN facultytable ON facultytable.facultyid = subjecttable.facultyid  
WHERE subjecttable.facultyid = @fid and gradetable.subjectcode =@subcode 
        "
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@fid", staffid)
                cmd.Parameters.AddWithValue("@subcode", sublist.Text)
                cmd.ExecuteNonQuery()
                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim sectionValue As String = reader("section").ToString()
                        ' Add only if it's not already in the list
                        If Not seclist.Items.Contains(sectionValue) Then
                            seclist.Items.Add(sectionValue)
                        End If
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub dashboardbn_Click(sender As Object, e As EventArgs) Handles dashboardbn.Click
        staff.staffid = staffid
        staff.Show()
        Me.Hide()
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        changepassstaff.staffid = staffid
        changepassstaff.Show()
        Me.Hide()
    End Sub

    Private Sub gradebtn_Click(sender As Object, e As EventArgs) Handles gradebtn.Click
        staffgradefrm.secget = seclist.Text
        staffgradefrm.subcode = sublist.Text
        staffgradefrm.staffid = staffid
        staffgradefrm.refresh()
        staffgradefrm.Show()
        refresh()
        Me.Hide()
    End Sub
End Class