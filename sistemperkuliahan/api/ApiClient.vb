Imports System.Net.Http

Imports System.Threading.Tasks

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ApiClient

    Private ReadOnly client As HttpClient

    Public Sub New(Optional token As String = Nothing)

        client = New HttpClient()

    End Sub

    ' --- GET ---
    Public Async Function GetDataAsync(Of T)(token As String, url As String) As Task(Of T)
        client.DefaultRequestHeaders.Clear()
        client.DefaultRequestHeaders.Add("Authorization", token)

        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        response.EnsureSuccessStatusCode()

        Dim jsonString As String = Await response.Content.ReadAsStringAsync()

        Dim jsonObj As JObject = JObject.Parse(jsonString)
        Dim dataPart = jsonObj("data")

        Return JsonConvert.DeserializeObject(Of T)(dataPart.ToString())
    End Function

    ' --- POST ---
    Public Async Function PostDataAsync(Of T)(token As String, url As String, data As Object) As Task(Of T)
        client.DefaultRequestHeaders.Clear()
        client.DefaultRequestHeaders.Add("Authorization", token)

        Dim json = JsonConvert.SerializeObject(data)
        Dim content = New StringContent(json, Nothing, "application/json")

        Dim response = Await client.PostAsync(url, content)
        response.EnsureSuccessStatusCode()

        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of T)(responseJson)
    End Function

    ' --- PUT ---
    Public Async Function PutDataAsync(Of T)(token As String, url As String, data As Object) As Task(Of T)
        client.DefaultRequestHeaders.Clear()
        client.DefaultRequestHeaders.Add("Authorization", token)

        Dim json = JsonConvert.SerializeObject(data)
        Dim content = New StringContent(json, Nothing, "application/json")

        Dim response = Await client.PutAsync(url, content)
        response.EnsureSuccessStatusCode()

        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of T)(responseJson)
    End Function

    ' --- DELETE ---
    Public Async Function DeleteDataAsync(token As String, url As String) As Task(Of String)
        client.DefaultRequestHeaders.Clear()
        client.DefaultRequestHeaders.Add("Authorization", token)

        Dim response = Await client.DeleteAsync(url)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    Public Async Function LoginAsync(Of T)(url As String, data As Object) As Task(Of T)

        Dim json = JsonConvert.SerializeObject(data)
        Dim content = New StringContent(json, Nothing, "application/json")

        Dim response = Await client.PostAsync(url, content)
        response.EnsureSuccessStatusCode()

        Dim responseJson = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of T)(responseJson)
    End Function

End Class