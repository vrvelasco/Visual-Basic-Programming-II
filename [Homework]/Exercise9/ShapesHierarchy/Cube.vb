Public Class Cube
    Inherits ThreeDimensionalShape

    ' Constructor
    Public Sub New(s As Double)
        Side = s
    End Sub


    Public Overrides Function GetArea() As Double
        Return 6 * Side * Side
    End Function

    Public Overrides Function GetVolume() As Double
        Return Side * Side * Side
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{4}CUBE{0}{0}Side: {1:N}{0}Area: {2:N}{0}Volume: {3}", vbNewLine, Side, GetArea(), GetVolume(), MyBase.ToString())
    End Function

End Class
