
' Kelas untuk deserialisasi respons API
Public Class ApiModel
    Public Property data As TokenData
End Class

Public Class TokenData
    Public Property token As String
    Public Property created_at As String
    Public Property updated_at As String
End Class

