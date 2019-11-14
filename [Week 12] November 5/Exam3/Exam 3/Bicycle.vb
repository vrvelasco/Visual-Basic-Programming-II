Public Class Bicycle
    Inherits Vehicle

    Private _weight As Double

    Public Sub New(m As Double, w As Double)
        MyBase.New(m)  ' Miles traveled
        Weight = w     ' Cyclist weight
    End Sub
    Public Overrides ReadOnly Property Name As String
        Get
            Return "Bicycle"
        End Get
    End Property

    Public Overrides ReadOnly Property Speed As Double
        Get
            Return 2000 / Weight
        End Get
    End Property

    Public Property Weight As Double
        Get
            Return _weight
        End Get
        Set(value As Double)
            If value > 0 Then
                _weight = value
            Else
                Throw New ArgumentOutOfRangeException("The value for weight must be greater than zero.")
            End If
        End Set
    End Property

End Class