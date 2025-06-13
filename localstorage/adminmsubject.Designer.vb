<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminmsubject
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminmsubject))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.atrail = New Guna.UI2.WinForms.Guna2Button()
        Me.logout = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Dashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.macayear = New Guna.UI2.WinForms.Guna2Button()
        Me.mcourse = New Guna.UI2.WinForms.Guna2Button()
        Me.muser = New Guna.UI2.WinForms.Guna2Button()
        Me.mstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.msubject = New Guna.UI2.WinForms.Guna2Button()
        Me.datagridv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.search = New System.Windows.Forms.Label()
        Me.addsubject1 = New Guna.UI2.WinForms.Guna2Button()
        Me.actstudent = New Guna.UI2.WinForms.Guna2Button()
        Me.subjectname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.addsubstudentbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
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
        Me.Guna2Panel1.Controls.Add(Me.Dashboard)
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
        'Dashboard
        '
        Me.Dashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Dashboard.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Dashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dashboard.ForeColor = System.Drawing.Color.Black
        Me.Dashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Dashboard.HoverState.ForeColor = System.Drawing.Color.White
        Me.Dashboard.Location = New System.Drawing.Point(0, 136)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.PressedColor = System.Drawing.Color.RosyBrown
        Me.Dashboard.Size = New System.Drawing.Size(171, 40)
        Me.Dashboard.TabIndex = 13
        Me.Dashboard.Text = "Dashboard"
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
        Me.muser.Location = New System.Drawing.Point(-16, 340)
        Me.muser.Name = "muser"
        Me.muser.Size = New System.Drawing.Size(190, 45)
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
        Me.mstudent.Location = New System.Drawing.Point(0, 182)
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.datagridv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.datagridv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.datagridv.ColumnHeadersHeight = 22
        Me.datagridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridv.DefaultCellStyle = DataGridViewCellStyle6
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
        'search
        '
        Me.search.AutoSize = True
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.search.Location = New System.Drawing.Point(193, 181)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(65, 20)
        Me.search.TabIndex = 13
        Me.search.Text = "Subject"
        '
        'addsubject1
        '
        Me.addsubject1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addsubject1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addsubject1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addsubject1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addsubject1.FillColor = System.Drawing.Color.White
        Me.addsubject1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addsubject1.ForeColor = System.Drawing.Color.Black
        Me.addsubject1.Location = New System.Drawing.Point(492, 159)
        Me.addsubject1.Name = "addsubject1"
        Me.addsubject1.Size = New System.Drawing.Size(163, 42)
        Me.addsubject1.TabIndex = 16
        Me.addsubject1.Text = "Add Subject"
        '
        'actstudent
        '
        Me.actstudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.actstudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.actstudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.actstudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.actstudent.FillColor = System.Drawing.Color.White
        Me.actstudent.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.actstudent.ForeColor = System.Drawing.Color.Black
        Me.actstudent.Location = New System.Drawing.Point(661, 159)
        Me.actstudent.Name = "actstudent"
        Me.actstudent.Size = New System.Drawing.Size(168, 42)
        Me.actstudent.TabIndex = 17
        Me.actstudent.Text = "Update Subject"
        '
        'subjectname
        '
        Me.subjectname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.subjectname.DefaultText = ""
        Me.subjectname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.subjectname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.subjectname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.subjectname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.subjectname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjectname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.subjectname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.subjectname.Location = New System.Drawing.Point(264, 159)
        Me.subjectname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.subjectname.Name = "subjectname"
        Me.subjectname.PlaceholderText = ""
        Me.subjectname.SelectedText = ""
        Me.subjectname.Size = New System.Drawing.Size(176, 42)
        Me.subjectname.TabIndex = 18
        '
        'addsubstudentbtn
        '
        Me.addsubstudentbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addsubstudentbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addsubstudentbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addsubstudentbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addsubstudentbtn.FillColor = System.Drawing.Color.White
        Me.addsubstudentbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addsubstudentbtn.ForeColor = System.Drawing.Color.Black
        Me.addsubstudentbtn.Location = New System.Drawing.Point(661, 108)
        Me.addsubstudentbtn.Name = "addsubstudentbtn"
        Me.addsubstudentbtn.Size = New System.Drawing.Size(168, 45)
        Me.addsubstudentbtn.TabIndex = 19
        Me.addsubstudentbtn.Text = "Add Student"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'adminmsubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 569)
        Me.Controls.Add(Me.addsubstudentbtn)
        Me.Controls.Add(Me.subjectname)
        Me.Controls.Add(Me.actstudent)
        Me.Controls.Add(Me.addsubject1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.datagridv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.atrail)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminmsubject"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Student"
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
    Friend WithEvents search As Label
    Friend WithEvents addsubject1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents actstudent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents subjectname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents addsubstudentbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
