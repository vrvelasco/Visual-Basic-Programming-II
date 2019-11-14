Public Class Carpool
    Inherits Auto

    Private _passengers As Integer

    Public Sub New(m As Double, vmpg As Double, p As Integer)
        MyBase.New(m, vmpg) ' Miles and MPG to super class
        Passengers = p      ' Number of passengers
    End Sub

    Public Overrides ReadOnly Property Name As String
        Get
            Return "Carpool"
        End Get
    End Property

    Public Property Passengers As Integer
        Get
            Return _passengers
        End Get
        Set(value As Integer)
            If value > 0 Then
                _passengers = value
            Else
                Throw New ArgumentOutOfRangeException("The value for Passengers must be greater than zero.")
            End If
        End Set
    End Property

    Public Overrides ReadOnly Property Cost As Double ' Cost is divided by number of passengers 
        Get
            Return MyBase.Cost / Passengers           ' Get the cost of the Auto class and divide by number of passengers
        End Get
    End Property

End Class
