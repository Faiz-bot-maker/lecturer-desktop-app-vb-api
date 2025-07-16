Imports Newtonsoft.Json

Public Class ScheduleResponseModel
    Public Property Id As Integer
    <JsonProperty("date")>
    Public Property Datee As DateTime ' Format tanggal dengan zona waktu
End Class