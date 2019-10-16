Public Class CheckingAccount
    Inherits Account

    ' Variable
    Private _fee As Decimal

    ' Constructor
    Public Sub New(b As Decimal, f As Decimal)
        MyBase.New(b)
        Fee = f
    End Sub

    ' Property
    Public Property Fee As Decimal
        Get
            Return _fee
        End Get
        Set(value As Decimal)
            If value >= 0 Then
                _fee = value
            End If
        End Set
    End Property

    ' Methods
    Public Overrides Sub Credit(c As Decimal)
        MyBase.Credit(c)
        Balance -= Fee ' Charge fee
    End Sub
    Public Overrides Sub Debit(d As Decimal)
        If Balance >= d Then
            Balance -= d
            Balance -= Fee
        Else
            Throw New Exception
        End If
    End Sub
End Class
