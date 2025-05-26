<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class termfrm
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
        Me.courseupd = New Guna.UI2.WinForms.Guna2Button()
        Me.returnbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.chsterm = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'courseupd
        '
        Me.courseupd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.courseupd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.courseupd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.courseupd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.courseupd.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseupd.ForeColor = System.Drawing.Color.White
        Me.courseupd.Location = New System.Drawing.Point(40, 198)
        Me.courseupd.Name = "courseupd"
        Me.courseupd.Size = New System.Drawing.Size(183, 50)
        Me.courseupd.TabIndex = 0
        Me.courseupd.Text = "Apply"
        '
        'returnbtn
        '
        Me.returnbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.returnbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.returnbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.returnbtn.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.returnbtn.ForeColor = System.Drawing.Color.White
        Me.returnbtn.Location = New System.Drawing.Point(322, 198)
        Me.returnbtn.Name = "returnbtn"
        Me.returnbtn.Size = New System.Drawing.Size(183, 50)
        Me.returnbtn.TabIndex = 1
        Me.returnbtn.Text = "Return"
        '
        'chsterm
        '
        Me.chsterm.BackColor = System.Drawing.Color.Transparent
        Me.chsterm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.chsterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.chsterm.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chsterm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chsterm.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.chsterm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.chsterm.ItemHeight = 30
        Me.chsterm.Location = New System.Drawing.Point(156, 130)
        Me.chsterm.Name = "chsterm"
        Me.chsterm.Size = New System.Drawing.Size(239, 36)
        Me.chsterm.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(220, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 32)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Terms"
        '
        'termfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 290)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chsterm)
        Me.Controls.Add(Me.returnbtn)
        Me.Controls.Add(Me.courseupd)
        Me.Name = "termfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "termfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents courseupd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents returnbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents chsterm As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
End Class
