Imports Newtonsoft.Json

Public Class ScheduleModel

    Public Property Course As String

    Public Property Classroom As String

    <JsonProperty("start_at")>
    Public Property StartAt As String

    <JsonProperty("end_at")>
    Public Property EndAt As String

    <JsonProperty("date")>
    Public Property ScheduleDate As DateTime

End Class