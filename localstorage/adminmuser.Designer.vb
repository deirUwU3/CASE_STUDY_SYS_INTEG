<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminmuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminmuser))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.atrail = New Guna.UI2.WinForms.Guna2Button()
        Me.logout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.dashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.macayear = New Guna.UI2.WinForms.Guna2Button()
        Me.mcourse = New Guna.UI2.WinForms.Guna2Button()
        Me.muser = New Guna.UI2.WinForms.Guna2Button()
        Me.mstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.msubject = New Guna.UI2.WinForms.Guna2Button()
        Me.datagridv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.updUser = New Guna.UI2.WinForms.Guna2Button()
        Me.adduser = New Guna.UI2.WinForms.Guna2Button()
        Me.Searchid = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.datagridv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'atrail
        '
        Me.atrail.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.atrail.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.atrail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.atrail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.atrail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.atrail.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.atrail.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atrail.ForeColor = System.Drawing.Color.Black
        Me.atrail.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.atrail.HoverState.ForeColor = System.Drawing.Color.White
        Me.atrail.Location = New System.Drawing.Point(2, 458)
        Me.atrail.Name = "atrail"
        Me.atrail.PressedColor = System.Drawing.Color.RosyBrown
        Me.atrail.Size = New System.Drawing.Size(167, 42)
        Me.atrail.TabIndex = 5
        Me.atrail.Text = "Audit Trail"
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.logout.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.logout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.Black
        Me.logout.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.logout.HoverState.ForeColor = System.Drawing.Color.White
        Me.logout.Location = New System.Drawing.Point(2, 520)
        Me.logout.Name = "logout"
        Me.logout.PressedColor = System.Drawing.Color.RosyBrown
        Me.logout.Size = New System.Drawing.Size(164, 34)
        Me.logout.TabIndex = 6
        Me.logout.Text = "Log Out"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Blue
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(40, 13)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(88, 81)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 7
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(324, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 45)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lyceum of Alabang"
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.dashboard)
        Me.Guna2Panel1.Controls.Add(Me.macayear)
        Me.Guna2Panel1.Controls.Add(Me.mcourse)
        Me.Guna2Panel1.Controls.Add(Me.muser)
        Me.Guna2Panel1.Controls.Add(Me.mstudent)
        Me.Guna2Panel1.Controls.Add(Me.msubject)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(-5, -1)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(174, 575)
        Me.Guna2Panel1.TabIndex = 9
        '
        'dashboard
        '
        Me.dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.dashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboard.ForeColor = System.Drawing.Color.Black
        Me.dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dashboard.HoverState.ForeColor = System.Drawing.Color.White
        Me.dashboard.Location = New System.Drawing.Point(0, 140)
        Me.dashboard.Name = "dashboard"
        Me.dashboard.PressedColor = System.Drawing.Color.RosyBrown
        Me.dashboard.Size = New System.Drawing.Size(174, 40)
        Me.dashboard.TabIndex = 13
        Me.dashboard.Text = "Dashboard"
        '
        'macayear
        '
        Me.macayear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.macayear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.macayear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.macayear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.macayear.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.macayear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.macayear.ForeColor = System.Drawing.Color.Black
        Me.macayear.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.macayear.HoverState.ForeColor = System.Drawing.Color.White
        Me.macayear.Location = New System.Drawing.Point(3, 408)
        Me.macayear.Name = "macayear"
        Me.macayear.Size = New System.Drawing.Size(168, 45)
        Me.macayear.TabIndex = 12
        Me.macayear.Text = "Manage Academic Year"
        '
        'mcourse
        '
        Me.mcourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.mcourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.mcourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.mcourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.mcourse.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mcourse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcourse.ForeColor = System.Drawing.Color.Black
        Me.mcourse.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mcourse.HoverState.ForeColor = System.Drawing.Color.White
        Me.mcourse.Location = New System.Drawing.Point(0, 232)
        Me.mcourse.Name = "mcourse"
        Me.mcourse.Size = New System.Drawing.Size(174, 45)
        Me.mcourse.TabIndex = 10
        Me.mcourse.Text = "Manage Course"
        '
        'muser
        '
        Me.muser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.muser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.muser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.muser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.muser.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.muser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.muser.ForeColor = System.Drawing.Color.Black
        Me.muser.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.muser.HoverState.ForeColor = System.Drawing.Color.White
        Me.muser.Location = New System.Drawing.Point(-6, 340)
        Me.muser.Name = "muser"
        Me.muser.Size = New System.Drawing.Size(180, 45)
        Me.muser.TabIndex = 11
        Me.muser.Text = "Manage User"
        '
        'mstudent
        '
        Me.mstudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.mstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.mstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.mstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.mstudent.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mstudent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstudent.ForeColor = System.Drawing.Color.Black
        Me.mstudent.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.mstudent.HoverState.ForeColor = System.Drawing.Color.White
        Me.mstudent.Location = New System.Drawing.Point(3, 186)
        Me.mstudent.Name = "mstudent"
        Me.mstudent.Size = New System.Drawing.Size(171, 45)
        Me.mstudent.TabIndex = 10
        Me.mstudent.Text = "Manage Student"
        '
        'msubject
        '
        Me.msubject.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.msubject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.msubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.msubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.msubject.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.msubject.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msubject.ForeColor = System.Drawing.Color.Black
        Me.msubject.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.msubject.HoverState.ForeColor = System.Drawing.Color.White
        Me.msubject.Location = New System.Drawing.Point(-6, 284)
        Me.msubject.Name = "msubject"
        Me.msubject.Size = New System.Drawing.Size(177, 45)
        Me.msubject.TabIndex = 10
        Me.msubject.Text = "Manage Subject"
        '
        'datagridv
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.datagridv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.datagridv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridv.ColumnHeadersHeight = 22
        Me.datagridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridv.DefaultCellStyle = DataGridViewCellStyle9
        Me.datagridv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridv.Location = New System.Drawing.Point(197, 211)
        Me.datagridv.Name = "datagridv"
        Me.datagridv.RowHeadersVisible = False
        Me.datagridv.RowHeadersWidth = 51
        Me.datagridv.RowTemplate.Height = 24
        Me.datagridv.Size = New System.Drawing.Size(632, 326)
        Me.datagridv.TabIndex = 10
        Me.datagridv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagridv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagridv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagridv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagridv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagridv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagridv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagridv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagridv.ThemeStyle.HeaderStyle.Height = 22
        Me.datagridv.ThemeStyle.ReadOnly = False
        Me.datagridv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagridv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagridv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagridv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagridv.ThemeStyle.RowsStyle.Height = 24
        Me.datagridv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagridv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(192, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Lastname"
        '
        'updUser
        '
        Me.updUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updUser.FillColor = System.Drawing.Color.White
        Me.updUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updUser.ForeColor = System.Drawing.Color.Black
        Me.updUser.Location = New System.Drawing.Point(666, 168)
        Me.updUser.Name = "updUser"
        Me.updUser.Size = New System.Drawing.Size(163, 37)
        Me.updUser.TabIndex = 14
        Me.updUser.Text = "Update User"
        '
        'adduser
        '
        Me.adduser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.adduser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.adduser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.adduser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.adduser.FillColor = System.Drawing.Color.White
        Me.adduser.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.adduser.ForeColor = System.Drawing.Color.Black
        Me.adduser.Location = New System.Drawing.Point(492, 167)
        Me.adduser.Name = "adduser"
        Me.adduser.Size = New System.Drawing.Size(168, 37)
        Me.adduser.TabIndex = 17
        Me.adduser.Text = "Add User"
        '
        'Searchid
        '
        Me.Searchid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Searchid.DefaultText = ""
        Me.Searchid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Searchid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Searchid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Searchid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Searchid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Searchid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Searchid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Searchid.Location = New System.Drawing.Point(294, 168)
        Me.Searchid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Searchid.Name = "Searchid"
        Me.Searchid.PlaceholderText = ""
        Me.Searchid.SelectedText = ""
        Me.Searchid.Size = New System.Drawing.Size(171, 36)
        Me.Searchid.TabIndex = 18
        '
        'adminmuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 569)
        Me.Controls.Add(Me.Searchid)
        Me.Controls.Add(Me.adduser)
        Me.Controls.Add(Me.updUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.datagridv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.atrail)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "adminmuser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin muser"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.datagridv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents atrail As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents mstudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mcourse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents msubject As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents muser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents macayear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datagridv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents updUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents adduser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Searchid As Guna.UI2.WinForms.Guna2TextBox
End Class
