Public Class HourlyWorker
    Inherits Employee

    Private hoursValue As Decimal
    Private wageValue As Decimal

    Public Sub New(first As String, last As String, ssn As String, hours As Decimal, wage As Decimal)

        ' use MyBase reference to call constructor
        MyBase.New(first, last, ssn)

        Me.Hours = hours
        Me.Wage = wage
    End Sub ' New

    ' Properties
    Public Property Hours As Decimal
        Get
            Return hoursValue
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                hoursValue = value
            End If
        End Set
    End Property

    Public Property Wage As Decimal
        Get
            Return wageValue
        End Get
        Set(value As Decimal)
            If value > 0 Then
                wageValue = value
            End If
        End Set
    End Property

    Public Overrides Function CalculateEarnings() As Decimal
        Dim ot, reg, pay As Decimal

        If Hours > 40 Then
            ot = (Hours - 40) * (Wage * 1.5)
            reg = 40 * Wage

            pay = ot + reg
        Else
            pay = Hours * Wage
        End If

        Return pay
    End Function
    Public Overrides Function ToString() As String
        Return "HOURLY" & MyBase.ToString() & vbNewLine & String.Format("Wage: {0:C}{1}Hours: {2}{3}Calculated Earnings: {4:C}", Wage, vbNewLine, Hours.ToString(), vbNewLine, CalculateEarnings())
    End Function ' ToString

End Class
