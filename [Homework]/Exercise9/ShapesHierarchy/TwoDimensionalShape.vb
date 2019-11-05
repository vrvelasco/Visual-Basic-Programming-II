Public Class TwoDimensionalShape
    Inherits Shape

    Public Overrides Function GetArea() As Double
        Throw New NotImplementedException()
    End Function

    Public Overrides Function GetVolume() As Double
        Throw New NotImplementedException()
    End Function

    Public Overrides Function ToString() As String
        Return "Two Dimensional Shape: "
    End Function

End Class
