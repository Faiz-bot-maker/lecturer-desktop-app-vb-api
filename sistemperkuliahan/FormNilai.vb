
Imports System.Reflection.Emit

Public Class FormNilai

    Private dashboardRef As Dashboard

    Private ReadOnly courseCode As String
    Private ReadOnly npm As String
    Private ReadOnly token As String

    Private grade As GradeCreateModel = New GradeCreateModel()
    Private isEdit As Boolean = False
    Private apiClient As ApiClient = New ApiClient()

    Public Sub New(courseCode As String, npm As Integer, token As String, dashboard As Dashboard)
        InitializeComponent()
        Me.token = token
        Me.dashboardRef = dashboard ' Simpan referensi form Dashboard

        Me.courseCode = courseCode
        Me.npm = npm
    End Sub

    Private Sub FormNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Public Async Sub RefreshData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API courses
            Dim url As String = $"http://localhost:9090/api/v1/lecturer/courses/{courseCode}/students/{npm}/grades/available-grade-components"
            Dim courses As List(Of GradeComponent) = Await apiClient.GetDataAsync(Of List(Of GradeComponent))(Me.token, url)

            ' Tampilkan di DataGridView
            cbNilai.DataSource = courses
            cbNilai.DisplayMember = "Name" ' Properti yang ditampilkan di ComboBox
            cbNilai.ValueMember = "ID"    ' Properti yang digunakan sebagai nilai

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub SaveData()
        grade.Score = nudNilai.Value
        grade.GradeComponentID = cbNilai.SelectedValue
    End Sub

    Private Async Sub btnSimpannilai_Click(sender As Object, e As EventArgs) Handles btnSimpannilai.Click
        SaveData()
        MsgBox(grade.GradeComponentID)
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API students by course
            Dim url As String = "http://localhost:9090/api/v1/lecturer/courses/" & Me.courseCode & "/students/" & Me.npm & "/grades"
            Await apiClient.PostDataAsync(Of GradeCreateModel)(Me.token, url, grade)

            Me.Hide()
            ' Refresh data di form Dashboard yang sudah ada
            Await dashboardRef.FetchGrade(Me.npm, Me.courseCode)


        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class