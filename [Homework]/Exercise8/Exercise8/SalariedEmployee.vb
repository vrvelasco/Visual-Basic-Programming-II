Public Class SalariedEmployee
    Inherits Employee

    Private weeklySalaryValue As Decimal

    ' six-argument constructor
    Public Sub New(first As String, last As String, ssn As String, weeklySalary As Decimal)

        ' use MyBase reference to call CommissionEmployee constructor
        MyBase.New(first, last, ssn)

        Me.WeeklySalary = weeklySalary
    End Sub ' New

    ' property WeeklySalary
    Public Property WeeklySalary() As Decimal
        Get
            Return weeklySalaryValue
        End Get

        Set(salary As Decimal)
            If salary >= 0D Then ' validate weekly salary
                weeklySalaryValue = salary ' valid
            Else
                Throw New ArgumentOutOfRangeException(
                   "Salary must be greater than or equal to 0")
            End If
        End Set
    End Property ' WeeklySalary

    Public Overrides Function CalculateEarnings() As Decimal
        Return WeeklySalary
    End Function

    ' return String representation of Employee object
    Public Overrides Function ToString() As String
        Return "SALARIED" &
           MyBase.ToString() & vbCrLf &
           "Weekly Salary: " & String.Format("{0:C}", WeeklySalary)
    End Function ' ToString

End Class