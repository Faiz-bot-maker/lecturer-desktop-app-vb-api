Public Class Dashboard
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click, Button1.Click
        pnlDashboard.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
