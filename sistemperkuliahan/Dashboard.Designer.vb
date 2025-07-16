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
        Me.lblNama = New System.Windows.Forms.Label()
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
        Me.pnlJadwal = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvJadwal = New System.Windows.Forms.DataGridView()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbsen = New System.Windows.Forms.Button()
        Me.pnljmlhjdwl = New System.Windows.Forms.Panel()
        Me.lblJmlhJadwal = New System.Windows.Forms.Label()
        Me.pnljmlhmtkl = New System.Windows.Forms.Panel()
        Me.lblJmlhMatkul = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlAbsen = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvAbsensi = New System.Windows.Forms.DataGridView()
        Me.pnlNilai = New System.Windows.Forms.Panel()
        Me.btnDeletenilai = New System.Windows.Forms.Button()
        Me.btnEditnilai = New System.Windows.Forms.Button()
        Me.btnAddnilai = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvStudentGrade = New System.Windows.Forms.DataGridView()
        Me.jmlhJdwl = New System.Windows.Forms.PictureBox()
        Me.jmlhMatkul = New System.Windows.Forms.PictureBox()
        Me.btnClosePnlCourseMhs = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnMatakuliah = New System.Windows.Forms.Button()
        Me.btnJadwal = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Sidebar.SuspendLayout()
        Me.Header.SuspendLayout()
        Me.pnlMatakuliah.SuspendLayout()
        CType(Me.dgvMatakuliah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCourseMhs.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJadwal.SuspendLayout()
        CType(Me.dgvJadwal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDashboard.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnljmlhjdwl.SuspendLayout()
        Me.pnljmlhmtkl.SuspendLayout()
        Me.PnlAbsen.SuspendLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNilai.SuspendLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jmlhJdwl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.jmlhMatkul, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sidebar
        '
        Me.Sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Sidebar.Controls.Add(Me.btnDashboard)
        Me.Sidebar.Controls.Add(Me.lblNama)
        Me.Sidebar.Controls.Add(Me.btnMatakuliah)
        Me.Sidebar.Controls.Add(Me.btnJadwal)
        Me.Sidebar.Controls.Add(Me.PictureBox1)
        Me.Sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.Sidebar.Location = New System.Drawing.Point(0, 0)
        Me.Sidebar.Name = "Sidebar"
        Me.Sidebar.Size = New System.Drawing.Size(194, 540)
        Me.Sidebar.TabIndex = 0
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNama.Location = New System.Drawing.Point(85, 126)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(16, 13)
        Me.lblNama.TabIndex = 6
        Me.lblNama.Text = "---"
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
        'pnlMatakuliah
        '
        Me.pnlMatakuliah.Controls.Add(Me.Label3)
        Me.pnlMatakuliah.Controls.Add(Me.dgvMatakuliah)
        Me.pnlMatakuliah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMatakuliah.Location = New System.Drawing.Point(194, 41)
        Me.pnlMatakuliah.Name = "pnlMatakuliah"
        Me.pnlMatakuliah.Size = New System.Drawing.Size(766, 499)
        Me.pnlMatakuliah.TabIndex = 4
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
        'pnlCourseMhs
        '
        Me.pnlCourseMhs.Controls.Add(Me.Button3)
        Me.pnlCourseMhs.Controls.Add(Me.Label6)
        Me.pnlCourseMhs.Controls.Add(Me.Button6)
        Me.pnlCourseMhs.Controls.Add(Me.Label4)
        Me.pnlCourseMhs.Controls.Add(Me.dgvStudents)
        Me.pnlCourseMhs.Controls.Add(Me.btnClosePnlCourseMhs)
        Me.pnlCourseMhs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCourseMhs.Location = New System.Drawing.Point(194, 41)
        Me.pnlCourseMhs.Name = "pnlCourseMhs"
        Me.pnlCourseMhs.Size = New System.Drawing.Size(766, 499)
        Me.pnlCourseMhs.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(409, 393)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(86, 37)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "Lihat Absen"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(281, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 12
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(511, 393)
        Me.Button6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 37)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Lihat Nilai"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(50, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "DAFTAR MAHASISWA"
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudents.Location = New System.Drawing.Point(24, 60)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersWidth = 51
        Me.dgvStudents.Size = New System.Drawing.Size(573, 319)
        Me.dgvStudents.TabIndex = 10
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
        Me.pnlDashboard.Controls.Add(Me.Label5)
        Me.pnlDashboard.Controls.Add(Me.Panel1)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(194, 41)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(766, 499)
        Me.pnlDashboard.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnAbsen)
        Me.Panel1.Controls.Add(Me.pnljmlhjdwl)
        Me.Panel1.Controls.Add(Me.pnljmlhmtkl)
        Me.Panel1.Location = New System.Drawing.Point(25, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 177)
        Me.Panel1.TabIndex = 3
        '
        'btnAbsen
        '
        Me.btnAbsen.BackColor = System.Drawing.Color.Turquoise
        Me.btnAbsen.Location = New System.Drawing.Point(544, 48)
        Me.btnAbsen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAbsen.Name = "btnAbsen"
        Me.btnAbsen.Size = New System.Drawing.Size(81, 81)
        Me.btnAbsen.TabIndex = 0
        Me.btnAbsen.Text = "Absen"
        Me.btnAbsen.UseVisualStyleBackColor = False
        '
        'pnljmlhjdwl
        '
        Me.pnljmlhjdwl.Controls.Add(Me.Label1)
        Me.pnljmlhjdwl.Controls.Add(Me.lblJmlhJadwal)
        Me.pnljmlhjdwl.Controls.Add(Me.jmlhJdwl)
        Me.pnljmlhjdwl.Location = New System.Drawing.Point(280, 31)
        Me.pnljmlhjdwl.Name = "pnljmlhjdwl"
        Me.pnljmlhjdwl.Size = New System.Drawing.Size(137, 125)
        Me.pnljmlhjdwl.TabIndex = 1
        '
        'lblJmlhJadwal
        '
        Me.lblJmlhJadwal.AutoSize = True
        Me.lblJmlhJadwal.Location = New System.Drawing.Point(61, 106)
        Me.lblJmlhJadwal.Name = "lblJmlhJadwal"
        Me.lblJmlhJadwal.Size = New System.Drawing.Size(22, 13)
        Me.lblJmlhJadwal.TabIndex = 2
        Me.lblJmlhJadwal.Text = "- - -"
        '
        'pnljmlhmtkl
        '
        Me.pnljmlhmtkl.Controls.Add(Me.lblJmlhMatkul)
        Me.pnljmlhmtkl.Controls.Add(Me.jmlhMatkul)
        Me.pnljmlhmtkl.Controls.Add(Me.Label8)
        Me.pnljmlhmtkl.Location = New System.Drawing.Point(49, 31)
        Me.pnljmlhmtkl.Name = "pnljmlhmtkl"
        Me.pnljmlhmtkl.Size = New System.Drawing.Size(137, 125)
        Me.pnljmlhmtkl.TabIndex = 2
        '
        'lblJmlhMatkul
        '
        Me.lblJmlhMatkul.AutoSize = True
        Me.lblJmlhMatkul.Location = New System.Drawing.Point(57, 106)
        Me.lblJmlhMatkul.Name = "lblJmlhMatkul"
        Me.lblJmlhMatkul.Size = New System.Drawing.Size(22, 13)
        Me.lblJmlhMatkul.TabIndex = 1
        Me.lblJmlhMatkul.Text = "- - -"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, -3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jumlah Matakuliah"
        '
        'PnlAbsen
        '
        Me.PnlAbsen.Controls.Add(Me.btnDelete)
        Me.PnlAbsen.Controls.Add(Me.btnAdd)
        Me.PnlAbsen.Controls.Add(Me.Label7)
        Me.PnlAbsen.Controls.Add(Me.dgvAbsensi)
        Me.PnlAbsen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlAbsen.Location = New System.Drawing.Point(194, 41)
        Me.PnlAbsen.Name = "PnlAbsen"
        Me.PnlAbsen.Size = New System.Drawing.Size(766, 499)
        Me.PnlAbsen.TabIndex = 12
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(474, 416)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(107, 47)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(361, 416)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 47)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(22, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ABSENSI MAHASISWA"
        '
        'dgvAbsensi
        '
        Me.dgvAbsensi.AllowUserToAddRows = False
        Me.dgvAbsensi.AllowUserToDeleteRows = False
        Me.dgvAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAbsensi.Location = New System.Drawing.Point(24, 61)
        Me.dgvAbsensi.Name = "dgvAbsensi"
        Me.dgvAbsensi.ReadOnly = True
        Me.dgvAbsensi.RowHeadersWidth = 51
        Me.dgvAbsensi.Size = New System.Drawing.Size(573, 319)
        Me.dgvAbsensi.TabIndex = 8
        '
        'pnlNilai
        '
        Me.pnlNilai.Controls.Add(Me.btnDeletenilai)
        Me.pnlNilai.Controls.Add(Me.btnEditnilai)
        Me.pnlNilai.Controls.Add(Me.btnAddnilai)
        Me.pnlNilai.Controls.Add(Me.Label9)
        Me.pnlNilai.Controls.Add(Me.dgvStudentGrade)
        Me.pnlNilai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNilai.Location = New System.Drawing.Point(194, 0)
        Me.pnlNilai.Name = "pnlNilai"
        Me.pnlNilai.Size = New System.Drawing.Size(766, 540)
        Me.pnlNilai.TabIndex = 13
        '
        'btnDeletenilai
        '
        Me.btnDeletenilai.Location = New System.Drawing.Point(474, 416)
        Me.btnDeletenilai.Name = "btnDeletenilai"
        Me.btnDeletenilai.Size = New System.Drawing.Size(107, 47)
        Me.btnDeletenilai.TabIndex = 12
        Me.btnDeletenilai.Text = "Hapus"
        Me.btnDeletenilai.UseVisualStyleBackColor = True
        '
        'btnEditnilai
        '
        Me.btnEditnilai.Location = New System.Drawing.Point(347, 416)
        Me.btnEditnilai.Name = "btnEditnilai"
        Me.btnEditnilai.Size = New System.Drawing.Size(107, 47)
        Me.btnEditnilai.TabIndex = 11
        Me.btnEditnilai.Text = "Edit"
        Me.btnEditnilai.UseVisualStyleBackColor = True
        '
        'btnAddnilai
        '
        Me.btnAddnilai.Location = New System.Drawing.Point(219, 416)
        Me.btnAddnilai.Name = "btnAddnilai"
        Me.btnAddnilai.Size = New System.Drawing.Size(107, 47)
        Me.btnAddnilai.TabIndex = 10
        Me.btnAddnilai.Text = "Tambah"
        Me.btnAddnilai.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(21, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(206, 24)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "NILAI MAHASISWA"
        '
        'dgvStudentGrade
        '
        Me.dgvStudentGrade.AllowUserToAddRows = False
        Me.dgvStudentGrade.AllowUserToDeleteRows = False
        Me.dgvStudentGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudentGrade.Location = New System.Drawing.Point(24, 61)
        Me.dgvStudentGrade.Name = "dgvStudentGrade"
        Me.dgvStudentGrade.ReadOnly = True
        Me.dgvStudentGrade.RowHeadersWidth = 51
        Me.dgvStudentGrade.Size = New System.Drawing.Size(573, 319)
        Me.dgvStudentGrade.TabIndex = 8
        '
        'jmlhJdwl
        '
        Me.jmlhJdwl.BackColor = System.Drawing.Color.Yellow
        Me.jmlhJdwl.BackgroundImage = Global.sistemperkuliahan.My.Resources.Resources.clock_dhs
        Me.jmlhJdwl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jmlhJdwl.Location = New System.Drawing.Point(31, 17)
        Me.jmlhJdwl.Name = "jmlhJdwl"
        Me.jmlhJdwl.Size = New System.Drawing.Size(82, 82)
        Me.jmlhJdwl.TabIndex = 1
        Me.jmlhJdwl.TabStop = False
        '
        'jmlhMatkul
        '
        Me.jmlhMatkul.BackColor = System.Drawing.Color.SpringGreen
        Me.jmlhMatkul.BackgroundImage = Global.sistemperkuliahan.My.Resources.Resources.icon_book
        Me.jmlhMatkul.Location = New System.Drawing.Point(28, 17)
        Me.jmlhMatkul.Name = "jmlhMatkul"
        Me.jmlhMatkul.Size = New System.Drawing.Size(81, 81)
        Me.jmlhMatkul.TabIndex = 0
        Me.jmlhMatkul.TabStop = False
        '
        'btnClosePnlCourseMhs
        '
        Me.btnClosePnlCourseMhs.FlatAppearance.BorderSize = 0
        Me.btnClosePnlCourseMhs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlCourseMhs.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClosePnlCourseMhs.Image = Global.sistemperkuliahan.My.Resources.Resources.left_arrow
        Me.btnClosePnlCourseMhs.Location = New System.Drawing.Point(11, 21)
        Me.btnClosePnlCourseMhs.Name = "btnClosePnlCourseMhs"
        Me.btnClosePnlCourseMhs.Size = New System.Drawing.Size(39, 32)
        Me.btnClosePnlCourseMhs.TabIndex = 0
        Me.btnClosePnlCourseMhs.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Jumlah Jadwal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(224, 33)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "SELAMAT DATANG."
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 540)
        Me.Controls.Add(Me.PnlAbsen)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMatakuliah)
        Me.Controls.Add(Me.pnlJadwal)
        Me.Controls.Add(Me.pnlCourseMhs)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.pnlNilai)
        Me.Controls.Add(Me.Sidebar)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.Sidebar.ResumeLayout(False)
        Me.Sidebar.PerformLayout()
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
        Me.pnlDashboard.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnljmlhjdwl.ResumeLayout(False)
        Me.pnljmlhjdwl.PerformLayout()
        Me.pnljmlhmtkl.ResumeLayout(False)
        Me.pnljmlhmtkl.PerformLayout()
        Me.PnlAbsen.ResumeLayout(False)
        Me.PnlAbsen.PerformLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNilai.ResumeLayout(False)
        Me.pnlNilai.PerformLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jmlhJdwl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.jmlhMatkul, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sidebar As Panel
    Friend WithEvents Header As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnJadwal As Button
    Friend WithEvents btnMatakuliah As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblNama As Label
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
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PnlAbsen As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvAbsensi As DataGridView
    Friend WithEvents btnAbsen As Button
    Friend WithEvents pnljmlhmtkl As Panel
    Friend WithEvents pnljmlhjdwl As Panel
    Friend WithEvents jmlhMatkul As PictureBox
    Friend WithEvents jmlhJdwl As PictureBox
    Friend WithEvents lblJmlhMatkul As Label
    Friend WithEvents lblJmlhJadwal As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlNilai As Panel
    Friend WithEvents btnDeletenilai As Button
    Friend WithEvents btnEditnilai As Button
    Friend WithEvents btnAddnilai As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvStudentGrade As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
End Class
