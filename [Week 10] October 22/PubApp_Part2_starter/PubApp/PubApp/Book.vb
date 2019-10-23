Public Class Book
    Inherits Publication

    Public Property Author As String
    Public Property Genre As String


    Sub New(t As String, y As Integer, a As String, g As String)
        MyBase.New(t, y)
        Author = a
        Genre = g
        Read = False
    End Sub

    Public Overrides Function GetInfo()
        Dim info As String
        info = MyBase.GetInfo()
        info &= $"Author: {Author}" & ControlChars.CrLf
        info &= $"Genre: {Genre}" & ControlChars.CrLf
        Return info
    End Function

End Class
