Public Class LoginForm
    Private model As LoginModel = New LoginModel()
    Private apiClient As ApiClient = New ApiClient()

    Private Sub SaveInput()
        model.Username = txtUsername.Text
        model.Password = txtPassword.Text
    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveInput()

        Try
            Dim response As ApiModel = Await apiClient.LoginAsync(Of ApiModel)("http://localhost:9090/login", model)

            MessageBox.Show("Login berhasil.", response.ToString)
            Me.Hide()

            Dim dashboard As New Dashboard(response.data.token, model.Username)
            dashboard.Show()

        Catch ex As Exception
            MessageBox.Show("Error: Please check your input")
        End Try



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class