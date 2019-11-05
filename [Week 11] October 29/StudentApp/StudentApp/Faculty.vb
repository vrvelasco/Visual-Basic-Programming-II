Imports StudentApp

Public Class Faculty
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
            Return CurrentCredits * TuitionRate * 0.75
        End Get
    End Property
End Class
