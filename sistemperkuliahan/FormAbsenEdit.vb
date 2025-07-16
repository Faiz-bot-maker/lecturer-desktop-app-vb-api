Public Class FormAbsenEdit

    Private dashboardRef As Dashboard

    Private ReadOnly courseCode As String
    Private ReadOnly npm As String
    Private ReadOnly token As String
    Private ReadOnly attendanceID As Integer

    Private attendance As AttendanceRequestModel = New AttendanceRequestModel()
    Private isEdit As Boolean = False
    Private apiClient As ApiClient = New ApiClient()

    Public Sub New(attendanceID As Integer, courseCode As String, npm As Integer, token As String, dashboard As Dashboard)
        InitializeComponent()
        Me.token = token
        Me.dashboardRef = dashboard ' Simpan referensi form Dashboard

        Me.courseCode = courseCode
        Me.npm = npm
        Me.attendanceID = attendanceID
    End Sub

    Private Sub SaveData()

        attendance.Status = cbStatus.SelectedItem.ToString()

    End Sub

    Private Async Sub btnSimpanEdit_Click(sender As Object, e As EventArgs) Handles btnSimpanEdit.Click

        SaveData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & Me.courseCode & "/students/" & Me.npm & "/attendances/" & attendanceID
            Await apiClient.PutDataAsync(Of GradeCreateModel)(Me.token, url, attendance)

            Me.Close()
            ' Refresh data di form Dashboard yang sudah ada
            Await dashboardRef.FetchAttendance(Me.npm, Me.courseCode)


        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Close()

    End Sub
End Class