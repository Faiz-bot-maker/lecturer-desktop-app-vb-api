Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Public Async Sub RefreshData()
        Try
            ' Inisialisasi API Client
            Dim apiClient As New ApiClient()

            ' Panggil API
            Dim url As String = "http://localhost:9090/api/v1/lecturer/course"
            Dim courses As List(Of CourseModel) = Await apiClient.GetDataAsync(Of List(Of CourseModel))(url)

            ' Tampilkan di DataGridView
            dgvMatakuliah.DataSource = courses

        Catch ex As Exception
            MessageBox.Show("Error saat memuat data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, Button1.Click
        pnlDashboard.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub btnAbsen_Click(sender As Object, e As EventArgs) Handles btnAbsen.Click
        pnlAbsen.Show()
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
    End Sub
End Class
