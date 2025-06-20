Imports System.Net.Http

Imports System.Threading.Tasks

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class ApiClient

    Private ReadOnly client As HttpClient

    Public Sub New()

        client = New HttpClient()
        client.DefaultRequestHeaders.Add("Authorization", "9dc225d3-4668-4e4b-8e50-810bec5625e2")

    End Sub

    ' --- GET ---
    Public Async Function GetDataAsync(Of T)(url As String) As Task(Of T)
        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        response.EnsureSuccessStatusCode()

        Dim jsonString As String = Await response.Content.ReadAsStringAsync()

        Dim jsonObj As JObject = JObject.Parse(jsonString)
        Dim dataPart = jsonObj("data")

        Return JsonConvert.DeserializeObject(Of T)(dataPart.ToString())
    End Function
End Class