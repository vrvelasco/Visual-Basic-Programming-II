Public Class Auto
    Inherits Vehicle

    Private _mpg As Double

    Public Sub New(m As Double, vmpg As Double)
        MyBase.New(m)  ' Miles traveled
        Mpg = vmpg     ' Vehicle’s miles per gallon
    End Sub

    Public Overrides ReadOnly Property Name As String
        Get
            Return "Auto"
        End Get
    End Property

    Public Overrides ReadOnly Property Speed As Double '  Assumes all automobiles travel at 65 MPH
        Get
            Return 65.0
        End Get
    End Property

    Public Property Mpg As Double
        Get
            Return _mpg
        End Get
        Set(value As Double)
            If value > 0 Then
                _mpg = value
            Else
                Throw New ArgumentOutOfRangeException("The value for MPG must be greater than zero.")
            End If
        End Set
    End Property

    Public Overridable ReadOnly Property Cost As Double ' Cost = Miles / Mpg * $3.00 
        Get                                 ' Assuming fuel costs $3.00 per gallon
            Return Miles / Mpg * 3.0
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & String.Format(" and costs {0:C}", Cost)
    End Function

End Class
