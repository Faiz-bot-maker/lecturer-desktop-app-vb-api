<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Sidebar = New System.Windows.Forms.Panel()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMatakuliah = New System.Windows.Forms.Button()
        Me.btnJadwal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Header = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pnlAbsen = New System.Windows.Forms.Panel()
        Me.pnlMatakuliah = New System.Windows.Forms.Panel()
        Me.pnlCourseMhs = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCourseMhs = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMatakuliah = New System.Windows.Forms.DataGridView()
        Me.pnlJadwal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.pnlMatakuliah.SuspendLayout()
        Me.pnlCourseMhs.SuspendLayout()
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJadwal.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.btnDashboard)
        Me.Sidebar.Controls.Add(Me.Label1)
        Me.Sidebar.Controls.Add(Me.btnMatakuliah)
        Me.Sidebar.Controls.Add(Me.btnJadwal)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 540)
        Me.Sidebar.TabIndex = 0
        '
        'btnDashboard
        '
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(3, 176)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(191, 31)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NID :"
        '
        'btnMatakuliah
        '
        Me.btnMatakuliah.FlatAppearance.BorderSize = 0
        Me.btnMatakuliah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatakuliah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatakuliah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMatakuliah.Image = CType(resources.GetObject("btnMatakuliah.Image"), System.Drawing.Image)
        Me.btnMatakuliah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatakuliah.Location = New System.Drawing.Point(3, 212)
        Me.btnMatakuliah.Name = "btnMatakuliah"
        Me.btnMatakuliah.Size = New System.Drawing.Size(191, 31)
        Me.btnMatakuliah.TabIndex = 2
        Me.btnMatakuliah.Text = "     Matakuliah"
        Me.btnMatakuliah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMatakuliah.UseVisualStyleBackColor = True
        '
        'btnJadwal
        '
        Me.btnJadwal.FlatAppearance.BorderSize = 0
        Me.btnJadwal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJadwal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnJadwal.Image = CType(resources.GetObject("btnJadwal.Image"), System.Drawing.Image)
        Me.btnJadwal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnJadwal.Location = New System.Drawing.Point(3, 252)
        Me.btnJadwal.Name = "btnJadwal"
        Me.btnJadwal.Size = New System.Drawing.Size(188, 31)
        Me.btnJadwal.TabIndex = 3
        Me.btnJadwal.Text = "     Jadwal"
        Me.btnJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJadwal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 79)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Header.Controls.Add(Me.btnLogout)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(194, 0)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(766, 41)
        Me.Header.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(679, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 31)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "     Dashboard"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(1, 169)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 31)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "     Absen Mahasiswa"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pnlAbsen
        '
        Me.pnlAbsen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAbsen.Location = New System.Drawing.Point(194, 41)
        Me.pnlAbsen.Name = "pnlAbsen"
        Me.pnlAbsen.Size = New System.Drawing.Size(766, 499)
        Me.pnlAbsen.TabIndex = 3
        '
        'pnlMatakuliah
        '
        Me.pnlMatakuliah.Controls.Add(Me.Label4)
        Me.pnlMatakuliah.Controls.Add(Me.btnCourseMhs)
        Me.pnlMatakuliah.Controls.Add(Me.Label3)
        Me.pnlMatakuliah.Controls.Add(Me.dgvMatakuliah)
        Me.pnlMatakuliah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMatakuliah.Location = New System.Drawing.Point(194, 41)
        Me.pnlMatakuliah.Name = "pnlMatakuliah"
        Me.pnlMatakuliah.Size = New System.Drawing.Size(766, 499)
        Me.pnlMatakuliah.TabIndex = 4
        '
        'pnlCourseMhs
        '
        Me.pnlCourseMhs.Controls.Add(Me.btnBack)
        Me.pnlCourseMhs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCourseMhs.Location = New System.Drawing.Point(194, 41)
        Me.pnlCourseMhs.Name = "pnlCourseMhs"
        Me.pnlCourseMhs.Size = New System.Drawing.Size(766, 499)
        Me.pnlCourseMhs.TabIndex = 10
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Image = Global.sistemperkuliahan.My.Resources.Resources.left_arrow
        Me.btnBack.Location = New System.Drawing.Point(6, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(39, 32)
        Me.btnBack.TabIndex = 0
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(20, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(396, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mahasiswa Yang Mengikuti Matakuliah"
        '
        'btnCourseMhs
        '
        Me.btnCourseMhs.FlatAppearance.BorderSize = 0
        Me.btnCourseMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCourseMhs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseMhs.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCourseMhs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCourseMhs.Location = New System.Drawing.Point(3, 397)
        Me.btnCourseMhs.Name = "btnCourseMhs"
        Me.btnCourseMhs.Size = New System.Drawing.Size(760, 75)
        Me.btnCourseMhs.TabIndex = 7
        Me.btnCourseMhs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCourseMhs.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(20, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MATAKULIAH DOSEN"
        '
        'dgvMatakuliah
        '
        Me.dgvMatakuliah.AllowUserToAddRows = False
        Me.dgvMatakuliah.AllowUserToDeleteRows = False
        Me.dgvMatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatakuliah.Location = New System.Drawing.Point(24, 61)
        Me.dgvMatakuliah.Name = "dgvMatakuliah"
        Me.dgvMatakuliah.ReadOnly = True
        Me.dgvMatakuliah.RowHeadersWidth = 51
        Me.dgvMatakuliah.Size = New System.Drawing.Size(573, 319)
        Me.dgvMatakuliah.TabIndex = 8
        '
        'pnlJadwal
        '
        Me.pnlJadwal.Controls.Add(Me.Label2)
        Me.pnlJadwal.Controls.Add(Me.dgvJadwal)
        Me.pnlJadwal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJadwal.Location = New System.Drawing.Point(194, 41)
        Me.pnlJadwal.Name = "pnlJadwal"
        Me.pnlJadwal.Size = New System.Drawing.Size(766, 499)
        Me.pnlJadwal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "JADWAL DOSEN"
        '
        'dgvJadwal
        '
        Me.dgvJadwal.AllowUserToAddRows = False
        Me.dgvJadwal.AllowUserToDeleteRows = False
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwal.Location = New System.Drawing.Point(24, 61)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.ReadOnly = True
        Me.dgvJadwal.RowHeadersWidth = 51
        Me.dgvJadwal.Size = New System.Drawing.Size(573, 319)
        Me.dgvJadwal.TabIndex = 0
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(194, 41)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(766, 499)
        Me.pnlDashboard.TabIndex = 2
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 540)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMatakuliah)
        Me.Controls.Add(Me.pnlCourseMhs)
        Me.Controls.Add(Me.pnlAbsen)
        Me.Controls.Add(Me.pnlJadwal)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.pnlMatakuliah.ResumeLayout(False)
        Me.pnlMatakuliah.PerformLayout()
        Me.pnlCourseMhs.ResumeLayout(False)
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlJadwal.ResumeLayout(False)
        Me.pnlJadwal.PerformLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sidebar As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnJadwal As Button
    Friend WithEvents btnMatakuliah As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents pnlAbsen As Panel
    Friend WithEvents pnlMatakuliah As Panel
    Friend WithEvents pnlJadwal As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMatakuliah As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCourseMhs As Button
    Friend WithEvents pnlCourseMhs As Panel
    Friend WithEvents btnBack As Button
End Class
