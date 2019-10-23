Public Class Magazine
    Inherits Publication

    Public Property Month As String
    Public Property Issue As Integer

    Public ReadOnly Property PubDate As String
        Get
            Return Month & ", " & Year
        End Get
    End Property

    Sub New(t As String, y As Integer, m As String, i As Integer)
        MyBase.New(t, y)
        Month = m
        Issue = i
        Read = False
    End Sub

    Public Overrides Function GetInfo()
        Dim info As String
        info = MyBase.GetInfo()
        info &= $"Publication Month: {Month}" & ControlChars.CrLf
        info &= $"Issue: {Issue}" & ControlChars.CrLf
        Return info
    End Function
End Class
