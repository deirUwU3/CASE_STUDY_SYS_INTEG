<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LocalLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocalLogin))
        Me.tpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L1 = New System.Windows.Forms.Label()
        Me.tusername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.b1 = New Guna.UI2.WinForms.Guna2Button()
        Me.b2 = New Guna.UI2.WinForms.Guna2Button()
        Me.cb1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.Attempts = New System.Windows.Forms.Label()
        Me.lblattempts = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tpassword
        '
        Me.tpassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tpassword.DefaultText = ""
        Me.tpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpassword.ForeColor = System.Drawing.Color.Black
        Me.tpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tpassword.Location = New System.Drawing.Point(204, 233)
        Me.tpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpassword.Name = "tpassword"
        Me.tpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tpassword.PlaceholderText = ""
        Me.tpassword.SelectedText = ""
        Me.tpassword.Size = New System.Drawing.Size(405, 37)
        Me.tpassword.TabIndex = 0
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.Color.FloralWhite
        Me.L1.Location = New System.Drawing.Point(37, 136)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(158, 36)
        Me.L1.TabIndex = 1
        Me.L1.Text = "Username:"
        '
        'tusername
        '
        Me.tusername.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tusername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tusername.DefaultText = ""
        Me.tusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tusername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tusername.ForeColor = System.Drawing.Color.Black
        Me.tusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tusername.Location = New System.Drawing.Point(204, 136)
        Me.tusername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tusername.Name = "tusername"
        Me.tusername.PlaceholderText = ""
        Me.tusername.SelectedText = ""
        Me.tusername.Size = New System.Drawing.Size(405, 37)
        Me.tusername.TabIndex = 0
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Gainsboro
        Me.l2.Location = New System.Drawing.Point(40, 233)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(155, 36)
        Me.l2.TabIndex = 1
        Me.l2.Text = "Password:"
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.White
        Me.b1.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.b1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.b1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.b1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.b1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.b1.FillColor = System.Drawing.Color.White
        Me.b1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.Color.Black
        Me.b1.Location = New System.Drawing.Point(429, 340)
        Me.b1.Name = "b1"
        Me.b1.PressedColor = System.Drawing.Color.RosyBrown
        Me.b1.Size = New System.Drawing.Size(180, 45)
        Me.b1.TabIndex = 2
        Me.b1.Text = "Login"
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.White
        Me.b2.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.b2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.b2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.b2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.b2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.b2.FillColor = System.Drawing.Color.White
        Me.b2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.Color.Black
        Me.b2.Location = New System.Drawing.Point(429, 414)
        Me.b2.Name = "b2"
        Me.b2.PressedColor = System.Drawing.Color.RosyBrown
        Me.b2.Size = New System.Drawing.Size(180, 45)
        Me.b2.TabIndex = 2
        Me.b2.Text = "Clear"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb1.CheckedState.BorderRadius = 0
        Me.cb1.CheckedState.BorderThickness = 0
        Me.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb1.Location = New System.Drawing.Point(484, 277)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(125, 20)
        Me.cb1.TabIndex = 3
        Me.cb1.Text = "Show Password"
        Me.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb1.UncheckedState.BorderRadius = 0
        Me.cb1.UncheckedState.BorderThickness = 0
        Me.cb1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrole.ForeColor = System.Drawing.Color.Red
        Me.lblrole.Location = New System.Drawing.Point(41, 369)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(45, 50)
        Me.lblrole.TabIndex = 4
        Me.lblrole.Text = "Lab" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "el1"
        '
        'Attempts
        '
        Me.Attempts.AutoSize = True
        Me.Attempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Attempts.Location = New System.Drawing.Point(41, 313)
        Me.Attempts.Name = "Attempts"
        Me.Attempts.Size = New System.Drawing.Size(95, 25)
        Me.Attempts.TabIndex = 5
        Me.Attempts.Tag = "Attempts"
        Me.Attempts.Text = "Attempts:"
        '
        'lblattempts
        '
        Me.lblattempts.AutoSize = True
        Me.lblattempts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblattempts.Location = New System.Drawing.Point(155, 313)
        Me.lblattempts.Name = "lblattempts"
        Me.lblattempts.Size = New System.Drawing.Size(71, 25)
        Me.lblattempts.TabIndex = 6
        Me.lblattempts.Text = "Label1"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(100, 94)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 7
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(379, 46)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lyceum of Alabang"
        '
        'LocalLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(645, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.lblattempts)
        Me.Controls.Add(Me.Attempts)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.L1)
        Me.Controls.Add(Me.tpassword)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.tusername)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "LocalLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Local Log In"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L1 As Label
    Friend WithEvents tusername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents b1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents b2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cb1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents lblrole As Label
    Friend WithEvents Attempts As Label
    Friend WithEvents lblattempts As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
End Class
