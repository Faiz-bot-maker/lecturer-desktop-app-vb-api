Imports Newtonsoft.Json

Public Class CourseModel

    Public Property Code As String

    Public Property Name As String

    Public Property SKS As Integer

    Public Property Semester As String

    <JsonProperty("total_meetings")>
    Public Property TotalMeetings As Integer

End Class