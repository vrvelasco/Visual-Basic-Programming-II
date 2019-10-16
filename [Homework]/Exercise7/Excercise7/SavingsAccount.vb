Public Class SavingsAccount
    Inherits Account

    ' Variable
    Private _rate As Double

    ' Constructor
    Public Sub New(b As Decimal, r As Double)
        MyBase.New(b)
        Rate = r
    End Sub

    ' Property
    Public Property Rate As Double
        Get
            Return _rate
        End Get
        Set(value As Double)
            If value > 0 Then
                _rate = value
            Else
                _rate = 1
            End If
        End Set
    End Property

    ' Method
    Public Function CalculateInterest() As Double
        Return Balance * (Rate / 100)
    End Function
End Class
