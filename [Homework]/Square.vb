Public Class Square

Private _side As Double

' Constructor
Public New(s As Double)
Side = s
End New

Public Property Side As Double
Get
Return _side
End Get
Set (value as Double) ' Validate that the side is not negative
If value > 0 Then
_side = value
Else
Throw New ArgumentOutOfRangeException("Side value need to be greater than zero.")
End If
End Set
End Property

Public Function GetArea()
Return Side * Side
End Function

End Class
