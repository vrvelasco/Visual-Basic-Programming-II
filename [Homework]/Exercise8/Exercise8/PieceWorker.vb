Public Class PieceWorker
    Inherits Employee

    Private wageValue As Decimal
    Private piecesValue As Integer

    Public Sub New(first As String, last As String, ssn As String, wage As Decimal, pieces As Integer)

        ' use MyBase reference to call constructor
        MyBase.New(first, last, ssn)

        Me.Wage = wage
        Me.Pieces = pieces
    End Sub ' New

    ' Properties
    Public Property Wage As Decimal
        Get
            Return wageValue
        End Get
        Set(value As Decimal)
            If value > 0 Then
                wageValue = value
            End If
        End Set
    End Property

    Public Property Pieces As Integer
        Get
            Return piecesValue
        End Get
        Set(value As Integer)
            If value >= 0 Then
                piecesValue = value
            End If
        End Set
    End Property
    Public Overrides Function CalculateEarnings() As Decimal
        Return Pieces * Wage
    End Function

    Public Overrides Function ToString() As String
        Return "PIECE WORK" & MyBase.ToString() & vbNewLine & String.Format("Wage: {0:C}{1}Pieces: {2}{3}Calculated Earnings: {4:C}", Wage, vbNewLine, Pieces.ToString(), vbNewLine, CalculateEarnings())
    End Function ' ToString

End Class
