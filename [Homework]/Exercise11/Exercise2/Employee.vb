' Victor Velasco
Public Class Employee
    ' Variable
    Dim _monthlySalary As Integer
    ' Shared variable
    Private Shared _raisePercentage As Integer
    ' Constructors
    Public Sub New()

    End Sub
    Public Sub New(n As String, p As String, s As Integer)
        Name = n
        Phone = p
        MonthlySalary = s
    End Sub

    ' Properties
    Public Property Name As String
    Public Property Phone As String
    Public Property MonthlySalary As Integer
        Get
            Return _monthlySalary
        End Get
        Set(value As Integer)
            If value > 0 Then
                _monthlySalary = value
            Else
                Throw New Exception
            End If
        End Set
    End Property
    Public ReadOnly Property AnnualSalary As Integer
        Get
            Return MonthlySalary * 12
        End Get
    End Property

    Public Shared Property RaisePercentage As Integer
        Get
            Return _raisePercentage
        End Get
        Set(value As Integer)
            _raisePercentage = value
        End Set
    End Property

    ' Method
    Public Sub Raise()
        MonthlySalary *= 1 + (RaisePercentage / 100)
    End Sub
End Class