' Victor Velasco
Public Class Employee
    ' Variables
    Dim _monthlySalary As Integer
    ' Constructor
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

    ' Method
    Public Sub Raise()
        MonthlySalary *= 1.1
    End Sub
End Class
