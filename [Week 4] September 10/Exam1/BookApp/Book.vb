' Victor Velasco
Public Class Book
    ' Variable
    Dim _cost As Double
    ' Constructor
    Public Sub New(t As String, q As Integer, c As Double)
        Title = t
        Quantity = q
        Cost = c
    End Sub
    ' Properties
    Public Property Title As String
    Public Property Quantity As Integer
    Public Property Cost As Double
        Get
            Return _cost
        End Get
        Set(value As Double)
            If value < 0 Then
                _cost = 0.0
            Else
                _cost = value
            End If
        End Set
    End Property
    Public ReadOnly Property Price As Double
        Get
            Return Cost * 1.1
        End Get
    End Property
    Public ReadOnly Property InventoryValue As Double
        Get
            Return Quantity * Price
        End Get
    End Property
End Class
