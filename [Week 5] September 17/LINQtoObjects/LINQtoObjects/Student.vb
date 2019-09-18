Public Class Student

    'instance variables, p. 316
    Private _lastName As String
    Private _currentCredits As Integer

    'constructors, p. 316

    Public Sub New()
        StudentFirstName = "Biff"
        StudentLastName = "Arfus"
        CurrentCredits = 0
        TotalCredits = 0
    End Sub
    Public Sub New(first As String, last As String)
        StudentFirstName = first
        StudentLastName = last
        CurrentCredits = 0
        TotalCredits = 0
    End Sub
    Public Sub New(first As String, last As String, transfer As Integer)
        StudentFirstName = first
        StudentLastName = last
        CurrentCredits = 0
        TotalCredits = transfer
    End Sub



    'properties, p. 317
    Public Property StudentLastName As String
        Get
            Return _lastName
        End Get
        Set(value As String)
            _lastName = value
        End Set
    End Property

    Public Property StudentFirstName As String

    Public ReadOnly Property StudentFullName As String
        Get
            Return StudentFirstName & " " & StudentLastName
        End Get
    End Property

    Public Property CurrentCredits As Integer
        Get
            Return _currentCredits
        End Get
        Private Set(value As Integer)
            If value <= 18 Then
                _currentCredits = value
                'Else
                '    Throw New Exception
            End If
        End Set
    End Property
    Public Property TotalCredits As Integer


    'methods, p. 317

    Public Sub AddCredits()
        CurrentCredits += 3
    End Sub
    Public Sub AddCredits(newCredits As Integer)
        CurrentCredits += newCredits
    End Sub

    Public Sub ResetCredits()
        TotalCredits += CurrentCredits
        CurrentCredits = 0
    End Sub


End Class
