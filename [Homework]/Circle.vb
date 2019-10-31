Public Class Circle

  Private _radius As Double

' Constructor
  Public New(r As Double)
  Radius = r
End New

Public Property Radius As Double
Get
  Return _radius
End Get
Set (value as Double) ' Validate that the side is not negative
If value > 0 Then
    _radius = value
Else
    Throw New ArgumentOutOfRangeException("Radius value need to be greater than zero.")
End If
End Set
End Property

Public Function GetArea()
Return Math.PI * Radius * Radius
End Function

End Class
