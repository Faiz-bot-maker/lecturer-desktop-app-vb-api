Public Class FormAbsenAdd

    Private dashboardRef As Dashboard

    Private ReadOnly courseCode As String
    Private ReadOnly npm As String
    Private ReadOnly token As String

    Private attendance As AttendanceRequestModel = New AttendanceRequestModel()
    Private isEdit As Boolean = False
    Private apiClient As ApiClient = New ApiClient()

    Public Sub New(courseCode As String, npm As Integer, token As String, dashboard As Dashboard)
        InitializeComponent()
        Me.token = token
        Me.dashboardRef = dashboard ' Simpan referensi form Dashboard

        Me.courseCode = courseCode
        Me.npm = npm
    End Sub

    Public Async Sub RefreshData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API courses
            Dim url As String = $"http://localhost:9090/api/v1/lecturer/courses/{courseCode}/students/{npm}/attendances/available-schedules"
            Dim courses As List(Of ScheduleResponseModel) = Await apiClient.GetDataAsync(Of List(Of ScheduleResponseModel))(Me.token, url)

            ' Tampilkan di DataGridView
            cbSchedule.DataSource = courses
            cbSchedule.DisplayMember = "Datee" ' Properti yang ditampilkan di ComboBox
            cbSchedule.ValueMember = "ID"    ' Properti yang digunakan sebagai nilai

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SaveData()

        attendance.Status = cbStatus.SelectedItem.ToString()
        attendance.ScheduleId = CType(cbSchedule.SelectedItem, ScheduleResponseModel).Id

    End Sub

    Private Async Sub btnSimpanAdd_Click(sender As Object, e As EventArgs) Handles btnSimpanAdd.Click
        SaveData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & Me.courseCode & "/students/" & Me.npm & "/attendances"
            Await apiClient.PostDataAsync(Of GradeCreateModel)(Me.token, url, attendance)

            Me.Close()
            ' Refresh data di form Dashboard yang sudah ada
            Await dashboardRef.FetchAttendance(Me.npm, Me.courseCode)


        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()
    End Sub

    Private Async Sub FormAbsenAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class