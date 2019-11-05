Public Class Square
    Inherits TwoDimensionalShape

    ' Constructor
    Public Sub New(s As Double)
        Side = s
    End Sub

    Public Overrides Function GetArea() As Double
        Return Side * Side
    End Function

    Public Overrides Function ToString() As String
        Return String.Format("{3}SQUARE{0}{0}Side: {1:N}{0}Area: {2:N}", vbNewLine, Side, GetArea(), MyBase.ToString())
    End Function

End Class
