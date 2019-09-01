Public Class Tetrahedron
    ' Variables
    Private _size As Double

    ' Constructors
    Public Sub New()
        Size = 1
    End Sub
    Public Sub New(p As Integer)
        Size = p
    End Sub

    ' Properties
    Public Property Size As Double
        Get
            Return _size
        End Get
        Set(value As Double)
            If value >= 0 Then
                _size = value
            Else
                Throw New Exception
            End If
        End Set
    End Property
    Public ReadOnly Property SurfaceArea As Double
        Get
            Return Math.Sqrt(3) * (Size ^ 2)
        End Get
    End Property
    Public ReadOnly Property Volume As Double
        Get
            Return (1 / 12) * Math.Sqrt(2) * (Size ^ 2)
        End Get
    End Property

    ' Method
    Public Sub Enlarge(v As Integer)
        If v > 0 Then
            ' Convert to percent and enlarge
            Size += (v / 100)
        Else
            Throw New Exception
        End If
    End Sub
End Class
