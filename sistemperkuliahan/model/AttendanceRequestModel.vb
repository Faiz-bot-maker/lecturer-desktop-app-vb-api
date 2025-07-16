Imports Newtonsoft.Json

Public Class AttendanceRequestModel
    <JsonProperty("schedule_id")>
    Public Property ScheduleId As Integer
    Public Property Status As String
End Class