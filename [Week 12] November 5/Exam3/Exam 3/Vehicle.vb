Public MustInherit Class Vehicle

    Private _miles As Double

    Public Sub New(m As Double)
        Miles = m ' Miles traveled
    End Sub

    Public MustOverride ReadOnly Property Name As String

    Public MustOverride ReadOnly Property Speed As Double

    Public Property Miles As Double
        Get
            Return _miles
        End Get
        Set(value As Double)
            If value > 0 Then
                _miles = value
            Else
                Throw New ArgumentOutOfRangeException("The value for miles must be greater than zero.")
            End If
        End Set
    End Property

    Public ReadOnly Property Hours As Double
        Get
            Return Miles / Speed
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return String.Format("{3}{0} - {1} miles takes {2:N} hours", Name, Miles, Hours, vbNewLine)
    End Function

End Class
