Imports Newtonsoft.Json

Public Class GradeCreateModel
    Public Property Score As Decimal

    <JsonProperty("grade_component_id")>
    Public Property GradeComponentID As Integer
End Class
