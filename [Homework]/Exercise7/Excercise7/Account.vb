Public Class Account

    ' Variable
    Private _balance As Decimal

    ' Constructor
    Public Sub New(b As Decimal)
        Balance = b
    End Sub

    ' Property
    Public Property Balance As Decimal
        Get
            Return _balance
        End Get
        Set(value As Decimal)
            If value >= 0.0 Then
                _balance = value
            Else
                _balance = 0.0
                Throw New Exception
            End If
        End Set
    End Property

    ' Methods
    Public Overridable Sub Credit(c As Decimal)
        Balance += c
    End Sub
    Public Overridable Sub Debit(d As Decimal)
        If Balance >= d Then
            Balance -= d
        Else
            Throw New Exception
        End If
    End Sub
End Class
