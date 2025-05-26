<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminmay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminmay))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.datav = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.yearlist = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.semlist = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Terms = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.datav, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.atrail.Size = New System.Drawing.Size(164, 42)
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
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(48, 13)
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
        Me.Label1.Location = New System.Drawing.Point(333, 33)
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
        Me.Dashboard.Location = New System.Drawing.Point(0, 140)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.PressedColor = System.Drawing.Color.RosyBrown
        Me.Dashboard.Size = New System.Drawing.Size(174, 40)
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
        Me.mcourse.Size = New System.Drawing.Size(171, 45)
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
        Me.muser.Size = New System.Drawing.Size(187, 45)
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
        Me.mstudent.Location = New System.Drawing.Point(0, 181)
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
        Me.msubject.Size = New System.Drawing.Size(180, 45)
        Me.msubject.TabIndex = 10
        Me.msubject.Text = "Manage Subject"
        '
        'datav
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.datav.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datav.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datav.ColumnHeadersHeight = 4
        Me.datav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datav.DefaultCellStyle = DataGridViewCellStyle3
        Me.datav.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datav.Location = New System.Drawing.Point(186, 174)
        Me.datav.Name = "datav"
        Me.datav.RowHeadersVisible = False
        Me.datav.RowHeadersWidth = 51
        Me.datav.RowTemplate.Height = 24
        Me.datav.Size = New System.Drawing.Size(655, 380)
        Me.datav.TabIndex = 10
        Me.datav.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datav.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datav.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datav.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datav.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datav.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datav.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datav.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datav.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datav.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datav.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datav.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datav.ThemeStyle.HeaderStyle.Height = 4
        Me.datav.ThemeStyle.ReadOnly = False
        Me.datav.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datav.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datav.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datav.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datav.ThemeStyle.RowsStyle.Height = 24
        Me.datav.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datav.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'yearlist
        '
        Me.yearlist.BackColor = System.Drawing.Color.Transparent
        Me.yearlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.yearlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearlist.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearlist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.yearlist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.yearlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.yearlist.ItemHeight = 30
        Me.yearlist.Location = New System.Drawing.Point(186, 132)
        Me.yearlist.Name = "yearlist"
        Me.yearlist.Size = New System.Drawing.Size(136, 36)
        Me.yearlist.TabIndex = 11
        '
        'semlist
        '
        Me.semlist.BackColor = System.Drawing.Color.Transparent
        Me.semlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.semlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semlist.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.semlist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.semlist.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.semlist.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.semlist.ItemHeight = 30
        Me.semlist.Location = New System.Drawing.Point(328, 132)
        Me.semlist.Name = "semlist"
        Me.semlist.Size = New System.Drawing.Size(140, 36)
        Me.semlist.TabIndex = 12
        '
        'Terms
        '
        Me.Terms.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Terms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Terms.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Terms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Terms.FillColor = System.Drawing.Color.White
        Me.Terms.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Terms.ForeColor = System.Drawing.Color.Black
        Me.Terms.Location = New System.Drawing.Point(690, 132)
        Me.Terms.Name = "Terms"
        Me.Terms.Size = New System.Drawing.Size(151, 36)
        Me.Terms.TabIndex = 13
        Me.Terms.Text = "Terms"
        '
        'adminmay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 569)
        Me.Controls.Add(Me.Terms)
        Me.Controls.Add(Me.semlist)
        Me.Controls.Add(Me.yearlist)
        Me.Controls.Add(Me.datav)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.atrail)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "adminmay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminmay"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.datav, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents datav As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents yearlist As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents semlist As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Terms As Guna.UI2.WinForms.Guna2Button
End Class
