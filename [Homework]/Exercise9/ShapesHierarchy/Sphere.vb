Public Class Sphere
    Inherits ThreeDimensionalShape

    ' Constructor
    Public Sub New(r As Double)
        Radius = r
    End Sub

    Public Overrides Function GetArea() As Double
        Return 4 * Math.PI * Radius * Radius
    End Function

    Public Overrides Function GetVolume() As Double
        Return (4 / 3) * Math.PI * Radius * Radius * Radius
    End Function
    Public Overrides Function ToString() As String
        Return String.Format("{4}SPHERE{0}{0}Radius: {1:N}{0}Area: {2:N}{0}Volume: {3:N}", vbNewLine, Radius, GetArea(), GetVolume(), MyBase.ToString())
    End Function

End Class
