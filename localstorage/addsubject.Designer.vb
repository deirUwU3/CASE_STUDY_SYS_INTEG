<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsubject
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addsubject))
        Me.subjectadd = New Guna.UI2.WinForms.Guna2Button()
        Me.returnbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.inputsubject = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputUnit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.clname = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cdepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.exfname = New System.Windows.Forms.Label()
        Me.departname = New System.Windows.Forms.Label()
        Me.scode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subjectadd
        '
        Me.subjectadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.subjectadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.subjectadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.subjectadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.subjectadd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectadd.ForeColor = System.Drawing.Color.White
        Me.subjectadd.Location = New System.Drawing.Point(213, 476)
        Me.subjectadd.Name = "subjectadd"
        Me.subjectadd.Size = New System.Drawing.Size(183, 50)
        Me.subjectadd.TabIndex = 0
        Me.subjectadd.Text = "Add course"
        '
        'returnbtn
        '
        Me.returnbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.returnbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.returnbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnbtn.ForeColor = System.Drawing.Color.White
        Me.returnbtn.Location = New System.Drawing.Point(457, 476)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(183, 50)
        Me.returnbtn.TabIndex = 1
        Me.returnbtn.Text = "Return"
        '
        'inputsubject
        '
        Me.inputsubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputsubject.DefaultText = ""
        Me.inputsubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.inputsubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.inputsubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputsubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputsubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputsubject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inputsubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputsubject.Location = New System.Drawing.Point(213, 139)
        Me.inputsubject.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inputsubject.Name = "inputsubject"
        Me.inputsubject.PlaceholderText = ""
        Me.inputsubject.SelectedText = ""
        Me.inputsubject.Size = New System.Drawing.Size(427, 36)
        Me.inputsubject.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subject"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 217)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = " Professor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'inputUnit
        '
        Me.inputUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inputUnit.DefaultText = ""
        Me.inputUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.inputUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.inputUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inputUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputUnit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inputUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inputUnit.Location = New System.Drawing.Point(213, 270)
        Me.inputUnit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inputUnit.Name = "inputUnit"
        Me.inputUnit.PlaceholderText = ""
        Me.inputUnit.SelectedText = ""
        Me.inputUnit.Size = New System.Drawing.Size(427, 36)
        Me.inputUnit.TabIndex = 5
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(33, 21)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(97, 87)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 22
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(205, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(349, 45)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Lyceum of Alabang"
        '
        'clname
        '
        Me.clname.BackColor = System.Drawing.Color.Transparent
        Me.clname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.clname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clname.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clname.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.clname.ItemHeight = 30
        Me.clname.Location = New System.Drawing.Point(213, 201)
        Me.clname.Name = "clname"
        Me.clname.Size = New System.Drawing.Size(150, 36)
        Me.clname.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(57, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Department"
        '
        'cdepartment
        '
        Me.cdepartment.BackColor = System.Drawing.Color.Transparent
        Me.cdepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cdepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cdepartment.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cdepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cdepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cdepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cdepartment.ItemHeight = 30
        Me.cdepartment.Location = New System.Drawing.Point(213, 335)
        Me.cdepartment.Name = "cdepartment"
        Me.cdepartment.Size = New System.Drawing.Size(150, 36)
        Me.cdepartment.TabIndex = 28
        '
        'exfname
        '
        Me.exfname.AutoSize = True
        Me.exfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exfname.ForeColor = System.Drawing.Color.White
        Me.exfname.Location = New System.Drawing.Point(382, 217)
        Me.exfname.Name = "exfname"
        Me.exfname.Size = New System.Drawing.Size(65, 20)
        Me.exfname.TabIndex = 30
        Me.exfname.Text = "Label5"
        '
        'departname
        '
        Me.departname.AutoSize = True
        Me.departname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departname.ForeColor = System.Drawing.Color.White
        Me.departname.Location = New System.Drawing.Point(393, 351)
        Me.departname.Name = "departname"
        Me.departname.Size = New System.Drawing.Size(65, 20)
        Me.departname.TabIndex = 31
        Me.departname.Text = "Label6"
        '
        'scode
        '
        Me.scode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.scode.DefaultText = ""
        Me.scode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.scode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.scode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.scode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.scode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.scode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.scode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.scode.Location = New System.Drawing.Point(213, 393)
        Me.scode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.scode.Name = "scode"
        Me.scode.PlaceholderText = ""
        Me.scode.SelectedText = ""
        Me.scode.Size = New System.Drawing.Size(150, 41)
        Me.scode.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(57, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "SubjectCode"
        '
        'addsubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(730, 538)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.scode)
        Me.Controls.Add(Me.departname)
        Me.Controls.Add(Me.exfname)
        Me.Controls.Add(Me.cdepartment)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.clname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.inputUnit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputsubject)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.subjectadd)
        Me.Name = "addsubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addcourse"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subjectadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents returnbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents inputsubject As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputUnit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents clname As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cdepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents exfname As Label
    Friend WithEvents departname As Label
    Friend WithEvents scode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
