﻿' Fig. 10.5: BasePlusCommissionEmployee.vb
' BasePlusCommissionEmployee inherits from class CommissionEmployee.
Public Class BasePlusCommissionEmployee
    Inherits CommissionEmployee

    Private baseSalaryValue As Decimal ' base salary per week

    ' six-argument constructor
    Public Sub New(first As String, last As String,
       ssn As String, sales As Decimal,
       rate As Double, salary As Decimal)

        ' use MyBase reference to call CommissionEmployee constructor
        MyBase.New(first, last, ssn, sales, rate)

        BaseSalary = salary ' validate and store base salary
    End Sub ' New

    ' property BaseSalary
    Public Property BaseSalary() As Decimal
        Get
            Return baseSalaryValue
        End Get

        Set(salary As Decimal)
            If salary >= 0D Then ' validate base salary
                baseSalaryValue = salary ' valid
            Else
                Throw New ArgumentOutOfRangeException(
                   "Base salary must be greater than or equal to 0")
            End If
        End Set
    End Property ' BaseSalary

    ' calculate earnings
    Public Overrides Function CalculateEarnings() As Decimal
        Return BaseSalary + MyBase.CalculateEarnings()
    End Function ' CalculateEarnings

    ' return String representation of BasePlusCommissionEmployee object
    Public Overrides Function ToString() As String
        Return "base-plus-" &
           "commission employee: " & FirstName & " " & LastName &
           vbCrLf & "social security number: " & SocialSecurityNumber &
           vbCrLf & "gross sales: " & String.Format("{0:C}", GrossSales) &
           vbCrLf & "commission rate: " &
           String.Format("{0:F}", CommissionRate) &
           vbCrLf &
           "base salary: " & String.Format("{0:C}", BaseSalary)
    End Function ' ToString
End Class ' BasePlusCommissionEmployee

' **************************************************************************
' * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
' * Pearson Education, Inc. All Rights Reserved.                           *
' *                                                                        *
' * DISCLAIMER: The authors and publisher of this book have used their     *
' * best efforts in preparing the book. These efforts include the          *
' * development, research, and testing of the theories and programs        *
' * to determine their effectiveness. The authors and publisher make       *
' * no warranty of any kind, expressed or implied, with regard to these    *
' * programs or to the documentation contained in these books. The authors *
' * and publisher shall not be liable in any event for incidental or       *
' * consequential damages in connection with, or arising out of, the       *
' * furnishing, performance, or use of these programs.                     *
' **************************************************************************