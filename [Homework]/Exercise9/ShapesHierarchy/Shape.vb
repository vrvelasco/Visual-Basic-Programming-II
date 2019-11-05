Public MustInherit Class Shape

    Private _side As Double
    Private _radius As Double

    Public Property Side As Double
        Get
            Return _side
        End Get
        Set(value As Double) ' Validate that the side is not negative
            If value > 0 Then
                _side = value
            Else
                Throw New ArgumentOutOfRangeException("Side value need to be greater than zero.")
            End If
        End Set
    End Property

    Public Property Radius As Double
        Get
            Return _radius
        End Get
        Set(value As Double) ' Validate that the side is not negative
            If value > 0 Then
                _radius = value
            Else
                Throw New ArgumentOutOfRangeException("Radius value need to be greater than zero.")
            End If
        End Set
    End Property

    ' These methods must be implemented
    Public MustOverride Function GetArea() As Double
    Public MustOverride Function GetVolume() As Double


End Class
