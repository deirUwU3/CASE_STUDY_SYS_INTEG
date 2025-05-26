<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addsubstudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addsubstudent))
        Me.subjectadd = New Guna.UI2.WinForms.Guna2Button()
        Me.returnbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.subbox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.studcbox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.slname = New System.Windows.Forms.Label()
        Me.flname = New System.Windows.Forms.Label()
        Me.ffname = New System.Windows.Forms.Label()
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
        Me.subjectadd.Location = New System.Drawing.Point(132, 476)
        Me.subjectadd.Name = "subjectadd"
        Me.subjectadd.Size = New System.Drawing.Size(183, 50)
        Me.subjectadd.TabIndex = 0
        Me.subjectadd.Text = "Add Subject"
        '
        'returnbtn
        '
        Me.returnbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.returnbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.returnbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnbtn.ForeColor = System.Drawing.Color.White
        Me.returnbtn.Location = New System.Drawing.Point(386, 476)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(183, 50)
        Me.returnbtn.TabIndex = 1
        Me.returnbtn.Text = "Return"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 302)
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
        Me.Label2.Location = New System.Drawing.Point(74, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = " Professor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'subbox
        '
        Me.subbox.BackColor = System.Drawing.Color.Transparent
        Me.subbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.subbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subbox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.subbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.subbox.ItemHeight = 30
        Me.subbox.Location = New System.Drawing.Point(203, 286)
        Me.subbox.Name = "subbox"
        Me.subbox.Size = New System.Drawing.Size(442, 36)
        Me.subbox.TabIndex = 26
        '
        'studcbox
        '
        Me.studcbox.BackColor = System.Drawing.Color.Transparent
        Me.studcbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.studcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.studcbox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studcbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studcbox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.studcbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.studcbox.ItemHeight = 30
        Me.studcbox.Location = New System.Drawing.Point(203, 209)
        Me.studcbox.Name = "studcbox"
        Me.studcbox.Size = New System.Drawing.Size(149, 36)
        Me.studcbox.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(77, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Student Id"
        '
        'slname
        '
        Me.slname.AutoSize = True
        Me.slname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slname.ForeColor = System.Drawing.Color.White
        Me.slname.Location = New System.Drawing.Point(370, 225)
        Me.slname.Name = "slname"
        Me.slname.Size = New System.Drawing.Size(65, 20)
        Me.slname.TabIndex = 32
        Me.slname.Text = "Label4"
        '
        'flname
        '
        Me.flname.AutoSize = True
        Me.flname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flname.ForeColor = System.Drawing.Color.White
        Me.flname.Location = New System.Drawing.Point(199, 359)
        Me.flname.Name = "flname"
        Me.flname.Size = New System.Drawing.Size(65, 20)
        Me.flname.TabIndex = 33
        Me.flname.Text = "Label5"
        '
        'ffname
        '
        Me.ffname.AutoSize = True
        Me.ffname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ffname.ForeColor = System.Drawing.Color.White
        Me.ffname.Location = New System.Drawing.Point(326, 359)
        Me.ffname.Name = "ffname"
        Me.ffname.Size = New System.Drawing.Size(65, 20)
        Me.ffname.TabIndex = 34
        Me.ffname.Text = "Label6"
        '
        'addsubstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(670, 538)
        Me.Controls.Add(Me.ffname)
        Me.Controls.Add(Me.flname)
        Me.Controls.Add(Me.slname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.studcbox)
        Me.Controls.Add(Me.subbox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.subjectadd)
        Me.Name = "addsubstudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addsubstudent"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents subjectadd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents returnbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents subbox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents studcbox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents slname As Label
    Friend WithEvents flname As Label
    Friend WithEvents ffname As Label
End Class
