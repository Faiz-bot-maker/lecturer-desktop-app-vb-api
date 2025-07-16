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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbsen = New System.Windows.Forms.Button()
        Me.pnljmlhjdwl = New System.Windows.Forms.Panel()
        Me.lblJmlhMatkul = New System.Windows.Forms.Label()
        Me.jmlhJdwl = New System.Windows.Forms.PictureBox()
        Me.pnljmlhmtkl = New System.Windows.Forms.Panel()
        Me.lblJmlhMhs = New System.Windows.Forms.Label()
        Me.jmlhMhs = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PnlAbsen = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClosePnlAbsensi = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvAbsensi = New System.Windows.Forms.DataGridView()
        Me.pnlNilai = New System.Windows.Forms.Panel()
        Me.btnDeletenilai = New System.Windows.Forms.Button()
        Me.btnEditnilai = New System.Windows.Forms.Button()
        Me.btnAddnilai = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvStudentGrade = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.SuspendLayout()
        Me.pnljmlhjdwl.SuspendLayout()
        CType(Me.jmlhJdwl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnljmlhmtkl.SuspendLayout()
        CType(Me.jmlhMhs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlAbsen.SuspendLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNilai.SuspendLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 46)
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
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(115, 46)
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
        Me.pnlDashboard.Controls.Add(Me.Panel1)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(259, 50)
        Me.pnlDashboard.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(1021, 615)
        Me.pnlDashboard.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnAbsen)
        Me.Panel1.Controls.Add(Me.pnljmlhjdwl)
        Me.Panel1.Controls.Add(Me.pnljmlhmtkl)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(33, 26)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(943, 218)
        Me.Panel1.TabIndex = 3
        '
        'btnAbsen
        '
        Me.btnAbsen.Location = New System.Drawing.Point(689, 38)
        Me.btnAbsen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAbsen.Name = "btnAbsen"
        Me.btnAbsen.Size = New System.Drawing.Size(183, 154)
        Me.btnAbsen.TabIndex = 0
        Me.btnAbsen.Text = "Absen"
        Me.btnAbsen.UseVisualStyleBackColor = True
        '
        'pnljmlhjdwl
        '
        Me.pnljmlhjdwl.Controls.Add(Me.lblJmlhMatkul)
        Me.pnljmlhjdwl.Controls.Add(Me.jmlhJdwl)
        Me.pnljmlhjdwl.Location = New System.Drawing.Point(373, 38)
        Me.pnljmlhjdwl.Margin = New System.Windows.Forms.Padding(4)
        Me.pnljmlhjdwl.Name = "pnljmlhjdwl"
        Me.pnljmlhjdwl.Size = New System.Drawing.Size(183, 154)
        Me.pnljmlhjdwl.TabIndex = 1
        '
        'lblJmlhMatkul
        '
        Me.lblJmlhMatkul.AutoSize = True
        Me.lblJmlhMatkul.Location = New System.Drawing.Point(81, 130)
        Me.lblJmlhMatkul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJmlhMatkul.Name = "lblJmlhMatkul"
        Me.lblJmlhMatkul.Size = New System.Drawing.Size(25, 16)
        Me.lblJmlhMatkul.TabIndex = 2
        Me.lblJmlhMatkul.Text = "- - -"
        '
        'jmlhJdwl
        '
        Me.jmlhJdwl.BackColor = System.Drawing.Color.Yellow
        Me.jmlhJdwl.BackgroundImage = Global.sistemperkuliahan.My.Resources.Resources.clock_dhs
        Me.jmlhJdwl.Location = New System.Drawing.Point(41, 21)
        Me.jmlhJdwl.Margin = New System.Windows.Forms.Padding(4)
        Me.jmlhJdwl.Name = "jmlhJdwl"
        Me.jmlhJdwl.Size = New System.Drawing.Size(108, 100)
        Me.jmlhJdwl.TabIndex = 1
        Me.jmlhJdwl.TabStop = False
        '
        'pnljmlhmtkl
        '
        Me.pnljmlhmtkl.Controls.Add(Me.lblJmlhMhs)
        Me.pnljmlhmtkl.Controls.Add(Me.jmlhMhs)
        Me.pnljmlhmtkl.Location = New System.Drawing.Point(65, 38)
        Me.pnljmlhmtkl.Margin = New System.Windows.Forms.Padding(4)
        Me.pnljmlhmtkl.Name = "pnljmlhmtkl"
        Me.pnljmlhmtkl.Size = New System.Drawing.Size(183, 154)
        Me.pnljmlhmtkl.TabIndex = 2
        '
        'lblJmlhMhs
        '
        Me.lblJmlhMhs.AutoSize = True
        Me.lblJmlhMhs.Location = New System.Drawing.Point(76, 130)
        Me.lblJmlhMhs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJmlhMhs.Name = "lblJmlhMhs"
        Me.lblJmlhMhs.Size = New System.Drawing.Size(25, 16)
        Me.lblJmlhMhs.TabIndex = 1
        Me.lblJmlhMhs.Text = "- - -"
        '
        'jmlhMhs
        '
        Me.jmlhMhs.BackColor = System.Drawing.Color.SpringGreen
        Me.jmlhMhs.BackgroundImage = Global.sistemperkuliahan.My.Resources.Resources.group
        Me.jmlhMhs.Location = New System.Drawing.Point(37, 21)
        Me.jmlhMhs.Margin = New System.Windows.Forms.Padding(4)
        Me.jmlhMhs.Name = "jmlhMhs"
        Me.jmlhMhs.Size = New System.Drawing.Size(108, 100)
        Me.jmlhMhs.TabIndex = 0
        Me.jmlhMhs.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 9)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Jumlah Mahasiswa"
        '
        'PnlAbsen
        '
        Me.PnlAbsen.Controls.Add(Me.btnDelete)
        Me.PnlAbsen.Controls.Add(Me.btnEdit)
        Me.PnlAbsen.Controls.Add(Me.btnAdd)
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
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(632, 512)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(143, 58)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(463, 512)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(143, 58)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(292, 512)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(143, 58)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
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
        Me.Label7.Location = New System.Drawing.Point(93, 31)
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
        'pnlNilai
        '
        Me.pnlNilai.Controls.Add(Me.btnDeletenilai)
        Me.pnlNilai.Controls.Add(Me.btnEditnilai)
        Me.pnlNilai.Controls.Add(Me.btnAddnilai)
        Me.pnlNilai.Controls.Add(Me.Label9)
        Me.pnlNilai.Controls.Add(Me.dgvStudentGrade)
        Me.pnlNilai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNilai.Location = New System.Drawing.Point(259, 50)
        Me.pnlNilai.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlNilai.Name = "pnlNilai"
        Me.pnlNilai.Size = New System.Drawing.Size(1021, 615)
        Me.pnlNilai.TabIndex = 13
        '
        'btnDeletenilai
        '
        Me.btnDeletenilai.Location = New System.Drawing.Point(632, 512)
        Me.btnDeletenilai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeletenilai.Name = "btnDeletenilai"
        Me.btnDeletenilai.Size = New System.Drawing.Size(143, 58)
        Me.btnDeletenilai.TabIndex = 12
        Me.btnDeletenilai.Text = "Hapus"
        Me.btnDeletenilai.UseVisualStyleBackColor = True
        '
        'btnEditnilai
        '
        Me.btnEditnilai.Location = New System.Drawing.Point(463, 512)
        Me.btnEditnilai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditnilai.Name = "btnEditnilai"
        Me.btnEditnilai.Size = New System.Drawing.Size(143, 58)
        Me.btnEditnilai.TabIndex = 11
        Me.btnEditnilai.Text = "Edit"
        Me.btnEditnilai.UseVisualStyleBackColor = True
        '
        'btnAddnilai
        '
        Me.btnAddnilai.Location = New System.Drawing.Point(292, 512)
        Me.btnAddnilai.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddnilai.Name = "btnAddnilai"
        Me.btnAddnilai.Size = New System.Drawing.Size(143, 58)
        Me.btnAddnilai.TabIndex = 10
        Me.btnAddnilai.Text = "Tambah"
        Me.btnAddnilai.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(28, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 32)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "NILAI MAHASISWA"
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
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 665)
        Me.Controls.Add(Me.pnlNilai)
        Me.Controls.Add(Me.pnlDashboard)
        Me.Controls.Add(Me.pnlMatakuliah)
        Me.Controls.Add(Me.pnlJadwal)
        Me.Controls.Add(Me.pnlCourseMhs)
        Me.Controls.Add(Me.PnlAbsen)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnljmlhjdwl.ResumeLayout(False)
        Me.pnljmlhjdwl.PerformLayout()
        CType(Me.jmlhJdwl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnljmlhmtkl.ResumeLayout(False)
        Me.pnljmlhmtkl.PerformLayout()
        CType(Me.jmlhMhs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlAbsen.ResumeLayout(False)
        Me.PnlAbsen.PerformLayout()
        CType(Me.dgvAbsensi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNilai.ResumeLayout(False)
        Me.pnlNilai.PerformLayout()
        CType(Me.dgvStudentGrade, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents PnlAbsen As Panel
    Friend WithEvents btnClosePnlAbsensi As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvAbsensi As DataGridView
    Friend WithEvents btnAbsen As Button
    Friend WithEvents pnljmlhmtkl As Panel
    Friend WithEvents pnljmlhjdwl As Panel
    Friend WithEvents jmlhMhs As PictureBox
    Friend WithEvents jmlhJdwl As PictureBox
    Friend WithEvents lblJmlhMhs As Label
    Friend WithEvents lblJmlhMatkul As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlNilai As Panel
    Friend WithEvents btnDeletenilai As Button
    Friend WithEvents btnEditnilai As Button
    Friend WithEvents btnAddnilai As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvStudentGrade As DataGridView
End Class
