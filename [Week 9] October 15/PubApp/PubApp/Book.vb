Public Class Book
    Inherits Publication

    Public Property Author As String
    Public Property Genre As String


    Sub New(t As String, y As Integer, a As String, g As String)
        MyBase.New(t, y) ' Calling the Base class constructor
        Author = a
        Genre = g
    End Sub

    Public Overrides Function GetInfo() As String
        Dim info As String
        info = MyBase.GetInfo()
        info &= $"Author: {Author}" & ControlChars.CrLf
        info &= $"Genre: {Genre}" & ControlChars.CrLf
        Return info
    End Function

End Class
