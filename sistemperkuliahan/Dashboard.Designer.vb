<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.pnlMatakuliah = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMatakuliah = New System.Windows.Forms.DataGridView()
        Me.pnlCourseMhs = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.btnClosePnlCourseMhs = New System.Windows.Forms.Button()
        Me.pnlJadwal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.btnAbsen = New System.Windows.Forms.Button()
        Me.pnlNilai = New System.Windows.Forms.Panel()
        Me.btnClosePnlNilai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvStudentGrade = New System.Windows.Forms.DataGridView()
        Me.PnlAbsen = New System.Windows.Forms.Panel()
        Me.btnClosePnlAbsensi = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvAbsensi = New System.Windows.Forms.DataGridView()
        Me.Sidebar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        Me.pnlMatakuliah.SuspendLayout()
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCourseMhs.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJadwal.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        Me.pnlNilai.SuspendLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlAbsen.SuspendLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Sidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(259, 665)
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
        Me.btnDashboard.Location = New System.Drawing.Point(4, 217)
        Me.btnDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(255, 38)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDashboard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(71, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
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
        Me.btnMatakuliah.Location = New System.Drawing.Point(4, 261)
        Me.btnMatakuliah.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMatakuliah.Name = "btnMatakuliah"
        Me.btnMatakuliah.Size = New System.Drawing.Size(255, 38)
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
        Me.btnJadwal.Location = New System.Drawing.Point(4, 310)
        Me.btnJadwal.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJadwal.Name = "btnJadwal"
        Me.btnJadwal.Size = New System.Drawing.Size(251, 38)
        Me.btnJadwal.TabIndex = 3
        Me.btnJadwal.Text = "     Jadwal"
        Me.btnJadwal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnJadwal.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(75, 43)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 97)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.Header.Controls.Add(Me.btnLogout)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Location = New System.Drawing.Point(259, 0)
        Me.Header.Margin = New System.Windows.Forms.Padding(4)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1021, 50)
        Me.Header.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(905, 15)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 28)
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
        'pnlMatakuliah
        '
        Me.pnlMatakuliah.Controls.Add(Me.Label3)
        Me.pnlMatakuliah.Controls.Add(Me.dgvMatakuliah)
        Me.pnlMatakuliah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMatakuliah.Location = New System.Drawing.Point(259, 50)
        Me.pnlMatakuliah.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlMatakuliah.Name = "pnlMatakuliah"
        Me.pnlMatakuliah.Size = New System.Drawing.Size(1021, 615)
        Me.pnlMatakuliah.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(27, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MATAKULIAH DOSEN"
        '
        'dgvMatakuliah
        '
        Me.dgvMatakuliah.AllowUserToAddRows = False
        Me.dgvMatakuliah.AllowUserToDeleteRows = False
        Me.dgvMatakuliah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMatakuliah.Location = New System.Drawing.Point(32, 75)
        Me.dgvMatakuliah.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvMatakuliah.Name = "dgvMatakuliah"
        Me.dgvMatakuliah.ReadOnly = True
        Me.dgvMatakuliah.RowHeadersWidth = 51
        Me.dgvMatakuliah.Size = New System.Drawing.Size(764, 393)
        Me.dgvMatakuliah.TabIndex = 8
        '
        'pnlCourseMhs
        '
        Me.pnlCourseMhs.Controls.Add(Me.Button3)
        Me.pnlCourseMhs.Controls.Add(Me.Label6)
        Me.pnlCourseMhs.Controls.Add(Me.Button6)
        Me.pnlCourseMhs.Controls.Add(Me.Label4)
        Me.pnlCourseMhs.Controls.Add(Me.dgvStudents)
        Me.pnlCourseMhs.Controls.Add(Me.btnClosePnlCourseMhs)
        Me.pnlCourseMhs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCourseMhs.Location = New System.Drawing.Point(259, 50)
        Me.pnlCourseMhs.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlCourseMhs.Name = "pnlCourseMhs"
        Me.pnlCourseMhs.Size = New System.Drawing.Size(1021, 615)
        Me.pnlCourseMhs.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(545, 484)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 45)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Lihat Absen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(375, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 32)
        Me.Label6.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(681, 484)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 45)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Lihat Nilai"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(67, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(300, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DAFTAR MAHASISWA"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(32, 74)
        Me.dgvStudents.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(764, 393)
        Me.dgvStudents.TabIndex = 10
        '
        'btnClosePnlCourseMhs
        '
        Me.btnClosePnlCourseMhs.FlatAppearance.BorderSize = 0
        Me.btnClosePnlCourseMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlCourseMhs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClosePnlCourseMhs.Image = Global.sistemperkuliahan.My.Resources.Resources.left_arrow
        Me.btnClosePnlCourseMhs.Location = New System.Drawing.Point(15, 26)
        Me.btnClosePnlCourseMhs.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClosePnlCourseMhs.Name = "btnClosePnlCourseMhs"
        Me.btnClosePnlCourseMhs.Size = New System.Drawing.Size(52, 39)
        Me.btnClosePnlCourseMhs.TabIndex = 0
        Me.btnClosePnlCourseMhs.UseVisualStyleBackColor = True
        '
        'pnlJadwal
        '
        Me.pnlJadwal.Controls.Add(Me.Label2)
        Me.pnlJadwal.Controls.Add(Me.dgvJadwal)
        Me.pnlJadwal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJadwal.Location = New System.Drawing.Point(259, 50)
        Me.pnlJadwal.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlJadwal.Name = "pnlJadwal"
        Me.pnlJadwal.Size = New System.Drawing.Size(1021, 615)
        Me.pnlJadwal.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(27, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "JADWAL DOSEN"
        '
        'dgvJadwal
        '
        Me.dgvJadwal.AllowUserToAddRows = False
        Me.dgvJadwal.AllowUserToDeleteRows = False
        Me.dgvJadwal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJadwal.Location = New System.Drawing.Point(32, 75)
        Me.dgvJadwal.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvJadwal.Name = "dgvJadwal"
        Me.dgvJadwal.ReadOnly = True
        Me.dgvJadwal.RowHeadersWidth = 51
        Me.dgvJadwal.Size = New System.Drawing.Size(764, 393)
        Me.dgvJadwal.TabIndex = 0
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.btnAbsen)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(259, 50)
        Me.pnlDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1021, 615)
        Me.pnlDashboard.TabIndex = 2
        '
        'btnAbsen
        '
        Me.btnAbsen.Location = New System.Drawing.Point(391, 104)
        Me.btnAbsen.Name = "btnAbsen"
        Me.btnAbsen.Size = New System.Drawing.Size(75, 23)
        Me.btnAbsen.TabIndex = 0
        Me.btnAbsen.Text = "Absen"
        Me.btnAbsen.UseVisualStyleBackColor = True
        '
        'pnlNilai
        '
        Me.pnlNilai.Controls.Add(Me.btnClosePnlNilai)
        Me.pnlNilai.Controls.Add(Me.Label5)
        Me.pnlNilai.Controls.Add(Me.dgvStudentGrade)
        Me.pnlNilai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNilai.Location = New System.Drawing.Point(259, 50)
        Me.pnlNilai.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNilai.Name = "pnlNilai"
        Me.pnlNilai.Size = New System.Drawing.Size(1021, 615)
        Me.pnlNilai.TabIndex = 11
        '
        'btnClosePnlNilai
        '
        Me.btnClosePnlNilai.FlatAppearance.BorderSize = 0
        Me.btnClosePnlNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlNilai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClosePnlNilai.Image = Global.sistemperkuliahan.My.Resources.Resources.left_arrow
        Me.btnClosePnlNilai.Location = New System.Drawing.Point(33, 28)
        Me.btnClosePnlNilai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClosePnlNilai.Name = "btnClosePnlNilai"
        Me.btnClosePnlNilai.Size = New System.Drawing.Size(52, 39)
        Me.btnClosePnlNilai.TabIndex = 9
        Me.btnClosePnlNilai.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(94, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(262, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NILAI MAHASISWA"
        '
        'dgvStudentGrade
        '
        Me.dgvStudentGrade.AllowUserToAddRows = False
        Me.dgvStudentGrade.AllowUserToDeleteRows = False
        Me.dgvStudentGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentGrade.Location = New System.Drawing.Point(32, 75)
        Me.dgvStudentGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvStudentGrade.Name = "dgvStudentGrade"
        Me.dgvStudentGrade.ReadOnly = True
        Me.dgvStudentGrade.RowHeadersWidth = 51
        Me.dgvStudentGrade.Size = New System.Drawing.Size(764, 393)
        Me.dgvStudentGrade.TabIndex = 8
        '
        'PnlAbsen
        '
        Me.PnlAbsen.Controls.Add(Me.btnClosePnlAbsensi)
        Me.PnlAbsen.Controls.Add(Me.Label7)
        Me.PnlAbsen.Controls.Add(Me.dgvAbsensi)
        Me.PnlAbsen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAbsen.Location = New System.Drawing.Point(259, 50)
        Me.PnlAbsen.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlAbsen.Name = "PnlAbsen"
        Me.PnlAbsen.Size = New System.Drawing.Size(1021, 615)
        Me.PnlAbsen.TabIndex = 12
        '
        'btnClosePnlAbsensi
        '
        Me.btnClosePnlAbsensi.FlatAppearance.BorderSize = 0
        Me.btnClosePnlAbsensi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlAbsensi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClosePnlAbsensi.Image = Global.sistemperkuliahan.My.Resources.Resources.left_arrow
        Me.btnClosePnlAbsensi.Location = New System.Drawing.Point(33, 28)
        Me.btnClosePnlAbsensi.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClosePnlAbsensi.Name = "btnClosePnlAbsensi"
        Me.btnClosePnlAbsensi.Size = New System.Drawing.Size(52, 39)
        Me.btnClosePnlAbsensi.TabIndex = 9
        Me.btnClosePnlAbsensi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(94, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(311, 32)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ABSENSI MAHASISWA"
        '
        'dgvAbsensi
        '
        Me.dgvAbsensi.AllowUserToAddRows = False
        Me.dgvAbsensi.AllowUserToDeleteRows = False
        Me.dgvAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbsensi.Location = New System.Drawing.Point(32, 75)
        Me.dgvAbsensi.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvAbsensi.Name = "dgvAbsensi"
        Me.dgvAbsensi.ReadOnly = True
        Me.dgvAbsensi.RowHeadersWidth = 51
        Me.dgvAbsensi.Size = New System.Drawing.Size(764, 393)
        Me.dgvAbsensi.TabIndex = 8
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 665)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMatakuliah)
        Me.Controls.Add(Me.pnlJadwal)
        Me.Controls.Add(Me.pnlCourseMhs)
        Me.Controls.Add(Me.PnlAbsen)
        Me.Controls.Add(Me.pnlNilai)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Sidebar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        Me.pnlMatakuliah.ResumeLayout(False)
        Me.pnlMatakuliah.PerformLayout()
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCourseMhs.ResumeLayout(False)
        Me.pnlCourseMhs.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlJadwal.ResumeLayout(False)
        Me.pnlJadwal.PerformLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDashboard.ResumeLayout(False)
        Me.pnlNilai.ResumeLayout(False)
        Me.pnlNilai.PerformLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlAbsen.ResumeLayout(False)
        Me.PnlAbsen.PerformLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlMatakuliah As Panel
    Friend WithEvents pnlJadwal As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvJadwal As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMatakuliah As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlCourseMhs As Panel
    Friend WithEvents btnClosePnlCourseMhs As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvStudents As DataGridView
    Friend WithEvents pnlNilai As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvStudentGrade As DataGridView
    Friend WithEvents btnClosePnlNilai As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PnlAbsen As Panel
    Friend WithEvents btnClosePnlAbsensi As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvAbsensi As DataGridView
    Friend WithEvents btnAbsen As Button
End Class
