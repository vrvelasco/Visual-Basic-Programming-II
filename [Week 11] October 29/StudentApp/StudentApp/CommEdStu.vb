Public Class CommEdStu
    Inherits SWICEnrollee

    Public Sub New(first As String, last As String)
        MyBase.New(first, last)
    End Sub

    Public Property SemestersAttended As Integer

    'Public Overrides ReadOnly Property Tuition As Decimal
    '    Get
    '        Throw New NotImplementedException()
    '    End Get
    'End Property
End Class
