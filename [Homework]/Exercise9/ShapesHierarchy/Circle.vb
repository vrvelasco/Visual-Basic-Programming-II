Public Class Circle
    Inherits TwoDimensionalShape

    ' Constructor
    Public Sub New(r As Double)
        Radius = r
    End Sub

    Public Overrides Function GetArea() As Double
        Return Math.PI * Radius * Radius
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{3}CIRCLE{0}{0}Radius: {1:N}{0}Area: {2:N}", vbNewLine, Radius, GetArea(), MyBase.ToString())
    End Function

End Class
