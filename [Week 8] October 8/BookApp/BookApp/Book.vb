Public Class Book
    Private _cost As Double

    ' Shared variable
    Private Shared _profitMargin As Double = 10

    Public Property Cost As Double
        Get
            Return _cost
        End Get
        Set(value As Double)
            If value > 0 Then
                _cost = value
            End If
        End Set
    End Property

    Public ReadOnly Property Price As Double
        Get
            Return Cost * (1 + (ProfitMargin / 100))
        End Get
    End Property

    Public Property Title As String
    Public Property Genre As String
    Public Property Quantity As Integer

    Public ReadOnly Property InventoryValue As Double
        Get
            Return Quantity * Price
        End Get
    End Property
    Public Shared Property ProfitMargin As Integer
        Get
            Return _profitMargin
        End Get
        Set(value As Integer)
            If value > 0 Then
                _profitMargin = value
            End If
        End Set
    End Property

    Public Sub New(t As String, g As String, q As Integer, c As Double)
        Title = t
        Genre = g
        Quantity = q
        Cost = c
    End Sub

End Class
