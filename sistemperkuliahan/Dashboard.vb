Imports System.Net.Http

Public Class Dashboard

    Private ReadOnly token As String

    Public Sub New(token As String)
        InitializeComponent()
        Me.token = token

        dgvMatakuliah.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvJadwal.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAbsensi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvStudentGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Public Async Sub RefreshData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API courses
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses"
            Dim courses As List(Of CourseModel) = Await apiClient.GetDataAsync(Of List(Of CourseModel))(Me.token, url)

            ' Tampilkan di DataGridView
            dgvMatakuliah.DataSource = courses

            ' Panggil API schedules
            url = "http://localhost:9090/api/v1/lecturer/schedules"
            Dim schedule As List(Of ScheduleModel) = Await apiClient.GetDataAsync(Of List(Of ScheduleModel))(Me.token, url)

            ' Tampilkan di DataGridView
            dgvJadwal.DataSource = schedule

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, Button1.Click
        pnlDashboard.Show()
    End Sub

    Private Async Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Inisialisasi API Client
        Dim apiClient As New ApiClient()

        ' Panggil API courses
        Dim url As String = "http://localhost:9090/logout"
        Await apiClient.PostDataAsync(Of Object)(Me.token, url, Nothing)

        Me.Hide()
        LoginForm.Show()
    End Sub


    Private Sub btnMatakuliah_Click(sender As Object, e As EventArgs) Handles btnMatakuliah.Click
        pnlMatakuliah.Show()
        pnlJadwal.Hide()
        pnlDashboard.Hide()
        pnlAbsen.Hide()
    End Sub

    Private Sub btnJadwal_Click(sender As Object, e As EventArgs) Handles btnJadwal.Click
        pnlJadwal.Show()
        pnlDashboard.Hide()
        pnlAbsen.Hide()
        pnlMatakuliah.Hide()
        pnlCourseMhs.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)
        pnlJadwal.Hide()
        pnlDashboard.Hide()
        pnlAbsen.Hide()
        pnlMatakuliah.Hide()
        pnlCourseMhs.Show()
    End Sub

    Private Sub btnCourseMhs_Click(sender As Object, e As EventArgs)
        pnlJadwal.Hide()
        pnlDashboard.Hide()
        pnlAbsen.Hide()
        pnlMatakuliah.Hide()
        pnlCourseMhs.Show()
    End Sub

    Private Async Sub dgvMatakuliah_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMatakuliah.CellContentClick

        Dim code As String = dgvMatakuliah.SelectedRows(0).Cells("Code").Value
        Label6.Text = code

        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & code & "/students"
            Dim students As List(Of StudentModel) = Await apiClient.GetDataAsync(Of List(Of StudentModel))(Me.token, url)

            ' Tampilkan di DataGridView
            dgvStudents.DataSource = students

            pnlMatakuliah.Hide()
            pnlCourseMhs.Show()

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Async Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim npm As String = dgvStudents.SelectedRows(0).Cells("Npm").Value

        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & Label6.Text & "/students/" & npm & "/grades"
            Dim grades As List(Of GradeModel) = Await apiClient.GetDataAsync(Of List(Of GradeModel))(Me.token, url)

            ' Tampilkan di DataGridView
            dgvStudentGrade.DataSource = grades

            pnlCourseMhs.Hide()
            pnlNilai.Show()

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClosePnlNilai_Click(sender As Object, e As EventArgs) Handles btnClosePnlNilai.Click
        pnlNilai.Hide()
        pnlCourseMhs.Show()
    End Sub

    Private Sub btnClosePnlCourseMhs_Click(sender As Object, e As EventArgs) Handles btnClosePnlCourseMhs.Click
        pnlCourseMhs.Hide()
        pnlMatakuliah.Show()
    End Sub

    Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim npm As String = dgvStudents.SelectedRows(0).Cells("Npm").Value

        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & Label6.Text & "/students/" & npm & "/attendances"
            Dim absensi As List(Of AttendanceModel) = Await apiClient.GetDataAsync(Of List(Of AttendanceModel))(Me.token, url)

            ' Tampilkan di DataGridView
            dgvAbsensi.DataSource = absensi

            pnlCourseMhs.Hide()
            PnlAbsen.Show()

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClosePnlAbsensi_Click(sender As Object, e As EventArgs) Handles btnClosePnlAbsensi.Click
        PnlAbsen.Hide()
        pnlCourseMhs.Show()
    End Sub
End Class
