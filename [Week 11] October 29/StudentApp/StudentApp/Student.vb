Imports StudentApp

Public Class Student
    Inherits SWICEnrollee
    Implements IPaysTuition

    Public Sub New(first As String, last As String)
        MyBase.New(first, last)
    End Sub
    Public Sub New(first As String, last As String, transfer As Integer)
        MyBase.New(first, last, transfer)
    End Sub

    Public Property TuitionRate As Decimal = 100 Implements IPaysTuition.TuitionRate

    Public Overrides ReadOnly Property Tuition As Decimal Implements IPaysTuition.Tuition
        Get
            Return CurrentCredits * TuitionRate
        End Get
    End Property
End Class
