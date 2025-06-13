<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConfirmPassword
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
        Me.inppass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.enterbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.retunbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.SuspendLayout()
        '
        'inppass
        '
        Me.inppass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.inppass.DefaultText = ""
        Me.inppass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.inppass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.inppass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inppass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.inppass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inppass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.inppass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.inppass.Location = New System.Drawing.Point(25, 75)
        Me.inppass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inppass.Name = "inppass"
        Me.inppass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.inppass.PlaceholderText = ""
        Me.inppass.SelectedText = ""
        Me.inppass.Size = New System.Drawing.Size(430, 48)
        Me.inppass.TabIndex = 0
        '
        'enterbtn
        '
        Me.enterbtn.BackColor = System.Drawing.Color.White
        Me.enterbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.enterbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.enterbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.enterbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.enterbtn.FillColor = System.Drawing.Color.White
        Me.enterbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.enterbtn.ForeColor = System.Drawing.Color.Black
        Me.enterbtn.Location = New System.Drawing.Point(12, 181)
        Me.enterbtn.Name = "enterbtn"
        Me.enterbtn.Size = New System.Drawing.Size(180, 45)
        Me.enterbtn.TabIndex = 1
        Me.enterbtn.Text = "Enter"
        '
        'retunbtn
        '
        Me.retunbtn.BackColor = System.Drawing.Color.White
        Me.retunbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.retunbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.retunbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.retunbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.retunbtn.FillColor = System.Drawing.Color.White
        Me.retunbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.retunbtn.ForeColor = System.Drawing.Color.Black
        Me.retunbtn.Location = New System.Drawing.Point(275, 181)
        Me.retunbtn.Name = "retunbtn"
        Me.retunbtn.Size = New System.Drawing.Size(180, 45)
        Me.retunbtn.TabIndex = 2
        Me.retunbtn.Text = "Return"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input Password"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb1.CheckedState.BorderRadius = 0
        Me.cb1.CheckedState.BorderThickness = 0
        Me.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cb1.Location = New System.Drawing.Point(307, 126)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(136, 20)
        Me.cb1.TabIndex = 5
        Me.cb1.Text = "Guna2CheckBox1"
        Me.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb1.UncheckedState.BorderRadius = 0
        Me.cb1.UncheckedState.BorderThickness = 0
        Me.cb1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'ConfirmPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(467, 238)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.retunbtn)
        Me.Controls.Add(Me.enterbtn)
        Me.Controls.Add(Me.inppass)
        Me.Name = "ConfirmPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inppass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents enterbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents retunbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cb1 As Guna.UI2.WinForms.Guna2CheckBox
End Class
