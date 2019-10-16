Public Class Publication
    Public Property Title As String
    Public Property Year As Integer
    Public Property Read As Boolean

    Public Sub New(t As String, y As Integer)
        Title = t
        Year = y
        Read = False
    End Sub

    Public Overridable Function GetInfo() As String
        Dim info As String
        info = $"Title: {Title}" & ControlChars.CrLf
        info &= $"Publication Year: {Year()}" & ControlChars.CrLf
        Return info
    End Function

End Class
